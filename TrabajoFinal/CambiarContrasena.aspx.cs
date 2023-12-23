using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoFinal
{
    public partial class RecuperarContraseña : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string usuario = Request.QueryString["usuario"];

            // Puedes utilizar el usuario para realizar operaciones en la base de datos o mostrar información en la página
            // Por ejemplo, puedes prellenar un campo oculto con el usuario para usarlo en el proceso de cambio de contraseña.
            if (!UsuarioRecuperarContrasena())
            {
                // Si no ha iniciado sesión, redirige a la página de inicio de sesión
                Response.Redirect("RecuperarContrasena.aspx");
            }

        }
        private bool UsuarioRecuperarContrasena()
        {
            // Verifica si existe una variable de sesión que indique que el usuario ha iniciado sesión
            return Session["RecuperarContrasena"] != null;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void btnCambiarContrasena_Click(object sender, EventArgs e)
        {
            try
            {
                string correoElectronico = txtCorreoElectronico.Text;
                string nuevaContrasena = txtNuevaContrasena.Text;

                CambiarContrasenaBL cambiarContrasenaBL = new CambiarContrasenaBL();
                string resultado = cambiarContrasenaBL.CambiarContrasena(correoElectronico, nuevaContrasena);

                lblMensaje.Text = resultado;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
}