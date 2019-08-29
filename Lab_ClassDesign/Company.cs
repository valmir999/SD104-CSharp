using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_ClassDesign
{
    class Company
    {
        public int id;
        public string companyName;
        public string companyAddr;

        /// <summary>
        /// Constractors for Company
        /// </summary>
        /// <param name="id">Company ID</param>
        /// <param name="companyName">Company Name</param>
        /// <param name="companyAddr">Company Address</param>
        public Company(int id, string companyName, string companyAddr)
        {
            this.id = id;
            this.companyName = companyName;
            this.companyAddr = companyAddr;
        }

        public Company(string companyName, string companyAddr)
        {
            this.companyName = companyName;
            this.companyAddr = companyAddr;
        }

        public Company(string companyName)
        {
            this.companyName = companyName;
        }

        public Company()
        {
        }

        /// <summary>
        /// Properties of Companies
        /// Each property has the getter and setter 
        /// The get accessor returns the value of the private field, 
        /// and the set accessor may perform some data validation before assigning a value to the private field.
        /// </summary>
        public int cmpnyID
        {
            get { return id; }
            set { id = value; }
        }

        public string cmpnyname
        {
            get { return companyName; }
            set
            {
                while (value == null || value == "")
                {
                    Console.Write("Enter company name: ");
                    value = Console.ReadLine();
                }

                companyName = value;
            }
        }

        public string cmpnyaddr
        {
            get { return companyAddr; }
            set
            {
                while (value == null || value == "")
                {
                    Console.Write("Enter company address: ");
                    value = Console.ReadLine();
                }
                companyAddr = value;
            }
        }

        
        public override string ToString()
        {
            return companyName;
        }
    }
}

