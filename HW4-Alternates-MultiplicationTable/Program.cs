using System;

namespace HW4_Alternates_MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarations
            int nUser = 12;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("MULTIPLICATION TABLE - DEFAULT: 12 X 12 TABLE");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("");

            // ask user for a number
            do
            {
                do
                {
                Console.Write("Enter a number between 1 and 12 to build a multiplication table ('0' defaults to 12): ");
                } while (!Int32.TryParse(Console.ReadLine(), out nUser));
            } while (!ValidInputNumber(nUser));

            if (nUser == 0) { nUser = 12; } // user entered ZERO --> default is Multi by 12
            displayTable(nUser);
            Console.WriteLine();
            Console.Write("Hit any key to exit...");
            Console.ReadLine();
        }

        static public bool ValidInputNumber(int num)
        {
            bool isValidNum = false;
            if (num >= 0 && num <= 12) { isValidNum = true; }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("---> WARNING: " + num + " is an invalid number for this operation.");
            }
            return isValidNum;
        }

        static public void displayTable(int num)
        {
            string[] xArray = new string[num+1]; // array for colunm x
            string[] yArray = new string[num]; // array for row y

            //populate array line x
            String columns = String.Format("{0,4}", "X");
            xArray[0] = "X";
            for (int i = 1; i < xArray.Length; i++)
            {
                xArray[i] = i.ToString();
                columns += String.Format("{0,4}", xArray[i]);
            }

            //populate array line y
            yArray = xArray;

            Console.WriteLine($"\n{columns}");

            String rows;
            for (int r = 1; r <= num; r++) // looping through each row
            {
                rows = "";
                for (int c = 0; c <= num; c++) // building each column
                {
                    if (c == 0) { yArray[c] = r.ToString(); }
                    else { yArray[c] = (r * c).ToString(); }
                    rows += String.Format("{0,4}", yArray[c]);
                }
                Console.WriteLine($"{rows}");
            }
        }
    }
}
