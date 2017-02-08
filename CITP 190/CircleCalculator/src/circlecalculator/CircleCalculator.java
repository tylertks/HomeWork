/*
Tyler Sikkema
CITP 190
Circle Calculator App
Takes an input (radius) and creates a circle, then prints the attributes
 */
package circlecalculator;
import java.util.*;
/**
 *
 * @author tyler
 */
public class CircleCalculator {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        System.out.println("Welcome to the circle calculator app.");
        Scanner scan = new Scanner(System.in);
        boolean loop = true;
        while(loop == true){
            System.out.print("Enter a radius: ");
            double inputRad = scan.nextDouble();            
            Circle circle = new Circle();
            circle.setRadius(inputRad);
            System.out.println("Diameter "+Double.toString(circle.getDiameter()));
            System.out.println("Circumfrence: "+Double.toString(circle.getCircumfrence()));
            System.out.println("Area: "+Double.toString(circle.getArea()));
            boolean againValidate = false;
            while(againValidate == false){
                System.out.print("Would you like to calculate another circle(y/n)? ");
                String again = scan.next();
                if(again.toLowerCase().equals("y")){
                    againValidate = true;
                }else if(again.toLowerCase().equals("n")){
                    againValidate = true;
                    loop=false;
                }else{
                    System.out.println("invalid input. please try again");
                }
            }
        }
    }
    
}
