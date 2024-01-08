using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoFinal
{
    public partial class Formulario_web113 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ExperienciasBL ocompañiaBL = new ExperienciasBL();
            gvListaE.DataSource = ocompañiaBL.listarExperiencias();
            gvListaE.DataBind();
        }
    }
}