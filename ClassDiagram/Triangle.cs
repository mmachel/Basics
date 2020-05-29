using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDiagram
{
    public class Triangle : Shape
    {
        private TriangleType Type;
        private Point[] Vertices;
        private static int count = 1;
        private int TriangleNr { get; }

        public Triangle() { }
        public Triangle(TriangleType type, params Point[] vertices)
        {
            this.Type = type;
            try
            {
                if (vertices.Length == 3)
                {
                    this.Vertices = vertices;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Triangle should have three vertices.");
                return;
            }
            
            TriangleNr = count++;
        }

        public TriangleType get_type()
        {
            return Type;
        }
        private double Area()
        {
            double area;

            Point a = Vertices[0];
            Point b = Vertices[1];
            Point c = Vertices[2];
            double ab = new Distance(a, b).distance();
            double bc = new Distance(b, c).distance();
            double ca = new Distance(c, a).distance();
            double s = (ab + bc + ca) / 2;
            area = Math.Sqrt(s * (s - ab) * (s - bc) * (s - ca));
            return area;
        }
        private double Perimeter()
        {
            double perimeter;
            Point a = Vertices[0];
            Point b = Vertices[1];
            Point c = Vertices[2];
            double ab = new Distance(a, b).distance();
            double bc = new Distance(b, c).distance();
            double ca = new Distance(c, a).distance();
            perimeter = ab + bc + ca;
            return perimeter;
        }
        
        public new void Draw()
        {
            Console.WriteLine("Drwaing triangle");
        }
        public void DisplayShape()
        {
            Console.WriteLine($"{TriangleNr}. Triangle: ");
            Console.WriteLine($"Triangle type: {Type}");
            Console.WriteLine($"Triangle area: {Area():F2} AU");
            Console.WriteLine($"Triangle parameter: {Perimeter():F2} DU");
            Console.WriteLine();
        }
    }
}