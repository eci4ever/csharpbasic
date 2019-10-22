using System;

namespace AbstractImplement
{
    class Program
    {
        static void Main(string[] args)
        {
            AbsChild c = new AbsChild();
            c.Add(20,10);
            c.Sub(20,10);
            c.Mul(20,10);
            c.Div(20,10);
            AbsParent p = c; // Parent class instance is reference to Child object
            p.Add(5,2);
            p.Sub(5,2);
            p.Mul(5,2); // Parent object can call method in child class because the method is not purely child method
            p.Div(5,2);
            Console.WriteLine("Hello World!");
        }
    }
}
