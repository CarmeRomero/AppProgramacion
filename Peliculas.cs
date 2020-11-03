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
    public partial class Peliculas : Form
    {
        CNN cnn = new CNN();
        List<Pelicula> lP = new List<Pelicula>();
       
        public Peliculas()
        {
            InitializeComponent();
            autoCompleteText("NACIONALIDADES", txtNacionalidad);
            autoCompleteText("peliculas", txtTitulo);

        }
        public void habilitarCampos(bool x)
        {
            txtTitulo.Enabled = x;
            txtNacionalidad.Enabled = x;
            btnCancelar.Enabled = x;
            btnGrabar.Enabled = x;
            cboClasificacion.Enabled = x;
            cboGenero.Enabled = x;
            cboIdiomas.Enabled = x;


            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnBorrar.Enabled = !x;
           

        }
        public void limpiar()
        {
            txtTitulo.Text = string.Empty;
            cboClasificacion.SelectedIndex = -1;
            cboGenero.SelectedIndex = -1;
            cboIdiomas.SelectedIndex = -1;
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
                Pelicula p = new Pelicula();
                if (!cnn.pDr.IsDBNull(1))
                    p.pTitulo = cnn.pDr.GetString(1);
                if (!cnn.pDr.IsDBNull(2))
                    p.pId_genero = cnn.pDr.GetInt32(2);
                if (!cnn.pDr.IsDBNull(3))
                    p.pId_nacionalidad = cnn.pDr.GetInt32(3);
                if (!cnn.pDr.IsDBNull(4))
                    p.pId_idioma = cnn.pDr.GetInt32(4);
                if (!cnn.pDr.IsDBNull(5))
                    p.pId_clasificacion = cnn.pDr.GetInt32(5);
                lP.Add(p);
            }
            cnn.pDr.Close();
            cnn.desconectar();
            cnn.leerTabla("NACIONALIDADES");
            
            while (cnn.pDr.Read())
            {
                for (int j = 0; j < lP.Count; j++)
                {
                    if (lP[j].pId_nacionalidad == cnn.pDr.GetInt32(0))
                        lP[j].pNacionalidad = cnn.pDr.GetString(1);
                }
            }
            cnn.pDr.Close();
            cnn.desconectar();
            
            lstPeliculas.Items.Clear();
            for (int i = 0; i < lP.Count; i++)
            {
                lstPeliculas.Items.Add(lP[i].ToString());
            }
        }
       
        private void Peliculas_Load(object sender, EventArgs e)
        {
            
            habilitarCampos(false);
            cargarCombos(cboClasificacion, "CLASIFICACIONES");
            cargarCombos(cboGenero, "GENEROS");
            cargarCombos(cboIdiomas, "IDIOMAS");
            cargarLista(lstPeliculas, "peliculas");

        }
        void autoCompleteText(string nombreTabla, TextBox txtbx)
        {
            txtbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtbx.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            cnn.leerTabla(nombreTabla);
            while (cnn.pDr.Read())
            {
                string descripcion = cnn.pDr.GetString(1);
                coll.Add(descripcion);
            }
            cnn.pDr.Close();
            cnn.desconectar();
            txtbx.AutoCompleteCustomSource = coll;
        }
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            habilitarCampos(true);
            limpiar();

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            habilitarCampos(true);

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            habilitarCampos(false);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            habilitarCampos(false);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCampos(lstPeliculas.SelectedIndex);
        }

        private void cargarCampos(int selectedIndex)
        {
            int k = lstPeliculas.SelectedIndex;
        }
    }
}
