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
        enum accion
        {
            nuevo,
            editado
        }
        accion miAccion;
       
        public Peliculas()
        {
            InitializeComponent();
            autoCompleteText("NACIONALIDADES", txtNacionalidad);
            autoCompleteText("peliculas", txtTitulo);
            miAccion = accion.editado;

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
            lstPeliculas.Enabled =! x;
        }
        public void limpiar()
        {
            txtTitulo.Text = string.Empty;
            txtNacionalidad.Text = string.Empty;
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
                if (!cnn.pDr.IsDBNull(0))
                    p.pId_pelicula = cnn.pDr.GetInt32(0);
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
            limpiar();

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
            miAccion = accion.nuevo;
            habilitarCampos(true);
            limpiar();
            txtTitulo.Focus();

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (lstPeliculas.SelectedIndex >= 0 || !string.IsNullOrEmpty(txtTitulo.Text))
            {
                miAccion = accion.editado;
                habilitarCampos(true);
                txtTitulo.Focus();
            }
            else
                MessageBox.Show("Debe seleccionar una pelicula de la lista", "Seleccionar");
            

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            habilitarCampos(false);
            cargarCampos(1);
            txtTitulo.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Pelicula p = new Pelicula();
                p.pTitulo = txtTitulo.Text;
                p.pId_genero = (int)cboGenero.SelectedValue;
                p.pNacionalidad = txtNacionalidad.Text;
                cnn.leerTabla("NACIONALIDADES");

                while (cnn.pDr.Read())
                {
                    if (p.pNacionalidad == cnn.pDr.GetString(1))
                        p.pId_nacionalidad = cnn.pDr.GetInt32(0);
                }
                cnn.pDr.Close();
                cnn.desconectar();
                p.pId_idioma = (int)cboIdiomas.SelectedValue;
                p.pId_clasificacion = (int)cboClasificacion.SelectedValue;
                if(miAccion == accion.nuevo)
                {
                    p.nuevo(p);
                    habilitarCampos(false);
                }
                else
                {
                    if (lstPeliculas.SelectedIndex >= 0)
                    {
                        int k = lstPeliculas.SelectedIndex;
                        lP[k].pTitulo = txtTitulo.Text;
                        lP[k].pId_genero = (int)cboGenero.SelectedValue;
                        lP[k].pNacionalidad = txtNacionalidad.Text;
                        cnn.leerTabla("NACIONALIDADES");

                        while (cnn.pDr.Read())
                        {
                            if (lP[k].pNacionalidad == cnn.pDr.GetString(1))
                                lP[k].pId_nacionalidad = cnn.pDr.GetInt32(0);
                        }
                        cnn.pDr.Close();
                        cnn.desconectar();
                        lP[k].pId_idioma = (int)cboClasificacion.SelectedValue;
                        lP[k].pId_clasificacion = (int)cboClasificacion.SelectedValue;


                        lP[k].editar(lP[k]);
                        habilitarCampos(false);

                    }
                    else
                        MessageBox.Show("Seleccione un item a editar", "Item");
                }
                lP.Clear();
                cargarLista(lstPeliculas, "PELICULAS");
            }
        }

        private bool validarCampos()
        {
            if (miAccion == accion.nuevo)
            {
                if (string.IsNullOrEmpty(txtTitulo.Text))
                {
                    MessageBox.Show("Debe ingresar un titulo", "Completar");
                    txtTitulo.Focus();
                    return false;
                }
                if (cboGenero.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe ingresar un genero", "Completar");
                    cboGenero.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtNacionalidad.Text))
                {
                    MessageBox.Show("Debe ingresar una nacionalidad", "Completar");
                    txtTitulo.Focus();
                    return false;
                }
                if (cboIdiomas.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe ingresar un idioma", "Completar");
                    cboIdiomas.Focus();
                    return false;
                }
                if (cboClasificacion.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe ingresar una clasificacion", "Completar");
                    cboClasificacion.Focus();
                    return false;
                }
                else
                {
                    if (lstPeliculas.SelectedIndex < 0 || string.IsNullOrEmpty(txtTitulo.Text))
                    {
                        MessageBox.Show("Debe seleccionar una pelicula de la lista", "Seleccionar");
                        lstPeliculas.Enabled = true;
                        lstPeliculas.SelectedIndex = 0;
                    }
                }
            }
            return true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCampos(lstPeliculas.SelectedIndex);
        }

        private void cargarCampos(int selectedIndex)
        {
            int k = lstPeliculas.SelectedIndex;
            txtTitulo.Text = lP[k].pTitulo;
            cboGenero.SelectedValue = lP[k].pId_genero;
            txtNacionalidad.Text = lP[k].pNacionalidad;
            cboIdiomas.SelectedValue = lP[k].pId_idioma;
            cboClasificacion.SelectedValue = lP[k].pId_clasificacion;
        }
    }
}
