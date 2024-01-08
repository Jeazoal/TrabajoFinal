using CapaNegocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoFinal
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string numeroDocumento = txtdni.Text;
                string contrasena = txtcontraseña.Text;

                LoginBL loginBL = new LoginBL();

                DatosPersonales usuarioAutenticado = loginBL.VerificarCredenciales(numeroDocumento, contrasena);

                if (usuarioAutenticado != null)
                {
                    // Obtiene la información completa del usuario
                    DatosPersonales infoUsuario = loginBL.ObtenerInformacionUsuario(numeroDocumento);

                    // Almacena la información del usuario en la sesión
                    Session["UsuarioAutenticado"] = infoUsuario;

                    // Redirige al formulario deseado
                    Response.Redirect("FormListarDatosA.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();
                }
                else
                {
                    Response.Write("Autenticación fallida. Verifica tu número de documento y contraseña.");
                }
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
        }
    }
}