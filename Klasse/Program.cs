using System;

namespace Klasse
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobile = new Mobile("Galaxy Note 8","Samsung",
            new DateTime(2017,08,01),"Black","SM-N9500","China","Android");
            var pc = new BasicDescription("MacBook Pro","Apple Inc.",
            new DateTime(2019,05,01),"Silva","MacBookPro16,1","USA","iOS");
            var list = new BasicDescription();
            list.Add(mobile);
            list.Add(pc);
            list.Display();
            mobile.Camera = false;
            mobile.OSystem();

        }
    }
}
