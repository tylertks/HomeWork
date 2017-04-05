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
public class Person implements Comparable<Person>{
    String personID;
    String lastName;
    String firstName;
    

    
    public void setPersonId(String id)
    {
        personID = id;
    }
    public String getPersonId()
    {
        return personID;
    }
    public void setLastName(String s)
    {
        lastName =s;
    }
    public String getLastName()
    {
        return lastName;
    }
    public void setFirstName(String s)
    {
        firstName = s;
    }
    public String getFirstName()
    {
        return firstName;
    }
    public String toString()
    {
        return personID + "\t"+lastName+"\t"+firstName;
    }
    public int compareTo(Person p){
        if(p.getLastName().equals(lastName))
        {
            return firstName.compareTo(p.getFirstName());
        }
        else
        {
            return lastName.compareTo(p.getLastName());
        }
    }
}
