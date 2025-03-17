using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    internal class Arrays
    {
        public void Test()
        {
            int x = 45;
            Console.WriteLine(x);  // 45

            // Index --> 0 

            int[] arr = { 2, 3, 45, 65, 66, 76, 78, 78, 8989,35,45,46,56,56 };

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);

            string[] str = { "Test", "xyz", "abc", "Pqr" };

            Console.WriteLine(str[3]);

            object[] obj = { 12, "Test", true, 34.45, 'A' };
            Console.WriteLine(obj[2]);

            int[] x1 = new int[5] {21,3,45,56,6 };
        }
    }
}
