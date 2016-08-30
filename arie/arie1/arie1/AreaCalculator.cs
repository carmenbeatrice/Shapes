using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class AreaCalculator
    {
        public float Cross_Product(Coordonate a, Coordonate b)
        {
            return a.abscisa * b.ordonata - a.ordonata * b.abscisa;
        }

        public double area(Coordonate[] vertices, int n)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += Math.Abs(Cross_Product(vertices[i], vertices[(i + 1) % n]));
            }
            return sum / 2;
        }
    }
}
