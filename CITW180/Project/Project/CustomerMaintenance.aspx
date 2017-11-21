<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerMaintenance.aspx.cs" Inherits="Project.CustomerMaintenance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Project 3-D: Maintain Products</title>
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
                            <li><a href="CustomerIncidentDisplay">Display Customer incidents</a></li>
                            <li><a href="#">Update Incidents</a></li>
                        </ul>
                    </li>
                    <li class="dropdown">
                        <a class="dropdown-toggle" data-toggle="dropdown" href="#">Administration
                            <span class="caret"></span></a>
                        <ul class="dropdown-menu">
                            <li><a href="#">Maintain products</a></li>
                            <li class="active"><a href="CustomerList.aspx">Maintain customers</a></li>
                            <li><a href="TechnicianMaintenance">Maintain technicians</a></li>
                            <li><a href="#">Display incidents</a></li>
                            <li><a href="CustomerDisplay">Display customers</a></li>
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

        </div>
        <div class="row">
            <div class="col-md-4">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CustomerID" DataSourceID="SqlDataSource1" AllowPaging="True">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                    <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
                </div>
            <div class="col-md-2">
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="CustomerID" DataSourceID="SqlDataSource2" Height="50px" Width="125px">
                <Fields>
                    <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" InsertVisible="False" ReadOnly="True" SortExpression="CustomerID" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                    <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                    <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                    <asp:BoundField DataField="ZipCode" HeaderText="ZipCode" SortExpression="ZipCode" />
                    <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                    <asp:CommandField ShowEditButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                    <asp:CommandField ShowInsertButton="True" />
                </Fields>
            </asp:DetailsView>
                </div>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                SelectCommand="SELECT * FROM [Customers] WHERE CustomerID = @CustomerID"
                UpdateCommand="UPDATE [Customers] Set Name=@Name, Address=@Address, City=@City, State=@State, ZipCode=@ZipCode, Phone=@Phone, Email=@Email WHERE CustomerID=@CustomerID"
                InsertCommand="INSERT INTO [Customers] (Name, Address, City, State, ZipCode, Phone, Email) VALUES (@Name, @Address, @City, @State, @ZipCode, @Phone, @Email)" >
                <SelectParameters>
                    <asp:ControlParameter ControlID="GridView1" PropertyName="SelectedValue" Name="CustomerID" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Name], [City], [State], [CustomerID] FROM [Customers]"></asp:SqlDataSource>

        </div>
    </form>
</body>
</html>
