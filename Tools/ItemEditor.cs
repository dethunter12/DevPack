// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.Tools.ItemEditor
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using MySql.Data.MySqlClient;
using StringExporter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools
{
  public class ItemEditor : Form
  {
    public static Connection connection = new Connection();
    public string Host = ItemEditor.connection.ReadSettings("Host");
    public string User = ItemEditor.connection.ReadSettings("User");
    public string Password = ItemEditor.connection.ReadSettings("Password");
    public string Database = ItemEditor.connection.ReadSettings("Database");
    private DatabaseHandle databaseHandle = new DatabaseHandle();
    public string rowName = "a_index";
    public string[] menuArray = new string[2]
    {
      "a_index",
      "a_name"
    };
    public string[] SearchMenu = new string[2]
    {
      "a_index",
      "a_name"
    };
    private string Episode = ItemEditor.connection.ReadSettings("Episode");
    public List<string> MenuList = new List<string>();
    public List<string> MenuListSearch = new List<string>();
    private ExportLodHandle exportLodHandle = new ExportLodHandle();
    private IContainer components = (IContainer) null;
    public string name;
    public int index;
    public string test2;
    public List<string> lArrayLevel;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileExportToolStripMenuItem;
    private ToolStripMenuItem exportlodToolStripMenuItem;
    private GroupBox groupBox3;
    private Button button3;
    private Button button1;
    private ListBox listBox1;
    private GroupBox groupBox5;
    private Label label7;
    private TextBox textBox12;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TabPage tabPage3;
    private Button button2;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private TextBox textBox2;
    private Label label3;
    private TextBox textBox3;
    private Label label2;
    private TextBox textBox4;
    private Label label4;
    private Label label6;
    private TextBox textBox1;
    private Label label5;
    private Label label1;
    private TextBox textBox5;
    private TextBox textBox6;
    private GroupBox groupBox4;
    private TextBox textBox15;
    private Label label15;
    private TextBox textBox10;
    private Label label11;
    private Label label14;
    private TextBox textBox11;
    private TextBox textBox14;
    private Label label12;
    private Label label13;
    private TextBox textBox13;
    private Label label9;
    private Label label10;
    private TextBox textBox8;
    private TextBox textBox9;
    private TextBox textBox7;
    private GroupBox groupBox6;
    private TextBox textBox19;
    private Label label19;
    private TextBox textBox16;
    private Label label16;
    private Label label18;
    private TextBox textBox17;
    private TextBox textBox18;
    private Label label17;
    private Label label20;
    private TextBox textBox20;
    private TextBox textBox21;
    private Label label21;
    private GroupBox groupBox7;
    private TextBox textBox28;
    private Label label28;
    private TextBox textBox27;
    private Label label27;
    private TextBox textBox26;
    private Label label26;
    private TextBox textBox25;
    private Label label25;
    private TextBox textBox24;
    private Label label24;
    private TextBox textBox23;
    private Label label23;
    private TextBox textBox22;
    private Label label22;
    private TextBox textBox31;
    private Label label31;
    private TextBox textBox30;
    private Label label30;
    private TextBox textBox29;
    private Label label29;
    private TextBox textBox41;
    private Label label41;
    private TextBox textBox40;
    private Label label40;
    private TextBox textBox39;
    private Label label39;
    private TextBox textBox38;
    private Label label38;
    private TextBox textBox37;
    private Label label37;
    private TextBox textBox36;
    private Label label36;
    private TextBox textBox35;
    private Label label35;
    private TextBox textBox34;
    private Label label34;
    private TextBox textBox33;
    private Label label33;
    private TextBox textBox32;
    private Label label32;
    private GroupBox groupBox8;
    private TextBox textBox43;
    private Label label43;
    private TextBox textBox42;
    private Label label42;
    private TextBox textBox45;
    private Label label45;
    private TextBox textBox44;
    private Label label44;
    private TextBox textBox46;
    private Label label46;
    private Label label47;
    private TextBox textBox47;
    private GroupBox groupBox9;
    private Label label50;
    private TextBox textBox50;
    private Label label49;
    private TextBox textBox49;
    private Label label48;
    private TextBox textBox48;
    private PictureBox pictureBox1;
    private LinkLabel linkLabel1;
    private GroupBox groupBox10;
    private TextBox textBox55;
    private Label label55;
    private TextBox textBox54;
    private Label label54;
    private TextBox textBox53;
    private Label label53;
    private TextBox textBox52;
    private Label label52;
    private TextBox textBox51;
    private Label label51;
    private GroupBox groupBox11;
    private TextBox textBox57;
    private Label label56;
    private Label label57;
    private TextBox textBox56;
    private TextBox textBox58;
    private Label label58;
    private TextBox textBox59;
    private Label label59;
    private GroupBox groupBox12;
    private GroupBox groupBox13;
    private TextBox textBox68;
    private Label label68;
    private TextBox textBox67;
    private Label label67;
    private TextBox textBox66;
    private Label label66;
    private TextBox textBox65;
    private Label label65;
    private TextBox textBox64;
    private Label label64;
    private TextBox textBox63;
    private Label label63;
    private TextBox textBox62;
    private Label label62;
    private TextBox textBox61;
    private Label label61;
    private TextBox textBox60;
    private Label label60;
    private TextBox textBox69;
    private Label label69;
    private TextBox textBox79;
    private Label label79;
    private TextBox textBox78;
    private Label label78;
    private TextBox textBox77;
    private Label label77;
    private TextBox textBox76;
    private Label label76;
    private TextBox textBox75;
    private Label label75;
    private TextBox textBox74;
    private Label label74;
    private TextBox textBox73;
    private Label label73;
    private TextBox textBox72;
    private Label label72;
    private TextBox textBox71;
    private Label label71;
    private TextBox textBox70;
    private Label label70;
    private GroupBox groupBox14;
    private Label label80;
    private TextBox textBox80;
    private Label label82;
    private TextBox textBox82;
    private Label label81;
    private TextBox textBox81;
    private TextBox textBox83;
    private Label label83;
    private TextBox textBox84;
    private Label label84;
    private GroupBox groupBox16;
    private TextBox textBox93;
    private Label label93;
    private Label label92;
    private TextBox textBox92;
    private Label label91;
    private TextBox textBox91;
    private TextBox textBox94;
    private Label label94;
    private CheckBox checkBox1;
    private ComboBox comboBox1;
    private ComboBox comboBox4;
    private ComboBox comboBox2;
    private TabPage tabPage5;
    private TabPage tabPage6;
    private GroupBox groupBox17;
    private CheckedListBox clbFlagTest;
    private GroupBox groupBox15;
    private TextBox textBox90;
    private Label label90;
    private TextBox textBox89;
    private Label label89;
    private TextBox textBox88;
    private Label label88;
    private TextBox textBox87;
    private Label label87;
    private TextBox textBox86;
    private Label label86;
    private TextBox textBox85;
    private Label label85;
    private Button button4;
    private ToolStripMenuItem exportStrItemlodToolStripMenuItem;
    private CheckedListBox checkedListBox1;
    private GroupBox groupBox18;
    private ComboBox comboBox24;
    private ComboBox comboBox23;
    private ComboBox comboBox22;
    private ComboBox comboBox21;
    private ComboBox comboBox20;
    private ComboBox comboBox19;
    private ComboBox comboBox18;
    private ComboBox comboBox17;
    private ComboBox comboBox16;
    private ComboBox comboBox15;
    private ComboBox comboBox14;
    private ComboBox comboBox13;
    private ComboBox comboBox12;
    private ComboBox comboBox11;
    private ComboBox comboBox10;
    private ComboBox comboBox9;
    private ComboBox comboBox8;
    private ComboBox comboBox7;
    private ComboBox comboBox6;
    private ComboBox comboBox5;
    private ComboBox comboBox3;

    public ItemEditor()
    {
            InitializeComponent();
    }

    private void LoadListBox()
    {
            MenuList.Clear();
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_index, a_name from t_item ORDER BY a_index;");
      for (int index = 0; index < listBox1.Items.Count; ++index)
                MenuList.Add(listBox1.Items[index].ToString());
            listBox1.DataSource = MenuList;
    }

    public void SearchList(string searchString)
    {
      searchString = searchString.Replace("\\", "\\\\").Replace("'", "\\'");
      string lower = searchString.ToLower();
      string upper = searchString.ToUpper();
      string str = "";
      if (searchString.Length > 1)
        str = char.ToUpper(searchString[0]).ToString() + searchString.Substring(1);
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_index, a_name from t_item WHERE a_name LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");
    }

    private void Exporter_Item_Load(object sender, EventArgs e)
    {
            LoadStartUp();
      try
      {
                LoadListBox();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message, "Unknown Exception", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    public void LoadMisc()
    {
            checkBox1.Checked = textBox4.Text == "1";
      int num1 = comboBox1.FindString(textBox2.Text);
      int num2 = comboBox2.FindString(textBox3.Text);
      int num3 = comboBox4.FindString(textBox9.Text);
      try
      {
                comboBox1.SelectedIndex = num1;
                comboBox2.SelectedIndex = num2;
                comboBox4.SelectedIndex = num3;
      }
      catch
      {
      }
    }

    public int GetIndex()
    {
      try
      {
        return Convert.ToInt32(listBox1.Text.Split(' ')[0]);
      }
      catch
      {
        return 0;
      }
    }

    public int GetIndexByComboBox(string comboBox)
    {
      try
      {
        return Convert.ToInt32(comboBox.Split(' ')[0]);
      }
      catch
      {
        return 0;
      }
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listBox1.SelectedIndex != -1)
                textBox1.Text = GetIndex().ToString();
      string Query = " select a_index , a_type_idx , a_subtype_idx , a_enable , a_name , a_descr , a_job_flag , a_flag , a_wearing , a_num_0 , a_num_1 , a_num_2, a_num_3 , a_num_4 , a_level , a_level2 , a_weight , a_price , a_max_use , a_drop_prob_10 , a_need_item0 , a_need_item1 , a_need_item2 , a_need_item3 , a_need_item4 , a_need_item5 , a_need_item6 , a_need_item7 , a_need_item8 , a_need_item9 , a_need_item_count0 , a_need_item_count1 , a_need_item_count2 , a_need_item_count3 , a_need_item_count4 , a_need_item_count5 , a_need_item_count6 , a_need_item_count7 , a_need_item_count8 , a_need_item_count9 , a_need_sskill , a_need_sskill_level , a_need_sskill2 , a_need_sskill_level2 , a_zone_flag , a_file_smc , a_texture_id , a_texture_row , a_texture_col , b_todo_delete , a_set_0 , a_set_1 , a_set_2 , a_set_3 , a_set_4 , a_set , a_grade , a_fame , a_rare_index_0 , a_rare_index_1 , a_rare_index_2 , a_rare_index_3 , a_rare_index_4 , a_rare_index_5 , a_rare_index_6 , a_rare_index_7 , a_rare_index_8 , a_rare_index_9 , a_rare_prob_0 , a_rare_prob_1 , a_rare_prob_2 , a_rare_prob_3 , a_rare_prob_4 , a_rare_prob_5 , a_rare_prob_6 , a_rare_prob_7 , a_rare_prob_8 , a_rare_prob_9 , a_effect_name, a_attack_effect_name, a_damage_effect_name, a_quest_trigger_count , a_quest_trigger_ids , a_origin_variation1 , a_origin_variation2 , a_origin_variation3 , a_origin_variation4 , a_origin_variation5 , a_origin_variation6 , a_rvr_value , a_rvr_grade , a_durability , a_castle_war from t_item WHERE a_index ='" + textBox1.Text + "';";
      string[] rows = new string[93]
      {
        "a_index",
        "a_type_idx",
        "a_subtype_idx",
        "a_enable",
        "a_name",
        "a_descr",
        "a_job_flag",
        "a_flag",
        "a_wearing",
        "a_num_0",
        "a_num_1",
        "a_num_2",
        "a_num_3",
        "a_num_4",
        "a_level",
        "a_level2",
        "a_weight",
        "a_price",
        "a_max_use",
        "a_drop_prob_10",
        "a_need_item0",
        "a_need_item1",
        "a_need_item2",
        "a_need_item3",
        "a_need_item4",
        "a_need_item5",
        "a_need_item6",
        "a_need_item7",
        "a_need_item8",
        "a_need_item9",
        "a_need_item_count0",
        "a_need_item_count1",
        "a_need_item_count2",
        "a_need_item_count3",
        "a_need_item_count4",
        "a_need_item_count5",
        "a_need_item_count6",
        "a_need_item_count7",
        "a_need_item_count8",
        "a_need_item_count9",
        "a_need_sskill",
        "a_need_sskill_level",
        "a_need_sskill2",
        "a_need_sskill_level2",
        "a_zone_flag",
        "a_file_smc",
        "a_texture_id",
        "a_texture_row",
        "a_texture_col",
        "b_todo_delete",
        "a_set_0",
        "a_set_1",
        "a_set_2",
        "a_set_3",
        "a_set_4",
        "a_set",
        "a_grade",
        "a_fame",
        "a_rare_index_0",
        "a_rare_index_1",
        "a_rare_index_2",
        "a_rare_index_3",
        "a_rare_index_4",
        "a_rare_index_5",
        "a_rare_index_6",
        "a_rare_index_7",
        "a_rare_index_8",
        "a_rare_index_9",
        "a_rare_prob_0",
        "a_rare_prob_1",
        "a_rare_prob_2",
        "a_rare_prob_3",
        "a_rare_prob_4",
        "a_rare_prob_5",
        "a_rare_prob_6",
        "a_rare_prob_7",
        "a_rare_prob_8",
        "a_rare_prob_9",
        "a_effect_name",
        "a_attack_effect_name",
        "a_damage_effect_name",
        "a_quest_trigger_count",
        "a_quest_trigger_ids",
        "a_origin_variation1",
        "a_origin_variation2",
        "a_origin_variation3",
        "a_origin_variation4",
        "a_origin_variation5",
        "a_origin_variation6",
        "a_rvr_value",
        "a_rvr_grade",
        "a_durability",
        "a_castle_war"
      };
      Query.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'");
      string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query, rows);
            textBox1.Text = strArray[0];
            textBox2.Text = strArray[1];
            textBox3.Text = strArray[2];
            textBox4.Text = strArray[3];
            textBox5.Text = strArray[4];
            textBox6.Text = strArray[5];
            textBox7.Text = strArray[6];
            textBox8.Text = strArray[7];
            textBox9.Text = strArray[8];
            textBox10.Text = strArray[9];
            textBox11.Text = strArray[10];
            textBox13.Text = strArray[11];
            textBox14.Text = strArray[12];
            textBox15.Text = strArray[13];
            textBox16.Text = strArray[14];
            textBox17.Text = strArray[15];
            textBox18.Text = strArray[16];
            textBox19.Text = strArray[17];
            textBox20.Text = strArray[18];
            textBox21.Text = strArray[19];
            textBox22.Text = strArray[20];
            textBox23.Text = strArray[21];
            textBox24.Text = strArray[22];
            textBox25.Text = strArray[23];
            textBox26.Text = strArray[24];
            textBox27.Text = strArray[25];
            textBox28.Text = strArray[26];
            textBox29.Text = strArray[27];
            textBox30.Text = strArray[28];
            textBox31.Text = strArray[29];
            textBox32.Text = strArray[30];
            textBox33.Text = strArray[31];
            textBox34.Text = strArray[32];
            textBox35.Text = strArray[33];
            textBox36.Text = strArray[34];
            textBox37.Text = strArray[35];
            textBox38.Text = strArray[36];
            textBox39.Text = strArray[37];
            textBox40.Text = strArray[38];
            textBox41.Text = strArray[39];
            textBox42.Text = strArray[40];
            textBox43.Text = strArray[41];
            textBox44.Text = strArray[42];
            textBox45.Text = strArray[43];
            textBox46.Text = strArray[44];
            textBox47.Text = strArray[45];
            textBox48.Text = strArray[46];
            textBox49.Text = strArray[47];
            textBox50.Text = strArray[48];
            textBox51.Text = strArray[49];
            textBox52.Text = strArray[50];
            textBox53.Text = strArray[51];
            textBox54.Text = strArray[52];
            textBox55.Text = strArray[53];
            textBox56.Text = strArray[54];
            textBox57.Text = strArray[55];
            textBox58.Text = strArray[56];
            textBox59.Text = strArray[57];
            textBox60.Text = strArray[58];
            textBox61.Text = strArray[59];
            textBox62.Text = strArray[60];
            textBox63.Text = strArray[61];
            textBox64.Text = strArray[62];
            textBox65.Text = strArray[63];
            textBox66.Text = strArray[64];
            textBox67.Text = strArray[65];
            textBox68.Text = strArray[66];
            textBox69.Text = strArray[67];
            textBox70.Text = strArray[68];
            textBox71.Text = strArray[69];
            textBox72.Text = strArray[70];
            textBox73.Text = strArray[71];
            textBox74.Text = strArray[72];
            textBox75.Text = strArray[73];
            textBox76.Text = strArray[74];
            textBox77.Text = strArray[75];
            textBox78.Text = strArray[76];
            textBox79.Text = strArray[77];
            textBox80.Text = strArray[78];
            textBox81.Text = strArray[79];
            textBox82.Text = strArray[80];
            textBox83.Text = strArray[81];
            textBox84.Text = strArray[82];
            textBox85.Text = strArray[83];
            textBox86.Text = strArray[84];
            textBox87.Text = strArray[85];
            textBox88.Text = strArray[86];
            textBox89.Text = strArray[87];
            textBox90.Text = strArray[88];
            textBox91.Text = strArray[89];
            textBox92.Text = strArray[90];
            textBox93.Text = strArray[91];
            textBox94.Text = strArray[92];
      try
      {
                comboBox5.SelectedIndex = Convert.ToInt32(textBox60.Text);
                comboBox6.SelectedIndex = Convert.ToInt32(textBox61.Text);
                comboBox7.SelectedIndex = Convert.ToInt32(textBox62.Text);
                comboBox8.SelectedIndex = Convert.ToInt32(textBox63.Text);
                comboBox9.SelectedIndex = Convert.ToInt32(textBox64.Text);
                comboBox15.SelectedIndex = Convert.ToInt32(textBox65.Text);
                comboBox16.SelectedIndex = Convert.ToInt32(textBox66.Text);
      }
      catch
      {
      }
      int int32 = Convert.ToInt32(strArray[6]);
      if (Episode == "EP4")
                ShowFlagLong(Convert.ToInt64(strArray[7]));
      else
                ShowFlag(Convert.ToInt32(strArray[7]));
            ShowJobFlag(int32);
            LoadMisc();
      try
      {
                pictureBox1.Image = (Image)databaseHandle.IconItem(int.Parse(textBox48.Text), int.Parse(textBox49.Text), int.Parse(textBox50.Text));
      }
      catch
      {
      }
    }

    private void label45_Click(object sender, EventArgs e)
    {
    }

    private void button2_Click(object sender, EventArgs e)
    {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_item SET " + "a_type_idx = '" + textBox2.Text + "', " + "a_subtype_idx = '" + textBox3.Text + "', " + "a_enable = '" + textBox4.Text + "', " + "a_name = '" + textBox5.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "', " + "a_descr = '" + textBox6.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "', " + "a_job_flag = '" + textBox7.Text + "', " + "a_flag = '" + textBox8.Text + "', " + "a_wearing = '" + textBox9.Text + "', " + "a_num_0 = '" + textBox10.Text + "', " + "a_num_1 = '" + textBox11.Text + "', " + "a_num_2 = '" + textBox13.Text + "', " + "a_num_3 = '" + textBox14.Text + "', " + "a_num_4 = '" + textBox15.Text + "', " + "a_level = '" + textBox16.Text + "', " + "a_level2 = '" + textBox17.Text + "', " + "a_weight = '" + textBox18.Text + "', " + "a_price = '" + textBox19.Text + "', " + "a_max_use = '" + textBox20.Text + "', " + "a_drop_prob_10 = '" + textBox21.Text + "', " + "a_need_item0 = '" + textBox22.Text + "', " + "a_need_item1 = '" + textBox23.Text + "', " + "a_need_item2 = '" + textBox24.Text + "', " + "a_need_item3 = '" + textBox25.Text + "', " + "a_need_item4 = '" + textBox26.Text + "', " + "a_need_item5 = '" + textBox27.Text + "', " + "a_need_item6 = '" + textBox28.Text + "', " + "a_need_item7 = '" + textBox29.Text + "', " + "a_need_item8 = '" + textBox30.Text + "', " + "a_need_item9 = '" + textBox31.Text + "', " + "a_need_item_count0 = '" + textBox32.Text + "', " + "a_need_item_count1 = '" + textBox33.Text + "', " + "a_need_item_count2 = '" + textBox34.Text + "', " + "a_need_item_count3 = '" + textBox35.Text + "', " + "a_need_item_count4 = '" + textBox36.Text + "', " + "a_need_item_count5 = '" + textBox37.Text + "', " + "a_need_item_count6 = '" + textBox38.Text + "', " + "a_need_item_count7 = '" + textBox39.Text + "', " + "a_need_item_count8 = '" + textBox40.Text + "', " + "a_need_item_count9 = '" + textBox41.Text + "', " + "a_need_sskill = '" + textBox42.Text + "', " + "a_need_sskill_level = '" + textBox43.Text + "', " + "a_need_sskill2 = '" + textBox44.Text + "', " + "a_need_sskill_level2 = '" + textBox45.Text + "', " + "a_zone_flag = '" + textBox46.Text + "', " + "a_file_smc = '" + textBox47.Text.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'") + "', " + "a_texture_id = '" + textBox48.Text + "', " + "a_texture_row = '" + textBox49.Text + "', " + "a_texture_col = '" + textBox50.Text + "', " + "b_todo_delete = '" + textBox51.Text + "', " + "a_set_0 = '" + textBox52.Text + "', " + "a_set_1 = '" + textBox53.Text + "', " + "a_set_2 = '" + textBox54.Text + "', " + "a_set_3 = '" + textBox55.Text + "', " + "a_set_4 = '" + textBox56.Text + "', " + "a_set = '" + textBox57.Text + "', " + "a_grade = '" + textBox58.Text + "', " + "a_fame = '" + textBox59.Text + "', " + "a_rare_index_0 = '" + textBox60.Text + "', " + "a_rare_index_1 = '" + textBox61.Text + "', " + "a_rare_index_2 = '" + textBox62.Text + "', " + "a_rare_index_3 = '" + textBox63.Text + "', " + "a_rare_index_4 = '" + textBox64.Text + "', " + "a_rare_index_5 = '" + textBox65.Text + "', " + "a_rare_index_6 = '" + textBox66.Text + "', " + "a_rare_index_7 = '" + textBox67.Text + "', " + "a_rare_index_8 = '" + textBox68.Text + "', " + "a_rare_index_9 = '" + textBox69.Text + "', " + "a_rare_prob_0 = '" + textBox70.Text + "', " + "a_rare_prob_1 = '" + textBox71.Text + "', " + "a_rare_prob_2 = '" + textBox72.Text + "', " + "a_rare_prob_3 = '" + textBox73.Text + "', " + "a_rare_prob_4 = '" + textBox74.Text + "', " + "a_rare_prob_5 = '" + textBox75.Text + "', " + "a_rare_prob_6 = '" + textBox76.Text + "', " + "a_rare_prob_7 = '" + textBox77.Text + "', " + "a_rare_prob_8 = '" + textBox78.Text + "', " + "a_rare_prob_9 = '" + textBox79.Text + "', " + "a_effect_name = '" + textBox80.Text + "', " + "a_attack_effect_name = '" + textBox81.Text + "', " + "a_damage_effect_name = '" + textBox82.Text + "', " + "a_quest_trigger_count = '" + textBox83.Text + "', " + "a_quest_trigger_ids = '" + textBox84.Text + "', " + "a_origin_variation1 = '" + textBox85.Text + "', " + "a_origin_variation2 = '" + textBox86.Text + "', " + "a_origin_variation3 = '" + textBox87.Text + "', " + "a_origin_variation4 = '" + textBox88.Text + "', " + "a_origin_variation5 = '" + textBox89.Text + "', " + "a_origin_variation6 = '" + textBox90.Text + "', " + "a_rvr_value = '" + textBox91.Text + "', " + "a_rvr_grade = '" + textBox92.Text + "', " + "a_durability = '" + textBox93.Text + "', " + "a_castle_war = '" + textBox94.Text + "' " + "WHERE a_index = '" + textBox1.Text + "'");
      int selectedIndex = listBox1.SelectedIndex;
      if (textBox12.Text != "")
                SearchList(textBox12.Text);
      else
                LoadListBox();
            listBox1.SelectedIndex = selectedIndex;
    }

    private void button1_Click(object sender, EventArgs e)
    {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "INSERT INTO t_item DEFAULT VALUES");
            LoadListBox();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      int selectedIndex = listBox1.SelectedIndex;
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_item WHERE a_index = '" + textBox1.Text + "'");
            LoadListBox();
            listBox1.SelectedIndex = selectedIndex - 1;
    }

    private void exportlodToolStripMenuItem_Click(object sender, EventArgs e)
    {
            exportLodHandle.ExportItemAll_V4();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      IconPickerItem iconPickerItem = new IconPickerItem();
      iconPickerItem.OldItemBtnSelect = Convert.ToInt32(textBox48.Text);
      if (iconPickerItem.ShowDialog() != DialogResult.OK)
        return;
            textBox48.Text = iconPickerItem.TexID.ToString();
            textBox49.Text = iconPickerItem.TexColumn.ToString();
            textBox50.Text = iconPickerItem.TexRow.ToString();
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_item SET " + "a_texture_id = '" + textBox48.Text + "', " + "a_texture_row = '" + textBox50.Text + "', " + "a_texture_col = '" + textBox49.Text + "' " + "WHERE a_index = '" + textBox1.Text + "'");
      int selectedIndex = listBox1.SelectedIndex;
      if (textBox12.Text != "")
                SearchList(textBox12.Text);
      else
                LoadListBox();
            listBox1.SelectedIndex = selectedIndex;
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBox1.Checked)
                textBox4.Text = "1";
      else
                textBox4.Text = "0";
    }

    private void LoadStartUp()
    {
      string str1 = "SELECT * FROM t_option ORDER BY a_index";
      MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
      MySqlCommand command = mySqlConnection.CreateCommand();
      command.CommandText = str1;
      mySqlConnection.Open();
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (mySqlDataReader.Read())
      {
        int ordinal1 = mySqlDataReader.GetOrdinal("a_index");
        mySqlDataReader.GetString(ordinal1);
        int ordinal2 = mySqlDataReader.GetOrdinal("a_type");
        string str2 = mySqlDataReader.GetString(ordinal2);
        int ordinal3 = mySqlDataReader.GetOrdinal("a_name");
        string str3 = mySqlDataReader.GetString(ordinal3);
        string str4 = str2 + " - " + str3;
                comboBox5.Items.Add( str4);
                comboBox6.Items.Add( str4);
                comboBox7.Items.Add( str4);
                comboBox8.Items.Add( str4);
                comboBox9.Items.Add( str4);
                comboBox15.Items.Add( str4);
                comboBox16.Items.Add( str4);
                comboBox17.Items.Add( str4);
                comboBox18.Items.Add( str4);
                comboBox19.Items.Add( str4);
      }
      mySqlConnection.Close();
            checkedListBox1.Items.AddRange(new object[11]
      {
         "Titan",
         "Knight",
         "Healer",
         "Mage",
         "Rogue",
         "Sorcerer",
         "NS",
         "Ex-Rogue",
         "Ex-Mage",
         "P1 Pet",
         "P2 Pet"
      });
      if (Episode == "EP4")
                clbFlagTest.Items.AddRange(new object[64]
        {
           "Count",
           "Drop",
           "Upgrade",
           "Exchange",
           "Trade",
           "Not Delete",
           "Made",
           "Mix",
           "Cash",
           "Lord",
           "No Stash",
           "Change",
           "Composite",
           "Duplication",
           "lent",
           "Rare",
           "ABS",
           "Not Reform",
           "ZoneMove Del",
           "Origin",
           "Trigger",
           "Raid Special",
           "Quest",
           "Box",
           "Not TradeAgent",
           "Durability",
           "Costume2",
           "Socket",
           "Seller",
           "Castillan",
           "LetsParty",
           "Non-RVR",
           "Quest Give",
           "Toggle",
           "Compose",
           "NotSingle",
           "Invisible Custom",
           "37 ",
           "38 ",
           "39 ",
           "40 ",
           "41 ",
           "42 ",
           "43 ",
           "44 ",
           "45 ",
           "46 ",
           "47 ",
           "48 ",
           "49 ",
           "50 ",
           "51 ",
           "52 ",
           "53 ",
           "54 ",
           "55 ",
           "56 ",
           "57 ",
           "58 ",
           "59 ",
           "60 ",
           "61 ",
           "62 ",
           "63 "
        });
      else
                clbFlagTest.Items.AddRange(new object[37]
        {
           "Count",
           "Drop",
           "Upgrade",
           "Exchange",
           "Trade",
           "Not Delete",
           "Made",
           "Mix",
           "Cash",
           "Lord",
           "No Stash",
           "Change",
           "Composite",
           "Duplication",
           "lent",
           "Rare",
           "ABS",
           "Not Reform",
           "ZoneMove Del",
           "Origin",
           "Trigger",
           "Raid Special",
           "Quest",
           "Box",
           "Not TradeAgent",
           "Durability",
           "Costume2",
           "Socket",
           "Seller",
           "Castillan",
           "LetsParty",
           "Non-RVR",
           "Quest Give",
           "Toggle",
           "Compose",
           "NotSingle",
           "Invisible Custom"
        });
            comboBox1.Items.AddRange(new object[8]
      {
         "0 - Weapons",
         "1 - Armor",
         "2 - Books, Scrolls",
         "3 - Shot",
         "4 - Quest, Event, Upgrade",
         "5 - Accesoires, Pets",
         "6 - Potions",
         "Unknown"
      });
            comboBox4.Items.AddRange(new object[14]
      {
         "-1 - None",
         "0 - Hood Slot",
         "1 - Shirt Slot",
         "2 - Weapon Slot",
         "3 - Pants Slot",
         "4 - Shield Slot",
         "5 - Gloves Slot",
         "6 - Boots Slot",
         "7 - Accesoire Slot",
         "8 - Accesoire Slot",
         "9 - Accesoire Slot",
         "10 - Pet Slot",
         "11 - Wing Slot",
         "12 - Insignia Slot"
      });
    }

    public static string[] OptionValues(string Type)
    {
      List<string> stringList1 = new List<string>();
      string str1 = "SELECT * FROM t_option WHERE a_type = '" + Type + "'";
      Connection connection = new Connection();
      MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + connection.ReadSettings("Host") + ";port=3306;username=" + connection.ReadSettings("User") + ";password=" + connection.ReadSettings("Password") + ";database=" + connection.ReadSettings("Database"));
      MySqlCommand command = mySqlConnection.CreateCommand();
      command.CommandText = str1;
      mySqlConnection.Open();
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (mySqlDataReader.Read())
      {
        int ordinal = mySqlDataReader.GetOrdinal("a_level");
        string[] strArray1 = mySqlDataReader.GetString(ordinal).Split(' ');
        string[] strArray2 = new string[1000];
        int index1 = 0;
        List<string> stringList2 = new List<string>();
        foreach (string str2 in strArray1)
        {
          strArray2[index1] = str2;
          stringList2.Add(str2);
          ++index1;
        }
        int count = stringList2.Count;
        for (int index2 = 0; index2 < count; ++index2)
          stringList1.Add(stringList2[index2]);
      }
      mySqlConnection.Close();
      return stringList1.ToArray();
    }

    public static string[] SubTypes(int Type)
    {
      List<string> stringList = new List<string>();
      switch (Type)
      {
        case 0:
          stringList.Add("-1 - None");
          stringList.Add("0 - Single Sword");
          stringList.Add("1 - X-Bow");
          stringList.Add("2 - Staff");
          stringList.Add("3 - Big Sword");
          stringList.Add("4 - Axe");
          stringList.Add("5 - Wand");
          stringList.Add("6 - Bow");
          stringList.Add("7 - Dagger");
          stringList.Add("8 - Hammer");
          stringList.Add("9 - Knife");
          stringList.Add("10 - Energy Collector");
          stringList.Add("11 - Dual Swords");
          stringList.Add("12 - Scepter");
          stringList.Add("13 - Scythe");
          stringList.Add("14 - Fallarm");
          stringList.Add("15 - NS Weapon");
          break;
        case 1:
          stringList.Add("-1 - None");
          stringList.Add("0 - Helm");
          stringList.Add("1 - Shirt");
          stringList.Add("2 - Pants");
          stringList.Add("3 - Gloves");
          stringList.Add("4 - Boots");
          stringList.Add("5 - Shield");
          stringList.Add("6 - Wing");
          stringList.Add("7 - Complete Costume");
          break;
        case 2:
          stringList.Add("-1 - None");
          stringList.Add("0 - Teleporting");
          stringList.Add("1 - Production Manual");
          stringList.Add("2 - Crafting Manual");
          stringList.Add("3 - Box");
          stringList.Add("4 - Potion Manual");
          stringList.Add("5 - Transformation Scrolls");
          stringList.Add("6 - Quest Scrolls");
          stringList.Add("7 - Changing Stuff");
          stringList.Add("8 - Mob Summoning");
          stringList.Add("9 - Boxes and Monstercombo");
          stringList.Add("10 - Attack Scrolls");
          stringList.Add("11 - Titles");
          stringList.Add("12 - Reward Package");
          stringList.Add("13 - Jumping Potion");
          stringList.Add("14 - Extend Character Slot");
          stringList.Add("15 - Server Trans");
          stringList.Add("16 - Remote Express");
          stringList.Add("17 - Jewel Pocket");
          stringList.Add("18 - Chaos Jewel Pocket");
          stringList.Add("19 - Cash Inventory");
          stringList.Add("20 - Pet Stash");
          stringList.Add("21 - GPS");
          stringList.Add("22 - Holy Water");
          stringList.Add("23 - Protect PVP");
          break;
        case 3:
          stringList.Add("-1 - None");
          stringList.Add("0 - Item Bullet Attack");
          stringList.Add("1 - Item Bullet Mana");
          stringList.Add("2 - Item Bullet Arrow");
          break;
        case 4:
          stringList.Add("-1 - None");
          stringList.Add("0 - Quest Items");
          stringList.Add("1 - Event");
          stringList.Add("2 - SkillUp");
          stringList.Add("3 - Upgrade Stuff");
          stringList.Add("4 - Materials & Skillbooks");
          stringList.Add("5 - Gold");
          stringList.Add("6 - Materials 1");
          stringList.Add("7 - Materials 2");
          stringList.Add("8 - Bloodseal Items");
          stringList.Add("9 - Powder");
          stringList.Add("10 - Event Items 1");
          stringList.Add("11 - Castle Siege Concentration");
          stringList.Add("12 - Castle Siege Powder");
          stringList.Add("13 - Castle Siege Stone");
          stringList.Add("14 - [P2] Target");
          stringList.Add("15 - Quest Trigger");
          stringList.Add("16 - Socket Jewel");
          stringList.Add("17 - Socket Upgrading");
          stringList.Add("18 - Socket Creation");
          stringList.Add("19 - Monster Mercenary");
          stringList.Add("20 - Guild Mark");
          stringList.Add("21 - Reformer");
          stringList.Add("22 - Chaos jewel");
          stringList.Add("23 - Function");
          stringList.Add("23 - RvR Jewel");
          break;
        case 5:
          stringList.Add("-1 - None");
          stringList.Add("0 - Accesoires Charm");
          stringList.Add("1 - Accesoires Magic Stone");
          stringList.Add("2 - Accesoires Light Stone");
          stringList.Add("3 - Accesoires Earing");
          stringList.Add("4 - Accesoires Ring");
          stringList.Add("5 - Accesoires Necklace");
          stringList.Add("6 - P1 Pet");
          stringList.Add("7 - P2 Pet");
          stringList.Add("8 - Artifact");
          break;
        case 6:
          stringList.Add("-1 - None");
          stringList.Add("0 - Antidotes / Cures");
          stringList.Add("1 - HP Heal Potions");
          stringList.Add("2 - MP Heal Potions");
          stringList.Add("3 - HP+MP Heal Potions");
          stringList.Add("4 - HP, MP, Attack Boost");
          stringList.Add("5 - Steroids");
          stringList.Add("6 - Minerals");
          stringList.Add("7 - Tears");
          stringList.Add("8 - Exp Crystals");
          stringList.Add("9 - NPC Scroll");
          stringList.Add("10 - HP Recovery Speed Potions");
          stringList.Add("11 - MP Recovery Speed Potions");
          stringList.Add("12 - [P2] Heal Items");
          stringList.Add("13 - [P2] SpeedUp");
          break;
        default:
          stringList.Add("-1 - Unknown");
          break;
      }
      return stringList.ToArray();
    }

    public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange((object[]) ItemEditor.SubTypes(comboBox1.SelectedIndex));
            textBox2.Text = comboBox1.SelectedIndex.ToString();
            LoadMisc();
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox3.Text = GetIndexByComboBox(comboBox2.Text).ToString();
    }

    private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox9.Text = GetIndexByComboBox(comboBox4.Text).ToString();
    }

    public bool SearchString(string s)
    {
      return s.ToUpper().Contains(textBox12.Text.ToUpper());
    }

    private void textBox12_TextChanged(object sender, EventArgs e)
    {
            MenuListSearch = MenuList.FindAll(new Predicate<string>(SearchString));
            listBox1.DataSource = MenuListSearch;
    }

    private void SetFlag(long flag, CheckedListBox clbFlagTest)
    {
      for (int index = 0; index < 64; ++index)
        clbFlagTest.SetItemChecked(index, (flag & 1L << index) > 0L);
    }

    private long GetFlag(CheckedListBox clbFlagTest)
    {
      long num = 0;
      for (int index = 0; index < clbFlagTest.Items.Count; ++index)
      {
        if (clbFlagTest.GetItemChecked(index))
          num += 1L << index;
      }
      return num;
    }

    private void clbFlagTest_SelectedIndexChanged(object sender, EventArgs e)
    {
      long num = 0;
      for (int index = 0; index < clbFlagTest.Items.Count; ++index)
      {
        if (clbFlagTest.GetItemChecked(index))
          num += 1L << index;
      }
            textBox8.Text = num.ToString();
    }

    private void tabPage1_Click(object sender, EventArgs e)
    {
    }

    private void ShowJobFlag(int flag)
    {
      for (int index = 0; index < checkedListBox1.Items.Count; ++index)
                checkedListBox1.SetItemChecked(index, (flag & 1 << index) > 0);
    }

    private void ShowFlagLong(long flag)
    {
      for (int index = 0; index < 64; ++index)
                clbFlagTest.SetItemChecked(index, (flag & 1L << index) > 0L);
    }

    private void ShowFlag(int flag)
    {
      for (int index = 0; index < clbFlagTest.Items.Count; ++index)
                clbFlagTest.SetItemChecked(index, (flag & 1 << index) > 0);
    }

    private void button4_Click(object sender, EventArgs e)
    {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DROP TABLE IF EXISTS tempTable;" + "CREATE TEMPORARY TABLE tempTable ENGINE=MEMORY SELECT * FROM t_item WHERE a_index=" + textBox1.Text + ";" + "SELECT a_index FROM tempTable;" + "UPDATE tempTable SET a_index=(SELECT a_index from t_item ORDER BY a_index DESC LIMIT 1)+1; " + "SELECT a_index FROM tempTable;" + "INSERT INTO t_item SELECT * FROM tempTable;");
            LoadListBox();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
    }

    private void groupBox3_Enter(object sender, EventArgs e)
    {
    }

    private void exportStrItemlodToolStripMenuItem_Click(object sender, EventArgs e)
    {
            FormExport f2 = new FormExport();
            f2.Show(); // Shows Form2
        }

    private void groupBox5_Enter(object sender, EventArgs e)
    {
    }

    private void groupBox17_Enter(object sender, EventArgs e)
    {
    }

    private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      int num = 0;
      for (int index = 0; index < checkedListBox1.Items.Count; ++index)
      {
        if (checkedListBox1.GetItemChecked(index))
          num += 1 << index;
      }
            textBox7.Text = num.ToString();
    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
    }

    private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
    {
            comboBox10.Items.Clear();
            comboBox10.Items.AddRange((object[]) ItemEditor.OptionValues(comboBox5.SelectedIndex.ToString()));
            textBox60.Text = comboBox5.SelectedIndex.ToString();
    }

    private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
    {
            comboBox11.Items.Clear();
            comboBox11.Items.AddRange((object[]) ItemEditor.OptionValues(comboBox6.SelectedIndex.ToString()));
            textBox61.Text = comboBox6.SelectedIndex.ToString();
    }

    private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
    {
            comboBox12.Items.Clear();
            comboBox12.Items.AddRange((object[]) ItemEditor.OptionValues(comboBox7.SelectedIndex.ToString()));
            textBox62.Text = comboBox7.SelectedIndex.ToString();
    }

    private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
    {
            comboBox13.Items.Clear();
            comboBox13.Items.AddRange((object[]) ItemEditor.OptionValues(comboBox8.SelectedIndex.ToString()));
            textBox63.Text = comboBox8.SelectedIndex.ToString();
    }

    private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox70.Text = (comboBox10.SelectedIndex + 1).ToString();
    }

    private void groupBox9_Enter(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && components != null)
                components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportlodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportStrItemlodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.textBox90 = new System.Windows.Forms.TextBox();
            this.label90 = new System.Windows.Forms.Label();
            this.textBox89 = new System.Windows.Forms.TextBox();
            this.label89 = new System.Windows.Forms.Label();
            this.textBox88 = new System.Windows.Forms.TextBox();
            this.label88 = new System.Windows.Forms.Label();
            this.textBox87 = new System.Windows.Forms.TextBox();
            this.label87 = new System.Windows.Forms.Label();
            this.textBox86 = new System.Windows.Forms.TextBox();
            this.label86 = new System.Windows.Forms.Label();
            this.textBox85 = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.clbFlagTest = new System.Windows.Forms.CheckedListBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.label92 = new System.Windows.Forms.Label();
            this.textBox92 = new System.Windows.Forms.TextBox();
            this.label91 = new System.Windows.Forms.Label();
            this.textBox91 = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label82 = new System.Windows.Forms.Label();
            this.textBox82 = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.textBox81 = new System.Windows.Forms.TextBox();
            this.label80 = new System.Windows.Forms.Label();
            this.textBox80 = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.textBox93 = new System.Windows.Forms.TextBox();
            this.textBox94 = new System.Windows.Forms.TextBox();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.textBox84 = new System.Windows.Forms.TextBox();
            this.label84 = new System.Windows.Forms.Label();
            this.textBox83 = new System.Windows.Forms.TextBox();
            this.label83 = new System.Windows.Forms.Label();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.textBox59 = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.textBox58 = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label47 = new System.Windows.Forms.Label();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox24 = new System.Windows.Forms.ComboBox();
            this.comboBox23 = new System.Windows.Forms.ComboBox();
            this.comboBox22 = new System.Windows.Forms.ComboBox();
            this.comboBox21 = new System.Windows.Forms.ComboBox();
            this.comboBox20 = new System.Windows.Forms.ComboBox();
            this.comboBox19 = new System.Windows.Forms.ComboBox();
            this.comboBox18 = new System.Windows.Forms.ComboBox();
            this.comboBox17 = new System.Windows.Forms.ComboBox();
            this.comboBox16 = new System.Windows.Forms.ComboBox();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.textBox79 = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.textBox78 = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.textBox77 = new System.Windows.Forms.TextBox();
            this.label77 = new System.Windows.Forms.Label();
            this.textBox76 = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.textBox75 = new System.Windows.Forms.TextBox();
            this.label75 = new System.Windows.Forms.Label();
            this.textBox74 = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.textBox73 = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.textBox72 = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.textBox71 = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.textBox70 = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.textBox69 = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.textBox68 = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.textBox67 = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.textBox66 = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.textBox65 = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileExportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1251, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileExportToolStripMenuItem
            // 
            this.fileExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportlodToolStripMenuItem,
            this.exportStrItemlodToolStripMenuItem});
            this.fileExportToolStripMenuItem.Name = "fileExportToolStripMenuItem";
            this.fileExportToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.fileExportToolStripMenuItem.Text = "File Export";
            // 
            // exportlodToolStripMenuItem
            // 
            this.exportlodToolStripMenuItem.Name = "exportlodToolStripMenuItem";
            this.exportlodToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exportlodToolStripMenuItem.Text = "Export itemAll.lod";
            this.exportlodToolStripMenuItem.Click += new System.EventHandler(this.exportlodToolStripMenuItem_Click);
            // 
            // exportStrItemlodToolStripMenuItem
            // 
            this.exportStrItemlodToolStripMenuItem.Name = "exportStrItemlodToolStripMenuItem";
            this.exportStrItemlodToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exportStrItemlodToolStripMenuItem.Text = "Export strItem.lod";
            this.exportStrItemlodToolStripMenuItem.Click += new System.EventHandler(this.exportStrItemlodToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 566);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Items";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(97, 530);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Copy";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(173, 530);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 498);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.textBox12);
            this.groupBox5.Location = new System.Drawing.Point(12, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(265, 49);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Text:";
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Location = new System.Drawing.Point(53, 19);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(206, 20);
            this.textBox12.TabIndex = 20;
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(283, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(955, 636);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.groupBox15);
            this.tabPage1.Controls.Add(this.groupBox17);
            this.tabPage1.Controls.Add(this.groupBox16);
            this.tabPage1.Controls.Add(this.groupBox14);
            this.tabPage1.Controls.Add(this.groupBox12);
            this.tabPage1.Controls.Add(this.groupBox11);
            this.tabPage1.Controls.Add(this.groupBox10);
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(947, 610);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.textBox90);
            this.groupBox15.Controls.Add(this.label90);
            this.groupBox15.Controls.Add(this.textBox89);
            this.groupBox15.Controls.Add(this.label89);
            this.groupBox15.Controls.Add(this.textBox88);
            this.groupBox15.Controls.Add(this.label88);
            this.groupBox15.Controls.Add(this.textBox87);
            this.groupBox15.Controls.Add(this.label87);
            this.groupBox15.Controls.Add(this.textBox86);
            this.groupBox15.Controls.Add(this.label86);
            this.groupBox15.Controls.Add(this.textBox85);
            this.groupBox15.Controls.Add(this.label85);
            this.groupBox15.Location = new System.Drawing.Point(9, 534);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(675, 68);
            this.groupBox15.TabIndex = 0;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Origin\'s";
            // 
            // textBox90
            // 
            this.textBox90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox90.Location = new System.Drawing.Point(404, 40);
            this.textBox90.Name = "textBox90";
            this.textBox90.Size = new System.Drawing.Size(61, 20);
            this.textBox90.TabIndex = 52;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(336, 42);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(57, 13);
            this.label90.TabIndex = 53;
            this.label90.Text = "Variation6:";
            // 
            // textBox89
            // 
            this.textBox89.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox89.Location = new System.Drawing.Point(404, 14);
            this.textBox89.Name = "textBox89";
            this.textBox89.Size = new System.Drawing.Size(61, 20);
            this.textBox89.TabIndex = 50;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(336, 16);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(57, 13);
            this.label89.TabIndex = 51;
            this.label89.Text = "Variation5:";
            // 
            // textBox88
            // 
            this.textBox88.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox88.Location = new System.Drawing.Point(236, 14);
            this.textBox88.Name = "textBox88";
            this.textBox88.Size = new System.Drawing.Size(61, 20);
            this.textBox88.TabIndex = 48;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(168, 16);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(57, 13);
            this.label88.TabIndex = 49;
            this.label88.Text = "Variation4:";
            // 
            // textBox87
            // 
            this.textBox87.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox87.Location = new System.Drawing.Point(236, 40);
            this.textBox87.Name = "textBox87";
            this.textBox87.Size = new System.Drawing.Size(61, 20);
            this.textBox87.TabIndex = 46;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(168, 42);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(57, 13);
            this.label87.TabIndex = 47;
            this.label87.Text = "Variation3:";
            // 
            // textBox86
            // 
            this.textBox86.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox86.Location = new System.Drawing.Point(74, 40);
            this.textBox86.Name = "textBox86";
            this.textBox86.Size = new System.Drawing.Size(61, 20);
            this.textBox86.TabIndex = 44;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(6, 42);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(57, 13);
            this.label86.TabIndex = 45;
            this.label86.Text = "Variation2:";
            // 
            // textBox85
            // 
            this.textBox85.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox85.Location = new System.Drawing.Point(74, 14);
            this.textBox85.Name = "textBox85";
            this.textBox85.Size = new System.Drawing.Size(61, 20);
            this.textBox85.TabIndex = 42;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(6, 16);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(57, 13);
            this.label85.TabIndex = 43;
            this.label85.Text = "Variation1:";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.clbFlagTest);
            this.groupBox17.Location = new System.Drawing.Point(687, 6);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(252, 596);
            this.groupBox17.TabIndex = 54;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Flag";
            this.groupBox17.Enter += new System.EventHandler(this.groupBox17_Enter);
            // 
            // clbFlagTest
            // 
            this.clbFlagTest.BackColor = System.Drawing.SystemColors.Control;
            this.clbFlagTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbFlagTest.CheckOnClick = true;
            this.clbFlagTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbFlagTest.Location = new System.Drawing.Point(3, 16);
            this.clbFlagTest.MultiColumn = true;
            this.clbFlagTest.Name = "clbFlagTest";
            this.clbFlagTest.Size = new System.Drawing.Size(246, 577);
            this.clbFlagTest.TabIndex = 15;
            this.clbFlagTest.SelectedIndexChanged += new System.EventHandler(this.clbFlagTest_SelectedIndexChanged);
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.label92);
            this.groupBox16.Controls.Add(this.textBox92);
            this.groupBox16.Controls.Add(this.label91);
            this.groupBox16.Controls.Add(this.textBox91);
            this.groupBox16.Location = new System.Drawing.Point(418, 242);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(263, 100);
            this.groupBox16.TabIndex = 53;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "RvR";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(11, 49);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(39, 13);
            this.label92.TabIndex = 58;
            this.label92.Text = "Grade:";
            // 
            // textBox92
            // 
            this.textBox92.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox92.Location = new System.Drawing.Point(68, 46);
            this.textBox92.Name = "textBox92";
            this.textBox92.Size = new System.Drawing.Size(126, 20);
            this.textBox92.TabIndex = 57;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(11, 22);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(37, 13);
            this.label91.TabIndex = 56;
            this.label91.Text = "Value:";
            // 
            // textBox91
            // 
            this.textBox91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox91.Location = new System.Drawing.Point(68, 19);
            this.textBox91.Name = "textBox91";
            this.textBox91.Size = new System.Drawing.Size(126, 20);
            this.textBox91.TabIndex = 55;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.label82);
            this.groupBox14.Controls.Add(this.textBox82);
            this.groupBox14.Controls.Add(this.label81);
            this.groupBox14.Controls.Add(this.textBox81);
            this.groupBox14.Controls.Add(this.label80);
            this.groupBox14.Controls.Add(this.textBox80);
            this.groupBox14.Location = new System.Drawing.Point(212, 241);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(200, 100);
            this.groupBox14.TabIndex = 52;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Item Special Effects";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(6, 77);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(50, 13);
            this.label82.TabIndex = 58;
            this.label82.Text = "Damage:";
            // 
            // textBox82
            // 
            this.textBox82.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox82.Location = new System.Drawing.Point(63, 74);
            this.textBox82.Name = "textBox82";
            this.textBox82.Size = new System.Drawing.Size(126, 20);
            this.textBox82.TabIndex = 57;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(6, 49);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(41, 13);
            this.label81.TabIndex = 56;
            this.label81.Text = "Attack:";
            // 
            // textBox81
            // 
            this.textBox81.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox81.Location = new System.Drawing.Point(63, 46);
            this.textBox81.Name = "textBox81";
            this.textBox81.Size = new System.Drawing.Size(126, 20);
            this.textBox81.TabIndex = 55;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(6, 22);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(43, 13);
            this.label80.TabIndex = 54;
            this.label80.Text = "Normal:";
            // 
            // textBox80
            // 
            this.textBox80.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox80.Location = new System.Drawing.Point(63, 19);
            this.textBox80.Name = "textBox80";
            this.textBox80.Size = new System.Drawing.Size(126, 20);
            this.textBox80.TabIndex = 53;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.textBox93);
            this.groupBox12.Controls.Add(this.textBox94);
            this.groupBox12.Controls.Add(this.label93);
            this.groupBox12.Controls.Add(this.label94);
            this.groupBox12.Controls.Add(this.textBox84);
            this.groupBox12.Controls.Add(this.label84);
            this.groupBox12.Controls.Add(this.textBox83);
            this.groupBox12.Controls.Add(this.label83);
            this.groupBox12.Controls.Add(this.textBox51);
            this.groupBox12.Controls.Add(this.textBox59);
            this.groupBox12.Controls.Add(this.label51);
            this.groupBox12.Controls.Add(this.label59);
            this.groupBox12.Location = new System.Drawing.Point(495, 348);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(186, 180);
            this.groupBox12.TabIndex = 51;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Misc";
            // 
            // textBox93
            // 
            this.textBox93.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox93.Location = new System.Drawing.Point(111, 149);
            this.textBox93.Name = "textBox93";
            this.textBox93.Size = new System.Drawing.Size(69, 20);
            this.textBox93.TabIndex = 59;
            // 
            // textBox94
            // 
            this.textBox94.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox94.Location = new System.Drawing.Point(111, 124);
            this.textBox94.Name = "textBox94";
            this.textBox94.Size = new System.Drawing.Size(69, 20);
            this.textBox94.TabIndex = 55;
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(6, 151);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(53, 13);
            this.label93.TabIndex = 60;
            this.label93.Text = "Durability:";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(7, 126);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(59, 13);
            this.label94.TabIndex = 56;
            this.label94.Text = "CastleWar:";
            // 
            // textBox84
            // 
            this.textBox84.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox84.Location = new System.Drawing.Point(111, 98);
            this.textBox84.Name = "textBox84";
            this.textBox84.Size = new System.Drawing.Size(69, 20);
            this.textBox84.TabIndex = 53;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(7, 100);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(87, 13);
            this.label84.TabIndex = 54;
            this.label84.Text = "QuestTriggerIDs:";
            // 
            // textBox83
            // 
            this.textBox83.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox83.Location = new System.Drawing.Point(111, 72);
            this.textBox83.Name = "textBox83";
            this.textBox83.Size = new System.Drawing.Size(69, 20);
            this.textBox83.TabIndex = 51;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(6, 74);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(99, 13);
            this.label83.TabIndex = 52;
            this.label83.Text = "QuestTriggerCount:";
            // 
            // textBox51
            // 
            this.textBox51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox51.Location = new System.Drawing.Point(111, 46);
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(69, 20);
            this.textBox51.TabIndex = 42;
            // 
            // textBox59
            // 
            this.textBox59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox59.Location = new System.Drawing.Point(111, 20);
            this.textBox59.Name = "textBox59";
            this.textBox59.Size = new System.Drawing.Size(69, 20);
            this.textBox59.TabIndex = 49;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(6, 48);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(66, 13);
            this.label51.TabIndex = 43;
            this.label51.Text = "TodoDelete:";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(7, 22);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(36, 13);
            this.label59.TabIndex = 50;
            this.label59.Text = "Fame:";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.textBox58);
            this.groupBox11.Controls.Add(this.label58);
            this.groupBox11.Controls.Add(this.textBox57);
            this.groupBox11.Controls.Add(this.label57);
            this.groupBox11.Location = new System.Drawing.Point(6, 462);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(215, 66);
            this.groupBox11.TabIndex = 48;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Common RareOption";
            // 
            // textBox58
            // 
            this.textBox58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox58.Location = new System.Drawing.Point(156, 30);
            this.textBox58.Name = "textBox58";
            this.textBox58.Size = new System.Drawing.Size(53, 20);
            this.textBox58.TabIndex = 49;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(109, 32);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(33, 13);
            this.label58.TabIndex = 50;
            this.label58.Text = "Rate:";
            // 
            // textBox57
            // 
            this.textBox57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox57.Location = new System.Drawing.Point(43, 30);
            this.textBox57.Name = "textBox57";
            this.textBox57.Size = new System.Drawing.Size(53, 20);
            this.textBox57.TabIndex = 46;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(6, 32);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(21, 13);
            this.label57.TabIndex = 47;
            this.label57.Text = "ID:";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBox55);
            this.groupBox10.Controls.Add(this.label56);
            this.groupBox10.Controls.Add(this.label55);
            this.groupBox10.Controls.Add(this.textBox54);
            this.groupBox10.Controls.Add(this.textBox56);
            this.groupBox10.Controls.Add(this.label54);
            this.groupBox10.Controls.Add(this.textBox53);
            this.groupBox10.Controls.Add(this.label53);
            this.groupBox10.Controls.Add(this.textBox52);
            this.groupBox10.Controls.Add(this.label52);
            this.groupBox10.Location = new System.Drawing.Point(357, 348);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(128, 180);
            this.groupBox10.TabIndex = 41;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Random Settings";
            // 
            // textBox55
            // 
            this.textBox55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox55.Location = new System.Drawing.Point(69, 98);
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(53, 20);
            this.textBox55.TabIndex = 50;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(13, 126);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(32, 13);
            this.label56.TabIndex = 45;
            this.label56.Text = "Set4:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(13, 100);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(32, 13);
            this.label55.TabIndex = 51;
            this.label55.Text = "Set3:";
            // 
            // textBox54
            // 
            this.textBox54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox54.Location = new System.Drawing.Point(69, 72);
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(53, 20);
            this.textBox54.TabIndex = 48;
            // 
            // textBox56
            // 
            this.textBox56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox56.Location = new System.Drawing.Point(69, 124);
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(53, 20);
            this.textBox56.TabIndex = 44;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(13, 74);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(32, 13);
            this.label54.TabIndex = 49;
            this.label54.Text = "Set2:";
            // 
            // textBox53
            // 
            this.textBox53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox53.Location = new System.Drawing.Point(69, 46);
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(53, 20);
            this.textBox53.TabIndex = 46;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(13, 48);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(32, 13);
            this.label53.TabIndex = 47;
            this.label53.Text = "Set1:";
            // 
            // textBox52
            // 
            this.textBox52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox52.Location = new System.Drawing.Point(69, 20);
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(53, 20);
            this.textBox52.TabIndex = 44;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(13, 22);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(32, 13);
            this.label52.TabIndex = 45;
            this.label52.Text = "Set0:";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.linkLabel1);
            this.groupBox9.Controls.Add(this.pictureBox1);
            this.groupBox9.Controls.Add(this.textBox50);
            this.groupBox9.Controls.Add(this.label50);
            this.groupBox9.Controls.Add(this.textBox48);
            this.groupBox9.Controls.Add(this.label48);
            this.groupBox9.Controls.Add(this.label49);
            this.groupBox9.Controls.Add(this.textBox49);
            this.groupBox9.Location = new System.Drawing.Point(6, 241);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(200, 100);
            this.groupBox9.TabIndex = 40;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Icon";
            this.groupBox9.Enter += new System.EventHandler(this.groupBox9_Enter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel1.Location = new System.Drawing.Point(132, 54);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 13);
            this.linkLabel1.TabIndex = 96;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Icon Picker";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(144, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // textBox50
            // 
            this.textBox50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox50.Location = new System.Drawing.Point(59, 74);
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(37, 20);
            this.textBox50.TabIndex = 38;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(11, 76);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(25, 13);
            this.label50.TabIndex = 39;
            this.label50.Text = "Col:";
            // 
            // textBox48
            // 
            this.textBox48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox48.Location = new System.Drawing.Point(59, 20);
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(37, 20);
            this.textBox48.TabIndex = 34;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(9, 22);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(37, 13);
            this.label48.TabIndex = 35;
            this.label48.Text = "FileID:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(11, 48);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(32, 13);
            this.label49.TabIndex = 37;
            this.label49.Text = "Row:";
            // 
            // textBox49
            // 
            this.textBox49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox49.Location = new System.Drawing.Point(59, 46);
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(37, 20);
            this.textBox49.TabIndex = 36;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox21);
            this.groupBox6.Controls.Add(this.textBox19);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.textBox16);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.textBox17);
            this.groupBox6.Controls.Add(this.textBox18);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Location = new System.Drawing.Point(6, 348);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(215, 108);
            this.groupBox6.TabIndex = 33;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Stats";
            // 
            // textBox21
            // 
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox21.Location = new System.Drawing.Point(169, 52);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(37, 20);
            this.textBox21.TabIndex = 34;
            // 
            // textBox19
            // 
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox19.Location = new System.Drawing.Point(60, 78);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(146, 20);
            this.textBox19.TabIndex = 31;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(109, 54);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 13);
            this.label21.TabIndex = 35;
            this.label21.Text = "Dropprob:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 80);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "Price:";
            // 
            // textBox16
            // 
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox16.Location = new System.Drawing.Point(60, 23);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(37, 20);
            this.textBox16.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Level:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 54);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "Weight:";
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox17.Location = new System.Drawing.Point(169, 23);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(37, 20);
            this.textBox17.TabIndex = 27;
            // 
            // textBox18
            // 
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox18.Location = new System.Drawing.Point(60, 52);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(37, 20);
            this.textBox18.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(109, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Level2:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox15);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.textBox10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.textBox11);
            this.groupBox4.Controls.Add(this.textBox14);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.textBox13);
            this.groupBox4.Location = new System.Drawing.Point(223, 348);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(128, 180);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Options";
            // 
            // textBox15
            // 
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox15.Location = new System.Drawing.Point(65, 124);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(53, 20);
            this.textBox15.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Num4:";
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Location = new System.Drawing.Point(65, 20);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(53, 20);
            this.textBox10.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Num0:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Num3:";
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox11.Location = new System.Drawing.Point(65, 46);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(53, 20);
            this.textBox11.TabIndex = 16;
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox14.Location = new System.Drawing.Point(65, 98);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(53, 20);
            this.textBox14.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Num1:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Num2:";
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.Location = new System.Drawing.Point(65, 72);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(53, 20);
            this.textBox13.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox18);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox20);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(338, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 229);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Catagorize";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.checkedListBox1);
            this.groupBox18.Location = new System.Drawing.Point(6, 100);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox18.Size = new System.Drawing.Size(331, 88);
            this.groupBox18.TabIndex = 40;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "JobFlag";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ColumnWidth = 105;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.IntegralHeight = false;
            this.checkedListBox1.Location = new System.Drawing.Point(6, 19);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(319, 63);
            this.checkedListBox1.TabIndex = 39;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(72, 73);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(233, 21);
            this.comboBox4.TabIndex = 38;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(72, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(233, 21);
            this.comboBox2.TabIndex = 36;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(72, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 21);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(178, 196);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 34;
            this.label20.Text = "MaxUse:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Flag:";
            // 
            // textBox20
            // 
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox20.Location = new System.Drawing.Point(233, 194);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(100, 20);
            this.textBox20.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Wearing:";
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Location = new System.Drawing.Point(72, 194);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(311, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(26, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Location = new System.Drawing.Point(311, 74);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(26, 20);
            this.textBox9.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "SubType:";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(311, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(26, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Type:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label47);
            this.groupBox1.Controls.Add(this.textBox46);
            this.groupBox1.Controls.Add(this.textBox47);
            this.groupBox1.Controls.Add(this.label46);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(144, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.Text = "Enable";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(11, 196);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(33, 13);
            this.label47.TabIndex = 35;
            this.label47.Text = "SMC:";
            // 
            // textBox46
            // 
            this.textBox46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox46.Location = new System.Drawing.Point(269, 19);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(51, 20);
            this.textBox46.TabIndex = 34;
            // 
            // textBox47
            // 
            this.textBox47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox47.Location = new System.Drawing.Point(67, 194);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(253, 20);
            this.textBox47.TabIndex = 34;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(213, 21);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(55, 13);
            this.label46.TabIndex = 35;
            this.label46.Text = "ZoneFlag:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Desc:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(67, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Index:";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(67, 45);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(253, 20);
            this.textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(67, 71);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(253, 117);
            this.textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Location = new System.Drawing.Point(9, 134);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(50, 20);
            this.textBox7.TabIndex = 12;
            this.textBox7.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(947, 610);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crafting";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBox45);
            this.groupBox8.Controls.Add(this.label45);
            this.groupBox8.Controls.Add(this.textBox44);
            this.groupBox8.Controls.Add(this.label44);
            this.groupBox8.Controls.Add(this.textBox43);
            this.groupBox8.Controls.Add(this.label43);
            this.groupBox8.Controls.Add(this.textBox42);
            this.groupBox8.Controls.Add(this.label42);
            this.groupBox8.Location = new System.Drawing.Point(6, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(232, 78);
            this.groupBox8.TabIndex = 39;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Crafting Skill Requirement";
            // 
            // textBox45
            // 
            this.textBox45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox45.Location = new System.Drawing.Point(178, 50);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(40, 20);
            this.textBox45.TabIndex = 84;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(114, 52);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(58, 13);
            this.label45.TabIndex = 85;
            this.label45.Text = "Skill Level:";
            this.label45.Click += new System.EventHandler(this.label45_Click);
            // 
            // textBox44
            // 
            this.textBox44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox44.Location = new System.Drawing.Point(52, 50);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(40, 20);
            this.textBox44.TabIndex = 82;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(6, 52);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(40, 13);
            this.label44.TabIndex = 83;
            this.label44.Text = "SkillID:";
            // 
            // textBox43
            // 
            this.textBox43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox43.Location = new System.Drawing.Point(178, 24);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(40, 20);
            this.textBox43.TabIndex = 80;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(114, 26);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(58, 13);
            this.label43.TabIndex = 81;
            this.label43.Text = "Skill Level:";
            // 
            // textBox42
            // 
            this.textBox42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox42.Location = new System.Drawing.Point(52, 24);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(40, 20);
            this.textBox42.TabIndex = 78;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(6, 26);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(40, 13);
            this.label42.TabIndex = 79;
            this.label42.Text = "SkillID:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox41);
            this.groupBox7.Controls.Add(this.label41);
            this.groupBox7.Controls.Add(this.textBox40);
            this.groupBox7.Controls.Add(this.label40);
            this.groupBox7.Controls.Add(this.textBox39);
            this.groupBox7.Controls.Add(this.label39);
            this.groupBox7.Controls.Add(this.textBox38);
            this.groupBox7.Controls.Add(this.label38);
            this.groupBox7.Controls.Add(this.textBox37);
            this.groupBox7.Controls.Add(this.label37);
            this.groupBox7.Controls.Add(this.textBox36);
            this.groupBox7.Controls.Add(this.label36);
            this.groupBox7.Controls.Add(this.textBox35);
            this.groupBox7.Controls.Add(this.label35);
            this.groupBox7.Controls.Add(this.textBox34);
            this.groupBox7.Controls.Add(this.label34);
            this.groupBox7.Controls.Add(this.textBox33);
            this.groupBox7.Controls.Add(this.label33);
            this.groupBox7.Controls.Add(this.textBox32);
            this.groupBox7.Controls.Add(this.label32);
            this.groupBox7.Controls.Add(this.textBox31);
            this.groupBox7.Controls.Add(this.label31);
            this.groupBox7.Controls.Add(this.textBox30);
            this.groupBox7.Controls.Add(this.label30);
            this.groupBox7.Controls.Add(this.textBox29);
            this.groupBox7.Controls.Add(this.label29);
            this.groupBox7.Controls.Add(this.textBox28);
            this.groupBox7.Controls.Add(this.label28);
            this.groupBox7.Controls.Add(this.textBox27);
            this.groupBox7.Controls.Add(this.label27);
            this.groupBox7.Controls.Add(this.textBox26);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.textBox25);
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.textBox24);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.textBox23);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.textBox22);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Location = new System.Drawing.Point(6, 90);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(593, 152);
            this.groupBox7.TabIndex = 38;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Crafting Need";
            // 
            // textBox41
            // 
            this.textBox41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox41.Location = new System.Drawing.Point(543, 123);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(40, 20);
            this.textBox41.TabIndex = 76;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(475, 125);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(46, 13);
            this.label41.TabIndex = 77;
            this.label41.Text = "Amount:";
            // 
            // textBox40
            // 
            this.textBox40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox40.Location = new System.Drawing.Point(543, 97);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(40, 20);
            this.textBox40.TabIndex = 74;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(475, 99);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(46, 13);
            this.label40.TabIndex = 75;
            this.label40.Text = "Amount:";
            // 
            // textBox39
            // 
            this.textBox39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox39.Location = new System.Drawing.Point(543, 71);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(40, 20);
            this.textBox39.TabIndex = 72;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(475, 73);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(46, 13);
            this.label39.TabIndex = 73;
            this.label39.Text = "Amount:";
            // 
            // textBox38
            // 
            this.textBox38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox38.Location = new System.Drawing.Point(543, 45);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(40, 20);
            this.textBox38.TabIndex = 70;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(475, 47);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(46, 13);
            this.label38.TabIndex = 71;
            this.label38.Text = "Amount:";
            // 
            // textBox37
            // 
            this.textBox37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox37.Location = new System.Drawing.Point(543, 19);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(40, 20);
            this.textBox37.TabIndex = 68;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(475, 21);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(46, 13);
            this.label37.TabIndex = 69;
            this.label37.Text = "Amount:";
            // 
            // textBox36
            // 
            this.textBox36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox36.Location = new System.Drawing.Point(243, 123);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(40, 20);
            this.textBox36.TabIndex = 66;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(175, 125);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(46, 13);
            this.label36.TabIndex = 67;
            this.label36.Text = "Amount:";
            // 
            // textBox35
            // 
            this.textBox35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox35.Location = new System.Drawing.Point(243, 97);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(40, 20);
            this.textBox35.TabIndex = 64;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(175, 99);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(46, 13);
            this.label35.TabIndex = 65;
            this.label35.Text = "Amount:";
            // 
            // textBox34
            // 
            this.textBox34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox34.Location = new System.Drawing.Point(243, 71);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(40, 20);
            this.textBox34.TabIndex = 62;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(175, 73);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(46, 13);
            this.label34.TabIndex = 63;
            this.label34.Text = "Amount:";
            // 
            // textBox33
            // 
            this.textBox33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox33.Location = new System.Drawing.Point(243, 45);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(40, 20);
            this.textBox33.TabIndex = 60;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(175, 47);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(46, 13);
            this.label33.TabIndex = 61;
            this.label33.Text = "Amount:";
            // 
            // textBox32
            // 
            this.textBox32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox32.Location = new System.Drawing.Point(243, 19);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(40, 20);
            this.textBox32.TabIndex = 58;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(175, 21);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(46, 13);
            this.label32.TabIndex = 59;
            this.label32.Text = "Amount:";
            // 
            // textBox31
            // 
            this.textBox31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox31.Location = new System.Drawing.Point(373, 123);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(61, 20);
            this.textBox31.TabIndex = 56;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(305, 125);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(62, 13);
            this.label31.TabIndex = 57;
            this.label31.Text = "NeedItem9:";
            // 
            // textBox30
            // 
            this.textBox30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox30.Location = new System.Drawing.Point(373, 97);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(61, 20);
            this.textBox30.TabIndex = 54;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(305, 99);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(62, 13);
            this.label30.TabIndex = 55;
            this.label30.Text = "NeedItem8:";
            // 
            // textBox29
            // 
            this.textBox29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox29.Location = new System.Drawing.Point(373, 71);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(61, 20);
            this.textBox29.TabIndex = 52;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(305, 73);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(62, 13);
            this.label29.TabIndex = 53;
            this.label29.Text = "NeedItem7:";
            // 
            // textBox28
            // 
            this.textBox28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox28.Location = new System.Drawing.Point(373, 45);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(61, 20);
            this.textBox28.TabIndex = 50;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(305, 47);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(62, 13);
            this.label28.TabIndex = 51;
            this.label28.Text = "NeedItem6:";
            // 
            // textBox27
            // 
            this.textBox27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox27.Location = new System.Drawing.Point(373, 19);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(61, 20);
            this.textBox27.TabIndex = 48;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(305, 21);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(62, 13);
            this.label27.TabIndex = 49;
            this.label27.Text = "NeedItem5:";
            // 
            // textBox26
            // 
            this.textBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox26.Location = new System.Drawing.Point(73, 123);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(61, 20);
            this.textBox26.TabIndex = 46;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(5, 125);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(62, 13);
            this.label26.TabIndex = 47;
            this.label26.Text = "NeedItem4:";
            // 
            // textBox25
            // 
            this.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox25.Location = new System.Drawing.Point(73, 97);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(61, 20);
            this.textBox25.TabIndex = 44;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 99);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(62, 13);
            this.label25.TabIndex = 45;
            this.label25.Text = "NeedItem3:";
            // 
            // textBox24
            // 
            this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox24.Location = new System.Drawing.Point(73, 71);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(61, 20);
            this.textBox24.TabIndex = 42;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(5, 73);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(62, 13);
            this.label24.TabIndex = 43;
            this.label24.Text = "NeedItem2:";
            // 
            // textBox23
            // 
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox23.Location = new System.Drawing.Point(73, 45);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(61, 20);
            this.textBox23.TabIndex = 40;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(5, 47);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(62, 13);
            this.label23.TabIndex = 41;
            this.label23.Text = "NeedItem1:";
            // 
            // textBox22
            // 
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox22.Location = new System.Drawing.Point(73, 19);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(61, 20);
            this.textBox22.TabIndex = 38;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(5, 21);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(62, 13);
            this.label22.TabIndex = 39;
            this.label22.Text = "NeedItem0:";
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.comboBox24);
            this.tabPage3.Controls.Add(this.comboBox23);
            this.tabPage3.Controls.Add(this.comboBox22);
            this.tabPage3.Controls.Add(this.comboBox21);
            this.tabPage3.Controls.Add(this.comboBox20);
            this.tabPage3.Controls.Add(this.comboBox19);
            this.tabPage3.Controls.Add(this.comboBox18);
            this.tabPage3.Controls.Add(this.comboBox17);
            this.tabPage3.Controls.Add(this.comboBox16);
            this.tabPage3.Controls.Add(this.comboBox15);
            this.tabPage3.Controls.Add(this.comboBox14);
            this.tabPage3.Controls.Add(this.comboBox13);
            this.tabPage3.Controls.Add(this.comboBox12);
            this.tabPage3.Controls.Add(this.comboBox11);
            this.tabPage3.Controls.Add(this.comboBox10);
            this.tabPage3.Controls.Add(this.comboBox9);
            this.tabPage3.Controls.Add(this.comboBox8);
            this.tabPage3.Controls.Add(this.comboBox7);
            this.tabPage3.Controls.Add(this.comboBox6);
            this.tabPage3.Controls.Add(this.comboBox5);
            this.tabPage3.Controls.Add(this.comboBox3);
            this.tabPage3.Controls.Add(this.groupBox13);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(947, 610);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rare";
            // 
            // comboBox24
            // 
            this.comboBox24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox24.FormattingEnabled = true;
            this.comboBox24.Location = new System.Drawing.Point(587, 401);
            this.comboBox24.Name = "comboBox24";
            this.comboBox24.Size = new System.Drawing.Size(58, 21);
            this.comboBox24.TabIndex = 22;
            // 
            // comboBox23
            // 
            this.comboBox23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox23.FormattingEnabled = true;
            this.comboBox23.Location = new System.Drawing.Point(587, 374);
            this.comboBox23.Name = "comboBox23";
            this.comboBox23.Size = new System.Drawing.Size(58, 21);
            this.comboBox23.TabIndex = 21;
            // 
            // comboBox22
            // 
            this.comboBox22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox22.FormattingEnabled = true;
            this.comboBox22.Location = new System.Drawing.Point(587, 347);
            this.comboBox22.Name = "comboBox22";
            this.comboBox22.Size = new System.Drawing.Size(58, 21);
            this.comboBox22.TabIndex = 20;
            // 
            // comboBox21
            // 
            this.comboBox21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox21.FormattingEnabled = true;
            this.comboBox21.Location = new System.Drawing.Point(587, 207);
            this.comboBox21.Name = "comboBox21";
            this.comboBox21.Size = new System.Drawing.Size(58, 21);
            this.comboBox21.TabIndex = 19;
            // 
            // comboBox20
            // 
            this.comboBox20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox20.FormattingEnabled = true;
            this.comboBox20.Location = new System.Drawing.Point(587, 180);
            this.comboBox20.Name = "comboBox20";
            this.comboBox20.Size = new System.Drawing.Size(58, 21);
            this.comboBox20.TabIndex = 18;
            // 
            // comboBox19
            // 
            this.comboBox19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox19.FormattingEnabled = true;
            this.comboBox19.Location = new System.Drawing.Point(365, 401);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Size = new System.Drawing.Size(216, 21);
            this.comboBox19.TabIndex = 17;
            this.comboBox19.SelectedIndexChanged += new System.EventHandler(this.comboBox19_SelectedIndexChanged);
            // 
            // comboBox18
            // 
            this.comboBox18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox18.FormattingEnabled = true;
            this.comboBox18.Location = new System.Drawing.Point(365, 374);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(216, 21);
            this.comboBox18.TabIndex = 16;
            this.comboBox18.SelectedIndexChanged += new System.EventHandler(this.comboBox18_SelectedIndexChanged);
            // 
            // comboBox17
            // 
            this.comboBox17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox17.FormattingEnabled = true;
            this.comboBox17.Location = new System.Drawing.Point(365, 347);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Size = new System.Drawing.Size(216, 21);
            this.comboBox17.TabIndex = 15;
            this.comboBox17.SelectedIndexChanged += new System.EventHandler(this.comboBox17_SelectedIndexChanged);
            // 
            // comboBox16
            // 
            this.comboBox16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox16.FormattingEnabled = true;
            this.comboBox16.Location = new System.Drawing.Point(365, 207);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(216, 21);
            this.comboBox16.TabIndex = 14;
            this.comboBox16.SelectedIndexChanged += new System.EventHandler(this.comboBox16_SelectedIndexChanged);
            // 
            // comboBox15
            // 
            this.comboBox15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Location = new System.Drawing.Point(365, 180);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(216, 21);
            this.comboBox15.TabIndex = 13;
            this.comboBox15.SelectedIndexChanged += new System.EventHandler(this.comboBox15_SelectedIndexChanged);
            // 
            // comboBox14
            // 
            this.comboBox14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Location = new System.Drawing.Point(236, 288);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(58, 21);
            this.comboBox14.TabIndex = 12;
            // 
            // comboBox13
            // 
            this.comboBox13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Location = new System.Drawing.Point(236, 261);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(58, 21);
            this.comboBox13.TabIndex = 11;
            // 
            // comboBox12
            // 
            this.comboBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Location = new System.Drawing.Point(236, 234);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(58, 21);
            this.comboBox12.TabIndex = 10;
            // 
            // comboBox11
            // 
            this.comboBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(236, 207);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(58, 21);
            this.comboBox11.TabIndex = 9;
            // 
            // comboBox10
            // 
            this.comboBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(236, 180);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(58, 21);
            this.comboBox10.TabIndex = 8;
            this.comboBox10.SelectedIndexChanged += new System.EventHandler(this.comboBox10_SelectedIndexChanged);
            // 
            // comboBox9
            // 
            this.comboBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(14, 288);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(216, 21);
            this.comboBox9.TabIndex = 7;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // comboBox8
            // 
            this.comboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(14, 261);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(216, 21);
            this.comboBox8.TabIndex = 6;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // comboBox7
            // 
            this.comboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(14, 234);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(216, 21);
            this.comboBox7.TabIndex = 5;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(14, 207);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(216, 21);
            this.comboBox6.TabIndex = 4;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(14, 180);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(216, 21);
            this.comboBox5.TabIndex = 3;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(26, 577);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(216, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.textBox79);
            this.groupBox13.Controls.Add(this.label79);
            this.groupBox13.Controls.Add(this.textBox78);
            this.groupBox13.Controls.Add(this.label78);
            this.groupBox13.Controls.Add(this.textBox77);
            this.groupBox13.Controls.Add(this.label77);
            this.groupBox13.Controls.Add(this.textBox76);
            this.groupBox13.Controls.Add(this.label76);
            this.groupBox13.Controls.Add(this.textBox75);
            this.groupBox13.Controls.Add(this.label75);
            this.groupBox13.Controls.Add(this.textBox74);
            this.groupBox13.Controls.Add(this.label74);
            this.groupBox13.Controls.Add(this.textBox73);
            this.groupBox13.Controls.Add(this.label73);
            this.groupBox13.Controls.Add(this.textBox72);
            this.groupBox13.Controls.Add(this.label72);
            this.groupBox13.Controls.Add(this.textBox71);
            this.groupBox13.Controls.Add(this.label71);
            this.groupBox13.Controls.Add(this.textBox70);
            this.groupBox13.Controls.Add(this.label70);
            this.groupBox13.Controls.Add(this.textBox69);
            this.groupBox13.Controls.Add(this.label69);
            this.groupBox13.Controls.Add(this.textBox68);
            this.groupBox13.Controls.Add(this.label68);
            this.groupBox13.Controls.Add(this.textBox67);
            this.groupBox13.Controls.Add(this.label67);
            this.groupBox13.Controls.Add(this.textBox66);
            this.groupBox13.Controls.Add(this.label66);
            this.groupBox13.Controls.Add(this.textBox65);
            this.groupBox13.Controls.Add(this.label65);
            this.groupBox13.Controls.Add(this.textBox64);
            this.groupBox13.Controls.Add(this.label64);
            this.groupBox13.Controls.Add(this.textBox63);
            this.groupBox13.Controls.Add(this.label63);
            this.groupBox13.Controls.Add(this.textBox62);
            this.groupBox13.Controls.Add(this.label62);
            this.groupBox13.Controls.Add(this.textBox61);
            this.groupBox13.Controls.Add(this.label61);
            this.groupBox13.Controls.Add(this.textBox60);
            this.groupBox13.Controls.Add(this.label60);
            this.groupBox13.Location = new System.Drawing.Point(3, 3);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(665, 155);
            this.groupBox13.TabIndex = 0;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Rare Options";
            // 
            // textBox79
            // 
            this.textBox79.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox79.Location = new System.Drawing.Point(581, 123);
            this.textBox79.Name = "textBox79";
            this.textBox79.Size = new System.Drawing.Size(61, 20);
            this.textBox79.TabIndex = 78;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(513, 125);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(47, 13);
            this.label79.TabIndex = 79;
            this.label79.Text = "Chance:";
            // 
            // textBox78
            // 
            this.textBox78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox78.Location = new System.Drawing.Point(581, 97);
            this.textBox78.Name = "textBox78";
            this.textBox78.Size = new System.Drawing.Size(61, 20);
            this.textBox78.TabIndex = 76;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(513, 99);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(47, 13);
            this.label78.TabIndex = 77;
            this.label78.Text = "Chance:";
            // 
            // textBox77
            // 
            this.textBox77.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox77.Location = new System.Drawing.Point(581, 71);
            this.textBox77.Name = "textBox77";
            this.textBox77.Size = new System.Drawing.Size(61, 20);
            this.textBox77.TabIndex = 74;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(513, 73);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(47, 13);
            this.label77.TabIndex = 75;
            this.label77.Text = "Chance:";
            // 
            // textBox76
            // 
            this.textBox76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox76.Location = new System.Drawing.Point(581, 45);
            this.textBox76.Name = "textBox76";
            this.textBox76.Size = new System.Drawing.Size(61, 20);
            this.textBox76.TabIndex = 72;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(513, 47);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(47, 13);
            this.label76.TabIndex = 73;
            this.label76.Text = "Chance:";
            // 
            // textBox75
            // 
            this.textBox75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox75.Location = new System.Drawing.Point(581, 19);
            this.textBox75.Name = "textBox75";
            this.textBox75.Size = new System.Drawing.Size(61, 20);
            this.textBox75.TabIndex = 70;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(513, 21);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(47, 13);
            this.label75.TabIndex = 71;
            this.label75.Text = "Chance:";
            // 
            // textBox74
            // 
            this.textBox74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox74.Location = new System.Drawing.Point(230, 125);
            this.textBox74.Name = "textBox74";
            this.textBox74.Size = new System.Drawing.Size(61, 20);
            this.textBox74.TabIndex = 68;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(162, 127);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(47, 13);
            this.label74.TabIndex = 69;
            this.label74.Text = "Chance:";
            // 
            // textBox73
            // 
            this.textBox73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox73.Location = new System.Drawing.Point(230, 97);
            this.textBox73.Name = "textBox73";
            this.textBox73.Size = new System.Drawing.Size(61, 20);
            this.textBox73.TabIndex = 66;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(162, 99);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(47, 13);
            this.label73.TabIndex = 67;
            this.label73.Text = "Chance:";
            // 
            // textBox72
            // 
            this.textBox72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox72.Location = new System.Drawing.Point(230, 71);
            this.textBox72.Name = "textBox72";
            this.textBox72.Size = new System.Drawing.Size(61, 20);
            this.textBox72.TabIndex = 64;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(162, 73);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(47, 13);
            this.label72.TabIndex = 65;
            this.label72.Text = "Chance:";
            // 
            // textBox71
            // 
            this.textBox71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox71.Location = new System.Drawing.Point(230, 45);
            this.textBox71.Name = "textBox71";
            this.textBox71.Size = new System.Drawing.Size(61, 20);
            this.textBox71.TabIndex = 62;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(162, 47);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(47, 13);
            this.label71.TabIndex = 63;
            this.label71.Text = "Chance:";
            // 
            // textBox70
            // 
            this.textBox70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox70.Location = new System.Drawing.Point(230, 19);
            this.textBox70.Name = "textBox70";
            this.textBox70.Size = new System.Drawing.Size(61, 20);
            this.textBox70.TabIndex = 60;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(162, 21);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(47, 13);
            this.label70.TabIndex = 61;
            this.label70.Text = "Chance:";
            // 
            // textBox69
            // 
            this.textBox69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox69.Location = new System.Drawing.Point(427, 123);
            this.textBox69.Name = "textBox69";
            this.textBox69.Size = new System.Drawing.Size(61, 20);
            this.textBox69.TabIndex = 58;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(359, 125);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(47, 13);
            this.label69.TabIndex = 59;
            this.label69.Text = "Option9:";
            // 
            // textBox68
            // 
            this.textBox68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox68.Location = new System.Drawing.Point(427, 97);
            this.textBox68.Name = "textBox68";
            this.textBox68.Size = new System.Drawing.Size(61, 20);
            this.textBox68.TabIndex = 56;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(359, 99);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(47, 13);
            this.label68.TabIndex = 57;
            this.label68.Text = "Option8:";
            // 
            // textBox67
            // 
            this.textBox67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox67.Location = new System.Drawing.Point(427, 71);
            this.textBox67.Name = "textBox67";
            this.textBox67.Size = new System.Drawing.Size(61, 20);
            this.textBox67.TabIndex = 54;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(359, 73);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(47, 13);
            this.label67.TabIndex = 55;
            this.label67.Text = "Option7:";
            // 
            // textBox66
            // 
            this.textBox66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox66.Location = new System.Drawing.Point(427, 45);
            this.textBox66.Name = "textBox66";
            this.textBox66.Size = new System.Drawing.Size(61, 20);
            this.textBox66.TabIndex = 52;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(359, 47);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(47, 13);
            this.label66.TabIndex = 53;
            this.label66.Text = "Option6:";
            // 
            // textBox65
            // 
            this.textBox65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox65.Location = new System.Drawing.Point(427, 19);
            this.textBox65.Name = "textBox65";
            this.textBox65.Size = new System.Drawing.Size(61, 20);
            this.textBox65.TabIndex = 50;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(359, 21);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(47, 13);
            this.label65.TabIndex = 51;
            this.label65.Text = "Option5:";
            // 
            // textBox64
            // 
            this.textBox64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox64.Location = new System.Drawing.Point(76, 123);
            this.textBox64.Name = "textBox64";
            this.textBox64.Size = new System.Drawing.Size(61, 20);
            this.textBox64.TabIndex = 48;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(8, 125);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(47, 13);
            this.label64.TabIndex = 49;
            this.label64.Text = "Option4:";
            // 
            // textBox63
            // 
            this.textBox63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox63.Location = new System.Drawing.Point(76, 97);
            this.textBox63.Name = "textBox63";
            this.textBox63.Size = new System.Drawing.Size(61, 20);
            this.textBox63.TabIndex = 46;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(8, 99);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(47, 13);
            this.label63.TabIndex = 47;
            this.label63.Text = "Option3:";
            // 
            // textBox62
            // 
            this.textBox62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox62.Location = new System.Drawing.Point(76, 71);
            this.textBox62.Name = "textBox62";
            this.textBox62.Size = new System.Drawing.Size(61, 20);
            this.textBox62.TabIndex = 44;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(8, 73);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(47, 13);
            this.label62.TabIndex = 45;
            this.label62.Text = "Option2:";
            // 
            // textBox61
            // 
            this.textBox61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox61.Location = new System.Drawing.Point(76, 45);
            this.textBox61.Name = "textBox61";
            this.textBox61.Size = new System.Drawing.Size(61, 20);
            this.textBox61.TabIndex = 42;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(8, 47);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(47, 13);
            this.label61.TabIndex = 43;
            this.label61.Text = "Option1:";
            // 
            // textBox60
            // 
            this.textBox60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox60.Location = new System.Drawing.Point(76, 19);
            this.textBox60.Name = "textBox60";
            this.textBox60.Size = new System.Drawing.Size(61, 20);
            this.textBox60.TabIndex = 40;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(8, 21);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(47, 13);
            this.label60.TabIndex = 41;
            this.label60.Text = "Option0:";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(947, 610);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Purple";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(947, 610);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Fortune";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(1038, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(31, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(989, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enable:";
            this.label4.Visible = false;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1139, 669);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ItemEditor
            // 
            this.ClientSize = new System.Drawing.Size(1251, 704);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemEditor";
            this.Text = "Item Editor";
            this.Load += new System.EventHandler(this.Exporter_Item_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
  }
}
