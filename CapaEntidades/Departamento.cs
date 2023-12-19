using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Departamento
    {
        public string Id { get; set; }
        public string Nombre { get; set; }

        public Departamento(string id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        // Constructor vacío si es necesario
        public Departamento()
        {
        }
    }
}
