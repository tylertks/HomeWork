/*
 * Tyler Sikkema
 * CITP 290
 * Java Refresher
 */
package module.pkg1.milestone;

/**
 *
 * @author tyler
 */
import java.util.*;
public class Module1Milestone {

    /**
     * @param args the command line arguments
     */
    
    public static void main(String[] args) {
        // TODO code application logic here
        
        
        Scanner sc = new Scanner(System.in);
        boolean go = true;
        //Application Loop
        while(go)
        {
            //Menu
            System.out.print("1 - Hello, World!\n2 - Integer Divider\n3 - Word Sorter\n4 - Exit\n");
            int i = 0;
                //try to validate input
            try{
                i = sc.nextInt();
                if(i > 0 && i <= 4){
                    if(i==4){
                     go=false;   
                    }                            
                }
            }catch(Exception e){
                i=0;
            }
            switch(i){
                case 1:
                    helloWorld(sc);
                    break;
                case 2:
                    divide(sc);
                    break;
                case 3:
                    sort(sc);
                    break;
                default:
                    sc.nextLine();
                    System.out.println("Invalid Input. Try again.");
                    break;
            }
        }
    }
    public static void helloWorld(Scanner sc){
        sc.nextLine();
        System.out.print("Please Input Your Name: ");
        String name = sc.nextLine();
        System.out.println("Hello, "+name+"!");
    }
    public static void divide(Scanner sc){
        sc.nextLine();
        int int1 = 0;
        int int2 = 0;
        for(int i = 0; i<2; i++)
        {
            boolean validate = false;
            while(!validate)
            {
                try{
                    if(i<1){
                        System.out.print("Please input your first integer: ");
                        int1= sc.nextInt();  
                        validate = true;
                    }else{
                        System.out.print("Please input your second integer: ");
                        int2 = sc.nextInt();
                        if(int2 == 0){
                            System.out.println("Cannot divide by zero.");
                            validate = false;
                        }else{
                            validate = true;
                        }                        
                    }
                }catch(Exception e){
                    System.out.println("Invalid Input");
                    sc.nextLine();
                }
            }
        }
        System.out.println(int1 + " / " +int2+" = "+int1/int2 +" remainder "+int1%int2 );
    }
    public static void sort(Scanner sc){
        sc.nextLine();
        List<String> words = new ArrayList<String>();
        boolean addWords = true;
        while(addWords){
            System.out.print("Please input a word: ");
            words.add(sc.nextLine());
            boolean validate = false;
            while(!validate){
                System.out.print("would you like to add another word (y/n): ");
                String answer = sc.nextLine();
                if(answer.toLowerCase().equals("y") || answer.toLowerCase().equals("n")){
                    validate = true;
                    if(answer.toLowerCase().equals("n")){
                        addWords=false;
                    }
                }else{
                    System.out.println("Invalid Input.");
                }
            }            
        }
        Collections.sort(words);
        System.out.println("Words in alphabetical order: ");
        for(String i:words){
            System.out.println(i);
        }
    }    
}
