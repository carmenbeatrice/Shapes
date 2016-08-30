using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arie
{
    class main
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("start");

            var shapes = new Shape[]
            {
                new Triangle(3, 2),
                new Square(2),
                new Rectangle(2,3)
            };

            foreach (var shape in shapes)
            {
                System.Console.WriteLine("Area of " + shape.GetType().Name + " is " + shape.getarea());
            }

            Console.ReadKey();
        }
    }
}
