using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

//using static System.Console; // without using Console in the Program

namespace August8th2023_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Step1: Checking Variable decalrations 
             
            int age;
            Console.WriteLine("Please Enter You are age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are currenr age is:{0}",age);
            
             
             */

            /* Step2: try catch finally excution blocks for refernce
            try
            {
                int age;
                Console.WriteLine("Please Enter You are age: ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You are currenr age is:{0}", age);

         


        }

            catch (Exception e)
            {
                Console.WriteLine("Exception is: "+ e.Message);

            }

            finally
            {
                Console.WriteLine("It is Final Block Excution: ");
            }

          


            //Step3: Arrays and String and lists sing for loop===============================

            int[] age = { 12, 34, 45, 67 };
            string[] names = new string[5];
            char[] getLetters = {'A','E','I','O','U'};
            names[0] = "Gopinath";
            names[1] = "Rajesh";
            names[2] = "Gopal";

            string senTancePart = "Hello Gopinath Malisetty Good afternoon!!!!";

            char[] getLetters2 = new char[5];
            getLetters2[0]= 'A';
            getLetters2[1] = 'K';
            getLetters2[2] = 'J';
            getLetters2[3] = 'H';

            for (int i = 0; i < age.Length; i++)
            {
                Console.WriteLine("You are age is: "+age[i]);

            }
            Console.WriteLine("=========================================================");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("You are name is: "+names[i]);

            }
            Console.WriteLine("=========================================================");
            for (int i = 0; i < getLetters.Length; i++)
            {
                Console.WriteLine("You are Vowel Sound is: " + getLetters[i]);

            }

            Console.WriteLine("=========================================================");
            for (int i = 0; i < getLetters2.Length; i++)
            {
                if (getLetters2[i]=='A' || getLetters2[i]=='E' || getLetters2[i] == 'I' || getLetters2[i] == 'O' || getLetters2[i] == 'U')
                {
                    Console.WriteLine("It is Vowel Sound is: " + getLetters2[i]);
                }
                else
                {
                    Console.WriteLine("It is not a Vowel Sound is: " + getLetters2[i]);
                }

            }
            Console.WriteLine("=========================================================");
            string destination = string.Copy(senTancePart);
            Console.WriteLine("Length Of string is: "+senTancePart.Length);
            Console.WriteLine("Upper Case Letters Of string is: " + senTancePart.ToUpper());
            Console.WriteLine("Lower Case Letters Of string is: " + senTancePart.ToLower());
            Console.WriteLine("Reverse Of string is: " + senTancePart.Reverse());
            Console.WriteLine("Check names contains Of string is: " + senTancePart.Contains("Gopinath"));
            Console.WriteLine("Check copy Of string is: " + destination);
            Console.WriteLine("Check index of string is: " + destination.IndexOf("Gopi"));
            Console.WriteLine("Check lastindex of string is: " + destination.LastIndexOf("op"));
            string subsentance = destination.Substring(Convert.ToInt32(destination.IndexOf("Go")));
            Console.WriteLine("Check substring of string is: " + subsentance);

            string namelist = "Hello Malistty: Gopinath! Can you hear me!";
            string[] separator = {",",":"," ","!" };
            string[] charnamelist = namelist.Split(separator, StringSplitOptions.None);

            Console.WriteLine("=========================================================");
            for (int i = 0; i < charnamelist.Length; i++)
            {
                Console.WriteLine("You Current String  is: " + charnamelist[i]);

            }



            string namelist2 = "@A$$$B, C:  D@";
            string[] separator2 = { "@", "$", ":", " ","," };
            string[] charnamelist2 = namelist2.Split(separator2, StringSplitOptions.None);
            string finalresult = "";
            Console.WriteLine("Test =========================================================");
            for (int i = 0; i < charnamelist2.Length; i++)
            {
                if (charnamelist2[i] !="")
                {
                    finalresult = finalresult + charnamelist2[i];
                }
               

            }
            Console.WriteLine("You Current String  is: " + finalresult);


            Console.WriteLine("Test =========================================================");

            int[] sage = { 12, 43, 56, 78 };
            int[] eage = { 79, 56, 23 };
            Array.Copy(sage, eage,eage.Length);  // Method to copy one array to another arrary
            for(int i = 0; i < eage.Length; i++)
            {
                Console.WriteLine("Check Values now: "+eage[i]);

            }

            Console.WriteLine("Check Array: " + eage);
            string namedisplay= Convert.ToString(eage);
            Console.WriteLine("Check Array: " + namedisplay);


            

            //Step4: List Operations=================================

            //List<string> lst = new List<string>();


            List<string> lst = new List<string> { "Gopinath", "Rajesh", "Kumar" };
            Console.WriteLine(lst[2]);
            lst.Add("Gopal Krishna");
            lst.Add("Hanvesh");
            lst.Add("SreeRam");
            lst.Remove("SreeRam");
            lst.RemoveAt(1); // Remove specific postion value from list
            lst.Insert(lst.Count, "Sanju Bhavik Roy");
            lst.Clear();
            foreach(string name in lst)
            {
                Console.WriteLine("Student List Data Name is: " + name);
                


            }
            Console.WriteLine("Get Total Count Items in the list: " + lst.Count);

          

            // Step5: Conditions to test if , while , do while , switch and for and for each loop.

            int[] marks = new int[5];
            string Sname, SID,result;
            double total, avg;
            int m1, m2, m3, m4, m5;

            for(int i= 0; i < marks.Length; i++)
            {
                Console.WriteLine("Please Enter Student Name: ");
                Sname = Console.ReadLine();

                Console.WriteLine("Please Enter Student ID: ");
                SID = Console.ReadLine();

               Console.WriteLine("Please Enter Student English Marks: ");
                m1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter Student Teligu Marks: ");
                m2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter Student Maths Marks: ");
                m3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter Student Science Marks: ");
                m4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter Student Social Marks: ");
                m5 = Convert.ToInt32(Console.ReadLine());
                total = m1 + m2 + m3 + m4 + m5;
                avg = total / 5;
                if (m1>=35 && m2>= 35 && m3>=35 && m4>=35 && m5>=35)
                {
                    result = "PASS";

                }
                else { result = "FAIL"; }



                Console.WriteLine("Student Results are====================================:");
                Console.WriteLine("Student Name: " + Sname);
                Console.WriteLine("Student ID: " + SID);
                Console.WriteLine("Student Total: " + total);
                Console.WriteLine("Student Avg: " + avg);
                Console.WriteLine("Student Overall Result: "+result); ;




            }

           
           

            string[] fruitslist = new string[] { "Apple", "Pears", "Carrot", "Banana", "Potato" };

            foreach( string fruit in fruitslist)
            {
                Console.WriteLine(" Fruit Name is: " + fruit);
            }

            int i = fruitslist.Length;
            while( i>0)
            {
                
               i--;
                Console.WriteLine("Check While Condition, Fruit Name: " + fruitslist[i]);
            }

             

            string[] fruitslist = new string[] { "Apple", "Pears", "Carrot", "Banana", "Potato" };

            Console.WriteLine("Please Enter You are Eating Fruit Name: ");
            string fruit = Console.ReadLine();
            fruit=fruit.Trim();
            fruit = fruit.ToLower();
            
               switch(fruit)
                {
                    case "apple":
                        Console.WriteLine("Eat Apple Every Day for Good Life......");
                        break;
                    case "potato":
                        Console.WriteLine("Eat Potato Every Day for Good Life......");
                        break;
                    case "banana":
                        Console.WriteLine("Eat Banana Every Day for Good Life......");
                        break;

                    case "pears":
                        Console.WriteLine("Eat Pears Every Day for Good Life......");
                        break;

                    case "carrot":
                        Console.WriteLine("Eat Carrot Every Day for Good Life......");
                        break;

                    case "cucumber":
                        Console.WriteLine("Eat Cumcumber Every Day for Good Life......");
                        break;


                    default:
                        Console.WriteLine("Please Eat Healthy Food: ");
                        break;
                }

            */


        }
    }
}
