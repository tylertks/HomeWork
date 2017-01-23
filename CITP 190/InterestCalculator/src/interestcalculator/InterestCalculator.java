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
        InputStreamReader r=new InputStreamReader(System.in);  
        BufferedReader br=new BufferedReader(r);
        // TODO code application logic here
        String welcomeMessage = "Welcome to the interest calculator\n";
        System.out.print(welcomeMessage);
        System.out.print("Enter your principal amount: ");
        String userInput = "";
        try {
            userInput = br.readLine();
        } catch (IOException ex) {
            Logger.getLogger(InterestCalculator.class.getName()).log(Level.SEVERE, null, ex);
        }
        double amount = Double.parseDouble(userInput);
        System.out.print("Enter the APR: ");
        try {
            userInput = br.readLine();
        } catch (IOException ex) {
            Logger.getLogger(InterestCalculator.class.getName()).log(Level.SEVERE, null, ex);
        }
        double apr = Double.parseDouble(userInput);
        System.out.print("Enter the term (in years): ");
        try {
            userInput = br.readLine();
        } catch (IOException ex) {
            Logger.getLogger(InterestCalculator.class.getName()).log(Level.SEVERE, null, ex);
        }
        int term = Integer.parseInt(userInput);      
        double accrued = amount * java.lang.Math.pow((1+apr/1200),12 * term);
        System.out.print("The amount accrued is: "+accrued);
    }
    
}
