<%@ Page Title="" Language="C#" MasterPageFile="~/PlantillaPaginasEmergentes.Master" AutoEventWireup="true" CodeBehind="RecuperarContrasena.aspx.cs" Inherits="TrabajoFinal.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Style/RecuperarForm.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="container">
        <h1>Recuperar Contraseña</h1>
         <p>Para continuar, primero debes verificar tu identidad.Ingresa tu correo electrónico con el que te registraste</p>
        
       <form>
            <asp:TextBox ID="txtgmail" runat="server" type="email" placeholder="Ingresa tu correo Electronico"></asp:TextBox>
             <asp:Button ID="btnIngresar" runat="server" style="margin-bottom: 0px" Text="Continuar" OnClick="btnIngresar_Click" />
       </form> 
       <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
       
       <div class="footer">
            <a href="#">Ayuda</a>
            <a href="#">Siguiente</a>
            <a href="#">Privacidad</a>
            <a href="#">Condiciones</a>
        </div>
    </div>
</asp:Content>
