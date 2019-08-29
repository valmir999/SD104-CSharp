using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritanceAndPolym
{
    class SavingsAccount : Account
    {
        private const int MONTHLY_WITHDRAWAL_LIMIT = 5;
        public decimal InterestRate { set; get; }
        public int WidrawalIsThisMonth { get; set; }

        // Set the initial Balance
        public SavingsAccount(decimal initialBalance, int withdrawalsThisMonth) : base(initialBalance)
        {
            WidrawalIsThisMonth = withdrawalsThisMonth;
        }

        public override Transaction Withdrawal(decimal amount)
        {
            // Implement the withdral transaction logic here

            Transaction thisTransaction = new Transaction();
            thisTransaction.AccountNumber = AccountNumber;
            thisTransaction.Amount = amount;
            thisTransaction.TimeStamp = DateTime.Now;
            thisTransaction.isSuccessful = false;

            //perform withdrawal

            if (amount > Balance)
            {
                thisTransaction.Detail = "Transaction Failed, Insufficient Balance. $ "+Balance;
                Console.WriteLine("Transaction Failed, Insufficient Balance.");
            }
            else if(WidrawalIsThisMonth > MONTHLY_WITHDRAWAL_LIMIT)
            {
                thisTransaction.Detail = "Transaction Failed, due to monthly withdrawal limit";
                Console.WriteLine("Transaction Failed, due to monthly withdrawal limit");
            }
            else
            {
                Balance -= amount;
                thisTransaction.isSuccessful = true;
                thisTransaction.Detail = "Debit Transaction for account number " + AccountNumber + " with the amount of $ " + amount;
                Console.WriteLine(thisTransaction.Detail);
            }
            return thisTransaction;
        }

        public void ProcessProfit()
        {
            Balance += Balance * InterestRate;

        }
    }
}
