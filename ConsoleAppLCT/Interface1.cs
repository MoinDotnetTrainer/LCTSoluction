using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    interface Interface1
    {
        void M1();
        void M2();

    }
    interface Interface2
    {
        void M4();

    }

    class ANotherClass
    {
        public void m3() { }
    }

    class InheritanceInterface : ANotherClass,Interface1,Interface2
    {
        public void M1() { 
        //
        }
        public void M2() { }
        public void M4() { }
    }
}
