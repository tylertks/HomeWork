package Module2Milestone;

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
    InventoryManager inv = new Module2Milestone.InventoryManager();
    
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, java.io.IOException
    {
        response.setContentType("text/html");
        java.io.PrintWriter out = response.getWriter();
        out.println("<html><head><title>Inventory</title></head><body>");        
        for(Product p: inv.getProductList())
        {
            out.print("<br/>"+p.toString());
        }
        //out.print(inv.toString());
        out.println("</body></html>");
        out.close();
    }
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, java.io.IOException
    {
        Product p = new Product();
        p.setUpc(request.getParameter("upc"));
        p.setShortDetails(request.getParameter("shortDetails"));
        p.setLongDetails(request.getParameter("longDetails"));
        p.setPrice(Float.parseFloat(request.getParameter("price")));
        p.setStock(Integer.parseInt(request.getParameter("stock")));
        inv.addProduct(p);
    }

}