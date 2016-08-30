using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using DataAccess;
using arie5.Shapes;
using arie5.Workers;

namespace arie5
{
    public static class CSVWorker
    {
        public static void DoWork()
        {
            DataAccess.DataTable dt = DataAccess.DataTable.New.ReadCsv(@"D:\work\Shape\arie\arie5\arie5\Resources\Input.csv");
            foreach (Row row in dt.Rows)
            {
                var id = row["id"];
                var tip = row["type"];
                var width = row["width"];
                var height = row["height"];
                Shape shape = CreateShape.Create(tip, int.Parse(width), int.Parse(height));
                Console.WriteLine(shape.ToString());
            }
        }
    }
}