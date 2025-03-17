using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    abstract class Vehicle {
        public abstract void Break();  // this method is used to stop the vehivle
        public abstract void Accelerate();  // this is used to moving spped

        public void M1() { }  // object Vehcile , child
        public static void M2() { }  // Vehicle class name
        public virtual void M3() { }  // override or Obj Vehicle , child
        public Vehicle() { }  // Create an object Vehicle , child
    }

    class Pulsar : Vehicle
    {
        public override void Break()
        {
            Console.WriteLine("this define for Pulsar");
        }
        public override void Accelerate()
        {
            Console.WriteLine("this acc for Pulsar");
        }
    }

    class BMW : Vehicle
    {
        public override void Break()
        {
            Console.WriteLine("this define for BMW");
        }
        public override void Accelerate()
        {
            Console.WriteLine("this acc for BMW");
        }
    }
}
