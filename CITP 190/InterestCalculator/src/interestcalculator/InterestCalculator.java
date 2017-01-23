/*
Tyler Sikkema
January 18, 2017
CITP 190
Interest Calculator
Calculates Compound Interest
 */
package interestcalculator;
import java.io.*;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author sikkemat
 */
public class InterestCalculator {
    /**
     * @param args the command line arguments
     */    
    public static void main(String[] args) {
      Scanner scan = new Scanner(System.in);
        String welcomeMessage = "Welcome to the interest calculator\n";
        System.out.print(welcomeMessage);
        System.out.print("\nPlease enter the principle amount: ");
        double amount = scan.nextDouble();
        System.out.print("Please enter the APR: ");
        double apr = scan.nextDouble();
        System.out.print("Please enter the amount of time (in years): ");
        int term = scan.nextInt();
        double accrued = amount * java.lang.Math.pow((1+apr/1200),12 * term);
        System.out.print("\nThe amount accrued is: "+accrued);
    }
    
}
