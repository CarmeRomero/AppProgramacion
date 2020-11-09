using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormProgramacion
{
    public partial class frmMessageBox : Form
    {
        string label;
        public frmMessageBox()
        {
            InitializeComponent();
        }

        public string pLabel 
        {
            set { this.lblTexto.Text = value; }
            get { return this.lblTexto.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
