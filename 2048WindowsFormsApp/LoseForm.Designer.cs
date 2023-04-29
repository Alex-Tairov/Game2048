namespace _2048WindowsFormsApp
{
    partial class LoseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoseForm));
            this.label1 = new System.Windows.Forms.Label();
            this.loseScoreLabel = new System.Windows.Forms.Label();
            this.ShowResultButton = new System.Windows.Forms.Button();
            this.scrLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(101, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Игра окончена.";
            // 
            // loseScoreLabel
            // 
            this.loseScoreLabel.AutoSize = true;
            this.loseScoreLabel.Location = new System.Drawing.Point(292, 106);
            this.loseScoreLabel.Name = "loseScoreLabel";
            this.loseScoreLabel.Size = new System.Drawing.Size(0, 17);
            this.loseScoreLabel.TabIndex = 1;
            // 
            // ShowResultButton
            // 
            this.ShowResultButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ShowResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowResultButton.Location = new System.Drawing.Point(88, 106);
            this.ShowResultButton.Name = "ShowResultButton";
            this.ShowResultButton.Size = new System.Drawing.Size(147, 70);
            this.ShowResultButton.TabIndex = 3;
            this.ShowResultButton.Text = "Показать результаты";
            this.ShowResultButton.UseVisualStyleBackColor = false;
            this.ShowResultButton.Click += new System.EventHandler(this.loseQuitButton_Click);
            // 
            // scrLabel
            // 
            this.scrLabel.AutoSize = true;
            this.scrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scrLabel.Location = new System.Drawing.Point(181, 52);
            this.scrLabel.Name = "scrLabel";
            this.scrLabel.Size = new System.Drawing.Size(17, 17);
            this.scrLabel.TabIndex = 4;
            this.scrLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(101, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ваш счет";
            // 
            // NewGameButton
            // 
            this.NewGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NewGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewGameButton.Location = new System.Drawing.Point(88, 215);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(147, 70);
            this.NewGameButton.TabIndex = 6;
            this.NewGameButton.Text = "Начать новую игру";
            this.NewGameButton.UseVisualStyleBackColor = false;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // LoseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(331, 307);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scrLabel);
            this.Controls.Add(this.ShowResultButton);
            this.Controls.Add(this.loseScoreLabel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoseForm";
           // this.Load += new System.EventHandler(this.LoseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loseScoreLabel;
        private System.Windows.Forms.Button ShowResultButton;
        private System.Windows.Forms.Label scrLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NewGameButton;
    }
}