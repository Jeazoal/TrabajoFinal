using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using System.Data;

namespace CapaDatos
{

    public class RegistrarDAL
    {


        public void RegistrarDatosPersonales(DatosPersonales datosPersonales)
        {
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("RegistrarDatosPersonales", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Ajusta los parámetros según tu procedimiento almacenado
                        cmd.Parameters.AddWithValue("@TipoDocumentoId", datosPersonales.TipoDocumentoId);
                        cmd.Parameters.AddWithValue("@NumeroDocumento", datosPersonales.NumeroDocumento);
                        cmd.Parameters.AddWithValue("@ApellidoPaterno", datosPersonales.ApellidoPaterno);
                        cmd.Parameters.AddWithValue("@ApellidoMaterno", datosPersonales.ApellidoMaterno);
                        cmd.Parameters.AddWithValue("@Nombres", datosPersonales.Nombres);
                        cmd.Parameters.AddWithValue("@Sexo", datosPersonales.Sexo);
                        cmd.Parameters.AddWithValue("@EstadoCivilId", datosPersonales.EstadoCivilId);
                        cmd.Parameters.AddWithValue("@Direccion", datosPersonales.Direccion);
                        cmd.Parameters.AddWithValue("@Ubigeo", datosPersonales.Ubigeo);
                        cmd.Parameters.AddWithValue("@Discapacidad", datosPersonales.Discapacidad);
                        cmd.Parameters.AddWithValue("@DescripcionDiscapacidad", datosPersonales.DescripcionDiscapacidad);
                        cmd.Parameters.AddWithValue("@Telefono", datosPersonales.Telefono);
                        cmd.Parameters.AddWithValue("@Celular", datosPersonales.Celular);
                        cmd.Parameters.AddWithValue("@CorreoElectronico", datosPersonales.CorreoElectronico);
                        cmd.Parameters.AddWithValue("@Contrasena", datosPersonales.Contrasena);
                        cmd.Parameters.AddWithValue("@Foto", datosPersonales.Foto);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción según tus necesidades
                    Console.WriteLine("Error al registrar datos personales: " + ex.Message);
                }
            }
        }
    }
}
