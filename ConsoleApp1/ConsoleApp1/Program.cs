using System;
using ConsoleApp2;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class GenericDemo {
        public bool AreEqual<T>(T val1, T val2)
        {
            return val1.Equals(val2);
        }
        public void PrintData<T1,T2>(T1 val1, T2 val2)
        {
            Console.WriteLine(val1+" "+val2);
        }
    }
    public class BCD:ABC
    {
        public void checkProtectedInternal()
        {
            base.checkNumber();
        }
    }
    public enum Days { Sun, Mon,Tues,Wed,Thurs,Fri,Sat }
    public abstract class Animal
    {
        public Animal(string abc)
        {
            Console.WriteLine("base constructor");
        }
        internal virtual void Eat()
        {
            Console.WriteLine("Animal is eating...");
        }

        public abstract void Abc();
    }

    public abstract class Dog : Animal
    {
        int a = 10;
        public Dog(): base("kdfn")
        {

        }
        internal override void Eat() 
        {
            Console.WriteLine("Dog is eating...");
        }
        public override void Abc()
        {

        }
    }
    public class C: Dog
    {
        public override void Abc()
        {

        }
    }
    class Program
    {
        class Person {
            public int age;
            public string name;

            public Person(int age, string name) 
            {
                this.age = age;
                this.name = name;
            }
            public Person(Person p)
            {
                this.age = p.age;
                this.name = p.name;
            }
            public void PrintDetails()
            {
                Console.WriteLine(this.name + " " + this.age);
            }
        }
        public static void Main(string[] args)
        {
            GenericDemo gd = new GenericDemo();
            Console.WriteLine(gd.AreEqual<int>(1,2));
            Console.WriteLine(gd.AreEqual<int>(1, 1));
            Console.WriteLine(gd.AreEqual<string>("abc","abc"));
            gd.PrintData<string,int>("djn",2);
            /*
                        Person p1 = new Person(10, "Hello");
                        Person p2 = new Person(p1);
                        Person p3 = p1;
                        p1 = new Person(20,"svhs");
                        p1.PrintDetails();
                        p2.PrintDetails();
                        p3.PrintDetails();
                        Console.WriteLine((Days)4);*/
            /*
            String str = "Devanshu";
            Console.WriteLine("Hello World from {0}", str);
            Int32 num = Convert.ToInt32(Console.ReadLine());
            CheckNumber(num);
            CheckForLoop(10);
            Console.WriteLine(Factorial(6));
            CheckDoWhile();
            Int32 n = 25;
            CallByValue(n);
            Console.WriteLine(n);
            CallByRef(ref n);
            Console.WriteLine(n);
            int n = 25;
            OutputDemo(out n);
            Console.WriteLine(n);
            int[] arr = new int[5] {1,2,3,4,5};
            ChangeArray(arr);
            MultiDimentionArray();
            JaggedArray();
            CheckParams("Abc", 10, true, 20, "BCD", 'a');
            */

            // Command Line input
            /*
            Console.WriteLine("Argument length: " + args.Length);
            Console.WriteLine("Supplied Arguments are:");
            foreach (Object obj in args)
            {
                Console.WriteLine(obj);
            }
            int[] arr2 = (int[])arr.Clone();
            arr2[0] = 20;
            int[] arr3 = Array.Empty<int>();

            
            Console.WriteLine(String.Join(",", arr3));
            Console .WriteLine(String.Join(",", arr2));
            ReadOnlyCollection<int> readOnlyCollection = Array.AsReadOnly(arr);
            Console.WriteLine(readOnlyCollection[0]);
            Array.Reverse(arr);
            Console.WriteLine(String.Join(",", arr));
            Console.WriteLine(Array.Find(arr,(a) => { return a % 2 == 0; }));
            */
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
            Console.WriteLine(Array.IndexOf(arr,5));
            Array.Reverse(arr);
            Array.Sort(arr);
            int[] arr2 = { }; 
            arr2.Initialize();
            Console.WriteLine(String.Join(",",arr));
            PrintPattern(10);
            Console.ReadLine();
        }

        #region Pattern
        public static void PrintPattern(int n)
        {
            for(int i = 0; i<n; i++)
            {
                int j = 0;
                for (; j<i; j++)
                {
                    Console.Write((char)(65+j));
                }
                for(; j>=0; j--)
                {
                    Console.Write((char)(65+j));
                }
                Console.WriteLine();
            }

            int l = n;
            for (; l>0; l--)
            {
                for(int j = l; j < n; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j<l; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
            

        }
        #endregion

        #region Params
        public static void CheckParams(params object[] arr)
        {
            foreach(object a in arr)
            {
                Console.WriteLine(a);
            }
        }
        #endregion

        #region Multi Dimentional Array
        public static void MultiDimentionArray()
        {
            int[,] arr = new int[3,3];
            int k = 0;
            for(int i=0; i<arr.GetLength(0); i++)
            {
                for(int j = 0; j<arr.GetLength(1);j++)
                {
                    arr[i, j] = k;
                    k++;
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Jagged Array
        public static void JaggedArray()
        {
            int[][] jaggedArr = new int[3][];
            jaggedArr[0] = new int[] { 2, 3, 4 };
            jaggedArr[1] = new int[] { 2, 3 };
            jaggedArr[2] = new int[] { 4, 5, 6 };
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for(int j = 0; j< jaggedArr[i].Length; j++)
                {
                    Console.WriteLine(jaggedArr[i][j]);
                }
            }
        }
        #endregion

        #region Change Array
        public static void ChangeArray(int[] arr) {
            for (int i = 0; i < arr.Length; i++) {
                arr[i] = arr[i] + 1;
                Console.WriteLine(arr[i]);
            }
        }
        #endregion

        #region Check Number
        public static void CheckNumber(Int32 num)
        {
            switch (num)
            {
                case 10: Console.WriteLine("It is 10"); break;
                case 20: Console.WriteLine("It is 20"); break;
                case 30: Console.WriteLine("It is 30"); break;
                default: Console.WriteLine("Not 10, 20 or 30"); break;
            }
        }
        #endregion

        #region For Loop
        public static void CheckForLoop(Int32 num)
        {
            for (Int32 i = 0; i < num; i += 2)
            {
                Console.WriteLine(i);
            }
        }
        #endregion

        #region While Loop
        public static int Factorial(int n)
        {
            if (n < 0) return -1;
            if (n == 0) return 1;
            Int32 answer = 1;
            while (n > 0)
            {
                answer *= n;
                n--;
            }
            return answer;
        }
        #endregion

        #region Do While Loop
        public static void CheckDoWhile()
        {
            int i = 1;
            do
            {
                int j = 1;
                do
                {
                    Console.WriteLine(i + " " + j);
                    j++;
                } while (j <= 3);
                i++;
            } while (i <= 3);
        }
        #endregion

        #region Call By Value
        public static void CallByValue(Int32 n)
        {
            for (; n > 0; n--)
            {
                Console.WriteLine(n);
            }
        }
        #endregion

        #region Call By Ref
        public static void CallByRef(ref Int32 n)
        {
            for (; n > 0; n--)
            {
                Console.WriteLine(n);
            }
        }
        #endregion

        #region Output Parameter Demo
        public static void OutputDemo(out int para) 
        {
            para = 5;
        }
        #endregion
    }
}