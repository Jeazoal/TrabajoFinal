using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class DatosAcademicos
    {
        public DatosAcademicos()
        {

        }
        public DatosAcademicos(string tituloGrado, string centroEstudios, DateTime fechaGrado, string rutaPdf)
        {

            TituloGrado = tituloGrado;
            CentroEstudios = centroEstudios;
            FechaGrado = fechaGrado;
            RutaPdf = rutaPdf;
        }

        public DatosAcademicos(int iD, string tituloGrado, string centroEstudios, DateTime fechaGrado, string rutaPdf)
        {
            ID = iD;
            TituloGrado = tituloGrado;
            CentroEstudios = centroEstudios;
            FechaGrado = fechaGrado;
            RutaPdf = rutaPdf;
        }

        public int ID { get; set; }

        public string TituloGrado { get; set; }

        public string CentroEstudios { get; set; }

        public DateTime FechaGrado { get; set; }

        public string RutaPdf { get; set; }
    }
}
