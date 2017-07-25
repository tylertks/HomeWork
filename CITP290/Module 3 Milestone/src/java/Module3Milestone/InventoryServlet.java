package Module3Milestone;

import java.math.BigDecimal;
import javax.servlet.http.*;
import javax.servlet.*;
import javax.servlet.annotation.*;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author tyler
 */
@WebServlet("/inventory")   
public class InventoryServlet extends HttpServlet{
    InventoryManager inv = new Module3Milestone.InventoryManager();
    DataAccessObject<Product> pDao = DataAccessObjectFactory.getProductDao();
    
    public void init(HttpServletRequest request, HttpServletResponse response) throws ServletException, java.io.IOException{
        
        this.getServletContext().setAttribute("productDao", pDao);
    }
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, java.io.IOException
    {
        /*response.setContentType("text/html");
        java.io.PrintWriter out = response.getWriter();
        out.println("<html><head><title>Inventory</title></head><body>");        
        out.println("<table>");
        out.println("<tr><th>UPC</th><th>Short Details</th><th>Long Details</th><th>Price</th><th>Stock</th></tr>");
        for(Product p: inv.getProductList())
        {
            out.print("<tr>");
            out.print("<td>"+p.getUpc()+"</td><td>"+p.getShortDetails()+"</td><td>"+p.getLongDetails()+"</td><td>$"+p.getPrice()+"</td><td>"+p.getStock()+"</td>");
            //out.print("<br/>"+p.toString());
        }
        out.println("</table>");
        //out.print(inv.toString());
        out.println("</body></html>");
        out.close();*/
        response.sendRedirect("/store/inventory.jsp");
    }
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, java.io.IOException
    {
        System.out.println(request.getParameter("button"));
        if("Create".equals(request.getParameter("button"))){
            Product p = new Product();
        p.setUpc(request.getParameter("upc"));
        p.setShortDetails(request.getParameter("shortDetails"));
        p.setLongDetails(request.getParameter("longDetails"));
        p.setPrice(Float.parseFloat(request.getParameter("price")));
        p.setStock(Integer.parseInt(request.getParameter("stock")));
        pDao.create(p);
        }else if("Delete".equals(request.getParameter("button"))){
            /*for(Product p: pDao.readAll()){
                if(p.getUpc().equals(request.getParameter("upc"))){
                    pDao.delete(p);
                }
            }*/
            pDao.delete(request.getParameter("upc"));
            System.out.println(request.getParameter("upc"));
        }        
        response.sendRedirect("/store/inventory.jsp");
    }
}