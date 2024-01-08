<%@ Page Title="" Language="C#" MasterPageFile="~/PlantillaForm.Master" AutoEventWireup="true" CodeBehind="FormEliminarDatosA.aspx.cs" Inherits="TrabajoFinal.Formulario_web116" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link rel="stylesheet" href="Style/ContentFomr.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                <asp:Label ID="lblId" runat="server" Text="Nombre Compañia" ForeColor="#000066"></asp:Label>
               <asp:Label ID="Label6" runat="server" Text="ID Compañia"></asp:Label>
    <div ><asp:Label ID="Label1" runat="server" Text="Titulo Grado Obtenido"></asp:Label></div>
   <div ><asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox></div>

    <div><asp:Label ID="Label2" runat="server" Text="Centro de Estudios"></asp:Label></div>
   <div ><asp:TextBox ID="txtCEstudios" runat="server"></asp:TextBox></div>
    <div><asp:Label ID="Label4" runat="server" Text="Fecha de Grado de Estudio"></asp:Label></div>
       <asp:TextBox ID="txtFecha" type="date" runat="server"></asp:TextBox>
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar Datos Academicos" OnClick="btnEliminar_Click" />
</asp:Content>
