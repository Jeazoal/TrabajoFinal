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

                        string formularioLink = "<a href='https://localhost:44380/CambiarContrasena.aspx'>Ingrese aquí</a>";

                        mailServices.sendMail(
                            subject: "Sistema EducaNet: Solicitud de recuperacion de contraseña",
                            body: $"<html><body><p>Hola {Nombre},</p>" +
                                  $"<p>Usted solicitó recuperar su contraseña.</p>" +
                                  $"<p>Sin embargo, le pedimos que cambie su contraseña inmediatamente una vez {formularioLink} ingrese al sistema.</p></body></html>",
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
