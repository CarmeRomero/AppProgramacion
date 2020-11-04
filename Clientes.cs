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
    public partial class Clientes : Form
    {
        CNN cnn = new CNN();
        List<Cliente> lP = new List<Cliente>();
        enum accion
        {
            nuevo,
            editado
        }
        accion miAccion;

        public Clientes()
        {
            InitializeComponent();

        }


        public void habilitarCampos(bool x)
        {
            txtNombreCliente.Enabled = x;
            txtApellidoCliente.Enabled = x;
            dtpFechaNacCliente.Enabled = x;
            cboTipoDocCliente.Enabled = x;
            txtDNICliente.Enabled = x;
            rbtFemCliente.Enabled = x;
            rbtMasculinoCliente.Enabled = x;

            txtCalleCliente.Enabled = x;
            txtAlturaCliente.Enabled = x;
            cboBarrioCliente.Enabled = x;

            btnCancelar.Enabled = x;
            btnGrabar.Enabled = x;

            btnNuevoCliente.Enabled = !x;
            btnEditarCliente.Enabled = !x;
            btnBorrarCliente.Enabled = !x;


        }
        public void limpiar()
        {
            txtNombreCliente.Text = string.Empty;
            txtApellidoCliente.Text = string.Empty;
            txtDNICliente.Text = string.Empty;
            txtCalleCliente.Text = string.Empty;
            txtAlturaCliente.Text = string.Empty;

            cboTipoDocCliente.SelectedIndex = -1;
            cboBarrioCliente.SelectedIndex = -1;


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
        public void cargarLista(ListBox lst, string nombreTabla)
        {

            cnn.leerTabla(nombreTabla);
            while (cnn.pDr.Read())
            {
                Cliente cli = new Cliente();
                if (!cnn.pDr.IsDBNull(0))
                 cli.pId_cliente = cnn.pDr.GetInt32(0);
                if (!cnn.pDr.IsDBNull(1))
                    cli.pNombre = cnn.pDr.GetString(1);
                if (!cnn.pDr.IsDBNull(2))
                    cli.pApellido = cnn.pDr.GetString(2);
                if (!cnn.pDr.IsDBNull(3))
                    cli.pFecha_nac = cnn.pDr.GetDateTime(3);
                if (!cnn.pDr.IsDBNull(4))
                    cli.pId_tipo_doc = cnn.pDr.GetInt32(4);
                if (!cnn.pDr.IsDBNull(5))
                    cli.pNro_documento = cnn.pDr.GetInt32(5);
                if (!cnn.pDr.IsDBNull(6))
                    cli.pId_sexo = cnn.pDr.GetInt32(6);
                if (!cnn.pDr.IsDBNull(7))
                    cli.pCalle = cnn.pDr.GetString(7);
                if (!cnn.pDr.IsDBNull(8))
                    cli.pAltura = cnn.pDr.GetInt32(8);
                if (!cnn.pDr.IsDBNull(9))
                    cli.pD_barrio = cnn.pDr.GetInt32(9);


                lP.Add(cli);
            }

            cnn.pDr.Close();
            cnn.desconectar();

            //lstClientes.Items.Clear();
            for (int i = 0; i < lP.Count; i++)
            {
                lstClientes.Items.Add(lP[i].ToString());
            }


        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            habilitarCampos(false);
            cargarCombos(cboBarrioCliente, "BARRIOS");
            cargarCombos(cboTipoDocCliente, "TIPOS_DOCUMENTO");
            
            limpiar();
        }

        // VER SI SIRVE EL AUTOCOMPLETADO CON ALGUN CAMPO

        //void autoCompleteText(string nombreTabla, TextBox txtbx)
        //{
        //    txtbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //    txtbx.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //    AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

        //    cnn.leerTabla(nombreTabla);
        //    while (cnn.pDr.Read())
        //    {
        //        string descripcion = cnn.pDr.GetString(1);
        //        coll.Add(descripcion);
        //    }
        //    cnn.pDr.Close();
        //    cnn.desconectar();
        //    txtbx.AutoCompleteCustomSource = coll;
        //}





    }

}
