using CapaDatos;
using CapaEntidades;
using CapaNegocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoFinal
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDepartamentos();
                CargarTiposDocumento();
                CargarEstadosCiviles();

                if (Session["UsuarioAutenticado"] != null)
                {
                    DatosPersonales usuarioAutenticado = (DatosPersonales)Session["UsuarioAutenticado"];
                    MostrarInformacionUsuario(usuarioAutenticado);
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        private void MostrarInformacionUsuario(DatosPersonales usuario)
        {
            string rutaRelativa = "~/Fotos/" + Path.GetFileName(usuario.Foto);

            string urlImagen = ResolveUrl(rutaRelativa);

            txtnombres.Text = usuario.Nombres;
            txtnumeroDocumento.Text = usuario.NumeroDocumento;
            txtgmail.Text = usuario.CorreoElectronico;
            txtapematerno.Text = usuario.ApellidoMaterno;
            txtapepaterno.Text = usuario.ApellidoPaterno;
            txtcelular.Text = usuario.Celular;
            txttelefono.Text = usuario.Telefono;
            txtdireccion.Text = usuario.Direccion;
            txtDiscapacidad.Text = usuario.DescripcionDiscapacidad;
            txtubigeo.Text = usuario.Ubigeo;
         
            if (usuario.Sexo == "M")
            {
                rbtMasculino.Checked = true;
            }
            else if (usuario.Sexo == "F")
            {
                rbtFemenino.Checked = true;
            }


            if (usuario.Discapacidad == "Si")
            {
                rbtsi.Checked = true;
            }
            else if (usuario.Discapacidad == "No")
            {
                rbtno.Checked = true;
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
            string codigoubigeo = dpldistrito.SelectedValue;
            ActualizarUbigeo();

        }

        private void ActualizarUbigeo()
        {
            string ubigeocode = dpldistrito.SelectedValue;

            txtubigeo.Text = "";
            txtubigeo.Text = ubigeocode;
        }

        protected void dplprovincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idProvincia = dplprovincia.SelectedValue;
            CargarDistritos(idProvincia);
        }

        protected void rbtsi_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        protected void rbtno_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        protected void rbt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtsi.Checked)
            {
                txtDiscapacidad.Enabled = true;
            }
            else if (rbtno.Checked)
            {
                txtDiscapacidad.Enabled = false;
                txtDiscapacidad.Text = "No tengo Discapacidad";
            }
        }

        protected void chkubigeo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkubigeo.Checked)
            {
                dplDepartamento.Enabled = true;
                dpldistrito.Enabled = true;
                dplprovincia.Enabled = true;
            }
            else
            {
                dplDepartamento.Enabled = false;
                dpldistrito.Enabled = false;
                dplprovincia.Enabled = false;
            }
        }



        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DatosPersonales datosActualizados = new DatosPersonales
                {
                    TipoDocumentoId = Convert.ToInt32(dpltipodocumento.SelectedValue),
                    NumeroDocumento = txtnumeroDocumento.Text,
                    ApellidoPaterno = txtapepaterno.Text,
                    ApellidoMaterno = txtapematerno.Text,
                    Nombres = txtnombres.Text,
                    Sexo = rbtMasculino.Checked ? "M" : "F",
                    EstadoCivilId = Convert.ToInt32(dplEstadoCivil.SelectedValue),
                    Direccion = txtdireccion.Text,
                    Ubigeo = txtubigeo.Text,
                    Discapacidad = rbtsi.Checked ? "Si" : (rbtno.Checked ? "No" : null),
                    DescripcionDiscapacidad = txtDiscapacidad.Text,
                    Telefono = txttelefono.Text,
                    Celular = txtcelular.Text,
                    CorreoElectronico = txtgmail.Text,
                };


                ActualizarBL actualizarBL = new ActualizarBL();


                actualizarBL.ActualizarDatosPersonales(datosActualizados);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar datos personales: " + ex.Message);
            }
        }
    }
}