using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_1_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance;
            string accountName;
            int menuOption = 0;

            Console.WriteLine();
            Console.WriteLine("   A   T   M");
            Console.WriteLine();

            do
            {
                menuOption = GetNumber("Select an option:\n\n1 - Exit ATM\n2 - Create Checking\n3 - Create Savings\n");
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
                        Checking NewChecking  = new Checking(accountName, balance, 0.02f);
                        DisplayAccountInfo("CHECING ACCOUNT",NewChecking.AccountName, NewChecking.Balance, NewChecking.InterestRate);
                        break;

                    case 3:
                        accountName = GetInput("Account Name: ");
                        balance = GetNumber("Initial balance: ");
                        Savings NewSavings = new Savings(accountName, balance, 0.03f);
                        DisplayAccountInfo("SAVINGS ACCOUNT", NewSavings.AccountName, NewSavings.Balance, NewSavings.InterestRate);
                        break;

                    default:
                        menuOption = 1;
                        break;
                }
            } while (menuOption != 1);
        } // end of the Main method. Everything comes after here


        public static void DisplayAccountInfo(string AccTyp, string acctNam, decimal acctBal, float acctInt)
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("YOU JUST CREATED A " + AccTyp + " - SUMMARY IS BELLOW:");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("The name of the account you created is: {0}", acctNam);
            Console.WriteLine("The initial balance is................: {0:C2}", acctBal);
            Console.WriteLine("The fixed interest rate is............: {0:P2}", acctInt/100);
            Console.WriteLine();
            Console.WriteLine("");
        }   // end of DisplayAccountInfo

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