<%@ Page Title="" Language="C#" MasterPageFile="~/PlantillaForm.Master" AutoEventWireup="true" CodeBehind="FormListarDatosA.aspx.cs" Inherits="TrabajoFinal.Formulario_web112" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Style/FormContent.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="divform">
            <h1>DATOS ACADEMICOS</h1>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/FormAgregarDatosA.aspx">Agregar DatosAcademicos</asp:HyperLink>
<table>
    <tr>
        <td colspan="2" align='center'>
            <asp:GridView ID="gvLista" runat="server">
                <Columns>
                    <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="FormEditarDatosA.aspx?id={0}"  Text="Editar" />
                    <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="FormEliminarDatosA.aspx?id={0}" Text="Eliminar" />
                </Columns>
            </asp:GridView>        
        </td>
    </tr>
</table>
        </div>
   
</asp:Content>
