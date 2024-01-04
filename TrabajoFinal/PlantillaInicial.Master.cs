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
    public partial class PaginaInicial : System.Web.UI.MasterPage
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
                    Session["UsuarioAutenticado"] = usuarioAutenticado;

                    Response.Redirect("FrmListarDatosAcademicos.aspx", false); // Cambio aquí
                    Context.ApplicationInstance.CompleteRequest(); // Cambio aquí
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