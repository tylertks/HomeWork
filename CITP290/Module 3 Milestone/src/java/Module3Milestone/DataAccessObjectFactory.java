/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Module3Milestone;

/**
 *
 * @author tyler
 */
public class DataAccessObjectFactory {
    public static DataAccessObject<User> getUserDao(){
        return new FileUserDao();
    }
    public static DataAccessObject<Product> getProductDao(){
        return new FileProductDao();
    }
}