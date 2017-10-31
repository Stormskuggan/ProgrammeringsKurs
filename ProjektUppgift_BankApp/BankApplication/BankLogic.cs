using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    static class BankLogic
    {

        private static List<Customer> allCustomers = new List<Customer>();
        private static List<SavingsAccount> allSavingsAccounts = new List<SavingsAccount>();
        private static int countOfAccounts;


        static public bool AddCustomer(long Pnr, string FirstName, string LastName)
        {
            
            foreach (Customer C in allCustomers)
            {
                if (C.PersonID == Pnr)
                {
                    return false;
                }
            }
            Customer customer = new Customer(Pnr, FirstName, LastName);
            allCustomers.Add(customer);
            return true;
        } 

        static public int AddSavingsAccount(long Pnr)
        {
            try
            {
                countOfAccounts++;
                SavingsAccount sA = new SavingsAccount(countOfAccounts + 1000);
                //allSavingsAccounts.Add(sA);
                Customer AccountOwner = allCustomers.Find((Customer c) => { return c.PersonID == Pnr; });
                AccountOwner.OwnedAccounts.Add(sA);

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
        static public bool Deposit(decimal amount, int AccountId, long Pnr)
        {
            
            //SavingsAccount account = allSavingsAccounts.Find((SavingsAccount a) => a.AccountID == AccountId);
            try
            {
                
                Customer AccountOwner = allCustomers.Find((Customer c) => { return c.PersonID == Pnr; });

                //SavingsAccount account = AccountOwner.OwnedAccounts.Find((SavingsAccount a) => { return a.AccountID == AccountId; });
                foreach (SavingsAccount sA in AccountOwner.OwnedAccounts)
                {
                    if (sA.AccountID == AccountId)
                    {
                        sA.Balance += amount;
                        return true;
                    }
                        
                }
                throw new Exception();

            }
            catch (NullReferenceException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }

            
            
        }
        static public bool Withdraw(decimal amount, int AccountId, long Pnr)
        {
           
            //SavingsAccount account = allSavingsAccounts.Find((SavingsAccount a) =>  a.AccountID == AccountId);
            Customer AccountOwner = allCustomers.Find((Customer c) => { return c.PersonID == Pnr; });
            foreach (SavingsAccount sA in AccountOwner.OwnedAccounts)
            {
                if (sA.AccountID == AccountId)
                {
                    if (sA.Balance >= amount)
                    {
                        //if successful
                        sA.Balance -= amount;
                        return true;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            //if fail
            return false;
         
        }
        static public string GetAccount(int AccountId)
        {
            SavingsAccount account = allSavingsAccounts.Find((SavingsAccount a) => { return a.AccountID == AccountId; });
            return "Account ID:" + Convert.ToString(account.AccountID) + "\nBalance: " + Convert.ToString(account.Balance) + "\nInterest rate:" + Convert.ToString(account.InterestRate * 100) + "%";
        }

        static public List<string> GetCustomer(long Pnr)
        {

            try
            {

                Customer myCustomer = allCustomers.Find((Customer c) => { return c.PersonID == Pnr; });
                List<string> thelist = new List<string>();
                thelist.Add("Name: " + myCustomer.FirstName + " " + myCustomer.LastName + "\nPersonID:" + myCustomer.PersonID.ToString() + "\n");
                foreach (SavingsAccount sA in myCustomer.OwnedAccounts)
                {
                    thelist.Add(sA.AccountID.ToString() + "\nBalance: " + sA.Balance.ToString() + "\nInterest rate: "  + sA.InterestRate.ToString() + "\n");

                }
                return thelist;
            }
            catch (NullReferenceException)
            {
                List<string> temp = new List<string>();
                temp.Add("No Customer with that PersonID number exists in Database");
                return temp;
            }

            catch (Exception x)
            {
                List<string> temp = new List<string>();
                temp.Add(x.ToString());
                return temp;
            }
           

        }

        static public List<string> GetAllCustomers()
        {

            List<string> myList = new List<string>();
            foreach (Customer c in allCustomers)
            {
                myList.Add(c.FirstName + " " + c.LastName + " " + c.PersonID.ToString());
            }
            return myList;
        }


        //static public bool ValidatePersonalNumber(int Pnr)
        //{
        //    if (Pnr.ToString().Length == 10)
        //    {

        //    }


        //    return false;
        //}
    }
}
