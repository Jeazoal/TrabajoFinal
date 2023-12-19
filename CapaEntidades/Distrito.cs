using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Distrito
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string DepartamentoId { get; set; }
        public string ProvinciaId { get; set; }

        public Distrito(string id, string nombre, string departamentoId, string provinciaId)
        {
            Id = id;
            Nombre = nombre;
            DepartamentoId = departamentoId;
            ProvinciaId = provinciaId;
        }

        // Constructor vacío si es necesario
        public Distrito()
        {
        }
    }
}
