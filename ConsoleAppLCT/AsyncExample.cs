using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLCT
{
    internal class AsyncExample
    {
        public int GetData(string FileName)
        {
            int length = 0;
            using (StreamReader reader = new StreamReader(FileName))
            {
                string res = reader.ReadToEnd();  // content
                length = res.Length;
                Task.Delay(4000).Wait();
            }
            return length;
        }

        public void Call()
        {
            string FileName = "C:\\Users\\m.a.khaja.moinuddin\\OneDrive - Accenture\\Desktop\\notes.txt";
            int lenth = GetData(FileName);

            Console.WriteLine("Task 1");
            Console.WriteLine("Task 2");
            Console.WriteLine("Task 3");
            Console.WriteLine("No of Words:" + lenth);
            Console.WriteLine("Task 4");
            Console.WriteLine("Task 5");
            Console.WriteLine("Task 6");

            // 7 events 
        }

        public async Task<int> GetData1(string FileName)
        {
            int length = 0;
            using (StreamReader reader = new StreamReader(FileName))
            {
                string res = await reader.ReadToEndAsync();  // content
                length = res.Length;
                Task.Delay(4000).Wait();
            }
            return length;
        }

        public async void Call1()
        {
            string FileName = "C:\\Users\\m.a.khaja.moinuddin\\OneDrive - Accenture\\Desktop\\notes.txt";
            Task<int> tk = GetData1(FileName);

            Console.WriteLine("Task 1");// await
            Console.WriteLine("Task 2"); //
            Console.WriteLine("Task 3");
            int finalfres = await tk;
            Console.WriteLine("No of Words:" + finalfres);
            Console.WriteLine("Task 4");
            Console.WriteLine("Task 5");
            Console.WriteLine("Task 6");

            // 7 events 
        }
    }
}
