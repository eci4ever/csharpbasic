using System;
using System.Threading;

namespace MultiThreadingP3
{
    class Program
    {
        static void Test(Object max)
        {
            int num = Convert.ToInt32(max);
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Test: "+ i);
            }
            Console.WriteLine("Thread is exiting");
        }
        static void Main(string[] args)
        {
            ParameterizedThreadStart obj = new ParameterizedThreadStart(Test);
            Thread t1 = new Thread(obj);
            //Non type safe method to pass int
            t1.Start(20);
            //Test(30);
            Console.WriteLine("Hello World!");
        }
    }
}
