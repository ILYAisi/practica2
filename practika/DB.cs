using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace practika
{
    internal class DB
    {
        MySqlConnection connection = new MySqlConnection("server=git.chtotib.ru ; port=3306 ; username=ws_005 ; password=altai1; database=usersdb");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }sdfadsf
    }
}
