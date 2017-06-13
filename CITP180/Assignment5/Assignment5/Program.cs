using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool mainLoop = true;
            int select = 0;
            while (mainLoop)
            {
                Console.Write("" +
                    "+----------------------------+\n" +
                    "| Tyler Sikkema Assignment 5 |\n" +
                    "|============================|\n" +
                    "| 1. Integer Validation      |\n" +
                    "| 2. Hex Addition            |\n" +
                    "| 3. Triangle Check          |\n" +
                    "| 4. Print Triangle          |\n" +
                    "| 5. Calculate GPA           |\n" +
                    "| 6. Exit                    |\n" +
                    "+----------------------------+\n");
                if(int.TryParse(Console.ReadLine(),out select))
                {
                    switch (select)
                    {
                        case 1:
                            IntInput();
                            break;
                        case 2:
                            HexInput();
                            break;
                        case 3:
                            TriangleCheck();
                            break;
                        case 4:
                            PrintTriangle();
                            break;
                        case 5:
                            GPA();
                            break;
                        case 6:
                            mainLoop = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Input. Try Again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }
            }
        }
        static void IntInput()
        {
            int input = 0;
            int validNums = 0;
            int invalidNums = 0;
            int nonInts = 0;
            bool intLoop = true;
            while(intLoop)
            {
                Console.WriteLine("Input an integer between 1 and 100. Input 0 to exit.");
                if(int.TryParse(Console.ReadLine(), out input))
                {
                    if(input > 0 && input < 101)
                    {
                        validNums++;
                    }
                    else if(input == 0)
                    {
                        intLoop = false;
                    }
                    else
                    {
                        invalidNums++;
                    }

                }
                else
                {
                    nonInts++;
                }
            }
            Console.Write("" +
                "Number of Valid Numbers:     {0,3:#}\n" +
                "Number of Invalid Numbers:   {1,3:#}\n" +
                "Number of Non-Integer Values:{2,3:#}\n",validNums,invalidNums,nonInts);
        }
        static void HexInput()
        {
            bool hexLoop = true;
            string input = "";
            string validChars = "0123456789abcdef";
            int numValid = 0;
            while(hexLoop)
            {
                Console.WriteLine("Enter any number of hexadecimal digits");
                input = Console.ReadLine().ToLower();
                foreach(char c in input)
                {
                    foreach(char d in validChars)
                    {
                        if(c == d)
                        {
                            numValid++;
                            break;
                        }
                    }
                }
                if(numValid < input.Length)
                {
                    Console.WriteLine("Invalid Character in Input.");
                }
                else
                {
                    hexLoop = false;
                }                
            }
            int sum = 0;
            foreach(char c in input)
            {
                sum+= int.Parse(c.ToString(), System.Globalization.NumberStyles.HexNumber);
            }
            Console.WriteLine("Input hex values of {0} has a sum of {1}", input.ToUpper(), sum.ToString("X"));
        }
        static void TriangleCheck()
        {
            bool triLoop = true;
            int side1 = 0;
            int side2 = 0;
            int side3 = 0;
            bool validTri = true;
            while (triLoop)
            {
                side1 = IntCheck("Enter the length of side #1",0,1000);
                side2 = IntCheck("Enter the length of side #2", 0, 1000);
                side3 = IntCheck("Enter the length of side #3", 0, 1000);
                if (side1 + side2 > side3)
                {
                    if (side2 + side3 > side1)
                    {
                        if(side1+side3>side2)
                        {
                            validTri = true;
                        }
                        else
                        {
                            validTri = false;
                        }
                    }
                    else
                    {
                        validTri = false;
                    }
                }
                else
                {
                    validTri = false;
                }
                if (validTri)
                {
                    Console.WriteLine("Sides {0}, {1}, and {2} create a valid triangle.",side1,side2,side3);
                }
                else
                {
                    Console.WriteLine("Invalid Triangle.");
                }
                string again = "";
                while(again != "y" && again != "n")
                {
                    Console.WriteLine("Run Again(y/n)?");
                    again = Console.ReadLine().ToLower();
                    if(again == "y")
                    {
                        
                    }else if(again == "n")
                    {
                        triLoop = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Try Again.");
                    }
                }
            }
        }
        static void PrintTriangle()
        {
            bool triLoop = true;
            while (triLoop)
            {
                Console.WriteLine("Enter the character used to display the triangle.");
                Char c = '*';
                if (Char.TryParse(Console.ReadLine(), out c)) { }
                else { c = '*'; }
                int num = 3;
                Console.WriteLine("Enter the size of the Triangle (1-10)");
                if(int.TryParse(Console.ReadLine(), out num))
                {
                    if(num < 1 || num > 10){ num = 3; }
                }
                else { num = 3; }
                for(int i = 0; i <= num; i++)
                {
                    for(int j = 0; j < i; j++)
                    {
                        Console.Write(c);
                    }
                    Console.Write("\n");
                }
                for(int i = num-1; i >= 0; i--)
                {
                    for(int j = 0; j < i; j++)
                    {
                        Console.Write(c);
                    }
                    Console.Write("\n");
                }
                string again = "";
                while (again != "y" && again != "n")
                {
                    Console.WriteLine("Run Again(y/n)?");
                    again = Console.ReadLine().ToLower();
                    if (again == "y")
                    {

                    }
                    else if (again == "n")
                    {
                        triLoop = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Try Again.");
                    }
                }
            }
        }
        static void GPA()
        {
            string validGrades = "abcdef";
            float qualityPoints=0;
            int totalHours=0;
            int hours=0;
            bool gpaLoop = true;
            Char grade = ' ';
            while (gpaLoop)
            {
                bool gradeLoop = true;
                while (gradeLoop)
                {
                    Console.WriteLine("Enter a grade:");
                    if (Char.TryParse(Console.ReadLine().ToLower(), out grade))
                    {
                        foreach (Char c in validGrades)
                        {
                            if (grade == c)
                            {
                                gradeLoop = false;
                                break;
                            }
                        }
                        if (gradeLoop)
                        {
                            Console.WriteLine("Invalid Grade. Try Again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Try Again.");
                    }
                }
                hours = IntCheck("Enter the Credit Hours",0,6);
                totalHours += hours;
                switch (grade)
                {
                    case 'a':
                        qualityPoints += 4 * hours;
                        break;
                    case 'b':
                        qualityPoints += 3 * hours;
                        break;
                    case 'c':
                        qualityPoints += 2 * hours;
                        break;
                    case 'd':
                        qualityPoints += 1 * hours;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Press Enter to input another course. Any character to get your GPA.");
                if (Console.ReadLine() != "")
                {
                    gpaLoop = false;
                }
            }
            Console.WriteLine("Your earned GPA is {0,3:0.00}", (qualityPoints / totalHours));
        }
        static int IntCheck(string s)
        {
            int i = 0;
            bool checkLoop = true;
            while(checkLoop)
            {
                Console.WriteLine(s);
                if (int.TryParse(Console.ReadLine(), out i))
                {
                    return i;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }
            }
            return 0;
        }
        static int IntCheck(string s, int min, int max)
        {
            int i = 0;
            bool checkLoop = true;
            while(checkLoop)
            {
                Console.WriteLine(s);
                if (int.TryParse(Console.ReadLine(), out i))
                {
                    if(i > max)
                    {
                        Console.WriteLine("Input Too Large. Try Again.");
                    }
                    else if(i < min)
                    {
                        Console.WriteLine("Input Too Small. Try Again.");
                    }
                    else
                    {
                        checkLoop = false;
                        return i;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }
            }
            return 0;
        }
        static float floatCheck(string s, float min, float max)
        {
            float i = 0;
            bool checkLoop = true;
            while (checkLoop)
            {
                Console.WriteLine(s);
                if (float.TryParse(Console.ReadLine(), out i))
                {
                    if (i > max)
                    {
                        Console.WriteLine("Input Too Large. Try Again.");
                    }
                    else if (i < min)
                    {
                        Console.WriteLine("Input Too Small. Try Again.");
                    }
                    else
                    {
                        checkLoop = false;
                        return i;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }
            }
            return 0;
        }
    }
}
