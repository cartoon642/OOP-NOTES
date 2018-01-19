using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMultipleAccounts
{
    class BankAccount
    {
        // attributes, fields: the characteristics that make up the class
        public string accountNo;
        string accountHolder;
        double balance;

        // constructor: a special method that is used to create an instance of the class.
        // Its role is to initialise the attributes of the object.
        // A constructor must always have the same name as the class
        // A constructor does not have a return type
        // A constructor must always have the modifier public
        // We can have as many constructors as we want
        public BankAccount(string pAccountNo, string pAccountHolder)
        {
            accountNo = pAccountNo;
            accountHolder = pAccountHolder;
            balance = 0;
        }

        public BankAccount(string pAccountNo, string pAccountHolder, double pInitialBalance)
        {
            accountNo = pAccountNo;
            accountHolder = pAccountHolder;
            balance = pInitialBalance;
        }

        public BankAccount()
        {
            accountNo = string.Empty;
            accountHolder = string.Empty;
            balance = 0;
        }

        // Behaviours, operations: Methods that retrieve and\or manipulate the class's attributes
        public string GetDetails()
        {
            return "Account No.: " + accountNo + "; Account Holder: " + accountHolder +
                "; Balance: " + balance;
            //return string.Format("Account No.: {0}; Account Holder: {1}; Balance: {2}",
            //    accountNo, accountHolder, balance);
        }

        public double GetBalance()
        {
            return balance;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>true if withdrawal was successful and false if there were insufficient funds</returns>
        public bool Withdraw(double amount)
        {
            bool result = false;
            if (amount <= balance)
            {
                result = true;
                balance -= amount;
            }
            return result;
        }
    }
}
