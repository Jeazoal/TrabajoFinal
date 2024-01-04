<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarDatos.aspx.cs" Inherits="TrabajoFinal.RegistrarDatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <link rel="stylesheet" href="Style/PaginaRegistrar.css">
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v4.0.0/css/line.css">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <div class="container">
        <header>Registrar</header>
        <form id="form1" runat="server">
                <div class="form first">
                    <div class="details personal">
                        <span class="title">Datos Personales</span>
                        <div class="fields">
                            <div class="input-field">
                                <label>Nombres</label>
                                <asp:TextBox ID="txtnombres" runat="server" type="text" placeholder="Ingresa tus nombres..." required></asp:TextBox>
                            </div>

                            <div class="input-field">
                                <label>Apellido Paterno</label>
                                <asp:TextBox ID="txtapepaterno" runat="server" type="text" placeholder="Ingresa tu apellido..." required></asp:TextBox>
                            </div>

                            <div class="input-field">
                                <label>Apellido Materno</label>
                                <asp:TextBox ID="txtapematerno" runat="server" type="text" placeholder="Ingresa tu apellido..." required></asp:TextBox>
                            </div>

                            <div class="input-field">
                                <label>Estado Civil</label>
                                <asp:DropDownList ID="dplEstadoCivil" AutoPostBack="true" runat="server">
                                </asp:DropDownList>
                            </div>
                            <div class="input-field">
                                <label>Genero</label>
                                <div class="rbtinput">
                                    <div class="item-rbt">
                                        <asp:RadioButton ID="rbtmasculino" GroupName="sexo" runat="server"  name="gender"/>
                                    <label for="check-male">Masculino</label>
                                    </div>
                                     <div class="item-rbt">
                                          <asp:RadioButton ID="rbtfemenino" GroupName="sexo" runat="server"  name="gender"/>
                                           <label for="check-female">Femenino</label>
                                    </div>                                   
                                </div>                     
                            </div>
                            <div class="input-field">
                                <label>Direccion</label>
                                <asp:TextBox ID="txtdireccion" runat="server" type="text" placeholder="Ingresa tus nombres..." required></asp:TextBox>
                            </div>
                            <div class="input-field">
                                <label>Tipo De Documento</label>
                                <asp:DropDownList ID="dpltipodocumento" AutoPostBack="true" runat="server">
                                </asp:DropDownList>
                            </div>
                            <div class="input-field">
                                <label>Número De Docúmento</label>
                                <asp:TextBox ID="txtnumeroDocumento" runat="server" type="text" placeholder="Numero De Documento ..." required></asp:TextBox>
                            </div>
                        </div>

                    </div>

                    <div class="details ID">
                        <span class="title">Ubigeo</span>

                        <div class="fields">

                            <div class="input-field">
                                <label>Departamento</label>
                      <asp:DropDownList ID="dplDepartamento" runat="server" OnSelectedIndexChanged="dplDepartamento_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></asp:DropDownList>
                            </div>

                            <div class="input-field">
                                <label>Provincia</label>
                      <asp:DropDownList ID="dplprovincia" runat="server" OnSelectedIndexChanged="dplprovincia_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                </asp:DropDownList>
                            </div>

                            <div class="input-field">
                                    <label>Distrito</label>
                      <asp:DropDownList ID="dpldistrito" runat="server" OnSelectedIndexChanged="dpldistrito_SelectedIndexChanged" AutoPostBack="true" requi></asp:DropDownList>
                                    </asp:DropDownList>
                                </div>
                        </div>
                        <div class="details address">
                            <span class="title">Datos de Usuario</span>

                            <div class="fields">
                                <div class="input-field">
                                    <label>Gmail</label>
                                    <asp:TextBox ID="txtgmail" runat="server" type="email" placeholder="Ingresa tu gmail..."></asp:TextBox>
                                </div>

                                <div class="input-field">
                                    <label>Contraseña</label>
                                    <asp:TextBox ID="txtcontrasena" runat="server" type="password" placeholder="Ingresa tu Contraseña..." required></asp:TextBox>
                                </div>

                                <div class="input-field">
                                    <label>Número De Telefono</label>
                                    <asp:TextBox ID="txttelefono" runat="server" type="number" placeholder="Ingresa tu numero de Telefono" required></asp:TextBox>
                                </div>

                                <div class="input-field">
                                    <label>Número De Celular</label>
                                    <asp:TextBox ID="txtcelular" runat="server" type="number" placeholder="Ingresa tu numero de Celular" required></asp:TextBox>
                                </div>

                                   <div class="input-field">
                                       <label>¿Cuentá Con Discapacidad?</label>
                                       <div class="rbtinput">
                                           <div class="item-rbt">
                                               <asp:RadioButton ID="rbtsi" GroupName="discapacidad" runat="server" name="gender" />
 <label for="check-male">Si</label>
                                           </div>
                                            <div class="item-rbt">
                                                 <asp:RadioButton ID="rbtno" GroupName="discapacidad" runat="server" name="gender" />
  <label for="check-female">No</label>
                                           </div>                                   
                                       </div>                     
                                   </div>
                                <div class="input-field">
                                    <label>Describa su Discapacidad</label>
                                    <asp:TextBox ID="txtdiscpacidad" runat="server" type="text" placeholder="Ingresa tu numero de Celular" required></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="details family">
                            <span class="title">Sube tu Foto</span>
                                     <label for="fileInput">Selecciona una foto:</label>
                                    <asp:FileUpload ID="fileInput" runat="server" />                          
                        </div>
                         <asp:Button ID="btnregistrar" runat="server" Text="Ingresar Datos" OnClick="btnregistrar_Click" />
                    </div>
                    </div>
        </form>
    </div>
</body>
</html>
