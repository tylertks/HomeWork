/*
 Tyler Sikkema
CITP 190
Contact Book App
 */
package contactbookapp;
import java.util.*;
/**
 *
 * @author tyler
 */
public class ContactBookApp {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        ContactBook contacts = new ContactBook();
        Scanner scan = new Scanner(System.in);
        // TODO code application logic here
        boolean go = true;
        int select = 0;
        while(go)
        {
            System.out.print("What would you like to do\n1) List all Contacts\n2) Add a contact\n3) Update a contact\n4) Remove a contact\n5) Exit\n:");
            select = scan.nextInt();
            if(select < 5 && select > 0){
                switch(select){
                    case 1:
                        System.out.print(contacts.toString());
                        break;
                    case 2:
                        contacts.add(scan);
                        break;
                    case 3:
                        contacts.update(scan);
                        break;
                    case 4:
                        contacts.remove(scan);
                        break;
                    default:
                        System.out.println("you broke it.");
                        break;
                }
            }
            else if(select == 5){
                go=false;
            }
            else{
                System.out.println("Invalid input. please try again. ");
            }
        }
    }
    
}
