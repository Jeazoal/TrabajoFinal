using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Entidades;
using CapaEntidades;

namespace CapaDatos
{
    public class DepartamentoDAL
    {
        public List<Departamento> ObtenerDepartamentos()
        {
            List<Departamento> departamentos = new List<Departamento>();

            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("ListarDepartamentos", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Departamento departamento = new Departamento();
                                departamento.Id = reader["id"].ToString();
                                departamento.Nombre = reader["name"].ToString();

                                departamentos.Add(departamento);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción según tus necesidades
                    Console.WriteLine("Error al obtener departamentos: " + ex.Message);
                }
            }

            return departamentos;
        }
    }
}
