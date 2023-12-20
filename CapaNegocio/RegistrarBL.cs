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
                // Llama al DAL para registrar datos personales
                registrarDAL.RegistrarDatosPersonales(datosPersonales);
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante el proceso de registro
                Console.WriteLine("Error al registrar datos personales: " + ex.Message);
            }
        }

    }
}
