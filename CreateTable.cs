using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    class CreateTable
    {
        static void Main(string[] args)
        {
            new CreateTable().TableCreation();
        }
        public void TableCreation()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source = JAGADEESH\SQLEXPRESS; Initial Catalog = Student; Integrated Security = True");
                SqlCommand cm = new SqlCommand("create table stu1(id int not null,name varchar(100), email varchar(50))", con);  
                con.Open();
                cm.ExecuteNonQuery();
                Console.WriteLine("Table created Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
