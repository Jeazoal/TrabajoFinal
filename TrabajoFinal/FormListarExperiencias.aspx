<%@ Page Title="" Language="C#" MasterPageFile="~/PlantillaForm.Master" AutoEventWireup="true" CodeBehind="FormListarExperiencias.aspx.cs" Inherits="TrabajoFinal.Formulario_web113" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link rel="stylesheet" href="Style/ContentForm.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
               <div class="divform">
            <h1>Experiencias</h1>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/FormAgregarExperiencias.aspx">Agregar Experiencias</asp:HyperLink>
<table width="100%">
    <tr>
        <td colspan="2" align='center'>
            <asp:GridView ID="gvListaE" runat="server">
                <Columns>
                    <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="FormEditarExperiencias.aspx?id={0}" Text="Modificar" />
                    <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="FormEliminarExperiencias.aspx?id={0}" Text="Eliminar" />
                </Columns>
            </asp:GridView>             
        </td>
    </tr>
</table>
</div>
    </asp:Content>
