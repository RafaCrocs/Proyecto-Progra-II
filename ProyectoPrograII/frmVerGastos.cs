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
    public partial class frmVerGastos : Form
    {
        public frmVerGastos()
        {
            InitializeComponent();

        }

        private void btnAgregarGasto_Click(object sender, EventArgs e)
        {
            frmAgregarGasto agregarGasto = new frmAgregarGasto();
            agregarGasto.ShowDialog();
        }

        private void frmVerGastos_Load(object sender, EventArgs e)
        {
            DataGriedGastos.DataSource = Gasto.ListaGastos;

        }


        private void DataGriedGastos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            decimal Suma = 0;
            for (int i = 0; i < DataGriedGastos.Rows.Count; i++)
            {
                Suma += Convert.ToDecimal(DataGriedGastos.Rows[i].Cells["Monto"].Value);
            }
            txtSuma.Text = Suma.ToString();

        }
    }
}
