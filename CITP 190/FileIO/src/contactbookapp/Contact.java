/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package contactbookapp;

/**
 *
 * @author tyler
 *
 */

public class Contact implements java.io.Serializable{
    String name;
    String address;
    String phone;
    String email;
    
    public Contact(String n, String a, String p, String e)
    {
        name = n;
        address = a;
        phone = p;
        email = e;
    }
    
    public void setName(String s)
    {
        name = s;
    }
    public String getName()
    {
        return name;
    }
    public void setAddress(String s)
    {
        address = s;
    }
    public String getAddress()
    {
        return address;
    }
    public void setPhone(String s)
    {
        phone = s;
    }
    public String getPhone()
    {
        return phone;
    }
    public void setEmail(String s)
    {
        email = s;
    }
    public String getEmail()
    {
        return email;
    }
    @Override
    public String toString()
    {
        return "Name: " + name +", address: "+address+", phone: "+phone+", email: "+email;
    }
    
}
