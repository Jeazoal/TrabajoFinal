using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class ProvinciaBL
    {
        private readonly ProvinciaDAL provinciaDAL;

        public ProvinciaBL()
        {
            provinciaDAL = new ProvinciaDAL();
        }

        public List<Provincia> ObtenerProvinciasPorDepartamento(string idDepartamento)
        {
            try
            {
                return provinciaDAL.ObtenerProvincias(idDepartamento);
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades
                Console.WriteLine("Error al obtener provincias: " + ex.Message);
                return new List<Provincia>();
            }
        }
    }
}