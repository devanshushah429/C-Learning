using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
   
    class LinkedListDemo
    {
        LinkedList<int> linkedList = new LinkedList<int>();
        
        public void UseAllMethods()
        {
            // AddFirst add elements at the first
            linkedList.AddFirst(1);
            DisplayList("Add 1");

            // Add elements at the last
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);
            DisplayList("Add 2,3,4,5 at last");


            //Remove Any element
            linkedList.Remove(4);
            DisplayList("remove 4");

            // Remove element from first
            linkedList.RemoveFirst();
            DisplayList("Remove first element");

            // Remove element from last
            linkedList.RemoveLast();
            DisplayList("remove last element");
            
            // Adding elements just to fix linked list
            linkedList.AddFirst(1);
            linkedList.AddLast(5);
            DisplayList("fix add");

            // Add element After any the node
            LinkedListNode<int> tempNode = linkedList.First;
            while(tempNode != null)
            {
                if(tempNode.Value.Equals(3))
                {
                    linkedList.AddAfter(tempNode, 4);
                    break;
                }
                tempNode = tempNode.Next;
            }

            // can also be dont by find method
            /*
            LinkedListNode<int> tempNode2 = linkedList.Find(3);
            linkedList.AddAfter(tempNode2, 4);
            */
            DisplayList("Add 4 after 3");

            linkedList.AddLast(7);
            tempNode = linkedList.First;
            while(tempNode!= null)
            {
                if(tempNode.Value.Equals(7))
                {
                    linkedList.AddBefore(tempNode,6);
                }
                tempNode = tempNode.Next;
            }
            DisplayList("Add 6 before 7");

            // can also be dont by find method
            /*
            LinkedListNode<int> tempNode2 = linkedList.Find(7);
            linkedList.AddBefore(tempNode2, 6);
            */

            // Find and Find Last
            Console.WriteLine(linkedList.Find(1).Value);
            Console.WriteLine(linkedList.FindLast(1).Value);

            // Contains method
            Console.WriteLine("Contains 5?"+linkedList.Contains(5));

            LinkedList<int>.Enumerator en = linkedList.GetEnumerator();
            while(en.MoveNext())
            {
                Console.Write(en.Current+"->");
            }

            // Clear linked list
            linkedList.Clear();

        }
        public void DisplayList(String msg)
        {
            if(linkedList.Count == 0)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                Console.WriteLine("List after "+msg+" : "+String.Join("->", linkedList));
            }
        }
    }
}
