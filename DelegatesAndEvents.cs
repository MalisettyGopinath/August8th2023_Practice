using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace August8th2023_Practice
{
    internal class DelegatesAndEvents
    {
        /*
        // Delegates operations==========================

        private delegate void myDelegeate();
        private void Show()
        {
            Console.WriteLine("I am Show Method");
        }

        private static void Display()
        {
            Console.WriteLine("I am Display Method");
        }

        private static void Print()
        {
            Console.WriteLine("I am print Method");
        }
        static void Main()
        {
            //Create Object for instance Method

            DelegatesAndEvents obinst = new DelegatesAndEvents();
            obinst.Show();
            // Create objectfor the Delegate

            myDelegeate obj1 = new myDelegeate(Display);
            obj1 = obj1 + new myDelegeate(Print);
            obj1(); // invoke Delegate by using object refernce()


        }
        */
        /*
       public delegate void myDelegate(int subj1,int subj2);

       //Create event name

       public static event myDelegate myevent1;
       public static event myDelegate myevent2;

       public static void Sum(int subj1,int subj2)
       {
           Console.WriteLine("Sum of two numbers are: " + (subj1 + subj2));
       }

       public static void Subtract(int subj1, int subj2)
       {
           Console.WriteLine("Subtraction of two numbers are: " + (subj1 - subj2));
       }

       public static void Multiplication(int subj1, int subj2)
       {
           Console.WriteLine("Multiplication of two numbers are: " + (subj1 * subj2));
       }

       public static void Divison(int subj1, int subj2)
       {
           Console.WriteLine("Division of two numbers are: " + (subj1 / subj2));
       }


       static void Main()
       {
       
           myDelegate obj1 = new myDelegate(Sum);
           obj1=obj1+new myDelegate(Subtract);
           obj1 = obj1 + new myDelegate(Multiplication);
           obj1 = obj1 + new myDelegate(Divison);
           obj1(45, 45);

          
        myevent1 = new myDelegate(Sum);
            myevent2 = new myDelegate(Subtract);
            myevent1(45,45);
            myevent2(70,56);


        }

         */

        //Create Delegates and Evnets

        public delegate void myDelegate(string fname, string lname, string midname);

        public static event myDelegate event1;
        public static event myDelegate event2;
        public static event myDelegate event3;

        public static void collegeName(string fname,string midname,string lname)
        {
            Console.WriteLine("Collge Full Name is: " + fname + " " + midname + " " + lname);

        }

        public static void SchoolName(string fname, string midname, string lname)
        {
            Console.WriteLine("School Full Name is: " + fname + " " + midname + " " + lname);

        }

        public static void houseName(string fname, string midname, string lname)
        {
            Console.WriteLine("House Full Name is: " + fname + " " + midname + " " + lname);

        }


        static void Main()
        {

            event1 = new myDelegate(collegeName);
            event2=new myDelegate(houseName);
            event3= new myDelegate(SchoolName);

            event1("v", "R", "EC");
            event2("Royal", "Street", "Palace");
            event3("Raju", "Andhra", "Addda");
           
        }


    }
    }
