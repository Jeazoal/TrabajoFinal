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
    public partial class Formulario_web14 : System.Web.UI.Page
    {
        ExperienciasBL unExperienciaBL = new ExperienciasBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ExperienciasBL unExperienciaBL = new ExperienciasBL();
                lblId.Text = Request.QueryString["id"];

                Experiencias unaExperiencia = unExperienciaBL.buscarExperiencias(Int32.Parse(lblId.Text));

                if (unaExperiencia != null)
                {
                    txtFechaInicio.Text = unaExperiencia.FechaInicio.ToString("yyyy-MM-dd");
                    txtFechaFin.Text = unaExperiencia.FechaFin.ToString("yyyy-MM-dd");
                    txtCargo.Text = unaExperiencia.Cargo;
                    txtNombre.Text = unaExperiencia.NombreEmpresa;
               
                }
            }

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            ExperienciasBL unDato = new ExperienciasBL();

            string m = unDato.ActualizarExperiencias(new Experiencias
            {
                ID = Int32.Parse(lblId.Text),
                FechaInicio = DateTime.Parse(txtFechaInicio.Text),
                FechaFin = DateTime.Parse(txtFechaFin.Text),
                Cargo = txtCargo.Text,
                NombreEmpresa = txtNombre.Text
            });

            Response.Write("<script language=javascript>alert('" + m + "');</script>");
            Response.Write("<script language=javascript>document.location.href = 'FormListarExperiencias.aspx';</script>");
        }
    }
}