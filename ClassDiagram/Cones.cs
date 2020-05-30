using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDiagram
{
    public class Cones : Cylinder, IShapeInfo
    {
        private static int count = 1;
        public double Length { get; set; }
        public int ConeNr { get; }
        
        public Cones() { ConeNr = count++; }
        public Cones(double Radius, double Height, double Length) : base(Radius, Height)
        {
            this.Length = Length;
            ConeNr = count++;
        }
        public Cones(Point Center, Point Edge, Point CenterTop) : base(Center, Edge, CenterTop)
        {
            Length = new Distance(Edge, CenterTop).distance();
            ConeNr = count++;
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing cone...");
        }
        private new double Area()
        {
            double area = Math.PI * get_radius() * (get_radius() + Length);
            return area;
        }
        private double CurvedArea()
        {
            double area = Math.PI * get_radius() * Length;
            return area;
        }
        private double Volume()
        {
            double volume = Math.PI * get_radius() * get_radius() * Height/3;
            return volume;
        }
        public new void DisplayShape()
        {
            Console.WriteLine($"{ConeNr}. Cone: ");
            Console.WriteLine($"Cone area: {Area():F2} AU");
            Console.WriteLine($"Curved surface cone area: {CurvedArea():F2} AU");
            Console.WriteLine($"Cone volume: {Volume():F2} VU");
            Console.WriteLine();
        }
    }
}