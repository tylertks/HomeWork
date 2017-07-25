<%-- 
    Document   : users
    Created on : Jul 18, 2017, 1:37:36 PM
    Author     : tyler
--%>

<%@page import="java.util.List"%>
<%@page import="Module3Milestone.*"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<jsp:useBean id = "users" scope="application" class="Module3Milestone.UserServlet"></jsp:useBean>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Inventory Manager</title>
    </head>
    <body>
        <% //InventoryManager in = new InventoryManager();
        //pageContext.setAttribute("inventory", in.getProductList());
        DataAccessObject userDao = new FileUserDao();
        pageContext.setAttribute("users", userDao.readAll());
        List<User> uList = userDao.readAll();
        pageContext.setAttribute("ulist",uList);
        %>
        ${ulist.get(0).getUsername()}
        <table border="1">
        <tr><th>Username</th><th>Password</th><th>Roles</th></tr>
        <c:forEach items="${ulist}" var="user">            
            <tr>
            <td>${user.getUsername()}</td>
            <td>${user.getPassword()}</td>
            <td>${user.getRoles()}</td>
                <td><form action="/store/users" method="post">
                    <input type="submit" name="button" value="Delete"/>
                    <input type="hidden" name="username" value="${item}"/>
                    </form>
                </td>                
            </tr>
        </c:forEach>
        </table>
        <div><h3>New User</h3>
            <form action="/store/users" method="post">
                <p><label>Username</label><input type="text" name ="username" size="20"/>
                    <label>Password</label><input type="password" name="password" size="20"/>
                    <input type="checkbox" name="Administrator"/><label>Administrator</label>
                    <input type="checkbox" name="InventoryManager"/><label>Inventory Manager</label>
                <p>
                    <input type="submit" value="Create" name="button"/>
                    <input type="hidden" name="redirect" value="/store/users"/>
                </p>
            </form>
        </div>
    </body>
</html>