using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialAssignment
{
    class Item
    {
        public string name;
        public float price;
        public Item(string itemName, float itemPrice)
        {
            name = itemName;
            price = itemPrice;
        }
        override
        public string ToString()
        {
            string output = name;
            output += string.Format("\t{0,4:$#0.00}", price);
            return output;
        }
    }
}
