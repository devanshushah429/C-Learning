using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class StackDemo
    {
        Stack<int> st = new Stack<int>();
        
        public void UseAllMethods()
        {
            // Push() Adding elements on top of stack
            st.Push(10);
            st.Push(20);
            st.Push(30);
            st.Push(40);
            PrintStack();

            // Pop() Remove element from top
            int popedElement = st.Pop();
            Console.WriteLine("Poped element is" + popedElement);
            PrintStack();

            // Peek() to check for the top most element in the stack
            int peekedElement = st.Peek();
            Console.WriteLine("Peeked element is " + peekedElement);

            // Contains to check given element is in Stack or not.
            Console.WriteLine("Contains 20? "+st.Contains(20));



            // Clear() method is used to clear the stack
            st.Clear();
            PrintStack();
        }
        public void PrintStack()
        {
            if(st.Count == 0)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine(String.Join(",",st));
            }
        }
    }
}
