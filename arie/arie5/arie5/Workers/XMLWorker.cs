using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Configuration;
using System.Xml;
using arie5.Shapes;
using arie5.Workers;

namespace arie5
{
    public static class XMLWorker
    {       
        public static void DoWork()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"D:\work\Shape\arie\arie5\arie5\Resources\Input.xml");
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

                Shape shape = CreateShape.Create(tip, width, height);
                Console.WriteLine(shape.ToString());
            }
        }
    }
}