using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoFinal
{
    public partial class Formulario_web18 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            ExperienciasBL unDato = new ExperienciasBL();
            string m = unDato.agregarExperiencias(new Experiencias(DateTime.Parse(txtFechaInicio.Text),
            DateTime.Parse(txtFechaFin.Text),  // Puede ser null si la fecha de fin es opcional
            txtCargo.Text,
            txtNombre.Text,
            txtRuta.Text));

            Response.Write("<script language=javascript>alert('" + m + "');</script>");
            Response.Write("<script language=javascript>document.location.href = 'FrmListarExperiencias.aspx';</script>");
        }
    }
}