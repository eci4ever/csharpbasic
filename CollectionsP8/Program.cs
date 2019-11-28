using System.Linq;
using System.Diagnostics.Tracing;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsP8
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
    }
    //Let define our own collection
    public class Organization : IEnumerable
    {
        List<Employee> emps = new List<Employee>();
        public void Add(Employee Emp)
        {
            emps.Add(Emp);
        }
        public int Count
        {
            get { return emps.Count; }
        }
        public Employee this[int index]
        {
            get { return emps[index]; }
        }

        public IEnumerator GetEnumerator()
        {
            return new OrganizationEnumerator(this);
        }
    }
    public class OrganizationEnumerator : IEnumerator
    {
        Organization orgColl;
        int currentIndex;
        Employee currentEmployee;
        public OrganizationEnumerator(Organization org)
        {
            orgColl = org;
            currentIndex = -1;
        }
        public object Current
        {
            get 
            {
                return currentEmployee;
            }
        }
        public bool MoveNext()
        {
            if (++currentIndex >= orgColl.Count)
                return false;
            else
                currentEmployee = orgColl[currentIndex];
            return true;
        }
        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            //List<Employee> employees = new List<Employee>();
            Organization employees = new Organization();
            employees.Add( new Employee { Id = 101, Name = "Johan", Job = "Pengurus", Salary = 5000.00 });
            employees.Add( new Employee { Id = 102, Name = "Sarah", Job = "IT", Salary = 2000.00 });
            employees.Add( new Employee { Id = 103, Name = "Abu", Job = "HR", Salary = 4000.00 });
            employees.Add( new Employee { Id = 104, Name = "Jamal", Job = "Operasi", Salary = 1000.00 });
            employees.Add( new Employee { Id = 105, Name = "Kamal", Job = "Operasi", Salary = 1500.00 });

            foreach (Employee item in employees)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Job} {item.Salary}");
            }
            //Console.WriteLine("Hello World!");
        }
    }
}
