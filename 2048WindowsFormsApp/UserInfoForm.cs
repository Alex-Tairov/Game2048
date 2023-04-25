using System;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class UserInfoForm : Form
    {
        public  UserInfoForm()
        {
            InitializeComponent();
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (userNameTextBox.Text.Length==0)
            {
                okButton.Enabled = false;
            }
            else
            {
                okButton.Enabled = true;
            }
        }
    }
}
