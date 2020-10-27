<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="datalist.aspx.cs" Inherits="WebApplication1.datalist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h3>datalist</h3>
        <div >
            <asp:DataList ID="DataList1"  runat="server" Width="100px" Height="98" >
                <ItemTemplate>
                    <asp:Table ID="table1"  runat="server" CellPadding=" 2" CellSpacing="0" Border="1"  style="background-color:gold;width:50px;height:50px"></asp:Table>
                   
                            <tr>
                                <td>
                        
                             <strong>Firstname:</strong><span class="fname"><%# Eval("Firstname")  %></span><br /><strong>Lastname:</strong><span class="lname"><%# Eval("Lastname") %></span><br /><strong>Designation:</strong><span class="desgn"><%# Eval ("Designation") %></span><br /><strong>Location:</strong><span class="loc"><%# Eval("Location") %></span><br /><strong>Country:</strong><span class="con"><%# Eval("Country") %></span></td>
                                </tr>
                        




                </ItemTemplate> 
            </asp:DataList>
        </div>
    </form>
</body>
</html>
