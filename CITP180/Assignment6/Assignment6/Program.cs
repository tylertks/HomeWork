using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool mainLoop = true;
            int choice = 0;
            while (mainLoop)
            {
                Console.Write("" +
                    "+------------------------------+\n" +
                    "|  Tyler Sikkema Assignment 6  |\n" +
                    "+==============================+\n" +
                    "| 1. Integer Validation        |\n" +
                    "| 2. Calculate Monthly Sales % |\n" +
                    "| 3. Check Area Code           |\n" +
                    "| 4. Integer Frequency         |\n" +
                    "| 5. Exit                      |\n" +
                    "+------------------------------+\n:");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            IntValid();
                            break;
                        case 2:
                            MonthlySales();
                            break;
                        case 3:
                            CodeCheck();
                            break;
                        case 4:
                            IntFreq();
                            break;
                        case 5:
                            mainLoop = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Choice. Start Again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }
            }
        }
        static void IntValid()
        {
            bool intLoop = true;
            int[] array = new int[11];
            int intAnswer;
            int invalid = 0;
            int outRange = 0;
            while (intLoop)
            {
                Console.WriteLine("Input an integer between 0 and 10. Press Enter to end.");
                string answer = Console.ReadLine();
                if (answer == "")
                {
                    intLoop = false;
                }
                else
                {
                    if (int.TryParse(answer, out intAnswer))
                    {
                        if (intAnswer > -1 && intAnswer < 11)
                        {
                            array[intAnswer]++;
                        }
                        else
                        {
                            outRange++;
                        }
                    }
                    else
                    {
                        invalid++;
                    }
                }
            }
            string strOut = "Number:\t\t";
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    strOut += i + "\t";
                }
            }
            strOut += "\nTimes Occured:\t";
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) { strOut += array[i] + "\t"; }
            }
            strOut += string.Format("\nOut of Range:\t{0}\nInvalid Input:\t{1}", outRange, invalid);
            Console.WriteLine(strOut);
        }
        static void MonthlySales()
        {
            bool salesLoop = true;
            string answer;
            List<float> sales = new List<float>();
            float month;
            while (salesLoop)
            {
                Console.Write("Enter Sales for Month #{0} (Enter to end)$", sales.Count + 1);
                answer = Console.ReadLine();
                if (answer == "")
                {
                    salesLoop = false;
                }
                else
                {
                    if (float.TryParse(answer, out month))
                    {
                        sales.Add(month);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Try Again.");
                    }
                }
            }
            string strOut = "Month\tSales\t\tPercentofTotal\n";
            for (int i = 0; i < sales.Count; i++)
            {
                strOut += string.Format("{0}\t{1,10:$#,##0.00}\t{2:#,##0.#%}\n", (i + 1), sales[i], (sales[i] / sales.Sum()));
            }
            Console.Write(strOut);
        }
        static void CodeCheck()
        {
            AreaCode codes = new AreaCode(new int[] { 231, 248, 269, 313, 517, 586, 616, 734, 810, 906, 847, 989 });
            bool codeLoop = true;
            int code = 0;
            string answer;
            while (codeLoop)
            {
                Console.WriteLine("Please Enter an Area Code to check. Press Enter to end.");
                answer = Console.ReadLine();
                if (answer == "")
                {
                    codeLoop = false;
                }
                else
                {
                    if (int.TryParse(answer, out code))
                    {
                        if (codes.Test(code))
                        {
                            Console.WriteLine("{0} is a valid area code in Michigan.", code);
                        }
                        else
                        {
                            Console.WriteLine("{0} is not a valid area code in Michigan.", code);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Try Again.");
                    }
                }
            }
            Console.WriteLine("All valid area codes in Michigan:");
            Console.Write(codes.ToString());
        }
        static void IntFreq()
        {
            bool intLoop = true;
            int[] ints = new int[11];
            int answer;
            string end;
            while (intLoop)
            {
                Console.WriteLine("Input an integer between 0 and 10. Enter to end.");
                end = Console.ReadLine();
                if(end == "")
                {
                    intLoop = false;
                }
                if(int.TryParse(end, out answer))
                {
                    if(answer > -1 && answer < 11)
                    {
                        ints[answer]++;
                    }
                    else
                    {
                        Console.WriteLine("Answer out of range.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }
            }
            string outStr = "";
            for (int i = 0; i < ints.Length; i++)
            {
                outStr += string.Format("{0}\t:",i);
                for (int j = 0; j < ints[i]; j++)
                {
                    outStr += "*";
                }
                outStr += "\n";
            }
            Console.Write(outStr);
        }
    }
    class AreaCode
    {
        int[] codes;
        public AreaCode(int[] areaCodes)
        {
            codes = areaCodes;
        }
        public AreaCode(List<int> areaCodes)
        {
            codes = new int[areaCodes.Count];
            for (int i = 0; i < areaCodes.Count; i++)
            {
                codes[i] = areaCodes[i];
            }
        }
        public bool Test(int i)
        {
            if (codes.Contains(i))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        override
        public string ToString()
        {
            string outStr = "";
            for (int i = 0; i < codes.Length; i++)
            {
                outStr += string.Format("({0})\n", codes[i]);
            }
            return outStr;
        }
    }
}
