using System;

namespace Delegate
{
    public delegate void AddDelegate(int x, int y);
    public delegate string SayDelegate(string str);
    class Program
    {
        public void AddNum(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public static string SayHello(string name)
        {
            return $"hello {name}";
        }
        static void Main(string[] args)
        {
            Program pr = new Program();

            AddDelegate ad = new AddDelegate(pr.AddNum);
            ad.Invoke(10,20);
            ad(20,30);
            SayDelegate sd = new SayDelegate(SayHello);
            Console.WriteLine(sd.Invoke("Test"));
            Console.WriteLine(sd("Test2"));
            // pr.AddNum(5,3);
            // Console.WriteLine(SayHello("nmfairus"));
            // Console.WriteLine("Hello World!");
        }
    }
}
