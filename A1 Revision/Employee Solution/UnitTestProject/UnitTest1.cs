using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Employees;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        // Step 1: Add reference to Employees project
        // Step 2: Ensure that all classes to be referenced are marked as Public
        // Step 3: Add namespace (using ...)
        // Step 4: Write the test
        // Step 5: Test > Run > All Tests
        // Step 6: Check Test Explorer (on the left)

        [TestMethod]
        public void TestSalariedEmployee()
        {
            SalariedEmployee se = new SalariedEmployee("001", "John", "Doe", 5000);
            double expectedSalary = 5000;
            double actualSalary = se.GetSalary();
            Assert.AreEqual(expectedSalary, actualSalary);
        }

        [TestMethod]
        public void TestHourlyEmployee()
        {
            HourlyEmployee he = new HourlyEmployee("001", "John", "Doe", 20, 5, 1.5);
            double expectedSalary = 100;
            double actualSalary = he.GetSalary();
            Assert.AreEqual(expectedSalary, actualSalary);
        }

        [TestMethod]
        public void TestCommissionEmployee()
        {
            CommissionEmployee ce = new CommissionEmployee("001", "John", "Doe", 100000, 10);
            double expectedSalary = 10 / 100 * 100000;
            double actualSalary = ce.GetSalary();
            // introdude a bug
            actualSalary += 1;
            Assert.AreEqual(expectedSalary, actualSalary);
        }

        [TestMethod]
        public void TestInheritance()
        {
            SalariedCommissionEmployee salCom = new SalariedCommissionEmployee();
            Assert.IsInstanceOfType(salCom, typeof(Employee));
        }
    }
}
