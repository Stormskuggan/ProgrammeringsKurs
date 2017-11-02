﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class SavingsAccount
    {
        enum Accounttype { Sparkonto, Kreditkonto }
    
        private decimal balance;
        public decimal Balance
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
        public decimal InterestRate { get; set; }

        private int accountID;
        public int AccountID
        {
            get
            {
                return accountID;
            }

        }
        
        public SavingsAccount(int NewID)
        {
            balance = 0;
            InterestRate = 0.01m;
            accountID = NewID;
        }



    }
}
