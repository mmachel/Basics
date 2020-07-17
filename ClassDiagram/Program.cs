using System;

namespace ClassDiagram
{
    class Program
    {
        static void Main(string[] args)
        {
             //Set Points
             var A = new Point(0, 0);
             var B = new Point(3, 4);
             var C = new Point(1.5, 5);
             var D = new Point(1, 2);

             //Distance between points
             var ab = new Distance(A, B);
             var bc = new Distance(B, C);
             var cd = new Distance(C, D);
             var da = new Distance(D, A);

             //Unit explanation
             UnitExplanation.Units();

             //Triangle test
             //var iso = TriangleType.Isosceles;
             //var rect = TriangleType.Rectangular;
             //var obt = TriangleType.Obtuse;
             //var equi = TriangleType.Echilateral;
             var t1 = new TriangleWithSides(A, B, C);
             var t2 = new TriangleWithSides(3, 4, 5);
             var t3 = new TriangleWithSides(1.5,3.7,5);
             var t4 = new TriangleWithAngle(3, 3, 45);
             var t5 = new TriangleWithAngle(A, B, C);
             var t6 = new TriangleWithAngle(3, 4, 90);
             t1.Draw();
             t1.DisplayShape();
             t2.DisplayShape();
             t3.DisplayShape();
             t4.DisplayShape();
             t5.DisplayShape();
             t6.DisplayShape();
            
             //Circle Test
             var circle1 = new Circle(A, B);
             var circle2 = new Circle(3);
             circle1.Draw();
             circle1.DisplayShape();
             circle2.DisplayShape();

             //Rectangle test
             var rect1 = new Rectangle(A,B, D);
             var rect2 = new Rectangle(3, 4);
             rect1.Draw();
             rect1.DisplayShape();
             rect2.DisplayShape();

             //Square test
             var sq1 = new Square(4);
             var sq2 = new Square(A, B);
             sq1.Draw();
             sq1.DisplayShape();
             sq2.DisplayShape();

             //Cylinder test
             var cyl1 = new Cylinder(A, B, C);
             var cyl2 = new Cylinder(3, 5);
             cyl1.Draw();
             cyl1.DisplayShape();
             cyl2.DisplayShape();

             //Sphere test
             var sphere1 = new Sphere(A, B);
             var sphere2 = new Sphere(7.5);
             sphere1.Draw();
             sphere1.DisplayShape();
             sphere2.DisplayShape();

             //Hemisphere test
             var hs1 = new Hemisphere(B, D);
             var hs2 = new Hemisphere(3.7);
             hs1.Draw();
             hs1.DisplayShape();
             hs2.DisplayShape();

             //Cone test
             var cone1 = new Cones(A, B, C);
             var cone2 = new Cones(2.5, 4, 5);
             cone1.Draw();
             cone1.DisplayShape();
             cone2.DisplayShape();

             //Cuboid test
             var cub1 = new Cuboid(5.0,6.0,7.0);
             var cub2 = new Cuboid(A, B, C, D);
             cub1.Draw();
             cub1.DisplayShape();
             cub2.DisplayShape();

            //Testing Cube
            var cube1 = new Cube(5);
            var cube2 = new Cube(A, B);
            cube1.Draw();
            cube1.DisplayShape();
            cube2.DisplayShape();
            Display();
        }
        static void Display()
        {
            Console.WriteLine("===========================================================");
            Console.WriteLine("Choose one option:\n" +
                "1. Triangle\n" +
                "2. Square\n3. Rectangle\n4. Circle");
            Console.WriteLine("===========================================================");
        }
    }
}
