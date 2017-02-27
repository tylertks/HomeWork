/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package boxgridapp;

/**
 *
 * @author tyler
 */
public class Vector {
    String direction;
    int magnitude;
    
    public void Vector(String s, int i)
    {
        direction = s;
        magnitude = i;
    }
    public String getDirection()
    {
        return direction;
    }
    public int getMagnitude()
    {
        return magnitude;
    }
}
