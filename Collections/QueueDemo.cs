using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class QueueDemo
    {
        Queue<int> q = new Queue<int>();
        public void UseAllMethods()
        {
            // Add elements in Queue
            q.Enqueue(5);
            q.Enqueue(10);
            q.Enqueue(15);
            q.Enqueue(20);
            q.Enqueue(25);
            q.Enqueue(30);
            q.Enqueue(35);
            q.Enqueue(40);
            DisplayQueue();

            // Remove Element from the queue
            q.Dequeue();
            DisplayQueue();

            // Display Size of queue
            Console.WriteLine("Count is " + q.Count);

            // Constains() Returns true if element exists in queue
            DisplayQueue();
            Console.WriteLine("Constains 10?"+q.Contains(10));

            // Peek()
            DisplayQueue();
            Console.WriteLine("Top most element is "+q.Peek());

            // Clear() Clears the complete queue
            q.Clear();
            DisplayQueue();


        }

        public void DisplayQueue()
        {
            if(q.Count == 0)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine("Queue is "+String.Join(",", q));
            }
        }
    }
}
