<%@ Page Title="" Language="C#" MasterPageFile="~/PlantillaFormulario.Master" AutoEventWireup="true" CodeBehind="FrmListarExperiencias.aspx.cs" Inherits="TrabajoFinal.Formulario_web17" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        table {
        width: 100%;
        border-collapse: collapse;
        margin-top: 20px;
        border-radius: 8px;
        overflow: hidden;
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    }

    td, th {
        padding: 10px;
        text-align: left;
    }

    td.right-align {
        text-align: right;
    }

    th {
        background-color: #555;
        color: #fff;
    }

    tr:nth-child(odd) {
        background-color: #555;
    }

    tr:nth-child(even) {
        background-color: #888;
    }

    .center-align {
        text-align: center;
    }

    #HyperLink1 {
        text-decoration: none;
        color: #3498db;
        font-weight: bold;
    }

    #HyperLink1:hover {
        text-decoration: underline;
    }

    #gvLista {
        width: 100%;
        border: none;
        border-radius: 8px;
        overflow: hidden;
        margin-top: 20px;
    }

    #gvLista th, #gvLista td {
        border-bottom: 1px solid #ddd;
    }

    #gvLista a {
        text-decoration: none;
        color: #3498db;
        font-weight: bold;
    }

    #gvLista a:hover {
        text-decoration: underline;
    }   

    .container{
        margin:20px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="width: 60%">
    <div class="row">
             <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/FrAgregarExperiencias.aspx">Agregar Experiencias</asp:HyperLink>
 <table width="100%">
         <td colspan="2" align='center'>
             <asp:GridView ID="gvListaE" runat="server">
                 <Columns>
                     <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="FrEditarExperiencias.aspx?id={0}" Text="Modificar" />
                     <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="FrEliminarExperiencias.aspx?id={0}" Text="Eliminar" />
                 </Columns>
             </asp:GridView>             
         </td>
     </tr>
 </table>
  </div>
 </div>
</asp:Content>
