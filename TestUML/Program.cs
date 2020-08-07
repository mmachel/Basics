using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace TestUML
{
    interface ICourse
    {
        string Course();
    }
    interface IResearch
    {
        string FieldOfResearch();
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
    class Practica
    {
        public string CompanyName { get; set; }
        public string Localization { get; set; }
        public Practica(string name, string local)
        {
            CompanyName = name;
            Localization = local;
        }
        public override string ToString()
        {
            return string.Format($"Name of the Company: {CompanyName}\nLocalization: {Localization}");
        }
    }
    class Student : Person, ICourse, IResearch
    {
        public string ID { get; set; }
        public Practica Praxis { get; set; }
        public Student(string name, int age) : base(name, age)
        {
            Praxis = new Practica("Earth exploration", "Earth's north pol");
        }
        public string Course() => "Information Technology";
        public override void Des() => Console.WriteLine("Student is a person.");
        public override string ToString()
        {
            return base.ToString() + " Course: " + Course() + "\nResearch Field: " + FieldOfResearch();
        }

        public string FieldOfResearch()
        {
            return "New technology for detecting antimatters and dark energy";
        }
    }
    class Scientist : Person, IResearch
    {
        public Scientist(string name, int age) : base(name, age)
        {
        }

        public string FieldOfResearch()
        {
            return "Genetic and modernal anatomic technology";
        }
        public override string ToString()
        {
            return base.ToString() + "\nResearch Field: " + FieldOfResearch();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Adelaide", 20);
            //Console.WriteLine(student);
            //student.Des();
            //Console.WriteLine(student.Praxis);
            var scientist = new Scientist("Ada Adelaide", 20);
            var list = new List<Person>();
            list.Add(student);
            list.Add(scientist);
            Console.WriteLine("First: ");
            foreach (var item in list)
            {
                if (item is ICourse)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("Second: ");
            foreach (var item in list)
            {
                var res = item as IResearch;
                if (res != null)
                {
                    Console.WriteLine(res);
                }
            }
        }
    }
}
