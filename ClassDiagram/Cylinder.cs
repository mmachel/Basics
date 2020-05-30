using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDiagram
{
    public class Cylinder : Circle, IShapeInfo
    {
        public double Height { get; set; }
        public Point CenterTop { get; set; }
        private static int count = 1;
        public int CylinderNr { get; }

        public Cylinder() { }
        public Cylinder(double Radius, double Height) : base(Radius)
        {
            this.Height = Height;
            CylinderNr = count++;
        }
        public Cylinder(Point Center, Point Edge, Point CenterTop) : base(Center, Edge)
        {
            this.CenterTop = CenterTop;
            Height = new Distance(Center, CenterTop).distance();
            CylinderNr = count++;
        }

        public override void Draw()
        {
            Console.WriteLine("Drwaing cylinder.");
        }
        private new double Area()
        {
            double area = 2 * Math.PI * get_radius() * (get_radius() + Height);
            return area;
        }
        private double CurvedArea()
        {
            double area = 2 * Math.PI * get_radius() * Height;
            return area;
        }
        private double Volume()
        {
            double volume = Math.PI * get_radius() * get_radius() * Height;
            return volume;
        }
        public new void DisplayShape()
        {
            Console.WriteLine($"{CylinderNr}. Cylinder: ");
            Console.WriteLine($"Cylinder area: {Area():F2} AU");
            Console.WriteLine($"Curved surface cylinder area: {CurvedArea():F2} AU");
            Console.WriteLine($"Cylinder volume: {Volume():F2} VU");
            Console.WriteLine();
        }
    }
}