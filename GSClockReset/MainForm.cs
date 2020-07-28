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

        private void GeneratePassword_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "")
                return;

            try
            {
                PasswordTextBox.Text = Password.GetPassword(NameBox.Text, (int)TIDBox.Value, (int)MoneyBox.Value, RegionKOR.Checked).ToString("D5");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
