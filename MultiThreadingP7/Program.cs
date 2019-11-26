using System;
using System.Threading;
using System.Diagnostics;

namespace MultiThreadingP7
{
    class Program
    {
        public static void IncCounter1()
        {
            long count = 0;
            for (long i = 0; i < 10000000000; i++)
            {
                count++;
            }
            Console.WriteLine("Increment Counter 1: " + count);
        }
        public static void IncCounter2()
        {
            long count = 0;
            for (long i = 0; i < 10000000000; i++)
            {
                count++;
            }
            Console.WriteLine("Increment Counter 2: " + count);
        }
        static void Main(string[] args)
        {
            Stopwatch sw1 = new Stopwatch();
            Stopwatch sw2 = new Stopwatch();
            sw1.Start();
            IncCounter1();
            IncCounter2();
            sw1.Stop();
            Console.WriteLine("TIme taken is : "+ sw1.ElapsedMilliseconds);

            Thread t1 = new Thread(IncCounter1);
            Thread t2 = new Thread(IncCounter2);

            sw2.Stop();
            t1.Start();
            t2.Start();
            sw2.Stop();

            t1.Join();
            t2.Join();

            Console.WriteLine("TIme taken is : "+ sw2.ElapsedMilliseconds);
            Console.WriteLine("Hello World!");
        }
    }
}
