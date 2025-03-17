using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    class ClassExample
    {
        public void Add()
        {
            Console.WriteLine("Enter X:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y:");
            int y = Convert.ToInt32(Console.ReadLine());

            int z = x + y;
            Console.WriteLine("Add is:" + z);

            //display the result
          
        }

        public int Sub()
        {
            int x = 50, y = 50, z;
            z = x - y;
            Console.WriteLine("Sub is:" + z);
            return z;

            //displaying and also using the value if necesssary
        }
        public void Mul(int x, int y)
        {
            int  z;
            z = x * y;
            Console.WriteLine("Mul is:" + z);
        }
        public void Div(int x, int y)
        {
            int z;
            z = x / y;
            Console.WriteLine("Div is:" + z);
        }

        public string m1() {
            return "";
        }

        public float M2() {
            return 23.45f;
        }

         
    }

    class SampleTest
    {

    }

    class Employees
    {

    }

    class Projects
    {

    }
}
