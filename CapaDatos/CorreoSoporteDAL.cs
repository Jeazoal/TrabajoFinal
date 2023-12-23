using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CorreoSoporteDAL : RecuperarPasswordDAL
    {
        public CorreoSoporteDAL() 
        {
            remitenteCorreo = "alonsomarzano11@gmail.com";
            password = "ioqn tiei jnrf xcfz";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }

    }
}
