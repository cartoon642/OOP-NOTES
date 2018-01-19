using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class SalariedCommissionEmployee : CommissionEmployee
    {
        double baseSalary;
        
        public SalariedCommissionEmployee() : base()
        {
            baseSalary = 0;
        }

        public SalariedCommissionEmployee(string pNi, string pName, string pSurname,
            double pSales, double pSalesCommissionPercentage,
            double pBaseSalary)
            : base(pNi, pName, pSurname, pSales, pSalesCommissionPercentage)
        {
            baseSalary = pBaseSalary;
        }

        public override double GetSalary()
        {
            return baseSalary + base.GetSalary();
        }

        public override string GetDetails()
        {
            return base.GetDetails() +
                ";Base Salary: " + baseSalary;
        }
    }
}
