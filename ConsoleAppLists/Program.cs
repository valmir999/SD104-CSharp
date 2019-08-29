using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleAppLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Mysets();
            Console.ReadLine();
        }
        static void Mysets()
        {
            HashSet<int> evenNumbers = new HashSet<int>();
            HashSet<int> oddNumbers = new HashSet<int>();
            for (int i = 0; i < 5; i++)
            {
                // Populate numbers with just even numbers.                
                evenNumbers.Add(i * 2);
                // Populate oddNumbers with just odd numbers.                
                oddNumbers.Add((i * 2) + 1);
            }
            Console.Write("evenNumbers contains {0} elements: ", evenNumbers.Count);
            DisplaySet(evenNumbers);
            Console.Write("oddNumbers contains {0} elements: ", oddNumbers.Count);
            DisplaySet(oddNumbers);
            // Create a new HashSet populated with even numbers.            
            HashSet<int> numbers = new HashSet<int>(evenNumbers);
            Console.WriteLine("numbers UnionWith oddNumbers...");
            numbers.UnionWith(oddNumbers);
            Console.Write("numbers contains {0} elements: ", numbers.Count);
            DisplaySet(numbers);
        }
        private static void DisplaySet(HashSet<int> set)
        {
            Console.Write("{");
            foreach (int i in set)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine(" }");
        }
        static void MyListandDict()
        {
            IDictionary<int, string> dictCourses = new Dictionary<int, string>();
            dictCourses.Add(101, "C#"); dictCourses.Add(102, "HTML5");
            dictCourses.Add(103, "Database");
            foreach (KeyValuePair<int, string> item in dictCourses)
            {
                Console.WriteLine("Key:{0},Value:{1}", item.Key, item.Value);
            }
            Console.ReadLine();
            //  List using custom type (class)            
            List<Students> myStudents = new List<Students>();
            Students objStudent = new Students();
            objStudent.FirstName = "John";
            objStudent.LastName = "Doe";
            objStudent.Enrolled = "Yes";
            myStudents.Add(objStudent);

            List<string> Courses = new List<string>();
            Courses.Add("HTML5");
            Courses.Add("Database");
            Courses.Add("JavaScript");
            Courses.Add("Web Development");
            Courses.Add("C#");
            if (Courses.IndexOf("C#") != -1)
            {
                // C# Class exist in our list , perform necessary operations            
            } // Unsorted List             

            Console.WriteLine("Print unsorted list");
            foreach (var item in Courses)
            {
                Console.WriteLine(item);
            } // Sort the list            

            Courses.Sort();

            Console.WriteLine("Print sorted list");
            foreach (var item in Courses)
            {
                Console.WriteLine(item);
            }
            Courses.RemoveAt(Courses.IndexOf("C#"));
            Courses.RemoveAt(0);
            Console.WriteLine(Courses.IndexOf("HTML5"));
            Console.ReadLine();
        }
    }
}

