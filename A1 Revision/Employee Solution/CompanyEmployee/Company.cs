using Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEmployee
{
    class Company
    {
        string name;
        Employee[] employees;

        public Company()
        {
            name = string.Empty;
            employees = new Employee[5];
        }

        public Company(string pName, Employee[] pEmployees)
        {
            name = pName;
            employees = pEmployees;
        }

        public void AddEmployee(Employee emp)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] == null)
                {
                    employees[i] = emp;
                    break;
                }
            }
        }

        public double GetPayroll()
        {
            double result = 0;
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null)
                {
                    result += employees[i].GetSalary();
                }
            }
            return result;
        }
    }
}
