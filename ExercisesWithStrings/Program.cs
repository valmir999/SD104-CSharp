using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ExercisesWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declarations
            int counter = 0;
            string line;
            string[] arrayAmendments = new string[10];

            // Convert the 10 amendments into a string array - Note: The amendments are stored in a Text File (amendaments.txt)
            FileStream myFileStream = new FileStream("C:\\Projects\\SD104-CSharp\\ExercisesWithStrings\\amendaments.txt", FileMode.Open, FileAccess.Read);
            StreamReader myFileReader = new StreamReader(myFileStream);
            while ((line = myFileReader.ReadLine()) != null)
            {
                arrayAmendments[counter] = line;
                counter++;
            }

            // loop through the array and print each amendment
            counter = 1;
            foreach (string amendment in arrayAmendments)
            {
                Console.WriteLine("Amendment " + counter + ": " + amendment);
                Console.WriteLine(""); // write a line between each amendment
                counter++;
            }

            myFileReader.Close();
            Console.ReadLine();

            // find the amendment that contains the word 'controversy'
            int i;
            for (i = 0; i < arrayAmendments.Length; i++)
            {
                if (arrayAmendments[i].Contains("controversy"))
                {
                    Console.WriteLine("Amendment " + (i + 1) + " contains the word 'controversy'.");
                    Console.WriteLine("");
                }
            }
            Console.ReadLine();

            // what is the longest amendment?
            int longestAmendment = 0, getNewLenth, holdLongest = 0;
            for (i = 0; i < arrayAmendments.Length; i++)
            {
                getNewLenth = arrayAmendments[i].Length;
                if (longestAmendment < getNewLenth)
                {
                    holdLongest = (i + 1);
                    longestAmendment = getNewLenth;
                }
            }
            Console.WriteLine("Amendment " + holdLongest + " is the longest, it holds a total length of " + longestAmendment + ".");
            counter++;
            Console.ReadLine();
        }
    }
}
