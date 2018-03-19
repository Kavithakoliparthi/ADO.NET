using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    class RetrieveRecordDemo
    {
        static void Main(string[] args)
        {
            new RetrieveRecordDemo().RetrieveData();
        }
        public void RetrieveData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source = JAGADEESH\SQLEXPRESS; Initial Catalog = Student; Integrated Security = True");
                SqlCommand sc = new SqlCommand("select * from stu1", con);
                con.Open();
                SqlDataReader sdr = sc.ExecuteReader();
                while(sdr.Read())
                {
                    Console.WriteLine(sdr["id"]+" "+sdr["name"]+" "+sdr["email"]);
                }
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
