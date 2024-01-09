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

        public DatosPersonales ObtenerInformacionCompleta(string numeroDocumento)
        {
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("ObtenerInformacionCompletaUsuario", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);

                        cn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {                              
                                return new DatosPersonales
                                {                                    
                                    Nombres = Convert.ToString(reader["Nombres"]),
                                    NumeroDocumento = Convert.ToString(reader["NumeroDocumento"]),
                                    ApellidoMaterno = Convert.ToString(reader["ApellidoMaterno"]),
                                    ApellidoPaterno = Convert.ToString(reader["ApellidoPaterno"]),
                                    Sexo = Convert.ToString(reader["Sexo"]),
                                    EstadoCivilId = Convert.ToInt32(reader["EstadoCivilId"]),
                                    Direccion = Convert.ToString(reader["Direccion"]),
                                    Ubigeo = Convert.ToString(reader["Ubigeo"]),
                                    Discapacidad = Convert.ToString(reader["Discapacidad"]),
                                    DescripcionDiscapacidad = Convert.ToString(reader["DescripcionDiscapacidad"]),
                                    Telefono = Convert.ToString(reader["Telefono"]),
                                    Celular = Convert.ToString(reader["Celular"]),
                                    CorreoElectronico = Convert.ToString(reader["CorreoElectronico"]),
                                    Contrasena = Convert.ToString(reader["Contrasena"]),
                                    Foto = Convert.ToString(reader["Foto"]),
                                };
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción según tus necesidades
                    Console.WriteLine("Error al obtener información completa del usuario: " + ex.Message);
                    return null;
                }
            }
        }



    }
}
