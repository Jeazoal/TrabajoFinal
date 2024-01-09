    <%@ Page Title="" Language="C#" MasterPageFile="~/PlantillaForm.Master" AutoEventWireup="true" CodeBehind="FormEditarPerfil.aspx.cs" Inherits="TrabajoFinal.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <link rel="stylesheet" href="Style/PerfilForm.css" /></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container">
                <h1>Perfil</h1>
    <label>Nombres</label><br />
            <asp:TextBox ID="txtnombres" runat="server" type="text" placeholder="Ingresa tus nombres..." required></asp:TextBox><br />
    <label>Apellido Paterno</label><br />
    <asp:TextBox ID="txtapepaterno" runat="server" type="text" placeholder="Ingresa tu apellido..." required></asp:TextBox><br />
    <label>Apellido Materno</label><br />
    <asp:TextBox ID="txtapematerno" runat="server" type="text" placeholder="Ingresa tu apellido..." required></asp:TextBox><br />
    <label>Estado Civil</label><br />
                <asp:DropDownList ID="dplEstadoCivil" AutoPostBack="true" runat="server">
                </asp:DropDownList><br />
 
        <label>Genero</label><br />           
             <div class="radio-group">
                 <label>Masculino</label>
                 <asp:RadioButton ID="rbtMasculino" CssClass="rbt-sexo" GroupName="sexo" runat="server" />
                 <label>Femenino</label>   
                 <asp:RadioButton ID="rbtFemenino" CssClass="rbt-sexo" GroupName="sexo" runat="server" />
                 </div>    
    <label>Direccion</label><br />
    <asp:TextBox ID="txtdireccion" runat="server" type="text" placeholder="Ingresa tus nombres..." required></asp:TextBox><br />
    <label>Tipo De Documento</label><br />
                <asp:DropDownList ID="dpltipodocumento" AutoPostBack="true" runat="server">
                </asp:DropDownList><br />
    <label>Número De Docúmento</label><br />
    <asp:TextBox ID="txtnumeroDocumento" runat="server" type="text" placeholder="Numero De Documento ..." required Enabled="False"></asp:TextBox><br />
    <label>Ubigeo</label><br />
<asp:TextBox ID="txtubigeo" runat="server" type="text" placeholder="" required Enabled="False"></asp:TextBox> 
<label>¿Quieres Editar Tu ubigeo?</label>
<asp:CheckBox ID="chkubigeo" runat="server" AutoPostBack="True" OnCheckedChanged="chkubigeo_CheckedChanged" />
            <label>Departamento</label><br />
                <asp:DropDownList ID="dplDepartamento" runat="server" OnSelectedIndexChanged="dplDepartamento_SelectedIndexChanged" AutoPostBack="true" Enabled="False"></asp:DropDownList><br />
                <label>Provincia</label><br />
                <asp:DropDownList ID="dplprovincia" runat="server" OnSelectedIndexChanged="dplprovincia_SelectedIndexChanged" AutoPostBack="true" Enabled="False"></asp:DropDownList><br />
                <label>Distrito</label><br />
                <asp:DropDownList ID="dpldistrito" runat="server" OnSelectedIndexChanged="dpldistrito_SelectedIndexChanged" AutoPostBack="true" requi Enabled="False"></asp:DropDownList><br />
                <label>Correo Electronico</label><br />
                    <asp:TextBox ID="txtgmail" runat="server" type="email" placeholder="Ingresa tu gmail..."></asp:TextBox><br />
                    <label>Número De Telefono</label><br />
                    <asp:TextBox ID="txttelefono" runat="server" type="number" placeholder="Ingresa tu numero de Telefono" required></asp:TextBox><br />
                    <label>Número De Celular</label><br />
                    <asp:TextBox ID="txtcelular" runat="server" type="number" placeholder="Ingresa tu numero de Celular" required></asp:TextBox><br />
                    <label>¿Cuentá Con Discapacidad?</label><br />
                        <div class="radio-group">
                            <label for="check-male">Si</label>               
                          <asp:RadioButton ID="rbtsi" runat="server" GroupName="discapacidadGroup" AutoPostBack="True" OnCheckedChanged="rbt_CheckedChanged" />
                            <label for="check-female">No</label>
                        <asp:RadioButton ID="rbtno" runat="server" GroupName="discapacidadGroup" AutoPostBack="True" OnCheckedChanged="rbt_CheckedChanged" />
                            </div>                   
                    <label>Describa su Discapacidad</label><br />
                    <asp:TextBox ID="txtDiscapacidad" runat="server" Enabled="False" placeholder="Ingresa tu Discapacidad"  required ></asp:TextBox>
            <div class="button-container">
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar Cambios" CssClass="button" OnClick="btnGuardar_Click" />
                </div>
</div>
    
</asp:Content>
