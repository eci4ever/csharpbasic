using System;

namespace OperatorOverloading
{
    class Matrix 
    {
        int a, b, c, d;
        public Matrix(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public static Matrix operator + (Matrix obj1, Matrix obj2)
        {
            Matrix obj = new Matrix(obj1.a + obj2.a, obj1.b + obj2.b, obj1.c + obj2.c, obj1.d + obj2.d);
            return obj;
        }
        public static Matrix operator - (Matrix obj1, Matrix obj2)
        {
            Matrix obj = new Matrix(obj1.a - obj2.a, obj1.b - obj2.b, obj1.c - obj2.c, obj1.d - obj2.d);
            return obj;
        }

        public override string ToString() // Override ToString method so that the matrix can be display correcty 2x2
        {
            return a + " " + b + "\n" + c + " " + d + "\n";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(5,10,8,3);
            Matrix m2 = new Matrix(3,2,1,6);
            Matrix m3 = m1 + m2;
            Matrix m4 = m1 - m2;
            System.Console.WriteLine(m1);
            System.Console.WriteLine(m2);
            System.Console.WriteLine(m3);
            System.Console.WriteLine(m4);
            //Console.WriteLine("Hello World!");
        }
    }
}
