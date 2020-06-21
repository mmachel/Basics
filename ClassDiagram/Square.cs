using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDiagram
{
    public class Square : Rectangle
    {
        private static int count = 1;
        public int SquareNr { get;}

        public Square(Distance side): base(side, side)
        {
            Length = side.distance();
            Width = side.distance();
            SquareNr = count++;

        }
        public Square(double side) : base(side, side)
        {
            Length = side;
            Width = side;
            SquareNr = count++;
        }
        public new void Draw()
        {
            Console.WriteLine("Drawing Square...");
        }
        private double Area()
        {
            return Width * Length;
        }
        private double Perimeter()
        {
            double perimeter = 2 * Width + 2 * Length;
            return perimeter;
        }
        private double Diagonal()
        {
            double diagonal = Math.Sqrt(Width * Width + Length * Length);
            return diagonal;
        }
        public new void DisplayShape()
        {
            Console.WriteLine($"{SquareNr}. Square: ");
            Console.WriteLine($"Square area: {Area():F2} AU");
            Console.WriteLine($"Square perimeter: {Perimeter():F2} DU");
            Console.WriteLine($"Square diagonal: {Diagonal():F2} DU");
            Console.WriteLine();
        }
    }
}