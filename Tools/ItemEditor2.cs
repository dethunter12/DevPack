// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.Tools.ItemEditor2
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using LcDevPack_TeamDamonA.Tools.MemoryWorker;
using MySql.Data.MySqlClient;
using SlimDX;
using SlimDX.Direct3D9;
using StringExporter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace LcDevPack_TeamDamonA.Tools
{

    public class ItemEditor2 : Form
    {
        private DataTable db_fort_data = new DataTable();
        public static Connection connection = new Connection();
        private int w = 0;
        private int a = 0;
        private string Host = ItemEditor2.connection.ReadSettings("Host");
        private string User = ItemEditor2.connection.ReadSettings("User");
        private string Password = ItemEditor2.connection.ReadSettings("Password");
        private string Database = ItemEditor2.connection.ReadSettings("Database");
        private string language = ItemEditor2.connection.ReadSettings("Language");//dethunter12 test
        private Encoding encoding = Encoding.GetEncoding("ISO-8859-1"); //assassin add

        private DatabaseHandle databaseHandle = new DatabaseHandle();
        public string rowName = "a_index";
        public string[] menuArray = new string[2]
        {
      "a_index",
      "a_name"
        };
        //dethunter12 language strings 4/11/2018
        public string[] menuArrayGER = new string[2]
           {
      "a_index",
      "a_name_ger"
           };
        public string[] menuArrayPOL = new string[2]
                {
      "a_index",
      "a_name_pld"
                };
        public string[] menuArrayBRA = new string[2]
                   {
      "a_index",
      "a_name_brz"
                   };
        public string[] menuArrayRUS = new string[2]
                   {
      "a_index",
      "a_name_rus"
                   };
        public string[] menuArrayFRA = new string[2]
                   {
      "a_index",
      "a_name_frc"
                   };
        public string[] menuArrayESP = new string[2]
                   {
      "a_index",
      "a_name_spn"
                   };
        public string[] menuArrayMEX = new string[2]
                   {
      "a_index",
      "a_name_mex"
                   };
        public string[] menuArrayTHA = new string[2]
                   {
      "a_index",
      "a_name_thai"
                   };
        public string[] menuArrayITA = new string[2]
                   {
      "a_index",
      "a_name_ita"
                   };
        public string[] menuArrayUSA = new string[2]
                   {
      "a_index",
      "a_name_usa"
                   };
        private string namee; //dethunter12 stringfrom lang modify
        public string adescr = "";
        public string aname = ""; //dehtunter12 add
        private string ISO = (string)null;
        private Label label8;
        private Label lblLang;
        private GroupBox gbFortune;
        private Button button8;
        private Button button6;
        private DataGridView dgV;
        private Button button7;
        private CheckBox CbSaveValueAndLevel;
        private CheckBox CbAutoUpdate;
        private TextBox tbDoesItemExist;
        private ToolStripMenuItem massUpdateFlagToolStripMenuItem;
        private ToolStrip toolStrip2;
        private ToolStripButton btnAddItems;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton btnSaveSelected;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDeleteSelected;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton toolBtnClear;
        private ToolStripTextBox r1;
        private DataGridViewTextBoxColumn a_item_idx;
        private DataGridViewTextBoxColumn a_skill_index;
        private DataGridViewTextBoxColumn a_skill_level;
        private DataGridViewTextBoxColumn a_string_index;
        private DataGridViewTextBoxColumn a_prob;
        private DataGridViewTextBoxColumn t_item_idx;
        private DataGridViewTextBoxColumn t_skill_index;
        private DataGridViewTextBoxColumn t_skill_level;
        private DataGridViewTextBoxColumn t_string_index;
        private DataGridViewTextBoxColumn t_prob;
        private ToolStripMenuItem massUpdateNameToolStripMenuItem;
        private Button BtnMassNum;
        private Button btnSub3;
        private Button btnSub2;
        private Button btnSub1;
        private ToolStripMenuItem massPriceToolStripMenuItem;
        private CheckBox CbSaveIconSmc;
        private Label lblProb1;
        private Label lblProb10;
        private Label lblProb9;
        private Label lblProb8;
        private Label lblProb7;
        private Label lblProb6;
        private Label lblProb5;
        private Label lblProb4;
        private Label lblProb3;
        private Label lblProb2;
        private ProgressBar pb_loading;
        public string descrr;        
        public string[] menuArray2 = new string[2]
        {
      "a_type",
      "a_name"
        };
        public string[] menuArray3 = new string[1] { "a_level" };
        public string[] SearchMenu = new string[2]
        {
      "a_index",
      "a_name"
        };
        public string mSortJob = "-1";
        public string mSortJob2 = "-1";
        public string _SortAboveLevel = "-1";
        private string Episode = ItemEditor2.connection.ReadSettings("Episode");
        public System.Collections.Generic.List<string> MenuList = new System.Collections.Generic.List<string>();
        public System.Collections.Generic.List<string> MenuListSearch = new System.Collections.Generic.List<string>();
        public string flagBuilderType = "items"; //dethunter12 add
        public long flagBig; //dethunter12 add
        public int flagSmall; //dethunter12 add
        public float _UpDown = -1f;
        private ASCIIEncoding _Enc = new ASCIIEncoding();
        public string _ClientPath = ItemEditor2.connection.ReadSettings("ClientPath");
        public bool _ComboBoxPurpleLocked = false;
        private ExportLodHandle exportLodHandle = new ExportLodHandle();
        private IContainer components = (IContainer)null;
        public System.Collections.Generic.List<string> List;
        public System.Collections.Generic.List<string> List2;
        public System.Collections.Generic.List<string> List3;
        public System.Collections.Generic.List<string> List4;
        public System.Collections.Generic.List<string> List5;
        public System.Collections.Generic.List<string> List6;
        public System.Collections.Generic.List<string> List7;
        public System.Collections.Generic.List<string> List8;
        public System.Collections.Generic.List<string> List9;
        public System.Collections.Generic.List<string> List10;
        public string name;
        public int index;
        public string test2;
        public Direct3D _Direct3D;
        public Device _Device;
        public float _Zoom;
        public float _LeftRight;
        public float _Rotation;
        public System.Collections.Generic.List<tMesh> _Models;
        public System.Collections.Generic.List<string> lArrayLevel;
        public string varf5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileExportToolStripMenuItem;
        private ToolStripMenuItem exportlodToolStripMenuItem;
        private GroupBox groupBox3;
        private Button button3;
        private Button button1;
        private ListBox listBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox TbType;
        private Label label3;
        private TextBox TbSubtype;
        private Label label2;
        private TextBox TbEnable;
        private Label label4;
        private Label label6;
        private TextBox TbIndex;
        private Label label5;
        private Label label1;
        private TextBox TbName;
        private TextBox TbDescr;
        private GroupBox groupBox4;
        private TextBox TbNum4;
        private Label label15;
        private TextBox TbNum0;
        private Label label11;
        private Label label14;
        private TextBox TbNum1;
        private TextBox TbNum3;
        private Label label12;
        private Label label13;
        private TextBox TbNum2;
        private Label label9;
        private Label label10;
        private TextBox TbWearing;
        private TextBox TbJobFlag;
        private GroupBox groupBox6;
        private TextBox TbPrice;
        private Label label19;
        private TextBox TbMinLvl;
        private Label label16;
        private Label label18;
        private TextBox TbMaxlvl;
        private TextBox TbStackAmnt;
        private Label label17;
        private Label label20;
        private TextBox TbMaxUse;
        private TextBox TbDropProb;
        private Label label21;
        private TextBox TbCraftItm7;
        private Label label28;
        private TextBox TbCraftItm6;
        private Label label27;
        private TextBox TbCraftItm5;
        private Label label26;
        private TextBox TbCraftItm4;
        private Label label25;
        private TextBox TbCraftItm3;
        private Label label24;
        private TextBox TbCraftItm2;
        private Label label23;
        private Label label22;
        private TextBox TbCraftItm10;
        private Label label31;
        private TextBox TbCraftItm9;
        private Label label30;
        private TextBox TbCraftItm8;
        private Label label29;
        private TextBox TbCraftAmnt10;
        private Label label41;
        private TextBox TbCraftAmnt9;
        private Label label40;
        private TextBox TbCraftAmnt8;
        private Label label39;
        private TextBox TbCraftAmnt7;
        private Label label38;
        private TextBox TbCraftAmnt6;
        private Label label37;
        private TextBox TbCraftAmnt5;
        private Label label36;
        private TextBox TbCraftAmnt4;
        private Label label35;
        private TextBox TbCraftAmnt3;
        private Label label34;
        private TextBox TbCraftAmnt2;
        private Label label33;
        private TextBox TbCraftAmnt1;
        private Label label32;
        private GroupBox groupBox8;
        private TextBox TbCraftSkillLevel1;
        private Label label43;
        private TextBox TbCraftSkillId1;
        private Label label42;
        private TextBox TbCraftSkillLevel2;
        private Label label45;
        private TextBox TbCraftSkillId2;
        private Label label44;
        private TextBox TbZoneFlag;
        private Label label46;
        private Label label47;
        private TextBox TbSmc;
        private GroupBox groupBox9;
        private Label label50;
        private TextBox TbIconCol;
        private Label label49;
        private TextBox TbIconRow;
        private Label label48;
        private TextBox TbIconID;
        private PictureBox pictureBox1;
        private GroupBox groupBox10;
        private TextBox TbSet3;
        private Label label55;
        private TextBox TbSet2;
        private Label label54;
        private TextBox TbSet1;
        private Label label53;
        private TextBox TbSet0;
        private Label label52;
        private GroupBox groupBox11;
        private TextBox TbCommonRareID;
        private Label label56;
        private Label label57;
        private TextBox TbSet4;
        private TextBox tbCommonRareRate;
        private Label label58;
        private GroupBox groupBox13;
        private TextBox TbOptionID9;
        private Label label68;
        private TextBox TbOptionID8;
        private Label label67;
        private TextBox TbOptionID7;
        private Label label66;
        private TextBox TbOptionID6;
        private Label label65;
        private TextBox TbOptionID5;
        private Label label64;
        private TextBox TbOptionID4;
        private Label label63;
        private TextBox TbOptionID3;
        private Label label62;
        private TextBox TbOptionID2;
        private Label label61;
        private TextBox TbOptionID1;
        private Label label60;
        private TextBox TbOptionID10;
        private Label label69;
        private TextBox TbOptionLvl10;
        private Label label79;
        private TextBox TbOptionLvl9;
        private Label label78;
        private TextBox TbOptionLvl8;
        private Label label77;
        private TextBox TbOptionLvl7;
        private Label label76;
        private TextBox TbOptionLvl6;
        private Label label75;
        private TextBox TbOptionLvl5;
        private Label label74;
        private TextBox TbOptionLvl4;
        private Label label73;
        private TextBox TbOptionLvl3;
        private Label label72;
        private TextBox TbOptionLvl2;
        private Label label71;
        private TextBox TbOptionLvl1;
        private Label label70;
        private GroupBox groupBox14;
        private Label label80;
        private TextBox TbNormalEffect;
        private Label label82;
        private TextBox TbDamageEffect;
        private Label label81;
        private TextBox TbAttackEffect;
        private GroupBox groupBox16;
        private Label label92;
        private TextBox TbRvrGrade;
        private Label label91;
        private TextBox TbRvrVal;
        private ComboBox comboBox1;
        private ComboBox comboBox4;
        private ComboBox comboBox2;
        private TextBox TbReformVaration6;
        private Label label90;
        private TextBox TbReformVaration5;
        private Label label89;
        private TextBox TbReformVaration4;
        private Label label88;
        private TextBox TbReformVaration3;
        private Label label87;
        private TextBox TbReformVaration2;
        private Label label86;
        private TextBox TbReformVaration1;
        private Label label85;
        private Button button4;
        private ToolStripMenuItem exportStrItemlodToolStripMenuItem;
        private CheckedListBox checkedListBox1;
        private TextBox TbCraftItm1;
        private CheckBox checkBox1;
        private TextBox TbFlag;
        private GroupBox groupBox7;
        private GroupBox groupBox17;
        private ComboBox comboBox3;
        private Label label95;
        private Label label96;
        private Label label97;
        private Label label98;
        private Label label99;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private ComboBox comboBox7;
        private ComboBox comboBox8;
        private ComboBox comboBox9;
        private ComboBox comboBox14;
        private Label label104;
        private ComboBox comboBox13;
        private Label label103;
        private Label label102;
        private Label label101;
        private Label label100;
        private ComboBox comboBox12;
        private ComboBox comboBox11;
        private ComboBox comboBox10;
        private ComboBox comboBox15;
        private ComboBox comboBox16;
        private ComboBox comboBox17;
        private ComboBox comboBox18;
        private ComboBox comboBox19;
        private ComboBox comboBox20;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox3;
        private ToolTip toolTip1;
        private ComboBox comboBox21;
        private ComboBox comboBox22;
        private ComboBox comboBox23;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        public PictureBox pictureBox13;
        public PictureBox pictureBox14;
        public PictureBox pictureBox15;
        public PictureBox pictureBox16;
        public PictureBox pictureBox17;
        public PictureBox pictureBox18;
        public PictureBox pictureBox19;
        public PictureBox pictureBox20;
        public PictureBox pictureBox21;
        public PictureBox pictureBox22;
        public CheckedListBox clbFlagTest;
        private GroupBox groupBox18;
        private GroupBox groupBox19;
        private TextBox textBox12;
        private Label label7;
        private GroupBox groupBox5;
        private CheckedListBox checkedListBox2;
        private TextBox TbDura;
        private TextBox TbCastle;
        private Label label93;
        private Label label94;
        private TextBox TbQuestTriggerID;
        private Label label84;
        private TextBox TbQuestTriggerCnt;
        private Label label83;
        private TextBox TbUnkown;
        private TextBox TbFame;
        private Label label51;
        private Label label59;
        private Label label105;
        private ToolStripMenuItem massEditToolStripMenuItem;
        private ToolStripMenuItem v;
        private ToolStripMenuItem massUpdateSealsToolStripMenuItem;
        private ComboBox CbSubType6;
        private ComboBox CbSubType5;
        private ComboBox CbSubType7;
        private ComboBox CbSubType4;
        private ComboBox CbSubtype3;
        private ComboBox CbSubtype2;
        private ComboBox CbSubtype1;
        private ToolStripMenuItem exportSmclodToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
        private ToolTip toolTip5;
        private ToolTip toolTip6;
        private ToolTip toolTip7;
        private ToolTip toolTip8;
        private ToolTip toolTip9;
        private ToolTip toolTip10;
        private PictureBox pictureBox2;
        private TextBox textBox95;
        public static string OpenedFile; //dethunter12 add
        private Button btnPercent2Add;
        private Button btnPercent1Add;
        private Button btnPercentAdd;
        private TextBox TbPercent2;
        private TextBox TbPercent1;
        private TextBox TbPercent;
        private Label label108;
        private Label label107;
        private Label label106;
        private ComboBox comboBox25;
        private ComboBox comboBox24;
        private GroupBox groupBox15;
        private PictureBox pictureBox25;
        private PictureBox pictureBox24;
        private GroupBox groupBox21;
        private Label label109;
        private GroupBox groupBox23;
        private GroupBox groupBox22;
        private ComboBox comboBox26;
        private Button btnSaveAndNext;
        private GroupBox groupBox12;
        public CheckedListBox ClbItemFlag;
        string tmpPath = "Data\\";

        public ItemEditor2()
        {
            InitializeComponent();
        }

        public ItemEditor2(string text)
        {
            Text = text;
        }
       
        private void LoadListBox()
        {
            listBox1.SelectedIndex = -1;
            MenuList.Clear();
            namee = LanguageHelper.StringFromLanguage(); //dethunter12 modify language
      
            string Query = "SELECT a_index, " + namee +" " + "FROM" + " t_item WHERE a_job_flag ='" + mSortJob + "' ORDER BY a_index;";
            if (mSortJob == "-1")
                Query = "SELECT a_index, " + namee +" "+ "FROM" + " " +  "t_item ORDER BY a_index;";
            if (_SortAboveLevel != "-1")
                Query = "SELECT a_index, " + namee + " " + "FROM t_item WHERE a_level >= " + _SortAboveLevel + ";";
            switch (language.ToString().Trim())
            {
                case "GER":
                    listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayGER, Host, User, Password, Database, Query);
                    break;
                case "POL":
                    listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayPOL, Host, User, Password, Database, Query);
                    break;
                case "BRA":
                    listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayBRA, Host, User, Password, Database, Query);
                    break;
                case "RUS":
                    listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayRUS, Host, User, Password, Database, Query);
                    break;
                case "FRA":
                    listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayFRA, Host, User, Password, Database, Query);
                    break;
                case "ESP":
                    listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayESP, Host, User, Password, Database, Query);
                    break;
                case "MEX":
                    listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayMEX, Host, User, Password, Database, Query);
                    break;
                case "THA":
                    listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayTHA, Host, User, Password, Database, Query);
                    break;
                case "ITA":
                    listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayITA, Host, User, Password, Database, Query);
                    break;
                case "USA":
                    listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayUSA, Host, User, Password, Database, Query);
                    break;
                default:
                    listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, Query);
                    break;
            }
   
            for (int index = 0; index < listBox1.Items.Count; ++index)
                MenuList.Add(listBox1.Items[index].ToString());
            listBox1.DataSource = MenuList;
            listBox1.SelectedIndex = -1;
        }

        public void SearchList(string searchString)
        {
            searchString = searchString.Replace("\\", "\\\\").Replace("'", "\\'");
            string lower = searchString.ToLower();
            string upper = searchString.ToUpper();
            string str = "";
            if (searchString.Length > 1)
                str = char.ToUpper(searchString[0]).ToString() + searchString.Substring(1);
            //dethunter12 4/11/2018 language add
            switch (language.ToString().Trim())
            {
                case "GER":
                    listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayGER, Host, User, Password, Database, "select a_index, a_name_ger from t_item WHERE a_name_ger LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_ger LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_ger LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_ger LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");
                    break;
                case "POL":
                    listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayPOL, Host, User, Password, Database, "select a_index, a_name_pld from t_item WHERE a_name_pld LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_pld LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_pld LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_pld LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");
                    break;
                case "BRA":
                    listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayBRA, Host, User, Password, Database, "select a_index, a_name_brz from t_item WHERE a_name_brz LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_brz LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_brz LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_brz LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");
                    break;
                case "RUS":
                    listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayRUS, Host, User, Password, Database, "select a_index, a_name_rus from t_item WHERE a_name_rus LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_rus LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_rus LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_rus LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");
                    break;
                case "FRA":
                    listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayFRA, Host, User, Password, Database, "select a_index, a_name_frc from t_item WHERE a_name_frc LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_frc LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_frc LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_frc LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");
                    break;
                case "ESP":
                    listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayFRA, Host, User, Password, Database, "select a_index, a_name_frc from t_item WHERE a_name_frc LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_frc LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_frc LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_frc LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");
                    break;
                case "MEX":
                    listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayMEX, Host, User, Password, Database, "select a_index, a_name_mex from t_item WHERE a_name_mex LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_mex LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_mex LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_mex LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");
                    break;
                case "THA":
                    listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayTHA, Host, User, Password, Database, "select a_index, a_name_thai from t_item WHERE a_name_thai LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_thai LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_thai LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_thai LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");
                    break;
                case "ITA":
                    listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayITA, Host, User, Password, Database, "select a_index, a_name_ita from t_item WHERE a_name_ita LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_ita LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_ita LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_ita LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");
                    break;
                case "USA":
                    listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayUSA, Host, User, Password, Database, "select a_index, a_name_usa from t_item WHERE a_name_usa LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_usa LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_usa LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_usa LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");
                    break;
                default:
                    listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_index, a_name from t_item WHERE a_name LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");
                    break;
            }
           
        }

        private void Exporter_Item_Load(object sender, EventArgs e)
        {
            InitializeDevice();
            LoadStartUp();
            LoadLangAtStartup(); //dethunter12 add
            SelectBoxes();
            LoadListBox();
            listBox1.SelectedIndex = 0; //dethunter12 list box not default 6/30/2019
            //  LoadMisc();

            Setup_DCol(db_fort_data);
        }

        private void Setup_DCol(DataTable dt)
        {
            dt = new DataTable();
            dt.Columns.Add("a_item_idx", typeof(System.Int32));
            dt.Columns.Add("a_skill_index", typeof(System.Int32));
            dt.Columns.Add("a_skill_level", typeof(System.Int32));
            dt.Columns.Add("a_string_index", typeof(System.Int32));
            dt.Columns.Add("a_prob", typeof(System.Int32));
            dt.Columns.Add("t_item_idx", typeof(System.Int32));
            dt.Columns.Add("t_skill_index", typeof(System.Int32));
            dt.Columns.Add("t_skill_level", typeof(System.Int32));
            dt.Columns.Add("t_string_index", typeof(System.Int32));
            dt.Columns.Add("t_prob", typeof(System.Int32));
        }

        private void LoadFortuneData(string item_idx)
        {
            if (item_idx == null || Int32.Parse(item_idx) <= 0)
                return;

            MySqlConnection connection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);

            string strCNNs = "datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database;
            string strSQL = "select *, a_item_idx as t_item_idx, a_skill_index as t_skill_index, a_skill_level as t_skill_level, a_string_index as t_string_index, a_prob as t_prob from t_fortune_data where a_item_idx = " + item_idx.ToString().Trim() + " order by a_item_idx";
            //MySqlCommand mySqlCommand = new MySqlCommand("select * from t_fortune_data where a_item_idx = " + item_idx.ToString().Trim() + " order by a_item_idx", connection);
            
            
            try
            {
                //dgV.Rows.Clear();

                if (db_fort_data == null)
                {
                    Setup_DCol(db_fort_data);
                }
                else
                {
                    db_fort_data.Rows.Clear();
                }

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(strSQL, connection);
                mySqlDataAdapter.Fill(db_fort_data);
            }
            catch (Exception)
            {
                db_fort_data.Rows.Clear();
            }

            dgV.DataSource = db_fort_data;
        }

        public void SelectBoxes()
        {
            checkBox1.Checked = TbEnable.Text == "1";
            int num1 = comboBox1.FindString(TbType.Text);
            int num2 = comboBox2.FindString(TbSubtype.Text);
            int num3 = comboBox4.FindString(TbWearing.Text);
            //dethunter12 selected id = number
            int num4 = CbSubtype1.FindString(TbSubtype.Text);
            int num5 = CbSubtype2.FindString(TbSubtype.Text);
            int num6 = CbSubtype3.FindString(TbSubtype.Text);
            int num7 = CbSubType4.FindString(TbSubtype.Text);
            int num8 = CbSubType5.FindString(TbSubtype.Text);
            int num9 = CbSubType6.FindString(TbSubtype.Text);
            int num10 = CbSubType7.FindString(TbSubtype.Text);
            int num11 = comboBox24.FindString(TbRvrVal.Text);
            int num12 = comboBox25.FindString(TbRvrGrade.Text);
            int num13 = comboBox26.FindString(TbRvrGrade.Text);
            comboBox1.SelectedIndex = num1;
            comboBox2.SelectedIndex = num2;
            comboBox4.SelectedIndex = num3;
            //id ==  num selected index
            CbSubtype1.SelectedIndex = num4;
            CbSubtype2.SelectedIndex = num5;
            CbSubtype3.SelectedIndex = num6;
            CbSubType4.SelectedIndex = num7;
            CbSubType5.SelectedIndex = num8;
            CbSubType6.SelectedIndex = num9;
            CbSubType7.SelectedIndex = num10;
            comboBox24.SelectedIndex = num11;
            comboBox25.SelectedIndex = num12;
            comboBox26.SelectedIndex = num13;
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

        public void ItemIconFastOnListboxValue() //dethunter12 start 3/16/2020
           //ideally try to get item icon to load for each item index (so get the item id for the index then add a icon for it) (fast)
        {

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

        private void LoadLangAtStartup() //dethunter12 add 
        {
            if (language == "GER")
            {
                fileExportToolStripMenuItem.Text = "Datei Export"; // File Export
                v.Text = "Masse aktualisieren"; //Mysql-Mass Update
                massUpdateSealsToolStripMenuItem.Text = "Masse aktualisieren Dichtungen";// Mysql-Mass Update Seals
                groupBox5.Text = "Suche"; //search
                groupBox3.Text = "Artikel"; //items
                groupBox1.Text = "Basic"; //basic
                groupBox6.Text = "Min- und Max-Level"; //min and max level
                groupBox16.Text = "RvR"; //RvR
                groupBox9.Text = "Symbol"; //icon
                groupBox11.Text = "häufige seltene Möglichkeit"; //common rareoption
                groupBox2.Text = "Charakter"; //Character
                groupBox14.Text = "Artikel Spezialeffekte"; //Item Special Effects
                groupBox15.Text = "Stapel und Preis"; //Stack and Prize
                groupBox4.Text = "Optionen"; //Options
                groupBox19.Text = "Reformvariante"; // Reform variation
                groupBox21.Text = "Klasse"; //Class
                groupBox10.Text = "Einstellungen"; //Random Settings
                groupBox22.Text = "Sonstiges"; //Misc
                groupBox23.Text = "Quest Auslöser Info";// Quest Trigger Info
                //groupBox20.Text = "3D-Ansicht"; //3d View
                //SecondPage Crafting
                groupBox8.Text = "Basteln Fertigkeit Anforderung"; //Crafting Skill Requirement
                groupBox7.Text = "Artikel Basteln"; //Item Crafting
                //Rare&Purple&Fortune
                groupBox13.Text = "Selten Optionen"; //Rare Options
                groupBox17.Text = "Lila Artikel "; //Purple Items
                lblLang.Text = "German";
            }
            else if (language == "FRA")
            {
                v.Text = "mise à jour massive"; //Mysql-Mass Update
                fileExportToolStripMenuItem.Text = "Exportation de fichier"; // File Export
                massUpdateSealsToolStripMenuItem.Text = "joints de mise à jour massifs";// Mysql-Mass Update Seals
                groupBox5.Text = "chercher"; //search
                groupBox3.Text = "articles"; //items
                groupBox1.Text = "de base"; //basic
                groupBox6.Text = "Min et Max"; //min and max level
                groupBox16.Text = "RvR"; //RvR
                groupBox9.Text = "Icône"; //icon
                groupBox11.Text = "option rare commune"; //common rareoption
                groupBox2.Text = "personnage"; //Character
                groupBox14.Text = "Effets spéciaux d'article"; //Item Special Effects
                groupBox15.Text = "Pile et prix"; //Stack and Prize
                groupBox4.Text = "Options"; //Options
                groupBox19.Text = "variation de la réforme"; // Reform variation
                groupBox21.Text = "Classe"; //Class
                groupBox10.Text = "Paramètres aléatoires"; //Random Settings
                groupBox22.Text = "Divers"; //Misc
                groupBox23.Text = "quête déclencheur Info";// Quest Trigger Info
                //groupBox20.Text = "Vue 3D"; //3d View
                //SecondPage Crafting
                groupBox8.Text = "Compétence d'artisanat"; //Crafting Skill Requirement
                groupBox7.Text = "Artisanat d'article"; //Item Crafting
                //Rare&Purple&Fortune
                groupBox13.Text = "Option rare"; //Rare Options
                groupBox17.Text = "Articles violets"; //Purple Items
                lblLang.Text = "French";
            }

            else if (language == "ITA")
            {
                v.Text = "mise à jour massive"; //Mysql-Mass Update
                fileExportToolStripMenuItem.Text = "Exportation de fichier"; // File Export
                massUpdateSealsToolStripMenuItem.Text = "joints de mise à jour massifs";// Mysql-Mass Update Seals
                groupBox5.Text = "chercher"; //search
                groupBox3.Text = "articles"; //items
                groupBox1.Text = "de base"; //basic
                groupBox6.Text = "Min et Max"; //min and max level
                groupBox16.Text = "RvR"; //RvR
                groupBox9.Text = "Icône"; //icon
                groupBox11.Text = "option rare commune"; //common rareoption
                groupBox2.Text = "personnage"; //Character
                groupBox14.Text = "Effets spéciaux d'article"; //Item Special Effects
                groupBox15.Text = "Pile et prix"; //Stack and Prize
                groupBox4.Text = "Options"; //Options
                groupBox19.Text = "variation de la réforme"; // Reform variation
                groupBox21.Text = "Classe"; //Class
                groupBox10.Text = "Paramètres aléatoires"; //Random Settings
                groupBox22.Text = "Divers"; //Misc
                groupBox23.Text = "quête déclencheur Info";// Quest Trigger Info
                //groupBox20.Text = "Vue 3D"; //3d View
                //SecondPage Crafting
                groupBox8.Text = "Compétence d'artisanat"; //Crafting Skill Requirement
                groupBox7.Text = "Artisanat d'article"; //Item Crafting
                //Rare&Purple&Fortune
                groupBox13.Text = "Option rare"; //Rare Options
                groupBox17.Text = "Articles violets"; //Purple Items
                lblLang.Text = "Italian";
            }

            else if (language == "RUS")
            {
                v.Text = "mise à jour massive"; //Mysql-Mass Update
                fileExportToolStripMenuItem.Text = "Exportation de fichier"; // File Export
                massUpdateSealsToolStripMenuItem.Text = "joints de mise à jour massifs";// Mysql-Mass Update Seals
                groupBox5.Text = "chercher"; //search
                groupBox3.Text = "articles"; //items
                groupBox1.Text = "de base"; //basic
                groupBox6.Text = "Min et Max"; //min and max level
                groupBox16.Text = "RvR"; //RvR
                groupBox9.Text = "Icône"; //icon
                groupBox11.Text = "option rare commune"; //common rareoption
                groupBox2.Text = "personnage"; //Character
                groupBox14.Text = "Effets spéciaux d'article"; //Item Special Effects
                groupBox15.Text = "Pile et prix"; //Stack and Prize
                groupBox4.Text = "Options"; //Options
                groupBox19.Text = "variation de la réforme"; // Reform variation
                groupBox21.Text = "Classe"; //Class
                groupBox10.Text = "Paramètres aléatoires"; //Random Settings
                groupBox22.Text = "Divers"; //Misc
                groupBox23.Text = "quête déclencheur Info";// Quest Trigger Info
                //groupBox20.Text = "Vue 3D"; //3d View
                //SecondPage Crafting
                groupBox8.Text = "Compétence d'artisanat"; //Crafting Skill Requirement
                groupBox7.Text = "Artisanat d'article"; //Item Crafting
                //Rare&Purple&Fortune
                groupBox13.Text = "Option rare"; //Rare Options
                groupBox17.Text = "Articles violets"; //Purple Items
                lblLang.Text = "Russian";
            }

            else if (language == "THA")
            {
                v.Text = "mise à jour massive"; //Mysql-Mass Update
                fileExportToolStripMenuItem.Text = "Exportation de fichier"; // File Export
                massUpdateSealsToolStripMenuItem.Text = "joints de mise à jour massifs";// Mysql-Mass Update Seals
                groupBox5.Text = "chercher"; //search
                groupBox3.Text = "articles"; //items
                groupBox1.Text = "de base"; //basic
                groupBox6.Text = "Min et Max"; //min and max level
                groupBox16.Text = "RvR"; //RvR
                groupBox9.Text = "Icône"; //icon
                groupBox11.Text = "option rare commune"; //common rareoption
                groupBox2.Text = "personnage"; //Character
                groupBox14.Text = "Effets spéciaux d'article"; //Item Special Effects
                groupBox15.Text = "Pile et prix"; //Stack and Prize
                groupBox4.Text = "Options"; //Options
                groupBox19.Text = "variation de la réforme"; // Reform variation
                groupBox21.Text = "Classe"; //Class
                groupBox10.Text = "Paramètres aléatoires"; //Random Settings
                groupBox22.Text = "Divers"; //Misc
                groupBox23.Text = "quête déclencheur Info";// Quest Trigger Info
                //groupBox20.Text = "Vue 3D"; //3d View
                //SecondPage Crafting
                groupBox8.Text = "Compétence d'artisanat"; //Crafting Skill Requirement
                groupBox7.Text = "Artisanat d'article"; //Item Crafting
                //Rare&Purple&Fortune
                groupBox13.Text = "Option rare"; //Rare Options
                groupBox17.Text = "Articles violets"; //Purple Items
                lblLang.Text = "Thai";
            }

            else if (language == "POL")
            {
                v.Text = "mise à jour massive"; //Mysql-Mass Update
                fileExportToolStripMenuItem.Text = "Exportation de fichier"; // File Export
                massUpdateSealsToolStripMenuItem.Text = "joints de mise à jour massifs";// Mysql-Mass Update Seals
                groupBox5.Text = "chercher"; //search
                groupBox3.Text = "articles"; //items
                groupBox1.Text = "de base"; //basic
                groupBox6.Text = "Min et Max"; //min and max level
                groupBox16.Text = "RvR"; //RvR
                groupBox9.Text = "Icône"; //icon
                groupBox11.Text = "option rare commune"; //common rareoption
                groupBox2.Text = "personnage"; //Character
                groupBox14.Text = "Effets spéciaux d'article"; //Item Special Effects
                groupBox15.Text = "Pile et prix"; //Stack and Prize
                groupBox4.Text = "Options"; //Options
                groupBox19.Text = "variation de la réforme"; // Reform variation
                groupBox21.Text = "Classe"; //Class
                groupBox10.Text = "Paramètres aléatoires"; //Random Settings
                groupBox22.Text = "Divers"; //Misc
                groupBox23.Text = "quête déclencheur Info";// Quest Trigger Info
                //groupBox20.Text = "Vue 3D"; //3d View
                //SecondPage Crafting
                groupBox8.Text = "Compétence d'artisanat"; //Crafting Skill Requirement
                groupBox7.Text = "Artisanat d'article"; //Item Crafting
                //Rare&Purple&Fortune
                groupBox13.Text = "Option rare"; //Rare Options
                groupBox17.Text = "Articles violets"; //Purple Items
                lblLang.Text = "Polish";
            }

            else if (language == "ESP")
            {
                v.Text = "mise à jour massive"; //Mysql-Mass Update
                fileExportToolStripMenuItem.Text = "Exportation de fichier"; // File Export
                massUpdateSealsToolStripMenuItem.Text = "joints de mise à jour massifs";// Mysql-Mass Update Seals
                groupBox5.Text = "chercher"; //search
                groupBox3.Text = "articles"; //items
                groupBox1.Text = "de base"; //basic
                groupBox6.Text = "Min et Max"; //min and max level
                groupBox16.Text = "RvR"; //RvR
                groupBox9.Text = "Icône"; //icon
                groupBox11.Text = "option rare commune"; //common rareoption
                groupBox2.Text = "personnage"; //Character
                groupBox14.Text = "Effets spéciaux d'article"; //Item Special Effects
                groupBox15.Text = "Pile et prix"; //Stack and Prize
                groupBox4.Text = "Options"; //Options
                groupBox19.Text = "variation de la réforme"; // Reform variation
                groupBox21.Text = "Classe"; //Class
                groupBox10.Text = "Paramètres aléatoires"; //Random Settings
                groupBox22.Text = "Divers"; //Misc
                groupBox23.Text = "quête déclencheur Info";// Quest Trigger Info
                //groupBox20.Text = "Vue 3D"; //3d View
                //SecondPage Crafting
                groupBox8.Text = "Compétence d'artisanat"; //Crafting Skill Requirement
                groupBox7.Text = "Artisanat d'article"; //Item Crafting
                //Rare&Purple&Fortune
                groupBox13.Text = "Option rare"; //Rare Options
                groupBox17.Text = "Articles violets"; //Purple Items
                lblLang.Text = "Spanish";
            }

            else if (language == "BRA")
            {
                v.Text = "mise à jour massive"; //Mysql-Mass Update
                fileExportToolStripMenuItem.Text = "Exportation de fichier"; // File Export
                massUpdateSealsToolStripMenuItem.Text = "joints de mise à jour massifs";// Mysql-Mass Update Seals
                groupBox5.Text = "chercher"; //search
                groupBox3.Text = "articles"; //items
                groupBox1.Text = "de base"; //basic
                groupBox6.Text = "Min et Max"; //min and max level
                groupBox16.Text = "RvR"; //RvR
                groupBox9.Text = "Icône"; //icon
                groupBox11.Text = "option rare commune"; //common rareoption
                groupBox2.Text = "personnage"; //Character
                groupBox14.Text = "Effets spéciaux d'article"; //Item Special Effects
                groupBox15.Text = "Pile et prix"; //Stack and Prize
                groupBox4.Text = "Options"; //Options
                groupBox19.Text = "variation de la réforme"; // Reform variation
                groupBox21.Text = "Classe"; //Class
                groupBox10.Text = "Paramètres aléatoires"; //Random Settings
                groupBox22.Text = "Divers"; //Misc
                groupBox23.Text = "quête déclencheur Info";// Quest Trigger Info
                //groupBox20.Text = "Vue 3D"; //3d View
                //SecondPage Crafting
                groupBox8.Text = "Compétence d'artisanat"; //Crafting Skill Requirement
                groupBox7.Text = "Artisanat d'article"; //Item Crafting
                //Rare&Purple&Fortune
                groupBox13.Text = "Option rare"; //Rare Options
                groupBox17.Text = "Articles violets"; //Purple Items
                lblLang.Text = "Brasilian";
            }
            else if (language == "MEX")
            {
                lblLang.Text = "Mex";
            }

            else if (language == "USA")
            {
                lblLang.Text = "English";
            }

        }
        private void ClearBackgroundColors()
        {
            comboBox1.BackColor = Color.White; //dethunter12 add/ Resets the  color upon click on another index.
            comboBox2.BackColor = Color.White; //dethunter12 add
            comboBox4.BackColor = Color.White; //dethunter12 add
            CbSubtype1.BackColor = Color.White; //dethunter12 add
            CbSubtype2.BackColor = Color.White; //dethunter12 add
            CbSubtype3.BackColor = Color.White; //dethunter12 add
            CbSubType4.BackColor = Color.White; //dethunter12 add
            CbSubType5.BackColor = Color.White; //dethunter12 add
            CbSubType6.BackColor = Color.White; //dethunter12 add
            CbSubType7.BackColor = Color.White; //dethunter12 add
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ComboBoxPurpleLocked = true;
            if (listBox1.SelectedIndex != -1)
              ClearBackgroundColors();
              
            TbIndex.Text = GetIndex().ToString();
            if (CbSaveValueAndLevel.Checked == true)
                UnClearComboBox();
            else
             ClearComboBoxPurple();
            ResetTextBoxBackground();
            ResetComboBoxPurpleBg();
            ClearComboBoxPurple2();
            string Query = " select a_index , a_type_idx , a_subtype_idx , a_enable , a_name , a_descr , a_job_flag , a_flag , a_wearing , a_num_0 , a_num_1 , a_num_2, a_num_3 , a_num_4 , a_level , a_level2 , a_weight , a_price , a_max_use , a_drop_prob_10 , a_need_item0 , a_need_item1 , a_need_item2 , a_need_item3 , a_need_item4 , a_need_item5 , a_need_item6 , a_need_item7 , a_need_item8 , a_need_item9 , a_need_item_count0 , a_need_item_count1 , a_need_item_count2 , a_need_item_count3 , a_need_item_count4 , a_need_item_count5 , a_need_item_count6 , a_need_item_count7 , a_need_item_count8 , a_need_item_count9 , a_need_sskill , a_need_sskill_level , a_need_sskill2 , a_need_sskill_level2 , a_zone_flag , a_file_smc , a_texture_id , a_texture_row , a_texture_col , b_todo_delete , a_set_0 , a_set_1 , a_set_2 , a_set_3 , a_set_4 , a_set , a_grade , a_fame , a_rare_index_0 , a_rare_index_1 , a_rare_index_2 , a_rare_index_3 , a_rare_index_4 , a_rare_index_5 , a_rare_index_6 , a_rare_index_7 , a_rare_index_8 , a_rare_index_9 , a_rare_prob_0 , a_rare_prob_1 , a_rare_prob_2 , a_rare_prob_3 , a_rare_prob_4 , a_rare_prob_5 , a_rare_prob_6 , a_rare_prob_7 , a_rare_prob_8 , a_rare_prob_9 , a_effect_name, a_attack_effect_name, a_damage_effect_name, a_quest_trigger_count , a_quest_trigger_ids , a_origin_variation1 , a_origin_variation2 , a_origin_variation3 , a_origin_variation4 , a_origin_variation5 , a_origin_variation6 , a_rvr_value , a_rvr_grade , a_durability , a_castle_war, a_name_frc, a_name_ita, a_name_usa, a_name_rus,  a_name_thai, a_name_pld, a_name_spn, a_name_brz, a_name_ger, a_descr_frc, a_descr_ita, a_descr_usa, a_descr_rus, a_descr_thai, a_descr_pld, a_descr_spn, a_descr_brz, a_descr_ger, a_name_mex, a_descr_mex from t_item WHERE a_index ='" + TbIndex.Text + "';"; //dethunter12 4/11/2018 lang edit
            string[] rows = new string[113]
            {
        "a_index",//0
        "a_type_idx", //1
        "a_subtype_idx", //2
        "a_enable", //3
        "a_name", //4
        "a_descr", //5
        "a_job_flag", //6
        "a_flag", //7
        "a_wearing", //8
        "a_num_0", //9
        "a_num_1", //10
        "a_num_2",//11
        "a_num_3",//12
        "a_num_4",//13
        "a_level",//14
        "a_level2",//15
        "a_weight",//16
        "a_price",//17
        "a_max_use",//18
        "a_drop_prob_10",//19
        "a_need_item0",//20
        "a_need_item1",//21
        "a_need_item2",//22
        "a_need_item3",//23
        "a_need_item4",//24
        "a_need_item5",//25
        "a_need_item6",//26
        "a_need_item7",//27
        "a_need_item8",//28
        "a_need_item9",//29
        "a_need_item_count0",//30
        "a_need_item_count1",//31
        "a_need_item_count2",//32
        "a_need_item_count3",//33
        "a_need_item_count4",//34
        "a_need_item_count5",//35
        "a_need_item_count6",//36
        "a_need_item_count7",//37
        "a_need_item_count8",//38
        "a_need_item_count9",//39
        "a_need_sskill",//40
        "a_need_sskill_level",//41
        "a_need_sskill2",//42
        "a_need_sskill_level2",//43
        "a_zone_flag",//44
        "a_file_smc",//45
        "a_texture_id",//46
        "a_texture_row",//47
        "a_texture_col",//48
        "b_todo_delete",//49
        "a_set_0",//50
        "a_set_1",//51
        "a_set_2",//52
        "a_set_3",//53
        "a_set_4",//54
        "a_set",//55
        "a_grade",//56
        "a_fame",//57
        "a_rare_index_0",//58
        "a_rare_index_1",//59
        "a_rare_index_2",//60
        "a_rare_index_3",//61
        "a_rare_index_4",//62
        "a_rare_index_5",//63
        "a_rare_index_6",//64
        "a_rare_index_7",//65
        "a_rare_index_8",//66
        "a_rare_index_9",//67
        "a_rare_prob_0",//68
        "a_rare_prob_1",//69
        "a_rare_prob_2",//70
        "a_rare_prob_3",//71
        "a_rare_prob_4",//72
        "a_rare_prob_5",//73
        "a_rare_prob_6",//74
        "a_rare_prob_7",//75
        "a_rare_prob_8",//76
        "a_rare_prob_9",//77
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
        "a_castle_war", //92
        //select language name-desc
        "a_name_frc",//93
        "a_name_ita",//94
        "a_name_usa",//95
        "a_name_rus",//96
        "a_name_thai",//97
        "a_name_pld",//98
        "a_name_spn",//99
        "a_name_brz",//100
        "a_name_ger",//101
        //desc 9-17 total count = 9
        "a_descr_frc",//102
        "a_descr_ita",//103
        "a_descr_usa",//104
        "a_descr_rus",//105
        "a_descr_thai",//106
        "a_descr_pld",//107
        "a_descr_spn",//108
        "a_descr_brz",//109
        "a_descr_ger",//110
        "a_name_mex", //111
        "a_descr_mex" //112
      };
           
            Query.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'");
            string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query, rows);
           /* if ( File.Exists(_ClientPath + strArray[45])) //chk3D removed
            {
                Console.WriteLine("Create Model > " + _ClientPath + strArray[45]);
                MakeLCModels(_ClientPath + strArray[45]);
            }*/
            TbIndex.Text = strArray[0];
            TbType.Text = strArray[1];
            TbSubtype.Text = strArray[2];
            TbEnable.Text = strArray[3];
            TbName.Text = strArray[4];
            //dethunter12 4/11/2018 language add
            if (language == "FRA")
            {
                TbName.Text = strArray[93]; //name
                TbDescr.Text = strArray[102]; //descr 
            }
            else if (language == "USA")
            {
                TbName.Text = strArray[95];
                TbDescr.Text = strArray[104];
            }
            else if (language == "ITA")
            {
                TbName.Text = strArray[94];
                TbDescr.Text = strArray[103];
            }
            else if (language == "RUS")
            {
                TbName.Text = strArray[96];
                TbDescr.Text = strArray[105];
            }
            else if (language == "THA")

            {
                //Encoding encThai = Encoding.GetEncoding("windows-874");//First Encoding
                //byte[] data = encLatin_1.GetBytes(textBox5.Text);//read db
                //temp.Name = Encoding.GetEncoding("windows-874").GetString(data);//end encoding
                TbName.Text = strArray[97];
                TbDescr.Text = strArray[106];
            }
            else if (language == "POL")
            {
                TbName.Text = strArray[98];
                TbDescr.Text = strArray[107];
            }
            else if (language == "ESP")
            {
                TbName.Text = strArray[99];
                TbDescr.Text = strArray[108];
            }
            else if (language == "BRA")
            {
                TbName.Text = strArray[100];
                TbDescr.Text = strArray[109];
            }
            else if (language == "GER")
            {
                TbName.Text = strArray[101];
                TbDescr.Text = strArray[110];
            }
            else if (language == "MEX")
            {
                TbName.Text = strArray[111];
                TbDescr.Text = strArray[112];
            }
            else if (language != "GER" && language != "POL" && language != "BRA" && language != "RUS" && language != "FRA" && language != "ESP" && language != "MEX" && language != "THA" && language != "ITA" && language != "USA") //if language isnt any of the supported language lists then use default a_name 
            {
                TbName.Text = strArray[4];//name
                TbDescr.Text = strArray[5];//desc
            }
          //  textBox6.Text = strArray[5];
            TbJobFlag.Text = strArray[6];
            TbFlag.Text = strArray[7];
            TbWearing.Text = strArray[8];
            TbNum0.Text = strArray[9];
            TbNum1.Text = strArray[10];
            TbNum2.Text = strArray[11];
            TbNum3.Text = strArray[12];
            TbNum4.Text = strArray[13];
            TbMinLvl.Text = strArray[14];
            TbMaxlvl.Text = strArray[15];
            TbStackAmnt.Text = strArray[16];
            TbPrice.Text = strArray[17];
            TbMaxUse.Text = strArray[18];
            TbDropProb.Text = strArray[19];
            TbCraftItm1.Text = strArray[20];
            TbCraftItm2.Text = strArray[21];
            TbCraftItm3.Text = strArray[22];
            TbCraftItm4.Text = strArray[23];
            TbCraftItm5.Text = strArray[24];
            TbCraftItm6.Text = strArray[25];
            TbCraftItm7.Text = strArray[26];
            TbCraftItm8.Text = strArray[27];
            TbCraftItm9.Text = strArray[28];
            TbCraftItm10.Text = strArray[29];
            TbCraftAmnt1.Text = strArray[30];
            TbCraftAmnt2.Text = strArray[31];
            TbCraftAmnt3.Text = strArray[32];
            TbCraftAmnt4.Text = strArray[33];
            TbCraftAmnt5.Text = strArray[34];
            TbCraftAmnt6.Text = strArray[35];
            TbCraftAmnt7.Text = strArray[36];
            TbCraftAmnt8.Text = strArray[37];
            TbCraftAmnt9.Text = strArray[38];
            TbCraftAmnt10.Text = strArray[39];
            TbCraftSkillId1.Text = strArray[40];
            TbCraftSkillLevel1.Text = strArray[41];
            TbCraftSkillId2.Text = strArray[42];
            TbCraftSkillLevel2.Text = strArray[43];
            TbZoneFlag.Text = strArray[44];
            if (CbSaveIconSmc.Checked == true)
            {
                TbSmc.Text = TbSmc.Text;
                TbIconID.Text = TbIconID.Text;
                TbIconRow.Text = TbIconRow.Text;
                TbIconCol.Text = TbIconCol.Text;
                
            }
            else if (CbSaveIconSmc.Checked == false)
            {
                TbSmc.Text = strArray[45];
                TbIconID.Text = strArray[46];
                TbIconRow.Text = strArray[47];
                TbIconCol.Text = strArray[48];
            }
            TbUnkown.Text = strArray[49];
            TbSet0.Text = strArray[50];
            TbSet1.Text = strArray[51];
            TbSet2.Text = strArray[52];
            TbSet3.Text = strArray[53];
            TbSet4.Text = strArray[54];
            TbCommonRareID.Text = strArray[55];
            tbCommonRareRate.Text = strArray[56];
            TbFame.Text = strArray[57];
            //options and levels
            if (CbSaveValueAndLevel.Checked == true)
            {
                TbOptionID1.Text = TbOptionID1.Text;
                TbOptionID2.Text = TbOptionID2.Text;
                TbOptionID3.Text = TbOptionID3.Text;
                TbOptionID4.Text = TbOptionID4.Text;
                TbOptionID5.Text = TbOptionID5.Text;
                TbOptionID6.Text = TbOptionID6.Text;
                TbOptionID7.Text = TbOptionID7.Text;
                TbOptionID8.Text = TbOptionID8.Text;
                TbOptionID9.Text = TbOptionID9.Text;
                TbOptionID10.Text = TbOptionID10.Text;
                TbOptionLvl1.Text = TbOptionLvl1.Text;
                TbOptionLvl2.Text = TbOptionLvl2.Text;
                TbOptionLvl3.Text = TbOptionLvl3.Text;
                TbOptionLvl4.Text = TbOptionLvl4.Text;
                TbOptionLvl5.Text = TbOptionLvl5.Text;
                TbOptionLvl6.Text = TbOptionLvl6.Text;
                TbOptionLvl7.Text = TbOptionLvl7.Text;
                TbOptionLvl8.Text = TbOptionLvl8.Text;
                TbOptionLvl9.Text = TbOptionLvl9.Text;
                TbOptionLvl10.Text = TbOptionLvl10.Text;
            }
            else if (CbSaveValueAndLevel.Checked == false)
            {
                TbOptionID1.Text = strArray[58];
                TbOptionID2.Text = strArray[59];
                TbOptionID3.Text = strArray[60];
                TbOptionID4.Text = strArray[61];
                TbOptionID5.Text = strArray[62];
                TbOptionID6.Text = strArray[63];
                TbOptionID7.Text = strArray[64];
                TbOptionID8.Text = strArray[65];
                TbOptionID9.Text = strArray[66];
                TbOptionID10.Text = strArray[67];
                TbOptionLvl1.Text = strArray[68];
                TbOptionLvl2.Text = strArray[69];
                TbOptionLvl3.Text = strArray[70];
                TbOptionLvl4.Text = strArray[71];
                TbOptionLvl5.Text = strArray[72];
                TbOptionLvl6.Text = strArray[73];
                TbOptionLvl7.Text = strArray[74];
                TbOptionLvl8.Text = strArray[75];
                TbOptionLvl9.Text = strArray[76];
                TbOptionLvl10.Text = strArray[77];
            }
            //options and levels end 
            TbNormalEffect.Text = strArray[78];
            TbAttackEffect.Text = strArray[79];
            TbDamageEffect.Text = strArray[80];
            TbQuestTriggerCnt.Text = strArray[81];
            TbQuestTriggerID.Text = strArray[82];
            TbReformVaration1.Text = strArray[83];
            TbReformVaration2.Text = strArray[84];
            TbReformVaration3.Text = strArray[85];
            TbReformVaration4.Text = strArray[86];
            TbReformVaration5.Text = strArray[87];
            TbReformVaration6.Text = strArray[88];
            TbRvrVal.Text = strArray[89];
            TbRvrGrade.Text = strArray[90];
            TbDura.Text = strArray[91];
            TbCastle.Text = strArray[92];
            
            SelectBoxes();
            int int32 = Convert.ToInt32(strArray[6]);
            if (Episode == "EP4")
                ShowFlagLong1(Convert.ToInt64(strArray[7])); //dethunter12 add
            else
                ShowFlag(Convert.ToInt32(strArray[7]));
            ShowJobFlag(int32);
            // LoadMisc();
            try
            {
                pictureBox1.Image = (Image)databaseHandle.IconItem(int.Parse(TbIconID.Text), int.Parse(TbIconRow.Text), int.Parse(TbIconCol.Text));
            }
            catch
            {
            }
            long int64 = Convert.ToInt64(strArray[7]);
            if (FlagCheck(int64, 19) && !FlagCheck(int64, 26))
            {
                comboBox5.SelectedIndex = int.Parse(TbOptionID2.Text);
                comboBox6.SelectedIndex = int.Parse(TbOptionID3.Text);
                comboBox7.SelectedIndex = int.Parse(TbOptionID4.Text);
                comboBox8.SelectedIndex = int.Parse(TbOptionID5.Text);
                comboBox9.SelectedIndex = int.Parse(TbOptionID6.Text);
                comboBox10.SelectedIndex = int.Parse(TbOptionID7.Text);
                SetSelectedComboBoxPurple2();
            }
            _ComboBoxPurpleLocked = false;

            if(TbIndex.Text.Trim().Length>0)
                LoadFortuneData(TbIndex.Text);

            //cHaR fortune data




        }

        public bool FlagCheck(long Flag, int CheckFlag)
        {
            return (Flag & (long)(1 << CheckFlag)) > 0L;
        }

        /*private void SelectBoxes()
        {
                comboBox2.SelectedIndex = comboBox2.FindString(textBox3.Text);
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            descrr = LanguageHelper.DescrFromLanguage(); // description 
            namee = LanguageHelper.StringFromLanguage(); // language name (to simplify the query without having to add alot of if elseif)
            string str1 = "UPDATE t_item SET " + "a_type_idx = '" + TbType.Text + "', " + "a_subtype_idx = '" + TbSubtype.Text + "', " + "a_enable = '" + TbEnable.Text + "', ";
            string str2 = TbName.Text.Replace("'", "\\'").Replace("\"", "\\\"");
            string str3 = TbDescr.Text.Replace("'", "\\'").Replace("\"", "\\\"");

            try {
                var itemType = int.Parse(TbType.Text);
                var itemSubType = int.Parse(TbSubtype.Text);
                //refrence way to write better querys
              //  var sql = $"UPDATE t_item SET a_type_idx = ${itemType}, a_subtype_idx = ${itemSubType}...";
       
            databaseHandle.SendQueryMySql(Host, User, Password, Database, str1 + "a_name = '" + str2 + "', " + namee + "=" + " " + "'" + str2 + "', " + "a_descr = '" + str3 + "', " + descrr + "='" + str3 + "', " + "a_job_flag = '" + TbJobFlag.Text + "', " + "a_flag = '" + TbFlag.Text + "', " + "a_wearing = '" + TbWearing.Text + "', " + "a_num_0 = '" + TbNum0.Text + "', " + "a_num_1 = '" + TbNum1.Text + "', " + "a_num_2 = '" + TbNum2.Text + "', " + "a_num_3 = '" + TbNum3.Text + "', " + "a_num_4 = '" + TbNum4.Text + "', " + "a_level = '" + TbMinLvl.Text + "', " + "a_level2 = '" + TbMaxlvl.Text + "', " + "a_weight = '" + TbStackAmnt.Text + "', " + "a_price = '" + TbPrice.Text + "', " + "a_max_use = '" + TbMaxUse.Text + "', " + "a_drop_prob_10 = '" + TbDropProb.Text + "', " + "a_need_item0 = '" + TbCraftItm1.Text + "', " + "a_need_item1 = '" + TbCraftItm2.Text + "', " + "a_need_item2 = '" + TbCraftItm3.Text + "', " + "a_need_item3 = '" + TbCraftItm4.Text + "', " + "a_need_item4 = '" + TbCraftItm5.Text + "', " + "a_need_item5 = '" + TbCraftItm6.Text + "', " + "a_need_item6 = '" + TbCraftItm7.Text + "', " + "a_need_item7 = '" + TbCraftItm8.Text + "', " + "a_need_item8 = '" + TbCraftItm9.Text + "', " + "a_need_item9 = '" + TbCraftItm10.Text + "', " + "a_need_item_count0 = '" + TbCraftAmnt1.Text + "', " + "a_need_item_count1 = '" + TbCraftAmnt2.Text + "', " + "a_need_item_count2 = '" + TbCraftAmnt3.Text + "', " + "a_need_item_count3 = '" + TbCraftAmnt4.Text + "', " + "a_need_item_count4 = '" + TbCraftAmnt5.Text + "', " + "a_need_item_count5 = '" + TbCraftAmnt6.Text + "', " + "a_need_item_count6 = '" + TbCraftAmnt7.Text + "', " + "a_need_item_count7 = '" + TbCraftAmnt8.Text + "', " + "a_need_item_count8 = '" + TbCraftAmnt9.Text + "', " + "a_need_item_count9 = '" + TbCraftAmnt10.Text + "', " + "a_need_sskill = '" + TbCraftSkillId1.Text + "', " + "a_need_sskill_level = '" + TbCraftSkillLevel1.Text + "', " + "a_need_sskill2 = '" + TbCraftSkillId2.Text + "', " + "a_need_sskill_level2 = '" + TbCraftSkillLevel2.Text + "', " + "a_zone_flag = '" + TbZoneFlag.Text + "', " + "a_file_smc = '" + TbSmc.Text.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'") + "', " + "a_texture_id = '" + TbIconID.Text + "', " + "a_texture_row = '" + TbIconRow.Text + "', " + "a_texture_col = '" + TbIconCol.Text + "', " + "b_todo_delete = '" + TbUnkown.Text + "', " + "a_set_0 = '" + TbSet0.Text + "', " + "a_set_1 = '" + TbSet1.Text + "', " + "a_set_2 = '" + TbSet2.Text + "', " + "a_set_3 = '" + TbSet3.Text + "', " + "a_set_4 = '" + TbSet4.Text + "', " + "a_set = '" + TbCommonRareID.Text + "', " + "a_grade = '" + tbCommonRareRate.Text + "', " + "a_fame = '" + TbFame.Text + "', " + "a_rare_index_0 = '" + TbOptionID1.Text + "', " + "a_rare_index_1 = '" + TbOptionID2.Text + "', " + "a_rare_index_2 = '" + TbOptionID3.Text + "', " + "a_rare_index_3 = '" + TbOptionID4.Text + "', " + "a_rare_index_4 = '" + TbOptionID5.Text + "', " + "a_rare_index_5 = '" + TbOptionID6.Text + "', " + "a_rare_index_6 = '" + TbOptionID7.Text + "', " + "a_rare_index_7 = '" + TbOptionID8.Text + "', " + "a_rare_index_8 = '" + TbOptionID9.Text + "', " + "a_rare_index_9 = '" + TbOptionID10.Text + "', " + "a_rare_prob_0 = '" + TbOptionLvl1.Text + "', " + "a_rare_prob_1 = '" + TbOptionLvl2.Text + "', " + "a_rare_prob_2 = '" + TbOptionLvl3.Text + "', " + "a_rare_prob_3 = '" + TbOptionLvl4.Text + "', " + "a_rare_prob_4 = '" + TbOptionLvl5.Text + "', " + "a_rare_prob_5 = '" + TbOptionLvl6.Text + "', " + "a_rare_prob_6 = '" + TbOptionLvl7.Text + "', " + "a_rare_prob_7 = '" + TbOptionLvl8.Text + "', " + "a_rare_prob_8 = '" + TbOptionLvl9.Text + "', " + "a_rare_prob_9 = '" + TbOptionLvl10.Text + "', " + "a_effect_name = '" + TbNormalEffect.Text + "', " + "a_attack_effect_name = '" + TbAttackEffect.Text + "', " + "a_damage_effect_name = '" + TbDamageEffect.Text + "', " + "a_quest_trigger_count = '" + TbQuestTriggerCnt.Text + "', " + "a_quest_trigger_ids = '" + TbQuestTriggerID.Text + "', " + "a_origin_variation1 = '" + TbReformVaration1.Text + "', " + "a_origin_variation2 = '" + TbReformVaration2.Text + "', " + "a_origin_variation3 = '" + TbReformVaration3.Text + "', " + "a_origin_variation4 = '" + TbReformVaration4.Text + "', " + "a_origin_variation5 = '" + TbReformVaration5.Text + "', " + "a_origin_variation6 = '" + TbReformVaration6.Text + "', " + "a_rvr_value = '" + TbRvrVal.Text + "', " + "a_rvr_grade = '" + TbRvrGrade.Text + "', " + "a_durability = '" + TbDura.Text + "', " + "a_castle_war = '" + TbCastle.Text + "' " + "WHERE a_index = '" + TbIndex.Text + "'");
                int selectedIndex = listBox1.SelectedIndex;
                if (textBox12.Text != "")
                    SearchList(textBox12.Text);
                else
                    LoadListBox();
                listBox1.SelectedIndex = selectedIndex;
                int num4 = (int)new CustomMessage("Done :)").ShowDialog();
            }
            catch(FormatException)
            {
                new CustomMessage("Cant parse value").ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "INSERT INTO t_item DEFAULT VALUES");
            LoadListBox();
            TbEnable.Text = "1";//values get set but once you click off the value it doesn't save (not saving the new values given)
            TbZoneFlag.Text = "1023";
            checkBox1.Checked = true;
            checkBox1.BackColor = Color.Lime;
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_item WHERE a_index = '" + TbIndex.Text + "'");
             LoadListBox();
            if (textBox12.Text != "") // if the text box field is not empty 
                SearchList(textBox12.Text);
            listBox1.SelectedIndex = selectedIndex - 1;
            int num2 = (int)new CustomMessage("Deleted :O").ShowDialog();
        }

        private async void exportlodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pb_loading.Visible = true;
            await exportLodHandle.ExportItemAll_V4Async();
            pb_loading.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TbEnable.Text = "1";
                checkBox1.BackColor = Color.Lime;
            }
            else
            {
                TbEnable.Text = "0";
                checkBox1.BackColor = Color.Red;
            }
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
                comboBox3.Items.Add(str4);
                comboBox5.Items.Add(str4);
                comboBox6.Items.Add(str4);
                comboBox7.Items.Add(str4);
                comboBox8.Items.Add(str4);
                comboBox9.Items.Add(str4);
                comboBox10.Items.Add(str4);
                comboBox11.Items.Add(str4);
                comboBox12.Items.Add(str4);
                comboBox13.Items.Add(str4);
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
            checkedListBox2.Items.AddRange(new object[9]
      {
         "Titan",
         "Knight",
         "Healer",
         "Mage",
         "Rogue",
         "Sorcerer",
         "NS",
         "Ex-Rogue",
         "Ex-Mage"
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
            ClbItemFlag.Items.AddRange(new object[64] //dethunter12 test item flag move
        {
           "Count",
           "Drop",
           "Upgrade",
           "Exchange",
           "Sell(NPC)",
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
           "Purple Seals",
           "Trigger",
           "Raid Special",
           "Quest",
           "LuckyDraw Box",
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
            comboBox4.Items.AddRange(new object[19]
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
         "12 - Insignia Slot",
         "13 - RUNE 1 Slot",
         "14 - RUNE 2 Slot",
         "15 - Rune 3 Slot",
         "16 - Rune 4 Slot",
         "17 - Legendary Rune"
      });

            comboBox24.Items.AddRange(new object[3] //dethunter12 add
     {
         "0 - None",
         "1 - KAILUX",
         "2 - DEALERMOON"
     });

            comboBox25.Items.AddRange(new object[10] //dethunter12 add
     {
         "0 - None", //dethunter12 add 8/15/2018
         "1 - SQUIRE",
         "2 - KNIGHT",
         "3 - GENTOR",
         "4 - HONORISE",
         "5 - BARONE",
         "6 - VISCONTE",
         "7 - CONTE",
         "8 - BARONE",
         "9 - MARQUISE"
     });

            comboBox26.Items.AddRange(new object[6] //dethunter12 add
     {
         "0- None", //dethunter12 add 8/15/2018
         "1 - NEOPTYE",
         "2 - ZELATOR",
         "3 - THEORICUS",
         "4 - PHILOSOPHUS",
         "5 - ADEPTUS"
     });

            comboBox2.Items.AddRange(new object[16] //dethunter12 add
      { //re-arrange the values and see if it still works test ;P
         "0 - Single Sword",
         "1 - X-Bow",
         "2 - Staff",
         "3 - Big Sword",
         "4 - Axe",
         "5 - Wand",
         "6 - Bow",
         "7 - Dagger",
         "8 - Hammer",
         "9 - Knife",
         "10 - Energy Collector",
         "11 - Dual Swords",
         "12 - Scepter",
        // "2 - Staff",
         //"3 - Big Sword",
         //"4 - Axe",
        // "5 - Wand",
         //"6 - Bow",
        // "7 - Dagger",
        // "8 - Hammer",
        // "9 - Knife",
        // "10 - Energy Collector",
       //  "11 - Dual Swords",
       //  "12 - Scepter",
         "13 - Scythe",
         "14 - Fallarm",
         "15 - NS Weapon",
        
      });
            CbSubtype1.Items.AddRange(new object[8] //dethunter12 add
 {
         "0 - Helm",
         "1 - Shirt",
         "2 - Pants",
         "3 - Gloves",
         "4 - Boots",
         "5 - Shield",
         "6 - Wing",
         "7 - Complete Costume"
 });
            CbSubtype2.Items.AddRange(new object[35] //dethunter12 add
 {
         "0 - Teleporting",
         "1 - Production Manual",
         "2 - Crafting Manual",
         "3 - Box",
         "4 - Potion Manual",
         "5 - Transformation Scrolls",
         "6 - Quest Scrolls",
         "7 - Changing Stuff",
         "8 - Mob Summoning",
         "9 - Boxes and Monstercombo",
         "10 - Attack Scrolls",
         "11 - Titles",
         "12 - Reward Package",
         "13 - Jumping Potion",
         "14 - Extend Character Slot",
         "15 - Server Trans",
         "16 - Remote Express",
         "17 - Jewel Pocket",
         "18 - Chaos Jewel Pocket",
         "19 - Cash Inventory",
         "20 - Pet Stash",
         "21 - GPS",
         "22 - Holy Water",
         "23 - Protect PVP",
         "24 - Seal Item",
         "25 - statpt_remain_200",
         "26 - statpt_remain_500",
         "27 - CASH_COLOR",
         "28 - CASH_COLOR1",
         "29 - CASH_COLOR2",
         "30 - CASH_COLOR3",
         "31 - CASH_COLOR4",
         "32 - CASH_COLOR5",
         "33 - CASH_COLOR6",
         "34 - CASH_COLOR7"
 });
            CbSubtype3.Items.AddRange(new object[3] //dethunter12 add
 {
         "0 - Item Bullet Attack",
         "1 - Item Bullet Mana",
         "2 - Item Bullet Arrow",
 });
            CbSubType4.Items.AddRange(new object[25] //dethunter12 add
{
         "0 - Quest Items",
         "1 - Event",
         "2 - SkillUp",
         "3 - Upgrade Stuff",
         "4 - Materials & Skillbooks",
         "5 - Gold",
         "6 - Materials 1",
         "7 - Materials 2",
         "8 - Bloodseal Items",
         "9 - Powder",
         "10 - Event Items 1",
         "11 - Castle Siege Concentration",
         "12 - Castle Siege Powder",
         "13 - Castle Siege Stone",
         "14 - [P2] Target",
         "15 - Quest Trigger",
         "16 - Socket Jewel",
         "17 - Socket Upgrading",
         "18 - Socket Creation",
         "19 - Monster Mercenary",
         "20 - Guild Mark",
         "21 - Reformer",
         "22 - Chaos jewel",
         "23 - Function",
         "24 - RvR Jewel"
});
            CbSubType5.Items.AddRange(new object[9] //dethunter12 add
{
         "0 - Accesoires Charm",
         "1 - Accesoires Magic Stone",
         "2 - Accesoires Light Stone",
         "3 - Accesoires Earing",
         "4 - Accesoires Ring",
         "5 - Accesoires Necklace",
         "6 - P1 Pet",
         "7 - P2 Pet",
         "8 - Artifact"
});
            CbSubType6.Items.AddRange(new object[14] //dethunter12 add
{
         "0 - Antidotes / Cures",
         "1 - HP Heal Potions",
         "2 - MP Heal Potions",
         "3 - HP+MP Heal Potions",
         "4 - HP, MP, Attack Boost",
         "5 - Steroids",
         "6 - Minerals",
         "7 - Tears",
         "8 - Exp Crystals",
         "9 - NPC Scroll",
         "10 - HP Recovery Speed Potions",
         "11 - MP Recovery Speed Potions",
         "12 - [P2] Heal Items",
         "13 - [P2] SpeedUp"
});
            CbSubType7.Items.AddRange(new object[1] //dethunter12 add
{
         "-1 - Unkown"
});
        }

        public static string[] SubTypes(int Type)
        {
            System.Collections.Generic.List<string> stringList = new System.Collections.Generic.List<string>();
            switch (Type)
            {
                case 0:
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
                    stringList.Add("0 - Item Bullet Attack");
                    stringList.Add("1 - Item Bullet Mana");
                    stringList.Add("2 - Item Bullet Arrow");
                    break;
                case 4:
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // comboBox2.Items.Clear();
            // comboBox2.Items.AddRange((object[]) ItemEditor2.SubTypes(comboBox1.SelectedIndex));
            TbType.Text = comboBox1.SelectedIndex.ToString();
            if (TbType.Text == "-1")
            {
                CbSubType7.Visible = true;
                comboBox2.Visible = false;
                CbSubtype1.Visible = false;
                CbSubtype2.Visible = false;
                CbSubtype3.Visible = false;
                CbSubType4.Visible = false;
                CbSubType5.Visible = false;
                CbSubType6.Visible = false;
            }
            else if (TbType.Text == "0")
            {
                CbSubType7.Visible = false;
                comboBox2.Visible = true;
                CbSubtype1.Visible = false;
                CbSubtype2.Visible = false;
                CbSubtype3.Visible = false;
                CbSubType4.Visible = false;
                CbSubType5.Visible = false;
                CbSubType6.Visible = false;
            }

            else if (TbType.Text == "1")
            {
                CbSubType7.Visible = false;
                comboBox2.Visible = false;
                CbSubtype1.Visible = true;
                CbSubtype2.Visible = false;
                CbSubtype3.Visible = false;
                CbSubType4.Visible = false;
                CbSubType5.Visible = false;
                CbSubType6.Visible = false;
            }

            else if (TbType.Text == "2")
            {
                CbSubType7.Visible = false;
                comboBox2.Visible = false;
                CbSubtype1.Visible = false;
                CbSubtype2.Visible = true;
                CbSubtype3.Visible = false;
                CbSubType4.Visible = false;
                CbSubType5.Visible = false;
                CbSubType6.Visible = false;
            }

            else if (TbType.Text == "3")
            {
                CbSubType7.Visible = false;
                comboBox2.Visible = false;
                CbSubtype1.Visible = false;
                CbSubtype2.Visible = false;
                CbSubtype3.Visible = true;
                CbSubType4.Visible = false;
                CbSubType5.Visible = false;
                CbSubType6.Visible = false;
            }

            else if (TbType.Text == "4")
            {
                CbSubType7.Visible = false;
                comboBox2.Visible = false;
                CbSubtype1.Visible = false;
                CbSubtype2.Visible = false;
                CbSubtype3.Visible = false;
                CbSubType4.Visible = true;
                CbSubType5.Visible = false;
                CbSubType6.Visible = false;
            }

            else if (TbType.Text == "5")
            {
                CbSubType7.Visible = false;
                comboBox2.Visible = false;
                CbSubtype1.Visible = false;
                CbSubtype2.Visible = false;
                CbSubtype3.Visible = false;
                CbSubType4.Visible = false;
                CbSubType5.Visible = true;
                CbSubType6.Visible = false;
            }

            else if (TbType.Text == "6")
            {
                CbSubType7.Visible = false;
                comboBox2.Visible = false;
                CbSubtype1.Visible = false;
                CbSubtype2.Visible = false;
                CbSubtype3.Visible = false;
                CbSubType4.Visible = false;
                CbSubType5.Visible = false;
                CbSubType6.Visible = true;
            }
            // LoadMisc();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TbType.Text == "0")
            {
                TbSubtype.Text = GetIndexByComboBox(comboBox2.Text).ToString();
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbWearing.Text = GetIndexByComboBox(comboBox4.Text).ToString();
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

        private void ShowFlagLong1(long flag) //dethunter12 add
        {
            for (int index = 0; index < 64; ++index)
            ClbItemFlag.SetItemChecked(index, (flag & 1L << index) > 0L); //dethunter12 add
        }

        private void ShowFlag(int flag)
        {
            for (int index = 0; index < clbFlagTest.Items.Count; ++index)
                clbFlagTest.SetItemChecked(index, (flag & 1 << index) > 0);
            for (int index = 0; index < ClbItemFlag.Items.Count; ++index)
                ClbItemFlag.SetItemChecked(index, (flag & 1L << index) > 0L); //dethunter12 add
        }

        private void button4_Click(object sender, EventArgs e)
        {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DROP TABLE IF EXISTS tempTable;" + "CREATE TEMPORARY TABLE tempTable ENGINE=MEMORY SELECT * FROM t_item WHERE a_index=" + TbIndex.Text + ";" + "SELECT a_index FROM tempTable;" + "UPDATE tempTable SET a_index=(SELECT a_index from t_item ORDER BY a_index DESC LIMIT 1)+1; " + "SELECT a_index FROM tempTable;" + "INSERT INTO t_item SELECT * FROM tempTable;");
            LoadListBox();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            if (textBox12.Text != "")
                SearchList(textBox12.Text);
            int num5 = (int)new CustomMessage("Copying Complete").ShowDialog();
        }

        private void exportStrItemlodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExport f2 = new FormExport();
            f2.Show(); // Shows Form2
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = 0;
            for (int index = 0; index < checkedListBox1.Items.Count; ++index)
            {
                if (checkedListBox1.GetItemChecked(index))
                    num += 1 << index;
            }
            TbJobFlag.Text = num.ToString();
        }

        private void clbFlagTest_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            long num = 0;
            for (int index = 0; index < clbFlagTest.Items.Count; ++index)
            {
                if (clbFlagTest.GetItemChecked(index))
                    num += 1L << index;
            }
            TbFlag.Text = num.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbOptionID1.Text = comboBox3.SelectedIndex.ToString();
            List = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + TbOptionID1.Text + "' ORDER BY a_index;");
            comboBox14.DataSource = null;
            comboBox14.Items.Clear();
            comboBox14.DataSource = List;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbOptionID2.Text = comboBox5.SelectedIndex.ToString();
            List2 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + TbOptionID2.Text + "' ORDER BY a_index;");
            comboBox15.DataSource = null;
            comboBox15.Items.Clear();
            comboBox15.DataSource = List2;
            if (!(TbOptionID2.Text != "-1"))
                return;
            comboBox15.SelectedIndex = Convert.ToInt32(TbOptionLvl2.Text) - 1;
        }

        private void SetSelectedComboBoxPurple2()
        {
            if (TbOptionID2.Text != "-1")
                comboBox15.SelectedIndex = Convert.ToInt32(TbOptionLvl2.Text) - 1;
            if (TbOptionID3.Text != "-1")
                comboBox16.SelectedIndex = Convert.ToInt32(TbOptionLvl3.Text) - 1;
            if (TbOptionID4.Text != "-1")
                comboBox17.SelectedIndex = Convert.ToInt32(TbOptionLvl4.Text) - 1;
            if (TbOptionID5.Text != "-1")
                comboBox18.SelectedIndex = Convert.ToInt32(TbOptionLvl5.Text) - 1;
            if (TbOptionID6.Text != "-1")
                comboBox19.SelectedIndex = Convert.ToInt32(TbOptionLvl6.Text) - 1;
            if (!(TbOptionID7.Text != "-1"))
                return;
            comboBox20.SelectedIndex = Convert.ToInt32(TbOptionLvl7.Text) - 1;
        }

        private void ClearComboBoxPurple2()
        {
            comboBox15.SelectedIndex = -1;
            comboBox16.SelectedIndex = -1;
            comboBox17.SelectedIndex = -1;
            comboBox18.SelectedIndex = -1;
            comboBox19.SelectedIndex = -1;
            comboBox20.SelectedIndex = -1;
        }

        private void ClearComboBoxPurple()
        {
            comboBox3.SelectedIndex = -1; //dethunter12 add
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            comboBox8.SelectedIndex = -1;
            comboBox9.SelectedIndex = -1;
            comboBox10.SelectedIndex = -1;
            comboBox11.SelectedIndex = -1; //dethunter12 add
            comboBox12.SelectedIndex = -1; //dethunter12 add
            comboBox13.SelectedIndex = -1; //dethunter12 add


        }

        private void UnClearComboBox()
        {
            comboBox3.SelectedIndex = comboBox3.SelectedIndex; //dethunter12 add
            comboBox5.SelectedIndex = comboBox5.SelectedIndex;
            comboBox6.SelectedIndex = comboBox6.SelectedIndex;
            comboBox7.SelectedIndex = comboBox7.SelectedIndex;
            comboBox8.SelectedIndex = comboBox8.SelectedIndex;
            comboBox9.SelectedIndex = comboBox9.SelectedIndex;
            comboBox10.SelectedIndex = comboBox10.SelectedIndex;
            comboBox11.SelectedIndex = comboBox11.SelectedIndex; //dethunter12 add
            comboBox12.SelectedIndex = comboBox12.SelectedIndex; //dethunter12 add
            comboBox13.SelectedIndex = comboBox13.SelectedIndex; //dethunter12 add


        }
        private void ResetComboBoxPurpleBg() //dethunter12 add
        {
            comboBox3.BackColor = Color.White;
            comboBox5.BackColor = Color.White;
            comboBox6.BackColor = Color.White;
            comboBox7.BackColor = Color.White;
            comboBox8.BackColor = Color.White;
            comboBox9.BackColor = Color.White;
            comboBox10.BackColor = Color.White;
            comboBox11.BackColor = Color.White;
            comboBox12.BackColor = Color.White;
            comboBox13.BackColor = Color.White;

        }

        private void ResetTextBoxBackground() //dethunter12 add
        {
            //basic
            TbIndex.BackColor = Color.White;
            TbZoneFlag.BackColor = Color.White;
            TbName.BackColor = Color.White;
            TbDescr.BackColor = Color.White;
            TbSmc.BackColor = Color.White;
            //icon
            TbIconID.BackColor = Color.White;
            TbIconRow.BackColor = Color.White;
            TbIconCol.BackColor = Color.White;
            //Stats
            TbMinLvl.BackColor = Color.White;
            TbMaxlvl.BackColor = Color.White;
            TbStackAmnt.BackColor = Color.White;
            TbPrice.BackColor = Color.White;
            TbDropProb.BackColor = Color.White;
            //Common Rare Option
            TbCommonRareID.BackColor = Color.White;
            tbCommonRareRate.BackColor = Color.White;
            //RvR
            TbRvrVal.BackColor = Color.White;
            TbRvrGrade.BackColor = Color.White;
            comboBox24.BackColor = Color.White;
            comboBox25.BackColor = Color.White;
            comboBox26.BackColor = Color.White;
            //Item Special Effects
            TbNormalEffect.BackColor = Color.White;
            TbAttackEffect.BackColor = Color.White;
            TbDamageEffect.BackColor = Color.White;
            //option 
            TbNum0.BackColor = Color.White;
            TbNum1.BackColor = Color.White;
            TbNum2.BackColor = Color.White;
            TbNum3.BackColor = Color.White;
            TbNum4.BackColor = Color.White;
            //random settings
            TbSet0.BackColor = Color.White;
            TbSet1.BackColor = Color.White;
            TbSet2.BackColor = Color.White;
            TbSet3.BackColor = Color.White;
            TbSet4.BackColor = Color.White;
            //origin
            TbReformVaration1.BackColor = Color.White;
            TbReformVaration2.BackColor = Color.White;
            TbReformVaration3.BackColor = Color.White;
            TbReformVaration4.BackColor = Color.White;
            TbReformVaration5.BackColor = Color.White;
            TbReformVaration6.BackColor = Color.White;
            //misc
            TbFame.BackColor = Color.White;
            TbUnkown.BackColor = Color.White;
            TbCastle.BackColor = Color.White;
            TbDura.BackColor = Color.White;
            TbQuestTriggerCnt.BackColor = Color.White;
            TbQuestTriggerID.BackColor = Color.White;
            //character
            TbType.BackColor = Color.White;
            TbSubtype.BackColor = Color.White;
            TbJobFlag.BackColor = Color.White;
            TbWearing.BackColor = Color.White;
            TbFlag.BackColor = Color.White;
            TbMaxUse.BackColor = Color.White;
            //crafting
            TbCraftSkillId1.BackColor = Color.White;
            TbCraftSkillLevel1.BackColor = Color.White;
            TbCraftSkillId2.BackColor = Color.White;
            TbCraftSkillLevel2.BackColor = Color.White;
            //itemcrafting
            TbCraftItm1.BackColor = Color.White;
            TbCraftItm2.BackColor = Color.White;
            TbCraftItm3.BackColor = Color.White;
            TbCraftItm4.BackColor = Color.White;
            TbCraftItm5.BackColor = Color.White;
            TbCraftAmnt1.BackColor = Color.White;
            TbCraftAmnt2.BackColor = Color.White;
            TbCraftAmnt3.BackColor = Color.White;
            TbCraftAmnt4.BackColor = Color.White;
            TbCraftAmnt5.BackColor = Color.White;
            TbCraftItm6.BackColor = Color.White;
            TbCraftItm7.BackColor = Color.White;
            TbCraftItm8.BackColor = Color.White;
            TbCraftItm9.BackColor = Color.White;
            TbCraftItm10.BackColor = Color.White;
            TbCraftAmnt6.BackColor = Color.White;
            TbCraftAmnt7.BackColor = Color.White;
            TbCraftAmnt8.BackColor = Color.White;
            TbCraftAmnt9.BackColor = Color.White;
            TbCraftAmnt10.BackColor = Color.White;
            //rareoption
            TbOptionID1.BackColor = Color.White;
            TbOptionID2.BackColor = Color.White;
            TbOptionID3.BackColor = Color.White;
            TbOptionID4.BackColor = Color.White;
            TbOptionID5.BackColor = Color.White;
            TbOptionID6.BackColor = Color.White;
            TbOptionID7.BackColor = Color.White;
            TbOptionID8.BackColor = Color.White;
            TbOptionID9.BackColor = Color.White;
            TbOptionID10.BackColor = Color.White;
            TbOptionLvl1.BackColor = Color.White;
            TbOptionLvl2.BackColor = Color.White;
            TbOptionLvl3.BackColor = Color.White;
            TbOptionLvl4.BackColor = Color.White;
            TbOptionLvl5.BackColor = Color.White;
            TbOptionLvl6.BackColor = Color.White;
            TbOptionLvl7.BackColor = Color.White;
            TbOptionLvl8.BackColor = Color.White;
            TbOptionLvl9.BackColor = Color.White;
            TbOptionLvl10.BackColor = Color.White;
            //percent
            TbPercent.BackColor = Color.White;
            TbPercent1.BackColor = Color.White;
            TbPercent2.BackColor = Color.White;
            TbPercent.Text = "";
            TbPercent1.Text = "";
            TbPercent2.Text = "";
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbOptionLvl1.Text = comboBox14.SelectedIndex.ToString();
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ComboBoxPurpleLocked)
                return;
            TbOptionLvl2.Text = (comboBox15.SelectedIndex + 1).ToString();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbOptionID3.Text = comboBox6.SelectedIndex.ToString();
            List3 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + TbOptionID3.Text + "' ORDER BY a_index;");
            comboBox16.DataSource = null;
            comboBox16.Items.Clear();
            comboBox16.DataSource = List3;
          //  if (!(textBox62.Text != "-1"))
            //    return;
           // comboBox16.SelectedIndex = Convert.ToInt32(textBox72.Text);
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ComboBoxPurpleLocked)
                return;
            TbOptionLvl3.Text = (comboBox16.SelectedIndex + 1).ToString();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbOptionID4.Text = comboBox7.SelectedIndex.ToString();
            List4 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + TbOptionID4.Text + "' ORDER BY a_index;");
            comboBox17.DataSource = null;
            comboBox17.Items.Clear();
            comboBox17.DataSource = List4;
          //  if (!(textBox63.Text != "-1"))
          //      return;
           // comboBox17.SelectedIndex = Convert.ToInt32(textBox73.Text);
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ComboBoxPurpleLocked)
                return;
            TbOptionLvl4.Text = (comboBox17.SelectedIndex + 1).ToString();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbOptionID5.Text = comboBox8.SelectedIndex.ToString();
            List5 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + TbOptionID5.Text + "' ORDER BY a_index;");
            comboBox18.DataSource = null;
            comboBox18.Items.Clear();
            comboBox18.DataSource = List5;
           // if (!(textBox64.Text != "-1"))
           //     return;
           // comboBox18.SelectedIndex = Convert.ToInt32(textBox74.Text);
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ComboBoxPurpleLocked)
                return;
            TbOptionLvl5.Text = (comboBox18.SelectedIndex + 1).ToString();
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbOptionID6.Text = comboBox9.SelectedIndex.ToString();
            List6 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + TbOptionID6.Text + "' ORDER BY a_index;");
            comboBox19.DataSource = null;
            comboBox19.Items.Clear();
            comboBox19.DataSource = List6;
         //   if (!(textBox65.Text != "-1"))
           //     return;
           // comboBox19.SelectedIndex = Convert.ToInt32(textBox75.Text);
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ComboBoxPurpleLocked)
                return;
            TbOptionLvl6.Text = (comboBox19.SelectedIndex + 1).ToString();
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbOptionID7.Text = comboBox10.SelectedIndex.ToString();
            List7 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + TbOptionID7.Text + "' ORDER BY a_index;");
            comboBox20.DataSource = null;
            comboBox20.Items.Clear();
            comboBox20.DataSource = List7;
           // if (!(textBox66.Text != "-1"))
           //     return;
          //  comboBox20.SelectedIndex = Convert.ToInt32(textBox76.Text);
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_ComboBoxPurpleLocked)
                return;
            TbOptionLvl7.Text = (comboBox20.SelectedIndex + 1).ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IconPickerItem iconPickerItem = new IconPickerItem();
            iconPickerItem.OldItemBtnSelect = Convert.ToInt32(TbIconID.Text);
            if (iconPickerItem.ShowDialog() != DialogResult.OK) 
                return;
            TbIconID.Text = iconPickerItem.TexID.ToString();
            TbIconRow.Text = iconPickerItem.TexColumn.ToString();
            TbIconCol.Text = iconPickerItem.TexRow.ToString();
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_item SET " + "a_texture_id = '" + TbIconID.Text + "', " + "a_texture_row = '" + TbIconCol.Text + "', " + "a_texture_col = '" + TbIconRow.Text + "' " + "WHERE a_index = '" + TbIndex.Text + "'");
            int selectedIndex = listBox1.SelectedIndex;
            if (textBox12.Text != "")
                SearchList(textBox12.Text);
            else
                LoadListBox();
            listBox1.SelectedIndex = selectedIndex;
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbOptionID8.Text = comboBox11.SelectedIndex.ToString();
            List8 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + TbOptionID8.Text + "' ORDER BY a_index;");
            comboBox21.DataSource = null;
            comboBox21.Items.Clear();
            comboBox21.DataSource = List8;
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbOptionLvl8.Text = comboBox21.SelectedIndex.ToString();
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbOptionID9.Text = comboBox12.SelectedIndex.ToString();
            List9 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + TbOptionID9.Text + "' ORDER BY a_index;");
            comboBox22.DataSource = null;
            comboBox22.Items.Clear();
            comboBox22.DataSource = List9;
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbOptionLvl9.Text = comboBox22.SelectedIndex.ToString();
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbOptionID10.Text = comboBox13.SelectedIndex.ToString();
            List10 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + TbOptionID10.Text + "' ORDER BY a_index;");
            comboBox23.DataSource = null;
            comboBox23.Items.Clear();
            comboBox23.DataSource = List10;
        }

        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbOptionLvl10.Text = comboBox23.SelectedIndex.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            TbCraftItm1.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void pictureBox3_MouseMove_1(object sender, MouseEventArgs e)
        {
            pictureBox3.Size = new Size(26, 26);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(22, 22);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            TbCraftItm2.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.Size = new Size(26, 26);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(22, 22);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            TbCraftItm3.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox5.Size = new Size(26, 26);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(22, 22);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            TbCraftItm4.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox6.Size = new Size(26, 26);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(22, 22);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            TbCraftItm5.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox7.Size = new Size(26, 26);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Size = new Size(22, 22);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            TbCraftItm6.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox8.Size = new Size(26, 26);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(22, 22);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            TbCraftItm7.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox9.Size = new Size(26, 26);
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Size = new Size(22, 22);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            TbCraftItm8.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void pictureBox10_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox10.Size = new Size(26, 26);
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Size = new Size(22, 22);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            TbCraftItm9.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void pictureBox11_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox11.Size = new Size(26, 26);
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.Size = new Size(22, 22);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            TbCraftItm10.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void pictureBox12_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox12.Size = new Size(26, 26);
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.Size = new Size(22, 22);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            RareOptSearch rareOptSearch = new RareOptSearch();
            if (rareOptSearch.ShowDialog() != DialogResult.OK)
                return;
            TbOptionID1.Text = rareOptSearch.varf3;
        }

        private void pictureBox13_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox13.Size = new Size(26, 26);
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.Size = new Size(22, 22);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            RareOptSearch rareOptSearch = new RareOptSearch();
            if (rareOptSearch.ShowDialog() != DialogResult.OK)
                return;
            TbOptionID2.Text = rareOptSearch.varf3;
        }

        private void pictureBox14_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox14.Size = new Size(26, 26);
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.Size = new Size(22, 22);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            RareOptSearch rareOptSearch = new RareOptSearch();
            if (rareOptSearch.ShowDialog() != DialogResult.OK)
                return;
            TbOptionID3.Text = rareOptSearch.varf3;
        }

        private void pictureBox15_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox15.Size = new Size(26, 26);
        }

        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            pictureBox15.Size = new Size(22, 22);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            RareOptSearch rareOptSearch = new RareOptSearch();
            if (rareOptSearch.ShowDialog() != DialogResult.OK)
                return;
            TbOptionID4.Text = rareOptSearch.varf3;
        }

        private void pictureBox16_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox16.Size = new Size(26, 26);
        }

        private void pictureBox16_MouseLeave(object sender, EventArgs e)
        {
            pictureBox16.Size = new Size(22, 22);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            RareOptSearch rareOptSearch = new RareOptSearch();
            if (rareOptSearch.ShowDialog() != DialogResult.OK)
                return;
            TbOptionID5.Text = rareOptSearch.varf3;
        }

        private void pictureBox17_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox17.Size = new Size(26, 26);
        }

        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {
            pictureBox17.Size = new Size(22, 22);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            RareOptSearch rareOptSearch = new RareOptSearch();
            if (rareOptSearch.ShowDialog() != DialogResult.OK)
                return;
            TbOptionID6.Text = rareOptSearch.varf3;
        }

        private void pictureBox18_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox18.Size = new Size(26, 26);
        }

        private void pictureBox18_MouseLeave(object sender, EventArgs e)
        {
            pictureBox18.Size = new Size(22, 22);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            RareOptSearch rareOptSearch = new RareOptSearch();
            if (rareOptSearch.ShowDialog() != DialogResult.OK)
                return;
            TbOptionID7.Text = rareOptSearch.varf3;
        }

        private void pictureBox19_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox19.Size = new Size(26, 26);
        }

        private void pictureBox19_MouseLeave(object sender, EventArgs e)
        {
            pictureBox19.Size = new Size(22, 22);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(TbOptionID8.Text) <= 134) //dethunter12 add
            {
                RareOptSearch rareOptSearch = new RareOptSearch();
                if (rareOptSearch.ShowDialog() != DialogResult.OK)
                    return;
                TbOptionID8.Text = rareOptSearch.varf3;
            }
            else if(Int32.Parse(TbOptionID8.Text) >= 134) //dethunter12 add
            {
                SkillPicker skillPicker = new SkillPicker();
                if (skillPicker.ShowDialog() != DialogResult.OK)
                    return;
                TbOptionID8.Text = Convert.ToString(skillPicker.SkillIndex);
            }
        }

        private void pictureBox20_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox20.Size = new Size(26, 26);
        }

        private void pictureBox20_MouseLeave(object sender, EventArgs e)
        {
            pictureBox20.Size = new Size(22, 22);
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            RareOptSearch rareOptSearch = new RareOptSearch();
            if (rareOptSearch.ShowDialog() != DialogResult.OK)
                return;
            TbOptionID9.Text = rareOptSearch.varf3;
        }

        private void pictureBox21_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox21.Size = new Size(26, 26);
        }

        private void pictureBox21_MouseLeave(object sender, EventArgs e)
        {
            pictureBox21.Size = new Size(22, 22);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            RareOptSearch rareOptSearch = new RareOptSearch();
            if (rareOptSearch.ShowDialog() != DialogResult.OK)
                return;
            TbOptionID10.Text = rareOptSearch.varf3;
        }

        private void pictureBox22_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox22.Size = new Size(26, 26);
        }

        private void pictureBox22_MouseLeave(object sender, EventArgs e)
        {
            pictureBox22.Size = new Size(22, 22);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            FlagBuilder flagBuilder = new FlagBuilder();
            if (Episode == "EP4")
            {
                flagBuilder.flagBig = Convert.ToInt64(TbFlag.Text);
                if (flagBuilder.ShowDialog() != DialogResult.OK)
                    return;
                TbFlag.Text = Convert.ToString(flagBuilder.flagSmall);
            }
            else
            {
                flagBuilder.flagSmall = Convert.ToInt32(TbFlag.Text);
                if (flagBuilder.ShowDialog() != DialogResult.OK)
                    return;
                TbFlag.Text = Convert.ToString(flagBuilder.flagSmall);
            }
        }



        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            for (int index = 0; index < checkedListBox2.Items.Count; ++index)
            {
                if (checkedListBox2.GetItemChecked(index))
                {
                    num1 += 1 << index;
                    ++num2;
                }
            }
            mSortJob = num1.ToString();
            if (num2 == 0)
                mSortJob = "-1";
            LoadListBox();
        }

        private void InitializeDevice()
        {
           /* _Direct3D = new Direct3D();
            Direct3D direct3D = _Direct3D;
            int adapter = 0;
            int num1 = 1;
            IntPtr handle1 = Handle;
            int num2 = 32;
            PresentParameters[] presentParametersArray = new PresentParameters[1];
            int index = 0;
            PresentParameters presentParameters = new PresentParameters();
            presentParameters.SwapEffect = SwapEffect.Discard;
            IntPtr handle2 = panel3DView.Handle;
            presentParameters.DeviceWindowHandle = handle2;
            int num3 = 1;
            presentParameters.Windowed = num3 != 0;
            int width = panel3DView.Width;
            presentParameters.BackBufferWidth = width;
            int height = panel3DView.Height;
            presentParameters.BackBufferHeight = height;
            int num4 = 21;
            presentParameters.BackBufferFormat = (SlimDX.Direct3D9.Format)num4;
            presentParametersArray[index] = presentParameters;
            _Device = new Device(direct3D, adapter, (DeviceType)num1, handle1, (CreateFlags)num2, presentParametersArray);
            _Device.SetRenderState<Cull>(RenderState.CullMode, Cull.None);
            _Device.SetRenderState<FillMode>(RenderState.FillMode, FillMode.Solid);
            _Device.SetRenderState(RenderState.Lighting, false);
            CameraPositioning();*/
        }

      /*  private void CameraPositioning()
        {
            _Device.SetTransform(TransformState.Projection, Matrix.PerspectiveFovLH(100f, 1f, 1f, 450f));
            _Device.SetTransform(TransformState.View, Matrix.LookAtLH(new Vector3(0.0f, 0.0f, -5f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 1f, 0.0f)));
            _Device.SetTransform(TransformState.World, Matrix.RotationYawPitchRoll(0.0f, 0.0f, 0.0f));
        }*/

       /* private void Render()
        {
            _Device.Viewport = new Viewport(0, 0, panel3DView.Width, panel3DView.Height);
            _Device.Clear(ClearFlags.ZBuffer | ClearFlags.Target, new Color4(Color.FromKnownColor(KnownColor.Control)), 1f, 0);
            _Device.BeginScene();
            _Device.SetTransform(TransformState.View, Matrix.LookAtLH(new Vector3(0.0f, 0.0f, _Zoom), new Vector3(_LeftRight, _UpDown, 0.0f), new Vector3(0.0f, 1f, 0.0f)));
            _Device.SetTransform(TransformState.World, Matrix.RotationYawPitchRoll(_Rotation, 3.1f, 0.0f));
            if (_Models != null && (uint)_Models.Count<tMesh>() > 0U)
            {
                for (int index = 0; index < _Models.Count<tMesh>(); ++index)
                {
                    if (_Models[index].TexData != null)
                        _Device.SetTexture(0, (BaseTexture)_Models[index].TexData);
                    for (int subset = 0; subset < 1000; ++subset)
                        _Models[index].MeshData.DrawSubset(subset);
                }
            }
            _Device.EndScene();
            _Device.Present();
            _Rotation = _Rotation - 0.03f;
        }

        private SlimDX.Direct3D9.Format ConvFormat(texFormat tFormat)
        {
            SlimDX.Direct3D9.Format format = SlimDX.Direct3D9.Format.Unknown;
            switch (tFormat)
            {
                case texFormat.RGB:
                    return SlimDX.Direct3D9.Format.R8G8B8;
                case texFormat.ARGB:
                    return SlimDX.Direct3D9.Format.A8R8G8B8;
                case texFormat.DXT1:
                    return SlimDX.Direct3D9.Format.Dxt1;
                case texFormat.DXT3:
                    return SlimDX.Direct3D9.Format.Dxt3;
                default:
                    return format;
            }
        }

        private Texture BuildTexture(byte[] imageData, SlimDX.Direct3D9.Format imageFormat, int width, int height)
        {
            if (imageFormat == SlimDX.Direct3D9.Format.R8G8B8)
            {
                MemoryStream memoryStream;
                using (memoryStream = new MemoryStream())
                {
                    Tex.makeRGB8(imageData, width, height).Save((Stream)memoryStream, ImageFormat.Bmp);
                    memoryStream.Write(imageData, 0, imageData.Length);
                    memoryStream.Position = 0L;
                    return Texture.FromStream(_Device, (Stream)memoryStream, width, height, 0, Usage.SoftwareProcessing, SlimDX.Direct3D9.Format.A8B8G8R8, Pool.Default, Filter.None, Filter.None, 0);
                }
            }
            else if (imageFormat == SlimDX.Direct3D9.Format.A8R8G8B8)
            {
                MemoryStream memoryStream;
                using (memoryStream = new MemoryStream())
                {
                    Tex.makeRGB(imageData, width, height).Save((Stream)memoryStream, ImageFormat.Bmp);
                    memoryStream.Write(imageData, 0, imageData.Length);
                    memoryStream.Position = 0L;
                    return Texture.FromStream(_Device, (Stream)memoryStream, width, height, 0, Usage.SoftwareProcessing, SlimDX.Direct3D9.Format.A8B8G8R8, Pool.Default, Filter.None, Filter.None, 0);
                }
            }
            else
            {
                Texture texture = new Texture(_Device, width, height, 0, Usage.None, imageFormat, Pool.Managed);
                using (Stream data = (Stream)texture.LockRectangle(0, LockFlags.None).Data)
                {
                    data.Write(imageData, 0, ((IEnumerable<byte>)imageData).Count<byte>());
                    texture.UnlockRectangle(0);
                }
                return texture;
            }
        }

        private Texture GetTextureFromFile(string FileName)
        {
            Texture texture = (Texture)null;
            if (File.Exists(FileName))
            {
                Tex.ReadFile(FileName);
                SlimDX.Direct3D9.Format imageFormat = ConvFormat(Tex.GetFormat());
                texture = BuildTexture(Tex.lcTex.imageData[0], imageFormat, (int)Tex.lcTex.Header.Width, (int)Tex.lcTex.Header.Height);
            }
            return texture;
        }*/

       /* private void MakeLCModels(string SMCFile)
        {
            System.Collections.Generic.List<float> source1 = new System.Collections.Generic.List<float>();
            System.Collections.Generic.List<float> source2 = new System.Collections.Generic.List<float>();
            System.Collections.Generic.List<float> source3 = new System.Collections.Generic.List<float>();
            System.Collections.Generic.List<float> floatList1 = new System.Collections.Generic.List<float>();
            System.Collections.Generic.List<float> floatList2 = new System.Collections.Generic.List<float>();
            System.Collections.Generic.List<float> floatList3 = new System.Collections.Generic.List<float>();
            _Models = new System.Collections.Generic.List<tMesh>();
            try
            {
                System.Collections.Generic.List<smcMesh> source4 = SMCReader.ReadFile(SMCFile);
                for (int index1 = 0; index1 < source4.Count<smcMesh>(); ++index1)
                {
                    if (LCMeshReader.ReadFile(source4[index1].FileName))
                    {
                        tMeshContainer pMesh = LCMeshReader.pMesh;
                        source1.Add(((IEnumerable<tVertex3f>)pMesh.Vertices).Max<tVertex3f>((Func<tVertex3f, float>)(p => p.X)));
                        source2.Add(((IEnumerable<tVertex3f>)pMesh.Vertices).Max<tVertex3f>((Func<tVertex3f, float>)(p => p.Y)));
                        source3.Add(((IEnumerable<tVertex3f>)pMesh.Vertices).Max<tVertex3f>((Func<tVertex3f, float>)(p => p.Z)));
                        floatList1.Add(((IEnumerable<tVertex3f>)pMesh.Vertices).Min<tVertex3f>((Func<tVertex3f, float>)(p => p.X)));
                        floatList2.Add(((IEnumerable<tVertex3f>)pMesh.Vertices).Min<tVertex3f>((Func<tVertex3f, float>)(p => p.Y)));
                        floatList3.Add(((IEnumerable<tVertex3f>)pMesh.Vertices).Min<tVertex3f>((Func<tVertex3f, float>)(p => p.Z)));
                        for (int index2 = 0; index2 < ((IEnumerable<tMeshObject>)pMesh.Objects).Count<tMeshObject>(); ++index2)
                        {
                            int toVert = (int)pMesh.Objects[index2].ToVert;
                            int faceCount = (int)pMesh.Objects[index2].FaceCount;
                            short[] faces = pMesh.Objects[index2].GetFaces();
                            CustomVertex.PositionNormalTextured[] data = new CustomVertex.PositionNormalTextured[toVert];
                            int fromVert = (int)pMesh.Objects[index2].FromVert;
                            for (int index3 = 0; (long)index3 < (long)pMesh.Objects[index2].ToVert; ++index3)
                            {
                                data[index3].Position = new Vector3(pMesh.Vertices[fromVert].X, pMesh.Vertices[fromVert].Y, pMesh.Vertices[fromVert].Z);
                                data[index3].Normal = new Vector3(pMesh.Normals[fromVert].X, pMesh.Normals[fromVert].Y, pMesh.Normals[fromVert].Z);
                                try
                                {
                                    data[index3].Texture = new Vector2(pMesh.UVMaps[0].Coords[fromVert].U, pMesh.UVMaps[0].Coords[fromVert].V);
                                }
                                catch
                                {
                                    data[index3].Texture = new Vector2(0.0f, 0.0f);
                                }
                                ++fromVert;
                            }
                            VertexBuffer vertexBuffer = new VertexBuffer(_Device, ((IEnumerable<CustomVertex.PositionNormalTextured>)data).Count<CustomVertex.PositionNormalTextured>() * 32, Usage.None, VertexFormat.PositionNormal | VertexFormat.Texture1, Pool.Default);
                            Mesh mesh = new Mesh(_Device, ((IEnumerable<short>)faces).Count<short>() / 3, ((IEnumerable<CustomVertex.PositionNormalTextured>)data).Count<CustomVertex.PositionNormalTextured>(), MeshFlags.Managed, VertexFormat.PositionNormal | VertexFormat.Texture1);
                            DataStream dataStream1;
                            using (dataStream1 = mesh.VertexBuffer.Lock(0, ((IEnumerable<CustomVertex.PositionNormalTextured>)data).Count<CustomVertex.PositionNormalTextured>() * 32, LockFlags.None))
                            {
                                dataStream1.WriteRange<CustomVertex.PositionNormalTextured>(data);
                                mesh.VertexBuffer.Unlock();
                            }
                            DataStream dataStream2;
                            using (dataStream2 = mesh.IndexBuffer.Lock(0, ((IEnumerable<short>)faces).Count<short>() * 2, LockFlags.None))
                            {
                                dataStream2.WriteRange<short>(faces);
                                mesh.IndexBuffer.Unlock();
                            }
                            if ((uint)((IEnumerable<tMeshJointWeights>)pMesh.Weights).Count<tMeshJointWeights>() > 0U)
                            {
                                string[] strArray = new string[((IEnumerable<tMeshJointWeights>)pMesh.Weights).Count<tMeshJointWeights>()];
                                System.Collections.Generic.List<int>[] intListArray = new System.Collections.Generic.List<int>[((IEnumerable<tMeshJointWeights>)pMesh.Weights).Count<tMeshJointWeights>()];
                                System.Collections.Generic.List<float>[] floatListArray = new System.Collections.Generic.List<float>[((IEnumerable<tMeshJointWeights>)pMesh.Weights).Count<tMeshJointWeights>()];
                                for (int index3 = 0; index3 < ((IEnumerable<tMeshJointWeights>)pMesh.Weights).Count<tMeshJointWeights>(); ++index3)
                                {
                                    strArray[index3] = _Enc.GetString(pMesh.Weights[index3].JointName);
                                    intListArray[index3] = new System.Collections.Generic.List<int>();
                                    floatListArray[index3] = new System.Collections.Generic.List<float>();
                                    for (int index4 = 0; index4 < ((IEnumerable<tMeshWeightsMap>)pMesh.Weights[index3].WeightsMap).Count<tMeshWeightsMap>(); ++index4)
                                    {
                                        intListArray[index3].Add(pMesh.Weights[index3].WeightsMap[index4].Index);
                                        floatListArray[index3].Add(pMesh.Weights[index3].WeightsMap[index4].Weight);
                                    }
                                }
                                mesh.SkinInfo = new SkinInfo(((IEnumerable<CustomVertex.PositionNormalTextured>)data).Count<CustomVertex.PositionNormalTextured>(), VertexFormat.PositionNormal | VertexFormat.Texture1, (int)pMesh.HeaderInfo.JointCount);
                                for (int bone = 0; bone < ((IEnumerable<System.Collections.Generic.List<int>>)intListArray).Count<System.Collections.Generic.List<int>>(); ++bone)
                                {
                                    mesh.SkinInfo.SetBoneName(bone, strArray[bone]);
                                    mesh.SkinInfo.SetBoneInfluence(bone, intListArray[bone].ToArray(), floatListArray[bone].ToArray());
                                }
                            }
                            mesh.GenerateAdjacency(0.5f);
                            mesh.ComputeNormals();
                            Texture texture = (Texture)null;
                            string objName = _Enc.GetString(pMesh.Objects[index2].Textures[0].InternalName);
                            int index5 = source4[index1].Object.FindIndex((Predicate<smcObject>)(x => x.Name.Equals(objName)));
                            if (index5 != -1)
                                texture = GetTextureFromFile(source4[index1].Object[index5].Texture);
                            _Models.Add(new tMesh(mesh, texture));
                        }
                    }
                }
            }
            catch
            {
            }
            try
            {
                _Zoom = ((IEnumerable<float>)new float[3]
        {
          source1.Max(),
          source2.Max(),
          source3.Max()
        }).Max() * 3f;
            }
            catch
            {
            }
            slideZoom.Value = (int)_Zoom * 100;
        }*/

      /*  private void timer1_Tick(object sender, EventArgs e)
        {
            Render();
        }*/

        private void textBox95_TextChanged(object sender, EventArgs e)
        {
            _SortAboveLevel = textBox95.Text;
            LoadListBox();
        }

        private void button27_Click(object sender, EventArgs e)
        {
        }

        private void textBox70_TextChanged(object sender, EventArgs e)
        {
            if (TbOptionID1.Text == "-1")
                lblProb1.Text = "";
            if (TbOptionID1.Text != "-1" && TbOptionID1.Text != "")
            {
                if (int.Parse(TbOptionID1.Text) > 10000)
                    TbOptionID1.Text = Convert.ToString(10000);
                Update_Probability_Text();
            }      
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemEditor2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportlodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportStrItemlodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSmclodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.massEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.v = new System.Windows.Forms.ToolStripMenuItem();
            this.massUpdateSealsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.massUpdateFlagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.massUpdateNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.massPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.ClbItemFlag = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TbFlag = new System.Windows.Forms.TextBox();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.label84 = new System.Windows.Forms.Label();
            this.TbQuestTriggerID = new System.Windows.Forms.TextBox();
            this.label83 = new System.Windows.Forms.Label();
            this.TbQuestTriggerCnt = new System.Windows.Forms.TextBox();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.TbUnkown = new System.Windows.Forms.TextBox();
            this.TbDropProb = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.TbMaxUse = new System.Windows.Forms.TextBox();
            this.TbCastle = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.label109 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.TbJobFlag = new System.Windows.Forms.TextBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.TbStackAmnt = new System.Windows.Forms.TextBox();
            this.TbPrice = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.TbReformVaration6 = new System.Windows.Forms.TextBox();
            this.label90 = new System.Windows.Forms.Label();
            this.TbReformVaration1 = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.TbReformVaration5 = new System.Windows.Forms.TextBox();
            this.label89 = new System.Windows.Forms.Label();
            this.TbReformVaration2 = new System.Windows.Forms.TextBox();
            this.label86 = new System.Windows.Forms.Label();
            this.TbReformVaration4 = new System.Windows.Forms.TextBox();
            this.label88 = new System.Windows.Forms.Label();
            this.TbReformVaration3 = new System.Windows.Forms.TextBox();
            this.label87 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.comboBox26 = new System.Windows.Forms.ComboBox();
            this.comboBox25 = new System.Windows.Forms.ComboBox();
            this.comboBox24 = new System.Windows.Forms.ComboBox();
            this.label92 = new System.Windows.Forms.Label();
            this.TbRvrGrade = new System.Windows.Forms.TextBox();
            this.label91 = new System.Windows.Forms.Label();
            this.TbRvrVal = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label82 = new System.Windows.Forms.Label();
            this.TbDamageEffect = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.TbAttackEffect = new System.Windows.Forms.TextBox();
            this.label80 = new System.Windows.Forms.Label();
            this.TbNormalEffect = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TbIconCol = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.TbIconID = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.TbIconRow = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.tbCommonRareRate = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.TbCommonRareID = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TbMinLvl = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TbMaxlvl = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.TbDura = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.TbFame = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.TbSet3 = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.TbSet2 = new System.Windows.Forms.TextBox();
            this.TbSet4 = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.TbSet1 = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.TbSet0 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSub3 = new System.Windows.Forms.Button();
            this.btnSub2 = new System.Windows.Forms.Button();
            this.btnSub1 = new System.Windows.Forms.Button();
            this.BtnMassNum = new System.Windows.Forms.Button();
            this.btnPercent2Add = new System.Windows.Forms.Button();
            this.btnPercent1Add = new System.Windows.Forms.Button();
            this.btnPercentAdd = new System.Windows.Forms.Button();
            this.TbPercent2 = new System.Windows.Forms.TextBox();
            this.TbPercent1 = new System.Windows.Forms.TextBox();
            this.TbPercent = new System.Windows.Forms.TextBox();
            this.label108 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.TbNum4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TbNum0 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TbNum1 = new System.Windows.Forms.TextBox();
            this.TbNum3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TbNum2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CbSubType6 = new System.Windows.Forms.ComboBox();
            this.CbSubType5 = new System.Windows.Forms.ComboBox();
            this.CbSubType7 = new System.Windows.Forms.ComboBox();
            this.CbSubType4 = new System.Windows.Forms.ComboBox();
            this.CbSubtype3 = new System.Windows.Forms.ComboBox();
            this.CbSubtype2 = new System.Windows.Forms.ComboBox();
            this.CbSubtype1 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TbType = new System.Windows.Forms.TextBox();
            this.TbWearing = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbSubtype = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label47 = new System.Windows.Forms.Label();
            this.TbZoneFlag = new System.Windows.Forms.TextBox();
            this.TbSmc = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbIndex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.TbDescr = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TbCraftAmnt5 = new System.Windows.Forms.TextBox();
            this.TbCraftItm6 = new System.Windows.Forms.TextBox();
            this.TbCraftAmnt8 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.TbCraftItm10 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.TbCraftItm5 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.TbCraftAmnt9 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TbCraftItm7 = new System.Windows.Forms.TextBox();
            this.TbCraftAmnt2 = new System.Windows.Forms.TextBox();
            this.TbCraftAmnt7 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.TbCraftAmnt3 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.TbCraftItm1 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.TbCraftAmnt10 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.TbCraftItm8 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.TbCraftItm4 = new System.Windows.Forms.TextBox();
            this.TbCraftAmnt1 = new System.Windows.Forms.TextBox();
            this.TbCraftAmnt6 = new System.Windows.Forms.TextBox();
            this.TbCraftAmnt4 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.TbCraftItm2 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.TbCraftItm9 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.TbCraftItm3 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.TbCraftSkillLevel2 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.TbCraftSkillId2 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.TbCraftSkillLevel1 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.TbCraftSkillId1 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gbFortune = new System.Windows.Forms.GroupBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAddItems = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveSelected = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeleteSelected = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.r1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolBtnClear = new System.Windows.Forms.ToolStripButton();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dgV = new System.Windows.Forms.DataGridView();
            this.a_item_idx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_skill_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_skill_level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_string_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_prob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_item_idx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_skill_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_skill_level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_string_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_prob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
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
            this.label104 = new System.Windows.Forms.Label();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.label103 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label99 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label98 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label97 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label96 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label95 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.lblProb10 = new System.Windows.Forms.Label();
            this.lblProb9 = new System.Windows.Forms.Label();
            this.lblProb8 = new System.Windows.Forms.Label();
            this.lblProb7 = new System.Windows.Forms.Label();
            this.lblProb6 = new System.Windows.Forms.Label();
            this.lblProb5 = new System.Windows.Forms.Label();
            this.lblProb4 = new System.Windows.Forms.Label();
            this.lblProb3 = new System.Windows.Forms.Label();
            this.lblProb2 = new System.Windows.Forms.Label();
            this.lblProb1 = new System.Windows.Forms.Label();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.TbOptionLvl10 = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.TbOptionLvl9 = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.TbOptionLvl8 = new System.Windows.Forms.TextBox();
            this.label77 = new System.Windows.Forms.Label();
            this.TbOptionLvl7 = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.TbOptionLvl6 = new System.Windows.Forms.TextBox();
            this.label75 = new System.Windows.Forms.Label();
            this.TbOptionLvl5 = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.TbOptionLvl4 = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.TbOptionLvl3 = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.TbOptionLvl2 = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.TbOptionLvl1 = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.TbOptionID10 = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.TbOptionID9 = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.TbOptionID8 = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.TbOptionID7 = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.TbOptionID6 = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.TbOptionID5 = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.TbOptionID4 = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.TbOptionID3 = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.TbOptionID2 = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.TbOptionID1 = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.clbFlagTest = new System.Windows.Forms.CheckedListBox();
            this.TbEnable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label105 = new System.Windows.Forms.Label();
            this.textBox95 = new System.Windows.Forms.TextBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip9 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip10 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSaveAndNext = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLang = new System.Windows.Forms.Label();
            this.CbSaveValueAndLevel = new System.Windows.Forms.CheckBox();
            this.CbAutoUpdate = new System.Windows.Forms.CheckBox();
            this.tbDoesItemExist = new System.Windows.Forms.TextBox();
            this.CbSaveIconSmc = new System.Windows.Forms.CheckBox();
            this.pb_loading = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            this.groupBox19.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gbFortune.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgV)).BeginInit();
            this.groupBox17.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.groupBox18.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileExportToolStripMenuItem,
            this.massEditToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1232, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileExportToolStripMenuItem
            // 
            this.fileExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportlodToolStripMenuItem,
            this.exportStrItemlodToolStripMenuItem,
            this.exportSmclodToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileExportToolStripMenuItem.Name = "fileExportToolStripMenuItem";
            this.fileExportToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.fileExportToolStripMenuItem.Text = "File Export";
            // 
            // exportlodToolStripMenuItem
            // 
            this.exportlodToolStripMenuItem.Name = "exportlodToolStripMenuItem";
            this.exportlodToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exportlodToolStripMenuItem.Text = "itemAll.lod";
            this.exportlodToolStripMenuItem.Click += new System.EventHandler(this.exportlodToolStripMenuItem_Click);
            // 
            // exportStrItemlodToolStripMenuItem
            // 
            this.exportStrItemlodToolStripMenuItem.Name = "exportStrItemlodToolStripMenuItem";
            this.exportStrItemlodToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exportStrItemlodToolStripMenuItem.Text = "Export strItem.lod";
            this.exportStrItemlodToolStripMenuItem.Click += new System.EventHandler(this.exportStrItemlodToolStripMenuItem_Click);
            // 
            // exportSmclodToolStripMenuItem
            // 
            this.exportSmclodToolStripMenuItem.Enabled = false;
            this.exportSmclodToolStripMenuItem.Name = "exportSmclodToolStripMenuItem";
            this.exportSmclodToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exportSmclodToolStripMenuItem.Text = "Export smc.lod";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Enabled = false;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exportToolStripMenuItem.Text = "Export itemFortune.lod";
            // 
            // massEditToolStripMenuItem
            // 
            this.massEditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.v,
            this.massUpdateSealsToolStripMenuItem,
            this.massUpdateFlagToolStripMenuItem,
            this.massUpdateNameToolStripMenuItem,
            this.massPriceToolStripMenuItem});
            this.massEditToolStripMenuItem.Name = "massEditToolStripMenuItem";
            this.massEditToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.massEditToolStripMenuItem.Text = "MYSQL";
            // 
            // v
            // 
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(177, 22);
            this.v.Text = "Mass Update";
            this.v.Click += new System.EventHandler(this.massEditToolStripMenuItem1_Click);
            // 
            // massUpdateSealsToolStripMenuItem
            // 
            this.massUpdateSealsToolStripMenuItem.Name = "massUpdateSealsToolStripMenuItem";
            this.massUpdateSealsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.massUpdateSealsToolStripMenuItem.Text = "Mass Update Seals";
            this.massUpdateSealsToolStripMenuItem.Click += new System.EventHandler(this.massUpdateSealsToolStripMenuItem_Click);
            // 
            // massUpdateFlagToolStripMenuItem
            // 
            this.massUpdateFlagToolStripMenuItem.Name = "massUpdateFlagToolStripMenuItem";
            this.massUpdateFlagToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.massUpdateFlagToolStripMenuItem.Text = "Mass Update Flag";
            this.massUpdateFlagToolStripMenuItem.Click += new System.EventHandler(this.massUpdateFlagToolStripMenuItem_Click);
            // 
            // massUpdateNameToolStripMenuItem
            // 
            this.massUpdateNameToolStripMenuItem.Name = "massUpdateNameToolStripMenuItem";
            this.massUpdateNameToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.massUpdateNameToolStripMenuItem.Text = "Mass Update Name";
            this.massUpdateNameToolStripMenuItem.Click += new System.EventHandler(this.MassUpdateNameToolStripMenuItem_Click);
            // 
            // massPriceToolStripMenuItem
            // 
            this.massPriceToolStripMenuItem.Name = "massPriceToolStripMenuItem";
            this.massPriceToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.massPriceToolStripMenuItem.Text = "Mass Price";
            this.massPriceToolStripMenuItem.Click += new System.EventHandler(this.MassPriceToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 535);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Items";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(91, 501);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Copy to new";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(188, 501);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete Item";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(10, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 459);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(283, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 636);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.groupBox12);
            this.tabPage1.Controls.Add(this.groupBox23);
            this.tabPage1.Controls.Add(this.groupBox22);
            this.tabPage1.Controls.Add(this.groupBox21);
            this.tabPage1.Controls.Add(this.groupBox15);
            this.tabPage1.Controls.Add(this.groupBox19);
            this.tabPage1.Controls.Add(this.groupBox16);
            this.tabPage1.Controls.Add(this.groupBox14);
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.groupBox11);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox10);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(939, 610);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.ClbItemFlag);
            this.groupBox12.Controls.Add(this.label9);
            this.groupBox12.Controls.Add(this.TbFlag);
            this.groupBox12.Location = new System.Drawing.Point(620, 9);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(315, 597);
            this.groupBox12.TabIndex = 61;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "ItemFlag";
            // 
            // ClbItemFlag
            // 
            this.ClbItemFlag.BackColor = System.Drawing.SystemColors.Control;
            this.ClbItemFlag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClbItemFlag.CheckOnClick = true;
            this.ClbItemFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClbItemFlag.FormattingEnabled = true;
            this.ClbItemFlag.IntegralHeight = false;
            this.ClbItemFlag.Location = new System.Drawing.Point(6, 20);
            this.ClbItemFlag.MultiColumn = true;
            this.ClbItemFlag.Name = "ClbItemFlag";
            this.ClbItemFlag.Size = new System.Drawing.Size(300, 539);
            this.ClbItemFlag.TabIndex = 0;
            this.ClbItemFlag.SelectedIndexChanged += new System.EventHandler(this.ClbItemFlag_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 573);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Flag:";
            // 
            // TbFlag
            // 
            this.TbFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbFlag.Location = new System.Drawing.Point(88, 570);
            this.TbFlag.Name = "TbFlag";
            this.TbFlag.Size = new System.Drawing.Size(114, 20);
            this.TbFlag.TabIndex = 14;
            this.TbFlag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox8_KeyPress);
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.label84);
            this.groupBox23.Controls.Add(this.TbQuestTriggerID);
            this.groupBox23.Controls.Add(this.label83);
            this.groupBox23.Controls.Add(this.TbQuestTriggerCnt);
            this.groupBox23.Location = new System.Drawing.Point(325, 132);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(289, 41);
            this.groupBox23.TabIndex = 60;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Quest Trigger Info";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(28, 21);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(26, 13);
            this.label84.TabIndex = 54;
            this.label84.Text = "IDs:";
            // 
            // TbQuestTriggerID
            // 
            this.TbQuestTriggerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbQuestTriggerID.Location = new System.Drawing.Point(60, 17);
            this.TbQuestTriggerID.Name = "TbQuestTriggerID";
            this.TbQuestTriggerID.Size = new System.Drawing.Size(68, 20);
            this.TbQuestTriggerID.TabIndex = 53;
            this.TbQuestTriggerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox84_KeyPress);
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(134, 19);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(38, 13);
            this.label83.TabIndex = 52;
            this.label83.Text = "Count:";
            // 
            // TbQuestTriggerCnt
            // 
            this.TbQuestTriggerCnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbQuestTriggerCnt.Location = new System.Drawing.Point(178, 16);
            this.TbQuestTriggerCnt.Name = "TbQuestTriggerCnt";
            this.TbQuestTriggerCnt.Size = new System.Drawing.Size(68, 20);
            this.TbQuestTriggerCnt.TabIndex = 51;
            this.TbQuestTriggerCnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox83_KeyPress);
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.TbUnkown);
            this.groupBox22.Controls.Add(this.TbDropProb);
            this.groupBox22.Controls.Add(this.label51);
            this.groupBox22.Controls.Add(this.label21);
            this.groupBox22.Controls.Add(this.TbMaxUse);
            this.groupBox22.Controls.Add(this.TbCastle);
            this.groupBox22.Controls.Add(this.label20);
            this.groupBox22.Controls.Add(this.label94);
            this.groupBox22.Location = new System.Drawing.Point(328, 175);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(286, 68);
            this.groupBox22.TabIndex = 59;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Misc";
            // 
            // TbUnkown
            // 
            this.TbUnkown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbUnkown.Location = new System.Drawing.Point(162, 45);
            this.TbUnkown.Name = "TbUnkown";
            this.TbUnkown.Size = new System.Drawing.Size(44, 20);
            this.TbUnkown.TabIndex = 42;
            this.TbUnkown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox51_KeyUp);
            // 
            // TbDropProb
            // 
            this.TbDropProb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbDropProb.Location = new System.Drawing.Point(62, 43);
            this.TbDropProb.Name = "TbDropProb";
            this.TbDropProb.Size = new System.Drawing.Size(41, 20);
            this.TbDropProb.TabIndex = 34;
            this.TbDropProb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox21_KeyPress);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(122, 50);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(13, 13);
            this.label51.TabIndex = 43;
            this.label51.Text = "?";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 13);
            this.label21.TabIndex = 35;
            this.label21.Text = "Drop prob:";
            // 
            // TbMaxUse
            // 
            this.TbMaxUse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbMaxUse.Location = new System.Drawing.Point(161, 15);
            this.TbMaxUse.Name = "TbMaxUse";
            this.TbMaxUse.Size = new System.Drawing.Size(44, 20);
            this.TbMaxUse.TabIndex = 33;
            this.TbMaxUse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox20_KeyPress);
            // 
            // TbCastle
            // 
            this.TbCastle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCastle.Location = new System.Drawing.Point(51, 17);
            this.TbCastle.Name = "TbCastle";
            this.TbCastle.Size = new System.Drawing.Size(51, 20);
            this.TbCastle.TabIndex = 55;
            this.TbCastle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox94_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(110, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 34;
            this.label20.Text = "MaxUse:";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(11, 19);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(39, 13);
            this.label94.TabIndex = 56;
            this.label94.Text = "Castle:";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.label109);
            this.groupBox21.Controls.Add(this.checkedListBox1);
            this.groupBox21.Controls.Add(this.TbJobFlag);
            this.groupBox21.Location = new System.Drawing.Point(478, 241);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(136, 209);
            this.groupBox21.TabIndex = 58;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Class";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(7, 186);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(34, 13);
            this.label109.TabIndex = 40;
            this.label109.Text = "Total:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ColumnWidth = 105;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.IntegralHeight = false;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(101, 171);
            this.checkedListBox1.TabIndex = 39;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            this.checkedListBox1.SelectedValueChanged += new System.EventHandler(this.checkedListBox1_SelectedValueChanged);
            // 
            // TbJobFlag
            // 
            this.TbJobFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbJobFlag.Location = new System.Drawing.Point(47, 184);
            this.TbJobFlag.Name = "TbJobFlag";
            this.TbJobFlag.Size = new System.Drawing.Size(55, 20);
            this.TbJobFlag.TabIndex = 12;
            this.TbJobFlag.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.pictureBox25);
            this.groupBox15.Controls.Add(this.pictureBox24);
            this.groupBox15.Controls.Add(this.TbStackAmnt);
            this.groupBox15.Controls.Add(this.TbPrice);
            this.groupBox15.Controls.Add(this.label19);
            this.groupBox15.Controls.Add(this.label18);
            this.groupBox15.Location = new System.Drawing.Point(227, 347);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(131, 110);
            this.groupBox15.TabIndex = 57;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Stack and Price";
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.gold1;
            this.pictureBox25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox25.Location = new System.Drawing.Point(41, 75);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(20, 20);
            this.pictureBox25.TabIndex = 59;
            this.pictureBox25.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.stack;
            this.pictureBox24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox24.Location = new System.Drawing.Point(41, 32);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(20, 20);
            this.pictureBox24.TabIndex = 58;
            this.pictureBox24.TabStop = false;
            // 
            // TbStackAmnt
            // 
            this.TbStackAmnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbStackAmnt.Location = new System.Drawing.Point(63, 31);
            this.TbStackAmnt.Name = "TbStackAmnt";
            this.TbStackAmnt.Size = new System.Drawing.Size(63, 20);
            this.TbStackAmnt.TabIndex = 29;
            this.TbStackAmnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox18_KeyPress);
            this.TbStackAmnt.MouseHover += new System.EventHandler(this.textBox18_MouseHover);
            // 
            // TbPrice
            // 
            this.TbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPrice.Location = new System.Drawing.Point(63, 75);
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.Size = new System.Drawing.Size(63, 20);
            this.TbPrice.TabIndex = 31;
            this.TbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox19_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "Price:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "Stack:";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.TbReformVaration6);
            this.groupBox19.Controls.Add(this.label90);
            this.groupBox19.Controls.Add(this.TbReformVaration1);
            this.groupBox19.Controls.Add(this.label85);
            this.groupBox19.Controls.Add(this.TbReformVaration5);
            this.groupBox19.Controls.Add(this.label89);
            this.groupBox19.Controls.Add(this.TbReformVaration2);
            this.groupBox19.Controls.Add(this.label86);
            this.groupBox19.Controls.Add(this.TbReformVaration4);
            this.groupBox19.Controls.Add(this.label88);
            this.groupBox19.Controls.Add(this.TbReformVaration3);
            this.groupBox19.Controls.Add(this.label87);
            this.groupBox19.Location = new System.Drawing.Point(374, 350);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(104, 100);
            this.groupBox19.TabIndex = 54;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Reform Variation";
            // 
            // TbReformVaration6
            // 
            this.TbReformVaration6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbReformVaration6.Location = new System.Drawing.Point(71, 73);
            this.TbReformVaration6.Name = "TbReformVaration6";
            this.TbReformVaration6.Size = new System.Drawing.Size(19, 20);
            this.TbReformVaration6.TabIndex = 52;
            this.TbReformVaration6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox90_KeyPress);
            this.TbReformVaration6.MouseHover += new System.EventHandler(this.textBox90_MouseHover);
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(51, 75);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(13, 13);
            this.label90.TabIndex = 53;
            this.label90.Text = "6";
            // 
            // TbReformVaration1
            // 
            this.TbReformVaration1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbReformVaration1.Location = new System.Drawing.Point(24, 19);
            this.TbReformVaration1.Name = "TbReformVaration1";
            this.TbReformVaration1.Size = new System.Drawing.Size(19, 20);
            this.TbReformVaration1.TabIndex = 42;
            this.TbReformVaration1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox85_KeyPress);
            this.TbReformVaration1.MouseHover += new System.EventHandler(this.textBox85_MouseHover);
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(5, 22);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(13, 13);
            this.label85.TabIndex = 43;
            this.label85.Text = "1";
            // 
            // TbReformVaration5
            // 
            this.TbReformVaration5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbReformVaration5.Location = new System.Drawing.Point(71, 46);
            this.TbReformVaration5.Name = "TbReformVaration5";
            this.TbReformVaration5.Size = new System.Drawing.Size(19, 20);
            this.TbReformVaration5.TabIndex = 50;
            this.TbReformVaration5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox89_KeyPress);
            this.TbReformVaration5.MouseHover += new System.EventHandler(this.textBox89_MouseHover);
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(51, 48);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(13, 13);
            this.label89.TabIndex = 51;
            this.label89.Text = "5";
            // 
            // TbReformVaration2
            // 
            this.TbReformVaration2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbReformVaration2.Location = new System.Drawing.Point(24, 48);
            this.TbReformVaration2.Name = "TbReformVaration2";
            this.TbReformVaration2.Size = new System.Drawing.Size(19, 20);
            this.TbReformVaration2.TabIndex = 44;
            this.TbReformVaration2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox86_KeyPress);
            this.TbReformVaration2.MouseHover += new System.EventHandler(this.textBox86_MouseHover);
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(5, 48);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(13, 13);
            this.label86.TabIndex = 45;
            this.label86.Text = "2";
            // 
            // TbReformVaration4
            // 
            this.TbReformVaration4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbReformVaration4.Location = new System.Drawing.Point(71, 19);
            this.TbReformVaration4.Name = "TbReformVaration4";
            this.TbReformVaration4.Size = new System.Drawing.Size(19, 20);
            this.TbReformVaration4.TabIndex = 48;
            this.TbReformVaration4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox88_KeyPress);
            this.TbReformVaration4.MouseHover += new System.EventHandler(this.textBox88_MouseHover);
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(52, 22);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(13, 13);
            this.label88.TabIndex = 49;
            this.label88.Text = "4";
            // 
            // TbReformVaration3
            // 
            this.TbReformVaration3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbReformVaration3.Location = new System.Drawing.Point(24, 74);
            this.TbReformVaration3.Name = "TbReformVaration3";
            this.TbReformVaration3.Size = new System.Drawing.Size(19, 20);
            this.TbReformVaration3.TabIndex = 46;
            this.TbReformVaration3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox87_KeyPress);
            this.TbReformVaration3.MouseHover += new System.EventHandler(this.textBox87_MouseHover);
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(5, 75);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(13, 13);
            this.label87.TabIndex = 47;
            this.label87.Text = "3";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.comboBox26);
            this.groupBox16.Controls.Add(this.comboBox25);
            this.groupBox16.Controls.Add(this.comboBox24);
            this.groupBox16.Controls.Add(this.label92);
            this.groupBox16.Controls.Add(this.TbRvrGrade);
            this.groupBox16.Controls.Add(this.label91);
            this.groupBox16.Controls.Add(this.TbRvrVal);
            this.groupBox16.Location = new System.Drawing.Point(8, 350);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(209, 74);
            this.groupBox16.TabIndex = 53;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "RvR";
            // 
            // comboBox26
            // 
            this.comboBox26.FormattingEnabled = true;
            this.comboBox26.Location = new System.Drawing.Point(55, 45);
            this.comboBox26.Name = "comboBox26";
            this.comboBox26.Size = new System.Drawing.Size(102, 21);
            this.comboBox26.TabIndex = 61;
            this.comboBox26.SelectedIndexChanged += new System.EventHandler(this.comboBox26_SelectedIndexChanged);
            this.comboBox26.SelectionChangeCommitted += new System.EventHandler(this.comboBox26_SelectionChangeCommitted);
            // 
            // comboBox25
            // 
            this.comboBox25.FormattingEnabled = true;
            this.comboBox25.Location = new System.Drawing.Point(55, 45);
            this.comboBox25.Name = "comboBox25";
            this.comboBox25.Size = new System.Drawing.Size(102, 21);
            this.comboBox25.TabIndex = 60;
            this.comboBox25.SelectedIndexChanged += new System.EventHandler(this.comboBox25_SelectedIndexChanged_1);
            this.comboBox25.SelectionChangeCommitted += new System.EventHandler(this.comboBox25_SelectionChangeCommitted);
            // 
            // comboBox24
            // 
            this.comboBox24.FormattingEnabled = true;
            this.comboBox24.Location = new System.Drawing.Point(55, 17);
            this.comboBox24.Name = "comboBox24";
            this.comboBox24.Size = new System.Drawing.Size(102, 21);
            this.comboBox24.TabIndex = 59;
            this.comboBox24.SelectedIndexChanged += new System.EventHandler(this.comboBox24_SelectedIndexChanged_1);
            this.comboBox24.SelectionChangeCommitted += new System.EventHandler(this.comboBox24_SelectionChangeCommitted);
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(13, 48);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(39, 13);
            this.label92.TabIndex = 58;
            this.label92.Text = "Grade:";
            // 
            // TbRvrGrade
            // 
            this.TbRvrGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbRvrGrade.Location = new System.Drawing.Point(172, 45);
            this.TbRvrGrade.Name = "TbRvrGrade";
            this.TbRvrGrade.Size = new System.Drawing.Size(31, 20);
            this.TbRvrGrade.TabIndex = 57;
            this.TbRvrGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox92_KeyPress);
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(13, 19);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(37, 13);
            this.label91.TabIndex = 56;
            this.label91.Text = "Value:";
            // 
            // TbRvrVal
            // 
            this.TbRvrVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbRvrVal.Location = new System.Drawing.Point(172, 17);
            this.TbRvrVal.Name = "TbRvrVal";
            this.TbRvrVal.Size = new System.Drawing.Size(31, 20);
            this.TbRvrVal.TabIndex = 55;
            this.TbRvrVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox91_KeyPress);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.label82);
            this.groupBox14.Controls.Add(this.TbDamageEffect);
            this.groupBox14.Controls.Add(this.label81);
            this.groupBox14.Controls.Add(this.TbAttackEffect);
            this.groupBox14.Controls.Add(this.label80);
            this.groupBox14.Controls.Add(this.TbNormalEffect);
            this.groupBox14.Location = new System.Drawing.Point(227, 241);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(249, 100);
            this.groupBox14.TabIndex = 52;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Item Special Effects";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(7, 76);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(50, 13);
            this.label82.TabIndex = 58;
            this.label82.Text = "Damage:";
            // 
            // TbDamageEffect
            // 
            this.TbDamageEffect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbDamageEffect.Location = new System.Drawing.Point(67, 74);
            this.TbDamageEffect.Name = "TbDamageEffect";
            this.TbDamageEffect.Size = new System.Drawing.Size(178, 20);
            this.TbDamageEffect.TabIndex = 57;
            this.TbDamageEffect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox82_KeyPress);
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(14, 50);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(41, 13);
            this.label81.TabIndex = 56;
            this.label81.Text = "Attack:";
            // 
            // TbAttackEffect
            // 
            this.TbAttackEffect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbAttackEffect.Location = new System.Drawing.Point(67, 46);
            this.TbAttackEffect.Name = "TbAttackEffect";
            this.TbAttackEffect.Size = new System.Drawing.Size(178, 20);
            this.TbAttackEffect.TabIndex = 55;
            this.TbAttackEffect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox81_KeyPress);
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(14, 23);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(43, 13);
            this.label80.TabIndex = 54;
            this.label80.Text = "Normal:";
            // 
            // TbNormalEffect
            // 
            this.TbNormalEffect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNormalEffect.Location = new System.Drawing.Point(67, 19);
            this.TbNormalEffect.Name = "TbNormalEffect";
            this.TbNormalEffect.Size = new System.Drawing.Size(178, 20);
            this.TbNormalEffect.TabIndex = 53;
            this.TbNormalEffect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox80_KeyPress);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.linkLabel1);
            this.groupBox9.Controls.Add(this.pictureBox1);
            this.groupBox9.Controls.Add(this.TbIconCol);
            this.groupBox9.Controls.Add(this.label50);
            this.groupBox9.Controls.Add(this.TbIconID);
            this.groupBox9.Controls.Add(this.label48);
            this.groupBox9.Controls.Add(this.label49);
            this.groupBox9.Controls.Add(this.TbIconRow);
            this.groupBox9.Location = new System.Drawing.Point(14, 430);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(201, 100);
            this.groupBox9.TabIndex = 40;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Icon";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(117, 75);
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
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(127, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // TbIconCol
            // 
            this.TbIconCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbIconCol.Location = new System.Drawing.Point(59, 74);
            this.TbIconCol.Name = "TbIconCol";
            this.TbIconCol.Size = new System.Drawing.Size(37, 20);
            this.TbIconCol.TabIndex = 38;
            this.TbIconCol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox50_KeyPress);
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
            // TbIconID
            // 
            this.TbIconID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbIconID.Location = new System.Drawing.Point(59, 20);
            this.TbIconID.Name = "TbIconID";
            this.TbIconID.Size = new System.Drawing.Size(37, 20);
            this.TbIconID.TabIndex = 34;
            this.TbIconID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox48_KeyPress);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(11, 22);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(21, 13);
            this.label48.TabIndex = 35;
            this.label48.Text = "ID:";
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
            // TbIconRow
            // 
            this.TbIconRow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbIconRow.Location = new System.Drawing.Point(59, 46);
            this.TbIconRow.Name = "TbIconRow";
            this.TbIconRow.Size = new System.Drawing.Size(37, 20);
            this.TbIconRow.TabIndex = 36;
            this.TbIconRow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox49_KeyPress);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.tbCommonRareRate);
            this.groupBox11.Controls.Add(this.label58);
            this.groupBox11.Controls.Add(this.TbCommonRareID);
            this.groupBox11.Controls.Add(this.label57);
            this.groupBox11.Location = new System.Drawing.Point(6, 536);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(209, 66);
            this.groupBox11.TabIndex = 48;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Common RareOption";
            // 
            // tbCommonRareRate
            // 
            this.tbCommonRareRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCommonRareRate.Location = new System.Drawing.Point(148, 28);
            this.tbCommonRareRate.Name = "tbCommonRareRate";
            this.tbCommonRareRate.Size = new System.Drawing.Size(53, 20);
            this.tbCommonRareRate.TabIndex = 49;
            this.tbCommonRareRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox58_KeyPress);
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(105, 32);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(33, 13);
            this.label58.TabIndex = 50;
            this.label58.Text = "Rate:";
            // 
            // TbCommonRareID
            // 
            this.TbCommonRareID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCommonRareID.Location = new System.Drawing.Point(43, 30);
            this.TbCommonRareID.Name = "TbCommonRareID";
            this.TbCommonRareID.Size = new System.Drawing.Size(53, 20);
            this.TbCommonRareID.TabIndex = 46;
            this.TbCommonRareID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox57_KeyPress);
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
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.TbMinLvl);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.TbMaxlvl);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label93);
            this.groupBox6.Controls.Add(this.TbDura);
            this.groupBox6.Controls.Add(this.label59);
            this.groupBox6.Controls.Add(this.TbFame);
            this.groupBox6.Location = new System.Drawing.Point(2, 242);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(213, 99);
            this.groupBox6.TabIndex = 33;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Min And Max Level";
            // 
            // TbMinLvl
            // 
            this.TbMinLvl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbMinLvl.Location = new System.Drawing.Point(40, 25);
            this.TbMinLvl.Name = "TbMinLvl";
            this.TbMinLvl.Size = new System.Drawing.Size(50, 20);
            this.TbMinLvl.TabIndex = 25;
            this.TbMinLvl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox16_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Min:";
            // 
            // TbMaxlvl
            // 
            this.TbMaxlvl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbMaxlvl.Location = new System.Drawing.Point(147, 24);
            this.TbMaxlvl.Name = "TbMaxlvl";
            this.TbMaxlvl.Size = new System.Drawing.Size(46, 20);
            this.TbMaxlvl.TabIndex = 27;
            this.TbMaxlvl.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            this.TbMaxlvl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox17_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(104, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Max:";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(5, 68);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(33, 13);
            this.label93.TabIndex = 60;
            this.label93.Text = "Dura:";
            // 
            // TbDura
            // 
            this.TbDura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbDura.Location = new System.Drawing.Point(40, 65);
            this.TbDura.Name = "TbDura";
            this.TbDura.Size = new System.Drawing.Size(51, 20);
            this.TbDura.TabIndex = 59;
            this.TbDura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox93_KeyPress);
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(107, 66);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(36, 13);
            this.label59.TabIndex = 50;
            this.label59.Text = "Fame:";
            // 
            // TbFame
            // 
            this.TbFame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbFame.Location = new System.Drawing.Point(147, 66);
            this.TbFame.Name = "TbFame";
            this.TbFame.Size = new System.Drawing.Size(45, 20);
            this.TbFame.TabIndex = 49;
            this.TbFame.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox59_KeyUp);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.TbSet3);
            this.groupBox10.Controls.Add(this.label56);
            this.groupBox10.Controls.Add(this.label55);
            this.groupBox10.Controls.Add(this.TbSet2);
            this.groupBox10.Controls.Add(this.TbSet4);
            this.groupBox10.Controls.Add(this.label54);
            this.groupBox10.Controls.Add(this.TbSet1);
            this.groupBox10.Controls.Add(this.label53);
            this.groupBox10.Controls.Add(this.TbSet0);
            this.groupBox10.Controls.Add(this.label52);
            this.groupBox10.Location = new System.Drawing.Point(495, 456);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(119, 146);
            this.groupBox10.TabIndex = 41;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Random Settings";
            // 
            // TbSet3
            // 
            this.TbSet3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbSet3.Location = new System.Drawing.Point(56, 97);
            this.TbSet3.Name = "TbSet3";
            this.TbSet3.Size = new System.Drawing.Size(53, 20);
            this.TbSet3.TabIndex = 50;
            this.TbSet3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox55_KeyPress);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(10, 125);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(32, 13);
            this.label56.TabIndex = 45;
            this.label56.Text = "Set4:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(10, 99);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(32, 13);
            this.label55.TabIndex = 51;
            this.label55.Text = "Set3:";
            // 
            // TbSet2
            // 
            this.TbSet2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbSet2.Location = new System.Drawing.Point(56, 71);
            this.TbSet2.Name = "TbSet2";
            this.TbSet2.Size = new System.Drawing.Size(53, 20);
            this.TbSet2.TabIndex = 48;
            this.TbSet2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox54_KeyPress);
            // 
            // TbSet4
            // 
            this.TbSet4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbSet4.Location = new System.Drawing.Point(56, 123);
            this.TbSet4.Name = "TbSet4";
            this.TbSet4.Size = new System.Drawing.Size(53, 20);
            this.TbSet4.TabIndex = 44;
            this.TbSet4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox56_KeyPress);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(10, 73);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(32, 13);
            this.label54.TabIndex = 49;
            this.label54.Text = "Set2:";
            // 
            // TbSet1
            // 
            this.TbSet1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbSet1.Location = new System.Drawing.Point(56, 45);
            this.TbSet1.Name = "TbSet1";
            this.TbSet1.Size = new System.Drawing.Size(53, 20);
            this.TbSet1.TabIndex = 46;
            this.TbSet1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox53_KeyPress);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(10, 47);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(32, 13);
            this.label53.TabIndex = 47;
            this.label53.Text = "Set1:";
            // 
            // TbSet0
            // 
            this.TbSet0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbSet0.Location = new System.Drawing.Point(56, 19);
            this.TbSet0.Name = "TbSet0";
            this.TbSet0.Size = new System.Drawing.Size(53, 20);
            this.TbSet0.TabIndex = 44;
            this.TbSet0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox52_KeyPress);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(10, 21);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(32, 13);
            this.label52.TabIndex = 45;
            this.label52.Text = "Set0:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSub3);
            this.groupBox4.Controls.Add(this.btnSub2);
            this.groupBox4.Controls.Add(this.btnSub1);
            this.groupBox4.Controls.Add(this.BtnMassNum);
            this.groupBox4.Controls.Add(this.btnPercent2Add);
            this.groupBox4.Controls.Add(this.btnPercent1Add);
            this.groupBox4.Controls.Add(this.btnPercentAdd);
            this.groupBox4.Controls.Add(this.TbPercent2);
            this.groupBox4.Controls.Add(this.TbPercent1);
            this.groupBox4.Controls.Add(this.TbPercent);
            this.groupBox4.Controls.Add(this.label108);
            this.groupBox4.Controls.Add(this.label107);
            this.groupBox4.Controls.Add(this.label106);
            this.groupBox4.Controls.Add(this.TbNum4);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.TbNum0);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.TbNum1);
            this.groupBox4.Controls.Add(this.TbNum3);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.TbNum2);
            this.groupBox4.Location = new System.Drawing.Point(227, 456);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(255, 146);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Options";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnSub3
            // 
            this.btnSub3.Location = new System.Drawing.Point(152, 73);
            this.btnSub3.Name = "btnSub3";
            this.btnSub3.Size = new System.Drawing.Size(19, 20);
            this.btnSub3.TabIndex = 36;
            this.btnSub3.Text = "-";
            this.toolTip1.SetToolTip(this.btnSub3, "Subtract Percent");
            this.btnSub3.UseVisualStyleBackColor = true;
            this.btnSub3.Click += new System.EventHandler(this.btnSub3_Click);
            // 
            // btnSub2
            // 
            this.btnSub2.Location = new System.Drawing.Point(152, 47);
            this.btnSub2.Name = "btnSub2";
            this.btnSub2.Size = new System.Drawing.Size(19, 20);
            this.btnSub2.TabIndex = 35;
            this.btnSub2.Text = "-";
            this.toolTip1.SetToolTip(this.btnSub2, "Subtract Percent");
            this.btnSub2.UseVisualStyleBackColor = true;
            this.btnSub2.Click += new System.EventHandler(this.btnSub2_Click);
            // 
            // btnSub1
            // 
            this.btnSub1.Location = new System.Drawing.Point(152, 19);
            this.btnSub1.Name = "btnSub1";
            this.btnSub1.Size = new System.Drawing.Size(19, 20);
            this.btnSub1.TabIndex = 34;
            this.btnSub1.Text = "-";
            this.toolTip1.SetToolTip(this.btnSub1, "Subtract Percent");
            this.btnSub1.UseVisualStyleBackColor = true;
            this.btnSub1.Click += new System.EventHandler(this.btnSub1_Click);
            // 
            // BtnMassNum
            // 
            this.BtnMassNum.Location = new System.Drawing.Point(129, 110);
            this.BtnMassNum.Name = "BtnMassNum";
            this.BtnMassNum.Size = new System.Drawing.Size(114, 20);
            this.BtnMassNum.TabIndex = 33;
            this.BtnMassNum.Text = "Mass Percent Adjust";
            this.toolTip1.SetToolTip(this.BtnMassNum, "Mass Percent Adjust");
            this.BtnMassNum.UseVisualStyleBackColor = true;
            this.BtnMassNum.Click += new System.EventHandler(this.BtnMassNum_Click);
            // 
            // btnPercent2Add
            // 
            this.btnPercent2Add.Location = new System.Drawing.Point(131, 73);
            this.btnPercent2Add.Name = "btnPercent2Add";
            this.btnPercent2Add.Size = new System.Drawing.Size(19, 20);
            this.btnPercent2Add.TabIndex = 32;
            this.btnPercent2Add.Text = "+";
            this.toolTip1.SetToolTip(this.btnPercent2Add, "Add Percent");
            this.btnPercent2Add.UseVisualStyleBackColor = true;
            this.btnPercent2Add.Click += new System.EventHandler(this.btnPercent2Add_Click);
            // 
            // btnPercent1Add
            // 
            this.btnPercent1Add.Location = new System.Drawing.Point(131, 47);
            this.btnPercent1Add.Name = "btnPercent1Add";
            this.btnPercent1Add.Size = new System.Drawing.Size(19, 20);
            this.btnPercent1Add.TabIndex = 31;
            this.btnPercent1Add.Text = "+";
            this.toolTip1.SetToolTip(this.btnPercent1Add, "Add Percent");
            this.btnPercent1Add.UseVisualStyleBackColor = true;
            this.btnPercent1Add.Click += new System.EventHandler(this.btnPercent1Add_Click);
            // 
            // btnPercentAdd
            // 
            this.btnPercentAdd.Location = new System.Drawing.Point(131, 19);
            this.btnPercentAdd.Name = "btnPercentAdd";
            this.btnPercentAdd.Size = new System.Drawing.Size(19, 20);
            this.btnPercentAdd.TabIndex = 30;
            this.btnPercentAdd.Text = "+";
            this.toolTip1.SetToolTip(this.btnPercentAdd, "Add Percent");
            this.btnPercentAdd.UseVisualStyleBackColor = true;
            this.btnPercentAdd.Click += new System.EventHandler(this.btnPercentAdd_Click);
            // 
            // TbPercent2
            // 
            this.TbPercent2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPercent2.Location = new System.Drawing.Point(176, 72);
            this.TbPercent2.Name = "TbPercent2";
            this.TbPercent2.Size = new System.Drawing.Size(53, 20);
            this.TbPercent2.TabIndex = 29;
            // 
            // TbPercent1
            // 
            this.TbPercent1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPercent1.Location = new System.Drawing.Point(176, 46);
            this.TbPercent1.Name = "TbPercent1";
            this.TbPercent1.Size = new System.Drawing.Size(53, 20);
            this.TbPercent1.TabIndex = 28;
            // 
            // TbPercent
            // 
            this.TbPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPercent.Location = new System.Drawing.Point(176, 20);
            this.TbPercent.Name = "TbPercent";
            this.TbPercent.Size = new System.Drawing.Size(53, 20);
            this.TbPercent.TabIndex = 27;
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label108.Location = new System.Drawing.Point(237, 75);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(14, 15);
            this.label108.TabIndex = 26;
            this.label108.Text = "%";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label107.Location = new System.Drawing.Point(236, 49);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(14, 15);
            this.label107.TabIndex = 25;
            this.label107.Text = "%";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label106.Location = new System.Drawing.Point(235, 22);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(14, 15);
            this.label106.TabIndex = 24;
            this.label106.Text = "%";
            // 
            // TbNum4
            // 
            this.TbNum4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNum4.Location = new System.Drawing.Point(65, 124);
            this.TbNum4.Name = "TbNum4";
            this.TbNum4.Size = new System.Drawing.Size(53, 20);
            this.TbNum4.TabIndex = 22;
            this.TbNum4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox15_KeyPress);
            this.TbNum4.MouseHover += new System.EventHandler(this.textBox15_MouseHover);
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
            // TbNum0
            // 
            this.TbNum0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNum0.Location = new System.Drawing.Point(65, 20);
            this.TbNum0.Name = "TbNum0";
            this.TbNum0.Size = new System.Drawing.Size(53, 20);
            this.TbNum0.TabIndex = 14;
            this.TbNum0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox10_KeyPress);
            this.TbNum0.MouseHover += new System.EventHandler(this.textBox10_MouseHover);
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
            // TbNum1
            // 
            this.TbNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNum1.Location = new System.Drawing.Point(65, 46);
            this.TbNum1.Name = "TbNum1";
            this.TbNum1.Size = new System.Drawing.Size(53, 20);
            this.TbNum1.TabIndex = 16;
            this.TbNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox11_KeyPress);
            this.TbNum1.MouseHover += new System.EventHandler(this.textBox11_MouseHover);
            // 
            // TbNum3
            // 
            this.TbNum3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNum3.Location = new System.Drawing.Point(65, 98);
            this.TbNum3.Name = "TbNum3";
            this.TbNum3.Size = new System.Drawing.Size(53, 20);
            this.TbNum3.TabIndex = 20;
            this.TbNum3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox14_KeyPress);
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
            // TbNum2
            // 
            this.TbNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNum2.Location = new System.Drawing.Point(65, 72);
            this.TbNum2.Name = "TbNum2";
            this.TbNum2.Size = new System.Drawing.Size(53, 20);
            this.TbNum2.TabIndex = 18;
            this.TbNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox13_KeyPress);
            this.TbNum2.MouseHover += new System.EventHandler(this.textBox13_MouseHover);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CbSubType6);
            this.groupBox2.Controls.Add(this.CbSubType5);
            this.groupBox2.Controls.Add(this.CbSubType7);
            this.groupBox2.Controls.Add(this.CbSubType4);
            this.groupBox2.Controls.Add(this.CbSubtype3);
            this.groupBox2.Controls.Add(this.CbSubtype2);
            this.groupBox2.Controls.Add(this.CbSubtype1);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TbType);
            this.groupBox2.Controls.Add(this.TbWearing);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TbSubtype);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(323, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 120);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Character";
            // 
            // CbSubType6
            // 
            this.CbSubType6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbSubType6.FormattingEnabled = true;
            this.CbSubType6.Location = new System.Drawing.Point(70, 54);
            this.CbSubType6.Name = "CbSubType6";
            this.CbSubType6.Size = new System.Drawing.Size(173, 21);
            this.CbSubType6.TabIndex = 48;
            this.CbSubType6.SelectedIndexChanged += new System.EventHandler(this.CbSubType6_SelectedIndexChanged);
            this.CbSubType6.SelectionChangeCommitted += new System.EventHandler(this.CbSubType6_SelectionChangeCommitted);
            // 
            // CbSubType5
            // 
            this.CbSubType5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbSubType5.FormattingEnabled = true;
            this.CbSubType5.Location = new System.Drawing.Point(70, 54);
            this.CbSubType5.Name = "CbSubType5";
            this.CbSubType5.Size = new System.Drawing.Size(173, 21);
            this.CbSubType5.TabIndex = 47;
            this.CbSubType5.SelectedIndexChanged += new System.EventHandler(this.CbSubType5_SelectedIndexChanged);
            this.CbSubType5.SelectionChangeCommitted += new System.EventHandler(this.CbSubType5_SelectionChangeCommitted);
            // 
            // CbSubType7
            // 
            this.CbSubType7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbSubType7.FormattingEnabled = true;
            this.CbSubType7.Location = new System.Drawing.Point(70, 54);
            this.CbSubType7.Name = "CbSubType7";
            this.CbSubType7.Size = new System.Drawing.Size(173, 21);
            this.CbSubType7.TabIndex = 46;
            this.CbSubType7.SelectedIndexChanged += new System.EventHandler(this.CbSubType7_SelectedIndexChanged);
            this.CbSubType7.SelectionChangeCommitted += new System.EventHandler(this.CbSubType7_SelectionChangeCommitted);
            // 
            // CbSubType4
            // 
            this.CbSubType4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbSubType4.FormattingEnabled = true;
            this.CbSubType4.Location = new System.Drawing.Point(70, 54);
            this.CbSubType4.Name = "CbSubType4";
            this.CbSubType4.Size = new System.Drawing.Size(173, 21);
            this.CbSubType4.TabIndex = 45;
            this.CbSubType4.SelectedIndexChanged += new System.EventHandler(this.CbSubType4_SelectedIndexChanged);
            this.CbSubType4.SelectionChangeCommitted += new System.EventHandler(this.CbSubType4_SelectionChangeCommitted);
            // 
            // CbSubtype3
            // 
            this.CbSubtype3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbSubtype3.FormattingEnabled = true;
            this.CbSubtype3.Location = new System.Drawing.Point(70, 54);
            this.CbSubtype3.Name = "CbSubtype3";
            this.CbSubtype3.Size = new System.Drawing.Size(173, 21);
            this.CbSubtype3.TabIndex = 44;
            this.CbSubtype3.SelectedIndexChanged += new System.EventHandler(this.CbSubtype3_SelectedIndexChanged);
            this.CbSubtype3.SelectionChangeCommitted += new System.EventHandler(this.CbSubtype3_SelectionChangeCommitted);
            // 
            // CbSubtype2
            // 
            this.CbSubtype2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbSubtype2.FormattingEnabled = true;
            this.CbSubtype2.Location = new System.Drawing.Point(70, 54);
            this.CbSubtype2.Name = "CbSubtype2";
            this.CbSubtype2.Size = new System.Drawing.Size(173, 21);
            this.CbSubtype2.TabIndex = 43;
            this.CbSubtype2.SelectedIndexChanged += new System.EventHandler(this.CbSubtype2_SelectedIndexChanged);
            this.CbSubtype2.SelectionChangeCommitted += new System.EventHandler(this.CbSubtype2_SelectionChangeCommitted);
            // 
            // CbSubtype1
            // 
            this.CbSubtype1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbSubtype1.FormattingEnabled = true;
            this.CbSubtype1.Location = new System.Drawing.Point(70, 54);
            this.CbSubtype1.Name = "CbSubtype1";
            this.CbSubtype1.Size = new System.Drawing.Size(173, 21);
            this.CbSubtype1.TabIndex = 42;
            this.CbSubtype1.SelectedIndexChanged += new System.EventHandler(this.CbSubtype1_SelectedIndexChanged);
            this.CbSubtype1.SelectionChangeCommitted += new System.EventHandler(this.CbSubtype1_SelectionChangeCommitted);
            // 
            // comboBox4
            // 
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(70, 86);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(173, 21);
            this.comboBox4.TabIndex = 38;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            this.comboBox4.SelectionChangeCommitted += new System.EventHandler(this.comboBox4_SelectionChangeCommitted);
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(70, 54);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(173, 21);
            this.comboBox2.TabIndex = 36;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Wearing:";
            // 
            // TbType
            // 
            this.TbType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbType.Location = new System.Drawing.Point(255, 22);
            this.TbType.Name = "TbType";
            this.TbType.Size = new System.Drawing.Size(30, 20);
            this.TbType.TabIndex = 2;
            // 
            // TbWearing
            // 
            this.TbWearing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbWearing.Location = new System.Drawing.Point(255, 87);
            this.TbWearing.Name = "TbWearing";
            this.TbWearing.Size = new System.Drawing.Size(30, 20);
            this.TbWearing.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "SubType:";
            // 
            // TbSubtype
            // 
            this.TbSubtype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbSubtype.Location = new System.Drawing.Point(255, 56);
            this.TbSubtype.Name = "TbSubtype";
            this.TbSubtype.Size = new System.Drawing.Size(30, 20);
            this.TbSubtype.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Type:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label47);
            this.groupBox1.Controls.Add(this.TbZoneFlag);
            this.groupBox1.Controls.Add(this.TbSmc);
            this.groupBox1.Controls.Add(this.label46);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TbIndex);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TbName);
            this.groupBox1.Controls.Add(this.TbDescr);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(286, 198);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 20);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "View SMC info");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            // 
            // checkBox1
            // 
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(14, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(296, 17);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.Text = "Enable";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(11, 200);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(33, 13);
            this.label47.TabIndex = 35;
            this.label47.Text = "SMC:";
            // 
            // TbZoneFlag
            // 
            this.TbZoneFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbZoneFlag.Location = new System.Drawing.Point(238, 39);
            this.TbZoneFlag.Name = "TbZoneFlag";
            this.TbZoneFlag.Size = new System.Drawing.Size(48, 20);
            this.TbZoneFlag.TabIndex = 34;
            this.TbZoneFlag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox46_KeyPress);
            // 
            // TbSmc
            // 
            this.TbSmc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbSmc.Location = new System.Drawing.Point(55, 198);
            this.TbSmc.Name = "TbSmc";
            this.TbSmc.Size = new System.Drawing.Size(231, 20);
            this.TbSmc.TabIndex = 34;
            this.TbSmc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox47_KeyPress);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(175, 41);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(55, 13);
            this.label46.TabIndex = 35;
            this.label46.Text = "ZoneFlag:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Desc:";
            // 
            // TbIndex
            // 
            this.TbIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbIndex.Location = new System.Drawing.Point(55, 39);
            this.TbIndex.Name = "TbIndex";
            this.TbIndex.Size = new System.Drawing.Size(63, 20);
            this.TbIndex.TabIndex = 1;
            this.TbIndex.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TbIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Index:";
            // 
            // TbName
            // 
            this.TbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbName.Location = new System.Drawing.Point(55, 65);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(231, 20);
            this.TbName.TabIndex = 5;
            this.TbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox5_KeyDown);
            // 
            // TbDescr
            // 
            this.TbDescr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbDescr.Location = new System.Drawing.Point(56, 91);
            this.TbDescr.Multiline = true;
            this.TbDescr.Name = "TbDescr";
            this.TbDescr.Size = new System.Drawing.Size(230, 101);
            this.TbDescr.TabIndex = 6;
            this.TbDescr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(939, 610);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crafting";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pictureBox12);
            this.groupBox7.Controls.Add(this.pictureBox11);
            this.groupBox7.Controls.Add(this.pictureBox10);
            this.groupBox7.Controls.Add(this.pictureBox9);
            this.groupBox7.Controls.Add(this.pictureBox8);
            this.groupBox7.Controls.Add(this.pictureBox7);
            this.groupBox7.Controls.Add(this.pictureBox6);
            this.groupBox7.Controls.Add(this.pictureBox5);
            this.groupBox7.Controls.Add(this.pictureBox4);
            this.groupBox7.Controls.Add(this.pictureBox3);
            this.groupBox7.Controls.Add(this.TbCraftAmnt5);
            this.groupBox7.Controls.Add(this.TbCraftItm6);
            this.groupBox7.Controls.Add(this.TbCraftAmnt8);
            this.groupBox7.Controls.Add(this.label40);
            this.groupBox7.Controls.Add(this.TbCraftItm10);
            this.groupBox7.Controls.Add(this.label28);
            this.groupBox7.Controls.Add(this.TbCraftItm5);
            this.groupBox7.Controls.Add(this.label27);
            this.groupBox7.Controls.Add(this.label39);
            this.groupBox7.Controls.Add(this.label34);
            this.groupBox7.Controls.Add(this.TbCraftAmnt9);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.TbCraftItm7);
            this.groupBox7.Controls.Add(this.TbCraftAmnt2);
            this.groupBox7.Controls.Add(this.TbCraftAmnt7);
            this.groupBox7.Controls.Add(this.label41);
            this.groupBox7.Controls.Add(this.TbCraftAmnt3);
            this.groupBox7.Controls.Add(this.label29);
            this.groupBox7.Controls.Add(this.TbCraftItm1);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.label33);
            this.groupBox7.Controls.Add(this.label38);
            this.groupBox7.Controls.Add(this.TbCraftAmnt10);
            this.groupBox7.Controls.Add(this.label35);
            this.groupBox7.Controls.Add(this.TbCraftItm8);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.TbCraftItm4);
            this.groupBox7.Controls.Add(this.TbCraftAmnt1);
            this.groupBox7.Controls.Add(this.TbCraftAmnt6);
            this.groupBox7.Controls.Add(this.TbCraftAmnt4);
            this.groupBox7.Controls.Add(this.label30);
            this.groupBox7.Controls.Add(this.TbCraftItm2);
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.label32);
            this.groupBox7.Controls.Add(this.label37);
            this.groupBox7.Controls.Add(this.label36);
            this.groupBox7.Controls.Add(this.TbCraftItm9);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.TbCraftItm3);
            this.groupBox7.Controls.Add(this.label31);
            this.groupBox7.Location = new System.Drawing.Point(6, 90);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(733, 176);
            this.groupBox7.TabIndex = 41;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Item Crafting";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox12.Location = new System.Drawing.Point(447, 129);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(22, 22);
            this.pictureBox12.TabIndex = 94;
            this.pictureBox12.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox12, "Search Item");
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            this.pictureBox12.MouseLeave += new System.EventHandler(this.pictureBox12_MouseLeave);
            this.pictureBox12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox12_MouseMove);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(447, 103);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(22, 22);
            this.pictureBox11.TabIndex = 93;
            this.pictureBox11.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox11, "Search Item");
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            this.pictureBox11.MouseLeave += new System.EventHandler(this.pictureBox11_MouseLeave);
            this.pictureBox11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox11_MouseMove);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(447, 77);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(22, 22);
            this.pictureBox10.TabIndex = 92;
            this.pictureBox10.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox10, "Search Item");
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            this.pictureBox10.MouseLeave += new System.EventHandler(this.pictureBox10_MouseLeave);
            this.pictureBox10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox10_MouseMove);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(447, 51);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(22, 22);
            this.pictureBox9.TabIndex = 91;
            this.pictureBox9.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox9, "Search Item");
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            this.pictureBox9.MouseLeave += new System.EventHandler(this.pictureBox9_MouseLeave);
            this.pictureBox9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox9_MouseMove);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(447, 25);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(22, 22);
            this.pictureBox8.TabIndex = 90;
            this.pictureBox8.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox8, "Search Item");
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            this.pictureBox8.MouseLeave += new System.EventHandler(this.pictureBox8_MouseLeave);
            this.pictureBox8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox8_MouseMove);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(143, 129);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(22, 22);
            this.pictureBox7.TabIndex = 89;
            this.pictureBox7.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox7, "Search Item");
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            this.pictureBox7.MouseLeave += new System.EventHandler(this.pictureBox7_MouseLeave);
            this.pictureBox7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox7_MouseMove);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(143, 103);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(22, 22);
            this.pictureBox6.TabIndex = 88;
            this.pictureBox6.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox6, "Search Item");
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            this.pictureBox6.MouseLeave += new System.EventHandler(this.pictureBox6_MouseLeave);
            this.pictureBox6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseMove);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(143, 77);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 22);
            this.pictureBox5.TabIndex = 87;
            this.pictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox5, "Search Item");
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            this.pictureBox5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseMove);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(143, 51);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 22);
            this.pictureBox4.TabIndex = 86;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "Search Item");
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.pictureBox4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(143, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Search Item");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove_1);
            // 
            // TbCraftAmnt5
            // 
            this.TbCraftAmnt5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCraftAmnt5.Location = new System.Drawing.Point(249, 130);
            this.TbCraftAmnt5.Name = "TbCraftAmnt5";
            this.TbCraftAmnt5.Size = new System.Drawing.Size(40, 20);
            this.TbCraftAmnt5.TabIndex = 66;
            this.TbCraftAmnt5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox36_KeyPress);
            // 
            // TbCraftItm6
            // 
            this.TbCraftItm6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCraftItm6.Location = new System.Drawing.Point(380, 26);
            this.TbCraftItm6.Name = "TbCraftItm6";
            this.TbCraftItm6.Size = new System.Drawing.Size(61, 20);
            this.TbCraftItm6.TabIndex = 48;
            this.TbCraftItm6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox27_KeyPress);
            // 
            // TbCraftAmnt8
            // 
            this.TbCraftAmnt8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCraftAmnt8.Location = new System.Drawing.Point(544, 78);
            this.TbCraftAmnt8.Name = "TbCraftAmnt8";
            this.TbCraftAmnt8.Size = new System.Drawing.Size(40, 20);
            this.TbCraftAmnt8.TabIndex = 72;
            this.TbCraftAmnt8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox39_KeyPress);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(480, 106);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(46, 13);
            this.label40.TabIndex = 75;
            this.label40.Text = "Amount:";
            // 
            // TbCraftItm10
            // 
            this.TbCraftItm10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCraftItm10.Location = new System.Drawing.Point(380, 130);
            this.TbCraftItm10.Name = "TbCraftItm10";
            this.TbCraftItm10.Size = new System.Drawing.Size(61, 20);
            this.TbCraftItm10.TabIndex = 56;
            this.TbCraftItm10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox31_KeyPress);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(320, 54);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 13);
            this.label28.TabIndex = 51;
            this.label28.Text = "Item ID:";
            // 
            // TbCraftItm5
            // 
            this.TbCraftItm5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCraftItm5.Location = new System.Drawing.Point(76, 130);
            this.TbCraftItm5.Name = "TbCraftItm5";
            this.TbCraftItm5.Size = new System.Drawing.Size(61, 20);
            this.TbCraftItm5.TabIndex = 46;
            this.TbCraftItm5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox26_KeyPress);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(320, 28);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(44, 13);
            this.label27.TabIndex = 49;
            this.label27.Text = "Item ID:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(480, 80);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(46, 13);
            this.label39.TabIndex = 73;
            this.label39.Text = "Amount:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(187, 80);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(46, 13);
            this.label34.TabIndex = 63;
            this.label34.Text = "Amount:";
            // 
            // TbCraftAmnt9
            // 
            this.TbCraftAmnt9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCraftAmnt9.Location = new System.Drawing.Point(544, 104);
            this.TbCraftAmnt9.Name = "TbCraftAmnt9";
            this.TbCraftAmnt9.Size = new System.Drawing.Size(40, 20);
            this.TbCraftAmnt9.TabIndex = 74;
            this.TbCraftAmnt9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox40_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(18, 28);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 13);
            this.label22.TabIndex = 39;
            this.label22.Text = "Item ID:";
            // 
            // TbCraftItm7
            // 
            this.TbCraftItm7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCraftItm7.Location = new System.Drawing.Point(380, 52);
            this.TbCraftItm7.Name = "TbCraftItm7";
            this.TbCraftItm7.Size = new System.Drawing.Size(61, 20);
            this.TbCraftItm7.TabIndex = 50;
            this.TbCraftItm7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox28_KeyPress);
            // 
            // TbCraftAmnt2
            // 
            this.TbCraftAmnt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCraftAmnt2.Location = new System.Drawing.Point(249, 52);
            this.TbCraftAmnt2.Name = "TbCraftAmnt2";
            this.TbCraftAmnt2.Size = new System.Drawing.Size(40, 20);
            this.TbCraftAmnt2.TabIndex = 60;
            this.TbCraftAmnt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox33_KeyPress);
            // 
            // TbCraftAmnt7
            // 
            this.TbCraftAmnt7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCraftAmnt7.Location = new System.Drawing.Point(544, 52);
            this.TbCraftAmnt7.Name = "TbCraftAmnt7";
            this.TbCraftAmnt7.Size = new System.Drawing.Size(40, 20);
            this.TbCraftAmnt7.TabIndex = 70;
            this.TbCraftAmnt7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox38_KeyPress);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(480, 132);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(46, 13);
            this.label41.TabIndex = 77;
            this.label41.Text = "Amount:";
            // 
            // TbCraftAmnt3
            // 
            this.TbCraftAmnt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCraftAmnt3.Location = new System.Drawing.Point(249, 78);
            this.TbCraftAmnt3.Name = "TbCraftAmnt3";
            this.TbCraftAmnt3.Size = new System.Drawing.Size(40, 20);
            this.TbCraftAmnt3.TabIndex = 62;
            this.TbCraftAmnt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox34_KeyPress);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(320, 80);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(44, 13);
            this.label29.TabIndex = 53;
            this.label29.Text = "Item ID:";
            // 
            // TbCraftItm1
            // 
            this.TbCraftItm1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCraftItm1.Location = new System.Drawing.Point(76, 26);
            this.TbCraftItm1.Name = "TbCraftItm1";
            this.TbCraftItm1.Size = new System.Drawing.Size(61, 20);
            this.TbCraftItm1.TabIndex = 38;
            this.TbCraftItm1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox22_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(18, 132);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(44, 13);
            this.label26.TabIndex = 47;
            this.label26.Text = "Item ID:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(187, 54);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(46, 13);
            this.label33.TabIndex = 61;
            this.label33.Text = "Amount:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(480, 54);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(46, 13);
            this.label38.TabIndex = 71;
            this.label38.Text = "Amount:";
            // 
            // TbCraftAmnt10
            // 
            this.TbCraftAmnt10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCraftAmnt10.Location = new System.Drawing.Point(544, 130);
            this.TbCraftAmnt10.Name = "TbCraftAmnt10";
            this.TbCraftAmnt10.Size = new System.Drawing.Size(40, 20);
            this.TbCraftAmnt10.TabIndex = 76;
            this.TbCraftAmnt10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox41_KeyPress);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(187, 106);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(46, 13);
            this.label35.TabIndex = 65;
            this.label35.Text = "Amount:";
            // 
            // TbCraftItm8
            // 
            this.TbCraftItm8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCraftItm8.Location = new System.Drawing.Point(380, 78);
            this.TbCraftItm8.Name = "TbCraftItm8";
            this.TbCraftItm8.Size = new System.Drawing.Size(61, 20);
            this.TbCraftItm8.TabIndex = 52;
            this.TbCraftItm8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox29_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(18, 54);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 13);
            this.label23.TabIndex = 41;
            this.label23.Text = "Item ID:";
            // 
            // TbCraftItm4
            // 
            this.TbCraftItm4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCraftItm4.Location = new System.Drawing.Point(76, 104);
            this.TbCraftItm4.Name = "TbCraftItm4";
            this.TbCraftItm4.Size = new System.Drawing.Size(61, 20);
            this.TbCraftItm4.TabIndex = 44;
            this.TbCraftItm4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox25_KeyPress);
            // 
            // TbCraftAmnt1
            // 
            this.TbCraftAmnt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCraftAmnt1.Location = new System.Drawing.Point(249, 26);
            this.TbCraftAmnt1.Name = "TbCraftAmnt1";
            this.TbCraftAmnt1.Size = new System.Drawing.Size(40, 20);
            this.TbCraftAmnt1.TabIndex = 58;
            this.TbCraftAmnt1.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            this.TbCraftAmnt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox32_KeyPress);
            // 
            // TbCraftAmnt6
            // 
            this.TbCraftAmnt6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCraftAmnt6.Location = new System.Drawing.Point(544, 26);
            this.TbCraftAmnt6.Name = "TbCraftAmnt6";
            this.TbCraftAmnt6.Size = new System.Drawing.Size(40, 20);
            this.TbCraftAmnt6.TabIndex = 68;
            this.TbCraftAmnt6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox37_KeyPress);
            // 
            // TbCraftAmnt4
            // 
            this.TbCraftAmnt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCraftAmnt4.Location = new System.Drawing.Point(249, 104);
            this.TbCraftAmnt4.Name = "TbCraftAmnt4";
            this.TbCraftAmnt4.Size = new System.Drawing.Size(40, 20);
            this.TbCraftAmnt4.TabIndex = 64;
            this.TbCraftAmnt4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox35_KeyPress);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(320, 106);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(44, 13);
            this.label30.TabIndex = 55;
            this.label30.Text = "Item ID:";
            // 
            // TbCraftItm2
            // 
            this.TbCraftItm2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCraftItm2.Location = new System.Drawing.Point(76, 52);
            this.TbCraftItm2.Name = "TbCraftItm2";
            this.TbCraftItm2.Size = new System.Drawing.Size(61, 20);
            this.TbCraftItm2.TabIndex = 40;
            this.TbCraftItm2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox23_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(18, 106);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(44, 13);
            this.label25.TabIndex = 45;
            this.label25.Text = "Item ID:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(187, 28);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(46, 13);
            this.label32.TabIndex = 59;
            this.label32.Text = "Amount:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(480, 28);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(46, 13);
            this.label37.TabIndex = 69;
            this.label37.Text = "Amount:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(187, 132);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(46, 13);
            this.label36.TabIndex = 67;
            this.label36.Text = "Amount:";
            // 
            // TbCraftItm9
            // 
            this.TbCraftItm9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCraftItm9.Location = new System.Drawing.Point(380, 104);
            this.TbCraftItm9.Name = "TbCraftItm9";
            this.TbCraftItm9.Size = new System.Drawing.Size(61, 20);
            this.TbCraftItm9.TabIndex = 54;
            this.TbCraftItm9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox30_KeyPress);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(18, 80);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 13);
            this.label24.TabIndex = 43;
            this.label24.Text = "Item ID:";
            // 
            // TbCraftItm3
            // 
            this.TbCraftItm3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCraftItm3.Location = new System.Drawing.Point(76, 78);
            this.TbCraftItm3.Name = "TbCraftItm3";
            this.TbCraftItm3.Size = new System.Drawing.Size(61, 20);
            this.TbCraftItm3.TabIndex = 42;
            this.TbCraftItm3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox24_KeyPress);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(320, 132);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(44, 13);
            this.label31.TabIndex = 57;
            this.label31.Text = "Item ID:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.TbCraftSkillLevel2);
            this.groupBox8.Controls.Add(this.label45);
            this.groupBox8.Controls.Add(this.TbCraftSkillId2);
            this.groupBox8.Controls.Add(this.label44);
            this.groupBox8.Controls.Add(this.TbCraftSkillLevel1);
            this.groupBox8.Controls.Add(this.label43);
            this.groupBox8.Controls.Add(this.TbCraftSkillId1);
            this.groupBox8.Controls.Add(this.label42);
            this.groupBox8.Location = new System.Drawing.Point(6, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(232, 78);
            this.groupBox8.TabIndex = 39;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Crafting Skill Requirement";
            // 
            // TbCraftSkillLevel2
            // 
            this.TbCraftSkillLevel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCraftSkillLevel2.Location = new System.Drawing.Point(178, 50);
            this.TbCraftSkillLevel2.Name = "TbCraftSkillLevel2";
            this.TbCraftSkillLevel2.Size = new System.Drawing.Size(40, 20);
            this.TbCraftSkillLevel2.TabIndex = 84;
            this.TbCraftSkillLevel2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox45_KeyPress);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(114, 52);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(58, 13);
            this.label45.TabIndex = 85;
            this.label45.Text = "Skill Level:";
            // 
            // TbCraftSkillId2
            // 
            this.TbCraftSkillId2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCraftSkillId2.Location = new System.Drawing.Point(52, 50);
            this.TbCraftSkillId2.Name = "TbCraftSkillId2";
            this.TbCraftSkillId2.Size = new System.Drawing.Size(40, 20);
            this.TbCraftSkillId2.TabIndex = 82;
            this.TbCraftSkillId2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox44_KeyPress);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(6, 52);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(43, 13);
            this.label44.TabIndex = 83;
            this.label44.Text = "Skill ID:";
            // 
            // TbCraftSkillLevel1
            // 
            this.TbCraftSkillLevel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCraftSkillLevel1.Location = new System.Drawing.Point(178, 24);
            this.TbCraftSkillLevel1.Name = "TbCraftSkillLevel1";
            this.TbCraftSkillLevel1.Size = new System.Drawing.Size(40, 20);
            this.TbCraftSkillLevel1.TabIndex = 80;
            this.TbCraftSkillLevel1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox43_KeyPress);
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
            // TbCraftSkillId1
            // 
            this.TbCraftSkillId1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbCraftSkillId1.Location = new System.Drawing.Point(52, 24);
            this.TbCraftSkillId1.Name = "TbCraftSkillId1";
            this.TbCraftSkillId1.Size = new System.Drawing.Size(40, 20);
            this.TbCraftSkillId1.TabIndex = 78;
            this.TbCraftSkillId1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox42_KeyPress);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(6, 26);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(43, 13);
            this.label42.TabIndex = 79;
            this.label42.Text = "Skill ID:";
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.gbFortune);
            this.tabPage3.Controls.Add(this.groupBox17);
            this.tabPage3.Controls.Add(this.groupBox13);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(939, 610);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rare & Purple & Fortune ";
            // 
            // gbFortune
            // 
            this.gbFortune.Controls.Add(this.toolStrip2);
            this.gbFortune.Controls.Add(this.button8);
            this.gbFortune.Controls.Add(this.button6);
            this.gbFortune.Controls.Add(this.dgV);
            this.gbFortune.Controls.Add(this.button7);
            this.gbFortune.Location = new System.Drawing.Point(3, 300);
            this.gbFortune.Name = "gbFortune";
            this.gbFortune.Size = new System.Drawing.Size(726, 305);
            this.gbFortune.TabIndex = 2;
            this.gbFortune.TabStop = false;
            this.gbFortune.Text = "Fortune";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddItems,
            this.toolStripSeparator6,
            this.btnSaveSelected,
            this.toolStripSeparator1,
            this.btnDeleteSelected,
            this.toolStripLabel1,
            this.r1,
            this.toolBtnClear});
            this.toolStrip2.Location = new System.Drawing.Point(3, 277);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(720, 25);
            this.toolStrip2.TabIndex = 9;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnAddItems
            // 
            this.btnAddItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(33, 22);
            this.btnAddItems.Text = "Add";
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSaveSelected
            // 
            this.btnSaveSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSaveSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveSelected.Name = "btnSaveSelected";
            this.btnSaveSelected.Size = new System.Drawing.Size(82, 22);
            this.btnSaveSelected.Text = "Save Selected";
            this.btnSaveSelected.Click += new System.EventHandler(this.btnSaveSelected_Click);
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
            this.btnDeleteSelected.Size = new System.Drawing.Size(91, 22);
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(179, 22);
            this.toolStripLabel1.Text = " Current Row Number Selected : ";
            // 
            // r1
            // 
            this.r1.Enabled = false;
            this.r1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(50, 25);
            this.r1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolBtnClear
            // 
            this.toolBtnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnClear.Name = "toolBtnClear";
            this.toolBtnClear.Size = new System.Drawing.Size(88, 22);
            this.toolBtnClear.Text = " Clear Selected";
            this.toolBtnClear.Click += new System.EventHandler(this.toolBtnClear_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(16, 576);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(49, 23);
            this.button8.TabIndex = 6;
            this.button8.Text = "Add Item";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(94, 576);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Copy to new";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dgV
            // 
            this.dgV.AllowUserToAddRows = false;
            this.dgV.AllowUserToDeleteRows = false;
            this.dgV.AllowUserToResizeColumns = false;
            this.dgV.AllowUserToResizeRows = false;
            this.dgV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a_item_idx,
            this.a_skill_index,
            this.a_skill_level,
            this.a_string_index,
            this.a_prob,
            this.t_item_idx,
            this.t_skill_index,
            this.t_skill_level,
            this.t_string_index,
            this.t_prob});
            this.dgV.Location = new System.Drawing.Point(8, 18);
            this.dgV.MultiSelect = false;
            this.dgV.Name = "dgV";
            this.dgV.RowHeadersVisible = false;
            this.dgV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgV.Size = new System.Drawing.Size(710, 255);
            this.dgV.TabIndex = 0;
            this.dgV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgV_CellFormatting);
            this.dgV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgV_CellValueChanged);
            this.dgV.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // a_item_idx
            // 
            this.a_item_idx.DataPropertyName = "a_item_idx";
            this.a_item_idx.HeaderText = "Index";
            this.a_item_idx.Name = "a_item_idx";
            this.a_item_idx.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.a_item_idx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.a_item_idx.Width = 80;
            // 
            // a_skill_index
            // 
            this.a_skill_index.DataPropertyName = "a_skill_index";
            this.a_skill_index.HeaderText = "Skill";
            this.a_skill_index.Name = "a_skill_index";
            this.a_skill_index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.a_skill_index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.a_skill_index.Width = 80;
            // 
            // a_skill_level
            // 
            this.a_skill_level.DataPropertyName = "a_skill_level";
            this.a_skill_level.HeaderText = "Level Skill";
            this.a_skill_level.Name = "a_skill_level";
            this.a_skill_level.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.a_skill_level.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.a_skill_level.Width = 80;
            // 
            // a_string_index
            // 
            this.a_string_index.DataPropertyName = "a_string_index";
            this.a_string_index.HeaderText = "String Index";
            this.a_string_index.Name = "a_string_index";
            this.a_string_index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.a_string_index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.a_string_index.Width = 80;
            // 
            // a_prob
            // 
            this.a_prob.DataPropertyName = "a_prob";
            this.a_prob.HeaderText = "Prob";
            this.a_prob.Name = "a_prob";
            this.a_prob.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.a_prob.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.a_prob.Width = 80;
            // 
            // t_item_idx
            // 
            this.t_item_idx.DataPropertyName = "t_item_idx";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.t_item_idx.DefaultCellStyle = dataGridViewCellStyle6;
            this.t_item_idx.HeaderText = "Tmp1";
            this.t_item_idx.Name = "t_item_idx";
            this.t_item_idx.ReadOnly = true;
            this.t_item_idx.Visible = false;
            this.t_item_idx.Width = 50;
            // 
            // t_skill_index
            // 
            this.t_skill_index.DataPropertyName = "t_skill_index";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.t_skill_index.DefaultCellStyle = dataGridViewCellStyle7;
            this.t_skill_index.HeaderText = "Tmp2";
            this.t_skill_index.Name = "t_skill_index";
            this.t_skill_index.ReadOnly = true;
            this.t_skill_index.Visible = false;
            this.t_skill_index.Width = 50;
            // 
            // t_skill_level
            // 
            this.t_skill_level.DataPropertyName = "t_skill_level";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.t_skill_level.DefaultCellStyle = dataGridViewCellStyle8;
            this.t_skill_level.HeaderText = "Tmp3";
            this.t_skill_level.Name = "t_skill_level";
            this.t_skill_level.ReadOnly = true;
            this.t_skill_level.Visible = false;
            this.t_skill_level.Width = 50;
            // 
            // t_string_index
            // 
            this.t_string_index.DataPropertyName = "t_string_index";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.t_string_index.DefaultCellStyle = dataGridViewCellStyle9;
            this.t_string_index.HeaderText = "Tmp4";
            this.t_string_index.Name = "t_string_index";
            this.t_string_index.ReadOnly = true;
            this.t_string_index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.t_string_index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.t_string_index.Visible = false;
            this.t_string_index.Width = 50;
            // 
            // t_prob
            // 
            this.t_prob.DataPropertyName = "t_prob";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.t_prob.DefaultCellStyle = dataGridViewCellStyle10;
            this.t_prob.HeaderText = "Tmp5";
            this.t_prob.Name = "t_prob";
            this.t_prob.ReadOnly = true;
            this.t_prob.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.t_prob.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.t_prob.Visible = false;
            this.t_prob.Width = 50;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(198, 576);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Delete Item";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.comboBox23);
            this.groupBox17.Controls.Add(this.comboBox22);
            this.groupBox17.Controls.Add(this.comboBox21);
            this.groupBox17.Controls.Add(this.comboBox20);
            this.groupBox17.Controls.Add(this.comboBox19);
            this.groupBox17.Controls.Add(this.comboBox18);
            this.groupBox17.Controls.Add(this.comboBox17);
            this.groupBox17.Controls.Add(this.comboBox16);
            this.groupBox17.Controls.Add(this.comboBox15);
            this.groupBox17.Controls.Add(this.comboBox14);
            this.groupBox17.Controls.Add(this.label104);
            this.groupBox17.Controls.Add(this.comboBox13);
            this.groupBox17.Controls.Add(this.label103);
            this.groupBox17.Controls.Add(this.label102);
            this.groupBox17.Controls.Add(this.label101);
            this.groupBox17.Controls.Add(this.label100);
            this.groupBox17.Controls.Add(this.comboBox12);
            this.groupBox17.Controls.Add(this.comboBox11);
            this.groupBox17.Controls.Add(this.comboBox10);
            this.groupBox17.Controls.Add(this.comboBox9);
            this.groupBox17.Controls.Add(this.comboBox8);
            this.groupBox17.Controls.Add(this.label99);
            this.groupBox17.Controls.Add(this.comboBox7);
            this.groupBox17.Controls.Add(this.label98);
            this.groupBox17.Controls.Add(this.comboBox6);
            this.groupBox17.Controls.Add(this.label97);
            this.groupBox17.Controls.Add(this.comboBox5);
            this.groupBox17.Controls.Add(this.label96);
            this.groupBox17.Controls.Add(this.comboBox3);
            this.groupBox17.Controls.Add(this.label95);
            this.groupBox17.Location = new System.Drawing.Point(341, 2);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(388, 295);
            this.groupBox17.TabIndex = 1;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Purple Items";
            // 
            // comboBox23
            // 
            this.comboBox23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox23.FormattingEnabled = true;
            this.comboBox23.Location = new System.Drawing.Point(275, 261);
            this.comboBox23.Name = "comboBox23";
            this.comboBox23.Size = new System.Drawing.Size(109, 21);
            this.comboBox23.TabIndex = 37;
            this.comboBox23.SelectedIndexChanged += new System.EventHandler(this.comboBox23_SelectedIndexChanged);
            // 
            // comboBox22
            // 
            this.comboBox22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox22.FormattingEnabled = true;
            this.comboBox22.Location = new System.Drawing.Point(275, 234);
            this.comboBox22.Name = "comboBox22";
            this.comboBox22.Size = new System.Drawing.Size(109, 21);
            this.comboBox22.TabIndex = 36;
            this.comboBox22.SelectedIndexChanged += new System.EventHandler(this.comboBox22_SelectedIndexChanged);
            // 
            // comboBox21
            // 
            this.comboBox21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox21.FormattingEnabled = true;
            this.comboBox21.Location = new System.Drawing.Point(275, 207);
            this.comboBox21.Name = "comboBox21";
            this.comboBox21.Size = new System.Drawing.Size(109, 21);
            this.comboBox21.TabIndex = 35;
            this.comboBox21.SelectedIndexChanged += new System.EventHandler(this.comboBox21_SelectedIndexChanged);
            // 
            // comboBox20
            // 
            this.comboBox20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox20.FormattingEnabled = true;
            this.comboBox20.Location = new System.Drawing.Point(275, 180);
            this.comboBox20.Name = "comboBox20";
            this.comboBox20.Size = new System.Drawing.Size(109, 21);
            this.comboBox20.TabIndex = 34;
            this.comboBox20.SelectedIndexChanged += new System.EventHandler(this.comboBox20_SelectedIndexChanged);
            // 
            // comboBox19
            // 
            this.comboBox19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox19.FormattingEnabled = true;
            this.comboBox19.Location = new System.Drawing.Point(275, 153);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Size = new System.Drawing.Size(109, 21);
            this.comboBox19.TabIndex = 33;
            this.comboBox19.SelectedIndexChanged += new System.EventHandler(this.comboBox19_SelectedIndexChanged);
            // 
            // comboBox18
            // 
            this.comboBox18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox18.FormattingEnabled = true;
            this.comboBox18.Location = new System.Drawing.Point(275, 126);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(109, 21);
            this.comboBox18.TabIndex = 32;
            this.comboBox18.SelectedIndexChanged += new System.EventHandler(this.comboBox18_SelectedIndexChanged);
            // 
            // comboBox17
            // 
            this.comboBox17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox17.FormattingEnabled = true;
            this.comboBox17.Location = new System.Drawing.Point(275, 99);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Size = new System.Drawing.Size(109, 21);
            this.comboBox17.TabIndex = 31;
            this.comboBox17.SelectedIndexChanged += new System.EventHandler(this.comboBox17_SelectedIndexChanged);
            // 
            // comboBox16
            // 
            this.comboBox16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox16.FormattingEnabled = true;
            this.comboBox16.Location = new System.Drawing.Point(275, 72);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(109, 21);
            this.comboBox16.TabIndex = 30;
            this.comboBox16.SelectedIndexChanged += new System.EventHandler(this.comboBox16_SelectedIndexChanged);
            // 
            // comboBox15
            // 
            this.comboBox15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Location = new System.Drawing.Point(275, 45);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(109, 21);
            this.comboBox15.TabIndex = 29;
            this.comboBox15.SelectedIndexChanged += new System.EventHandler(this.comboBox15_SelectedIndexChanged);
            // 
            // comboBox14
            // 
            this.comboBox14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Location = new System.Drawing.Point(275, 18);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(109, 21);
            this.comboBox14.TabIndex = 28;
            this.comboBox14.SelectedIndexChanged += new System.EventHandler(this.comboBox14_SelectedIndexChanged);
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(5, 264);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(40, 13);
            this.label104.TabIndex = 27;
            this.label104.Text = "Seal 9:";
            // 
            // comboBox13
            // 
            this.comboBox13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Location = new System.Drawing.Point(51, 261);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(217, 21);
            this.comboBox13.TabIndex = 26;
            this.comboBox13.SelectedIndexChanged += new System.EventHandler(this.comboBox13_SelectedIndexChanged);
            this.comboBox13.SelectionChangeCommitted += new System.EventHandler(this.comboBox13_SelectionChangeCommitted);
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(5, 237);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(40, 13);
            this.label103.TabIndex = 25;
            this.label103.Text = "Seal 8:";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(5, 211);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(40, 13);
            this.label102.TabIndex = 24;
            this.label102.Text = "Seal 7:";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(5, 184);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(40, 13);
            this.label101.TabIndex = 23;
            this.label101.Text = "Seal 6:";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(5, 156);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(40, 13);
            this.label100.TabIndex = 22;
            this.label100.Text = "Seal 5:";
            // 
            // comboBox12
            // 
            this.comboBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Location = new System.Drawing.Point(51, 234);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(217, 21);
            this.comboBox12.TabIndex = 21;
            this.comboBox12.SelectedIndexChanged += new System.EventHandler(this.comboBox12_SelectedIndexChanged);
            this.comboBox12.SelectionChangeCommitted += new System.EventHandler(this.comboBox12_SelectionChangeCommitted);
            // 
            // comboBox11
            // 
            this.comboBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(51, 207);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(217, 21);
            this.comboBox11.TabIndex = 20;
            this.comboBox11.SelectedIndexChanged += new System.EventHandler(this.comboBox11_SelectedIndexChanged);
            this.comboBox11.SelectionChangeCommitted += new System.EventHandler(this.comboBox11_SelectionChangeCommitted);
            // 
            // comboBox10
            // 
            this.comboBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(51, 180);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(217, 21);
            this.comboBox10.TabIndex = 19;
            this.comboBox10.SelectedIndexChanged += new System.EventHandler(this.comboBox10_SelectedIndexChanged);
            this.comboBox10.SelectionChangeCommitted += new System.EventHandler(this.comboBox10_SelectionChangeCommitted);
            // 
            // comboBox9
            // 
            this.comboBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(51, 153);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(217, 21);
            this.comboBox9.TabIndex = 18;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            this.comboBox9.SelectionChangeCommitted += new System.EventHandler(this.comboBox9_SelectionChangeCommitted);
            // 
            // comboBox8
            // 
            this.comboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(51, 126);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(217, 21);
            this.comboBox8.TabIndex = 17;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            this.comboBox8.SelectionChangeCommitted += new System.EventHandler(this.comboBox8_SelectionChangeCommitted);
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(5, 128);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(40, 13);
            this.label99.TabIndex = 16;
            this.label99.Text = "Seal 4:";
            // 
            // comboBox7
            // 
            this.comboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(51, 99);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(217, 21);
            this.comboBox7.TabIndex = 13;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            this.comboBox7.SelectionChangeCommitted += new System.EventHandler(this.comboBox7_SelectionChangeCommitted);
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(5, 101);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(40, 13);
            this.label98.TabIndex = 12;
            this.label98.Text = "Seal 3:";
            // 
            // comboBox6
            // 
            this.comboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(51, 72);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(217, 21);
            this.comboBox6.TabIndex = 9;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            this.comboBox6.SelectionChangeCommitted += new System.EventHandler(this.comboBox6_SelectionChangeCommitted);
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(5, 76);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(40, 13);
            this.label97.TabIndex = 8;
            this.label97.Text = "Seal 2:";
            // 
            // comboBox5
            // 
            this.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(51, 45);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(217, 21);
            this.comboBox5.TabIndex = 5;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            this.comboBox5.SelectionChangeCommitted += new System.EventHandler(this.comboBox5_SelectionChangeCommitted);
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(5, 49);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(40, 13);
            this.label96.TabIndex = 4;
            this.label96.Text = "Seal 1:";
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(51, 18);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(217, 21);
            this.comboBox3.TabIndex = 1;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.comboBox3.SelectionChangeCommitted += new System.EventHandler(this.comboBox3_SelectionChangeCommitted);
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(5, 21);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(40, 13);
            this.label95.TabIndex = 0;
            this.label95.Text = "Seal 0:";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.lblProb10);
            this.groupBox13.Controls.Add(this.lblProb9);
            this.groupBox13.Controls.Add(this.lblProb8);
            this.groupBox13.Controls.Add(this.lblProb7);
            this.groupBox13.Controls.Add(this.lblProb6);
            this.groupBox13.Controls.Add(this.lblProb5);
            this.groupBox13.Controls.Add(this.lblProb4);
            this.groupBox13.Controls.Add(this.lblProb3);
            this.groupBox13.Controls.Add(this.lblProb2);
            this.groupBox13.Controls.Add(this.lblProb1);
            this.groupBox13.Controls.Add(this.pictureBox22);
            this.groupBox13.Controls.Add(this.pictureBox21);
            this.groupBox13.Controls.Add(this.pictureBox20);
            this.groupBox13.Controls.Add(this.pictureBox19);
            this.groupBox13.Controls.Add(this.pictureBox18);
            this.groupBox13.Controls.Add(this.pictureBox17);
            this.groupBox13.Controls.Add(this.pictureBox16);
            this.groupBox13.Controls.Add(this.pictureBox15);
            this.groupBox13.Controls.Add(this.pictureBox14);
            this.groupBox13.Controls.Add(this.pictureBox13);
            this.groupBox13.Controls.Add(this.TbOptionLvl10);
            this.groupBox13.Controls.Add(this.label79);
            this.groupBox13.Controls.Add(this.TbOptionLvl9);
            this.groupBox13.Controls.Add(this.label78);
            this.groupBox13.Controls.Add(this.TbOptionLvl8);
            this.groupBox13.Controls.Add(this.label77);
            this.groupBox13.Controls.Add(this.TbOptionLvl7);
            this.groupBox13.Controls.Add(this.label76);
            this.groupBox13.Controls.Add(this.TbOptionLvl6);
            this.groupBox13.Controls.Add(this.label75);
            this.groupBox13.Controls.Add(this.TbOptionLvl5);
            this.groupBox13.Controls.Add(this.label74);
            this.groupBox13.Controls.Add(this.TbOptionLvl4);
            this.groupBox13.Controls.Add(this.label73);
            this.groupBox13.Controls.Add(this.TbOptionLvl3);
            this.groupBox13.Controls.Add(this.label72);
            this.groupBox13.Controls.Add(this.TbOptionLvl2);
            this.groupBox13.Controls.Add(this.label71);
            this.groupBox13.Controls.Add(this.TbOptionLvl1);
            this.groupBox13.Controls.Add(this.label70);
            this.groupBox13.Controls.Add(this.TbOptionID10);
            this.groupBox13.Controls.Add(this.label69);
            this.groupBox13.Controls.Add(this.TbOptionID9);
            this.groupBox13.Controls.Add(this.label68);
            this.groupBox13.Controls.Add(this.TbOptionID8);
            this.groupBox13.Controls.Add(this.label67);
            this.groupBox13.Controls.Add(this.TbOptionID7);
            this.groupBox13.Controls.Add(this.label66);
            this.groupBox13.Controls.Add(this.TbOptionID6);
            this.groupBox13.Controls.Add(this.label65);
            this.groupBox13.Controls.Add(this.TbOptionID5);
            this.groupBox13.Controls.Add(this.label64);
            this.groupBox13.Controls.Add(this.TbOptionID4);
            this.groupBox13.Controls.Add(this.label63);
            this.groupBox13.Controls.Add(this.TbOptionID3);
            this.groupBox13.Controls.Add(this.label62);
            this.groupBox13.Controls.Add(this.TbOptionID2);
            this.groupBox13.Controls.Add(this.label61);
            this.groupBox13.Controls.Add(this.TbOptionID1);
            this.groupBox13.Controls.Add(this.label60);
            this.groupBox13.Location = new System.Drawing.Point(3, 3);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(337, 295);
            this.groupBox13.TabIndex = 0;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Rare Options";
            // 
            // lblProb10
            // 
            this.lblProb10.AutoSize = true;
            this.lblProb10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblProb10.Location = new System.Drawing.Point(280, 261);
            this.lblProb10.Name = "lblProb10";
            this.lblProb10.Size = new System.Drawing.Size(0, 15);
            this.lblProb10.TabIndex = 109;
            // 
            // lblProb9
            // 
            this.lblProb9.AutoSize = true;
            this.lblProb9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblProb9.Location = new System.Drawing.Point(279, 234);
            this.lblProb9.Name = "lblProb9";
            this.lblProb9.Size = new System.Drawing.Size(0, 15);
            this.lblProb9.TabIndex = 108;
            // 
            // lblProb8
            // 
            this.lblProb8.AutoSize = true;
            this.lblProb8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblProb8.Location = new System.Drawing.Point(280, 209);
            this.lblProb8.Name = "lblProb8";
            this.lblProb8.Size = new System.Drawing.Size(0, 15);
            this.lblProb8.TabIndex = 107;
            // 
            // lblProb7
            // 
            this.lblProb7.AutoSize = true;
            this.lblProb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblProb7.Location = new System.Drawing.Point(280, 182);
            this.lblProb7.Name = "lblProb7";
            this.lblProb7.Size = new System.Drawing.Size(0, 15);
            this.lblProb7.TabIndex = 106;
            // 
            // lblProb6
            // 
            this.lblProb6.AutoSize = true;
            this.lblProb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblProb6.Location = new System.Drawing.Point(279, 156);
            this.lblProb6.Name = "lblProb6";
            this.lblProb6.Size = new System.Drawing.Size(0, 15);
            this.lblProb6.TabIndex = 105;
            // 
            // lblProb5
            // 
            this.lblProb5.AutoSize = true;
            this.lblProb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblProb5.Location = new System.Drawing.Point(280, 130);
            this.lblProb5.Name = "lblProb5";
            this.lblProb5.Size = new System.Drawing.Size(0, 15);
            this.lblProb5.TabIndex = 104;
            // 
            // lblProb4
            // 
            this.lblProb4.AutoSize = true;
            this.lblProb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblProb4.Location = new System.Drawing.Point(280, 102);
            this.lblProb4.Name = "lblProb4";
            this.lblProb4.Size = new System.Drawing.Size(0, 15);
            this.lblProb4.TabIndex = 103;
            // 
            // lblProb3
            // 
            this.lblProb3.AutoSize = true;
            this.lblProb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblProb3.Location = new System.Drawing.Point(280, 76);
            this.lblProb3.Name = "lblProb3";
            this.lblProb3.Size = new System.Drawing.Size(0, 15);
            this.lblProb3.TabIndex = 102;
            // 
            // lblProb2
            // 
            this.lblProb2.AutoSize = true;
            this.lblProb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblProb2.Location = new System.Drawing.Point(281, 50);
            this.lblProb2.Name = "lblProb2";
            this.lblProb2.Size = new System.Drawing.Size(0, 15);
            this.lblProb2.TabIndex = 101;
            // 
            // lblProb1
            // 
            this.lblProb1.AutoSize = true;
            this.lblProb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProb1.Location = new System.Drawing.Point(281, 23);
            this.lblProb1.Name = "lblProb1";
            this.lblProb1.Size = new System.Drawing.Size(0, 15);
            this.lblProb1.TabIndex = 100;
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pictureBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox22.Location = new System.Drawing.Point(135, 254);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(22, 22);
            this.pictureBox22.TabIndex = 99;
            this.pictureBox22.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox22, "Search Option");
            this.pictureBox22.Click += new System.EventHandler(this.pictureBox22_Click);
            this.pictureBox22.MouseLeave += new System.EventHandler(this.pictureBox22_MouseLeave);
            this.pictureBox22.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox22_MouseMove);
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pictureBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox21.Location = new System.Drawing.Point(135, 228);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(22, 22);
            this.pictureBox21.TabIndex = 98;
            this.pictureBox21.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox21, "Search Option");
            this.pictureBox21.Click += new System.EventHandler(this.pictureBox21_Click);
            this.pictureBox21.MouseLeave += new System.EventHandler(this.pictureBox21_MouseLeave);
            this.pictureBox21.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox21_MouseMove);
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pictureBox20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox20.Location = new System.Drawing.Point(135, 202);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(22, 22);
            this.pictureBox20.TabIndex = 97;
            this.pictureBox20.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox20, "Search Option");
            this.pictureBox20.Click += new System.EventHandler(this.pictureBox20_Click);
            this.pictureBox20.MouseLeave += new System.EventHandler(this.pictureBox20_MouseLeave);
            this.pictureBox20.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox20_MouseMove);
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pictureBox19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox19.Location = new System.Drawing.Point(135, 175);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(22, 22);
            this.pictureBox19.TabIndex = 96;
            this.pictureBox19.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox19, "Search Option");
            this.pictureBox19.Click += new System.EventHandler(this.pictureBox19_Click);
            this.pictureBox19.MouseLeave += new System.EventHandler(this.pictureBox19_MouseLeave);
            this.pictureBox19.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox19_MouseMove);
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pictureBox18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox18.Location = new System.Drawing.Point(135, 149);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(22, 22);
            this.pictureBox18.TabIndex = 95;
            this.pictureBox18.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox18, "Search Option");
            this.pictureBox18.Click += new System.EventHandler(this.pictureBox18_Click);
            this.pictureBox18.MouseLeave += new System.EventHandler(this.pictureBox18_MouseLeave);
            this.pictureBox18.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox18_MouseMove);
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox17.Location = new System.Drawing.Point(135, 123);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(22, 22);
            this.pictureBox17.TabIndex = 94;
            this.pictureBox17.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox17, "Search Option");
            this.pictureBox17.Click += new System.EventHandler(this.pictureBox17_Click);
            this.pictureBox17.MouseLeave += new System.EventHandler(this.pictureBox17_MouseLeave);
            this.pictureBox17.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox17_MouseMove);
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox16.Location = new System.Drawing.Point(135, 97);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(22, 22);
            this.pictureBox16.TabIndex = 93;
            this.pictureBox16.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox16, "Search Option");
            this.pictureBox16.Click += new System.EventHandler(this.pictureBox16_Click);
            this.pictureBox16.MouseLeave += new System.EventHandler(this.pictureBox16_MouseLeave);
            this.pictureBox16.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox16_MouseMove);
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox15.Location = new System.Drawing.Point(135, 71);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(22, 22);
            this.pictureBox15.TabIndex = 92;
            this.pictureBox15.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox15, "Search Option");
            this.pictureBox15.Click += new System.EventHandler(this.pictureBox15_Click);
            this.pictureBox15.MouseLeave += new System.EventHandler(this.pictureBox15_MouseLeave);
            this.pictureBox15.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox15_MouseMove);
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox14.Location = new System.Drawing.Point(135, 45);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(22, 22);
            this.pictureBox14.TabIndex = 91;
            this.pictureBox14.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox14, "Search Option");
            this.pictureBox14.Click += new System.EventHandler(this.pictureBox14_Click);
            this.pictureBox14.MouseLeave += new System.EventHandler(this.pictureBox14_MouseLeave);
            this.pictureBox14.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox14_MouseMove);
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox13.Location = new System.Drawing.Point(135, 19);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(22, 22);
            this.pictureBox13.TabIndex = 90;
            this.pictureBox13.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox13, "Search Option");
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            this.pictureBox13.MouseLeave += new System.EventHandler(this.pictureBox13_MouseLeave);
            this.pictureBox13.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox13_MouseMove);
            // 
            // TbOptionLvl10
            // 
            this.TbOptionLvl10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbOptionLvl10.Location = new System.Drawing.Point(217, 257);
            this.TbOptionLvl10.Name = "TbOptionLvl10";
            this.TbOptionLvl10.Size = new System.Drawing.Size(61, 20);
            this.TbOptionLvl10.TabIndex = 78;
            this.TbOptionLvl10.TextChanged += new System.EventHandler(this.TbOptionLvl10_TextChanged);
            this.TbOptionLvl10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox79_KeyPress);
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(164, 259);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(47, 13);
            this.label79.TabIndex = 79;
            this.label79.Text = "Chance:";
            // 
            // TbOptionLvl9
            // 
            this.TbOptionLvl9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbOptionLvl9.Location = new System.Drawing.Point(217, 231);
            this.TbOptionLvl9.Name = "TbOptionLvl9";
            this.TbOptionLvl9.Size = new System.Drawing.Size(61, 20);
            this.TbOptionLvl9.TabIndex = 76;
            this.TbOptionLvl9.TextChanged += new System.EventHandler(this.TbOptionLvl9_TextChanged);
            this.TbOptionLvl9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox78_KeyPress);
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(164, 233);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(47, 13);
            this.label78.TabIndex = 77;
            this.label78.Text = "Chance:";
            // 
            // TbOptionLvl8
            // 
            this.TbOptionLvl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbOptionLvl8.Location = new System.Drawing.Point(217, 205);
            this.TbOptionLvl8.Name = "TbOptionLvl8";
            this.TbOptionLvl8.Size = new System.Drawing.Size(61, 20);
            this.TbOptionLvl8.TabIndex = 74;
            this.TbOptionLvl8.TextChanged += new System.EventHandler(this.TbOptionLvl8_TextChanged);
            this.TbOptionLvl8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox77_KeyPress);
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(164, 207);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(47, 13);
            this.label77.TabIndex = 75;
            this.label77.Text = "Chance:";
            // 
            // TbOptionLvl7
            // 
            this.TbOptionLvl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbOptionLvl7.Location = new System.Drawing.Point(217, 179);
            this.TbOptionLvl7.Name = "TbOptionLvl7";
            this.TbOptionLvl7.Size = new System.Drawing.Size(61, 20);
            this.TbOptionLvl7.TabIndex = 72;
            this.TbOptionLvl7.TextChanged += new System.EventHandler(this.TbOptionLvl7_TextChanged);
            this.TbOptionLvl7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox76_KeyPress);
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(164, 181);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(47, 13);
            this.label76.TabIndex = 73;
            this.label76.Text = "Chance:";
            // 
            // TbOptionLvl6
            // 
            this.TbOptionLvl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbOptionLvl6.Location = new System.Drawing.Point(217, 153);
            this.TbOptionLvl6.Name = "TbOptionLvl6";
            this.TbOptionLvl6.Size = new System.Drawing.Size(61, 20);
            this.TbOptionLvl6.TabIndex = 70;
            this.TbOptionLvl6.TextChanged += new System.EventHandler(this.TbOptionLvl6_TextChanged);
            this.TbOptionLvl6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox75_KeyPress);
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(164, 155);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(47, 13);
            this.label75.TabIndex = 71;
            this.label75.Text = "Chance:";
            // 
            // TbOptionLvl5
            // 
            this.TbOptionLvl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbOptionLvl5.Location = new System.Drawing.Point(217, 126);
            this.TbOptionLvl5.Name = "TbOptionLvl5";
            this.TbOptionLvl5.Size = new System.Drawing.Size(61, 20);
            this.TbOptionLvl5.TabIndex = 68;
            this.TbOptionLvl5.TextChanged += new System.EventHandler(this.TbOptionLvl5_TextChanged);
            this.TbOptionLvl5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox74_KeyPress);
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(164, 128);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(47, 13);
            this.label74.TabIndex = 69;
            this.label74.Text = "Chance:";
            // 
            // TbOptionLvl4
            // 
            this.TbOptionLvl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbOptionLvl4.Location = new System.Drawing.Point(217, 98);
            this.TbOptionLvl4.Name = "TbOptionLvl4";
            this.TbOptionLvl4.Size = new System.Drawing.Size(61, 20);
            this.TbOptionLvl4.TabIndex = 66;
            this.TbOptionLvl4.TextChanged += new System.EventHandler(this.TbOptionLvl4_TextChanged);
            this.TbOptionLvl4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox73_KeyPress);
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(164, 100);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(47, 13);
            this.label73.TabIndex = 67;
            this.label73.Text = "Chance:";
            // 
            // TbOptionLvl3
            // 
            this.TbOptionLvl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbOptionLvl3.Location = new System.Drawing.Point(217, 72);
            this.TbOptionLvl3.Name = "TbOptionLvl3";
            this.TbOptionLvl3.Size = new System.Drawing.Size(61, 20);
            this.TbOptionLvl3.TabIndex = 64;
            this.TbOptionLvl3.TextChanged += new System.EventHandler(this.TbOptionLvl3_TextChanged);
            this.TbOptionLvl3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox72_KeyPress);
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(164, 74);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(47, 13);
            this.label72.TabIndex = 65;
            this.label72.Text = "Chance:";
            // 
            // TbOptionLvl2
            // 
            this.TbOptionLvl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbOptionLvl2.Location = new System.Drawing.Point(217, 46);
            this.TbOptionLvl2.Name = "TbOptionLvl2";
            this.TbOptionLvl2.Size = new System.Drawing.Size(61, 20);
            this.TbOptionLvl2.TabIndex = 62;
            this.TbOptionLvl2.TextChanged += new System.EventHandler(this.TbOptionLvl2_TextChanged);
            this.TbOptionLvl2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox71_KeyPress);
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(164, 48);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(47, 13);
            this.label71.TabIndex = 63;
            this.label71.Text = "Chance:";
            // 
            // TbOptionLvl1
            // 
            this.TbOptionLvl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbOptionLvl1.Location = new System.Drawing.Point(217, 20);
            this.TbOptionLvl1.Name = "TbOptionLvl1";
            this.TbOptionLvl1.Size = new System.Drawing.Size(61, 20);
            this.TbOptionLvl1.TabIndex = 60;
            this.TbOptionLvl1.TextChanged += new System.EventHandler(this.textBox70_TextChanged);
            this.TbOptionLvl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox70_KeyPress);
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(164, 22);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(47, 13);
            this.label70.TabIndex = 61;
            this.label70.Text = "Chance:";
            // 
            // TbOptionID10
            // 
            this.TbOptionID10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbOptionID10.Location = new System.Drawing.Point(68, 255);
            this.TbOptionID10.Name = "TbOptionID10";
            this.TbOptionID10.Size = new System.Drawing.Size(61, 20);
            this.TbOptionID10.TabIndex = 58;
            this.TbOptionID10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox69_KeyPress);
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(15, 257);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(47, 13);
            this.label69.TabIndex = 59;
            this.label69.Text = "Option9:";
            // 
            // TbOptionID9
            // 
            this.TbOptionID9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbOptionID9.Location = new System.Drawing.Point(68, 229);
            this.TbOptionID9.Name = "TbOptionID9";
            this.TbOptionID9.Size = new System.Drawing.Size(61, 20);
            this.TbOptionID9.TabIndex = 56;
            this.TbOptionID9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox68_KeyPress);
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(15, 231);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(47, 13);
            this.label68.TabIndex = 57;
            this.label68.Text = "Option8:";
            // 
            // TbOptionID8
            // 
            this.TbOptionID8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbOptionID8.Location = new System.Drawing.Point(68, 203);
            this.TbOptionID8.Name = "TbOptionID8";
            this.TbOptionID8.Size = new System.Drawing.Size(61, 20);
            this.TbOptionID8.TabIndex = 54;
            this.TbOptionID8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox67_KeyPress);
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(15, 205);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(47, 13);
            this.label67.TabIndex = 55;
            this.label67.Text = "Option7:";
            // 
            // TbOptionID7
            // 
            this.TbOptionID7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbOptionID7.Location = new System.Drawing.Point(68, 177);
            this.TbOptionID7.Name = "TbOptionID7";
            this.TbOptionID7.Size = new System.Drawing.Size(61, 20);
            this.TbOptionID7.TabIndex = 52;
            this.TbOptionID7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox66_KeyPress);
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(15, 179);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(47, 13);
            this.label66.TabIndex = 53;
            this.label66.Text = "Option6:";
            // 
            // TbOptionID6
            // 
            this.TbOptionID6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbOptionID6.Location = new System.Drawing.Point(68, 151);
            this.TbOptionID6.Name = "TbOptionID6";
            this.TbOptionID6.Size = new System.Drawing.Size(61, 20);
            this.TbOptionID6.TabIndex = 50;
            this.TbOptionID6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox65_KeyPress);
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(15, 153);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(47, 13);
            this.label65.TabIndex = 51;
            this.label65.Text = "Option5:";
            // 
            // TbOptionID5
            // 
            this.TbOptionID5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbOptionID5.Location = new System.Drawing.Point(68, 124);
            this.TbOptionID5.Name = "TbOptionID5";
            this.TbOptionID5.Size = new System.Drawing.Size(61, 20);
            this.TbOptionID5.TabIndex = 48;
            this.TbOptionID5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox64_KeyPress);
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(15, 126);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(47, 13);
            this.label64.TabIndex = 49;
            this.label64.Text = "Option4:";
            // 
            // TbOptionID4
            // 
            this.TbOptionID4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbOptionID4.Location = new System.Drawing.Point(68, 98);
            this.TbOptionID4.Name = "TbOptionID4";
            this.TbOptionID4.Size = new System.Drawing.Size(61, 20);
            this.TbOptionID4.TabIndex = 46;
            this.TbOptionID4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox63_KeyPress);
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(15, 100);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(47, 13);
            this.label63.TabIndex = 47;
            this.label63.Text = "Option3:";
            // 
            // TbOptionID3
            // 
            this.TbOptionID3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbOptionID3.Location = new System.Drawing.Point(68, 72);
            this.TbOptionID3.Name = "TbOptionID3";
            this.TbOptionID3.Size = new System.Drawing.Size(61, 20);
            this.TbOptionID3.TabIndex = 44;
            this.TbOptionID3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox62_KeyPress);
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(15, 74);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(47, 13);
            this.label62.TabIndex = 45;
            this.label62.Text = "Option2:";
            // 
            // TbOptionID2
            // 
            this.TbOptionID2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbOptionID2.Location = new System.Drawing.Point(68, 46);
            this.TbOptionID2.Name = "TbOptionID2";
            this.TbOptionID2.Size = new System.Drawing.Size(61, 20);
            this.TbOptionID2.TabIndex = 42;
            this.TbOptionID2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox61_KeyPress);
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(15, 48);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(47, 13);
            this.label61.TabIndex = 43;
            this.label61.Text = "Option1:";
            // 
            // TbOptionID1
            // 
            this.TbOptionID1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbOptionID1.Location = new System.Drawing.Point(68, 20);
            this.TbOptionID1.Name = "TbOptionID1";
            this.TbOptionID1.Size = new System.Drawing.Size(61, 20);
            this.TbOptionID1.TabIndex = 40;
            this.TbOptionID1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox60_KeyPress);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(15, 22);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(47, 13);
            this.label60.TabIndex = 41;
            this.label60.Text = "Option0:";
            // 
            // clbFlagTest
            // 
            this.clbFlagTest.BackColor = System.Drawing.SystemColors.Control;
            this.clbFlagTest.CheckOnClick = true;
            this.clbFlagTest.Location = new System.Drawing.Point(6, 17);
            this.clbFlagTest.MultiColumn = true;
            this.clbFlagTest.Name = "clbFlagTest";
            this.clbFlagTest.Size = new System.Drawing.Size(246, 574);
            this.clbFlagTest.TabIndex = 15;
            this.clbFlagTest.SelectedIndexChanged += new System.EventHandler(this.clbFlagTest_SelectedIndexChanged_1);
            // 
            // TbEnable
            // 
            this.TbEnable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbEnable.Location = new System.Drawing.Point(589, 2);
            this.TbEnable.Name = "TbEnable";
            this.TbEnable.Size = new System.Drawing.Size(31, 20);
            this.TbEnable.TabIndex = 4;
            this.TbEnable.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enable:";
            this.label4.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1016, 667);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "";
            this.toolTip1.ToolTipTitle = "Information";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.clbFlagTest);
            this.groupBox18.Location = new System.Drawing.Point(1249, 42);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(260, 617);
            this.groupBox18.TabIndex = 35;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Flag Builder";
            this.groupBox18.Visible = false;
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Location = new System.Drawing.Point(43, 19);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(216, 20);
            this.textBox12.TabIndex = 20;
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label105);
            this.groupBox5.Controls.Add(this.textBox95);
            this.groupBox5.Controls.Add(this.checkedListBox2);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.textBox12);
            this.groupBox5.Location = new System.Drawing.Point(12, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(265, 135);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(6, 108);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(102, 13);
            this.label105.TabIndex = 44;
            this.label105.Text = "Search above level:";
            // 
            // textBox95
            // 
            this.textBox95.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox95.Location = new System.Drawing.Point(114, 105);
            this.textBox95.Name = "textBox95";
            this.textBox95.Size = new System.Drawing.Size(42, 20);
            this.textBox95.TabIndex = 43;
            this.textBox95.TextChanged += new System.EventHandler(this.textBox95_TextChanged);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkedListBox2.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.ColumnWidth = 70;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.IntegralHeight = false;
            this.checkedListBox2.Location = new System.Drawing.Point(9, 48);
            this.checkedListBox2.MultiColumn = true;
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(250, 52);
            this.checkedListBox2.TabIndex = 42;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // toolTip2
            // 
            this.toolTip2.Tag = "";
            this.toolTip2.ToolTipTitle = "Information";
            this.toolTip2.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip2_Popup);
            // 
            // toolTip3
            // 
            this.toolTip3.Tag = "";
            this.toolTip3.ToolTipTitle = "Information";
            // 
            // toolTip4
            // 
            this.toolTip4.Tag = "";
            this.toolTip4.ToolTipTitle = "Information";
            // 
            // toolTip5
            // 
            this.toolTip5.Tag = "";
            this.toolTip5.ToolTipTitle = "Information";
            // 
            // toolTip6
            // 
            this.toolTip6.Tag = "";
            this.toolTip6.ToolTipTitle = "Information";
            // 
            // toolTip7
            // 
            this.toolTip7.Tag = "";
            this.toolTip7.ToolTipTitle = "Information";
            // 
            // toolTip8
            // 
            this.toolTip8.Tag = "";
            this.toolTip8.ToolTipTitle = "Information";
            // 
            // toolTip9
            // 
            this.toolTip9.Tag = "";
            this.toolTip9.ToolTipTitle = "Information";
            // 
            // toolTip10
            // 
            this.toolTip10.Tag = "";
            this.toolTip10.ToolTipTitle = "Information";
            // 
            // btnSaveAndNext
            // 
            this.btnSaveAndNext.BackColor = System.Drawing.Color.Chartreuse;
            this.btnSaveAndNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAndNext.Location = new System.Drawing.Point(1125, 667);
            this.btnSaveAndNext.Name = "btnSaveAndNext";
            this.btnSaveAndNext.Size = new System.Drawing.Size(99, 23);
            this.btnSaveAndNext.TabIndex = 36;
            this.btnSaveAndNext.Text = "Save and Next";
            this.btnSaveAndNext.UseVisualStyleBackColor = false;
            this.btnSaveAndNext.Click += new System.EventHandler(this.button5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(962, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Current Language is :";
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLang.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblLang.Location = new System.Drawing.Point(1116, 4);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(0, 16);
            this.lblLang.TabIndex = 38;
            // 
            // CbSaveValueAndLevel
            // 
            this.CbSaveValueAndLevel.AutoSize = true;
            this.CbSaveValueAndLevel.Location = new System.Drawing.Point(287, 673);
            this.CbSaveValueAndLevel.Name = "CbSaveValueAndLevel";
            this.CbSaveValueAndLevel.Size = new System.Drawing.Size(175, 17);
            this.CbSaveValueAndLevel.TabIndex = 3;
            this.CbSaveValueAndLevel.Text = "Save Option Values and Levels";
            this.CbSaveValueAndLevel.UseVisualStyleBackColor = true;
            // 
            // CbAutoUpdate
            // 
            this.CbAutoUpdate.AutoSize = true;
            this.CbAutoUpdate.Location = new System.Drawing.Point(813, 673);
            this.CbAutoUpdate.Name = "CbAutoUpdate";
            this.CbAutoUpdate.Size = new System.Drawing.Size(170, 17);
            this.CbAutoUpdate.TabIndex = 39;
            this.CbAutoUpdate.Text = "Auto Update on Index Change";
            this.CbAutoUpdate.UseVisualStyleBackColor = true;
            this.CbAutoUpdate.Visible = false;
            // 
            // tbDoesItemExist
            // 
            this.tbDoesItemExist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDoesItemExist.Location = new System.Drawing.Point(667, 2);
            this.tbDoesItemExist.Name = "tbDoesItemExist";
            this.tbDoesItemExist.Size = new System.Drawing.Size(38, 20);
            this.tbDoesItemExist.TabIndex = 16;
            this.tbDoesItemExist.Visible = false;
            // 
            // CbSaveIconSmc
            // 
            this.CbSaveIconSmc.AutoSize = true;
            this.CbSaveIconSmc.Location = new System.Drawing.Point(472, 673);
            this.CbSaveIconSmc.Name = "CbSaveIconSmc";
            this.CbSaveIconSmc.Size = new System.Drawing.Size(143, 17);
            this.CbSaveIconSmc.TabIndex = 40;
            this.CbSaveIconSmc.Text = "Save Icon Info and SMC";
            this.CbSaveIconSmc.UseVisualStyleBackColor = true;
            // 
            // pb_loading
            // 
            this.pb_loading.Location = new System.Drawing.Point(139, 6);
            this.pb_loading.Name = "pb_loading";
            this.pb_loading.Size = new System.Drawing.Size(385, 10);
            this.pb_loading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pb_loading.TabIndex = 41;
            this.pb_loading.Visible = false;
            // 
            // ItemEditor2
            // 
            this.ClientSize = new System.Drawing.Size(1232, 708);
            this.Controls.Add(this.pb_loading);
            this.Controls.Add(this.CbSaveIconSmc);
            this.Controls.Add(this.tbDoesItemExist);
            this.Controls.Add(this.CbAutoUpdate);
            this.Controls.Add(this.CbSaveValueAndLevel);
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSaveAndNext);
            this.Controls.Add(this.groupBox18);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.TbEnable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ItemEditor2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Editor EP4 V1.02";
            this.Load += new System.EventHandler(this.Exporter_Item_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.gbFortune.ResumeLayout(false);
            this.gbFortune.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgV)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.groupBox18.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void massEditToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MassEdit m = new MassEdit(); //dethunter12 add
            m.Show(); //dethunter12 add
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox1.BackColor = Color.Pink; //dethunter12 add
            TbType.BackColor = Color.Pink; //dethunter12 add
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox2.BackColor = Color.Pink; //dethunter12 add
            TbSubtype.BackColor = Color.Pink; //dethunter12 add
        }

        private void comboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox4.BackColor = Color.Pink; //dethunter12 add
            TbWearing.BackColor = Color.Pink;
        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox3.BackColor = Color.Pink; //dethunter12 add
        }

        private void comboBox5_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox5.BackColor = Color.Pink; //dethunter12 add
        }

        private void comboBox6_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox6.BackColor = Color.Pink; //dethunter12 add
        }

        private void comboBox7_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox7.BackColor = Color.Pink; //dethunter12 add
        }

        private void comboBox8_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox8.BackColor = Color.Pink; //dethunter12 add
        }

        private void comboBox9_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox9.BackColor = Color.Pink; //dethunter12 add
        }

        private void comboBox10_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox10.BackColor = Color.Pink; //dethunter12 add
        }

        private void comboBox11_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox11.BackColor = Color.Pink; //dethunter12 add
        }

        private void comboBox12_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox12.BackColor = Color.Pink; //dethunter12 add
        }

        private void comboBox13_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox13.BackColor = Color.Pink; //dethunter12 add
        }

        private void massUpdateSealsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MassEditSeals ma = new MassEditSeals(); //dethunter12 add
            ma.Show(); //dethunter12 add
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbFlag.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbMaxUse.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbIndex.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox46_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbZoneFlag.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            TbName.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbDescr.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox47_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbSmc.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox48_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbIconID.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox49_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbIconRow.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox50_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbIconCol.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbMinLvl.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbStackAmnt.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbPrice.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox57_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCommonRareID.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox58_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbCommonRareRate.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox91_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbRvrVal.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox92_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbRvrGrade.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbNum0.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbNum1.BackColor = Color.Pink; //dethunter12 add 
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbNum2.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbNum3.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbNum4.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox52_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbSet0.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox53_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbSet1.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox54_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbSet2.BackColor = Color.Pink; //dethunter12 add 
        }

        private void textBox55_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbSet3.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox56_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbSet4.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox85_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbReformVaration1.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox86_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbReformVaration2.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox87_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbReformVaration3.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox88_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbReformVaration4.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox89_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbReformVaration5.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox90_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbReformVaration6.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbMaxlvl.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbDropProb.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TbMaxlvl.Text, "[^0-9]")) //checks the textbox text for matching case 0-9
            {
                MessageBox.Show("Please enter only numbers.");
                TbMaxlvl.Text = TbMaxlvl.Text.Remove(TbMaxlvl.Text.Length - 1); //if 0-9 isnt found remove the length
            }
        }

        private void textBox80_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbNormalEffect.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox81_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbAttackEffect.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox82_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbDamageEffect.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox59_KeyUp(object sender, KeyEventArgs e)
        {
            TbFame.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox51_KeyUp(object sender, KeyEventArgs e)
        {
            TbUnkown.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox94_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCastle.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox93_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbDura.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox83_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbQuestTriggerCnt.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox84_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbQuestTriggerID.BackColor = Color.Pink; //dethunter12 add
        }

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            TbJobFlag.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox60_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbOptionID1.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox61_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbOptionID2.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox62_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbOptionID3.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox63_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbOptionID4.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox64_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbOptionID5.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox65_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbOptionID6.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox66_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbOptionID7.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox67_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbOptionID8.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox68_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbOptionID9.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox69_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbOptionID10.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox70_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbOptionLvl1.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox71_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbOptionLvl2.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox72_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbOptionLvl3.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox73_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbOptionLvl4.BackColor = Color.Pink; //dethunter12
        }

        private void textBox74_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbOptionLvl5.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox75_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbOptionLvl6.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox76_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbOptionLvl7.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox77_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbOptionLvl8.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox78_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbOptionLvl9.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox79_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbOptionLvl10.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox42_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCraftSkillId1.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox44_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCraftSkillId2.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox43_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCraftSkillLevel1.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox45_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCraftSkillLevel2.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCraftItm1.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCraftItm2.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCraftItm3.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox25_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCraftItm4.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox26_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCraftItm5.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            TbCraftAmnt1.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox33_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCraftAmnt2.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox34_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCraftAmnt3.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox35_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCraftAmnt4.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox36_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCraftAmnt5.BackColor = Color.Pink; //dethunter12
        }

        private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCraftItm6.BackColor = Color.Pink; //dethunter12
        }

        private void textBox28_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCraftItm7.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox29_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCraftItm8.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox30_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCraftItm9.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox31_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCraftItm10.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox37_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCraftAmnt6.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox38_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCraftAmnt7.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox39_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCraftAmnt8.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox40_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCraftAmnt9.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox41_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCraftAmnt10.BackColor = Color.Pink; //dethunter12 add 
        }

        private void CbSubtype1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TbType.Text == "1") //dethunter12 add
            {
                TbSubtype.Text = GetIndexByComboBox(CbSubtype1.Text).ToString();
            }
        }

        private void CbSubtype1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CbSubtype1.BackColor = Color.Pink; //dethunter12 add
            TbSubtype.BackColor = Color.Pink; //dethunter12 add
        }

        private void CbSubtype2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TbType.Text == "2") //dethunter12 add
            {
                TbSubtype.Text = GetIndexByComboBox(CbSubtype2.Text).ToString();
            }
        }

        private void CbSubtype2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CbSubtype2.BackColor = Color.Pink; //dethunter12 add
            TbSubtype.BackColor = Color.Pink; //dethunter12 add
        }

        private void CbSubtype3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TbType.Text == "3") //dethunter12 add
            {
                TbSubtype.Text = GetIndexByComboBox(CbSubtype3.Text).ToString();
            }
        }

        private void CbSubtype3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CbSubtype3.BackColor = Color.Pink; //dethunter12 add
            TbSubtype.BackColor = Color.Pink; //dethunter12 add
        }

        private void CbSubType4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TbType.Text == "4") //dethunter12 add
            {
                TbSubtype.Text = GetIndexByComboBox(CbSubType4.Text).ToString();
            }
        }

        private void CbSubType4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CbSubType4.BackColor = Color.Pink; //dethunter12 add
            TbSubtype.BackColor = Color.Pink; //dethunter12 add
        }

        private void CbSubType5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TbType.Text == "5") //dethunter12 add
            {
                TbSubtype.Text = GetIndexByComboBox(CbSubType5.Text).ToString();
            }
        }

        private void CbSubType5_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CbSubType5.BackColor = Color.Pink; //dethunter12 add
            TbSubtype.BackColor = Color.Pink; //dethunter12 add
        }

        private void CbSubType6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TbType.Text == "6") //dethunter12 add 
            {
                TbSubtype.Text = GetIndexByComboBox(CbSubType6.Text).ToString();
            }
        }

        private void CbSubType6_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CbSubType6.BackColor = Color.Pink; //dethunter12 add
            TbSubtype.BackColor = Color.Pink; //dethunter12 add
        }

        private void CbSubType7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TbType.Text == "-1") //dethunter12 add
            {
                TbSubtype.Text = GetIndexByComboBox(CbSubType7.Text).ToString();
            }
        }

        private void CbSubType7_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CbSubType7.BackColor = Color.Pink; //dethunter12 add
            TbSubtype.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox32_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbCraftAmnt1.BackColor = Color.Pink; //dethunter12 add
        }

        private void textBox15_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(TbNum4, "Costume Duration in Days"); //dethunter12 add
        }

        private void textBox18_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(TbStackAmnt, "Stack Size"); //dethunter12 add
        }

        private void textBox85_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(TbReformVaration1, "Reform Rate"); //dethunter12 add
        }

        private void textBox86_MouseHover(object sender, EventArgs e)
        {
            toolTip4.SetToolTip(TbReformVaration2, "Reform Rate"); //dethunter12 add
        }

        private void textBox87_MouseHover(object sender, EventArgs e)
        {
            toolTip5.SetToolTip(TbReformVaration3, "Reform Rate"); //dethunter12 add
        }

        private void textBox88_MouseHover(object sender, EventArgs e)
        {
            toolTip6.SetToolTip(TbReformVaration4, "Reform Rate"); //dethunter12 add
        }

        private void textBox89_MouseHover(object sender, EventArgs e)
        {
            toolTip7.SetToolTip(TbReformVaration5, "Reform Rate"); //dethunter12 add
        }

        private void textBox90_MouseHover(object sender, EventArgs e)
        {
            toolTip8.SetToolTip(TbReformVaration6, "Reform Rate"); //dethunter12 add
        }

        private void textBox10_MouseHover(object sender, EventArgs e)
        {
            if (TbType.Text == "1")
            {
                toolTip9.SetToolTip(TbNum0, "Physical Defence"); //dethunter12 add
            }

            else if (TbType.Text == "0")
            {
                toolTip9.SetToolTip(TbNum0, " Physical Attack"); //dethunter12 add
            }
            else if (TbType.Text == "6")
            {
                toolTip9.SetToolTip(TbNum0, " Skill ID"); //dethunter12 add
            }
            else if (TbType.Text == "2" && TbSubtype.Text == "13")
            {
                toolTip9.SetToolTip(TbNum0, "Level"); //dethunter12 add
            }
            else if (TbType.Text == "2" && TbSubtype.Text == "12")
            {
                toolTip9.SetToolTip(TbNum0, "Reward Index"); //dethunter12 add
            }
        }

        private void textBox11_MouseHover(object sender, EventArgs e)
        {
            if (TbType.Text == "1")
            {
                toolTip9.SetToolTip(TbNum1, "Magical Defence"); //dethunter12 add
            }
            else if (TbType.Text == "0")
            {
                toolTip9.SetToolTip(TbNum1, " Magical Attack"); //dethunter12 add
            }
            else if (TbType.Text == "6")
            {
                toolTip9.SetToolTip(TbNum1, " Skill Level"); //dethunter12 add
            }
            else if (TbType.Text == "2" && TbSubtype.Text == "13")
            {
                toolTip9.SetToolTip(TbNum1, "Reward Index"); //dethunter12 add
            }
        }

        private void textBox13_MouseHover(object sender, EventArgs e)
        {
            if (TbType.Text == "1")
            {
                toolTip9.SetToolTip(TbNum2, "Flight Speed"); //dethunter12 add
            }
            else if (TbType.Text == "0")
            {
                toolTip9.SetToolTip(TbNum2, "Attack Speed"); //dethunter12 add
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e) //dethunter12 add
        {
            string str = Path.GetDirectoryName(_ClientPath).Replace("Data", "").Replace("data", "") + "\\" + TbSmc.Text;
            if (File.Exists(str))
                new TextEditor(str).Show();
            else
                new CustomMessage("File not found").Show();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnPercentAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int result1 = 0; //Dethunter12 add (wizatek code)
                float result2 = 0.0f;
                
                if (!int.TryParse(TbNum0.Text, out result1) || !float.TryParse(TbPercent.Text.Replace('.', ','), out result2))
                    return;
                TbNum0.Text = ((int)(result1 / 100f * (double)result2) + result1).ToString();


            }
            catch (Exception) { }
            
        }

        private void btnPercent1Add_Click(object sender, EventArgs e)
        {
            try
            {
                int result1 = 0; //Dethunter12 add (wizatek code)
                float result2 = 0.0f;

                if (!int.TryParse(TbNum1.Text, out result1) || !float.TryParse(TbPercent1.Text.Replace('.', ','), out result2))
                    return;
                this.TbNum1.Text = ((int)(result1 / 100f * (double)result2) + result1).ToString();
            }
            catch (Exception) { }
        }

        private void btnPercent2Add_Click(object sender, EventArgs e)
        {
            try
            {
                int result1 = 0; //Dethunter12 add (wizatek code)
                float result2 = 0.0f;
                
                if (!int.TryParse(TbNum2.Text, out result1) || !float.TryParse(TbPercent2.Text.Replace('.', ','), out result2))
                    return;
                this.TbNum2.Text = ((int)(result1 / 100f * (double)result2) + result1).ToString();
            }
            catch (Exception) { }
        }

        private void comboBox24_SelectedIndexChanged_1(object sender, EventArgs e) //dethunter12 adjust
        {
            TbRvrVal.Text = comboBox24.SelectedIndex.ToString();
            if (TbRvrVal.Text == "1")
            {
                comboBox25.Visible = true;
                comboBox26.Visible = false;
            }
            else if (TbRvrVal.Text == "2")
            {
                comboBox25.Visible = false;
                comboBox26.Visible = true;
            }
        }

        private void comboBox25_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (TbRvrVal.Text == "1")
            {
                TbRvrGrade.Text = GetIndexByComboBox(comboBox25.Text).ToString(); //dethunter12  add
            }
        }

        private void comboBox24_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox24.BackColor = Color.Pink; //dethunter12 add
            TbRvrVal.BackColor = Color.Pink;
        }

        private void comboBox25_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox25.BackColor = Color.Pink; //dethunter12 add
            TbRvrGrade.BackColor = Color.Pink;
        }

        private void comboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TbRvrVal.Text == "2")
            {
                TbRvrGrade.Text = GetIndexByComboBox(comboBox26.Text).ToString(); //dethunter12  add
            }
            
        }

        private void comboBox26_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox26.BackColor = Color.Pink; //dethunter12 add
            TbRvrGrade.BackColor = Color.Pink;
        }
        private int GetID()
        {
            int result = -1;
            int.TryParse(TbIndex.Text.Split(' ')[0], out result);
            return result;
        }
        private void button5_Click(object sender, EventArgs e)
        {
           // int itemID = GetID();
            descrr = LanguageHelper.DescrFromLanguage(); // description 
            namee = LanguageHelper.StringFromLanguage(); // language name (to simplify the query without having to add alot of if elseif)
            string str1 = "UPDATE t_item SET " + "a_type_idx = '" + TbType.Text + "', " + "a_subtype_idx = '" + TbSubtype.Text + "', " + "a_enable = '" + TbEnable.Text + "', ";
            string str2 = TbName.Text.Replace("'", "\\'").Replace("\"", "\\\"");
            string str3 = TbDescr.Text.Replace("'", "\\'").Replace("\"", "\\\"");
            //
            databaseHandle.SendQueryMySql(Host, User, Password, Database, str1 + "a_name = '" + str2 + "', " + namee + "=" + " " + "'" + str2 + "', " + "a_descr = '" + str3 + "', " + descrr + "='" + str3 + "', " + "a_job_flag = '" + TbJobFlag.Text + "', " + "a_flag = '" + TbFlag.Text + "', " + "a_wearing = '" + TbWearing.Text + "', " + "a_num_0 = '" + TbNum0.Text + "', " + "a_num_1 = '" + TbNum1.Text + "', " + "a_num_2 = '" + TbNum2.Text + "', " + "a_num_3 = '" + TbNum3.Text + "', " + "a_num_4 = '" + TbNum4.Text + "', " + "a_level = '" + TbMinLvl.Text + "', " + "a_level2 = '" + TbMaxlvl.Text + "', " + "a_weight = '" + TbStackAmnt.Text + "', " + "a_price = '" + TbPrice.Text + "', " + "a_max_use = '" + TbMaxUse.Text + "', " + "a_drop_prob_10 = '" + TbDropProb.Text + "', " + "a_need_item0 = '" + TbCraftItm1.Text + "', " + "a_need_item1 = '" + TbCraftItm2.Text + "', " + "a_need_item2 = '" + TbCraftItm3.Text + "', " + "a_need_item3 = '" + TbCraftItm4.Text + "', " + "a_need_item4 = '" + TbCraftItm5.Text + "', " + "a_need_item5 = '" + TbCraftItm6.Text + "', " + "a_need_item6 = '" + TbCraftItm7.Text + "', " + "a_need_item7 = '" + TbCraftItm8.Text + "', " + "a_need_item8 = '" + TbCraftItm9.Text + "', " + "a_need_item9 = '" + TbCraftItm10.Text + "', " + "a_need_item_count0 = '" + TbCraftAmnt1.Text + "', " + "a_need_item_count1 = '" + TbCraftAmnt2.Text + "', " + "a_need_item_count2 = '" + TbCraftAmnt3.Text + "', " + "a_need_item_count3 = '" + TbCraftAmnt4.Text + "', " + "a_need_item_count4 = '" + TbCraftAmnt5.Text + "', " + "a_need_item_count5 = '" + TbCraftAmnt6.Text + "', " + "a_need_item_count6 = '" + TbCraftAmnt7.Text + "', " + "a_need_item_count7 = '" + TbCraftAmnt8.Text + "', " + "a_need_item_count8 = '" + TbCraftAmnt9.Text + "', " + "a_need_item_count9 = '" + TbCraftAmnt10.Text + "', " + "a_need_sskill = '" + TbCraftSkillId1.Text + "', " + "a_need_sskill_level = '" + TbCraftSkillLevel1.Text + "', " + "a_need_sskill2 = '" + TbCraftSkillId2.Text + "', " + "a_need_sskill_level2 = '" + TbCraftSkillLevel2.Text + "', " + "a_zone_flag = '" + TbZoneFlag.Text + "', " + "a_file_smc = '" + TbSmc.Text.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'") + "', " + "a_texture_id = '" + TbIconID.Text + "', " + "a_texture_row = '" + TbIconRow.Text + "', " + "a_texture_col = '" + TbIconCol.Text + "', " + "b_todo_delete = '" + TbUnkown.Text + "', " + "a_set_0 = '" + TbSet0.Text + "', " + "a_set_1 = '" + TbSet1.Text + "', " + "a_set_2 = '" + TbSet2.Text + "', " + "a_set_3 = '" + TbSet3.Text + "', " + "a_set_4 = '" + TbSet4.Text + "', " + "a_set = '" + TbCommonRareID.Text + "', " + "a_grade = '" + tbCommonRareRate.Text + "', " + "a_fame = '" + TbFame.Text + "', " + "a_rare_index_0 = '" + TbOptionID1.Text + "', " + "a_rare_index_1 = '" + TbOptionID2.Text + "', " + "a_rare_index_2 = '" + TbOptionID3.Text + "', " + "a_rare_index_3 = '" + TbOptionID4.Text + "', " + "a_rare_index_4 = '" + TbOptionID5.Text + "', " + "a_rare_index_5 = '" + TbOptionID6.Text + "', " + "a_rare_index_6 = '" + TbOptionID7.Text + "', " + "a_rare_index_7 = '" + TbOptionID8.Text + "', " + "a_rare_index_8 = '" + TbOptionID9.Text + "', " + "a_rare_index_9 = '" + TbOptionID10.Text + "', " + "a_rare_prob_0 = '" + TbOptionLvl1.Text + "', " + "a_rare_prob_1 = '" + TbOptionLvl2.Text + "', " + "a_rare_prob_2 = '" + TbOptionLvl3.Text + "', " + "a_rare_prob_3 = '" + TbOptionLvl4.Text + "', " + "a_rare_prob_4 = '" + TbOptionLvl5.Text + "', " + "a_rare_prob_5 = '" + TbOptionLvl6.Text + "', " + "a_rare_prob_6 = '" + TbOptionLvl7.Text + "', " + "a_rare_prob_7 = '" + TbOptionLvl8.Text + "', " + "a_rare_prob_8 = '" + TbOptionLvl9.Text + "', " + "a_rare_prob_9 = '" + TbOptionLvl10.Text + "', " + "a_effect_name = '" + TbNormalEffect.Text + "', " + "a_attack_effect_name = '" + TbAttackEffect.Text + "', " + "a_damage_effect_name = '" + TbDamageEffect.Text + "', " + "a_quest_trigger_count = '" + TbQuestTriggerCnt.Text + "', " + "a_quest_trigger_ids = '" + TbQuestTriggerID.Text + "', " + "a_origin_variation1 = '" + TbReformVaration1.Text + "', " + "a_origin_variation2 = '" + TbReformVaration2.Text + "', " + "a_origin_variation3 = '" + TbReformVaration3.Text + "', " + "a_origin_variation4 = '" + TbReformVaration4.Text + "', " + "a_origin_variation5 = '" + TbReformVaration5.Text + "', " + "a_origin_variation6 = '" + TbReformVaration6.Text + "', " + "a_rvr_value = '" + TbRvrVal.Text + "', " + "a_rvr_grade = '" + TbRvrGrade.Text + "', " + "a_durability = '" + TbDura.Text + "', " + "a_castle_war = '" + TbCastle.Text + "' " + "WHERE a_index = '" + TbIndex.Text + "'");
            int selectedIndex = listBox1.SelectedIndex;
            int nextselected = listBox1.SelectedIndex + 1;
            if (textBox12.Text != "")
                SearchList(textBox12.Text);
            else
                LoadListBox();
            //  int itemID = GetID();
            if (selectedIndex + 1 >= listBox1.Items.Count)
            {
                listBox1.SelectedIndex = selectedIndex;
            }
            else
                listBox1.SelectedIndex = nextselected;
            //listBox1.SelectedIndex = selectedIndex +1;
            int num4 = (int)new CustomMessage("Done :)").ShowDialog();
        }

        private void ClbItemFlag_SelectedIndexChanged(object sender, EventArgs e)
        {
            long num = 0;
            for (int index = 0; index < ClbItemFlag.Items.Count; ++index)
            {
                if (ClbItemFlag.GetItemChecked(index))
                    num += 1L << index;
            }
            TbFlag.Text = num.ToString();
            if (flagBuilderType == "items")
            {
                if (Episode == "EP4")
                    flagBig = num;
                else
                    flagSmall = Convert.ToInt32(num);
            }
            else
                flagSmall = Convert.ToInt32(num);
        }

        private void massUpdateFlagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlagChangerMass fcm = new FlagChangerMass(); //dethunter12 add
            fcm.Show(); //dethunter12 add

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolBtnClear_Click(object sender, EventArgs e)
        {
            r1.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            if (TbIndex.Text.Trim().Length <= 0)
                return;

            //check existing before save
            if (Existed("-1"))
            {
                MessageBox.Show("Do not make a duplicate changed, Please try again another value.", "Error, Duplicate items !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string strSQL = "insert into t_fortune_data(a_item_idx, a_skill_index, a_skill_level, a_string_index, a_prob) values(" + TbIndex.Text.Trim() + ", -1, -1, -1, -1)";


                MySqlConnection connection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
                MySqlCommand mySqlCommand = new MySqlCommand(strSQL, connection);
                connection.Open();

                try
                {
                    mySqlCommand.ExecuteReader();
                    MessageBox.Show("Updated Item No. " + dgV.Rows[int.Parse(r1.Text)].Cells["a_item_idx"].Value.ToString().Trim() + " with Skill No. " + dgV.Rows[int.Parse(r1.Text)].Cells["a_skill_index"].Value.ToString().Trim() + " Level " + dgV.Rows[int.Parse(r1.Text)].Cells["a_skill_level"].Value.ToString().Trim() + " completed..", "Done !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception )
                {
                    MessageBox.Show("Can't updated your selected data..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();

                if (TbIndex.Text.Trim().Length > 0)
                    LoadFortuneData(TbIndex.Text);
            }
        }

        private void btnSaveSelected_Click(object sender, EventArgs e)
        {
            if (r1.Text.Trim().Length <= 0)
                return;

            if (MessageBox.Show(string.Format("Do you want to save change on Item No. {0} with Skill No. {1} Level {2} ?", dgV.Rows[int.Parse(r1.Text)].Cells["t_item_idx"].Value.ToString().Trim(), dgV.Rows[int.Parse(r1.Text)].Cells["t_skill_index"].Value.ToString().Trim(), dgV.Rows[int.Parse(r1.Text)].Cells["t_skill_level"].Value.ToString().Trim()), "Please confirm delete..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                //check existing before save
                if (Existed(r1.Text.Trim()))
                {
                    MessageBox.Show("Do not make a duplicate changed, Please try again another value.", "Duplicate items", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    string strSQL = string.Format("UPDATE t_fortune_data SET a_item_idx = {0}, a_skill_index = {1}, a_skill_level = {2}, " +
                        "a_string_index = {3}, a_prob = {4} WHERE a_item_idx = {5} and a_skill_index = {6} and a_skill_level = {7}",
                        dgV.Rows[int.Parse(r1.Text)].Cells["a_item_idx"].Value.ToString().Trim(), dgV.Rows[int.Parse(r1.Text)].Cells["a_skill_index"].Value.ToString().Trim(),
                        dgV.Rows[int.Parse(r1.Text)].Cells["a_skill_level"].Value.ToString().Trim(), dgV.Rows[int.Parse(r1.Text)].Cells["a_string_index"].Value.ToString().Trim(),
                        dgV.Rows[int.Parse(r1.Text)].Cells["a_prob"].Value.ToString().Trim(), dgV.Rows[int.Parse(r1.Text)].Cells["t_item_idx"].Value.ToString().Trim(),
                        dgV.Rows[int.Parse(r1.Text)].Cells["t_skill_index"].Value.ToString().Trim(), dgV.Rows[int.Parse(r1.Text)].Cells["t_skill_level"].Value.ToString().Trim());


                    MySqlConnection connection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
                    MySqlCommand mySqlCommand = new MySqlCommand(strSQL, connection);
                    connection.Open();

                    try
                    {
                        mySqlCommand.ExecuteReader();
                        MessageBox.Show("Updated Item No. " + dgV.Rows[int.Parse(r1.Text)].Cells["a_item_idx"].Value.ToString().Trim() + " with Skill No. " + dgV.Rows[int.Parse(r1.Text)].Cells["a_skill_index"].Value.ToString().Trim() + " Level " + dgV.Rows[int.Parse(r1.Text)].Cells["a_skill_level"].Value.ToString().Trim() + " completed..", "Done !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Can't updated your selected data.." + Environment.NewLine + x.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    connection.Close();

                    if (TbIndex.Text.Trim().Length > 0)
                        LoadFortuneData(TbIndex.Text);
                }
            }
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (r1.Text.Trim().Length <= 0)
                return;

            if (dgV.Rows[int.Parse(r1.Text)].Cells["a_item_idx"].Value.ToString().Trim() == ""
                || dgV.Rows[int.Parse(r1.Text)].Cells["a_skill_index"].Value.ToString().Trim() == ""
                || dgV.Rows[int.Parse(r1.Text)].Cells["a_skill_level"].Value.ToString().Trim() == ""
                || dgV.Rows[int.Parse(r1.Text)].Cells["a_string_index"].Value.ToString().Trim() == ""
                || dgV.Rows[int.Parse(r1.Text)].Cells["a_prob"].Value.ToString().Trim() == "")
            {
                MessageBox.Show(string.Format("Please full fill all data in row number {0} !!", r1.Text), "There are some blank data..");
                return;
            }

            if (MessageBox.Show(string.Format("Do you want to delete Item No. {0} with Skill No. {1} Level {2} ?", dgV.Rows[int.Parse(r1.Text)].Cells["t_item_idx"].Value.ToString().Trim(), dgV.Rows[int.Parse(r1.Text)].Cells["t_skill_index"].Value.ToString().Trim(), dgV.Rows[int.Parse(r1.Text)].Cells["t_skill_level"].Value.ToString().Trim()), "Please confirm delete..", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                //check existing before save

                string strSQL = string.Format("DELETE FROM t_fortune_data WHERE a_item_idx = {0} and a_skill_index = {1} and a_skill_level = {2}",
                        dgV.Rows[int.Parse(r1.Text)].Cells["t_item_idx"].Value.ToString().Trim(), dgV.Rows[int.Parse(r1.Text)].Cells["t_skill_index"].Value.ToString().Trim(),
                        dgV.Rows[int.Parse(r1.Text)].Cells["t_skill_level"].Value.ToString().Trim());


                MySqlConnection connection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
                MySqlCommand mySqlCommand = new MySqlCommand(strSQL, connection);
                connection.Open(); 

                try
                {
                    mySqlCommand.ExecuteReader();
                    MessageBox.Show("Delete Item No. " + dgV.Rows[int.Parse(r1.Text)].Cells["a_item_idx"].Value.ToString().Trim() + " with Skill No. " + dgV.Rows[int.Parse(r1.Text)].Cells["a_skill_index"].Value.ToString().Trim() + " Level " + dgV.Rows[int.Parse(r1.Text)].Cells["a_skill_level"].Value.ToString().Trim() + " completed..", "Done !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception )
                {
                    MessageBox.Show("Can't deleted your selected data..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();

                if (TbIndex.Text.Trim().Length > 0)
                    LoadFortuneData(TbIndex.Text);
            }
        }

        private bool Existed(string row_selected)
        {
            if (row_selected == null || row_selected.Trim().Length <= 0)
                return true;

            MySqlConnection connection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);

            string strCNNs = "datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database;
            string strSQL = "";

            if (int.Parse(row_selected) < 0)
            {
                strSQL = "select count(*) as row_existed from t_fortune_data where a_item_idx = " + TbIndex.Text.Trim() + " and a_skill_index = -1 and a_skill_level = -1 ";
            }
            else
            {
                strSQL = string.Format("select count(*) as row_existed from t_fortune_data where a_item_idx = {0} and a_skill_index = {1} and a_skill_level = {2} ", dgV.Rows[int.Parse(row_selected)].Cells["a_item_idx"].Value.ToString(), dgV.Rows[int.Parse(row_selected)].Cells["a_skill_index"].Value.ToString(), dgV.Rows[int.Parse(row_selected)].Cells["a_skill_level"].Value.ToString());
            }
            
            try
            {
                DataTable dt_existed = new DataTable();
                
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(strSQL, connection);
                mySqlDataAdapter.Fill(dt_existed);

                if (dt_existed != null && dt_existed.Rows.Count>0)
                {
                    return (Convert.ToInt32(dt_existed.Rows[0].ItemArray[0]) <= 0 ? false : true);
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return true;
            }            
        }

        private void dgV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if ("a_item_idxa_skill_indexa_skill_levela_string_indexa_prob".Contains(dgV.Columns[e.ColumnIndex].Name.ToString().Trim()))
            {

            }
        }

        private void dgV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgV.Rows[e.RowIndex].Cells["a_item_idx"].Value.ToString() != dgV.Rows[e.RowIndex].Cells["t_item_idx"].Value.ToString()
                || dgV.Rows[e.RowIndex].Cells["a_skill_index"].Value.ToString() != dgV.Rows[e.RowIndex].Cells["t_skill_index"].Value.ToString()
                || dgV.Rows[e.RowIndex].Cells["a_skill_level"].Value.ToString() != dgV.Rows[e.RowIndex].Cells["t_skill_level"].Value.ToString()
                || dgV.Rows[e.RowIndex].Cells["a_string_index"].Value.ToString() != dgV.Rows[e.RowIndex].Cells["t_string_index"].Value.ToString()
                || dgV.Rows[e.RowIndex].Cells["a_prob"].Value.ToString() != dgV.Rows[e.RowIndex].Cells["t_prob"].Value.ToString())
            {
                dgV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Maroon;
                dgV.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
            else
            {
                dgV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                dgV.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void MassUpdateNameToolStripMenuItem_Click(object sender, EventArgs e) //dethunter12 add 10/2/2019
        {
            MassNameChanger massNameChanger = new MassNameChanger(); //dethunter12 add
            massNameChanger.Show();
        }

        private void BtnMassNum_Click(object sender, EventArgs e)
        {
            MassPercentAdd mpa = new MassPercentAdd(); //dethunter12 add 12/22/2019
            mpa.Show();
        }

        private void btnSub1_Click(object sender, EventArgs e)
        {
            try
            {
                int result1 = 0; //Dethunter12 add (wizatek code)
                float result2 = 0.0f;

                if (!int.TryParse(TbNum0.Text, out result1) || !float.TryParse(TbPercent.Text.Replace('.', ','), out result2))
                    return;
                TbNum0.Text = (result1 -  (int)(result1 / 100f * (double)result2)).ToString();


            }
            catch (Exception) { }
        }

        private void btnSub2_Click(object sender, EventArgs e)
        {
            try
            {
                int result1 = 0; //Dethunter12 add (wizatek code)
                float result2 = 0.0f;

                if (!int.TryParse(TbNum1.Text, out result1) || !float.TryParse(TbPercent1.Text.Replace('.', ','), out result2))
                    return;
                TbNum1.Text = (result1 - (int)(result1 / 100f * (double)result2)).ToString();


            }
            catch (Exception) { }
        }

        private void btnSub3_Click(object sender, EventArgs e)
        {
            try
            {
                int result1 = 0; //Dethunter12 add (wizatek code)
                float result2 = 0.0f;

                if (!int.TryParse(TbNum2.Text, out result1) || !float.TryParse(TbPercent2.Text.Replace('.', ','), out result2))
                    return;
                TbNum2.Text = (result1 - (int)(result1 / 100f * (double)result2)).ToString();


            }
            catch (Exception) { }
        }

        private void MassPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MassPrice m = new MassPrice(); //dethunter12 add
            m.Show();
        }

        public string LanguageExport() //dethunter12 add 7/5/2020
        {

            if (language == "GER")
            {
                return "ger";
            }
            else if (language == "POL")
            {
                return "pol";
            }
            else if (language == "BRA")
            {
                return "brz";
            }
            else if (language == "RUS")
            {
                return "rus";
            }
            else if (language == "FRA")
            {
                return "fra";
            }
            else if (language == "ESP")
            {
                return "esp";
            }
            else if (language == "MEX")
            {
                return "mex";
            }
            else if (language == "THA")
            {
                return "tha";
            }
            else if (language == "ITA")
            {
                return "ita";
            }
            else if (language == "USA")
            {
                return "usa";
            }
            else
            {
                return null;
            }
        }
        private void usaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            string text1 = "item";
            string text2 = "path_ship";
            string text3 = LanguageExport(); //dethunter12 add 7/5/2020
           

            Process.Start(new ProcessStartInfo()
            {
                FileName = "ExportLod.exe",
                Arguments = " -h " + Host + " -d " + Database + " -u " + User + " -p " + Password + " -k " + text2 + " -l " + text3 + " -t " + text1
            });
        }
        private bool Item_Is_Rare()
        {
            int type = int.Parse(TbType.Text);
            if (type == 0 || type == 1 || type == 5)
            {
                int flag = int.Parse(TbFlag.Text);
                switch (flag)
                {
                    case 134250526:
                    case 352847104:
                    case 163866:
                    case 33806:
                        return true;
                }
            }
            return false;
        }


        private void Update_Probability_Text() //dethunter12 9/3/2020
        {
            
            if (Item_Is_Rare() && int.Parse(TbOptionID1.Text) >= 0 && TbOptionLvl1.Text !="")
            {

                lblProb1.Text = "";
                decimal result = ((int.Parse(TbOptionLvl1.Text) * 100m) / 10000m);
                lblProb1.Text = Convert.ToString(result) + "%";
            }
            if (Item_Is_Rare() && int.Parse(TbOptionID2.Text) >= 0 && TbOptionLvl2.Text != "")
            {

                lblProb2.Text = "";
                
                decimal result = ((int.Parse(TbOptionLvl2.Text) * 100m) / 10000m);
                lblProb2.Text = Convert.ToString(result) + "%";
            }
            if (Item_Is_Rare() && int.Parse(TbOptionID3.Text) >= 0 && TbOptionLvl3.Text != "")
            {

                lblProb3.Text = "";
                decimal result = ((int.Parse(TbOptionLvl3.Text) * 100m) / 10000m);
                lblProb3.Text = Convert.ToString(result) + "%";
            }
            if (Item_Is_Rare() && int.Parse(TbOptionID4.Text) >= 0 && TbOptionLvl4.Text != "")
            {

                lblProb4.Text = "";
                decimal result = ((int.Parse(TbOptionLvl4.Text) * 100m) / 10000m);
                lblProb4.Text = Convert.ToString(result) + "%";
            }
            if (Item_Is_Rare() && int.Parse(TbOptionID5.Text) >= 0 && TbOptionLvl5.Text != "")
            {

                lblProb5.Text = "";
                decimal result = ((int.Parse(TbOptionLvl5.Text) * 100m) / 10000m);
                lblProb5.Text = Convert.ToString(result) + "%";
            }
            if (Item_Is_Rare() && int.Parse(TbOptionID6.Text) >= 0 && TbOptionLvl6.Text != "")
            {

                lblProb6.Text = "";
                decimal result = ((int.Parse(TbOptionLvl6.Text) * 100) / 10000m);
                lblProb6.Text = Convert.ToString(result) + "%";
            }
            if (Item_Is_Rare() && int.Parse(TbOptionID7.Text) >= 0 && TbOptionLvl7.Text != "")
            {

                lblProb7.Text = "";
                decimal result = ((int.Parse(TbOptionLvl7.Text) * 100m) / 10000m);
                
                lblProb7.Text = Convert.ToString(result) + "%";
            }
            if (Item_Is_Rare() && int.Parse(TbOptionID8.Text) >= 0 && TbOptionLvl8.Text != "")
            {

                lblProb8.Text = "";
                decimal result = ((int.Parse(TbOptionLvl8.Text) * 100m) / 10000m);
                lblProb8.Text = Convert.ToString(result) + "%";
                //var thevalue = string.Format("{0:0.00}", result);
                //lblProb8.Text = thevalue + "%";
            }
            if (Item_Is_Rare() && int.Parse(TbOptionID9.Text) >= 0 && TbOptionLvl9.Text != "")
            {

                lblProb9.Text = "";
                decimal result = ((int.Parse(TbOptionLvl9.Text) * 100m) / 10000m);
                lblProb9.Text = Convert.ToString(result) + "%";
            }
            if (Item_Is_Rare() && int.Parse(TbOptionID10.Text) >= 0 && TbOptionLvl10.Text != "")
            {

                lblProb10.Text = "";
                decimal result = ((int.Parse(TbOptionLvl10.Text) * 100m) / 10000m);
                lblProb10.Text = Convert.ToString(result) + "%";
            }

        }

        private void TbOptionLvl2_TextChanged(object sender, EventArgs e)
        {
            if (TbOptionID2.Text == "-1")
                lblProb2.Text = "";
            if (TbOptionID2.Text != "-1" && TbOptionID2.Text != "")
            {
                if (int.Parse(TbOptionID2.Text) > 10000)
                    TbOptionID2.Text = Convert.ToString(10000);
                Update_Probability_Text();
            }
        }

        private void TbOptionLvl3_TextChanged(object sender, EventArgs e)
        {
            if (TbOptionID3.Text == "-1")
                lblProb3.Text = "";
            if (TbOptionID3.Text != "-1" && TbOptionID3.Text != "")
            {
                if (int.Parse(TbOptionID3.Text) > 10000)
                    TbOptionID3.Text = Convert.ToString(10000);
                Update_Probability_Text();
            }
        }

        private void TbOptionLvl4_TextChanged(object sender, EventArgs e)
        {
            if (TbOptionID4.Text == "-1")
                lblProb4.Text = "";
            if (TbOptionID4.Text != "-1" && TbOptionID4.Text != "")
            {
                if (int.Parse(TbOptionID4.Text) > 10000)
                    TbOptionID4.Text = Convert.ToString(10000);
                Update_Probability_Text();
            }
        }

        private void TbOptionLvl5_TextChanged(object sender, EventArgs e)
        {
            if (TbOptionID5.Text == "-1")
                lblProb5.Text = "";
            if (TbOptionID5.Text != "-1" && TbOptionID5.Text != "")
            {
                if (int.Parse(TbOptionID5.Text) > 10000)
                    TbOptionID5.Text = Convert.ToString(10000);
                Update_Probability_Text();
            }
        }

        private void TbOptionLvl6_TextChanged(object sender, EventArgs e)
        {
            if (TbOptionID6.Text == "-1")
                lblProb6.Text = "";
            if (TbOptionID6.Text != "-1" && TbOptionID6.Text != "")
            {
                if (int.Parse(TbOptionID6.Text) > 10000)
                    TbOptionID6.Text = Convert.ToString(10000);
                Update_Probability_Text();
            }
        }

        private void TbOptionLvl7_TextChanged(object sender, EventArgs e)
        {
            if (TbOptionID7.Text == "-1")
                lblProb7.Text = "";
            if (TbOptionID7.Text != "-1" && TbOptionID7.Text != "")
            {
                if (int.Parse(TbOptionID7.Text) > 10000)
                    TbOptionID7.Text = Convert.ToString(10000);
                Update_Probability_Text();
            }
        }

        private void TbOptionLvl8_TextChanged(object sender, EventArgs e)
        {
            if (TbOptionID8.Text == "-1")
                lblProb8.Text = "";
            if (TbOptionID8.Text != "-1" && TbOptionID8.Text != "")
            {
                if (int.Parse(TbOptionID8.Text) > 10000)
                    TbOptionID8.Text = Convert.ToString(10000);
                Update_Probability_Text();
            }
        }

        private void TbOptionLvl9_TextChanged(object sender, EventArgs e)
        {
            if (TbOptionID9.Text == "-1")
                lblProb9.Text = "";
            if (TbOptionID9.Text != "-1" && TbOptionID9.Text != "")
            {
                if (int.Parse(TbOptionID9.Text) > 10000 )
                    TbOptionID9.Text = Convert.ToString(10000);
                Update_Probability_Text();
            }
        }

        private void TbOptionLvl10_TextChanged(object sender, EventArgs e)
        {
            if (TbOptionID10.Text == "-1")
                lblProb10.Text = "";
            if (TbOptionID10.Text != "-1" && TbOptionID10.Text != "")
            {
                if (int.Parse(TbOptionID10.Text) > 10000)
                    TbOptionID10.Text = Convert.ToString(10000);
                Update_Probability_Text();
            }
        }
    }
    
}
