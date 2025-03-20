using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLINQ
{

 
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Branch { get; set; }

    }

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
            List<int> obj = new List<int>() { 23, 34, 45, 46, 56, 7, 67, 78, 79, 34, 45, 46, 56 };
            var res = (from s in obj select s).Count();
            var max = (from s in obj select s).Max();
            var min = (from s in obj select s).Min();
            var sum = (from s in obj select s).Sum();
            Console.WriteLine(max);
        }


        public void Test5()
        {
            List<int> obj = new List<int>() { 12, 23, 22, 33, 10, 34, 35, 45, 45, 46, 56, 56, 57, 67, 34, 4, 54 };

            List<int> obj1 = new List<int>() { 12, 23, 22, 56, 33, 10, 34, 35, 45, 45, 46, 56, 56, 57, 67, 34, 4, 54 };


            var seq = (from s in obj select s).SequenceEqual(obj1);
            Console.WriteLine(seq);


            //elements from the source

            // elementat

            //   var res = (from s in obj select s).ElementAt(300);

            //var res1 = (from s in obj select s).ElementAtOrDefault(400);

            //var res2 = (from s in obj select s).First(x => x >= 50);

            //var res3 = (from s in obj select s).LastOrDefault();

            //var res4 = (from s in obj select s).Single(x => x >= 45);

            var res5 = (from s in obj select s).SingleOrDefault(x => x >= 100);

            var res6 = (from s in obj select s).Take(5);

            var res7 = (from s in obj select s).TakeWhile(x => x <= 25);

            var res8 = (from s in obj select s).Skip(5);

            var res9 = (from s in obj select s).SkipWhile(x => x <= 25);

            var ArrayReversedData = (from num in obj
                                     select num).Reverse();

            foreach (var item in ArrayReversedData)
            {
                //Console.WriteLine(item);
            }
        }

        public void OrderbyEx()
        {
            List<Student> listStudents = new List<Student>()
            {
                new Student{ID= 101,FirstName = "Preety",LastName = "Tiwary",Branch = "CSE"},
                new Student{ID= 102,FirstName = "Preety",LastName = "Agrawal",Branch = "ETC"},
                new Student{ID= 103,FirstName = "Priyanka",LastName = "Dewangan",Branch = "ETC"},
                new Student{ID= 104,FirstName = "Hina",LastName = "Sharma",Branch = "ETC"},
                new Student{ID= 105,FirstName = "Anugrag",LastName = "Mohanty",Branch = "CSE"},
                new Student{ID= 106,FirstName = "Anurag",LastName = "Sharma",Branch = "CSE"},
                new Student{ID= 107,FirstName = "Pranaya",LastName = "Kumar",Branch = "CSE"},
                new Student{ID= 108,FirstName = "Manoj",LastName = "Kumar",Branch = "ETC"},
                new Student{ID= 109,FirstName = "Pranaya",LastName = "Rout",Branch = "ETC"},
                new Student{ID= 110,FirstName = "Saurav",LastName = "Rout",Branch = "CSE"}
            };

            // group key and value pair

            var group = (from s in listStudents group s by s.Branch); // key

            foreach (var item in group)
            {
                // Console.WriteLine(item.Key);// key will be printed

                foreach (var data in item)
                {
                    //Console.WriteLine($"FirstName is {data.FirstName} , last name is {data.LastName}");
                }
            }

            var GroupByQS = (from std in listStudents
                             select std).ToLookup(x => x.Branch);
            foreach (var item in GroupByQS)
            {
                Console.WriteLine(item.Key);// key will be printed

                foreach (var data in item)
                {
                    Console.WriteLine($"FirstName is {data.FirstName} , last name is {data.LastName} and branch {data.Branch}");
                }
            }


            var res = (from s in listStudents orderby s.FirstName descending select s).ToList();


            var MS = listStudents
                .OrderBy(x => x.FirstName)
                .ThenByDescending(y => y.LastName)
                .ToList();
            foreach (var item in MS)
            {
                //  Console.WriteLine($"FirstName is {item.FirstName} , last name is {item.LastName}");
            }

        }

       
    }
}
