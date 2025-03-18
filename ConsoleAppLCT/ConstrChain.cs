using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{

    partial class Products
    {
        public void Production() { }
    }
    internal class ConstrChain
    {
        public ConstrChain()
        {
            Console.WriteLine("Defauly const");
        }

        public ConstrChain(int x) : this()
        {
            Console.WriteLine("pM int  const");
        }

        public ConstrChain(string x) : this(23)
        {
            Console.WriteLine("pM string  const");
        }
    }

    class ConstrChain2 : ConstrChain
    {
        public ConstrChain2() : base(34)
        {
            Console.WriteLine("def from chld class");
        }
    }
}
