<%@ Page Title="" Language="C#" MasterPageFile="~/PlantillaForm.Master" AutoEventWireup="true" CodeBehind="FormEditarDatosA.aspx.cs" Inherits="TrabajoFinal.Formulario_web115" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Style/FormContent.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <h1>Editar Datos Academicos</h1>
             <asp:Label ID="lblId" runat="server" Text="Nombre Compañia" ForeColor="#000066"></asp:Label>
                <asp:Label ID="Label6" runat="server" Text="ID Compañia"></asp:Label>
     <div ><asp:Label ID="Label1" runat="server" Text="Titulo Grado Obtenido"></asp:Label></div>
    <div ><asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox></div>

     <div><asp:Label ID="Label2" runat="server" Text="Centro de Estudios"></asp:Label></div>
    <div ><asp:TextBox ID="txtCEstudios" runat="server"></asp:TextBox></div>
     <div><asp:Label ID="Label4" runat="server" Text="Fecha de Grado de Estudio"></asp:Label></div>
        <asp:TextBox ID="txtFecha" type="date" runat="server"></asp:TextBox>
  <div><asp:Label ID="Label5" runat="server" Text="Subir Certificado"></asp:Label></div>
 <div class="file" ><asp:FileUpload ID="fuCargar" runat="server" /></div>
         <asp:TextBox ID="txtRuta" runat="server"></asp:TextBox>

        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar Datos Academicos" OnClick="btnActualizar_Click"/>

</asp:Content>
