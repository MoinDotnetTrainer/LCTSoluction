using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    internal class Var
    {
        public void Test()
        {
            // other categories of Datatypes
            // var dynamic and object


            // compile
            var v1 = 45; // interger

            v1 = 67;
            //v1 = true;

            var v2 = true;  // bool
            v2 = false;
          //  v2 = 45;
            var v3 = "test"; // string
            var v4 = 45.5; // float
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);
            Console.WriteLine(v4);


            // runtime
            dynamic d1 = 45;


            dynamic d2 = true;
            dynamic d3 = "test";
            dynamic d4 = 45.5;

            dynamic res = d1 + d4;


            //runtime
            object o1 = 45;

            object o2 = true;
            object o3 = "test";
            object o4 = 45.5;

          //  object result = o1 + o4;

            // object --> Assigment 


            // value type  --> lenth is fixed  byte sbyte int long double decimal 
            // ref type --> not fixed --> string arrays object 

            // Task 1 Var dynamic and object comes under which category , value or ref


        }
    }
}
