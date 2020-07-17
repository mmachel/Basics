using System;

namespace ClassDiagram
{
    public class Cylinder : Circle, IShapeInfo
    {
        public double Height { get; set; }
        public Point CenterTop { get; set; }
        private static int count = 1;
        public int CylinderNr { get; }

        public Cylinder() { CylinderNr = count++; }
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

        public override void Draw() => Console.WriteLine("Drwaing cylinder.");
        public new double Area() => 2 * Math.PI * Radius * (Radius + Height);
        public double CurvedArea() => 2 * Math.PI * Radius * Height;
        public double Volume() => Math.PI * Radius * Radius * Height;
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