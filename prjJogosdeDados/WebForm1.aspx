<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="prjJogosdeDados.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" type="text/css" href="CSS/estilos.css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image class="img" ID="Image1" runat="server" Height="150px" Width="150px" />
            <asp:Image class="img" ID="Image2" runat="server" Height="150px" Width="150px" />
            <br />
            <asp:Button class="btn" ID="BtnSortear" runat="server" Text="Sortear" OnClick="BtnSortear_Click" /><br />
            <asp:Label ID="Label1" runat="server" Text="Empates: "></asp:Label>
            <asp:Label ID="lblempate" runat="server" Text="0"></asp:Label>
        </div>
    </form>
</body>
</html>
