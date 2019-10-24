using System;

namespace Structure
{
    struct MyStruct
    {
        int i;
        public MyStruct(int x)
        {
            this.i = x;
        }
        public void Display()
        {
            Console.WriteLine("Struct is Called!!" + i);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct my = new MyStruct();
            my.Display();
            MyStruct my1 = new MyStruct(20);
            my1.Display();
            Console.WriteLine("Hello World!");
        }
    }
}
