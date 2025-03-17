using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    internal class ControlStatement
    {
        public void Test()
        {
            // Ctrl Statemets used to chk the cond btwn variables
            // SImple if
            //if else
            //else if
            //nested if else

            int x = -112;
            if (x > 0) // true
            {
                Console.WriteLine("Executing if block as x is grater than 0");
            }

            // if else
            if (x > 0)// when the cond is true
            {
                Console.WriteLine("if Is executing");
            }
            else
            {
                Console.WriteLine("Else will be executing");
            }

            // else if

            int a = 4135, b = 4, c = 456;
            if (a > b && a > c)
            {
                Console.WriteLine("A is Greater");
            }
            else if (b > c && b > a)
            {
                Console.WriteLine("B is Greater");
            }
            else
            {
                Console.WriteLine("C Is Greater");
            }
        }

        public void Login()
        {
            string Email = "xyz@yahoo.com";
            string Password = "123";
            bool status = false;
            string Role = "Admin";


            if (Email == "xyz@yahoo.com" && Password == "1236")
            {
                if (status == true)
                {
                    if (Role == "Admin")
                    {
                        Console.WriteLine("User successfully Logged In");
                    }
                    else
                    {
                        Console.WriteLine("This User Is not Admin");
                    }
                }
                else
                {
                    Console.WriteLine("User Is InActive");
                }
            }
            else
            {
                Console.WriteLine("EmailID or Password is Not correct");
            }

        }


        public void Switch() {
        // Block is exe based on user wish
        a:
            Console.WriteLine("Enter ur Choice!");
            int x= Convert.ToInt32(Console.ReadLine());  // 4

            // Customer care --> 1 2 3 
            // 1 main 2 withdraw 
           
            switch (x)
            {
                case 1:
                    Console.WriteLine("English");
                    break;
                case 2:
                    Console.WriteLine("Hindi");
                    break;
                case 3:
                    Console.WriteLine("Spanish");
                    break;
                case 9:
                    goto a;
                
            }
        }
    }
}
