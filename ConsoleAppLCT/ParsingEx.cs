using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    internal class ParsingEx
    {
        public void Test()
        {
            Console.WriteLine("Enter Ur Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age is:" + age);

            Console.WriteLine("Enter Ur Salary");
            float Salary = Convert.ToSingle(Console.ReadLine()); // convertion
            Console.WriteLine("Salary is:" + Salary);

            Console.WriteLine("Enter Ur Age");
            byte age1 = byte.Parse(Console.ReadLine());  // parsing 
            Console.WriteLine("Age is:" + age1);

            Console.WriteLine("Enter Ur Salary");
            float Salary1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Salary is:" + Salary1);




            //Convertion Accepts Null value 

            string str = null;
            int x = Convert.ToInt32(str);
            Console.WriteLine(x);  // 0 of type int


            // Parsing will not accept null value while parsing
            string str1 = null;
            int x1 = int.Parse(str1);
            Console.WriteLine(x1);  // get runtime



        }
    }
}
