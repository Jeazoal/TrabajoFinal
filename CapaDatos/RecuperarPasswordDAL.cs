using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class RecuperarPasswordDAL
    {
        private SmtpClient smtpCliente;

        protected string remitenteCorreo { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }
        protected void initializeSmtpClient()
        {
            smtpCliente = new SmtpClient();
            smtpCliente.Credentials=new NetworkCredential(remitenteCorreo, password);
            smtpCliente.Host = host;    
            smtpCliente.Port = port;
            smtpCliente.EnableSsl = ssl;
        }

        public void sendMail(string subject, string body, List<string>destinatariocorreo)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(remitenteCorreo);
                foreach (string mail in destinatariocorreo)
                {
                    mailMessage.To.Add(mail);
                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.IsBodyHtml = true;
                mailMessage.Priority=MailPriority.Normal;
                smtpCliente.Send(mailMessage);

            }
            catch (Exception ex)
            {
                mailMessage.Dispose();
                smtpCliente.Dispose();
            }
        }

        public string recoverPassword(string usuarioSolicitado)
        {     
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                cn.Open();
                using(var command = new SqlCommand())
                {
                    command.Connection = cn;
                    command.CommandText = "select*from DatosPersonales where CorreoElectronico=@CorreoElectronico";
                    command.Parameters.AddWithValue("@CorreoElectronico", usuarioSolicitado);
                    command.CommandType=System.Data.CommandType.Text;
                    SqlDataReader reader=command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string Nombre=reader.GetString(5);
                        string correoUsuario = reader.GetString(14);

                        var mailServices = new CorreoSoporteDAL();

                        string formularioLink = "https://localhost:44380/CambiarContrasena.aspx'";

                        mailServices.sendMail(
                            subject: "Sistema EducaNet: Solicitud de recuperacion de contraseña",
         body: $"<html><head><style>" +
          $"body {{ font-family: 'Arial, sans-serif'; margin: 0; padding: 0; }}" +
          $".container {{ max-width: 600px; margin: 0 auto; padding: 20px; border-radius: 10px; background-color: #F5F5F5; box-shadow: 0 0 10px rgba(0, 0, 0, 0.1); }}" +
          $".header {{ background-color: #007BFF; color: #fff; text-align: center; padding: 10px; border-radius: 10px 10px 0 0; }}" +
          $"p {{ color: #333; }}" +
          $"a {{ color: #007BFF; text-decoration: none; }}" +
          $"</style></head><body>" +
          $"<div class='container'>" +
          $"<div class='header'>" +
          $"<h2>Hola {Nombre}</h2>" +
          $"</div>" +
          $"<p>Usted solicitó recuperar su contraseña.</p>" +
          $"<p>Le pedimos que cambie su contraseña inmediatamente una vez <a href='{formularioLink}'>ingrese al sistema</a>.</p>" +
          $"</div></body></html>",
                    destinatariocorreo: new List<string> { correoUsuario }
                        );
                        return "Hola " + Nombre + "\n Usted solicitud recuperar su contraseña.\n" +
                            "Porfavor revise su correo: " + correoUsuario +
                             "\nSin embargo, le pedimos que cambie su contraseña inmediatamente una vez ingrese al sistema.";
                    }
                    else                   
                        return "Lo siento, no tiene una cuenta con ese correo";
                    
                }
            }
        }

    }
}
