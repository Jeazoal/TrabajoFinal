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
                // Obtén el número de documento y la contraseña ingresados por el usuario
                string numeroDocumento = txtdni.Text;
                string contrasena = txtcontraseña.Text;

                // Crea una instancia del Business Logic (BL) para el login
                LoginBL loginBL = new LoginBL();

                // Realiza la autenticación del usuario
                DatosPersonales usuarioAutenticado = loginBL.VerificarCredenciales(numeroDocumento, contrasena);

                // Verifica si la autenticación fue exitosa
                if (usuarioAutenticado != null)
                {
                    // Establece la variable de sesión indicando que el usuario ha iniciado sesión
                    Session["UsuarioAutenticado"] = usuarioAutenticado;

                    // Redirige a la página principal
                    Response.Redirect("PaginaPrincipal.aspx");
                }
                else
                {
                    // Muestra un mensaje de error si la autenticación falla
                    Response.Write("Autenticación fallida. Verifica tu número de documento y contraseña.");
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante el proceso de login
                Response.Write("Error: " + ex.Message);
            }

        }
    }
}