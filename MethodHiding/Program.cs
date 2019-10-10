using System;

namespace MethodHiding
{
    class ParentClass
    {
        public virtual void Test1()
        {
            System.Console.WriteLine("Parent tesr one called");
        }
         public void Show1()
        {
            System.Console.WriteLine("Parent show method is called");
        }
    }
    class Program : ParentClass
    {
        public override void Test1()
        {
            System.Console.WriteLine("Child test 1 called");
        }
        public new void Show1()
        {
            System.Console.WriteLine("child show1 is called");
        }
        public void PTest1()
        {
            base.Test1();
        }
        public void PShow1()
        {
            base.Show1();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            ParentClass pl = p;
            pl.Test1();
            pl.Show1();
            // p.Show1();
            // p.Test1();
            // p.PShow1();
            // p.PTest1();
            Console.WriteLine("Hello World!");
        }
    }
}
