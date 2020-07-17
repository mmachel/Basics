using System;

namespace ClassDiagram
{
    public class Rectangle : Shape, IShapeInfo
    {
        public double Width { get; set; }
        public double Length { get; set; }
        private static int count = 1;
        public int RectangleNr { get; }

        public Rectangle() { RectangleNr = count++; }
        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
            RectangleNr = count++;
        }
        /// <summary>
        /// A|-----------|D
        ///  |           |
        ///  |           |
        /// B|-----------|C
        /// The rectange has four ponts, but we need only three to calculate area and perimeter
        /// </summary>
        /// <param name="A">Point A of rectangle</param>
        /// <param name="B">Point B of rectangle </param>
        /// <param name="D">Point D of rectangle</param>
        public Rectangle(Point A, Point B,Point D)
        {
            Length = new Distance(A, B).distance();
            Width = new Distance(A, D).distance();
            RectangleNr = count++;
        }
        public override void Draw() => Console.WriteLine("Drawing rectangles");
        public double Area() => Width * Length;
        public double Perimeter() => 2 * Width + 2 * Length;
        public double Diagonal() => Math.Sqrt(Width * Width + Length * Length);
        public void DisplayShape()
        {
            Console.WriteLine($"{RectangleNr}. Rectangle: ");
            Console.WriteLine($"Rectangle area: {Area():F2} AU");
            Console.WriteLine($"Rectangle perimeter: {Perimeter():F2} DU");
            Console.WriteLine($"Rectangle diagonal: {Diagonal():F2} DU");
            Console.WriteLine();
        }
    }
}