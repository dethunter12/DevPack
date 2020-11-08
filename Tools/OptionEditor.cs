// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.Tools.OptionEditor
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

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
  public class OptionEditor : Form
  {
    public static Connection connection = new Connection();
    public static int MaxOptionLevel;
    private string Host = OptionEditor.connection.ReadSettings("Host");
    private string User = OptionEditor.connection.ReadSettings("User");
    private string Password = OptionEditor.connection.ReadSettings("Password");
    private string Database = OptionEditor.connection.ReadSettings("Database");
    private string language = OptionEditor.connection.ReadSettings("Language");//dethunter12 language selection
    private string namee; //dethunter12 stringfrom lang modify
    private DatabaseHandle databaseHandle = new DatabaseHandle();
    public string rowName = "a_index";
    public string[] menuArray = new string[2]
    {
      "a_index",
      "a_name"
    };

    private ExportLodHandle exportLodHandle = new ExportLodHandle();
    private IContainer components = (IContainer) null;
    public string name;
    public int index;
    public string test2;
    public List<string> lArrayLevel;
    public List<string> lArrayProb;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileExportToolStripMenuItem;
    private ToolStripMenuItem exportlodToolStripMenuItem;
    private GroupBox groupBox3;
    private Button button3;
    private Button button1;
    private ListBox listBox1;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private TextBox textBox4;
    private TextBox textBox5;
    private TextBox textBox6;
    private Label label3;
    private Label label2;
    private Label label1;
    private Label label5;
    private Label label4;
    private Label label6;
    private GroupBox groupBox4;
    private DataGridView dgItems;
    private ToolStrip toolStrip2;
    private ToolStripButton btnDeleteSelected;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripButton btnAddItems;
    private ToolStripSeparator toolStripSeparator6;
    private ToolStripButton toolStripButton1;
    private Button button2;
    private DataGridViewTextBoxColumn ID;
    private DataGridViewTextBoxColumn Count;
    private DataGridViewTextBoxColumn Level;
    private DataGridViewTextBoxColumn Prob;
        private TextBox tbMaxOption;
        private Label label7;
        private ToolStripMenuItem exportStrOptionlodToolStripMenuItem;

    public OptionEditor()
    {
            InitializeComponent();
    }

    private void LoadListBox()
    {
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select * from t_option ORDER BY a_index;");
    }

    private void Exporter_Option_Load(object sender, EventArgs e)
    {
            MaxOptionLevel = Convert.ToInt32(tbMaxOption.Text);
            LoadListBox();
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

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listBox1.SelectedIndex != -1)
                textBox1.Text = GetIndex().ToString();
      string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, " select * from t_option WHERE a_index ='" + textBox1.Text + "';", new string[6]
      {
        "a_index",
        "a_type",
        "a_name",
        "a_weapon_type",
        "a_wear_type",
        "a_accessory_type"
      });
            textBox1.Text = strArray[0];
            textBox2.Text = strArray[1];
            textBox3.Text = strArray[2];
            textBox4.Text = strArray[3];
            textBox5.Text = strArray[4];
            textBox6.Text = strArray[5];
            dgItems.Rows.Clear();
            LoadDG();
    }

    public void LoadDG()
    {
      string str1 = "SELECT a_index, a_level, a_prob FROM t_option WHERE a_index ='" + textBox1.Text + "'";
      MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
      MySqlCommand command = mySqlConnection.CreateCommand();
      command.CommandText = str1;
      mySqlConnection.Open();
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (mySqlDataReader.Read())
      {
        string str2 = mySqlDataReader.GetValue(0).ToString();
        string str3 = mySqlDataReader.GetValue(1).ToString();
        string str4 = mySqlDataReader.GetValue(2).ToString();
        string[] strArray1 = str3.Split(' ');
        string[] strArray2 = str4.Split(' ');
        string[] strArray3 = new string[1000];
        string[] strArray4 = new string[1000];
        int index1 = 0;
        int index2 = 0;
                lArrayLevel = new List<string>();
                lArrayProb = new List<string>();
        foreach (string str5 in strArray1)
        {
          strArray3[index1] = str5;
                    lArrayLevel.Add(str5);
          ++index1;
        }
        foreach (string str5 in strArray2)
        {
          strArray4[index2] = str5;
                    lArrayProb.Add(str5);
          ++index2;
        }
        int count = lArrayLevel.Count;
        for (int index3 = 0; index3 < count; ++index3)
                    dgItems.Rows.Add( str2,  (index3 + 1), lArrayLevel[index3], lArrayProb[index3]);
      }
      mySqlConnection.Close();
    }

    private void btnDeleteSelected_Click(object sender, EventArgs e)
    {
      int index1 = dgItems.CurrentRow.Index;
      DataGridViewRow row = dgItems.Rows[index1];
      string str1 = Convert.ToString(row.Cells["ID"].Value);
      string s = Convert.ToString(row.Cells["Count"].Value);
      string str2 = Convert.ToString(row.Cells["Level"].Value);
      string str3 = Convert.ToString(row.Cells["Prob"].Value);
      int index2 = int.Parse(s) - 1;
            lArrayLevel[index2] = str2;
            lArrayProb[index2] = str3;
      string str4 = "";
      string str5 = "";
      int count = lArrayLevel.Count;
      for (int index3 = 0; index3 < count; ++index3)
      {
        if (index3 == count - 1)
        {
          str4 += lArrayLevel[index3].ToString();
          str5 += lArrayProb[index3].ToString();
        }
        else
        {
          str4 = str4 + lArrayLevel[index3].ToString() + " ";
          str5 = str5 + lArrayProb[index3].ToString() + " ";
        }
      }
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_option SET a_level = '" + str4 + "', a_prob = '" + str5 + "' WHERE a_index = '" + str1 + "'");
            dgItems.Rows.Clear();
            LoadDG();
      try
      {
                dgItems.Rows[index1].Selected = true;
                dgItems.FirstDisplayedScrollingRowIndex = index1;
      }
      catch
      {
        int num = (int) MessageBox.Show("You must select a Item", "Error");
      }
    }

    private void btnAddItems_Click(object sender, EventArgs e)
    {
      string s = Convert.ToString(dgItems.Rows[dgItems.CurrentRow.Index].Cells["ID"].Value);
      int.Parse(s);
      string str1 = "";
      string str2 = "";
      int count = lArrayLevel.Count;
      for (int index = 0; index < count; ++index)
      {
        str1 = str1 + lArrayLevel[index].ToString() + " ";
        str2 = str2 + lArrayProb[index].ToString() + " ";
      }
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_option SET a_level = '" + str1 + "999" + "', a_prob = '" + str2 + "999" + "' WHERE a_index = '" + s + "'");
            dgItems.Rows.Clear();
            LoadDG();
      int index1 = dgItems.Rows.Count - 1;
            dgItems.Rows[index1].Selected = true;
            dgItems.FirstDisplayedScrollingRowIndex = index1;
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      int index1 = dgItems.CurrentRow.Index;
      int index2 = index1 - 1;
      DataGridViewRow row = dgItems.Rows[index1];
      string str1 = Convert.ToString(row.Cells["ID"].Value);
      string s = Convert.ToString(row.Cells["Count"].Value);
      string str2 = Convert.ToString(row.Cells["Level"].Value);
      string str3 = Convert.ToString(row.Cells["Prob"].Value);
      int index3 = int.Parse(s) - 1;
            lArrayLevel[index3] = str2;
            lArrayProb[index3] = str3;
            lArrayLevel.RemoveAt(index3);
            lArrayProb.RemoveAt(index3);
      string str4 = "";
      string str5 = "";
      int count = lArrayLevel.Count;
      for (int index4 = 0; index4 < count; ++index4)
      {
        if (index4 == count - 1)
        {
          str4 += lArrayLevel[index4].ToString();
          str5 += lArrayProb[index4].ToString();
        }
        else
        {
          str4 = str4 + lArrayLevel[index4].ToString() + " ";
          str5 = str5 + lArrayProb[index4].ToString() + " ";
        }
      }
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_option SET a_level = '" + str4 + "', a_prob = '" + str5 + "' WHERE a_index = '" + str1 + "'");
            dgItems.Rows.Clear();
            LoadDG();
      try
      {
                dgItems.Rows[index2].Selected = true;
                dgItems.FirstDisplayedScrollingRowIndex = index2;
      }
      catch
      {
        int num = (int) MessageBox.Show("You must select a Item", "Error");
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_option SET " + "a_type = '" + textBox2.Text + "', " + "a_name = '" + textBox3.Text + "', " + "a_weapon_type = '" + textBox4.Text + "', " + "a_wear_type = '" + textBox5.Text + "', " + "a_accessory_type = '" + textBox6.Text + "' " + "WHERE a_index = '" + textBox1.Text + "'");
      int selectedIndex = listBox1.SelectedIndex;
            LoadListBox();
            listBox1.SelectedIndex = selectedIndex;
    }

    private void button1_Click(object sender, EventArgs e)
    {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "INSERT INTO t_option (a_level, a_prob) VALUES('0','0')");
            LoadListBox();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      int selectedIndex = listBox1.SelectedIndex;
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_option WHERE a_index = '" + textBox1.Text + "'");
            LoadListBox();
            listBox1.SelectedIndex = selectedIndex - 1;
    }
        public string LanguageExport() //dethunter12 add 7/5/2020
        {

            if (language == "GER")
            {
                namee = "ger";
                return namee;

            }
            else if (language == "POL")
            {
                namee = "pol";
                return namee;

            }
            else if (language == "BRA")
            {
                namee = "brz";
                return namee;
            }
            else if (language == "RUS")
            {
                namee = "rus";
                return namee;
            }
            else if (language == "FRA")
            {
                namee = "fra";
                return namee;
            }
            else if (language == "ESP")
            {
                namee = "esp";
                return namee;
            }
            else if (language == "MEX")
            {
                namee = "mex";
                return namee;
            }
            else if (language == "THA")
            {
                namee = "tha";
                return namee;
            }
            else if (language == "ITA")
            {
                namee = "ita";
                return namee;
            }
            else if (language == "USA")
            {
                namee = "usa";
                return namee;
            }
            else
            {
                return null;
            }
        }
        private void exportlodToolStripMenuItem_Click(object sender, EventArgs e)
    {
            string text1 = "option";
            string text2 = "path_ship";
            string text3 = LanguageExport();
            Process.Start(new ProcessStartInfo()
            {
                FileName = "ExportLod.exe",
                Arguments = " -h " + Host + " -d " + Database + " -u " + User + " -p " + Password + " -k " + text2 + " -l " + text3 + " -t " + text1
            });
        }

    private void exportStrOptionlodToolStripMenuItem_Click(object sender, EventArgs e)
    {
            FormExport f2 = new FormExport();
            f2.ShowDialog(); // Shows Form2
        }

    protected override void Dispose(bool disposing)
    {
      if (disposing && components != null)
                components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportlodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportStrOptionlodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnDeleteSelected = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddItems = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.button2 = new System.Windows.Forms.Button();
            this.tbMaxOption = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileExportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileExportToolStripMenuItem
            // 
            this.fileExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportlodToolStripMenuItem,
            this.exportStrOptionlodToolStripMenuItem});
            this.fileExportToolStripMenuItem.Name = "fileExportToolStripMenuItem";
            this.fileExportToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.fileExportToolStripMenuItem.Text = "File Export";
            // 
            // exportlodToolStripMenuItem
            // 
            this.exportlodToolStripMenuItem.Name = "exportlodToolStripMenuItem";
            this.exportlodToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exportlodToolStripMenuItem.Text = "Export option.lod";
            this.exportlodToolStripMenuItem.Click += new System.EventHandler(this.exportlodToolStripMenuItem_Click);
            // 
            // exportStrOptionlodToolStripMenuItem
            // 
            this.exportStrOptionlodToolStripMenuItem.Name = "exportStrOptionlodToolStripMenuItem";
            this.exportStrOptionlodToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exportStrOptionlodToolStripMenuItem.Text = "Export strOption.lod";
            this.exportStrOptionlodToolStripMenuItem.Click += new System.EventHandler(this.exportStrOptionlodToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 475);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(131, 446);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 420);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(255, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 80);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Index:";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(48, 49);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 20);
            this.textBox3.TabIndex = 37;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(48, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 20);
            this.textBox1.TabIndex = 35;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(151, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(41, 20);
            this.textBox2.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(525, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 80);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(87, 49);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(44, 20);
            this.textBox6.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "AccessoryType:";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(211, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(44, 20);
            this.textBox5.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "WearType:";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(87, 19);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(44, 20);
            this.textBox4.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "WeaponType:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.dgItems);
            this.groupBox4.Controls.Add(this.toolStrip2);
            this.groupBox4.Location = new System.Drawing.Point(255, 113);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(531, 348);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seals";
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
            this.dgItems.AllowUserToDeleteRows = false;
            this.dgItems.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Count,
            this.Level,
            this.Prob});
            this.dgItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgItems.EnableHeadersVisualStyles = false;
            this.dgItems.Location = new System.Drawing.Point(3, 16);
            this.dgItems.Name = "dgItems";
            this.dgItems.RowHeadersVisible = false;
            this.dgItems.RowTemplate.Height = 25;
            this.dgItems.Size = new System.Drawing.Size(525, 304);
            this.dgItems.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 60;
            // 
            // Count
            // 
            this.Count.HeaderText = "Level";
            this.Count.Name = "Count";
            this.Count.Width = 50;
            // 
            // Level
            // 
            this.Level.HeaderText = "Value";
            this.Level.Name = "Level";
            this.Level.Width = 225;
            // 
            // Prob
            // 
            this.Prob.HeaderText = "Prob";
            this.Prob.Name = "Prob";
            this.Prob.Width = 225;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeleteSelected,
            this.toolStripSeparator1,
            this.btnAddItems,
            this.toolStripSeparator6,
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(3, 320);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(525, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDeleteSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(65, 22);
            this.btnDeleteSelected.Text = "Save Level";
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddItems
            // 
            this.btnAddItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(63, 22);
            this.btnAddItems.Text = "Add Level";
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(91, 22);
            this.toolStripButton1.Text = "Delete Selected";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(686, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbMaxOption
            // 
            this.tbMaxOption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMaxOption.Location = new System.Drawing.Point(758, 1);
            this.tbMaxOption.Name = "tbMaxOption";
            this.tbMaxOption.Size = new System.Drawing.Size(41, 20);
            this.tbMaxOption.TabIndex = 46;
            this.tbMaxOption.Text = "36";
            this.tbMaxOption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMaxOption.Visible = false;
            this.tbMaxOption.TextChanged += new System.EventHandler(this.tbMaxOption_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(662, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Max Option Level:";
            this.label7.Visible = false;
            // 
            // OptionEditor
            // 
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbMaxOption);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OptionEditor";
            this.Text = "Option Editor";
            this.Load += new System.EventHandler(this.Exporter_Option_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        private void tbMaxOption_TextChanged(object sender, EventArgs e)
        {
            MaxOptionLevel = Convert.ToInt32(tbMaxOption.Text);
        }
    }
}
