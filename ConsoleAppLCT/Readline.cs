using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    internal class Readline
    {
        public void Test()
        {

            // readline method accept the values from keyboard during runtime execution

            Console.WriteLine("Enter ur Name");
            string Name = Console.ReadLine();  //lHS = RHS
            Console.WriteLine("My Name is :" + Name);





            Console.WriteLine("Enter ur Age");
            int Age = Convert.ToInt32(Console.ReadLine()); //12 --> "12"
            Console.WriteLine("My Age is :" + Age);

             // work and not work
            //  255 more than 255 

            Console.WriteLine("Enter Byte Value");
            byte b =Convert.ToByte( Console.ReadLine());
            Console.WriteLine("Byte val is :"+b);



            // c --> scanf 
            // %d , %f

            // Convertion technique , Converts the value from one type to another


        }
    }
}
