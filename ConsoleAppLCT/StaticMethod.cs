using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    class StaticMethod
    {
        public void M1()
        { // non static , exe thtw object
            Console.WriteLine("Task 1");
        }
        public static void M2()  // exe thrw class name
        {
            // any logic
            Console.WriteLine("Task 2");
        }
        public static void M3()
        {
            Console.WriteLine("Task 3");
        }
    }


    static class Project
    {
        public static void M1()
        {  // class name

        }
        public static void M2()  // class name
        {

        }
        public static void M3()  // error ,  Object 
        {

        }
    }

    class ConstrExample
    {
        public  ConstrExample() { // auto, when a class has been initiated
            Console.WriteLine("Constr");
        }
        public void M1() // object
        {
            Console.WriteLine(" Non static M1");
        }
        public static void M2() // class name
        {
            Console.WriteLine("Static M2 ");
        }
    }

}
