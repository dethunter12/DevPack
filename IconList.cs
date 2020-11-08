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
                descrr = "a_descr_ger";
                return descrr;

            }
            else if (language == "POL")
            {
                descrr = "a_descr_pld";
                return descrr;

            }
            else if (language == "BRA")
            {
                descrr = "a_descr_brz";
                return descrr;
            }
            else if (language == "RUS")
            {
                descrr = "a_descr_rus";
                return descrr;
            }
            else if (language == "FRA")
            {
                descrr = "a_descr_frc";
                return descrr;
            }
            else if (language == "ESP")
            {
                descrr = "a_descr_spn";
                return descrr;
            }
            else if (language == "MEX")
            {
                descrr = "a_descr_mex";
                return descrr;
            }
            else if (language == "THA")
            {
                descrr = "a_descr_thai";
                return descrr;
            }
            else if (language == "ITA")
            {
                descrr = "a_descr_ita";
                return descrr;
            }
            else if (language == "USA")
            {
                descrr = "a_descr_usa";
                return descrr;
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
