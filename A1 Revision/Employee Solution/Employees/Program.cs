using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Polymorphism is an OOP concept that allows objects to change form (polymorphism of 
             * objects). It also allows objects to call methods according to how they were
             * instantiated (polymorphism of methods)
             */ 
            Employee[] employees = new Employee[3];

            SalariedCommissionEmployee sce = new SalariedCommissionEmployee(
                "001", "Joe", "Borg", 100000, 5, 1000);
            double salary = sce.GetSalary();

            /* The following 3 lines demonstrate polymorphism of objects. Different specialised
             * Employee objects (e.g., SalariedEmployee) are being stored in a generic variable
             * (Employee)
             */ 
            employees[0] = sce;
            employees[1] = new SalariedEmployee("002", "Peter", "Vella", 1000);
            employees[2] = new HourlyEmployee("003", "Katia", "Attard", 30, 5, 1.5);

            // Calculate payroll for all
            double totalPayroll = 0;
            for (int i = 0; i < employees.Length; i++)
            {
                /* The Following line demonstrates polymorphism of methods. Although we are calling
                 * employee.GetSalary(), in reality the GetSalary() version that is invoked depends
                 * on how the object was instantiated before. That is, employee[0] morphs to 
                 * SalesCommissionEmployee and invokes SalesCommissionEmployee[0].GetSalary()
                 */ 
                totalPayroll += employees[i].GetSalary();
            }

            
        }
    }
}
