using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arie5.Shapes
{
    abstract public class Shape
    {
        protected int _width, _height;
        public Shape(int width, int height)
        {
            this._width = width;
            this._height = height;
        }

        public override string ToString()
        {
            return "I am a shape with width " + _width + " and height " + _height + " and my are is " + this.getarea().ToString();
        }
        abstract public int getarea();
    }
}