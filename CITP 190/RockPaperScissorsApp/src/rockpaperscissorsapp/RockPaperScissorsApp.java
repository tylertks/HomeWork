/*
 Tyler Sikkema
CITP 190
Rock, Paper, Scissors App
Allows user to play Rock, Paper, Scissors against Computer
 */
package rockpaperscissorsapp;
import java.util.*;
/**
 *
 * @author tyler
 */
public class RockPaperScissorsApp {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        boolean gameLoop = true;
        boolean inputLoop;
        Random rand = new Random();
        String userChoice="";
        String result="";
        System.out.println("Welcome to Rock, Paper, Scissors");
        while(gameLoop == true){
           inputLoop = true;
            while(inputLoop == true){
               System.out.print("Please select (R)ock, (P)aper, or (S)cissors: ");
               userChoice = scan.next();
               userChoice = userChoice.toUpperCase();
               if(userChoice.equals("R") || userChoice.equals("P") || userChoice.equals("S")){
                   inputLoop = false;
               }
               else{
                   System.out.println("Invalid Input");
               }
           }
            switch(userChoice){
                case "R":
                    System.out.println("You chose Rock");
                    break;
                case "P":
                    System.out.println("You chose Paper");
                    break;
                case "S":
                    System.out.println("You chose Scissors");
                    break;
            }
            //Generate Computer Choice. 0 is Rock, 1 is Paper, 2 is Scissors
            int cpuGenerate = rand.nextInt(3);
            switch(cpuGenerate){
                case 0:
                        System.out.println("Computer chooses Rock");
                        break;
                case 1:
                        System.out.println("Computer Chooses Paper");
                        break;
                case 2:
                        System.out.println("Computer Chooses Scissors");
                        break;
                default:
                    System.out.println("Invalid Computer Choice");
            }
            if(userChoice.equals("R")){
                if(cpuGenerate == 0){
                    result = "Draw!";
                }else if(cpuGenerate == 1){
                    result = "You Lose!";
                }else if(cpuGenerate == 2){
                    result = "You Win!";
                }
            }else if(userChoice.equals("P")){
                if(cpuGenerate == 0){
                    result = "You Win!";
                }else if(cpuGenerate == 1){
                    result = "Draw!";
                }else if(cpuGenerate == 2){
                    result = "You Lose!";
                }
            }else if(userChoice.equals("S")){
                if(cpuGenerate == 0){
                    result = "You Lose!";
                }else if(cpuGenerate == 1){
                    result = "You Win!";
                }else if(cpuGenerate == 2){
                    result = "Draw!";
                }
            }
            System.out.println(result);
            Boolean againLoop=true;
            String again="";
            while(againLoop == true){
                System.out.print("Would you like to play again (y/n)?");
                again = scan.next();
                again = again.toLowerCase();
                if(again.equals("y")){
                    againLoop = false;
                }else if(again.equals("n")){
                    againLoop = false;
                    gameLoop = false;
                }else{
                    System.out.println("Invalid Input.");
                }
            }
        }
        // TODO code application logic here
    }
    
}
