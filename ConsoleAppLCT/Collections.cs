using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    public class AccentureEmp // Database Table , rows and columns
    {
        public int Eid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int? Age { get; set; }

    }
    internal class Collections
    {

        public void ArrayListEx()
        {
            ArrayList obj = new ArrayList();
            obj.Add(1);
            obj.Add(1.34);
            obj.Add(true);
            obj.Add("test");
            obj.Add(24.34);
            obj.Add("Test");
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
        }
        public void Any()
        {
            List<AccentureEmp> list = new List<AccentureEmp>() {
            new AccentureEmp{ Eid=1,Name="test",Email="test@yahoo.com",Age=23},
             new AccentureEmp{ Eid=2,Name="sam",Email="sam@yahoo.com",Age=32},
              new AccentureEmp{ Eid=3,Name="abc",Email="abc@yahoo.com",Age=12},
               new AccentureEmp{ Eid=4,Name="xyz",Email="xyz@yahoo.com",Age=null},
                new AccentureEmp{ Eid=5,Name="pqr",Email="pqr@yahoo.com",Age=null},
            };

            foreach (var item in list)
            {
                Console.WriteLine("Eid is :" + item.Eid + "--" + "Ename is:" + item.Name);
            }

        }
        public void SorrtedSet()
        {
            SortedSet<string> obj = new SortedSet<string>();
            obj.Add("Hi");
            obj.Add("Hello");
            obj.Add("Test");
            obj.Add("Abc");
            obj.Add("Hi");
            obj.Add("Hi");
            obj.Add("Hello");
            obj.Add("Test");
            obj.Add("Abc");
            obj.Add("Hi");

            foreach (string item in obj)
            {
                Console.WriteLine(item);
            }


        }
        public void Hashsetex()
        {
            HashSet<string> obj = new HashSet<string>();
            obj.Add("Hi");
            obj.Add("Hello");
            obj.Add("Test");
            obj.Add("Abc");
            obj.Add("Hi");
            obj.Add("Hi");
            obj.Add("Hello");
            obj.Add("Test");
            obj.Add("Abc");
            obj.Add("Hi");

            foreach (string item in obj)
            {
                Console.WriteLine(item);
            }


        }
        public void ListEx()
        {
            List<int> list = new List<int>();
            list.Add(12);
            list.Add(45);
            list.Add(1242);
            list.Add(43);
            list.Add(1242);
            list.Add(43);
            list.Remove(45);  // element Name
            list.RemoveAt(0); // index of the elemnet
            list.Insert(0, 100);

            for (int i = 0; i < list.Count; i++)
            {
                // Console.WriteLine(list[i]);
            }

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            // looping statement for while do foreach


            // here the len is dynamic

            List<string> strings = new List<string>();
            strings.Add("Hi");
        }
    }
}
