using System;

namespace HW2GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0, remNum = -1, maxNum = -1, minNum = -1, divNum = 0;
            string answerYN = "Y";

            // show program title
            Console.WriteLine("This program shows the GCD - Greatest Common Divisor");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" ");

        RunAgain:

            // user input N1
            Console.Write("N1 = ");
            while (!Int32.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("N1 = ");
            }
            Console.WriteLine("");

            // user input N2
            Console.Write("N2 = ");
            while (!Int32.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("N2 = ");
            }
            Console.WriteLine("");

            // using built in math methods to hold Max and Min numbers
            maxNum = Math.Max(num1, num2);
            minNum = Math.Min(num1, num2);

            divNum = maxNum / minNum;
            remNum = maxNum % minNum;

            while (remNum > 0)
            {
                Console.WriteLine(maxNum + "/" + minNum + " = " + divNum + " r " + remNum);
                maxNum = minNum;
                minNum = remNum;

                divNum = maxNum / minNum;
                remNum = maxNum % minNum;
            }

            Console.WriteLine(maxNum + "/" + minNum + " = " + divNum + " r " + remNum);
            Console.WriteLine("");
            Console.Write("Do you want to do another run (Y/N)?");

        GetAnotherAns:
            answerYN = Console.ReadLine();
            if (answerYN.ToUpper() == "Y" || answerYN.ToUpper() == "N")
            {
                if (answerYN.ToUpper() == "N")
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("");
                    goto RunAgain;
                }
            }
            else
            {
                Console.Write("Tray Again -- Please enter (Y/N)?");
                goto GetAnotherAns;
            }
            Console.WriteLine("");
        }
    }
}


