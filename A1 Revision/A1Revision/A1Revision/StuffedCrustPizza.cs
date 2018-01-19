using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1Revision
{
    public class StuffedCrustPizza : Pizza
    {
        string crustFilling;

        public StuffedCrustPizza() : base()
        {
            crustFilling = string.Empty;
        }

        public StuffedCrustPizza(DateTime pDeliveryDate, string pSize, string pSauce, Topping[] pToppings, string pCrustFilling) 
            : base(pDeliveryDate, pSize, pSauce, pToppings)
        {
            crustFilling = pCrustFilling;
        }

        public override double GetPrice()
        {
            // Basic price includes pizza size and toppings
            double price =  base.GetPrice();
            switch (crustFilling)
            {
                case "Mozzarella":
                    price += 2;
                    break;
                case "Spiced Cheese":
                    price += 4;
                    break;
            }
            return price;
        }
    }
}
