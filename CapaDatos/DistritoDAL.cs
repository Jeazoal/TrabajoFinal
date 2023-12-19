using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Entidades;
using CapaEntidades;

namespace CapaDatos
{
    public class DistritoDAL
    {
        public List<Distrito> ObtenerDistritos(string provinciaId)
        {
            List<Distrito> distritos = new List<Distrito>();

            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("ListarDistritos", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@ProvinciaId", SqlDbType.VarChar, 4).Value = provinciaId;
                        cn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Distrito distrito = new Distrito();
                                distrito.Id = reader["id"].ToString();
                                distrito.Nombre = reader["name"].ToString();
                                distritos.Add(distrito);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción según tus necesidades
                    Console.WriteLine("Error al obtener distritos: " + ex.Message);
                }
            }

            return distritos;
        }
    }
}
