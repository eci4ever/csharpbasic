using System;

namespace inheritanceP2
{
    class Program : ParentClass
    {
        public Program(int x) : base(x)
        {
            System.Console.WriteLine("Program constructor is called");
        }
        static void Main(string[] args)
        {
            Program p = new Program(20);
            Console.WriteLine("Hello World!");
        }
    }
}
