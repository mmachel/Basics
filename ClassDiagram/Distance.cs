using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDiagram
{
    public class Distance
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Distance() { }
        public Distance(Point A, Point B)
        {
            this.A = A;
            this.B = B;
        }
        public double distance()
        {
            double distance;
            distance = Math.Sqrt((B.X-A.X)* (B.X - A.X) + (B.Y - A.Y)*(B.Y - A.Y));
            return distance;
        }
    }
}