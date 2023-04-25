using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class WinnerForm : Form
    {
        private Form1 form;
        public WinnerForm(Form1 form)
        {
            InitializeComponent();
            this.form=form;
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            form.Close();
        }
    }
}
