using System;
using System.Collections.Generic;
namespace CollectionsP5a
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> dt = new Dictionary<string,object>();

            dt.Add("name", "Eci4ever");
            dt.Add("Salary", 3000.50);
            dt.Add("Dept", "IT System");

            foreach (var item in dt.Keys)
            {
                Console.WriteLine(item + " : " + dt[item]);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
