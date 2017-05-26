/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package module1project;

/**
 *
 * @author Tyler Sikkema
 * Module 1 Project maintains a list of products including their upc, description, price, and amount.
 * Saving to a local file is done with the CollexctionFileStorageUtility class.
 */
import java.util.*;

public class Module1Project {

    /**
     * The main class creates a loop for the main menu.
     * This menu creates options for:
     *      showing the list of products
     *      searching by upc
     *      adding new products
     *      updating an existing product by upc
     *      removing products
     *      exiting the program.
     * Any input that it not a number will return an error and restart the loop. Any number other than 1-5 will exit the program.
     * Adding a product will call the newProduct function.
     * All other commands will ask for a UPC if appropriate, and call the corresponding function in the Inventory Manager class.
     */
    public static void main(String[] args) {
        System.out.println("Welcome to the Inventory Manager:");
        // TODO code application logic here
        Scanner sc = new Scanner(System.in);
        boolean mainLoop = true;
        InventoryManager inv = new InventoryManager();
        int choice = 0;
        while(mainLoop){
            boolean menuLoop = true;
            while(menuLoop){
                System.out.print("1. Show Products\n2. Find Product by UPC\n3. Add Product\n4. Update Product\n5. Remove Product\n6. Exit\n");
                try{
                    choice = sc.nextInt();
                    menuLoop = false;
                }catch(Exception e){
                    System.out.println("Invalid Input. Try Again.");
                    sc.nextLine();
                }
            }            
            sc.nextLine();
            switch(choice){
                case 1:
                    System.out.print(inv.toString());
                    break;
                case 2:
                    System.out.print("Enter UPC: ");
                    System.out.println(inv.getProduct(sc.nextLine()).toString());
                    break;
                case 3:
                    inv.addProduct(newProduct(sc));
                    break;
                case 4:
                    System.out.print("Enter UPC: ");
                    inv.updateProduct(inv.getProduct(sc.nextLine()), sc);
                    break;
                case 5:
                    System.out.print("Enter UPC: ");
                    inv.removeProduct(sc.nextLine());
                    break;
                default:
                    mainLoop = false;
                    break;
                    
            }
        }
    }
    /**
     * This function is called from the main menu and asks the user for all necessary information for a new product.
     * This includes: UPC, Short Details, Long Details, Price, and Stock.
     */
    static public Product newProduct(Scanner sc)
    {
        Product p = new Product();
        System.out.println("Enter UPC");
        p.setUpc(sc.nextLine());
        System.out.println("Enter Short Details");
        p.setShortDetails(sc.nextLine());
        System.out.println("Enter Long Details");
        p.setLongDetails(sc.nextLine());
        boolean priceLoop  = true;
        while(priceLoop){
            try{
                System.out.println("Enter Price");
                p.setPrice(sc.nextBigDecimal());
                priceLoop = false;
            }catch(Exception e){
                System.out.println("Invalid Input. Try Again.");
                sc.nextLine();
            }
        }
        boolean stockLoop = true;
        while(stockLoop){
            try{
                System.out.println("Enter Stock");
                p.setStock(sc.nextInt());
                stockLoop = false;
            }catch(Exception e){
                System.out.println("Invalid Input. Try Again.");
                sc.nextLine();
            }
        }       
        return p;
    }
}
