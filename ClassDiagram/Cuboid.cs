using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDiagram
{
    public class Cuboid : Shape, IShapeInfo
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public double Height { get; set; }
        public Point InnerBaseLeftConner { get; set; }
        public Point FrontBaseRightConner { get; set; }
        public Point InnerBaseRightConner { get; set; }
        public Point InnerTopRightConner { get; set; }
        private static int count = 1;
        public int CuboidNr { get; }
        public Cuboid() { CuboidNr = count++; }
        public Cuboid(double length, double bradth, double height)
        {
            Length = length;
            Breadth = bradth;
            Height = height;
            CuboidNr = count++;
        }
        public Cuboid(double length)
        {
            Length = length;
            Breadth = length;
            Height = length;
            CuboidNr = count++;
        }
        public Cuboid(Point A, Point B, Point C, Point F)
        {
            InnerBaseLeftConner = A;
            InnerBaseRightConner = B;
            FrontBaseRightConner = C;
            InnerTopRightConner = F;
            Length = new Distance(InnerBaseLeftConner, InnerBaseRightConner).distance();
            Breadth = new Distance(InnerBaseRightConner, FrontBaseRightConner).distance();
            Height = new Distance(InnerBaseRightConner, InnerTopRightConner).distance();
            CuboidNr = count++;
        }
        public double Area()
        {
            double area = 2 * (Length * Breadth + Length * Height + Breadth * Height);
            return area;
        }
        private double Volume()
        {
            double volume = Length * Breadth * Height;
            return volume;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing cuboid...");
        }

        public void DisplayShape()
        {
            Console.WriteLine($"{CuboidNr}. Cuboid: ");
            Console.WriteLine($"Cuboid area: {Area():F2} AU");
            Console.WriteLine($"Cuboid volume: {Volume():F2} VU");
            Console.WriteLine();
        }
    }
}