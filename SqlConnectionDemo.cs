using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    class SqlConnectionDemo
    {
        static void Main(string[] args)
        {
            new SqlConnectionDemo().Connecting();
        }
        //public void Connecting()
        //{
        //    using (
        //   SqlConnection con = new SqlConnection(@"Data Source = JAGADEESH\SQLEXPRESS; Initial Catalog = Student; Integrated Security = True")
        //         )
        //    {
        //        con.Open();
        //        Console.WriteLine("Connection Established Successfully");
        //    }
        //}
        public void Connecting()
        {
            SqlConnection con = null;
            try
            {
               con = new SqlConnection(@"Data Source = JAGADEESH\SQLEXPRESS; Initial Catalog = Student; Integrated Security = True");
               con.Open();
               Console.WriteLine("Connection Established Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {  
                con.Close();
            }
        }
    }
}
