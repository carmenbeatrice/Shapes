using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;
using arie5.Workers;
using System.Data.SqlClient;

namespace arie5
{
    class main
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("start\n");
            Console.WriteLine("from xml");
            XMLWorker.DoWork();
            Console.WriteLine("\nfrom csv");
            CSVWorker.DoWork();
            Console.WriteLine("\nfrom db");
            DBWorker.DoWork();
            Console.WriteLine("\nstop");
            Console.ReadKey();
        }
    }
}