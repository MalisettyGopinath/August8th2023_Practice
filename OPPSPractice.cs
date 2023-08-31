using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace August8th2023_Practice
{
    class OPPSPractice
    {

        // Student Collage Name and Address
        const string CollageName="VREC", CollegeAddress="NZB", CollegeCode="5672";
        string Sname, Saddress, Sresult;
        int StudentID, M1,M2,M3;
        double stotal, savg;

       public OPPSPractice(string name,string address,int ID,int m1,int m2,int m3)
        {
            this.Sname = name;
            this.Saddress = address;
            this.StudentID = ID;
            this.M1 = m1;
            this.M2 = m2;
            this.M3 = m3;
        }
        private static void CollgeDetails()
        {
           
            Console.WriteLine("Collge Details are===================================:  ");
            Console.WriteLine("Collage Name: " + CollageName);
            Console.WriteLine("Collge Address: "+CollegeAddress);
            Console.WriteLine("Collge Address: " + CollegeCode);
        }

        private void StudentMarks()
        {
            stotal = this.M1 + this.M2 + this.M3;
            savg = Math.Round(stotal / 3,3);
            if (this.M1 >= 35 && this.M2 >= 35 && this.M3 >= 35)
            {
                Sresult = "PASS";
            }
            else
            {
                Sresult = "FAILED";
            }
            Console.WriteLine("Student Marks are===================================:  ");
            Console.WriteLine("Student Subject1 Marks: " + this.M1);
            Console.WriteLine("Student Subject2 Marks: " + this.M2);
            Console.WriteLine("Student Subject3 Marks: " + this.M3);
            Console.WriteLine("Student Total is: " + stotal);
            Console.WriteLine("Student Average is: " + savg);

        }



        private void StudentFinalResult()
        {
            Console.WriteLine("Student Final Result Details===================================:  ");
            Console.WriteLine("Student Overall Result is: " + Sresult); 

        }


        private void StudentDetails()
        {
            Console.WriteLine("Student Details are===================================:  ");
            Console.WriteLine("Student Name: " + this.Sname);
            Console.WriteLine("Student ID: " + this.StudentID);
            Console.WriteLine("Student Address: " + this.Saddress);
        }

        static void Main()
        {
            Console.WriteLine("Hello I am Main() ");
            OPPSPractice Obj1 = new OPPSPractice("Gopinath","HYD",13563,35,67,70);
            OPPSPractice.CollgeDetails();  // Static Method always call by class name only.
            Obj1.StudentDetails();
            Obj1.StudentMarks();
            Obj1.StudentFinalResult();

            OPPSPractice Obj2 = new OPPSPractice("Jhansi Lakshmi", "Chennai", 16475, 90, 90, 100);
            OPPSPractice.CollgeDetails();
            Obj2.StudentDetails();
            Obj2.StudentMarks();
            Obj2.StudentFinalResult();


            OPPSPractice Obj3 = new OPPSPractice("Chasvika Rai", "Banaglore", 1273834, 100, 70, 60);
            OPPSPractice.CollgeDetails();
            Obj3.StudentDetails();
            Obj3.StudentMarks();
            Obj3.StudentFinalResult();
          



        }

      





    }
}
