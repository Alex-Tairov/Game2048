using _2048_Common;
using System;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    
    public partial class LoseForm : Form
    {
       public UserName user;

        public LoseForm(Form1 form)
        {
            InitializeComponent();
            scrLabel.Text = form.user.score.ToString();
        }

        private void loseQuitButton_Click(object sender, EventArgs e)
        {
            var userResultsForm = new UserResultsForm(UserResults.GetResultsFromFile());
            userResultsForm.Show();
        }
                

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            var userInfoForm = new UserInfoForm();
            if (userInfoForm.ShowDialog(this) == DialogResult.OK)
            {
                var userName = userInfoForm.userNameTextBox.Text;//Записываем имя пользователя
                user = new UserName(userName);
            }
        }
    }
}
