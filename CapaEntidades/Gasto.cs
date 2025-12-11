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
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public string Usuario { get; set; }

        public static BindingList<Gasto> ListaGastos { get; } = new BindingList<Gasto>();

        public Gasto(decimal Monto, string Usuario, string Categoria,string Descripcion, DateTimePicker Fecha)
        {
            this.Monto = Monto;
            this.Usuario = Usuario;
            this.Categoria = Categoria;
            this.Descripcion = Descripcion;
            this.Fecha = Fecha.Value;
            ListaGastos.Add(this);
        }
    }
}
