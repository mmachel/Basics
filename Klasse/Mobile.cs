using System;
using System.Collections;
using System.Collections.Generic;

namespace Klasse
{
    public class Mobile: BasicDescription
    {
        
        public bool Camera { get; set; }
        public string Continent { get; set; }
        public Mobile() : base(){}
  
        public Mobile(string Name, string Manufactur, DateTime DateOfPublication, string Cor,
        string ModelNumber,string ManufactureCountry, string OperatingSystem, bool Camera)
        :base(Name, Manufactur, DateOfPublication, Cor,ModelNumber,ManufactureCountry,OperatingSystem)
        {
            this.Camera = Camera;
        }
        private decimal FixPriceModelBased()
        {
            decimal DeviceFixPrice;
            if (ModelNumber== "SM-N9500")
            {
               DeviceFixPrice = 600m;
            }
            else if (ModelNumber=="SM-J110M")
            {
                DeviceFixPrice = 129;
            }
            else
            {
                return 0;
            }
            return DeviceFixPrice;
        }
        protected override decimal DevicePriceContinentBased()
        {
            Console.Write("Please enter the continent: ");
            Continent = Console.ReadLine();
            decimal temporaryPrice=0;
            switch(Continent)
            {
                case "Africa": temporaryPrice = FixPriceModelBased() * 1.5m;
                    break;
                case "America": temporaryPrice = FixPriceModelBased() * 1.8m;
                    break;
                case "South America": temporaryPrice = FixPriceModelBased() * 1.58m;
                    break;
                case "Europe": temporaryPrice = FixPriceModelBased() * 1.77m;
                    break;
                case "Asia": temporaryPrice = FixPriceModelBased() * 1.62m;
                    break;
                case "Australia": temporaryPrice = FixPriceModelBased() * 1.48m;
                    break;
                case "Antarctica": temporaryPrice = FixPriceModelBased() * 1.65m;
                    break;
                default: Console.WriteLine("There is no continent with this name, please verify and try again.");
                    break;

            }
            // return base.DevicePrice();
            return temporaryPrice;
        }
        public void Price()
        {
            Console.WriteLine("{0}: {1:C2}",ModelNumber,DevicePriceContinentBased());
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