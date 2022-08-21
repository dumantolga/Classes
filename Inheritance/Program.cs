using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3]
            {
                new Customer
                {
                    FirstName="Tolga"
                },
                new Student
                {
                    FirstName="Engin"
                },
                new Person
                {
                    FirstName="Ayşe"
                }
            };
            foreach (var p in person)
            {
                Console.WriteLine(p.FirstName);
            }
            Console.ReadLine();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
}