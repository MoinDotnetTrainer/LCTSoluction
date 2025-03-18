using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    class Parent
    {
        protected int x, y, z;

        public void Add()
        {
            x = 45;
            y = 45;
            z = x + y;
            Console.WriteLine("Add is:" + z);
        }
        public void Sub()
        {
            x = 45;
            y = 45;
            z = x - y;
            Console.WriteLine("Sub is:" + z);
        }
    }


    class Child : Parent
    {
        public void Mul()
        {
            //Add();
            //Sub();
            x = 45;
            y = 45;
            z = x * y;
            Console.WriteLine("Mul is:" + z);
        }
        public void Div()
        {
            x = 45;
            y = 45;
            z = x / y;
            Console.WriteLine("Div is:" + z);
        }
    }

}
