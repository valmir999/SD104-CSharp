using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteFile
{
    class Employee
    {
        string firstName;
        string lastName;
        string dept;
        string val;

        public Employee(string firstName, string lastName, string dept)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dept = dept;

            if (string.IsNullOrEmpty(dept))
            {
                dept = "IT";
            }

//            Console.WriteLine("First Name: " + firstName + " Last Name: " + lastName + " Dept: " + dept);
        }

        public Employee(string firstName, string lastName, string dept, string value)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dept = dept;
            this.val = value;

            if (string.IsNullOrEmpty(dept))
            {
                dept = "IT";
            }

            //            Console.WriteLine("First Name: " + firstName + " Last Name: " + lastName + " Dept: " + dept);
        }


        public string Value
        {
            get
            {
                return val;
            }
            set
            {
                val = value;
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            //            return base.ToString();
         return "First Name: " + firstName + " Last Name: " + lastName + " Dept: " + dept;
        }
    }
}
