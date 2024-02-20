using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    internal class Account
    {
        //property
        public decimal Balance { get; set; }

        //constructor
        public Account (decimal initialBalance)
        {
            Balance = initialBalance;
        }

        //method
        public void deposit (decimal amount)
        {
            //Balance = Balance + amount;
            Balance += amount;
        } 
    }
}
