<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerDisplay.aspx.cs" Inherits="Project.CustomerDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>SportsPro</h1>
    <h2>Sports Management Software for the sports enthusiast</h2>
    <form id="form1" runat="server">
        <div>
        <asp:SqlDataSource ID="SqlDataSource" 
            runat="server" 
            DataSourceMode="DataReader" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
            SelectCommand="SELECT * FROM [Customers]">
            </asp:SqlDataSource>
        <asp:DropDownList
            id="DropDown1"
            runat="server"
            DataTextField="Name"
            DataSourceID="SqlDataSource" 
            OnSelectedIndexChanged="DropDown1_SelectedIndexChanged"
            AutoPostBack ="True">
        </asp:DropDownList>
            <table>
                <tr><th>Name</th><th>Address</th><th>Phone</th><th>Email</th></tr>
                <tr><td><asp:Label ID="customerName" runat="server"></asp:Label></td>
                    <td><asp:Label ID="customerAddress" runat="server"></asp:Label></td>
                    <td><asp:Label ID="customerPhone" runat="server"></asp:Label></td>
                    <td><asp:Label ID="customerEmail" runat="server"></asp:Label></td>
                </tr>
            </table>
            <asp:Button ID="addCustomer" runat="server" OnClick="addCustomer_Click" Text="Add to List"/>
            <asp:Button ID="showList" runat="server" OnClick="showList_Click" Text="Customer List" />
            <br />
            <asp:Label ID="testLabel" runat="server"></asp:Label>
            </div>
    </form>
</body>
</html>
