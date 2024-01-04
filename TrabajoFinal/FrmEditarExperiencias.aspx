<%@ Page Title="" Language="C#" MasterPageFile="~/PlantillaFormulario.Master" AutoEventWireup="true" CodeBehind="FrmEditarExperiencias.aspx.cs" Inherits="TrabajoFinal.Formulario_web19" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container" style="width:60%">
         <div class="row mt-2">
       <div class="col-12" style="text-align:center"><asp:Label ID="Label3" runat="server" Text="Experiencias"></asp:Label></div>
     </div>
     <asp:Label ID="lblId" runat="server" Text="Experiencias" style="font-weight: 700; color: #CC00CC; font-size: large"></asp:Label>
                     <asp:Label ID="Label7" runat="server" Text="ID Experiencias" BorderStyle="None"></asp:Label>

         <div class="row mt-2">
          <div class="col-4"><asp:Label ID="Label1" runat="server" Text="Fecha de Inicio"></asp:Label></div>
         <div class="col-4"><asp:TextBox ID="txtFechaInicio" type="date" runat="server"></asp:TextBox></div>
     </div>
         <div class="row mt-2">
          <div class="col-4"><asp:Label ID="Label2" runat="server" Text="Fecha de Fin"></asp:Label></div>
         <div class="col-4"><asp:TextBox ID="txtFechaFin" type="date" runat="server"></asp:TextBox></div>
     </div>
         <div class="row mt-2">
          <div class="col-4"><asp:Label ID="Label4" runat="server" Text="Cargo"></asp:Label></div>
         <div class="col-4"><asp:TextBox ID="txtCargo" runat="server"></asp:TextBox></div>
     </div>
      <div class="row mt-2">
          <div class="col-4"><asp:Label ID="Label6" runat="server" Text="Nombre de la Empresa"></asp:Label></div>
         <div class="col-4"><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></div>
     </div>
         <div class="row mt-2">
          <div class="col-4"><asp:Label ID="Label5" runat="server" Text="Subir Certificado"></asp:Label></div>
         <div class="col-4"><asp:FileUpload ID="fuCargar" runat="server" /></div>
         </div>
         <div class="row mt-2">
             <div class="col-4">
                 <asp:TextBox ID="txtRuta" runat="server"></asp:TextBox>
             </div>
         </div>
         <div class="col-4">
             <asp:Button ID="btnActualizar" runat="server" Text="Actualizar Experiencias" OnClick="btnActualizar_Click" />
         </div>
       </div>
          
</asp:Content>
