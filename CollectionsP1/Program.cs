using System;
using System.Collections;

namespace CollectionsP1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            Console.WriteLine(arr.Capacity);
            arr.Add(100);
            Console.WriteLine(arr.Capacity);
            arr.Add(200); arr.Add(300); arr.Add(400); arr.Add(500);
            Console.WriteLine(arr.Capacity);
            arr.Insert(2,250);

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            arr.RemoveAt(1);

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Hello World!");
        }
    }
}
