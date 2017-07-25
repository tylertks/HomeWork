using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialAssignment
{
    class Pizza : Item
    {
        public List<string> toppings = new List<string>();
        public int size;
        public string crust;
        public Pizza(float Price, int Size, List<string> Toppings, string Crust = "regular", string Name = "Pizza") : base(Name,Price){
            name = Name;
            price = Price;
            size = Size;
            crust = Crust;
            toppings = Toppings;
        }
        override
        public string ToString()
        {
            string output = name;
            output += ":";
            switch (size)
            {
                case 0:
                    output += "Small";
                    break;
                case 1:
                    output += "Medium";
                    break;
                case 2:
                    output += "Large";
                    break;
                default:
                    output += "Invalid Size";
                    break;
            }
            output += " (";
            for (int i = 0; i < toppings.Count; i++)
            {
                if(i>0)
                    output += ",";
                output += toppings[i];
            }
            output += ") ";
            output += crust;
            output += " Crust";
            output += string.Format("\t{0,4:$#0.00}", price);
            return output;
        }
    }
}
