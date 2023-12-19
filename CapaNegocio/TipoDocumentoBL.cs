using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class TipoDocumentoBL
    {
        public List<TipoDocumento> ListarDocumentos()
        {
            TipoDocumentoDAL tipoDocumentoDAL = new TipoDocumentoDAL();
            return tipoDocumentoDAL.ListarDocumentos();
        }
    }
}
