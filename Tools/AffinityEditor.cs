// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.Tools.AffinityEditor
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using LcDevPack_TeamDamonA;
using LcDevPack_TeamDamonA.Properties;
using MySql.Data.MySqlClient;
using StringExporter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools
{
  //test comment
  public class AffinityEditor : Form
  {
    public static Connection connection = new Connection();
    private string Host = AffinityEditor.connection.ReadSettings("Host");
    private string User = AffinityEditor.connection.ReadSettings("User");
    private string Password = AffinityEditor.connection.ReadSettings("Password");
    private string Database = AffinityEditor.connection.ReadSettings("Database");
    private DatabaseHandle databaseHandle = new DatabaseHandle();
        private ExportLodHandle exportLodHandle = new ExportLodHandle();
        public string rowName = "a_index";
    public string[] menuArray = new string[2]
    {
      "a_index",
      "a_name"
    };
    public int test = 0;
    private string Episode = AffinityEditor.connection.ReadSettings("Episode");
    public List<string> MenuList = new List<string>();
    public List<string> MenuListSearch = new List<string>();
    private IContainer components = (IContainer) null;
    public string name;
    public int index;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem gToolStripMenuItem;
    private ToolStripMenuItem exportAffinitylodToolStripMenuItem;
    private ToolStripMenuItem exportStrAffinityusalodToolStripMenuItem;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private ListBox listBox1;
    private TextBox textBox1;
    private GroupBox groupBox3;
    private Label label1;
    private TextBox textBox2;
    private CheckBox checkBox1;
    private Label label2;
    private GroupBox groupBox4;
    private Label label3;
    private TextBox textBox4;
    private PictureBox pictureBox1;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label9;
    private Label label10;
    private PictureBox pictureBox2;
    private Label label11;
    private PictureBox pictureBox3;
    private TextBox textBox3;
    private TextBox textBox7;
    private TextBox textBox6;
    private TextBox textBox5;
    private TextBox textBox8;
    private TextBox textBox9;
    private TextBox textBox10;
    private TextBox textBox11;
    private TextBox textBox13;
    private TextBox textBox12;
    private TextBox textBox17;
    private TextBox textBox16;
    private TextBox textBox15;
    private TextBox textBox14;
    private TextBox textBox21;
    private TextBox textBox20;
    private TextBox textBox19;
    private TextBox textBox18;
    private Label label12;
    private PictureBox pictureBox4;
    private PictureBox pictureBox5;
    private PictureBox pictureBox6;
    private GroupBox groupBox5;
    private DataGridView dataGridView1;
    private GroupBox groupBox6;
    private DataGridView dataGridView2;
    private GroupBox groupBox7;
    private DataGridView dataGridView3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    private GroupBox groupBox8;
    private DataGridView dataGridView4;
    private DataGridViewTextBoxColumn Column7;
    private DataGridViewTextBoxColumn Column8;
    private DataGridViewTextBoxColumn Column13;
    private DataGridViewTextBoxColumn Column9;
    private DataGridViewTextBoxColumn Column10;
    private DataGridViewTextBoxColumn Column11;
    private DataGridViewTextBoxColumn Column12;
    private Button button2;
    private Button button1;
    private GroupBox groupBox9;
    private TextBox textBox22;
    private Label label13;
    private Button button3;
    private DataGridView dataGridView5;
    private DataGridViewTextBoxColumn Column14;
    private DataGridViewTextBoxColumn Column15;
    private DataGridViewTextBoxColumn Column16;
    private DataGridViewTextBoxColumn Column17;
    private DataGridViewTextBoxColumn Column18;
    private DataGridViewTextBoxColumn Column19;
    private DataGridViewTextBoxColumn Column20;
    private DataGridViewTextBoxColumn Column21;
    private DataGridViewTextBoxColumn Column22;
    private DataGridViewTextBoxColumn Column23;
    private ToolStrip toolStrip1;
    private ToolStripButton toolStripButton1;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripButton toolStripButton2;
    private ToolStrip toolStrip2;
    private ToolStripButton toolStripButton3;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripButton toolStripButton4;
    private ToolStrip toolStrip3;
    private ToolStripButton toolStripButton5;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripButton toolStripButton6;
    private ToolStrip toolStrip4;
    private ToolStripButton toolStripButton7;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripButton toolStripButton8;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column4;
    private DataGridViewTextBoxColumn Column5;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewTextBoxColumn Work_Type;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn AffinityIdx;
        private DataGridViewTextBoxColumn AffinityPoints;
        private DataGridViewTextBoxColumn Enable;
        private ToolStripMenuItem usaToolStripMenuItem;
        private ToolStripMenuItem thaiToolStripMenuItem;
        private ToolStripMenuItem frenchToolStripMenuItem;
        private ToolStripMenuItem germanToolStripMenuItem;
        private ToolStripMenuItem spanishToolStripMenuItem;
        private ToolStripMenuItem mexicanToolStripMenuItem;
        private ToolStripMenuItem brazilToolStripMenuItem;
        private ToolStripMenuItem italianToolStripMenuItem;
        private ToolStripMenuItem polandToolStripMenuItem;
        private DataGridViewTextBoxColumn Column6;

    public AffinityEditor()
    {
            InitializeComponent();
    }

    public void LoadMisc()
    {
      if (textBox4.Text == "1")
      {
                checkBox1.Checked = true;
                checkBox1.BackColor = Color.Lime;
      }
      else
      {
                checkBox1.Checked = false;
                checkBox1.BackColor = Color.Red;
      }
    }

    private void LoadListBox()
    {
            MenuList.Clear();
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_index, a_name from t_affinity ORDER BY a_index;");
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
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_index, a_name from t_affinity WHERE a_name LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");
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

    private void AffinityEditor_Load(object sender, EventArgs e)
    {
            LoadDG();
            LoadDG2();
            LoadDG3();
            LoadDG4();
            LoadDG5(textBox1.Text);
            LoadListBox();
            LoadMisc();
    }

    private void AffinityIcon()
    {
      string Query = "select a_index, a_name_usa, a_texture_id, a_texture_row, a_texture_col from t_affinity WHERE a_index ='" + textBox12.Text + "';";
      string[] rows = new string[5]
      {
        "a_index",
        "a_name_usa",
        "a_texture_id",
        "a_texture_row",
        "a_texture_col"
      };
      Query.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'");
      string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query, rows);
            textBox14.Text = strArray[0];
            label11.Text = strArray[1];
            textBox15.Text = strArray[2];
            textBox16.Text = strArray[3];
            textBox17.Text = strArray[4];
      if (!(textBox14.Text == ""))
        return;
            pictureBox2.Image = (Image) null;
            label11.Visible = true;
    }

    private void ItemIcon()
    {
      string Query = "select a_index, a_name_usa, a_texture_id, a_texture_row, a_texture_col from t_item WHERE a_index = '" + textBox10.Text + "';";
      string[] rows = new string[5]
      {
        "a_index",
        "a_name_usa",
        "a_texture_id",
        "a_texture_row",
        "a_texture_col"
      };
      Query.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'");
      string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query, rows);
            textBox18.Text = strArray[0];
            label12.Text = strArray[1];
            textBox19.Text = strArray[2];
            textBox20.Text = strArray[3];
            textBox21.Text = strArray[4];
      if (!(textBox18.Text == ""))
        return;
            pictureBox4.Image = (Image) null;
            label12.Visible = true;
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listBox1.SelectedIndex != -1)
                textBox1.Text = GetIndex().ToString();
      string Query = "select a_index, a_name, a_maxvalue, a_enable, a_texture_id, a_texture_row, a_texture_col, a_nas, a_needlevel, a_needitemidx, a_needitemcount, a_affinity_idx, a_affinity_value from t_affinity WHERE a_index ='" + textBox1.Text + "';";
      string[] rows = new string[13]
      {
        "a_index",
        "a_name",
        "a_maxvalue",
        "a_enable",
        "a_texture_id",
        "a_texture_row",
        "a_texture_col",
        "a_nas",
        "a_needlevel",
        "a_needitemidx",
        "a_needitemcount",
        "a_affinity_idx",
        "a_affinity_value"
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
            textBox12.Text = strArray[11];
            textBox13.Text = strArray[12];
            AffinityIcon();
            LoadDG5(textBox1.Text);
            LoadDG4();
            LoadDG3();
            LoadDG2();
            LoadDG();
            ItemIcon();
            LoadMisc();
      try
      {
                pictureBox1.Image = (Image)databaseHandle.IconSkill1(int.Parse(textBox5.Text), int.Parse(textBox6.Text), int.Parse(textBox7.Text));
                pictureBox2.Image = (Image)databaseHandle.IconSkill1(int.Parse(textBox15.Text), int.Parse(textBox16.Text), int.Parse(textBox17.Text));
      }
      catch
      {
      }
      try
      {
                pictureBox4.Image = (Image)databaseHandle.IconItem(int.Parse(textBox19.Text), int.Parse(textBox20.Text), int.Parse(textBox21.Text));
      }
      catch
      {
      }
    }

    public void LoadDG()
    {
            dataGridView1.Rows.Clear();
      string str1 = "SELECT * FROM t_affinity_work WHERE a_work_type = 1 AND a_affinity_idx = '" + textBox1.Text + "'";
      string[] strArray = new string[8]
      {
        "a_work_type",
        "a_type_idx",
        "a_affinity_idx",
        "a_value",
        "a_enable",
        "a_id",
        "a_row",
        "a_col"
      };
      MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
      MySqlCommand command = mySqlConnection.CreateCommand();
      command.CommandText = str1;
      mySqlConnection.Open();
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (mySqlDataReader.Read())
      {
        int ordinal1 = mySqlDataReader.GetOrdinal("a_work_type");
        int ordinal2 = mySqlDataReader.GetOrdinal("a_enable");
        int ordinal3 = mySqlDataReader.GetOrdinal("a_affinity_idx");
        int ordinal4 = mySqlDataReader.GetOrdinal("a_type_idx");
        int ordinal5 = mySqlDataReader.GetOrdinal("a_value");
        string str2 = mySqlDataReader.GetString(ordinal4);
        string str3 = mySqlDataReader.GetString(ordinal5);
        string str4 = mySqlDataReader.GetString(ordinal1);
        string str5 = mySqlDataReader.GetString(ordinal2);
        string str6 = mySqlDataReader.GetString(ordinal3);
        string str7 = databaseHandle.FunctionMonsterName(Convert.ToInt32(str2));
                dataGridView1.Rows.Add( str4,  str2,  str7,  str6,  str3,  str5);
      }
      mySqlConnection.Close();
    }

    public void LoadDG2()
    {
            dataGridView2.Rows.Clear();
      string str1 = "SELECT * FROM t_affinity_work WHERE a_work_type = 0 AND a_affinity_idx = '" + textBox1.Text + "'";
      string[] strArray = new string[8]
      {
        "a_work_type",
        "a_type_idx",
        "a_affinity_idx",
        "a_value",
        "a_enable",
        "a_id",
        "a_row",
        "a_col"
      };
      MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
      MySqlCommand command = mySqlConnection.CreateCommand();
      command.CommandText = str1;
      mySqlConnection.Open();
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (mySqlDataReader.Read())
      {
        int ordinal1 = mySqlDataReader.GetOrdinal("a_work_type");
        int ordinal2 = mySqlDataReader.GetOrdinal("a_enable");
        int ordinal3 = mySqlDataReader.GetOrdinal("a_affinity_idx");
        int ordinal4 = mySqlDataReader.GetOrdinal("a_type_idx");
        int ordinal5 = mySqlDataReader.GetOrdinal("a_value");
        string str2 = mySqlDataReader.GetString(ordinal4);
        string str3 = mySqlDataReader.GetString(ordinal5);
        string str4 = mySqlDataReader.GetString(ordinal1);
        string str5 = mySqlDataReader.GetString(ordinal2);
        string str6 = mySqlDataReader.GetString(ordinal3);
        string str7 = databaseHandle.ItemNameFast(Convert.ToInt32(str2));
                dataGridView2.Rows.Add(databaseHandle.IconFast(Convert.ToInt32(str2)),  str4,  str2,  str7,  str6,  str3,  str5);
      }
      mySqlConnection.Close();
    }

    public void LoadDG3()
    {
            dataGridView3.Rows.Clear();
      string str1 = "SELECT * FROM t_affinity_work WHERE a_work_type = 2 AND a_affinity_idx = '" + textBox1.Text + "'";
      string[] strArray = new string[8]
      {
        "a_work_type",
        "a_type_idx",
        "a_affinity_idx",
        "a_value",
        "a_enable",
        "a_id",
        "a_row",
        "a_col"
      };
      MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
      MySqlCommand command = mySqlConnection.CreateCommand();
      command.CommandText = str1;
      mySqlConnection.Open();
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (mySqlDataReader.Read())
      {
        int ordinal1 = mySqlDataReader.GetOrdinal("a_work_type");
        int ordinal2 = mySqlDataReader.GetOrdinal("a_enable");
        int ordinal3 = mySqlDataReader.GetOrdinal("a_affinity_idx");
        int ordinal4 = mySqlDataReader.GetOrdinal("a_type_idx");
        int ordinal5 = mySqlDataReader.GetOrdinal("a_value");
        string str2 = mySqlDataReader.GetString(ordinal4);
        string str3 = mySqlDataReader.GetString(ordinal5);
        string str4 = mySqlDataReader.GetString(ordinal1);
        string str5 = mySqlDataReader.GetString(ordinal2);
        string str6 = mySqlDataReader.GetString(ordinal3);
        string str7 = databaseHandle.FunctionQuestName(Convert.ToInt32(str2));
                dataGridView3.Rows.Add( str4,  str2,  str7,  str6,  str3,  str5);
      }
      mySqlConnection.Close();
    }

    public void LoadDG4()
    {
            dataGridView4.Rows.Clear();
      string str1 = "SELECT * FROM t_affinity_npc WHERE a_affinity_idx = '" + textBox1.Text + "'";
      string[] strArray = new string[6]
      {
        "a_affinity_idx",
        "a_npcidx",
        "a_use_point",
        "a_enable",
        "a_flag",
        "a_string_idx"
      };
      MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
      MySqlCommand command = mySqlConnection.CreateCommand();
      command.CommandText = str1;
      mySqlConnection.Open();
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (mySqlDataReader.Read())
      {
        int ordinal1 = mySqlDataReader.GetOrdinal("a_affinity_idx");
        int ordinal2 = mySqlDataReader.GetOrdinal("a_npcidx");
        int ordinal3 = mySqlDataReader.GetOrdinal("a_use_point");
        int ordinal4 = mySqlDataReader.GetOrdinal("a_enable");
        int ordinal5 = mySqlDataReader.GetOrdinal("a_flag");
        int ordinal6 = mySqlDataReader.GetOrdinal("a_string_idx");
        string str2 = mySqlDataReader.GetString(ordinal1);
        string str3 = mySqlDataReader.GetString(ordinal2);
        string str4 = mySqlDataReader.GetString(ordinal3);
        string str5 = mySqlDataReader.GetString(ordinal5);
        string str6 = mySqlDataReader.GetString(ordinal6);
        string str7 = mySqlDataReader.GetString(ordinal4);
        string str8 = databaseHandle.FunctionMonsterName(Convert.ToInt32(str3));
                dataGridView4.Rows.Add( str2,  str3,  str8,  str4,  str7,  str5,  str6);
      }
      mySqlConnection.Close();
    }

    public void LoadDG5(string npcidx)
    {
            dataGridView5.Rows.Clear();
      string str1 = "SELECT * FROM t_affinity_reward_item WHERE  a_npcidx ='+" + npcidx + "' ORDER BY a_npcidx";
      string[] strArray = new string[10]
      {
        "a_npcidx",
        "a_allow_point",
        "a_itemidx",
        "a_flag",
        "a_count",
        "a_exp",
        "a_sp",
        "a_needpclevel",
        "a_needitemidx",
        "a_needitemcount"
      };
      MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
      MySqlCommand command = mySqlConnection.CreateCommand();
      command.CommandText = str1;
      mySqlConnection.Open();
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (mySqlDataReader.Read())
      {
        int ordinal1 = mySqlDataReader.GetOrdinal("a_npcidx");
        int ordinal2 = mySqlDataReader.GetOrdinal("a_allow_point");
        int ordinal3 = mySqlDataReader.GetOrdinal("a_itemidx");
        int ordinal4 = mySqlDataReader.GetOrdinal("a_flag");
        int ordinal5 = mySqlDataReader.GetOrdinal("a_count");
        int ordinal6 = mySqlDataReader.GetOrdinal("a_exp");
        int ordinal7 = mySqlDataReader.GetOrdinal("a_sp");
        int ordinal8 = mySqlDataReader.GetOrdinal("a_needpclevel");
        int ordinal9 = mySqlDataReader.GetOrdinal("a_needitemidx");
        int ordinal10 = mySqlDataReader.GetOrdinal("a_needitemcount");
        string str2 = mySqlDataReader.GetString(ordinal1);
        string str3 = mySqlDataReader.GetString(ordinal2);
        string str4 = mySqlDataReader.GetString(ordinal3);
        string str5 = mySqlDataReader.GetString(ordinal5);
        string str6 = mySqlDataReader.GetString(ordinal6);
        string str7 = mySqlDataReader.GetString(ordinal4);
        string str8 = mySqlDataReader.GetString(ordinal7);
        string str9 = mySqlDataReader.GetString(ordinal8);
        string str10 = mySqlDataReader.GetString(ordinal9);
        string str11 = mySqlDataReader.GetString(ordinal10);
                dataGridView5.Rows.Add( str2,  str3,  str4,  str7,  str5,  str6,  str8,  str9,  str10,  str11);
      }
      mySqlConnection.Close();
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
      IconPickerSkill iconPickerSkill = new IconPickerSkill();
      iconPickerSkill.OldItemBtnSelect = Convert.ToInt32(textBox5.Text);
      if (iconPickerSkill.ShowDialog() != DialogResult.OK)
        return;
            textBox5.Text = iconPickerSkill.TexID.ToString();
            textBox6.Text = iconPickerSkill.TexRow.ToString();
            textBox7.Text = iconPickerSkill.TexColumn.ToString();
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_affinity SET " + "a_texture_id = '" + textBox5.Text + "', " + "a_texture_row = '" + textBox6.Text + "', " + "a_texture_col = '" + textBox7.Text + "' " + "WHERE a_index = '" + textBox1.Text + "'");
      int selectedIndex = listBox1.SelectedIndex;
            LoadListBox();
            listBox1.SelectedIndex = selectedIndex;
    }

    private void pictureBox5_Click(object sender, EventArgs e)
    {
      ItemPicker itemPicker = new ItemPicker();
      if (itemPicker.ShowDialog() != DialogResult.OK)
        return;
            textBox10.Text = Convert.ToString(itemPicker.ItemIndex);
    }

    private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "INSERT INTO t_affinity DEFAULT VALUES");
            LoadListBox();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      int selectedIndex = listBox1.SelectedIndex;
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_affinity WHERE a_index = '" + textBox1.Text + "'");
            LoadListBox();
            listBox1.SelectedIndex = selectedIndex - 1;
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void toolStripButton1_Click(object sender, EventArgs e) // Add Monster dethuter12
    {
      try
      {
                databaseHandle.SendQueryMySql(Host, User, Password, Database, "INSERT INTO t_affinity_work (a_work_type, a_type_idx) VALUES (" + textBox1.Text + ")");
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message, "Error");
      }
            dataGridView1.Rows.Clear();
            LoadDG();
    }

    private void toolStripButton2_Click(object sender, EventArgs e) //Delete Monster dethunter12
    {
      DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentRow.Index];
      string str1 = Convert.ToString(row.Cells["Column1"].Value);
      string str2 = Convert.ToString(row.Cells["Column2"].Value);
      string str3 = Convert.ToString(row.Cells["Column4"].Value);
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_affinity_work WHERE a_work_type ='" + str1 + "' a_affinity_idx = '" + str3 + "AND a_type_idx = '" + str2 + "'");
            dataGridView1.Rows.Clear();
            LoadDG();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && components != null)
                components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffinityEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAffinitylodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mexicanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brazilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportStrAffinityusalodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Work_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AffinityIdx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AffinityPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1391, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAffinitylodToolStripMenuItem,
            this.exportStrAffinityusalodToolStripMenuItem});
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.gToolStripMenuItem.Text = "File Export";
            this.gToolStripMenuItem.Click += new System.EventHandler(this.gToolStripMenuItem_Click);
            // 
            // exportAffinitylodToolStripMenuItem
            // 
            this.exportAffinitylodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usaToolStripMenuItem,
            this.thaiToolStripMenuItem,
            this.frenchToolStripMenuItem,
            this.germanToolStripMenuItem,
            this.spanishToolStripMenuItem,
            this.mexicanToolStripMenuItem,
            this.brazilToolStripMenuItem,
            this.italianToolStripMenuItem,
            this.polandToolStripMenuItem});
            this.exportAffinitylodToolStripMenuItem.Name = "exportAffinitylodToolStripMenuItem";
            this.exportAffinitylodToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.exportAffinitylodToolStripMenuItem.Text = "Export affinity.lod";
            this.exportAffinitylodToolStripMenuItem.Click += new System.EventHandler(this.exportAffinitylodToolStripMenuItem_Click);
            // 
            // usaToolStripMenuItem
            // 
            this.usaToolStripMenuItem.Name = "usaToolStripMenuItem";
            this.usaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.usaToolStripMenuItem.Text = "usa";
            this.usaToolStripMenuItem.Click += new System.EventHandler(this.usaToolStripMenuItem_Click);
            // 
            // thaiToolStripMenuItem
            // 
            this.thaiToolStripMenuItem.Name = "thaiToolStripMenuItem";
            this.thaiToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.thaiToolStripMenuItem.Text = "thai";
            this.thaiToolStripMenuItem.Click += new System.EventHandler(this.thaiToolStripMenuItem_Click);
            // 
            // frenchToolStripMenuItem
            // 
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            this.frenchToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.frenchToolStripMenuItem.Text = "french";
            this.frenchToolStripMenuItem.Click += new System.EventHandler(this.frenchToolStripMenuItem_Click);
            // 
            // germanToolStripMenuItem
            // 
            this.germanToolStripMenuItem.Name = "germanToolStripMenuItem";
            this.germanToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.germanToolStripMenuItem.Text = "german";
            this.germanToolStripMenuItem.Click += new System.EventHandler(this.germanToolStripMenuItem_Click);
            // 
            // spanishToolStripMenuItem
            // 
            this.spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
            this.spanishToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.spanishToolStripMenuItem.Text = "Spanish";
            this.spanishToolStripMenuItem.Click += new System.EventHandler(this.spanishToolStripMenuItem_Click);
            // 
            // mexicanToolStripMenuItem
            // 
            this.mexicanToolStripMenuItem.Name = "mexicanToolStripMenuItem";
            this.mexicanToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mexicanToolStripMenuItem.Text = "Mexican";
            this.mexicanToolStripMenuItem.Click += new System.EventHandler(this.mexicanToolStripMenuItem_Click);
            // 
            // brazilToolStripMenuItem
            // 
            this.brazilToolStripMenuItem.Name = "brazilToolStripMenuItem";
            this.brazilToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.brazilToolStripMenuItem.Text = "Brazil";
            this.brazilToolStripMenuItem.Click += new System.EventHandler(this.brazilToolStripMenuItem_Click);
            // 
            // italianToolStripMenuItem
            // 
            this.italianToolStripMenuItem.Name = "italianToolStripMenuItem";
            this.italianToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.italianToolStripMenuItem.Text = "Italian";
            this.italianToolStripMenuItem.Click += new System.EventHandler(this.italianToolStripMenuItem_Click);
            // 
            // polandToolStripMenuItem
            // 
            this.polandToolStripMenuItem.Name = "polandToolStripMenuItem";
            this.polandToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.polandToolStripMenuItem.Text = "Poland";
            this.polandToolStripMenuItem.Click += new System.EventHandler(this.polandToolStripMenuItem_Click);
            // 
            // exportStrAffinityusalodToolStripMenuItem
            // 
            this.exportStrAffinityusalodToolStripMenuItem.Name = "exportStrAffinityusalodToolStripMenuItem";
            this.exportStrAffinityusalodToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.exportStrAffinityusalodToolStripMenuItem.Text = "Export strAffinity_usa.lod";
            this.exportStrAffinityusalodToolStripMenuItem.Click += new System.EventHandler(this.exportStrAffinityusalodToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox22);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // textBox22
            // 
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox22.Location = new System.Drawing.Point(43, 22);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(167, 20);
            this.textBox22.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Text:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 532);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Affinities";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(127, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(8, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add to New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 459);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(60, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(237, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 91);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Basic";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(399, 19);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(20, 20);
            this.textBox7.TabIndex = 11;
            this.textBox7.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(373, 19);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(20, 20);
            this.textBox6.TabIndex = 10;
            this.textBox6.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(347, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(20, 20);
            this.textBox5.TabIndex = 9;
            this.textBox5.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(396, 58);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(358, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Index:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(188, 24);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Enable";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(60, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(292, 20);
            this.textBox2.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox6);
            this.groupBox4.Controls.Add(this.pictureBox5);
            this.groupBox4.Controls.Add(this.textBox21);
            this.groupBox4.Controls.Add(this.textBox20);
            this.groupBox4.Controls.Add(this.textBox19);
            this.groupBox4.Controls.Add(this.textBox18);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.pictureBox4);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBox17);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBox16);
            this.groupBox4.Controls.Add(this.textBox15);
            this.groupBox4.Controls.Add(this.textBox14);
            this.groupBox4.Controls.Add(this.textBox13);
            this.groupBox4.Controls.Add(this.textBox12);
            this.groupBox4.Controls.Add(this.textBox11);
            this.groupBox4.Controls.Add(this.textBox10);
            this.groupBox4.Controls.Add(this.textBox9);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(237, 124);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(430, 257);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Need for Affinity";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(232, 134);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 20);
            this.pictureBox6.TabIndex = 30;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(188, 29);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(23, 20);
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(323, 11);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(20, 20);
            this.textBox21.TabIndex = 28;
            this.textBox21.Visible = false;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(301, 11);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(20, 20);
            this.textBox20.TabIndex = 27;
            this.textBox20.Visible = false;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(276, 11);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(20, 20);
            this.textBox19.TabIndex = 26;
            this.textBox19.Visible = false;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(253, 11);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(20, 20);
            this.textBox18.TabIndex = 25;
            this.textBox18.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(260, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "label12";
            this.label12.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(218, 23);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(126, 221);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Location = new System.Drawing.Point(126, 195);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Max Value:";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(293, 102);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(20, 20);
            this.textBox17.TabIndex = 22;
            this.textBox17.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nas:";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(271, 102);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(20, 20);
            this.textBox16.TabIndex = 21;
            this.textBox16.Visible = false;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(250, 102);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(20, 20);
            this.textBox15.TabIndex = 20;
            this.textBox15.Visible = false;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(229, 102);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(20, 20);
            this.textBox14.TabIndex = 19;
            this.textBox14.Visible = false;
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.Location = new System.Drawing.Point(126, 169);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 18;
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Location = new System.Drawing.Point(126, 134);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 17;
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox11.Location = new System.Drawing.Point(126, 63);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 16;
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Location = new System.Drawing.Point(126, 29);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(56, 20);
            this.textBox10.TabIndex = 15;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Location = new System.Drawing.Point(126, 98);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(299, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "label11";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(261, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Need Affinity Points:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Need Affinity:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Need Item Count:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Need Item:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Need Level:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(562, 1);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(42, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Enable";
            this.label4.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.toolStrip1);
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Location = new System.Drawing.Point(673, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(689, 175);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Monster Set";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 147);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(683, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(80, 22);
            this.toolStripButton1.Text = "Add Monster";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(90, 22);
            this.toolStripButton2.Text = "Delete selected";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(683, 134);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "a_work_type";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Monster";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Monster Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 230;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "a_affinity_idx";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Affinity Points";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "a_enable";
            this.Column6.Name = "Column6";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.toolStrip2);
            this.groupBox6.Controls.Add(this.dataGridView2);
            this.groupBox6.Location = new System.Drawing.Point(673, 207);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(462, 199);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Donate Items Set";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripButton4});
            this.toolStrip2.Location = new System.Drawing.Point(3, 171);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(456, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton3.Text = "Add Item";
            this.toolStripButton3.ToolTipText = "Add Item";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(44, 22);
            this.toolStripButton4.Text = "Delete";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.Work_Type,
            this.ItemID,
            this.ItemName,
            this.AffinityIdx,
            this.AffinityPoints,
            this.Enable});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(456, 180);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 32;
            // 
            // Work_Type
            // 
            this.Work_Type.HeaderText = "a_work_type";
            this.Work_Type.Name = "Work_Type";
            this.Work_Type.Visible = false;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 205;
            // 
            // AffinityIdx
            // 
            this.AffinityIdx.HeaderText = "a_affinity_idx";
            this.AffinityIdx.Name = "AffinityIdx";
            this.AffinityIdx.Visible = false;
            // 
            // AffinityPoints
            // 
            this.AffinityPoints.HeaderText = "Affinity Points";
            this.AffinityPoints.Name = "AffinityPoints";
            // 
            // Enable
            // 
            this.Enable.HeaderText = "a_enable";
            this.Enable.Name = "Enable";
            this.Enable.Visible = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.toolStrip3);
            this.groupBox7.Controls.Add(this.dataGridView3);
            this.groupBox7.Location = new System.Drawing.Point(670, 412);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(462, 175);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Quest Set";
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripSeparator3,
            this.toolStripButton6});
            this.toolStrip3.Location = new System.Drawing.Point(3, 147);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(456, 25);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(67, 22);
            this.toolStripButton5.Text = "Add Quest";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(44, 22);
            this.toolStripButton6.Text = "Delete";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.Location = new System.Drawing.Point(3, 16);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView3.Size = new System.Drawing.Size(456, 156);
            this.dataGridView3.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "a_work_type";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "QuestID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Quest Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 230;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "a_affinity_idx";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Affinity Points";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "a_enable";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.toolStrip4);
            this.groupBox8.Controls.Add(this.dataGridView4);
            this.groupBox8.Location = new System.Drawing.Point(237, 387);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(430, 114);
            this.groupBox8.TabIndex = 15;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Manager NPC Settings";
            // 
            // toolStrip4
            // 
            this.toolStrip4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7,
            this.toolStripSeparator4,
            this.toolStripButton8});
            this.toolStrip4.Location = new System.Drawing.Point(3, 86);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip4.Size = new System.Drawing.Size(424, 25);
            this.toolStrip4.TabIndex = 1;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton7.Text = "Add NPC";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(44, 22);
            this.toolStripButton8.Text = "Delete";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column13,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dataGridView4.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView4.EnableHeadersVisualStyles = false;
            this.dataGridView4.Location = new System.Drawing.Point(3, 16);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView4.Size = new System.Drawing.Size(424, 65);
            this.dataGridView4.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "a_affinity_idx";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "NPC ID";
            this.Column8.Name = "Column8";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Npc Name";
            this.Column13.Name = "Column13";
            this.Column13.Width = 140;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Use Points";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "a_enable";
            this.Column10.Name = "Column10";
            this.Column10.Visible = false;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Flag";
            this.Column11.Name = "Column11";
            this.Column11.Width = 60;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "String ID";
            this.Column12.Name = "Column12";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.dataGridView5);
            this.groupBox9.Location = new System.Drawing.Point(240, 523);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(424, 146);
            this.groupBox9.TabIndex = 16;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Affinity Reward";
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22,
            this.Column23});
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView5.EnableHeadersVisualStyles = false;
            this.dataGridView5.Location = new System.Drawing.Point(3, 16);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersVisible = false;
            this.dataGridView5.Size = new System.Drawing.Size(418, 127);
            this.dataGridView5.TabIndex = 0;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "a_npcidx";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "a_allow_point";
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.HeaderText = "a_itemidx";
            this.Column16.Name = "Column16";
            // 
            // Column17
            // 
            this.Column17.HeaderText = "a_flag";
            this.Column17.Name = "Column17";
            // 
            // Column18
            // 
            this.Column18.HeaderText = "a_count";
            this.Column18.Name = "Column18";
            // 
            // Column19
            // 
            this.Column19.HeaderText = "a_exp";
            this.Column19.Name = "Column19";
            // 
            // Column20
            // 
            this.Column20.HeaderText = "a_sp";
            this.Column20.Name = "Column20";
            // 
            // Column21
            // 
            this.Column21.HeaderText = "a_needpclevle";
            this.Column21.Name = "Column21";
            // 
            // Column22
            // 
            this.Column22.HeaderText = "a_needitemidx";
            this.Column22.Name = "Column22";
            // 
            // Column23
            // 
            this.Column23.HeaderText = "a_needitemcount";
            this.Column23.Name = "Column23";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1040, 656);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 28);
            this.button3.TabIndex = 17;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AffinityEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 696);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AffinityEditor";
            this.Text = "Affinity Editor";
            this.Load += new System.EventHandler(this.AffinityEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        private void exportAffinitylodToolStripMenuItem_Click(object sender, EventArgs e)// Roseon Export
        {
            
        }

        private void toolStripButton7_Click(object sender, EventArgs e) //Add NPC dethunter12
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e) // Add Quest dethunter12
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e) //Add item dethunter12
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e) //Delete Quest dethunter12
        {
            DataGridViewRow row = dataGridView3.Rows[dataGridView3.CurrentRow.Index]; // to get the information of the current row.
            string str1 = Convert.ToString(row.Cells["Column1"].Value); // to simplify the database query string
            string str2 = Convert.ToString(row.Cells["Column2"].Value); // to simplify the database query string
            string str3 = Convert.ToString(row.Cells["Column4"].Value); // to simplify the database query string
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_magicLevel WHERE a_index ='" + Convert.ToString(row.Cells["index"].Value) + "' AND a_level = '" + Convert.ToString(row.Cells["Level"].Value) + "'");
            dataGridView3.Rows.Clear();
            LoadDG3(); //dethunter12 add
        }

        private void toolStripButton4_Click(object sender, EventArgs e)//Delete Donate Item dethunter12
        {

        }

        private void toolStripButton8_Click(object sender, EventArgs e) //Delete manager npc dethunter12
        {

        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text1 = "affinity";
            string text2 = "path_ship";
            string text3 = "usa";
            Process.Start(new ProcessStartInfo()
            {
                FileName = "ExportLod.exe",
                Arguments = " -h " + Host + " -d " + Database + " -u " + User + " -p " + Password + " -k " + text2 + " -l " + text3 + " -t " + text1
            });
        }

        private void thaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text1 = "affinity";
            string text2 = "path_ship";
            string text3 = "tha";
            Process.Start(new ProcessStartInfo()
            {
                FileName = "ExportLod.exe",
                Arguments = " -h " + Host + " -d " + Database + " -u " + User + " -p " + Password + " -k " + text2 + " -l " + text3 + " -t " + text1
            });
        }

        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text1 = "affinity";
            string text2 = "path_ship";
            string text3 = "fra";
            Process.Start(new ProcessStartInfo()
            {
                FileName = "ExportLod.exe",
                Arguments = " -h " + Host + " -d " + Database + " -u " + User + " -p " + Password + " -k " + text2 + " -l " + text3 + " -t " + text1
            });
        }

        private void germanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text1 = "affinity";
            string text2 = "path_ship";
            string text3 = "ger";
            Process.Start(new ProcessStartInfo()
            {
                FileName = "ExportLod.exe",
                Arguments = " -h " + Host + " -d " + Database + " -u " + User + " -p " + Password + " -k " + text2 + " -l " + text3 + " -t " + text1
            });
        }

        private void spanishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text1 = "affinity";
            string text2 = "path_ship";
            string text3 = "esp";
            Process.Start(new ProcessStartInfo()
            {
                FileName = "ExportLod.exe",
                Arguments = " -h " + Host + " -d " + Database + " -u " + User + " -p " + Password + " -k " + text2 + " -l " + text3 + " -t " + text1
            });
        }

        private void mexicanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text1 = "affinity";
            string text2 = "path_ship";
            string text3 = "mex";
            Process.Start(new ProcessStartInfo()
            {
                FileName = "ExportLod.exe",
                Arguments = " -h " + Host + " -d " + Database + " -u " + User + " -p " + Password + " -k " + text2 + " -l " + text3 + " -t " + text1
            });
        }

        private void brazilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text1 = "affinity";
            string text2 = "path_ship";
            string text3 = "bra";
            Process.Start(new ProcessStartInfo()
            {
                FileName = "ExportLod.exe",
                Arguments = " -h " + Host + " -d " + Database + " -u " + User + " -p " + Password + " -k " + text2 + " -l " + text3 + " -t " + text1
            });
        }

        private void italianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text1 = "affinity";
            string text2 = "path_ship";
            string text3 = "ita";
            Process.Start(new ProcessStartInfo()
            {
                FileName = "ExportLod.exe",
                Arguments = " -h " + Host + " -d " + Database + " -u " + User + " -p " + Password + " -k " + text2 + " -l " + text3 + " -t " + text1
            });
        }

        private void polandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text1 = "affinity";
            string text2 = "path_ship";
            string text3 = "pol";
            Process.Start(new ProcessStartInfo()
            {
                FileName = "ExportLod.exe",
                Arguments = " -h " + Host + " -d " + Database + " -u " + User + " -p " + Password + " -k " + text2 + " -l " + text3 + " -t " + text1
            });
        }

        private void exportStrAffinityusalodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExport f2 = new FormExport();
            f2.ShowDialog(); // Shows Form2
        }
    }
}
