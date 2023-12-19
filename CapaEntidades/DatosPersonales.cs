using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DatosPersonales
    {
        public int Id { get; set; }
        public int TipoDocumentoId { get; set; }
        public string NumeroDocumento { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Nombres { get; set; }
        public string Sexo { get; set; }
        public int EstadoCivilId { get; set; }
        public string Direccion { get; set; }
        public string Ubigeo { get; set; }
        public string Discapacidad { get; set; }
        public string DescripcionDiscapacidad { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contrasena { get; set; }
        public byte[] Foto { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }

        // Relaciones
        public TipoDocumento TipoDocumento { get; set; }
        public EstadoC EstadoCivil { get; set; }
    }
}
