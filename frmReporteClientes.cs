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
            this.DataTable1TableAdapter.Fill(this.BDCINE.DataTable1);

            this.reportViewer1.RefreshReport();
            txtEdad1.Enabled = false;
            txtEdad2.Enabled = false;
            cboTemporada.Enabled = false;
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimirTodo_Click(object sender, EventArgs e)
        {
            string strSQL = "SELECT CLIENTES.Id_cliente, CLIENTES.apellido, CLIENTES.nombre , CLIENTES.Edad, " +
                            "COMPROBANTES.Id_comprobante, COMPROBANTES.fecha, TEMPORADAS.temporada, TIPOS_COMPRAS.tipo_compra, " +
                            "FORMAS_PAGOS.forma_pago, TICKETS.precio, SUCURSALES.sucursal " +
                            "FROM CLIENTES FULL JOIN " +
                            "COMPROBANTES ON CLIENTES.Id_cliente = COMPROBANTES.Id_cliente FULL JOIN " +
                            "FORMAS_PAGOS ON COMPROBANTES.id_formas_pago = FORMAS_PAGOS.id_formas_pago FULL JOIN " +
                            "SUCURSALES ON COMPROBANTES.id_sucursal = SUCURSALES.id_sucursal FULL JOIN " +
                            "TEMPORADAS ON COMPROBANTES.id_temporada = TEMPORADAS.id_temporada FULL JOIN " +
                            "TICKETS ON COMPROBANTES.Id_comprobante = TICKETS.Id_comprobante FULL JOIN " +
                            "TIPOS_COMPRAS ON COMPROBANTES.id_tipo_compra = TIPOS_COMPRAS.id_tipo_compra " +
                            "ORDER BY 1";
            DataTable1BindingSource.DataSource = cnn.consultarTabla(strSQL);
            reportViewer1.RefreshReport();
        }
        public bool validarEdad()
        {
            if (Convert.ToInt32(txtEdad1.Text) > Convert.ToInt32(txtEdad2.Text))
            {
                MessageBox.Show("La edad inicial debe ser menor a la final", "Edad",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                chkEdades.Checked = true;
                txtEdad1.Clear();
                txtEdad2.Clear();
                txtEdad1.Focus();
                return false;
            }
            return true;
        }

        private void btnImprimirFiltro_Click(object sender, EventArgs e)
        {
            string strSQL = "";
            string strBase = "SELECT CLIENTES.Id_cliente, CLIENTES.apellido, CLIENTES.nombre , CLIENTES.Edad, " +
                            "COMPROBANTES.Id_comprobante, COMPROBANTES.fecha, TEMPORADAS.temporada, TIPOS_COMPRAS.tipo_compra, " +
                            "FORMAS_PAGOS.forma_pago, TICKETS.precio, SUCURSALES.sucursal " +
                            "FROM CLIENTES FULL JOIN " +
                            "COMPROBANTES ON CLIENTES.Id_cliente = COMPROBANTES.Id_cliente FULL JOIN " +
                            "FORMAS_PAGOS ON COMPROBANTES.id_formas_pago = FORMAS_PAGOS.id_formas_pago FULL JOIN " +
                            "SUCURSALES ON COMPROBANTES.id_sucursal = SUCURSALES.id_sucursal FULL JOIN " +
                            "TEMPORADAS ON COMPROBANTES.id_temporada = TEMPORADAS.id_temporada FULL JOIN " +
                            "TICKETS ON COMPROBANTES.Id_comprobante = TICKETS.Id_comprobante FULL JOIN " +
                            "TIPOS_COMPRAS ON COMPROBANTES.id_tipo_compra = TIPOS_COMPRAS.id_tipo_compra ";
            if (chkEdades.Checked && validarEdad())
            {

                strSQL = strBase+
                            
                                            "where CLIENTES.apellido like '" + txtApellido.Text + "%' AND " +
                                            "CLIENTES.Edad between " + txtEdad1.Text + " AND " + txtEdad2.Text +
                                            " order by 1 ";
                if (chkTemporada.Checked)
                {
                    strSQL = strBase +
                            
                                            "where CLIENTES.apellido like '" + txtApellido.Text + "%' AND " +
                                            "CLIENTES.Edad between " + txtEdad1.Text + " AND " + txtEdad2.Text +
                                            " AND TEMPORADAS.id_temporada = " + (int)cboTemporada.SelectedValue +
                                            " order by 1 ";
                }
            }
            else 
            {
                strSQL = strBase +
                                            "where CLIENTES.apellido like '" + txtApellido.Text + "%' ORDER BY 1";
                if (chkTemporada.Checked)
                {
                    strSQL = strBase +
                                            "where CLIENTES.apellido like '" + txtApellido.Text + "%' " +
                                            "AND TEMPORADAS.id_temporada = " + (int)cboTemporada.SelectedValue
                                            +" ORDER BY 1";
                }
            }



            DataTable1BindingSource.DataSource = cnn.consultarTabla(strSQL);
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
        public void cargarCombos(ComboBox combo, string nombreTabla)
        {
            DataTable dt = new DataTable();
            dt = cnn.extraerTabla(nombreTabla);

            combo.DataSource = dt;

            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTemporada.Checked == true)
            {
                cboTemporada.Enabled = true;
                cargarCombos(cboTemporada, "TEMPORADAS");
            }
            if (chkTemporada.Checked == false)
            {
                cboTemporada.Enabled = false;
                cboTemporada.SelectedIndex=-1;
            }
        }

        private void txtEdad1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Ingrese una edad valida", "Edad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFechas_Click(object sender, EventArgs e)
        {
            if (dtpInicio.Value > dtpFin.Value)
            {
                MessageBox.Show("La fecha inicial debe ser menor a la final", "Fechas", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                dtpInicio.Focus();
            }
            else
            {
                string strSQL = "SELECT CLIENTES.Id_cliente, CLIENTES.apellido, CLIENTES.nombre , CLIENTES.Edad, " +
                            "COMPROBANTES.Id_comprobante, COMPROBANTES.fecha, TEMPORADAS.temporada, TIPOS_COMPRAS.tipo_compra, " +
                            "FORMAS_PAGOS.forma_pago, TICKETS.precio, SUCURSALES.sucursal " +
                            "FROM CLIENTES FULL JOIN " +
                            "COMPROBANTES ON CLIENTES.Id_cliente = COMPROBANTES.Id_cliente FULL JOIN " +
                            "FORMAS_PAGOS ON COMPROBANTES.id_formas_pago = FORMAS_PAGOS.id_formas_pago FULL JOIN " +
                            "SUCURSALES ON COMPROBANTES.id_sucursal = SUCURSALES.id_sucursal FULL JOIN " +
                            "TEMPORADAS ON COMPROBANTES.id_temporada = TEMPORADAS.id_temporada FULL JOIN " +
                            "TICKETS ON COMPROBANTES.Id_comprobante = TICKETS.Id_comprobante FULL JOIN " +
                            "TIPOS_COMPRAS ON COMPROBANTES.id_tipo_compra = TIPOS_COMPRAS.id_tipo_compra " +
                            "WHERE COMPROBANTES.fecha BETWEEN '" + dtpInicio.Value + "' AND '" + dtpFin.Value + "' ";
                DataTable1BindingSource.DataSource = cnn.consultarTabla(strSQL);
                reportViewer1.RefreshReport();
            }
        }
    }
}
