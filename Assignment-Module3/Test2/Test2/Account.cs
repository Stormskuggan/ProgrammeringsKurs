using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Account
    {

        private double balance = 0;
        private string name = "";

        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Account()
        {
            
        }

        public Account(double amount, string name)
        {
            Balance = amount;
            Name = name;
        }


        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public double Deposit (double depositAmount)
        {


            return Balance + depositAmount * 1.05;
        }

        public void Withdraw (double withdrawAmount)
        {
            Balance -= withdrawAmount;

        }
    }
}
