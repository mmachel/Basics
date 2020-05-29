using System;

namespace ClassDiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set Points
            var A = new Point(2, 1);
            var B = new Point(3, 7);
            var C = new Point(1.5, 5);
            var D = new Point(1, 2);
            
            //Distance between points
            var ab = new Distance(A, B);
            var bc = new Distance(B, C);
            var cd = new Distance(C, D);
            var da = new Distance(D, A);

            //Triangle test
            var iso = (TriangleType)0;
            var rect = (TriangleType)1;
            var obt = (TriangleType)2;
            var equi = (TriangleType)3;
            var t1 = new Triangle(iso, A, B, C);
            var t2 = new Triangle(rect, D,C,B);
            var t3 = new Triangle(obt, C, B, D);
            var t4 = new Triangle(equi, C, D, A);
            t1.DisplayShape();
            t2.DisplayShape();
            t3.DisplayShape();
            t4.DisplayShape();

            //Circle Test
            var circle1 = new Circle(A, B);
            var circle2 = new Circle(cd);
            circle1.Draw();
            circle1.DisplayShape();
            circle2.DisplayShape();

            //Rectangle test
            var rect1 = new Rectangle(ab,bc);
            var rect2 = new Rectangle(5, 4);
            rect1.DisplayShape();
            rect2.DisplayShape();
            rect1.set_width(da);
            rect1.DisplayShape();

        }
    }
}
