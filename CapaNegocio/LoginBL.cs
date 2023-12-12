using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;

namespace CapaNegocio
{
    public class LoginBL
    {
        LoginDAL loginDAL = new LoginDAL();

        public string ValidarCredenciales(string numeroDocumento, string contrasena)
        {
            return loginDAL.ValidarCredenciales(numeroDocumento, contrasena);
        }
    }
}
