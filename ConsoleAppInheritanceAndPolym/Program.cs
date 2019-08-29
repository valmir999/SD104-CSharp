using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritanceAndPolym
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount myChkAccount = new CheckingAccount(1000);
            Console.WriteLine("Initiate withdrawl of $250");
            myChkAccount.Withdrawal(250);
            Console.WriteLine("Balance is: $ "+myChkAccount.Balance);
            Console.ReadLine();

            Console.WriteLine("Initiate withdrawl of $850");
            myChkAccount.Withdrawal(850);
            Console.WriteLine("Balance is: $ " + myChkAccount.Balance);
            Console.ReadLine();

        }
    }
}
