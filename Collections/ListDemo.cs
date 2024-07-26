using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class ListDemo
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
        public void printList()
        {
            if (list.Count() == 0)
            {
                Console.WriteLine("List is empty");
            }
            Console.WriteLine(String.Join(",", list));
        }
        public void ListMethodsDemo()
        {
            // add element to last
            list.Add(7);
            printList();

            // AddRange() method adds specified collection to the end
            list.AddRange(new int[] { 8, 9, 10 });
            printList();

            // performs Binary Search
            Console.WriteLine("5 is at " + list.BinarySearch(5) + " index.");

            // Contains checks that given element is present or not and returns true or false
            int number = 8;
            if (list.Contains(number))
            {
                Console.WriteLine(number + " is present");
            }
            else
            {
                Console.WriteLine(number + " is not present");
            }

            // Clear removes all methods from the list
            list.Clear();
            printList();

            // Just making a new list as it was cleared
            list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<String> stringArr = list.ConvertAll((e) => { return "number : " + e; });
            Console.WriteLine(String.Join("\n", stringArr));

            // Copy To
            int[] newArr = new int[10];
            list.CopyTo(newArr);
            Console.WriteLine(String.Join(",", newArr));

            // Equals compares two lists
            if (list.Equals(new List<int> { 1, 2, 3 }))
            {
                Console.WriteLine("Lists are same");
            }
            else
            {
                Console.WriteLine("List are not same");
            }

            // Check for given type of number
            if (list.Exists((e) => { return e > 5; }))
            {
                Console.WriteLine("Number greater than 5 are avialable");
            }
            else
            {
                Console.WriteLine("Number greater than 5 are not availble");
            }

            // Find gives the first element that mathches the given condition
            Console.WriteLine(list.Find(e => { return e > 5; }));

            // Find all the element that matches the given conditions
            List<int> findAllList = list.FindAll(e => e > 5);
            Console.WriteLine("Numbers greater than 5 : " + String.Join(",", findAllList));

            // FindIndex gets the first index of the element that matches the given conditions
            Console.WriteLine("Index of first number greater than 5" + list.FindIndex(e => e > 5));

            // Findlast find from last and gives first element that matches the given condition
            Console.WriteLine(list.FindLast(e => e > 5));

            // Findlast find from last and gives the index of first element that matches the given condition
            Console.WriteLine(list.FindLastIndex(e => e > 5));

            // Foreach makes changes but remains inside in only
            list.ForEach((e) => { e = e + 1; Console.Write(e + " "); });
            Console.WriteLine();

            // GetEnumerator gives an iterator for it that will be useful to iterate over list
            List<int>.Enumerator em = list.GetEnumerator();
            while (em.MoveNext())
            {
                Console.Write(em.Current + " ");
            }
            Console.WriteLine();

            // Gets the hash code of the list
            Console.WriteLine("Hash Code : " + list.GetHashCode());

            // Get Range
            List<int> listGetRange = list.GetRange(1, 4);
            Console.WriteLine(String.Join(",", listGetRange));

            // Get Type
            Console.WriteLine(list.GetType());

            // IndexOf retrives index for element of first occurence 
            Console.WriteLine(list.IndexOf(1));

            // Similar to IndexOf but finds from last
            Console.WriteLine(list.LastIndexOf(4));

            // Insert method is used to add element at the specified index
            // 0 index upar 0 insert karo
            list.Insert(0, 0);
            printList();

            // RemoveAt removes element at given index
            list.RemoveAt(0);
            printList();

            // Insert Range Inserts more than one element in the list at the given index
            list.InsertRange(7, new int[] { 7, 8, 9 });
            printList();

            // Remove range removes multiple elements in given range of index
            list.RemoveRange(7, 3);
            printList();

            //Remove All
            list.RemoveAll(e => e > 8);
            printList();

            // reverses the list
            list.Reverse();
            printList();
            list.Reverse();

            // insert element at specified index
            list.Insert(0, 9);
            list.Insert(0, 10);
            
            // sort list based on comparator
            // here it performs bubble sort
            // here if comparator returns number greater than 1 than it swaps 
            // if not than it dont swaps
            list.Sort((a, b) =>
            {
                if (b > a)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            });
            printList();

            // list to string
            Console.WriteLine(list.ToString());

            // TrimEccess reduce escess the capacity to current no of element.
            list.TrimExcess();

            // TrueForAll
            Console.WriteLine(list.TrueForAll(e => e % 1 == 0));

            // ToArray
            int[] arr = list.ToArray();
        }
    }
}
