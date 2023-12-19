using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Entidades;
using CapaEntidades;

namespace CapaDatos
{
    public class ProvinciaDAL
    {
        public List<Provincia> ObtenerProvincias(string idDepartamento)
        {
            List<Provincia> provincias = new List<Provincia>();

            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("ListarProvincias", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@IdDepartamento", SqlDbType.VarChar, 2).Value = idDepartamento;
                        cn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Provincia provincia = new Provincia();
                                provincia.Id = reader["id"].ToString();
                                provincia.Nombre = reader["name"].ToString();

                                provincias.Add(provincia);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción según tus necesidades
                    Console.WriteLine("Error al obtener provincias: " + ex.Message);
                }
            }

            return provincias;
        }
    }
}
