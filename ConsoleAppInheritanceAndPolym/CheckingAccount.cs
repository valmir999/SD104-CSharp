using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritanceAndPolym
{
    /// <summary>
    /// Inherited from Account Class, Child class Checking Account
    /// </summary>
    class CheckingAccount : Account
    {
        public CheckingAccount(decimal initalBalance) : base(initalBalance)
        {

        }

        public Transaction Withdrawal(decimal amount)
        {
            // Create Transaction Object
            Transaction thisTransaction = new Transaction();
            thisTransaction.AccountNumber = AccountNumber;
            thisTransaction.Amount = amount;
            thisTransaction.isSuccessful = false;
            thisTransaction.TimeStamp = DateTime.Now;

            // try to process transaction

            if (amount > Balance)
            {
                thisTransaction.Detail = "Trnasaction Failed: Insufficient Funds.";
                Console.WriteLine("Trnasaction Failed: Insufficient Funds.");
            }
            else
            {
                Balance -= amount; // Balance = Balance - amount;
                thisTransaction.isSuccessful = true;
                thisTransaction.Detail = String.Format("Account#: {0} was debited{1}", thisTransaction.AccountNumber, thisTransaction.Amount);
                Console.WriteLine("Successfully withdrew from " + thisTransaction.AccountNumber + " debited amount of " + thisTransaction.Amount);
            }

            return thisTransaction;
        }
    }
}
