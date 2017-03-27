/*
 Tyler Sikkema
CITP 190
BoxGridApp
Draw a grid with a box in it. User can move the box
 */
package boxgridapp;
import java.util.*;
/**
 *
 * @author tyler
 */
public class BoxGridApp {

    /**
     * @param args the command line arguments
     */
    
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        Grid grid = new Grid(10,10);
        String userInput="";
        while(!userInput.toUpperCase().equals("E")){
            grid.draw();
            boolean validInput = false;
            while(!validInput){
                System.out.print("Enter (U)p, (D)own, (L)eft, (R)ight, or (E)xit: ");
                userInput=scan.next();
                if(userInput.toUpperCase().equals("U")||userInput.toUpperCase().equals("D")||userInput.toUpperCase().equals("L")||userInput.toUpperCase().equals("R")||userInput.toUpperCase().equals("E")){
                    validInput=true;
                }else{
                    System.out.println(userInput+" is an Invalid Input");
                }
            }
            if(!userInput.toUpperCase().equals("E")){
               String direction = userInput.toUpperCase();
               boolean validInt = false;
               int magnitude=0;
               while(!validInt){
                   System.out.print("Enter a magnitude (integer): ");
                   //int magnitude = scan.nextInt();
                   userInput = scan.next();
                   try{
                       magnitude=Integer.parseInt(userInput);
                       validInt=true;
                   }catch(Exception e){
                       System.out.println("Invalid Input");
                   }
               }
               
               Vector vector = new Vector(direction,magnitude);
               grid.getBox().push(vector);   
            }            
        }
    }
    
}
