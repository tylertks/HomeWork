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
        HttpSession session = request.getSession();
        if(session.getAttribute("currentUser")!=null){
            User u = DataAccessObjectFactory.getUserDao().read(session.getAttribute("currentUser"));
            if(u.getRoles().contains(User.INVENTORY_MANAGER)){
                response.sendRedirect("/store/inventory.jsp");
            }
            else{
                response.sendRedirect("/store/login");
            }
        }else{
            response.sendRedirect("/store/login");
        }
        
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