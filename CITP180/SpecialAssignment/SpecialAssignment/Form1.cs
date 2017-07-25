using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecialAssignment
{
    public partial class Form1 : Form
    {
        bool nameFilled = false;
        bool phoneFilled = false;
        bool addressFilled = false;
        Order order = new Order();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pizzaPrice();
            totalPrice();
            crust.SelectedItem = "none";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void delivery_CheckedChanged(object sender, EventArgs e)
        {    
            customerAddress.Enabled = delivery.Checked;
            order.delivery = delivery.Checked;
            totalPrice();
            EnableOrderBtn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> toppings = new List<String>();
            int size = 0;
            if (pepperoni.Checked)
                toppings.Add("Pepperoni");
            if (bacon.Checked)
                toppings.Add("Bacon");
            if (mushroom.Checked)
                toppings.Add("Mushroom");
            if (onion.Checked)
                toppings.Add("Onion");
            if (ham.Checked)
                toppings.Add("Ham");
            if (greenPepper.Checked)
                toppings.Add("Green Pepper");
            if (pineapple.Checked)
                toppings.Add("Pineapple");
            if (olive.Checked)
                toppings.Add("Olive");
            if (chicken.Checked)
                toppings.Add("Chicken");
            if (cheese.Checked)
                toppings.Add("Cheese");
            if (sizeS.Checked)
                size = 0;
            if (sizeM.Checked)
                size = 1;
            if (sizeL.Checked)
                size = 2;
            if(crust.SelectedItem.ToString()!="" || crust.SelectedItem.ToString() != "none")
            {
                order.items.Add(new Pizza(getPizzaPrice(), size, toppings, crust.Text));
            }
            else
            {
                order.items.Add(new Pizza(getPizzaPrice(), size, toppings));
            }
            ResetPizza();
            totalPrice();
        }

        private void customerName_TextChanged(object sender, EventArgs e)
        {
            if (customerName.Text != "")
            {
                nameFilled = true;
            }
            else
            {
                nameFilled = false;
            }
            EnableOrderBtn();
        }

        private void customerPhone_TextChanged(object sender, EventArgs e)
        {
            if(customerPhone.Text != "")
            {
                phoneFilled = true;
            }
            else
            {
                phoneFilled = false;
            }
            EnableOrderBtn();
        }

        private void customerAddress_TextChanged(object sender, EventArgs e)
        {
            if (customerAddress.Text != "")
            {
                addressFilled = true;
            }
            else
            {
                addressFilled = false;
            }
            EnableOrderBtn();
        }
        void EnableOrderBtn()
        {
            order.address = customerAddress.Text;
            order.customerName = customerName.Text;
            if (int.TryParse(customerPhone.Text, out order.phone)){ }
            if (nameFilled && phoneFilled)
            {
                if (delivery.Checked)
                {
                    if (addressFilled)
                    {
                        button2.Enabled = true;
                    }
                    else
                    {
                        button2.Enabled = false;
                    }
                }
                else
                {
                    button2.Enabled = true;
                }
            }
            else
            {
                button2.Enabled = false;
            }
        }
        void pizzaPrice()
        {
            float f = 0;
            if (sizeS.Checked)
            {
                f += 6;
            }else if (sizeM.Checked)
            {
                f += 8;
            }else if (sizeL.Checked)
            {
                f += 10;
            }
            if (pepperoni.Checked)
                f += .3f;
            if (bacon.Checked)
                f += .3f;
            if (mushroom.Checked)
                f += .3f;
            if (onion.Checked)
                f += .3f;
            if (ham.Checked)
                f += .3f;
            if (greenPepper.Checked)
                f += .3f;
            if (pineapple.Checked)
                f += .3f;
            if (olive.Checked)
                f += .3f;
            if (chicken.Checked)
                f += .5f;
            if (cheese.Checked)
                f += .5f;
            pizza.Text = string.Format("Pizza: {0:$0.00}", f);
        }
        float getPizzaPrice()
        {
            float f = 0;
            if (sizeS.Checked)
            {
                f += 6;
            }
            else if (sizeM.Checked)
            {
                f += 8;
            }
            else if (sizeL.Checked)
            {
                f += 10;
            }
            if (pepperoni.Checked)
                f += .3f;
            if (bacon.Checked)
                f += .3f;
            if (mushroom.Checked)
                f += .3f;
            if (onion.Checked)
                f += .3f;
            if (ham.Checked)
                f += .3f;
            if (greenPepper.Checked)
                f += .3f;
            if (pineapple.Checked)
                f += .3f;
            if (olive.Checked)
                f += .3f;
            if (chicken.Checked)
                f += .5f;
            if (cheese.Checked)
                f += .5f;
            return f;
        }

        private void bacon_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice();
        }

        private void mushroom_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice();
        }

        private void onion_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice();
        }

        private void ham_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice();
        }

        private void greenPepper_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice();
        }

        private void pineapple_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice();
        }

        private void olive_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice();
        }

        private void chicken_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice();
        }

        private void cheese_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice();
        }

        private void sizeS_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice();
        }

        private void sizeM_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice();
        }

        private void sizeL_CheckedChanged(object sender, EventArgs e)
        {
            pizzaPrice();
        }
        private void totalPrice()
        {
            listBox1.Text = order.ToString();
            listBox1.Items.Clear();
            foreach(string s in order.Items())
            {
                listBox1.Items.Add(s);
            }
            //listBox1.Items = order.Items();
            label8.Text = string.Format("Total: {0:$0.00}", order.Total());
        }
        private void ResetPizza()
        {
            crust.SelectedItem = "none";
            sizeL.Checked = true;
            pepperoni.Checked = false;
            bacon.Checked = false;
            mushroom.Checked = false;
            onion.Checked = false;
            ham.Checked = false;
            greenPepper.Checked = false;
            olive.Checked = false;
            pineapple.Checked = false;
            chicken.Checked = false;
            cheese.Checked = false;
        }
        private void ResetOrder()
        {
            ResetPizza();
            delivery.Checked = true;
            customerName.Text = "";
            customerPhone.Text = "";
            customerAddress.Text = "";
            order = new Order();
            pizzaPrice();
            totalPrice();
        }

        private void sodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order.items.Add(new Item("Soda", 3));
            totalPrice();
        }

        private void breadsticksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order.items.Add(new Item("Bread Sticks", 4.5f));
            totalPrice();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetOrder();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = order.customerName + "-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm") + ".txt";
            System.IO.File.WriteAllText(fileName, order.ToString());
            ResetOrder();
        }
    }
}
