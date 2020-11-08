// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.Tools.MemoryWorker.mySQL
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using MySql.Data.MySqlClient;
using StringExporter;
using System.Data;

namespace LcDevPack_TeamDamonA.Tools.MemoryWorker
{
  public class mySQL
  {
    public static MySqlConnection mysqlCon;
    public static string ConnectionString;
        public static Connection connection = new Connection();
        private DataTable _dt;
        private string Host = FormExport.connection.ReadSettings("Host");
        private string User = FormExport.connection.ReadSettings("User");
        private string Password = FormExport.connection.ReadSettings("Password");
        private string Database = FormExport.connection.ReadSettings("Database");

        public DataTable dt
        {
            get
            {
                return _dt;
            }
        }

        public static bool SetConnection()
    {
      config.ReadConfig();
      mySQL.ConnectionString = config.ConfigString;
      return true;
    }

    public static DataTable GetFromQuery(string query)
    {
      DataTable dataTable = new DataTable();
      using (mySQL.mysqlCon = new MySqlConnection(mySQL.ConnectionString))
      {
        mySQL.mysqlCon.Open();
        MySqlDataReader mySqlDataReader = MySqlHelper.ExecuteReader(mySQL.mysqlCon, query);
        dataTable.Load(mySqlDataReader);
        mySQL.mysqlCon.Close();
      }
      return dataTable;
    }
        public DataTable Query(string strQuery)
        {
            MySqlConnection Mysql = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
            Mysql.Open();

            MySqlCommand cmd = new MySqlCommand(strQuery, Mysql);
            MySqlDataAdapter returnVal = new MySqlDataAdapter(strQuery, Mysql);
            _dt = new DataTable();
            returnVal.Fill(_dt);

            Mysql.Close();

            return _dt;
        }

        public static DataTable GetFromQueryIcon(string query)
        {
            DataTable dataTable = new DataTable();
            using (mySQL.mysqlCon = new MySqlConnection(mySQL.ConnectionString))
            {
                mySQL.mysqlCon.Open();
                MySqlDataReader mySqlDataReader = MySqlHelper.ExecuteReader(mySQL.mysqlCon, query);
                dataTable.Load(mySqlDataReader);
                mySQL.mysqlCon.Close();
            }
            return dataTable;
        }

        public static object SingleQuery(string query)
    {
      object obj;
      using (mySQL.mysqlCon = new MySqlConnection(mySQL.ConnectionString))
      {
        mySQL.mysqlCon.Open();
        obj = MySqlHelper.ExecuteScalar(mySQL.mysqlCon, query);
      }
      return obj;
    }

    public static void UpdateQuery(string query)
    {
      using (mySQL.mysqlCon = new MySqlConnection(mySQL.ConnectionString))
      {
        mySQL.mysqlCon.Open();
        MySqlHelper.ExecuteNonQuery(mySQL.mysqlCon, query);
      }
    }
  }
}
