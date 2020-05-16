using System;
using System.Collections;
using System.Collections.Generic;

namespace Klasse
{
    public class Mobile: BasicDescription
    {
        
        public bool Camera { get; set; }
        public Mobile() : base(){}

        readonly decimal FixPrice = 649.99m;
        public Mobile(string Name, string Manufactur, DateTime DateOfPublication, string Cor,
        string ModelNumber,string ManufactureCountry, string OperatingSystem, bool Camera)
        :base(Name, Manufactur, DateOfPublication, Cor,ModelNumber,ManufactureCountry,OperatingSystem)
        {
            this.Camera = Camera;
        }

        public override decimal DevicePrice()
        {
            Console.Write("Please enter the continent: ");
            string continent = Console.ReadLine();
            decimal temporaryPrice=0;
            switch(continent)
            {
                case "Africa": temporaryPrice = FixPrice * 1.5m;
                    break;
                case "America": temporaryPrice = FixPrice * 1.8m;
                    break;
                case "South America": temporaryPrice = FixPrice * 1.58m;
                    break;
                case "Europe": temporaryPrice = FixPrice * 1.77m;
                    break;
                case "Asia": temporaryPrice = FixPrice * 1.62m;
                    break;
                case "Australia": temporaryPrice = FixPrice * 1.48m;
                    break;
                case "Antarctica": temporaryPrice = FixPrice * 1.65m;
                    break;
                default: Console.WriteLine("There is no continent with this name, please verify and try again.");
                    break;

            }
            // return base.DevicePrice();
            return temporaryPrice;
        }
        public void Price()
        {
            Console.WriteLine("Price: {0:C2}",DevicePrice());
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