using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August8th2023_Practice
{

    internal class BaseCalss
    {
        internal string sname, sid, saddress;
        internal int m1=56, m2=76, m3=90;
        const string location = "HYD", pincode = "516126";
        public void Method1()
        {
            Console.WriteLine("Hello I ma Method1");
            Console.WriteLine("Check m1 value is: "+m1);
            Console.WriteLine("Check m2 value is: " + m2);
            Console.WriteLine("Check m3 value is: " + m3);
        }


    }
    internal class InheritanceProcess:BaseCalss
    {

        public static void Main()
        {
            BaseCalss obj1 = new InheritanceProcess();
            obj1.Method1();
            obj1.m1 = 23;
            obj1.m2 = 33;
            obj1.m3 = 43;
            obj1.Method1();
       
        }




    }
}
