// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.Tools.ItemCollection
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe
using LcDevPack_TeamDamonA.Tools.MemoryWorker;
using MySql.Data.MySqlClient; //dethunter12 add
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools
{
  public class ItemCollection : Form
  {
    public static Connection connection = new Connection();
    public string Host = ItemCollection.connection.ReadSettings("Host");
    public string User = ItemCollection.connection.ReadSettings("User");
    public string Password = ItemCollection.connection.ReadSettings("Password");
    public string Database = ItemCollection.connection.ReadSettings("Database");
    private DatabaseHandle databaseHandle = new DatabaseHandle();
    public string[] _needType = new string[6];
    public string[] menuArray = new string[2]
    {
      "a_theme",
      "a_theme_string"
    };
    public string[] SearchMenu = new string[2]
    {
      "a_theme",
      "a_theme_string"
    };
    public List<string> MenuList = new List<string>();
    public List<string> MenuListSearch = new List<string>();
    private IContainer components = (IContainer) null;
    public int _index;
    public string _enable;
    public string _category;
    public string _texFileID;
    public string _texRow;
    public string _texCol;
    public string _resultType;
    public bool doesCollectionExist;
     private GroupBox groupBox5;
    private Label label7;
    private TextBox textBox1;
    private GroupBox groupBox3;
    private Button btnCopy;
    private Button btnDelete;
    private Button btnAdd;
    private ListBox listBox1;
    private Button button2;
    private GroupBox groupBox1;
    private Label label6;
    private TextBox TbTheme;
    private Label label5;
    private Label label1;
    private TextBox TbThemeString;
    private TextBox TbDescrString;
    private GroupBox groupBox2;
    private GroupBox groupBox4;
    private Label label4;
    private CheckBox checkBox1;
    private ComboBox comboBox1;
    private GroupBox groupBox7;
    private Button btnSave;
    private PictureBox pictureBox1;
    private LinkLabel linkLabel1;
    private GroupBox groupBox6;
    private TextBox TbNeedIndex1;
    private ComboBox comboBox2;
    private TextBox TbNeedCount1;
    private Label label2;
    private Label label8;
    private Label label3;
    private GroupBox groupBox8;
    private TextBox TbNeedCount2;
    private ComboBox comboBox3;
    private TextBox TbNeedIndex2;
    private Label label9;
    private Label label10;
    private Label label11;
    private GroupBox groupBox12;
    private TextBox TbNeedCount6;
    private ComboBox comboBox7;
    private TextBox TbNeedIndex6;
    private Label label21;
    private Label label22;
    private Label label23;
    private GroupBox groupBox11;
    private TextBox TbNeedCount5;
    private ComboBox comboBox6;
    private TextBox TbNeedIndex5;
    private Label label18;
    private Label label19;
    private Label label20;
    private GroupBox groupBox10;
    private TextBox TbNeedCount4;
    private ComboBox comboBox5;
    private TextBox TbNeedIndex4;
    private Label label15;
    private Label label16;
    private Label label17;
    private GroupBox groupBox9;
    private TextBox TbNeedCount3;
    private ComboBox comboBox4;
    private TextBox TbNeedIndex3;
    private Label label12;
    private Label label13;
    private Label label14;
    private TextBox TbResultCount;
    private ComboBox comboBox8;
    private TextBox TbResultIndex;
    private Label label26;
    private Label label24;
    private Label label25;
    private PictureBox pbNeed5;
    private PictureBox pbNeed4;
    private PictureBox pbNeed3;
    private PictureBox pbNeed2;
    private PictureBox pbNeed1;
    private PictureBox pbNeed6;
    private PictureBox pbResult;
        private TextBox tbResultType;
        private Label lblResultType;
        private TextBox tbNeed6;
        private TextBox tbNeed5;
        private TextBox tbNeed4;
        private TextBox tbNeed3;
        private TextBox tbNeed2;
        private TextBox tbNeed1;
        private TextBox tbCategory;
        private Label lblCount;
        private TextBox TbCollectionExist;
        private Button button1;
        private Label lblStatus;
        private TextBox TbId;
        private TextBox TbCol;
        private TextBox TbRow;
        private PictureBox PbSelectID6;
        private PictureBox PbSelectID5;
        private PictureBox PbSelectID4;
        private PictureBox PbSelectID3;
        private PictureBox PbSelectID2;
        private PictureBox PbSelectID1;
        private PictureBox PbResultItemIdx;
        private ToolTip toolTip2;
        private ToolTip toolTip1;

    public ItemCollection()
    {
            InitializeComponent();
    }
   private void IsCollectionInDB() //dethunter12 7/9/2018
        {
            string Query = "select a_theme FROM t_item_collection WHERE a_theme ='" + TbTheme.Text + "';";
            foreach (DataRow row in (InternalDataCollectionBase)mySQL.GetFromQuery(Query).Rows)
            {
                TbCollectionExist.Text = Convert.ToString(row["a_theme"]);
                if (TbCollectionExist.Text != null || TbCollectionExist.Text != "")
                {
                    doesCollectionExist = true;
                }
                else
                {
                    TbCollectionExist.Text = "";
                    doesCollectionExist = false;
                }
            }
        }
        private void ItemCollection_Load(object sender, EventArgs e)
    {
            mySQL.SetConnection();
            new LoadFromDatabase().tItemCollection_Import(); //dethunter12 7/26/2020 add
            lblCount.Text = "Collection Count: " + AllLists.tItemCollect_MenuData.Count();
            LoadStartUpCombo(); //loads the statrtup combo on form  load 
            RefreshAll();
            SelectBoxes(); //dethunter12 add
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
   private int GetID()
    {
            int result = -1;
            int.TryParse(listBox1.Text.Split(' ')[0], out result);
            return result;
     }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
            int CollectionIDx = GetID();
            if (CollectionIDx == -1)
                return;
            var itemcollection = AllLists.tItemCollect_MenuData.Find((Predicate<tItemCollection>)(p => p.a_theme.Equals(CollectionIDx)));
            if (itemcollection == null)
                return;
            TbCollectionExist.Text = "";
            TbTheme.Text = itemcollection.a_theme.ToString();
            TbThemeString.Text = itemcollection.a_theme_string.ToString();
            TbDescrString.Text = itemcollection.a_descr_string.ToString();
            _enable = itemcollection.a_enable.ToString();
            _category = itemcollection.a_category.ToString();
            _texFileID = itemcollection.a_id.ToString();
            _texRow = itemcollection.a_row.ToString();
            _texCol = itemcollection.a_col.ToString();
            TbId.Text = itemcollection.a_id.ToString();//dethunter12 8/4/2020 add
            TbRow.Text = itemcollection.a_row.ToString();//dethunter12 8/4/2020 add
            TbCol.Text = itemcollection.a_col.ToString();//dethunter12 8/4/2020 add
            tbNeed1.Text = itemcollection.a_need1_type.ToString();
            TbNeedIndex1.Text = itemcollection.a_need1_index.ToString();
            TbNeedCount1.Text = itemcollection.a_need1_num.ToString();
            tbNeed2.Text = itemcollection.a_need2_type.ToString();
            TbNeedIndex2.Text = itemcollection.a_need2_index.ToString();
            TbNeedCount2.Text = itemcollection.a_need2_num.ToString();
            tbNeed3.Text = itemcollection.a_need3_type.ToString();
            TbNeedIndex3.Text = itemcollection.a_need3_index.ToString();
            TbNeedCount3.Text = itemcollection.a_need3_num.ToString();
            tbNeed4.Text = itemcollection.a_need4_type.ToString();
            TbNeedIndex4.Text = itemcollection.a_need4_index.ToString();
            TbNeedCount4.Text = itemcollection.a_need4_num.ToString();
            tbNeed5.Text = itemcollection.a_need5_type.ToString();
            TbNeedIndex5.Text = itemcollection.a_need5_index.ToString();
            TbNeedCount5.Text = itemcollection.a_need5_num.ToString();
            tbNeed6.Text = itemcollection.a_need6_type.ToString();
            TbNeedIndex6.Text = itemcollection.a_need6_index.ToString();
            TbNeedCount6.Text = itemcollection.a_need6_num.ToString();
            tbResultType.Text = itemcollection.a_result_type.ToString(); //dethunter12 add
            TbResultIndex.Text = itemcollection.a_result_index.ToString();
            TbResultCount.Text = itemcollection.a_result_num.ToString();
            tbCategory.Text = itemcollection.a_category.ToString();
            IsCollectionInDB();
            SelectBoxes(); //dethunter12 add Note* if you dont add this the form loads the listbox incorrectly 
            SetPublicValues();
            SetIcons();
            
    }

    private void SetPublicValues()
    {
            if (_enable == "True")
            {
                checkBox1.Checked = true;
                checkBox1.BackColor = Color.Lime; //dethunter12 add
            }
            else
            {
                checkBox1.Checked = false;
                checkBox1.BackColor = Color.Red; //dethunter12 add
            }
    }

        private void RefreshAll()//Add By Assasin
        {
            this.listBox1.Items.Clear();
            List<int> SortedIDs = new List<int>();
            for (int i = 0; i < AllLists.tItemCollect_MenuData.Count<tItemCollection>(); i++)
            {
                SortedIDs.Add(AllLists.tItemCollect_MenuData[i].a_theme);
            }
            SortedIDs.Sort();
            Predicate<tItemCollection> match = null;
            Predicate<tItemCollection> predicate2 = null;
            for (int a = 0; a < SortedIDs.Count<int>(); a++)
            {
                if (match == null)
                {
                    if (predicate2 == null)
                    {
                        predicate2 = p => p.a_theme.Equals(SortedIDs[a]);
                    }
                    match = predicate2;
                }
                int num2 = AllLists.tItemCollect_MenuData.FindIndex(match);
                if (num2 != -1)
                {
                    string item = AllLists.tItemCollect_MenuData[num2].a_theme + " - " + AllLists.tItemCollect_MenuData[num2].a_theme_string;
                    this.listBox1.Items.Add(item);
                }
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

    public bool SearchString(string s)
    {
      return s.ToUpper().Contains(textBox1.Text.ToUpper());
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
            MenuListSearch = MenuList.FindAll(new Predicate<string>(SearchString));
            listBox1.DataSource = MenuListSearch;
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      IconPickerItemCollection pickerItemCollection = new IconPickerItemCollection();
      pickerItemCollection.OldItemBtnSelect = 1;
      if (pickerItemCollection.ShowDialog() != DialogResult.OK)
        return;
            _texFileID = pickerItemCollection.TexID.ToString();
            _texCol = pickerItemCollection.TexColumn.ToString();
            _texRow = pickerItemCollection.TexRow.ToString();
            SetIcons();
    }

    private void SetIcons()
    {

            //dethunter12 adjust 5/7/2020 : 8:02PM
            if (TbNeedIndex1.Text != "" && tbNeed1.Text == "1")
                pbNeed1.Image = databaseHandle.IconFast(Convert.ToInt32(TbNeedIndex1.Text));
            if (tbNeed1.Text != "1")
                pbNeed1.Image = null;
            if (TbNeedIndex2.Text != "" && tbNeed2.Text == "1")
                pbNeed2.Image = databaseHandle.IconFast(Convert.ToInt32(TbNeedIndex2.Text));
            if (tbNeed2.Text != "1")
                pbNeed2.Image = null;
            if (TbNeedIndex3.Text != "" && tbNeed3.Text == "1")
                pbNeed3.Image = databaseHandle.IconFast(Convert.ToInt32(TbNeedIndex3.Text));
            if (tbNeed3.Text != "1")
                pbNeed3.Image = null;
            if (TbNeedIndex4.Text != "" && tbNeed4.Text == "1")
                pbNeed4.Image = databaseHandle.IconFast(Convert.ToInt32(TbNeedIndex4.Text));
            if (tbNeed4.Text != "1")
                pbNeed4.Image = null;
            if (TbNeedIndex5.Text != "" && tbNeed5.Text == "1")
                pbNeed5.Image = databaseHandle.IconFast(Convert.ToInt32(TbNeedIndex5.Text));
            if (tbNeed5.Text != "1")
                pbNeed5.Image = null;
            if (tbResultType.Text == "1")
                pbResult.Image = databaseHandle.IconFast(Convert.ToInt32(TbResultIndex.Text));
            else
                pbResult.Image = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemCollection));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbTheme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbThemeString = new System.Windows.Forms.TextBox();
            this.TbDescrString = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.tbNeed6 = new System.Windows.Forms.TextBox();
            this.pbNeed6 = new System.Windows.Forms.PictureBox();
            this.TbNeedCount6 = new System.Windows.Forms.TextBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.TbNeedIndex6 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.tbNeed5 = new System.Windows.Forms.TextBox();
            this.pbNeed5 = new System.Windows.Forms.PictureBox();
            this.TbNeedCount5 = new System.Windows.Forms.TextBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.TbNeedIndex5 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.tbNeed4 = new System.Windows.Forms.TextBox();
            this.pbNeed4 = new System.Windows.Forms.PictureBox();
            this.TbNeedCount4 = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.TbNeedIndex4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tbNeed3 = new System.Windows.Forms.TextBox();
            this.pbNeed3 = new System.Windows.Forms.PictureBox();
            this.TbNeedCount3 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.TbNeedIndex3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tbNeed2 = new System.Windows.Forms.TextBox();
            this.pbNeed2 = new System.Windows.Forms.PictureBox();
            this.TbNeedCount2 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.TbNeedIndex2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbNeed1 = new System.Windows.Forms.TextBox();
            this.pbNeed1 = new System.Windows.Forms.PictureBox();
            this.TbNeedIndex1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.TbNeedCount1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.TbResultCount = new System.Windows.Forms.TextBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.TbResultIndex = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbResultType = new System.Windows.Forms.TextBox();
            this.lblResultType = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.TbCollectionExist = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.TbId = new System.Windows.Forms.TextBox();
            this.TbCol = new System.Windows.Forms.TextBox();
            this.TbRow = new System.Windows.Forms.TextBox();
            this.PbSelectID1 = new System.Windows.Forms.PictureBox();
            this.PbSelectID4 = new System.Windows.Forms.PictureBox();
            this.PbSelectID5 = new System.Windows.Forms.PictureBox();
            this.PbSelectID2 = new System.Windows.Forms.PictureBox();
            this.PbSelectID3 = new System.Windows.Forms.PictureBox();
            this.PbSelectID6 = new System.Windows.Forms.PictureBox();
            this.PbResultItemIdx = new System.Windows.Forms.PictureBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeed6)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeed5)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeed4)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeed3)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeed2)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeed1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbResultItemIdx)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(265, 49);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search";
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
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(53, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCopy);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 467);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Items";
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Location = new System.Drawing.Point(94, 434);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(70, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(170, 434);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(3, 434);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 407);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(947, 597);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TbTheme);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TbThemeString);
            this.groupBox1.Controls.Add(this.TbDescrString);
            this.groupBox1.Location = new System.Drawing.Point(283, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 166);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(134, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 17);
            this.checkBox1.TabIndex = 41;
            this.checkBox1.Text = "Enable";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            // TbTheme
            // 
            this.TbTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbTheme.Location = new System.Drawing.Point(67, 19);
            this.TbTheme.Name = "TbTheme";
            this.TbTheme.Size = new System.Drawing.Size(51, 20);
            this.TbTheme.TabIndex = 1;
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
            // TbThemeString
            // 
            this.TbThemeString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbThemeString.Location = new System.Drawing.Point(67, 45);
            this.TbThemeString.Name = "TbThemeString";
            this.TbThemeString.Size = new System.Drawing.Size(242, 20);
            this.TbThemeString.TabIndex = 5;
            // 
            // TbDescrString
            // 
            this.TbDescrString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbDescrString.Location = new System.Drawing.Point(67, 71);
            this.TbDescrString.Multiline = true;
            this.TbDescrString.Name = "TbDescrString";
            this.TbDescrString.Size = new System.Drawing.Size(242, 83);
            this.TbDescrString.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox12);
            this.groupBox2.Controls.Add(this.groupBox11);
            this.groupBox2.Controls.Add(this.groupBox10);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Location = new System.Drawing.Point(283, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 252);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Need Items";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.PbSelectID6);
            this.groupBox12.Controls.Add(this.tbNeed6);
            this.groupBox12.Controls.Add(this.pbNeed6);
            this.groupBox12.Controls.Add(this.TbNeedCount6);
            this.groupBox12.Controls.Add(this.comboBox7);
            this.groupBox12.Controls.Add(this.TbNeedIndex6);
            this.groupBox12.Controls.Add(this.label21);
            this.groupBox12.Controls.Add(this.label22);
            this.groupBox12.Controls.Add(this.label23);
            this.groupBox12.Location = new System.Drawing.Point(354, 132);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(168, 107);
            this.groupBox12.TabIndex = 7;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Need 6";
            // 
            // tbNeed6
            // 
            this.tbNeed6.Location = new System.Drawing.Point(132, 20);
            this.tbNeed6.Name = "tbNeed6";
            this.tbNeed6.Size = new System.Drawing.Size(31, 20);
            this.tbNeed6.TabIndex = 104;
            // 
            // pbNeed6
            // 
            this.pbNeed6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbNeed6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbNeed6.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbNeed6.Location = new System.Drawing.Point(131, 62);
            this.pbNeed6.Name = "pbNeed6";
            this.pbNeed6.Size = new System.Drawing.Size(32, 32);
            this.pbNeed6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNeed6.TabIndex = 100;
            this.pbNeed6.TabStop = false;
            this.pbNeed6.MouseHover += new System.EventHandler(this.pbNeed6_MouseHover);
            // 
            // TbNeedCount6
            // 
            this.TbNeedCount6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNeedCount6.Location = new System.Drawing.Point(46, 74);
            this.TbNeedCount6.Name = "TbNeedCount6";
            this.TbNeedCount6.Size = new System.Drawing.Size(46, 20);
            this.TbNeedCount6.TabIndex = 5;
            // 
            // comboBox7
            // 
            this.comboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(46, 19);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(85, 21);
            this.comboBox7.TabIndex = 0;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // TbNeedIndex6
            // 
            this.TbNeedIndex6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNeedIndex6.Location = new System.Drawing.Point(46, 46);
            this.TbNeedIndex6.Name = "TbNeedIndex6";
            this.TbNeedIndex6.Size = new System.Drawing.Size(46, 20);
            this.TbNeedIndex6.TabIndex = 4;
            this.TbNeedIndex6.TextChanged += new System.EventHandler(this.TbNeedIndex6_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 21);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(34, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "Type:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 76);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "Count:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 47);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Index:";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.PbSelectID5);
            this.groupBox11.Controls.Add(this.tbNeed5);
            this.groupBox11.Controls.Add(this.pbNeed5);
            this.groupBox11.Controls.Add(this.TbNeedCount5);
            this.groupBox11.Controls.Add(this.comboBox6);
            this.groupBox11.Controls.Add(this.TbNeedIndex5);
            this.groupBox11.Controls.Add(this.label18);
            this.groupBox11.Controls.Add(this.label19);
            this.groupBox11.Controls.Add(this.label20);
            this.groupBox11.Location = new System.Drawing.Point(184, 132);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(168, 107);
            this.groupBox11.TabIndex = 10;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Need 5";
            // 
            // tbNeed5
            // 
            this.tbNeed5.Location = new System.Drawing.Point(132, 20);
            this.tbNeed5.Name = "tbNeed5";
            this.tbNeed5.Size = new System.Drawing.Size(31, 20);
            this.tbNeed5.TabIndex = 103;
            // 
            // pbNeed5
            // 
            this.pbNeed5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbNeed5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbNeed5.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbNeed5.Location = new System.Drawing.Point(131, 62);
            this.pbNeed5.Name = "pbNeed5";
            this.pbNeed5.Size = new System.Drawing.Size(32, 32);
            this.pbNeed5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNeed5.TabIndex = 102;
            this.pbNeed5.TabStop = false;
            this.pbNeed5.MouseHover += new System.EventHandler(this.pbNeed5_MouseHover);
            // 
            // TbNeedCount5
            // 
            this.TbNeedCount5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNeedCount5.Location = new System.Drawing.Point(46, 74);
            this.TbNeedCount5.Name = "TbNeedCount5";
            this.TbNeedCount5.Size = new System.Drawing.Size(46, 20);
            this.TbNeedCount5.TabIndex = 5;
            // 
            // comboBox6
            // 
            this.comboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(46, 19);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(85, 21);
            this.comboBox6.TabIndex = 0;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // TbNeedIndex5
            // 
            this.TbNeedIndex5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNeedIndex5.Location = new System.Drawing.Point(46, 45);
            this.TbNeedIndex5.Name = "TbNeedIndex5";
            this.TbNeedIndex5.Size = new System.Drawing.Size(46, 20);
            this.TbNeedIndex5.TabIndex = 4;
            this.TbNeedIndex5.TextChanged += new System.EventHandler(this.TbNeedIndex5_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Type:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "Count:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 47);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Index:";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.PbSelectID4);
            this.groupBox10.Controls.Add(this.tbNeed4);
            this.groupBox10.Controls.Add(this.pbNeed4);
            this.groupBox10.Controls.Add(this.TbNeedCount4);
            this.groupBox10.Controls.Add(this.comboBox5);
            this.groupBox10.Controls.Add(this.TbNeedIndex4);
            this.groupBox10.Controls.Add(this.label15);
            this.groupBox10.Controls.Add(this.label16);
            this.groupBox10.Controls.Add(this.label17);
            this.groupBox10.Location = new System.Drawing.Point(14, 132);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(168, 107);
            this.groupBox10.TabIndex = 9;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Need 4";
            // 
            // tbNeed4
            // 
            this.tbNeed4.Location = new System.Drawing.Point(133, 20);
            this.tbNeed4.Name = "tbNeed4";
            this.tbNeed4.Size = new System.Drawing.Size(31, 20);
            this.tbNeed4.TabIndex = 102;
            // 
            // pbNeed4
            // 
            this.pbNeed4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbNeed4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbNeed4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbNeed4.Location = new System.Drawing.Point(132, 62);
            this.pbNeed4.Name = "pbNeed4";
            this.pbNeed4.Size = new System.Drawing.Size(32, 32);
            this.pbNeed4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNeed4.TabIndex = 101;
            this.pbNeed4.TabStop = false;
            this.pbNeed4.MouseHover += new System.EventHandler(this.pbNeed4_MouseHover);
            // 
            // TbNeedCount4
            // 
            this.TbNeedCount4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNeedCount4.Location = new System.Drawing.Point(46, 74);
            this.TbNeedCount4.Name = "TbNeedCount4";
            this.TbNeedCount4.Size = new System.Drawing.Size(46, 20);
            this.TbNeedCount4.TabIndex = 5;
            // 
            // comboBox5
            // 
            this.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(46, 19);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(85, 21);
            this.comboBox5.TabIndex = 0;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // TbNeedIndex4
            // 
            this.TbNeedIndex4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNeedIndex4.Location = new System.Drawing.Point(45, 45);
            this.TbNeedIndex4.Name = "TbNeedIndex4";
            this.TbNeedIndex4.Size = new System.Drawing.Size(46, 20);
            this.TbNeedIndex4.TabIndex = 4;
            this.TbNeedIndex4.TextChanged += new System.EventHandler(this.TextBox16_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Type:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Count:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Index:";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.PbSelectID3);
            this.groupBox9.Controls.Add(this.tbNeed3);
            this.groupBox9.Controls.Add(this.pbNeed3);
            this.groupBox9.Controls.Add(this.TbNeedCount3);
            this.groupBox9.Controls.Add(this.comboBox4);
            this.groupBox9.Controls.Add(this.TbNeedIndex3);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Location = new System.Drawing.Point(356, 19);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(168, 107);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Need 3";
            // 
            // tbNeed3
            // 
            this.tbNeed3.Location = new System.Drawing.Point(131, 19);
            this.tbNeed3.Name = "tbNeed3";
            this.tbNeed3.Size = new System.Drawing.Size(31, 20);
            this.tbNeed3.TabIndex = 103;
            // 
            // pbNeed3
            // 
            this.pbNeed3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbNeed3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbNeed3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbNeed3.Location = new System.Drawing.Point(130, 62);
            this.pbNeed3.Name = "pbNeed3";
            this.pbNeed3.Size = new System.Drawing.Size(32, 32);
            this.pbNeed3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNeed3.TabIndex = 100;
            this.pbNeed3.TabStop = false;
            this.pbNeed3.MouseHover += new System.EventHandler(this.pbNeed3_MouseHover);
            // 
            // TbNeedCount3
            // 
            this.TbNeedCount3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNeedCount3.Location = new System.Drawing.Point(46, 74);
            this.TbNeedCount3.Name = "TbNeedCount3";
            this.TbNeedCount3.Size = new System.Drawing.Size(46, 20);
            this.TbNeedCount3.TabIndex = 5;
            // 
            // comboBox4
            // 
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(46, 19);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(85, 21);
            this.comboBox4.TabIndex = 0;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // TbNeedIndex3
            // 
            this.TbNeedIndex3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNeedIndex3.Location = new System.Drawing.Point(46, 45);
            this.TbNeedIndex3.Name = "TbNeedIndex3";
            this.TbNeedIndex3.Size = new System.Drawing.Size(46, 20);
            this.TbNeedIndex3.TabIndex = 4;
            this.TbNeedIndex3.TextChanged += new System.EventHandler(this.TextBox14_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Type:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Count:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Index:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.PbSelectID2);
            this.groupBox8.Controls.Add(this.tbNeed2);
            this.groupBox8.Controls.Add(this.pbNeed2);
            this.groupBox8.Controls.Add(this.TbNeedCount2);
            this.groupBox8.Controls.Add(this.comboBox3);
            this.groupBox8.Controls.Add(this.TbNeedIndex2);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Location = new System.Drawing.Point(185, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(168, 107);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Need 2";
            // 
            // tbNeed2
            // 
            this.tbNeed2.Location = new System.Drawing.Point(131, 19);
            this.tbNeed2.Name = "tbNeed2";
            this.tbNeed2.Size = new System.Drawing.Size(31, 20);
            this.tbNeed2.TabIndex = 102;
            // 
            // pbNeed2
            // 
            this.pbNeed2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbNeed2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbNeed2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbNeed2.Location = new System.Drawing.Point(130, 62);
            this.pbNeed2.Name = "pbNeed2";
            this.pbNeed2.Size = new System.Drawing.Size(32, 32);
            this.pbNeed2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNeed2.TabIndex = 100;
            this.pbNeed2.TabStop = false;
            this.pbNeed2.MouseHover += new System.EventHandler(this.pbNeed2_MouseHover);
            // 
            // TbNeedCount2
            // 
            this.TbNeedCount2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNeedCount2.Location = new System.Drawing.Point(46, 74);
            this.TbNeedCount2.Name = "TbNeedCount2";
            this.TbNeedCount2.Size = new System.Drawing.Size(46, 20);
            this.TbNeedCount2.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(46, 19);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(85, 21);
            this.comboBox3.TabIndex = 0;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // TbNeedIndex2
            // 
            this.TbNeedIndex2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNeedIndex2.Location = new System.Drawing.Point(46, 45);
            this.TbNeedIndex2.Name = "TbNeedIndex2";
            this.TbNeedIndex2.Size = new System.Drawing.Size(46, 20);
            this.TbNeedIndex2.TabIndex = 4;
            this.TbNeedIndex2.TextChanged += new System.EventHandler(this.TextBox12_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Type:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Count:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Index:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.PbSelectID1);
            this.groupBox6.Controls.Add(this.tbNeed1);
            this.groupBox6.Controls.Add(this.pbNeed1);
            this.groupBox6.Controls.Add(this.TbNeedIndex1);
            this.groupBox6.Controls.Add(this.comboBox2);
            this.groupBox6.Controls.Add(this.TbNeedCount1);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Location = new System.Drawing.Point(14, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(168, 107);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Need 1";
            // 
            // tbNeed1
            // 
            this.tbNeed1.Location = new System.Drawing.Point(133, 20);
            this.tbNeed1.Name = "tbNeed1";
            this.tbNeed1.Size = new System.Drawing.Size(31, 20);
            this.tbNeed1.TabIndex = 101;
            // 
            // pbNeed1
            // 
            this.pbNeed1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbNeed1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbNeed1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbNeed1.Location = new System.Drawing.Point(132, 62);
            this.pbNeed1.Name = "pbNeed1";
            this.pbNeed1.Size = new System.Drawing.Size(32, 32);
            this.pbNeed1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNeed1.TabIndex = 99;
            this.pbNeed1.TabStop = false;
            this.pbNeed1.MouseHover += new System.EventHandler(this.pbNeed1_MouseHover);
            // 
            // TbNeedIndex1
            // 
            this.TbNeedIndex1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNeedIndex1.Location = new System.Drawing.Point(46, 45);
            this.TbNeedIndex1.Name = "TbNeedIndex1";
            this.TbNeedIndex1.Size = new System.Drawing.Size(45, 20);
            this.TbNeedIndex1.TabIndex = 5;
            this.TbNeedIndex1.TextChanged += new System.EventHandler(this.TextBox6_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(46, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(85, 21);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // TbNeedCount1
            // 
            this.TbNeedCount1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNeedCount1.Location = new System.Drawing.Point(46, 74);
            this.TbNeedCount1.Name = "TbNeedCount1";
            this.TbNeedCount1.Size = new System.Drawing.Size(45, 20);
            this.TbNeedCount1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Index:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbCategory);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(604, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(299, 49);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Category";
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(255, 17);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(43, 20);
            this.tbCategory.TabIndex = 104;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 21);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Category:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.PbResultItemIdx);
            this.groupBox7.Controls.Add(this.pbResult);
            this.groupBox7.Controls.Add(this.TbResultCount);
            this.groupBox7.Controls.Add(this.comboBox8);
            this.groupBox7.Controls.Add(this.TbResultIndex);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Location = new System.Drawing.Point(283, 442);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(524, 53);
            this.groupBox7.TabIndex = 42;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Result";
            // 
            // pbResult
            // 
            this.pbResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbResult.Location = new System.Drawing.Point(485, 15);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(32, 32);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResult.TabIndex = 101;
            this.pbResult.TabStop = false;
            this.pbResult.MouseHover += new System.EventHandler(this.pbResult_MouseHover);
            // 
            // TbResultCount
            // 
            this.TbResultCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbResultCount.Location = new System.Drawing.Point(385, 19);
            this.TbResultCount.Name = "TbResultCount";
            this.TbResultCount.Size = new System.Drawing.Size(85, 20);
            this.TbResultCount.TabIndex = 5;
            // 
            // comboBox8
            // 
            this.comboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(46, 19);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(85, 21);
            this.comboBox8.TabIndex = 0;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // TbResultIndex
            // 
            this.TbResultIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbResultIndex.Location = new System.Drawing.Point(179, 19);
            this.TbResultIndex.Name = "TbResultIndex";
            this.TbResultIndex.Size = new System.Drawing.Size(85, 20);
            this.TbResultIndex.TabIndex = 4;
            this.TbResultIndex.TextChanged += new System.EventHandler(this.TextBox18_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(137, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(36, 13);
            this.label26.TabIndex = 2;
            this.label26.Text = "Index:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 21);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(34, 13);
            this.label24.TabIndex = 1;
            this.label24.Text = "Type:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(341, 22);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(38, 13);
            this.label25.TabIndex = 3;
            this.label25.Text = "Count:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(683, 507);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(665, 57);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 13);
            this.linkLabel1.TabIndex = 98;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Icon Picker";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(604, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // tbResultType
            // 
            this.tbResultType.Location = new System.Drawing.Point(341, 503);
            this.tbResultType.Name = "tbResultType";
            this.tbResultType.Size = new System.Drawing.Size(73, 20);
            this.tbResultType.TabIndex = 99;
            this.tbResultType.Visible = false;
            // 
            // lblResultType
            // 
            this.lblResultType.AutoSize = true;
            this.lblResultType.Location = new System.Drawing.Point(292, 507);
            this.lblResultType.Name = "lblResultType";
            this.lblResultType.Size = new System.Drawing.Size(44, 13);
            this.lblResultType.TabIndex = 100;
            this.lblResultType.Text = "ResultT";
            this.lblResultType.Visible = false;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Blue;
            this.lblCount.Location = new System.Drawing.Point(19, 537);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 16);
            this.lblCount.TabIndex = 101;
            // 
            // TbCollectionExist
            // 
            this.TbCollectionExist.Location = new System.Drawing.Point(613, 141);
            this.TbCollectionExist.Name = "TbCollectionExist";
            this.TbCollectionExist.Size = new System.Drawing.Size(23, 20);
            this.TbCollectionExist.TabIndex = 102;
            this.TbCollectionExist.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(797, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 103;
            this.button1.Text = "Save And Next";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Blue;
            this.lblStatus.Location = new System.Drawing.Point(367, 537);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            this.lblStatus.TabIndex = 104;
            // 
            // TbId
            // 
            this.TbId.Location = new System.Drawing.Point(699, 25);
            this.TbId.Name = "TbId";
            this.TbId.Size = new System.Drawing.Size(27, 20);
            this.TbId.TabIndex = 105;
            // 
            // TbCol
            // 
            this.TbCol.Location = new System.Drawing.Point(732, 25);
            this.TbCol.Name = "TbCol";
            this.TbCol.Size = new System.Drawing.Size(27, 20);
            this.TbCol.TabIndex = 106;
            // 
            // TbRow
            // 
            this.TbRow.Location = new System.Drawing.Point(765, 26);
            this.TbRow.Name = "TbRow";
            this.TbRow.Size = new System.Drawing.Size(27, 20);
            this.TbRow.TabIndex = 107;
            // 
            // PbSelectID1
            // 
            this.PbSelectID1.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.PbSelectID1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbSelectID1.Location = new System.Drawing.Point(97, 45);
            this.PbSelectID1.Name = "PbSelectID1";
            this.PbSelectID1.Size = new System.Drawing.Size(22, 22);
            this.PbSelectID1.TabIndex = 112;
            this.PbSelectID1.TabStop = false;
            this.PbSelectID1.Click += new System.EventHandler(this.PbSelectID1_Click);
            // 
            // PbSelectID4
            // 
            this.PbSelectID4.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.PbSelectID4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbSelectID4.Location = new System.Drawing.Point(95, 43);
            this.PbSelectID4.Name = "PbSelectID4";
            this.PbSelectID4.Size = new System.Drawing.Size(22, 22);
            this.PbSelectID4.TabIndex = 113;
            this.PbSelectID4.TabStop = false;
            this.PbSelectID4.Click += new System.EventHandler(this.PbSelectID4_Click);
            // 
            // PbSelectID5
            // 
            this.PbSelectID5.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.PbSelectID5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbSelectID5.Location = new System.Drawing.Point(96, 43);
            this.PbSelectID5.Name = "PbSelectID5";
            this.PbSelectID5.Size = new System.Drawing.Size(22, 22);
            this.PbSelectID5.TabIndex = 114;
            this.PbSelectID5.TabStop = false;
            this.PbSelectID5.Click += new System.EventHandler(this.PbSelectID5_Click);
            // 
            // PbSelectID2
            // 
            this.PbSelectID2.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.PbSelectID2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbSelectID2.Location = new System.Drawing.Point(95, 45);
            this.PbSelectID2.Name = "PbSelectID2";
            this.PbSelectID2.Size = new System.Drawing.Size(22, 22);
            this.PbSelectID2.TabIndex = 115;
            this.PbSelectID2.TabStop = false;
            this.PbSelectID2.Click += new System.EventHandler(this.PbSelectID2_Click);
            // 
            // PbSelectID3
            // 
            this.PbSelectID3.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.PbSelectID3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbSelectID3.Location = new System.Drawing.Point(98, 43);
            this.PbSelectID3.Name = "PbSelectID3";
            this.PbSelectID3.Size = new System.Drawing.Size(22, 22);
            this.PbSelectID3.TabIndex = 116;
            this.PbSelectID3.TabStop = false;
            this.PbSelectID3.Click += new System.EventHandler(this.PbSelectID3_Click);
            // 
            // PbSelectID6
            // 
            this.PbSelectID6.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.PbSelectID6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbSelectID6.Location = new System.Drawing.Point(97, 43);
            this.PbSelectID6.Name = "PbSelectID6";
            this.PbSelectID6.Size = new System.Drawing.Size(22, 22);
            this.PbSelectID6.TabIndex = 117;
            this.PbSelectID6.TabStop = false;
            this.PbSelectID6.Click += new System.EventHandler(this.PbSelectID6_Click);
            // 
            // PbResultItemIdx
            // 
            this.PbResultItemIdx.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.PbResultItemIdx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbResultItemIdx.Location = new System.Drawing.Point(270, 18);
            this.PbResultItemIdx.Name = "PbResultItemIdx";
            this.PbResultItemIdx.Size = new System.Drawing.Size(22, 22);
            this.PbResultItemIdx.TabIndex = 114;
            this.PbResultItemIdx.TabStop = false;
            this.PbResultItemIdx.Click += new System.EventHandler(this.PbResultItemIdx_Click);
            // 
            // ItemCollection
            // 
            this.ClientSize = new System.Drawing.Size(905, 561);
            this.Controls.Add(this.TbRow);
            this.Controls.Add(this.TbCol);
            this.Controls.Add(this.TbId);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TbCollectionExist);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblResultType);
            this.Controls.Add(this.tbResultType);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemCollection";
            this.Text = "ItemCollection";
            this.Load += new System.EventHandler(this.ItemCollection_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeed6)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeed5)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeed4)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeed3)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeed2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeed1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbResultItemIdx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        private void LoadStartUpCombo() //initialize a startup load for the combo box strings
        {
            comboBox1.Items.AddRange(new object[4] //newobject  is a way to count the amount of objects or "values" you have in the collection 
      {
         "1 - The greatest hero", //displays the combo box on form as these values 
         "2 - The alchemy of all creation",
         "3 - The richest trader",
         "4 - The courageous adventurer"
      });
            comboBox2.Items.AddRange(new object[3] //combo box 2-7 are Need Theme
      {
         "0 - NONE",
         "1 - ITEM",
         "2 - THEME"
      });
            comboBox3.Items.AddRange(new object[3]
    {
         "0 - NONE",
         "1 - ITEM",
         "2 - THEME"
      });
            comboBox4.Items.AddRange(new object[3]
     {
         "0 - NONE",
         "1 - ITEM",
         "2 - THEME"
      });
            comboBox5.Items.AddRange(new object[3]
     {
         "0 - NONE",
         "1 - ITEM",
         "2 - THEME"
      });
            comboBox6.Items.AddRange(new object[3]
      {
         "0 - NONE",
         "1 - ITEM",
         "2 - THEME"
      });
            comboBox7.Items.AddRange(new object[3]
    {
         "0 - NONE",
         "1 - ITEM",
         "2 - THEME"
      });
            comboBox8.Items.AddRange(new object[4] //result combo box strings
      {
         "1 - ITEM",
         "2 - GOLD",
         "3 - EXP",
         "4 - SP"
      });

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbCategory.Text = GetIndexByComboBox(comboBox1.Text).ToString(); //dethunter12 add
        }

        private void SelectBoxes() //dethunter12 add
        {
            int num1 = comboBox1.FindString(tbCategory.Text); //dethunter12 add
            int num2 = comboBox2.FindString(tbNeed1.Text); //dethunter12 add
            int num3 = comboBox3.FindString(tbNeed2.Text); //dethunter12 add
            int num4 = comboBox4.FindString(tbNeed3.Text); //dethunter12 add
            int num5 = comboBox5.FindString(tbNeed4.Text); //dethunter12 add
            int num6 = comboBox6.FindString(tbNeed5.Text); //dethunter12 add
            int num7 = comboBox7.FindString(tbNeed6.Text); //dethunter12 add
            int num8 = comboBox8.FindString(tbResultType.Text); //dethunter12 add
            comboBox1.SelectedIndex = num1; //dethunter12 add
            comboBox2.SelectedIndex = num2; //dethunter12 add
            comboBox3.SelectedIndex = num3; //dethunter12 add
            comboBox4.SelectedIndex = num4; //dethunter12 add
            comboBox5.SelectedIndex = num5; //dethunter12 add
            comboBox6.SelectedIndex = num6; //dethunter12 add
            comboBox7.SelectedIndex = num7; //dethunter12 add
            comboBox8.SelectedIndex = num8; //dethunter12 add
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox1.BackColor = Color.Pink; //dethunter12 add
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNeed1.Text = GetIndexByComboBox(comboBox2.Text).ToString(); //dethunter12 add
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNeed2.Text = GetIndexByComboBox(comboBox3.Text).ToString(); //dethunter12 add
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNeed3.Text = GetIndexByComboBox(comboBox4.Text).ToString(); //dethunter12 add
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNeed4.Text = GetIndexByComboBox(comboBox5.Text).ToString(); //dethunter12 add
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNeed5.Text = GetIndexByComboBox(comboBox6.Text).ToString(); //dethunter12 add
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNeed6.Text = GetIndexByComboBox(comboBox7.Text).ToString(); //dethunter12 add
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbResultType.Text = GetIndexByComboBox(comboBox8.Text).ToString(); //dethunter12 add
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int enabled;
            int ThemeID = GetID();
            int i = AllLists.tItemCollect_MenuData.FindIndex((tItemCollection p) => p.a_theme.Equals(ThemeID));
            if (i != -1)
            {
                string menu = AllLists.tItemCollect_MenuData[i].Menu;
                AllLists.tItemCollect_MenuData[i].a_theme = int.Parse(TbTheme.Text);
                AllLists.tItemCollect_MenuData[i].a_enable = checkBox1.Checked;
                if (AllLists.tItemCollect_MenuData[i].a_enable == Convert.ToBoolean("true")) 
                    enabled = 1;
                else
                    enabled = 0;
                AllLists.tItemCollect_MenuData[i].a_category = int.Parse(tbCategory.Text); //dethunter12 7/9/2018 adjust
                comboBox1.SelectedIndex = AllLists.tItemCollect_MenuData[i].a_category - 1; //dethunter12 adjust 7/9/2018
                AllLists.tItemCollect_MenuData[i].a_theme_string = Convert.ToString(TbThemeString.Text);
                AllLists.tItemCollect_MenuData[i].a_descr_string = Convert.ToString(TbDescrString.Text);
                AllLists.tItemCollect_MenuData[i].a_id = int.Parse(TbId.Text);
                AllLists.tItemCollect_MenuData[i].a_col = int.Parse(TbCol.Text);
                AllLists.tItemCollect_MenuData[i].a_row = int.Parse(TbRow.Text);
                AllLists.tItemCollect_MenuData[i].a_need1_type = int.Parse(tbNeed1.Text);
                AllLists.tItemCollect_MenuData[i].a_need1_index = int.Parse(TbNeedIndex1.Text);
                AllLists.tItemCollect_MenuData[i].a_need1_num = int.Parse(TbNeedCount1.Text);
                AllLists.tItemCollect_MenuData[i].a_need2_type = int.Parse(tbNeed2.Text);
                AllLists.tItemCollect_MenuData[i].a_need2_index = int.Parse(TbNeedIndex2.Text);
                AllLists.tItemCollect_MenuData[i].a_need2_num = int.Parse(TbNeedCount2.Text);
                AllLists.tItemCollect_MenuData[i].a_need3_type = int.Parse(tbNeed3.Text);
                AllLists.tItemCollect_MenuData[i].a_need3_index = int.Parse(TbNeedIndex3.Text);
                AllLists.tItemCollect_MenuData[i].a_need3_num = int.Parse(TbNeedCount3.Text);
                AllLists.tItemCollect_MenuData[i].a_need4_type = int.Parse(tbNeed4.Text);
                AllLists.tItemCollect_MenuData[i].a_need4_index = int.Parse(TbNeedIndex4.Text);
                AllLists.tItemCollect_MenuData[i].a_need4_num = int.Parse(TbNeedCount4.Text);
                AllLists.tItemCollect_MenuData[i].a_need5_type = int.Parse(tbNeed5.Text);
                AllLists.tItemCollect_MenuData[i].a_need5_index = int.Parse(TbNeedIndex5.Text);
                AllLists.tItemCollect_MenuData[i].a_need5_num = int.Parse(TbNeedCount5.Text);
                AllLists.tItemCollect_MenuData[i].a_need6_type = int.Parse(tbNeed6.Text);
                AllLists.tItemCollect_MenuData[i].a_need6_index = int.Parse(TbNeedIndex6.Text);
                AllLists.tItemCollect_MenuData[i].a_need6_num = int.Parse(TbNeedCount6.Text);
                AllLists.tItemCollect_MenuData[i].a_result_type = int.Parse(tbResultType.Text);
                AllLists.tItemCollect_MenuData[i].a_result_index = int.Parse(TbResultIndex.Text);
                AllLists.tItemCollect_MenuData[i].a_result_num = int.Parse(TbResultCount.Text);
                //Status
                AllLists.tItemCollect_MenuData[i].Menu = AllLists.tItemCollect_MenuData[i].a_theme + " - " + AllLists.tItemCollect_MenuData[i].a_theme_string;
                listBox1.Items[listBox1.SelectedIndex] = AllLists.tItemCollect_MenuData[i].Menu;
                listBox1.SelectedItem = AllLists.tItemCollect_MenuData[i].Menu;
                doesCollectionExist = false; //dethunter12 8/4/2020 default value false
                IsCollectionInDB(); //dethunter12 7/9/2018
                if (doesCollectionExist == true)
                {

                    mySQL.UpdateQuery("UPDATE t_item_collection SET a_theme = '" + AllLists.tItemCollect_MenuData[i].a_theme + "'," + "a_enable ='" + AllLists.tItemCollect_MenuData[i].a_enable + "'," + "a_category ='" + AllLists.tItemCollect_MenuData[i].a_category + "'," + "a_theme_string ='" + AllLists.tItemCollect_MenuData[i].a_theme_string + "'," + "a_desc_string = '" + AllLists.tItemCollect_MenuData[i].a_descr_string + "'," + "a_id ='" + AllLists.tItemCollect_MenuData[i].a_id + "',a_row = '" + AllLists.tItemCollect_MenuData[i].a_row + "',a_col = '" + AllLists.tItemCollect_MenuData[i].a_col + "', a_need1_type = '" + AllLists.tItemCollect_MenuData[i].a_need1_type + "',a_need1_num = '" + AllLists.tItemCollect_MenuData[i].a_need1_num + "',a_need1_index = '" + AllLists.tItemCollect_MenuData[i].a_need1_index + "',a_need2_type = '" + AllLists.tItemCollect_MenuData[i].a_need2_type + "',a_need2_index = '" + AllLists.tItemCollect_MenuData[i].a_need2_index + "',a_need2_num = '" + AllLists.tItemCollect_MenuData[i].a_need2_num + "',a_need3_type = '" + AllLists.tItemCollect_MenuData[i].a_need3_type + "',a_need3_index = '" + AllLists.tItemCollect_MenuData[i].a_need3_index + "',a_need3_num = '" + AllLists.tItemCollect_MenuData[i].a_need3_num + "',a_need4_type = '" + AllLists.tItemCollect_MenuData[i].a_need4_type + "',a_need4_index = '" + AllLists.tItemCollect_MenuData[i].a_need4_index + "',a_need4_num = '" + AllLists.tItemCollect_MenuData[i].a_need4_num + "',a_need5_type = '" + AllLists.tItemCollect_MenuData[i].a_need5_type + "',a_need5_index = '" + AllLists.tItemCollect_MenuData[i].a_need5_index + "',a_need5_num = '" + AllLists.tItemCollect_MenuData[i].a_need5_num + "',a_need6_type = '" + AllLists.tItemCollect_MenuData[i].a_need6_type + "',a_need6_index = '" + AllLists.tItemCollect_MenuData[i].a_need6_index + "',a_need6_num = '" + AllLists.tItemCollect_MenuData[i].a_need6_num + "',a_result_type = '" + AllLists.tItemCollect_MenuData[i].a_result_type + "',a_result_index = '" + AllLists.tItemCollect_MenuData[i].a_result_index + "',a_result_num = '" + AllLists.tItemCollect_MenuData[i].a_result_num + "'WHERE a_theme ='" + AllLists.tItemCollect_MenuData[i].a_theme + "';"); //dethunter12 7/9/2018 update query
                    lblStatus.Text = "Saved Pet : " + AllLists.tItemCollect_MenuData[i].Menu;
                    int num4 = (int)new CustomMessage("Updated Pet").ShowDialog();
                }
                else if (doesCollectionExist == false)
                {
                    //here...
                    //here
                    mySQL.UpdateQuery(string.Format(@"INSERT INTO t_item_collection (a_theme, a_category, a_theme_string,
                            a_desc_string, a_enable, a_id, a_row, a_col, a_need1_type, a_need1_index, 
                            a_need1_num, a_need2_type, a_need2_index, a_need2_num, a_need3_type, 
                            a_need3_index, a_need3_num, a_need4_type, a_need4_index, a_need4_num, a_need5_type,
                            a_need5_index, a_need5_num, a_need6_type, a_need6_index,
                            a_need6_num, a_result_type, a_result_index, a_result_num)
                            VALUES ({0}, {1}, '{2}','{3}',{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},{27},{28} )",
                            AllLists.tItemCollect_MenuData[i].a_theme,
                            AllLists.tItemCollect_MenuData[i].a_category,
                            //Fixme //insert '' around the string before inserting into query.
                            AllLists.tItemCollect_MenuData[i].a_theme_string,
                            AllLists.tItemCollect_MenuData[i].a_descr_string,
                            AllLists.tItemCollect_MenuData[i].a_enable,
                            AllLists.tItemCollect_MenuData[i].a_id,
                            AllLists.tItemCollect_MenuData[i].a_row,
                            AllLists.tItemCollect_MenuData[i].a_col,
                            AllLists.tItemCollect_MenuData[i].a_need1_type,
                            AllLists.tItemCollect_MenuData[i].a_need1_index,
                            AllLists.tItemCollect_MenuData[i].a_need1_num,
                            AllLists.tItemCollect_MenuData[i].a_need2_type,
                            AllLists.tItemCollect_MenuData[i].a_need2_index,
                            AllLists.tItemCollect_MenuData[i].a_need2_num,
                            AllLists.tItemCollect_MenuData[i].a_need3_type,
                            AllLists.tItemCollect_MenuData[i].a_need3_index,
                            AllLists.tItemCollect_MenuData[i].a_need3_num,
                            AllLists.tItemCollect_MenuData[i].a_need4_type,
                            AllLists.tItemCollect_MenuData[i].a_need4_index,
                            AllLists.tItemCollect_MenuData[i].a_need4_num,
                            AllLists.tItemCollect_MenuData[i].a_need5_type,
                            AllLists.tItemCollect_MenuData[i].a_need5_index,
                            AllLists.tItemCollect_MenuData[i].a_need5_num,
                            AllLists.tItemCollect_MenuData[i].a_need6_type,
                            AllLists.tItemCollect_MenuData[i].a_need6_index,
                            AllLists.tItemCollect_MenuData[i].a_need6_num,
                            AllLists.tItemCollect_MenuData[i].a_result_type,
                            AllLists.tItemCollect_MenuData[i].a_result_index,
                            AllLists.tItemCollect_MenuData[i].a_result_num)); //dethunter12 7/9/2018 update query
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      // DatabaseUpdate.tattkpet_Update(AllLists.tpet_MenuData[i]);
                    lblStatus.Text = "Inserted Collection : " + AllLists.tItemCollect_MenuData[i].Menu;
                    int num4 = (int)new CustomMessage("Inserted Collection").ShowDialog();
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int CollectionID = AllLists.tItemCollect_MenuData.Max((tItemCollection p) => p.a_theme) + 1;
            var Collection = new tItemCollection();
            Collection.a_theme = CollectionID;
            Collection.a_theme_string = "New Collection"; Collection.a_descr_string = "";
            Collection.a_category = 1;
            Collection.a_enable = true;
            Collection.a_id = 1;
            Collection.a_row = 0;
            Collection.a_col = 1;
            Collection.a_id = 1;
            Collection.a_need1_type = 0;
            Collection.a_need1_index = 0;
            Collection.a_need1_num = 0;
            Collection.a_need2_type = 0;
            Collection.a_need2_index = 0;
            Collection.a_need2_num = 0;
            Collection.a_need3_type = 0;
            Collection.a_need3_index = 0;
            Collection.a_need3_num = 0;
            Collection.a_need4_type = 0;
            Collection.a_need4_index = 0;
            Collection.a_need4_num = 0;
            Collection.a_need5_type = 0;
            Collection.a_need5_index = 0;
            Collection.a_need5_num = 0;
            Collection.a_need6_type = 0;
            Collection.a_need6_index = 0;
            Collection.a_need6_num = 0;
            Collection.a_result_type = 1;
            Collection.a_result_index = 19;
            Collection.a_result_num = 1;
            SetPublicValues();
            
            AllLists.tItemCollect_MenuData.Add(Collection);
            AllLists.tItemCollect_Menu.Add(Collection.a_theme + " - " + Collection.a_theme_string);
            lblCount.Text = "Collection Count: " + AllLists.tItemCollect_MenuData.Count();
            RefreshAll();
            this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            int CollectionID = this.GetID();
            int collectionID = AllLists.tItemCollect_MenuData.Max((tItemCollection p) => p.a_theme) + 1;
            var CollectionList = AllLists.tItemCollect_MenuData.Find((tItemCollection p) => p.a_theme.Equals(CollectionID));
            var CollectionList2 = (tItemCollection)CollectionList.Clone();
            CollectionList2.a_theme = collectionID;
            tItemCollection expr_6E = CollectionList2;
            expr_6E.a_theme_string += " (copy)";
            CollectionList2.Menu = CollectionList2.a_theme + " - " + CollectionList2.a_theme_string;
            TbCollectionExist.Text = "";
            AllLists.tItemCollect_MenuData.Add(CollectionList2);
            lblCount.Text = "Collection Count: " + AllLists.tItemCollect_MenuData.Count();
            RefreshAll();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;

            //TODO:
            //add in query save
        }

        private void btnDelete_Click(object sender, EventArgs e) //dethunter12 add
        {
            if (MessageBox.Show("Are u sure u want to delete this entire collection?\r\nThe action cannot be undone", "Delete Collection", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int CollectionID = GetID();
                int selectedIndex = listBox1.SelectedIndex;
                AllLists.tItemCollect_MenuData.RemoveAll((tItemCollection p) => p.a_theme.Equals(CollectionID));
                mySQL.UpdateQuery("DELETE FROM t_item_collection WHERE a_theme ='" + CollectionID + "';"); //dethunter12 update delete from actual table
                int num4 = (int)new CustomMessage("Deleted :o").ShowDialog();
                RefreshAll();
                lblCount.Text = "Collection Count: " + AllLists.tItemCollect_MenuData.Count();
                listBox1.SelectedIndex = selectedIndex - 1;
            }
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            //icon update dethunter12 5/7/2020
            if (TbNeedIndex1.Text != "" && tbNeed1.Text == "1")
                pbNeed1.Image = databaseHandle.IconFast(Convert.ToInt32(TbNeedIndex1.Text));
            if (tbNeed1.Text != "1")
                pbNeed1.Image = null;
        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {
            if (TbNeedIndex2.Text != "" && tbNeed2.Text == "1")
                pbNeed2.Image = databaseHandle.IconFast(Convert.ToInt32(TbNeedIndex2.Text));
            if (tbNeed2.Text != "1")
                pbNeed2.Image = null;
        }

        private void TextBox14_TextChanged(object sender, EventArgs e)
        {
            if (TbNeedIndex3.Text != "" && tbNeed3.Text == "1")
                pbNeed3.Image = databaseHandle.IconFast(Convert.ToInt32(TbNeedIndex3.Text));
            if (tbNeed3.Text != "1")
                pbNeed3.Image = null;
        }

        private void TextBox16_TextChanged(object sender, EventArgs e)
        {
            if (TbNeedIndex4.Text != "" && tbNeed4.Text == "1")
                pbNeed4.Image = databaseHandle.IconFast(Convert.ToInt32(TbNeedIndex4.Text));
            if (tbNeed4.Text != "1")
                pbNeed4.Image = null;
        }

      

        private void TextBox18_TextChanged(object sender, EventArgs e)
        {
            if (tbResultType.Text == "1")
                pbResult.Image = databaseHandle.IconFast(Convert.ToInt32(TbResultIndex.Text));
            else
                pbResult.Image = null;
        }

        private void PbResultItemIdx_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbResultType.Text) == 1)
            {

                ItemPicker itemPicker = new ItemPicker();
                if (itemPicker.ShowDialog() != DialogResult.OK)
                    return;
                TbResultIndex.Text = Convert.ToString(itemPicker.ItemIndex);
                TbResultCount.Text = Convert.ToString(itemPicker.ItemAmount); //dethunter12 add 6/14/2018
              
            }
            else if (int.Parse(tbResultType.Text) != 1)
                return;

        }

        private void PbSelectID1_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbNeed1.Text) == 1)
            {

                ItemPicker itemPicker = new ItemPicker();
                if (itemPicker.ShowDialog() != DialogResult.OK)
                    return;
                TbNeedIndex1.Text = Convert.ToString(itemPicker.ItemIndex);
                TbNeedCount1.Text = Convert.ToString(itemPicker.ItemAmount); //dethunter12 add 6/14/2018

            }
            else if (int.Parse(tbNeed1.Text) != 1)
                return;
        }

        private void PbSelectID2_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbNeed2.Text) == 1)
            {

                ItemPicker itemPicker = new ItemPicker();
                if (itemPicker.ShowDialog() != DialogResult.OK)
                    return;
                TbNeedIndex2.Text = Convert.ToString(itemPicker.ItemIndex);
                TbNeedCount2.Text = Convert.ToString(itemPicker.ItemAmount); //dethunter12 add 6/14/2018

            }
            else if (int.Parse(tbNeed2.Text) != 1)
                return;
        }

        private void PbSelectID3_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbNeed3.Text) == 1)
            {

                ItemPicker itemPicker = new ItemPicker();
                if (itemPicker.ShowDialog() != DialogResult.OK)
                    return;
                TbNeedIndex3.Text = Convert.ToString(itemPicker.ItemIndex);
                TbNeedCount3.Text = Convert.ToString(itemPicker.ItemAmount); //dethunter12 add 6/14/2018

            }
            else if (int.Parse(tbNeed3.Text) != 1)
                return;
        }

        private void PbSelectID4_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbNeed4.Text) == 1)
            {

                ItemPicker itemPicker = new ItemPicker();
                if (itemPicker.ShowDialog() != DialogResult.OK)
                    return;
                TbNeedIndex4.Text = Convert.ToString(itemPicker.ItemIndex);
                TbNeedCount4.Text = Convert.ToString(itemPicker.ItemAmount); //dethunter12 add 6/14/2018

            }
            else if (int.Parse(tbNeed4.Text) != 1)
                return;
        }

        private void PbSelectID5_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbNeed5.Text) == 1)
            {

                ItemPicker itemPicker = new ItemPicker();
                if (itemPicker.ShowDialog() != DialogResult.OK)
                    return;
                TbNeedIndex5.Text = Convert.ToString(itemPicker.ItemIndex);
                TbNeedCount5.Text = Convert.ToString(itemPicker.ItemAmount); //dethunter12 add 6/14/2018

            }
            else if (int.Parse(tbNeed5.Text) != 1)
                return;
        }

        private void PbSelectID6_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbNeed6.Text) == 1)
            {

                ItemPicker itemPicker = new ItemPicker();
                if (itemPicker.ShowDialog() != DialogResult.OK)
                    return;
                TbNeedIndex6.Text = Convert.ToString(itemPicker.ItemIndex);
                TbNeedCount6.Text = Convert.ToString(itemPicker.ItemAmount); //dethunter12 add 6/14/2018

            }
            else if (int.Parse(tbNeed6.Text) != 1)
                return;
        }

        private void TbNeedIndex5_TextChanged(object sender, EventArgs e)
        {
            if (TbNeedIndex5.Text != "" && tbNeed5.Text == "1")
                pbNeed5.Image = databaseHandle.IconFast(Convert.ToInt32(TbNeedIndex5.Text));
            if (tbNeed5.Text != "1")
                pbNeed5.Image = null;
        }

        private void TbNeedIndex6_TextChanged(object sender, EventArgs e)
        {
            if (TbNeedIndex6.Text != "" && tbNeed6.Text == "1")
                pbNeed6.Image = databaseHandle.IconFast(Convert.ToInt32(TbNeedIndex6.Text));
            if (tbNeed6.Text != "1")
                pbNeed6.Image = null;
        }

        private void pbNeed1_MouseHover(object sender, EventArgs e)
        {
            if (tbNeed1.Text == "1")
            {
                var name = databaseHandle.ItemNameFast(int.Parse(TbNeedIndex1.Text));
                toolTip1.SetToolTip(pbNeed1, name); //dethunter12 add
            }
        }

        private void pbNeed2_MouseHover(object sender, EventArgs e)
        {
            if (tbNeed2.Text == "1")
            {
                var name = databaseHandle.ItemNameFast(int.Parse(TbNeedIndex2.Text));
                toolTip1.SetToolTip(pbNeed2, name); //dethunter12 add
            }
        }

        private void pbNeed3_MouseHover(object sender, EventArgs e)
        {
            if (tbNeed3.Text == "1")
            {
                var name = databaseHandle.ItemNameFast(int.Parse(TbNeedIndex3.Text));
                toolTip1.SetToolTip(pbNeed3, name); //dethunter12 add
            }
        }

        private void pbNeed4_MouseHover(object sender, EventArgs e)
        {
            if (tbNeed4.Text == "1")
            {
                var name = databaseHandle.ItemNameFast(int.Parse(TbNeedIndex4.Text));
                toolTip1.SetToolTip(pbNeed4, name); //dethunter12 add
            }
        }

        private void pbNeed5_MouseHover(object sender, EventArgs e)
        {
            if (tbNeed5.Text == "1")
            {
                var name = databaseHandle.ItemNameFast(int.Parse(TbNeedIndex5.Text));
                toolTip1.SetToolTip(pbNeed5, name); //dethunter12 add
            }
        }

        private void pbNeed6_MouseHover(object sender, EventArgs e)
        {
            if (tbNeed6.Text == "1")
            {
                var name = databaseHandle.ItemNameFast(int.Parse(TbNeedIndex6.Text));
                toolTip1.SetToolTip(pbNeed6, name); //dethunter12 add
            }
        }

        private void pbResult_MouseHover(object sender, EventArgs e)
        {
            if (tbResultType.Text == "1")
            {
                var name = databaseHandle.ItemNameFast(int.Parse(TbResultIndex.Text));
                toolTip1.SetToolTip(pbResult, name); //dethunter12 add
            }
        }
    }
}
