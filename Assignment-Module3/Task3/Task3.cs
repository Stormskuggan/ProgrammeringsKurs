using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Accounts
    {
        static void Main(string[] args)
        {

            double newBalance = 0;
            string newName = "";
            double withdrawAmount = 0;
            int choice = 0;

            Console.Write("Enter your name please: ");

            newName = Console.ReadLine();
            Account myAccount = new Account(2200, newName);


            Console.WriteLine("Welcome, {0}. This is your account book!", myAccount.Name);
            myAccount.ShowMessage("Your balance is " + myAccount.Balance);
            

            
            do
            {
                myAccount.ShowMessage("enter 1 to depost money, 2 to withdraw money and 3 to leave");

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Write("Error, format needs to be numeral without decimal. ");
                }


                switch (choice)
                {
                    case 1:
                        Console.Write("Enter amount to deposit:");

                        try
                        {
                            newBalance = myAccount.Deposit(double.Parse(Console.ReadLine()));
                            myAccount.Balance = newBalance;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error, format needs to be numeral. Exiting Depositing...");
                        }
                        break;
                    case 2:
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
                            Console.WriteLine("Error, format needs to be numeral.Exiting Withdrawal...");
                        }
                        break;
                    case 3:
                        
                        break;
                    default :
                        Console.WriteLine("What do you mean with this input?");
                        break;


                }
                myAccount.ShowMessage("Your balance is now: " + myAccount.Balance);
            } while (choice != 3);

            Console.WriteLine("Exiting application, have a nice day!");


        }

    }
}
