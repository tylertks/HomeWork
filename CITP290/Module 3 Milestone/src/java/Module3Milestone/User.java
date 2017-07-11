/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Module3Milestone;

import java.util.*;

/**
 *
 * @author tyler
 */
public class User implements java.io.Serializable{
    public static String ADMINISTRATOR = "ADMIN";
    public static String INVENTORY_MANAGER = "INV_MAN";
    private String username;
    private String password;
    private Set<String> roles;
    /**
     * @return the username
     */
    public String getUsername() {
        return username;
    }

    /**
     * @param username the username to set
     */
    public void setUsername(String username) {
        this.username = username;
    }

    /**
     * @return the password
     */
    public String getPassword() {
        return password;
    }

    /**
     * @param password the password to set
     */
    public void setPassword(String password) {
        this.password = password;
    }

    /**
     * @return the roles
     */
    public Set<String> getRoles() {
        return roles;
    }

    /**
     * @param roles the roles to set
     */
    public void setRoles(Set<String> roles) {
        this.roles = roles;
    }
    
    public boolean isAdministrator()
    {
        return roles.contains(ADMINISTRATOR);
    }
    public boolean isInventoryManager()
    {
        return roles.contains(INVENTORY_MANAGER)||roles.contains(ADMINISTRATOR);
    }
}
