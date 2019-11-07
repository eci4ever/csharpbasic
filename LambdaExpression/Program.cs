using System;

namespace LambdaExpression
{
    public delegate string GreetingDelegate(string str);
    public delegate void SayHello();
    class Program
    {
        
        static void Main(string[] args)
        {
            GreetingDelegate obj = (name) => //Using arrow function then remove keyword delegate, datatype for parameter also removed
            {
                return "Hello " + name + ", Good Morning";
            };
            var str = obj.Invoke("nmfairus");
            Console.WriteLine(str);

            SayHello obj2 = () => { Console.WriteLine("Hello Lambda Expression"); };
            obj2.Invoke();
            
            Console.WriteLine("Hello World!");
        }
    }
}
