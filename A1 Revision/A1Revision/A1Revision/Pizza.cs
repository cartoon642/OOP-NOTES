using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1Revision
{
    public class Pizza
    {
        DateTime deliveryDate;
        string size;
        string sauce;
        Topping[] toppings;

        public Pizza()
        {
            deliveryDate = DateTime.Now;
            size = string.Empty;
            sauce = string.Empty;
            toppings = new Topping[5];
        }

        public Pizza(DateTime pDeliveryDate, string pSize, string pSauce, Topping[] pToppings)
        {
            deliveryDate = pDeliveryDate;
            size = pSize;
            sauce = pSauce;
            toppings = pToppings;
        }

        public virtual double GetPrice()
        {
            double price = 0;
            // SIZE
            switch (size)
            {
                case "Small":
                    price += 5;
                    break;
                case "medium":
                    price += 7;
                    break;
                case "large":
                    price += 10;
                    break;
            }
            // TOPPINGS
            for (int i = 0; i < toppings.Length; i++)
            {
                price += toppings[i].GetPrice();
            }
            return price;
        }

        public string GetSpiceLevel()
        {
            string pizzaSpiceLevel = "Mild";
            // TOPPINGS
            for (int i = 0; i < toppings.Length; i++)
            {
                if (toppings[i] is SpicyTopping)
                {
                    SpicyTopping spicyTopping = (SpicyTopping)toppings[i];
                    if (spicyTopping.GetSpicyLevel() == "Moderate" && pizzaSpiceLevel == "Mild")
                        pizzaSpiceLevel = "Moderate";
                    if (spicyTopping.GetSpicyLevel() == "Ferocious")
                        pizzaSpiceLevel = "Ferocious";
                }
            }
            return pizzaSpiceLevel;
        }
    }
}
