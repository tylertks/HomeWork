using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool mainLoop = true;
            int option = 0;
            while(mainLoop)
            {
                Console.WriteLine("Tyler Sikkema Assignment 4");
                Console.WriteLine("+------------------------+");
                Console.WriteLine("|        Main Menu       |");
                Console.WriteLine("|------------------------|");
                Console.WriteLine("| 1. Roman Numerals      |");
                Console.WriteLine("| 2. BMI                 |");
                Console.WriteLine("| 3. Take-Home Pay       |");
                Console.WriteLine("| 4. Profit              |");
                Console.WriteLine("| 5. Exit                |");
                Console.WriteLine("+------------------------+");
                Console.Write("Select one option: ");
                if(int.TryParse(Console.ReadLine(), out option))
                {
                    switch(option)
                    {
                        case 1:
                            Roman r = new Roman();
                            Console.WriteLine(r.GetRoman());
                            break;
                        case 2:
                            BMI();
                            break;
                        case 3:
                            Pay();
                            break;
                        case 4:
                            Profits();
                            break;
                        default:
                            mainLoop = false;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }
            }            
        }
        static void BMI()
        {
            BMI b = new BMI();
            bool unitLoop = true;
            float height = 0;
            float weight = 0;
            while (unitLoop)
            {
                Console.WriteLine("Would you like to use (I)mperial or (M)etric Units?");
                string iorm = Console.ReadLine().ToLower();
                if (iorm == "i")
                {
                    unitLoop = false;
                    bool heightLoop = true;
                    while (heightLoop)
                    {
                        Console.WriteLine("Enter your height in inches");
                        if (float.TryParse(Console.ReadLine(), out height))
                        {
                            heightLoop = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Try Again.");
                        }
                    }
                    bool weightLoop = true;
                    while (weightLoop)
                    {
                        Console.WriteLine("Enter your weight in pounds");
                        if (float.TryParse(Console.ReadLine(), out weight))
                        {
                            weightLoop = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Try Again.");
                        }
                    }
                    Console.WriteLine("With a height of {0} inches and a weight of {1} pounds, you are considered {2}.", height.ToString(), weight.ToString(), b.CalculateImperial(height, weight));
                }
                else if (iorm == "m")
                {
                    unitLoop = false;
                    bool heightLoop = true;
                    while (heightLoop)
                    {
                        Console.WriteLine("Enter your height in meters");
                        if (float.TryParse(Console.ReadLine(), out height))
                        {
                            heightLoop = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Try Again.");
                        }
                    }
                    bool weightLoop = true;
                    while (weightLoop)
                    {
                        Console.WriteLine("Enter your weight in kilograms");
                        if (float.TryParse(Console.ReadLine(), out weight))
                        {
                            weightLoop = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Try Again.");
                        }
                    }
                    Console.WriteLine("With a height of {0} meters and a weight of {1} kilograms, you are considered {2}", height.ToString(), weight.ToString(), b.CalculateMetric(height, weight));
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }
            }
        }
        static void Pay()
        {
            string firstN = "";
            string lastN = "";
            string id = "";
            bool hourly = true;
            float salary = 0;
            float wage = 0;
            float hours = 0;
            bool firstLoop = true;
            Console.Write("Employee's First Name: ");
            firstN = Console.ReadLine();
            Console.Write("Employee's Last Name: ");
            lastN = Console.ReadLine();
            Console.Write("ID Number: ");
            id = Console.ReadLine();
            bool typeLoop = true;
            while(typeLoop)
            {
                Console.Write("Is the employee (S)alaried or (H)ourly? ");
                string type = Console.ReadLine().ToLower();
                if(type == "s")
                {
                    hourly = false;
                    typeLoop = false;
                }
                else if(type == "h")
                {
                    hourly = true;
                    typeLoop = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }
            }
            if(hourly)
            {
                bool wageLoop = true;
                while(wageLoop)
                {
                    Console.Write("Enter Employee wage: $");
                    if(float.TryParse(Console.ReadLine(), out wage))
                    {
                        wageLoop = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Try Again.");
                    }
                }
                bool hourLoop = true;
                while(hourLoop)
                {
                    Console.Write("Enter Numer of Hours: ");
                    if(float.TryParse(Console.ReadLine(), out hours))
                    {
                        hourLoop = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Try Again.");
                    }
                }
                Pay p = new Pay(firstN,lastN,id,wage,hours);
                Console.Write(p.GetTakeHome());
            }
            else
            {
                bool salaryLoop = true;
                while(salaryLoop)
                {
                    Console.Write("Enter employee salary: $");
                    if(float.TryParse(Console.ReadLine(), out salary))
                    {
                        salaryLoop = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Try Again.");
                    }
                }
                Pay p = new Assignment4.Pay(firstN, lastN, id, salary);
                Console.Write(p.GetTakeHome());
            }
        }
        static void Profits()
        {
            Decimal sales = 0;
            float profits = 0;
            bool profitLoop = true;
            while(profitLoop)
            {
                Console.WriteLine("Enter the total amount of profits.");
                Console.Write("$");
                if(Decimal.TryParse(Console.ReadLine(), out sales))
                {
                    if (sales > 0)
                    {
                        profitLoop = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Value. Try Again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }
            }
            if(sales <= 1000)
            {
                profits = .03f;
            }
            else if(sales > 1000 && sales <= 5000)
            {
                profits = .035f;
            }
            else if(sales > 5000 && sales <= 10000)
            {
                profits = .04f;
            }
            else
            {
                profits = .045f;
            }
            Console.Write("" +
                "Total Sales:  {0,20:$#,0.00}\n" +
                "Profit Margin:{1,20:0.0%}\n" +
                "Profits:      {2,20:$#,0.00}\n", sales, profits,((float)sales*profits));
        }
    }
    class Roman
    {
        public string GetRoman()
        {
            int num1 = 0;
            bool validLoop = true;
            string roman = "";
            while(validLoop)
            {
                Console.WriteLine("Input a value between 1 and 10");
                if (int.TryParse(Console.ReadLine(), out num1))
                {
                    if(num1 > 0 && num1 < 11)
                    {
                        validLoop = false;
                        if(num1 == 10)
                        {
                            num1 -= 10;
                            roman+="X";
                        }
                        if(num1==9)
                        {
                            num1 -= 9;
                            roman += "IX";
                        }
                        if(num1>=5)
                        {
                            num1 -= 5;
                            roman += "V";
                        }
                        if(num1==4)
                        {
                            num1 -= 4;
                            roman += "IV";
                        }
                        for (int i =num1; i > 0; i--)
                        {
                            roman += "I";
                        }
                    }
                    else if(num1 < 1)
                    {
                        Console.WriteLine("Number too small. Try again.");
                    }
                    else if(num1 > 10)
                    {
                        Console.WriteLine("Number too large. Try Again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }                
            }
            return roman;
        }
    }
    class BMI
    {
        public string CalculateMetric(float height, float weight)
        {
            float bmi = weight / (height * height);
            string status = "";
            if(bmi < 18.5f)
            {
                status = "Underweight";
            }
            else if(bmi >= 18.5f && bmi < 25)
            {
                status = "Normal";
            }
            else if(bmi >= 25 && bmi < 30)
            {
                status = "Overweight";
            }
            else if(bmi >= 30)
            {
                status = "Obese";
            }
            else
            {
                status = "Calculation Error.";
            }
            return status;
        }
        public string CalculateImperial(float height, float weight)
        {
            height /= 39.37f;
            weight /= 2.2f;
            return CalculateMetric(height, weight);
        }
    }
    class Pay 
    {
        string nameF;
        string nameL;
        string id;
        float wage;
        float hours;
        float salary;
        public Pay(string firstName, string lastName, string employeeID, float hourlyWage, float hoursWorked)
        {
            nameF = firstName;
            nameL = lastName;
            id = employeeID;
            wage = hourlyWage;
            hours = hoursWorked;
            salary = Calc();
        }
        public Pay(string firstName, string lastName, string employeeID, float yearlySalary)
        {
            nameF = firstName;
            nameL = lastName;
            id = employeeID;
            salary = yearlySalary;
        }
        public float Calc()
        {
            float outNum = 0;
            if (hours > 40)
            {
                float overTime = hours - 40;
                outNum += overTime * wage * 1.5f;
                hours = 40;
            }
            outNum += hours * wage;
            return outNum;
        }
        public string GetTakeHome()
        {
            float tax = salary * .18f;
            float retirement = salary * .1f;
            float ss = salary * .06f;
            float takeHome = salary - tax - retirement - ss;
            return string.Format("{0}, {1} Employee: {2} wage:\n" +
                "Tax:{3,10:$#,0.00}\n" +
                "Retirement:{4,10:$#,0.00}\n" +
                "Social Security:{5,10:$#,0.00}\n" +
                "Take Home:{6,10:$#,0.00}\n",nameL,nameF,id,tax,retirement,ss,takeHome);
        }

    }
}
