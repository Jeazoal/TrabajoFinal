using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class DatosAcademicosBL
    {
        DatosAcademicosDAL datosDL = new DatosAcademicosDAL();

        public string agregarDatos(DatosAcademicos datos)
        {
            return datosDL.agregar(datos);
        }

        public List<DatosAcademicos> listarDatos()
        {
            return datosDL.listar();
        }

        public DatosAcademicos buscarDatos(int id)
        {
            return datosDL.buscar(id);
        }

        public string actualizarDatos(DatosAcademicos datos)
        {
            return datosDL.actualizar(datos);
        }

        public string eliminarDatos(int id)
        {
            return datosDL.eliminar(id);
        }
    }
}
