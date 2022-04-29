// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.Tools.CatalogEditor
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using LcDevPack_TeamDamonA.Properties;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LcDevPack_TeamDamonA.Tools
{
  public class CatalogEditor : Form
  {
    public static Connection connection = new Connection();
    private string Host = CatalogEditor.connection.ReadSettings("Host");
    private string User = CatalogEditor.connection.ReadSettings("User");
    private string Password = CatalogEditor.connection.ReadSettings("Password");
    private string Database = CatalogEditor.connection.ReadSettings("Database");
    private DatabaseHandle databaseHandle = new DatabaseHandle();
    public string rowName = "a_ctid";
    public string CategoryHide = "0";
    public string SortCategoryValue = "-1";
    public string SwitchCheckBox = "-1";
    public int enabled = 1;
    public string[] menuArray = new string[2]
    {
      "a_ctid",
      "a_ctname"
    };
    private int tmpFlag = 0;
    private int tmpLimit = 0;
    private ExportLodHandle exportLodHandle = new ExportLodHandle();
    private IContainer components = (IContainer) null;
    public string name;
    public int index;
    public string test2;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileExportToolStripMenuItem;
    private ToolStripMenuItem exportlodToolStripMenuItem;
    private ListBox listBox1;
    private TextBox tbCatalogID;
    private TextBox tbName;
    private TextBox tbCategory;
    private TextBox tbType;
    private TextBox textBox5;
    private TextBox tbPrice;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label5;
    private Label label6;
    private TextBox tbDescr;
    private TextBox tbMileage;
    private Label label8;
    private Label label9;
    private TextBox tbEnable;
    private TextBox tbFlag;
    private TextBox tbIcon;
    private Label label10;
    private Label label11;
    private Label label12;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private GroupBox groupBox4;
    private DataGridView dgItems;
    private ToolStrip toolStrip2;
    private ToolStripButton btnAddItems;
    private ToolStripSeparator toolStripSeparator6;
    private ToolStripButton btnSaveSelected;
    private GroupBox groupBox3;
    private Button button1;
    private Button button3;
    private GroupBox groupBox5;
    private Label label7;
    private TextBox textBox12;
    private ToolStripButton btnCopy;
    private DataGridViewImageColumn Column7;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column4;
    private DataGridViewTextBoxColumn Column5;
    private DataGridViewTextBoxColumn Column6;
    private DataGridViewTextBoxColumn Column8;
    private DataGridViewTextBoxColumn Column9;
    private Button button2;
    private ToolStripSeparator toolStripSeparator1;
    private GroupBox groupBox6;
    private CheckedListBox clbFlagTest;
    private Button btnShowCat1;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button7;
    private Button button8;
    private Button button9;
    private GroupBox groupBox7;
    private Button button10;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel toolStripStatusLabel1;
    private GroupBox groupBox8;
    private CheckedListBox checkedListBox1;
    private GroupBox groupBox9;
    private CheckedListBox checkedListBox2;
    private Button button11;
    private CheckBox checkBox1;
    private Label label13;
    private ToolStripButton btnDelete;
    private ToolStripButton btnUpdateName;
        private Button btnCopyRec;
        private Button btnSaveAndNext;
        private CheckBox cbshowEnabled;
        private ToolTip toolTip1;
        private CheckBox cbEnabled;
        private TextBox tbLimit;

    public CatalogEditor()
    {
            InitializeComponent();
    }

    public void SearchList(string searchString)
    {
      searchString = searchString.Replace("\\", "\\\\").Replace("'", "\\'");
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_ctid, a_ctname from t_catalog WHERE a_ctname LIKE '%" + searchString + "%' ORDER BY a_ctid;");
    }

    public void SortCategory(string category)
    {
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_ctid, a_ctname from t_catalog WHERE a_category ='" + category + "'");
    }
    public void SortEnabled_Catagory(string category,int enabled)
        {
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_ctid, a_ctname from t_catalog WHERE a_category ='" + category + "'" + "AND a_enable =' " + enabled + "'");

        }
        public void LoadListBox()
        {
            if (cbshowEnabled.Checked == true && tbEnable.Text != "")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_ctid, a_ctname from t_catalog WHERE a_enable = '" + tbEnable.Text + "'" + " ORDER BY a_ctid;");
            }
            else
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_ctid, a_ctname from t_catalog WHERE a_enable = '1' ORDER BY a_ctid;");
            }
        }
    public Bitmap CropImage(Bitmap source, Rectangle section)
    {
      Bitmap bitmap = new Bitmap(section.Width, section.Height);
      Graphics.FromImage((Image) bitmap).DrawImage((Image) source, 0, 0, section, GraphicsUnit.Pixel);
      return bitmap;
    }

    private void Exporter_Catalog_Load(object sender, EventArgs e)
    {
            listBox1.Items.Clear();
            LoadStartUp();
            LoadListBox();
    }

    public void LoadMisc()
    {
      string text1 = tbCategory.Text;
      string text2 = tbType.Text;
      for (int index = 0; index < checkedListBox1.Items.Count; ++index)
      {
        int num = checkedListBox1.FindString(text1);
        if (index == num)
                    checkedListBox1.SetItemChecked(index, true);
      }
      for (int index = 0; index < checkedListBox2.Items.Count; ++index)
      {
        int num = checkedListBox2.FindString(text2);
        if (index == num)
                    checkedListBox2.SetItemChecked(index, true);
      }
            tbLimit.Text = tmpLimit.ToString();
    }

    public void LoadStartUp()
    {
            checkedListBox1.Items.AddRange(new object[9]
      {
         "0 - none",
         "999 - Credit Shop",
         "10000 - Hot & New",
         "20000 - Super Specials",
         "30000 - Potions",
         "40000 - Equipment",
         "50000 - Creatures",
         "60000 - Tickets",
         "70000 - Packages"
      });
            checkedListBox2.Items.AddRange(new object[31]
      {
         "0 - none",
         "10000 - Hot & New none",
         "10100 - Hot & New",
         "10200 - Hot & New discount",
         "10300 - Hot & New hot",
         "20000 - Platinium none",
         "30000 - Disposable none",
         "30100 - Disposable character grow",
         "30200 - Disposable ability buildup",
         "30300 - Disposable potion",
         "40000 - Equip none",
         "40100 - Equip equipment",
         "40200 - Equip buildup",
         "40300 - Equip costume",
         "50000 - Avatar none",
         "50100 - Avatar pet",
         "50200 - Avatar mercenary",
         "60000 - Service none",
         "60100 - Service conentience",
         "60200 - Service etc",
         "70000 - Package none",
         "70100 - Package boosters",
         "70200 - Package enhancements",
         "70300 - Package potions",
         "70400 - Package vanity",
         "70500 - Package upgrade",
         "70600 - Package pets",
         "70700 - Package mercenary",
         "70800 - Package convenience",
         "70900 - Package others",
         "90000 - Old Goods"
      });
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
                tbCatalogID.Text = GetIndex().ToString();
      string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, " select * from t_catalog WHERE a_ctid ='" + tbCatalogID.Text + "';", new string[11]
      {
        "a_ctid",
        "a_ctname",
        "a_category",
        "a_type",
        "a_subtype",
        "a_cash",
        "a_ctdesc",
        "a_mileage",
        "a_enable",
        "a_flag",
        "a_icon"
      });
            tbCatalogID.Text = strArray[0];
            tbName.Text = strArray[1];
            tbCategory.Text = strArray[2];
            tbType.Text = strArray[3];
            textBox5.Text = strArray[4];
            tbPrice.Text = strArray[5];
            tbDescr.Text = strArray[6];
            tbMileage.Text = strArray[7];
            tbEnable.Text = strArray[8];

            if (tbEnable.Text == "1")
            {
                cbEnabled.Checked = true;
                cbEnabled.Text = "Enabled";
            }
                
            else
            {
                cbEnabled.Checked = false;
                cbEnabled.Text = "Disabled";
            }
               

            tbFlag.Text = strArray[9];
            tbIcon.Text = strArray[10];
            ShowFlag(int.Parse(strArray[9]));
            ShowCategory(int.Parse(strArray[2]));
            dgItems.Rows.Clear();
            LoadDG();
            LoadMisc();
            SplitLimitFromFlag(int.Parse(strArray[9]));
    }

    private void ShowCategory(int CategoryID)
    {
    }

    private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "INSERT INTO t_catalog DEFAULT VALUES");
            //Catalog Modification Dethunter12 -t_catalog_1 - t_catalog_1_hardcore
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "INSERT INTO t_catalog_1 DEFAULT VALUES"); //dethunter12 add
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select * from t_catalog ORDER BY a_ctid;");
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      int selectedIndex = listBox1.SelectedIndex;
            
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_catalog WHERE a_ctid = '" + tbCatalogID.Text + "'");
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_catalog_1 WHERE a_ctid = '" + tbCatalogID.Text + "'"); //dethunter12 add
            //catalog Modification Dethunter12 Delete t_ct_item-t_ct_item_1
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_ct_item WHERE a_ctid = '" + tbCatalogID.Text + "'");
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_ct_item_1 WHERE a_ctid = '" + tbCatalogID.Text + "'"); //dethunter12 add
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select * from t_catalog ORDER BY a_ctid;");
            listBox1.SelectedIndex = selectedIndex - 1;
            int num5 = (int)new CustomMessage("Deleted").ShowDialog();
        }
    public static int[] ItemPicker2 { get; set; }

    public static List<ItemPicker2_items> ItemPicker2List = new List<ItemPicker2_items>();

    private void btnAddItems_Click(object sender, EventArgs e)
    {
         ItemPicker2List.Clear();

            ItemPicker2 itemPicker = new ItemPicker2(); //dethunter12 add  3/29/2019
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            int ItemIDx;
            int ItemAmnt;
            
            for (int i = 0; i < ItemPicker2List.Count; i++)
            {
                ItemAmnt = itemPicker.ItemAmount; //dethunter12 add 5/30/2020
                if (ItemAmnt == -1 || ItemAmnt <= 0)
                    ItemAmnt = 1;
                ItemIDx = ItemPicker2List[i].ID;
               
                //dethunter12 adjust t_ct_item_1
                databaseHandle.SendQueryMySql(Host, User, Password, Database, "INSERT INTO t_ct_item (a_ctid, a_item_idx, a_item_flag, a_item_plus, a_item_option, a_item_num) VALUES (" + tbCatalogID.Text + "," + ItemIDx + ", 0, 0, 0, " + ItemAmnt + " )");
                databaseHandle.SendQueryMySql(Host, User, Password, Database, "INSERT INTO t_ct_item_1 (a_ctid, a_item_idx, a_item_flag, a_item_plus, a_item_option, a_item_num) VALUES (" + tbCatalogID.Text + "," + ItemIDx + ", 0, 0, 0," + ItemAmnt + ")"); //dethunter12 add
            }
           

            //dethunter12 2/4/2020 adjust

            dgItems.Rows.Clear();
            LoadDG();
    }

    public void LoadDG()
    {
            toolStripStatusLabel1.Text = "Load Items ...";
      string str1 = " select * from t_ct_item WHERE a_ctid ='" + tbCatalogID.Text + "' ORDER BY a_index;";
      string[] strArray = new string[6]
      {
        "a_ctid",
        "a_item_idx",
        "a_item_flag",
        "a_item_plus",
        "a_item_option",
        "a_item_num"
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
        int int32 = Convert.ToInt32(str4);
                dgItems.Rows.Add(databaseHandle.IconFast(int32),  str4, databaseHandle.ItemNameFast(int32),  str8,  str6,  str7,  str5,  str2,  str3);
      }
      mySqlConnection.Close();
            toolStripStatusLabel1.Text = "Ready";
    }

    private void btnCopy_Click(object sender, EventArgs e)
    {
      
    }

    private void dgItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void btnSaveSelected_Click(object sender, EventArgs e)
    {
      DataGridViewRow row = dgItems.Rows[dgItems.CurrentRow.Index];
      string str1 = Convert.ToString(row.Cells["Column1"].Value);
      Convert.ToString(row.Cells["Column2"].Value);
      string str2 = Convert.ToString(row.Cells["Column3"].Value);
      string str3 = Convert.ToString(row.Cells["Column4"].Value);
      string str4 = Convert.ToString(row.Cells["Column5"].Value);
      string str5 = Convert.ToString(row.Cells["Column6"].Value);
      string str6 = Convert.ToString(row.Cells["Column8"].Value);
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_ct_item SET " + "a_ctid = '" + Convert.ToString(row.Cells["Column9"].Value) + "', " + "a_item_idx = '" + str1 + "', " + "a_item_flag = '" + str5 + "', " + "a_item_plus = '" + str3 + "', " + "a_item_option = '" + str4 + "', " + "a_item_num = '" + str2 + "' WHERE a_index ='" + str6 + "'");
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_ct_item_1 SET " + "a_ctid = '" + Convert.ToString(row.Cells["Column9"].Value) + "', " + "a_item_idx = '" + str1 + "', " + "a_item_flag = '" + str5 + "', " + "a_item_plus = '" + str3 + "', " + "a_item_option = '" + str4 + "', " + "a_item_num = '" + str2 + "' WHERE a_index ='" + str6 + "'"); //dethunter12 adjust
            dgItems.Rows.Clear();
            LoadDG();
    }

    private void button2_Click(object sender, EventArgs e)
    {
            //dethunter12 add t_catalog_1 - t_catalog_hardcore
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_catalog SET " + "a_ctname = '" + tbName.Text.Replace("'", "\\'") + "', " + "a_category = '" + tbCategory.Text + "', " + "a_type = '" + tbType.Text + "', " + "a_subtype = '" + textBox5.Text + "', " + "a_cash = '" + tbPrice.Text + "', " + "a_ctdesc = '" + tbDescr.Text.Replace("'", "\\'") + "', " + "a_mileage = '" + tbMileage.Text + "', " + "a_enable = '" + tbEnable.Text + "', " + "a_flag = '" + tbFlag.Text + "', " + "a_icon = '" + tbIcon.Text + "' " + "WHERE a_ctid = '" + tbCatalogID.Text + "'");
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_catalog_1 SET " + "a_ctname = '" + tbName.Text.Replace("'", "\\'") + "', " + "a_category = '" + tbCategory.Text + "', " + "a_type = '" + tbType.Text + "', " + "a_subtype = '" + textBox5.Text + "', " + "a_cash = '" + tbPrice.Text + "', " + "a_ctdesc = '" + tbDescr.Text.Replace("'", "\\'") + "', " + "a_mileage = '" + tbMileage.Text + "', " + "a_enable = '" + tbEnable.Text + "', " + "a_flag = '" + tbFlag.Text + "', " + "a_icon = '" + tbIcon.Text + "' " + "WHERE a_ctid = '" + tbCatalogID.Text + "'");
            int selectedIndex = listBox1.SelectedIndex;
            if (textBox12.Text != "")
            {
                SearchList(textBox12.Text);
            }
                
            else if (SortCategoryValue == "-1")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select * from t_catalog ORDER BY a_ctid;");

            }
             else
            {
                if (cbshowEnabled.Checked == true)
                {
                    SortEnabled_Catagory(SortCategoryValue, enabled);
                }
                else
                {
                    SortCategory(SortCategoryValue);
                }
               
            }
                
            listBox1.SelectedIndex = selectedIndex;
            int num5 = (int)new CustomMessage("Saved").ShowDialog();
        }

    private void exportlodToolStripMenuItem_Click(object sender, EventArgs e)
    {
            exportLodHandle.ExportCatalog_V4();
    }

    private void textBox12_TextChanged(object sender, EventArgs e)
    {
            SearchList(textBox12.Text);
    }

    private void clbFlagTest_SelectedIndexChanged(object sender, EventArgs e)
    {
      int num = 0;
      for (int index = 0; index < clbFlagTest.Items.Count; ++index)
      {
        if (clbFlagTest.GetItemChecked(index))
          num += 1 << index;
                tbFlag.Text = num.ToString();
      }
    }

    private void ShowFlag(int flag)
    {
      for (int index = 0; index < clbFlagTest.Items.Count; ++index)
      {
        if ((uint) (flag & 1 << index) > 0U)
                    clbFlagTest.SetItemChecked(index, true);
        else
                    clbFlagTest.SetItemChecked(index, false);
      }
    }

    private void clbFlagTest_MouseUp(object sender, MouseEventArgs e)
    {
      int num1 = 0;
      for (int index = 0; index < clbFlagTest.Items.Count; ++index)
      {
        if (clbFlagTest.GetItemChecked(index))
          num1 += 1 << index;
        int num2 = (int) MessageBox.Show(num1.ToString());
      }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
    }

    private void btnShowCat1_Click(object sender, EventArgs e)
        {
            
            SortCategoryValue = "10000";
            if (cbshowEnabled.Checked == true)
            {
                SortEnabled_Catagory(SortCategoryValue, enabled);
            }

            else
            {
                SortCategory("10000");
            }
           
    }

    private void button4_Click(object sender, EventArgs e)
    {
            SortCategoryValue = "20000";

            if (cbshowEnabled.Checked == true)
            {
                SortEnabled_Catagory(SortCategoryValue, enabled);
            }

            else
            {
                SortCategory("20000");
            }
        }

    private void button5_Click(object sender, EventArgs e)
    {
            SortCategoryValue = "30000";

            if (cbshowEnabled.Checked == true)
            {
                SortEnabled_Catagory(SortCategoryValue, enabled);
            }

            else
            {
                SortCategory("30000");
            }
        }

    private void button6_Click(object sender, EventArgs e)
    {
            SortCategoryValue = "40000";

            if (cbshowEnabled.Checked == true)
            {
                SortEnabled_Catagory(SortCategoryValue, enabled);
            }

            else
            {
                SortCategory("40000");
            }
        }

    private void button7_Click(object sender, EventArgs e)
    {
            SortCategoryValue = "50000";

            if (cbshowEnabled.Checked == true)
            {
                SortEnabled_Catagory(SortCategoryValue, enabled);
            }

            else
            {
                SortCategory("50000");
            }
        }

    private void groupBox7_Enter(object sender, EventArgs e)
    {
    }

    private void button8_Click(object sender, EventArgs e)
    {
            SortCategoryValue = "60000";

            if (cbshowEnabled.Checked == true)
            {
                SortEnabled_Catagory(SortCategoryValue, enabled);
            }

            else
            {
                SortCategory("60000");
            }
        }

    private void button9_Click(object sender, EventArgs e)
    {
            SortCategoryValue = "70000";

            if (cbshowEnabled.Checked == true)
            {
                SortEnabled_Catagory(SortCategoryValue, enabled);
            }

            else
            {
                SortCategory("70000");
            }
        }

    private void button10_Click(object sender, EventArgs e)
    {
            LoadListBox();
            SortCategoryValue = "-1";
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
      foreach (object checkedItem in checkedListBox1.CheckedItems)
        comboBox = checkedItem.ToString();
            tbCategory.Text = GetIndexByComboBox(comboBox).ToString();
    }

    private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      if (checkedListBox1.CheckedItems.Count != 1)
        return;
      if (e.CurrentValue == CheckState.Checked)
      {
        e.NewValue = CheckState.Checked;
      }
      else
      {
        int checkedIndex = checkedListBox1.CheckedIndices[0];
                checkedListBox1.ItemCheck -= new ItemCheckEventHandler(checkedListBox1_ItemCheck);
                checkedListBox1.SetItemChecked(checkedIndex, false);
                checkedListBox1.ItemCheck += new ItemCheckEventHandler(checkedListBox1_ItemCheck);
      }
    }

    private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      if (checkedListBox2.CheckedItems.Count != 1)
        return;
      if (e.CurrentValue == CheckState.Checked)
      {
        e.NewValue = CheckState.Checked;
      }
      else
      {
        int checkedIndex = checkedListBox2.CheckedIndices[0];
                checkedListBox2.ItemCheck -= new ItemCheckEventHandler(checkedListBox2_ItemCheck);
                checkedListBox2.SetItemChecked(checkedIndex, false);
                checkedListBox2.ItemCheck += new ItemCheckEventHandler(checkedListBox2_ItemCheck);
      }
    }

    private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      string comboBox = "";
      foreach (object checkedItem in checkedListBox2.CheckedItems)
        comboBox = checkedItem.ToString();
            tbType.Text = GetIndexByComboBox(comboBox).ToString();
            textBox5.Text = GetIndexByComboBox(comboBox).ToString();
    }

    private void groupBox8_Enter(object sender, EventArgs e)
    {
    }

    private void button11_Click(object sender, EventArgs e)
    {
            
            SortCategoryValue = "999";

            if (cbshowEnabled.Checked == true)
            {
                SortEnabled_Catagory(SortCategoryValue, enabled);
            }

            else
            {
                SortCategory("999");
            }
        }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
            SwitchCheckBox = "1";
    }

    private void textBox13_TextChanged(object sender, EventArgs e)
    {
      int.TryParse(tbLimit.Text, out tmpLimit);
            tbFlag.Text = JoinLimitWithFlag().ToString();
    }

    private void SplitLimitFromFlag(int flag)
    {
            tmpFlag = 0;
            tmpLimit = 0;
      for (int index = 0; index < 10; ++index)
      {
        if ((uint) (flag & 1 << index) > 0U)
                    tmpFlag = tmpFlag + (1 << index);
      }
      for (int index = 10; index < 32; ++index)
      {
        if ((uint) (flag & 1 << index) > 0U)
                    tmpLimit = tmpLimit + (1 << index - 10);
      }
    }

    private int JoinLimitWithFlag()
    {
            tmpLimit = Convert.ToInt32(tbLimit.Text);
      return tmpFlag | tmpLimit << 10;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && components != null)
                components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportlodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbCatalogID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDescr = new System.Windows.Forms.TextBox();
            this.tbMileage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbEnable = new System.Windows.Forms.TextBox();
            this.tbFlag = new System.Windows.Forms.TextBox();
            this.tbIcon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbLimit = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnSaveSelected = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddItems = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateName = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCopyRec = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.clbFlagTest = new System.Windows.Forms.CheckedListBox();
            this.btnShowCat1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnSaveAndNext = new System.Windows.Forms.Button();
            this.cbshowEnabled = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbEnabled = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1146, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileExportToolStripMenuItem
            // 
            this.fileExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportlodToolStripMenuItem});
            this.fileExportToolStripMenuItem.Name = "fileExportToolStripMenuItem";
            this.fileExportToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.fileExportToolStripMenuItem.Text = "File Export";
            // 
            // exportlodToolStripMenuItem
            // 
            this.exportlodToolStripMenuItem.Name = "exportlodToolStripMenuItem";
            this.exportlodToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exportlodToolStripMenuItem.Text = "Export .lod";
            this.exportlodToolStripMenuItem.Click += new System.EventHandler(this.exportlodToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(249, 472);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tbCatalogID
            // 
            this.tbCatalogID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCatalogID.Location = new System.Drawing.Point(72, 31);
            this.tbCatalogID.Name = "tbCatalogID";
            this.tbCatalogID.Size = new System.Drawing.Size(64, 20);
            this.tbCatalogID.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Location = new System.Drawing.Point(72, 57);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(205, 20);
            this.tbName.TabIndex = 3;
            // 
            // tbCategory
            // 
            this.tbCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCategory.Location = new System.Drawing.Point(220, 17);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(89, 20);
            this.tbCategory.TabIndex = 3;
            this.tbCategory.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tbType
            // 
            this.tbType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbType.Location = new System.Drawing.Point(75, 43);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(68, 20);
            this.tbType.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(656, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(68, 20);
            this.textBox5.TabIndex = 5;
            this.textBox5.Visible = false;
            // 
            // tbPrice
            // 
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrice.Location = new System.Drawing.Point(75, 17);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(68, 20);
            this.tbPrice.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Catalog ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Desc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mileage:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Price:";
            // 
            // tbDescr
            // 
            this.tbDescr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescr.Location = new System.Drawing.Point(72, 83);
            this.tbDescr.Multiline = true;
            this.tbDescr.Name = "tbDescr";
            this.tbDescr.Size = new System.Drawing.Size(205, 145);
            this.tbDescr.TabIndex = 13;
            // 
            // tbMileage
            // 
            this.tbMileage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMileage.Location = new System.Drawing.Point(209, 31);
            this.tbMileage.Name = "tbMileage";
            this.tbMileage.Size = new System.Drawing.Size(68, 20);
            this.tbMileage.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Category:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(174, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Flag:";
            // 
            // tbEnable
            // 
            this.tbEnable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEnable.Location = new System.Drawing.Point(491, 3);
            this.tbEnable.Name = "tbEnable";
            this.tbEnable.Size = new System.Drawing.Size(64, 20);
            this.tbEnable.TabIndex = 16;
            this.tbEnable.Visible = false;
            this.tbEnable.TextChanged += new System.EventHandler(this.tbEnable_TextChanged);
            // 
            // tbFlag
            // 
            this.tbFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFlag.Location = new System.Drawing.Point(220, 43);
            this.tbFlag.Name = "tbFlag";
            this.tbFlag.Size = new System.Drawing.Size(89, 20);
            this.tbFlag.TabIndex = 17;
            // 
            // tbIcon
            // 
            this.tbIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIcon.Location = new System.Drawing.Point(220, 69);
            this.tbIcon.Name = "tbIcon";
            this.tbIcon.Size = new System.Drawing.Size(89, 20);
            this.tbIcon.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Type:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(597, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "SubType:";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(174, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Icon:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEnabled);
            this.groupBox1.Controls.Add(this.tbMileage);
            this.groupBox1.Controls.Add(this.tbCatalogID);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbDescr);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(282, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 277);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tbLimit);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tbCategory);
            this.groupBox2.Controls.Add(this.tbType);
            this.groupBox2.Controls.Add(this.tbPrice);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbIcon);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbFlag);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(581, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 98);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Misc";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Limit:";
            // 
            // tbLimit
            // 
            this.tbLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLimit.Location = new System.Drawing.Point(75, 69);
            this.tbLimit.Name = "tbLimit";
            this.tbLimit.Size = new System.Drawing.Size(68, 20);
            this.tbLimit.TabIndex = 23;
            this.tbLimit.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.dgItems);
            this.groupBox4.Controls.Add(this.toolStrip2);
            this.groupBox4.Location = new System.Drawing.Point(282, 313);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(644, 350);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Items";
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
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column9});
            this.dgItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgItems.EnableHeadersVisualStyles = false;
            this.dgItems.Location = new System.Drawing.Point(3, 16);
            this.dgItems.Name = "dgItems";
            this.dgItems.RowHeadersVisible = false;
            this.dgItems.RowTemplate.Height = 32;
            this.dgItems.Size = new System.Drawing.Size(638, 306);
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
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Amount";
            this.Column3.Name = "Column3";
            this.Column3.Width = 75;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Plus";
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Level";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Flag";
            this.Column6.Name = "Column6";
            this.Column6.Width = 50;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Index";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "CatalogID";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveSelected,
            this.toolStripSeparator1,
            this.btnAddItems,
            this.toolStripSeparator6,
            this.btnCopy,
            this.btnDelete,
            this.btnUpdateName});
            this.toolStrip2.Location = new System.Drawing.Point(3, 322);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(638, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnSaveSelected
            // 
            this.btnSaveSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSaveSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveSelected.Name = "btnSaveSelected";
            this.btnSaveSelected.Size = new System.Drawing.Size(62, 22);
            this.btnSaveSelected.Text = "Save Item";
            this.btnSaveSelected.Click += new System.EventHandler(this.btnSaveSelected_Click);
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
            // btnCopy
            // 
            this.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(39, 22);
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 22);
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateName
            // 
            this.btnUpdateName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUpdateName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateName.Name = "btnUpdateName";
            this.btnUpdateName.Size = new System.Drawing.Size(135, 22);
            this.btnUpdateName.Text = "Update Name and Desc";
            this.btnUpdateName.Click += new System.EventHandler(this.btnUpdateName_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCopyRec);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(15, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 531);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Package";
            // 
            // btnCopyRec
            // 
            this.btnCopyRec.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCopyRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyRec.Location = new System.Drawing.Point(100, 494);
            this.btnCopyRec.Name = "btnCopyRec";
            this.btnCopyRec.Size = new System.Drawing.Size(84, 23);
            this.btnCopyRec.TabIndex = 5;
            this.btnCopyRec.Text = "Copy";
            this.btnCopyRec.UseVisualStyleBackColor = false;
            this.btnCopyRec.Click += new System.EventHandler(this.btnCopyRec_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(191, 494);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.textBox12);
            this.groupBox5.Location = new System.Drawing.Point(15, 30);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(261, 51);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 21);
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
            this.textBox12.Size = new System.Drawing.Size(202, 20);
            this.textBox12.TabIndex = 20;
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(916, 670);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.clbFlagTest);
            this.groupBox6.Location = new System.Drawing.Point(578, 134);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(167, 173);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Flag";
            // 
            // clbFlagTest
            // 
            this.clbFlagTest.BackColor = System.Drawing.SystemColors.Control;
            this.clbFlagTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbFlagTest.CheckOnClick = true;
            this.clbFlagTest.ColumnWidth = 75;
            this.clbFlagTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbFlagTest.Items.AddRange(new object[] {
            "New",
            "Popular",
            "Discount",
            "Best Item 1",
            "Best Item 2",
            "Best Item 3",
            "Best Item 4",
            "Best Item 5",
            "Reserved1",
            "Reserved2"});
            this.clbFlagTest.Location = new System.Drawing.Point(3, 16);
            this.clbFlagTest.MultiColumn = true;
            this.clbFlagTest.Name = "clbFlagTest";
            this.clbFlagTest.Size = new System.Drawing.Size(161, 154);
            this.clbFlagTest.TabIndex = 14;
            this.clbFlagTest.SelectedIndexChanged += new System.EventHandler(this.clbFlagTest_SelectedIndexChanged);
            // 
            // btnShowCat1
            // 
            this.btnShowCat1.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources._1;
            this.btnShowCat1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowCat1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCat1.Location = new System.Drawing.Point(6, 19);
            this.btnShowCat1.Name = "btnShowCat1";
            this.btnShowCat1.Size = new System.Drawing.Size(25, 25);
            this.btnShowCat1.TabIndex = 19;
            this.btnShowCat1.UseVisualStyleBackColor = true;
            this.btnShowCat1.Click += new System.EventHandler(this.btnShowCat1_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources._2;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(43, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 25);
            this.button4.TabIndex = 32;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources._3;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(78, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 25);
            this.button5.TabIndex = 33;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources._4;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(116, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 25);
            this.button6.TabIndex = 34;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources._5;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(154, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(25, 25);
            this.button7.TabIndex = 35;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources._6;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(191, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(25, 25);
            this.button8.TabIndex = 36;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources._7;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(227, 19);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(25, 25);
            this.button9.TabIndex = 37;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(6, 50);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(110, 25);
            this.button10.TabIndex = 38;
            this.button10.Text = "All";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button11);
            this.groupBox7.Controls.Add(this.button10);
            this.groupBox7.Controls.Add(this.btnShowCat1);
            this.groupBox7.Controls.Add(this.button9);
            this.groupBox7.Controls.Add(this.button4);
            this.groupBox7.Controls.Add(this.button8);
            this.groupBox7.Controls.Add(this.button5);
            this.groupBox7.Controls.Add(this.button7);
            this.groupBox7.Controls.Add(this.button6);
            this.groupBox7.Location = new System.Drawing.Point(15, 87);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(261, 83);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Category";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // button11
            // 
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(130, 50);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(122, 25);
            this.button11.TabIndex = 39;
            this.button11.Text = "Credit Shop";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 710);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1146, 22);
            this.statusStrip1.TabIndex = 49;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.checkedListBox1);
            this.groupBox8.Location = new System.Drawing.Point(751, 134);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox8.Size = new System.Drawing.Size(175, 173);
            this.groupBox8.TabIndex = 50;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Category";
            this.groupBox8.Enter += new System.EventHandler(this.groupBox8_Enter);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(5, 18);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(165, 150);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.checkedListBox2);
            this.groupBox9.Location = new System.Drawing.Point(929, 30);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox9.Size = new System.Drawing.Size(205, 634);
            this.groupBox9.TabIndex = 51;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Type/Subtype";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(5, 18);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(195, 611);
            this.checkedListBox2.TabIndex = 0;
            this.checkedListBox2.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox2_ItemCheck);
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(992, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "SwitchCategoryOnSave";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnSaveAndNext
            // 
            this.btnSaveAndNext.BackColor = System.Drawing.Color.Chartreuse;
            this.btnSaveAndNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAndNext.Location = new System.Drawing.Point(1034, 670);
            this.btnSaveAndNext.Name = "btnSaveAndNext";
            this.btnSaveAndNext.Size = new System.Drawing.Size(100, 23);
            this.btnSaveAndNext.TabIndex = 52;
            this.btnSaveAndNext.Text = "Save And Next";
            this.btnSaveAndNext.UseVisualStyleBackColor = false;
            this.btnSaveAndNext.Click += new System.EventHandler(this.btnSaveAndNext_Click);
            // 
            // cbshowEnabled
            // 
            this.cbshowEnabled.AutoSize = true;
            this.cbshowEnabled.Location = new System.Drawing.Point(285, 676);
            this.cbshowEnabled.Name = "cbshowEnabled";
            this.cbshowEnabled.Size = new System.Drawing.Size(123, 17);
            this.cbshowEnabled.TabIndex = 53;
            this.cbshowEnabled.Text = "Show Enabled Items";
            this.toolTip1.SetToolTip(this.cbshowEnabled, "Turn off Disabled Items");
            this.cbshowEnabled.UseVisualStyleBackColor = true;
            this.cbshowEnabled.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbEnabled
            // 
            this.cbEnabled.BackColor = System.Drawing.Color.Red;
            this.cbEnabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEnabled.Location = new System.Drawing.Point(72, 234);
            this.cbEnabled.Name = "cbEnabled";
            this.cbEnabled.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.cbEnabled.Size = new System.Drawing.Size(212, 17);
            this.cbEnabled.TabIndex = 14;
            this.cbEnabled.Text = "Enabled";
            this.cbEnabled.UseVisualStyleBackColor = false;
            this.cbEnabled.CheckedChanged += new System.EventHandler(this.cbEnabled_CheckedChanged);
            // 
            // CatalogEditor
            // 
            this.ClientSize = new System.Drawing.Size(1146, 732);
            this.Controls.Add(this.cbshowEnabled);
            this.Controls.Add(this.btnSaveAndNext);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbEnable);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CatalogEditor";
            this.Text = "Catalog Editor v1.05 (Modified by Dethunter12 & Maykom)";
            this.Load += new System.EventHandler(this.Exporter_Catalog_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_ct_item WHERE a_index ='" + Convert.ToString(dgItems.Rows[dgItems.CurrentRow.Index].Cells["Column8"].Value) + "'");
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_ct_item_1 WHERE a_index ='" + Convert.ToString(dgItems.Rows[dgItems.CurrentRow.Index].Cells["Column8"].Value) + "'"); //dethunter12 add
            dgItems.Rows.Clear();
            LoadDG();
    }

    private void btnUpdateName_Click(object sender, EventArgs e)
    {
           
                DataGridViewRow row = dgItems.Rows[dgItems.CurrentRow.Index];
                string str1 = Convert.ToString(row.Cells["Column1"].Value);
                int ItemIdx = Convert.ToInt32(str1);
                string str2;
                string str3;
                str2 = new DatabaseHandle().ItemNameFast(ItemIdx);
                str3 = new DatabaseHandle().ItemDescrFast(ItemIdx);
                // column 1

                tbName.Text = str2;  // name
                tbDescr.Text = str3; //description
            
    }

        private void btnCopyRec_Click(object sender, EventArgs e)
        {

           databaseHandle.SendQueryMySql(Host, User, Password, Database, "DROP TABLE IF EXISTS tempTable;" + "CREATE TEMPORARY TABLE tempTable ENGINE=MEMORY SELECT * FROM t_catalog WHERE a_ctid=" + tbCatalogID.Text + ";" + "SELECT a_ctid FROM tempTable;" + "UPDATE tempTable SET a_ctid=(SELECT a_ctid from t_catalog ORDER BY a_ctid DESC LIMIT 1)+1; " + "SELECT a_ctid FROM tempTable;" + "INSERT INTO t_catalog SELECT * FROM tempTable;");
           databaseHandle.SendQueryMySql(Host, User, Password, Database, "DROP TABLE IF EXISTS tempTable;" + "CREATE TEMPORARY TABLE tempTable ENGINE=MEMORY SELECT * FROM t_catalog_1 WHERE a_ctid=" + tbCatalogID.Text + ";" + "SELECT a_ctid FROM tempTable;" + "UPDATE tempTable SET a_ctid=(SELECT a_ctid from t_catalog_1 ORDER BY a_ctid DESC LIMIT 1)+1; " + "SELECT a_ctid FROM tempTable;" + "INSERT INTO t_catalog_1 SELECT * FROM tempTable;");
           databaseHandle.SendQueryMySql(Host, User, Password, Database, "DROP TABLE IF EXISTS tempTable;" + "CREATE TEMPORARY TABLE tempTable ENGINE=MEMORY SELECT * FROM t_ct_item WHERE a_ctid=" + tbCatalogID.Text + ";" + "SELECT a_index, a_ctid FROM tempTable;" + "UPDATE tempTable SET a_ctid=(SELECT a_ctid from t_ct_item ORDER BY a_ctid DESC LIMIT 1)+1; " + "SELECT a_ctid FROM tempTable;" + "INSERT INTO t_ct_item SELECT * FROM tempTable;");
           databaseHandle.SendQueryMySql(Host, User, Password, Database, "DROP TABLE IF EXISTS tempTable;" + "CREATE TEMPORARY TABLE tempTable ENGINE=MEMORY SELECT * FROM t_ct_item_1 WHERE a_ctid=" + tbCatalogID.Text + ";" + "SELECT a_index, a_ctid FROM tempTable;" + "UPDATE tempTable SET a_ctid=(SELECT a_ctid from t_ct_item_1 ORDER BY a_ctid DESC LIMIT 1)+1; " + "SELECT a_ctid FROM tempTable;" + "INSERT INTO t_ct_item_1 SELECT * FROM tempTable;");
            LoadListBox();
            LoadDG();
           if (textBox12.Text != "")
                SearchList(textBox12.Text);
           listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void btnSaveAndNext_Click(object sender, EventArgs e)
        {
            //dethunter12 add t_catalog_1 - t_catalog_hardcore
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_catalog SET " + "a_ctname = '" + tbName.Text.Replace("'", "\\'") + "', " + "a_category = '" + tbCategory.Text + "', " + "a_type = '" + tbType.Text + "', " + "a_subtype = '" + textBox5.Text + "', " + "a_cash = '" + tbPrice.Text + "', " + "a_ctdesc = '" + tbDescr.Text.Replace("'", "\\'") + "', " + "a_mileage = '" + tbMileage.Text + "', " + "a_enable = '" + tbEnable.Text + "', " + "a_flag = '" + tbFlag.Text + "', " + "a_icon = '" + tbIcon.Text + "' " + "WHERE a_ctid = '" + tbCatalogID.Text + "'");
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_catalog_1 SET " + "a_ctname = '" + tbName.Text.Replace("'", "\\'") + "', " + "a_category = '" + tbCategory.Text + "', " + "a_type = '" + tbType.Text + "', " + "a_subtype = '" + textBox5.Text + "', " + "a_cash = '" + tbPrice.Text + "', " + "a_ctdesc = '" + tbDescr.Text.Replace("'", "\\'") + "', " + "a_mileage = '" + tbMileage.Text + "', " + "a_enable = '" + tbEnable.Text + "', " + "a_flag = '" + tbFlag.Text + "', " + "a_icon = '" + tbIcon.Text + "' " + "WHERE a_ctid = '" + tbCatalogID.Text + "'");

            int selectedIndex = listBox1.SelectedIndex;
            int nextselected = listBox1.SelectedIndex + 1;
            if (textBox12.Text != "")
            {
                SearchList(textBox12.Text);

            }
              
            else if (SortCategoryValue == "-1")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select * from t_catalog ORDER BY a_ctid;");
          
            }

             else
            {
                if (cbshowEnabled.Checked == true)
                {
                    SortEnabled_Catagory(SortCategoryValue, enabled);
                }
                   
                else
                {
                    SortCategory(SortCategoryValue);
                }
                   
            }
            if (selectedIndex + 1 >= listBox1.Items.Count)
            {
                listBox1.SelectedIndex = selectedIndex;
            }
            else
                listBox1.SelectedIndex = nextselected;

            int num5 = (int)new CustomMessage("Saved").ShowDialog();

        }
       
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshowEnabled.Checked == true)
            {
                LoadListBox();
            }
               else
            {
                LoadListBox();  
            }
                
        }

        private void tbEnable_TextChanged(object sender, EventArgs e)
        {
           if (cbEnabled.Checked)
            {

            }
        }

        private void cbEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnabled.Checked)
                cbEnabled.BackColor = Color.LimeGreen;
            else
                cbEnabled.BackColor = Color.Red;

            if (int.Parse(tbEnable.Text) == 1 && cbEnabled.Checked == false)
            {
                tbEnable.Text = "0";
                cbEnabled.Text = "Disabled";
            }
                

            else if (int.Parse(tbEnable.Text) == 0 && cbEnabled.Checked)
            {
                tbEnable.Text = "1";
                cbEnabled.Text = "Enabled";
            }
            

        }
    }
}
