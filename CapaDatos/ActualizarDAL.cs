using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class ActualizarDAL
    {
        public void ActualizarDatosPersonales(DatosPersonales datosPersonales)
        {
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("ActualizarDatosPersonales", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
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
                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al actualizar datos personales: " + ex.Message);
                }
            }
        }
    }
}