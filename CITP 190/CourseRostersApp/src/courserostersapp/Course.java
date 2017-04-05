/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package courserostersapp;

import java.util.*;
/**
 *
 * @author tyler
 */
public class Course {
    String courseID;
    String courseName;
    String courseCode;
    Instructor instructor;
    final List<Student> roster = new ArrayList<>();

    
    public void setCourseId(String s)
    {
        courseID = s;
    }
    public String getCourseId()
    {
        return courseID;
    }
    public void setCourseName(String s)
    {
        courseName = s;
    }
    public String getCourseName()
    {
        return courseName;
    }
    public void setCourseCode(String s)
    {
        courseCode = s;
    }
    public String getCourseCode()
    {
        return courseCode;
    }
    public void setInstructor(Instructor i)
    {
        instructor = i;
    }
    public Instructor getInstructor()
    {
        return instructor;
    }
    public void addStudent(Student s)
    {
        roster.add(s);
    }
    public void removeStudent(String personID)
    {
        for(int i = 0;i<roster.size();i++)
        {
            if(roster.get(i).getPersonId().equals(personID))
            {
                roster.remove(i);
                break;
            }
        }
    }
    public String toString()
    {
        String out= "Course ID: "+courseID+"\n"+
                "Course Name: "+courseName+"\n"+
                "Course Code: "+courseCode+"\n"+
                "\n"+
                "Instructor\n"+
                "---------------------\n"+
                instructor.toString()+"\n"+
                "\n"+
                "Student Roster\n"+
                "---------------------\n";
        for(int i = 0; i < roster.size();i++){
            out+=roster.get(i).toString()+"\n";
        }
        return out;
    }
}
