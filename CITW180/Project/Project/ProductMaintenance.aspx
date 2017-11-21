<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductMaintenance.aspx.cs" Inherits="Project.ProductMaintenance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Project 3-B: Maintain Products</title>
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
                            <li class="active"><a href="#">Maintain products</a></li>
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

        </div>
        <asp:Label ID="ErrorLabel" runat="server" EnableViewState="true" Color="Red"></asp:Label>
             <asp:GridView 
                 ID="GridView1" 
                 runat="server" 
                 DataKeyNames="ProductCode" 
                 OnRowEditing="GridView1_RowEditing"
                 OnRowCancelingEdit="GridView1_RowCancelingEdit"
                 OnRowUpdating="GridView1_RowUpdating"
                 OnRowDeleting="GridView1_RowDeleting"
                 OnPageIndexChanging="GridView1_PageIndexChanging"
                 AutoPostback="true" AutoGenerateColumns="False">
                 <Columns>
                     <asp:BoundField DataField="ProductCode" HeaderText="ProductCode" ReadOnly="True" SortExpression="ProductCode" />
                     <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                     <asp:BoundField DataField="Version" HeaderText="Version" SortExpression="Version" />
                     <asp:BoundField DataField="ReleaseDate" HeaderText="ReleaseDate" SortExpression="ReleaseDate" />
                     <asp:CommandField ShowEditButton="True" />
                     <asp:CommandField ShowDeleteButton="True" />
                 </Columns>
             </asp:GridView>
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                 SelectCommand="SELECT * FROM [Products]">
             </asp:SqlDataSource>
        <p>To add a new product, enter the product information and click Add Product</p>
        <p>Product Code: <asp:TextBox ID="productCode" runat="server"></asp:TextBox></p>
        <p>Name: <asp:TextBox ID="name" runat="server"></asp:TextBox></p>
        <p>Version: <asp:TextBox ID="version" runat="server"></asp:TextBox></p>
        <p>Release date: <asp:TextBox ID="date" runat="server" TextMode="Date" AutoPostBack="true" OnTextChanged="date_TextChanged"></asp:TextBox>
            <asp:Label ID="dateLbl" runat="server"></asp:Label></p>
        <asp:Button ID="AddBtn" runat="server" Text="Add Product" OnClick="AddBtn_Click" AutoPostback="true"/>
    </form>
</body>
</html>
