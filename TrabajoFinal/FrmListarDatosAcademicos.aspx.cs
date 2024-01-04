using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoFinal
{
    public partial class Formulario_web2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!UsuarioHaIniciadoSesion())
            {
                // Si no ha iniciado sesión, redirige a la página de inicio de sesión
                Response.Redirect("Home.aspx");
            }
            DatosAcademicosBL ocompañiaBL = new DatosAcademicosBL();
            gvLista.DataSource = ocompañiaBL.listarDatos();
            gvLista.DataBind();
        }
        private bool UsuarioHaIniciadoSesion()
        {
            // Verifica si existe una variable de sesión que indique que el usuario ha iniciado sesión
            return Session["UsuarioAutenticado"] != null;
        }
    }
}