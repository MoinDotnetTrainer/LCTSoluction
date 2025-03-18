using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    static class Addextra
    {
        public static void DeptSalary(this Dept obj)
        {
            Console.WriteLine("this is salary method , extended method");
        }

        public static void Add(this Dept obj,int x , int y)
        {
            int z = x + y;
            Console.WriteLine(z);
        }
    }
}
