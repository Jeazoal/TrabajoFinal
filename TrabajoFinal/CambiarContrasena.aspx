<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CambiarContrasena.aspx.cs" Inherits="TrabajoFinal.RecuperarContraseña" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Cambiar Contraseña</h2>
            <asp:Label ID="lblMensaje" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />
            <asp:Label ID="lblCorreoElectronico" runat="server" Text="Correo Electrónico:"></asp:Label>
            <asp:TextBox ID="txtCorreoElectronico" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblNuevaContrasena" runat="server" Text="Nueva Contraseña:"></asp:Label>
            <asp:TextBox ID="txtNuevaContrasena" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="btnCambiarContrasena" runat="server" Text="Cambiar Contraseña" OnClick="btnCambiarContrasena_Click" />
        </div>
    </form>
</body>
</html>
