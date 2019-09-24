using System;

namespace constructor1
{
    class Program
    {
        int a = 2; string b=null; bool c=true;
        static void Main(string[] args)
        {
            Program p = new Program();
            System.Console.WriteLine(p.a);
            System.Console.WriteLine(p.b);
            System.Console.WriteLine(p.c);
            //
            Console.WriteLine("Hello World!");
        }
    }
}
