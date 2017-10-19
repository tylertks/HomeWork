<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerSurvey.aspx.cs" Inherits="Project.CustomerSurvey" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Project 2-A: Survey Customer</title>
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
                            <li><a href="#">Display Customer incidents</a></li>
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
        <div class="container">
            <h1>SportsPro</h1>
            <h3>Sports Management software for the sports enthusiast</h3>
            <asp:Label ID="idLabel" runat="server">Enter your Customer ID: </asp:Label>
            <asp:TextBox ID="idText" runat="server"></asp:TextBox>
            <asp:Label ID="errorMessage" runat="server"></asp:Label>
            <asp:Button id="idButton" runat="server" OnClick="idButton_Click" Text="Get Incidents"/>
            <br />
            <asp:ListBox ID="incidentsBox" runat="server" Enabled="false"></asp:ListBox>
            <br />
            <asp:Table ID="surveyTable" runat="server" Enabled ="false">
                <asp:TableRow><asp:TableHeaderCell ColumnSpan="2">Please Rate this incident by the following categories</asp:TableHeaderCell></asp:TableRow>
                <asp:TableRow><asp:TableCell>Response Time: </asp:TableCell>
                    <asp:TableCell><asp:RadioButton id="resNotSatisfied" Text="Not Satisfied"  runat="server" GroupName="response"/>
                    <asp:RadioButton id="resSomeSatisfied" Text="Somewhat Satisfied"  runat="server" GroupName="response"/>
                    <asp:RadioButton id="resSatisfied" Text="Satisfied" runat="server"  GroupName="response"/>
                    <asp:RadioButton id="resComplete" Text="Completely Satisfied" runat="server"  GroupName="response"/></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow><asp:TableCell>Technician Efficiency: </asp:TableCell>
                    <asp:TableCell><asp:RadioButton id="techNotSatisfied" Text="Not Satisfied"  runat="server" GroupName="technician"/>
                    <asp:RadioButton id="techSomeSatisfied" Text="Somewhat Satisfied" runat="server"  GroupName="technician"/>
                    <asp:RadioButton id="techSatisfied" Text="Satisfied" runat="server"  GroupName="technician"/>
                    <asp:RadioButton id="techComplete" Text="Completely Satisfied" runat="server"  GroupName="technician"/></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow><asp:TableCell>Problem Resolution: </asp:TableCell>
                    <asp:TableCell><asp:RadioButton id="probNotSatisfied" Text="Not Satisfied" runat="server"  GroupName="problem"/>
                    <asp:RadioButton id="probSomeSatisfied" Text="Somewhat Satisfied" runat="server"  GroupName="problem"/>
                    <asp:RadioButton id="probSatisfied" Text="Satisfied" runat="server"  GroupName="problem"/>
                    <asp:RadioButton id="probComplete" Text="Completely Satisfied" runat="server"  GroupName="problem"/></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow><asp:TableCell>Additional Comments</asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="comments" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <asp:CheckBox id="contactMe" runat="server" Text="Please contact me to discuss this incident" OnCheckedChanged="contactMe_CheckedChanged" Enabled="false" AutoPostBack="true" />
            <br />
            <asp:RadioButton ID="emailContact" runat="server" Text="Contact by Email" GroupName="contact" Enabled="false"/><br />
            <asp:RadioButton ID="phoneContact" runat="server" Text="Contact by Phone" GroupName="contact" Enabled="false"/><br />
            <asp:Button id="SubmitSurvey" runat="server" Text="Submit" OnClick="SubmitSurvey_Click" Enabled ="false"/>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Incidents]"></asp:SqlDataSource>
    </form>
</body>
</html>
