using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ThirdAssignmentCSharp;

namespace ThirdAssignmentCSharp
{

    internal class Accounts
    {
        protected static int counter = 1000; 

        public string Account_no;
        public string Customer_name, Account_type, Transaction_type;
        public float amount, balance;

        public Accounts(string name, string accType, string transType, float amt, float bal)
        {
            counter++;
            Account_no = "ACC" + counter; 

            Customer_name = name;
            Account_type = accType;
            Transaction_type = transType;
            amount = amt;
            balance = bal;
        }
        public void Credit(float amt)
        {
            balance += amt;
        }

        public void Debit(float amt)
        {
            balance -= amt;
        }
        public void ProcessTransaction()
        {
            if (Transaction_type == "D")
                Credit(amount);
            else if (Transaction_type == "W")
                Debit(amount);
            else
                Console.WriteLine("Invalid Transaction");
        }

        
        public void ShowData()
        {
            Console.WriteLine("\nAccount No: " + Account_no);
            Console.WriteLine("Customer Name: " + Customer_name);
            Console.WriteLine("Account Type: " + Account_type);
            Console.WriteLine("Transaction: " + Transaction_type);
            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Balance: " + balance);
        }
    }
    class SavingsAccount : Accounts
    {
        public SavingsAccount(string name, string transType, float amt, float bal)
            : base(name, "Savings", transType, amt, bal)
        {
        }
    }
    class CurrentAccount : Accounts
    {
        public CurrentAccount(string name, string transType, float amt, float bal)
            : base(name, "Current", transType, amt, bal)
        {
        }
    }

    
}
