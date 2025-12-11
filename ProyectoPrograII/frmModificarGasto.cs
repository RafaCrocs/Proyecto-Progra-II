using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograII
{
    public partial class frmModificarGasto : Form
    {
        Gasto nuevoGasto;
        public frmModificarGasto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                nuevoGasto = new Gasto(decimal.Parse(txtMonto.Text), cmbUsuarios.Text, cmbCategorias.Text, txtDescripcion.Text, dtpFecha);
                MessageBox.Show("Gasto agregado exitosamente");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar algun dato: " + ex.Message);
                return;
            }
        }

        private void frmModificarGasto_Load(object sender, EventArgs e)
        {
            //Configurar el comboBox con las categorias
            if (Categoria.ListaCategorias.Count > 0)
            {
                for (int i = 0; i < Categoria.ListaCategorias.Count; i++)
                {
                    cmbCategorias.Items.Add(Categoria.ListaCategorias[i].Nombre);
                }
                //cmbCategoria.DataSource = Categoria.ListaCategorias;
                //cmbCategoria.SelectedIndex = 0;
            }

            if (Usuario.ListaUsuarios.Count > 0)
            {
                for (int i = 0; i < Usuario.ListaUsuarios.Count; i++)
                {
                    cmbUsuarios.Items.Add(Usuario.ListaUsuarios[i].Nombre);
                }

            }

        }
    }
}
