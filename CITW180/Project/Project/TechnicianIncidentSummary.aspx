<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TechnicianIncidentSummary.aspx.cs" Inherits="Project.TechnicianIncidentSummary" %>

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
                            <li><a href="IncidentDisplay">Display incidents</a></li>
                            <li><a href="CustomerDisplay.aspx">Display customers</a></li>
                            <li class="active"><a href="#">Display incidents by technician</a></li>
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
             <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="Name" DataValueField="TechID">
             </asp:DropDownList>
             <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetOpenTechIncidents" TypeName="Project.IncidentDB">
                 <SelectParameters>
                     <asp:ControlParameter ControlID="DropDownList1" PropertyName="SelectedValue" Type="int32" Name="TechID"/>
                 </SelectParameters>
             </asp:ObjectDataSource>
             <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllTechnicians" TypeName="Project.TechnicianDB"></asp:ObjectDataSource>
             <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource2">
             </asp:GridView>
    </form>
</body>
</html>
