//Write a short program that prints each number from 1 to 100 on a new line.

//For each multiple of 3, print "Fizz" instead of the number.

//For each multiple of 5, print "Buzz" instead of the number. 

//For numbers which are multiples of both 3 and 5, print "FizzBuzz" instead of the number.
//Write a solution (or reduce an existing one) so it has as few characters as possible.

//Scoring
//Your score is: 

using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("First run");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine((i%15==0)?"FizzBuzz":(i % 5==0)?"Buzz":(i%3==0)?"Fizz":i.ToString());
              }
            Console.ReadLine();

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Second run");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            for (int i = 1; i <= 100; i++)
            {
                int three = i % 3;
                int five = i % 5;
                if ((three == 0) && (five == 0))
                    Console.WriteLine("FizzBuzz");
                else if (three == 0)
                    Console.WriteLine("Fizz");
                else if (five == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
            Console.ReadLine();

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Third run");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
