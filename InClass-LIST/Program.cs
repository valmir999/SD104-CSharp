using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_LIST
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> dictCourses = new Dictionary<int, string>();

            dictCourses.Add(101, "C#");
            dictCourses.Add(102, "HTMLS");
            dictCourses.Add(103, "Database");

            foreach (KeyValuePair<int,string> item in dictCourses)
            {
                Console.WriteLine("Key:{0},value:{1}", item.Key, item.Value);
            }

            if (public bool ContainsValue(TValue value);)
            {

            }

            Console.ReadLine();

            // List using custom type (class)

            List<Students> myStudents = new List<Students>();

            Students objStudent = new Students();

            objStudent.FirstName = "John";
            objStudent.LastName = "John";
            objStudent.Enrolled = "Yes";

            myStudents.Add(objStudent);
        }
    }
}
