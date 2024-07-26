using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class LessAgeException: Exception
    {
        public LessAgeException() : base("Age less than 18")
        {

        }
    }
    public class ABC
    {
        protected internal void checkNumber()
        {
            Console.WriteLine("Hello form c2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ABC a = new ABC();
            a.checkNumber();
            try
            {
                int x = 0;
                int n = 5 / x;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.GetBaseException());
            }
            finally
            {
                Console.WriteLine("Handled exception");
            }

            //
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if(age < 18)
                {
                    throw new LessAgeException();
                }
            }
            catch (LessAgeException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                int[] arr = new int[3];
                arr[5] = 10;
            }
            catch (SystemException ex)
            {
                // Handle system-level exceptions
                Console.WriteLine($"System exception occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle all other exceptions
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.ReadLine();
            List<string> list = new List<string>() { "abc", "asdf","sdfg"};
            list.IndexOf();
        }
    }
}