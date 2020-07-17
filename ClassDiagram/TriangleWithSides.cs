using System;

namespace ClassDiagram
{
    public class TriangleWithSides: Triangle
    {
        //Fields and properties
        private static int count = 1;
        private int TriangleNr { get; }

        //Constructors
        public TriangleWithSides() { TriangleNr = count++; }
        public TriangleWithSides(double side1, double side2, double side3)
                                : base(side1, side2, side3) => TriangleNr = count++;
        public TriangleWithSides(Point A, Point B, Point C) : base(A, B, C) => TriangleNr = count++;

        //Methods
        private double S => Perimeter() / 2;
        public double Area() => Math.Sqrt(S * (S - Side1) * (S - Side2) * (S - Side3)); //Using Heron's formula
        public new void DisplayShape()
        {
            Console.WriteLine($"{TriangleNr}. Triangle: ");
            Console.WriteLine($"Triangle area: {Area():F2} AU");
            Console.WriteLine($"Triangle perimeter: {Perimeter():F2} DU");
            Console.WriteLine();
        }
    }
}