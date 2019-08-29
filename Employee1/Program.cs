using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee();
            myEmployee.FirstName = "Joe";
            myEmployee.LastName = "Miller";
            myEmployee.Dept = "HR";

            AssignDept(myEmployee);
            myEmployee.SetNames();

            Console.WriteLine(myEmployee.Dept);

            Console.ReadLine();

        }
 
        static void AssignDept(Employee emp)
        {
            if (string.IsNullOrEmpty(emp.Dept))
            {
                emp.Dept = "Sales";
            }

        }

        class Employee
        {
            public string FirstName;
            public string LastName;
            public string Dept;


            public void SetNames()
            {

            }

        }
    }
}
