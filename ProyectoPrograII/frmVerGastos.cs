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
            if (e.RowIndex < 0)
                return;

            // Obtener el índice actual de la columna por nombre en vez de asumir 0
            var iconCol = dataGridView1.Columns["asd"];
            if (iconCol == null)
                return;

            if (e.ColumnIndex == iconCol.Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var bmp = Properties.Resources.controlar;
                if (bmp != null)
                {
                    var w = bmp.Width;
                    var h = bmp.Height;
                    // Escalar si la imagen es más grande que la celda
                    var maxW = e.CellBounds.Width - 4;
                    var maxH = e.CellBounds.Height - 4;
                    if (w > maxW || h > maxH)
                    {
                        var scale = Math.Min((float)maxW / w, (float)maxH / h);
                        w = (int)(w * scale);
                        h = (int)(h * scale);
                    }
                    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                    e.Graphics.DrawImage(bmp, new Rectangle(x, y, w, h));
                }
                e.Handled = true;
            }
        }
    }
}
