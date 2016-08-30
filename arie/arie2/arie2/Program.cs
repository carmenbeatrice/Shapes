using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arie
{
    public class Shape
    {
        public float l;
        public float L;

        public Shape(float l, float L)
        {
            this.l = l;
            this.L = L;
        }
    }

    public class Triangle : Shape
    {
        public Triangle(float l, float L)
            : base(l, L)
        {
            this.l = l;
            this.L = L;
        }

        public float getarea()
        {
            return (l * L) / 2;
        }

    }

    public class Rectangle : Shape
    {
        public Rectangle(float l, float L)
            : base(l, L)
        {
            this.l = l;
            this.L = L;
        }

        public float getarea()
        {
            return l * L;
        }

    }

    public class Square : Shape
    {
        public Square(float l, float L)
            : base(l, L)
        {
            this.l = l;
            this.L = l;
        }

        public float getarea()
        {
            return l * l;
        }

    }

}
