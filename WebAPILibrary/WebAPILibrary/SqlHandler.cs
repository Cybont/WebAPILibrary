using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace WebAPILibrary
{
    public class SqlHandler
    {
        private readonly string _connectionString;
        private readonly string _sqlCommand;

        private SqlConnection _conn;

        public SqlDataReader Reader;

        public SqlHandler(string cmd, string conn)
        {
            _sqlCommand = cmd;
            _connectionString = conn;
        }

        public void SqlConnect()
        {
            using (_conn = new SqlConnection())
            {
                _conn.ConnectionString = _connectionString;
                _conn.Open();
            }
        }





    }
}
