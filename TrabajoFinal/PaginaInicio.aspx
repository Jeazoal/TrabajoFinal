<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaInicio.aspx.cs" Inherits="TrabajoFinal.PaginaInicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Portal | EducaNet</title>
    <!-- Google Fonts Link For Icons -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Material+Symbols+Rounded:opsz,wght,FILL,GRAD@48,400,0,0">
    <link rel="stylesheet" href="Style/Login.css">
    <script src="Scripts/script.js" defer></script>
</head>
<body>
    <header>
        <nav class="navbar">
            <span class="hamburger-btn material-symbols-rounded">menu</span>
            <a href="#" class="logo">
                <img src="Imagenes/logo.png" alt="logo">
                <h2>EducaNet</h2>
            </a>
            <ul class="links">
                <span class="close-btn material-symbols-rounded">close</span>
                <li><a href="#">Home</a></li>
                <li><a href="#">Oficinas</a></li>
                <li><a href="#">Reglamentos</a></li>
                <li><a href="#">Canales De Atencion</a></li>
            </ul>
            <button class="login-btn">LOG IN</button>
        </nav>
    </header>

    <div class="blur-bg-overlay"></div>
    <div class="form-popup">
        <span class="close-btn material-symbols-rounded">close</span>
        <div class="form-box login">
            <div class="form-details">
                <h2>Bienvenido de nuevo</h2>
                <p>Inicie sesión con su información personal para mantenerse conectado con nosotros.</p>
            </div>
            <div class="form-content">
                <h2>LOGIN</h2>
                <form id="form1" runat="server">
                    <div class="input-field">                       
                        <asp:TextBox ID="txtdni" runat="server" required></asp:TextBox>
                        <label>DNI</label>
                    </div>
                    <div class="input-field">
                        <asp:TextBox ID="txtcontraseña" runat="server" type="password" required></asp:TextBox>
                        <label>Contraseña</label>
                    </div>
                    <a href="#" class="forgot-pass-link">¿Has olvidado tu contraseña?</a>
                     <asp:Button ID="btnLogin" runat="server" OnClick="Button1_Click" Text="Ingresar" />
                    <div class="bottom-link">         
                   
                    ¿No tienes una cuenta?
                    <a href="#" id="signup-link">Registrarse</a>
                </div>
                </form>
            </div>
        </div>
    </div>
</body>
</html>
