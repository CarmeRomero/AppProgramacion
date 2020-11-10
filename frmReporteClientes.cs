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
        CNN cnn = new CNN();
        public frmReporteClientes()
        {
            InitializeComponent();
        }

        private void frmReporteClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CINEDataSet.TABLA_COMPLETA' table. You can move, or remove it, as needed.
            this.TABLA_COMPLETATableAdapter.Fill(this.CINEDataSet.TABLA_COMPLETA);

            this.reportViewer1.RefreshReport();
            txtEdad1.Enabled = false;
            txtEdad2.Enabled = false;
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimirTodo_Click(object sender, EventArgs e)
        {
            string strSQL = "select Id_cliente, Apellido , Nombre,Edad," +
                            "Comprobante,Fecha_de_venta,temporada,Tipo_de_compra,Forma_de_pago,Precio,Sucursal " +
                            "from TABLA_COMPLETA " +
                            
                            "order by 1 ";
            TABLA_COMPLETABindingSource.DataSource = cnn.consultarTabla(strSQL);
            reportViewer1.RefreshReport();
        }

        private void btnImprimirFiltro_Click(object sender, EventArgs e)
        {
            string strSQL = "";
            if (chkEdades.Checked)
            {
                

                strSQL = "select Id_cliente, Apellido , Nombre,Edad," +
                                            "Comprobante,Fecha_de_venta,temporada,Tipo_de_compra,Forma_de_pago,Precio,Sucursal " +
                                            "from TABLA_COMPLETA " +
                                            "where Apellido like '" + txtApellido.Text + "%' AND " +
                                            "edad between " + txtEdad1.Text + " AND " + txtEdad2.Text +
                                            " order by 1 ";
            }
            else 
            {
                strSQL = "select Id_cliente, Apellido , Nombre,Edad, Tipo_de_compra," +
                                            "Comprobante,Fecha_de_venta,temporada,Tipo_de_compra,Forma_de_pago,Precio,Sucursal " +
                                            "from TABLA_COMPLETA " +
                                            "where Apellido like '" + txtApellido.Text + "%' ORDER BY 1";
            }
            


            TABLA_COMPLETABindingSource.DataSource = cnn.consultarTabla(strSQL);
            reportViewer1.RefreshReport();
        }

        private void chkEdades_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEdades.Checked == true)
            {
                txtEdad1.Enabled = true;
                txtEdad2.Enabled = true;
            }
            if (chkEdades.Checked == false)
            {
                txtEdad1.Enabled = false;
                txtEdad2.Enabled = false;
            }
        }
    }
}
