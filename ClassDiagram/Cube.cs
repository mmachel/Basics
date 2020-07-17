using System;

namespace ClassDiagram
{
    class Cube : Cuboid
    {
        public Point A { get; set; }
        public Point B { get; set; }
        private static int count = 1;
        public int CubeNr { get; }
        public Cube() { CubeNr = count++; }
        public Cube(double length)
        {
            Length = length;
            Breadth = length;
            Height = length;
            CubeNr = count++;
        }
        public Cube(Point a, Point b)
        {
            A = a;
            B = b;
            Length = new Distance(A, B).distance();
            Breadth = Length;
            Height = Length;
        }
        public override void Draw() => Console.WriteLine("Drawing cube...");
        public new void DisplayShape()
        {
            Console.WriteLine($"{CubeNr}. Cube: ");
            Console.WriteLine($"Cube area: {Area():F2} AU");
            Console.WriteLine($"Cube volume: {Volume():F2} VU");
            Console.WriteLine();
        }
    }
}