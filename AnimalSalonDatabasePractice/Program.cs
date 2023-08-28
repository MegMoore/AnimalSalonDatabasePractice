
using Microsoft.Data.SqlClient;

var connStr = "server=localhost\\sqlexpress;" + //connection string
    "database=AnimalGroomingSalon;" +
    "trusted_connection=true;" +
    "trustServerCertificate=true;";

var conn = new SqlConnection(connStr);
conn.Open();

if(conn.State != System.Data.ConnectionState.Open)
{
    throw new Exception("The connection did not open!");

}

///////// Begin Coding Here //////////////


Console.WriteLine("Hello");






conn.Close();