using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos_Ejercicio3.Entidades
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string contraseña { get; set; }

        public Usuario()
        {

        }

        public Usuario(string nombreUsuario, string contraseña)
        {
            NombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
        }
    }


}
