using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    static class BankLogic
    {

        //private List<Costumer> allcostumers;
        private static List<SavingsAccount> allSavingsAccounts = new List<SavingsAccount>();
        private static int countOfAccounts;


        //public BankLogic()
        //{



        //}

        static public int addSavingsAccount()
        {
            try
            {
                countOfAccounts++;
                SavingsAccount sA = new SavingsAccount(countOfAccounts + 1000);
                allSavingsAccounts.Add(sA);
                //if successful
                return sA.AccountID;
                //else 
                //return -1;
            }
            catch (NullReferenceException)
            {
                return 404;
            }
            catch (Exception)
            {
                return 000;
            }

        }


        static public bool Withdraw (decimal amount, int AccountId)
        {
            bool state = true;
            SavingsAccount account = allSavingsAccounts.Find((SavingsAccount a) =>  a.AccountID == AccountId);

            if (account.Balance >= amount)
            {
                //if successful
                account.Balance -= amount;
                state = true;
            }
            else
                state = false;
            //if fail
            return state;
         
        }
        static public string GetAccount(int AccountId)
        {
            SavingsAccount account = allSavingsAccounts.Find((SavingsAccount a) => a.AccountID == AccountId);
            return "Account ID:" + Convert.ToString(account.AccountID) + "\nBalance: " + Convert.ToString(account.Balance) + "\nInterest rate:" + Convert.ToString(account.InterestRate * 100) + "%";
        }

    }
}
