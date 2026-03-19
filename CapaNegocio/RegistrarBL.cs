using CapaDatos;
using Entidades;
using BCrypt.Net;
using System.Security.Cryptography;
using System.Text;
using System;

namespace CapaNegocio
{
    public class RegistrarBL
    {
        private readonly RegistrarDAL registrarDAL = new RegistrarDAL();

        public void RegistrarDatosPersonales(DatosPersonales datosPersonales)
        {
            try
            {
                registrarDAL.RegistrarDatosPersonales(datosPersonales);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar datos personales: " + ex.Message);
            }
        }

    }
}
