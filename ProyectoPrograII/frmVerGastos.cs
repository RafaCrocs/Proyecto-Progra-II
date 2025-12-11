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
    public partial class frmVerGastos : Form
    {
        public frmVerGastos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {


        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            frmAgregarGasto agregarGasto = new frmAgregarGasto();
            agregarGasto.ShowDialog();
        }

        private void frmVerGastos_Load(object sender, EventArgs e)
        {
            DataGriedGastos.DataSource = CapaEntidades.Gasto.ListaGastos;
        }
    }
}
