namespace _2048WindowsFormsApp
{
    partial class SetSizeField
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
            this.setRowLabel = new System.Windows.Forms.Label();
            this.setColumnLabel = new System.Windows.Forms.Label();
            this.setRowTextBox = new System.Windows.Forms.TextBox();
            this.setColumnTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // setRowLabel
            // 
            this.setRowLabel.AutoSize = true;
            this.setRowLabel.Location = new System.Drawing.Point(66, 50);
            this.setRowLabel.Name = "setRowLabel";
            this.setRowLabel.Size = new System.Drawing.Size(90, 17);
            this.setRowLabel.TabIndex = 0;
            this.setRowLabel.Text = "Число строк";
            // 
            // setColumnLabel
            // 
            this.setColumnLabel.AutoSize = true;
            this.setColumnLabel.Location = new System.Drawing.Point(66, 122);
            this.setColumnLabel.Name = "setColumnLabel";
            this.setColumnLabel.Size = new System.Drawing.Size(114, 17);
            this.setColumnLabel.TabIndex = 1;
            this.setColumnLabel.Text = "Число столбцов";
            // 
            // setRowTextBox
            // 
            this.setRowTextBox.Location = new System.Drawing.Point(216, 50);
            this.setRowTextBox.Name = "setRowTextBox";
            this.setRowTextBox.Size = new System.Drawing.Size(100, 22);
            this.setRowTextBox.TabIndex = 2;
            // 
            // setColumnTextBox
            // 
            this.setColumnTextBox.Location = new System.Drawing.Point(216, 117);
            this.setColumnTextBox.Name = "setColumnTextBox";
            this.setColumnTextBox.Size = new System.Drawing.Size(100, 22);
            this.setColumnTextBox.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(134, 229);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // SetSizeField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.setColumnTextBox);
            this.Controls.Add(this.setRowTextBox);
            this.Controls.Add(this.setColumnLabel);
            this.Controls.Add(this.setRowLabel);
            this.Name = "SetSizeField";
            this.Text = "SetSizeField";
            //this.Load += new System.EventHandler(this.SetSizeField_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label setRowLabel;
        private System.Windows.Forms.Label setColumnLabel;
        private System.Windows.Forms.TextBox setRowTextBox;
        private System.Windows.Forms.TextBox setColumnTextBox;
        private System.Windows.Forms.Button okButton;
    }
}