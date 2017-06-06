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
import edu.lcc.citp.utility.*;
import java.io.*;
import java.util.*;

/**
 *
 * @author tyler
 */
public class InventoryManager {
    List<Product> productList = new ArrayList<Product>();
    CollectionFileStorageUtility inventory = new CollectionFileStorageUtility();
    public Product getProduct(String upc){
       try{
           productList = getProductList();
           for(Product p: productList){
               if(p.getUpc().equals(upc)){
                   return(p);
               }                 
           }
           System.out.println("Product not found");
           return null;
       }catch(Exception e){
           System.out.println("Error: "+e.toString());
           return null;
       }
    }
    /**
     * when called. Attempts to load a list of products from a local file using CollectionFileStorageUtility.
     * If this fails, returns an empty list.
     */
    public List<Product> getProductList()
    {
        try{
            return (List<Product>)inventory.load(Product.class);
        }catch(Exception e)
        {
            return productList;
        }         
    }
    /**
     * takes in a Product object and inserts the object into the ArrayList, then saves the ArrayList to a local file.
     */
    public void addProduct(Product p)
    {
        productList = getProductList();
        boolean newProduct = true;
        outLoop:
        for(Product i: productList){
            if(i.getUpc().equals(p.getUpc())){
                newProduct = false;
                break outLoop;
            }
        }
        if(newProduct){
            productList.add(p);
            save(productList);
        }else{
            System.out.println("Product already exists");
        }
    }
    /**
     * Takes in a Product Object, and searches for a matching object in the ArrayList.
     * If a matching object is found, asks for user input to update the Product information.
     * If no match is found, returns an error.
     */
    public void updateProduct(Product p, Scanner sc){
        productList = getProductList();
        outLoop:
        for(Product i:productList){
            if(i.getUpc().equals(p.getUpc()))
            {
                System.out.println("Input Short Details:");
                i.setShortDetails(sc.nextLine());
                System.out.println("Input Long Details: ");
                i.setLongDetails(sc.nextLine());
                boolean priceLoop = true;
                while(priceLoop){
                    try{
                        System.out.println("Input Price: ");
                        i.setPrice(sc.nextFloat());
                        priceLoop = false;
                    }catch(Exception e){
                        System.out.println("Invalid Input. Try Again.");
                    }
                    sc.nextLine();
                }
                boolean stockLoop = true;
                while(stockLoop){
                    try{
                        System.out.println("Input Stock: ");
                        i.setStock(sc.nextInt());                    
                        stockLoop = false;
                    }catch(Exception e){
                        System.out.println("Invalid Input. Try Again.");
                    }
                    sc.nextLine();
                }
                break outLoop;
            }
        }
        save(productList);
    }
    /**
     * Takes in a UPC and searches for a matching object to remove.
     * If no object is found returns an error.
     */
    public void removeProduct(String upc)
    {
        productList = getProductList();
        outLoop:
        for(int i=0; i<productList.size(); i++){
            if(productList.get(i).getUpc().equals(upc)){
                productList.remove(i);
                break outLoop;
            }
        }
        save(productList);
    }
    /**
     * Utilizes CollectionFileStorageUtility to save to a local file.
     */
    public void save(List<Product> list)
    {
        try
        {
            inventory.save((Collection<Product>)list, Product.class);
        }catch(Exception e){
            System.out.println("Error: "+e.toString());
        }
    }
    /**
     * Overrides the toString method to print the list of Products
     */
    @Override
    public String toString()
    {
        productList = getProductList();
        String s="Products:\n";
        for(int i = 0; i < productList.size(); i++)
        {
            s+=productList.get(i).toString()+"\n\n";
        }
        return s;
    }
}
