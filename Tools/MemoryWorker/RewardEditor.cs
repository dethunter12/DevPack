//
// Type: LcDevPack_TeamDamonA.Tools.MemoryWorker.RewardEditor
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 31A1F430-D7EB-43B7-9A84-1AAE93231337
//

using MySql.Data.MySqlClient;
using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools.MemoryWorker
{
  public class RewardEditor : Form
  {
      public static Connection connection = new Connection();
      private string Host = RewardEditor.connection.ReadSettings("Host");
      private string User = RewardEditor.connection.ReadSettings("User");
      private string Password = RewardEditor.connection.ReadSettings("Password");
      private string Database = RewardEditor.connection.ReadSettings("Database");
      private DatabaseHandle databaseHandle = new DatabaseHandle();
      public string _ClientPath = RewardEditor.connection.ReadSettings("ClientPath");
      public string rowName = "a_index";
      public System.Collections.Generic.List<string> MenuList = new System.Collections.Generic.List<string>();
      public string[] menuArray = new string[2]
    {
      "a_reward_idx",
      "a_desc"
    };
      private DataTable table = new DataTable();
      private DataTable table2 = new DataTable();    
      private MySqlCommand command;
      private MySqlDataAdapter adapter;
      private BindingManagerBase managerBase;
      private BindingManagerBase managerBase2;
      private MySqlCommandBuilder builder;
    private IContainer components = (IContainer) null;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem importFromDatabaseToolStripMenuItem;
    private ToolStripMenuItem saveToolStripMenuItem;
    private ToolStripMenuItem extraToolStripMenuItem;
    private GroupBox groupBox2;
    private ListBox listBox1;
    private GroupBox groupBox1;
    private TextBox textBox1;
    private GroupBox groupBox4;
    private DataGridView dgItems;
    private TextBox textBox2;
    private TextBox textBox3;
    private TextBox textBox4;
    private TextBox textBox5;
    private GroupBox groupBox3;
    private TextBox textBox7;
    private Label label2;
    private TextBox textBox6;
    private Label label1;
    private CheckedListBox checkedListBox1;
    private TextBox textBox8;
    private GroupBox groupBox21;
    
    private CheckedListBox checkedListBox2;
    private TextBox textBox9;
    private GroupBox groupBox5;
    private Label label3;
    private ComboBox comboBox1;
    private Label label4;
    private Button button4;
    private TextBox textBox26;
    private Label label15;
    private TextBox textBox24;
    private TextBox textBox11;
    private Label label6;
    private TextBox textBox10;
    private Label label5;
    private TextBox textBox25;
    private Label label16;
    private GroupBox groupBox6;
    private TextBox textBox13;
    private Label label7;
    private TextBox textBox12;
    private GroupBox groupBox7;
    private TextBox textBox14;
    private Button button12;
    private Button button9;
    private Button button6;
    private Button button17;
    private Button button18;
    private Button button19;
    private TextBox textBox15;
    private TextBox textBox16;
    private CheckBox checkBox1;
    private PictureBox pictureBox7;
    private Label label9;
    private Label label12;
    private Label label11;
    private Label label10;
    private TextBox textBox17;
    private DataGridViewImageColumn Icon;
    private DataGridViewTextBoxColumn PrimaryKey;
    private DataGridViewTextBoxColumn RewardID;
    private DataGridViewTextBoxColumn Type;
    private DataGridViewTextBoxColumn ItemID;
    private DataGridViewTextBoxColumn Value1;
    private DataGridViewTextBoxColumn Value2;
    private DataGridViewTextBoxColumn Value3;
    private DataGridViewTextBoxColumn JobFlag;
    private DataGridViewTextBoxColumn MinLevel;
    private DataGridViewTextBoxColumn MaxLevel;
    private DataGridViewTextBoxColumn Prob;
    private Label label8;

        private void IniRead()
    {
        IniFile iniFile = new IniFile(Application.StartupPath + "\\Config\\Settings.cfg");
        this.textBox2.Text = iniFile.IniReadValue("## MYSQL", "SQL_HOST");
        this.textBox3.Text = iniFile.IniReadValue("## MYSQL", "SQL_USER");
        this.textBox4.Text = iniFile.IniReadValue("## MYSQL", "SQL_PASSWORD");
        this.textBox5.Text = iniFile.IniReadValue("## MYSQL", "SQL_DATABASE");
        
    }
    public RewardEditor()
    {
      this.InitializeComponent();
      this.MakeList();
    }
 
    public void MakeList()
    {
        listBox1.SelectedIndex = -1;
        MenuList.Clear();


        string connectionString = "datasource=" + this.Host + ";port=3306;username=" + this.User + ";password=" + this.Password + ";database=" + this.Database;
        string Query = "SELECT * FROM t_reward_head ORDER BY a_reward_idx ASC;";
        listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, Query);
        for (int index = 0; index < listBox1.Items.Count; ++index)
            MenuList.Add(listBox1.Items[index].ToString());
        listBox1.DataSource = MenuList;
        listBox1.SelectedIndex = -1;

    }
    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        ClearBox();
        if (listBox1.SelectedIndex != -1)
            textBox6.Text = GetIndex().ToString();
        string Query = "select a_reward_idx, a_desc, a_rand_type from t_reward_head WHERE a_reward_idx ='" + textBox6.Text + "';";
        string[] rows = new string[3]
      {
        "a_reward_idx",
        "a_desc",
        "a_rand_type"

      };
        Query.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'");
        string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query, rows);
        textBox6.Text = strArray[0];
        textBox7.Text = strArray[1];
        textBox8.Text = strArray[2];
        LoadMisc();
        FillGrid();
        this.textBox25.Text = "0";
        this.textBox10.Text = "0";
        this.textBox11.Visible = true;
        this.textBox12.Text = "0";
        this.textBox13.Text = "999";
        this.textBox14.Text = "10000";
        //this.textBox15.Text = "511";
        this.label4.Visible = true;
        this.button4.Visible = true;
        this.label15.Visible = true;
        this.textBox24.Visible = true;
        this.label16.Visible = true;
        this.textBox25.Visible = true;
        this.textBox26.Visible = true;
        this.label5.Visible = true;
        this.textBox10.Visible = true;
        this.label12.Visible = true;
        this.label6.Visible = true;
        label4.Text = "Item Id:";
        label16.Text = "Plus:";

    }
    private void ShowRandom(int flag)
    {
        for (int index = 0; index < this.checkedListBox1.Items.Count; ++index)
        {
            if ((uint)flag > 0U)
                this.checkedListBox1.SetItemChecked(index, true);
            else
                this.checkedListBox1.SetItemChecked(index, false);
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

    private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string comboBox = "";
        foreach (object checkedItem in this.checkedListBox1.CheckedItems)
            comboBox = checkedItem.ToString();
        this.textBox8.Text = this.GetIndexByComboBox(comboBox).ToString();
    }
    private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
    {
        if (e.NewValue != CheckState.Checked)
            return;
        for (int index = 0; index < this.checkedListBox1.Items.Count; ++index)
        {
            if (e.Index != index)
                this.checkedListBox1.SetItemChecked(index, false);
        }
    }
    public void LoadMisc()
    {
        string text = this.textBox8.Text;
        for (int index = 0; index < this.checkedListBox1.Items.Count; ++index)
        {
            int num = this.checkedListBox1.FindString(text);
            if (index == num)
                this.checkedListBox1.SetItemChecked(index, true);
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
    private int GetID()
    {
      int result = -1;
      int.TryParse(this.listBox1.Text.Split(' ')[0], out result);
      return result;
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void RewardEditor_Load(object sender, EventArgs e)
    {
      mySQL.SetConnection();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      this.MakeList();
    }



    private void LoadDataGrid()
    {
    }

    private void FillGrid()
    {
        dgItems.Rows.Clear();
        string str1 = "SELECT * FROM t_reward_data WHERE a_reward_idx = '" + textBox6.Text + "'";
        string[] strArray = new string[11]
      {
        "a_primarykey",
        "a_reward_idx",
        "a_type",
        "a_idx",
        "a_value_1",
        "a_value_2",
        "a_value_3",
        "a_job_flag",
        "a_level_mini",
        "a_level_maxi",
        "a_prob"
      };
        MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
        MySqlCommand command = mySqlConnection.CreateCommand();
        command.CommandText = str1;
        mySqlConnection.Open();
        MySqlDataReader mySqlDataReader = command.ExecuteReader();
        while (mySqlDataReader.Read())
        {
            int ordinal1 = mySqlDataReader.GetOrdinal("a_primarykey");
            int ordinal2 = mySqlDataReader.GetOrdinal("a_reward_idx");
            int ordinal3 = mySqlDataReader.GetOrdinal("a_type");
            int ordinal4 = mySqlDataReader.GetOrdinal("a_idx");
            int ordinal5 = mySqlDataReader.GetOrdinal("a_value_1");
            int ordinal6 = mySqlDataReader.GetOrdinal("a_value_2");
            int ordinal7 = mySqlDataReader.GetOrdinal("a_value_3");
            int ordinal8 = mySqlDataReader.GetOrdinal("a_job_flag");
            int ordinal9 = mySqlDataReader.GetOrdinal("a_level_mini");
            int ordinal10 = mySqlDataReader.GetOrdinal("a_level_maxi");
            int ordinal11 = mySqlDataReader.GetOrdinal("a_prob");
            string str2 = mySqlDataReader.GetString(ordinal4);
            string str3 = mySqlDataReader.GetString(ordinal5);
            string str4 = mySqlDataReader.GetString(ordinal1);
            string str5 = mySqlDataReader.GetString(ordinal2);
            string str6 = mySqlDataReader.GetString(ordinal3);
            //string str7 = databaseHandle.ItemNameFast(Convert.ToInt32(str2));
            string str8 = mySqlDataReader.GetString(ordinal6);
            string str9 = mySqlDataReader.GetString(ordinal7);
            string str10 = mySqlDataReader.GetString(ordinal8);
            string str11 = mySqlDataReader.GetString(ordinal9);
            string str12 = mySqlDataReader.GetString(ordinal10);
            string str13 = mySqlDataReader.GetString(ordinal11);
            if (str6 == "5")
            {
                dgItems.Rows.Add(databaseHandle.SkillsFast(Convert.ToInt32(str2)), str4, str5, str6, str2, str3, str8, str9, str10, str11, str12, str13);

            }
            else
            {
                dgItems.Rows.Add(databaseHandle.IconFast(Convert.ToInt32(str2)), str4, str5, str6, str2, str3, str8, str9, str10, str11, str12, str13);            
            }
        }
 
        mySqlConnection.Close();
    }
    private void dgItems_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
            return;
        DataGridViewRow row = this.dgItems.Rows[e.RowIndex];
        this.textBox16.Text = row.Cells["Type"].Value.ToString();
        this.textBox26.Text = row.Cells["ItemID"].Value.ToString();
        this.textBox25.Text = row.Cells["Value1"].Value.ToString();
        this.textBox10.Text = row.Cells["Value2"].Value.ToString();
        this.textBox11.Text = row.Cells["Value3"].Value.ToString();
        this.textBox15.Text = row.Cells["JobFlag"].Value.ToString();
        this.textBox12.Text = row.Cells["MinLevel"].Value.ToString();
        this.textBox13.Text = row.Cells["MaxLevel"].Value.ToString();
        this.textBox14.Text = row.Cells["Prob"].Value.ToString();
        this.textBox17.Text = row.Cells["PrimaryKey"].Value.ToString();

        this.comboBox1.SelectedIndex = int.Parse(this.textBox16.Text);
        int int32 = Convert.ToInt32(textBox15.Text);
        this.ShowJobFlag(int32);
    }
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }
    private void ShowJobFlag(int flag)
    {
        for (int index = 0; index < this.checkedListBox2.Items.Count; ++index)
            this.checkedListBox2.SetItemChecked(index, (flag & 1 << index) > 0);
    }
    private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
        int num = 0;
        for (int index = 0; index < this.checkedListBox2.Items.Count; ++index)
        {
            if (this.checkedListBox2.GetItemChecked(index))
                num += 1 << index;
        }
        this.textBox15.Text = num.ToString();
 //       if (this.textBox15.Text == "511")
  //          this.checkBox1.Checked = true;
  //      else
 //           this.checkBox1.Checked = false;
    }
    private void checkedListBox2_SelectedValueChanged(object sender, EventArgs e)
    {
        this.textBox15.BackColor = Color.Pink;
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.textBox16.Text = this.comboBox1.SelectedIndex.ToString();
        if (this.textBox16.Text == "0")
        {
            this.textBox25.Text = "0";
            this.textBox10.Text = "0";
            this.textBox11.Visible = true;
            this.textBox12.Text = "0";
            this.textBox13.Text = "999";
            this.textBox14.Text = "10000";
            //this.textBox15.Text = "511";
            this.label4.Visible = true;
            this.button4.Visible = true;
            this.label15.Visible = true;
            this.textBox24.Visible = true;
            this.label16.Visible = true;
            this.textBox25.Visible = true;
            this.textBox26.Visible = true;
            this.label5.Visible = true;
            this.textBox10.Visible = true;
            this.label12.Visible = true;
            this.label6.Visible = true;
        }
        else if (this.textBox16.Text == "1")
        {
            this.textBox26.Text = "-1";
            this.textBox25.Text = "0";
            this.textBox10.Text = "0";
            this.textBox11.Visible = true;
            this.textBox12.Text = "0";
            this.textBox13.Text = "999";
            this.textBox14.Text = "10000";
           // this.textBox15.Text = "511";
            this.label4.Visible = false;
            this.button4.Visible = false;
            this.label15.Visible = false;
            this.textBox24.Visible = false;
            this.label16.Visible = false;
            this.textBox25.Visible = false;
            this.textBox26.Visible = false;
            this.label5.Visible = false;
            this.textBox10.Visible = false;
            pictureBox7.Image = (Image)null;
            this.label10.Visible = false;
            this.label11.Visible = false;
            this.label12.Visible = true;
            this.label6.Visible = true;
        }
        else if (this.textBox16.Text == "2")
        {
            this.textBox26.Text = "-1";
            this.textBox25.Text = "0";
            this.textBox10.Text = "0";
            this.textBox11.Visible = true;
            this.textBox12.Text = "0";
            this.textBox13.Text = "999";
            this.textBox14.Text = "10000";
          //  this.textBox15.Text = "511";
            this.label4.Visible = false;
            this.button4.Visible = false;
            this.label15.Visible = false;
            this.textBox24.Visible = false;
            this.label16.Visible = false;
            this.textBox25.Visible = false;
            this.textBox26.Visible = false;
            this.label5.Visible = false;
            this.textBox10.Visible = false;
            pictureBox7.Image = (Image)null;
            this.label10.Visible = false;
            this.label11.Visible = false;
            this.label12.Visible = true;
            this.label6.Visible = true;
        }
        else if (this.textBox16.Text == "3")
        {
            this.textBox26.Text = "-1";
            this.textBox25.Text = "0";
            this.textBox10.Text = "0";
            this.textBox11.Visible = true;
            this.textBox12.Text = "0";
            this.textBox13.Text = "999";
            this.textBox14.Text = "10000";
           // this.textBox15.Text = "511";
            this.label4.Visible = false;
            this.button4.Visible = false;
            this.label15.Visible = false;
            this.textBox24.Visible = false;
            this.label16.Visible = false;
            this.textBox25.Visible = false;
            this.textBox26.Visible = false;
            this.label5.Visible = false;
            this.textBox10.Visible = false;
            pictureBox7.Image = (Image)null;
            this.label10.Visible = false;
            this.label11.Visible = false;
            this.label12.Visible = true;
            this.label6.Visible = true;
        }
        else if (this.textBox16.Text == "4")
        {
            this.textBox26.Text = "-1";
            this.textBox25.Text = "0";
            this.textBox10.Text = "0";
            this.textBox11.Visible = true;
            this.textBox12.Text = "0";
            this.textBox13.Text = "999";
            this.textBox14.Text = "10000";
           // this.textBox15.Text = "511";
            this.label4.Visible = false;
            this.button4.Visible = false;
            this.label15.Visible = false;
            this.textBox24.Visible = false;
            this.label16.Visible = false;
            this.textBox25.Visible = false;
            this.textBox26.Visible = false;
            this.label5.Visible = false;
            this.textBox10.Visible = false;
            pictureBox7.Image = (Image)null;
            this.label10.Visible = false;
            this.label11.Visible = false;
            this.label12.Visible = true;
            this.label6.Visible = true;
        }
        else if (this.textBox16.Text == "5")
        {
            label4.Text = "Skill Id:";
            label16.Text = "Lv.:";
          //  this.textBox26.Text = "-1";
           // this.textBox25.Text = "0";
            this.textBox10.Text = "0";
            //this.textBox11.Text = "1";
            this.textBox12.Text = "0";
            this.textBox13.Text = "999";
            this.textBox14.Text = "10000";
           // this.textBox15.Text = "511";
            this.label5.Visible = false;
         //   this.button4.Visible = false;
            this.label11.Visible = false;
           // this.textBox24.Visible = false;
            this.label6.Visible = false;
          //  this.textBox25.Visible = false;
          //  this.textBox26.Visible = false;
            this.textBox11.Visible = false;
            // this.label16.Visible = false;
            this.label12.Visible = false;
            this.textBox10.Visible = false;
           // pictureBox7.Image = (Image)null;
         //   this.label10.Visible = false;
         //   this.label11.Visible = false;
              this.label12.Visible = false;
        }
    }
         private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox1.Checked)
        {
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.SetItemChecked(i, true);
                this.textBox15.Text = "511";
            }
        }
        else
        {
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.SetItemChecked(i, false);
                this.textBox15.Text = "0";
            }
        }

    }
    private void checkBox1_SelectedValueChanged(object sender, EventArgs e)
    {
        this.textBox15.BackColor = Color.Pink;
    }
    private void textBox15_TextChanged(object sender, EventArgs e)
    {
    //    int num = int.Parse(this.textBox15.Text);
    //    for (int i = 0; i < checkedListBox2.Items.Count; i++)
    //   {
     //       checkedListBox2.SetItemChecked(i, true);
     //       num += 1 << i;
            //this.textBox15.Text = "511";
     //   }

    }
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RewardEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.Icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.PrimaryKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RewardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.extraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFromDatabaseToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importFromDatabaseToolStripMenuItem
            // 
            this.importFromDatabaseToolStripMenuItem.Name = "importFromDatabaseToolStripMenuItem";
            this.importFromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importFromDatabaseToolStripMenuItem.Text = "Load from Database";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // extraToolStripMenuItem
            // 
            this.extraToolStripMenuItem.Enabled = false;
            this.extraToolStripMenuItem.Name = "extraToolStripMenuItem";
            this.extraToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.extraToolStripMenuItem.Text = "Extra";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button17);
            this.groupBox2.Controls.Add(this.button18);
            this.groupBox2.Controls.Add(this.button19);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 565);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reward Head list";
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.LightCoral;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Image = global::LcDevPack_TeamDamonA.Properties.Resources.delete;
            this.button17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button17.Location = new System.Drawing.Point(174, 512);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(65, 27);
            this.button17.TabIndex = 103;
            this.button17.Text = "    Delete";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.LightCyan;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Image = global::LcDevPack_TeamDamonA.Properties.Resources._08;
            this.button18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button18.Location = new System.Drawing.Point(96, 512);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(72, 27);
            this.button18.TabIndex = 102;
            this.button18.Text = "      Update";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Plum;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Image = global::LcDevPack_TeamDamonA.Properties.Resources.control_add_blue;
            this.button19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button19.Location = new System.Drawing.Point(19, 512);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(71, 27);
            this.button19.TabIndex = 101;
            this.button19.Text = "     Add";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 485);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.dgItems);
            this.groupBox4.Location = new System.Drawing.Point(274, 103);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(644, 248);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rewards";
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
            this.dgItems.AllowUserToDeleteRows = false;
            this.dgItems.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Icon,
            this.PrimaryKey,
            this.RewardID,
            this.Type,
            this.ItemID,
            this.Value1,
            this.Value2,
            this.Value3,
            this.JobFlag,
            this.MinLevel,
            this.MaxLevel,
            this.Prob});
            this.dgItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgItems.EnableHeadersVisualStyles = false;
            this.dgItems.Location = new System.Drawing.Point(3, 16);
            this.dgItems.Name = "dgItems";
            this.dgItems.RowHeadersVisible = false;
            this.dgItems.RowTemplate.Height = 32;
            this.dgItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItems.Size = new System.Drawing.Size(638, 229);
            this.dgItems.TabIndex = 0;
            this.dgItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItems_CellClick);
            // 
            // Icon
            // 
            this.Icon.HeaderText = "";
            this.Icon.Name = "Icon";
            this.Icon.Width = 32;
            // 
            // PrimaryKey
            // 
            this.PrimaryKey.HeaderText = "Index";
            this.PrimaryKey.Name = "PrimaryKey";
            this.PrimaryKey.Visible = false;
            this.PrimaryKey.Width = 60;
            // 
            // RewardID
            // 
            this.RewardID.HeaderText = "RewardID";
            this.RewardID.Name = "RewardID";
            this.RewardID.Visible = false;
            this.RewardID.Width = 70;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.Width = 50;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            this.ItemID.Width = 70;
            // 
            // Value1
            // 
            this.Value1.HeaderText = "Value1";
            this.Value1.Name = "Value1";
            this.Value1.Width = 50;
            // 
            // Value2
            // 
            this.Value2.HeaderText = "Value2";
            this.Value2.Name = "Value2";
            this.Value2.Width = 50;
            // 
            // Value3
            // 
            this.Value3.HeaderText = "Value3";
            this.Value3.Name = "Value3";
            // 
            // JobFlag
            // 
            this.JobFlag.HeaderText = "JobFlag";
            this.JobFlag.Name = "JobFlag";
            this.JobFlag.Width = 70;
            // 
            // MinLevel
            // 
            this.MinLevel.HeaderText = "MinLevel";
            this.MinLevel.Name = "MinLevel";
            this.MinLevel.Width = 70;
            // 
            // MaxLevel
            // 
            this.MaxLevel.HeaderText = "MaxLevel";
            this.MaxLevel.Name = "MaxLevel";
            this.MaxLevel.Width = 70;
            // 
            // Prob
            // 
            this.Prob.HeaderText = "Prob";
            this.Prob.Name = "Prob";
            this.Prob.Width = 70;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(646, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(27, 20);
            this.textBox2.TabIndex = 27;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(680, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(28, 20);
            this.textBox3.TabIndex = 28;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(714, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(27, 20);
            this.textBox4.TabIndex = 29;
            this.textBox4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(748, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(26, 20);
            this.textBox5.TabIndex = 30;
            this.textBox5.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkedListBox1);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(280, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(639, 70);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reward Setting";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "0 - Multi",
            "1 - Once-Random",
            "2 - Once-Select"});
            this.checkedListBox1.Location = new System.Drawing.Point(400, 19);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(94, 45);
            this.checkedListBox1.TabIndex = 52;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(87, 47);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(284, 20);
            this.textBox7.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desc";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(86, 17);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(45, 20);
            this.textBox6.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reward Index";
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(809, 3);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(55, 20);
            this.textBox8.TabIndex = 53;
            this.textBox8.Visible = false;
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.checkBox1);
            this.groupBox21.Controls.Add(this.textBox15);
            this.groupBox21.Controls.Add(this.label8);
            this.groupBox21.Controls.Add(this.checkedListBox2);
            this.groupBox21.Controls.Add(this.textBox9);
            this.groupBox21.Location = new System.Drawing.Point(274, 468);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(242, 155);
            this.groupBox21.TabIndex = 59;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Job Flag Setting";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 118);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 48;
            this.checkBox1.Text = "Check All";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(147, 94);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(55, 21);
            this.textBox15.TabIndex = 47;
            this.textBox15.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Total:";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox2.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.ColumnWidth = 105;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.IntegralHeight = false;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Titan",
            "Knight",
            "Healer",
            "Mage",
            "Rogue",
            "Sorcerer",
            "NS",
            "Ex-Rogue",
            "Ex-Mage"});
            this.checkedListBox2.Location = new System.Drawing.Point(12, 19);
            this.checkedListBox2.MultiColumn = true;
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(213, 96);
            this.checkedListBox2.TabIndex = 39;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            this.checkedListBox2.SelectedValueChanged += new System.EventHandler(this.checkedListBox2_SelectedValueChanged);
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Location = new System.Drawing.Point(47, 184);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(55, 20);
            this.textBox9.TabIndex = 12;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox17);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.pictureBox7);
            this.groupBox5.Controls.Add(this.textBox16);
            this.groupBox5.Controls.Add(this.textBox11);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.textBox10);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.textBox25);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.textBox24);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.textBox26);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(274, 357);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(641, 100);
            this.groupBox5.TabIndex = 60;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Reward Type Setting";
            // 
            // textBox17
            // 
            this.textBox17.Enabled = false;
            this.textBox17.Location = new System.Drawing.Point(8, 70);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(90, 20);
            this.textBox17.TabIndex = 53;
            this.textBox17.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label12.Location = new System.Drawing.Point(394, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "Value3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Location = new System.Drawing.Point(262, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Value2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(134, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Value1";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(194, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 32);
            this.pictureBox7.TabIndex = 49;
            this.pictureBox7.TabStop = false;
            // 
            // textBox16
            // 
            this.textBox16.Enabled = false;
            this.textBox16.Location = new System.Drawing.Point(8, 40);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(64, 20);
            this.textBox16.TabIndex = 48;
            this.textBox16.Visible = false;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(441, 62);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(167, 21);
            this.textBox11.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Count:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(308, 62);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(55, 21);
            this.textBox10.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Flag:";
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(184, 62);
            this.textBox25.Multiline = true;
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(55, 21);
            this.textBox25.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(144, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "Plus:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(424, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Name:";
            // 
            // textBox24
            // 
            this.textBox24.Enabled = false;
            this.textBox24.Location = new System.Drawing.Point(468, 12);
            this.textBox24.Multiline = true;
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(170, 21);
            this.textBox24.TabIndex = 40;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Image = global::LcDevPack_TeamDamonA.Properties.Resources.search__5_;
            this.button4.Location = new System.Drawing.Point(375, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 25);
            this.button4.TabIndex = 39;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox26
            // 
            this.textBox26.Enabled = false;
            this.textBox26.Location = new System.Drawing.Point(277, 14);
            this.textBox26.Multiline = true;
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(92, 21);
            this.textBox26.TabIndex = 38;
            this.textBox26.TextChanged += new System.EventHandler(this.textBox26_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Item ID:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.GreenYellow;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0 - Item",
            "1 - Nas",
            "2 - Exp",
            "3 - Skill Point",
            "4 - Stat Point",
            "5 - Skill"});
            this.comboBox1.Location = new System.Drawing.Point(82, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 21);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reward Type";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox13);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.textBox12);
            this.groupBox6.Location = new System.Drawing.Point(524, 468);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 50);
            this.groupBox6.TabIndex = 61;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Level Setting";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(136, 19);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(48, 20);
            this.textBox13.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "<= level<=";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(20, 20);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(48, 20);
            this.textBox12.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox14);
            this.groupBox7.Location = new System.Drawing.Point(749, 468);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(165, 50);
            this.groupBox7.TabIndex = 62;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Prob (10000 = 100%)";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(33, 20);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 3;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LightCoral;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Image = global::LcDevPack_TeamDamonA.Properties.Resources.delete;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(526, 567);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(77, 27);
            this.button12.TabIndex = 65;
            this.button12.Text = "    Delete";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightCyan;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = global::LcDevPack_TeamDamonA.Properties.Resources._08;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(621, 534);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(293, 60);
            this.button9.TabIndex = 64;
            this.button9.Text = "      Update";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Plum;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::LcDevPack_TeamDamonA.Properties.Resources.control_add_blue;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(526, 534);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(77, 27);
            this.button6.TabIndex = 63;
            this.button6.Text = "     Add";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(271, 636);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(591, 13);
            this.label9.TabIndex = 69;
            this.label9.Text = "JobFlags: Titan = 1 Knight = 2 Healer = 4 Mage+ArchMage =264 Rogue+ExRouge =144 S" +
    "orcerer = 32 NS = 64: 511 = ALL ";
            // 
            // RewardEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 669);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox21);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
         //   this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RewardEditor";
            this.Text = "RewardEditor by Kimpobin";
            this.Load += new System.EventHandler(this.RewardEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void button4_Click(object sender, EventArgs e)
    {
        if (this.textBox16.Text == "5")
        {
            SkillPicker SkillPicker = new SkillPicker();
            if (SkillPicker.ShowDialog() != DialogResult.OK)
                return;
            this.textBox26.Text = Convert.ToString(SkillPicker.SkillIndex);
        }
        else
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            this.textBox26.Text = Convert.ToString(itemPicker.ItemIndex);
        }
    }
    private void textBox26_TextChanged(object sender, EventArgs e)
    {
        if (this.textBox16.Text == "5")
        {
            label4.Text = "Skill Id";
            label16.Text = "Lv.";
            this.pictureBox7.Image = (Image)this.databaseHandle.SkillsFast(int.Parse(this.textBox26.Text.Trim()));
            this.textBox24.Text = this.databaseHandle.SkillNameFast(int.Parse(this.textBox26.Text.Trim()));
        }
        else 
        { 
        this.pictureBox7.Image = (Image)this.databaseHandle.IconFast(int.Parse(this.textBox26.Text.Trim()));
        this.textBox24.Text = this.databaseHandle.ItemNameFast(int.Parse(this.textBox26.Text.Trim()));
        }
    }

    private void button12_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Do you want to Delete Reward Item " + this.textBox26.Text.Trim() + "-" + this.textBox24.Text.Trim() + " ?", "Please confirm.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            return;
        int selectedIndex = listBox1.SelectedIndex;
        databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_reward_data WHERE a_primarykey = '" + textBox17.Text + "'");

        this.FillGrid();

        listBox1.SelectedIndex = selectedIndex;

        this.checkBox1.Checked = false;
        for (int i = 0; i < checkedListBox2.Items.Count; i++)
        {
            checkedListBox2.SetItemChecked(i, false);
        }
    }

    private void button9_Click(object sender, EventArgs e)
    {
        this.IniRead();
        int selectedIndex = listBox1.SelectedIndex;
        if (MessageBox.Show("Do you want to Change Reward to " + this.textBox24.Text.Trim() + " ?", "Please confirm.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            return;
        MySqlConnection connection = new MySqlConnection("datasource=" + this.textBox2.Text + ";port=3306;username=" + this.textBox3.Text + ";password=" + this.textBox4.Text);
        MySqlCommand mySqlCommand = new MySqlCommand("UPDATE " + this.textBox5.Text + ".t_reward_data SET a_reward_idx='" + this.textBox6.Text + "', a_type='" + this.textBox16.Text + "', a_idx='" + this.textBox26.Text + "', a_value_1='" + this.textBox25.Text + "', a_value_2='" + this.textBox10.Text + "', a_value_3='" + this.textBox11.Text + "', a_job_flag='" + this.textBox15.Text + "', a_level_mini='" + this.textBox12.Text + "', a_level_maxi='" + this.textBox13.Text + "', a_prob='" + this.textBox14.Text + "' WHERE a_primarykey='" + this.textBox17.Text + "'", connection);
        try
        {
            connection.Open();
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            int num = (int)MessageBox.Show("Your Reward is Saved!");
            while (mySqlDataReader.Read())
                ;
        }
        catch (Exception ex)
        {
            int num = (int)MessageBox.Show(ex.Message);
        }

        FillGrid();

        listBox1.SelectedIndex = selectedIndex;

        this.checkBox1.Checked = false;
        for (int i = 0; i < checkedListBox2.Items.Count; i++)
        {
            checkedListBox2.SetItemChecked(i, false);
        }
    }

    private void button6_Click(object sender, EventArgs e)
    {

        if (MessageBox.Show("Do you Add Reward ?", "Please confirm.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            return;
        if (comboBox1.SelectedIndex == -1)
        {

            int num = (int)MessageBox.Show("Do you Need Select Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
        }
        if (comboBox1.SelectedIndex == 0)
        {           
            if (Convert.ToInt32(this.textBox26.Text) <= 0)
            {
                int num = (int)MessageBox.Show("No Item to select", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (MessageBox.Show("Do you want add Item " + this.textBox26.Text.Trim() + "-" + this.textBox24.Text.Trim() + " ?", "Please confirm.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
        }
            

            if (comboBox1.SelectedIndex >= 1)
            {
               
                if (Convert.ToInt32(this.textBox11.Text) <= 0)
                {
                    int num = (int)MessageBox.Show("You need add value Count", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
            //    if (MessageBox.Show("Do you want add Value Type " + comboBox1.SelectedValue + " ?", "Please confirm.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            //        return;
            }
       
      
        else
        {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "INSERT INTO t_reward_data (a_reward_idx, a_type, a_idx, a_value_1, a_value_2, a_value_3, a_job_flag,a_level_mini,a_level_maxi,a_prob) VALUES (" + textBox6.Text + ", " + textBox16.Text + ", " + textBox26.Text + ", " + textBox25.Text + ", " + textBox10.Text + ", " + textBox11.Text + ", " + textBox15.Text + ",  " + textBox12.Text + ", " + textBox13.Text + ", " + textBox14.Text + ")");
            int num2 = (int)MessageBox.Show("Successful add new", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
            FillGrid();

            listBox1.SelectedIndex = listBox1.Items.Count - 1;

            this.checkBox1.Checked = false;
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.SetItemChecked(i, false);
            }
        }
    }

    private void button17_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Do you want to Delete Reward ID " + this.textBox6.Text.Trim() + "-" + this.textBox7.Text.Trim() + " ?", "Please confirm.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            return;
        int selectedIndex = listBox1.SelectedIndex;
        databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_reward_head WHERE a_reward_idx = '" + textBox6.Text + "'");
        databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_reward_data WHERE a_reward_idx = '" + textBox6.Text + "'");
        this.MakeList();

        listBox1.SelectedIndex = listBox1.Items.Count - 1;

    
    }

    private void button18_Click(object sender, EventArgs e)
    {
        this.IniRead();
        int selectedIndex = listBox1.SelectedIndex;
            //test comment
        if (MessageBox.Show("Do you want to Change Reward Head Data " + this.textBox24.Text.Trim() + " ?", "Please confirm.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            return;
        MySqlConnection connection = new MySqlConnection("datasource=" + this.Database + ";port=3306;username=" + this.User + ";password=" + this.Password);
        MySqlCommand mySqlCommand = new MySqlCommand("UPDATE " + this.textBox5.Text + ".t_reward_head SET a_desc='" + this.textBox7.Text + "', a_rand_type='" + this.textBox8.Text + "' WHERE a_reward_idx='" + this.textBox6.Text + "'", connection);
        try
        {
            connection.Open();
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            int num = (int)MessageBox.Show("Your Reward is Saved!");
            while (mySqlDataReader.Read())
                ;
        }
        catch (Exception ex)
        {
            int num = (int)MessageBox.Show(ex.Message);
        }

        this.MakeList();

        listBox1.SelectedIndex = selectedIndex;

       
    }

    private void button19_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Do you want add New Reward Head " + " ?", "Please confirm.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            return;
        if (this.textBox6.Text.Trim().Length <= 0)
        {
            int num = (int)MessageBox.Show("No data to select", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        else
        {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DROP TABLE IF EXISTS tempTable;CREATE TEMPORARY TABLE tempTable ENGINE=MEMORY SELECT * FROM t_reward_head WHERE a_reward_idx=" + this.textBox6.Text + ";SELECT a_reward_idx FROM tempTable;UPDATE tempTable SET a_reward_idx=(SELECT a_reward_idx from t_reward_head ORDER BY a_reward_idx DESC LIMIT 1)+1; SELECT a_reward_idx FROM tempTable;INSERT INTO t_reward_head SELECT * FROM tempTable;");
            int num2 = (int)MessageBox.Show("Successful Add new", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            this.MakeList();
            
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
    }
    private void ClearBox()
    {
        this.comboBox1.SelectedIndex = -1;
        pictureBox7.Image = (Image)null;
        textBox26.Text = "0";
        textBox25.Text = "0";
        textBox10.Text = "0";
        textBox11.Text = "1";
        textBox12.Text = "0";
        textBox13.Text = "999";
        textBox14.Text = "10000";
        textBox15.Clear();
        for (int i = 0; i < checkedListBox2.Items.Count; i++)
        {
            checkedListBox2.SetItemChecked(i, false);
        }
    }
  }
}
