using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoFinal
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Verifica si el usuario está autenticado en la sesión
                if (Session["UsuarioAutenticado"] != null)
                {
                    // Obtiene la información del usuario desde la sesión
                    DatosPersonales usuarioAutenticado = (DatosPersonales)Session["UsuarioAutenticado"];

                    // Muestra la información en la página
                    MostrarInformacionUsuario(usuarioAutenticado);
                }
                else
                {
                    // Si el usuario no está autenticado, redirige a la página de login
                    Response.Redirect("Login.aspx");
                }
            }
        }

        private void MostrarInformacionUsuario(DatosPersonales usuario)
        {
            string rutaRelativa = "~/Fotos/" + Path.GetFileName(usuario.Foto);

            // Convierte la ruta relativa a una URL absoluta
            string urlImagen = ResolveUrl(rutaRelativa);

            // Muestra la foto, nombre y correo del usuario en los controles correspondientes
            imgFoto.ImageUrl = urlImagen; // Suponiendo que tu control de imagen se llama imgFoto
            lblNombre.Text = $"{usuario.Nombres} {usuario.ApellidoPaterno} {usuario.ApellidoMaterno}"; // Suponiendo que tu control de etiqueta es lblNombre
            lblnumerouser.Text = usuario.NumeroDocumento; // Suponiendo que tu control de etiqueta es lblCorreo
        }
    }
}