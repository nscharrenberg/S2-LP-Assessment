using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE2_LP_Application.DAL
{
    class SqlDataAccessObject
    {
        public string connectionString = "server=LAPTOP-P13PI4CQ;database=SE2LP;uid=sa;password=banaan;";

        public SqlCommand GetSqlCommand(string query)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, conn);
            return cmd;
        }

        public DataTable Execute(string query)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = GetSqlCommand(query);
            cmd.Connection.Open();
            dt.Load(cmd.ExecuteReader());
            cmd.Connection.Close();

            return dt;
        }

        public DataTable Execute(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            cmd.Connection.Open();
            dt.Load(cmd.ExecuteReader());
            cmd.Connection.Close();

            return dt;
        }

        public int ExecuteNonQuery(string query)
        {
            SqlCommand cmd = GetSqlCommand(query);
            cmd.Connection.Open();
            int results = cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            return results;
        }

        public int ExecuteNonQuery(SqlCommand cmd)
        {
            cmd.Connection.Open();
            int results = cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            return results;
        }
    }
}
