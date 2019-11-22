using System;
using System.Threading;

namespace MultiThreadingP1
{
    class Program
    {
        static void Test1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Test1 {i}");
            }
        }
        static void Test2()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 50)
                {
                    Console.WriteLine("Thread Sleep");
                    Thread.Sleep(5000);
                }
                Console.WriteLine($"Test2 {i}");
            }
        }
        static void Test3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Test3 {i}");
            }
        }
        static void Main(string[] args)
        {
            Test1();
            Test2();
            Test3();
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine($"Current thread is {Thread.CurrentThread.Name}");
        }
    }
}
