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
        public  static string StringFromLanguage() 
        {

            if (language == "GER")
            {

                name = "a_name_ger";
                return name;

            }
            else if (language == "POL")
            {
                name = "a_name_pld";
                return name;

            }
            else if (language == "BRA")
            {
                name = "a_name_brz";
                return name;
            }
            else if (language == "RUS")
            {
                name = "a_name_rus";
                return name;
            }
            else if (language == "FRA")
            {
                name = "a_name_frc";
                return name;
            }
            else if (language == "ESP")
            {
                name = "a_name_spn";
                return name;
            }
            else if (language == "MEX")
            {
                name = "a_name_mex";
                return name;
            }
            else if (language == "THA")
            {
                name = "a_name_thai";
                return name;
            }
            else if (language == "ITA")
            {
                name = "a_name_ita";
                return name;
            }
            else if (language == "USA")
            {
                name = "a_name_usa";
                return name;
            }
            else
            {
                return null;
            }
        }

        public static string DescripFromLanguage()
        {
            if (language == "GER")
            {

                descr = "a_client_description_ger";
                return descr;

            }
            else if (language == "POL")
            {
                descr = "a_client_description_pld";
                return descr;

            }
            else if (language == "BRA")
            {
                descr = "a_client_description_brz";
                return descr;
            }
            else if (language == "RUS")
            {
                descr = "a_client_description_rus";
                return descr;
            }
            else if (language == "FRA")
            {
                descr = "a_client_description_frc";
                return descr;
            }
            else if (language == "ESP")
            {
                descr = "a_client_description_spn";
                return descr;
            }
            else if (language == "MEX")
            {
                descr = "a_client_description_mex";
                return descr;
            }
            else if (language == "THA")
            {
                descr = "a_client_description_thai";
                return descr;
            }
            else if (language == "ITA")
            {
                descr = "a_client_description_ita";
                return descr;
            }
            else if (language == "USA")
            {
                descr = "a_client_description_usa";
                return descr;
            }
            else
            {
                return null;
            }
        }

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
            name = StringFromLanguage();
            descr = DescripFromLanguage();

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

