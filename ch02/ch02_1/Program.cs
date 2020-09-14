using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ch02_1.Shapes;

namespace ch02_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(-10, -5);
            Console.WriteLine(rect.Legal);
            Console.WriteLine(rect.Area);

            Square sq = new Square(5);
            Console.WriteLine(sq.Legal);
            Console.WriteLine(sq.Area);

            Triangle tri = new Triangle(5, 7, 8);
            Console.WriteLine(tri.Legal);
            Console.WriteLine(tri.Area);

            Shape shape = rect;
            Console.WriteLine(shape.Legal);
            Console.WriteLine(shape.Area);
        }
    }
}
