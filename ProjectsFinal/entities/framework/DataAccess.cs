using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;





namespace framework
{
    public class DataAccess
    {

        string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\all information\essential thing boi,software,,,,,\poralekha\9th semester1\c#\school_managment_System\ProjectsFinal\StudentDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

        public void Execute(SqlCommand command)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            command.Connection = connection;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable Query(SqlCommand command)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(connectionString);
            command.Connection = connection;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            connection.Open();
            dataAdapter.Fill(dataTable);
            connection.Close();

            return dataTable;
        }
        public void updateDatabase(SqlCommand command)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            command.Connection = connection;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            connection.Open();
            dataAdapter.Fill(dataTable);
            connection.Close();
        } 
    }
}
