using System;

namespace LearnInterface
{
    class Program
    {
        class ImpGreeting : IGreeting, INama
        {
            public void Greet()
            {
                Console.WriteLine("Selamat Datang");
            }

            public void InputName(string name)
            {
                Console.WriteLine("Welcome {0}", name);
            }
        }
        static void Main(string[] args)
        {
            ImpGreeting imp = new ImpGreeting();
            imp.Greet();
            imp.InputName("nmfairus");
            System.Console.WriteLine("Test");
            //Console.WriteLine("Hello World!");
        }
    }
}
