using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace framework
{
  public class DataAcess
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Servent of ALLAH\Downloads\StudentDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

        public void Execute(SqlCommand command)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            command.Connection = connection;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
