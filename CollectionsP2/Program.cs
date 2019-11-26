using System.Collections;
using System;

namespace CollectionsP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht1 = new Hashtable();
            ht1.Add("name", "Eci4ever");
            ht1.Add("Salary", 3000.50);
            ht1.Add("Dept", "IT System");

            foreach (var item in ht1.Keys)
            {
                Console.WriteLine($"{item} : " + ht1[item]);
            }

            string str1 = "test";
            Console.WriteLine(str1.GetHashCode());
            Console.WriteLine("Hello World!");
        }
    }
}
