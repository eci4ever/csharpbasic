using System;

namespace inheritanceP1
{
    class Class2 : Class1
    {
        public void Test3()
        {
            System.Console.WriteLine("Test3 called");
        }
        static void Main(string[] args)
        {
            Class2 c2 = new Class2();
            //c2.Test1(); c2.Test1() can't be called because dont have public access specifier
            c2.Test2();
            c2.Test3();
            Console.WriteLine("Hello World!");
        }
    }
}
