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

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (fuCargar.HasFile)
            {
                // Obtiene el nombre del archivo
                string nombreArchivo = fuCargar.FileName;

                // Guarda el archivo en una ubicación específica en el servidor
                string rutaGuardar = Server.MapPath("~/Experiencias/" + nombreArchivo);
                fuCargar.SaveAs(rutaGuardar);

                // Resto de tu lógica para agregar datos académicos a la base de datos
                ExperienciasBL unDato = new ExperienciasBL();
                string m = unDato.agregarExperiencias(new Experiencias(DateTime.Parse(txtFechaInicio.Text),
                DateTime.Parse(txtFechaFin.Text),
                txtCargo.Text,
                txtNombre.Text,
                rutaGuardar));
                Response.Write("<script language=javascript>alert('" + m + "');</script>");
                Response.Write("<script language=javascript>document.location.href = 'FormListarExperiencias.aspx';</script>");
            }
            else
            {
                // Mensaje si no se seleccionó ningún archivo
                Response.Write("<script language=javascript>alert('Seleccione un archivo PDF');</script>");
                
            }
        }
    }
}