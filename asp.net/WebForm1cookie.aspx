<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1cookie.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="chklbl1" runat="server" Text="selct brand"></asp:Label><br />
        <asp:CheckBox ID="CheckBox1" runat="server"  Text="iphone"/><br />
        <asp:CheckBox ID="CheckBox2" runat="server" Text="redmi" /><br />
        <asp:CheckBox ID="CheckBox3" runat="server" Text="oppo" /><br />
        <asp:CheckBox ID="CheckBox4" runat="server" Text="oneplus" /><br />
        <asp:Button ID="chkbtn" runat="server" Text="checkon" OnClick="chkbtn_Click" /><br /><br />
         <p>
        <asp:Label ID="chklbl2" runat="server"></asp:Label>
    </p>
        
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
     </form>   
    
</body>
</html>
