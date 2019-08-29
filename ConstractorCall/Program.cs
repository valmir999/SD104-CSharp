using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConstractorCall
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;

            //Stream myStream;

            // myStream = null;

            // StreamReader myReader = new StreamReader(myStream);

            FileStream myFileStream = new FileStream("C:\\Projects\\SD104-CSharp\\TextFile.txt", FileMode.Open, FileAccess.Read);

            StreamReader myFileReader = new StreamReader(myFileStream);

            //            Console.WriteLine(myFileReader.ReadLine());

            Console.WriteLine(myFileReader.ReadToEnd());
            Console.WriteLine("");
            Console.ReadLine();


 //           while ((line = myFileReader.ReadLine()) != null)
 //           {
 //               Console.WriteLine(line);
 //               counter++;
 //           }

            myFileReader.Close();
            Console.ReadLine();

        }
    }
}
