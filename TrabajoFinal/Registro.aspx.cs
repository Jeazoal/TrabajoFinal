using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaDatos;
using CapaEntidades;
using Entidades;

namespace TrabajoFinal
{
    public partial class Registro : System.Web.UI.Page
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

                // Insertar el elemento "Seleccionar Provincia" al inicio
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

            // Mostrar el ID en el TextBox
            txtubigeo.Text = idDistrito;
        }

        protected void dplprovincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idProvincia = dplprovincia.SelectedValue;
            CargarDistritos(idProvincia);
            txtubigeo.Text = string.Empty;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los controles en tu formulario
                int tipoDocumentoId = Convert.ToInt32(dpltipodocumento.SelectedValue);
                string numeroDocumento = txtnumeroDocumento.Text;
                string apellidoPaterno = txtapepaterno.Text;
                string apellidoMaterno = txtapematerno.Text;
                string nombres = txtnombres.Text;
                string sexo = rbtmasculino.Checked ? "M" : (rbtfemenino.Checked ? "F" : string.Empty); // Asignar "M" si masculino, "F" si femenino
                int estadoCivilId = Convert.ToInt32(dplEstadoCivil.SelectedValue);
                string direccion = txtdireccion.Text;
                string ubigeo = $"{dplDepartamento.SelectedValue}{dplprovincia.SelectedValue}{dpldistrito.SelectedValue}";
                string discapacidad = rbtsi.Checked ? "Si" : (rbtno.Checked ? "No" : string.Empty); // Asignar "Si" si tiene discapacidad, "No" si no tiene
                string descripcionDiscapacidad = txtdiscpacidad.Text;
                string telefono = txttelefono.Text;
                string celular = txtcelular.Text;
                string correoElectronico = txtgmail.Text;
                string contrasena = txtcontrasena.Text;

                // Crear una instancia de la entidad DatosPersonales y asignar los valores
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
                    // Puedes agregar otros campos y asignar sus valores aquí
                };

                // Obtener la foto y convertirla a bytes
                byte[] fotoBytes = null;
                if (fileInput.HasFile)
                {
                    using (System.IO.Stream stream = fileInput.PostedFile.InputStream)
                    {
                        using (System.IO.BinaryReader reader = new System.IO.BinaryReader(stream))
                        {
                            fotoBytes = reader.ReadBytes((int)stream.Length);
                        }
                    }
                }

                // Asignar la foto a la entidad DatosPersonales
                datosPersonales.Foto = fotoBytes;

                // Llamar a la capa de negocio para realizar el registro
                RegistrarBL registrarBL = new RegistrarBL();
                registrarBL.RegistrarDatosPersonales(datosPersonales);

                // Aquí puedes agregar lógica adicional, como redireccionar a otra página o mostrar un mensaje de éxito
                Response.Write("Registro exitoso!");
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante el proceso de registro
                Response.Write("Error: " + ex.Message);
            }
        }
    }
}