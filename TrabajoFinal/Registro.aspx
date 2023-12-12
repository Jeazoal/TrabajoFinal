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
        <div class="input-box">
          <label>DNI o CE</label>
             <asp:TextBox ID="txtnumDocumento" runat="server" type="text" placeholder="Ingresa tu numero de Documento..." required></asp:TextBox>
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
                   <asp:DropDownList ID="DropDownList1" runat="server">
                       <asp:ListItem>Soltero</asp:ListItem>
                       <asp:ListItem>Casado</asp:ListItem>
                       <asp:ListItem>Viudo</asp:ListItem>
                       <asp:ListItem>Divorciado</asp:ListItem>
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
            <input  />
          </div>
        </div>

        <div class="input-box address">
          <label>Ubigeo</label>
          <div class="column">
            <div class="select-box">
              <select>
                
              </select>
            </div>
            <div class="select-box">
              <select>
                
              </select>
            </div>
            <div class="select-box">
              <select>

              </select>
            </div>
          </div>
          <input type="text" placeholder="Codigo Ubigeo..." required />
        </div>

        <label for="fileInput">Selecciona un archivo:</label>
        <input type="file" id="fileInput" name="archivo" accept=".jpg, .jpeg, .png">
        <button>Submit</button>
      </form>
    </section>
</body>
</html>


