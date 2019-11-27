using System;

namespace CollectionsP4a
{
    class Program
    {
        public static bool Compare<T>(T a, T b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            var a = Compare<int>(10,10);
            Console.WriteLine(a);
        }
    }
}
