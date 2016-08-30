using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arie5.Shapes
{
    public class Square : Shape
    {
        public Square(int width, int height) : base(width, width) { }

        public override string ToString()
        {
            return "I am a square with width " + _width + " and my are is " + this.getarea().ToString();
        }

        public override int getarea()
        {
            return (_width * _width);
        }
    }
}
