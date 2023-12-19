using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EstadoC
    {
        public int Id { get; set; }
        public string EstadoCivil { get; set; }

        public EstadoC(int id, string estadoCivil)
        {
            Id = id;
            EstadoCivil = estadoCivil;
        }

        // Constructor vacío si es necesario
        public EstadoC()
        {
        }
    }
}
