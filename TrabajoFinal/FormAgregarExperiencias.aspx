<%@ Page Title="" Language="C#" MasterPageFile="~/PlantillaForm.Master" AutoEventWireup="true" CodeBehind="FormAgregarExperiencias.aspx.cs" Inherits="TrabajoFinal.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link rel="stylesheet" href="Style/ContentFomr.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Agregar Experiencias</h1>
    <div>
            <asp:Label ID="Label3" runat="server" Text="Experiencias"></asp:Label></> 
    </div>
    <div>
             <asp:Label ID="Label1" runat="server" Text="Fecha de Inicio"></asp:Label>
    </div>
    <div>
            <asp:TextBox ID="txtFechaInicio" type="date" runat="server"></asp:TextBox>
    </div>
    <div>
            <asp:Label ID="Label2" runat="server" Text="Fecha de Fin"></asp:Label>
    </div>
    <div>
            <asp:TextBox ID="txtFechaFin" type="date" runat="server"></asp:TextBox>
    </div>
    <div>
            <asp:Label ID="Label4" runat="server" Text="Cargo"></asp:Label>
    </div>
    <div>
            <asp:TextBox ID="txtCargo" runat="server"></asp:TextBox>
    </div>
    <div>
            <asp:Label ID="Label6" runat="server" Text="Nombre de la Empresa"></asp:Label>
    </div>
    <div>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    </div>
    <div>
            <asp:Label ID="Label5" runat="server" Text="Subir Certificado"></asp:Label>
    </div>
    <div>
            <asp:FileUpload ID="fuCargar" runat="server" />
    </div>
    <asp:Button ID="btnAgregar" runat="server" Text="Agregar Experiencias" OnClick="btnAgregar_Click" />
</asp:Content>
