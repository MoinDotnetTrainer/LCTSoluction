using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    internal class GenEx
    {
        public void Add(int x , int y) { // Datatype as an Argu
            Console.WriteLine("Add method");
        }

        public void UserDetails<t1>(t1 x ) {
            Console.WriteLine("x:"+x);
        }
        public void UserDetails<t1, t2>(t1 x, t2 y)
        {
            Console.WriteLine("x:" + x);
            Console.WriteLine("Y:" + y);
        }
    }
}
