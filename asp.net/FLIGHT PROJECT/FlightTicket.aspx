<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FlightTicket.aspx.cs" Inherits="FlightProject.FlightTicket" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <h2>AIRLINES TICKET BOOKING</h2>
    <style type="text/css">
        .auto-style1 {
            width: 299px;
        }
        .auto-style2 {
            margin-left: 153px;
        }
        .auto-style3 {
            width: 272px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       
        <table style="width:100%;">
            <tr>
                <td class="auto-style1" style="background-color: #669999">PassengerName</td>
                <td class="auto-style3" style="background-color: #669999">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="[*must enter name]" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="background-color: #669999">FlightID</td>
                <td class="auto-style3" style="background-color: #669999">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="[*enter flight id]" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="background-color: #669999">FlightName</td>
                <td class="auto-style3" style="background-color: #669999">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="[*enter flight name]" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="background-color: #669999">Source</td>
                <td class="auto-style3" style="background-color: #669999">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="[*enter source]" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="background-color: #669999">Destination</td>
                <td class="auto-style3" style="background-color: #669999">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="[*enter destination]" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <asp:Button ID="Button3" runat="server" CssClass="auto-style2" Text="BOOK NOW" Width="218px" BackColor="Black" ForeColor="Blue" OnClick="Button3_Click" />
       
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" ></asp:Label>
       
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
       
    </form>
</body>
</html>
