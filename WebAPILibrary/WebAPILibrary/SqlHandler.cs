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

        /// <summary>
        /// Executes SQL commands
        /// </summary>
        /// <param name="cmd">Querystring</param>
        /// <param name="conn">Connection string for Database</param>
        /// <param name="http">HTTP Actions: Get, GetOne Post, Put </param>
        public SqlHandler(string cmd, string conn, string http = "")
        {
            _sqlCommand = cmd;
            _connectionString = conn;

            SqlConnect();

            switch (http)
            {
                default:
                    break;
                case "Get":
                    break;
                case "GetOne":
                    break;
                case "Post":
                    break;
                case "Put":
                    break;
            }
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
