using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Entidades;

namespace CapaNegocio
{
    public class ActualizarBL
    {
        private readonly ActualizarDAL actualizarDAL = new ActualizarDAL();

        public void ActualizarDatosPersonales(DatosPersonales datosPersonales)
        {
            try
            {
                actualizarDAL.ActualizarDatosPersonales(datosPersonales);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar datos personales: " + ex.Message);
            }
        }
    }
}