<%-- 
    Document   : inventory
    Created on : Jun 20, 2017, 1:30:54 PM
    Author     : tyler
--%>

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@page import="Module3Milestone.InventoryManager"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<jsp:useBean id = "inv" scope="application" class="Module3Milestone.InventoryServlet"></jsp:useBean>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Inventory Manager</title>
    </head>
    <body>
        <% InventoryManager in = new InventoryManager();
        pageContext.setAttribute("inventory", in.getProductList());
        %>
        <table>
        <tr><th>UPC</th><th>Short Details</th><th>Long Details</th><th>Price</th><th>Stock</th></tr>
        <c:out value="${test}" escapeXml="false"/>
        <c:forEach items="${inventory}" var="item">            
            <tr>
            <td>${item.getUpc()}</td>
            <td>${item.getShortDetails()}</td>
            <td>${item.getLongDetails()}</td>
            <td>${item.getPrice()}</td>
            <td>${item.getStock()}</td>            
                <td><form action="/store/inventory" method="post">
                    <input type="submit" name="button" value="Delete"/>
                    <input type="hidden" name="upc" value="${item.getUpc()}"/>
                    </form>
                </td>                
            </tr>
        </c:forEach>
        </table>
        <!--<c:forEach items="${inventory}" var="item">
            ${item}
        </c:forEach>-->
        <div><h3>New Product</h3>
            <form action="/store/inventory" method="post">
                <p><label>UPC</label><input type="text" name ="upc" size="20"/>
                    <label>Short Details</label><input type="text" name="shortDetails" size="20"/>
                    <label>Long Details</label><input type="text" name="longDetails" size="20"/>
                    <label>Price</label><input type="text" name="price" size="3"/>
                    <label>Stock</label><input type="text" name="stock" size="3"/></p>
                <p>
                    <input type="submit" value="Create" name="button"/>
                    <input type="hidden" name="redirect" value="/store/inventory"/>
                </p>
            </form>
        </div>
    </body>
</html>
