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
    public class EstadoCDAL
    {
        public List<EstadoC> ListarEstadosCiviles()
        {
            List<EstadoC> estadosCiviles = new List<EstadoC>();

            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("ListarEstadoCivil", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EstadoC estadoCivil = new EstadoC();
                                estadoCivil.Id = Convert.ToInt32(reader["Id"]);
                                estadoCivil.EstadoCivil = reader["EstadoCivil"].ToString();

                                estadosCiviles.Add(estadoCivil);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción según tus necesidades
                    Console.WriteLine("Error al obtener estados civiles: " + ex.Message);
                }
            }

            return estadosCiviles;
        }
    }
}
