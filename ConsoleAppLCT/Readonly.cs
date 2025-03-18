using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    class Readonly
    {

        // Const & Readonly

        // we can del a var with const or Readonly

        const double pi = 3.14;
        readonly int x;

        // value can assigned to readonly at constr level


        public Readonly() {
            x = 56;   
        }
        public void Test()
        {

            Console.WriteLine(pi);
            Console.WriteLine(x);
        }
    }
}
