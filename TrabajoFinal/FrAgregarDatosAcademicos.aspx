<%@ Page Title="" Language="C#" MasterPageFile="~/PlantillaPaginasEmergentes.Master" AutoEventWireup="true" CodeBehind="FrAgregarDatosAcademicos.aspx.cs" Inherits="TrabajoFinal.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet" href="Style/RecuperarForm.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
      <h1>Agregar Datos Academicos</h1>     
     <form>
           <div class="col-4"><asp:Label ID="Label1" runat="server" Text="Titulo Grado Obtenido"></asp:Label></div>
<div class="col-4"><asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox></div>
        <div class="col-4"><asp:Label ID="Label2" runat="server" Text="Centro de Estudios"></asp:Label></div>
 <div class="col-4"><asp:TextBox ID="txtCEstudios" runat="server"></asp:TextBox></div>
          <div class="col-4"><asp:Label ID="Label4" runat="server" Text="Fecha de Grado de Estudio"></asp:Label></div>
<div class="col-4"><asp:TextBox ID="txtFecha" type="date" runat="server"></asp:TextBox> </div>
          <div class="col-4"><asp:Label ID="Label5" runat="server" Text="Subir Titulo"></asp:Label></div>
<div class="col-4"><asp:FileUpload ID="fuCargar" runat="server" /></div>
             <div class="col-4">
<div class="col-4"><asp:TextBox ID="txtRuta" runat="server"></asp:TextBox></div>
                    <asp:Button ID="btnActualizar" runat="server" Text="Agregar Datos Academicos" OnClick="btnActualizar_Click" />
     </form> 
     <br />
     <br />     
     <div class="footer">
          <a href="#">Ayuda</a>
          <a href="#">Siguiente</a>
          <a href="#">Privacidad</a>
          <a href="#">Condiciones</a>
      </div>
  </div>
</asp:Content>
