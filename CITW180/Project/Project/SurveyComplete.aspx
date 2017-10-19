<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SurveyComplete.aspx.cs" Inherits="Project.SurveyComplete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Thank you for your feedback!</title>
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script> 
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h3 class="page-header">Thank you for your feedback</h3>
            <asp:Label ID="surveyLbl" runat="server"></asp:Label>
            <asp:Button id="return" runat="server" OnClick="return_Click" Text="Return to Survey"/>
        </div>
    </form>
</body>
</html>
