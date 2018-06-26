using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = "Server=tcp:srvka.database.windows.net,1433;Initial Catalog=db;Persist Security Info=False;User ID=agnaldo;Password=Pa55w.rd1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";  //servidos, database, autenticacao
            //first criar um using para o sqlconnection
            using (var c = new SqlConnection(cs))
            {
                var cmd = "SELECT * FROM PESSOA";

                using (var k = new System.Data.SqlClient.SqlCommand(cmd, c))
                {
                    c.Open();

                    var dr = k.ExecuteReader();

                    while (dr.Read())
                    {
                        Console.WriteLine("{0,-5}{1,50}", dr[0], dr[1]);
                    }
                    c.Close();
                }
                Console.ReadKey();
            }
        }
    }
}
