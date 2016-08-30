using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arie
{
    class main
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("start");
            Triangle t = new Triangle(1, 2);
            Square s = new Square(2, 3);
            Rectangle r = new Rectangle(2, 3);
            Console.WriteLine(t.getarea());
            Console.WriteLine(s.getarea());
            Console.WriteLine(r.getarea());
            Console.Read();
        }
    }
}
