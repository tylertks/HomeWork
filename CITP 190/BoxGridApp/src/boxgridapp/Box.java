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
public class Box {
    static final int MIN_X = 0;
    static final int MIN_Y = 0;
    int maxX;
    int maxY;
    int x = MIN_X;
    int y = MIN_Y;
    
    public Box(int xMax, int yMax)
    {
        maxX = xMax;
        maxY = yMax;
    }
    public int getX()
    {
        return x;
    }
    public int getY(){
        return y;
    }
    public void push(Vector v)
    {
        switch(v.getDirection()){
            case "U":
                y-=v.getMagnitude();
                if(y>maxY){y=maxY;}
                break;
            case "D":
                y+=v.getMagnitude();
                if(y<MIN_Y){y=MIN_Y;}
                break;
            case"L":
                x-=v.getMagnitude();
                if(x<MIN_X){x=MIN_X;}
                break;
            case"R":
                x+=v.getMagnitude();
                if(x>maxX){x=maxX;}
                break;
        }
    }
}
