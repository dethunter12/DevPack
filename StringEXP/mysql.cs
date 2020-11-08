//-----------------------------------------------------------------------------------------
//
// 13.11.14 현재 개발용 MySQL 4.0.x 버전 사용으로 .Net / Connect 5.1.x 이하 버전 사용해야 함.
//

using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using LcDevPack_TeamDamonA;
using LcDevPack_TeamDamonA.Tools;

namespace UTIL
{
    class mysql
    {
       // private MySqlConnection _conn;
        public static MySqlConnection connection = new MySqlConnection();
        private string Host = AffinityEditor.connection.ReadSettings("Host");
        private readonly string User = AffinityEditor.connection.ReadSettings("User");
        private string Password = AffinityEditor.connection.ReadSettings("Password");
        private string Database = AffinityEditor.connection.ReadSettings("Database");
        public DataTable dt
        {
            get
            {
                return _dt;
            }
        }

        private DataTable _dt;

        public bool Connect()
        {
            if (connection != null)
                connection.Close();

            string connStr = String.Format("server={0};user id={1}; password={2}; database={3}; ",
                Host, User, Password, Database);

            connStr += "pooling=false;" +
                       "Charset=latin1;" +
                       "Respect Binary Flags=false;";

            try
            {
                connection = new MySqlConnection(connStr);

                return true;
                
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error connecting to the server: " + ex.Message);
            }

            return false;
        }

        public DataTable Query(string strQuery)
        {
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(strQuery, connection);
            MySqlDataAdapter returnVal = new MySqlDataAdapter(strQuery, connection);
            _dt = new DataTable();
            returnVal.Fill(_dt);

            connection.Close();

            return _dt;
        }

        public void Close()
        {
            if (connection != null)
                connection.Close();
        }
    }
}
