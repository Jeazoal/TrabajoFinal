using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class ExperienciasBL
    {
        ExperienciasDAL experienciasDL = new ExperienciasDAL();

        public string agregarExperiencias(Experiencias datos)
        {
            return experienciasDL.Agregar(datos);
        }

        public List<Experiencias> listarExperiencias()
        {
            return experienciasDL.Listar();
        }

        public Experiencias buscarExperiencias(int id)
        {
            return experienciasDL.Buscar(id);
        }

        public string actualizarExperiencias(Experiencias datos)
        {
            return experienciasDL.Actualizar(datos);
        }

        public string eliminarExperiencias(int id)
        {
            return experienciasDL.Eliminar(id);
        }
    }
}
