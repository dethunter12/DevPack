// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.ExportLodHandle
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

//using Checksum;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA
{
  public class ExportLodHandle
  {
    private string Host = ExportLodHandle.connection.ReadSettings("Host");
    private string User = ExportLodHandle.connection.ReadSettings("User");
    private string Password = ExportLodHandle.connection.ReadSettings("Password");
    private string Database = ExportLodHandle.connection.ReadSettings("Database");
    private DatabaseHandle databaseHandle = new DatabaseHandle();
    private MessageHandle messageHandle = new MessageHandle();
    public static Connection connection = new Connection();
    public List<string> lArrayLevel;
     // private readonly string connectionString;

        static ExportLodHandle()
    {
      MessageHandle messageHandle = new MessageHandle();
    }

    public void ExportMoonstoneLOD_V2()
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "File moonstone.lod|moonstone*.lod";
      saveFileDialog.FileName = "moonstone.lod";
      saveFileDialog.Title = "Save moonstone.lod file";
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      BinaryWriter binaryWriter = new BinaryWriter((Stream) File.Create(saveFileDialog.FileName));
      string str1 = "SELECT a_giftindex FROM t_moonstone_reward WHERE a_type='2545'";
      string str2 = "SELECT a_giftindex FROM t_moonstone_reward WHERE a_type='2546'";
      string str3 = "SELECT a_giftindex FROM t_moonstone_reward WHERE a_type='723'";
      string str4 = "SELECT a_giftindex FROM t_moonstone_reward WHERE a_type='2547'";
      string str5 = "SELECT a_giftindex FROM t_moonstone_reward WHERE a_type='2548'";
      string Query1 = "SELECT COUNT(*) FROM t_moonstone_reward WHERE a_type = '2545' ";
      string Query2 = "SELECT COUNT(*) FROM t_moonstone_reward WHERE a_type = '2546' ";
      string Query3 = "SELECT COUNT(*) FROM t_moonstone_reward WHERE a_type = '723' ";
      string Query4 = "SELECT COUNT(*) FROM t_moonstone_reward WHERE a_type = '2547' ";
      string Query5 = "SELECT COUNT(*) FROM t_moonstone_reward WHERE a_type = '2548' ";
      int num1 = databaseHandle.CountByRow(Host, User, Password, Database, Query1);
      int num2 = databaseHandle.CountByRow(Host, User, Password, Database, Query2);
      int num3 = databaseHandle.CountByRow(Host, User, Password, Database, Query3);
      int num4 = databaseHandle.CountByRow(Host, User, Password, Database, Query4);
      int num5 = databaseHandle.CountByRow(Host, User, Password, Database, Query5);
      int num6 = 0;
      string str6 = "";
      for (int index = 0; index < 5; ++index)
      {
        if (index == 0)
        {
          binaryWriter.Write(num1);
          num6 = num1;
          str6 = str1;
        }
        else if (index == 1)
        {
          binaryWriter.Write(num2);
          num6 = num2;
          str6 = str2;
        }
        else if (index == 2)
        {
          binaryWriter.Write(num3);
          num6 = num3;
          str6 = str3;
        }
        else if (index == 3)
        {
          binaryWriter.Write(num4);
          num6 = num4;
          str6 = str4;
        }
        else if (index == 4)
        {
          binaryWriter.Write(num5);
          num6 = num5;
          str6 = str5;
        }
        MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
        MySqlCommand command = mySqlConnection.CreateCommand();
        command.CommandText = str6;
        mySqlConnection.Open();
        MySqlDataReader mySqlDataReader = command.ExecuteReader();
        while (mySqlDataReader.Read())
        {
          string s = mySqlDataReader.GetValue(0).ToString();
          binaryWriter.Write(int.Parse(s));
        }
        mySqlConnection.Close();
      }
      binaryWriter.Close();
            messageHandle.SuccessFileMessage();
    }

     public async Task ExportItemAll_V4Async()
     {
         SaveFileDialog saveFileDialog = new SaveFileDialog();

         saveFileDialog.Filter = "File itemAll.lod|itemAll*.lod";
         saveFileDialog.FileName = "itemAll.lod";
         saveFileDialog.Title = "Save itemAll.lod file";
         if (saveFileDialog.ShowDialog() != DialogResult.OK)
             return;


         /* Async task, by Scura 21/05/22 */
         await Task.Run(() =>
         {
             try
             {
                 BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Create(saveFileDialog.FileName));

                 int num = databaseHandle.CountByRow(Host, User, Password, Database, "SELECT COUNT(*) FROM t_item");
                 string myquery = "SELECT * FROM t_item WHERE a_zone_flag=1023 AND a_enable = 1 ORDER by a_index";
                 string connectionString = "datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database;

                 MySqlConnection mySqlConnection1 = new MySqlConnection(connectionString);
                 MySqlCommand command1 = mySqlConnection1.CreateCommand();
                 command1.CommandText = myquery;
                 mySqlConnection1.Open();
                 MySqlDataReader mySqlDataReader1 = command1.ExecuteReader();
                 binaryWriter.Write(num);

                 while (mySqlDataReader1.Read())
                 {
                     int ordinal1 = mySqlDataReader1.GetOrdinal("a_index");
                     string s1 = mySqlDataReader1.GetString(ordinal1);
                     binaryWriter.Write(int.Parse(s1));
                     int ordinal2 = mySqlDataReader1.GetOrdinal("a_job_flag");
                     string s2 = mySqlDataReader1.GetString(ordinal2);
                     binaryWriter.Write(int.Parse(s2));
                     int ordinal3 = mySqlDataReader1.GetOrdinal("a_weight");
                     string s3 = mySqlDataReader1.GetString(ordinal3);
                     binaryWriter.Write(int.Parse(s3));
                     int ordinal4 = mySqlDataReader1.GetOrdinal("a_fame");
                     string s4 = mySqlDataReader1.GetString(ordinal4);
                     binaryWriter.Write(int.Parse(s4));
                     int ordinal5 = mySqlDataReader1.GetOrdinal("a_level");
                     string s5 = mySqlDataReader1.GetString(ordinal5);
                     binaryWriter.Write(int.Parse(s5));
                     int ordinal6 = mySqlDataReader1.GetOrdinal("a_flag");
                     string s6 = mySqlDataReader1.GetString(ordinal6);
                     binaryWriter.Write(long.Parse(s6));
                     int ordinal7 = mySqlDataReader1.GetOrdinal("a_wearing");
                     string s7 = mySqlDataReader1.GetString(ordinal7);
                     binaryWriter.Write(int.Parse(s7));
                     int ordinal8 = mySqlDataReader1.GetOrdinal("a_type_idx");
                     string s8 = mySqlDataReader1.GetString(ordinal8);
                     binaryWriter.Write(int.Parse(s8));
                     int ordinal9 = mySqlDataReader1.GetOrdinal("a_subtype_idx");
                     string s9 = mySqlDataReader1.GetString(ordinal9);
                     binaryWriter.Write(int.Parse(s9));
                     int ordinal10 = mySqlDataReader1.GetOrdinal("a_need_item0");
                     string s10 = mySqlDataReader1.GetString(ordinal10);
                     binaryWriter.Write(int.Parse(s10));
                     int ordinal11 = mySqlDataReader1.GetOrdinal("a_need_item1");
                     string s11 = mySqlDataReader1.GetString(ordinal11);
                     binaryWriter.Write(int.Parse(s11));
                     int ordinal12 = mySqlDataReader1.GetOrdinal("a_need_item2");
                     string s12 = mySqlDataReader1.GetString(ordinal12);
                     binaryWriter.Write(int.Parse(s12));
                     int ordinal13 = mySqlDataReader1.GetOrdinal("a_need_item3");
                     string s13 = mySqlDataReader1.GetString(ordinal13);
                     binaryWriter.Write(int.Parse(s13));
                     int ordinal14 = mySqlDataReader1.GetOrdinal("a_need_item4");
                     string s14 = mySqlDataReader1.GetString(ordinal14);
                     binaryWriter.Write(int.Parse(s14));
                     int ordinal15 = mySqlDataReader1.GetOrdinal("a_need_item5");
                     string s15 = mySqlDataReader1.GetString(ordinal15);
                     binaryWriter.Write(int.Parse(s15));
                     int ordinal16 = mySqlDataReader1.GetOrdinal("a_need_item6");
                     string s16 = mySqlDataReader1.GetString(ordinal16);
                     binaryWriter.Write(int.Parse(s16));
                     int ordinal17 = mySqlDataReader1.GetOrdinal("a_need_item7");
                     string s17 = mySqlDataReader1.GetString(ordinal17);
                     binaryWriter.Write(int.Parse(s17));
                     int ordinal18 = mySqlDataReader1.GetOrdinal("a_need_item8");
                     string s18 = mySqlDataReader1.GetString(ordinal18);
                     binaryWriter.Write(int.Parse(s18));
                     int ordinal19 = mySqlDataReader1.GetOrdinal("a_need_item9");
                     string s19 = mySqlDataReader1.GetString(ordinal19);
                     binaryWriter.Write(int.Parse(s19));
                     int ordinal20 = mySqlDataReader1.GetOrdinal("a_need_item_count0");
                     string s20 = mySqlDataReader1.GetString(ordinal20);
                     binaryWriter.Write(int.Parse(s20));
                     int ordinal21 = mySqlDataReader1.GetOrdinal("a_need_item_count1");
                     string s21 = mySqlDataReader1.GetString(ordinal21);
                     binaryWriter.Write(int.Parse(s21));
                     int ordinal22 = mySqlDataReader1.GetOrdinal("a_need_item_count2");
                     string s22 = mySqlDataReader1.GetString(ordinal22);
                     binaryWriter.Write(int.Parse(s22));
                     int ordinal23 = mySqlDataReader1.GetOrdinal("a_need_item_count3");
                     string s23 = mySqlDataReader1.GetString(ordinal23);
                     binaryWriter.Write(int.Parse(s23));
                     int ordinal24 = mySqlDataReader1.GetOrdinal("a_need_item_count4");
                     string s24 = mySqlDataReader1.GetString(ordinal24);
                     binaryWriter.Write(int.Parse(s24));
                     int ordinal25 = mySqlDataReader1.GetOrdinal("a_need_item_count5");
                     string s25 = mySqlDataReader1.GetString(ordinal25);
                     binaryWriter.Write(int.Parse(s25));
                     int ordinal26 = mySqlDataReader1.GetOrdinal("a_need_item_count6");
                     string s26 = mySqlDataReader1.GetString(ordinal26);
                     binaryWriter.Write(int.Parse(s26));
                     int ordinal27 = mySqlDataReader1.GetOrdinal("a_need_item_count7");
                     string s27 = mySqlDataReader1.GetString(ordinal27);
                     binaryWriter.Write(int.Parse(s27));
                     int ordinal28 = mySqlDataReader1.GetOrdinal("a_need_item_count8");
                     string s28 = mySqlDataReader1.GetString(ordinal28);
                     binaryWriter.Write(int.Parse(s28));
                     int ordinal29 = mySqlDataReader1.GetOrdinal("a_need_item_count9");
                     string s29 = mySqlDataReader1.GetString(ordinal29);
                     binaryWriter.Write(int.Parse(s29));
                     int ordinal30 = mySqlDataReader1.GetOrdinal("a_need_sskill");
                     string s30 = mySqlDataReader1.GetString(ordinal30);
                     binaryWriter.Write(int.Parse(s30));
                     int ordinal31 = mySqlDataReader1.GetOrdinal("a_need_sskill_level");
                     string s31 = mySqlDataReader1.GetString(ordinal31);
                     binaryWriter.Write(int.Parse(s31));
                     int ordinal32 = mySqlDataReader1.GetOrdinal("a_need_sskill2");
                     string s32 = mySqlDataReader1.GetString(ordinal32);
                     binaryWriter.Write(int.Parse(s32));
                     int ordinal33 = mySqlDataReader1.GetOrdinal("a_need_sskill_level2");
                     string s33 = mySqlDataReader1.GetString(ordinal33);
                     binaryWriter.Write(int.Parse(s33));
                     int ordinal34 = mySqlDataReader1.GetOrdinal("a_texture_id");
                     string s34 = mySqlDataReader1.GetString(ordinal34);
                     binaryWriter.Write(int.Parse(s34));
                     int ordinal35 = mySqlDataReader1.GetOrdinal("a_texture_row");
                     string s35 = mySqlDataReader1.GetString(ordinal35);
                     binaryWriter.Write(int.Parse(s35));
                     int ordinal36 = mySqlDataReader1.GetOrdinal("a_texture_col");
                     string s36 = mySqlDataReader1.GetString(ordinal36);
                     binaryWriter.Write(int.Parse(s36));
                     int ordinal37 = mySqlDataReader1.GetOrdinal("a_num_0");
                     string s37 = mySqlDataReader1.GetString(ordinal37);
                     binaryWriter.Write(int.Parse(s37));
                     int ordinal38 = mySqlDataReader1.GetOrdinal("a_num_1");
                     string s38 = mySqlDataReader1.GetString(ordinal38);
                     binaryWriter.Write(int.Parse(s38));
                     int ordinal39 = mySqlDataReader1.GetOrdinal("a_num_2");
                     string s39 = mySqlDataReader1.GetString(ordinal39);
                     binaryWriter.Write(int.Parse(s39));
                     int ordinal40 = mySqlDataReader1.GetOrdinal("a_num_3");
                     string s40 = mySqlDataReader1.GetString(ordinal40);
                     binaryWriter.Write(int.Parse(s40));
                     int ordinal41 = mySqlDataReader1.GetOrdinal("a_price");
                     string s41 = mySqlDataReader1.GetString(ordinal41);
                     binaryWriter.Write(int.Parse(s41));
                     int ordinal42 = mySqlDataReader1.GetOrdinal("a_set_0");
                     string s42 = mySqlDataReader1.GetString(ordinal42);
                     binaryWriter.Write(int.Parse(s42));
                     int ordinal43 = mySqlDataReader1.GetOrdinal("a_set_1");
                     string s43 = mySqlDataReader1.GetString(ordinal43);
                     binaryWriter.Write(int.Parse(s43));
                     int ordinal44 = mySqlDataReader1.GetOrdinal("a_set_2");
                     string s44 = mySqlDataReader1.GetString(ordinal44);
                     binaryWriter.Write(int.Parse(s44));
                     int ordinal45 = mySqlDataReader1.GetOrdinal("a_set_3");
                     string s45 = mySqlDataReader1.GetString(ordinal45);
                     binaryWriter.Write(int.Parse(s45));
                     int ordinal46 = mySqlDataReader1.GetOrdinal("a_set_4");
                     string s46 = mySqlDataReader1.GetString(ordinal46);
                     binaryWriter.Write(int.Parse(s46));
                     int ordinal47 = mySqlDataReader1.GetOrdinal("a_file_smc");
                     string str2 = mySqlDataReader1.GetString(ordinal47);
                     byte[] buffer1 = new byte[64];
                     int length1 = str2.Length > 64 ? 64 : str2.Length;
                     Encoding.UTF8.GetBytes(str2.Substring(0, length1)).CopyTo((Array)buffer1, 0);
                     binaryWriter.Write(buffer1);
                     int ordinal48 = mySqlDataReader1.GetOrdinal("a_effect_name");
                     string str3 = mySqlDataReader1.GetString(ordinal48);
                     byte[] buffer2 = new byte[32];
                     int length2 = str3.Length > 32 ? 32 : str3.Length;
                     Encoding.UTF8.GetBytes(str3.Substring(0, length2)).CopyTo((Array)buffer2, 0);
                     binaryWriter.Write(buffer2);
                     int ordinal49 = mySqlDataReader1.GetOrdinal("a_attack_effect_name");
                     string str4 = mySqlDataReader1.GetString(ordinal49);
                     byte[] buffer3 = new byte[32];
                     int length3 = str4.Length > 32 ? 32 : str4.Length;
                     Encoding.UTF8.GetBytes(str4.Substring(0, length3)).CopyTo((Array)buffer3, 0);
                     binaryWriter.Write(buffer3);
                     int ordinal50 = mySqlDataReader1.GetOrdinal("a_damage_effect_name");
                     string str5 = mySqlDataReader1.GetString(ordinal50);
                     byte[] buffer4 = new byte[32];
                     int length4 = str5.Length > 32 ? 32 : str5.Length;
                     Encoding.UTF8.GetBytes(str5.Substring(0, length4)).CopyTo((Array)buffer4, 0);
                     binaryWriter.Write(buffer4);
                     int ordinal51 = mySqlDataReader1.GetOrdinal("a_rare_index_0");
                     string s47 = mySqlDataReader1.GetString(ordinal51);
                     binaryWriter.Write(int.Parse(s47));
                     int ordinal52 = mySqlDataReader1.GetOrdinal("a_rare_prob_0");
                     string s48 = mySqlDataReader1.GetString(ordinal52);
                     binaryWriter.Write(int.Parse(s48));
                     int ordinal53 = mySqlDataReader1.GetOrdinal("a_rare_index_0");
                     string s49 = mySqlDataReader1.GetString(ordinal53);
                     binaryWriter.Write(int.Parse(s49));
                     int ordinal54 = mySqlDataReader1.GetOrdinal("a_rare_index_1");
                     string s50 = mySqlDataReader1.GetString(ordinal54);
                     binaryWriter.Write(int.Parse(s50));
                     int ordinal55 = mySqlDataReader1.GetOrdinal("a_rare_index_2");
                     string s51 = mySqlDataReader1.GetString(ordinal55);
                     binaryWriter.Write(int.Parse(s51));
                     int ordinal56 = mySqlDataReader1.GetOrdinal("a_rare_index_3");
                     string s52 = mySqlDataReader1.GetString(ordinal56);
                     binaryWriter.Write(int.Parse(s52));
                     int ordinal57 = mySqlDataReader1.GetOrdinal("a_rare_index_4");
                     string s53 = mySqlDataReader1.GetString(ordinal57);
                     binaryWriter.Write(int.Parse(s53));
                     int ordinal58 = mySqlDataReader1.GetOrdinal("a_rare_index_5");
                     string s54 = mySqlDataReader1.GetString(ordinal58);
                     binaryWriter.Write(int.Parse(s54));
                     int ordinal59 = mySqlDataReader1.GetOrdinal("a_rare_index_6");
                     string s55 = mySqlDataReader1.GetString(ordinal59);
                     binaryWriter.Write(int.Parse(s55));
                     int ordinal60 = mySqlDataReader1.GetOrdinal("a_rare_index_7");
                     string s56 = mySqlDataReader1.GetString(ordinal60);
                     binaryWriter.Write(int.Parse(s56));
                     int ordinal61 = mySqlDataReader1.GetOrdinal("a_rare_index_8");
                     string s57 = mySqlDataReader1.GetString(ordinal61);
                     binaryWriter.Write(int.Parse(s57));
                     int ordinal62 = mySqlDataReader1.GetOrdinal("a_rare_index_9");
                     string s58 = mySqlDataReader1.GetString(ordinal62);
                     binaryWriter.Write(int.Parse(s58));
                     int ordinal63 = mySqlDataReader1.GetOrdinal("a_rare_prob_0");
                     string s59 = mySqlDataReader1.GetString(ordinal63);
                     binaryWriter.Write(int.Parse(s59));
                     int ordinal64 = mySqlDataReader1.GetOrdinal("a_rare_prob_1");
                     string s60 = mySqlDataReader1.GetString(ordinal64);
                     binaryWriter.Write(int.Parse(s60));
                     int ordinal65 = mySqlDataReader1.GetOrdinal("a_rare_prob_2");
                     string s61 = mySqlDataReader1.GetString(ordinal65);
                     binaryWriter.Write(int.Parse(s61));
                     int ordinal66 = mySqlDataReader1.GetOrdinal("a_rare_prob_3");
                     string s62 = mySqlDataReader1.GetString(ordinal66);
                     binaryWriter.Write(int.Parse(s62));
                     int ordinal67 = mySqlDataReader1.GetOrdinal("a_rare_prob_4");
                     string s63 = mySqlDataReader1.GetString(ordinal67);
                     binaryWriter.Write(int.Parse(s63));
                     int ordinal68 = mySqlDataReader1.GetOrdinal("a_rare_prob_5");
                     string s64 = mySqlDataReader1.GetString(ordinal68);
                     binaryWriter.Write(int.Parse(s64));
                     int ordinal69 = mySqlDataReader1.GetOrdinal("a_rare_prob_6");
                     string s65 = mySqlDataReader1.GetString(ordinal69);
                     binaryWriter.Write(int.Parse(s65));
                     int ordinal70 = mySqlDataReader1.GetOrdinal("a_rare_prob_7");
                     string s66 = mySqlDataReader1.GetString(ordinal70);
                     binaryWriter.Write(int.Parse(s66));
                     int ordinal71 = mySqlDataReader1.GetOrdinal("a_rare_prob_8");
                     string s67 = mySqlDataReader1.GetString(ordinal71);
                     binaryWriter.Write(int.Parse(s67));
                     int ordinal72 = mySqlDataReader1.GetOrdinal("a_rare_prob_9");
                     string s68 = mySqlDataReader1.GetString(ordinal72);
                     binaryWriter.Write(int.Parse(s68));
                     int ordinal73 = mySqlDataReader1.GetOrdinal("a_rvr_value");
                     string s69 = mySqlDataReader1.GetString(ordinal73);
                     binaryWriter.Write(int.Parse(s69));
                     int ordinal74 = mySqlDataReader1.GetOrdinal("a_rvr_grade");
                     string s70 = mySqlDataReader1.GetString(ordinal74);
                     binaryWriter.Write(int.Parse(s70));
                     int ordinal75 = mySqlDataReader1.GetOrdinal("a_castle_war");
                     string str6 = mySqlDataReader1.GetString(ordinal75);
                     binaryWriter.Write(Convert.ToByte(str6));
                     string str7 = "SELECT * FROM t_fortune_data WHERE a_item_idx = " + s1 + " ORDER BY a_skill_index, a_skill_level";
                     MySqlConnection mySqlConnection2 = new MySqlConnection(connectionString);
                     MySqlCommand command2 = mySqlConnection2.CreateCommand();
                     command2.CommandText = str7;
                     mySqlConnection2.Open();
                     MySqlDataReader mySqlDataReader2 = command2.ExecuteReader();
                     while (mySqlDataReader2.Read())
                     {
                         int ordinal76 = mySqlDataReader2.GetOrdinal("a_item_idx");
                         string s71 = mySqlDataReader2.GetString(ordinal76);
                         binaryWriter.Write(int.Parse(s71));
                     }
                     mySqlConnection2.Close();
                 }
                 mySqlConnection1.Close();
                 binaryWriter.Close();
                 messageHandle.SuccessFileMessage();
             }
             catch (Exception ex)
             {
                 // generic exception
                 Debug.WriteLine("Exception: " + ex);
                 MessageBox.Show(ex.ToString(), "Error | Exception!");
             }
         });
     }

    public void ExportMobAll_V4()
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "File mobAll.lod|mobAll*.lod";
      saveFileDialog.FileName = "mobAll.lod";
      saveFileDialog.Title = "Save mobAll.lod file";
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      BinaryWriter binaryWriter = new BinaryWriter((Stream) File.Create(saveFileDialog.FileName));
      int num = databaseHandle.CountByRow(Host, User, Password, Database, "SELECT COUNT(*) FROM t_npc");
      string str1 = "SELECT * FROM t_npc WHERE a_enable = 1 ORDER BY a_index";
      MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
      MySqlCommand command = mySqlConnection.CreateCommand();
      command.CommandText = str1;
      mySqlConnection.Open();
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      binaryWriter.Write(num);
      while (mySqlDataReader.Read())
      {
        int ordinal1 = mySqlDataReader.GetOrdinal("a_index");
        string s1 = mySqlDataReader.GetString(ordinal1);
        binaryWriter.Write(int.Parse(s1));
        int ordinal2 = mySqlDataReader.GetOrdinal("a_level");
        string s2 = mySqlDataReader.GetString(ordinal2);
        binaryWriter.Write(int.Parse(s2));
        int ordinal3 = mySqlDataReader.GetOrdinal("a_walk_speed");
        string s3 = mySqlDataReader.GetString(ordinal3);
        binaryWriter.Write(float.Parse(s3));
        int ordinal4 = mySqlDataReader.GetOrdinal("a_run_speed");
        string s4 = mySqlDataReader.GetString(ordinal4);
        binaryWriter.Write(float.Parse(s4));
        int ordinal5 = mySqlDataReader.GetOrdinal("a_size");
        string s5 = mySqlDataReader.GetString(ordinal5);
        binaryWriter.Write(float.Parse(s5));
        int ordinal6 = mySqlDataReader.GetOrdinal("a_skill0");
        string s6 = mySqlDataReader.GetString(ordinal6);
        binaryWriter.Write(int.Parse(s6));
        mySqlDataReader.GetOrdinal("a_skill0");
        mySqlDataReader.GetString(ordinal6);
        binaryWriter.Write(int.Parse(s6));
        mySqlDataReader.GetOrdinal("a_skill0");
        mySqlDataReader.GetString(ordinal6);
        binaryWriter.Write(int.Parse(s6));
        mySqlDataReader.GetOrdinal("a_skill0");
        mySqlDataReader.GetString(ordinal6);
        binaryWriter.Write(int.Parse(s6));
        mySqlDataReader.GetOrdinal("a_skill0");
        mySqlDataReader.GetString(ordinal6);
        binaryWriter.Write(int.Parse(s6));
        int ordinal7 = mySqlDataReader.GetOrdinal("a_hp");
        string s7 = mySqlDataReader.GetString(ordinal7);
        binaryWriter.Write(int.Parse(s7));
        int ordinal8 = mySqlDataReader.GetOrdinal("a_mp");
        string s8 = mySqlDataReader.GetString(ordinal8);
        binaryWriter.Write(int.Parse(s8));
        int ordinal9 = mySqlDataReader.GetOrdinal("a_attack_area");
        string s9 = mySqlDataReader.GetString(ordinal9);
        binaryWriter.Write(float.Parse(s9));
        int ordinal10 = mySqlDataReader.GetOrdinal("a_skillmaster");
        mySqlDataReader.GetString(ordinal10);
        binaryWriter.Write(Convert.ToInt16(ordinal10));
        int ordinal11 = mySqlDataReader.GetOrdinal("a_sskill_master");
        mySqlDataReader.GetString(ordinal11);
        binaryWriter.Write(Convert.ToInt16(ordinal11));
        int ordinal12 = mySqlDataReader.GetOrdinal("a_flag");
        string s10 = mySqlDataReader.GetString(ordinal12);
        binaryWriter.Write(int.Parse(s10));
        int ordinal13 = mySqlDataReader.GetOrdinal("a_flag1");
        string s11 = mySqlDataReader.GetString(ordinal13);
        binaryWriter.Write(int.Parse(s11));
        int ordinal14 = mySqlDataReader.GetOrdinal("a_scale");
        string s12 = mySqlDataReader.GetString(ordinal14);
        binaryWriter.Write(float.Parse(s12));
        int ordinal15 = mySqlDataReader.GetOrdinal("a_file_smc");
        string str2 = mySqlDataReader.GetString(ordinal15);
        byte[] buffer1 = new byte[128];
        int length1 = str2.Length > 128 ? 128 : str2.Length;
        Encoding.UTF8.GetBytes(str2.Substring(0, length1)).CopyTo((Array) buffer1, 0);
        binaryWriter.Write(buffer1);
        int ordinal16 = mySqlDataReader.GetOrdinal("a_motion_idle");
        string str3 = mySqlDataReader.GetString(ordinal16);
        byte[] buffer2 = new byte[64];
        int length2 = str3.Length > 64 ? 64 : str3.Length;
        Encoding.UTF8.GetBytes(str3.Substring(0, length2)).CopyTo((Array) buffer2, 0);
        binaryWriter.Write(buffer2);
        int ordinal17 = mySqlDataReader.GetOrdinal("a_motion_walk");
        string str4 = mySqlDataReader.GetString(ordinal17);
        byte[] buffer3 = new byte[64];
        int length3 = str4.Length > 64 ? 64 : str4.Length;
        Encoding.UTF8.GetBytes(str4.Substring(0, length3)).CopyTo((Array) buffer3, 0);
        binaryWriter.Write(buffer3);
        int ordinal18 = mySqlDataReader.GetOrdinal("a_motion_dam");
        string str5 = mySqlDataReader.GetString(ordinal18);
        byte[] buffer4 = new byte[64];
        int length4 = str5.Length > 64 ? 64 : str5.Length;
        Encoding.UTF8.GetBytes(str5.Substring(0, length4)).CopyTo((Array) buffer4, 0);
        binaryWriter.Write(buffer4);
        int ordinal19 = mySqlDataReader.GetOrdinal("a_motion_attack");
        string str6 = mySqlDataReader.GetString(ordinal19);
        byte[] buffer5 = new byte[64];
        int length5 = str6.Length > 64 ? 64 : str6.Length;
        Encoding.UTF8.GetBytes(str6.Substring(0, length5)).CopyTo((Array) buffer5, 0);
        binaryWriter.Write(buffer5);
        int ordinal20 = mySqlDataReader.GetOrdinal("a_motion_die");
        string str7 = mySqlDataReader.GetString(ordinal20);
        byte[] buffer6 = new byte[64];
        int length6 = str7.Length > 64 ? 64 : str7.Length;
        Encoding.UTF8.GetBytes(str7.Substring(0, length6)).CopyTo((Array) buffer6, 0);
        binaryWriter.Write(buffer6);
        int ordinal21 = mySqlDataReader.GetOrdinal("a_motion_run");
        string str8 = mySqlDataReader.GetString(ordinal21);
        byte[] buffer7 = new byte[64];
        int length7 = str8.Length > 64 ? 64 : str8.Length;
        Encoding.UTF8.GetBytes(str8.Substring(0, length7)).CopyTo((Array) buffer7, 0);
        binaryWriter.Write(buffer7);
        int ordinal22 = mySqlDataReader.GetOrdinal("a_motion_idle2");
        string str9 = mySqlDataReader.GetString(ordinal22);
        byte[] buffer8 = new byte[64];
        int length8 = str9.Length > 64 ? 64 : str9.Length;
        Encoding.UTF8.GetBytes(str9.Substring(0, length8)).CopyTo((Array) buffer8, 0);
        binaryWriter.Write(buffer8);
        int ordinal23 = mySqlDataReader.GetOrdinal("a_motion_attack2");
        string str10 = mySqlDataReader.GetString(ordinal23);
        byte[] buffer9 = new byte[64];
        int length9 = str10.Length > 64 ? 64 : str10.Length;
        Encoding.UTF8.GetBytes(str10.Substring(0, length9)).CopyTo((Array) buffer9, 0);
        binaryWriter.Write(buffer9);
        int ordinal24 = mySqlDataReader.GetOrdinal("a_attackSpeed");
        string s13 = mySqlDataReader.GetString(ordinal24);
        binaryWriter.Write(int.Parse(s13));
        int ordinal25 = mySqlDataReader.GetOrdinal("a_attackType");
        string str11 = mySqlDataReader.GetString(ordinal25);
        binaryWriter.Write(Convert.ToByte(str11));
        int ordinal26 = mySqlDataReader.GetOrdinal("a_fireDelayCount");
        string str12 = mySqlDataReader.GetString(ordinal26);
        binaryWriter.Write(Convert.ToByte(str12));
        int ordinal27 = mySqlDataReader.GetOrdinal("a_fireDelay0");
        string s14 = mySqlDataReader.GetString(ordinal27);
        binaryWriter.Write(float.Parse(s14));
        int ordinal28 = mySqlDataReader.GetOrdinal("a_fireDelay1");
        string s15 = mySqlDataReader.GetString(ordinal28);
        binaryWriter.Write(float.Parse(s15));
        int ordinal29 = mySqlDataReader.GetOrdinal("a_fireDelay2");
        string s16 = mySqlDataReader.GetString(ordinal29);
        binaryWriter.Write(float.Parse(s16));
        int ordinal30 = mySqlDataReader.GetOrdinal("a_fireDelay3");
        string s17 = mySqlDataReader.GetString(ordinal30);
        binaryWriter.Write(float.Parse(s17));
        int ordinal31 = mySqlDataReader.GetOrdinal("a_fireEffect0");
        string str13 = mySqlDataReader.GetString(ordinal31);
        byte[] buffer10 = new byte[64];
        int length10 = str13.Length > 64 ? 64 : str13.Length;
        Encoding.UTF8.GetBytes(str13.Substring(0, length10)).CopyTo((Array) buffer10, 0);
        binaryWriter.Write(buffer10);
        int ordinal32 = mySqlDataReader.GetOrdinal("a_fireEffect1");
        string str14 = mySqlDataReader.GetString(ordinal32);
        byte[] buffer11 = new byte[64];
        int length11 = str14.Length > 64 ? 64 : str14.Length;
        Encoding.UTF8.GetBytes(str14.Substring(0, length11)).CopyTo((Array) buffer11, 0);
        binaryWriter.Write(buffer11);
        int ordinal33 = mySqlDataReader.GetOrdinal("a_fireEffect2");
        string str15 = mySqlDataReader.GetString(ordinal33);
        byte[] buffer12 = new byte[64];
        int length12 = str15.Length > 64 ? 64 : str15.Length;
        Encoding.UTF8.GetBytes(str15.Substring(0, length12)).CopyTo((Array) buffer12, 0);
        binaryWriter.Write(buffer12);
        int ordinal34 = mySqlDataReader.GetOrdinal("a_fireObject");
        string str16 = mySqlDataReader.GetString(ordinal34);
        binaryWriter.Write(Convert.ToByte(str16));
        int ordinal35 = mySqlDataReader.GetOrdinal("a_fireSpeed");
        string s18 = mySqlDataReader.GetString(ordinal35);
        binaryWriter.Write(float.Parse(s18));
        int ordinal36 = mySqlDataReader.GetOrdinal("a_rvr_value");
        string s19 = mySqlDataReader.GetString(ordinal36);
        binaryWriter.Write(int.Parse(s19));
        int ordinal37 = mySqlDataReader.GetOrdinal("a_rvr_grade");
        string s20 = mySqlDataReader.GetString(ordinal37);
        binaryWriter.Write(int.Parse(s20));
        int ordinal38 = mySqlDataReader.GetOrdinal("a_bound");
        string s21 = mySqlDataReader.GetString(ordinal38);
        binaryWriter.Write(int.Parse(s21));
        mySqlDataReader.GetOrdinal("a_fireObject");
        mySqlDataReader.GetString(ordinal34);
        binaryWriter.Write(Convert.ToByte(str16));
        mySqlDataReader.GetOrdinal("a_fireObject");
        mySqlDataReader.GetString(ordinal34);
        binaryWriter.Write(Convert.ToByte(str16));
      }
      mySqlConnection.Close();
      binaryWriter.Close();
            messageHandle.SuccessFileMessage();
    }

    public void ExportSkillAll_V4()
    {

      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "File skills.lod|skills*.lod";
      saveFileDialog.FileName = "skills.lod";
      saveFileDialog.Title = "Save skills.lod file";
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      string fileName = saveFileDialog.FileName;
      BinaryWriter binaryWriter = new BinaryWriter((Stream) File.Create(fileName));
      int num1 = databaseHandle.CountByRow(Host, User, Password, Database, "SELECT CAST(MAX(a_index) AS SIGNED) FROM t_skill");
      string str1 = "SELECT * FROM t_skill WHERE a_job>=0 ORDER BY a_index";
      string connectionString = "datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database;
      MySqlConnection mySqlConnection1 = new MySqlConnection(connectionString);
      MySqlCommand command1 = mySqlConnection1.CreateCommand();
      command1.CommandText = str1;
      mySqlConnection1.Open();
      MySqlDataReader mySqlDataReader1 = command1.ExecuteReader();
      binaryWriter.Write(num1);
      while (mySqlDataReader1.Read())
      {
        int ordinal1 = mySqlDataReader1.GetOrdinal("a_index");
        string s1 = mySqlDataReader1.GetString(ordinal1);
        binaryWriter.Write(int.Parse(s1));
        int ordinal2 = mySqlDataReader1.GetOrdinal("a_job");
        string s2 = mySqlDataReader1.GetString(ordinal2);
        binaryWriter.Write(int.Parse(s2));
        int ordinal3 = mySqlDataReader1.GetOrdinal("a_job2");
        string s3 = mySqlDataReader1.GetString(ordinal3);
        binaryWriter.Write(int.Parse(s3));
        int ordinal4 = mySqlDataReader1.GetOrdinal("a_apet_index");
        string s4 = mySqlDataReader1.GetString(ordinal4);
        binaryWriter.Write(int.Parse(s4));
        int ordinal5 = mySqlDataReader1.GetOrdinal("a_type");
        string str2 = mySqlDataReader1.GetString(ordinal5);
        binaryWriter.Write(Convert.ToByte(str2));
        int ordinal6 = mySqlDataReader1.GetOrdinal("a_flag");
        string s5 = mySqlDataReader1.GetString(ordinal6);
        binaryWriter.Write(int.Parse(s5));
        int ordinal7 = mySqlDataReader1.GetOrdinal("a_sorcerer_flag");
        string s6 = mySqlDataReader1.GetString(ordinal7);
        binaryWriter.Write(int.Parse(s6));
        int ordinal8 = mySqlDataReader1.GetOrdinal("a_maxLevel");
        string str3 = mySqlDataReader1.GetString(ordinal8);
        binaryWriter.Write(Convert.ToByte(str3));
        int ordinal9 = mySqlDataReader1.GetOrdinal("a_appRange");
        string s7 = mySqlDataReader1.GetString(ordinal9);
        binaryWriter.Write(float.Parse(s7));
        int ordinal10 = mySqlDataReader1.GetOrdinal("a_fireRange");
        string s8 = mySqlDataReader1.GetString(ordinal10);
        binaryWriter.Write(float.Parse(s8));
        int ordinal11 = mySqlDataReader1.GetOrdinal("a_fireRange2");
        string s9 = mySqlDataReader1.GetString(ordinal11);
        binaryWriter.Write(float.Parse(s9));
        int ordinal12 = mySqlDataReader1.GetOrdinal("a_targetType");
        string str4 = mySqlDataReader1.GetString(ordinal12);
        binaryWriter.Write(Convert.ToByte(str4));
        int ordinal13 = mySqlDataReader1.GetOrdinal("a_useState");
        string s10 = mySqlDataReader1.GetString(ordinal13);
        binaryWriter.Write(int.Parse(s10));
        int ordinal14 = mySqlDataReader1.GetOrdinal("a_useWeaponType0");
        string s11 = mySqlDataReader1.GetString(ordinal14);
        binaryWriter.Write(int.Parse(s11));
        int ordinal15 = mySqlDataReader1.GetOrdinal("a_useWeaponType1");
        string s12 = mySqlDataReader1.GetString(ordinal15);
        binaryWriter.Write(int.Parse(s12));
        int ordinal16 = mySqlDataReader1.GetOrdinal("a_useMagicIndex1");
        string s13 = mySqlDataReader1.GetString(ordinal16);
        binaryWriter.Write(int.Parse(s13));
        int ordinal17 = mySqlDataReader1.GetOrdinal("a_useMagicLevel1");
        string str5 = mySqlDataReader1.GetString(ordinal17);
        binaryWriter.Write(Convert.ToByte(str5));
        int ordinal18 = mySqlDataReader1.GetOrdinal("a_useMagicIndex2");
        string s14 = mySqlDataReader1.GetString(ordinal18);
        binaryWriter.Write(int.Parse(s14));
        int ordinal19 = mySqlDataReader1.GetOrdinal("a_useMagicLevel2");
        string str6 = mySqlDataReader1.GetString(ordinal19);
        binaryWriter.Write(Convert.ToByte(str6));
        int ordinal20 = mySqlDataReader1.GetOrdinal("a_useMagicIndex3");
        string s15 = mySqlDataReader1.GetString(ordinal20);
        binaryWriter.Write(int.Parse(s15));
        int ordinal21 = mySqlDataReader1.GetOrdinal("a_useMagicLevel3");
        string str7 = mySqlDataReader1.GetString(ordinal21);
        binaryWriter.Write(Convert.ToByte(str7));
        int ordinal22 = mySqlDataReader1.GetOrdinal("a_soul_consum");
        string s16 = mySqlDataReader1.GetString(ordinal22);
        binaryWriter.Write(int.Parse(s16));
        int ordinal23 = mySqlDataReader1.GetOrdinal("a_appState");
        string s17 = mySqlDataReader1.GetString(ordinal23);
        binaryWriter.Write(int.Parse(s17));
        int ordinal24 = mySqlDataReader1.GetOrdinal("a_readyTime");
        string s18 = mySqlDataReader1.GetString(ordinal24);
        binaryWriter.Write(int.Parse(s18));
        int ordinal25 = mySqlDataReader1.GetOrdinal("a_stillTime");
        string s19 = mySqlDataReader1.GetString(ordinal25);
        binaryWriter.Write(int.Parse(s19));
        int ordinal26 = mySqlDataReader1.GetOrdinal("a_fireTime");
        string s20 = mySqlDataReader1.GetString(ordinal26);
        binaryWriter.Write(int.Parse(s20));
        int ordinal27 = mySqlDataReader1.GetOrdinal("a_reuseTime");
        string s21 = mySqlDataReader1.GetString(ordinal27);
        binaryWriter.Write(int.Parse(s21));
        int ordinal28 = mySqlDataReader1.GetOrdinal("a_cd_ra");
        string s22 = mySqlDataReader1.GetString(ordinal28);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s22).Length);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s22));
        int ordinal29 = mySqlDataReader1.GetOrdinal("a_cd_re");
        string s23 = mySqlDataReader1.GetString(ordinal29);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s23).Length);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s23));
        int ordinal30 = mySqlDataReader1.GetOrdinal("a_cd_sa");
        string s24 = mySqlDataReader1.GetString(ordinal30);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s24).Length);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s24));
        int ordinal31 = mySqlDataReader1.GetOrdinal("a_cd_fa");
        string s25 = mySqlDataReader1.GetString(ordinal31);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s25).Length);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s25));
        int ordinal32 = mySqlDataReader1.GetOrdinal("a_cd_fe0");
        string s26 = mySqlDataReader1.GetString(ordinal32);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s26).Length);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s26));
        int ordinal33 = mySqlDataReader1.GetOrdinal("a_cd_fe1");
        string s27 = mySqlDataReader1.GetString(ordinal33);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s27).Length);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s27));
        int ordinal34 = mySqlDataReader1.GetOrdinal("a_cd_fe2");
        string s28 = mySqlDataReader1.GetString(ordinal34);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s28).Length);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s28));
        int ordinal35 = mySqlDataReader1.GetOrdinal("a_cd_fot");
        string str8 = mySqlDataReader1.GetString(ordinal35);
        binaryWriter.Write(Convert.ToByte(str8));
        int ordinal36 = mySqlDataReader1.GetOrdinal("a_cd_fos");
        string s29 = mySqlDataReader1.GetString(ordinal36);
        binaryWriter.Write(float.Parse(s29));
        int ordinal37 = mySqlDataReader1.GetOrdinal("a_cd_ox");
        string s30 = mySqlDataReader1.GetString(ordinal37);
        binaryWriter.Write(float.Parse(s30));
        int ordinal38 = mySqlDataReader1.GetOrdinal("a_cd_oz");
        string s31 = mySqlDataReader1.GetString(ordinal38);
        binaryWriter.Write(float.Parse(s31));
        int ordinal39 = mySqlDataReader1.GetOrdinal("a_cd_oh");
        string s32 = mySqlDataReader1.GetString(ordinal39);
        binaryWriter.Write(float.Parse(s32));
        int ordinal40 = mySqlDataReader1.GetOrdinal("a_cd_oc");
        string str9 = mySqlDataReader1.GetString(ordinal40);
        binaryWriter.Write(Convert.ToByte(str9));
        int ordinal41 = mySqlDataReader1.GetOrdinal("a_cd_fdc");
        string str10 = mySqlDataReader1.GetString(ordinal41);
        binaryWriter.Write(Convert.ToByte(str10));
        int ordinal42 = mySqlDataReader1.GetOrdinal("a_cd_fd0");
        string s33 = mySqlDataReader1.GetString(ordinal42);
        binaryWriter.Write(float.Parse(s33));
        int ordinal43 = mySqlDataReader1.GetOrdinal("a_cd_fd1");
        string s34 = mySqlDataReader1.GetString(ordinal43);
        binaryWriter.Write(float.Parse(s34));
        int ordinal44 = mySqlDataReader1.GetOrdinal("a_cd_fd2");
        string s35 = mySqlDataReader1.GetString(ordinal44);
        binaryWriter.Write(float.Parse(s35));
        int ordinal45 = mySqlDataReader1.GetOrdinal("a_cd_fd3");
        string s36 = mySqlDataReader1.GetString(ordinal45);
        binaryWriter.Write(float.Parse(s36));
        int ordinal46 = mySqlDataReader1.GetOrdinal("a_cd_dd");
        string s37 = mySqlDataReader1.GetString(ordinal46);
        binaryWriter.Write(float.Parse(s37));
        int ordinal47 = mySqlDataReader1.GetOrdinal("a_cd_ra2");
        string s38 = mySqlDataReader1.GetString(ordinal47);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s38).Length);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s38));
        int ordinal48 = mySqlDataReader1.GetOrdinal("a_cd_re2");
        string s39 = mySqlDataReader1.GetString(ordinal48);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s39).Length);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s39));
        int ordinal49 = mySqlDataReader1.GetOrdinal("a_cd_sa2");
        string s40 = mySqlDataReader1.GetString(ordinal49);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s40).Length);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s40));
        int ordinal50 = mySqlDataReader1.GetOrdinal("a_cd_fa2");
        string s41 = mySqlDataReader1.GetString(ordinal50);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s41).Length);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s41));
        int ordinal51 = mySqlDataReader1.GetOrdinal("a_cd_fe3");
        string s42 = mySqlDataReader1.GetString(ordinal51);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s42).Length);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s42));
        int ordinal52 = mySqlDataReader1.GetOrdinal("a_cd_fe4");
        string s43 = mySqlDataReader1.GetString(ordinal52);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s43).Length);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s43));
        int ordinal53 = mySqlDataReader1.GetOrdinal("a_cd_fe5");
        string s44 = mySqlDataReader1.GetString(ordinal53);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s44).Length);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s44));
        int ordinal54 = mySqlDataReader1.GetOrdinal("a_cd_fot2");
        string str11 = mySqlDataReader1.GetString(ordinal54);
        binaryWriter.Write(Convert.ToByte(str11));
        int ordinal55 = mySqlDataReader1.GetOrdinal("a_cd_fos2");
        string s45 = mySqlDataReader1.GetString(ordinal55);
        binaryWriter.Write(float.Parse(s45));
        int ordinal56 = mySqlDataReader1.GetOrdinal("a_cd_ox2");
        string s46 = mySqlDataReader1.GetString(ordinal56);
        binaryWriter.Write(float.Parse(s46));
        int ordinal57 = mySqlDataReader1.GetOrdinal("a_cd_oz2");
        string s47 = mySqlDataReader1.GetString(ordinal57);
        binaryWriter.Write(float.Parse(s47));
        int ordinal58 = mySqlDataReader1.GetOrdinal("a_cd_oh2");
        string s48 = mySqlDataReader1.GetString(ordinal58);
        binaryWriter.Write(float.Parse(s48));
        int ordinal59 = mySqlDataReader1.GetOrdinal("a_cd_oc2");
        string str12 = mySqlDataReader1.GetString(ordinal59);
        binaryWriter.Write(Convert.ToByte(str12));
        int ordinal60 = mySqlDataReader1.GetOrdinal("a_cd_fdc2");
        string str13 = mySqlDataReader1.GetString(ordinal60);
        binaryWriter.Write(Convert.ToByte(str13));
        int ordinal61 = mySqlDataReader1.GetOrdinal("a_cd_fd4");
        string s49 = mySqlDataReader1.GetString(ordinal61);
        binaryWriter.Write(float.Parse(s49));
        int ordinal62 = mySqlDataReader1.GetOrdinal("a_cd_fd5");
        string s50 = mySqlDataReader1.GetString(ordinal62);
        binaryWriter.Write(float.Parse(s50));
        int ordinal63 = mySqlDataReader1.GetOrdinal("a_cd_fd6");
        string s51 = mySqlDataReader1.GetString(ordinal63);
        binaryWriter.Write(float.Parse(s51));
        int ordinal64 = mySqlDataReader1.GetOrdinal("a_cd_fd7");
        string s52 = mySqlDataReader1.GetString(ordinal64);
        binaryWriter.Write(float.Parse(s52));
        int ordinal65 = mySqlDataReader1.GetOrdinal("a_cd_dd2");
        string s53 = mySqlDataReader1.GetString(ordinal65);
        binaryWriter.Write(float.Parse(s53));
        int ordinal66 = mySqlDataReader1.GetOrdinal("a_cd_fe_after");
        string s54 = mySqlDataReader1.GetString(ordinal66);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s54).Length);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s54));
        int ordinal67 = mySqlDataReader1.GetOrdinal("a_client_icon_texid");
        string s55 = mySqlDataReader1.GetString(ordinal67);
        binaryWriter.Write(int.Parse(s55));
        int ordinal68 = mySqlDataReader1.GetOrdinal("a_client_icon_row");
        string s56 = mySqlDataReader1.GetString(ordinal68);
        binaryWriter.Write(int.Parse(s56));
        int ordinal69 = mySqlDataReader1.GetOrdinal("a_client_icon_col");
        string s57 = mySqlDataReader1.GetString(ordinal69);
        binaryWriter.Write(int.Parse(s57));
        string str14 = "SELECT * FROM t_skillLevel WHERE a_index=" + s1 + " ORDER BY a_level";
        MySqlConnection mySqlConnection2 = new MySqlConnection(connectionString);
        MySqlCommand command2 = mySqlConnection2.CreateCommand();
        command2.CommandText = str14;
        mySqlConnection2.Open();
        MySqlDataReader mySqlDataReader2 = command2.ExecuteReader();
        while (mySqlDataReader2.Read())
        {
          int ordinal70 = mySqlDataReader2.GetOrdinal("a_needHP");
          string s58 = mySqlDataReader2.GetString(ordinal70);
          binaryWriter.Write(int.Parse(s58));
          int ordinal71 = mySqlDataReader2.GetOrdinal("a_needMP");
          string s59 = mySqlDataReader2.GetString(ordinal71);
          binaryWriter.Write(int.Parse(s59));
          int ordinal72 = mySqlDataReader2.GetOrdinal("a_needGP");
          string s60 = mySqlDataReader2.GetString(ordinal72);
          binaryWriter.Write(int.Parse(s60));
          int ordinal73 = mySqlDataReader2.GetOrdinal("a_durtime");
          string s61 = mySqlDataReader2.GetString(ordinal73);
          binaryWriter.Write(int.Parse(s61));
          int ordinal74 = mySqlDataReader2.GetOrdinal("a_dummypower");
          string s62 = mySqlDataReader2.GetString(ordinal74);
          binaryWriter.Write(int.Parse(s62));
          int ordinal75 = mySqlDataReader2.GetOrdinal("a_needItemIndex1");
          string s63 = mySqlDataReader2.GetString(ordinal75);
          binaryWriter.Write(int.Parse(s63));
          int ordinal76 = mySqlDataReader2.GetOrdinal("a_needItemCount1");
          string s64 = mySqlDataReader2.GetString(ordinal76);
          binaryWriter.Write(int.Parse(s64));
          int ordinal77 = mySqlDataReader2.GetOrdinal("a_needItemIndex2");
          string s65 = mySqlDataReader2.GetString(ordinal77);
          binaryWriter.Write(int.Parse(s65));
          int ordinal78 = mySqlDataReader2.GetOrdinal("a_needItemCount2");
          string s66 = mySqlDataReader2.GetString(ordinal78);
          binaryWriter.Write(int.Parse(s66));
          int ordinal79 = mySqlDataReader2.GetOrdinal("a_learnLevel");
          string s67 = mySqlDataReader2.GetString(ordinal79);
          binaryWriter.Write(int.Parse(s67));
          int ordinal80 = mySqlDataReader2.GetOrdinal("a_learnSP");
          string s68 = mySqlDataReader2.GetString(ordinal80);
          binaryWriter.Write(int.Parse(s68));
          int ordinal81 = mySqlDataReader2.GetOrdinal("a_learnSkillIndex1");
          string s69 = mySqlDataReader2.GetString(ordinal81);
          binaryWriter.Write(int.Parse(s69));
          int ordinal82 = mySqlDataReader2.GetOrdinal("a_learnSkillLevel1");
          string str15 = mySqlDataReader2.GetString(ordinal82);
          binaryWriter.Write(Convert.ToByte(str15));
          int ordinal83 = mySqlDataReader2.GetOrdinal("a_learnSkillIndex2");
          string s70 = mySqlDataReader2.GetString(ordinal83);
          binaryWriter.Write(int.Parse(s70));
          int ordinal84 = mySqlDataReader2.GetOrdinal("a_learnSkillLevel2");
          string str16 = mySqlDataReader2.GetString(ordinal84);
          binaryWriter.Write(Convert.ToByte(str16));
          int ordinal85 = mySqlDataReader2.GetOrdinal("a_learnSkillIndex3");
          string s71 = mySqlDataReader2.GetString(ordinal85);
          binaryWriter.Write(int.Parse(s71));
          int ordinal86 = mySqlDataReader2.GetOrdinal("a_learnSkillLevel3");
          string str17 = mySqlDataReader2.GetString(ordinal86);
          binaryWriter.Write(Convert.ToByte(str17));
          int ordinal87 = mySqlDataReader2.GetOrdinal("a_learnItemIndex1");
          string s72 = mySqlDataReader2.GetString(ordinal87);
          binaryWriter.Write(int.Parse(s72));
          int ordinal88 = mySqlDataReader2.GetOrdinal("a_learnItemCount1");
          string s73 = mySqlDataReader2.GetString(ordinal88);
          binaryWriter.Write(int.Parse(s73));
          int ordinal89 = mySqlDataReader2.GetOrdinal("a_learnItemIndex2");
          string s74 = mySqlDataReader2.GetString(ordinal89);
          binaryWriter.Write(int.Parse(s74));
          int ordinal90 = mySqlDataReader2.GetOrdinal("a_learnItemCount2");
          string s75 = mySqlDataReader2.GetString(ordinal90);
          binaryWriter.Write(int.Parse(s75));
          int ordinal91 = mySqlDataReader2.GetOrdinal("a_learnItemIndex3");
          string s76 = mySqlDataReader2.GetString(ordinal91);
          binaryWriter.Write(int.Parse(s76));
          int ordinal92 = mySqlDataReader2.GetOrdinal("a_learnItemCount3");
          string s77 = mySqlDataReader2.GetString(ordinal92);
          binaryWriter.Write(int.Parse(s77));
          int ordinal93 = mySqlDataReader2.GetOrdinal("a_learnstr");
          string s78 = mySqlDataReader2.GetString(ordinal93);
          binaryWriter.Write(int.Parse(s78));
          int ordinal94 = mySqlDataReader2.GetOrdinal("a_learndex");
          string s79 = mySqlDataReader2.GetString(ordinal94);
          binaryWriter.Write(int.Parse(s79));
          int ordinal95 = mySqlDataReader2.GetOrdinal("a_learnint");
          string s80 = mySqlDataReader2.GetString(ordinal95);
          binaryWriter.Write(int.Parse(s80));
          int ordinal96 = mySqlDataReader2.GetOrdinal("a_learncon");
          string s81 = mySqlDataReader2.GetString(ordinal96);
          binaryWriter.Write(int.Parse(s81));
          int ordinal97 = mySqlDataReader2.GetOrdinal("a_appMagicIndex1");
          string s82 = mySqlDataReader2.GetString(ordinal97);
          binaryWriter.Write(int.Parse(s82));
          int ordinal98 = mySqlDataReader2.GetOrdinal("a_appMagicLevel1");
          string str18 = mySqlDataReader2.GetString(ordinal98);
          binaryWriter.Write(Convert.ToByte(str18));
          int ordinal99 = mySqlDataReader2.GetOrdinal("a_appMagicIndex2");
          string s83 = mySqlDataReader2.GetString(ordinal99);
          binaryWriter.Write(int.Parse(s83));
          int ordinal100 = mySqlDataReader2.GetOrdinal("a_appMagicLevel2");
          string str19 = mySqlDataReader2.GetString(ordinal100);
          binaryWriter.Write(Convert.ToByte(str19));
          int ordinal101 = mySqlDataReader2.GetOrdinal("a_appMagicIndex3");
          string s84 = mySqlDataReader2.GetString(ordinal101);
          binaryWriter.Write(int.Parse(s84));
          int ordinal102 = mySqlDataReader2.GetOrdinal("a_appMagicLevel3");
          string str20 = mySqlDataReader2.GetString(ordinal102);
          binaryWriter.Write(Convert.ToByte(str20));
          int ordinal103 = mySqlDataReader2.GetOrdinal("a_magicIndex1");
          string s85 = mySqlDataReader2.GetString(ordinal103);
          binaryWriter.Write(int.Parse(s85));
          int ordinal104 = mySqlDataReader2.GetOrdinal("a_magicLevel1");
          string str21 = mySqlDataReader2.GetString(ordinal104);
          binaryWriter.Write(Convert.ToByte(str21));
          int ordinal105 = mySqlDataReader2.GetOrdinal("a_magicIndex2");
          string s86 = mySqlDataReader2.GetString(ordinal105);
          binaryWriter.Write(int.Parse(s86));
          int ordinal106 = mySqlDataReader2.GetOrdinal("a_magicLevel2");
          string str22 = mySqlDataReader2.GetString(ordinal106);
          binaryWriter.Write(Convert.ToByte(str22));
          int ordinal107 = mySqlDataReader2.GetOrdinal("a_magicIndex3");
          string s87 = mySqlDataReader2.GetString(ordinal107);
          binaryWriter.Write(int.Parse(s87));
          int ordinal108 = mySqlDataReader2.GetOrdinal("a_magicLevel3");
          string str23 = mySqlDataReader2.GetString(ordinal108);
          binaryWriter.Write(Convert.ToByte(str23));
          int ordinal109 = mySqlDataReader2.GetOrdinal("a_learnGP");
          string s88 = mySqlDataReader2.GetString(ordinal109);
          binaryWriter.Write(int.Parse(s88));
          binaryWriter.Write(Convert.ToChar(0));
          binaryWriter.Write(Convert.ToChar(0));
          binaryWriter.Write(Convert.ToChar(0));
          binaryWriter.Write(Convert.ToChar(0));
          int ordinal110 = mySqlDataReader2.GetOrdinal("a_targetNum");
          string s89 = mySqlDataReader2.GetString(ordinal110);
          binaryWriter.Write(int.Parse(s89));
        }
        mySqlConnection2.Close();
      }
      int num2 = -9999;
      binaryWriter.Write(num2);
      mySqlConnection1.Close();
      binaryWriter.Close();
      //DoWork.EncodeFile(fileName);
            messageHandle.SuccessFileMessage();
    }

    public void ExportQuestAll_V4()
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "File questAll.lod|questAll*.lod";
      saveFileDialog.FileName = "questAll.lod";
      saveFileDialog.Title = "Save questAll.lod file";
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      BinaryWriter binaryWriter = new BinaryWriter((Stream) File.Create(saveFileDialog.FileName));
      int num = databaseHandle.CountByRow(Host, User, Password, Database, "SELECT COUNT(*) FROM t_quest");
      string str = "SELECT * FROM t_quest WHERE a_enable=1 ORDER BY a_index";
      MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
      MySqlCommand command = mySqlConnection.CreateCommand();
      command.CommandText = str;
      mySqlConnection.Open();
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      binaryWriter.Write(num);
      while (mySqlDataReader.Read())
      {
        int ordinal1 = mySqlDataReader.GetOrdinal("a_index");
        string s1 = mySqlDataReader.GetString(ordinal1);
        binaryWriter.Write(int.Parse(s1));
        int ordinal2 = mySqlDataReader.GetOrdinal("a_type1");
        string s2 = mySqlDataReader.GetString(ordinal2);
        binaryWriter.Write(int.Parse(s2));
        int ordinal3 = mySqlDataReader.GetOrdinal("a_type2");
        string s3 = mySqlDataReader.GetString(ordinal3);
        binaryWriter.Write(int.Parse(s3));
        int ordinal4 = mySqlDataReader.GetOrdinal("a_start_type");
        string s4 = mySqlDataReader.GetString(ordinal4);
        binaryWriter.Write(int.Parse(s4));
        int ordinal5 = mySqlDataReader.GetOrdinal("a_start_data");
        string s5 = mySqlDataReader.GetString(ordinal5);
        binaryWriter.Write(int.Parse(s5));
        int ordinal6 = mySqlDataReader.GetOrdinal("a_prize_npc");
        string s6 = mySqlDataReader.GetString(ordinal6);
        binaryWriter.Write(int.Parse(s6));
        int ordinal7 = mySqlDataReader.GetOrdinal("a_prequest_num");
        string s7 = mySqlDataReader.GetString(ordinal7);
        binaryWriter.Write(int.Parse(s7));
        int ordinal8 = mySqlDataReader.GetOrdinal("a_start_npc_zone_num");
        string s8 = mySqlDataReader.GetString(ordinal8);
        binaryWriter.Write(int.Parse(s8));
        int ordinal9 = mySqlDataReader.GetOrdinal("a_prize_npc_zone_num");
        string s9 = mySqlDataReader.GetString(ordinal9);
        binaryWriter.Write(int.Parse(s9));
        int ordinal10 = mySqlDataReader.GetOrdinal("a_need_exp");
        string s10 = mySqlDataReader.GetString(ordinal10);
        binaryWriter.Write(int.Parse(s10));
        int ordinal11 = mySqlDataReader.GetOrdinal("a_need_min_level");
        string s11 = mySqlDataReader.GetString(ordinal11);
        binaryWriter.Write(int.Parse(s11));
        int ordinal12 = mySqlDataReader.GetOrdinal("a_need_max_level");
        string s12 = mySqlDataReader.GetString(ordinal12);
        binaryWriter.Write(int.Parse(s12));
        int ordinal13 = mySqlDataReader.GetOrdinal("a_need_job");
        string s13 = mySqlDataReader.GetString(ordinal13);
        binaryWriter.Write(int.Parse(s13));
        binaryWriter.Write(0);
        binaryWriter.Write(0);
        int ordinal14 = mySqlDataReader.GetOrdinal("a_need_item0");
        string s14 = mySqlDataReader.GetString(ordinal14);
        binaryWriter.Write(int.Parse(s14));
        int ordinal15 = mySqlDataReader.GetOrdinal("a_need_item1");
        string s15 = mySqlDataReader.GetString(ordinal15);
        binaryWriter.Write(int.Parse(s15));
        int ordinal16 = mySqlDataReader.GetOrdinal("a_need_item2");
        string s16 = mySqlDataReader.GetString(ordinal16);
        binaryWriter.Write(int.Parse(s16));
        int ordinal17 = mySqlDataReader.GetOrdinal("a_need_item3");
        string s17 = mySqlDataReader.GetString(ordinal17);
        binaryWriter.Write(int.Parse(s17));
        int ordinal18 = mySqlDataReader.GetOrdinal("a_need_item4");
        string s18 = mySqlDataReader.GetString(ordinal18);
        binaryWriter.Write(int.Parse(s18));
        int ordinal19 = mySqlDataReader.GetOrdinal("a_need_item_count0");
        string s19 = mySqlDataReader.GetString(ordinal19);
        binaryWriter.Write(int.Parse(s19));
        int ordinal20 = mySqlDataReader.GetOrdinal("a_need_item_count1");
        string s20 = mySqlDataReader.GetString(ordinal20);
        binaryWriter.Write(int.Parse(s20));
        int ordinal21 = mySqlDataReader.GetOrdinal("a_need_item_count2");
        string s21 = mySqlDataReader.GetString(ordinal21);
        binaryWriter.Write(int.Parse(s21));
        int ordinal22 = mySqlDataReader.GetOrdinal("a_need_item_count3");
        string s22 = mySqlDataReader.GetString(ordinal22);
        binaryWriter.Write(int.Parse(s22));
        int ordinal23 = mySqlDataReader.GetOrdinal("a_need_item_count4");
        string s23 = mySqlDataReader.GetString(ordinal23);
        binaryWriter.Write(int.Parse(s23));
        int ordinal24 = mySqlDataReader.GetOrdinal("a_need_rvr_type");
        string s24 = mySqlDataReader.GetString(ordinal24);
        binaryWriter.Write(int.Parse(s24));
        int ordinal25 = mySqlDataReader.GetOrdinal("a_need_rvr_grade");
        string s25 = mySqlDataReader.GetString(ordinal25);
        binaryWriter.Write(int.Parse(s25));
        int ordinal26 = mySqlDataReader.GetOrdinal("a_condition0_type");
        string s26 = mySqlDataReader.GetString(ordinal26);
        binaryWriter.Write(int.Parse(s26));
        int ordinal27 = mySqlDataReader.GetOrdinal("a_condition0_index");
        string s27 = mySqlDataReader.GetString(ordinal27);
        binaryWriter.Write(int.Parse(s27));
        int ordinal28 = mySqlDataReader.GetOrdinal("a_condition0_num");
        string s28 = mySqlDataReader.GetString(ordinal28);
        binaryWriter.Write(int.Parse(s28));
        int ordinal29 = mySqlDataReader.GetOrdinal("a_condition0_data0");
        string s29 = mySqlDataReader.GetString(ordinal29);
        binaryWriter.Write(int.Parse(s29));
        int ordinal30 = mySqlDataReader.GetOrdinal("a_condition0_data1");
        string s30 = mySqlDataReader.GetString(ordinal30);
        binaryWriter.Write(int.Parse(s30));
        int ordinal31 = mySqlDataReader.GetOrdinal("a_condition0_data2");
        string s31 = mySqlDataReader.GetString(ordinal31);
        binaryWriter.Write(int.Parse(s31));
        int ordinal32 = mySqlDataReader.GetOrdinal("a_condition0_data3");
        string s32 = mySqlDataReader.GetString(ordinal32);
        binaryWriter.Write(int.Parse(s32));
        int ordinal33 = mySqlDataReader.GetOrdinal("a_condition1_type");
        string s33 = mySqlDataReader.GetString(ordinal33);
        binaryWriter.Write(int.Parse(s33));
        int ordinal34 = mySqlDataReader.GetOrdinal("a_condition1_index");
        string s34 = mySqlDataReader.GetString(ordinal34);
        binaryWriter.Write(int.Parse(s34));
        int ordinal35 = mySqlDataReader.GetOrdinal("a_condition1_num");
        string s35 = mySqlDataReader.GetString(ordinal35);
        binaryWriter.Write(int.Parse(s35));
        int ordinal36 = mySqlDataReader.GetOrdinal("a_condition1_data0");
        string s36 = mySqlDataReader.GetString(ordinal36);
        binaryWriter.Write(int.Parse(s36));
        int ordinal37 = mySqlDataReader.GetOrdinal("a_condition1_data1");
        string s37 = mySqlDataReader.GetString(ordinal37);
        binaryWriter.Write(int.Parse(s37));
        int ordinal38 = mySqlDataReader.GetOrdinal("a_condition1_data2");
        string s38 = mySqlDataReader.GetString(ordinal38);
        binaryWriter.Write(int.Parse(s38));
        int ordinal39 = mySqlDataReader.GetOrdinal("a_condition1_data3");
        string s39 = mySqlDataReader.GetString(ordinal39);
        binaryWriter.Write(int.Parse(s39));
        int ordinal40 = mySqlDataReader.GetOrdinal("a_condition2_type");
        string s40 = mySqlDataReader.GetString(ordinal40);
        binaryWriter.Write(int.Parse(s40));
        int ordinal41 = mySqlDataReader.GetOrdinal("a_condition2_index");
        string s41 = mySqlDataReader.GetString(ordinal41);
        binaryWriter.Write(int.Parse(s41));
        int ordinal42 = mySqlDataReader.GetOrdinal("a_condition2_num");
        string s42 = mySqlDataReader.GetString(ordinal42);
        binaryWriter.Write(int.Parse(s42));
        int ordinal43 = mySqlDataReader.GetOrdinal("a_condition2_data0");
        string s43 = mySqlDataReader.GetString(ordinal43);
        binaryWriter.Write(int.Parse(s43));
        int ordinal44 = mySqlDataReader.GetOrdinal("a_condition2_data1");
        string s44 = mySqlDataReader.GetString(ordinal44);
        binaryWriter.Write(int.Parse(s44));
        int ordinal45 = mySqlDataReader.GetOrdinal("a_condition2_data2");
        string s45 = mySqlDataReader.GetString(ordinal45);
        binaryWriter.Write(int.Parse(s45));
        int ordinal46 = mySqlDataReader.GetOrdinal("a_condition2_data3");
        string s46 = mySqlDataReader.GetString(ordinal46);
        binaryWriter.Write(int.Parse(s46));
        int ordinal47 = mySqlDataReader.GetOrdinal("a_prize_type0");
        string s47 = mySqlDataReader.GetString(ordinal47);
        binaryWriter.Write(int.Parse(s47));
        int ordinal48 = mySqlDataReader.GetOrdinal("a_prize_index0");
        string s48 = mySqlDataReader.GetString(ordinal48);
        binaryWriter.Write(int.Parse(s48));
        int ordinal49 = mySqlDataReader.GetOrdinal("a_prize_data0");
        string s49 = mySqlDataReader.GetString(ordinal49);
        binaryWriter.Write(long.Parse(s49));
        int ordinal50 = mySqlDataReader.GetOrdinal("a_prize_type1");
        string s50 = mySqlDataReader.GetString(ordinal50);
        binaryWriter.Write(int.Parse(s50));
        int ordinal51 = mySqlDataReader.GetOrdinal("a_prize_index1");
        string s51 = mySqlDataReader.GetString(ordinal51);
        binaryWriter.Write(int.Parse(s51));
        int ordinal52 = mySqlDataReader.GetOrdinal("a_prize_data1");
        string s52 = mySqlDataReader.GetString(ordinal52);
        binaryWriter.Write(long.Parse(s52));
        int ordinal53 = mySqlDataReader.GetOrdinal("a_prize_type2");
        string s53 = mySqlDataReader.GetString(ordinal53);
        binaryWriter.Write(int.Parse(s53));
        int ordinal54 = mySqlDataReader.GetOrdinal("a_prize_index2");
        string s54 = mySqlDataReader.GetString(ordinal54);
        binaryWriter.Write(int.Parse(s54));
        int ordinal55 = mySqlDataReader.GetOrdinal("a_prize_data2");
        string s55 = mySqlDataReader.GetString(ordinal55);
        binaryWriter.Write(long.Parse(s55));
        int ordinal56 = mySqlDataReader.GetOrdinal("a_prize_type3");
        string s56 = mySqlDataReader.GetString(ordinal56);
        binaryWriter.Write(int.Parse(s56));
        int ordinal57 = mySqlDataReader.GetOrdinal("a_prize_index3");
        string s57 = mySqlDataReader.GetString(ordinal57);
        binaryWriter.Write(int.Parse(s57));
        int ordinal58 = mySqlDataReader.GetOrdinal("a_prize_data3");
        string s58 = mySqlDataReader.GetString(ordinal58);
        binaryWriter.Write(long.Parse(s58));
        int ordinal59 = mySqlDataReader.GetOrdinal("a_prize_type4");
        string s59 = mySqlDataReader.GetString(ordinal59);
        binaryWriter.Write(int.Parse(s59));
        int ordinal60 = mySqlDataReader.GetOrdinal("a_prize_index4");
        string s60 = mySqlDataReader.GetString(ordinal60);
        binaryWriter.Write(int.Parse(s60));
        int ordinal61 = mySqlDataReader.GetOrdinal("a_prize_data4");
        string s61 = mySqlDataReader.GetString(ordinal61);
        binaryWriter.Write(long.Parse(s61));
        int ordinal62 = mySqlDataReader.GetOrdinal("a_option_prize");
        string s62 = mySqlDataReader.GetString(ordinal62);
        binaryWriter.Write(int.Parse(s62));
        int ordinal63 = mySqlDataReader.GetOrdinal("a_opt_prize_type0");
        string s63 = mySqlDataReader.GetString(ordinal63);
        binaryWriter.Write(int.Parse(s63));
        int ordinal64 = mySqlDataReader.GetOrdinal("a_opt_prize_index0");
        string s64 = mySqlDataReader.GetString(ordinal64);
        binaryWriter.Write(int.Parse(s64));
        int ordinal65 = mySqlDataReader.GetOrdinal("a_opt_prize_data0");
        string s65 = mySqlDataReader.GetString(ordinal65);
        binaryWriter.Write(int.Parse(s65));
        int ordinal66 = mySqlDataReader.GetOrdinal("a_opt_prize_plus0");
        string s66 = mySqlDataReader.GetString(ordinal66);
        binaryWriter.Write(int.Parse(s66));
        int ordinal67 = mySqlDataReader.GetOrdinal("a_opt_prize_type1");
        string s67 = mySqlDataReader.GetString(ordinal67);
        binaryWriter.Write(int.Parse(s67));
        int ordinal68 = mySqlDataReader.GetOrdinal("a_opt_prize_index1");
        string s68 = mySqlDataReader.GetString(ordinal68);
        binaryWriter.Write(int.Parse(s68));
        int ordinal69 = mySqlDataReader.GetOrdinal("a_opt_prize_data1");
        string s69 = mySqlDataReader.GetString(ordinal69);
        binaryWriter.Write(int.Parse(s69));
        int ordinal70 = mySqlDataReader.GetOrdinal("a_opt_prize_plus1");
        string s70 = mySqlDataReader.GetString(ordinal70);
        binaryWriter.Write(int.Parse(s70));
        int ordinal71 = mySqlDataReader.GetOrdinal("a_opt_prize_type2");
        string s71 = mySqlDataReader.GetString(ordinal71);
        binaryWriter.Write(int.Parse(s71));
        int ordinal72 = mySqlDataReader.GetOrdinal("a_opt_prize_index2");
        string s72 = mySqlDataReader.GetString(ordinal72);
        binaryWriter.Write(int.Parse(s72));
        int ordinal73 = mySqlDataReader.GetOrdinal("a_opt_prize_data2");
        string s73 = mySqlDataReader.GetString(ordinal73);
        binaryWriter.Write(int.Parse(s73));
        int ordinal74 = mySqlDataReader.GetOrdinal("a_opt_prize_plus2");
        string s74 = mySqlDataReader.GetString(ordinal74);
        binaryWriter.Write(int.Parse(s74));
        int ordinal75 = mySqlDataReader.GetOrdinal("a_opt_prize_type3");
        string s75 = mySqlDataReader.GetString(ordinal75);
        binaryWriter.Write(int.Parse(s75));
        int ordinal76 = mySqlDataReader.GetOrdinal("a_opt_prize_index3");
        string s76 = mySqlDataReader.GetString(ordinal76);
        binaryWriter.Write(int.Parse(s76));
        int ordinal77 = mySqlDataReader.GetOrdinal("a_opt_prize_data3");
        string s77 = mySqlDataReader.GetString(ordinal77);
        binaryWriter.Write(int.Parse(s77));
        int ordinal78 = mySqlDataReader.GetOrdinal("a_opt_prize_plus3");
        string s78 = mySqlDataReader.GetString(ordinal78);
        binaryWriter.Write(int.Parse(s78));
        int ordinal79 = mySqlDataReader.GetOrdinal("a_opt_prize_type4");
        string s79 = mySqlDataReader.GetString(ordinal79);
        binaryWriter.Write(int.Parse(s79));
        int ordinal80 = mySqlDataReader.GetOrdinal("a_opt_prize_index4");
        string s80 = mySqlDataReader.GetString(ordinal80);
        binaryWriter.Write(int.Parse(s80));
        int ordinal81 = mySqlDataReader.GetOrdinal("a_opt_prize_data4");
        string s81 = mySqlDataReader.GetString(ordinal81);
        binaryWriter.Write(int.Parse(s81));
        int ordinal82 = mySqlDataReader.GetOrdinal("a_opt_prize_plus4");
        string s82 = mySqlDataReader.GetString(ordinal82);
        binaryWriter.Write(int.Parse(s82));
        int ordinal83 = mySqlDataReader.GetOrdinal("a_opt_prize_type5");
        string s83 = mySqlDataReader.GetString(ordinal83);
        binaryWriter.Write(int.Parse(s83));
        int ordinal84 = mySqlDataReader.GetOrdinal("a_opt_prize_index5");
        string s84 = mySqlDataReader.GetString(ordinal84);
        binaryWriter.Write(int.Parse(s84));
        int ordinal85 = mySqlDataReader.GetOrdinal("a_opt_prize_data5");
        string s85 = mySqlDataReader.GetString(ordinal85);
        binaryWriter.Write(int.Parse(s85));
        int ordinal86 = mySqlDataReader.GetOrdinal("a_opt_prize_plus5");
        string s86 = mySqlDataReader.GetString(ordinal86);
        binaryWriter.Write(int.Parse(s86));
        int ordinal87 = mySqlDataReader.GetOrdinal("a_opt_prize_type6");
        string s87 = mySqlDataReader.GetString(ordinal87);
        binaryWriter.Write(int.Parse(s87));
        int ordinal88 = mySqlDataReader.GetOrdinal("a_opt_prize_index6");
        string s88 = mySqlDataReader.GetString(ordinal88);
        binaryWriter.Write(int.Parse(s88));
        int ordinal89 = mySqlDataReader.GetOrdinal("a_opt_prize_data6");
        string s89 = mySqlDataReader.GetString(ordinal89);
        binaryWriter.Write(int.Parse(s89));
        int ordinal90 = mySqlDataReader.GetOrdinal("a_opt_prize_plus6");
        string s90 = mySqlDataReader.GetString(ordinal90);
        binaryWriter.Write(int.Parse(s90));
        int ordinal91 = mySqlDataReader.GetOrdinal("a_partyscale");
        string s91 = mySqlDataReader.GetString(ordinal91);
        binaryWriter.Write(int.Parse(s91));
        int ordinal92 = mySqlDataReader.GetOrdinal("a_only_opt_prize");
        string s92 = mySqlDataReader.GetString(ordinal92);
        binaryWriter.Write(int.Parse(s92));
      }
      mySqlConnection.Close();
      binaryWriter.Close();
            messageHandle.SuccessFileMessage();
    }

    public void ExportTitle_V4()
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "File titletool.lod|titletool*.lod";
      saveFileDialog.FileName = "titletool.lod";
      saveFileDialog.Title = "Save titletool.lod file";
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      BinaryWriter binaryWriter = new BinaryWriter((Stream) File.Create(saveFileDialog.FileName));
      int num1 = databaseHandle.CountByRow(Host, User, Password, Database, "SELECT COUNT(*) FROM t_title");
      string str1 = "SELECT * FROM t_title WHERE a_enable = 1 ORDER by a_index";
      MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
      MySqlCommand command = mySqlConnection.CreateCommand();
      command.CommandText = str1;
      mySqlConnection.Open();
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      binaryWriter.Write(num1);
      while (mySqlDataReader.Read())
      {
        int ordinal1 = mySqlDataReader.GetOrdinal("a_index");
        string s1 = mySqlDataReader.GetString(ordinal1);
        binaryWriter.Write(int.Parse(s1));
        int ordinal2 = mySqlDataReader.GetOrdinal("a_enable");
        string str2 = mySqlDataReader.GetString(ordinal2);
        binaryWriter.Write(Convert.ToByte(str2));
        string str3;
        string str4;
        string str5;
        try
        {
          int ordinal3 = mySqlDataReader.GetOrdinal("a_effect_name");
          str3 = mySqlDataReader.GetString(ordinal3);
          int ordinal4 = mySqlDataReader.GetOrdinal("a_attack");
          str4 = mySqlDataReader.GetString(ordinal4);
          int ordinal5 = mySqlDataReader.GetOrdinal("a_damage");
          str5 = mySqlDataReader.GetString(ordinal5);
        }
        catch
        {
          str3 = "";
          str4 = "";
          str5 = "";
        }
        byte[] buffer1 = new byte[64];
        int length1 = str3.Length > 64 ? 64 : str3.Length;
        Encoding.UTF8.GetBytes(str3.Substring(0, length1)).CopyTo((Array) buffer1, 0);
        byte[] buffer2 = new byte[64];
        int length2 = str4.Length > 64 ? 64 : str4.Length;
        Encoding.UTF8.GetBytes(str4.Substring(0, length2)).CopyTo((Array) buffer2, 0);
        byte[] buffer3 = new byte[64];
        int length3 = str5.Length > 64 ? 64 : str5.Length;
        Encoding.UTF8.GetBytes(str5.Substring(0, length3)).CopyTo((Array) buffer3, 0);
        binaryWriter.Write(buffer1);
        binaryWriter.Write(buffer2);
        binaryWriter.Write(buffer3);
        int ordinal6 = mySqlDataReader.GetOrdinal("a_color");
        string s2 = mySqlDataReader.GetString(ordinal6);
        int num2;
        try
        {
          num2 = int.Parse(s2, NumberStyles.HexNumber);
        }
        catch
        {
          num2 = 0;
        }
        binaryWriter.Write(num2);
        int ordinal7 = mySqlDataReader.GetOrdinal("a_bgcolor");
        string s3 = mySqlDataReader.GetString(ordinal7);
        int num3;
        try
        {
          num3 = int.Parse(s3, NumberStyles.HexNumber);
        }
        catch
        {
          num3 = 0;
        }
        binaryWriter.Write(num3);
        int ordinal8 = mySqlDataReader.GetOrdinal("a_option_index0");
        string s4 = mySqlDataReader.GetString(ordinal8);
        binaryWriter.Write(int.Parse(s4));
        int ordinal9 = mySqlDataReader.GetOrdinal("a_option_index1");
        string s5 = mySqlDataReader.GetString(ordinal9);
        binaryWriter.Write(int.Parse(s5));
        int ordinal10 = mySqlDataReader.GetOrdinal("a_option_index2");
        string s6 = mySqlDataReader.GetString(ordinal10);
        binaryWriter.Write(int.Parse(s6));
        int ordinal11 = mySqlDataReader.GetOrdinal("a_option_index3");
        string s7 = mySqlDataReader.GetString(ordinal11);
        binaryWriter.Write(int.Parse(s7));
        int ordinal12 = mySqlDataReader.GetOrdinal("a_option_index4");
        string s8 = mySqlDataReader.GetString(ordinal12);
        binaryWriter.Write(int.Parse(s8));
        int ordinal13 = mySqlDataReader.GetOrdinal("a_option_level0");
        string str6 = mySqlDataReader.GetString(ordinal13);
        binaryWriter.Write(Convert.ToByte(str6));
        int ordinal14 = mySqlDataReader.GetOrdinal("a_option_level1");
        string str7 = mySqlDataReader.GetString(ordinal14);
        binaryWriter.Write(Convert.ToByte(str7));
        int ordinal15 = mySqlDataReader.GetOrdinal("a_option_level2");
        string str8 = mySqlDataReader.GetString(ordinal15);
        binaryWriter.Write(Convert.ToByte(str8));
        int ordinal16 = mySqlDataReader.GetOrdinal("a_option_level3");
        string str9 = mySqlDataReader.GetString(ordinal16);
        binaryWriter.Write(Convert.ToByte(str9));
        int ordinal17 = mySqlDataReader.GetOrdinal("a_option_level4");
        string str10 = mySqlDataReader.GetString(ordinal17);
        binaryWriter.Write(Convert.ToByte(str10));
        int ordinal18 = mySqlDataReader.GetOrdinal("a_item_index");
        string s9 = mySqlDataReader.GetString(ordinal18);
        binaryWriter.Write(int.Parse(s9));
      }
      mySqlConnection.Close();
      binaryWriter.Close();
            messageHandle.SuccessFileMessage();
    }

    public void ExportString_V4(string fileType)
    {
      string str1 = "";
      string str2 = "";
      string str3 = "";
      string str4 = "";
      int num = 0;
      bool flag1 = false;
      bool flag2 = false;
      if (fileType == "strItem")
      {
        str1 = "File strItem.lod|strItem*.lod";
        str2 = "strItem.lod";
        str3 = "Save strItem.lod file";
        str4 = "SELECT * FROM t_item";
        num = databaseHandle.CountByRow(Host, User, Password, Database, "SELECT COUNT(*) FROM t_item");
        flag1 = true;
        flag2 = true;
      }
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = str1;
      saveFileDialog.FileName = str2;
      saveFileDialog.Title = str3;
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      BinaryWriter binaryWriter = new BinaryWriter((Stream) File.Create(saveFileDialog.FileName));
      MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
      MySqlCommand command = mySqlConnection.CreateCommand();
      command.CommandText = str4;
      mySqlConnection.Open();
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      binaryWriter.Write(num);
      if (flag1)
        binaryWriter.Write(num);
      while (mySqlDataReader.Read())
      {
        int ordinal1 = mySqlDataReader.GetOrdinal("a_index");
        string s1 = mySqlDataReader.GetString(ordinal1);
        binaryWriter.Write(int.Parse(s1));
        int ordinal2 = mySqlDataReader.GetOrdinal("a_name_usa"); //fix export string
        string s2 = mySqlDataReader.GetString(ordinal2);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s2).Length);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s2));
        if (flag2)
        {
          int ordinal3 = mySqlDataReader.GetOrdinal("a_descr_usa"); //fix export string
          string s3 = mySqlDataReader.GetString(ordinal3);
          binaryWriter.Write(Encoding.UTF8.GetBytes(s3).Length);
          binaryWriter.Write(Encoding.UTF8.GetBytes(s3));
        }
      }
      mySqlConnection.Close();
      binaryWriter.Close();
            messageHandle.SuccessFileMessage();
    }

    public void ExportCatalog_V4()
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "File catalog.lod|catalog*.lod";
      saveFileDialog.FileName = "catalog.lod";
      saveFileDialog.Title = "Save catalog.lod file";
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      BinaryWriter binaryWriter = new BinaryWriter((Stream) File.Create(saveFileDialog.FileName));
      int num1 = databaseHandle.CountByRow(Host, User, Password, Database, "SELECT COUNT(*) FROM t_catalog");
      string str1 = "SELECT * FROM t_catalog WHERE a_enable='1' ORDER BY a_ctid ASC";
      string connectionString = "datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database;
      MySqlConnection mySqlConnection1 = new MySqlConnection(connectionString);
      MySqlCommand command1 = mySqlConnection1.CreateCommand();
      command1.CommandText = str1;
      mySqlConnection1.Open();
      MySqlDataReader mySqlDataReader1 = command1.ExecuteReader();
      binaryWriter.Write(num1);
      while (mySqlDataReader1.Read())
      {
        int ordinal1 = mySqlDataReader1.GetOrdinal("a_ctid");
        string s1 = mySqlDataReader1.GetString(ordinal1);
        binaryWriter.Write(int.Parse(s1));
        int ordinal2 = mySqlDataReader1.GetOrdinal("a_category");
        string s2 = mySqlDataReader1.GetString(ordinal2);
        binaryWriter.Write(int.Parse(s2));
        int ordinal3 = mySqlDataReader1.GetOrdinal("a_cash");
        string s3 = mySqlDataReader1.GetString(ordinal3);
        binaryWriter.Write(int.Parse(s3));
        int ordinal4 = mySqlDataReader1.GetOrdinal("a_mileage");
        string s4 = mySqlDataReader1.GetString(ordinal4);
        binaryWriter.Write(int.Parse(s4));
        int ordinal5 = mySqlDataReader1.GetOrdinal("a_flag");
        string s5 = mySqlDataReader1.GetString(ordinal5);
        binaryWriter.Write(int.Parse(s5));
        int ordinal6 = mySqlDataReader1.GetOrdinal("a_enable");
        string str2 = mySqlDataReader1.GetString(ordinal6);
        binaryWriter.Write(Convert.ToByte(str2));
        int ordinal7 = mySqlDataReader1.GetOrdinal("a_ctname");
        string s6 = mySqlDataReader1.GetString(ordinal7);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s6).Length);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s6));
        int ordinal8 = mySqlDataReader1.GetOrdinal("a_ctdesc");
        string s7 = mySqlDataReader1.GetString(ordinal8);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s7).Length);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s7));
        int num2 = databaseHandle.CountByRow(Host, User, Password, Database, "SELECT COUNT(*) FROM t_ct_item WHERE a_ctid ='" + s1 + "'");
        binaryWriter.Write(num2);
        string str3 = "SELECT * FROM t_ct_item WHERE a_ctid='" + s1 + "' ORDER BY a_index";
        MySqlConnection mySqlConnection2 = new MySqlConnection(connectionString);
        MySqlCommand command2 = mySqlConnection2.CreateCommand();
        command2.CommandText = str3;
        mySqlConnection2.Open();
        MySqlDataReader mySqlDataReader2 = command2.ExecuteReader();
        while (mySqlDataReader2.Read())
        {
          int ordinal9 = mySqlDataReader2.GetOrdinal("a_item_idx");
          string s8 = mySqlDataReader2.GetString(ordinal9);
          binaryWriter.Write(int.Parse(s8));
          int ordinal10 = mySqlDataReader2.GetOrdinal("a_item_flag");
          string s9 = mySqlDataReader2.GetString(ordinal10);
          binaryWriter.Write(int.Parse(s9));
          int ordinal11 = mySqlDataReader2.GetOrdinal("a_item_plus");
          string s10 = mySqlDataReader2.GetString(ordinal11);
          binaryWriter.Write(int.Parse(s10));
          int ordinal12 = mySqlDataReader2.GetOrdinal("a_item_option");
          string s11 = mySqlDataReader2.GetString(ordinal12);
          binaryWriter.Write(int.Parse(s11));
          int ordinal13 = mySqlDataReader2.GetOrdinal("a_item_num");
          string s12 = mySqlDataReader2.GetString(ordinal13);
          binaryWriter.Write(int.Parse(s12));
        }
        mySqlConnection2.Close();
        int ordinal14 = mySqlDataReader1.GetOrdinal("a_icon");
        string s13 = mySqlDataReader1.GetString(ordinal14);
        binaryWriter.Write(int.Parse(s13));
      }
      mySqlConnection1.Close();
      binaryWriter.Close();
            messageHandle.SuccessFileMessage();
    }

    public void ExportShop_V4()
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "File shopAll.lod|shopAll*.lod";
      saveFileDialog.FileName = "shopAll.lod";
      saveFileDialog.Title = "Save shopAll.lod file";
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      BinaryWriter binaryWriter = new BinaryWriter((Stream) File.Create(saveFileDialog.FileName));
      int num1 = databaseHandle.CountByRow(Host, User, Password, Database, "SELECT CAST(MAX(a_keeper_idx) AS SIGNED) FROM t_shop");
      string str1 = "SELECT * FROM t_shop  ORDER BY a_keeper_idx";
      string connectionString = "datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database;
      MySqlConnection mySqlConnection1 = new MySqlConnection(connectionString);
      MySqlCommand command1 = mySqlConnection1.CreateCommand();
      command1.CommandText = str1;
      mySqlConnection1.Open();
      MySqlDataReader mySqlDataReader1 = command1.ExecuteReader();
      binaryWriter.Write(num1);
      while (mySqlDataReader1.Read())
      {
        int ordinal1 = mySqlDataReader1.GetOrdinal("a_keeper_idx");
        string s1 = mySqlDataReader1.GetString(ordinal1);
        binaryWriter.Write(int.Parse(s1));
        int ordinal2 = mySqlDataReader1.GetOrdinal("a_name");
        string s2 = mySqlDataReader1.GetString(ordinal2);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s2).Length);
        binaryWriter.Write(Encoding.UTF8.GetBytes(s2));
        int ordinal3 = mySqlDataReader1.GetOrdinal("a_sell_rate");
        string s3 = mySqlDataReader1.GetString(ordinal3);
        binaryWriter.Write(int.Parse(s3));
        int ordinal4 = mySqlDataReader1.GetOrdinal("a_buy_rate");
        string s4 = mySqlDataReader1.GetString(ordinal4);
        binaryWriter.Write(int.Parse(s4));
        int num2 = databaseHandle.CountByRow(Host, User, Password, Database, "SELECT COUNT(*) FROM t_shopitem WHERE a_keeper_idx ='" + s1 + "'");
        binaryWriter.Write(num2);
        string str2 = "SELECT t1.a_item_idx AS itemindex FROM t_shopitem t1, t_item t2 WHERE t1.a_national = 0 AND t1.a_keeper_idx=" + s1 + " AND t1.a_item_idx=t2.a_index ORDER BY t2.a_job_flag, t2.a_level, t2.a_type_idx, t2.a_subtype_idx, t2.a_index";
        MySqlConnection mySqlConnection2 = new MySqlConnection(connectionString);
        MySqlCommand command2 = mySqlConnection2.CreateCommand();
        command2.CommandText = str2;
        mySqlConnection2.Open();
        MySqlDataReader mySqlDataReader2 = command2.ExecuteReader();
        while (mySqlDataReader2.Read())
        {
          int ordinal5 = mySqlDataReader2.GetOrdinal("itemindex");
          string s5 = mySqlDataReader2.GetString(ordinal5);
          binaryWriter.Write(int.Parse(s5));
        }
        mySqlConnection2.Close();
      }
      mySqlConnection1.Close();
      binaryWriter.Close();
            messageHandle.SuccessFileMessage();
    }

    public void ExportOption_V4()
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "File option.lod|option*.lod";
      saveFileDialog.FileName = "option.lod";
      saveFileDialog.Title = "Save option.lod file";
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      BinaryWriter binaryWriter = new BinaryWriter((Stream) File.Create(saveFileDialog.FileName));
      int num1 = databaseHandle.CountByRow(Host, User, Password, Database, "SELECT COUNT(*) FROM t_option");
      string str1 = "SELECT * FROM t_option ORDER BY a_index";
      MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
      MySqlCommand command = mySqlConnection.CreateCommand();
      command.CommandText = str1;
      mySqlConnection.Open();
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      binaryWriter.Write(num1);
      while (mySqlDataReader.Read())
      {
        int ordinal1 = mySqlDataReader.GetOrdinal("a_index");
        string s1 = mySqlDataReader.GetString(ordinal1);
        binaryWriter.Write(int.Parse(s1));
        int ordinal2 = mySqlDataReader.GetOrdinal("a_type");
        string s2 = mySqlDataReader.GetString(ordinal2);
        binaryWriter.Write(int.Parse(s2));
        int ordinal3 = mySqlDataReader.GetOrdinal("a_level");
        string[] strArray1 = mySqlDataReader.GetString(ordinal3).Split(' ');

                //write binary fixed By :Maskov
                int[] lArrayLevel = new int[36];

                int index1 = 0;
                
        foreach (string str2 in strArray1)
        {
          if (str2 != "")
                    {
                        lArrayLevel[index1] = Convert.ToInt32(str2);
                        ++index1;
                    }
        }
        int num2 = 36;
        for (int index2 = 0; index2 < num2; ++index2)
          binaryWriter.Write(lArrayLevel[index2]);
      }
      mySqlConnection.Close();
      binaryWriter.Close();
            messageHandle.SuccessFileMessage();
    }

    public void ExportSkillTree_V4()
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "File skill_tree.bin|skill_tree*.bin";
      saveFileDialog.FileName = "skill_tree.bin";
      saveFileDialog.Title = "Save skill_tree.bin file";
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      BinaryWriter binaryWriter = new BinaryWriter((Stream) File.Create(saveFileDialog.FileName));
      for (int index1 = 0; index1 < 9; ++index1)
      {
        for (int index2 = 0; index2 < 3; ++index2)
        {
          int num1 = databaseHandle.CountByRow(Host, User, Password, Database, "SELECT COUNT(*) FROM t_skill WHERE a_job = " +  index1 + " AND a_job2 = " +  index2 ?? "");
          int num2 = (int) MessageBox.Show(num1.ToString());
          binaryWriter.Write(num1);
          string str = "SELECT * FROM t_skill WHERE a_job = " +  index1 + " AND a_job2 = " +  index2 ?? "";
          MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
          MySqlCommand command = mySqlConnection.CreateCommand();
          command.CommandText = str;
          mySqlConnection.Open();
          MySqlDataReader mySqlDataReader = command.ExecuteReader();
          while (mySqlDataReader.Read())
          {
            int ordinal = mySqlDataReader.GetOrdinal("a_index");
            string s = mySqlDataReader.GetString(ordinal);
            binaryWriter.Write(int.Parse(s));
          }
          mySqlConnection.Close();
        }
      }
      binaryWriter.Close();
            messageHandle.SuccessFileMessage();
    }

    public void ExportEvent_V4()
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "File event_usa.lod|event_usa*.lod";
      saveFileDialog.FileName = "event_usa.lod";
      saveFileDialog.Title = "Save event_usa.lod file";
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      BinaryWriter binaryWriter = new BinaryWriter((Stream) File.Create(saveFileDialog.FileName));
      int num1 = 9;
      int num2 = databaseHandle.CountByRow(Host, User, Password, Database, "SELECT COUNT(*) FROM t_event");
      string str = "SELECT * FROM t_event ORDER BY a_index";
      MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
      MySqlCommand command = mySqlConnection.CreateCommand();
      command.CommandText = str;
      mySqlConnection.Open();
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      binaryWriter.Write(num1);
      binaryWriter.Write(num2);
      while (mySqlDataReader.Read())
      {
        int ordinal1 = mySqlDataReader.GetOrdinal("a_index");
        string s1 = mySqlDataReader.GetString(ordinal1);
        binaryWriter.Write(int.Parse(s1));
        int ordinal2 = mySqlDataReader.GetOrdinal("a_enable");
        string s2 = mySqlDataReader.GetString(ordinal2);
        binaryWriter.Write(int.Parse(s2));
      }
      mySqlConnection.Close();
      binaryWriter.Close();
            messageHandle.SuccessFileMessage();
    }
        public void ExportAffl_V4()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "File affinity.lod|affinity*.lod";
            saveFileDialog.FileName = "affinity.lod";
            saveFileDialog.Title = "Save affinity.lod file";
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Create(saveFileDialog.FileName));
            int num = databaseHandle.CountByRow(Host, User, Password, Database, "SELECT COUNT(*) FROM t_affinity");
            string str = "SELECT * FROM t_affinity WHERE a_enable=1 ORDER BY a_index";
            MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
            MySqlCommand command = mySqlConnection.CreateCommand();
            command.CommandText = str;
            mySqlConnection.Open();
            MySqlDataReader mySqlDataReader = command.ExecuteReader();
            binaryWriter.Write(num);
            while (mySqlDataReader.Read())
            {
                int ordinal1 = mySqlDataReader.GetOrdinal("a_index");
                string s1 = mySqlDataReader.GetString(ordinal1);
                binaryWriter.Write(int.Parse(s1));
                int ordinal2 = mySqlDataReader.GetOrdinal("a_name");
                string s2 = mySqlDataReader.GetString(ordinal2);
               binaryWriter.Write(Encoding.UTF8.GetBytes(s2).Length);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s2));
                int ordinal3 = mySqlDataReader.GetOrdinal("a_maxvalue");
                string s3 = mySqlDataReader.GetString(ordinal3);
                binaryWriter.Write(int.Parse(s3));
                int ordinal4 = mySqlDataReader.GetOrdinal("a_enable");
                string s4 = mySqlDataReader.GetString(ordinal4);
                binaryWriter.Write(int.Parse(s4));
                int ordinal5 = mySqlDataReader.GetOrdinal("a_texture_id");
                string s5 = mySqlDataReader.GetString(ordinal5);
                binaryWriter.Write(int.Parse(s5));
                int ordinal6 = mySqlDataReader.GetOrdinal("a_texture_row");
                string s6 = mySqlDataReader.GetString(ordinal6);
                binaryWriter.Write(int.Parse(s6));
                int ordinal7 = mySqlDataReader.GetOrdinal("a_texture_col");
                string s7 = mySqlDataReader.GetString(ordinal7);
                binaryWriter.Write(int.Parse(s7));
                int ordinal8 = mySqlDataReader.GetOrdinal("a_nas");
                string s8 = mySqlDataReader.GetString(ordinal8);
                binaryWriter.Write(int.Parse(s8));
                int ordinal9 = mySqlDataReader.GetOrdinal("a_name_jpn");
                string s9 = mySqlDataReader.GetString(ordinal9);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s9).Length);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s9));
                int ordinal10 = mySqlDataReader.GetOrdinal("a_name_mex");
                string s10 = mySqlDataReader.GetString(ordinal10);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s10).Length);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s10));
                int ordinal11 = mySqlDataReader.GetOrdinal("a_name_brz");
                string s11 = mySqlDataReader.GetString(ordinal11);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s11).Length);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s11));
                int ordinal12 = mySqlDataReader.GetOrdinal("a_needlevel");
                string s12 = mySqlDataReader.GetString(ordinal12);
                binaryWriter.Write(int.Parse(s12));
                int ordinal13 = mySqlDataReader.GetOrdinal("a_needitemidx");
                string s13 = mySqlDataReader.GetString(ordinal13);
                binaryWriter.Write(int.Parse(s13));
                int ordinal14 = mySqlDataReader.GetOrdinal("a_needitemcount");
                string s14 = mySqlDataReader.GetString(ordinal14);
                binaryWriter.Write(int.Parse(s14));
                int ordinal15 = mySqlDataReader.GetOrdinal("a_affinity_idx");
                string s15 = mySqlDataReader.GetString(ordinal15);
                binaryWriter.Write(int.Parse(s15));
                int ordinal16 = mySqlDataReader.GetOrdinal("a_affinity_value");
                string s16 = mySqlDataReader.GetString(ordinal16);
                binaryWriter.Write(int.Parse(s16));
                int ordinal17 = mySqlDataReader.GetOrdinal("a_name_ger");
                string s17 = mySqlDataReader.GetString(ordinal17);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s17).Length);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s17));
                int ordinal18 = mySqlDataReader.GetOrdinal("a_name_spn");
                string s18 = mySqlDataReader.GetString(ordinal18);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s18).Length);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s18));
                int ordinal19 = mySqlDataReader.GetOrdinal("a_name_frc");
                string s19 = mySqlDataReader.GetString(ordinal19);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s19).Length);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s19));
                int ordinal20 = mySqlDataReader.GetOrdinal("a_name_rus");
                string s20 = mySqlDataReader.GetString(ordinal20);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s20).Length);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s20));
                int ordinal21 = mySqlDataReader.GetOrdinal("a_name_hk_eng");
                string s21 = mySqlDataReader.GetString(ordinal21);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s21).Length);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s21));
                int ordinal22 = mySqlDataReader.GetOrdinal("a_name_hk");
                string s22 = mySqlDataReader.GetString(ordinal22);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s22).Length);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s22));
                int ordinal23 = mySqlDataReader.GetOrdinal("a_name_usa");
                string s23 = mySqlDataReader.GetString(ordinal23);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s23).Length);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s23));
                int ordinal24 = mySqlDataReader.GetOrdinal("a_name_tur");
                string s24 = mySqlDataReader.GetString(ordinal24);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s24).Length);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s24));
                int ordinal25 = mySqlDataReader.GetOrdinal("a_name_ita");
                string s25 = mySqlDataReader.GetString(ordinal25);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s25).Length);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s25));
                int ordinal26 = mySqlDataReader.GetOrdinal("a_name_thai");
                string s26 = mySqlDataReader.GetString(ordinal26);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s26).Length);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s26));
                int ordinal27 = mySqlDataReader.GetOrdinal("a_name_uk");
                string s27 = mySqlDataReader.GetString(ordinal27);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s27).Length);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s27));
                int ordinal28 = mySqlDataReader.GetOrdinal("a_name_dev");
                string s28 = mySqlDataReader.GetString(ordinal28);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s28).Length);
                binaryWriter.Write(Encoding.UTF8.GetBytes(s28));
             int num2 = databaseHandle.CountByRow(Host, User, Password, Database, "SELECT COUNT(*) FROM t_affinity_npc WHERE a_npcidx ='" + s1 + "'");
                binaryWriter.Write(num2);
                MySqlConnection mySqlConnection2= new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);

                string str3 = "SELECT * FROM t_affinity_npc WHERE a_npcidx='" + s1 + "' ORDER BY a_affinity_idx";
               //ySqlConnection mySqlConnection2 = new MySqlConnection(mySqlConnection2);
                MySqlCommand command2 = mySqlConnection2.CreateCommand();
                command2.CommandText = str3;
                mySqlConnection2.Open();
                MySqlDataReader mySqlDataReader2 = command2.ExecuteReader();
                while (mySqlDataReader2.Read())
                {
                    int ordinal29= mySqlDataReader2.GetOrdinal("a_affinity_idx");
                    string s29 = mySqlDataReader2.GetString(ordinal29);
                    binaryWriter.Write(int.Parse(s29));
                    int ordinal30 = mySqlDataReader2.GetOrdinal("a_npcidx");
                    string s30= mySqlDataReader2.GetString(ordinal30);
                    binaryWriter.Write(int.Parse(s30));
                    int ordinal31 = mySqlDataReader2.GetOrdinal("a_use_point");
                    string s31 = mySqlDataReader2.GetString(ordinal31);
                    binaryWriter.Write(int.Parse(s31));
                    int ordinal32 = mySqlDataReader2.GetOrdinal("a_enable");
                    string s32 = mySqlDataReader2.GetString(ordinal32);
                    binaryWriter.Write(int.Parse(s32));
                    int ordinal33 = mySqlDataReader2.GetOrdinal("a_flag");
                    string s33 = mySqlDataReader2.GetString(ordinal33);
                    binaryWriter.Write(int.Parse(s33));
                    int ordinal34 = mySqlDataReader2.GetOrdinal("a_string_idx");
                    string s34 = mySqlDataReader2.GetString(ordinal34);
                    binaryWriter.Write(int.Parse(s34));
                }
                mySqlConnection2.Close();
                binaryWriter.Write(0);
                binaryWriter.Write(0);
                
            }
            mySqlConnection.Close();
            binaryWriter.Close();
            messageHandle.SuccessFileMessage();
        }

    }
}
