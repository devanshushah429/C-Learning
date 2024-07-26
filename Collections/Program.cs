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
            /*
                        QueueDemo q = new QueueDemo();
                        q.UseAllMethods();
            */

            /*
            LinkedListDemo linkedList = new LinkedListDemo();
            linkedList.UseAllMethods();
            */

            DictionaryDemo dict = new DictionaryDemo();
            dict.UseAllMethods();
            dict.UseAllMethodsSortedDict();
            Console.ReadLine();

            // Customer Demo
            List<Customer> list = new List<Customer>();
            list.Add(new Customer(1, "Devanshu", Convert.ToDateTime("2003-04-29")));
            list.Add(new Customer(2, "Diya", Convert.ToDateTime("2003-04-30")));
            list.Add(new NewlyAddedCustomer(3, "ABC", Convert.ToDateTime("2003-05-30"),1));

            foreach(var a in list)
            {
                Console.WriteLine(a.name);
                Console.WriteLine(a.joiningDate);
            }
        }
    }
}
