<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Swtich2.aspx.cs" Inherits="Switch_case_uygulamasi.Swtich2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Şehir Seçiniz:<asp:DropDownList ID="Sehir_listesi" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Sehir_listesi_SelectedIndexChanged">
                <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                <asp:ListItem Value="16">Bursa</asp:ListItem>
                <asp:ListItem Value="6">Ankara</asp:ListItem>
                <asp:ListItem Value="35">izmir</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:ListBox ID="ilce_listesi" runat="server" Height="355px" Width="287px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
