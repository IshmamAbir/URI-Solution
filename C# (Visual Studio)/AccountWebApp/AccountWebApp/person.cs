using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountWebApp
{
    [Serializable]
    public class person
    {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        private double balance;

        public person()
        {
            balance = 0;
        }

        public string Deposit(double amount)
        {
            balance += amount;

            return "Deposit Successful";
        }

        public string Withdraw(double amount)
        {
            if (amount>balance)
            {
                return "Insufficient Balance";
            }
            else
            {
                balance -= amount;

                return "Withdraw Successful";

            }
        }

        public string Report()
        {
            return "Customer Name :" + CustomerName + "\nAccount Number :" + AccountNumber + "\nBalance :" + balance;
        }

    }
}