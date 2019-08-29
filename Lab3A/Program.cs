// Lab 3A
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
        private static string answerYN;

        static void Main(string[] args)
        {
            // program header/title info
            Console.WriteLine("This program calculates your BMI");
            Console.WriteLine("");

            // declare variables
            double dblHeight;
            double dblWeight;
            double dblBMI;

GetUserInput:

            // user input  
            Console.Write("Enter your Height in inches: ");

            //validate
            while (!double.TryParse(Console.ReadLine(), out dblHeight) || dblHeight < 0)
            {
                Console.WriteLine("Not valid. Must be a positive rational number.");
            }

            // user input  
            Console.Write("Enter your Weight in inches: ");

            //validate
            while (!double.TryParse(Console.ReadLine(), out dblWeight) || dblWeight < 0)
            {
                Console.WriteLine("Not valid. Must be a positive rational number.");
            }

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

            answerYN = "";
            Console.Write("Do you want to do another run (Y/N)?");

TryAgain:

            answerYN = Console.ReadLine();
            if (answerYN.ToUpper() == "Y" )
            {
                Console.WriteLine("");
                goto GetUserInput;
            }
            else if (answerYN.ToUpper() == "N")
            {
                System.Environment.Exit(0);
            }
            else
            {
                Console.Write("Tray Again -- Please enter (Y/N)?");
                goto TryAgain;
            }
            Console.WriteLine("");
        }
    }
}
