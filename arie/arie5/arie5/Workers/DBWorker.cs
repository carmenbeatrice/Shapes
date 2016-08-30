using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using arie5.Workers;
using arie5.Shapes;


namespace arie5
{
    public static class DBWorker
    {        
        public static void DoWork()
        {
            //var a ="metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string="data source=ASUS-PC\SQLEXPRESS;initial catalog=Shape;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"
            string connectionString = @"data source=ASUS-PC\SQLEXPRESS;initial catalog=Shape;Trusted_Connection=True";
            string select = "SELECT * FROM dbo.Input";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(select, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            da.Dispose();
            foreach (DataRow dr in dt.Rows)
            {
                var id = dr["id"];
                string tip = dr["type"].ToString().Trim();
                var width = dr["width"];
                var height = dr["height"];
               Shape shape = CreateShape.Create(tip, int.Parse(width.ToString()), int.Parse(height.ToString()));                
                Console.WriteLine(shape.ToString());
            }            
        }
    }
}