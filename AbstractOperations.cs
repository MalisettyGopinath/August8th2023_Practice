using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August8th2023_Practice
{

    // Abstract Method Operations==========================

    abstract class CGDetailsList
    {
        public string ename, eid;
        public static string ecode;
        public static void Display()
        {
            Console.WriteLine("Hello I am Static Method in Abstarct Class: ");

        }

        public void DoctorList()
        {
            Console.WriteLine("Hello I am Instance Method in Abstarct Class");
        }

        // Abstract Method Declaration==================

        public abstract void EmployeeList();
        
      
    }

    class EmpData:CGDetailsList
    {

        public override void EmployeeList()
        {
            Console.WriteLine("Hello Abtsract Method Implemented in Derived Class");
        }
        public void CabelData()
        {
            Console.WriteLine("Hello Cable Data List is Ready: ");
        }

    }
    internal class AbstractOperations
    {

        static void Main()
        {

            EmpData obj1 = new EmpData();
            obj1.ename = "Gopinath";
            obj1.eid = "AAHS3564";
            CGDetailsList.ecode = "ASH0983";
            Console.WriteLine("Employee Name in Abstarct Class: "+obj1.ename);
            Console.WriteLine("Employee Name in Abstarct Class: " + obj1.eid);
            Console.WriteLine("Employee Name in Abstarct Class: " + CGDetailsList.ecode); // Calling Static Variables by Class
            Console.WriteLine("Methods Excution Started Here============================");
            CGDetailsList.Display();
            obj1.DoctorList();
            obj1.EmployeeList();
            obj1.CabelData();

        }
    }
}
