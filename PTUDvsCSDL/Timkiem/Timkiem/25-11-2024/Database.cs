using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _25_11_2024
{
    class Database
    {
        private static string connectionString = @"Data Source=LHB\SQLEXPRESS;Initial Catalog=xinchao;Integrated Security=True";

        private static SqlConnection connection;

        public static DataTable Query(string sql)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }

        public static void Execute(string sql)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable Query(string sql, Dictionary<string,object> dictionary)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            foreach(string key in dictionary.Keys)
            {
                adapter.SelectCommand.Parameters.AddWithValue(key, dictionary[key]);
            }
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }


        public static void Execute(string sql, Dictionary<string, object> dictionary)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            foreach(string key in dictionary.Keys)
            {
                command.Parameters.AddWithValue(key, dictionary[key]);
            }
            command.ExecuteNonQuery();
            connection.Close();
        }
       

        
    }
}
