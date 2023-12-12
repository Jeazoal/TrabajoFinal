using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ConexionBD
    {
        SqlConnection cn = new SqlConnection("server=DESKTOP-FT5EC3K;database=EducaNet;uid=sa;pwd=123456");
        public SqlConnection conectar()
        {
            return cn;
        }
    }
}
