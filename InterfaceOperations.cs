using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August8th2023_Practice
{

    interface IOfficeData
    {
        void OfficeDetails();
        void OfficeLocation();

    }

    interface ICollgeData
    {

        void CollgeDetails();
        void CollegeInformation();
        void CollgeAnnouncement();


    }

    class InformationFromAll:IOfficeData,ICollgeData
        {

        public void OfficeDetails()
        {
            Console.WriteLine("Hello  I am Display Office Deatils: ");

        }
       public void OfficeLocation()
        {
            Console.WriteLine("Hello  I am Display Office Location: ");

        }


       public void CollgeDetails()
        {
            Console.WriteLine("Hello  I am Display Collge Deatils: ");

        }
        public void CollegeInformation()
        {
            Console.WriteLine("Hello  I am Display Collge Information Details: ");
        }
        public void CollgeAnnouncement()
        {
            Console.WriteLine("Hello  I am Display Collge Announcement Deatils: ");

        }




    }
    internal class InterfaceOperations
    {

        static void Main()
        {


            InformationFromAll obj1 = new InformationFromAll();
            obj1.OfficeDetails();
            obj1.OfficeLocation();
            obj1.CollgeDetails();
            obj1.CollegeInformation();
            obj1.CollgeAnnouncement();


        }
    }
}
