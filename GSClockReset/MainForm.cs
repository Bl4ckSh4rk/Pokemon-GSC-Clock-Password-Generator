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
                MessageBox.Show(ex.Message);
                return;
            }

            ushort tid;
            try
            {
                tid = UInt16.Parse(tidBox.Text);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Trainer ID is not a number");
                return;
            }
            catch (OverflowException oe)
            {
                MessageBox.Show("Trainer ID is out of range (0 - 65535)");
                return;
            }

            uint money;
            try
            {
                money = UInt32.Parse(moneyBox.Text);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Money value is not a number");
                return;
            }

            if (Password.IsValidTID(UInt16.Parse(tidBox.Text)))
            { 
                pw.TID = tid;
            }
            else
            {
                MessageBox.Show("Trainer ID is out of range (0 - 65535)");
                return;
            }

            if (Password.IsValidMoneyAmount(UInt32.Parse(moneyBox.Text)))
            {
                pw.Money = money;
            }
            else
            {
                MessageBox.Show("Money value is out of range (0 - 999999)");
                return;
            }
            
            password.Text = pw.GetPasswordString();
        }
    }
}
