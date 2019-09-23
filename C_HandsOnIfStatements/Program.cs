//This is not a method just lines of code using the if statement
//Given the following variables
//int x = 100;
//int y = 200;
//int z = 101;
//string name = "just a test";
//Create if statements for
//if x plus z is greater that y then print something to the console, else print a different message
//if x minus 1 plus z is equal to y then print something to the console, else print a different message
//if name is longer than 12 then print something to the console, else print a different message
//if name contains "test" then print something to the console, else print a different message
//if the sum of x, y and z is < 301 then print something to the console, else print a different message

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HandsOnIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given variables
            int x = 100;
            int y = 200;
            int z = 101;
            string name = "just a test";

            DisplayHeader();
            Console.WriteLine("The value of x = " + x);
            Console.WriteLine("The value of y = " + y);
            Console.WriteLine("The value of z = " + z);
            Console.WriteLine("The string name is: " + name);
            Console.WriteLine();

            //if x plus z is greater that y then print something to the console, else print a different message
            if (x + z > y) { Console.WriteLine("The equation x+z > y is correct because (" + x + " + " + z + " > " + y + ")"); }
            else { Console.WriteLine("The equation x+z > y is incorrect because (" + x + " + " + z + " = " + (x+y) + " which is smaller than y="+ y +")"); }
            Console.WriteLine();

            //if x minus 1 plus z is equal to y then print something to the console, else print a different message
            if (((x-1) + z) == y) { Console.WriteLine("The equation (x-1)+z = y is correct because (" + (x-1) + " + " + z + " = " + y + ")."); }
            else { Console.WriteLine("The equation (x-1)+z = y is incorrect."); }
            Console.WriteLine();

            //if name is longer than 12 then print something to the console, else print a different message
            if (name.Length > 12) { Console.Write("The string name ( "+ name + ") is larger then 12. "); }
            else { Console.Write("The string name (" + name + ") is smaller then 12. "); }
            Console.WriteLine("It has " + name.Length + " characters.");
            Console.WriteLine();

            //if name contains "test" then print something to the console, else print a different message
            bool has_test = name.Contains("test");
            Console.WriteLine("Does the string name contain test? " + (has_test ? "Yes it does!" : "No, it doesn't cointain test!!!"));
            Console.WriteLine();

            //if the sum of x, y and z is < 301 then print something to the console, else print a different message
            if ((x + y + z) < 301) { Console.WriteLine("The sum of x-y+z = 301 because (" + x + " + " + y + " + " + z + " = 301)"); }
            else { Console.WriteLine("The sum of x-y+z is not equal to 301 because (" + x + " + " + y + " + " + z + " = " + (x+y+z) + ")."); }
            Console.WriteLine();

            Console.WriteLine("Hit any key to exit...");
            Console.ReadLine();
        }
        static public void DisplayHeader()
        {
            Console.WriteLine("         Hands on - If Statements");
            Console.WriteLine("         ------------------------");
            Console.WriteLine();
        }

    }
}
