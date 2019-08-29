using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleAppInheritanceAndPolym
{
    class SavingsAccount : Account
    {
        private const int MOTHLY_WITHDRAWAL_LIMIT = 5;
        public decimal InterestRate { get; set; }
        public int WithdrawlsThisMonth { get; set; }
        // Set the initial Balance and Withdrawals this month        
        public SavingsAccount(decimal initialBalance, int withdrawalsThisMonth) : base(initialBalance)
        {
            WithdrawlsThisMonth = withdrawalsThisMonth;
        }
        public override Transaction Withdrawal(decimal amount)
        {
            // Implement the withdrawl transaction logic here            
            Transaction thisTransaction = new Transaction();
            thisTransaction.AccountNumber = AccountNumber;
            thisTransaction.Amount = amount;
            thisTransaction.TimeStamp = DateTime.Now;
            thisTransaction.isSuccessful = false;
            //perform withdrawal            
            if (amount > Balance)
            {
                thisTransaction.Detail = "Transaction Failed, Insufficent Balance. $" + Balance;
                Console.WriteLine("Transaction Failed, Insufficent Balance.");
            }
            else if (WithdrawlsThisMonth > MOTHLY_WITHDRAWAL_LIMIT)
            {
                thisTransaction.Detail = "Transaction Failed, due to monthly withdrawal limit";
                Console.WriteLine("Transaction Failed, due to monthly withdrawal limit");
            }
            else
            {
                Balance -= amount;
                thisTransaction.isSuccessful = true;
                thisTransaction.Detail = "Debit Transaction for account number " + AccountNumber + "with the amount of $" + amount;
                Console.WriteLine(thisTransaction.Detail);

            }
            return thisTransaction;
        }
        public void ProcessProfit()
        {
            Balance += Balance * InterestRate / 100;
        }
    }
}
