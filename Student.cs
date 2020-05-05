using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Default
{
    class Student: Person
    {
        public float LearnTime{get;set;}
        public void Doing()
        {
            System.Console.WriteLine($"Im am Studying {Activities} for {LearnTime}");
        }
    }
}