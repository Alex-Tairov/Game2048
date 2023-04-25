using _2048_Common;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class UserResultsForm : Form
    {
        private List<UserResults> userResults;
        private int max = 0;
        private string bestUser = "";
        public UserResultsForm(List<UserResults> userResults)
        {
            InitializeComponent();
            this.userResults = userResults;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserResultsForm_Load(object sender, EventArgs e)
        {
            var results = UserResults.GetResultsFromFile();
            for (int i = 0; i < userResults.Count; i++)
            {
                var userResult = results[i];
                if (userResult.score > max)
                {
                    max = userResult.score;
                    bestUser = userResult.name;
                }
                usersDataGridView.Rows.Add(userResult.name, userResult.score);
                
                
            }
            bestUserDataGridView.Rows.Add(bestUser, max);
            
            
        }
    }
}
