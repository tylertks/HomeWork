<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TechnicianMaintenance.aspx.cs" Inherits="Project.TechnicianMaintenance" %>

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
                            <li class="active"><a href="#">Maintain technicians</a></li>
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
        <div>
        </div>
             <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="DDLData" DataTextField="Name" DataValueField="TechID" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
             </asp:DropDownList>
             <asp:SqlDataSource ID="DDLData" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [TechID], [Name] FROM [Technicians]"></asp:SqlDataSource>
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Technicians] WHERE TechID = @TechID"
                 UpdateCommand="Update [Technicians] SET Name=@Name, Email=@Email, Phone=@Phone where TechID = @TechID"
                 InsertCommand="Insert into [Technicians] (Name, Email, Phone) VALUES (@Name, @Email, @Phone)">
                 <SelectParameters>
                     <asp:ControlParameter ControlID="DropDownList1" Name="TechID" PropertyName="SelectedValue" Type="String" />
                 </SelectParameters>
             </asp:SqlDataSource>
            <asp:FormView ID="FormView1" runat="server" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" DataKeyNames="TechID">
                <EditItemTemplate>
                    TechID:
                    <asp:Label ID="TechIDLabel1" runat="server" Text='<%# Eval("TechID") %>' />
                    <br />
                    Name:
                    <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                    <br />
                    Email:
                    <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                    <br />
                    Phone:
                    <asp:TextBox ID="PhoneTextBox" runat="server" Text='<%# Bind("Phone") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <InsertItemTemplate>
                    <br />
                    Name:
                    <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                    <br />
                    Email:
                    <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                    <br />
                    Phone:
                    <asp:TextBox ID="PhoneTextBox" runat="server" Text='<%# Bind("Phone") %>' />
                    <br />
                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </InsertItemTemplate>
                <ItemTemplate>
                    TechID:
                    <asp:Label ID="TechIDLabel" runat="server" Text='<%# Eval("TechID") %>' />
                    <br />
                    Name:
                    <asp:Label ID="NameLabel" runat="server" Text='<%# Bind("Name") %>' />
                    <br />
                    Email:
                    <asp:Label ID="EmailLabel" runat="server" Text='<%# Bind("Email") %>' />
                    <br />
                    Phone:
                    <asp:Label ID="PhoneLabel" runat="server" Text='<%# Bind("Phone") %>' />
                    <br />
                    <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" AutoPostBack="true"/>
                    &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" AutoPostBack="true"/>
                </ItemTemplate>
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
             </asp:FormView>
            <asp:Label ID="TestLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
