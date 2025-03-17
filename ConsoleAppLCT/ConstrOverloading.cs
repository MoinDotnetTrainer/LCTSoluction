using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    internal class ConstrOverloading
    {
        public  ConstrOverloading() // default or implict
        {
            Console.WriteLine("constr with 0 pm");
        }
        public ConstrOverloading(int x)// parameterized or Explict
        {
            Console.WriteLine("constr with 1 int pm");
        }
        public ConstrOverloading(string str)
        {
            Console.WriteLine("constr with 1 string pm");
        }
        public ConstrOverloading(int x, int y)
        {
            Console.WriteLine("constr with 2 int pm");
        }
    }
}
