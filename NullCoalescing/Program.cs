using System;

namespace NullCoalescing
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = null;
            string str2 = null;
            string str3 = null;
            string str4 = null;
            string str5 = null;

            string final = str1 ?? str2 ?? str3 ?? str4 ?? str5;
            Console.WriteLine(final);
            Console.WriteLine("Hello World!");
        }
    }
}
