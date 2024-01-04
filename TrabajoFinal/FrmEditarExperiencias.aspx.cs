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
    public partial class Formulario_web19 : System.Web.UI.Page
    {
        ExperienciasBL unExperienciaBL = new ExperienciasBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Experiencias unExperienciaBL = new Experiencias();
                lblId.Text = Request.QueryString["id"];

            }

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            ExperienciasBL unDato = new ExperienciasBL();

            string m = unDato.actualizarExperiencias(new Experiencias(Int32.Parse(lblId.Text), DateTime.Parse(txtFechaInicio.Text),
            DateTime.Parse(txtFechaFin.Text),  
            txtCargo.Text,
            txtNombre.Text,
            txtRuta.Text));

            Response.Write("<script language=javascript>alert('" + m + "');</script>");
            Response.Write("<script language=javascript>document.location.href = 'FrmListarExperiencias.aspx';</script>");
        }
    }
}