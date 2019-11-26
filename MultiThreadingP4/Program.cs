using System;
using System.Threading;

namespace MultiThreadingP4
{
    class Program
    {
        static void Test1()
        {
            Console.WriteLine("Thread 1 is starting");
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Test1: {i}");
            }
            Console.WriteLine("Thread 1 is ending");
        }
        static void Test2()
        {
            Console.WriteLine("Thread 2 is starting");
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Test2: {i}");
            }
            Console.WriteLine("Thread 2 is ending");
        }
        static void Test3()
        {
            Console.WriteLine("Thread 3 is starting");
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Test3: {i}");
            }
            Console.WriteLine("Thread 3 is ending");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread is started");
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            //Starting thread
            t1.Start(); t2.Start(); t3.Start();
            //To make Main thread to wait until program ended
            //Use Join() method
            t1.Join(); t2.Join(); t3.Join(1000);
            //Join method can be overloaded, we can pass timeout parameter in miliseconds
            Console.WriteLine("Main thread is Ended");

        }
    }
}
