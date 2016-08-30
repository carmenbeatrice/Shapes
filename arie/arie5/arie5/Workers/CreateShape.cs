using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using arie5.Shapes;

namespace arie5.Workers
{
    class CreateShape
    {
        public static Shape Create(string tip, int width, int height)
        {
            Shape shape = null;
            switch (tip)
            {
                case "Triangle":
                    shape = new Triangle(width, height);
                    break;

                case "Square":
                    shape = new Square(width, width);
                    break;

                case "Rectangle":
                    shape = new Rectangle(width, height);
                    break;
            }
            return shape;
        }
    }
}
