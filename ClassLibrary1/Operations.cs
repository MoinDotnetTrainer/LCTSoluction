using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Operations
    {
        public void Add() {
            int x = 34, y = 34, z;
            z = x + y;
            Console.WriteLine("Add is:"+z);
        }
        public void SUb()
        {
            int x = 34, y = 34, z;
            z = x - y;
            Console.WriteLine("sub is:" + z);
        }
        public void mul()
        {
            int x = 34, y = 34, z;
            z = x * y;
            Console.WriteLine("mul is:" + z);
        }
        public void div()
        {
            int x = 34, y = 34, z;
            z = x / y;
            Console.WriteLine("div is:" + z);
        }
    }
}
