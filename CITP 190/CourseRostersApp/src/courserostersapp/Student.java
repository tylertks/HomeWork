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
public class Student extends Person{
    String major;
    double gpa;
    
    public void setMajor(String s){
        major = s;
    }
    public String getMajor(){
        return major;
    }
    public void setGpa(double d){
        gpa =d;
    }
    public double getGpa(){
        return gpa;
    }
    public String toString()
    {
        return super.toString()+"\t"+major+"\t"+gpa;
    }
}
