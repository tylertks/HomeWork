<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerIncidentDisplay.aspx.cs" Inherits="Project.CustomerIncidentDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Project 3-A: Display Customer Incidents</title>
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script> 
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
</head>
<body>
    <form id="form1" runat="server">
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
                            <li class="active"><a href="CustomerSurvey.aspx">Complete Customer Survey</a></li>
                        </ul>
                    </li>
                    <li class="dropdown">
                        <a class="dropdown-toggle" data-toggle="dropdown" href="#">Technician Support
                            <span class="caret"></span></a>
                        <ul class="dropdown-menu">
                            <li class ="active"><a href="#">Display Customer incidents</a></li>
                            <li><a href="#">Update Incidents</a></li>
                        </ul>
                    </li>
                    <li class="dropdown">
                        <a class="dropdown-toggle" data-toggle="dropdown" href="#">Administration
                            <span class="caret"></span></a>
                        <ul class="dropdown-menu">
                            <li><a href="#">Maintain products</a></li>
                            <li><a href="CustomerList.aspx">Maintain customers</a></li>
                            <li><a href="#">Maintain technicians</a></li>
                            <li><a href="#">Display incidents</a></li>
                            <li><a href="CustomerDisplay.aspx">Display customers</a></li>
                            <li><a href="#">Display incidents by technician</a></li>
                        </ul>
                    </li>
                    <li><a href="ContactUs.aspx">Contact Us</a></li>
                </ul>
            </div>
        </nav>
        <div>
            <h1>SportsPro</h1>
            <h3>Sports Management software for the sports enthusiast</h3>
            <table><tr><td>Select a Customer:</td><td>
                                                  <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="CustomerID" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                                  </asp:DropDownList>
                                                  </td></tr></table>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Name], [CustomerID] FROM [Customers] ORDER BY [Name]"></asp:SqlDataSource>
        <br />
       <div class="container">
            <div class="row" style="border-bottom:1px solid black">
                <div class="col-md-3" ><strong>Product/Incident</strong></div>
                <div class="col-md-3" ><strong>Tech Name</strong></div>
                <div class="col-md-3" ><strong>Opened</strong></div>
                <div class="col-md-3" ><strong>Closed</strong></div>
            </div>
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource2" Width="100%">
             
           <ItemTemplate>
                <div class="row">
                    <!--Product/Incident:-->
                    <div class="col-md-3" ><asp:Label ID="ProductLabel" runat="server" Text='<%# Eval("pName") %>' /></div>
                    <!--<br />
                    Name:-->
                    <div class="col-md-3" ><asp:Label ID="NameLabel" runat="server" Text='<%# Eval("tName") %>' /></div>
                    <!--<br />
                    DateOpened:-->
                    <div class="col-md-3" ><asp:Label ID="DateOpenedLabel" runat="server" Text='<%# Eval("DateOpened") %>' /></div>
                    <!--<br />
                    DateClosed:-->
                    <div class="col-md-3" ><asp:Label ID="DateClosedLabel" runat="server" Text='<%# Eval("DateClosed") %>' /></div>
                    <!--<br />
                    Title:-->
                </div>
                <div class="row">
                    <div class="col-md-12" style="border-bottom:1px solid gray"><asp:Label ID="TitleLabel" runat="server" Text='<%# Eval("Title") %>' /></div>
                    <br />
                </div>
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT Products.Name as pName, Technicians.Name as tName, Incidents.DateOpened, Incidents.DateClosed, Incidents.Title FROM Incidents INNER JOIN Technicians ON Incidents.TechID = Technicians.TechID INNER JOIN Products ON Incidents.ProductCode = Products.ProductCode WHERE Incidents.CustomerID = 0;"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
