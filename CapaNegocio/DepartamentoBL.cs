using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos; 
using CapaEntidades;

namespace CapaNegocio
{
    public class DepartamentoBL
    {
        public List<Departamento> ObtenerDepartamentos()
        {
            DepartamentoDAL departamentoDAL = new DepartamentoDAL();
            return departamentoDAL.ObtenerDepartamentos();
        }
    }
}
