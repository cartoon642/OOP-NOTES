using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1Revision
{
    public class Topping
    {
        protected string name;

        public Topping()
        {
            name = string.Empty;
        }

        public Topping(string pName)
        {
            name = pName;
        }

        public virtual double GetPrice()
        {
            double result = 0;
            switch (name)
            {
                case "Mozzarella":
                    result = 0.40;
                    break;
                case "Ham":
                    result = 0.60;
                    break;
                case "Eggs":
                    result = 0.70;
                    break;
                case "Salmon":
                    result = 0.98;
                    break;
                case "Tuna":
                    result = 0.80;
                    break;
                case "Garlic":
                    result = 0.20;
                    break;
                case "Beef":
                    result = 0.90;
                    break;
                case "Chicken":
                    result = 0.95;
                    break;
            }
            return result;
        }

    }
}
