using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    class GenClass<type1, type2>
    {
        public void M1(type1 x , type2 y) {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        public void M2(type1 x, type2 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        public void M3(type1 x, type2 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        public void M4(type1 x, type2 y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        public void M5(type1 x) {
            Console.WriteLine(x);
        }
    }
}
