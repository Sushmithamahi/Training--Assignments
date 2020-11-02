<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Boardingpass.aspx.cs" Inherits="FlightProject.Boardingpass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 176px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #FFFFFF">
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#66FFFF" DataSourceID="SqlDataSource1" Width="962px">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="PassengerName" HeaderText="PassengerName" SortExpression="PassengerName" />
                <asp:BoundField DataField="FlightID" HeaderText="FlightID" SortExpression="FlightID" />
                <asp:BoundField DataField="FlightName" HeaderText="FlightName" SortExpression="FlightName" />
                <asp:BoundField DataField="Source" HeaderText="Source" SortExpression="Source" />
                <asp:BoundField DataField="Destination" HeaderText="Destination" SortExpression="Destination" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [passengers]"></asp:SqlDataSource>
        <asp:Button ID="Button1" runat="server" BackColor="#0066FF" CssClass="auto-style1" OnClick="Button1_Click" Text="View/Print" Width="249px" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        
    </form>
</body>
</html>
