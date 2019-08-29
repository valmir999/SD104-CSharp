using System;

namespace Lab_Reverse_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program, that takes a user input n times;
            // Store it in an array
            // Loop through it, and display the array backwards

            Console.Write("Please enter how many numbers you want in your array: ");
            int input;

            // Validating the size of the array
            while (Int32.TryParse(Console.ReadLine(), out input) == false)
            {
                Console.Write("Not a number. Please enter a number: ");
            }

            // Setting the size of the array through the number the user input
            int[] userArray = new int[input];

            // Creating the array through user input
            for (int count = 0; count < userArray.Length; count++)
            {
                Console.Write("Please enter the value for number " + (count + 1) + ": ");
                while (Int32.TryParse(Console.ReadLine(), out input) == false)
                {
                    Console.Write("Not a number. Please enter a number: ");
                }
                userArray[count] = input;
            }

            Console.WriteLine("Your array backwards is: ");
            Console.WriteLine("-------------------------");

            for (int count = userArray.Length - 1; count >= 0; count--)
            {
                if (count != 0)
                    Console.Write(userArray[count] + " , ");
                else
                    Console.Write(userArray[count]);
            }

            Console.Read();
        }
    }
}