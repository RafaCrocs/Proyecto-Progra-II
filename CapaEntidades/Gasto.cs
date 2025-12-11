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
        public decimal Monto { get; set; }
        public string Categoria { get; set; }
        public string Usuario { get; set; }

        public static BindingList<Gasto> ListaGastos { get; } = new BindingList<Gasto>();

        public Gasto(decimal Monto, string Usuario, string Categoria)
        {
            this.Monto = Monto;
            this.Usuario = Usuario;
            this.Categoria = Categoria;
            ListaGastos.Add(this);
        }
    }
}
