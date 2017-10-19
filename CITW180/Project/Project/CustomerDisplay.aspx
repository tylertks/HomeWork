<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerDisplay.aspx.cs" Inherits="Project.CustomerDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Display</title>
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>    
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
</head>
<body>
    <nav class ="navbar navbar-default">
            <div class="container-fluid">
                <div class="navbar-header">
                    <a class="navbar-brand" href="#">SportsPro</a>
                </div>
                <ul class="nav navbar-nav">
                    <li class="dropdown">
                        <a class="dropdown-toggle" data-toggle="dropdown" href="#">Customer Support
                            <span class="caret"></span></a>
                        <ul class="dropdown-menu">
                            <li><a href="#">Register products</a></li>
                            <li><a href="CustomerSurvey">Complete Customer Survey</a></li>
                        </ul>
                    </li>
                    <li class="dropdown">
                        <a class="dropdown-toggle" data-toggle="dropdown" href="#">Technician Support
                            <span class="caret"></span></a>
                        <ul class="dropdown-menu">
                            <li><a href="#">Display Customer incidents</a></li>
                            <li><a href="#">Update Incidents</a></li>
                        </ul>
                    </li>
                    <li class="dropdown">
                        <a class="dropdown-toggle" data-toggle="dropdown" href="#">Administration
                            <span class="caret"></span></a>
                        <ul class="dropdown-menu">
                            <li><a href="#">Maintain products</a></li>
                            <li class="active"><a href="CustomerList">Maintain customers</a></li>
                            <li><a href="#">Maintain technicians</a></li>
                            <li><a href="#">Display incidents</a></li>
                            <li><a href="CustomerDisplay">Display customers</a></li>
                            <li><a href="#">Display incidents by technician</a></li>
                        </ul>
                    </li>
                    <li><a href="ContactUs">Contact Us</a></li>
                </ul>
            </div>
        </nav>
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
