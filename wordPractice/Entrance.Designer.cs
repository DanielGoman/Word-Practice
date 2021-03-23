namespace wordPractice
{
    partial class Entrance
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 111);
            this.button1.TabIndex = 0;
            this.button1.Text = "English";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.englishClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 111);
            this.button2.TabIndex = 1;
            this.button2.Text = "עברית";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.hebrewClick);
            // 
            // Entrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(650, 430);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Entrance";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Entrance_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

