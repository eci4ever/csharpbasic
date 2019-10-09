using System;

namespace MethodOverloading
{
    class Program
    {
        public void Test()
        {
            System.Console.WriteLine("1st Method Called");
        }

        public void Test(int i)
        {
            System.Console.WriteLine("2nd Method Called");
        }

        public void Test(string s)
        {
            System.Console.WriteLine("3rd Method Called");
        }

        public void Test(int i, string s)
        {
            System.Console.WriteLine("4th Method Called");
        }

        public void Test(string s, int i)
        {
            System.Console.WriteLine("5th Method Called");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test();
            Console.WriteLine("Hello World!");
        }
    }
}
