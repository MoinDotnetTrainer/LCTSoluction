using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    internal class Nullables
    {
        public void Test()
        {
            /*
            //what is a nullable


            // No error, ref type
            string str = null;


            // no null value directly , value type

            // x as nullable , so that we can add nll value to avlue
            int? x = null;

            Nullable<float> f = null;


            // boxing and Unboxing

            // Converting a var from value to ref type
            // vice versa --> ref to value unboxing

            int x1 = 34;
            string str1 = x1.ToString();  // boxing
            Console.WriteLine(str1);
            int x2 = Convert.ToInt32(str1);  // unboxing

            // implict casting & explict Casting

            //lower to higher --> implict auto

            byte b1 = 23;
            int b2 = b1; // implict auto

            */

            int x4 = 656565;
            byte b3 = (byte)x4;  //explict manualyy
            Console.WriteLine(b3);

            // try this 
            // Logic
        }
    }
}
