using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myemployee = new Employee("John", "Doe", "");
            Console.WriteLine(myemployee.ToString());
            myemployee.Value = "John" + "Doe" + "HR" + "JOHN DOE";
            Console.ReadLine();

        }

        private static void WriteFile(string fileName)
        {
            // Read the file and display it line by line. 
            StreamWriter file = new StreamWriter(@"..\..\" + fileName);

            while (true)
            {
                string line = Console.ReadLine();
                if (line.Length == 0)
                    break;
                file.WriteLine(line);
            }
            file.Close();
        }

        private static void WriteFileTry(string fileName)
        {
            try
            {
//                fileName = "../../" + fileName;
                FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
//                FileStream textOut = new StreamWriter(stream);
//                for (int i = 0; i < screenText.Length; i++)
//                {
//                    textOut.WriteLine(screenText[i]);
//                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Creating file: ");
                Console.WriteLine(ex.ToString());
                return;
            }
            finally
            {
//                if (textOut != null)
//                    textOut.Close();
            }
        }

        private static void WriteFileNewTry(string fileName)
        {
            try
            {
                //using block automatically disposes stream after use.
                using (StreamReader textfile1 = new StreamReader(fileName))
                {
                    Console.Write(textfile1.ReadLine());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The following exception occured: " + ex.ToString());
            }
            finally
            {
                //do some more stuff regardless of whether an exception was thrown.
//                textfile1.Close();
            }
        }
    }
}


