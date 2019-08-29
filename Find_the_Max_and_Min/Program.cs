using System;

namespace Find_the_Max_and_Min
{
    class Program
    {
        static void Main(string[] args)
        {
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

            int min = userArray[0];
            int max = userArray[0];


            for (int count = 0; count < userArray.Length; count++)
            {
                if (userArray[count] < min)
                    min = userArray[count];

                if (userArray[count] > max)
                    max = userArray[count];
            }

            Console.WriteLine("Your minimum number is: " + min);
            Console.WriteLine("Your maximum number is: " + max);

            Console.Read();
        }
    }
}