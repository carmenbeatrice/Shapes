using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Punct
    {
        float x;
        float y;

        public Punct(float x, float y)
        {
            this.x = x;
            this.y = y;

        }
        public float getAbscisa()
        {
            return x;
        }

        public void setAbscisa(float abscisa)
        {
            this.x = abscisa;
        }

        public float getOrdonata()
        {
            return y;
        }

        public void setOrdonata(float ordonata)
        {
            this.y = ordonata;
        }
    }
}
