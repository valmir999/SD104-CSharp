using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            string exit = "";
            Random rnd = new Random();
            while (!exit.Equals("x"))
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("CASH REGISTER - POS TERMINAL 001");
                Console.WriteLine("--------------------------------");

                retry: //when exception occurs, cash register keeps going

                try
                {
                    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    // Commented logic would allow user to input values for tendered amount and price                             //        
                    // Which in this case the auto generated tendered amount and price must be commented before compiling program //
                    //                    Console.Write("Enter tendered amount $ ");                                              //
                    //                    decimal tendered = Convert.ToDecimal(Console.ReadLine());                               //
                    //                    Console.Write("Enter price $ ");                                                        //
                    //                    decimal price = Convert.ToDecimal(Console.ReadLine());                                  //
                    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    // auto generating price and tendered amount
                    int intPrice = rnd.Next(1, 100);
                    decimal price = (decimal)intPrice / 100.00M + rnd.Next(10);
                    int tendered = rnd.Next((int)price + 1, (int)price + rnd.Next(5));

                    // displaying values before transaction 
                    Console.WriteLine();
                    Console.WriteLine("Amount tendered.....   {0:C2}", tendered);
                    Console.WriteLine("Purchase amount.....   {0:C2}", price);
                    Console.WriteLine("                      ----------");
                    Console.WriteLine("Change..............   {0:C2}", (tendered - price));
                    Console.WriteLine();

                    // open cash register make change and hand back change to customer
                    string change = MakingChange(tendered - price);
                    Console.WriteLine(change);
                    Console.WriteLine("Please return change to customer. ");
                    Console.WriteLine();
                    Console.Write("Type x to stop ");
                    exit = Console.ReadLine();
                    Console.WriteLine();
                }
                catch (Exception) { goto retry; } // on exception, keep processing transactions until user quit
            }
        }

        static public string MakingChange(decimal t)
        {
            // variable declarations
            int[] bills = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            string[] notes = new string[10] { "Hundred", "Fift", "Twent", "Ten", "Five", "Dollar", "Quarter", "Dime", "Nickel", "Penn" };
            int cnt = 0, lastIdx = -1; // control displying ',' or and when changeDue string is built
            string changeDue;
            string endOfWord = "y"; // controls singular/plural words
            int prevIndex;

            // initialize change
            decimal change = t;

            // check for hundreds fifties twenties tens fives and ones first
            if (change >= 1.00M)
            {
                while (change >= 1.00M) 
                {
                    cnt++;
                    if (change >= 100.0M) // hundreds
                     {
                        change = change - 100.0M;
                        bills[0]++;
                        lastIdx = 0;
                    }
                    else if (change >= 50.0M) // fifties
                     {
                        change = change - 50.0M;
                        bills[1]++;
                        lastIdx = 1;
                    }
                     else if (change >= 20.0M)// twenties
                     {
                        change = change - 20.0M;
                        bills[2]++;
                        lastIdx = 2;
                    }
                    else if (change >= 10.0M) // tens
                     {
                        change = change - 10.0M;
                        bills[3]++;
                        lastIdx = 3;
                    }
                    else if (change >= 5.0M) // fives
                    {
                        change = change - 5.0M;
                        bills[4]++;
                        lastIdx = 4;
                    }
                    else // ones
                    {
                        change = change - 1.00M;
                        bills[5]++;
                        lastIdx = 5;
                    }
                }
            }

            // check for cents (quarter dimes nickels and pennies
            while (change > .0M)
            {
                cnt++;

                if (change >= .25M) // quaters
                {
                    change -= .25M;
                    bills[6]++;
                    lastIdx = 6;
                }
                else if (change >= .10M) // dimes
                {
                    change -= .10M;
                    bills[7]++;
                    lastIdx = 7;
                }
                else if (change >= 0.05M) // nickels
                {
                    change -= .05M;
                    bills[8]++;
                    lastIdx = 8;
                }
                else // pennies
                {
                    change -= .01M;
                    bills[9]++;
                    if (bills[1] > 1) { endOfWord = "ies"; } // penny gets plurul 'ies'
                    lastIdx = 9;
                }
            }

            prevIndex = lastIdx;

            if (lastIdx > 0)
            {
                for (int n = lastIdx - 1; n >= 0; n--)
                {
                    prevIndex = n;
                    if (bills[n] != 0) { break; }
                }
            }
            else { prevIndex = -1; }

            if (cnt > 0)
            {
                // build Change Due string
                changeDue = "Change due: ";
                for (int i = 0; i <= lastIdx; i++)
                {
                    if (bills[i] > 0)
                    {
                        endOfWord = ""; // default singular words
                        if (i == 1 || i == 2 || i == 9) { endOfWord = "y"; } // fifty, twenty and penny get 'y' at the end
                        if (bills[i] > 1)
                        {
                            endOfWord = "s"; // regular plurul words get 's'
                            if (i == 1 || i == 2 || i == 9) { endOfWord = "ies"; } // only for fifties, twenties and pennies
                        }
                        if (i == lastIdx) { endOfWord = endOfWord + "."; }
                        else if (i == prevIndex) { endOfWord = endOfWord + " and "; }
                        else { endOfWord = endOfWord + ", "; }
                        changeDue = changeDue + bills[i].ToString() + " " + notes[i] + endOfWord;
                    }
                }
            }
            else { changeDue = "Dollar amount is even - 'NO CHANGE DUE.'"; }

            return changeDue;
        }
    }
}