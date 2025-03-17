using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    internal class Looping
    {

        // will be exe the block of code multiple times , as per the cond
        /*
         * for loop
         * while 
         * do while
         * foreach
         * */

        /*
         * 
         * for(var ini ; cond ; incr ){
         * -- code
         * }
         * 
         * chk flow of program exe
         * */
        public void ForLoop()
        {
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("some code");
            }// if the cond is false , skipped

            int[] arr = { 34, 4, 56, 56, 7, 67, 8, 78, 78, 7, 98, 9, 090, 9, 0, 3, 545, 45, 4, 46 };
            for (int x = 0; x < arr.Length; x++)
            {
                Console.WriteLine(arr[x]);
            }



        }

        public void While()
        {
            int x = 0;
            while (x > 10)
            {
                Console.WriteLine("While");
                x++;
            }

            int[] arr = { 34, 34, 45, 45, 56, 5, 6, 76, 7 };

            int i = 0;
            while (i < arr.Length)
            {
                Console.WriteLine(arr[i]);
                i++;
            }
        }

        public void Dowhile()
        {
            int x = 0;
            do
            {
                Console.WriteLine("Do while");
                x++;
            }
            while (x > 10);
        }

        public void Foreach()
        {

            int[] arr = { 34, 4, 56, 56, 7, 67, 8, 78, 78, 7, 98, 9, 090, 9, 0, 3, 545, 45, 4, 46 };
            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine("for loop:" + arr[x]);
            }

            // list  dynmaic elemets can be added , no lenth
            //arrays lenth is known

            foreach (int x in arr)
            {
                Console.WriteLine("foreach:" + x);
            }
        }
    }
}
