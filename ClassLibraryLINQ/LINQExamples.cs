using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLINQ
{

    class Emp
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        public string Gender { get; set; }
    }
    public class LINQExamples
    {
        public void Test()
        {
            List<int> obj = new List<int>() { 34, 4, 546, 5, 65, 76, 76, 8, 87, 34, 4, 546, 5, 65, 76, 76, 8, 87 };


            var getunique = (from s in obj select s).Distinct();
            foreach (var item in getunique)
            {
                Console.WriteLine(item);
            }

            var res = from s in obj select s;  // linq Query Syntax
            foreach (var item in res)
            {
                //Console.WriteLine(item);
            }

            Console.WriteLine();

            var result = from s in obj

                         where s >= 50

                         select s;
            foreach (var item in result)
            {
                // Console.WriteLine(item);
            }



            var x2 = obj.Where(x => x >= 100).ToList();  //method

            foreach (var item in x2)
            {
                //Console.WriteLine(item);
            }

            List<object> mydata = new List<object>() { 34, 4, "HI", true, 34.45, "Hello", 'A', "How ru" };
            var myres = mydata.OfType<string>().ToList();

            var myres1 = (from s1 in mydata.OfType<string>() select s1).ToList();
            foreach (var item in myres1)
            {
                //  Console.WriteLine(item);
            }



        }

        public void Test1()
        {
            List<Emp> emps = new List<Emp>() {
            new Emp{ ID=1,Name="Raj",EMail="raj@yahoo.com",Gender="Male"},
            new Emp{ ID=2,Name="Sam",EMail="sam@yahoo.com",Gender="Male"},
            new Emp{ ID=3,Name="Anusha",EMail="Anusha@yahoo.com",Gender="Female"},
            new Emp{ ID=4,Name="Priya",EMail="priya@yahoo.com",Gender="Female"},
            new Emp{ ID=5,Name="Khan",EMail="khan@yahoo.com",Gender="Male"}
            };

            var res = from s in emps select s;
            foreach (var item in res)
            {
                // Console.WriteLine($"Eid is :{item.ID} and Name is:{item.Name} and Email is:{item.EMail} and gender is:{item.Gender}");
            }


            var res3 = from s in emps where s.Gender != "Male" select s;
            foreach (var item in res3)
            {
                Console.WriteLine($"Eid is :{item.ID} and Name is:{item.Name} and Email is:{item.EMail} and gender is:{item.Gender}");
            }


            var res1 = (from s in emps
                        select new Emp
                        {
                            ID = s.ID,
                            Name = s.Name
                        });

            foreach (var item in res1)
            {
                //  Console.WriteLine($"Eid is :{item.ID} and Name is:{item.Name} and Email is:{item.EMail} and gender is:{item.Gender}");
            }
        }


        public void Test2()
        {
            List<int> obj1 = new List<int>() { 23, 34, 45, 46, 56, 7, 67, 78, 79 };
            List<int> obj2 = new List<int>() { 465, 6, 76, 7, 787, 988, 99, 056, 23, 34, 45, 46 };

            var res = (from s in obj1 select s).Union(obj2);
            var res1 = (from s in obj1 select s).Concat(obj2);
            var res2 = (from s in obj1 select s).Intersect(obj2);
            var res3 = (from s in obj1 select s).Except(obj2);
            foreach (var item in res3)
            {
                Console.WriteLine("except Ex:" + item);
            }

        }
        public void Test3()
        {
            List<int> obj = new List<int>() { 23, 34, 45, 46, 56, 7, 67, 78, 79 };
            // Contains all any  --> return a bool based on a condtion

            var res = (from s in obj select s).Contains(23); // false

            var res1 = (from s in obj select s).Any(x => x >= 50);  // true

            var res2 = (from s in obj select s).All(x => x >= 2);  // true

            Console.WriteLine(res2);
        }

        public void Test4()
        {
            List<int> obj = new List<int>() { 23, 34, 45, 46, 56, 7, 67, 78, 79,34,45,46,56 };
            var res = (from s in obj select s).Count();
            var max = (from s in obj select s).Max();
            var min = (from s in obj select s).Min();
            var sum = (from s in obj select s).Sum();
            Console.WriteLine(max);
        }

    }
}
