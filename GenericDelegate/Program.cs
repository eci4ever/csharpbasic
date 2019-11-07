using System;

namespace GenericDelegate
{
    class Program
    {
        public static double Add1(int x, float y, double z)
        {
            return x * y * z;
        }
        public static void Add2(int x, float y, double z)
        {
            Console.WriteLine(x * y * z);
        }
        public static bool CheckLenght(string str)
        {
            return (str.Length > 5)?true:false;
        }
        static void Main(string[] args)
        {
            Func<int,float,double,double> obj = Add1;
            double result1 = obj.Invoke(2,4.2f,5.1);
            Console.WriteLine(result1);
            Action<int,float,double> obj2 = Add2;
            obj2.Invoke(2,4.2f,5.1);
            Predicate<string> obj3 = CheckLenght;
            bool result2 = obj3.Invoke("Hello");
            Console.WriteLine(result2);
            Console.WriteLine("Hello World!");
        }
    }
}
