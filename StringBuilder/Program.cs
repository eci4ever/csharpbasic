using System;
using System.Text;
using System.Diagnostics;

namespace StringBuilder1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw1 = new Stopwatch();
            StringBuilder sb = new StringBuilder();
            sw1.Start();
            sb.Append("");
            for (int i = 0; i < 10000; i++)
            {
                sb.Append(i);
            }
            sw1.Stop();
            Console.WriteLine("Time SB elapsed: {0}", sw1.ElapsedMilliseconds);
            //Console.WriteLine(sb);

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            string str = "";
            for (int i = 0; i < 100000; i++)
            {
                str += i;
            }
            sw2.Stop();
            Console.WriteLine("Time STR elapsed: {0}", sw2.ElapsedMilliseconds);
            //Console.WriteLine(str);
            Console.WriteLine("Hello World!");
        }
    }
}
