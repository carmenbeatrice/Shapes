using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Configuration;
using System.Xml;

namespace arie4
{
    public static class XMLShapeReader
    {
        /*delegate int CreateShape(int a, int b);
        private static Dictionary<string, CreateShape> diction = new Dictionary<string, CreateShape>()
        {
            {"Triangle", new Triangle().getarea},
            {"Rectangle", new Rectangle().getarea},
            {"Square", new Square().getarea}
        };*/


        static Shape CreateShape(string tip,int width, int height)
        {
            Shape s = null;
            switch (tip)
            {
                case "Triangle":
                    s = new Triangle(width, height);
                    break;

                case "Square":
                    s = new Square(width, width);
                    break;

                case "Rectangle":
                    s = new Rectangle(width, height);
                    break;                
            }

            return s ;
        }
        
        public static void ReadShape()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"D:\work\Shape\arie\arie4\arie4\Input.xml");
            foreach (XmlNode xmlNode in xmlDoc.DocumentElement.ChildNodes)
            {
                var tip = xmlNode.Attributes["type"].Value;
                int width = 0, height = 0;


                if (tip.Equals("Square"))
                {
                    width = int.Parse(xmlNode.ChildNodes[0].InnerText);
                    height = width;
                }
                else
                {
                    width = int.Parse(xmlNode.ChildNodes[0].InnerText);
                    height = int.Parse(xmlNode.ChildNodes[1].InnerText);
                }

                //int a = diction[tip.ToString()].Invoke(width, height);

                //Console.WriteLine(xmlNode.Attributes["id"].Value + ": " + tip.ToString() + " has height " + height + " and width " + width /*+ " and area " + a*/);
                Shape s = CreateShape(tip,width,height);
                Console.WriteLine(s.ToString());

            }
        }
    }
}