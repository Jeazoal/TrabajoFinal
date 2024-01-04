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