using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace August8th2023_Practice
{

    // Struct Operation===============================

    public struct EmployeeInfo
        {

        public int width, hieght;

        }

    //Enumeration Information
    enum level
    {

        Low,
        Medium,
        High


    }

    enum Days
    {

        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday


    }

    enum Year
    {
        January=1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,   
        September,
        October,
        November,
        December


    }

    internal class StructAndEnum
    {
     
        static void Main()
        {

            EmployeeInfo obj1 = new EmployeeInfo();
            obj1.width = 23;
            obj1.hieght = 10;
            Console.WriteLine("Are of ReactAngle is: " + (obj1.width * obj1.hieght));
            obj1.width = 13;
            obj1.hieght = 5;
            Console.WriteLine("Are of ReactAngle is: " + (obj1.width * obj1.hieght));

            Console.WriteLine("Enumration Operations============================== ");

            level lvl = level.Low;
            level mvl = level.Medium;
            level hvl = level.High;
            Days d1 = Days.Tuesday;
            Days d2 = Days.Wednesday;



            Console.WriteLine("Level Deatisl Low Level: "+lvl);
            Console.WriteLine("Level Deatisl Medium Level: " + mvl);
            Console.WriteLine("Level Deatisl High Level: " + hvl);

            Console.WriteLine("Days are D1 is: " + d1);
            Console.WriteLine("Days are D2 is: " + d2);
            Console.WriteLine("Days are D3 is: " + (int)Days.Wednesday);



            Console.WriteLine("Enumration Swithc Case Operations============================== ");

            switch (mvl)
            {
                case level.Low:
                    Console.WriteLine("Hello This is Low level Process");
                    break;
                case level.Medium:
                    Console.WriteLine("Hello This is Medium level Process");
                    break;
                case level.High:
                    Console.WriteLine("Hello This is High level Process");
                    break;

                default:
                    Console.WriteLine("Hello This is not belongs to any level Process");
                    break;



            }
                

        }
    }
}
