using System;
using System.Collections.Generic;

namespace CollectionsP3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(400); li.Add(500);
            li.Add(100); li.Add(200); li.Add(300);
            li.Sort();

            foreach (var item in li)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
