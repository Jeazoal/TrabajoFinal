using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CambiarContrasenaDAL
    {
        public string CambiarContrasena(string correoElectronico, string nuevaContrasena)
        {
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("CambiarContraseña", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);
                        cmd.Parameters.AddWithValue("@NuevaContraseña", nuevaContrasena);

                        cn.Open();

                        // Ejecutar el procedimiento almacenado y obtener el mensaje de resultado
                        object resultado = cmd.ExecuteScalar();

                        // Puedes manejar el resultado según tus necesidades
                        return resultado != null ? resultado.ToString() : "No se obtuvo un resultado válido.";
                    }
                }
                catch (Exception ex)
                {
                    // Puedes manejar la excepción según tus necesidades
                    return "Error al cambiar la contraseña: " + ex.Message;
                }
            }
        }
    }
}
