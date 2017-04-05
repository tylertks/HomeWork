/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package courserostersapp;

/**
 *
 * @author tyler
 */
public class Instructor extends Person{
    String title;  
    String department;
    
    
    public void setTitle(String s){
        title=s;
    }
    public String getTitle()
    {
        return title;
    }
    public void setDepartment(String s)
    {
        department=s;
    }
    public String getDepartment()
    {
        return department;
    }
    public String toString()
    {
        return super.toString()+"\t"+title+"\t"+department;
    }
}
