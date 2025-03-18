using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    internal class CallByVal
    {
        public void Call(ref int y) // passing the value  to this call method
        {
            Console.WriteLine("X before Cal:" + y); // 10
            y = y + 10;
            Console.WriteLine("X after Cal :" + y);  // 20
        }

        public void Exe()
        {
            int x = 10;
            Console.WriteLine("x from Exe  before call:" + x); // 10

            Call(ref x);

            Console.WriteLine("x from exe , after call :" + x); // 20
        }

        public void Calculation(int x, int y , out int Add , out int Sub) {
            // method can also return a multiple using out keyword
            Add = x + y;
            Sub = x - y;
        }
    }
}
