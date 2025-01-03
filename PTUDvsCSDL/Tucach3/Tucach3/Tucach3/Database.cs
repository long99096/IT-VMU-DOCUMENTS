using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Tucach3
{
    class Database
    {
        private static string connectionString = @"Data Source=LHB\SQLEXPRESS;Initial Catalog=BuiHoangLong_99096_KT3;Integrated Security=True";
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

        public static DataTable Query(string sql, Dictionary<string, object> dictionary)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable table = new DataTable();
            foreach (string key in dictionary.Keys)
            {
                adapter.SelectCommand.Parameters.AddWithValue(key, dictionary[key]);
            }
            adapter.Fill(table);
            connection.Close();
            return table;
        }

        public static void Execute(string sql)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void Execute(string sql, Dictionary<string, object> dictionary)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            foreach (string key in dictionary.Keys)
            {
                cmd.Parameters.AddWithValue(key, dictionary[key]);
            }
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
