// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.Tools.MoonstoneEditor
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools
{
  public class MoonstoneEditor : Form
  {
    public static Connection connection = new Connection();
    private string Host = MoonstoneEditor.connection.ReadSettings("Host");
    private string User = MoonstoneEditor.connection.ReadSettings("User");
    private string Password = MoonstoneEditor.connection.ReadSettings("Password");
    private string Database = MoonstoneEditor.connection.ReadSettings("Database");
    private DatabaseHandle databaseHandle = new DatabaseHandle();
    public string rowName = "a_index";
    public string[] menuArray = new string[2]
    {
      "a_index",
      "a_name"
    };
    public string MoonstoneID = "";
    private ExportLodHandle exportLodHandle = new ExportLodHandle();
    private IContainer components = (IContainer) null;
    public string name;
    public int index;
    public string test2;
    public List<string> lArrayLevel;
    public List<string> lArrayProb;
    private ToolStripStatusLabel toolStripStatusLabel1;
    private Button button5;
    private Button button4;
    private Button button3;
    private Button button2;
    private GroupBox groupBox1;
    private Button button1;
    private ToolStripButton toolStripButton1;
    private ToolStripSeparator toolStripSeparator6;
    private ToolStripButton btnAddItems;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripButton btnDeleteSelected;
    private StatusStrip statusStrip1;
    private DataGridView dgItems;
    private DataGridViewImageColumn Column7;
    private DataGridViewTextBoxColumn GiftIndex;
    private DataGridViewTextBoxColumn ItemName;
    private DataGridViewTextBoxColumn Type;
    private DataGridViewTextBoxColumn GiftCount;
    private DataGridViewTextBoxColumn GiftProb;
    private DataGridViewTextBoxColumn GiftFlag;
    private DataGridViewTextBoxColumn ID;
    private GroupBox groupBox4;
    private ToolStrip toolStrip2;
    private ToolStripMenuItem exportlodToolStripMenuItem;
    private ToolStripMenuItem fileExportToolStripMenuItem;
    private MenuStrip menuStrip1;

    public MoonstoneEditor()
    {
            InitializeComponent();
    }

    private void MoonstoneEditor_Load(object sender, EventArgs e)
    {
            button1.BackgroundImage = (Image)databaseHandle.IconFast(723);
            button2.BackgroundImage = (Image)databaseHandle.IconFast(2545);
            button3.BackgroundImage = (Image)databaseHandle.IconFast(2546);
            button4.BackgroundImage = (Image)databaseHandle.IconFast(2547);
            button5.BackgroundImage = (Image)databaseHandle.IconFast(2548);
            toolStripStatusLabel1.Text = "Choose your category!";
            toolStripStatusLabel1.ForeColor = Color.Maroon;
    }

    public void LoadDG(string MoonstoneIDX)
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();
      if (MoonstoneID != "")
      {
                toolStripStatusLabel1.Text = "Ready";
                toolStripStatusLabel1.ForeColor = Color.Black;
      }
            toolStripStatusLabel1.Text = "Load Items ...";
            dgItems.Rows.Clear();
      string str1 = "SELECT * FROM t_moonstone_reward WHERE a_type ='+" + MoonstoneIDX + "' ORDER BY a_index";
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
        string str5 = mySqlDataReader.GetValue(3).ToString();
        string str6 = mySqlDataReader.GetValue(4).ToString();
        string str7 = mySqlDataReader.GetValue(5).ToString();
        int int32 = Convert.ToInt32(str4);
                dgItems.Rows.Add(databaseHandle.IconFast(int32),  str4, databaseHandle.ItemNameFast(int32),  str3,  str5,  str6,  str7,  str2);
      }
      mySqlConnection.Close();
      stopwatch.Stop();
      TimeSpan elapsed = stopwatch.Elapsed;
      string.Format("{0:00}:{1:00}:{2:00}.{3:00}",  elapsed.Hours,  elapsed.Minutes,  elapsed.Seconds,  (elapsed.Milliseconds / 10));
            toolStripStatusLabel1.Text = "Ready";
    }

    private void btnDeleteSelected_Click(object sender, EventArgs e)
    {
      int index = dgItems.CurrentRow.Index;
      DataGridViewRow row = dgItems.Rows[index];
      string str1 = Convert.ToString(row.Cells["GiftIndex"].Value);
      string str2 = Convert.ToString(row.Cells["Type"].Value);
      string str3 = Convert.ToString(row.Cells["GiftCount"].Value);
      string str4 = Convert.ToString(row.Cells["GiftProb"].Value);
      string str5 = Convert.ToString(row.Cells["GiftFlag"].Value);
      string str6 = Convert.ToString(row.Cells["ID"].Value);
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_moonstone_reward SET " + "a_type = '" + str2 + "', " + "a_giftindex = '" + str1 + "', " + "a_giftcount = '" + str3 + "', " + "a_giftprob = '" + str4 + "', " + "a_giftflag = '" + str5 + "' " + "WHERE a_index = '" + str6 + "' ");
            dgItems.Rows.Clear();
            LoadDG(MoonstoneID);
      try
      {
                dgItems.Rows[index].Selected = true;
                dgItems.FirstDisplayedScrollingRowIndex = index;
      }
      catch
      {
        int num = (int) MessageBox.Show("You must select a Item", "Error");
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
            MoonstoneID = "723";
            LoadDG(MoonstoneID);
    }

    private void btnAddItems_Click(object sender, EventArgs e)
    {
      try
      {
                ItemPicker itemPicker = new ItemPicker(); //dethunter12 add
                if (itemPicker.ShowDialog() != DialogResult.OK)
                    return;
                int ItemIDx;
                ItemIDx = itemPicker.ItemIndex;
                databaseHandle.SendQueryMySql(Host, User, Password, Database, "INSERT INTO t_moonstone_reward (a_type, a_giftindex) VALUES ('" + MoonstoneID + "'," + "'" + ItemIDx + "')");
      }
      catch
      {
        int num = (int) MessageBox.Show("Duplicated ItemID isn't allowed.", "Error");
      }
            dgItems.Rows.Clear();
            LoadDG(MoonstoneID);
      int index = dgItems.Rows.Count - 1;
            dgItems.Rows[index].Selected = true;
            dgItems.FirstDisplayedScrollingRowIndex = index;
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      int index1 = dgItems.CurrentRow.Index;
      int index2 = index1 - 1;
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_moonstone_reward WHERE a_index ='" + Convert.ToString(dgItems.Rows[index1].Cells["ID"].Value) + "'");
            dgItems.Rows.Clear();
            LoadDG(MoonstoneID);
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
            MoonstoneID = "2545";
            LoadDG(MoonstoneID);
    }

    private void button3_Click(object sender, EventArgs e)
    {
            MoonstoneID = "2546";
            LoadDG(MoonstoneID);
    }

    private void button4_Click(object sender, EventArgs e)
    {
            MoonstoneID = "2547";
            LoadDG(MoonstoneID);
    }

    private void button5_Click(object sender, EventArgs e)
    {
            MoonstoneID = "2548";
            LoadDG(MoonstoneID);
    }

    private void exportlodToolStripMenuItem_Click(object sender, EventArgs e)
    {
            exportLodHandle.ExportMoonstoneLOD_V2();
    }

    public void SaveFile(string fileName)
    {
      BinaryWriter binaryWriter = new BinaryWriter((Stream) File.Create(fileName));
      string str = "SELECT a_giftindex FROM t_moonstone_reward ORDER BY a_type";
      MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
      MySqlCommand command = mySqlConnection.CreateCommand();
      command.CommandText = str;
      mySqlConnection.Open();
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (mySqlDataReader.Read())
      {
        string s = mySqlDataReader.GetValue(0).ToString();
        binaryWriter.Write(int.Parse(s));
      }
      mySqlConnection.Close();
      binaryWriter.Close();
    }

    private void toolStripStatusLabel1_Click(object sender, EventArgs e)
    {
    }

    private void exportlodToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
            exportLodHandle.ExportMoonstoneLOD_V2();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && components != null)
                components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoonstoneEditor));
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddItems = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeleteSelected = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.GiftIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiftCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiftProb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiftFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.exportlodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(158, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 32);
            this.button5.TabIndex = 49;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(120, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 32);
            this.button4.TabIndex = 48;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(44, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 32);
            this.button3.TabIndex = 47;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(6, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 46;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(14, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 55);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(82, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 45;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddItems
            // 
            this.btnAddItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(60, 22);
            this.btnAddItems.Text = "Add Item";
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDeleteSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(62, 22);
            this.btnDeleteSelected.Text = "Save Item";
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 562);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(707, 22);
            this.statusStrip1.TabIndex = 52;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
            this.dgItems.AllowUserToDeleteRows = false;
            this.dgItems.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.GiftIndex,
            this.ItemName,
            this.Type,
            this.GiftCount,
            this.GiftProb,
            this.GiftFlag,
            this.ID});
            this.dgItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgItems.EnableHeadersVisualStyles = false;
            this.dgItems.Location = new System.Drawing.Point(3, 16);
            this.dgItems.Name = "dgItems";
            this.dgItems.RowHeadersVisible = false;
            this.dgItems.RowTemplate.Height = 32;
            this.dgItems.Size = new System.Drawing.Size(678, 427);
            this.dgItems.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "";
            this.Column7.Name = "Column7";
            this.Column7.Width = 32;
            // 
            // GiftIndex
            // 
            this.GiftIndex.HeaderText = "ID";
            this.GiftIndex.Name = "GiftIndex";
            this.GiftIndex.Width = 50;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 275;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.Visible = false;
            this.Type.Width = 75;
            // 
            // GiftCount
            // 
            this.GiftCount.HeaderText = "GiftCount";
            this.GiftCount.Name = "GiftCount";
            // 
            // GiftProb
            // 
            this.GiftProb.HeaderText = "GiftProb";
            this.GiftProb.Name = "GiftProb";
            // 
            // GiftFlag
            // 
            this.GiftFlag.HeaderText = "GiftFlag";
            this.GiftFlag.Name = "GiftFlag";
            // 
            // ID
            // 
            this.ID.HeaderText = "Index";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 60;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgItems);
            this.groupBox4.Controls.Add(this.toolStrip2);
            this.groupBox4.Location = new System.Drawing.Point(11, 88);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(684, 471);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Items";
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
            this.toolStrip2.Location = new System.Drawing.Point(3, 443);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(678, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // exportlodToolStripMenuItem
            // 
            this.exportlodToolStripMenuItem.Name = "exportlodToolStripMenuItem";
            this.exportlodToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exportlodToolStripMenuItem.Text = "Export .lod";
            this.exportlodToolStripMenuItem.Click += new System.EventHandler(this.exportlodToolStripMenuItem_Click_1);
            // 
            // fileExportToolStripMenuItem
            // 
            this.fileExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportlodToolStripMenuItem});
            this.fileExportToolStripMenuItem.Name = "fileExportToolStripMenuItem";
            this.fileExportToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.fileExportToolStripMenuItem.Text = "File Export";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileExportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MoonstoneEditor
            // 
            this.ClientSize = new System.Drawing.Size(707, 584);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MoonstoneEditor";
            this.Text = "MoonstoneEditor";
            this.Load += new System.EventHandler(this.MoonstoneEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
  }
}
