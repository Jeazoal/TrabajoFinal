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
    public partial class Formulario_web22 : System.Web.UI.Page
    {
        ExperienciasBL unDatoBL = new ExperienciasBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Experiencias unDato = new Experiencias();
                lblId.Text = Request.QueryString["id"];
                unDato = unDatoBL.buscarExperiencias(Int32.Parse(lblId.Text));
                if (unDatoBL != null)
                {

                    txtNombre.Text = unDato.NombreEmpresa;
                    txtCargo.Text = unDato.Cargo;
                    txtRuta.Text = unDato.RutaPdf;

                }
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            ExperienciasBL unDato = new ExperienciasBL();

            string m = unDato.eliminarExperiencias(Int32.Parse(lblId.Text));

            Response.Write("<script language=javascript>alert('" + m + "');</script>");
            Response.Write("<script language=javascript>document.location.href = 'FrmListarExperiencias.aspx';</script>");
        }
    }
}