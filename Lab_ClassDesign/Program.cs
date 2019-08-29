//Create three Classes
//Each class will have 3 or more properties
//Create the Getters/Setters
//Create the Constructor
//Create the ToString method
//In a separate module create several instances of each class


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_ClassDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            int cmpID = 0, i, cnt;
            string ans = "Y";

            Console.WriteLine("CREATING A NEW COMPANY");
            Console.WriteLine("----------------------");

            // CREATE NEW OBJECTS: Company, Depto and Employee  
            Company newCmp = new Company();
            Depto newDpt = new Depto();
            Employee newEmp = new Employee();

            // create array to hold display data
            string[,] deptos=new string[100,2];
            string[] employees=new string[100];

            //            do
            //            {
            Console.WriteLine("");
            Console.Write("Enter company name: ");
            newCmp.cmpnyname = Console.ReadLine();
            Console.Write("Enter company's address: ");
            newCmp.cmpnyaddr = Console.ReadLine();

            cmpID++;
            newCmp.cmpnyID = cmpID;

            Console.WriteLine("");
            Console.Write("The new company is ID# " + $"{newCmp.cmpnyID} - " + newCmp);
            Console.WriteLine("");
            Console.WriteLine("");

            //                Console.Write("Do you want to input another company (Type 'Y' or any key to exit): ");
            //            } while (Console.ReadLine().ToUpper() == "Y");

            int dptID = 0;

            Console.WriteLine("CREATING A NEW DEPARTMENT FOR " + $"{newCmp.cmpnyname}");
            Console.WriteLine("-----------------------------------------------------------");
            do
            {
                Console.WriteLine("");
                Console.Write("Enter department name: ");
                newDpt.deptoName = Console.ReadLine();
                Console.Write("Enter department abbreviation: ");
                newDpt.deptoAbbr = Console.ReadLine();
                Console.Write("Enter department's company name: ");
                newDpt.compName = newCmp.cmpnyname;

                cnt = dptID;
                dptID++;
                newDpt.dptID = dptID;

                Console.WriteLine("");
                Console.Write(newDpt + " is the new department at " + newCmp);
                Console.WriteLine("");
                Console.WriteLine("");

                deptos[cnt, 0] = newDpt.deptoAbbr;
                deptos[cnt,1]=newDpt.deptoName ;

                ans = GetInput("Do you want to input another department (Type 'Y' or any key to exit): ");
            } while (ans.ToUpper() == "Y");

            Console.WriteLine("");
            Console.WriteLine("Departments list");
            Console.WriteLine("----------------");
            Console.WriteLine("");
            Console.WriteLine("Abbr - Name");

            for (i = 0; i <= cnt; i++)
            {
                    Console.WriteLine(deptos[i,0] + "   - " + deptos[i,1]);
            }

            Console.WriteLine("");

            int empID = 0;

            Console.WriteLine("NEW EMPLOYEE REGISTRATION");
            Console.WriteLine("-------------------------");
            do
            {
                Console.WriteLine("");

                do
                {
                    ans = GetInput("Please enter the department for the new employees: ");
                } while (!foundAns(deptos, ans, cnt));

                empID++;
                Console.WriteLine("");
                Console.Write("Enter employee's first name: ");
                newEmp.fname = Console.ReadLine();
                Console.Write("Enter employee's last name: ");
                newEmp.lname = Console.ReadLine();
                newEmp.comp = newCmp.cmpnyname;
                newEmp.dept = newDpt.deptoName;

                newEmp.eID = empID;
                string dptName = locateDepto(deptos, ans, cnt);
                Console.WriteLine("");
                Console.Write(newEmp.ToString() + " is the new employee of " +
                              newCmp + " at the " + dptName + " department.");
                Console.WriteLine("");  
                Console.WriteLine("");

                Console.Write("Do you want to input another employee (Type 'Y' or any key to exit): ");
            } while (Console.ReadLine().ToUpper() == "Y");
        }

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string str = Console.ReadLine();
            return str;
        }
        public static bool foundAns(string[,] dp, string answer, int idx)
        {
            bool found = false;
            while (!found)
            {
                for (int i = 0; i <= idx; i++)
                {
                    if (dp[i,0] == answer)
                    {
                        found = true;
                        break;
                    } 
                }
                break;
            }
            return found;
        }

        public static String locateDepto(string[,] dp, string abb, int idx)
        {
            bool found = false;
            string retDepto = "Department not found";

            while (!found)
            {
                for (int i = 0; i <= idx; i++)
                {
                    if (dp[i, 0] == abb)
                    {
                        retDepto = dp[i, 1];
                        found = true;
                        break;
                    }
                }
                break;
            }
            return retDepto;
        }
    }
}
