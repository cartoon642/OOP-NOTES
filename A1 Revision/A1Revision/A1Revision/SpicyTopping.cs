using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1Revision
{
    public class SpicyTopping : Topping
    {
        public SpicyTopping() : base()
        {
        }

        public SpicyTopping(string pName) : 
            base(pName)
        {
        }

        //Sweet chili peppers Mild 0.31
        //Cayenne chili peppers Moderate 0.32
        //Habanero chili peppers Ferocious 0.33

        public override double GetPrice()
        {
            double result = 0;
            switch (name)
            {
                case "Sweet":
                    result = 0.31;
                    break;
                case "Cayenne":
                    result = 0.32;
                    break;
                case "Habanero":
                    result = 0.33;
                    break;
            }
            return result;
        }

        public string GetSpicyLevel()
        {
            string result = string.Empty;
            switch (name)
            {
                case "Sweet":
                    result = "Mild";
                    break;
                case "Cayenne":
                    result = "Moderate";
                    break;
                case "Habanero":
                    result = "Ferocious";
                    break;
            }
            return result;
        }
    }
}
