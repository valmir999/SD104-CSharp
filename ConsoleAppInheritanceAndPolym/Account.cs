using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritanceAndPolym
{
    class Account
    {
        /// <summary>
        /// Inheritance
        /// Parent Class
        /// </summary>
        public string AccountNumber { get; set; }

        public decimal Balance { get; set; }

        // Set our account balance, initial balance value using constructor
        public Account(decimal initalBalance)
        {
            Balance = initalBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }
}
