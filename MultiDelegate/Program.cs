using System;

namespace MultiDelegate
{
    public delegate void RectDelegate(int a, int b);
    class RectClass
    {
        public void GetArea(int a , int b)
        {
            Console.WriteLine($"Area is : {a * b}");
        }
        public void GetPerimeter(int a, int b)
        {
            Console.WriteLine($"Perimeter is : {2 * a * b}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RectClass rc = new RectClass();
            RectDelegate rd = new RectDelegate(rc.GetArea);
            rd += rc.GetPerimeter;

            rd.Invoke(5,4);
            // rc.GetArea(4,5);
            // rc.GetPerimeter(4,5);
            Console.WriteLine("Hello World!");
        }
    }
}
