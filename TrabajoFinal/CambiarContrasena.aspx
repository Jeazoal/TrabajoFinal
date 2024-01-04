<%@ Page Title="" Language="C#" MasterPageFile="~/PlantillaPaginasEmergentes.Master" AutoEventWireup="true" CodeBehind="CambiarContrasena.aspx.cs" Inherits="TrabajoFinal.Formulario_web13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet" href="Style/RecuperarForm.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
     <h1>Recuperar Contraseña</h1>
      <p>Para continuar, primero debes verificar tu identidad.Ingresa tu correo electrónico con el que te registraste</p>   
         <asp:Label ID="lblCorreoElectronico" runat="server" Text="Correo Electrónico:"></asp:Label>
         <asp:TextBox ID="txtCorreoElectronico" runat="server" placeholder="Ingresa tu correo Electronico"></asp:TextBox>
         <asp:Label ID="lblNuevaContrasena" runat="server" Text="Nueva Contraseña:"></asp:Label>
         <asp:TextBox ID="txtNuevaContrasena" runat="server" TextMode="Password" placeholder="Ingresa nueva contraseña"></asp:TextBox>
         <asp:Button ID="btnCambiarContrasena" runat="server" Text="Cambiar Contraseña" OnClick="btnCambiarContrasena_Click" />
    <br />
     <asp:Label ID="lblMensaje" runat="server" ForeColor="#33CC33"></asp:Label>
    
    <div class="footer">
         <a href="#">Ayuda</a>
         <a href="#">Siguiente</a>
         <a href="#">Privacidad</a>
         <a href="#">Condiciones</a>
     </div>
 </div>
</asp:Content>
