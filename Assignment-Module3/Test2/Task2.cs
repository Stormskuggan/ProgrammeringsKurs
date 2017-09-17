using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Accounts
    {
        static void Main(string[] args)
        {

            double newBalance = 0;
            string newName = "";
            double withdrawAmount = 0;

            Console.Write("Enter your name please: ");

            newName = Console.ReadLine();
            Account myAccount = new Account(2200, newName);
            Console.WriteLine("Welcome,{0}. This is your account book!", myAccount.Name);
            myAccount.ShowMessage("Balance is " + myAccount.Balance);
            Console.Write("Enter first deposit:");

            try
            {
                newBalance = myAccount.Deposit(double.Parse(Console.ReadLine()));
                myAccount.Balance = newBalance;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error, Skipping Depositing");
            }

            myAccount.ShowMessage("your balance is now: " + myAccount.Balance);
            Console.Write("Enter the withdraw amount: ");
            
            try
            {
                withdrawAmount = double.Parse(Console.ReadLine());
                if (withdrawAmount <= myAccount.Balance)
                {
                    myAccount.Withdraw(withdrawAmount);
                }
                else if (withdrawAmount > myAccount.Balance)
                {
                    Console.WriteLine("You don't have enough money!");
                }
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Error, Skipping withdrawal");
            }
            myAccount.ShowMessage("Your balance is now: " + myAccount.Balance);
        }
    }
}
