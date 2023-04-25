using _2048_Common;
using System;
using System.Windows.Forms;


namespace _2048WindowsFormsApp
{
    public partial class SetSizeField : Form
    {
        private Form1 form;
        public SetSizeField(Form1 form)
        {
            InitializeComponent();
            this.form = form;            
        }

       
        //Кнопка ОК
        private void okButton_Click(object sender, EventArgs e)
        {
            var setRow = Convert.ToInt32(setRowTextBox.Text);
            var setColumn =Convert.ToInt32(setColumnTextBox.Text);

            form.ClearMap();

            form.mapSizeX = setRow;
            form.mapSizeY = setColumn;
            form.InitMap();
            
            
            Close();
        }
    }
}
