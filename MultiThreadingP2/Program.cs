using System;
using System.Threading;

namespace MultiThreadingP2
{
    class Program
    {
        static void Test1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test1 : "+ i);
            }
            Console.WriteLine("Thread 1 is exiting");
        }
        static void Test2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test2 : "+ i);
                if (i == 20)
                {
                    Console.WriteLine("Thread 2 Sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread started");
                }
            }
            Console.WriteLine("Thread 2 is exiting");
        }
        static void Test3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test3 : "+ i);
            }
            Console.WriteLine("Thread 3 is exiting");
        }
        static void Main(string[] args)
        {
            // Thread T1 = new Thread(Test1);
            // Thread T2 = new Thread(Test2);
            // Thread T3 = new Thread(Test3);
            // T1.Start(); T2.Start(); T3.Start();
            //
            //ThreadStart is a delegate
            //ThreadStart obj = new ThreadStart(Test1);
            //ThreadStart obj = Test3;
            //ThreadStart obj = delegate () { Test2(); };
            ThreadStart obj = () => Test1();
            Thread t1 = new Thread(obj);
            t1.Start();
            Console.WriteLine("Main thread Exiting");
        }
    }
}
