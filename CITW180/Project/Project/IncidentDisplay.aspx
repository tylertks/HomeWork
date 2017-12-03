<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IncidentDisplay.aspx.cs" Inherits="Project.IncidentDisplay" %>

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
                            <li><a href="CustomerList.aspx">Maintain customers</a></li>
                            <li><a href="TechnicianMaintenance">Maintain technicians</a></li>
                            <li class="active"><a href="#">Display incidents</a></li>
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

             <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
                 <AlternatingItemTemplate>
                     <tr style="background-color:#FFF8DC;">
                         <td>
                             <asp:Label ID="CustomerLabel" runat="server" Text='<%# Eval("Customer") %>' />
                         </td>
                         <td>
                             <asp:Label ID="ProductLabel" runat="server" Text='<%# Eval("Product") %>' />
                         </td>
                         <td>
                             <asp:Label ID="TechnicianLabel" runat="server" Text='<%# Eval("Technician") %>' />
                         </td>
                         <td>
                             <asp:Label ID="DateOpenedLabel" runat="server" Text='<%# Eval("DateOpened") %>' />
                         </td>
                         <td>
                             <asp:Label ID="DateClosedLabel" runat="server" Text='<%# Eval("DateClosed") %>' />
                         </td>
                         <td>
                             <asp:Label ID="TitleLabel" runat="server" Text='<%# Eval("Title") %>' />
                         </td>
                         <td>
                             <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>' />
                         </td>
                     </tr>
                 </AlternatingItemTemplate>
                 <EditItemTemplate>
                     <tr style="background-color:#008A8C;color: #FFFFFF;">
                         <td>
                             <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                             <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                         </td>
                         <td>
                             <asp:TextBox ID="CustomerTextBox" runat="server" Text='<%# Bind("Customer") %>' />
                         </td>
                         <td>
                             <asp:TextBox ID="ProductTextBox" runat="server" Text='<%# Bind("Product") %>' />
                         </td>
                         <td>
                             <asp:TextBox ID="TechnicianTextBox" runat="server" Text='<%# Bind("Technician") %>' />
                         </td>
                         <td>
                             <asp:TextBox ID="DateOpenedTextBox" runat="server" Text='<%# Bind("DateOpened") %>' />
                         </td>
                         <td>
                             <asp:TextBox ID="DateClosedTextBox" runat="server" Text='<%# Bind("DateClosed") %>' />
                         </td>
                         <td>
                             <asp:TextBox ID="TitleTextBox" runat="server" Text='<%# Bind("Title") %>' />
                         </td>
                         <td>
                             <asp:TextBox ID="DescriptionTextBox" runat="server" Text='<%# Bind("Description") %>' />
                         </td>
                     </tr>
                 </EditItemTemplate>
                 <EmptyDataTemplate>
                     <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                         <tr>
                             <td>No data was returned.</td>
                         </tr>
                     </table>
                 </EmptyDataTemplate>
                 <InsertItemTemplate>
                     <tr style="">
                         <td>
                             <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                             <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                         </td>
                         <td>
                             <asp:TextBox ID="CustomerTextBox" runat="server" Text='<%# Bind("Customer") %>' />
                         </td>
                         <td>
                             <asp:TextBox ID="ProductTextBox" runat="server" Text='<%# Bind("Product") %>' />
                         </td>
                         <td>
                             <asp:TextBox ID="TechnicianTextBox" runat="server" Text='<%# Bind("Technician") %>' />
                         </td>
                         <td>
                             <asp:TextBox ID="DateOpenedTextBox" runat="server" Text='<%# Bind("DateOpened") %>' />
                         </td>
                         <td>
                             <asp:TextBox ID="DateClosedTextBox" runat="server" Text='<%# Bind("DateClosed") %>' />
                         </td>
                         <td>
                             <asp:TextBox ID="TitleTextBox" runat="server" Text='<%# Bind("Title") %>' />
                         </td>
                         <td>
                             <asp:TextBox ID="DescriptionTextBox" runat="server" Text='<%# Bind("Description") %>' />
                         </td>
                     </tr>
                 </InsertItemTemplate>
                 <ItemTemplate>
                     <tr style="background-color:#DCDCDC;color: #000000;">
                         <td>
                             <asp:Label ID="CustomerLabel" runat="server" Text='<%# Eval("Customer") %>' />
                         </td>
                         <td>
                             <asp:Label ID="ProductLabel" runat="server" Text='<%# Eval("Product") %>' />
                         </td>
                         <td>
                             <asp:Label ID="TechnicianLabel" runat="server" Text='<%# Eval("Technician") %>' />
                         </td>
                         <td>
                             <asp:Label ID="DateOpenedLabel" runat="server" Text='<%# Eval("DateOpened") %>' />
                         </td>
                         <td>
                             <asp:Label ID="DateClosedLabel" runat="server" Text='<%# Eval("DateClosed") %>' />
                         </td>
                         <td>
                             <asp:Label ID="TitleLabel" runat="server" Text='<%# Eval("Title") %>' />
                         </td>
                         <td>
                             <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>' />
                         </td>
                     </tr>
                 </ItemTemplate>
                 <LayoutTemplate>
                     <table runat="server">
                         <tr runat="server">
                             <td runat="server">
                                 <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                     <tr runat="server" style="background-color:#DCDCDC;color: #000000;">
                                         <th runat="server">Customer</th>
                                         <th runat="server">Product</th>
                                         <th runat="server">Technician</th>
                                         <th runat="server">DateOpened</th>
                                         <th runat="server">DateClosed</th>
                                         <th runat="server">Title</th>
                                         <th runat="server">Description</th>
                                     </tr>
                                     <tr id="itemPlaceholder" runat="server">
                                     </tr>
                                 </table>
                             </td>
                         </tr>
                         <tr runat="server">
                             <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;">
                                 <asp:DataPager ID="DataPager1" runat="server">
                                     <Fields>
                                         <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                                     </Fields>
                                 </asp:DataPager>
                             </td>
                         </tr>
                     </table>
                 </LayoutTemplate>
                 <SelectedItemTemplate>
                     <tr style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">
                         <td>
                             <asp:Label ID="CustomerLabel" runat="server" Text='<%# Eval("Customer") %>' />
                         </td>
                         <td>
                             <asp:Label ID="ProductLabel" runat="server" Text='<%# Eval("Product") %>' />
                         </td>
                         <td>
                             <asp:Label ID="TechnicianLabel" runat="server" Text='<%# Eval("Technician") %>' />
                         </td>
                         <td>
                             <asp:Label ID="DateOpenedLabel" runat="server" Text='<%# Eval("DateOpened") %>' />
                         </td>
                         <td>
                             <asp:Label ID="DateClosedLabel" runat="server" Text='<%# Eval("DateClosed") %>' />
                         </td>
                         <td>
                             <asp:Label ID="TitleLabel" runat="server" Text='<%# Eval("Title") %>' />
                         </td>
                         <td>
                             <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>' />
                         </td>
                     </tr>
                 </SelectedItemTemplate>
             </asp:ListView>
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT Customers.Name AS Customer, Products.Name AS Product, Technicians.Name AS Technician, Incidents.DateOpened, Incidents.DateClosed, Incidents.Title, Incidents.Description FROM Incidents INNER JOIN Products ON Incidents.ProductCode = Products.ProductCode INNER JOIN Customers ON Incidents.CustomerID = Customers.CustomerID INNER JOIN Technicians ON Incidents.TechID = Technicians.TechID"></asp:SqlDataSource>

    </form>
</body>
</html>
