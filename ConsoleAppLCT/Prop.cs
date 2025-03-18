using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    internal class Prop
    {
        // key concpt hold and traneferring the data

        // sensetive data

        //public 

        //default scoope of var

        private int x;

        public int x_
        {
            get { return x; }
            set {
                if (value > 50)
                {
                    throw new ArgumentOutOfRangeException("Value is more than 50");
                }
                else
                {
                    x = value;
                }
            }
        }

        private int y;

        public int y_
        {
            get { return y; }
            set {

                if (value > 50)
                {
                    throw new ArgumentOutOfRangeException("Value is more than 50");
                }
                else
                {
                    y = value;
                }
            }
        }


        public void Add() {
            int z = x + y;
            Console.WriteLine("Add is:"+z);
        }

    }
}
