using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool programLoop = true;
            while (programLoop)
            {
                Console.Write("---------------\nAssignment 2 Menu\n1. Temperature Conversion\n2. Distance Conversion\n3. Average Exam Scores\n4. Tip Calculator\n5. Metric Cost Conversion\n6. Exit Program\n---------------\n");
                String input = Console.ReadLine();
                int i = 0;
                if(int.TryParse(input, out i))
                {
                    switch (i)
                    {
                        case 1:
                            Temperature();
                            break;
                        case 2:
                            Distance();
                            break;
                        case 3:
                            Average();
                            break;
                        case 4:
                            Tip();
                            break;
                        case 5:
                            Cost();
                            break;
                        default:
                            programLoop = false;
                            break;
                    }
                }
                else
                {
                    Console.Write("Invalid Input. Try Again.");
                }
            }
        }
        static void Temperature()
        {
            bool valid = false;
            String input = null;
            float cTemp=0;
            while (!valid)
            {
                Console.Write("Enter a Tempurature in Celsius: ");
                input = Console.ReadLine();
                if (float.TryParse(input,out cTemp)){
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }
            }
            float fTemp = (9 * cTemp) / 5 + 32;
            Console.WriteLine(cTemp + " degress in Celsius is " + fTemp + " degrees in Fahrenheit.");
        }
        static void Distance()
        {
            bool valid = false;
            String input = null;
            float miles=0;
            while (!valid)
            {
                Console.Write("Enter a disance in miles: ");
                input = Console.ReadLine();
                if (float.TryParse(input, out miles))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }
            }
            float feet = miles * 5280;
            float km = miles * 1.60934f;
            Console.Write(string.Format("{0,10:0.##} miles is\n{1,10:#,#.} feet.\n{2,10:0.##} kilometers.\n",miles,feet,km));
            //Console.Write(miles.ToString("10.##") + " miles =\n" + feet.ToString("N5.") + " feet.\n" +km.ToString("N5.##")+" kilometers.\n");
        }
        static void Average()
        {
            float[] scores = new float[5];
            for (int i = 0; i < 5; i++)
            {
                bool valid = false;
                while (!valid)
                {
                    Console.Write("Enter Exam Score #"+(i+1)+": ");
                    if(float.TryParse(Console.ReadLine(), out scores[i])) {
                        if (0 <= scores[i] && scores[i] <= 100)
                        {
                            valid = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Try Again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Try Again.");
                    }
                }
            }
            float total = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("Exam #"+(i+1)+" Score: " + scores[i].ToString("#.##") + "%");
                total += scores[i];
            }
            Console.WriteLine("Average Score: "+(total / scores.Length).ToString("#.##") + "%");

        }
        static void Tip()
        {
            bool valid = false;
            float value = 0;
            while (!valid)
            {
                Console.Write("Enter the bill amount: $");
                if(float.TryParse(Console.ReadLine(), out value))
                {
                    valid = true;
                }
                else
                {
                    Console.Write("Invalid Input. Try Again.");
                }
            }
            Console.Write("For a bill of $" + value.ToString("#,#.##") + "\n15% tip: $" + (value * 0.15f).ToString("#,#.##") + " Total: $" + (value * 1.15f).ToString("#,#.##") + "\n20% Tip: $" + (value * 0.2f).ToString("#.##") + " Total: $" + (value * 1.2f).ToString("#.##")+"\n");
        }
        static void Cost()
        {
            bool massValid = false;
            bool costValid = false;
            float mass = 0;
            float cost = 0;
            while (!massValid)
            {
                Console.Write("Enter the weight of the product in grams: ");
                if(float.TryParse(Console.ReadLine(), out mass))
                {
                    massValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }
            }
            while (!costValid)
            {
                Console.Write("Enter the cost of the product: ");
                if(float.TryParse(Console.ReadLine(), out cost))
                {
                    costValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }
            }
            float pounds = mass * 0.00220462f;
            float lbCost = cost / pounds;
            float kgCost = cost / mass * 1000f;
            Console.Write("Cost of Product\n$" + kgCost.ToString("#,#.##")+"/kg" + "\n$" + lbCost.ToString("#,#.##")+"/lb\n");
        }
    }
}
