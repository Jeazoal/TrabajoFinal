using CapaDatos;
using CapaEntidades;
using CapaNegocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoFinal
{
    public partial class RegistrarDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if (!IsPostBack)
            {
                if (!IsPostBack)
                {
                    CargarDepartamentos();
                    CargarTiposDocumento();
                    CargarEstadosCiviles();
                }

            }
        }

        private void CargarDepartamentos()
        {
            try
            {
                DepartamentoDAL departamentoDAL = new DepartamentoDAL();
                List<Departamento> departamentos = departamentoDAL.ObtenerDepartamentos();
                dplDepartamento.DataSource = departamentos;
                dplDepartamento.DataTextField = "Nombre";
                dplDepartamento.DataValueField = "Id";
                dplDepartamento.DataBind();
                dplDepartamento.Items.Insert(0, new System.Web.UI.WebControls.ListItem("Seleccionar Departamento", "0"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar departamentos: " + ex.Message);
            }
        }

        private void CargarProvincias(string idDepartamento)
        {
            try
            {
                ProvinciaBL provinciaBL = new ProvinciaBL();
                List<Provincia> provincias = provinciaBL.ObtenerProvinciasPorDepartamento(idDepartamento);

                dplprovincia.DataSource = provincias;
                dplprovincia.DataTextField = "Nombre";
                dplprovincia.DataValueField = "Id";
                dplprovincia.DataBind();

                dplprovincia.Items.Insert(0, new System.Web.UI.WebControls.ListItem("Seleccionar Provincia", "0"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar provincias: " + ex.Message);
            }
        }


        protected void CargarDistritos(string provinciaId)
        {
            DistritoBL distritoBL = new DistritoBL();
            List<Distrito> distritos = distritoBL.ObtenerDistritos(provinciaId);

            dpldistrito.DataSource = distritos;
            dpldistrito.DataTextField = "Nombre";
            dpldistrito.DataValueField = "Id";  // Ajusta esto según la propiedad en tu clase Distrito que contiene el ID del distrito
            dpldistrito.DataBind();
            dpldistrito.Items.Insert(0, new System.Web.UI.WebControls.ListItem("Seleccionar Distrito", "0"));
        }

        protected void CargarTiposDocumento()
        {
            TipoDocumentoBL tipoDocumentoBL = new TipoDocumentoBL();
            List<TipoDocumento> tiposDocumento = tipoDocumentoBL.ListarDocumentos();

            dpltipodocumento.DataSource = tiposDocumento;
            dpltipodocumento.DataTextField = "NombreDocumento";
            dpltipodocumento.DataValueField = "Id";
            dpltipodocumento.DataBind();
        }

        private void CargarEstadosCiviles()
        {
            try
            {
                EstadoCBL estadoCBL = new EstadoCBL();
                List<EstadoC> estadosCiviles = estadoCBL.ListarEstadosCiviles();

                dplEstadoCivil.DataSource = estadosCiviles;
                dplEstadoCivil.DataTextField = "EstadoCivil";
                dplEstadoCivil.DataValueField = "Id";
                dplEstadoCivil.DataBind();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar estados civiles: " + ex.Message);
            }
        }


        protected void dplDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idDepartamento = dplDepartamento.SelectedValue;
            CargarProvincias(idDepartamento);
        }

        protected void dpldistrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idDistrito = dpldistrito.SelectedValue;


        }

        protected void dplprovincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idProvincia = dplprovincia.SelectedValue;
            CargarDistritos(idProvincia);
        }


        protected void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (fileInput.HasFile)
                {
                    // Obtiene el nombre del archivo
                    string nombreArchivo = fileInput.FileName;

                    // Guarda el archivo en una ubicación específica en el servidor
                    string rutaGuardar = Server.MapPath("~/Fotos/" + nombreArchivo);
                    fileInput.SaveAs(rutaGuardar);
                    int tipoDocumentoId = Convert.ToInt32(dpltipodocumento.SelectedValue);
                    string numeroDocumento = txtnumeroDocumento.Text;
                    string apellidoPaterno = txtapepaterno.Text;
                    string apellidoMaterno = txtapematerno.Text;
                    string nombres = txtnombres.Text;
                    string sexo = rbtmasculino.Checked ? "M" : (rbtfemenino.Checked ? "F" : string.Empty); // Asignar "M" si masculino, "F" si femenino
                    int estadoCivilId = Convert.ToInt32(dplEstadoCivil.SelectedValue);
                    string direccion = txtdireccion.Text;
                    string ubigeo = dpldistrito.SelectedValue;
                    string discapacidad = rbtsi.Checked ? "Si" : (rbtno.Checked ? "No" : string.Empty); // Asignar "Si" si tiene discapacidad, "No" si no tiene
                    string descripcionDiscapacidad = txtdiscpacidad.Text;
                    string telefono = txttelefono.Text;
                    string celular = txtcelular.Text;
                    string correoElectronico = txtgmail.Text;
                    string contrasena = txtcontrasena.Text;
                    string foto = rutaGuardar;
                DatosPersonales datosPersonales = new DatosPersonales
                {
                    TipoDocumentoId = tipoDocumentoId,
                    NumeroDocumento = numeroDocumento,
                    ApellidoPaterno = apellidoPaterno,
                    ApellidoMaterno = apellidoMaterno,
                    Nombres = nombres,
                    Sexo = sexo,
                    EstadoCivilId = estadoCivilId,
                    Direccion = direccion,
                    Ubigeo = ubigeo,
                    Discapacidad = discapacidad,
                    DescripcionDiscapacidad = descripcionDiscapacidad,
                    Telefono = telefono,
                    Celular = celular,
                    CorreoElectronico = correoElectronico,
                    Contrasena = contrasena,
                    Foto = foto,
                };
                    RegistrarBL registrarBL = new RegistrarBL();
                    registrarBL.RegistrarDatosPersonales(datosPersonales);

                    Response.Redirect("Login.aspx");

                }
                else
                {
                    // Mensaje si no se seleccionó ningún archivo
                    Response.Write("<script language=javascript>alert('Seleccione un archivo Png, jpg');</script>");
                }

                
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "showAlert", $"alert('Error durante el registro: {ex.Message}');", true);

            }
        }

        protected void rbtsi_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void rbtno_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}