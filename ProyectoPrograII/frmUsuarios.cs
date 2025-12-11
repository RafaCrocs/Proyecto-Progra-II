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
    public partial class frmUsuarios : Form
    {
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            DataGriedUsuarios.DataSource = Usuario.ListaUsuarios;
        }

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            // Abrir el formulario AgregarUsuario
            AgregarUsuario agregarUsuario = new AgregarUsuario();
            agregarUsuario.Show();
        }

        private void DataGriedUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Usar botones editar y eliminar
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGriedUsuarios.Rows[e.RowIndex];

                if (DataGriedUsuarios.Columns[e.ColumnIndex].Name == "Editar")
                {
                    //Ver que columna se esta seleccionando


                    //frmModificarUsuario frmModificarUsuario = new frmModificarUsuario();
                    //frmModificarUsuario.Show();

                }
                else if (DataGriedUsuarios.Columns[e.ColumnIndex].Name == "Eliminar")
                {

                }

            }
        }
    }
}
