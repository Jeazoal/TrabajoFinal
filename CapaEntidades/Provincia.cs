using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Provincia
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string DepartamentoId { get; set; }

        public Provincia(string id, string nombre, string departamentoId)
        {
            Id = id;
            Nombre = nombre;
            DepartamentoId = departamentoId;
        }

        // Constructor vacío si es necesario
        public Provincia()
        {
        }
    }
}
