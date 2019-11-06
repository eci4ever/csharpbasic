using System;

namespace AnonMethod
{
    public delegate string GreetingDelegate(string str);
    class Program
    {
        static void Main(string[] args)
        {
            GreetingDelegate obj = delegate(string name)
            {
                return "Hello " + name + ", Good Morning";
            };

            var str = obj.Invoke("eci");
            Console.WriteLine(str);
            Console.WriteLine("Hello World!");
        }
    }
}
