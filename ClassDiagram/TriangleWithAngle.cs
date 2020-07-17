using System;

namespace ClassDiagram
{
    public class TriangleWithAngle: TriangleWithSides
    {
        //Fields and properties
        public double Angle { get; set; }
        private static int count = 1;
        private int TriangleNr { get; }

        //Constructors
        public TriangleWithAngle() { TriangleNr = count++; }
        public TriangleWithAngle(double side1, double side2, double angle)
        {
            Side1 = side1;
            Side2 = side2;
            Angle = new Angle(angle).angle();
            Side3 = Math.Sqrt(Side1 * Side1 + Side2 * Side2 - 2 * Side1 * Side2 * Math.Cos(Angle));
            TriangleNr = count++;
        }
        public TriangleWithAngle(Point A, Point B, Point C) : base(A, B, C)
        {
            TriangleNr = count++;
            Angle = 0;
        }

        //Methods
        public double LokalArea() => Side1 * Side2 * Math.Sin(Angle) / 2;
        public double area => Angle != 0 ? LokalArea() : Area();
        public new void DisplayShape()
        {
            Console.WriteLine($"{TriangleNr}. Triangle: ");
            Console.WriteLine($"Triangle area: {area:F2} AU");
            Console.WriteLine($"Triangle perimeter: {Perimeter():F2} DU");
            Console.WriteLine();
        }
    }
}