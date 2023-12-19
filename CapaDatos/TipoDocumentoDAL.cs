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
    public class TipoDocumentoDAL
    {
        public List<TipoDocumento> ListarDocumentos()
        {
            List<TipoDocumento> documentos = new List<TipoDocumento>();

            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("ListarDocumento", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TipoDocumento documento = new TipoDocumento();
                                documento.Id = Convert.ToInt32(reader["Id"]);
                                documento.NombreDocumento = reader["NombreDocumento"].ToString();

                                documentos.Add(documento);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción según tus necesidades
                    Console.WriteLine("Error al obtener documentos: " + ex.Message);
                }
            }

            return documentos;
        }
    }
}
