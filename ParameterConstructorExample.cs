using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August8th2023_Practice
{
    class College1
    {
        internal int marks1, marks2, marks3;
        internal double total, avg;
        internal string Sname, SID, Slocation;


        public College1(int m1)
        {
            Console.WriteLine("I am Base Class Constructor");
            this.marks1 = m1;
            Console.WriteLine("Base Class m1 value is: " + this.marks1);
        }
        public College1(int m1, int m2):this(m1)
        {
            Console.WriteLine("I am Base Class Constructor");
            this.marks1 = m1;
            this.marks2 = m2;
            Console.WriteLine("Base Class m1 value is: " + this.marks1+" Base Class m2 value is: "+this.marks2);
        }

        public College1(int m1, int m2, int m3):this(m1,m2)
        {
            Console.WriteLine("I am Base Class Constructor");
            this.marks1 = m1;
            this.marks2 = m2;
            this.marks3 = m3;
            total = this.marks1 + this.marks2 + this.marks3;
            avg = Math.Round(total / 3,2);
            Console.WriteLine("Base Class Total and Avg is: " + total + " Base Class Avg is: " + avg);
        }

    }

    class Student1 : College1
    {
        int sub1, sub2, sub3;

       
        public Student1(int s1, int s2, int s3) : base(s1, s2, s3)
        {
            Console.WriteLine("I am Derived Class Constructor");
            this.sub1 = s1;
            this.sub2 = s2;
            this.sub3 = s3;
            Console.WriteLine("Dervied Class Marks are: " +" Subject1: "+ this.sub1 +" Subject2: "+this.sub2+" Subject3: "+this.sub3);
        }
          
        /*
     public Student1() : base(45,56,78)
     {
         Console.WriteLine("I am Derived Class Constructor");
     }

      */
        internal void DisplayMethod()
        {
            Console.WriteLine("===================================================================");
            Console.WriteLine("Hello Happy Coding Malisetty Gopinath");
        }



    }

    internal class ParameterConstructorExample
    {

        static void Main()
        {

            Student1 sobj1 = new Student1(50,50,50);
            sobj1.DisplayMethod();


        }
    }
}
