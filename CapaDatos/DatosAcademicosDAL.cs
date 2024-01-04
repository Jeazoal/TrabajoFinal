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
    public class DatosAcademicosDAL
    {
        public string agregar(DatosAcademicos unDato)
        {
            string r = "";
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_AgregarDatos";
                    cmd.Parameters.AddWithValue("@tituloGrado", unDato.TituloGrado);
                    cmd.Parameters.AddWithValue("@centroEstudios", unDato.CentroEstudios);
                    cmd.Parameters.AddWithValue("@fechaGrado", unDato.FechaGrado);
                    cmd.Parameters.AddWithValue("@rutaPdf", unDato.RutaPdf);
                    cn.Open();
                    int f = cmd.ExecuteNonQuery();
                    if (f > 0)
                    {
                        r = "Registro Agregado";
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    cn.Dispose();
                }
            }
            return r;
        }

        public List<DatosAcademicos> listar()
        {
            List<DatosAcademicos> lista = new List<DatosAcademicos>();
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ListarDatos";
                    cn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DatosAcademicos datos = new DatosAcademicos
                            {
                                ID = int.Parse(reader["ID"].ToString()),
                                TituloGrado = reader["TituloGrado"].ToString(),
                                CentroEstudios = reader["CentroEstudios"].ToString(),
                                RutaPdf = reader["RutaPdf"].ToString()
                            };

                            // Intenta convertir la fecha y maneja el caso en el que no sea válida
                            if (DateTime.TryParse(reader["FechaGrado"].ToString(), out DateTime fechaGrado))
                            {
                                datos.FechaGrado = fechaGrado;
                            }
                            else
                            {
                                // Puedes asignar un valor predeterminado o manejar el error de otra manera
                                datos.FechaGrado = DateTime.MinValue;
                            }

                            lista.Add(datos);
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
                    cn.Dispose();
                }

                return lista;
            }
        }


        public DatosAcademicos buscar(int id)
        {
            DatosAcademicos unDato = null;
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                SqlCommand cmd = new SqlCommand();

                try
                {
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_BuscarDatos";
                    cmd.Parameters.AddWithValue("@id", id);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            unDato = new DatosAcademicos
                            {
                                ID = int.Parse(dr["ID"].ToString()),
                                TituloGrado = dr["TituloGrado"].ToString(),
                                CentroEstudios = dr["CentroEstudios"].ToString(),
                                RutaPdf = dr["RutaPdf"].ToString()
                            };

                            // Intenta convertir la fecha y maneja el caso en el que no sea válida
                            if (DateTime.TryParse(dr["FechaGrado"].ToString(), out DateTime fechaGrado))
                            {
                                unDato.FechaGrado = fechaGrado;
                            }
                            else
                            {
                                // Puedes asignar un valor predeterminado o manejar el error de otra manera
                                unDato.FechaGrado = DateTime.MinValue;
                            }
                        }
                        else
                        {
                            unDato = null;
                        }
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    cn.Dispose();
                }
            }
            return unDato;
        }

        public string actualizar(DatosAcademicos unDato)
        {
            SqlCommand cmd = new SqlCommand();
            string r = "";
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_ActualizarDatos";
                    cmd.Parameters.AddWithValue("@id", unDato.ID);
                    cmd.Parameters.AddWithValue("@tituloGrado", unDato.TituloGrado);
                    cmd.Parameters.AddWithValue("@centroEstudios", unDato.CentroEstudios);
                    cmd.Parameters.AddWithValue("@fechaGrado", unDato.FechaGrado);
                    cmd.Parameters.AddWithValue("@rutaPdf", unDato.RutaPdf);

                    // abrir conexion
                    cn.Open();
                    int f = cmd.ExecuteNonQuery();
                    if (f > 0)
                    {
                        r = "Registro Actualizado";
                    }
                    // cerrar conexion
                    cn.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    cn.Dispose();
                }
            }
            return r;
        }

        public string eliminar(int id)
        {
            SqlCommand cmd = new SqlCommand();
            string r = "";
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_EliminarDatos";
                    cmd.Parameters.AddWithValue("@id", id);

                    // abrir conexion
                    cn.Open();
                    int f = cmd.ExecuteNonQuery();
                    if (f > 0)
                    {
                        r = "Registro Eliminado";
                    }
                    // cerrar conexion
                    cn.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    cn.Dispose();
                }
            }
            return r;
        }
    }
}
