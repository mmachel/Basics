using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ClassDiagram
{
    public class Rectangle : Shape, IShapeInfo
    {
        private double Width;
        private double Length;
        private static int count = 1;
        public int RectangleNr { get; }

        public Rectangle(Distance width, Distance length)
        {
            Width = width.distance();
            Length = length.distance();
            RectangleNr = count++;
        }
        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
            RectangleNr = count++;
        }

        public double get_width()
        {
            return Width;
        }

        public double get_height()
        {
            return Length;
        }

        public void set_width(Distance wid)
        {
            Width = wid.distance();
        }

        public void set_height(Distance length)
        {
            Length = length.distance();
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing rectangles");
        }
        private double Area()
        {
            return Width * Length;
        }
        private double Perimeter()
        {
            double perimeter = 2*Width + 2*Length;
            return perimeter;
        }
        private double Diagonal()
        {
            double diagonal = Math.Sqrt(Width * Width + Length * Length);
            return diagonal;
        }
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