using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    class ExceptionHandling
    {

        // two types of Error 
        // compile --> syntax 
        // runtime --> unepectdly

        public void Div()
        {
        a:
            try
            {
                Console.WriteLine("Enter X:");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Y:");
                int y = int.Parse(Console.ReadLine());

                int z = x / y;
                Console.WriteLine("Div is :" + z);

                int[] arr = { 23, 3 };
                Console.WriteLine(arr[10]);//
            }

            
            catch (FormatException e)
            {
                Console.WriteLine("Plz Enter Only Numbers:" + e.Message);
                goto a;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Y cannot be zero:" + e.Message);
                goto a;
            }
            catch (Exception e)
            {
                Console.WriteLine("Index out of Bound:" + e.Message);
            }
        }
    }
}
