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
        /// <summary>
        /// Derermine the distance between two points
        /// </summary>
        /// <returns>Return distance as double number.</returns>
        public double distance()
        {
            double distance;
            distance = Math.Sqrt((B.X-A.X)* (B.X - A.X) + (B.Y - A.Y)*(B.Y - A.Y));
            return distance;
        }

        public static implicit operator Distance(double v)
        {
            //throw new NotImplementedException();
            return v;
        }
    }
}