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
    public partial class frmReporteClientes : Form
    {
        public frmReporteClientes()
        {
            InitializeComponent();
        }

        private void frmReporteClientes_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
