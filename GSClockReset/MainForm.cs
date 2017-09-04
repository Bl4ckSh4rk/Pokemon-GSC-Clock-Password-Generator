using System;
using System.Windows.Forms;

namespace GSClockReset
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Password pw = new Password();

        private void generatePassword_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "" || tidBox.Text == "" || moneyBox.Text == "")
                return;

            pw.Korean = region_kor.Checked;

            try
            {
                pw.Name = nameBox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid character in Trainer Name");
                return;
            }

            ushort tid;
            try
            {
                tid = UInt16.Parse(tidBox.Text);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Invalid Trainer ID");
                return;
            }

            uint money;
            try
            {
                money = UInt32.Parse(moneyBox.Text);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Invalid money value");
                return;
            }

            if (Password.IsValidTID(Int32.Parse(tidBox.Text)))
            { 
                pw.TID = tid;
            }
            else
            {
                MessageBox.Show("Invalid Trainer ID");
                return;
            }

            if (Password.IsValidMoneyAmount(Int32.Parse(moneyBox.Text)))
            {
                pw.Money = money;
            }
            else
            {
                MessageBox.Show("Invalid money value");
                return;
            }
            
            password.Text = pw.GetPasswordString();
        }
    }
}
