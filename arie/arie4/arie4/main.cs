using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data;

namespace arie4
{
    class main
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("start");           
            XMLShapeReader.ReadShape();
            Console.WriteLine("stop");
            Console.ReadKey();
        }
    }
}