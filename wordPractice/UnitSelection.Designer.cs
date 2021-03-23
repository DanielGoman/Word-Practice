namespace wordPractice
{
    partial class UnitSelection
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
            this.unitsGroup = new System.Windows.Forms.GroupBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(575, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(110, 35);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backPressed);
            // 
            // unitsGroup
            // 
            this.unitsGroup.Location = new System.Drawing.Point(199, 98);
            this.unitsGroup.Name = "unitsGroup";
            this.unitsGroup.Size = new System.Drawing.Size(300, 238);
            this.unitsGroup.TabIndex = 1;
            this.unitsGroup.TabStop = false;
            this.unitsGroup.Text = "Units";
            // 
            // typeLabel
            // 
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.typeLabel.Location = new System.Drawing.Point(289, 22);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(100, 25);
            this.typeLabel.TabIndex = 2;
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnitSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(695, 440);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.unitsGroup);
            this.Controls.Add(this.backButton);
            this.Name = "UnitSelection";
            this.Text = "UnitSelection";
            this.Load += new System.EventHandler(this.UnitSelection_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox unitsGroup;
        private System.Windows.Forms.Label typeLabel;
    }
}