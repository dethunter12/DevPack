// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.DatabaseHandle
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using LcDevPack_TeamDamonA.Tools;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA
{
    public class DatabaseHandle
    {
        public static Connection connection = new Connection();
        private string Host = DatabaseHandle.connection.ReadSettings("Host");
        private string User = DatabaseHandle.connection.ReadSettings("User");
        private string Password = DatabaseHandle.connection.ReadSettings("Password");
        private string Database = DatabaseHandle.connection.ReadSettings("Database");
        private string language = DatabaseHandle.connection.ReadSettings("Language");
        private string name;
        public List<string> Menu;

        private string EncodeMySqlString(string value)
        {
            return value.Replace("\\", "\\\\").Replace("'", "\\'");
        }
        public string StringFromLanguage() //dethunter12 4/11/2018
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
        public List<string> SearchList(string searchString, string[] rowName, string tableName)
        {
            searchString = searchString.Replace("\\", "\\\\").Replace("'", "\\'");
            string lower = searchString.ToLower();
            string upper = searchString.ToUpper();
            string str1 = "";
            string namee = ""; // set the string equal to empty so it can be filled.
            //namee is grabed from the stringfromlanguage function
            namee = StringFromLanguage();
            //test to see that it actually is grabbing the name correctly.
            // MessageBox.Show(name);

            if (searchString.Length > 1)
                str1 = char.ToUpper(searchString[0]).ToString() + searchString.Substring(1);
            //dethunter12 4/11/2018 language change

            string cmdText = "SELECT a_index," + " " + namee + " FROM " + tableName + " WHERE" + " " + namee + " " + "LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR" + " " + namee + " " + "LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR" + " " + namee + " " + "LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR" + " " + namee + " " + " LIKE '%" + str1 + "%' OR a_index LIKE '%" + str1 + "%'" + " ORDER BY a_index;"; //dethunter12 test
            MySqlConnection connection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
            MySqlCommand mySqlCommand = new MySqlCommand(cmdText, connection);
            try
            {
                Menu = new List<string>();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                mySqlDataAdapter.SelectCommand = mySqlCommand;
                DataTable dataTable1 = new DataTable();
                mySqlDataAdapter.Fill(dataTable1);
                new BindingSource().DataSource = dataTable1;
                mySqlDataAdapter.Update(dataTable1);
                connection.Open();
                DataTable dataTable2 = new DataTable();
                mySqlCommand.ExecuteNonQuery();
                mySqlDataAdapter.Fill(dataTable2);
                Convert.ToString(mySqlCommand.ExecuteScalar());
                foreach (DataRow row in (InternalDataCollectionBase)dataTable2.Rows)
                {
                    string str2 = "";
                    for (int index = 0; index < rowName.Length; ++index)
                    {
                        str2 += row[rowName[index]].ToString();
                        if (index == 0 && rowName.Length > 1)
                            str2 += " - ";
                    }
                    Menu.Add(str2);
                }
                connection.Close();
                return Menu;
            }
            catch (Exception ex)
            {
                Menu = new List<string>();
                Menu.Add("Error");
                int num = (int)MessageBox.Show(ex.Message, "Error!");
                return Menu;
            }
        }


        public List<string> SelectMySqlReturnList(string[] rowName, string Host, string User, string Password, string Database, string Query)
        {
            MySqlConnection connection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
            MySqlCommand mySqlCommand = new MySqlCommand(Query, connection);
            try
            {
                
                Menu = new List<string>();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                mySqlDataAdapter.SelectCommand = mySqlCommand;
                DataTable dataTable1 = new DataTable();
                mySqlDataAdapter.Fill(dataTable1);
                new BindingSource().DataSource = dataTable1;
                mySqlDataAdapter.Update(dataTable1);
                connection.Open();
                DataTable dataTable2 = new DataTable();
                mySqlCommand.ExecuteNonQuery();
                mySqlDataAdapter.Fill(dataTable2);
                Convert.ToString(mySqlCommand.ExecuteScalar());
                foreach (DataRow row in (InternalDataCollectionBase)dataTable2.Rows)
                {
                    string str = "";
                    for (int index = 0; index < rowName.Length; ++index)
                    {
                        str += row[rowName[index]].ToString();
                        if (index == 0 && rowName.Length > 1)
                            str += " - ";
                    }
                    Menu.Add(str);
                }
                connection.Close();
                return Menu;
            }
            catch (Exception ex)
            {
                Menu = new List<string>();
                Menu.Add("Error");
                int num = (int)MessageBox.Show(ex.Message, "Error!");
                return Menu;
            }
        }

        public List<string> SelectMySqlExplodedReturnList(string[] rowName, string Host, string User, string Password, string Database, string Query)
        {
            Query.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'");
            MySqlConnection connection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
            MySqlCommand mySqlCommand = new MySqlCommand(Query, connection);
            try
            {
                Menu = new List<string>();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                mySqlDataAdapter.SelectCommand = mySqlCommand;
                DataTable dataTable1 = new DataTable();
                mySqlDataAdapter.Fill(dataTable1);
                new BindingSource().DataSource = dataTable1;
                mySqlDataAdapter.Update(dataTable1);
                connection.Open();
                DataTable dataTable2 = new DataTable();
                mySqlCommand.ExecuteNonQuery();
                mySqlDataAdapter.Fill(dataTable2);
                Convert.ToString(mySqlCommand.ExecuteScalar());
                foreach (DataRow row in (InternalDataCollectionBase)dataTable2.Rows)
                {
                    for (int index = 0; index < rowName.Length; ++index)
                    {
                        string str1 = row[rowName[index]].ToString();
                        char[] chArray = new char[1] { ' ' };
                        foreach (string str2 in str1.Split(chArray))
                            Menu.Add(str2);
                    }
                }
                connection.Close();
                return Menu;
            }
            catch (Exception ex)
            {
                Menu = new List<string>();
                Menu.Add("Error");
                int num = (int)MessageBox.Show(ex.Message, "Error!");
                return Menu;
            }
        }

        public string[] SelectMySqlReturnArray(string Host, string User, string Password, string Database, string Query, string[] rows)
        {
            try // Scura Exception Handler [25-05-22]
            {
                Query.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'");
                MySqlConnection connection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
                MySqlCommand mySqlCommand = new MySqlCommand(Query, connection);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                mySqlDataAdapter.SelectCommand = mySqlCommand;
                DataTable dataTable1 = new DataTable();
                mySqlDataAdapter.Fill(dataTable1);
                new BindingSource().DataSource = dataTable1;
                mySqlDataAdapter.Update(dataTable1);
                connection.Open();
                DataTable dataTable2 = new DataTable();
                mySqlCommand.ExecuteNonQuery();
                mySqlDataAdapter.Fill(dataTable2);
                Convert.ToString(mySqlCommand.ExecuteScalar());
                string[] strArray = new string[rows.Length];
                foreach (DataRow row in (InternalDataCollectionBase)dataTable2.Rows)
                {
                    for (int index = 0; index < rows.Length; ++index)
                    {
                        row[rows[index]].ToString();
                        strArray[index] = row[rows[index]].ToString();
                    }
                }
                connection.Close();
                return strArray;
            }
            catch (Exception ex) // Scura Catch Exception 
            {
                MessageBox.Show($"Error while connecting into server\n\n{ex}", "Mysql Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        bool abort_connection = false; //Scura - prevent multiple exceptions
        public void SendQueryMySql(string Host, string User, string Password, string Database, string Query)
        {
            if (abort_connection) //Scura
            {
                MessageBox.Show("Connection Aborted. Re-launch the application!", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Query.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'");
                MySqlConnection connection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
                MySqlCommand mySqlCommand = new MySqlCommand(Query, connection);
                connection.Open();
                mySqlCommand.ExecuteReader();
                connection.Close();
                abort_connection = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while sending mysql query to server. Exception:\n\n{ex}", "Error");
                abort_connection = true;
            }
        }

        public int CountByRow(string Host, string User, string Password, string Database, string Query)
        {
            MySqlConnection connection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
            MySqlCommand mySqlCommand = new MySqlCommand(Query, connection);
            connection.Open();
            int int32 = Convert.ToInt32(mySqlCommand.ExecuteScalar());
            connection.Close();
            return int32;
        }

        public Bitmap IconFast(int itemID)
        {
            Image image1 = Image.FromFile("icons/ItemBtn0.png");
            Bitmap bitmap1 = new Bitmap(32, 32);
            Graphics graphics1 = Graphics.FromImage((Image)bitmap1);
            Rectangle srcRect1 = new Rectangle(0, 0, 32, 32);
            graphics1.DrawImage(image1, 0, 0, srcRect1, GraphicsUnit.Pixel);
            graphics1.Dispose();
            if (itemID == -1)
                return bitmap1;
            ticon ticon = IconList.List.Find((Predicate<ticon>)(p => p.ItemID.Equals(itemID)));
            if (ticon == null)
                return bitmap1;
            int fileId = ticon.FileID;
            int row = ticon.Row;
            int col = ticon.Col;
            Image image2 = Image.FromFile("icons/ItemBtn" + fileId.ToString() + ".png");
            Bitmap bitmap2 = new Bitmap(32, 32);
            Graphics graphics2 = Graphics.FromImage((Image)bitmap2);
            int y = row * 32;
            Rectangle srcRect2 = new Rectangle(col * 32, y, 32, 32);
            graphics2.DrawImage(image2, 0, 0, srcRect2, GraphicsUnit.Pixel);
            graphics2.Dispose();
            return bitmap2;
        }

        public Bitmap SkillsFast(int SkillID)
        {
            Image image1 = Image.FromFile("icons/SkillBtn0.png");
            Bitmap bitmap1 = new Bitmap(32, 32);
            Graphics graphics1 = Graphics.FromImage((Image)bitmap1);
            Rectangle srcRect1 = new Rectangle(0, 0, 32, 32);
            graphics1.DrawImage(image1, 0, 0, srcRect1, GraphicsUnit.Pixel);
            graphics1.Dispose();
            if (SkillID == -1)
                return bitmap1;
            SkillIcon SkillIcon = IconSkill.List.Find((Predicate<SkillIcon>)(g => g.SkillID.Equals(SkillID)));
            if (SkillIcon == null)
                return bitmap1;
            int fileId = SkillIcon.FileID;
            int row = SkillIcon.Row;
            int col = SkillIcon.Col;
            Image image2 = Image.FromFile("icons/SkillBtn" + fileId.ToString() + ".png");
            Bitmap bitmap2 = new Bitmap(32, 32);
            Graphics graphics2 = Graphics.FromImage((Image)bitmap2);
            int y = row * 32;
            Rectangle srcRect2 = new Rectangle(col * 32, y, 32, 32);
            graphics2.DrawImage(image2, 0, 0, srcRect2, GraphicsUnit.Pixel);
            graphics2.Dispose();
            return bitmap2;
        }
        public Bitmap ActionFast(int ActionID)
        {
            Image image1 = Image.FromFile("icons/ActionBtn0.png");
            Bitmap bitmap1 = new Bitmap(32, 32);
            Graphics graphics1 = Graphics.FromImage((Image)bitmap1);
            Rectangle srcRect1 = new Rectangle(0, 0, 32, 32);
            graphics1.DrawImage(image1, 0, 0, srcRect1, GraphicsUnit.Pixel);
            graphics1.Dispose();
            if (ActionID == -1)
                return bitmap1;
            ActionIcon ActionIcon = IconAction.List.Find((Predicate<ActionIcon>)(g => g.ActionID.Equals(ActionID)));
            if (ActionIcon == null)
                return bitmap1;
            int fileId = ActionIcon.FileID;
            int row = ActionIcon.Row;
            int col = ActionIcon.Col;
            Image image2 = Image.FromFile("icons/ActionBtn" + fileId.ToString() + ".png");
            Bitmap bitmap2 = new Bitmap(32, 32);
            Graphics graphics2 = Graphics.FromImage((Image)bitmap2);
            int y = row * 32;
            Rectangle srcRect2 = new Rectangle(col * 32, y, 32, 32);
            graphics2.DrawImage(image2, 0, 0, srcRect2, GraphicsUnit.Pixel);
            graphics2.Dispose();
            return bitmap2;
        }

        public string ItemNameFast(int itemID)
        {
            if (itemID == -1)
                return "";
            ticon ticon = IconList.List.Find((Predicate<ticon>)(p => p.ItemID.Equals(itemID)));
            if (ticon == null)
                return "";
            return ticon.Name;
        }

        public string ItemDescrFast(int itemID) //dethunter12 item description fast implement
        {
            if (itemID == -1)
                return "None";
            ticon ticon = IconList.List.Find((Predicate<ticon>)(p => p.ItemID.Equals(itemID)));
            if (ticon == null)
                return "None";
            return ticon.Desc;
        }
        public string DrawBoxNameFromItem(int itemID) //dethunter12 draw box name from icon
        {
           
            
            if (itemID == -1)
                return "None";
          
            ticon ticon = IconList.List.Find((Predicate<ticon>)(p => p.ItemID.Equals(itemID)));
            if (ticon == null)
                return "None";
            int num1 = 0;

            string str = " select a_num_0 from t_item WHERE a_type_idx = 2 AND a_sub_type_idx = 9 AND ENABLE = 1 AND  a_index = '" + itemID + "';";
            MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
            MySqlCommand command = mySqlConnection.CreateCommand();
            command.CommandText = str;
            mySqlConnection.Open();
            MySqlDataReader mySqlDataReader = command.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                num1 = Convert.ToInt32(mySqlDataReader.GetValue(0));
                ticon.num0 = num1;
            }
            mySqlConnection.Close();
            if (itemID == 1838 || itemID == 1839 || itemID == 2135
               || itemID == 2136 || itemID == 2146 || itemID == 2148
               || itemID == 2407 || itemID == 2408 || itemID == 2500 || itemID == 2609 || itemID == 2666
               || itemID == 2710 || itemID == 2711 || itemID == 2712 || itemID == 2713 || itemID == 2714 || itemID == 2859 || itemID == 2860 || itemID == 2861 || itemID == 2862 || itemID == 2863
               || itemID == 2864 || itemID == 2882 || itemID == 2982 || itemID == 3575 || itemID == 3764 || itemID == 3769 || itemID == 4709 || itemID == 4911
               || itemID == 5018 || itemID == 5019 || itemID == 5067 || itemID == 5123 || itemID == 5124 || itemID == 5329 || itemID == 5347 || itemID == 5952 || itemID == 6251
               || itemID == 6256 || itemID == 6258 || itemID == 6259 || itemID == 6260 || itemID == 6593 || itemID == 6647 || itemID == 6648 || itemID == 6653 || itemID == 6697 || itemID == 6804
               || itemID == 6890 || itemID == 6891 || itemID == 7064 || itemID == 7210 || itemID == 7307 || itemID == 7308 || itemID == 7310
                || itemID == 7311 || itemID == 7320 || itemID == 7321 || itemID == 7336 || itemID == 7337 || itemID == 7394 || itemID == 7484
                || itemID == 7572 || itemID == 7573 || itemID == 7574 || itemID == 7575 || itemID == 7576 || itemID == 7577 || itemID == 7578 || itemID == 7579 || itemID == 7580 || itemID == 7612 || itemID == 7619 || itemID == 7620 || itemID == 7622 || itemID == 7623 || itemID == 7624
                || itemID == 7736 || itemID == 7898 || itemID == 9938 || itemID == 10022 || itemID == 10266 || itemID == 10286 || itemID == 10301 || itemID == 10799 || itemID == 11038)

                return "None";
            return ticon.Name;

        }

        public string MobNameFast(int MobIndex) //dethunter12 add 6/14/2018
        {
            if (MobIndex == -1)
                return "None";
            tNpc Tnpc = NpcList.List.Find((Predicate<tNpc>)(p => p.ItemID.Equals(MobIndex)));
            if (Tnpc == null)
                return "None";
            return Tnpc.Name;
        }

        public string SkillNameFast(int SkillIndex) //dethunter12 add 6/14/2018
        {
            if (SkillIndex == -1)
                return "None";
            tSkill skill = SkillList.List.Find((Predicate<tSkill>)(p => p.ItemID.Equals(SkillIndex)));
            if (skill == null)
                return "None";
            return skill.Name;
        }

    public Bitmap Icon(int ItemID)
    {
       int num1 = 0;
       int num2 = 0;
       int num3 = 0;
       string str = " select a_texture_id, a_texture_row, a_texture_col from t_item WHERE a_index ='" +  ItemID + "';";
       MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
       MySqlCommand command = mySqlConnection.CreateCommand();
       command.CommandText = str;
       mySqlConnection.Open();
       MySqlDataReader mySqlDataReader = command.ExecuteReader();
       while (mySqlDataReader.Read())
       {
         num1 = Convert.ToInt32(mySqlDataReader.GetValue(0));
         num2 = Convert.ToInt32(mySqlDataReader.GetValue(1));
         num3 = Convert.ToInt32(mySqlDataReader.GetValue(2));
       }
       Image image = Image.FromFile("icons/ItemBtn" + num1.ToString() + ".png");
       Bitmap bitmap = new Bitmap(32, 32);
       Graphics graphics = Graphics.FromImage((Image) bitmap);
       int y = num2 * 32;
       Rectangle srcRect = new Rectangle(num3 * 32, y, 32, 32);
       graphics.DrawImage(image, 0, 0, srcRect, GraphicsUnit.Pixel);
       graphics.Dispose();
       mySqlConnection.Close();
       return bitmap;
    }

    public Bitmap IconItem(int FileID, int Row, int Col)
    {
      Image image = Image.FromFile("icons/ItemBtn" + FileID.ToString() + ".png");
      Bitmap bitmap = new Bitmap(32, 32);
      Graphics graphics = Graphics.FromImage((Image) bitmap);
      int y = Row * 32;
      Rectangle srcRect = new Rectangle(Col * 32, y, 32, 32);
      graphics.DrawImage(image, 0, 0, srcRect, GraphicsUnit.Pixel);
      graphics.Dispose();
      return bitmap;
    }

    public Bitmap IconSkill1(int FileID, int Row, int Col)
    {
      Image image = Image.FromFile("icons/SkillBtn" + FileID.ToString() + ".png");
      Bitmap bitmap = new Bitmap(32, 32);
      Graphics graphics = Graphics.FromImage((Image) bitmap);
      int y = Row * 32;
      Rectangle srcRect = new Rectangle(Col * 32, y, 32, 32);
      graphics.DrawImage(image, 0, 0, srcRect, GraphicsUnit.Pixel);
      graphics.Dispose();
      return bitmap;
    }
    public Bitmap IconActionn(int FileID, int Row, int Col)
     {
        Image image = Image.FromFile("icons/ActionBtn" + FileID.ToString() + ".png");
        Bitmap bitmap = new Bitmap(32, 32);
        Graphics graphics = Graphics.FromImage((Image)bitmap);
        int y = Row * 32;
        Rectangle srcRect = new Rectangle(Col * 32, y, 32, 32);
        graphics.DrawImage(image, 0, 0, srcRect, GraphicsUnit.Pixel);
        graphics.Dispose();
        return bitmap;
     }

    public Bitmap IconItemCollection(int FileID, int Row, int Col)
    {
      Image image = Image.FromFile("icons/ItemCollectionBtn" + FileID.ToString() + ".png");
      Bitmap bitmap = new Bitmap(60, 60);
      Graphics graphics = Graphics.FromImage((Image) bitmap);
      int y = Row * 60;
      Rectangle srcRect = new Rectangle(Col * 60, y, 60, 60);
      graphics.DrawImage(image, 0, 0, srcRect, GraphicsUnit.Pixel);
      graphics.Dispose();
      return bitmap;
    }

    public string FunctionItemName(int itemID)
    {
      string str1 = " select a_name from t_item WHERE a_index ='" +  itemID + "';";
      MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
      MySqlCommand command = mySqlConnection.CreateCommand();
      command.CommandText = str1;
      mySqlConnection.Open();
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      string str2 = "";
      while (mySqlDataReader.Read())
        str2 = mySqlDataReader.GetValue(0).ToString();
      mySqlConnection.Close();
      return str2;
    }

    public string FunctionMonsterName(int MonsterID)
    {
      string str1 = "select a_name from t_npc WHERE a_index ='" +  MonsterID + "';";
      MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
      MySqlCommand command = mySqlConnection.CreateCommand();
      command.CommandText = str1;
      mySqlConnection.Open();
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      string str2 = "";
      while (mySqlDataReader.Read())
        str2 = mySqlDataReader.GetValue(0).ToString();
      mySqlConnection.Close();
      return str2;
    }

    public string FunctionQuestName(int QuestID)
    {
      string str1 = " select a_name from t_quest WHERE a_index ='" +  QuestID + "';";
      MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
      MySqlCommand command = mySqlConnection.CreateCommand();
      command.CommandText = str1;
      mySqlConnection.Open();
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      string str2 = "";
      while (mySqlDataReader.Read())
        str2 = mySqlDataReader.GetValue(0).ToString();
      mySqlConnection.Close();
      return str2;
    }
  }
}
