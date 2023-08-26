<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ilk_web_app._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            İsim Giriniz:
            <asp:TextBox ID="TextBox1" runat="server" Height="22px" Width="226px"></asp:TextBox>
            &nbsp;<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" BackColor="Red" Font-Bold="True" Font-Size="Large" ForeColor="White" Height="62px" OnClick="Button1_Click" Text="Buraya Tıkla" Width="225px" />
        </div>
    </form>
</body>
</html>
