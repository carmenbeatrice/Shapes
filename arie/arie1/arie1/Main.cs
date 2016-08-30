using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class main
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("start");

            AreaCalculator calc = new AreaCalculator();
            Coordonate a = new Coordonate(3, 1);
            Coordonate b = new Coordonate(2, 3);
            Coordonate[] puncte = new Coordonate[] { a, b };
            Console.WriteLine(calc.area(puncte, puncte.Count()));
            Console.Read();
        }

    }
}
