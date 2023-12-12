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
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Nombres { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string Direccion { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public bool Discapacidad { get; set; }
        public string DescripcionDiscapacidad { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contrasena { get; set; }
        public byte[] Foto { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public DatosPersonales(int id, string tipoDocumento, string numeroDocumento, string apellidoPaterno, string apellidoMaterno,
            string nombres, string sexo, string estadoCivil, string direccion, string departamento, string provincia, string distrito,
            bool discapacidad, string descripcionDiscapacidad, string telefono, string celular, string correoElectronico, string contrasena,
            byte[] foto, DateTime fechaRegistro, DateTime? fechaModificacion)
        {
            Id = id;
            TipoDocumento = tipoDocumento;
            NumeroDocumento = numeroDocumento;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            Nombres = nombres;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
            Direccion = direccion;
            Departamento = departamento;
            Provincia = provincia;
            Distrito = distrito;
            Discapacidad = discapacidad;
            DescripcionDiscapacidad = descripcionDiscapacidad;
            Telefono = telefono;
            Celular = celular;
            CorreoElectronico = correoElectronico;
            Contrasena = contrasena;
            Foto = foto;
            FechaRegistro = fechaRegistro;
            FechaModificacion = fechaModificacion;
        }

        public DatosPersonales()
        {
            // Constructor vacío
        }
    }
}
