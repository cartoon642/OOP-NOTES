using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using A1Revision;

namespace UnitTestProject
{
    // STEP 1: Right click on solution, add new project (UnitTestProject)
    // STEP 2: Add Reference to main project (A1Revision) - Right click on test project > Add Reference > Program
    //         > Tick A1Revision > OK
    // STEP 3: Ensure all classes in the main program are public
    // STEP 4: Add reference to namespace (using A1Revision)
    // STEP 5: Write a method for every test
    // STEP 6: Test > Run > All Tests
    // STEP 7: Check Test Explorer to ensure tests are successful
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetPrice()
        {
            Topping[] toppings = new Topping[5];
            toppings[0] = new Topping("Ham");
            toppings[1] = new Topping("Chicken");
            toppings[2] = new Topping("Beef");
            toppings[3] = new Topping("Tuna");
            toppings[4] = new SpicyTopping("Habanero");
            Pizza p = new Pizza(DateTime.Now, "Small", "Tomato", toppings);
            double expectedPrice = 5 + 0.6 + 0.95 + .9 + 0.8 + 0.33;
            double actualPrice = p.GetPrice();
            Assert.AreEqual(expectedPrice, actualPrice);
        }

        [TestMethod]
        public void TestGetSpiceLevel()
        {
            Topping[] toppings = new Topping[5];
            toppings[0] = new Topping("Ham");
            toppings[1] = new Topping("Chicken");
            toppings[2] = new Topping("Beef");
            toppings[3] = new Topping("Tuna");
            toppings[4] = new SpicyTopping("Habanero");
            Pizza p = new Pizza(DateTime.Now, "Small", "Tomato", toppings);
            string expectedValue = "Ferocious";
            string actualValue = p.GetSpiceLevel();
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
