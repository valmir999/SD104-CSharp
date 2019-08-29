

// Lab 3 BMI Calculator

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_BMI_Calculator
{
    class Program
    {
        // declare variables
        private static double nUserPick;
        private static string answerYN;

        static void Main(string[] args)
        {
            // program header/title info
            Console.WriteLine("This program calculates your BMI");
            Console.WriteLine("");

            while (true)
            {
                try
                {
                    // declare variables
                    double dblHeight;
                    double dblWeight;
                    double dblBMI;

                // user input
                InputHeight:
                    Console.Write("Enter your Height in inches: ");
                    if (!double.TryParse(Console.ReadLine(), out nUserPick))
                    {
                        Console.WriteLine("Invalid Entry!!! Try again... ");
                        Console.WriteLine("");
                        goto InputHeight;
                    }
                    dblHeight = Convert.ToInt32(nUserPick);

                InputWeight:
                    Console.Write("Enter your Weight in pounds: ");
                    if (!double.TryParse(Console.ReadLine(), out nUserPick))
                    {
                        Console.WriteLine("Invalid Entry!!! Try again... ");
                        Console.WriteLine("");
                        goto InputWeight;
                    }
                    dblWeight = Convert.ToInt32(nUserPick);

                    dblBMI = (dblWeight * 703) / (dblHeight * dblHeight);

                    // issue result and message
                    Console.WriteLine("Your BMI is {0:F}", dblBMI);

                    if (dblBMI < 18.5)
                    {
                        Console.WriteLine("BMI < 18.5 - Underweight");
                    }
                    else if (dblBMI <= 24.9)
                    {
                        Console.WriteLine("BMI between 18.5 and 24.9 - Normal");
                    }
                    else if (dblBMI < 29.9)
                    {
                        Console.WriteLine("BMI between 25 and 29.9 - Overweight");
                    }
                    else
                    {
                        Console.WriteLine("BMI > 30 - Obese");
                    }

                    Console.WriteLine("");
                    answerYN = "Y";
                    Console.Write("Do you want to do another run (Y/N)?");
                RunAgain:
                    answerYN = Console.ReadLine();
                    if (answerYN.ToUpper() == "Y" || answerYN.ToUpper() == "N")
                    {
                        if (answerYN.ToUpper() == "N")
                        {
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
                catch (Exception e) { Console.WriteLine("Please try again !!!"); continue; }
            }
        }
    }
}