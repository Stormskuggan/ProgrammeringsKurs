using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class BankLogic
    {

        //private List<Costumer> allcostumers;
        private List<SavingsAccount> allSavingsAccounts;
        private int countOfAccounts;


        public BankLogic()
        {



        }

        public int addSavingsAccount()
        {
            countOfAccounts++;
            SavingsAccount s = new SavingsAccount(countOfAccounts+1000);
            allSavingsAccounts.Add(s);
            //if successful
            return s.AccountID;
            //else 
                //return -1;
        }


        public bool Withdraw (decimal amount, int AccountId)
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
    }
}
