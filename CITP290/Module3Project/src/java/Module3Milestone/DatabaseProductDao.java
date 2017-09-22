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
public class DatabaseProductDao implements DataAccessObject<Product>{
    String dbURL = "jdbc:derby://localhost:1527/store;create=true";
    String tableName = "";
    Connection conn = null;
    Statement stmt = null;
    public DatabaseProductDao()
    {
        try{
            Class.forName("org.apache.derby.jdbc.ClientDriver").newInstance();
            conn = DriverManager.getConnection(dbURL);
            boolean exists = conn.getMetaData().getTables(null,null,"PRODUCT",null).next();
            System.out.println("Product Table = "+exists);
            if(!exists)
            {
                stmt = conn.createStatement();
                System.out.println("CREATE TABLE PRODUCT (UPC VARCHAR(25), SHORT_DETAILS(50), LONG_DETAILS(5000), PRICE DECIMAL(10,2), STOCK INTEGER, PRIMARY KEY(UPC))");
                stmt.execute("CREATE TABLE PRODUCT (UPC VARCHAR(25), SHORT_DETAILS VARCHAR(50), LONG_DETAILS VARCHAR(5000), PRICE DECIMAL(10,2), STOCK INTEGER, PRIMARY KEY(UPC))");
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
            boolean exists = conn.getMetaData().getTables(null,null,"PRODUCT",null).next();
            if(!exists)
            {
                stmt = conn.createStatement();
                stmt.execute("CREATE TABLE PRODUCT (UPC VARCHAR(25), SHORT_DETAILS(50), LONG_DETAILS(5000), PRICE DECIMAL(10,2), STOCK INTEGER, PRIMARY KEY(UPC));");
                stmt.close();
            }
        }catch(Exception e){
            System.out.println(e);
        }
    }
    @Override
    public List<Product> readAll()
    {
        ResultSet results = null;
        List<Product> list = new ArrayList<Product>();
        try{
            stmt  = conn.createStatement();
            results = stmt.executeQuery("SELECT * FROM PRODUCT");
            while(results.next()) {
                Product p = new Product();
                p.setUpc(results.getString("UPC"));
                p.setShortDetails(results.getString("SHORT_DETAILS"));
                p.setLongDetails(results.getString("LONG_DETAILS"));
                p.setPrice(results.getFloat("PRICE"));
                p.setStock(results.getInt("STOCK"));
                list.add(p);
            }
            results.close();
            stmt.close();
        }catch(Exception e){
            System.out.println(e);
        }
        
        return list;
    }
    @Override
    public Product read(Object id)
    {
        String upc = id.toString();
        ResultSet results = null;
        Product p = new Product();
        try{
            stmt = conn.createStatement();
            results = stmt.executeQuery(String.format("SELECT * FROM PRODUCT WHERE UPC = '%s'",upc));
            p.setUpc(results.getString("UPC"));
            p.setShortDetails(results.getString("SHORT_DETAILS"));
            p.setLongDetails(results.getString("LONG_DETAILS"));
            p.setPrice(results.getFloat("PRICE"));
            p.setStock(results.getInt("STOCK"));
            results.close();
            stmt.close();
        }catch(Exception e){
            System.out.println(e);
        }
        return p;
    }
    @Override
    public void create(Product entity)
    {        
        try{
            stmt = conn.createStatement();
            stmt.execute(String.format("INSERT INTO PRODUCT (UPC, SHORT_DETAILS, LONG_DETAILS, PRICE, STOCK) VALUES ('%s','%s','%s',%f,%d)",entity.getUpc(),entity.getShortDetails(),entity.getLongDetails(),entity.getPrice(),entity.getStock()));
            stmt.close();
        }catch(Exception e){
            System.out.println(e);
        }
    }
    @Override
    public void update(Product entity){
        try{
            stmt = conn.createStatement();
            stmt.execute(String.format("UPDATE PRODUCT SET SHORT_DETAILS='%s', LONG_DETAILS='%s', Price=%f, STOCK=%d, WHERE UPC='%s'",entity.getShortDetails(), entity.getLongDetails(), entity.getPrice(), entity.getStock(), entity.getUpc()));
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
            stmt.execute(String.format("DELETE FROM PRODUCT WHERE UPC='%s'",upc));
            stmt.close();
        }catch(Exception e){
            System.out.println(e);
        }
        
    }
    
}
