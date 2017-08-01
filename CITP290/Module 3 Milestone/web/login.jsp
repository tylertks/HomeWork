<%-- 
    Document   : login
    Created on : Aug 1, 2017, 9:55:43 AM
    Author     : tyler
--%>

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <jsp:useBean id = "login" scope="application" class="Module3Milestone.loginServlet"></jsp:useBean>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Login</title>
    </head>
    <body>
    <% try{if(request.getParameter("failed").equals("true")){
        out.print("<p style=\"color:red;\">Username or Password Invalid</p>");
    }}catch(Exception e) { }%>
        <form action="/store/login" method="post">
            <label>Username</label><input type="text" name="username" />
            <label>Password</label><input type="password" name="password" />
            <br/>
            <input type="submit" value="Login" name="button"/>
        </form>
    </body>
</html>
