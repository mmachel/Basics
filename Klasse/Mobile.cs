using System;
using System.Collections;
using System.Collections.Generic;

namespace Klasse
{
    public class Mobile: BasicDescription
    {
        
        public bool Camera { get; set; }
        public Mobile() : base(){}
        public Mobile(string Name, string Manufactur, DateTime DateOfPublication, string Cor,
        string ModelNumber,string ManufactureCountry, string OperatingSystem, bool Camera)
        :base(Name, Manufactur, DateOfPublication, Cor,ModelNumber,ManufactureCountry,OperatingSystem)
        {
            this.Camera = Camera;
        }

        public void DisplayMobile()
        {
            base.DisplayDescription();
            if (Camera)
            {
                Console.WriteLine("Camera: {0}", Camera);
            }
            else
            {
                Console.WriteLine("No camera!");
            }
        }
        public void Displays()
        {
            base.Display();
        }


    }
}