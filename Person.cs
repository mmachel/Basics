using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    public class Person
    {
        public string Name{get;set;}
        public int Age{get; set;}
        public char Gender{get; set;}
        public string Status{get;set;}
        public decimal Salary{get;set;}
        public string Address{get;set;}

        public Person()
        {
            
        }
        public Person(string Name, int Age, char Gender, string Status, decimal Salary, string Address)
        {
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
            this.Status = Status;
            this.Salary = Salary;
            this.Address = Address;
        }
        public void PersonInfo()
        {
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"Age: {Age}");
            System.Console.WriteLine($"Gender: {Gender}, Status: {Status}");
            System.Console.WriteLine($"Salary: {Salary}");
            System.Console.WriteLine($"Address: {Address}");
        }

        public void WelcomeMessage()
        {
            System.Console.WriteLine("Welcome to MyApp!");
        }

    }
}
