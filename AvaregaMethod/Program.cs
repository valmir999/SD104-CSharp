using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaregaMethod
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Calculate avarege");
            Console.WriteLine("-----------------");

            //declarations

            int firstNum, secondNum = 0;

            while (true)
            {
                do
                {
                    Console.WriteLine("");
                    Console.Write("Enter first number: ");
                } while (!Int32.TryParse(Console.ReadLine(), out firstNum));

                do
                {
                    Console.Write("Enter second number: ");
                } while (!Int32.TryParse(Console.ReadLine(), out secondNum));

                int averageNum = CalcAverage(firstNum, secondNum);
                Console.WriteLine("");
                Console.WriteLine("Average is " + averageNum + "%.");
                Console.WriteLine("");

                if (averageNum < 25 )
                {
                    Console.WriteLine("Average " + averageNum + "% is below 25%!!! Try again...");
                }
                else
                {
                    Console.WriteLine("Average is " + averageNum + "%. Great... It's above 25%!!! Hit any key to continue...");
                    Console.ReadLine();
                    break;
                }
            }

        }

        private static int CalcAverage(int x, int y)
        {
            return x / y;
        }
    }
}
