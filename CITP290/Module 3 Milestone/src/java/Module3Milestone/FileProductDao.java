/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Module3Milestone;

import edu.lcc.citp.utility.CollectionFileStorageUtility;
import java.util.ArrayList;
import java.util.Collection;
import java.util.List;

/**
 *
 * @author tyler
 */
public class FileProductDao implements DataAccessObject<Product>{
    CollectionFileStorageUtility inventory = new CollectionFileStorageUtility();
    List<Product> productList = new ArrayList<Product>();
    @Override
    public List<Product> readAll(){
        try{
            return (List<Product>)inventory.load(Product.class);
        }catch(Exception e)
        {
            return new ArrayList<Product>();
        } 
    }
    @Override
    public Product read(Object id){
     try{
           productList = readAll();
           for(Product p: productList){
               if(p==id){
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
    @Override
    public void create(Product product){
        productList = readAll();
        boolean newProduct = true;
        outLoop:
        for(Product i: productList){
            if(i.getUpc().equals(product.getUpc())){
                newProduct = false;
                break outLoop;
            }
        }
        if(newProduct){
            productList.add(product);
            save(productList);
        }else{
            System.out.println("Product already exists");
        }
    }
    @Override
    public void update(Product product){
        productList = readAll();
        boolean newProduct = true;
        outLoop:
        for(Product i: productList){
            if(i.getUpc().equals(product.getUpc())){
                newProduct = false;
                break outLoop;
            }
        }
        if(!newProduct){
            delete(product);
            productList.add(product);
            save(productList);
        }else{
            System.out.println("Product not found");
        }
    }
    @Override
    public void delete(Object id){
        for(Product p: productList){
            if(p==id){
                productList.remove(id);
            }
        }
        productList.remove(id);
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
}
