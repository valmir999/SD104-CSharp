using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleAppInheritanceAndPolym
{    
    /// <summary>    
    /// Parent Class   
    /// </summary>    
    abstract class Account    
    {       
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        
        // Set our account balance , initial balance value using constructor        
        public Account(decimal initalBalance)
        {
            Balance = initalBalance;
        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        // child class can implement its own Withdrawl method with custom logic    
        public abstract Transaction Withdrawal(decimal amount);
    }
}