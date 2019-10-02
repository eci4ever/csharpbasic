using System;

namespace varType
{
    class Program
    {
        public Program(int x)
        {
            this.c = x;
        }
        int a = 100;
        static int b = 200;
        const float pi = 3.14f;
        readonly int c;
        static void Main(string[] args)
        {
            Program p = new Program(10);
            
            System.Console.WriteLine(p.a);
            System.Console.WriteLine(b);
            System.Console.WriteLine(p.c);
            System.Console.WriteLine(pi);
            Console.WriteLine("Hello World!");
        }
    }

}
