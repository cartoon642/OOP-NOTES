using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSingleAccount
{
    class Program
    {
        static BankAccount bankAccount;

        static string ShowMenu()
        {
            string result = string.Empty;
            Console.Clear();
            Console.Write(
                    "MENU\n" +
                    "----\n" +
                    "1.. Open Account\n" +
                    "2.. Deposit\n" +
                    "3.. Withdraw\n" +
                    "4.. Show Details\n" +
                    "5.. Quit\n" +
                    "Your choice: ");
            result = Console.ReadLine();
            return result;
        }

        static void OpenAccount()
        {
            Console.WriteLine("OPEN ACCOUNT");
            Console.WriteLine("------------");
            Console.Write("Account Number: ");
            string accountNumber = Console.ReadLine();
            Console.Write("Account Holder: ");
            string accountHolder = Console.ReadLine();
            bankAccount = new BankAccount(accountNumber, accountHolder);
        }

        static void Deposit()
        {
            Console.WriteLine("DEPOSIT");
            Console.WriteLine("-------");
            if (bankAccount == null)
            {
                Console.WriteLine("Open account first!!!");
            }
            else
            {
                Console.Write("Amount: ");
                double amount = Convert.ToInt32(Console.ReadLine());
                bankAccount.Deposit(amount);
            }
        }

        static void Withdraw()
        {
            Console.WriteLine("WITHDRAW");
            Console.WriteLine("--------");
            if (bankAccount == null)
            {
                Console.WriteLine("Open account first!!!");
            }
            else
            {
                Console.Write("Amount: ");
                double amount = Convert.ToInt32(Console.ReadLine());
                bool withdrawSuccessful = bankAccount.Withdraw(amount);
                if (!withdrawSuccessful)
                {
                    Console.WriteLine("Insufficient funds");
                }
            }
        }

        static void ShowDetails()
        {
            Console.WriteLine("GET DETAILS");
            Console.WriteLine("-----------");
            if (bankAccount == null)
            {
                Console.WriteLine("Open account first!!!");
            }
            else
            {
                Console.WriteLine(bankAccount.GetDetails());
            }
        }

        static void Main(string[] args)
        {
            Console.Clear();
            string choice = string.Empty;
            do
            {
                choice = ShowMenu();

                Console.Clear();
                switch (choice)
                {
                    case "1": // Open Account
                        OpenAccount();
                        break;
                    case "2": // Deposit
                        Deposit();
                        break;
                    case "3": // Withdraw
                        Withdraw();
                        break;
                    case "4": // Show Details
                        ShowDetails();
                        break;
                }
                Console.WriteLine("Press any key...");
                Console.ReadKey();
            } while (choice != "5");
        }
    }
}
