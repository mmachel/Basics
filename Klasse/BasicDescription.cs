using System;
using System.Collections;
using System.Collections.Generic;
namespace Klasse
{
    public class BasicDescription
    {
        public string Name  { get; set; }
        public string Manufactur { get; set; }
        public DateTime DateOfPublication { get; set; }
        public string Cor { get; set; }
        public string ModelNumber { get; set; }
        public string ManufactureCountry { get; set; }
        public string OperatingSystem { get; set; }
        List<BasicDescription> numberOfDevice = new List<BasicDescription>();
        public BasicDescription(){} 
        public BasicDescription(string Name, string Manufactur,
         DateTime DateOfPublication, string Cor,string ModelNumber,
         string ManufactureCountry, string OperatingSystem)
        {
            this.Name = Name;
            this.Manufactur = Manufactur;
            this.DateOfPublication = DateOfPublication;
            this.Cor = Cor;
            this.ModelNumber = ModelNumber;
            this.ManufactureCountry = ManufactureCountry;
            this.OperatingSystem = OperatingSystem;
        }

        public void Add(BasicDescription bs)
        {
            numberOfDevice.Add(bs);
        }
        public void DisplayDescription()
        {
            Console.WriteLine();
            Console.WriteLine("Device name: {0}",Name);
            Console.WriteLine("Manufactur: {0}",Manufactur);
            Console.WriteLine("Model number: {0}",ModelNumber);
            Console.WriteLine("OS: {0}",OperatingSystem);
            Console.WriteLine("Color: {0}",Cor);
            Console.WriteLine("Date of Publication: {0}",DateOfPublication.Year);
            Console.WriteLine("Country: {0}",ManufactureCountry);
            //Console.WriteLine();
        }
        public void Display()
        {
            int i =1;
            foreach (var item in numberOfDevice)
            {
                Console.Write("Device {0}:",i);
                item.DisplayDescription();
                Console.WriteLine();
                i++;
            }
        }
        
    }
}