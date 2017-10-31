using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Customer
    {
        private long personID;
        public long PersonID
        {
            get
            {
                return personID;
            }
        }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private List<SavingsAccount> ownedAccounts;
        public List<SavingsAccount> OwnedAccounts
        {
            get
            {
                return ownedAccounts;
            }
            set
            {
                ownedAccounts = value;
            }
        }


        public Customer(long newPnr, string newFN, string newLN)
        {
            personID = newPnr;
            FirstName = newFN;
            LastName = newLN;
            ownedAccounts = new List<SavingsAccount>();
        }
    }   
}
