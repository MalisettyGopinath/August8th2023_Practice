using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August8th2023_Practice
{
    internal class Polymorphism
    {
        // Method Overloading ===============
        double result;
        private void Sum()
        {

            Console.WriteLine("Sum Method Intial Excution Process==========");

        }

        private void Sum(int sub1,int sub2)
        {


           result= sub1 + sub2;

            Console.WriteLine("Sum of Two Numbers : " + result);


        }


        private void Sum(int sub1, int sub2, int sub3)
        {


            result = sub1 + sub2 + sub3;

            Console.WriteLine("Sum of Three Numbers : " + result);


        }


        private string Sum(string fname,string lname)
        {


            string concatResult = fname+" "+lname;

            Console.WriteLine("You are Full Name Is : " + concatResult);

            return concatResult;


        }


        private static string Sum(string efname, string elname,string mname)
        {


            string concatResult = efname +" "+mname +" " + elname;

            Console.WriteLine("You are Static Method Full Name Is : " + concatResult);

            return concatResult;


        }

        static void Main()
        {


            Polymorphism obj1 = new Polymorphism();

            obj1.Sum();
            Console.WriteLine("Calling Second Method with two inputs Parameters: ======================");

            obj1.Sum(40,40);
            Console.WriteLine("Calling Second Method with three inputs Parameters: ======================");


            obj1.Sum(35,35,35);
            Console.WriteLine("Calling Second Method with two string inputs Parameters: ======================");



            obj1.Sum("Gopinath","Malisetty");
            Console.WriteLine("Calling Second Method with three static inputs Parameters: ======================");

            Polymorphism.Sum("Gopinath", "Malisetty","Royal");



        }
    }
}
