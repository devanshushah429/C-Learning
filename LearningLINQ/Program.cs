using System;
using System.Collections;
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
            /*PartitionOperatorsDemo();*/
            /*CastDemo();*/
            /*OfTypeDemo();*/
            List<Employee> list = new Employee().GetAllEmployees();

            /*ToArrayMethodDemo(list);*/
            /*LookUpMethod(list);*/
            /*GroupByDemo(list);*/
            /*AsEnumerableDemo();*/
            /*AsDictionaryDemo(list);*/


            //Element Operators
            List<String> strList = new List<string>() { "India", "America", "China", "Pakistan"};
            var orderedListDesc = from s in strList
                                  orderby s descending
                                  select s;
            foreach(var a in orderedListDesc)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("Heloo");
            List<String> emptyList = new List<String>();

            // To retrive first element

            //gives exception if element not avialable
            Console.WriteLine(strList.First());
            /*Console.WriteLine(emptyList.First());*/

            // gives by default value
            Console.WriteLine(strList.FirstOrDefault());
            Console.WriteLine(emptyList.FirstOrDefault());

            // To retrive last element

            // gives exception if element not avialable
            Console.WriteLine(strList.Last());
            /*Console.WriteLine(emptyList.Last());*/

            // gives by default value
            Console.WriteLine(strList.LastOrDefault());
            Console.WriteLine(emptyList.LastOrDefault());

            // element at also gives exception when element not available at the specific index 
            Console.WriteLine(strList.ElementAt(2));
            /*Console.WriteLine(emptyList.ElementAt(4));*/
            Console.WriteLine(strList.ElementAtOrDefault(2));
            Console.WriteLine(strList.ElementAtOrDefault(4));
/*
            Console.WriteLine(strList.SingleOrDefault());*/
            Console.WriteLine(strList.SingleOrDefault(x => x == "Russia"));

            foreach(var a in emptyList.DefaultIfEmpty())
            {
                Console.WriteLine(a);
            }
            Console.Read();
        }

        private static void AsDictionaryDemo(List<Employee> list)
        {
            Dictionary<int, string> dict = list.ToDictionary(x => x.ID, x => x.Name);
            foreach (var kvp in dict)
            {
                Console.WriteLine("ID : " + kvp.Key + " Name : " + kvp.Value);
            }
        }

        private static void AsEnumerableDemo()
        {
            List<int> a = new List<int> { 1, 2, 3, 4 };
            IEnumerable<int> inu = a.AsEnumerable();
            foreach (int i in inu)
            {
                Console.WriteLine(i);
            }
        }

        private static void OfTypeDemo()
        {
            //OfType Checks for the elements in the given iterable and return the iterable of the specified type
            ArrayList arrList = new ArrayList { "India", 1, "Australia", 2, true, false, "USA", new ArrayList { "asdf", "123" } };
            List<String> ofTypeList = arrList.OfType<String>().ToList();
            Console.WriteLine(String.Join(", ", ofTypeList));
        }

        private static void CastDemo()
        {
            // Specificallly cast to IEnumerable
            ArrayList names = new ArrayList { "Alice", "Bob", "Charlie" };
            IEnumerable<String> names2 = names.Cast<String>();
            foreach (String a in names2)
            {
                Console.WriteLine(a);
            }
        }

        private static void ToArrayMethodDemo(List<Employee> list)
        {
            // To array method changes the given iterable to an array
            Employee[] arr = list.ToArray();
            foreach (Employee e in arr)
            {
                Console.WriteLine(e.Name);
            }
        }

        private static void GroupByDemo(List<Employee> list)
        {
            // Group by groups the data according to the given fields
            var groupbyOutput = list.GroupBy(x => new { x.Department, x.City });
            foreach (var abc in groupbyOutput)
            {
                Console.WriteLine("----- Department : " + abc.Key + " -----");
                foreach (var item in abc)
                {
                    Console.WriteLine("Name : " + item.Name);
                    Console.WriteLine("Position : " + item.Position);
                    Console.WriteLine("City : " + item.City);

                }
            }
        }

        private static ILookup<string, Employee> LookUpMethod(List<Employee> list)
        {
            // Look up is similar to the group by and is used to get the key value pair
            var lookUpOutput = list.ToLookup(x => x.Department);
            foreach (var kvp in lookUpOutput)
            {
                Console.WriteLine("----- Department : " + kvp.Key + " -----");
                foreach (var item in lookUpOutput[kvp.Key])
                {
                    Console.WriteLine("Name : " + item.Name);
                    Console.WriteLine("Position : " + item.Position);
                    Console.WriteLine("City : " + item.City);

                }
            }

            return lookUpOutput;
        }

        private static void PartitionOperatorsDemo()
        {
            List<Employee> list = new Employee().GetAllEmployees();
            List<String> nameList = list.Take(3).Select(x => x.Name).ToList();
            Console.WriteLine(string.Join(",", nameList));
            List<String> nameList2 = list.TakeWhile(x => x.Salary > 5000m).Select(x => x.Name).ToList();
            Console.WriteLine(string.Join(",", nameList2));
            List<String> nameList3 = list.Skip(3).Select(x => x.Name).ToList();
            Console.WriteLine(string.Join(", ", nameList3));
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
