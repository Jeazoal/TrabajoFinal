using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;

namespace CapaNegocio
{
    public class LoginBL
    {
        private readonly LoginDAL loginDAL = new LoginDAL();

        public DatosPersonales VerificarCredenciales(string numeroDocumento, string contrasena)
        {
            try
            {
                return loginDAL.VerificarCredenciales(numeroDocumento, contrasena);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al verificar credenciales: " + ex.Message);
                return null;
            }
        }

        
        

        public DatosPersonales ObtenerInformacionUsuario(string numeroDocumento)
        {
            try
            {
                return loginDAL.ObtenerInformacionCompleta(numeroDocumento);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener información del usuario: " + ex.Message);
                return null;
            }
        }
    }
}
