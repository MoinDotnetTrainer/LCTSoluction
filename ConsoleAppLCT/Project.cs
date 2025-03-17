using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    internal class RBI
    {
        public virtual void Withdraw() {  // multi tasking (overriding)
            Console.WriteLine("Its withdraw details per day From RBI");
        }
        public virtual void Deposite()
        {
            Console.WriteLine("Its Deposite details per day From RBI");
        }
    }


    class ICICI:RBI {
        public override  void Withdraw()
        {  // multi tasking (overriding)
            Console.WriteLine("Its withdraw details per day from icici");
        }
        public  override void Deposite()
        {
            Console.WriteLine("Its Deposite details per day from icici");
        }
    }

    class Axis : RBI
    {
        public override void Withdraw()
        {  // multi tasking (overriding)
            Console.WriteLine("Its withdraw details per day from Axis");
        }
        public override void Deposite()
        {
            Console.WriteLine("Its Deposite details per day from Axis");
        }
    }


}
