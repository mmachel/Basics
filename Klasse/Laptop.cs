using System;
using System.Collections;
using System.Collections.Generic;
namespace Klasse
{
    class Laptop : BasicDescription
    {
        public bool IntegratedCamera { get; set; }
        public bool TouchScreen { get; set; }
        public Laptop(): base() { }
        public Laptop(string Name, string Manufactur, DateTime DateOfPublication, string Cor, string ModelNumber,
         string ManufactureCountry, string OperatingSystem, bool Camera, bool TouchScreen) 
            :base(Name,Manufactur,DateOfPublication,Cor,ModelNumber,ManufactureCountry,OperatingSystem)
        {
            this.IntegratedCamera = Camera;
            this.TouchScreen = TouchScreen;
        }
        public void DisplayLapTop()
        {
            base.DisplayDescription();
            if (IntegratedCamera || TouchScreen)
            {
                Console.WriteLine("Camera: {0}", IntegratedCamera);
                Console.WriteLine("Touch function: {0}",TouchScreen);
            }
            else
            {
                Console.WriteLine("No camera and no touch function!");
            }
        }
    }
}
