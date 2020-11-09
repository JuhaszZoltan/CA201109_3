using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201109_3
{
    class Program
    {
        static SqlConnection conn;
        static void Main()
        {
            conn = new SqlConnection(
                @"Server=(localdb)\MSSQLLocalDB;" +
                @"AttachDbFileName=|DataDirectory|\Res\teszt2.mdf;" +
                "Trusted_Connection=True;");

            conn.Open();

            new SqlCommand("INSERT INTO emberek (orszagId, nev) VALUES (1, 'Zsófika');", conn)
                .ExecuteNonQuery();

            var sql = new SqlCommand("SELECT * FROM emberek;", conn);
            var r = sql.ExecuteReader();
            while (r.Read()) Console.WriteLine(r[2]);

            conn.Close();
            Console.ReadKey();

        }
    }
}
