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
                allSavingsAccounts.Add(sA);

                int ownernumber = allCustomers.FindIndex((Customer c) => { return c.PersonID == Pnr; });
                allCustomers[ownernumber].OwnedAccounts.Add(sA);

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
                SavingsAccount sA = AccountOwner.OwnedAccounts.Find((SavingsAccount a) => { return a.AccountID == AccountId; });
                sA.Balance += amount;
                return true;

                //använd for loop. foreach kan int ändra något i listan som den itererar på!!!!!
                // DET FUNKAR FORTFARANDE INTE!!!!1!!!!11!!
                // i hate coding. properyn Balance hade en if-sats i sig som hindrade värdet fårn att uppdateras

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
        static public int Withdraw(decimal amount, int AccountId, long Pnr)
        {
            try
            {
                Customer AccountOwner = allCustomers.Find((Customer c) => { return c.PersonID == Pnr; });
                foreach (SavingsAccount sA in AccountOwner.OwnedAccounts)
                {
                    if (sA.AccountID == AccountId)
                    {
                        if (sA.Balance >= amount)
                        {
                            //if successful
                            sA.Balance -= amount;
                            return 1;
                        }
                        else
                            return -1;
                    }

                }
                //if fail
                return 4042;
            }   
            catch (NullReferenceException)
            {
                return 404;
            }
            //catch (Exception)
            //SavingsAccount account = allSavingsAccounts.Find((SavingsAccount a) =>  a.AccountID == AccountId);

         
        }

        static public bool ChangeCustomerName(long Pnr, string firstname, string lastname)
        {
            try
            {
                //int CustomerIndex = allCustomers.FindIndex((Customer c) => { return c.PersonID == Pnr; });
                //allCustomers[CustomerIndex].FirstName = firstname;
                //allCustomers[CustomerIndex].LastName = lastname;
                Customer AccountOwner = allCustomers.Find((Customer c) => { return c.PersonID == Pnr; });
                AccountOwner.FirstName = firstname;
                AccountOwner.LastName = lastname;
                return true;
            }
            catch (NullReferenceException)
            {
                return false;
            }
        }

        static public string GetAccount(int AccountId, long Pnr)
        {
            //SavingsAccount account = allSavingsAccounts.Find((SavingsAccount a) => { return a.AccountID == AccountId; });
            try
            {
                Customer AccountOwner = allCustomers.Find((Customer c) => { return c.PersonID == Pnr; });
                foreach (SavingsAccount sA in AccountOwner.OwnedAccounts)
                {
                    if (sA.AccountID == AccountId)
                    {
                        return "Account ID:" + Convert.ToString(sA.AccountID) + "\nBalance: " + Convert.ToString(sA.Balance) + "\nInterest rate: " + Convert.ToString(sA.InterestRate * 100) + " %\n";
                    }
                    
                        
                }
                return "Account not Found";
            }
            catch (NullReferenceException)
            {
                return "Customer or Account not found";
            }

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
                myList.Add(c.PersonID.ToString() + "\n" + c.FirstName + " " + c.LastName + "\n");
            }
            return myList;
        }

        static public string CloseAccount(int AccountId, long Pnr)
        {

            try
            {
                Customer myCustomer = allCustomers.Find((Customer c) => { return c.PersonID == Pnr; });
                int i = myCustomer.OwnedAccounts.FindIndex((SavingsAccount sA) => { return sA.AccountID == AccountId; });
                decimal earnedMoney = CalculateInterestReturn(myCustomer.OwnedAccounts[i]);
                string AccountInfo = GetAccount(AccountId, Pnr);
                myCustomer.OwnedAccounts.RemoveAt(i);

                return AccountInfo + "Account now closed, Earning " + earnedMoney.ToString() + " through interest.\n";
            }
            catch (ArgumentOutOfRangeException)
            {
                return "Account doesn't exist, Try a different Account ID.";
            }
            catch (IndexOutOfRangeException)
            {
                return "Account doesn't exist, Try a different Account ID.";
            }

            catch (Exception x)
            {
                return x.ToString();

            }
           
        }
        static public decimal CalculateInterestReturn(SavingsAccount sA)
        {
            decimal earnedMoney = sA.Balance * sA.InterestRate;

            return earnedMoney;

        }
        static public List<string> RemoveCustomer(long Pnr)
        {
            List<string> result = new List<string>();
            try
            {
                Customer myCustomer = allCustomers.Find((Customer c) => { return c.PersonID == Pnr; });
                //WHat im doing next! find a way to close all accounts of a customer.
                decimal earnedMoney = 0m;
                List<int> accIdCollection = new List<int>();
                for (int i = 0; i < myCustomer.OwnedAccounts.Count; i++)
                {
                    earnedMoney += CalculateInterestReturn(myCustomer.OwnedAccounts[i]);
                    accIdCollection.Add(myCustomer.OwnedAccounts[i].AccountID);
                }
                for (int i = 0; i < accIdCollection.Count; i++)
                {
                    result.Add(CloseAccount(accIdCollection[i], Pnr));
                }
                allCustomers.Remove(myCustomer);
                result.Add("In total the customer earned " + earnedMoney.ToString() + " through interest\n");
                return result;

            }
            catch (NullReferenceException)

            {
                result.Add("Customer not found in database");
                return result;
            }
            catch (Exception x)
            {
                result.Add(x.ToString());
                return result;
            }
            
          

        }


    }
}
