using System;

namespace ClassDiagram
{
    public abstract class Triangle : Shape, IShapeInfo
    {
        //Fields and properties
        public TriangleType Type { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        //Constructores
        public Triangle() { }
        public Triangle(Point A, Point B, Point C)
        {
            Side1 = new Distance(A, B).distance();
            Side2 = new Distance(B, C).distance();
            Side3 = new Distance(C, A).distance();
        }
        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        //Methods
        public override void Draw() => Console.WriteLine("Drawing triangle");
        public double Perimeter() => Side1 + Side2 + Side3;
        public void DisplayShape()
        {
            throw new NotImplementedException();
        }
        //private double area => Side3 !=0 ? AreaWithSides() : AreaWithSideAndAngle();

    }
}