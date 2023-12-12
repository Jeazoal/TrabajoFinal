using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }

        public Usuario(int idUsuario, string dni, string nombre, string apellido, string correo, string contraseña)
        {
            this.IdUsuario = idUsuario;
            this.DNI = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Correo = correo;
            this.Contraseña = contraseña;
        }

        public Usuario(string dni, string nombre, string apellido, string correo, string contraseña)
        {
            this.DNI = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Correo = correo;
            this.Contraseña = contraseña;
        }

        public Usuario()
        {
            // Constructor vacío
        }
    }
}
