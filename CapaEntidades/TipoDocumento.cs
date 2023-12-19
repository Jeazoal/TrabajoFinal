using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{

    public class TipoDocumento
    {
        public int Id { get; set; }
        public string NombreDocumento { get; set; }

        public TipoDocumento(int id, string nombreDocumento)
        {
            Id = id;
            NombreDocumento = nombreDocumento;
        }

        // Constructor vacío si es necesario
        public TipoDocumento()
        {
        }
    }
}
