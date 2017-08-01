/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Module3Milestone;

import edu.lcc.citp.utility.CollectionFileStorageUtility;
import java.util.*;

/**
 *
 * @author tyler
 */
public class FileUserDao implements DataAccessObject<User>{
    List<User> userList = new ArrayList<User>();
    CollectionFileStorageUtility inventory = new CollectionFileStorageUtility();
    @Override
    public List<User> readAll(){
        try{
            return (List<User>)inventory.load(User.class);
        }catch(Exception e)
        {
            return new ArrayList<User>();
        } 
    }
    @Override
    public User read(Object id){
        try{
            String obj = String.class.cast(id);
            userList = readAll();
            for(User p: userList){
                 if(p.getUsername().equals(obj)){
                    return(p);
                }                 
            }
            System.out.println("User not found");
            return null;
        }catch(Exception e){
           System.out.println("Error: "+e.toString());
           return null;
        }
    }
    @Override
    public void create(User user){
        userList = readAll();
        boolean newProduct = true;
        outLoop:
        for(User i: userList){
            if(i.getUsername().equals(user.getUsername())){
                newProduct = false;
                break outLoop;
            }
        }
        if(newProduct){
            userList.add(user);
            save(userList);
        }else{
            System.out.println("Product already exists");
        }        
    }
    @Override
    public void update(User user){
        userList = readAll();
        boolean newUser = true;
        outLoop:
        for(User i: userList){
            if(i.getUsername().equals(user.getUsername())){
                newUser = false;
                break outLoop;
            }
        }
        if(!newUser){
            delete(user.getUsername());
            userList.add(user);
            save(userList);
        }else{
            System.out.println("User not found");
        }
    }
    @Override
    public void delete(Object id){
        String delUser = id.toString();
        userList = readAll();
        //System.out.println("User = "+read(id).getUsername());
        for (int i = 0; i < userList.size(); i++) {
            if(userList.get(i).getUsername().equals(delUser)){
                userList.remove(i);
                save(userList);
            }
        }
        //userList.remove(read(id));
    }
    public void save(List<User> list)
    {
        try
        {
            inventory.save((Collection<User>)list, User.class);
        }catch(Exception e){
            System.out.println("Error: "+e.toString());
        }
    }
}
