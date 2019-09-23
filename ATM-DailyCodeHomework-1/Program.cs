using System;
using System.Collections.Generic;

namespace ATM_DailyCodeHomework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance;
            string accountName;
            int menuOption = 0;
            Checking checking = null;
            Savings savings = null;
            decimal deposit;

            Console.WriteLine();
            Console.WriteLine("   A   T   M");
            Console.WriteLine();

            while (menuOption != 1)
            { 
                menuOption = GetNumber("Select an option:\n\n1 - Exit ATM\n2 - Create Checking\n3 - Create Savings\n" +
                                       "4 - Get Checking Balance\n5 - Get Get Savings Balance\n6 - Make a Deposit to Checking\n" +
                                       "7 - Make a Deposit to Savings\n\n");
                switch (menuOption)
                {
                    case 1:
 //                       System.Environment.Exit(0); //  exit the ATM
                        break; 
                    case 2:
                        accountName = GetInput("Account Name: ");
                        balance = GetNumber("Initial balance: ");
                        checking = new Checking(accountName, balance, 0.02f);
                        break;

                    case 3:
                        accountName = GetInput("Account Name: ");
                        balance = GetNumber("Initial balance: ");
                        savings = new Savings(accountName, balance, 0.03f);
                        break;
                    case 4:
                        balance = GetNumber("Initial balance: ");
                        break;
                    case 5:
                        balance = GetNumber("Initial balance: ");
                        break;
                    case 6:
                        balance = GetNumber("Deposit amount: ");
                        deposit = Deposit();
                        break;
                    case 7:
                        accountName = GetInput("Deposit amount: ");
                        balance = GetNumber("Initial balance: ");
                        savings = new Savings(accountName, balance, 0.03f);
                        break;
                    default:
                        break;
                }
            }
        }   // end of the Main method. Everything comes after here

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