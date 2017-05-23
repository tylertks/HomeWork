/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package module1project;

/**
 *
 * @author tyler
 */
import java.util.*;

public class Module1Project {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        System.out.println("Welcome to the Inventory Manager:");
        // TODO code application logic here
        Scanner sc = new Scanner(System.in);
        boolean mainLoop = true;
        InventoryManager inv = new InventoryManager();
        while(mainLoop){
            System.out.print("1. Show Products\n2. Find Product by UPC\n3. Add Product\n4. Update Product\n5. Remove Product\n6. Exit\n");
            int choice = sc.nextInt();
            switch(choice){
                case 1:
                    System.out.print(inv.toString());
                    break;
                case 2:
                    System.out.print("Enter UPC: ");
                    inv.getProduct(sc.nextLine());
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
    static public Product newProduct(Scanner sc)
    {
        sc.nextLine();
        Product p = new Product();
        System.out.println("Enter UPC");
        p.setUpc(sc.nextLine());
        System.out.println("Enter Short Details");
        p.setShortDetails(sc.nextLine());
        System.out.println("Enter Long Details");
        p.setLongDetails(sc.nextLine());
        System.out.println("Enter Price");
        p.setPrice(sc.nextBigDecimal());
        System.out.println("Enter Stock");
        p.setStock(sc.nextInt());
        
        return p;
    }
}
