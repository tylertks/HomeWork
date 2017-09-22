<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerList.aspx.cs" Inherits="Project.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>SportsPro</h1>
    <h2>Sports Management Software for the sports enthusiast</h2>
    <form id="form1" runat="server">
        <div id ="listDiv" runat="server">
            <asp:ListBox ID="customerListBox" runat="server"></asp:ListBox>
            <br />
            <asp:Button ID="removeBtn" runat="server" OnClick="removeBtn_Click" Text="Remove Customer" />
            <asp:Button ID="emptyBtn" runat="server" OnClick="emptyBtn_Click" Text="Empty List"/>
            <asp:Button ID="customerDisplay" runat="server" OnClick="customerDisplay_Click" Text="Select Additional Customers"/>
        </div>
    </form>
</body>
</html>
