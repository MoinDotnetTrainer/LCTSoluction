using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    class Emp
    {
        //public private proctected

        // void int string
        public void Add()
        {
            int x = 45, y = 5, z;
            z = x + y;
            Console.WriteLine("Add is:" + z);
        }
        public void Sub()
        {
            int x = 45, y = 5, z;
            z = x - y;
            Console.WriteLine("Sub is:" + z);
        }
        public void Mul()
        {
            int x = 45, y = 5, z;
            z = x * y;
            Console.WriteLine("mul is:" + z);
        }

        public void Div(int x, int y)
        {
            int z;
            z = x / y;
            Console.WriteLine("Div is:" + z);
        }

        public void EvenNumbers(int x, int y)
        {
            Console.WriteLine("x is:" + x);
            Console.WriteLine("y is :" + y);
        }

        public void Numbers(string str, params int[] num)
        {
            Console.WriteLine("Given Numbers are");
            foreach (int item in num)
            {
                Console.WriteLine(item);
            }
        }

        public void M1(int x, params int[] y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        /*public void M2(params int[] y, int x)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        */


    }



    class Emp2
    {
        public void M1()
        {
            int x = 35, y = 35, z;
            z = x + y;
            Console.WriteLine("Add Task is:" + z); // we are displaying the result
        }

        public int M2()
        {
            int x = 35, y = 35, z;
            z = x - y;
            Console.WriteLine("sub Task is:" + z);  // res is getting display
            return z;
        }

        public string M3()
        {
            return "Hi";
        }

        public (string, int) M4()
        {
            string x = "45";
            int y = 45;
            return (x, y);
        }
    }

}
