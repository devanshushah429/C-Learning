using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            ListDemo listDemo = new ListDemo();
            listDemo.ListMethodsDemo();
            */

            /*
            HashSetDemo dm = new HashSetDemo();
            dm.DoHashSetDemo();
            */

            /*
            StackDemo st = new StackDemo();
            st.UseAllMethods();
            */

            QueueDemo q = new QueueDemo();
            q.UseAllMethods();
            Console.ReadLine();
        }
    }
}
