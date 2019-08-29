using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleAppInheritanceAndPolym
{   
    /// <summary>    
    /// Polymorphism Implementation     
    /// </summary>    
    class Program
    {        static void Main(string[] args)
        {
            Account myAccount;
            myAccount = new CheckingAccount(1000);
            myAccount.Withdrawal(500);
            Console.WriteLine(myAccount.GetType());
            myAccount = new SavingsAccount(2000, 0);
            myAccount.Withdrawal(1500);
            myAccount.Deposit(500);
            SavingsAccount mySav = new SavingsAccount(1000,2);
            // mySav.InterestRate = 10/100;        
            mySav.InterestRate = 10;
            mySav.ProcessProfit();
            Console.WriteLine("Balance after processing profit"+mySav.Balance);
            Console.WriteLine(myAccount.Balance);
            Console.WriteLine(myAccount.GetType());
            Console.ReadLine();
        }
    }
}