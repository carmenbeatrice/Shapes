using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arie5.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(int width, int height) : base(width, height) { }

        public override string ToString()
        {
            return "I am a triangle with width " + _width + " and height " + _height + " and my are is " + this.getarea().ToString();
        }

        public override int getarea()
        {
            return (_width * _height / 2);
        }
    }
}