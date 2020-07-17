using System;

namespace ClassDiagram
{
    public class Circle : Shape, IShapeInfo
    {
        public Point Center { get; set; }
        public Point Edge { get; set; }
        public double Radius { get; set; }
        public int CircleNr { get; }
        private static int count = 1;

        public Circle() { CircleNr = count++; }
        public Circle(Point center, Point edge)
        {
            Center = center;
            Edge = edge;
            Radius = new Distance(Center, Edge).distance();
            CircleNr = count++;
        }
        public Circle(double Radius)
        {
            this.Radius = Radius;
            CircleNr = count++;
        }
        public override void Draw() => Console.WriteLine("Drawing circles");
        public double Area() => Math.PI * Radius * Radius;
        public double Perimeter() => 2 * Math.PI * Radius;
        public void DisplayShape()
        {
            Console.WriteLine($"{CircleNr}. Circle: ");
            Console.WriteLine($"Circle area: {Area():F2} AU");
            Console.WriteLine($"Circle perimeter: {Perimeter():F2} DU");
            Console.WriteLine();
        }
    }
}