using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ExperienciasDAL
    {
        public string Agregar(Experiencias experiencia)
        {
            string r = "";
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_AgregarExperiencia";

                    cmd.Parameters.AddWithValue("@FechaInicio", experiencia.FechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", experiencia.FechaFin);
                    cmd.Parameters.AddWithValue("@Cargo", experiencia.Cargo);
                    cmd.Parameters.AddWithValue("@NombreEmpresa", experiencia.NombreEmpresa);
                    cmd.Parameters.AddWithValue("@RutaPdf", experiencia.RutaPdf);

                    cn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        r = "Experiencia Agregada";
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
            return r;
        }

        public List<Experiencias> Listar()
        {
            List<Experiencias> lista = new List<Experiencias>();
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ListarExperiencias";
                    cn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Experiencias experiencia = new Experiencias
                            {
                                ID = int.Parse(reader["ID"].ToString()),
                                Cargo = reader["Cargo"].ToString(),
                                NombreEmpresa = reader["NombreEmpresa"].ToString(),
                                RutaPdf = reader["RutaPdf"].ToString()
                            };

                            // Intenta convertir la fecha y maneja el caso en el que no sea válida
                            if (DateTime.TryParse(reader["FechaInicio"].ToString(), out DateTime fechaInicio))
                            {
                                experiencia.FechaInicio = fechaInicio;
                            }
                            else
                            {
                                // Puedes asignar un valor predeterminado o manejar el error de otra manera
                                experiencia.FechaInicio = DateTime.MinValue;
                            }

                            // Intenta convertir la fecha de fin y maneja el caso en el que no sea válida
                            if (reader["FechaFin"] != DBNull.Value && DateTime.TryParse(reader["FechaFin"].ToString(), out DateTime fechaFin))
                            {
                                experiencia.FechaFin = fechaFin;
                            }
                            else
                            {
                                // Puedes asignar un valor predeterminado o manejar el error de otra manera
                                experiencia.FechaFin = null; // o algún otro valor predeterminado
                            }

                            lista.Add(experiencia);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    cn.Close();
                }

                return lista;
            }
        }

        public Experiencias Buscar(int id)
        {
            Experiencias experiencia = null;
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_BuscarExperiencia";
                    cmd.Parameters.AddWithValue("@ID", id);
                    cn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            experiencia = new Experiencias
                            {
                                ID = int.Parse(reader["ID"].ToString()),
                                Cargo = reader["Cargo"].ToString(),
                                NombreEmpresa = reader["NombreEmpresa"].ToString(),
                                RutaPdf = reader["RutaPdf"].ToString()
                            };

                            // Intenta convertir la fecha y maneja el caso en el que no sea válida
                            if (DateTime.TryParse(reader["FechaInicio"].ToString(), out DateTime fechaInicio))
                            {
                                experiencia.FechaInicio = fechaInicio;
                            }
                            else
                            {
                                // Puedes asignar un valor predeterminado o manejar el error de otra manera
                                experiencia.FechaInicio = DateTime.MinValue;
                            }

                            // Intenta convertir la fecha de fin y maneja el caso en el que no sea válida
                            if (reader["FechaFin"] != DBNull.Value && DateTime.TryParse(reader["FechaFin"].ToString(), out DateTime fechaFin))
                            {
                                experiencia.FechaFin = fechaFin;
                            }
                            else
                            {
                                // Puedes asignar un valor predeterminado o manejar el error de otra manera
                                experiencia.FechaFin = null; // o algún otro valor predeterminado
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
            return experiencia;
        }

        public string Actualizar(Experiencias experiencia)
        {
            string mensaje = "";
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ActualizarExperiencia";

                    cmd.Parameters.AddWithValue("@ID", experiencia.ID);
                    cmd.Parameters.AddWithValue("@FechaInicio", experiencia.FechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", experiencia.FechaFin);
                    cmd.Parameters.AddWithValue("@Cargo", experiencia.Cargo);
                    cmd.Parameters.AddWithValue("@NombreEmpresa", experiencia.NombreEmpresa);
                    cmd.Parameters.AddWithValue("@RutaPdf", experiencia.RutaPdf);

                    cn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        mensaje = "Experiencia Actualizada";
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
            return mensaje;
        }

        public string Eliminar(int id)
        {
            string mensaje = "";
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_EliminarExperiencia";
                    cmd.Parameters.AddWithValue("@ID", id);

                    cn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        mensaje = "Experiencia Eliminada";
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
            return mensaje;
        }
    }

}
