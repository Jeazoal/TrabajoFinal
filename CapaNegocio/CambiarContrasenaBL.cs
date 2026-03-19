using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CambiarContrasenaBL
    {
        private readonly CambiarContrasenaDAL cambiarContrasenaDAL = new CambiarContrasenaDAL();

        public string CambiarContrasena(string correoElectronico, string nuevaContrasena)
        {
            try
            {
                return cambiarContrasenaDAL.CambiarContrasena(correoElectronico, nuevaContrasena);
            }
            catch (Exception ex)
            {
                return "Error al cambiar la contraseña: " + ex.Message;
            }
        }
    }
}
