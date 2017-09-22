/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Module3Milestone;

import java.sql.*;
import java.util.*;

/**
 *
 * @author tyler
 */
public class DatabaseUserDao implements DataAccessObject<User>{
    String dbURL = "jdbc:derby://localhost:1527/store;create=true";
    String tableName = "";
    Connection conn = null;
    Statement stmt = null;
    public DatabaseUserDao()
    {
        try{
            Class.forName("org.apache.derby.jdbc.ClientDriver").newInstance();
            conn = DriverManager.getConnection(dbURL);
            boolean exists = conn.getMetaData().getTables(null,null,"USER_T",null).next();
            System.out.println("Table USER_T exists = "+exists);
            if(!exists)
            {
                stmt = conn.createStatement();
                stmt.execute("CREATE TABLE USER_T (USERNAME VARCHAR(25), PASSWORD VARCHAR(500), ROLES VARCHAR(5000))");
                stmt.close();
            }
        }catch(Exception e){
            System.out.println(e);
        }
        
    }
    public void Connect()
    {
        try{
            Class.forName("org.apache.derby.jdbc.ClientDriver").newInstance();
            conn = DriverManager.getConnection(dbURL);
            boolean exists = conn.getMetaData().getTables(null,null,"USER_T",null).next();
            if(!exists)
            {
                stmt = conn.createStatement();
                stmt.execute("CREATE TABLE USER_T (USERNAME VARCHAR(25), PASSWORD VARCHAR(500), ROLES VARCHAR(5000))");
                stmt.close();
            }
            
        }catch(Exception e){
            System.out.println(e);
        }
    }
    @Override
    public List<User> readAll()
    {
        ResultSet results = null;
        List<User> list = new ArrayList<User>();
        try{
            stmt  = conn.createStatement();
            results = stmt.executeQuery("SELECT * FROM USER_T");
            while(results.next()) {
                User u = new User();
                u.setUsername(results.getString("USERNAME"));
                u.setPassword(results.getString("PASSWORD"));
                String roles = results.getString("ROLES");
                Set<String> r = new HashSet<>();
                if(roles.contains(User.ADMINISTRATOR)){
                    r.add(User.ADMINISTRATOR);
                }
                if(roles.contains(User.INVENTORY_MANAGER)){
                    r.add(User.INVENTORY_MANAGER);
                }
                u.setRoles(r);
                list.add(u);
            }
            results.close();
            stmt.close();
        }catch(Exception e){
            System.out.println(e);
        }
        
        return list;
    }
    @Override
    public User read(Object id)
    {
        String upc = id.toString();
        ResultSet results = null;
        User u = new User();
        try{
            stmt = conn.createStatement();
            System.out.println("Get user: "+upc);
            results = stmt.executeQuery(String.format("SELECT * FROM USER_T WHERE USERNAME = '%s'",upc));
            if(results.next()){
                u.setUsername(results.getString("USERNAME"));
                u.setPassword(results.getString("PASSWORD"));
                String roles = results.getString("ROLES");
                Set<String> r = new HashSet<>();
                if(roles.contains(User.ADMINISTRATOR)){
                    r.add(User.ADMINISTRATOR);
                }
                if(roles.contains(User.INVENTORY_MANAGER)){
                    r.add(User.INVENTORY_MANAGER);
                }
            u.setRoles(r);
            }            
            results.close();
            stmt.close();
        }catch(Exception e){
            System.out.println(e);
        }
        return u;
    }
    @Override
    public void create(User entity)
    {        
        List<User> list = readAll();
        boolean exists = false;
        for(int i = 0; i < list.size(); i++){
            if(list.get(i).getUsername().equals(entity.getUsername())){
                exists = true;
                break;
            }
        }
        if(!exists)
        {
        try{
            System.out.println(String.join("",entity.getRoles()));
            stmt = conn.createStatement();
            stmt.execute(String.format("INSERT INTO USER_T (USERNAME, PASSWORD, ROLES) VALUES ('%s', '%s', '%s')",entity.getUsername(), entity.getPassword(), String.join("",entity.getRoles())));
            stmt.close();
        }catch(Exception e){
            System.out.println(e);
        }
        }
    }
    @Override
    public void update(User entity){
        try{
            stmt = conn.createStatement();
            stmt.execute(String.format("UPDATE USER_T SET PASSWORD='%s', ROLES='%s', WHERE USERNAME='%s'",entity.getPassword(),String.join("",entity.getRoles()),entity.getUsername()));
            stmt.close();
        }catch(Exception e){
            System.out.println(e);
        }
    }
    @Override
    public void delete(Object id){
        String upc = id.toString();
        try{
            stmt = conn.createStatement();
            stmt.execute(String.format("DELETE FROM USER_T WHERE USERNAME='%s'",upc));
            stmt.close();
        }catch(Exception e){
            System.out.println(e);
        }
        
    }
}
