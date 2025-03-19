using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public delegate void Cal1();
public delegate int Cal2(int x, int y);
namespace ConsoleAppLCT
{
    public class DelExample
    {
        public void Add() {
            Console.WriteLine("Add Method");
        }
        public void Sub()
        {
            Console.WriteLine("Sub Method");
        }
        public int Mul(int x , int y)
        {
            Console.WriteLine("mul Method");
            return 1;
        }
        public int Div(int x , int y)
        {
            Console.WriteLine("div Method");
            return 1;
        }
    }
}
