namespace wordPractice
{
    partial class Unit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backButton = new System.Windows.Forms.Button();
            this.previousB = new System.Windows.Forms.Button();
            this.nextB = new System.Windows.Forms.Button();
            this.answerB = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.hideB = new System.Windows.Forms.Button();
            this.wordCounter = new System.Windows.Forms.Label();
            this.wordLabel = new System.Windows.Forms.Label();
            this.answer1 = new System.Windows.Forms.Label();
            this.answer2 = new System.Windows.Forms.Label();
            this.answer3 = new System.Windows.Forms.Label();
            this.answer4 = new System.Windows.Forms.Label();
            this.answers = new System.Windows.Forms.Label();
            this.shuffleB = new System.Windows.Forms.Button();
            this.wordsContainer = new System.Windows.Forms.Panel();
            this.wordsLabel = new System.Windows.Forms.Label();
            this.wordsCountLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(655, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(110, 35);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backPressed);
            // 
            // previousB
            // 
            this.previousB.Location = new System.Drawing.Point(241, 366);
            this.previousB.Name = "previousB";
            this.previousB.Size = new System.Drawing.Size(110, 35);
            this.previousB.TabIndex = 1;
            this.previousB.Text = "Previous";
            this.previousB.UseVisualStyleBackColor = true;
            this.previousB.Click += new System.EventHandler(this.previousB_Click);
            // 
            // nextB
            // 
            this.nextB.Location = new System.Drawing.Point(603, 366);
            this.nextB.Name = "nextB";
            this.nextB.Size = new System.Drawing.Size(110, 35);
            this.nextB.TabIndex = 2;
            this.nextB.Text = "Next";
            this.nextB.UseVisualStyleBackColor = true;
            this.nextB.Click += new System.EventHandler(this.nextClicked);
            // 
            // answerB
            // 
            this.answerB.Location = new System.Drawing.Point(419, 366);
            this.answerB.Name = "answerB";
            this.answerB.Size = new System.Drawing.Size(110, 35);
            this.answerB.TabIndex = 3;
            this.answerB.Text = "Show answers";
            this.answerB.UseVisualStyleBackColor = true;
            this.answerB.Click += new System.EventHandler(this.answerClick);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(19, 20);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(0, 13);
            this.countLabel.TabIndex = 4;
            // 
            // hideB
            // 
            this.hideB.Location = new System.Drawing.Point(419, 445);
            this.hideB.Name = "hideB";
            this.hideB.Size = new System.Drawing.Size(110, 35);
            this.hideB.TabIndex = 5;
            this.hideB.Text = "Hide";
            this.hideB.UseVisualStyleBackColor = true;
            this.hideB.Click += new System.EventHandler(this.hideClicked);
            // 
            // wordCounter
            // 
            this.wordCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.wordCounter.Location = new System.Drawing.Point(438, 24);
            this.wordCounter.Name = "wordCounter";
            this.wordCounter.Size = new System.Drawing.Size(75, 25);
            this.wordCounter.TabIndex = 6;
            // 
            // wordLabel
            // 
            this.wordLabel.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.wordLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wordLabel.Location = new System.Drawing.Point(241, 64);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(475, 35);
            this.wordLabel.TabIndex = 7;
            this.wordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answer1
            // 
            this.answer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answer1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.answer1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answer1.Location = new System.Drawing.Point(241, 165);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(475, 35);
            this.answer1.TabIndex = 8;
            this.answer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answer1.Visible = false;
            // 
            // answer2
            // 
            this.answer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answer2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.answer2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answer2.Location = new System.Drawing.Point(241, 217);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(475, 35);
            this.answer2.TabIndex = 8;
            this.answer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answer2.Visible = false;
            // 
            // answer3
            // 
            this.answer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answer3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.answer3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answer3.Location = new System.Drawing.Point(241, 265);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(475, 35);
            this.answer3.TabIndex = 8;
            this.answer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answer3.Visible = false;
            // 
            // answer4
            // 
            this.answer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answer4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.answer4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.answer4.Location = new System.Drawing.Point(241, 315);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(475, 35);
            this.answer4.TabIndex = 8;
            this.answer4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answer4.Visible = false;
            // 
            // answers
            // 
            this.answers.AutoSize = true;
            this.answers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.answers.Location = new System.Drawing.Point(240, 119);
            this.answers.Name = "answers";
            this.answers.Size = new System.Drawing.Size(82, 19);
            this.answers.TabIndex = 9;
            this.answers.Text = "Answers:";
            this.answers.Visible = false;
            // 
            // shuffleB
            // 
            this.shuffleB.Location = new System.Drawing.Point(15, 445);
            this.shuffleB.Name = "shuffleB";
            this.shuffleB.Size = new System.Drawing.Size(110, 35);
            this.shuffleB.TabIndex = 11;
            this.shuffleB.Text = "Shuffle";
            this.shuffleB.UseVisualStyleBackColor = true;
            this.shuffleB.Click += new System.EventHandler(this.shuffleClicked);
            // 
            // wordsContainer
            // 
            this.wordsContainer.AutoScroll = true;
            this.wordsContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wordsContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.wordsContainer.Location = new System.Drawing.Point(16, 49);
            this.wordsContainer.Name = "wordsContainer";
            this.wordsContainer.Size = new System.Drawing.Size(202, 384);
            this.wordsContainer.TabIndex = 0;
            this.wordsContainer.MouseHover += new System.EventHandler(this.mouseHover);
            // 
            // wordsLabel
            // 
            this.wordsLabel.AutoSize = true;
            this.wordsLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.wordsLabel.Location = new System.Drawing.Point(12, 30);
            this.wordsLabel.Name = "wordsLabel";
            this.wordsLabel.Size = new System.Drawing.Size(57, 16);
            this.wordsLabel.TabIndex = 12;
            this.wordsLabel.Text = "Words:";
            // 
            // wordsCountLabel
            // 
            this.wordsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.wordsCountLabel.Location = new System.Drawing.Point(66, 24);
            this.wordsCountLabel.Name = "wordsCountLabel";
            this.wordsCountLabel.Size = new System.Drawing.Size(75, 25);
            this.wordsCountLabel.TabIndex = 13;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(655, 445);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(110, 35);
            this.resetButton.TabIndex = 14;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetClick);
            // 
            // Unit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(777, 492);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.wordsCountLabel);
            this.Controls.Add(this.wordsLabel);
            this.Controls.Add(this.wordsContainer);
            this.Controls.Add(this.shuffleB);
            this.Controls.Add(this.answers);
            this.Controls.Add(this.answer4);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.wordCounter);
            this.Controls.Add(this.hideB);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.answerB);
            this.Controls.Add(this.nextB);
            this.Controls.Add(this.previousB);
            this.Controls.Add(this.backButton);
            this.Name = "Unit";
            this.Text = "Unit";
            this.Load += new System.EventHandler(this.Unit_Load);
            this.Click += new System.EventHandler(this.onFormClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button previousB;
        private System.Windows.Forms.Button nextB;
        private System.Windows.Forms.Button answerB;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button hideB;
        private System.Windows.Forms.Label wordCounter;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Label answer1;
        private System.Windows.Forms.Label answer2;
        private System.Windows.Forms.Label answer3;
        private System.Windows.Forms.Label answer4;
        private System.Windows.Forms.Label answers;
        private System.Windows.Forms.Button shuffleB;
        private System.Windows.Forms.Panel wordsContainer;
        private System.Windows.Forms.Label wordsLabel;
        private System.Windows.Forms.Label wordsCountLabel;
        private System.Windows.Forms.Button resetButton;
    }
}