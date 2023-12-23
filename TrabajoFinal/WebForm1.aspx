<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TrabajoFinal.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <div style="margin-left: 200px">
        </div>
        <asp:TextBox ID="txtgmail" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <p>
            <asp:Button ID="btnIngresar" runat="server" OnClick="Button1_Click" style="margin-bottom: 0px" Text="Ingresar" Width="94px" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
