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
                // Llama al DAL para cambiar la contraseña
                return cambiarContrasenaDAL.CambiarContrasena(correoElectronico, nuevaContrasena);
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante el cambio de contraseña
                return "Error al cambiar la contraseña: " + ex.Message;
            }
        }
    }
}
