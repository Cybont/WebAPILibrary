using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace WebAPILibrary
{
    public class SqlHandler<T, TKey>
    {
        private readonly string _connectionString;
        //private readonly string _sqlCommand;

        private SqlConnection _conn;

        public SqlDataReader Reader;

        /// <summary>
        /// Executes SQL commands
        /// </summary>
        /// <param name="cmd">Querystring</param>
        /// <param name="conn">Connection string for Database</param>
        /// <param name="http">HTTP Actions: Get, GetOne Post, Put </param>
        public SqlHandler(string conn)
        {
            //_sqlCommand = cmd;
            _connectionString = conn;

            //SqlConnect();

            //switch (http)
            //{
            //    default:
            //        break;
            //    case "Get":
            //        break;
            //    case "GetOne":
            //        break;
            //    case "Post":
            //        break;
            //    case "Put":
            //        break;
            //}

            //_conn.Close();
        }

        public void SqlConnect()
        {
                _conn.ConnectionString = _connectionString;
                _conn.Open();
        }

        public List<T> Get(string cmd)
        {
            SqlConnect();
            SqlCommand command = new SqlCommand(cmd);
            Reader = command.ExecuteReader();
            List<T> list = new List<T>();
            while (Reader.Read())
            {
            }
            
            return list;
        }
        public void GetOne(string cmd, TKey key)
        {
            SqlConnect();

            _conn.Close();
        }
        public void Post(string cmd, List<T> list)
        {
            SqlConnect();

            _conn.Close();
        }
        public void Put(string cmd)
        {
            SqlConnect();

            _conn.Close();
        }


        public void Close()
        {
            _conn.Close();
        }


    }
}
