using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CapaEntidades
{
    public class Gasto
    {
        public int IdGasto { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }

        public static BindingList<Gasto> ListaGastos { get; } = new BindingList<Gasto>();

        public Gasto(int idGasto, string descripcion, decimal monto)
        {
            this.IdGasto = idGasto;
            this.Descripcion = descripcion;
            this.Monto = monto;
            ListaGastos.Add(this);
        }
    }
}
