package contactbookapp;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
import java.util.*;
import java.io.*;
/**
 *
 * @author tyler
 */
public class ContactFileManager {
    
    public void writeContacts(String s, ArrayList<Contact> a)
    {
        
        try{
        File dir = new File(".");
        File newFile = new File(dir.getAbsolutePath()+File.separator+s);
        FileOutputStream fout = new FileOutputStream(newFile);
        PrintStream out = new PrintStream(fout);
        
        for(Contact item: a)
        {
            out.print(item.getName()+"\n"+item.getAddress()+"\n"+item.getPhone()+"\n"+item.getEmail()+"\n");
        }
        }catch(Exception e){
            System.out.println("Unable to save file. "+e.toString());
        }
    }
    
    public ArrayList<Contact> readContacts(String s)
    {
        try{             
        FileReader fileRead = new FileReader(s);
        ArrayList<Contact> newList = new ArrayList<Contact>();
        String line = null;
        BufferedReader bufferedReader = new BufferedReader(fileRead);
        while((line = bufferedReader.readLine()) != null){
            
            newList.add(new Contact(line,bufferedReader.readLine(),bufferedReader.readLine(),bufferedReader.readLine()));
        }
        fileRead.close();
        return newList;
        }catch(Exception e){
            System.out.println("Unable to load file. "+e.toString());
            return null;
        }                
    }
    
}
