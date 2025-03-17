using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    internal class GP
    {
        public void M1() { }
    }

    class P :GP{
        public void M2() {
            M1();
        }
    }

    class C : P {
        public void M3() {
            M2();
            M1();
        }
    }
}
