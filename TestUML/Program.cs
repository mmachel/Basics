using System;
using System.Security.Cryptography.X509Certificates;

namespace TestUML
{
    interface ICourse
    {
        string Course();
    }
    abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void Des() => Console.WriteLine("Person is a mamal.");
        public override string ToString()
        {
            return string.Format($"Name: {Name} and Age: {Age}");
        }
    }
    class Student : Person, ICourse
    {
        public Student(string name, int age) : base(name, age) { }
        public string Course()
        {
            return "Information Technology";
        }
        public override void Des() => Console.WriteLine("Student is a person.");
        public override string ToString()
        {
            return base.ToString() + " Course: " + Course();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Adelaide", 20);
            Console.WriteLine(student);
        }
    }
}
