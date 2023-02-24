// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.IconList
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace LcDevPack_TeamDamonA
{
  public class IconList
  {
    public static System.Collections.Generic.List<ticon> List = new System.Collections.Generic.List<ticon>();
        public static string LoadFromDatabaseSQL = "SELECT a_index, a_name_ger, a_name_usa, a_name_frc, a_name_pld, a_name_brz, a_name_rus, a_name_mex, a_name_spn, a_name_thai, a_name_ita, a_texture_id, a_texture_row, a_texture_col, a_descr_usa, a_descr_ger, a_descr_ita, a_descr_thai, a_descr_spn, a_descr_frc, a_descr_pld, a_descr_brz, a_descr_mex, a_descr_rus, a_num_0  FROM t_item ORDER BY a_index";
        public static Connection connection = new Connection();
    public static string Host = IconList.connection.ReadSettings("Host");
    public static string User = IconList.connection.ReadSettings("User");
    public static string Password = IconList.connection.ReadSettings("Password");
    public static string Database = IconList.connection.ReadSettings("Database");
    public static string language = IconList.connection.ReadSettings("Language");//dethunter12 language selection
    public static MySqlConnection mysqlCon;
    public static string ConnectionString;
    public static string namee; //dethunter12 stringfrom lang modify
    public static string descrr; //dethunter12 stringform 2/5/2020

        public  static string DescrFromLanguage() //dethunter12 4/11/2018
        {

            if (language == "GER")
            {
                return "a_descr_ger";
            }
            else if (language == "POL")
            {
                return "a_descr_pld";
            }
            else if (language == "BRA")
            {
                return "a_descr_brz";
            }
            else if (language == "RUS")
            {
                return "a_descr_rus";
            }
            else if (language == "FRA")
            {
                return "a_descr_frc";
            }
            else if (language == "ESP")
            {
                return "a_descr_spn";
            }
            else if (language == "MEX")
            {
                return "a_descr_mex";
            }
            else if (language == "THA")
            {
                return "a_descr_thai";
            }
            else if (language == "ITA")
            {
                return "a_descr_ita";
            }
            else if (language == "USA")
            {
                return "a_descr_usa";
            }
            else
            {
                return null;
            }
        }

        public static string StringFromLanguage() //dethunter12 5/10/2018
        {
            if (language == "GER")
            {
                return "a_name_ger";
            }
            else if (language == "POL")
            {
                return "a_name_pld";
            }
            else if (language == "BRA")
            {
                return "a_name_brz";
            }
            else if (language == "RUS")
            {
                return "a_name_rus";
            }
            else if (language == "FRA")
            {
                return "a_name_frc";
            }
            else if (language == "ESP")
            {
                return "a_name_spn";
            }
            else if (language == "MEX")
            {
                return "a_name_mex";
            }
            else if (language == "THA")
            {
                return "a_name_thai";
            }
            else if (language == "ITA")
            {
                return "a_name_ita";
            }
            else if (language == "USA")
            {
                return "a_name_usa";
            }
            else
            {
                return null;
            }
        }
     public static bool SetConnection()
    {
      IconList.ConnectionString = string.Format("Data Source={0};Database={1};User ID={2};Password={3};",  IconList.Host,  IconList.Database,  IconList.User,  IconList.Password);
      return true;
    }

    public static DataTable GetFromQuery(string query)
    {
      DataTable dataTable = new DataTable();
      using (IconList.mysqlCon = new MySqlConnection(IconList.ConnectionString))
      {
        IconList.mysqlCon.Open();
        MySqlDataReader mySqlDataReader = MySqlHelper.ExecuteReader(IconList.mysqlCon, query);
        dataTable.Load((IDataReader) mySqlDataReader);
        IconList.mysqlCon.Close();
      }
      return dataTable;
    }

    public static void Import()
    {
            namee = StringFromLanguage(); //dethunter12 test
            descrr = DescrFromLanguage();

            foreach (DataRow row in (InternalDataCollectionBase)IconList.GetFromQuery(IconList.LoadFromDatabaseSQL).Rows)

                IconList.List.Add(new ticon()
                {
                  
          ItemID = Convert.ToInt32(row["a_index"]),
          FileID = Convert.ToInt32(row["a_texture_id"]),
          Row = Convert.ToInt32(row["a_texture_row"]),
          Col = Convert.ToInt32(row["a_texture_col"]),
          Name = Convert.ToString(row["" +namee + ""]), //dethunter12 test
          Desc = Convert.ToString(row["" +descrr + ""]), //dethunter12 2/5/2020
          num0 = Convert.ToInt32(row["a_num_0"])
        });
    }
  }
}
