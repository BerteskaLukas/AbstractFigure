using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentals
{
    public class Program
    {

        // Krastines clockwise
        // kampai vidiniai 
        static void Main(string[] args)
        {

            Console.WriteLine("Hello world");

            Triangle tri = new Triangle(60, 5, 7);
            RightTriangle rTri = new RightTriangle(3, 4);
            EquilateralTriangle eTri = new EquilateralTriangle(6);
            IsosalesTriangle iTri = new IsosalesTriangle(30, 5);
            Quadrilateral Q = new Quadrilateral(25,9,13,75,7,8);
            Square sQ = new Square(5);

            Console.WriteLine(tri.ToString());
            Console.WriteLine(rTri.ToString());
            Console.WriteLine(eTri.ToString());
            Console.WriteLine(iTri.ToString());
            Console.WriteLine(Q.ToString());
            Console.WriteLine(sQ.ToString());


            Console.ReadKey();

        }
    }
}
