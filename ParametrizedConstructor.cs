using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace August8th2023_Practice
{

    class College
    {
        internal int marks1, marks2, marks3;
        internal double total, avg;
        internal string Sname,SID,Slocation;

        public College(int m1,int m2,int m3)
        {
            Console.WriteLine("I am Base Class Constructor");
            this.marks1 = m1;
            this.marks2 = m2;
            this.marks3 = m3;
            total = this.marks1+this.marks2+this.marks3;
            avg = total / 3;
            Console.WriteLine("Base Class Total and Avg is: " + total + "Base Class Avg is: " + avg);
        }
      
    }

    class Student: College
    {
        public int sub1, sub2, sub3;
        public Student(int s1,int s2,int s3):base(s1,s2,s3)
        {
            Console.WriteLine("I am Derived Class Constructor");
            this.sub1 = s1;
            this.sub2 = s2;
            this.sub3 = s3;
        }



    }
    class ParametrizedConstructor
    {

        static void Manin()
        {
            Console.WriteLine("I am Main Method");

            Student obj1 = new Student(34, 56, 78);

        }
    }
}
