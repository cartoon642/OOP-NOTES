using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees;

namespace CompanyEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Company apple = new Company(); // using parameterless ctor
            apple.AddEmployee(new SalariedEmployee("1", "Steve", "Jobs", 10000));
            double applePayroll = apple.GetPayroll();
            Console.WriteLine("Apple Payroll: " + applePayroll);

            Employee[] employees = new Employee[2];
            employees[0] = new SalariedEmployee("1", "Mark", "Zuckerberg", 20000);
            employees[1] = new SalariedEmployee("2", "Peter", "Vella", 10000);
            Company facebook = new Company("Facebook Inc.", employees); // using parameterised ctor
            double facebookPayroll = facebook.GetPayroll();
            Console.WriteLine("Facebook Payroll: " + facebookPayroll);

            Console.ReadKey();

        }
    }
}
