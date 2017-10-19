<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="Project.ContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
    <title>Contact Us</title>
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script> t>
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
                            <li><a href="CustomerList">Maintain customers</a></li>
                            <li><a href="#">Maintain technicians</a></li>
                            <li><a href="#">Display incidents</a></li>
                            <li><a href="CustomerDisplay">Display customers</a></li>
                            <li><a href="#">Display incidents by technician</a></li>
                        </ul>
                    </li>
                    <li class="active"><a href="ContactUs">Contact Us</a></li>
                </ul>
            </div>
        </nav>
        <div = "container">
            <h1>SportsPro</h1>
            <h3>Sports Management software for the sports enthusiast</h3>
            <br />
            <h3>How to contact us</h3>
            <p>if you ever have any questions or comments about our products, please be sure to contact us in whatever way is most convenient for you</p>
            <table>
                <tr><td>Phone</td>
                    <td>1-800-555-0400<br />Weekdays, 8 to 5 pacific time</td></tr>
                <tr><td>E-mail</td>
                    <td><a href="mailto:sportspro@sportsprosoftware.com">sportspro@sportsprosoftware.com</a></td></tr>
                <tr><td>Fax</td>
                    <td>1-559-555-2732</td></tr>
                <tr><td>Address</td>
                    <td>SportsPro Software, inc<br />
                    1500 N Main Street<br />
                    Fresno, California 93710</td>
                </tr>
            </table>
            <p style="font-size:small">To contact us, call us at 800-555-0400 or email us at <a href="mailto:sportspro@sportsprosoftware.com">sportspro@sportsprosoftware.com</a></p>
        </div>
    </form>
</body>
</html>
