using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Example_VS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            FiveCardDraw fiveCardDraw = new FiveCardDraw();
            fiveCardDraw.PlayRound();

            Console.ReadLine();

        }
    }
}
