using System.ComponentModel;
using System.Net.WebSockets; // namespace predefine 
using ClassLibrary1;// user define


namespace ConsoleAppLCT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello, World from Program .cs!");

            Demo obj = new Demo();
            obj.Test();

            Sample anyname = new Sample();
            anyname.Test();
            */




            //DatatypesEx x1 = new DatatypesEx();
            //x1.Test();


            // Var obj = new Var();
            // obj.Test();

            // Readline obj = new Readline();
            //obj.Test();


            // Nullables obj = new Nullables();
            // obj.Test();



            // Arrays obj = new Arrays();
            // obj.Test();

            // ControlStatement obj = new ControlStatement();
            // obj.Switch();

            // Looping obj = new Looping();
            // obj.Foreach();

            /* ClassExample obj = new ClassExample();
             obj.Add();
             int final = obj.Sub();
             if (final == 0)
             {
                 Console.WriteLine("do this");
             }
             else
             {
                 Console.WriteLine("some other task");
             }
             obj.Mul(23, 34);
             obj.Div(45, 45);
            */

            //  MethodOverLoading obj = new MethodOverLoading();
            // obj.M1(12);

            /* Emp obj = new Emp();
             obj.Add();
             obj.Sub();
             obj.Mul();
             obj.Div(y: 2, x: 12);
             obj.EvenNumbers(1, 34);
             obj.Numbers("Given numbers are:" + 23, 34, 54, 56);
             obj.Numbers("Given numbers are:");
             obj.M1(2);
            */

            /* Emp2 obj = new Emp2();
             obj.M1();
             int res = obj.M2();
             if (res == 0)
             {
                 Console.WriteLine("if block");
             }
             else
             {
                 Console.WriteLine("else");
             }

             (string res1, int res2) = obj.M4();
             Console.WriteLine(res1);
             Console.WriteLine(res2);
            */

            /*StaticMethod obj = new StaticMethod();
            obj.M1();
            StaticMethod.M2();
            StaticMethod.M3();
            */

            //Project.M1();
            //Project.M2();
            //Project.M3();


            /* ConstrExample obj = new ConstrExample(); // object 
             obj.M1();
             ConstrExample.M2();
            */

            // OverLoading obj = new OverLoading();
            // obj.M1("hi");

            //   ConstrOverloading obj = new ConstrOverloading(34,56);


            /* Parent p = new Parent();
           //  p.Add();
            // p.Sub();

             Child c = new Child();
             c.Mul();
             c.Div();

             c.Add();
             c.Sub();
            */

            //RBI obj = new RBI();
            //obj.Withdraw();
            //obj.Deposite();

            //ICICI obj1 = new ICICI();
            //obj1.Withdraw();
            //obj1.Deposite();


            //Vehicle.M2();

            //ConstrChain obj = new ConstrChain("hi");


            //ConstrChain2 obj= new ConstrChain2();

            //Products obj1 = new Products();
            //obj1.Sales();
            //obj1.Production();

            //CallByVal obj = new CallByVal();
            //obj.Exe();

            //// obj.Calculation(12,2,out int add , out int sub);
            //Console.WriteLine(add);
            //Console.WriteLine(sub);

            //Dept obj = new Dept();
            //obj.DeptEmp();
            //obj.DeptSalary();
            //obj.Add(12,3);

            // ExceptionHandling obj = new ExceptionHandling();
            // obj.Div();

            //  Operations obj = new Operations();
            // obj.Add();



            try
            {
                Prop obj1 = new Prop();
                obj1.x_ = 45;
                obj1.y_ = 55;

                //max 100
                //50 50
                obj1.Add();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
