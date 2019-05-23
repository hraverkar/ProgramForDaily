using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
  class Program
  {
    static void Main()
    {
      string ConnectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TestDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
      SqlConnection sqlConnection = new SqlConnection(ConnectionString);
      string sql = "Select * from Customers order by Name DESC ;";
      SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
      sqlConnection.Open();
      SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
      Console.WriteLine("CustomerID , Name, Address");
      Console.WriteLine("-------------------------------");
      while (sqlDataReader.Read())
      {
        Console.WriteLine(sqlDataReader["Id"].ToString());
        Console.WriteLine(sqlDataReader["Name"].ToString());
        Console.WriteLine(sqlDataReader["Address"].ToString());
        Console.WriteLine("__________________________________");
      }
      sqlDataReader.Close();
      sqlConnection.Close();
    }
  }
}
