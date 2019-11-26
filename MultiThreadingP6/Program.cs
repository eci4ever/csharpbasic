using System;
using System.Threading;

namespace MultiThreadingP6
{
    class Program
    {
        static long counter1, counter2;
        static void IncCounter1()
        {
            while(true)
            {
                counter1++;
            }
        }
        static void IncCounter2()
        {
            while(true)
            {
                counter2++;
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(IncCounter1);
            Thread t2 = new Thread(IncCounter2);

            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;

            t1.Start(); t2.Start();
            Thread.Sleep(5000);
            //Thread.Abort is depreceted in .Net Core
            t1.Abort(); 
            t2.Abort();

            t1.Join(); 
            t2.Join();
            
            Console.WriteLine($"Counter 1: {counter1}");
            Console.WriteLine($"Counter 2: {counter2}");

        }
    }
}
