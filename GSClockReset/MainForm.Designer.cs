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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InputBox = new System.Windows.Forms.GroupBox();
            this.RegionBox = new System.Windows.Forms.GroupBox();
            this.RegionKOR = new System.Windows.Forms.RadioButton();
            this.RegionEUUS = new System.Windows.Forms.RadioButton();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.TIDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.GroupBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.GeneratePassword = new System.Windows.Forms.Button();
            this.JPGSCInstructionsBox = new System.Windows.Forms.GroupBox();
            this.JPGSCLabel = new System.Windows.Forms.Label();
            this.EUUSCInstructionsBox = new System.Windows.Forms.GroupBox();
            this.EUUSCInstructionsLabel = new System.Windows.Forms.Label();
            this.EUUSGSInstructionsBox = new System.Windows.Forms.GroupBox();
            this.EUUSGSInstructionsLabel = new System.Windows.Forms.Label();
            this.InstructionsBox = new System.Windows.Forms.GroupBox();
            this.charLabel1 = new System.Windows.Forms.Label();
            this.charLabel2 = new System.Windows.Forms.Label();
            this.SpecialCharactersBox = new System.Windows.Forms.GroupBox();
            this.multiplicationTextBox = new System.Windows.Forms.TextBox();
            this.MNTextBox = new System.Windows.Forms.TextBox();
            this.PKTextBox = new System.Windows.Forms.TextBox();
            this.charLabel3 = new System.Windows.Forms.Label();
            this.TIDBox = new System.Windows.Forms.NumericUpDown();
            this.MoneyBox = new System.Windows.Forms.NumericUpDown();
            this.multiplicationPictureBox = new System.Windows.Forms.PictureBox();
            this.PKPictureBox = new System.Windows.Forms.PictureBox();
            this.MNPictureBox = new System.Windows.Forms.PictureBox();
            this.InputBox.SuspendLayout();
            this.RegionBox.SuspendLayout();
            this.PasswordBox.SuspendLayout();
            this.JPGSCInstructionsBox.SuspendLayout();
            this.EUUSCInstructionsBox.SuspendLayout();
            this.EUUSGSInstructionsBox.SuspendLayout();
            this.InstructionsBox.SuspendLayout();
            this.SpecialCharactersBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TIDBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplicationPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PKPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MNPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Controls.Add(this.MoneyBox);
            this.InputBox.Controls.Add(this.TIDBox);
            this.InputBox.Controls.Add(this.RegionBox);
            this.InputBox.Controls.Add(this.MoneyLabel);
            this.InputBox.Controls.Add(this.TIDLabel);
            this.InputBox.Controls.Add(this.NameLabel);
            this.InputBox.Controls.Add(this.NameBox);
            this.InputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.Location = new System.Drawing.Point(12, 6);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(150, 145);
            this.InputBox.TabIndex = 0;
            this.InputBox.TabStop = false;
            this.InputBox.Text = "Input";
            // 
            // RegionBox
            // 
            this.RegionBox.Controls.Add(this.RegionKOR);
            this.RegionBox.Controls.Add(this.RegionEUUS);
            this.RegionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegionBox.Location = new System.Drawing.Point(9, 95);
            this.RegionBox.Name = "RegionBox";
            this.RegionBox.Size = new System.Drawing.Size(132, 40);
            this.RegionBox.TabIndex = 3;
            this.RegionBox.TabStop = false;
            this.RegionBox.Text = "Region";
            // 
            // RegionKOR
            // 
            this.RegionKOR.AutoSize = true;
            this.RegionKOR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegionKOR.Location = new System.Drawing.Point(73, 16);
            this.RegionKOR.Name = "RegionKOR";
            this.RegionKOR.Size = new System.Drawing.Size(48, 17);
            this.RegionKOR.TabIndex = 1;
            this.RegionKOR.TabStop = true;
            this.RegionKOR.Text = "KOR";
            this.RegionKOR.UseVisualStyleBackColor = true;
            // 
            // RegionEUUS
            // 
            this.RegionEUUS.AutoSize = true;
            this.RegionEUUS.Checked = true;
            this.RegionEUUS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegionEUUS.Location = new System.Drawing.Point(7, 16);
            this.RegionEUUS.Name = "RegionEUUS";
            this.RegionEUUS.Size = new System.Drawing.Size(60, 17);
            this.RegionEUUS.TabIndex = 0;
            this.RegionEUUS.TabStop = true;
            this.RegionEUUS.Text = "EU/US";
            this.RegionEUUS.UseVisualStyleBackColor = true;
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyLabel.Location = new System.Drawing.Point(19, 73);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(39, 13);
            this.MoneyLabel.TabIndex = 5;
            this.MoneyLabel.Text = "Money";
            // 
            // TIDLabel
            // 
            this.TIDLabel.AutoSize = true;
            this.TIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIDLabel.Location = new System.Drawing.Point(4, 46);
            this.TIDLabel.Name = "TIDLabel";
            this.TIDLabel.Size = new System.Drawing.Size(54, 13);
            this.TIDLabel.TabIndex = 4;
            this.TIDLabel.Text = "Trainer ID";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(23, 19);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(64, 16);
            this.NameBox.MaxLength = 7;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(77, 20);
            this.NameBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Controls.Add(this.PasswordTextBox);
            this.PasswordBox.Controls.Add(this.GeneratePassword);
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(12, 157);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(150, 93);
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.TabStop = false;
            this.PasswordBox.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(52, 56);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.ReadOnly = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(46, 16);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GeneratePassword
            // 
            this.GeneratePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeneratePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratePassword.Location = new System.Drawing.Point(38, 19);
            this.GeneratePassword.Name = "GeneratePassword";
            this.GeneratePassword.Size = new System.Drawing.Size(75, 23);
            this.GeneratePassword.TabIndex = 0;
            this.GeneratePassword.Text = "Generate";
            this.GeneratePassword.UseVisualStyleBackColor = true;
            this.GeneratePassword.Click += new System.EventHandler(this.GeneratePassword_Click);
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
            // InstructionsBox
            // 
            this.InstructionsBox.Controls.Add(this.EUUSGSInstructionsBox);
            this.InstructionsBox.Controls.Add(this.JPGSCInstructionsBox);
            this.InstructionsBox.Controls.Add(this.EUUSCInstructionsBox);
            this.InstructionsBox.Location = new System.Drawing.Point(183, 6);
            this.InstructionsBox.Name = "InstructionsBox";
            this.InstructionsBox.Size = new System.Drawing.Size(229, 195);
            this.InstructionsBox.TabIndex = 11;
            this.InstructionsBox.TabStop = false;
            this.InstructionsBox.Text = "Instructions";
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
            // SpecialCharactersBox
            // 
            this.SpecialCharactersBox.Controls.Add(this.multiplicationTextBox);
            this.SpecialCharactersBox.Controls.Add(this.MNTextBox);
            this.SpecialCharactersBox.Controls.Add(this.PKTextBox);
            this.SpecialCharactersBox.Controls.Add(this.multiplicationPictureBox);
            this.SpecialCharactersBox.Controls.Add(this.charLabel3);
            this.SpecialCharactersBox.Controls.Add(this.PKPictureBox);
            this.SpecialCharactersBox.Controls.Add(this.charLabel2);
            this.SpecialCharactersBox.Controls.Add(this.MNPictureBox);
            this.SpecialCharactersBox.Controls.Add(this.charLabel1);
            this.SpecialCharactersBox.Location = new System.Drawing.Point(183, 207);
            this.SpecialCharactersBox.Name = "SpecialCharactersBox";
            this.SpecialCharactersBox.Size = new System.Drawing.Size(229, 43);
            this.SpecialCharactersBox.TabIndex = 15;
            this.SpecialCharactersBox.TabStop = false;
            this.SpecialCharactersBox.Text = "Special Characters";
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
            // charLabel3
            // 
            this.charLabel3.AutoSize = true;
            this.charLabel3.Location = new System.Drawing.Point(184, 19);
            this.charLabel3.Name = "charLabel3";
            this.charLabel3.Size = new System.Drawing.Size(16, 13);
            this.charLabel3.TabIndex = 15;
            this.charLabel3.Text = "= ";
            // 
            // TIDBox
            // 
            this.TIDBox.Location = new System.Drawing.Point(64, 43);
            this.TIDBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.TIDBox.Name = "TIDBox";
            this.TIDBox.Size = new System.Drawing.Size(77, 20);
            this.TIDBox.TabIndex = 6;
            // 
            // MoneyBox
            // 
            this.MoneyBox.Location = new System.Drawing.Point(64, 70);
            this.MoneyBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.MoneyBox.Name = "MoneyBox";
            this.MoneyBox.Size = new System.Drawing.Size(77, 20);
            this.MoneyBox.TabIndex = 7;
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
            this.Controls.Add(this.SpecialCharactersBox);
            this.Controls.Add(this.InstructionsBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.InputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Pokemon GSC Clock Password Generator";
            this.InputBox.ResumeLayout(false);
            this.InputBox.PerformLayout();
            this.RegionBox.ResumeLayout(false);
            this.RegionBox.PerformLayout();
            this.PasswordBox.ResumeLayout(false);
            this.PasswordBox.PerformLayout();
            this.JPGSCInstructionsBox.ResumeLayout(false);
            this.JPGSCInstructionsBox.PerformLayout();
            this.EUUSCInstructionsBox.ResumeLayout(false);
            this.EUUSCInstructionsBox.PerformLayout();
            this.EUUSGSInstructionsBox.ResumeLayout(false);
            this.EUUSGSInstructionsBox.PerformLayout();
            this.InstructionsBox.ResumeLayout(false);
            this.SpecialCharactersBox.ResumeLayout(false);
            this.SpecialCharactersBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TIDBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplicationPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PKPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MNPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox InputBox;
        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.Label TIDLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.GroupBox PasswordBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button GeneratePassword;
        private System.Windows.Forms.GroupBox RegionBox;
        private System.Windows.Forms.RadioButton RegionKOR;
        private System.Windows.Forms.RadioButton RegionEUUS;
        private System.Windows.Forms.GroupBox JPGSCInstructionsBox;
        private System.Windows.Forms.Label JPGSCLabel;
        private System.Windows.Forms.GroupBox EUUSCInstructionsBox;
        private System.Windows.Forms.Label EUUSCInstructionsLabel;
        private System.Windows.Forms.GroupBox EUUSGSInstructionsBox;
        private System.Windows.Forms.Label EUUSGSInstructionsLabel;
        private System.Windows.Forms.GroupBox InstructionsBox;
        private System.Windows.Forms.PictureBox PKPictureBox;
        private System.Windows.Forms.PictureBox MNPictureBox;
        private System.Windows.Forms.GroupBox SpecialCharactersBox;
        private System.Windows.Forms.PictureBox multiplicationPictureBox;
        private System.Windows.Forms.Label charLabel3;
        private System.Windows.Forms.Label charLabel2;
        private System.Windows.Forms.Label charLabel1;
        private System.Windows.Forms.TextBox multiplicationTextBox;
        private System.Windows.Forms.TextBox MNTextBox;
        private System.Windows.Forms.TextBox PKTextBox;
        private System.Windows.Forms.NumericUpDown MoneyBox;
        private System.Windows.Forms.NumericUpDown TIDBox;
    }
}

