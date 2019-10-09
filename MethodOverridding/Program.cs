using System;

namespace MethodOverridding
{
    class ParentClass
    {
        public void Show()
        {
            System.Console.WriteLine("Parent Show Method called");
        }

        public virtual void Test()
        {
            System.Console.WriteLine("Parent Test method is called!!");
        }
    }
    class Program : ParentClass
    {
        public override void Test()
        {
            System.Console.WriteLine("Test Child class is called");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test();
            Console.WriteLine("Hello World!");
        }
    }
}
