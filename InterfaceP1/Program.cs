using System;

namespace InterfaceP1
{
    interface ITest1
    {
        void Add(int a, int b);
        void Show();
    }

    interface ITest2
    {
        void Sub(int a, int b);
        void Show();
    }

    class Program : ITest1, ITest2
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        // Implicitly implementing show method
        // public void Show()
        // {
        //     Console.WriteLine("Show Called ");
        // }

        // Explicitly impleminting Show() method
        void ITest1.Show()
        {
            Console.WriteLine("Show from Iface 1");
        }
        void ITest2.Show()
        {
            Console.WriteLine("Show from Iface 2");
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Add(10,15);
            obj.Sub(10,5);
            ITest1 i1 = obj;
            ITest2 i2 = obj;
            i1.Show();
            i2.Show();
            // Calling Show() method from object reference
            Console.WriteLine("Hello World!");
        }
    }
}
