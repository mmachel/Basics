using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Default
{
    public class Program
    {
        static void Main(string[] args)
        {
           var person1 = new Student("Marshall Mudzane",1998,'M',"Single",36,"Zvishavane");
            person1.WelcomeMessage();
            person1.PersonInfo(); 

            person1.Course = "Applied Geoscience";
            person1.LearnTime = 1;
            person1.Doing();
            person1.AddModule("H�here Mathematik f�r Ing. 1");           
            person1.AddModule("H�here Mathematik f�r Ing. 2");
            person1.AddModule("Physik f�r Naturwissenschaftler 1");
            person1.AddModule("Physik f�r Naturwissenschaftler 2");
            person1.AddModule("Grundlagen der Informatik");
            person1.AddModule("Grundlagen der Geowissenschaften");
            person1.AddModule("Einf�hrung in die Geophysik");
            person1.AddModule("Einf�hrung in die Geoinformatik");
            person1.AddModule("Grundlagen der Geodynamik und Tektonik");
            person1.AddModule("Softwareentwicklung");
            person1.AddModule("Fachsprache English");
            person1.MyModul();
        }
    }
}
