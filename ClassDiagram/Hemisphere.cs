using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDiagram
{
    public class Hemisphere : Sphere
    {
        public int HemisphereNr { get; }
        private static int count = 1;
        public Hemisphere() { HemisphereNr = count++; }
        public Hemisphere(Point Center, Point Edge) :base(Center, Edge)
        {
            HemisphereNr = count++;
        }
        public Hemisphere(double Radius): base(Radius)
        {
            HemisphereNr = count++;
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing hemisphere..."); 
        }
        private double Area()
        {
            double area = 3 * Math.PI * Radius * Radius;
            return area;
        }
        private double CurvedArea()
        {
            double area = 2*Math.PI *Radius * Radius;
            return area;
        }
        private double Volume()
        {
            double volume = 2.0 * Math.PI * Radius * Radius * Radius / 3;
            return volume;
        }

        public new void DisplayShape()
        {
            Console.WriteLine($"{HemisphereNr}. Hemisphere: ");
            Console.WriteLine($"Hemispherical area: {Area():F2} AU");
            Console.WriteLine($"Curved surface area: {CurvedArea():F2} AU");
            Console.WriteLine($"Hemispherical volume: {Volume():F2} VU");
            Console.WriteLine();
        }
    }
}