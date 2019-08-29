using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_BMI_Calculator
{
    class Program
    {
        private static int nUserPick;
        private static bool loopExit;

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    // This program:
                    // Write a program that asks for two integers.  Display their sum, product, difference and quotient.  
                    // Be mindful of integer division and make sure to display the quotient as a rational number 
                    // and not a truncated whole number.

                    // variable declaration
                    string answerYN;
                    int firstNum, secondNum, resultNum;

                    // Get input
                    Console.WriteLine("Write a program that asks for two integers.");
                    Console.WriteLine("Display their sum, product, difference and quotient.");
                    Console.WriteLine("Valid input for numbers are integer only");
                    Console.WriteLine("Type 0 for first or second number to exit");
                    Console.WriteLine("<-------------------------------------------------->");
                    Console.WriteLine("");

                    loopExit = true;

                EnterFirstNumOutofLoop:
                    Console.Write("Enter first number: ");
                    if (!int.TryParse(Console.ReadLine(), out nUserPick))
                    {
                        Console.WriteLine("Not a valid input. Try Again.");
                        goto EnterFirstNumOutofLoop;
                    }
                    firstNum = Convert.ToInt32(nUserPick);
                    if (firstNum == 0)
                    {
                        loopExit = false;
                        System.Environment.Exit(0);
                    }

                EnterSecondNumOutofLoop:
                    Console.Write("Enter second number: ");
                    if (!int.TryParse(Console.ReadLine(), out nUserPick))
                    {
                        Console.WriteLine("Not a valid input. Try Again.");
                        Console.WriteLine("");
                        Console.WriteLine("Remember your first number was :" + firstNum);
                        goto EnterSecondNumOutofLoop;
                    }
                    secondNum = Convert.ToInt32(nUserPick);
                    if (secondNum == 0)
                    {
                        loopExit = false;
                        System.Environment.Exit(0);
                    }

                    int cnt;
                    cnt = 0;
                    while (loopExit)
                    {
                        if (cnt > 0)
                        {
                        EnterFirstNumInLoop:
                            Console.Write("Enter first number: ");
                            if (!int.TryParse(Console.ReadLine(), out nUserPick))
                            {
                                Console.WriteLine("Not a valid input. Try Again.");
                                goto EnterFirstNumInLoop;
                            }
                            firstNum = Convert.ToInt32(nUserPick);
                            if (firstNum == 0)
                            {
                                loopExit = false;
                                System.Environment.Exit(0);
                            }

                        EnterSecondNumInLoop:
                            Console.Write("Enter second number: ");
                            if (!int.TryParse(Console.ReadLine(), out nUserPick))
                            {
                                Console.WriteLine("Not a valid input. Try Again.");
                                Console.WriteLine("");
                                Console.WriteLine("Remember your first number was :" + firstNum);
                                goto EnterSecondNumInLoop;
                            }
                            secondNum = Convert.ToInt32(nUserPick);
                            if (secondNum == 0)
                            {
                                loopExit = false;
                                System.Environment.Exit(0);
                            }
                        }

                        cnt++;

                        Console.WriteLine("");
                        Console.WriteLine("This is run # " + cnt);
                        Console.WriteLine("--------------------");
                        Console.WriteLine("");

                        if (firstNum == 0 || secondNum == 0)
                        {
                            loopExit = false;
                            System.Environment.Exit(0);
                        }

                        // Sum of 2 number
                        resultNum = firstNum + secondNum;
                        Console.Write("1 - The sum of " + firstNum + " + " + secondNum + " equal to " + resultNum);
                        Console.WriteLine("");
                        Console.Write("1 - This is another way of doing it (firstNum + secondNum) with the same result: " + (firstNum + secondNum));
                        Console.WriteLine("");
                        Console.WriteLine("");

                        // Product sum of 2 number
                        resultNum = firstNum * secondNum;
                        Console.Write("2 - The sum of " + firstNum + " + " + secondNum + " equal to " + resultNum);
                        Console.WriteLine("");
                        Console.Write("2 - This is another way of doing it (firstNum * secondNum) with the same result: " + (firstNum * secondNum));
                        Console.WriteLine("");
                        Console.WriteLine("");

                        // Difference of 2 number
                        resultNum = firstNum - secondNum;
                        Console.Write("3 - The sum of " + firstNum + " + " + secondNum + " equal to " + resultNum);
                        Console.WriteLine("");
                        Console.Write("3 - This is another way of doing it (firstNum - secondNum) with the same result: " + (firstNum - secondNum));
                        Console.WriteLine("");
                        Console.WriteLine("");

                        // Quotient sum of 2 number
                        resultNum = firstNum / secondNum;
                        Console.Write("4 - The quotien of " + firstNum + " + " + secondNum + " equal to {0:F}", resultNum);
                        Console.WriteLine("");
                        Console.Write("4 - This is another way of doing it (firstNum / secondNum) with the same result: " + (firstNum / secondNum));
                        Console.WriteLine("");
                        Console.WriteLine("");
                        answerYN = "Y";

                        Console.Write("Do you want to do another run (Y/N)?");
                    RunAgain:
                        answerYN = Console.ReadLine();
                        if (answerYN.ToUpper() == "Y" || answerYN.ToUpper() == "N")
                        {
                            if (answerYN.ToUpper() == "N")
                            {
                                loopExit = false;
                                System.Environment.Exit(0);
                            }
                        }
                        else
                        {
                            Console.Write("Tray Again -- Please enter (Y/N)?");
                            goto RunAgain;
                        }
                        Console.WriteLine("");
                    }
                    Console.ReadLine();
                }
                catch (Exception e) { Console.WriteLine("Please try again !!!"); continue; }
            }
        }
    }
}
