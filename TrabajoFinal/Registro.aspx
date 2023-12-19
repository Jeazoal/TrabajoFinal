<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="TrabajoFinal.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="Style/Registrar.css" />
    <title></title>
</head>
<body>
    <section class="container">
      <header>Registrate en EducaNet</header>
      <form id="form1" runat="server" action="#" class="form">
          <div class="input-box address">
        <label>Numeró de Documento</label>
        <div class="column">
              <div class="select-box"">
                   <asp:DropDownList ID="dpltipodocumento"  AutoPostBack="true" runat="server">
                    </asp:DropDownList>
              </div>  
               <asp:TextBox ID="txtnumeroDocumento" runat="server" type="text" placeholder="Numero De Documento ..." required></asp:TextBox>
          </div>
        </div>      
          <div class="input-box address">
  <label>Ubigeo</label>
  <div class="column">
    <div class="select-box">
      <asp:DropDownList ID="dplDepartamento" runat="server" OnSelectedIndexChanged="dplDepartamento_SelectedIndexChanged" AutoPostBack="true" ></asp:DropDownList>
    </div>
    <div class="select-box">
      <asp:DropDownList ID="dplprovincia" runat="server" OnSelectedIndexChanged="dplprovincia_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
    </div>
    <div class="select-box">
      <asp:DropDownList ID="dpldistrito" runat="server" OnSelectedIndexChanged="dpldistrito_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
    </div>
  </div>
              <div class="input-box">
  <label>Codigo Ubigeo:</label>
    <asp:TextBox ID="txtubigeo" runat="server" type="text" placeholder="Codigo Ubigeo..." required></asp:TextBox>
</div>
</div>
        <div class="input-box">
          <label>Nombres</label>
            <asp:TextBox ID="txtnombres" runat="server" type="text" placeholder="Ingresa tus nombres..." required></asp:TextBox>
        </div>
        <div class="input-box">
          <label>Gmail</label>
          <asp:TextBox ID="txtgmail" runat="server" type="email" placeholder="Ingresa tu gmail..." required></asp:TextBox>
        </div>
        <div class="input-box">
          <label>Contraseña</label>
            <asp:TextBox ID="txtcontrasena" runat="server" type="password" placeholder="Ingresa tu Contraseña..." required></asp:TextBox>
        </div>
        <div class="column">
          <div class="input-box">
            <label>Apellido Paterno</label>
            <asp:TextBox ID="txtapepaterno" runat="server" type="text" placeholder="Ingresa tu apellido..." required></asp:TextBox>
          </div>
          <div class="input-box">
            <label>Apellido Materno</label>
            <asp:TextBox ID="txtapematerno" runat="server" type="text" placeholder="Ingresa tu apellido..." required></asp:TextBox>
          </div>
        </div>
          <div class="input-box">
              <label>Direccion</label>
              <asp:TextBox ID="txtdireccion" runat="server" type="text" placeholder="Ingresa tus nombres..." required></asp:TextBox>
          </div>
        <div class="gender-box">
          <h3>Genero</h3>
          <div class="gender-option">
            <div class="gender">
              <asp:RadioButton ID="rbtmasculino" GroupName="sexo" runat="server"  name="gender"/>
                <label for="check-male">Masculino</label>
            </div>
            <div class="gender">
                <asp:RadioButton ID="rbtfemenino" GroupName="sexo" runat="server"  name="gender"/>
              <label for="check-female">Femenino</label>
            </div>
          </div>
        </div>
        <div class="input-box address">
          <label>Estado Civil</label>
          <div class="column">
              <div class="select-box"">
                   <asp:DropDownList ID="dplEstadoCivil" AutoPostBack="true" runat="server">                 
                    </asp:DropDownList>
              </div>         
          </div>
        </div>
        <div class="column">
          <div class="input-box">
            <label>Numero De Telefono</label>
              <asp:TextBox ID="txttelefono" runat="server" type="number" placeholder="Ingresa tu numero de Telefono" required ></asp:TextBox>
          </div>
          <div class="input-box">
            <label>Numero De Celular</label>
              <asp:TextBox ID="txtcelular" runat="server" type="number" placeholder="Ingresa tu numero de Celular" required ></asp:TextBox>     
          </div>
        </div>
          <div class="gender-box">
              <h3>¿Cuentá con alguna Discapacidad?</h3>
              <div class="gender-option">
                  <div class="gender">
                      <asp:RadioButton ID="rbtsi" GroupName="discapacidad" runat="server" name="gender" />
                      <label for="check-male">Si</label>
                  </div>
                  <div class="gender">
                      <asp:RadioButton ID="rbtno" GroupName="discapacidad" runat="server" name="gender" />
                      <label for="check-female">No</label>
                  </div>
              </div>
          </div>
          <div class="column">
              <div class="input-box">
                  <label>Describa su Discapacidad</label>
                  <asp:TextBox ID="txtdiscpacidad" runat="server" type="text" placeholder="Ingresa tu numero de Celular" required></asp:TextBox>
              </div>
          </div>
           <div class="input-box">
            <label for="fileInput">Selecciona una foto:</label>
            <asp:FileUpload ID="fileInput" runat="server" />
        </div>

&nbsp;<asp:Button ID="btnregistrar" runat="server" Text="Button" OnClick="Button1_Click" />
      </form>
    </section>
</body>
</html>


