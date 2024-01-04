<%@ Page Title="" Language="C#" MasterPageFile="~/PlantillaPaginasEmergentes.Master" AutoEventWireup="true" CodeBehind="FrEliminarDatosAcademicos.aspx.cs" Inherits="TrabajoFinal.Formulario_web110" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link rel="stylesheet" href="Style/RecuperarForm.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="width:60%">
       <div class="row mt-2">
     <div class="col-12" style="text-align:center"><asp:Label ID="Label3" runat="server" Text="Datos Academicos"></asp:Label></div>
            <asp:Label ID="lblId" runat="server" Text="Nombre Compañia" style="font-weight: 700; color: #CC00CC; font-size: large"></asp:Label>
                   <asp:Label ID="Label6" runat="server" Text="ID Compañia" BorderStyle="None"></asp:Label>

   </div>
       <div class="row mt-2">
        <div class="col-4"><asp:Label ID="Label1" runat="server" Text="Titulo Grado Obtenido"></asp:Label></div>
       <div class="col-4"><asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox></div>
   </div>
       <div class="row mt-2">
        <div class="col-4"><asp:Label ID="Label2" runat="server" Text="Centro de Estudios"></asp:Label></div>
       <div class="col-4"><asp:TextBox ID="txtCEstudios" runat="server"></asp:TextBox></div>
   </div>
       <div class="row mt-2">
        <div class="col-4"><asp:Label ID="Label4" runat="server" Text="Fecha de Grado de Estudio"></asp:Label></div>
       <div class="col-4">
           <asp:TextBox ID="txtFecha" type="date" runat="server"></asp:TextBox>
       </div>
   </div>
       <div class="row mt-2">
        <div class="col-4"><asp:Label ID="Label5" runat="server" Text="Subir Titulo"></asp:Label></div>
       <div class="col-4"><asp:FileUpload ID="fuCargar" runat="server" /></div>
       </div>
       <div class="row mt-2">
           <div class="col-4">
               <asp:TextBox ID="txtRuta" runat="server"></asp:TextBox>
           </div>
       </div>
       <div class="col-4">
           <asp:Button ID="btnEliminar" runat="server" Text="Eliminar Datos Academicos" OnClick="btnEliminar_Click" />
       </div>
   </div>
</asp:Content>
