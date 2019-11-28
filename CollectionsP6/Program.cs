using System;
using System.Collections.Generic;

namespace CollectionsP6
{
    class Program
    {
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Class { get; set; }
            public float Mark { get; set; }
        }
        static void Main(string[] args)
        {
            Student s1 = new Student() { Id = 103, Name = "Saiful", Class = "F01", Mark = 88.5f };
            Student s2 = new Student() { Id = 101, Name = "Amar", Class = "F01", Mark = 74.5f };
            Student s3 = new Student() { Id = 105, Name = "Danish", Class = "F01", Mark = 90.5f };
            Student s4 = new Student() { Id = 104, Name = "Mariam", Class = "F01", Mark = 95.5f };
            Student s5 = new Student() { Id = 102, Name = "Siti", Class = "F01", Mark = 77.5f };

            List<Student> students = new List<Student>() { s1, s2, s3, s4, s5 };

            //students.Sort((s1,s2) => s1.Id.CompareTo(s2.Id)); Sort by ID using comparison delegate
            students.Sort((s1,s2) => s1.Name.CompareTo(s2.Name));

            foreach (var item in students)
            {
                Console.WriteLine($"{item.Id} | {item.Name} | {item.Class} | {item.Mark}");
            }


            int[] myArr = {20, 10, 5, 50 , 30, 40 };
            List<int> listInt = new List<int>();
            listInt.AddRange(myArr);
            listInt.Sort();
            foreach (var item in listInt)
            {
                Console.Write(item + " ");
            }
           // Console.WriteLine("Hello World!");
        }
    }
}
