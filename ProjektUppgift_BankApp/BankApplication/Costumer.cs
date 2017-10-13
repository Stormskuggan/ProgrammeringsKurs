using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Costumer
    {

        public int PersonNummer { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private List<SavingsAccount> ownedAccounts;
        



    }
}
