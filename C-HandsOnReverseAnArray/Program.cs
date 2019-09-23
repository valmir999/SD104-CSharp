//Create a method ReverseArray
//It will have one parameter: an string array
//It will move the string at[0] to the last position and the last position will be copied to[0]. 
//Then the string at[1] will be copied to the next to last position 
//and the next to last position will be copied to position[1].
//and so on and so on
//It will return the array.
//Create several string arrays to test your code:
//for instance:
//string[] arrayX = {"AAAAA", "BBBB", "CCC", "DD", "E" };
//string[] arrayY = { "Texas", "New York", "Washington", "Nevada" };


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace C_HandsOnReverseAnArray
{
    class ArrayExample
    {
        static void Main()
        {
            // Declare and initialize an array.
            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            string[] arrayX = { "AAAAA", "BBBB", "CCC", "DD", "E" };
            string[] arrayY = { "Texas", "New York", "Washington", "Nevada" };
            string[] arrayPeople = { "Nancy", "John", "Kristy", "Washington", "Diana", "William", "Jully", "Liza", "David" };

            DisplayHeader();

            Console.WriteLine("Original Arrays:");
            Console.WriteLine("----------------");
            Console.Write("1) - "); DisplayArray(weekDays);
            Console.Write("2) - "); DisplayArray(arrayX);
            Console.Write("3) - "); DisplayArray(arrayY);
            Console.Write("4) - "); DisplayArray(arrayPeople);

            weekDays = ReverseArray(weekDays);
            arrayX = ReverseArray(arrayX);
            arrayY = ReverseArray(arrayY);
            arrayPeople = ReverseArray(arrayPeople);

            Console.WriteLine("");
            Console.WriteLine("Reversed Arrays:");
            Console.WriteLine("----------------");
            Console.Write("1) - "); DisplayArray(weekDays);
            Console.Write("2) - "); DisplayArray(arrayX);
            Console.Write("3) - "); DisplayArray(arrayY);
            Console.Write("4) - "); DisplayArray(arrayPeople);

            Console.WriteLine();
            Console.WriteLine("Hit any key to exit...");
            Console.ReadLine();
        }


        static public void DisplayHeader()
        {
            Console.WriteLine("         Hands on - Reverse an Array Program");
            Console.WriteLine("         -----------------------------------");
            Console.WriteLine();
        }


        //method to reverse string arrays
        static public string[] ReverseArray(string[] paramArr)
        {
            string[] tmpArr = new string[paramArr.Length];
            string[] cpyArr = new string[paramArr.Length];
            int cnt, cntBack;
            for (cnt = 0; cnt < paramArr.Length; cnt++)
            {
                cpyArr[cnt] = "";
            }
            cntBack = paramArr.Length - 1;
            for (cnt = 0; cnt < paramArr.Length; cnt++)
            {
                cpyArr[cnt] = paramArr[cntBack];
                cpyArr[cntBack] = paramArr[cnt];
                cntBack--;
            }
            return cpyArr;
        }

        // display array elements.
        static void DisplayArray(string[] arr) => Console.WriteLine(string.Join(", ", arr));
    }
}
