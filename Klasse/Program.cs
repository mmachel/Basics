using System;

namespace Klasse
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobile = new Mobile("Galaxy Note 8","Samsung",
            new DateTime(2017,08,01),"Black","SM-N9500","China","Android",true);
            var pc = new Laptop("MacBook Pro","Apple Inc.",
            new DateTime(2019,05,01),"Silva","MacBookPro16,1","USA","iOS",true,false);
            var list = new BasicDescription();
            list.Add(mobile);
            list.Add(pc);
            //mobile.DisplayMobile();
            //pc.DisplayLapTop();
            var celular = new Mobile
            {
                Name = "Galaxy J1 Ace",
                ModelNumber = "SM-J110M",
                Manufactur = "Samsung",
                DateOfPublication = new DateTime(2015, 08, 31),
                Camera = true,
                ManufactureCountry = "South Corea",
                OperatingSystem = "Android"
            };

            var laptop = new Laptop
            {
                Name = "HP Pavilion",
                Manufactur = "HP Inc.",
                DateOfPublication = new DateTime(2019, 02, 27)
            };
            //Console.WriteLine(laptop.Name);
            list.Add(celular);
            list.Add(laptop);
            //list.Add(mobile);
            //mobile.Price();
            //celular.Price();
            list.Display();
            Console.ReadKey();
        }
    }
}
