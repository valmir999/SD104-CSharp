using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_ClassDesign
{
    class Employee
    {
        public int id;
        public string firstName;
        public string lastName;
        public string company;
        public string depto;

        /// <summary>
        /// Constractors for Employee
        /// </summary>
        /// <param name="id">Employee ID</param>
        /// <param name="firstName">First Name</param>
        /// <param name="lastName">Last Name</param>
        /// <param name="company">Company Name</param>
        /// <param name="depto">Department Name</param>

        public Employee(int id, string company, string depto)
        {
            this.id = id;
            this.company = company;
            this.depto = depto;
        }

        public Employee(int id, string firstName, string lastName, string company, string depto)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.company = company;
            this.depto = depto;
        }

        public Employee(string firstName, string lastName, string company, string depto)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.company = company;
            this.depto = depto;
        }

        public Employee(string firstName, string lastName, string company)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.company = company;
        }

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Employee(string firstName)
        {
            this.firstName = firstName;
        }

        public Employee()
        {
        }

        /// <summary>
        /// Properties of employees
        /// Each property has the getter and setter 
        /// The get accessor returns the value of the private field, 
        /// and the set accessor may perform some data validation before assigning a value to the private field.
        /// </summary>
        public int eID
        {
            get { return id; }
            set { id = value; }
        }

        public string fname
        {
            get { return firstName; }
            set
            {
                while (value == null || value == "")
                {
                    Console.Write("Enter employee's first name: ");
                    value = Console.ReadLine();
                }

                firstName = value;
            }
        }

        public string lname
        {
            get { return lastName; }
            set
            {
                while (value == null || value == "")
                {
                    Console.Write("Enter employee's last name: ");
                    value = Console.ReadLine();
                }
                lastName = value;
            }
        }
        public string comp
        {
            get { return company; }
            set
            {
                while (value == null || value == "")
                {
                    Console.Write("Enter employee's company name: ");
                    value = Console.ReadLine();
                }
                company = value;
            }
        }
        public string dept
        {
            get { return depto; }
            set
            {
                while (value == null || value == "")
                {
                    Console.Write("Enter employee's department name: ");
                    value = Console.ReadLine();
                }
                depto = value;
            }
        }

        public override string ToString()
        {
            return id + " - " + firstName + " " + lastName;
        }
    }
}

