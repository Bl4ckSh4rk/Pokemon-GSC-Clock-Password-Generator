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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.instructionsBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.specialCharactersBox = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.inputBox.SuspendLayout();
            this.regionBox.SuspendLayout();
            this.passwordBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.instructionsBox.SuspendLayout();
            this.specialCharactersBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 40);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "JAP Gold/Silver/Crystal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "- the menu does not exist in these games!";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 80);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EU/US Crystal + KOR Gold/Silver";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 52);
            this.label2.TabIndex = 0;
            this.label2.Text = "- hold ↓ + SELECT + B on the title screen\r\n- release ↓ + B but still hold SELECT\r" +
    "\n- hold ← + ↑\r\n- release SELECT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 40);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EU/US Gold/Silver";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "- hold ↓ + SELECT + B on the title screen";
            // 
            // instructionsBox
            // 
            this.instructionsBox.Controls.Add(this.groupBox1);
            this.instructionsBox.Controls.Add(this.groupBox3);
            this.instructionsBox.Controls.Add(this.groupBox2);
            this.instructionsBox.Location = new System.Drawing.Point(183, 6);
            this.instructionsBox.Name = "instructionsBox";
            this.instructionsBox.Size = new System.Drawing.Size(229, 195);
            this.instructionsBox.TabIndex = 11;
            this.instructionsBox.TabStop = false;
            this.instructionsBox.Text = "Instructions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "= {";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "= }";
            // 
            // specialCharactersBox
            // 
            this.specialCharactersBox.Controls.Add(this.pictureBox3);
            this.specialCharactersBox.Controls.Add(this.label6);
            this.specialCharactersBox.Controls.Add(this.pictureBox1);
            this.specialCharactersBox.Controls.Add(this.label5);
            this.specialCharactersBox.Controls.Add(this.pictureBox2);
            this.specialCharactersBox.Controls.Add(this.label4);
            this.specialCharactersBox.Location = new System.Drawing.Point(183, 207);
            this.specialCharactersBox.Name = "specialCharactersBox";
            this.specialCharactersBox.Size = new System.Drawing.Size(229, 43);
            this.specialCharactersBox.TabIndex = 15;
            this.specialCharactersBox.TabStop = false;
            this.specialCharactersBox.Text = "Special Characters";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GSClockReset.Properties.Resources.multiplication;
            this.pictureBox3.Location = new System.Drawing.Point(127, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 10);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "= ×  (Alt + 0215)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GSClockReset.Properties.Resources.pk;
            this.pictureBox1.Location = new System.Drawing.Point(11, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 18);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GSClockReset.Properties.Resources.mn;
            this.pictureBox2.Location = new System.Drawing.Point(69, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 18);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.instructionsBox.ResumeLayout(false);
            this.specialCharactersBox.ResumeLayout(false);
            this.specialCharactersBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox instructionsBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox specialCharactersBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

