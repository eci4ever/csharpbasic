using System;

namespace AaChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------------------------
            int foo = 1;
            for(int x =5;x<=50;x++)
            {
                foo *= x;
                for(int y = 1; y <= 5; y++)
                {
                    if(x == y)
                    goto bar;
                    foo *= y;
                }
            }
            bar : Console.WriteLine(foo);
            //---------------------------------------------------------------------
            // var x = Convert.ToInt32(3.7); // Convert.ToInt32() roundup the value
            // var y = (int)3.7; // Casting round down the value
            // Console.WriteLine("value of x is {0} and value of y is {1}", x, y);
            //---------------------------------------------------------------------
            //Console.WriteLine("Hello World!");
        }
    }
}
