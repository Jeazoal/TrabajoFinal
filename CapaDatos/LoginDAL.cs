using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class LoginDAL
    {
        public string ValidarCredenciales(string numeroDocumento, string contrasena)
        {
            string resultado = string.Empty;

            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("ValidarCredencialesDocente", cn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.Add("@NumeroDocumento", System.Data.SqlDbType.NVarChar, 12).Value = numeroDocumento;
                        cmd.Parameters.Add("@Contrasena", System.Data.SqlDbType.NVarChar, 10).Value = contrasena;

                        cn.Open();
                        resultado = (string)cmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    resultado = "Error: " + ex.Message;
                }
            }
            return resultado;
        }
    }
}
