using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August8th2023_Practice
{

    class EmployeeAttendance
    {
        private const string empname = "Rajesh";
        private string fname, lname,empid;

        public string empdata;


        public string Name
        {
            get; set; // Automatic Properies or POCO method or low code
            
        }


        public string Empdata
        {
            get
            {
                return empdata;
            }

            set
            {
                empdata = value;
            }
        }

        public string EmpName
        {
            get
            {
                return empname;
            }
           
        }

        public string Empid
        {
            get
            {
                return empid;
            }

            set
            {
                empid = value;
            }
        }

        //Properties
        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }


        }

        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }


    }
    internal class PropertiesOperatiosn
    {

        static void Main()
        {

            EmployeeAttendance obj1 = new EmployeeAttendance();
            obj1.Fname = "Gopinath"; //set value into prperty
            obj1.Empid = "AGSHD123455667";
            string username = obj1.Fname;
            string ID = obj1.Empid;
            obj1.Name = "Royals";
            string ltname=obj1.Name;
            Console.WriteLine("Set Value Property: "+username);
            Console.WriteLine("Emp ID Set Value property from Employee Class: " + obj1.Empid);
            Console.WriteLine("Emp name  Set Value property from Employee Class: " + obj1.Name);
            Console.WriteLine("Get Property from Employee Class: "+obj1.Fname);
            Console.WriteLine("Get Name Property from Employee Class: " + ltname);
            Console.WriteLine("Constant Get Property from Employee Class: " + obj1.EmpName);

        }
    }
}
