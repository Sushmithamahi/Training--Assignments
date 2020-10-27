<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dropdown.aspx.cs" Inherits="WebApplication1.dropdown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h3>select city from the dropdown</h3>
        <div>
        <asp:DropDownList ID="DropDownList1" runat="server" Width="125px" >
            <asp:ListItem Value="" runat="server">City you like</asp:ListItem>
            <asp:ListItem>Bangalore</asp:ListItem>
            <asp:ListItem>Hyderabad</asp:ListItem>
            <asp:ListItem>Chennai</asp:ListItem>
            <asp:ListItem>coorg</asp:ListItem>
            <asp:ListItem>kerala</asp:ListItem>
            <asp:ListItem>ooty</asp:ListItem>
            <asp:ListItem>hampi</asp:ListItem>
            </asp:DropDownList><br /><br />
        
       
            <asp:Button ID="drpbtn" runat="server" Text="select" OnClick="drpbtn_Click" />
        </div>
        <p>
            <asp:Label ID="drplbl" runat="server" ></asp:Label>
        </p>
    </form>
</body>
</html>
