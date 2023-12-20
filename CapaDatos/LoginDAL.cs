using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using CapaEntidades;
using Entidades;
using System.Security.Cryptography;


namespace CapaDatos
{
    public class LoginDAL
    {
        public DatosPersonales VerificarCredenciales(string numeroDocumento, string contrasena)
        {
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("VerificarCredenciales", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);
                        cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                        cn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Si las credenciales son válidas, crea un objeto DatosPersonales con los datos obtenidos
                                return new DatosPersonales
                                {
                                    NumeroDocumento = Convert.ToString(reader["NumeroDocumento"]),
                                    Contrasena = Convert.ToString(reader["Contrasena"])
                                };
                            }
                            else
                            {
                                // Las credenciales no son válidas
                                return null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción según tus necesidades
                    Console.WriteLine("Error al verificar credenciales: " + ex.Message);
                    return null;
                }
            }
        }
    }
}
