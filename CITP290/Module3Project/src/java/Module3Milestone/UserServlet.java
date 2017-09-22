package Module3Milestone;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

import Module3Milestone.*;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.Collections;
import java.util.HashSet;
import java.util.List;
import java.util.Set;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

/**
 *
 * @author tyler
 */
@WebServlet(urlPatterns = {"/users"})
public class UserServlet extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    DataAccessObject<User> uDao = DataAccessObjectFactory.getUserDao();
    public void init(HttpServletRequest request, HttpServletResponse response) throws ServletException, java.io.IOException{
        DataAccessObject<User> uDao = DataAccessObjectFactory.getUserDao();
        this.getServletContext().setAttribute("userDao", uDao);
    }
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        try (PrintWriter out = response.getWriter()) {
            /* TODO output your page here. You may use following sample code. */
            out.println("<!DOCTYPE html>");
            out.println("<html>");
            out.println("<head>");
            out.println("<title>Servlet UserServlet</title>");            
            out.println("</head>");
            out.println("<body>");
            out.println("<h1>Servlet UserServlet at " + request.getContextPath() + "</h1>");
            out.println("</body>");
            out.println("</html>");
            
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        HttpSession session = request.getSession();
        if(session.getAttribute("currentUser")!=null){
            User u = DataAccessObjectFactory.getUserDao().read(session.getAttribute("currentUser"));
            if(u.getRoles().contains(User.ADMINISTRATOR)){
                response.sendRedirect("/store/users.jsp");
            }
            else{
                response.sendRedirect("/store/login");
            }
        }else{
            response.sendRedirect("/store/login");
        }
        //response.sendRedirect("/store/users.jsp");
        //processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        //processRequest(request, response);
        System.out.println(request.getParameter("button"));
        if("Create".equals(request.getParameter("button"))){
            User u = new User();
            Set<String> roles = new HashSet<String>();
            if(request.getParameter("Administrator")!=null){
                roles.add(User.ADMINISTRATOR);
            }
            if(request.getParameter("InventoryManager")!=null){
                roles.add(User.INVENTORY_MANAGER);
            }
            u.setRoles(roles);
            u.setUsername(request.getParameter("username"));
            u.setPassword(request.getParameter("password"));
        uDao.create(u);
        }else if("Delete".equals(request.getParameter("button"))){
            uDao.delete(request.getParameter("username"));
        }        
        response.sendRedirect("/store/users");
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
