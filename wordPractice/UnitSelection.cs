using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wordPractice
{
    public partial class UnitSelection : Form
    {
        public static readonly int ENGLISH_MODE = 1;
        public static readonly int HEBREW_MODE = 2;
        private const int hebrewUnits = 11;
        private const int englishUnits = 10;
        private const int baseLeftPadding = 50;
        private const int baseTopPadding = 50;
        public static int mode;
        private List<Button> buttons = new List<Button>();

        public UnitSelection(int _mode)
        {
            InitializeComponent();
            mode = _mode;

            int unitsCount;
            if (mode == HEBREW_MODE)
                unitsCount = hebrewUnits;
            else
                unitsCount = englishUnits;

            for (int i = 0; i < unitsCount; i++)
            {
                //Adding a new button to the group
                Button button = new Button();
                int left = baseLeftPadding * (i % 4 + 1);   //Calculating x location
                int top = baseTopPadding * (i / 4 + 1);     //Calculating y location

                button.Name = i.ToString();
                button.Size = new Size(50, 50);
                button.Location = new Point(left, top);
                button.Text = i.ToString();
                button.Click += unitSelection;    //Setting custom on click event
                buttons.Add(button);
                unitsGroup.Controls.Add(button);
            }

            if (mode == ENGLISH_MODE)
                typeLabel.Text = "English";
            else
                typeLabel.Text = "עברית";
        }

        private void UnitSelection_Load(object sender, EventArgs e)
        {

        }

        private void unitSelection(object sender, EventArgs e)
        {
            int unitNumber = int.Parse((sender as Button).Name);
            Unit unit = new Unit(unitNumber);
            unit.Owner = this;
            this.Hide();
            unit.ShowDialog();
        }

        private void backPressed(object sender, EventArgs e)
        {
            this.Owner.Show();      //Making the calling form visible
            this.Close();
        }

        private void typeLabel_Click(object sender, EventArgs e)
        {

        }


    }
}
