using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount b = new BankAccount("123", "Maria Vella", 500);
            // Maria Vella married Joe Borg so she wants to change name to Maria Borg
            b.AccountHolder = "Maria Borg";
            b.Deposit(100);
            b.Withdraw(50);
            Console.WriteLine("Balance is " + b.Balance);
            // b.Balance = 10000000000; disallowed because property has no set
            Console.WriteLine();
            Console.WriteLine(b.Audit);
            Console.ReadKey();
        }
    }
}
