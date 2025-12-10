using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CapaEntidades
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public static BindingList<Categoria> ListaCategorias { get; } = new BindingList<Categoria>();

        public Categoria(int idCategoria, string nombre, string descripcion)
        {
            this.IdCategoria = idCategoria;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            ListaCategorias.Add(this);
        }

    }
}
