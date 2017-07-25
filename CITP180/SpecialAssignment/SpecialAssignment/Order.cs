using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialAssignment
{
    class Order
    {
        public string customerName;
        public int phone;
        public string address;
        public List<Item> items = new List<Item>();
        public bool delivery = true;
        public Order()
        {

        }
        public float Total()
        {
            float total = 0f;
            for (int i = 0; i < items.Count; i++)
            {
                total+= items[i].price;
            }
            if (delivery)
            {
                total += 3;
            }
            return total;
        }
        override
        public string ToString()
        {
            string s = "";
            s += "Customer Name:\t" + customerName + "\n";
            s += "Phone:\t" + phone + "\n";
            if (delivery)
            {
                s += "Address:\t" + address + "\n";
            }
            foreach(Item i in items)
            {
                s += i.ToString() + "\n";
            }
            if (delivery)
            {
                s += "Delivery:\t$3.00\n";
            }
            s+=string.Format("Total:{0:$#,##0.00}",Total());
            return s;
        }
        public List<string> Items()
        {
            List<string> s = new List<string>();
            foreach (Item i in items)
            {
                s.Add(i.ToString());
            }
            if (delivery)
            {
                s.Add("Delivery\t$3.00");
            }
            return s;
        }
    }
}
