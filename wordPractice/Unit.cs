using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace wordPractice
{
    public partial class Unit : Form
    {
        static int unitNum;
        static List<Word> words;
        List<Label> answerLabels;
        bool answersVisible;
        static int current_word_id;
        static SQLiteConnection db;
        int visibleWordsCounter;

        private const int HIDDEN = 1;
        private const int NOT_HIDDEN = 0;

        public Unit(int _unitNum)
        {
            InitializeComponent();
            unitNum = _unitNum;
            answersVisible = false;
            current_word_id = -1;
            visibleWordsCounter = 0;

            this.Text = "Unit " + unitNum.ToString();

            //Initializing the answer labels
            answerLabels = new List<Label>();
            answerLabels.Add(answer1);
            answerLabels.Add(answer2);
            answerLabels.Add(answer3);
            answerLabels.Add(answer4);

            words = new List<Word>();
            words = initWords();

            wordCounter.Text = "1/" + words.Count.ToString();
            wordsCountLabel.Text = "(" + visibleWordsCounter.ToString() + ")";

            this.MouseWheel += new MouseEventHandler(onScreenScroll);       //Adding the mouse scroll event handler

            nextClicked(null, null);
            answerB.Focus();
        }

        private void Unit_Load(object sender, EventArgs e)
        {

        }
    
        //Initializes the list of words for this unit from the database
        private List<Word> initWords()
        {
            List<Word> words = new List<Word>();
            int counter = 0;
            String mode;
            if(UnitSelection.mode == UnitSelection.HEBREW_MODE)
                mode = "Hebrew.db";
            else
                mode = "English.db";

            db = new SQLiteConnection("Data Source=" + mode + ";Version=3; FailIfMissing=True; Foreign Keys=True;");
            db.Open();

            String query = "select * from \"" + unitNum.ToString() + "\";";
            SQLiteCommand command = new SQLiteCommand(query, db);
            SQLiteDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                int id = reader.GetInt32(0);
                int position = counter;
                String word = reader.GetString(1);
                String answer1 = null, answer2 = null, answer3 = null, answer4 = null;
                try
                {
                    answer1 = reader.GetString(2);
                    answer2 = reader.GetString(3);
                    answer3 = reader.GetString(4);
                    answer4 = reader.GetString(5);
                }
                catch(Exception e){ }
                bool hidden = reader.GetBoolean(6);
                
                String[] answersArr = { answer1, answer2, answer3, answer4 };
                List<String> answers = new List<String>();
                for(int i = 0; i < 4; i++)
                {
                    if (answersArr[i] != null)
                        answers.Add(answersArr[i]);
                    else
                        break;
                }
                Word new_word = new Word(id, position, word, answers, hidden, wordsContainer, this);
                words.Add(new_word);

                counter++;
            }

            return words;
        }

        //Moving to the previous word
        private void previousB_Click(object sender, EventArgs e)
        {
            int initial_id = current_word_id;
            current_word_id--;
            if (current_word_id >= 0 && current_word_id < words.Count)
            {
                //Moving to the previous not hidden word
                while (words[current_word_id].hidden == true)
                {
                    current_word_id--;

                    if (!(current_word_id >= 0 && current_word_id < words.Count))
                    {
                        current_word_id = initial_id;
                        return;
                    }
                }
                setNewWord(initial_id);
            }
            else
                current_word_id++;
        }

        //Showing/hiding the answers
        private void answerClick(object sender, EventArgs e)
        {
            if(!answersVisible)
            {
                //Showing answers
                for (int i = 0; i < words[current_word_id].definitions.Count; i++)
                    answerLabels[i].Visible = true;

                answerB.Text = "Hide answers";
            }
            else
            {
                //Hiding answers
                for (int i = 0; i < answerLabels.Count; i++)
                    answerLabels[i].Visible = false;

                answerB.Text = "Show answers";
            }
            answersVisible = !answersVisible;
        }

        //Moving to the next word
        private void nextClicked(object sender, EventArgs e)
        {
            int initial_id = current_word_id;
            current_word_id++;
            if (current_word_id < words.Count)
            { 
                //Moving to the next not hidden word
                while(words[current_word_id].hidden == true)
                {
                    current_word_id++;

                    if (!(current_word_id < words.Count))
                    {
                        current_word_id = initial_id;
                        return;
                    }
                }
                setNewWord(initial_id);
            }
            else
                current_word_id--;
        }

        //Hides the current word from the list
        private void hideClicked(object sender, EventArgs e)
        {
            if(current_word_id >= 0)
            {
                if (!words[current_word_id].hidden)
                {
                    words[current_word_id].hidden = true;
                    words[current_word_id].checkBox.Checked = false;

                    //Updating db
                    String query = "update \"" + unitNum.ToString() + "\" set hidden = " + HIDDEN.ToString() + " where ID = " + words[current_word_id].id.ToString();
                    SQLiteCommand command = new SQLiteCommand(query, db);
                    command.ExecuteNonQuery();
                }
                nextClicked(sender, e);
            }
        }

        //Sets the new word, its answers, marks it in the list and unmraks the previous word
        private void setNewWord(int previous_id)
        {
            //Changing back the background color of the previously selected word
            if(previous_id >= 0 && previous_id < words.Count)
                words[previous_id].displayLabel.BackColor = SystemColors.GradientInactiveCaption;

            //Setting color for the new word
            words[current_word_id].displayLabel.BackColor = Color.LightGreen;

            //Scrolling to the new word
            wordsContainer.ScrollControlIntoView(words[current_word_id].displayLabel);

            Word current_word = words[current_word_id];
            wordLabel.Text = current_word.word;
            for (int i = 0; i < current_word.definitions.Count; i++)
                answerLabels[i].Text = current_word.definitions[i];

            //Making all the answers invisible
            answers.Visible = false;
            answer1.Visible = false;
            answer2.Visible = false;
            answer3.Visible = false;
            answer4.Visible = false;

            //Updates the current location in the list of words
            wordCounter.Text = (current_word_id + 1).ToString() + "/" + words.Count.ToString(); 

            //Reseting the answer reveal
            answerB.Text = "Show answers";
            answersVisible = false;
        }

        //Shuffling the words
        private void shuffleClicked(object sender, EventArgs e)
        {
            Random rand = Entrance.rand;
            List<int> positions = new List<int>();
            for(int i = 0; i < words.Count; i++)
            {
                int selected_position;
                do{
                    selected_position = rand.Next(0, words.Count);
                }while(positions.Contains(selected_position));
                positions.Add(selected_position);
            }

            //Setting the new words
            wordsContainer.Controls.Clear();
            List<Word> new_words = new List<Word>();
            for(int i = 0; i < words.Count; i++)
            {
                Word current_word = words[positions[i]];
                Word new_word = new Word(current_word.id, i, current_word.word, current_word.definitions, current_word.hidden, wordsContainer, this);
                new_words.Add(new_word);
                current_word.checkBox.Dispose();
                current_word.displayLabel.Dispose();
            }
            words = new_words;

            //Reseting the layout
            current_word_id = -1;
            nextClicked(sender, e);
        }

        //Focusing the container so it will be scollable while the mouse is hovering over it
        private void mouseHover(object sender, EventArgs e)
        {
            wordsContainer.Focus();
        }
        
        //Called when back is pressed - closing this form and showing the parent form
        private void backPressed(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        //Makes all the words not hidden
        private void resetClick(object sender, EventArgs e)
        {
            words[current_word_id].displayLabel.BackColor = SystemColors.GradientInactiveCaption;
            for(int i = 0; i < words.Count; i++)
            {
                if(words[i].hidden)
                    words[i].checkBox.Checked = true;
            }
            current_word_id = -1;
            nextClicked(sender, e);
        }

        private void onScreenScroll(object sender, MouseEventArgs e)
        {
            if(e.Delta > 0)     //Scrolled up -> previous
                previousB_Click(sender, e);
            else if (e.Delta < 0)
                nextClicked(sender, e);
        }

        private void onFormClick(object sender, EventArgs e)
        {
            MouseEventArgs args = (MouseEventArgs)e;
            if (args.Button == MouseButtons.Left)
            {
                answerClick(sender, e);
                answerB.Focus();
            }
            else if (args.Button == MouseButtons.Right)
            {
                hideClicked(sender, e);
                hideB.Focus();
            }
        }

        //Called when the form is on the verge of closing
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            db.Close();
            base.OnFormClosing(e);
        }

        //A representation of a single word
        public class Word
        {
            public int id;
            public int position;
            public String word;
            public List<String> definitions;
            public bool hidden;
            public CheckBox checkBox;
            public Label displayLabel;
            public Unit unit;

            public Word(int id, int position, String word, List<String> definitions, bool hidden, Panel container, Unit unit)
            {
                this.id = id;
                this.position = position;
                this.word = word;
                this.definitions = definitions;
                this.hidden = hidden;
                this.unit = unit;

                if (!hidden)
                    unit.visibleWordsCounter++;

                checkBox = new CheckBox();
                checkBox.Text = "";
                checkBox.Location = new Point(30, 20 * id);
                checkBox.AutoSize = true;
                checkBox.Checked = !hidden;
                checkBox.CheckedChanged += (sender, EventArgs) => { checkChanged(sender, EventArgs, position); };

                displayLabel = new Label();
                displayLabel.AutoSize = true;
                displayLabel.Location = new Point(50, 20 * id);
                displayLabel.Text = word;
                displayLabel.Font = new Font("Arial", displayLabel.Font.Size, FontStyle.Bold);
                displayLabel.Click += (sender, EventArgs) => { labelClicked(sender, EventArgs, position); };

                container.Controls.Add(checkBox);
                container.Controls.Add(displayLabel);

            }

            //Called when the label of the word is clicked
            private void labelClicked(object sender, EventArgs e, int position)
            {
                int previous_id = current_word_id;
                current_word_id = position;
                unit.setNewWord(previous_id);
            }

            //Called when the checkbox of the word is checked/unchecked
            private void checkChanged(object sender, EventArgs e, int position)
            {
                words[position].hidden = !words[position].checkBox.Checked;

                int mode;
                if (words[position].hidden)
                {
                    mode = HIDDEN;
                    unit.visibleWordsCounter--;
                }
                else
                {
                    mode = NOT_HIDDEN;
                    unit.visibleWordsCounter++;
                }

                //Updating db
                String query = "update \"" + unitNum.ToString() + "\" set hidden = " + mode.ToString() + " where ID = " + words[position].id.ToString();
                SQLiteCommand command = new SQLiteCommand(query, db);
                command.ExecuteNonQuery();

                unit.wordsCountLabel.Text = "(" + unit.visibleWordsCounter.ToString() + ")";
            }
        }
    }
}
