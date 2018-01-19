using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMultipleAccounts
{
    class Program
    {
        static BankAccount[] bankAccounts = new BankAccount[5];

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

        static void AddToArray(BankAccount bankAccount)
        {
            for (int i = 0; i < bankAccounts.Length; i++)
            {
                if (bankAccounts[i] == null)
                {
                    bankAccounts[i] = bankAccount;
                    break;
                }
            }
        }

        static void OpenAccount()
        {
            Console.WriteLine("OPEN ACCOUNT");
            Console.WriteLine("------------");
            Console.Write("Account Number: ");
            string accountNumber = Console.ReadLine();
            Console.Write("Account Holder: ");
            string accountHolder = Console.ReadLine();
            BankAccount bankAccount = new BankAccount(accountNumber, accountHolder);
            AddToArray(bankAccount);
        }

        /// <summary>
        /// Searches for a the bankAccount with the specified no. Returns the bankAccount if found
        /// </summary>
        static BankAccount SearchBankAccount(string bankAccountNo)
        {
            for (int i = 0; i < bankAccounts.Length; i++)
            {
                if (bankAccounts[i] != null)
                {
                    if (bankAccounts[i].accountNo == bankAccountNo)
                    {
                        return bankAccounts[i];
                    }
                }
            }
            return null;
        }

        static void Deposit()
        {
            Console.WriteLine("DEPOSIT");
            Console.WriteLine("-------");
            Console.Write("Bank Account No: ");
            string bankAccountNo = Console.ReadLine();
            BankAccount bankAccount = SearchBankAccount(bankAccountNo);
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
            Console.Write("Bank Account No: ");
            string bankAccountNo = Console.ReadLine();
            BankAccount bankAccount = SearchBankAccount(bankAccountNo);
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
            Console.Write("Bank Account No: ");
            string bankAccountNo = Console.ReadLine();
            BankAccount bankAccount = SearchBankAccount(bankAccountNo);
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
