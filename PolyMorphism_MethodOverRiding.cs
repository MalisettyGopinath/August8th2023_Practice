using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace August8th2023_Practice
{

    class CGDeatils
    {
        internal static string CGName = "VREC", CGAddress = "HYD", CGCode = "A343464";

        public static void CGDisplay()
        {
            Console.WriteLine("Collge Details are==================================");
            Console.WriteLine("Collge Name: " + CGName);
            Console.WriteLine("Collge Address: " + CGAddress);
            Console.WriteLine("Collge Code: " + CGCode);

        }

        public virtual void CGRules(string name,string lname)
        {

            string fname = name + lname;
            Console.WriteLine("Base Class Full Name is: "+fname);
        }



    }

    class EmpDetails: CGDeatils
    {

        public override void CGRules(string name, string lname)
        {

            string fname = name + lname;
            Console.WriteLine("Dervied CG Rules Class Full Name is: " + fname);
        }


        public void EmpRules(string ename, string elname)
        {

            string efname = ename + elname;
            Console.WriteLine("Dervied Emp rules Class Full Name is: " + efname);
        }

    }
    internal class PolyMorphism_MethodOverRiding
    {
        // Method Over Ridiing==================
        static void Main()
        {
            Console.WriteLine(" Method Over Riding is in Progress================");

            EmpDetails obj1 = new EmpDetails();
            CGDeatils.CGDisplay();
            obj1.CGRules("Patel","Rajsingh");
            obj1.EmpRules("Gopinath", "Malisetty");
        }
    }
}
