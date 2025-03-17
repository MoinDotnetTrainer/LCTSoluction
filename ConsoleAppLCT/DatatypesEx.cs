using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    internal class DatatypesEx
    {
        public void Test()
        {

            // Interger of 1 byte 
            // 1 byte = 8 bits = 0-255
            sbyte x = 23; // SIgned 8 bit
            byte x1 = 255;  // unsigned

            // 2 bytes --> 16bit



            Console.WriteLine("The value of sbyte var is:" + x);
            Console.WriteLine(x1);

            ushort x2 = 65535;
            Console.WriteLine(x2);

            int i = 2147483647;
            Console.WriteLine(i);
            uint i2 = 4294967295;
            Console.WriteLine(i2);

            float f = 34.45f;

            double d = 45.45;

            decimal dm = 45.56m;

            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(dm);

            char c = 'A';
            Console.WriteLine(c);

            bool b = true;

            string str = "Hi hello tesy &^$^$ 6546556 ffryt";
            Console.WriteLine(str);

            string str1 = "765675675658";
            Console.WriteLine(str1);


            // Rules for declaring ur var name

            int a;
            int abc = 45;
            Console.WriteLine(abc);
            int abc334;
            int abc123_;
            int _2334sghh;
            int Age;
            string Email;


            // Not allwed
            //int e er;
            //int 334ffg;
            //int string;
            //int z;



        }
    }
}
