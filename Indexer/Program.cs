using System;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(101,"Eci Ismail", "C# Coder", "System Development", "Melaka", 6000.00);
            // emp.Eno = 102 We cannot access direcly the field because default private access
            //Accessing using indexer
            Console.WriteLine($"Employee ID : {emp[0]}");
            Console.WriteLine($"Employee Name : {emp[1]}");
            Console.WriteLine($"Employee Job : {emp[2]}");
            Console.WriteLine($"Employee Department : {emp[3]}");
            Console.WriteLine($"Employee Location : {emp[4]}");
            Console.WriteLine($"Employee Salary : {emp[5]}");
            // Changing value
            emp[0] = 102;
            emp[1] = "Evar";
            emp[2] = "PHP Coder";
            emp[3] = "Web Dev";
            emp[4] = "Johor";
            emp[5] = 5000.00;
            Console.WriteLine($"Employee ID : {emp[0]}");
            Console.WriteLine($"Employee Name : {emp[1]}");
            Console.WriteLine($"Employee Job : {emp[2]}");
            Console.WriteLine($"Employee Department : {emp[3]}");
            Console.WriteLine($"Employee Location : {emp[4]}");
            Console.WriteLine($"Employee Salary : {emp[5]}");

            emp["ename"] = "Test name";
            Console.WriteLine(emp["ename"]);
            //Console.WriteLine("Hello World!");
        }
    }
}
