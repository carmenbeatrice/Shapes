using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arie
{

    //--------------------------------------------------------------
    abstract public class Shape
    {
        protected int width, height;
        public Shape(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }

        abstract public int getarea();
    }
    //--------------------------------------------------------------
    public class Triangle : Shape
    {
        public Triangle(int a = 0, int b = 0)
            : base(a, b)
        {

        }

        public override int getarea()
        {
            return (width * height / 2);
        }

    }

    //--------------------------------------------------------------
    public class Rectangle : Shape
    {
        public Rectangle(int a = 0, int b = 0)
            : base(a, b)
        {

        }

        public override int getarea()
        {
            return (width * height);
        }

    }

    //--------------------------------------------------------------
    public class Square : Rectangle
    {
        public Square(int a)
            : base(a, a)
        {

        }

        public override int getarea()
        {
            return (width * width);
        }

    }
}
