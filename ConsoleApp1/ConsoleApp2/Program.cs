using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
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
        }
    }
}