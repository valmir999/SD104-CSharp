using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            if (true || false)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("2");
            }

            int x = 0;
            int counter = 0;
            while (counter < 100)
            {
                Console.WriteLine(counter);
                counter += 5;
                x++;
            }
            Console.WriteLine(x);
            counter = 0;
            while (counter < 100)
            {
      //          Console.WriteLine(counter);
  //              Console.ReadLine();
                counter++;
            }

       //     int[] anArray = new int[10];
       //     int[] anotherArray = { 6, 7, 4, 5, 6, 2, 3, 5, 9, 1 };


    //        Console.WriteLine(anotherArray.Length);

       //    int[] num = new int[10];
       //     num[100] = 50;


        //    int[] anArray2 = new int[10];
        //    int[] anotherArray2 = { 6, 7, 4, 5, 6, 2, 3, 5, 9, 1 };

            int[] anArray = new int[10];
            int[] anotherArray = { 6, 7, 4, 5, 6, 2, 3, 5, 9, 1 };

            int total=0;

            for (int i = 0; i < anotherArray.Length; i++)
                total += i;


            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
