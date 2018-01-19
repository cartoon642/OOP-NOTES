using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1Revision
{
    class Program
    {
        static string SizeMenu()
        {
            string size = string.Empty;
            Console.Clear();
            Console.WriteLine("Size Menu");
            Console.WriteLine("1. Small");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Large");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    size = "Small";
                    break;
                case "2":
                    size = "Medium";
                    break;
                case "3":
                    size = "Small";
                    break;
            }
            return size;
        }

        static string SauceMenu()
        {
            string sauce = string.Empty;
            Console.Clear();
            Console.WriteLine("Sauce Menu");
            Console.WriteLine("1. Tomato");
            Console.WriteLine("2. Cream");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    sauce = "Tomato";
                    break;
                case "2":
                    sauce = "Cream";
                    break;
            }
            return sauce;
        }

        static string PizzaTypeMenu()
        {
            string pizzaType = string.Empty;
            Console.Clear();
            Console.WriteLine("Pizza Type Menu");
            Console.WriteLine("1. Regular");
            Console.WriteLine("2. Stuffed Crust");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    pizzaType = "Regular";
                    break;
                case "2":
                    pizzaType = "Stuffed";
                    break;
            }
            return pizzaType;
        }

        static string StuffingMenu()
        {
            string stuffing = string.Empty;
            Console.Clear();
            Console.WriteLine("Stuffing Menu");
            Console.WriteLine("1. Mozzarella");
            Console.WriteLine("2. Spiced Cheese");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    stuffing = "Mozzarella";
                    break;
                case "2":
                    stuffing = "Spiced Cheese";
                    break;
            }
            return stuffing;
        }

        static Topping ToppingMenu()
        {
            Topping topping = new Topping();
            Console.WriteLine("1. Mozzarella");
            Console.WriteLine("2. Hame");
            Console.WriteLine("3. Eggs");
            Console.WriteLine("4. Salmon");
            Console.WriteLine("5. Tuna");
            Console.WriteLine("6. Sweet");
            Console.WriteLine("7. Cayenne");
            Console.WriteLine("8. Habanero");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    topping = new Topping("Mozzarella");
                    break;
                case "2":
                    topping = new Topping("Ham");
                    break;
                case "3":
                    topping = new Topping("Eggs");
                    break;
                case "4":
                    topping = new Topping("Salmon");
                    break;
                case "5":
                    topping = new Topping("Tuna");
                    break;
                case "6":
                    topping = new SpicyTopping("Sweet");
                    break;
                case "7":
                    topping = new SpicyTopping("Cayenne");
                    break;
                case "8":
                    topping = new SpicyTopping("Habanero");
                    break;
            }
            return topping;
        }

        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Enter delivery date: ");
            DateTime dt = DateTime.Parse(Console.ReadLine()); // 22/03/2018
            string size = SizeMenu();
            string sauce = SauceMenu();
            string pizzaType = PizzaTypeMenu();
            string stuffedCrustFilling = string.Empty;
            if (pizzaType == "Stuffed")
            {
                stuffedCrustFilling = StuffingMenu();
            }
            Topping[] toppings = new Topping[5];
            for (int i = 0; i < toppings.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("Topping " + (i + 1));
                toppings[i] = ToppingMenu();
            }
            Pizza p = new Pizza();
            if (pizzaType == "Regular")
                p = new Pizza(dt, size, sauce, toppings);
            else if (pizzaType == "Stuffed")
                p = new StuffedCrustPizza(dt, size, sauce, toppings, stuffedCrustFilling); // polymorphism of objects
            Console.WriteLine();
            Console.WriteLine("Pizza price is: " + p.GetPrice()); // polymorphism of methods
            Console.WriteLine("Pizza spice level is: " + p.GetSpiceLevel());
            Console.ReadKey();
        }
    }
}