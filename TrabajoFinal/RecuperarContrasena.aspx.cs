using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoFinal
{
    public partial class Formulario_web12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            var correo = new RecuperarPasswordBL();
            var result = correo.recoverPassword(txtgmail.Text);
            Label1.Text = result;

            if (result != null)
            {
                Session["RecuperarContrasena"] = result;

                // Redirige a la página principal
                Response.Redirect("RecuperarContrasena.aspx");
            }
            else
            {
                // Muestra un mensaje de error si la autenticación falla
                Response.Write("Autenticación fallida. Verifica tu número de documento y contraseña.");
            }
        }
    }
}