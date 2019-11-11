using System;

namespace ExtMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            SealClass sc = new SealClass();
            sc.Test1(); sc.Test2();sc.Test3();

            int i = 5;
            var facti = i.Factorial();
            Console.WriteLine(facti);

            string str = "sElamat daTanG kE mElAka";
            str.toProper();
            Console.WriteLine(str);
            Console.WriteLine("Hello World!");
        }
    }
}
