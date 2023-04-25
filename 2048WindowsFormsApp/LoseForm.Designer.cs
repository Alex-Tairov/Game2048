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
            this.label1 = new System.Windows.Forms.Label();
            this.loseScoreLabel = new System.Windows.Forms.Label();
            this.loseQuitButton = new System.Windows.Forms.Button();
            this.scrLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
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
            // loseQuitButton
            // 
            this.loseQuitButton.Location = new System.Drawing.Point(163, 195);
            this.loseQuitButton.Name = "loseQuitButton";
            this.loseQuitButton.Size = new System.Drawing.Size(75, 23);
            this.loseQuitButton.TabIndex = 3;
            this.loseQuitButton.Text = "OK";
            this.loseQuitButton.UseVisualStyleBackColor = true;
            this.loseQuitButton.Click += new System.EventHandler(this.loseQuitButton_Click);
            // 
            // scrLabel
            // 
            this.scrLabel.AutoSize = true;
            this.scrLabel.Location = new System.Drawing.Point(222, 133);
            this.scrLabel.Name = "scrLabel";
            this.scrLabel.Size = new System.Drawing.Size(16, 17);
            this.scrLabel.TabIndex = 4;
            this.scrLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ваш счет";
            // 
            // LoseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scrLabel);
            this.Controls.Add(this.loseQuitButton);
            this.Controls.Add(this.loseScoreLabel);
            this.Controls.Add(this.label1);
            this.Name = "LoseForm";
            this.Text = "LoseForm";
            this.Load += new System.EventHandler(this.LoseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loseScoreLabel;
        private System.Windows.Forms.Button loseQuitButton;
        private System.Windows.Forms.Label scrLabel;
        private System.Windows.Forms.Label label2;
    }
}