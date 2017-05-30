using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menuLoop = true;
            int option = 0;
            while (menuLoop)
            {
                Console.Write("***********************************\n* Tyler Sikkema Assignment 3 Menu *\n***********************************\nPlease Select an Option:\n1. Rectangle Calculator\n2. Seconds Calculator\n3. Meter Conversion\n4. Tip Calculator\n5. Property Taxes\n6. Exit\n");
                bool validate = false;
                while (!validate)
                {
                    if (int.TryParse(Console.ReadLine(), out option))
                    {
                        validate = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Try Again");
                    }
                }
                switch (option)
                {
                    case 1:
                        Rectangle();
                        break;
                    case 2:
                        Seconds();
                        break;
                    case 3:
                        Meters();
                        break;
                    case 4:
                        Tip();
                        break;
                    case 5:
                        Propery();
                        break;
                    default:
                        menuLoop = false;
                        break;
                }
            }
        }
        static void Rectangle()
        {
            float width = 0;
            bool widthLoop = true;
            while (widthLoop)
            {
                Console.WriteLine("Input Rectangle Width");
                if (float.TryParse(Console.ReadLine(), out width))
                {
                    widthLoop = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }
            }
            float height = 0;
            bool heightLoop = true;
            while(heightLoop)
            {
                Console.WriteLine("Input Rectangle Height");
                if(float.TryParse(Console.ReadLine(), out height))
                {
                    heightLoop = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }
            }
            Console.Write("For a rectangle that is {0:#.#} by {1:#.#}\n" +
                "Area:\t\t{2,10:#,#.#}\n"+
                "Perimeter:\t{3,10:#,#.#}\n",width,height,Area(width,height),Perimeter(width,height));
        }
        static float Area(float width, float height)
        {
            return width * height;
        }
        static float Perimeter(float width, float height)
        {
            return ((2 * width) + (2 * height));
        }
        static void Seconds()
        {
            bool secondLoop = true;
            int seconds = 0;
            while (secondLoop)
            {
                Console.WriteLine("Please Enter the number of seconds.");
                if(int.TryParse(Console.ReadLine(),out seconds))
                {
                    secondLoop = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }
            }
            int hours = Hours(seconds);
            int minutes = Minutes(seconds);
            int sec = seconds % 3600 % 60;
            Console.Write("{0} seconds is:\n"+
                "Hours:\t\t{1,10:#,0.##}\n"+
                "Minutes:\t{2,10:#,0.##}\n"+
                "Seconds:\t{3,10:#,0.##}\n",seconds,hours,minutes,sec);
        }
        static int Hours(int seconds)
        {
            return seconds / 3600;
        }
        static int Minutes(int seconds)
        {
            return (seconds % 3600) / 60;
        }
        static void Meters()
        {
            bool meterLoop = true;
            float meters = 0f;
            while (meterLoop)
            {
                Console.WriteLine("Enter an amount of meters: ");
                if(float.TryParse(Console.ReadLine(), out meters))
                {
                    meterLoop = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }
            }
            float totalInches = MtoIN(meters);
            int feet = (int)totalInches / 12;
            int miles = 0;
            float inches = totalInches % 12;
            if (feet / 5280 > 0)
            {
                miles = feet / 5280;
                feet = feet % 5280;
                Console.Write("{0} meters is:\n" +
                    "{3,10:#,#}\tMiles\n"+
                "{1,10:#,#}\tFeet\n" +
                "{2,10:#.##}\tInches\n", meters, feet, inches,miles);
            }
            else
            {
                Console.Write("{0} meters is:\n" +
                "{1,10:#,#}\tFeet\n" +
                "{2,10:#.##}\tInches\n", meters, feet, inches);
            }
            
            
        }
        static float MtoIN(float a)
        {
            return a * 39.37f;
        }
        static void Tip()
        {
            float charge = 0;
            bool tipLoop = true;
            while (tipLoop)
            {
                Console.WriteLine("Input the Bill amount");
                if(float.TryParse(Console.ReadLine(), out charge))
                {
                    tipLoop = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }
            }
            charge = AddTax(charge);
            float tip15 = charge * 0.15f;
            float tip20 = charge * 0.20f;
            Console.Write("The total bill with tax is ${0:#,0.00}\nAppropriate Tips would be:\n{1,10:$#,0.00}\t15%\n{2,10:$#,0.00}\t20%\n",charge,tip15,tip20);
        }
        static float AddTax(float f)
        {
            return f * 1.09f;
        }
        static void Propery()
        {
            bool propertyLoop = true;
            float pValue = 0;
            string address = "";
            Console.Write("Enter Property Address: ");
            address = Console.ReadLine();
            while(propertyLoop)
            {
                Console.WriteLine("Enter Last years Property Value");
                if(float.TryParse(Console.ReadLine(), out pValue))
                {
                    propertyLoop = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }
            }
            float taxable = NewYear(pValue);
            float taxes = taxable * 0.01003f;
            if(taxable > 0)
            {
                Console.Write("The Taxable value for {0} is {1,10:$#,0.00}\n" +
                "{2,10:$#,0.00}\twould be owed in taxes\n", address, taxable, taxes);
            }
            else
            {
                Console.WriteLine("There are no taxes to pay for the property at {0}", address);
            }
            
        }
        static float NewYear(float f)
        {
            return f * 1.027f - 25000;
        }
    }   
}
