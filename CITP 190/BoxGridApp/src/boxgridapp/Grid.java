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
public class Grid {
    static final char WALL_TOP_BOTTOM = 0x2550;
    static final char WALL_LEFT_RIGHT = 0x2551;
    static final char WALL_TOP_LEFT_CORNER = 0x2554;
    static final char WALL_TOP_RIGHT_CORNER = 0x2557;
    static final char WALL_BOTTOM_LEFT_CORNER = 0x255A;
    static final char WALL_BOTTOM_RIGHT_CORNER = 0x255D;
    static final char BOX_CHAR = 0x2588;
    static final char EMPTY = 0x2591;
    int verticalSize;
    int horizontalSize;
    Box box;
    public void Grid(int vSize, int hSize)
    {
        verticalSize = vSize;
        horizontalSize = hSize;
    }
    public Box getBox(){
        return box;
    }
    public void Draw()
    {
        
    }
    }
}
