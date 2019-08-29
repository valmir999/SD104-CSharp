using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraPracticeWithLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarations
            int maxNum, minNum, curNum = 0;
            int[] arrNums;

            int nInArray = GetNumber("Please enter how many numbers you want in your array: ");
            for (int i = 0; i < nInArray; i++)
            {
                curNum = GetNumber("Please enter the value for number " + i + ": ");
                arrNums[i] = curNum;

                if (curNum > maxNum)
                {
                    maxNum = curNum;
                }
                maxNum = Math.Max(num1, num2);
                minNum = Math.Min(num1, num2);

            }

        }

        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public static int GetNumber(string prompt)
        {
            int num;
            Console.WriteLine(prompt);
            do
            {
                if (Int32.TryParse(Console.ReadLine(), out num))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Bad input. Try again");
                }
            } while (true);
            return num;
        }

        public static int GetNumber(string prompt, int max)
        {
            int num;
            do
            {
                num = GetNumber(prompt);
                if (num > max)
                {
                    Console.WriteLine("Number too large");
                }
            } while (num > max);
            return num;
        }


    }
}
