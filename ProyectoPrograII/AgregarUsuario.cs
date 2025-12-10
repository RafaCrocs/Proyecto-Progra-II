using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;

namespace ProyectoPrograII
{
    public partial class AgregarUsuario : Form
    {

        Usuario nuevoUsuario;

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {


        }

        public AgregarUsuario()
        {
            InitializeComponent();
        }


        public void btnGuardar_Click(object sender, EventArgs e)
        {

            nuevoUsuario = new Usuario(int.Parse(txtId.Text), txtNombre.Text, txtApellido.Text);


            MessageBox.Show("Usuario agregado exitosamente");

            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
