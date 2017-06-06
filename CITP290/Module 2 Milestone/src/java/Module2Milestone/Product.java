/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Module2Milestone;
/**
 *
 * @author tyler
 */
import java.io.*;
import java.math.*;
/**
 *
 * @author tyler
 */
public class Product implements Serializable{
    private String upc;
    private String shortDetails;
    private String longDetails;
    private float price;
    private int stock;
    
    public String getUpc()
    {
        return upc;
    }
    public void setUpc(String s)
    {
        upc = s;
    }
    public String getShortDetails()
    {
        return shortDetails;
    }
    public void setShortDetails(String s)
    {
        shortDetails = s;
    }
    public String getLongDetails()
    {
        return longDetails;
    }
    public void setLongDetails(String s)
    {
        longDetails = s;
    }
    public float getPrice()
    {
        return price;
    }
    public void setPrice(float i)
    {
        price = i;
    }
    public int getStock()
    {
        return stock;
    }
    public void setStock(int i)
    {
        stock = i;
    }
    public int compareTo(Product p)
    {
        return upc.compareTo(p.getUpc());
    }
    @Override
    public String toString()
    {
        String s = "UPC: " + upc +"\nshort details: "+shortDetails+"\nlong details: "+longDetails+"\nprice: $"+price+"\nstock: "+stock;
        return s;
    }
}
