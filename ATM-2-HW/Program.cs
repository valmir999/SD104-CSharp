using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_2_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance;
            string accountName;
            int menuOption = 0;
            Checking NewChecking = null;
            Savings NewSavings = null;
            decimal deposit = 0;

            Console.WriteLine();
            Console.WriteLine("   A   T   M");
            Console.WriteLine();

            do
            {
                menuOption = GetNumber("Select an option:\n\n1 - Exit ATM\n2 - Create Checking\n3 - Create Savings\n" +
                                       "4 - Get Checking Balance\n5 - Get Get Savings Balance\n6 - Make a Deposit to Checking\n" +
                                       "7 - Make a Deposit to Savings\n\n");
                Console.WriteLine();
                switch (menuOption)
                {
                    case 1:
                        System.Environment.Exit(0);
                        menuOption = 1;
                        break;
                    case 2:
                        accountName = GetInput("Account Name: ");
                        balance = GetNumber("Initial balance: ");
                        NewChecking = new Checking(accountName, balance, 0.02f);
                        DisplayAccountInfo("CHECING ACCOUNT", NewChecking.AccountName, NewChecking.Balance, NewChecking.InterestRate);
                        break;

                    case 3:
                        accountName = GetInput("Account Name: ");
                        balance = GetNumber("Initial balance: ");
                        NewSavings = new Savings(accountName, balance, 0.03f);
                        DisplayAccountInfo("SAVINGS ACCOUNT", NewSavings.AccountName, NewSavings.Balance, NewSavings.InterestRate);
                        break;

                    case 4:
                        if (NewChecking != null) { DisplayBalance(NewChecking.AccountName, NewChecking.Balance); }
                        else { Console.WriteLine(); Console.WriteLine("Checking Account doesn't exist. Please use Option 2 to create one."); Console.WriteLine(); }
                        break;

                    case 5:
                        if (NewSavings != null) { DisplayBalance(NewSavings.AccountName, NewSavings.Balance); }
                        else { Console.WriteLine(); Console.WriteLine("Savings Account doesn't exist. Please use Option 3 to create one."); Console.WriteLine(); }
                        break;

                    case 6:
                        if (NewChecking != null) { deposit = Convert.ToDecimal(GetNumber("Deposit amount: ")); ConfirmDeposit(NewChecking.AccountName, deposit, NewChecking.Deposit(deposit)); }
                        else { Console.WriteLine(); Console.WriteLine("Checking Account doesn't exist. Please use Option 2 to create one."); Console.WriteLine(); }
                        break;

                    case 7:
                        if (NewSavings != null) { deposit = Convert.ToDecimal(GetNumber("Deposit amount: ")); ConfirmDeposit(NewSavings.AccountName, deposit, NewSavings.Deposit(deposit)); }
                        else { Console.WriteLine(); Console.WriteLine("Savings Account doesn't exist. Please use Option 3 to create one."); Console.WriteLine(); }
                        break;

                    default:
                        menuOption = 1;
                        break;
                }
            } while (menuOption != 1);
        } // end of the Main method. Everything comes after here

        public static void DisplayAccountInfo(string AccTyp, string acctNam, decimal acctBal, float acctInt)
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(    "YOU JUST CREATED A " + AccTyp + " - SUMMARY IS BELLOW:");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("The name of the account you created is: {0}", acctNam);
            Console.WriteLine("The initial balance is................: {0:C2}", acctBal);
            Console.WriteLine("The fixed interest rate is............: {0:P2}", acctInt / 100);
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();
        }   // end of DisplayAccountInfo


        public static void DisplayBalance(string acctNam, decimal acctBal)
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine(" --->  {0} Balance {1:C2}", acctNam, acctBal);
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
        }   // end of DisplayBalance

        public static void ConfirmDeposit(string acctNam, decimal acctDep, decimal acctBal)
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("         D E P O S I T   R E C E I P T  ");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("         Acct: {0}", acctNam);
            Console.WriteLine("         -----------------------------");
            Console.WriteLine("         Deposit of.....: {0:C2}", acctDep);
            Console.WriteLine();
            Console.WriteLine("         New Balance....: {0:C2}", acctBal);
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
        }   // end of DisplayBalance

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string str = Console.ReadLine();
            return str;
        }   // end of the GetInput method

        public static int GetNumber(string prompt)
        {
            int userNumber;
            string strNumber = GetInput(prompt);
            while (!Int32.TryParse(strNumber, out userNumber))
            {
                Console.WriteLine("That is not an integer");
                strNumber = GetInput(prompt);
            }
            return userNumber;
        }   // end of the GetNumber method
    }
}