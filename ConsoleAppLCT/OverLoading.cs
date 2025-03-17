using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    class OverLoading
    {
        public void M1() {
            Console.WriteLine("Task 1");
        }
        public void M1(int x)
        {
            Console.WriteLine("Task 2");
        }
        public void M1(string str)
        {
            Console.WriteLine("Task 3");
        }
        public void M1(int x , int y)
        {
            Console.WriteLine("Task 4");
        }
        public void M1(string str , string str1)
        {
            Console.WriteLine("Task 5");
        }
        public void M1(string x, int y)
        {
            Console.WriteLine("Task 6");
        }
        public void M1(int str, string str1)
        {
            Console.WriteLine("Task 7");
        }
    }
}
