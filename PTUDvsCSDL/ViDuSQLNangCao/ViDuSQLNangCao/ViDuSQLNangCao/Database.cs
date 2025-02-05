﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ViDuSQLNangCao
{
    class Database
    {
        private static string connectionString = @"Data Source=LHB\SQLEXPRESS;Initial Catalog=ViDuSQLNangCao;Integrated Security=True";
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

        public static DataTable Query(string sql,Dictionary<string,object> Dictionary)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable table = new DataTable();
            foreach(string key in Dictionary.Keys)
            {
                adapter.SelectCommand.Parameters.AddWithValue(key, Dictionary[key]);
            }
            adapter.Fill(table);
            connection.Close();
            return table;
        }

        public static void Execute(string sql)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void Execute(string sql, Dictionary<string, object> Dictionary)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql);
            foreach(string key in Dictionary.Keys)
            {
                cmd.Parameters.AddWithValue(key, Dictionary[key]);
            }
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
