using System;
using System.Collections.Generic;

namespace CollectionsP5b
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Student s1 = new Student {
                Id = 101,
                Name = "Joe",
                Location = "Kuala Lumpur"
            };
            Student s2 = new Student {
                Id = 102,
                Name = "Doe",
                Location = "Kedah"
            };
            Student s3 = new Student {
                Id = 103,
                Name = "Moe",
                Location = "Melaka"
            };

            students.Add(s1); students.Add(s2); students.Add(s3); 

            foreach (var item in students)
            {
                Console.WriteLine($"{item.Id} : {item.Name} : {item.Location}");
            }
            Console.WriteLine("Hello World!");
        }
    }
}
