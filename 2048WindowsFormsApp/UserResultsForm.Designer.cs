namespace _2048WindowsFormsApp
{
    partial class UserResultsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserResultsForm));
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bestUserDataGridView = new System.Windows.Forms.DataGridView();
            this.UserNameBest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserBestScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestUserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.UserScore});
            this.usersDataGridView.Location = new System.Drawing.Point(24, 200);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.RowHeadersWidth = 51;
            this.usersDataGridView.RowTemplate.Height = 24;
            this.usersDataGridView.Size = new System.Drawing.Size(408, 253);
            this.usersDataGridView.TabIndex = 0;
            this.usersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Имя пользователя";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.Width = 125;
            // 
            // UserScore
            // 
            this.UserScore.HeaderText = "Количество очков";
            this.UserScore.MinimumWidth = 6;
            this.UserScore.Name = "UserScore";
            this.UserScore.Width = 125;
            // 
            // bestUserDataGridView
            // 
            this.bestUserDataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.bestUserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bestUserDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserNameBest,
            this.UserBestScore});
            this.bestUserDataGridView.Location = new System.Drawing.Point(24, 12);
            this.bestUserDataGridView.Name = "bestUserDataGridView";
            this.bestUserDataGridView.RowHeadersWidth = 51;
            this.bestUserDataGridView.RowTemplate.Height = 24;
            this.bestUserDataGridView.Size = new System.Drawing.Size(408, 127);
            this.bestUserDataGridView.TabIndex = 1;
            this.bestUserDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // UserNameBest
            // 
            this.UserNameBest.HeaderText = "Имя лучшего игрока";
            this.UserNameBest.MinimumWidth = 6;
            this.UserNameBest.Name = "UserNameBest";
            this.UserNameBest.Width = 125;
            // 
            // UserBestScore
            // 
            this.UserBestScore.HeaderText = "Количество очков";
            this.UserBestScore.MinimumWidth = 6;
            this.UserBestScore.Name = "UserBestScore";
            this.UserBestScore.Width = 125;
            // 
            // UserResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(520, 554);
            this.Controls.Add(this.bestUserDataGridView);
            this.Controls.Add(this.usersDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.Load += new System.EventHandler(this.UserResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestUserDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserScore;
        private System.Windows.Forms.DataGridView bestUserDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameBest;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserBestScore;
    }
}