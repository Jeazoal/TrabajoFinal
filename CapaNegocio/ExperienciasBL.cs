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

        public string ActualizarExperiencias(Experiencias experiencia)
        {
            try
            {
                // Puedes agregar aquí lógica de negocio adicional antes de actualizar la experiencia si es necesario

                // Llama al método de la capa de datos para actualizar la experiencia
                return experienciasDL.Actualizar(experiencia);
            }
            catch (Exception ex)
            {
                // Maneja la excepción según tus necesidades
                throw new Exception("Error en la capa de negocios al actualizar experiencia.", ex);
            }
        }

        public string eliminarExperiencias(int id)
        {
            return experienciasDL.Eliminar(id);
        }
    }
}
