<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="session.aspx.cs" Inherits="WebApplication1.session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>provide following details</h3>
           <%-- <asp:Label ID="userlbl" runat="server" Text="Email "></asp:Label>--%>
            Email <asp:TextBox ID="emailtxt" runat="server" TextMode="Email" OnTextChanged="emailtxt_TextChanged"></asp:TextBox><br /><br />

           
            Password<asp:TextBox ID="pwdtxt" runat="server" TextMode="Password"></asp:TextBox><br /><br />

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:Button ID="pwdbtn" runat="server" Text="submit" OnClick="pwdbtn_Click" />
        </div>
        <p>
            <asp:Label ID="seslbl1" runat="server" ></asp:Label><br /><br />

            <asp:Label ID="seslbl2" runat="server" ></asp:Label>
        </p>
    </form>
</body>
</html>
