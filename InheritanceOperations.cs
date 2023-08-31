using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August8th2023_Practice
{


class CGDetails
    {
        internal const string CGname = "Capgemini", CGAddress = "HYD",CGCode="A23353";
        public virtual void CompantDetails()
        {
            Console.WriteLine("Compant Name is: "+CGname);
            Console.WriteLine("Compant Address is: "+CGAddress);
            Console.WriteLine("Compant CODE is: "+CGCode);
        }

    }

class Employee: CGDetails
    {
       public string empname, empadress, empsal, empdesignation;

        sealed public override void CompantDetails()
        {
            Console.WriteLine("Employee Compant Name is: " + "Rolls Royal");
            Console.WriteLine("Employee Compant Address is: " + "Bangalore");
            Console.WriteLine("Employee Compant CODE is: " + "AFSG26367");
        }
        public Employee(string name, string address,string sal,string empdes)
        {
            this.empname = name;
            this.empadress = address;
            this.empsal = sal;
            this.empdesignation = empdes;
        }
        public void EmployeeDetails()
        {       
     
        Console.WriteLine("Employee Name is: " + this.empname);
        Console.WriteLine("Employee Address is: " + this.empadress);
        Console.WriteLine("Employee Salary is: " + this.empsal);
        Console.WriteLine("Employee Designation is: " + this.empdesignation);

        }


    }

    class Security : CGDetails
    {
        public string secname, secadress, secsal, secdesignation;

        public Security(string name, string address, string sal, string empdes)
        {
            this.secname = name;
            this.secadress = address;
            this.secsal = sal;
            this.secdesignation = empdes;
        }


        sealed public override void CompantDetails()
        {
          
            Console.WriteLine("Security Compant Name is: " + "Scorpio");
            Console.WriteLine("Security Compant Address is: " + "Chennai Fish Market");
            Console.WriteLine("Security Compant CODE is: " + "HDJF26367");
        }

        public void SecDetails()
        {
         
            Console.WriteLine("Security Name is: " + this.secname);
            Console.WriteLine("Security Address is: " + this.secadress);
            Console.WriteLine("Security Salary is: " + this.secsal);
            Console.WriteLine("Security Designation is: " + this.secdesignation);

        }


    }


    class Lab:Security
    {
        public string labname, labadress, labsal, labdesignation;

        public Lab(string name1, string address1, string sal1, string empdes1):base(name1, address1, sal1, empdes1) 
        {
            this.labname = name1;
            this.labadress = address1;
            this.labsal = sal1;
            this.labdesignation = empdes1;
        }

        public void LabDetails()
        {
            
            Console.WriteLine("Labour Name is: " + this.labname);
            Console.WriteLine("Labour Address is: " + this.labadress);
            Console.WriteLine("Labour Salary is: " + this.labsal);
            Console.WriteLine("Labour Designation is: " + this.labdesignation);

        }


    }



    class InheritanceOperations
    {


        static void Main()
        {

            
             Employee obj1 = new Employee("Gopinath", "HYD", "450000", "Professor");
            Console.WriteLine("Employee Details are==============================");
            obj1.CompantDetails();
            obj1.EmployeeDetails();
              
            Security obj2 = new Security("Raj Singh", "CHENNAI", "250000", "Security Head");
            Console.WriteLine("Security Details are==============================");
            obj2.CompantDetails();
            obj2.SecDetails();
             

            Lab obj3 = new Lab("Malisetty", "Mumbai", "15000", "Labour Head");
            Console.WriteLine("Labour Details are==============================");
            obj3.CompantDetails();
            obj3.SecDetails();
            obj3.LabDetails();

        }
    }
}
