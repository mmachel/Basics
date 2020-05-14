using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Default
{
    class Student: Person
    {
        public int Credit { get; set; }
        public float LearnTime { get; set; }
        List<string> modulo = new List<string>();
        public Student(string Name, int Age, char Gender, string Status, int Credit, string Address)
            :base(Name, Age, Gender, Status, Credit, Address) { }

        public override void PersonInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {DateTime.Now.Year - BirthYear}");
            Console.WriteLine($"Gender: {Gender}\nStatus: {Status}");
            Console.WriteLine($"Credit: {Credit}");
            Console.WriteLine($"Address: {Address}");
           // base.PersonInfo();
            Console.WriteLine();
        }
        public void Doing()
        {
            Console.WriteLine($"Im am studying {Course} for {LearnTime} years.");
            Console.WriteLine();
        }
        public void AddModule(string m)
        {
            modulo.Add(m);
        }
        public void MyModul()
        {
            Console.WriteLine("My modules are: ");
            foreach(var m in modulo)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();
        }
    }
}