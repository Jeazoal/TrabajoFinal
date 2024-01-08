<%@ Page Title="" Language="C#" MasterPageFile="~/PlantillaForm.Master" AutoEventWireup="true" CodeBehind="FormAgregarDatosA.aspx.cs" Inherits="TrabajoFinal.Formulario_web114" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Style/ContentForm.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         
              <h1>Agregar Datos Academicos</h1>     
      <div><asp:Label ID="Label1" runat="server" Text="Titulo Grado Obtenido"></asp:Label></div>
       <div><asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox></div>
               <div ><asp:Label ID="Label2" runat="server" Text="Centro de Estudios"></asp:Label></div>
        <div ><asp:TextBox ID="txtCEstudios" runat="server"></asp:TextBox></div>
                 <div ><asp:Label ID="Label4" runat="server" Text="Fecha de Grado de Estudio"></asp:Label></div>
       <div ><asp:TextBox ID="txtFecha" type="date" runat="server"></asp:TextBox> </div>
                 <div ><asp:Label ID="Label5" runat="server" Text="Subir Titulo"></asp:Label></div>
       <div ><asp:FileUpload ID="fuCargar" runat="server" /></div>
       <asp:Button ID="btnAgregar" runat="server" Text="Agregar Datos Academicos" OnClick="btnAgregar_Click" />

     
</asp:Content>
