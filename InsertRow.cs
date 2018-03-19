using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    class InsertRow
    {
        static void Main(string[] args)
        {
            new InsertRow().InsertData();
        }
        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source = JAGADEESH\SQLEXPRESS; Initial Catalog = Student; Integrated Security = True");
                SqlCommand sc1 = new SqlCommand("insert into stu1(id,name,email) values(1,'anu','anu@gmail.com')", con);
                SqlCommand sc2 = new SqlCommand("insert into stu1(id,name,email) values(2,'siri','siri@gmail.com')", con);
                SqlCommand sc3 = new SqlCommand("insert into stu1(id,name,email) values(3,'akshu','akshu@gmail.com')", con);
                SqlCommand sc4 = new SqlCommand("insert into stu1(id,name,email) values(4,'sanvi','sanvi@gmail.com')", con);
                SqlCommand sc5 = new SqlCommand("insert into stu1(id,name,email) values(5,'sarika','sarika@gmail.com')", con);
                SqlCommand sc6 = new SqlCommand("insert into stu1(id,name,email) values(6,'anitha','anitha@gmail.com')", con);
                con.Open();
                sc1.ExecuteNonQuery();
                sc2.ExecuteNonQuery();
                sc3.ExecuteNonQuery();
                sc4.ExecuteNonQuery();
                sc5.ExecuteNonQuery();
                sc6.ExecuteNonQuery();
                Console.WriteLine("insert data into table successfully");
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
