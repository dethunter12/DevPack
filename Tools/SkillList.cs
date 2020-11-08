using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace LcDevPack_TeamDamonA.Tools
{
    public class SkillList
    {
        public static System.Collections.Generic.List<tSkill> List = new System.Collections.Generic.List<tSkill>();
        public static string LoadFromDatabaseSQL = "SELECT a_index, a_name_ger, a_name_usa, a_name_frc, a_name_pld, a_name_brz, a_name_rus, a_name_mex, a_name_spn, a_name_thai, a_name_ita  FROM t_skill ORDER BY a_index";
        public static Connection connection = new Connection();
        public static string Host = SkillList.connection.ReadSettings("Host");
        public static string User = SkillList.connection.ReadSettings("User");
        public static string Password = SkillList.connection.ReadSettings("Password");
        public static string Database = SkillList.connection.ReadSettings("Database");
        public static string language = SkillList.connection.ReadSettings("Language");//dethunter12 language selection
        public static MySqlConnection mysqlCon;
        public static string ConnectionString;
        public static string namee; //dethunter12 stringfrom lang modify
        public static string StringFromLanguage() //dethunter12 5/10/2018
        {

            if (language == "GER")
            {
                namee = "a_name_ger";
                return namee;

            }
            else if (language == "POL")
            {
                namee = "a_name_pld";
                return namee;

            }
            else if (language == "BRA")
            {
                namee = "a_name_brz";
                return namee;
            }
            else if (language == "RUS")
            {
                namee = "a_name_rus";
                return namee;
            }
            else if (language == "FRA")
            {
                namee = "a_name_frc";
                return namee;
            }
            else if (language == "ESP")
            {
                namee = "a_name_spn";
                return namee;
            }
            else if (language == "MEX")
            {
                namee = "a_name_mex";
                return namee;
            }
            else if (language == "THA")
            {
                namee = "a_name_thai";
                return namee;
            }
            else if (language == "ITA")
            {
                namee = "a_name_ita";
                return namee;
            }
            else if (language == "USA")
            {
                namee = "a_name_usa";
                return namee;
            }
            else
            {
                return null;
            }
        }

        public static bool SetConnection()
        {
            ConnectionString = string.Format("Data Source={0};Database={1};User ID={2};Password={3};", SkillList.Host, SkillList.Database, SkillList.User, SkillList.Password);
            return true;
        }

        public static DataTable GetFromQuery(string query)
        {
            DataTable dataTable = new DataTable();
            using (SkillList.mysqlCon = new MySqlConnection(ConnectionString))
            {
                SkillList.mysqlCon.Open();
                MySqlDataReader mySqlDataReader = MySqlHelper.ExecuteReader(SkillList.mysqlCon, query);
                dataTable.Load((IDataReader)mySqlDataReader);
                SkillList.mysqlCon.Close();
            }
            return dataTable;
        }

        public static void Import()
        {
            namee = StringFromLanguage(); //dethunter12 test
            foreach (DataRow row in (InternalDataCollectionBase)SkillList.GetFromQuery(SkillList.LoadFromDatabaseSQL).Rows)

                SkillList.List.Add(new tSkill()
                {

                    ItemID = Convert.ToInt32(row["a_index"]),
                    Name = Convert.ToString(row["" + namee + ""]), //dethunter12 test
                  
                });
        }
    }
}
