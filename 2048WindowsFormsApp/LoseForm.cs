using System;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    
    public partial class LoseForm : Form
    {
        private Form1 form;
        

        public LoseForm(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            scrLabel.Text = form.user.score.ToString();

        }

        private void loseQuitButton_Click(object sender, EventArgs e)
        {
            form.Close();
        }

        private void LoseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
