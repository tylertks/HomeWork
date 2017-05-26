/**
 * Serializable object. Contains variables for upc, short details, long details, price, and stock.
 * Overrides the toString method to output the information stored in these variables.
 */
package module1project;

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
    private BigDecimal price;
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
    public BigDecimal getPrice()
    {
        return price;
    }
    public void setPrice(BigDecimal i)
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
