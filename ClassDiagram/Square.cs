using System;

namespace ClassDiagram
{
    public class Square : Rectangle
    {
        private static int count = 1;
        public int SquareNr { get;}

        public Square() { SquareNr = count++; }
        public Square(Point A, Point B): base(A, B, B)
        {
            Length = new Distance(A, B).distance();
            Width =  new Distance(A, B).distance();
            SquareNr = count++;

        }
        public Square(double side) : base(side, side)
        {
            Length = side;
            Width = side;
            SquareNr = count++;
        }
        public new void Draw() => Console.WriteLine("Drawing Square...");
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