using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            int empId = 0;
            Employee NewEmp = new Employee();

            do
            {
                Console.WriteLine("");

                empId++; 
                NewEmp.id = empId; // creating a new employee
                NewEmp.registered = true;

                Console.Write("Type employee's first name: ");
                NewEmp.firstName = Console.ReadLine();
                Console.Write("Type employee's last name: ");
                NewEmp.lastName = Console.ReadLine();
                Console.Write("Type employee's email name: ");
                NewEmp.email = Console.ReadLine();
                Console.Write("Type employee's department name: ");
                NewEmp.department = Console.ReadLine();

                NewEmp.DisplayData();

            } while (RegisterEmployee("Would you like to register an employee? Type Y for Yes or any other key to quit... "));
        }

        public class Employee
        {
            public int id;
            public string firstName;
            public string lastName;
            public string email;
            public string department;
            public bool registered;

            public void InsertDate(int ID, string FirstName, string LastName, string Email, string Department)
            {
                id = ID;
                firstName = FirstName;
                lastName = LastName;
                email = Email;
                department = Department;
                registered = true;
            }

            public void DisplayData()
            {
                Console.WriteLine("Employee id: " + id);
                Console.WriteLine("Employee First Name: " + firstName);
                Console.WriteLine("Employee Last: " + lastName);
                Console.WriteLine("Employee Email: " + email);
                Console.WriteLine("Employee Department: " + department);
            }
        }

        private static bool RegisterEmployee (string UserPrompt)
        {
            bool registerAnother = false;

            // ask user for a number
            Console.WriteLine("");
            Console.Write(UserPrompt);

            if (Console.ReadLine().ToUpper() == "Y")
            {
                registerAnother = true;
            }
            return registerAnother;
        }
    }
}
