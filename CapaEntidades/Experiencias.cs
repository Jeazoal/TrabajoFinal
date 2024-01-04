using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Experiencias
    {
        public int ID { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Cargo { get; set; }
        public string NombreEmpresa { get; set; }
        public string RutaPdf { get; set; }

        public Experiencias(int iD, DateTime fechaInicio, DateTime? fechaFin, string cargo, string nombreEmpresa, string rutaPdf)
        {
            ID = iD;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Cargo = cargo;
            NombreEmpresa = nombreEmpresa;
            RutaPdf = rutaPdf;
        }
        public Experiencias(DateTime fechaInicio, DateTime? fechaFin, string cargo, string nombreEmpresa, string rutaPdf)
        {

            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Cargo = cargo;
            NombreEmpresa = nombreEmpresa;
            RutaPdf = rutaPdf;
        }
        public Experiencias()
        {

        }
    }
}
