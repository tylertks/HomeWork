/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package module1project;

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
    public List<Product> getProductList()
    {
        /*try{
            ObjectInputStream ois = new ObjectInputStream(new FileInputStream("products.txt"));
            return (List<Product>)ois.readObject();
        }catch(Exception e)
        {
            System.out.println("Error: "+e.toString());
            return null;
        }*/
        try{
            return (List<Product>)inventory.load(Product.class);
        }catch(Exception e)
        {
            //System.out.println("Error: "+e.toString());
            return productList;
        }         
    }
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
                System.out.println("Input Price: ");
                i.setPrice(sc.nextBigDecimal());
                sc.nextLine();
                System.out.println("Input Stock: ");
                i.setStock(sc.nextInt());
                sc.nextLine();
                break outLoop;
            }
        }
        save(productList);
    }
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
    public void save(List<Product> list)
    {
        try
        {
            inventory.save((Collection<Product>)list, Product.class);
        }catch(Exception e){
            System.out.println("Error: "+e.toString());
        }
    }
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
