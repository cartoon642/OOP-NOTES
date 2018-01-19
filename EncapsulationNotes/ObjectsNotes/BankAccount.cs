using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsNotes
{
    class BankAccount
    {
        // attributes, fields: the characteristics that make up the class
        DateTime dateOpened;
        string accountNo;
        string accountHolder;
        double balance;
        string audit;

        // properties: Properties are used when we want to change the value of an attribute
        // (or when we want to deduce something)
        // public is called an access modifier. Other modifiers are private and public.
        // The property has the same data type as the attribute and its name just capitalises the first letter
        public string AccountHolder
        {
            get // get is used to read the value e.g., Console.WriteLine(b.AccountHolder);
            {
                return accountHolder;
            }
            set // set is used to change the value e.g., b.AccountHolder = "Maria Borg";
            {
                audit += string.Format("Account Holder changed from {0} to {1} at {2}\n", accountHolder, value, DateTime.Now.ToString());
                accountHolder = value;
            }
        }

        public double Balance
        {
            get
            {
                audit += string.Format("Balance Enquiry at {0}\n", DateTime.Now.ToString());
                return balance;
            }
            // no set... balance is read only
        }

        public string Audit
        {
            get
            {
                return audit;
            }
        }

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
            dateOpened = DateTime.Now;
            audit += "Account created at " + dateOpened.ToString() + "\n";
        }

        public BankAccount(string pAccountNo, string pAccountHolder, double pInitialBalance)
        {
            accountNo = pAccountNo;
            accountHolder = pAccountHolder;
            balance = pInitialBalance;
            dateOpened = DateTime.Now;
            audit += "Account created at " + dateOpened.ToString() + "\n";
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

        public void Deposit(double amount)
        {
            balance += amount;
            audit += string.Format("Deposit of {0} at {1}\n", amount, DateTime.Now.ToString());
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
            audit += string.Format("Withdrawal of {0} at {1}\n", amount, DateTime.Now.ToString());
            return result;
        }
    }
}
