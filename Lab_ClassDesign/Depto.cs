using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_ClassDesign
{
    class Depto
    {
        public int id;
        public string deptoName;
        public string deptoAbbr;
        public string company;

        /// <summary>
        /// Constractors for Depto
        /// </summary>
        /// <param name="id">Depto ID</param>
        /// <param name="deptoName">Depto Name</param>
        /// <param name="deptoAbbr">Depto Abbreviation</param>
        public Depto(int id, string deptoName, string deptoAbbr, string company)
        {
            this.id = id;
            this.deptoName = deptoName;
            this.deptoAbbr = deptoAbbr;
            this.company = company;
        }

        public Depto(string deptoName, string deptoAbbr, string company)
        {
            this.deptoName = deptoName;
            this.deptoAbbr = deptoAbbr;
            this.company = company;
        }

        public Depto(string deptoName, string deptoAbbr)
        {
            this.deptoName = deptoName;
            this.deptoAbbr = deptoAbbr;
        }

        public Depto(int id, string company)
        {
            this.id = id;
            this.company = company;
        }

        public Depto(string deptoName)
        {
            this.deptoName = deptoName;
        }

        public Depto()
        {
        }

        /// <summary>
        /// Properties of Deptos
        /// Each property has the getter and setter 
        /// The get accessor returns the value of the private field, 
        /// and the set accessor may perform some data validation before assigning a value to the private field.
        /// </summary>
        public int dptID
        {
            get { return id; }
            set { id = value; }
        }

        public string dptname
        {
            get { return deptoName; }
            set
            {
                while (value == null || value == "")
                {
                    Console.Write("Enter department name: ");
                    value = Console.ReadLine();
                }

                deptoName = value;
            }
        }

        public string dptabbr
        {
            get { return deptoAbbr; }
            set
            {
                while (value == null || value == "")
                {
                    Console.Write("Enter department abbreviaton: ");
                    value = Console.ReadLine();
                }
                deptoAbbr = value;
            }
        }
        public string compName
        {
            get { return company; }
            set
            {
                while (value == null || value == "")
                {
                    Console.Write("Enter department company name: ");
                    value = Console.ReadLine();
                }
                company = value;
            }
        }
        public override string ToString()
        {
            return deptoAbbr + " - " + deptoName;
        }
    }
}


