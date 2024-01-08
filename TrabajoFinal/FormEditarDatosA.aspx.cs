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
    public partial class Formulario_web115 : System.Web.UI.Page
    {
        DatosAcademicosBL unDatoBL = new DatosAcademicosBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DatosAcademicos unDato = new DatosAcademicos();
                lblId.Text = Request.QueryString["id"];
                unDato = unDatoBL.buscarDatos(Int32.Parse(lblId.Text));

                    txtTitulo.Text = unDato.TituloGrado;
                    txtCEstudios.Text = unDato.CentroEstudios;
                    txtFecha.Text = unDato.FechaGrado.ToString("yyyy-MM-dd");
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            DatosAcademicosBL unDato = new DatosAcademicosBL();

            string m = unDato.actualizarDatos(new DatosAcademicos
            {
                ID = Int32.Parse(lblId.Text),
                CentroEstudios = txtCEstudios.Text,
                TituloGrado = txtTitulo.Text,
                FechaGrado = DateTime.Parse(txtFecha.Text)
            });

            Response.Write("<script language=javascript>alert('" + m + "');</script>");
            Response.Write("<script language=javascript>document.location.href = 'FormListarDatosA.aspx';</script>");
        }
    }
}