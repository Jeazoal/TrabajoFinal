using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoFinal
{
    public partial class Formulario_web13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Verificar si la cookie existe
            if (Request.Cookies["RecoveryEmail"] != null)
            {
                // Obtener el valor de la cookie y asignarlo al TextBox
                string recoveryEmail = Request.Cookies["RecoveryEmail"].Value;
            }
        }

        protected void btnCambiarContrasena_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el valor de la cookie "RecoveryEmail"
                HttpCookie recoveryEmailCookie = Request.Cookies["RecoveryEmail"];

                if (recoveryEmailCookie != null)
                {
                    string correoElectronico = recoveryEmailCookie.Value;
                    string nuevaContrasena = txtNuevaContrasena.Text;

                    CambiarContrasenaBL cambiarContrasenaBL = new CambiarContrasenaBL();
                    string resultado = cambiarContrasenaBL.CambiarContrasena(correoElectronico, nuevaContrasena);

                    lblMensaje.Text = resultado;
                }
                else
                {
                    lblMensaje.Text = "Error: No se pudo obtener el correo electrónico de la cookie.";
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
}