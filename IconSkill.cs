// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.IconSkill
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace LcDevPack_TeamDamonA
{
  internal class IconSkill
  {
    public static System.Collections.Generic.List<SkillIcon> List = new System.Collections.Generic.List<SkillIcon>(); //ticon for SkillIcon
    public static string LoadFromDatabaseSQL = "SELECT * FROM t_skill ORDER BY a_index";
    public static Connection connection = new Connection();
    public static string Host = IconSkill.connection.ReadSettings("Host");
    public static string User = IconSkill.connection.ReadSettings("User");
    public static string Password = IconSkill.connection.ReadSettings("Password");
    public static string Database = IconSkill.connection.ReadSettings("Database");
    public static MySqlConnection mysqlCon;
    public static string ConnectionString;

    public static bool SetConnection()
    {
      IconSkill.ConnectionString = string.Format("Data Source={0};Database={1};User ID={2};Password={3};",  IconSkill.Host,  IconSkill.Database,  IconSkill.User, "'" + IconSkill.Password + "'");
      return true;
    }

    public static DataTable GetFromQuery(string query)
    {
      DataTable dataTable = new DataTable();
      using (IconSkill.mysqlCon = new MySqlConnection(IconSkill.ConnectionString))
      {
            IconSkill.mysqlCon.Open();
        MySqlDataReader mySqlDataReader = MySqlHelper.ExecuteReader(IconSkill.mysqlCon, query);
        dataTable.Load((IDataReader) mySqlDataReader);
        IconSkill.mysqlCon.Close();
      }
      return dataTable;
    }

    public static void Import()
    {
      foreach (DataRow row in (InternalDataCollectionBase)IconSkill.GetFromQuery(IconSkill.LoadFromDatabaseSQL).Rows)
        IconSkill.List.Add(new SkillIcon()
        {
          SkillID = Convert.ToInt32(row["a_index"]),
          FileID = Convert.ToInt32(row["a_client_icon_texid"]),
          Row = Convert.ToInt32(row["a_client_icon_row"]),
          Col = Convert.ToInt32(row["a_client_icon_col"]),
          Name = Convert.ToString(row["a_name_usa"]),
          Desc = Convert.ToString(row["a_client_description_usa"]) //dethunter12 add
        });
    }
  }
}
