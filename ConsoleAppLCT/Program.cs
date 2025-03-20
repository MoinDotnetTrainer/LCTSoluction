using System.ComponentModel;
using System.Net.WebSockets; // namespace predefine 
using ClassLibrary1;
using ClassLibrary3;// user define
using ClassLibraryLINQ;



namespace ConsoleAppLCT
{
    public class Students
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)// single Thread , Main thread
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



            /*  try
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
            */

            /*  Class2 obj = new Class2();
               obj.Test();
               obj.test2();
               obj.Test3();
            */



            /*  DelExample obj = new DelExample();


               Cal1 del = new Cal1(obj.Add);
               del();

               Cal1 del1 = new Cal1(obj.Sub);
               del1();  // single


               Cal2 c2 = new Cal2(obj.Mul);
               c2 += new Cal2(obj.Div);
               c2(23,3); // multi cast
            */

            /*   GenEx obj = new GenEx();
               obj.Add(12,34);
               obj.UserDetails<int , int>(12,23);
               obj.UserDetails<int, string>(12,"Hi");
               obj.UserDetails<string,string>("","");
               obj.UserDetails<int>(23);

               GenClass<int , int > obj1 = new GenClass<int, int >();
               obj1.M1(22,34);

               GenClass<int, string> obj2 = new GenClass<int, string>();
               obj2.M1(22, "34");
            */

            /* Collections c = new Collections();
             c.ListEx();
             Console.WriteLine("hashset starts here");
             c.Hashsetex();
             Console.WriteLine("sorted set starts here");
             c.SorrtedSet();

             Console.WriteLine("any");
             c.Any();
             Console.WriteLine();
             c.ArrayListEx();
            */

            /*  Multi obj = new Multi();

              Thread t1 = new Thread(obj.M1);
              t1.Start();

              Thread t2 = new Thread(obj.M2);
              t2.Start();
            */

            /* AsyncExample obj = new AsyncExample();
             Task t = new Task(obj.Call1);
             t.Start();
             t.Wait();
             Console.ReadKey();

             */
            List<Students> students_ = new List<Students>()
 {
     new Students { ID = 101, Name = "Preety", Age = 22 },
     new Students { ID = 102, Name = "Sambit", Age = 60 },
     new Students { ID = 103, Name = "Hina", Age = 55 },
     new Students { ID = 104, Name = "Anurag", Age = 24 },
     new Students { ID = 101, Name = "Preety", Age = 22 },
     new Students { ID = 102, Name = "Sambit", Age = 23 },
     new Students { ID = 103, Name = "Hina", Age = 26 },
     new Students { ID = 102, Name = "Sambit", Age = 25 },
     new Students { ID = 103, Name = "Hina", Age = 30 },
     new Students { ID = 101, Name = "Preety", Age = 22 },
     new Students { ID = 100, Name = "Anurag", Age = 24 }
 };

            

            var res = (from s in students_ where s.Age >= 25 select s);//no of 5

            var res1 = (from s in students_ where s.Age >= 25 select s).Count();//5, s e

            students_.Add(new Students { ID = 200, Name = "xyz", Age = 35 });


            foreach (var item in res)// at this
            {
                Console.WriteLine($"FirstName is {item.Name} , last name is {item.Age}");// 6
            }

            Console.WriteLine("No of Students:" + res1); // 5


        }


    }
}
