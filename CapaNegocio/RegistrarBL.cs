using CapaDatos;
using Entidades;
using BCrypt.Net;


namespace CapaNegocio
{
    public class RegistrarBL
    {
        private readonly RegistrarDAL registrarDAL = new RegistrarDAL();

        public void RegistrarDatosPersonales(DatosPersonales datosPersonales)
        {
            string contrasenaSinCifrar = datosPersonales.Contrasena;
            string contrasenaCifrada = BCrypt.Net.BCrypt.HashPassword(contrasenaSinCifrar);
            datosPersonales.Contrasena = contrasenaCifrada;

            // Aquí puedes realizar validaciones adicionales antes de llamar al DAL, si es necesario
            registrarDAL.RegistrarDatosPersonales(datosPersonales);
        }
    }
}
