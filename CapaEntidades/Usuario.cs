using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Usuario
    {
        public int Identificacion { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }

        public static BindingList<Usuario> ListaUsuarios { get; } = new BindingList<Usuario>();
        public Usuario(int identificacion, string Nombre, string Apellido)
        {
            this.Identificacion = identificacion;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            ListaUsuarios.Add(this);


        }

    }
}
