using System;
using System.Threading;

// Demonstrate thread locking 
namespace MultiThreadingP5
{
    class Program
    {
        //to make only one thread can access this code at one time
        //we use thread locking
        public void Display()
        {
            lock(this)
            {
            Console.Write("[Csharp is an ");
            Thread.Sleep(2000);
            Console.WriteLine("an object oriented language]");
            }
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Thread t1 = new Thread(p1.Display);
            Thread t2 = new Thread(p1.Display);
            Thread t3 = new Thread(p1.Display);
            t1.Start(); t2.Start(); t3.Start();
            // t1.Join();
            // Console.WriteLine("Hello World!");
        }
    }
}
