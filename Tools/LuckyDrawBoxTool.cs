// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.Tools.LuckyDrawBoxTool
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools
{
  public class LuckyDrawBoxTool : Form
  {
    public static Connection connection = new Connection();
    private string Host = LuckyDrawBoxTool.connection.ReadSettings("Host");
    private string User = LuckyDrawBoxTool.connection.ReadSettings("User");
    private string Password = LuckyDrawBoxTool.connection.ReadSettings("Password");
    private string Database = LuckyDrawBoxTool.connection.ReadSettings("Database");
    private DatabaseHandle databaseHandle = new DatabaseHandle();
    public string rowName = "a_index";
    public string[] menuArray = new string[2]
    {
      "a_index",
      "a_name"
    };
    private IContainer components = (IContainer) null;
    public string name;
    public int index;
    public string test2;
    private ListBox listBox1;
    private GroupBox groupBox1;
    private Button button2;
    private Button button1;
    private Button button3;
    private GroupBox groupBox2;
    private Label label4;
    private Label label3;
    private TextBox textBox4;
    private Label label2;
    private Label label1;
    private TextBox textBox3;
    private TextBox textBox2;
    private TextBox textBox1;
    private GroupBox groupBox4;
    private DataGridView dgItems;
    private ToolStrip toolStrip2;
    private ToolStripButton btnDeleteSelected;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripButton btnAddItems;
    private ToolStripSeparator toolStripSeparator6;
    private ToolStripButton toolStripButton1;
    private GroupBox groupBox3;
    private DataGridView dgItems2;
    private ToolStrip toolStrip1;
    private ToolStripButton toolStripButton2;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripButton toolStripButton3;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripButton toolStripButton4;
    private DataGridViewImageColumn Column7;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column4;
    private DataGridViewTextBoxColumn Column5;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private DataGridViewImageColumn dataGridViewImageColumn1;
    private DataGridViewTextBoxColumn Column11;
    private DataGridViewTextBoxColumn Column12;
    private DataGridViewTextBoxColumn Column13;
    private DataGridViewTextBoxColumn Column14;
    private DataGridViewTextBoxColumn Column15;
    private DataGridViewTextBoxColumn Column16;
    private DataGridViewTextBoxColumn Column17;
    private DataGridViewTextBoxColumn Column10;
    private CheckBox checkBox1;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel toolStripStatusLabel1;
    private CheckedListBox checkedListBox1;

    public LuckyDrawBoxTool()
    {
            InitializeComponent();
    }

    private void LoadListBox()
    {
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select * from t_luckydrawbox ORDER BY a_index;");
    }
 
    //private void LoadListBoxNameFromItem()
    //    {
    //        string str1 = "SELECT ='" + textBox1.Text + "'";

    //        MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
    //        MySqlCommand command = mySqlConnection.CreateCommand();
    //        command.CommandText = str1;
    //        mySqlConnection.Open();
    //        MySqlDataReader mySqlDataReader = command.ExecuteReader();
    //        while (mySqlDataReader.Read())
    //        {
    //            int a1 = mySqlDataReader.GetOrdinal("a_item_idx");
    //            string a_item_idx = mySqlDataReader.GetString(a1);
    //            Bitmap bitmap1 = databaseHandle.IconFast(Convert.ToInt32(a_item_idx));
    //            string a_name = databaseHandle.ItemNameFast(Convert.ToInt32(a_item_idx));
    //            int a2 = mySqlDataReader.GetOrdinal("a_prob");
    //            string a_prob = mySqlDataReader.GetString(a2);
    //            //load a_num_0 name into textbox field 
    //            //takes paramter item index to trigger 
    //            // create a paramter item index , but check it against a_index )fpr each statment?
    //            //

    //        }
    //       // textBox2.Text = databaseHandle.DrawBoxNameFromItem(itemID);
    //    }
    private void LoadBasic()
    {
      if (textBox3.Text == "1")
                checkBox1.Checked = true;
      else
                checkBox1.Checked = false;
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

    private void LuckyDrawBoxTool_Load(object sender, EventArgs e)
    {
            LoadListBox();
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listBox1.SelectedIndex != -1)
      {
                name = listBox1.SelectedItem.ToString();
                textBox1.Text = name;
      }
      string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, " select * from t_luckydrawbox WHERE a_index ='" + textBox1.Text + "';", new string[4]
      {
        "a_index",
        "a_name",
        "a_enable",
        "a_random"
      });
            textBox1.Text = strArray[0];
            textBox2.Text = strArray[1];
            textBox3.Text = strArray[2];
            textBox4.Text = strArray[3];
            dgItems.Rows.Clear();
            dgItems2.Rows.Clear();
            LoadDG();
            LoadDG2();
            LoadBasic();
            LoadMisc();
    }

    private void ShowRandom(int flag)
    {
      for (int index = 0; index < checkedListBox1.Items.Count; ++index)
      {
        if ((uint) flag > 0U)
                    checkedListBox1.SetItemChecked(index, true);
        else
                    checkedListBox1.SetItemChecked(index, false);
      }
    }

    public void LoadDG()
    {
            toolStripStatusLabel1.Text = "Load Items ...";
      string str1 = "SELECT * FROM t_luckydrawNeed WHERE a_luckydraw_idx ='" + textBox1.Text + "'";
      string[] strArray = new string[4]
      {
        "a_index",
        "a_luckydraw_idx",
        "a_item_idx",
        "a_count"
      };
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
        Bitmap bitmap = databaseHandle.IconFast(Convert.ToInt32(str4));
        string str6 = databaseHandle.ItemNameFast(Convert.ToInt32(str4));
                dgItems.Rows.Add( bitmap,  str3,  str4,  str6,  str5,  str2);
      }
      mySqlConnection.Close();
            toolStripStatusLabel1.Text = "Ready";
    }

    public void LoadDG2()
    {
            toolStripStatusLabel1.Text = "Load Items ...";
      string str1 = "SELECT * FROM t_luckydrawResult WHERE a_luckydraw_idx ='" + textBox1.Text + "' ORDER BY a_prob DESC";
      string[] strArray1 = new string[7]
      {
        "a_index",
        "a_luckydraw_idx",
        "a_item_idx",
        "a_count",
        "a_upgrade",
        "a_prob",
        "a_flag"
      };
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
        string str8 = mySqlDataReader.GetValue(6).ToString();
        string[] strArray2 = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, "SELECT a_name, a_texture_id, a_texture_row, a_texture_col from t_item WHERE a_index ='" + str4 + "';", new string[4]
        {
          "a_name",
          "a_texture_id",
          "a_texture_row",
          "a_texture_col"
        });
        string str9 = strArray2[0];
                dgItems2.Rows.Add(databaseHandle.IconItem(Convert.ToInt32(strArray2[1]), Convert.ToInt32(strArray2[2]), Convert.ToInt32(strArray2[3])),  str3,  str4,  str9,  str5,  str6,  str7,  str8,  str2);
      }
      mySqlConnection.Close();
            toolStripStatusLabel1.Text = "Ready";
    }

    private void dgItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_luckydrawNeed WHERE a_index ='" + Convert.ToString(dgItems.Rows[dgItems.CurrentRow.Index].Cells["Column5"].Value) + "'");
            dgItems.Rows.Clear();
            LoadDG();
    }

    private void btnAddItems_Click(object sender, EventArgs e) 
    {
             ItemPicker2Listt.Clear();//dethunter12 add 7/26/2020
      try
      {
                ItemPicker2 itemPicker = new ItemPicker2(); //dethunter12 add  3/29/2019
                if (itemPicker.ShowDialog() != DialogResult.OK)
                    return;
                int ItemIDx;
                int ItemAmnt;

                for (int i = 0; i < ItemPicker2Listt.Count; i++)
                {
                    ItemAmnt = itemPicker.ItemAmount; //dethunter12 adjust 5/30/2020
                    if (ItemAmnt == -1 || ItemAmnt <= 0)
                        ItemAmnt = 1;
                    ItemIDx = ItemPicker2Listt[i].ID;
                    databaseHandle.SendQueryMySql(Host, User, Password, Database, "INSERT INTO t_luckydrawNeed (a_luckydraw_idx, a_item_idx, a_count) VALUES (" + textBox1.Text + "," + ItemIDx + ", '" + ItemAmnt + "' )"); //dethunter12 adjust add item index from listbox
                }
                dgItems.Rows.Clear();
                LoadDG();
            }
      catch
      {
        int num = (int) MessageBox.Show("Duplicated ItemID isn't allowed.", "Error");
      }
     
    }

    private void btnDeleteSelected_Click(object sender, EventArgs e) // Save Need
        {
      DataGridViewRow row = dgItems.Rows[dgItems.CurrentRow.Index];
      string str = Convert.ToString(row.Cells["Column5"].Value);
      Convert.ToString(row.Cells["Column1"].Value);
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_luckydrawNeed SET " + "a_item_idx = '" + Convert.ToString(row.Cells["Column2"].Value) + "', " + "a_count = '" + Convert.ToString(row.Cells["Column4"].Value) + "' " + "WHERE a_index = '" + str + "' "); //fix test  cant update need item upon item change
            dgItems.Rows.Clear();
            LoadDG();
    }

    private void toolStripButton4_Click(object sender, EventArgs e)
    {
            DataGridViewRow row = dgItems2.Rows[dgItems2.CurrentRow.Index]; //dethunter12 adjust 1 remove item from luckydraw result.
           //databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_luckydrawResult WHERE a_index ='" + Convert.ToString(dgItems2.Rows[dgItems2.CurrentRow.Index].Cells["Column10"].Value) + "'");
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_luckydrawResult WHERE a_index ='" + Convert.ToString(row.Cells["Column10"].Value) + "'");
            dgItems2.Rows.Clear(); //dethunter12 test delete removed  from ui window
            LoadDG();
            LoadDG2(); // delete remove fix (needed to reload the elements from luckydrawresult)
    }
        public static int[] ItemPicker2 { get; set; }

        public static List<ItemPicker2_items> ItemPicker2Listt = new List<ItemPicker2_items>();
        private void toolStripButton3_Click(object sender, EventArgs e)
    {
            ItemPicker2Listt.Clear();
          try
      {
              
                ItemPicker2 itemPicker = new ItemPicker2(); //dethunter12 add  3/29/2019
                if (itemPicker.ShowDialog() != DialogResult.OK)
                    return;
                int ItemIDx;
                int ItemAmnt;
               
                for (int i = 0; i < ItemPicker2Listt.Count; i++)
                {
                    ItemAmnt = itemPicker.ItemAmount; //dethunter12 adjust 5/30/2020
                    if (ItemAmnt == -1 || ItemAmnt <= 0)
                        ItemAmnt = 1;
                    ItemIDx = ItemPicker2Listt[i].ID;
                    databaseHandle.SendQueryMySql(Host, User, Password, Database, "INSERT INTO t_luckydrawResult (a_luckydraw_idx, a_item_idx, a_count, a_upgrade, a_prob, a_flag) VALUES (" + textBox1.Text + ", " + ItemIDx + ", " + ItemAmnt + ", " + "0, 0, 0)");//     
                }
               
                dgItems2.Rows.Clear();
                LoadDG2();

            }
      catch
      {
        int num = (int) MessageBox.Show("Duplicated ItemID isn't allowed.", "Error");
      }
           
    }

    private void toolStripButton2_Click(object sender, EventArgs e) //save1 Result
    {
            //column 12 = item id
      DataGridViewRow row = dgItems2.Rows[dgItems2.CurrentRow.Index];
      string str = Convert.ToString(row.Cells["Column10"].Value);
      Convert.ToString(row.Cells["Column11"].Value);
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_luckydrawResult SET " + "a_item_idx = '" + Convert.ToString(row.Cells["Column12"].Value) + "', " + "a_count = '" + Convert.ToString(row.Cells["Column14"].Value) + "', " + "a_upgrade = '" + Convert.ToString(row.Cells["Column15"].Value) + "', " + "a_prob = '" + Convert.ToString(row.Cells["Column16"].Value) + "', " + "a_flag = '" + Convert.ToString(row.Cells["Column17"].Value) + "' " + "WHERE a_index = '" + str + "' ");
            dgItems2.Rows.Clear();
            LoadDG2();
    }

    private void button1_Click(object sender, EventArgs e)
    {
           
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "INSERT INTO t_luckydrawbox DEFAULT VALUES");
            LoadListBox();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      int selectedIndex = listBox1.SelectedIndex;
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_luckydrawbox WHERE a_index = '" + textBox1.Text + "'");
            LoadListBox();
            listBox1.SelectedIndex = selectedIndex - 1;
            int num4 = (int)new CustomMessage("Deleted :O").ShowDialog();
        }

    private void button3_Click(object sender, EventArgs e)
    {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_luckydrawbox SET " + "a_name = '" + textBox2.Text + "', " + "a_enable = '" + textBox3.Text + "', " + "a_random = '" + textBox4.Text + "' " + "WHERE a_index = '" + textBox1.Text + "'");
      int selectedIndex = listBox1.SelectedIndex;
            LoadListBox();
            listBox1.SelectedIndex = selectedIndex;
            int num4 = (int)new CustomMessage("Done :)").ShowDialog();
        }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBox1.Checked)
                textBox3.Text = "1";
      else
                textBox3.Text = "0";
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void dgItems2_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      string comboBox = "";
      foreach (object checkedItem in checkedListBox1.CheckedItems)
        comboBox = checkedItem.ToString();
            textBox4.Text = GetIndexByComboBox(comboBox).ToString();
    }

    private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      if (e.NewValue != CheckState.Checked)
        return;
      for (int index = 0; index < checkedListBox1.Items.Count; ++index)
      {
        if (e.Index != index)
                    checkedListBox1.SetItemChecked(index, false);
      }
    }

    public void LoadMisc()
    {
      string text = textBox4.Text;
      for (int index = 0; index < checkedListBox1.Items.Count; ++index)
      {
        int num = checkedListBox1.FindString(text);
        if (index == num)
                    checkedListBox1.SetItemChecked(index, true);
      }
    }

    private void textBox4_TextChanged(object sender, EventArgs e)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LuckyDrawBoxTool));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnDeleteSelected = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddItems = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgItems2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 719);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 774);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boxes";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(117, 745);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(7, 745);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(816, 763);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(241, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 77);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "0 - Prob",
            "1 - Random",
            "2 - All"});
            this.checkedListBox1.Location = new System.Drawing.Point(347, 16);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(184, 45);
            this.checkedListBox1.TabIndex = 51;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(157, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Enable";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Index:";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(54, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(287, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(54, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(799, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enable:";
            this.label3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(852, 62);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(51, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.Visible = false;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(796, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Random:";
            this.label2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(855, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(48, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.dgItems);
            this.groupBox4.Controls.Add(this.toolStrip2);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(441, 570);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Need Items";
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
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgItems.EnableHeadersVisualStyles = false;
            this.dgItems.Location = new System.Drawing.Point(3, 16);
            this.dgItems.Name = "dgItems";
            this.dgItems.RowHeadersVisible = false;
            this.dgItems.RowTemplate.Height = 32;
            this.dgItems.Size = new System.Drawing.Size(435, 526);
            this.dgItems.TabIndex = 0;
            this.dgItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItems_CellContentClick);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "";
            this.Column7.Name = "Column7";
            this.Column7.Width = 32;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "BoxID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ItemID";
            this.Column2.Name = "Column2";
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 275;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Count";
            this.Column4.Name = "Column4";
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Index";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
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
            this.toolStrip2.Location = new System.Drawing.Point(3, 542);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(435, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
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
            this.btnAddItems.Size = new System.Drawing.Size(60, 22);
            this.btnAddItems.Text = "Add Item";
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
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.dgItems2);
            this.groupBox3.Controls.Add(this.toolStrip1);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(614, 622);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result Items";
            // 
            // dgItems2
            // 
            this.dgItems2.AllowUserToAddRows = false;
            this.dgItems2.AllowUserToDeleteRows = false;
            this.dgItems2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgItems2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgItems2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column10});
            this.dgItems2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgItems2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgItems2.EnableHeadersVisualStyles = false;
            this.dgItems2.Location = new System.Drawing.Point(3, 16);
            this.dgItems2.Name = "dgItems2";
            this.dgItems2.RowHeadersVisible = false;
            this.dgItems2.RowTemplate.Height = 32;
            this.dgItems2.Size = new System.Drawing.Size(608, 578);
            this.dgItems2.TabIndex = 0;
            this.dgItems2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItems2_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 32;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "BoxID";
            this.Column11.Name = "Column11";
            this.Column11.Visible = false;
            this.Column11.Width = 60;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "ItemID";
            this.Column12.Name = "Column12";
            this.Column12.Width = 60;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Name";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 290;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Count";
            this.Column14.Name = "Column14";
            this.Column14.Width = 60;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Upgrade";
            this.Column15.Name = "Column15";
            this.Column15.Width = 60;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Prob";
            this.Column16.Name = "Column16";
            this.Column16.Width = 50;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Flag";
            this.Column17.Name = "Column17";
            this.Column17.Width = 35;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Index";
            this.Column10.Name = "Column10";
            this.Column10.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(3, 594);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(608, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton2.Text = "Save Item";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton3.Text = "Add Item";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(91, 22);
            this.toolStripButton4.Text = "Delete Selected";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(241, 95);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 662);
            this.tabControl1.TabIndex = 46;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(628, 636);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Result Items";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(628, 636);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Need Items";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 789);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(952, 22);
            this.statusStrip1.TabIndex = 50;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // LuckyDrawBoxTool
            // 
            this.ClientSize = new System.Drawing.Size(952, 811);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LuckyDrawBoxTool";
            this.Text = "LuckyDrawBox Editor V1.01 By Dethunter12 & Maykom";
            this.Load += new System.EventHandler(this.LuckyDrawBoxTool_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
  }
}
