<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TrabajoFinal.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
         <link rel="stylesheet" href="Style/Login.css" />
   <link href='https://unpkg.com/boxicons@2.1.4/css/boxicons.min.css' rel='stylesheet'>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
   
<body>
    <form id="form1" runat="server">
        <div class="Content">
            <div class="Home-left">         
            </div>
            <div class="Home-right">         
                <div>
                   <h1>EDUC<i class='bx bxs-flame'></i>NET</h1>                 
                </div>
                <h2>Bienvenido Al Portal Docente!</h2>
                <p>Inicia Sesion con tu número de Usuario</p>
                 <asp:TextBox ID="txtdni" runat="server" placeholder="Ingresa tu usuario" required></asp:TextBox>
               <asp:TextBox ID="txtcontraseña" runat="server" type="password" placeholder="Ingresa tu contraseña" required></asp:TextBox>
                <asp:Button ID="btnLogin" runat="server" Text="Iniciar Sesión" BorderStyle="None" OnClick="btnLogin_Click" />
                <div class="div-link">¿No tiene una cuenta? <a href="RegistrarDatos.aspx">Registrate Aquí</a></div>
                <div class="div-link">¿Olvidaste tu Contraseña? <a href="RecuperarContrasena.aspx">Ingrese Aquí</a></div>              
            </div>
        </div>
    </form>
     <script src="Scripts/Loginportal.js"></script>
</body>
</html>
