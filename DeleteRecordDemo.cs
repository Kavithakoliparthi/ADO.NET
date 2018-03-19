using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    class DeleteRecordDemo
    {
        static void Main(string[] args)
        {
            new DeleteRecordDemo().RemoveData();
        }
        public void RemoveData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source = JAGADEESH\SQLEXPRESS; Initial Catalog = Student; Integrated Security = True");
                SqlCommand sc1 = new SqlCommand("delete from stu1 where id='1'", con);
                SqlCommand sc2 = new SqlCommand("delete from stu1 where id='2'", con);
                con.Open();
                sc1.ExecuteNonQuery();
                sc2.ExecuteNonQuery();
                Console.WriteLine("record deleted successfully");
                Console.Read();
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
