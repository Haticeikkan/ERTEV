<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Switch1.aspx.cs" Inherits="Switch_case_uygulamasi.Switch1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Not Değeri:<asp:TextBox ID="not_txt" runat="server" Height="22px"  Width="207px"></asp:TextBox>
            <br />
            <asp:Button ID="btn_hesapla" runat="server" Height="46px" OnClick="btn_hesapla_Click" Text="Hesapla" Width="138px" />
            <br />
        </div>
    </form>
</body>
</html>
