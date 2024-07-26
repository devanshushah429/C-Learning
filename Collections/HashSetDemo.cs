using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class HashSetDemo
    {
        HashSet<int> hashSet = new HashSet<int>();

        public void DoHashSetDemo()
        {
            // Add elements to the HashSet
            hashSet.Add(10);
            hashSet.Add(20);
            hashSet.Add(30);
            hashSet.Add(40); 

            // Display the elements in the HashSet
            Console.Write("HashSet after adding elements:");
            DisplayHashSet(hashSet);

            // Check if an element exists in the HashSet
            Console.WriteLine("contain 20 " + hashSet.Contains(20));
            Console.WriteLine("contain 50 " + hashSet.Contains(50));

            // Remove an element from the HashSet
            hashSet.Remove(20);
            Console.Write("removing 20:");
            DisplayHashSet(hashSet);

            // Clear all elements from the HashSet
            hashSet.Clear();
            Console.Write("clearing all elements:");
            DisplayHashSet(hashSet);

            // Add some elements again 
            hashSet.Add(10);
            hashSet.Add(20);
            hashSet.Add(30);
            hashSet.Add(40);

            // UnionWith another HashSet
            HashSet<int> anotherSet = new HashSet<int> { 30, 40, 50, 60 };
            hashSet.UnionWith(anotherSet);
            Console.Write("after UnionWith another set:");
            DisplayHashSet(hashSet);
            Console.WriteLine();

            // IntersectWith another HashSet
            HashSet<int> intersectSet = new HashSet<int> { 40, 50, 70 };
            hashSet.IntersectWith(intersectSet);
            Console.Write("after IntersectWith another set:");
            DisplayHashSet(hashSet);
            Console.WriteLine();

            //Adding some extra elements
            hashSet.Add(40);
            hashSet.Add(30);
            hashSet.Add(60);
            DisplayHashSet(hashSet);


            // Except with another HashSet
            HashSet<int> exceptSet = new HashSet<int> { 40, 50 };
            hashSet.ExceptWith(exceptSet);
            Console.Write("after ExceptWith another set:");
            DisplayHashSet(hashSet);
            Console.WriteLine();

            // SymmetricExcept with another HashSet
            HashSet<int> symmetricExceptSet = new HashSet<int> { 30, 20 };
            hashSet.SymmetricExceptWith(symmetricExceptSet);
            Console.WriteLine("after SymmetricExceptWith another set:");
            DisplayHashSet(hashSet);

            // Check if HashSet is a subset of another HashSet
            HashSet<int> subsetSet = new HashSet<int> { 30, 60 };
            Console.WriteLine("SubSet? " + hashSet.IsSubsetOf(subsetSet));

            // Check if HashSet is a superset of another HashSet
            HashSet<int> supersetSet = new HashSet<int> { 30, 60, 90 };
            Console.WriteLine("SuperSet" + hashSet.IsSupersetOf(supersetSet));

            // Check if HashSet is disjoint with another HashSet
            HashSet<int> disjointSet = new HashSet<int> { 100, 200 };
            DisplayHashSet(hashSet);

            // Copy HashSet to an array
            int[] array = new int[hashSet.Count];
            hashSet.CopyTo(array);
            Console.WriteLine("copied to array:" + String.Join(",", array));
        }

        static void DisplayHashSet(HashSet<int> hashSet)
        {
            if (hashSet.Count == 0)
            {
                Console.WriteLine("HashSet is empty.");
            }
            else
            {
                Console.WriteLine(String.Join(",", hashSet));
            }
        }
    }
}
