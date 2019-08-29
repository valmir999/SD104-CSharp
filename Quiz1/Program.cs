using System;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // int ans = 5, v1 = 2, v2 = 10, v3 = 18;
            // ans += v1 + 10 * (v2-- / 5) + v3 / v2;

            //Console.WriteLine(ans);

            int answer = 200;

            answer -= 100;
            Console.WriteLine(answer);

            float amountDue = 0f;
            Console.WriteLine(amountDue);

            sbyte a = -1;
            //          uint b = -1;
            int c = -1;
            long d = -1;

            Console.WriteLine(a);
            //          Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            int ans = 5 * 10 % 7;
            Console.WriteLine(ans);

            switch (ans == 7)
            {
                default:
                    break;
            }


            //      int sum = 0;
            //      int number = 0;
            //      while (number < 10)
            //      {
            //          sum = sum + number;
            //           Console.WriteLine(sum);
            //      }


            ///            int loopVariable = 0;
            //           do
            //           {
            //               Console.WriteLine("Count = { 0:}",  ++loopVariable);
            //               Console.ReadLine();
            //           } while (loopVariable < 5);

            int integerValue;

            try
            {
                if (int.TryParse(Console.ReadLine(), out integerValue) == false)
                    Console.WriteLine("Invalid input - 0 recorded for end value");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }


            //          int sum = 0;
            //           int number = 1;
            //            while (number < 100)
            //          {
            //              sum = sum + number;
            //          }
            //
            for (int outer = 0; outer < 2; outer++)
            {
                for (int inner = 0; inner < 3; inner++)
                {
                    Console.WriteLine("Outer: {0}\tInner: {1}", outer, inner);
                }
            }

            int[] anArray = new int[10];
            int[] anotherArray = { 6, 7, 4, 5, 6, 2, 3, 5, 9, 1 };
            int total=0;

            for (int i = 0; i < anotherArray.Length; i++)
            {
                total += i;
            }
            Console.WriteLine(total);

            //Using the above declaration along with the for loop, what is stored in total after the program statements are executed?


            Console.ReadLine();
        }


        //      void DisplayOutput(double anArray [10])
        //       {
        //      }

        void DisplayOutput(double[] anArray)
        {
        }

        void DisplayOutput(double anArray)
        {
        }

        //       void DisplayOutput(double[10] anArray)
        //       {

        //       }

        //  string myArray = new string[];

    }
}
