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
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {

            DatosAcademicosBL unDato = new DatosAcademicosBL();

            string m = unDato.agregarDatos(new DatosAcademicos(txtCEstudios.Text, txtTitulo.Text, DateTime.Parse(txtFecha.Text), txtRuta.Text));

            Response.Write("<script language=javascript>alert('" + m + "');</script>");
            Response.Write("<script language=javascript>document.location.href = 'FrmListarDatosAcademicos.aspx';</script>");
        }
    }
}