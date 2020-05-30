using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Transactions;

namespace ClassDiagram
{
    public class Circle : Shape, IShapeInfo
    {
        private Point Center;
        private Point Edge;
        private double Radius;
        public int CircleNr { get; }
        private static int count = 1;

        public Circle() { }
        public Circle(Point center, Point edge)
        {
            Center = center;
            Edge = edge;
            Radius = new Distance(Center, Edge).distance();
            CircleNr = count++;
        }
        public Circle(Distance radius)
        {
            Radius = radius.distance();
            CircleNr = count++;
        }
        public Circle(double Radius)
        {
            this.Radius = Radius;
            CircleNr = count++;
        }

        public Point get_center()
        {
            return Center;
        }
        public Point get_edge()
        {
            return Edge;
        }

        public double get_radius()
        {
            return Radius;
        }

        public void set_center(Point center)
        {
            Center = center;
        }
        public void set_edge(Point edge)
        {
            Edge = edge;
        }
        public void set_radius(double radius)
        {
            Radius = radius;
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing circles");
        }
        public double Area()
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }
        public double Perimeter()
        {
            double perimeter = 2 * Math.PI * Radius;
            return perimeter;
        }
        public void DisplayShape()
        {
            Console.WriteLine($"{CircleNr}. Circle: ");
            Console.WriteLine($"Circle area: {Area():F2} AU");
            Console.WriteLine($"Circle perimeter: {Perimeter():F2} DU");
            Console.WriteLine();
        }
    }
}