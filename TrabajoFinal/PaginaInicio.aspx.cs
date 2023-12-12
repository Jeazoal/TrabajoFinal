using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoFinal
{
    public partial class PaginaInicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string numeroDocumento = txtdni.Text;
            string contrasena = txtcontraseña.Text;

            CapaNegocio.LoginBL loginBL = new CapaNegocio.LoginBL();
            string resultado = loginBL.ValidarCredenciales(numeroDocumento, contrasena);

            // Verificar el resultado y redireccionar según sea necesario
            if (resultado == "Login exitoso")
            {
                // Redireccionar a la página FormularioWeb1.aspx
                Session["UsuarioDNI"] = numeroDocumento;

                Response.Redirect("FormularioWeb1.aspx");
            }
            else
            {
                // Manejar el caso en que las credenciales no son válidas (puedes mostrar un mensaje de error, por ejemplo)
                Response.Write("<script>alert('Credenciales inválidas.')</script>");
            }
        }
    }
}