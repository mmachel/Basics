using System;

namespace ClassDiagram
{
    public class Sphere : Shape, IShapeInfo
    {
        public double Radius { get; set; }
        public Point Center { get; set; }
        public Point Edge { get; set; }
        public int SphereNr { get; }
        private static int count = 1;

        public Sphere() {SphereNr = count++; }
        public Sphere(Point Center, Point Edge)
        {
            this.Center = Center;
            this.Edge = Edge;
            Radius = new Distance(Center, Edge).distance();
            SphereNr = count++;
        }
        public Sphere(double Radius)
        {
            this.Radius = Radius;
            SphereNr = count++;
        }
        public override void Draw() => Console.WriteLine("Drawing sphere...");
        private double Area() => 4 * Math.PI * Radius * Radius;
        private double Volume() => 4.0 * Math.PI * Radius * Radius * Radius / 3;
        public void DisplayShape()
        {
            Console.WriteLine($"{SphereNr}. Sphere: ");
            Console.WriteLine($"Spherical area: {Area():F2} AU");
            Console.WriteLine($"Spherical volume: {Volume():F2} VU");
            Console.WriteLine();
        }
    }
}