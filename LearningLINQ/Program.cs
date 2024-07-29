using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            /*AggregateFunctionsDemo();*/
            /*SortingOperators();*/
            List<Employee> list = new Employee().GetAllEmployees();
            List<String> nameList = list.Take(3).Select(x => x.Name).ToList();
            Console.WriteLine(string.Join(",",nameList));
            List<String> nameList2 = list.TakeWhile(x => x.Salary > 5000m).Select(x => x.Name).ToList();
            Console.WriteLine(string.Join(",", nameList2));
            Console.Read();
        }

        private static void SortingOperators()
        {
            Employee emp = new Employee();
            List<Employee> list = emp.GetAllEmployees();

            list.ForEach(x => Console.WriteLine(x.Name));


            // Order by salary ASCENDING
            Console.WriteLine("\n-----Ascending Employees-----");
            List<Employee> list2 = list.OrderBy(x => x.Salary).ToList();
            list2.ForEach(x => Console.WriteLine("Name : " + x.Name + "Salary : " + x.Salary));

            // Order by salary Descending
            Console.WriteLine("\n-----Descending Employees-----");
            List<Employee> list3 = list.OrderByDescending(x => x.Salary).ToList();
            list3.ForEach(x => Console.WriteLine("Name : " + x.Name + "Salary : " + x.Salary));

            // To reverse the list of descending
            Console.WriteLine("\n-----Reverse List-----");
            List<Employee> list4 = list.OrderByDescending(x => x.Salary).Reverse().ToList();
            list4.ForEach(x => Console.WriteLine("Name : " + x.Name + "Salary : " + x.Salary));

            Console.WriteLine("knvkm");
            List<Employee> list5 = list.Where(x => true).Reverse().ToList();
            list5.ForEach(x => Console.WriteLine("Name : " + x.Name + "Salary : " + x.Salary));

            // Order By Salary Then By Name
            Console.WriteLine("\nOrder By Salary Then By Name");
            List<Employee> list6 = list.OrderByDescending(x => x.Salary).ThenBy(x => x.Name).ToList();
            list6.ForEach(x => Console.WriteLine("Name : " + x.Name + "Salary : " + x.Salary));
            Console.ReadLine();
        }

        #region Aggregate Functions
        private static void AggregateFunctionsDemo()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int min = list.Min();
            int max = list.Max();
            int count = list.Count();
            int sum = list.Sum();
            double avg = list.Average();
            int agg = list.Where(n => n > 5).Aggregate((a, b) => { return a + b; });
            Console.WriteLine(agg);
            Console.WriteLine("Minimum number is : " + min);
            Console.WriteLine("Maximum number is : " + max);
            Console.WriteLine("Count is : " + count);
            Console.WriteLine("Sum is : " + sum);
            Console.WriteLine("Average is : " + avg);
        }
        #endregion
    }
}
