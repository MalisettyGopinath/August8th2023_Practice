using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace August8th2023_Practice
{

    /*
     1. List<T>
     2.SortedList<TKey,TValue>
     3.Dictionary<TKey,TValue>
     4.Stack<T>
     5.Queue<T>
     6.Hashset<T>
     */

    /* List methods  are 
     
                a. Add()
                b. AddRange()  // Need to Google
                c. BinarySearch()  // Need to Google
                d. Clear()
                e. Contains()
                f. Find()  // Need to Google
                g. Insert()
                h. Sort()
                i. Remove()
                j. RemoveAt()
     
     
     */
    internal class CollectionsAndGenericsOperations
    {

        static void Main()
        {
            Console.WriteLine("Hello Malisetty Gopinath, Good Morning");

            List<int> lst = new List<int>();

            lst.Add(23);
            lst.Add(45);
            lst.Add(78);

            foreach (int i in lst)
            {
                Console.WriteLine("List Item are : " + i);
            }

            Console.WriteLine("List Count is: " + lst.Count);

            lst.Remove(23);
            Console.WriteLine("List Count is: " + lst.Count);

            lst.Add(46);
            lst.Add(75);

            Console.WriteLine("List Count is: " + lst.Count);

            foreach (int i in lst)
            {
                Console.WriteLine("List Item are : " + i);
            }

            // lst.Clear();

            lst.Sort();

            Console.WriteLine("Sorting List ====================================");

            foreach (int i in lst)
            {
                Console.WriteLine("List Item are : " + i);
            }

            lst.Remove(45);//Specific Value in the list
                           // lst.RemoveAt(2);//Index Position

            Console.WriteLine("Remove List ====================================");

            foreach (int i in lst)
            {
                Console.WriteLine("List Item are : " + i);
            }

            Console.WriteLine("List Contains 76 value or not ====================================: " + lst.Contains(78));

            lst.Reverse();


            Console.WriteLine("Reverse List ====================================");

            foreach (int i in lst)
            {
                Console.WriteLine("List Item are : " + i);
            }

            lst.Insert(1, 56); // Index and Postion Value
            lst.Insert(0, 100);//Index and Postion Value


            Console.WriteLine("Index List Postions====================================");

            foreach (int i in lst)
            {
                Console.WriteLine("List Item are : " + i);
            }


            Console.WriteLine("Sorted List Process is in Progress =================================");
            /* Sortedlist<TKey,TValue>

            1.Add()
            2.Remove()
            3.RemoveAt()
            4.ContainsKey()
            5.ContainsValue()
            6.Clear()
            7.IndexOfKey()
            8.IndexOfValue()
            9.TryGetValue()
            */
            SortedList<int, string> srtlst = new SortedList<int, string>();
            srtlst.Add(1234, "Gopinath");
            srtlst.Add(456, "Royal");
            srtlst.Add(654, "Rajesh");
            int countvalue = srtlst.Count;
            Console.WriteLine("Sorted List Count is: " + countvalue);
            foreach(int item in srtlst.Keys)
            {
                Console.WriteLine("Stored Item Value: " + srtlst[item]);
            }
            srtlst.Remove(1234);
            countvalue = srtlst.Count;
            Console.WriteLine("Sorted List Count is: " + countvalue);
            foreach (int item in srtlst.Keys)
            {
                Console.WriteLine("Stored Item Value: " + srtlst[item]);
            }

            Console.WriteLine("Stored Item Key Value: " + srtlst.ContainsKey(456));
            Console.WriteLine("Stored Item Value: " + srtlst.ContainsValue("Royal"));
            srtlst.RemoveAt(1); //Delete Specific Position
            Console.WriteLine("Remove at Position============================");
            foreach (int item in srtlst.Keys)
            {
                Console.WriteLine("Stored Item Value: " + srtlst[item]);
            }
            srtlst.TryGetValue(456,out string result); // Try Get Value

            Console.WriteLine("List Try Get Valure based on Index position in list: "+result);

            srtlst.IndexOfValue("Royal"); // Index of Value

            Console.WriteLine("Index of value in list: " + srtlst.IndexOfValue("Royal"));



            Console.WriteLine("List Clear Operation============================");
            srtlst.Clear();
            countvalue = srtlst.Count;
            Console.WriteLine("Sorted List Count is: " + countvalue);
            foreach (int item in srtlst.Keys)
            {
                Console.WriteLine("Stored Item Value: " + srtlst[item]);
            }


            // Hashset<T> Opertaion
            // Mandatory Note: To Remove Duplicates in Array , we just use Hashset Operation for refernce.
            Console.WriteLine("Hash Type Operation========================================");
            string[] colors = { "RED", "GREEN", "BLUE", "RED", "ORANGE", "APPLE", "BANANA", "BLUE" };
            string resultarr = string.Join(",", colors);
            Console.WriteLine("List Array Elements needs to display in correct format: "+resultarr);

            var hashobj = new HashSet<string>(colors); // Use HashSet constructor to ensure unique strings.
            string[] distinctresult = hashobj.ToArray();   // Convert to array of strings again.
            string resultarr2 = string.Join(",", distinctresult);
            Console.WriteLine("Hash Result List Array Elements needs to display in correct format: " + resultarr2); // Display the resulting array.

        }
    }
}
