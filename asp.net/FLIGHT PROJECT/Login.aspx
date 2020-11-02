<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FlightProject.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <h2>AIRLINES LOGIN</h2>
    <style type="text/css">
        .auto-style1 {
            width: 225px;
        }
        .auto-style2 {
            margin-left: 193px;
        }
        .auto-style3 {
            width: 203px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       
        <table style="width:100%;">
            <tr>
                <td class="auto-style1" style="background-color: #669999">&nbsp;Email</td>
                <td class="auto-style3" style="background-color: #669999">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;
                    &nbsp; </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="[*enter email]" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="[*mismatch email]" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="background-color: #669999">Password</td>
                <td class="auto-style3" style="background-color: #669999">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="[*password]" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            </table>
        <asp:Button ID="Button2" runat="server" CssClass="auto-style2" OnClick="Button2_Click" Text="login" Width="131px" BackColor="Black" ForeColor="Blue" />
       
    </form>
</body>
</html>
