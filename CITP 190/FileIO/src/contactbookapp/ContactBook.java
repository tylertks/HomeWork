/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package contactbookapp;

import java.util.*;


/**
 *
 * @author tyler
 */
public class ContactBook {
   ArrayList<Contact> entries = new ArrayList<Contact>();
   ContactFileManager fileMan = new ContactFileManager(); 
   
    public ContactBook()
    {
        
    }
    public void add(Scanner s)
    {
        add(s,entries.size());
    }
    public void add(Scanner s, int i)
    {
        s.nextLine();
        System.out.println("Enter the contacts information");
        System.out.println("name: ");
        String name = s.nextLine();
        System.out.print("address: ");
        String address = s.nextLine();
        System.out.print("phone: ");
        String phone = s.nextLine();
        System.out.print("email: ");
        String email = s.nextLine();
        entries.add(i, new Contact(name,address,phone,email));
    }
    public void update(Scanner s){
        System.out.print(this.toString());
        boolean validateNum = false;
        int contactNum = -1;
        int updateNum = -1;
        while(validateNum == false){
            System.out.println("Select a contact number: ");
            contactNum = s.nextInt();
            if(contactNum < entries.size()){
                validateNum = true;
            }else{
                System.out.println("Invalid selection, please try again.");
            }
        }        
        while(updateNum == -1){
            System.out.println("Select information to update:\n1. Name\n2. Address\n3. Phone\n4. Email\n5. All");
            updateNum = s.nextInt();
            switch(updateNum)
            {
                case 1:
                    System.out.println("Enter new name: ");
                    entries.get(contactNum).setName(s.next());
                    break;
                case 2:
                    System.out.println("Enter new address: ");
                    entries.get(contactNum).setAddress(s.next());
                    break;
                case 3:
                    System.out.println("Enter new phone: ");
                    entries.get(contactNum).setPhone(s.next());
                    break;
                case 4:
                    System.out.println("Enter new email: ");
                    entries.get(contactNum).setEmail(s.next());
                    break;
                case 5:
                    entries.remove(contactNum);
                    add(s,contactNum);
                    break;
                default:
                    System.out.println("you broke it.");
                    break;
            }   
        }
    }
    public void remove(Scanner s){
        if(entries.size()>0)
        {
            System.out.print(this.toString());
            boolean validateNum = false;
            int contactNum = -1;
            while(validateNum == false){
                System.out.print("Select a contact number: ");
                contactNum = s.nextInt();
                if(contactNum < entries.size()){
                    validateNum = true;
                }else{
                    System.out.println("Invalid selection, please try again.");
                }
            } 
            entries.remove(contactNum);
        }
        else
        {
            System.out.println("No contacts. Select another option");
        }
        
    }
   @Override
    public String toString()
    {
        String out="";
        for (int i = 0; i < entries.size(); i++) {
            out+=String.valueOf(i);
            out+=", "+entries.get(i).toString();
            out+="\n";            
        }
        return out;
    }
    
    public void save(Scanner s)
    {
        System.out.println();
        s.nextLine();
        System.out.println("What would you like to save the file as?");
        String filename = s.nextLine();
        System.out.println("file name = "+filename);
        System.out.println("entries = "+entries.toString());
        fileMan.writeContacts(filename, entries);       
        System.out.println("file saved");
    }
    public void load(Scanner s)
    {
        s.nextLine();
        System.out.println("What is the name of the contact book you would like to load?");
        String filename = s.nextLine();
        try{
            entries = fileMan.readContacts(filename);
        }catch(Exception e){
            System.out.println("Unable to load file. "+e.toString());
        }

    }
}
