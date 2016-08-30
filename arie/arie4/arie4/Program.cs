using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arie4
{

    //--------------------------------------------------------------
    abstract public class Shape
    {
        protected int width, height;

        public Shape(int a, int b)
        {
            width = a;
            height = b;
        }

        
        public override string ToString()
        {
            return "I am a shape with width " + width + " and height " + height + " and my are is " + this.getarea().ToString();
        }

        abstract public int getarea();
    }

    //--------------------------------------------------------------
    public class Triangle : Shape
    {
        public Triangle(int a, int b) : base(a,b)
        {

        }

        public override string ToString()
        {
            return "I am a triangle with width " + width + " and height " + height + " and my are is " + this.getarea().ToString();
        }

        public override int getarea()
        {
            return (width * height / 2);
        }
    }

    //--------------------------------------------------------------
    public class Rectangle : Shape
    {
        public Rectangle(int a, int b) : base(a,b)
        {

        }

        public override string ToString()
        {
            return "I am a rectangle with width " + width + " and height " + height + " and my are is " + this.getarea().ToString();
        }

        public override int getarea()
        {
            return (width * height);
        }
    }

    //--------------------------------------------------------------
    public class Square : Rectangle
    {
        public Square(int a, int b) : base(a,a)
        {

        }

        public override string ToString()
        {
            return "I am a square with width " + width + " and my are is " + this.getarea().ToString();
        }

        public override int getarea()
        {
            return (width * width);
        }
    }
}