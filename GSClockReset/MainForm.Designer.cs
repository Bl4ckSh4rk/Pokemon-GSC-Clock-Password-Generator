namespace GSClockReset
{
    partial class MainForm
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
            this.inputBox = new System.Windows.Forms.GroupBox();
            this.regionBox = new System.Windows.Forms.GroupBox();
            this.region_kor = new System.Windows.Forms.RadioButton();
            this.region_euus = new System.Windows.Forms.RadioButton();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.tidLabel = new System.Windows.Forms.Label();
            this.moneyBox = new System.Windows.Forms.TextBox();
            this.tidBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.GroupBox();
            this.password = new System.Windows.Forms.TextBox();
            this.generatePassword = new System.Windows.Forms.Button();
            this.JPGSCInstructionsBox = new System.Windows.Forms.GroupBox();
            this.JPGSCLabel = new System.Windows.Forms.Label();
            this.EUUSCInstructionsBox = new System.Windows.Forms.GroupBox();
            this.EUUSCInstructionsLabel = new System.Windows.Forms.Label();
            this.EUUSGSInstructionsBox = new System.Windows.Forms.GroupBox();
            this.EUUSGSInstructionsLabel = new System.Windows.Forms.Label();
            this.instructionsBox = new System.Windows.Forms.GroupBox();
            this.charLabel1 = new System.Windows.Forms.Label();
            this.charLabel2 = new System.Windows.Forms.Label();
            this.specialCharactersBox = new System.Windows.Forms.GroupBox();
            this.multiplicationTextBox = new System.Windows.Forms.TextBox();
            this.MNTextBox = new System.Windows.Forms.TextBox();
            this.PKTextBox = new System.Windows.Forms.TextBox();
            this.multiplicationPictureBox = new System.Windows.Forms.PictureBox();
            this.charLabel3 = new System.Windows.Forms.Label();
            this.PKPictureBox = new System.Windows.Forms.PictureBox();
            this.MNPictureBox = new System.Windows.Forms.PictureBox();
            this.inputBox.SuspendLayout();
            this.regionBox.SuspendLayout();
            this.passwordBox.SuspendLayout();
            this.JPGSCInstructionsBox.SuspendLayout();
            this.EUUSCInstructionsBox.SuspendLayout();
            this.EUUSGSInstructionsBox.SuspendLayout();
            this.instructionsBox.SuspendLayout();
            this.specialCharactersBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.multiplicationPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PKPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MNPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Controls.Add(this.regionBox);
            this.inputBox.Controls.Add(this.moneyLabel);
            this.inputBox.Controls.Add(this.tidLabel);
            this.inputBox.Controls.Add(this.moneyBox);
            this.inputBox.Controls.Add(this.tidBox);
            this.inputBox.Controls.Add(this.nameLabel);
            this.inputBox.Controls.Add(this.nameBox);
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(12, 6);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(150, 145);
            this.inputBox.TabIndex = 0;
            this.inputBox.TabStop = false;
            this.inputBox.Text = "Input";
            // 
            // regionBox
            // 
            this.regionBox.Controls.Add(this.region_kor);
            this.regionBox.Controls.Add(this.region_euus);
            this.regionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionBox.Location = new System.Drawing.Point(9, 95);
            this.regionBox.Name = "regionBox";
            this.regionBox.Size = new System.Drawing.Size(132, 40);
            this.regionBox.TabIndex = 3;
            this.regionBox.TabStop = false;
            this.regionBox.Text = "Region";
            // 
            // region_kor
            // 
            this.region_kor.AutoSize = true;
            this.region_kor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.region_kor.Location = new System.Drawing.Point(73, 16);
            this.region_kor.Name = "region_kor";
            this.region_kor.Size = new System.Drawing.Size(48, 17);
            this.region_kor.TabIndex = 1;
            this.region_kor.TabStop = true;
            this.region_kor.Text = "KOR";
            this.region_kor.UseVisualStyleBackColor = true;
            // 
            // region_euus
            // 
            this.region_euus.AutoSize = true;
            this.region_euus.Checked = true;
            this.region_euus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.region_euus.Location = new System.Drawing.Point(7, 16);
            this.region_euus.Name = "region_euus";
            this.region_euus.Size = new System.Drawing.Size(60, 17);
            this.region_euus.TabIndex = 0;
            this.region_euus.TabStop = true;
            this.region_euus.Text = "EU/US";
            this.region_euus.UseVisualStyleBackColor = true;
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.Location = new System.Drawing.Point(19, 73);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(39, 13);
            this.moneyLabel.TabIndex = 5;
            this.moneyLabel.Text = "Money";
            // 
            // tidLabel
            // 
            this.tidLabel.AutoSize = true;
            this.tidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tidLabel.Location = new System.Drawing.Point(4, 46);
            this.tidLabel.Name = "tidLabel";
            this.tidLabel.Size = new System.Drawing.Size(54, 13);
            this.tidLabel.TabIndex = 4;
            this.tidLabel.Text = "Trainer ID";
            // 
            // moneyBox
            // 
            this.moneyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyBox.Location = new System.Drawing.Point(64, 70);
            this.moneyBox.MaxLength = 6;
            this.moneyBox.Name = "moneyBox";
            this.moneyBox.Size = new System.Drawing.Size(77, 20);
            this.moneyBox.TabIndex = 2;
            // 
            // tidBox
            // 
            this.tidBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tidBox.Location = new System.Drawing.Point(64, 43);
            this.tidBox.MaxLength = 5;
            this.tidBox.Name = "tidBox";
            this.tidBox.Size = new System.Drawing.Size(77, 20);
            this.tidBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(23, 19);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(64, 16);
            this.nameBox.MaxLength = 7;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(77, 20);
            this.nameBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.Controls.Add(this.password);
            this.passwordBox.Controls.Add(this.generatePassword);
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(12, 157);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(150, 93);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.TabStop = false;
            this.passwordBox.Text = "Password";
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Cursor = System.Windows.Forms.Cursors.Default;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(52, 56);
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Size = new System.Drawing.Size(46, 16);
            this.password.TabIndex = 1;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // generatePassword
            // 
            this.generatePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatePassword.Location = new System.Drawing.Point(38, 19);
            this.generatePassword.Name = "generatePassword";
            this.generatePassword.Size = new System.Drawing.Size(75, 23);
            this.generatePassword.TabIndex = 0;
            this.generatePassword.Text = "Generate";
            this.generatePassword.UseVisualStyleBackColor = true;
            this.generatePassword.Click += new System.EventHandler(this.generatePassword_Click);
            // 
            // JPGSCInstructionsBox
            // 
            this.JPGSCInstructionsBox.Controls.Add(this.JPGSCLabel);
            this.JPGSCInstructionsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JPGSCInstructionsBox.Location = new System.Drawing.Point(6, 149);
            this.JPGSCInstructionsBox.Name = "JPGSCInstructionsBox";
            this.JPGSCInstructionsBox.Size = new System.Drawing.Size(217, 40);
            this.JPGSCInstructionsBox.TabIndex = 10;
            this.JPGSCInstructionsBox.TabStop = false;
            this.JPGSCInstructionsBox.Text = "JAP Gold/Silver/Crystal";
            // 
            // JPGSCLabel
            // 
            this.JPGSCLabel.AutoSize = true;
            this.JPGSCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JPGSCLabel.Location = new System.Drawing.Point(6, 16);
            this.JPGSCLabel.Name = "JPGSCLabel";
            this.JPGSCLabel.Size = new System.Drawing.Size(202, 13);
            this.JPGSCLabel.TabIndex = 0;
            this.JPGSCLabel.Text = "- the menu does not exist in these games!";
            // 
            // EUUSCInstructionsBox
            // 
            this.EUUSCInstructionsBox.Controls.Add(this.EUUSCInstructionsLabel);
            this.EUUSCInstructionsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EUUSCInstructionsBox.Location = new System.Drawing.Point(6, 63);
            this.EUUSCInstructionsBox.Name = "EUUSCInstructionsBox";
            this.EUUSCInstructionsBox.Size = new System.Drawing.Size(217, 80);
            this.EUUSCInstructionsBox.TabIndex = 9;
            this.EUUSCInstructionsBox.TabStop = false;
            this.EUUSCInstructionsBox.Text = "EU/US Crystal + KOR Gold/Silver";
            // 
            // EUUSCInstructionsLabel
            // 
            this.EUUSCInstructionsLabel.AutoSize = true;
            this.EUUSCInstructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EUUSCInstructionsLabel.Location = new System.Drawing.Point(6, 16);
            this.EUUSCInstructionsLabel.Name = "EUUSCInstructionsLabel";
            this.EUUSCInstructionsLabel.Size = new System.Drawing.Size(201, 52);
            this.EUUSCInstructionsLabel.TabIndex = 0;
            this.EUUSCInstructionsLabel.Text = "- hold ↓ + SELECT + B on the title screen\r\n- release ↓ + B but still hold SELECT\r" +
    "\n- hold ← + ↑\r\n- release SELECT";
            // 
            // EUUSGSInstructionsBox
            // 
            this.EUUSGSInstructionsBox.Controls.Add(this.EUUSGSInstructionsLabel);
            this.EUUSGSInstructionsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EUUSGSInstructionsBox.Location = new System.Drawing.Point(6, 17);
            this.EUUSGSInstructionsBox.Name = "EUUSGSInstructionsBox";
            this.EUUSGSInstructionsBox.Size = new System.Drawing.Size(217, 40);
            this.EUUSGSInstructionsBox.TabIndex = 8;
            this.EUUSGSInstructionsBox.TabStop = false;
            this.EUUSGSInstructionsBox.Text = "EU/US Gold/Silver";
            // 
            // EUUSGSInstructionsLabel
            // 
            this.EUUSGSInstructionsLabel.AutoSize = true;
            this.EUUSGSInstructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EUUSGSInstructionsLabel.Location = new System.Drawing.Point(6, 16);
            this.EUUSGSInstructionsLabel.Name = "EUUSGSInstructionsLabel";
            this.EUUSGSInstructionsLabel.Size = new System.Drawing.Size(201, 13);
            this.EUUSGSInstructionsLabel.TabIndex = 2;
            this.EUUSGSInstructionsLabel.Text = "- hold ↓ + SELECT + B on the title screen";
            // 
            // instructionsBox
            // 
            this.instructionsBox.Controls.Add(this.EUUSGSInstructionsBox);
            this.instructionsBox.Controls.Add(this.JPGSCInstructionsBox);
            this.instructionsBox.Controls.Add(this.EUUSCInstructionsBox);
            this.instructionsBox.Location = new System.Drawing.Point(183, 6);
            this.instructionsBox.Name = "instructionsBox";
            this.instructionsBox.Size = new System.Drawing.Size(229, 195);
            this.instructionsBox.TabIndex = 11;
            this.instructionsBox.TabStop = false;
            this.instructionsBox.Text = "Instructions";
            // 
            // charLabel1
            // 
            this.charLabel1.AutoSize = true;
            this.charLabel1.Location = new System.Drawing.Point(28, 19);
            this.charLabel1.Name = "charLabel1";
            this.charLabel1.Size = new System.Drawing.Size(16, 13);
            this.charLabel1.TabIndex = 13;
            this.charLabel1.Text = "= ";
            // 
            // charLabel2
            // 
            this.charLabel2.AutoSize = true;
            this.charLabel2.Location = new System.Drawing.Point(109, 19);
            this.charLabel2.Name = "charLabel2";
            this.charLabel2.Size = new System.Drawing.Size(16, 13);
            this.charLabel2.TabIndex = 14;
            this.charLabel2.Text = "= ";
            // 
            // specialCharactersBox
            // 
            this.specialCharactersBox.Controls.Add(this.multiplicationTextBox);
            this.specialCharactersBox.Controls.Add(this.MNTextBox);
            this.specialCharactersBox.Controls.Add(this.PKTextBox);
            this.specialCharactersBox.Controls.Add(this.multiplicationPictureBox);
            this.specialCharactersBox.Controls.Add(this.charLabel3);
            this.specialCharactersBox.Controls.Add(this.PKPictureBox);
            this.specialCharactersBox.Controls.Add(this.charLabel2);
            this.specialCharactersBox.Controls.Add(this.MNPictureBox);
            this.specialCharactersBox.Controls.Add(this.charLabel1);
            this.specialCharactersBox.Location = new System.Drawing.Point(183, 207);
            this.specialCharactersBox.Name = "specialCharactersBox";
            this.specialCharactersBox.Size = new System.Drawing.Size(229, 43);
            this.specialCharactersBox.TabIndex = 15;
            this.specialCharactersBox.TabStop = false;
            this.specialCharactersBox.Text = "Special Characters";
            // 
            // multiplicationTextBox
            // 
            this.multiplicationTextBox.Location = new System.Drawing.Point(197, 16);
            this.multiplicationTextBox.Name = "multiplicationTextBox";
            this.multiplicationTextBox.ReadOnly = true;
            this.multiplicationTextBox.Size = new System.Drawing.Size(20, 20);
            this.multiplicationTextBox.TabIndex = 19;
            this.multiplicationTextBox.Text = "×";
            this.multiplicationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MNTextBox
            // 
            this.MNTextBox.Location = new System.Drawing.Point(122, 16);
            this.MNTextBox.Name = "MNTextBox";
            this.MNTextBox.ReadOnly = true;
            this.MNTextBox.Size = new System.Drawing.Size(20, 20);
            this.MNTextBox.TabIndex = 18;
            this.MNTextBox.Text = "}";
            this.MNTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PKTextBox
            // 
            this.PKTextBox.Location = new System.Drawing.Point(41, 16);
            this.PKTextBox.Name = "PKTextBox";
            this.PKTextBox.ReadOnly = true;
            this.PKTextBox.Size = new System.Drawing.Size(20, 20);
            this.PKTextBox.TabIndex = 17;
            this.PKTextBox.Text = "{";
            this.PKTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // multiplicationPictureBox
            // 
            this.multiplicationPictureBox.Image = global::GSClockReset.Properties.Resources.multiplication;
            this.multiplicationPictureBox.Location = new System.Drawing.Point(173, 22);
            this.multiplicationPictureBox.Name = "multiplicationPictureBox";
            this.multiplicationPictureBox.Size = new System.Drawing.Size(10, 10);
            this.multiplicationPictureBox.TabIndex = 16;
            this.multiplicationPictureBox.TabStop = false;
            // 
            // charLabel3
            // 
            this.charLabel3.AutoSize = true;
            this.charLabel3.Location = new System.Drawing.Point(184, 19);
            this.charLabel3.Name = "charLabel3";
            this.charLabel3.Size = new System.Drawing.Size(16, 13);
            this.charLabel3.TabIndex = 15;
            this.charLabel3.Text = "= ";
            // 
            // PKPictureBox
            // 
            this.PKPictureBox.Image = global::GSClockReset.Properties.Resources.pk;
            this.PKPictureBox.Location = new System.Drawing.Point(11, 17);
            this.PKPictureBox.Name = "PKPictureBox";
            this.PKPictureBox.Size = new System.Drawing.Size(16, 18);
            this.PKPictureBox.TabIndex = 11;
            this.PKPictureBox.TabStop = false;
            // 
            // MNPictureBox
            // 
            this.MNPictureBox.Image = global::GSClockReset.Properties.Resources.mn;
            this.MNPictureBox.Location = new System.Drawing.Point(92, 17);
            this.MNPictureBox.Name = "MNPictureBox";
            this.MNPictureBox.Size = new System.Drawing.Size(16, 18);
            this.MNPictureBox.TabIndex = 12;
            this.MNPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 261);
            this.Controls.Add(this.specialCharactersBox);
            this.Controls.Add(this.instructionsBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.inputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Pokemon GSC Clock Password Generator";
            this.inputBox.ResumeLayout(false);
            this.inputBox.PerformLayout();
            this.regionBox.ResumeLayout(false);
            this.regionBox.PerformLayout();
            this.passwordBox.ResumeLayout(false);
            this.passwordBox.PerformLayout();
            this.JPGSCInstructionsBox.ResumeLayout(false);
            this.JPGSCInstructionsBox.PerformLayout();
            this.EUUSCInstructionsBox.ResumeLayout(false);
            this.EUUSCInstructionsBox.PerformLayout();
            this.EUUSGSInstructionsBox.ResumeLayout(false);
            this.EUUSGSInstructionsBox.PerformLayout();
            this.instructionsBox.ResumeLayout(false);
            this.specialCharactersBox.ResumeLayout(false);
            this.specialCharactersBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.multiplicationPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PKPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MNPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputBox;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label tidLabel;
        private System.Windows.Forms.TextBox moneyBox;
        private System.Windows.Forms.TextBox tidBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.GroupBox passwordBox;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button generatePassword;
        private System.Windows.Forms.GroupBox regionBox;
        private System.Windows.Forms.RadioButton region_kor;
        private System.Windows.Forms.RadioButton region_euus;
        private System.Windows.Forms.GroupBox JPGSCInstructionsBox;
        private System.Windows.Forms.Label JPGSCLabel;
        private System.Windows.Forms.GroupBox EUUSCInstructionsBox;
        private System.Windows.Forms.Label EUUSCInstructionsLabel;
        private System.Windows.Forms.GroupBox EUUSGSInstructionsBox;
        private System.Windows.Forms.Label EUUSGSInstructionsLabel;
        private System.Windows.Forms.GroupBox instructionsBox;
        private System.Windows.Forms.PictureBox PKPictureBox;
        private System.Windows.Forms.PictureBox MNPictureBox;
        private System.Windows.Forms.GroupBox specialCharactersBox;
        private System.Windows.Forms.PictureBox multiplicationPictureBox;
        private System.Windows.Forms.Label charLabel3;
        private System.Windows.Forms.Label charLabel2;
        private System.Windows.Forms.Label charLabel1;
        private System.Windows.Forms.TextBox multiplicationTextBox;
        private System.Windows.Forms.TextBox MNTextBox;
        private System.Windows.Forms.TextBox PKTextBox;
    }
}

