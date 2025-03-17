using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    class MethodOverLoading
    {
        public void M1() {
            Console.WriteLine("Task1");
        }
        public void M1(int x)
        {
            Console.WriteLine("Task2");
        }
        public void M1(string x)
        {
            Console.WriteLine("Task3");
        }
        public void M1(int x , int y)
        {
            Console.WriteLine("Task4");
        }
        public void M1(string x , string y)
        {
            Console.WriteLine("Task5");
        }
        public void M1(int x, string y)
        {
            Console.WriteLine("Task6");
        }
        public void M1(string x, int y)
        {
            Console.WriteLine("Task7");
        }
    }
}
