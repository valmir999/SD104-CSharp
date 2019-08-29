//C# HW 3 - Working With StreamReader
//Due Sunday by 11:59pm Points 10  Submitting a text entry box or a file upload
//C# HW 3 - Working With StreamReader
// For your HW assignment, you will gain more experience working with the StreamReader 
//and FileStream objects.A menu-driven program has been started for you 
//that has options to read the contents of a file and write lines to a file.
//You will be completing the methods that perform these two actions.
//Pull the following project from GitHub https://github.com/JasonMonroe-EdgeTech/SD-104-Files-IO.git 
//(Links to an external site.).  You can open a new pull request by clicking on the Pull Requests button on the home screen in Team Explorer.

//Finish the ViewNames function as described in the comments.
//The finished product should allow you to add and read names to the file.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_WorkingWithStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declarations
            string strChoice = "";

            //menu loop
            while (strChoice != "3")
            {
                //main menu
                Console.WriteLine("-------Main Menu--------");
                Console.WriteLine("1.\tAdd Names to a File");
                Console.WriteLine("2.\tView Names in a File");
                Console.WriteLine("3.\tExit");
                strChoice = Console.ReadLine();


                //process choice
                switch (strChoice)
                {
                    case "1":
                        AddNames();
                        break;
                    case "2":
                        ViewNames();
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine(strChoice + " is not a valid choice.");
                        break;
                }
            }

        }//end Main()


        static void AddNames()
        {
            //Instantiate a FileStream that will open a file named "names.txt", 
            FileStream stream1 = new FileStream("names.txt", FileMode.Append, FileAccess.Write);
            StreamWriter textFile1 = new StreamWriter(stream1);

            Console.WriteLine("Enter a name or type -99 to quit:");
            string userInput = Console.ReadLine();

            //input loop
            while (userInput != "-99")
            {
                textFile1.WriteLine(userInput);
                Console.WriteLine("Enter a name or type -99 to quit:");
                userInput = Console.ReadLine();
            }

            textFile1.Close();

        }//end AddNames()

        //Finish the ViewNames function as described in the comments.
        //The finished product should allow you to add and read names to the file.

        static void ViewNames()
        {
            int counter = 0;
            string line;

            //instantiate a FileStream Object to open "names.txt" with FileMode.Open and FileAccess.Read
            FileStream myFileStream = new FileStream("names.txt", FileMode.Open, FileAccess.Read);

            //instantiate a StreamReader Object and pass to it the FileStream Object you created
            StreamReader myFileReader = new StreamReader(myFileStream);

            //read file in loop while the reader is not at the EndOfStream and display the lines of text
            //            Console.WriteLine(myFileReader.ReadToEnd());

            while ((line = myFileReader.ReadLine()) != null)
            {
                counter++;
                Console.WriteLine(counter + ". " + line);
            }

            Console.WriteLine("");

            //Close the file
            myFileReader.Close();

        }//end ViewNames()
    }


}

