using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_3_HW
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
            decimal transfer = 0;

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("                    A   T   M");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();

            do
            {
                menuOption = GetNumber("Select an option:\n\n1 - Exit ATM\n2 - Create Checking\n3 - Create Savings\n" +
                                       "4 - Get Checking Balance\n5 - Get Get Savings Balance\n6 - Make a Deposit to Checking\n" +
                                       "7 - Make a Deposit to Savings\n" +
                                       "8 - Transfer money\n\n" +
                                       "    Type in your option ---> ");
                Console.WriteLine();
                switch (menuOption)
                {
                    case 1:
                        System.Environment.Exit(0);
                        menuOption = 1;
                        break;
                    case 2:
                        if (NewChecking == null)
                        {
                            accountName = GetInput("Account Name: ");
                            balance = GetNumber("Initial balance: ");
                            NewChecking = new Checking(accountName, balance, 0.02f);
                            DisplayAccountInfo("CHECING ACCOUNT", NewChecking.AccountName, NewChecking.Balance, NewChecking.InterestRate);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Checking account already exists ---> " + NewChecking.AccountName);
                            Console.WriteLine("Type in any other option from menu.");
                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        if (NewSavings == null)
                        {
                            accountName = GetInput("Account Name: ");
                            balance = GetNumber("Initial balance: ");
                            NewSavings = new Savings(accountName, balance, 0.03f);
                            DisplayAccountInfo("SAVINGS ACCOUNT", NewSavings.AccountName, NewSavings.Balance, NewSavings.InterestRate);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Savings account already exists ---> " + NewSavings.AccountName);
                            Console.WriteLine("Type in any other option from menu.");
                            Console.WriteLine();
                        }
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
                    case 8:
                        if (NewChecking != null && NewSavings != null)
                        {
                            // Variables declaration
                            int FromAcct = 0;
                            int ToAcct = 0;
                            bool transfered = true;
                            decimal iniBalanceFrom, iniBalanceTo;
                            string msg = "";
                            do
                            {
                                // Get From acct - 1 = Checking or 2 = Savings
                                accountName = GetInput("Trasfer From Account: ");
                                FromAcct = GetFromAcct(NewChecking, NewSavings, accountName);
                            } while (FromAcct == 0);

                            do
                            {
                                ToAcct = FromAcct; // Initialize Flag ToAcct = FromAcct

                                // Get To acct - 1 = Checking or 2 = Savings
                                accountName = GetInput("Trasfer To Account: ");
                                ToAcct = GetToAcct(NewChecking, NewSavings, accountName, ToAcct);
                            } while (ToAcct == 0);

                            transfer = Convert.ToDecimal(GetNumber("Treansfer amount: "));

                            switch (FromAcct)
                            {
                                case 1:
                                    transfered = false; // No transfer was made
                                    if (NewChecking.Balance >= transfer)
                                    {
                                        iniBalanceFrom = NewChecking.Balance;
                                        iniBalanceTo = NewSavings.Balance;
                                        NewChecking.Withdrawal(transfer, 5.00M);
                                        NewSavings.Deposit(transfer);
                                        if (NewSavings.Balance > iniBalanceTo)
                                        {
                                            ConfirmTransfer(NewChecking.AccountName, NewSavings.AccountName, transfer, NewChecking.Balance, NewSavings.Balance);
                                            transfered = true; // Transfer was made
                                        }
                                    }
                                    else
                                    {
                                        msg = "Couldn't transfer money between accounts. Checking doesn't have enough funds.";
                                    }
                                    break;
                                case 2:
                                    transfered = false; // No transfer was made
                                    if (NewSavings.Balance >= transfer)
                                    {
                                        iniBalanceFrom = NewSavings.Balance;
                                        iniBalanceTo = NewChecking.Balance;
                                        NewSavings.Withdrawal(transfer, 5.00M);
                                        NewChecking.Deposit(transfer);
                                        if (NewChecking.Balance > iniBalanceTo)
                                        {
                                            ConfirmTransfer(NewSavings.AccountName, NewChecking.AccountName, transfer, NewSavings.Balance, NewChecking.Balance);
                                            transfered = true; // Transfer was made
                                        }
                                    }
                                    else
                                    {
                                        msg = "Couldn't transfer money between accounts. Savings doesn't have enough funds.";
                                    }
                                    break;

                                default:
                                    break;
                            }

                            if (!transfered)
                            {
                                Console.WriteLine();
                                Console.WriteLine(msg);
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Couldn't efetuate transaction. Please create two accounts to procced.");
                            Console.WriteLine();
                        }

                        break;

                    default:
                        menuOption = 1;
                        break;
                }
            } while (menuOption != 1);
        } // end of the Main method. Everything comes after here

        public static int GetFromAcct(Checking C, Savings S, string N)
        {
            if (C.AccountName == N)
            {
                return 1; // From Acct is Checking
            } 
            else if (S.AccountName == N)
            {
                return 2; // From Acct is Savings
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Account name not valid!!!");
                Console.WriteLine("Checking Account name is: " + C.AccountName);
                Console.WriteLine("Savings Account name is: " + S.AccountName);
                Console.WriteLine();
                return 0; // Not a valid Acct
            }
        }   // end of the GetFromAcct method

        public static int GetToAcct(Checking C, Savings S, string N, int F)
        {
            if (C.AccountName == N && F == 2)
            {
                return 1; // From Acct is Checking
            }
            else if (S.AccountName == N && F == 1)
            {
                return 2; // From Acct is Savings
            }
            if (C.AccountName == N && F == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Not a valid entry. Checking Account: " + N + " is the From Account.");
                Console.WriteLine("Savings Account name is: " + S.AccountName);
                Console.WriteLine();
                return 0; // Not a valid Acct
            }
            else if (S.AccountName == N && F == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Not a valid entry. Savings Account: " + N + " is the From Account.");
                Console.WriteLine("Checking Account name is: " + C.AccountName);
                Console.WriteLine();
                return 0; // Not a valid Acct
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Account name not valid!!!");
                if (F == 1)
                {
                    Console.WriteLine("Savings Account name is: " + S.AccountName);
                }
                else
                {
                    Console.WriteLine("Checking Account name is: " + C.AccountName);
                }
                Console.WriteLine();
                return 0; // Not a valid Acct
            }
        }   // end of the GetToAcct method
        public static void DisplayAccountInfo(string AccTyp, string acctNam, decimal acctBal, float acctInt)
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("YOU JUST CREATED A " + AccTyp + " - SUMMARY IS BELLOW:");
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


        public static void ConfirmTransfer(string fromAcct, string toAcct, decimal amount, decimal fromNewBal, decimal toNewBal)
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("         T R A N S F E R   R E C E I P T  ");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("         From: {0}", fromAcct);
            Console.WriteLine("         Amount.........: {0:C2}", amount);
            Console.WriteLine("         New Balance....: {0:C2}", fromNewBal);
            Console.WriteLine();
            Console.WriteLine("         -----------------------------");
            Console.WriteLine();
            Console.WriteLine("         To  : {0}", toAcct);
            Console.WriteLine("         Amount.........: {0:C2}", amount);
            Console.WriteLine("         New Balance....: {0:C2}", toNewBal);
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
