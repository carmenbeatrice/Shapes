using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication
{

    public class Coordonate : Punct
    {
        public float abscisa;
        public float ordonata;

        public Coordonate(float a, float b)
            : base(a, b)
        {
            this.abscisa = a;
            this.ordonata = b;

        }

        public float getAbscisa()
        {
            return abscisa;
        }

        public void setAbscisa(float abscisa)
        {
            this.abscisa = abscisa;
        }

        public float getOrdonata()
        {
            return ordonata;
        }

        public void setOrdonata(float ordonata)
        {
            this.ordonata = ordonata;
        }
    }
}
