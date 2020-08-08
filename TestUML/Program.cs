using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Test
{
   
}
namespace TestUML
{
    interface ICourse
    {
        string Course { get; set; }
    }
    interface IResearch
    {
        string FieldOfResearch { get; set; }
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
        public abstract void Hobby();
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
        public string FieldOfResearch { get; set; }
        public string Course { get; set; }
        public Student(string name, int age) : base(name, age)
        {
            Praxis = new Practica("Earth exploration", "Earth's north pol");
            FieldOfResearch = "New technology for detecting antimatters and dark energy";
            Course = "Information Technology";
        }
        public override void Des() => Console.WriteLine("Student is a person.");
        public override string ToString()
        {
            return base.ToString() + " Course: " + Course + "\nResearch Field: " + FieldOfResearch;
        }

        public override void Hobby()
        {
            throw new NotImplementedException();
        }
    }
    class Scientist : Person, IResearch
    {
        public string FieldOfResearch { get; set; }
        public Scientist(string name, int age) : base(name, age)
        {
            FieldOfResearch = "Genetic and modernal anatomic technology";
        } 
        public override void Hobby()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString() + "\nResearch Field: " + FieldOfResearch;
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
                    Console.WriteLine(((ICourse)item).Course);
                }
                else
                {
                    Console.WriteLine("I am not a student of this course");
                }
            }
            Console.WriteLine("Second: ");
            foreach (var item in list)
            {
                var res = item as IResearch;
                if (res != null)
                {
                    Console.WriteLine(res.FieldOfResearch);
                }
            }

            
        }
    }
}
