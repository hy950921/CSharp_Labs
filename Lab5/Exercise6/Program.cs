using System;
using System.Data.SqlClient;


namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            SqlConnection conn = new SqlConnection("MyConnectString");
            SqlCommand cmd = new SqlCommand("sp_Myproc", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            //And
            SqlConnection conn1 = new SqlConnection("Myconnectstring");
            SqlCommand cmd1 = new SqlCommand("sp_Myproc", conn1);
            using(conn1)
            {
                conn1.Open();
                cmd1.ExecuteNonQuery();
            }


        }
    }
}
