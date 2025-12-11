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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //Buscar gasto por descripcion
            string descripcionBuscada = txtDescripcion.Text.ToLower();
            var gastosFiltrados = Gasto.ListaGastos.Where(g => g.Descripcion.ToLower().Contains(descripcionBuscada)).ToList();
            DataGriedGastos.DataSource = gastosFiltrados;


        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //Filtrar por Fecha
            DateTime fechaSeleccionada = dtpFecha.Value.Date;
            var gastosFiltrados = Gasto.ListaGastos.Where(g => g.Fecha.Date == fechaSeleccionada).ToList();
            DataGriedGastos.DataSource = gastosFiltrados;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiar filtros
            DataGriedGastos.DataSource = Gasto.ListaGastos;
            txtDescripcion.Clear();

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            //Filtrar entre Fechas
            DateTime fechaInicio = Fecha1.Value.Date;
            DateTime fechaFin = Fecha2.Value.Date;
            var gastosFiltrados = Gasto.ListaGastos.Where(g => g.Fecha.Date >= fechaInicio && g.Fecha.Date <= fechaFin).ToList();
            DataGriedGastos.DataSource = gastosFiltrados;

        }
    }
}
