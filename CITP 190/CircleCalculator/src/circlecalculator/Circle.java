/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package circlecalculator;

/**
 *
 * @author tyler
 */
public class Circle {
    double rad;
    
    public void setRadius(double r)
    {
        rad = r;
    }
    public double getRadius()
    {
        return rad;
    }
    public double getDiameter()
    {
        return rad*2;
    }
    public double getCircumfrence()
    {
        return rad*2*Math.PI;
    }
    public double getArea()
    {
        return Math.PI*Math.pow(rad, 2);
    }
    
}
