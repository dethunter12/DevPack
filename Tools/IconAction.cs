using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LcDevPack_TeamDamonA.Tools
{
    internal class IconAction
    {
        public static List<ActionIcon> List = new System.Collections.Generic.List<ActionIcon>(); 
        public static string LoadFromDatabaseSQL = "SELECT * FROM t_action ORDER BY a_index";
        public static Connection connection = new Connection();
        public static string Host = connection.ReadSettings("Host");
        public static string User = connection.ReadSettings("User");
        public static string Password = connection.ReadSettings("Password");
        public static string Database = connection.ReadSettings("Database");
        public static string language = connection.ReadSettings("Language");
        public static MySqlConnection mysqlCon;
        public static string ConnectionString;
        public static string name;
        public static string descr;

        public static bool SetConnection()
        {
            ConnectionString = string.Format("Data Source={0};Database={1};User ID={2};Password={3};", IconAction.Host, IconAction.Database, IconAction.User, "'" + IconAction.Password + "'");
            return true;
        }

        public static DataTable GetFromQuery(string query)
        {
            DataTable dataTable = new DataTable();
            using (mysqlCon = new MySqlConnection(ConnectionString))
            {
                mysqlCon.Open();
                MySqlDataReader mySqlDataReader = MySqlHelper.ExecuteReader(mysqlCon, query);
                dataTable.Load((IDataReader)mySqlDataReader);
                mysqlCon.Close();
            }
            return dataTable;
        }
        public static void Import()
        {
            name = LanguageHelper.StringFromLanguage();
            descr = LanguageHelper.ActionDescFromLanguage();

            foreach (DataRow row in (InternalDataCollectionBase)GetFromQuery(LoadFromDatabaseSQL).Rows)
                IconAction.List.Add(new ActionIcon()
                {
                   
                    ActionID = Convert.ToInt32(row["a_index"]),
                    FileID = Convert.ToInt32(row["a_iconid"]),
                    Row = Convert.ToInt32(row["a_iconrow"]),
                    Col = Convert.ToInt32(row["a_iconcol"]),
                    Name = Convert.ToString(row["" + name + ""]),
                    Desc = Convert.ToString(row["" + descr + ""]) //dethunter12 add
                }) ;
        }
    }
}

