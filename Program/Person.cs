using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Default
{
    public class Person
    {
        public string Name{get;set;}
        public int BirthYear{get; set;}
        public char Gender{get; set;}
        public string Status{get;set;}
        public decimal Salary{get;set;}
        public string Address{get;set;}
        public string Course{get;set;}

        public Person()
        {
            
        }
        public Person(string Name, int Age, char Gender, string Status, decimal Salary, string Address)
        {
            this.Name = Name;
            this.BirthYear = Age;
            this.Gender = Gender;
            this.Status = Status;
            this.Salary = Salary;
            this.Address = Address;
        }
        public virtual void PersonInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {DateTime.Now.Year-BirthYear}");
            Console.WriteLine($"Gender: {Gender}\nStatus: {Status}");
            Console.WriteLine($"Salary: {Salary:C2}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine();
        }

        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to MyApp!");
            Console.WriteLine();
        }

    }
}
