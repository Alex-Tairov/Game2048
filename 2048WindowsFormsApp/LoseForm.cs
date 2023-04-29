using _2048_Common;
using System;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    
    public partial class LoseForm : Form
    {
        private Form1 form;

        public UserName user;

        private Game game;

        public LoseForm(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            scrLabel.Text = form.user.score.ToString();

        }

        private void loseQuitButton_Click(object sender, EventArgs e)
        {
            var userResultsForm = new UserResultsForm(UserResults.GetResultsFromFile());
            userResultsForm.Show();
        }

        private void LoseForm_Load(object sender, EventArgs e)
        {

        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            var userInfoForm = new UserInfoForm();
            if (userInfoForm.ShowDialog(this) == DialogResult.OK)
            {
                var userName = userInfoForm.userNameTextBox.Text;//Записываем имя пользователя
                user = new UserName(userName);
                game = new Game(user);
            }
        }
    }
}
