// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.Tools.SkillEditor
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using StringExporter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LcDevPack_TeamDamonA.Tools.MemoryWorker;

namespace LcDevPack_TeamDamonA.Tools
{
    public class SkillEditor : Form
    {
        public static Connection connection = new Connection();
        private string Host = SkillEditor.connection.ReadSettings("Host");
        private string User = SkillEditor.connection.ReadSettings("User");
        private string Password = SkillEditor.connection.ReadSettings("Password");
        private string Database = SkillEditor.connection.ReadSettings("Database");
        private DatabaseHandle databaseHandle = new DatabaseHandle();
        public string rowName = "a_index";
        private string Episode = SkillEditor.connection.ReadSettings("Episode");
        public bool IsSelectIndexChanged = false; //dethunter12 add 7/26/2020
        public bool ISMagicIndexChanged = false; //dethunter12 add 7/26/2020
        public string[] menuArray = new string[2]
        {
      "a_index",
      "a_name"
        };
        public string[] menuArray2 = new string[2]
        {
      "a_type",
      "a_name"
        };
        public string[] menuArray3 = new string[1] { "a_level" };
        public string[] menuArray4 = new string[1] { "a_level" };
        public string[] SearchMenu = new string[2]
        {
      "a_index",
      "a_name"
        };
      
        private ComboBox CBPet;
        private BackgroundWorker backgroundWorker1;
        private Button btnSaveAndNext;
        private Button button9;
        private Button button8;
        private Button button7;
        private Label label133;
        private Button button12;
        private Button button11;
        private Button button10;
        private Label label134;
        private ToolStripMenuItem mYSQLToolStripMenuItem;
        private ToolStripMenuItem sKILLSCOST0SPToolStripMenuItem;
        private ToolStripMenuItem sKILLSREQUIRENOITEMSToolStripMenuItem;
        private ToolStripMenuItem sKILLSREQUIRENOITEMLEARNToolStripMenuItem;
        private Button button16;
        private Button button13;
        private Button button14;
        private Button button15;
        private Label label142;
        private TextBox tbmaxLevel;
        private Label label140;
        private Label label132;


        private void PetBoxTest()
        {
            if (textBox84.Text != "0" && textBox2.Text != "11")
            {
                CBPet.Enabled = false;
            }
            else
            {
                CBPet.Enabled = true;
            }
        }
        //dethunter12 4/12/2018 language system
        private string language = ItemEditor2.connection.ReadSettings("Language");//dethunter12 test
        private void LoadLangAtStartup()
        {
            if (language == "GER")
            {
                lblLang.Text = "German";
            }
            else if (language == "POL")
            {
                lblLang.Text = "Polish";
            }
            else if (language == "BRA")
            {
                lblLang.Text = "Brasilian";
            }
            else if (language == "RUS")
            {
                lblLang.Text = "Russian";
            }
            else if (language == "FRA")
            {
                lblLang.Text = "French";
            }
            else if (language == "ESP")
            {
                lblLang.Text = "Spanish";
            }
            else if (language == "MEX")
            {
                lblLang.Text = "Mex";
            }
            else if (language == "THA")
            {
                lblLang.Text = "Thai";
            }
            else if (language == "ITA")
            {
                lblLang.Text = "Italian";
            }
            else if (language == "USA")
            {
                lblLang.Text = "English";
            }
            else
            {
                lblLang.Text = "";
            }
        }
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
        public string aClientDescripton = "";
        public string aname = ""; //dehtunter12 add
        public string ClientDescription;
        public string aToolTip = "";
        public string ToolTip;

        public string StringFromLanguage() //dethunter12 4/12/2018
        {

            if (language == "GER")
            {
                return "a_name_ger";
            }
            else if (language == "POL")
            {
                return "a_name_pld";
            }
            else if (language == "BRA")
            {
                return "a_name_brz";
            }
            else if (language == "RUS")
            {
                return "a_name_rus";
            }
            else if (language == "FRA")
            {
                return "a_name_frc";
            }
            else if (language == "ESP")
            {
                return "a_name_spn";
            }
            else if (language == "MEX")
            {
                return "a_name_mex";
            }
            else if (language == "THA")
            {
                return "a_name_thai";
            }
            else if (language == "ITA")
            {
                return "a_name_ita";
            }
            else if (language == "USA")
            {
                return "a_name_usa";
            }
            else
            {
                return null;
            }
        }
        public string ClientDescrFromLanguage() //dethunter12 4/12/2018
        {
            if (language == "GER")
            {
                return "a_client_description_ger";
            }
            else if (language == "POL")
            {
                return "a_client_description_pld";
            }
            else if (language == "BRA")
            {
               return "a_client_description_brz";
            }
            else if (language == "RUS")
            {
                return "a_client_description_rus";
            }
            else if (language == "FRA")
            {
                return"a_client_description_frc";
            }
            else if (language == "ESP")
            {
                return "a_client_description_spn";
            }
            else if (language == "MEX")
            {
                return "a_client_description_mex";
            }
            else if (language == "THA")
            {
                return "a_client_description_thai";
            }
            else if (language == "ITA")
            {
                return "a_client_description_ita";
            }
            else if (language == "USA")
            {
                return "a_client_description_usa";
            }
            else
            {
                return null;
            }
        }
        public string ToolTipFromLanguage() //dethunter12 4/12/2018
        {

            if (language == "GER")
            {
                return "a_client_tooltip_ger";
            }
            else if (language == "POL")
            {
                return "a_client_tooltip_pld";
            }
            else if (language == "BRA")
            {
                return "a_client_tooltip_brz";
            }
            else if (language == "RUS")
            {
                return "a_client_tooltip_rus";
            }
            else if (language == "FRA")
            {
                return "a_client_tooltip_frc";
            }
            else if (language == "ESP")
            {
                return "a_client_tooltip_spn";
            }
            else if (language == "MEX")
            {
                return "a_client_tooltip_mex";
            }
            else if (language == "THA")
            {
                return "a_client_tooltip_thai";
            }
            else if (language == "ITA")
            {
                return "a_client_tooltip_ita";
            }
            else if (language == "USA")
            {
                return "a_client_tooltip_usa";
            }
            else
            {
                return null;
            }
        }


        //dethunter12 4/12/2018 language system end
        public List<string> MenuList = new List<string>();
        public List<string> MenuListSearch = new List<string>();
        public List<string> MenuList2 = new List<string>();
        public List<string> MenuListSearch2 = new List<string>();
        public string mSortJob = "-1";
        public string mSortJob2 = "-1";
        public string mSortPet = "0"; //dethunter12 add 5/6/2018
        private ExportLodHandle exportLodhandle = new ExportLodHandle();
        private IContainer components = (IContainer)null;
        public string name;
        public int index;
        public string test2;
        public const int AW_ACTIVATE = 131072;
        public const int AW_HIDE = 65536;
        public const int AW_BLEND = 524288;
        public const int AW_CENTER = 16;
        public const int AW_SLIDE = 262144;
        public const int AW_HOR_POSITIVE = 1;
        public const int AW_HOR_NEGATIVE = 2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileExportToolStripMenuItem;
        private GroupBox groupBox3;
        private Button button3;
        private Button button1;
        private ListBox listBox1;
        private GroupBox groupBox5;
        private Label label7;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox6;
        private ComboBox comboBox5;
        private ComboBox comboBox4;
        private ComboBox comboBox13;
        private ComboBox comboBox12;
        private ComboBox comboBox11;
        private ComboBox comboBox10;
        private ComboBox comboBox9;
        private ComboBox comboBox8;
        private ComboBox comboBox7;
        private ComboBox comboBox14;
        private Label label3;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private GroupBox groupBox4;
        private Label label8;
        private ComboBox comboBox15;
        private TextBox textBox7;
        private GroupBox groupBox6;
        private TabPage tabPage4;
        private Label label16;
        private TextBox textBox14;
        private Label label15;
        private TextBox textBox13;
        private TextBox textBox9;
        private Label label14;
        private Label label11;
        private TextBox textBox12;
        private TextBox textBox10;
        private Label label13;
        private Label label12;
        private TextBox textBox11;
        private TextBox textBox15;
        private GroupBox groupBox9;
        private Label label17;
        private ComboBox comboBox16;
        private TextBox textBox16;
        private GroupBox groupBox10;
        private ComboBox comboBox17;
        private Label label18;
        private TextBox textBox17;
        private Label label19;
        private ComboBox comboBox18;
        private TextBox textBox18;
        private TextBox textBox19;
        private GroupBox groupBox11;
        private Label label22;
        private Label label21;
        private Label label20;
        private TextBox textBox21;
        private TextBox textBox20;
        private TextBox textBox22;
        private TextBox textBox23;
        private TextBox textBox24;
        private Label label25;
        private Label label24;
        private Label label23;
        private TextBox textBox25;
        private Label label26;
        private ToolStripMenuItem exportSkilllodToolStripMenuItem;
        private ToolStripMenuItem exportStrSkillsusalodToolStripMenuItem;
        private TextBox textBox26;
        private Label label4;
        private Label label27;
        private TextBox textBox28;
        private Label label10;
        private TextBox textBox27;
        private TextBox textBox29;
        private GroupBox groupBox8;
        private TextBox textBox30;
        private Label label28;
        private TextBox textBox31;
        private Label label29;
        private TextBox textBox32;
        private Label label30;
        private Label label31;
        private TabPage tabPage3;
        private GroupBox groupBox12;
        private GroupBox groupBox13;
        private TextBox textBox33;
        private TextBox textBox35;
        private TextBox textBox34;
        private Label label34;
        private Label label33;
        private Label label32;
        private GroupBox groupBox14;
        private Label label35;
        private Label label36;
        private Label label37;
        private GroupBox groupBox20;
        private Label label64;
        private Label label65;
        private Label label66;
        private Label label67;
        private Label label68;
        private Label label69;
        private GroupBox groupBox19;
        private Label label63;
        private Label label62;
        private Label label61;
        private Label label60;
        private Label label59;
        private Label label58;
        private GroupBox groupBox18;
        private Label label52;
        private Label label53;
        private Label label54;
        private Label label55;
        private Label label56;
        private Label label57;
        private GroupBox groupBox17;
        private Label label51;
        private Label label50;
        private Label label49;
        private Label label48;
        private Label label47;
        private Label label46;
        private GroupBox groupBox16;
        private Label label42;
        private Label label43;
        private Label label44;
        private Label label45;
        private GroupBox groupBox15;
        private Label label41;
        private Label label40;
        private Label label39;
        private Label label38;
        private TextBox textBox36;
        private TextBox textBox37;
        private TextBox textBox39;
        private TextBox textBox38;
        private TextBox textBox40;
        private TextBox textBox41;
        private TextBox textBox42;
        private TextBox textBox43;
        private TextBox textBox45;
        private TextBox textBox44;
        private TextBox textBox46;
        private TextBox textBox47;
        private TextBox textBox48;
        private TextBox textBox51;
        private TextBox textBox50;
        private TextBox textBox49;
        private GroupBox groupBox21;
        private Label label70;
        private TextBox textBox52;
        private Label label71;
        private TextBox textBox53;
        private TextBox textBox54;
        private TextBox textBox55;
        private Label label72;
        private GroupBox groupBox22;
        private Label label73;
        private LinkLabel linkLabel1;
        private Label label75;
        private Label label74;
        private TextBox textBox57;
        private TextBox textBox56;
        private PictureBox pictureBox1;
        private TextBox textBox58;
        private TextBox textBox59;
        private TextBox textBox60;
        private TextBox textBox61;
        private TextBox textBox62;
        private TextBox textBox63;
        private TextBox textBox64;
        private TextBox textBox65;
        private TextBox textBox66;
        private TextBox textBox70;
        private TextBox textBox69;
        private TextBox textBox68;
        private TextBox textBox67;
        private TextBox textBox71;
        private TextBox textBox76;
        private TextBox textBox75;
        private TextBox textBox74;
        private TextBox textBox73;
        private TextBox textBox72;
        private TextBox textBox77;
        private TextBox textBox203;
        private Label label76;
        private Label label77;
        private TextBox textBox78;
        private TextBox textBox79;
        private PictureBox pictureBox2;
        private Label label78;
        private Label label79;
        private Label label80;
        private Label label81;
        private TextBox textBox80;
        private PictureBox pictureBox3;
        private TextBox textBox81;
        private Label label82;
        private Label label83;
        private TextBox textBox82;
        private TextBox textBox83;
        private Label label84;
        private TabPage tabPage2;
        private TextBox textBox84;
        private Label label85;
        private Label label86;
        private TextBox textBox85;
        private Label label88;
        private TextBox textBox87;
        private Label label87;
        private TextBox textBox86;
        private GroupBox groupBox23;
        private Label label89;
        private TextBox textBox88;
        private TextBox textBox89;
        private Label label90;
        private TextBox textBox90;
        private Label label91;
        private TextBox textBox91;
        private Label label92;
        private PictureBox pictureBox4;
        private Label label93;
        private TextBox textBox92;
        private Label label95;
        private TextBox textBox94;
        private PictureBox pictureBox5;
        private Label label94;
        private TextBox textBox93;
        private TextBox textBox95;
        private GroupBox groupBox25;
        private Label label96;
        private TextBox textBox96;
        private Label label97;
        private PictureBox pictureBox6;
        private Label label98;
        private TextBox textBox97;
        private TextBox textBox98;
        private Label label99;
        private TextBox textBox102;
        private Label label103;
        private PictureBox pictureBox8;
        private Label label102;
        private TextBox textBox101;
        private TextBox textBox100;
        private Label label101;
        private PictureBox pictureBox7;
        private Label label100;
        private TextBox textBox99;
        private PictureBox pbNeedItem3;
        private TextBox tbNeedLearn3;
        private Label label106;
        private PictureBox pbNeedItem2;
        private TextBox tbNeedLearn2;
        private Label label105;
        private TextBox tbNeedLearn1;
        private Label label104;
        private Label label107;
        private TextBox textBox104;
        private Label label108;
        private TextBox textBox106;
        private Label label109;
        private TextBox textBox108;
        private GroupBox groupBox26;
        private Label label110;
        private TextBox textBox109;
        private Label label115;
        private TextBox textBox114;
        private Label label114;
        private TextBox textBox113;
        private Label label113;
        private TextBox textBox112;
        private Label label112;
        private TextBox textBox111;
        private Label label111;
        private TextBox textBox110;
        private GroupBox groupBox27;
        private TextBox tbMagicLevel3;
        private Label label121;
        private TextBox tbMagicIndex3;
        private Label label120;
        private TextBox tbMagicLevel2;
        private Label label119;
        private TextBox tbMagicIndex2;
        private Label label118;
        private TextBox tbMagicLevel1;
        private Label label117;
        private TextBox tbMagicIndex1;
        private Label label116;
        private Label label125;
        private Label label124;
        private Label label123;
        private Label label122;
        private GroupBox groupBox28;
        private TextBox textBox121;
        private TextBox textBox122;
        private TextBox textBox123;
        private TextBox textBox124;
        private TextBox textBox125;
        private Label label126;
        private Label label127;
        private TextBox textBox126;
        private TextBox textBox127;
        private TextBox textBox128;
        private Label label129;
        private Label label128;
        private TextBox textBox129;
        private TextBox textBox130;
        private TextBox textBox131;
        private TextBox textBox132;
        private TextBox textBox136;
        private TextBox textBox133;
        private TextBox textBox134;
        private TextBox textBox135;
        private TextBox textBox137;
        private TextBox textBox138;
        private TextBox textBox139;
        private TextBox textBox140;
        private TextBox textBox144;
        private TextBox textBox141;
        private TextBox textBox142;
        private TextBox textBox143;
        private TextBox textBox148;
        private TextBox textBox145;
        private TextBox textBox146;
        private TextBox textBox147;
        private TextBox textBox149;
        private TextBox textBox150;
        private TextBox textBox151;
        private TextBox textBox152;
        private Label label135;
        private PictureBox pbNeedItem1;
        private TextBox textBox153;
        private TextBox textBox154;
        private TextBox textBox155;
        private TextBox textBox156;
        private Label label136;
        private TextBox textBox157;
        private TextBox textBox158;
        private TextBox textBox159;
        private Label label137;
        private TextBox textBox160;
        private ComboBox comboBox19;
        private ComboBox comboBox20;
        private Label label139;
        private Label label138;
        private ToolTip toolTip1;
        private Button button6;
        private GroupBox groupBox7;
        private Button button5;
        private Button button4;
        private ListBox listBox2;
        private GroupBox groupBox30;
        private TabControl tabControl2;
        private TabPage tabPage5;
        private PictureBox PbMagicIdx3;
        private PictureBox PbMagicIdx2;
        private PictureBox PbMagicIdx1;
        private PictureBox PbUseState;
        private PictureBox PbAppState;
        private Button btnCopyLevel;
        private Button btnCopy;
        private Label label131;
        private Label lblLang;
        private Label label130;

        public SkillEditor()
        {
            InitializeComponent();
        }

        private void LoadListBox()
        {
            aname = StringFromLanguage(); //dethunte12 4/12/2018
            MenuList.Clear();
            string Query = "SELECT a_index," + " " + aname + " " + "FROM t_skill WHERE a_job ='" + mSortJob + "' AND a_job2 ='" + mSortJob2 + "' ORDER BY a_index;"; //dethunter12 4/12/2018
            if (mSortJob == "-1")
                Query = "SELECT a_index," + " " + aname + " " + "FROM t_skill ORDER BY a_index;"; //dethunter12 4/12/2018
            if (mSortJob2 == "-1" && mSortJob != "-1" && mSortPet == "0") //dethunter12 adjust 5/6/2018
                Query = "SELECT a_index," + " " + aname + " " + "FROM t_skill WHERE a_job ='" + mSortJob + "' ORDER BY a_index;"; //dethunter12 5/6/2018
            if (mSortJob2 == "-1" && mSortJob != "-1" && mSortPet != "0") //dethunter12 adjust 5/6/2018
                Query = "SELECT a_index," + " " + aname + " " + "FROM t_skill WHERE a_job ='" + mSortJob + "' AND a_apet_index ='" + mSortPet + "' ORDER BY a_index;"; //dethunter12 5/6/2018
            if (mSortJob2 == "-1" && mSortJob == "-1" && mSortPet == "0") //dethunter12 add  5/6/2018
                Query = "SELECT a_index," + " " + aname + " " + "FROM t_skill ORDER BY a_index;"; //dethunter12 5/6/2018
            if (mSortJob2 != "-1" && mSortJob != "-1" && mSortPet != "-1")
                Query = "SELECT a_index," + " " + aname + " " + "FROM t_skill WHERE a_job ='" + mSortJob + "' AND a_job2 ='" + mSortJob2 + "' ORDER BY a_index;";
            //dethunter12 4/12/2018 language system modify
            if (language == "GER")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayGER, Host, User, Password, Database, Query);
            }
            else if (language == "POL")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayPOL, Host, User, Password, Database, Query);
            }
            else if (language == "BRA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayBRA, Host, User, Password, Database, Query);
            }
            else if (language == "RUS")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayRUS, Host, User, Password, Database, Query);
            }
            else if (language == "FRA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayFRA, Host, User, Password, Database, Query);
            }
            else if (language == "ESP")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayESP, Host, User, Password, Database, Query);
            }
            else if (language == "MEX")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayMEX, Host, User, Password, Database, Query);
            }
            else if (language == "THA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayTHA, Host, User, Password, Database, Query);
            }
            else if (language == "ITA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayITA, Host, User, Password, Database, Query);
            }
            else if (language == "USA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayUSA, Host, User, Password, Database, Query);
            }
            else
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, Query);
            }
            //dethunter12 4/12/2018 language system modify
            //  listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, Query);
            for (int index = 0; index < listBox1.Items.Count; ++index)
                MenuList.Add(listBox1.Items[index].ToString());
            listBox1.DataSource = MenuList;
            PetBoxTest();
        }

    private void LoadListBox2()
    {
            MenuList2.Clear();
            listBox2.DataSource = databaseHandle.SelectMySqlReturnList(menuArray4, Host, User, Password, Database, "select a_level from t_skillLevel WHERE a_index ='" + textBox1.Text + "';");
      for (int index = 0; index < listBox2.Items.Count; ++index)
                MenuList2.Add(listBox2.Items[index].ToString());
            listBox2.DataSource = MenuList2;
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
            if (language == "GER")
            {
                //search the list box with german
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayGER, Host, User, Password, Database, "select a_index, a_name_ger from t_skill WHERE a_name_ger LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_ger LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_ger LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_ger LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "POL")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayPOL, Host, User, Password, Database, "select a_index, a_name_pld from t_skill WHERE a_name_pld LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_pld LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_pld LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_pld LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "BRA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayBRA, Host, User, Password, Database, "select a_index, a_name_brz from t_skill WHERE a_name_brz LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_brz LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_brz LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_brz LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "RUS")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayRUS, Host, User, Password, Database, "select a_index, a_name_rus from t_skill WHERE a_name_rus LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_rus LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_rus LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_rus LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "FRA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayFRA, Host, User, Password, Database, "select a_index, a_name_frc from t_skill WHERE a_name_frc LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_frc LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_frc LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_frc LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "ESP")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayESP, Host, User, Password, Database, "select a_index, a_name_spn from t_skill WHERE a_name_spn LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_spn LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_spn LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_spn LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "MEX")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayMEX, Host, User, Password, Database, "select a_index, a_name_mex from t_skill WHERE a_name_mex LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_mex LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_mex LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_mex LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "THA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayTHA, Host, User, Password, Database, "select a_index, a_name_thai from t_skill WHERE a_name_thai LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_thai LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_thai LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_thai LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "ITA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayITA, Host, User, Password, Database, "select a_index, a_name_ita from t_skill WHERE a_name_ita LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_ita LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_ita LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_ita LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else if (language == "USA")
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArrayUSA, Host, User, Password, Database, "select a_index, a_name_usa from t_skill WHERE a_name_usa LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name_usa LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name_usa LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name_usa LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

            }
            else // if none of these do default search a_name
            {
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_index, a_name from t_skill WHERE a_name LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_name LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_name LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_name LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;");

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
            string Query = " select a_index , a_job , a_job2 , a_name , a_client_description , a_type , a_flag , a_maxLevel , a_appRange , a_fireRange , a_fireRange2 , a_minRange , a_targetType, a_targetNum , a_useState , a_useWeaponType0 , a_useWeaponType1 , a_use_needWearingType , a_useMagicIndex1 , a_useMagicIndex2 , a_useMagicIndex3 , a_useMagicLevel1 , a_useMagicLevel2 , a_useMagicLevel3 , a_appState , a_appWeaponType0 , a_appWeaponType1 , a_app_needWearingType , a_readyTime , a_stillTime , a_fireTime , a_reuseTime , a_cd_ra , a_cd_re , a_cd_sa , a_cd_fa , a_cd_fe0 , a_cd_fe1 , a_cd_fe2 , a_cd_fot , a_cd_fos , a_cd_ox , a_cd_oz , a_cd_oh , a_cd_oc , a_cd_fdc , a_cd_fd0 , a_cd_fd1 , a_cd_fd2 , a_cd_fd3 , a_cd_dd , a_cd_fe_after , a_cd_fe_after2 , a_client_tooltip , a_client_icon_texid , a_client_icon_row , a_client_icon_col , a_cd_ra2 , a_cd_re2 , a_cd_sa2 , a_cd_fa2 , a_cd_fe3 , a_cd_fe4 , a_cd_fe5 , a_cd_fot2 , a_cd_fos2 , a_cd_ox2 , a_cd_oz2 , a_cd_oh2 , a_cd_oc2 , a_cd_fdc2 , a_cd_fd4 , a_cd_fd5 , a_cd_fd6 , a_cd_fd7 , a_cd_dd2 , a_selfparam , a_targetparam , a_soul_consum , a_summon_idx , a_sorcerer_flag , a_apet_index , a_allowzone, a_name_usa, a_client_description_usa, a_client_tooltip_usa, a_name_ger, a_client_description_ger, a_client_tooltip_ger, a_name_rus, a_client_description_rus, a_client_tooltip_rus, a_name_thai, a_client_description_thai, a_client_tooltip_thai, a_name_frc, a_client_description_frc, a_client_tooltip_frc, a_name_mex, a_client_description_mex, a_client_tooltip_mex, a_name_brz, a_client_description_brz, a_client_tooltip_brz, a_name_spn, a_client_description_spn, a_client_tooltip_spn, a_name_ita, a_client_description_ita, a_client_tooltip_ita, a_name_pld, a_client_description_pld, a_client_tooltip_pld from t_skill  WHERE a_index ='" + textBox1.Text + "';"; //dethunter12 4/12/2018 adjust language system
            string[] rows = new string[113]
            {
        "a_index",
        "a_job",
        "a_job2",
        "a_name",
        "a_client_description",
        "a_type",
        "a_flag",
        "a_maxLevel",
        "a_appRange",
        "a_fireRange",
        "a_fireRange2",
        "a_minRange",
        "a_targetType",
        "a_targetNum",
        "a_useState",
        "a_useWeaponType0",
        "a_useWeaponType1",
        "a_use_needWearingType",
        "a_useMagicIndex1",
        "a_useMagicIndex2",
        "a_useMagicIndex3",
        "a_useMagicLevel1",
        "a_useMagicLevel2",
        "a_useMagicLevel3",
        "a_appState",
        "a_appWeaponType0",
        "a_appWeaponType1",
        "a_app_needWearingType",
        "a_readyTime",
        "a_stillTime",
        "a_fireTime",
        "a_reuseTime",
        "a_cd_ra",
        "a_cd_re",
        "a_cd_sa",
        "a_cd_fa",
        "a_cd_fe0",
        "a_cd_fe1",
        "a_cd_fe2",
        "a_cd_fot",
        "a_cd_fos",
        "a_cd_ox",
        "a_cd_oz",
        "a_cd_oh",
        "a_cd_oc",
        "a_cd_fdc",
        "a_cd_fd0",
        "a_cd_fd1",
        "a_cd_fd2",
        "a_cd_fd3",
        "a_cd_dd",
        "a_cd_fe_after",
        "a_cd_fe_after2",
        "a_client_tooltip",
        "a_client_icon_texid",
        "a_client_icon_row",
        "a_client_icon_col",
        "a_cd_ra2",
        "a_cd_re2",
        "a_cd_sa2",
        "a_cd_fa2",
        "a_cd_fe3",
        "a_cd_fe4",
        "a_cd_fe5",
        "a_cd_fot2",
        "a_cd_fos2",
        "a_cd_ox2",
        "a_cd_oz2",
        "a_cd_oh2",
        "a_cd_oc2",
        "a_cd_fdc2",
        "a_cd_fd4",
        "a_cd_fd5",
        "a_cd_fd6",
        "a_cd_fd7",
        "a_cd_dd2",
        "a_selfparam",
        "a_targetparam",
        "a_soul_consum",
        "a_summon_idx",
        "a_sorcerer_flag",
        "a_apet_index",
        "a_allowzone", //82
        "a_name_usa",//83
        "a_client_description_usa",//84
        "a_client_tooltip_usa",//85
        "a_name_ger",//86
        "a_client_description_ger",//87
        "a_client_tooltip_ger",//88
        "a_name_rus",//89
        "a_client_description_rus",//90
        "a_client_tooltip_rus",//91
        "a_name_thai",//92
        "a_client_description_thai",//93
        "a_client_tooltip_thai",//94
        "a_name_frc",//95
        "a_client_description_frc",//96
        "a_client_tooltip_frc",//97
        "a_name_mex",//98
        "a_client_description_mex",//99
        "a_client_tooltip_mex",//100
        "a_name_brz",//101
        "a_client_description_brz",//102
        "a_client_tooltip_brz",//103
        "a_name_spn",//104
        "a_client_description_spn",//105
        "a_client_tooltip_spn",//106
        "a_name_ita",//107
        "a_client_description_ita",//108
        "a_client_tooltip_ita",	//109
	    "a_name_pld",//110
        "a_client_description_pld",//111
        "a_client_tooltip_pld",//112
            };
            Query.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'");
            string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query, rows);
            textBox1.Text = strArray[0];
            textBox2.Text = strArray[1];
            textBox3.Text = strArray[2];
            //dethunter12 4/12/2018 language system
            if (language == "GER")
            {
                textBox4.Text = strArray[86];
                textBox5.Text = strArray[87];
                textBox54.Text = strArray[88];
            }
            else if (language == "POL")
            {
                textBox4.Text = strArray[110];
                textBox5.Text = strArray[111];
                textBox54.Text = strArray[112];
            }
            else if (language == "BRA")
            {
                textBox4.Text = strArray[101];
                textBox5.Text = strArray[102];
                textBox54.Text = strArray[103];
            }
            else if (language == "RUS")
            {
                textBox4.Text = strArray[89];
                textBox5.Text = strArray[90];
                textBox54.Text = strArray[91];
            }
            else if (language == "FRA")
            {
                textBox4.Text = strArray[95];
                textBox5.Text = strArray[96];
                textBox54.Text = strArray[97];
            }
            else if (language == "ESP")
            {
                textBox4.Text = strArray[104];
                textBox5.Text = strArray[105];
                textBox54.Text = strArray[106];
            }
            else if (language == "MEX")
            {
                textBox4.Text = strArray[98];
                textBox5.Text = strArray[99];
                textBox54.Text = strArray[100];
            }
            else if (language == "THA")
            {
                textBox4.Text = strArray[92];
                textBox5.Text = strArray[93];
                textBox54.Text = strArray[94];
            }
            else if (language == "ITA")
            {
                textBox4.Text = strArray[107];
                textBox5.Text = strArray[108];
                textBox54.Text = strArray[109];
            }
            else if (language == "USA")
            {
                textBox4.Text = strArray[83];
                textBox5.Text = strArray[84];
                textBox54.Text = strArray[85];
            }
            else // if none of these do default search a_name
            {
                textBox4.Text = strArray[3];
                textBox5.Text = strArray[4];
                textBox54.Text = strArray[53];
            }
            //dethunter12 4/12/2018 lang system end
            //textBox4.Text = strArray[3]; 
            //textBox5.Text = strArray[4];
            //textBox54.Text = strArray[53];

            textBox6.Text = strArray[5];
            textBox7.Text = strArray[6];
            tbmaxLevel.Text = strArray[7];
            textBox9.Text = strArray[8];
            textBox10.Text = strArray[9];
            textBox11.Text = strArray[10];
            textBox12.Text = strArray[11];
            textBox13.Text = strArray[12];
            textBox14.Text = strArray[13];
            textBox15.Text = strArray[14];
            textBox16.Text = strArray[15];
            textBox17.Text = strArray[16];
            textBox18.Text = strArray[17];
            textBox19.Text = strArray[18];
            textBox20.Text = strArray[19];
            textBox21.Text = strArray[20];
            textBox22.Text = strArray[21];
            textBox23.Text = strArray[22];
            textBox24.Text = strArray[23];
            textBox25.Text = strArray[24];
            textBox26.Text = strArray[25];
            textBox27.Text = strArray[26];
            textBox28.Text = strArray[27];
            textBox29.Text = strArray[28];
            textBox30.Text = strArray[29];
            textBox31.Text = strArray[30];
            textBox32.Text = strArray[31];
            textBox33.Text = strArray[32];
            textBox34.Text = strArray[33];
            textBox35.Text = strArray[34];
            textBox36.Text = strArray[35];
            textBox37.Text = strArray[36];
            textBox38.Text = strArray[37];
            textBox39.Text = strArray[38];
            textBox40.Text = strArray[39];
            textBox41.Text = strArray[40];
            textBox42.Text = strArray[41];
            textBox43.Text = strArray[42];
            textBox44.Text = strArray[43];
            textBox45.Text = strArray[44];
            textBox46.Text = strArray[45];
            textBox47.Text = strArray[46];
            textBox48.Text = strArray[47];
            textBox49.Text = strArray[48];
            textBox50.Text = strArray[49];
            textBox51.Text = strArray[50];
            textBox52.Text = strArray[51];
            textBox53.Text = strArray[52];
            //   textBox54.Text = strArray[53]; dethunter12 disable 4/12/2018
            textBox55.Text = strArray[54];
            textBox56.Text = strArray[55];
            textBox57.Text = strArray[56];
            textBox58.Text = strArray[57];
            textBox59.Text = strArray[58];
            textBox60.Text = strArray[59];
            textBox61.Text = strArray[60];
            textBox62.Text = strArray[61];
            textBox63.Text = strArray[62];
            textBox64.Text = strArray[63];
            textBox65.Text = strArray[64];
            textBox66.Text = strArray[65];
            textBox67.Text = strArray[66];
            textBox68.Text = strArray[67];
            textBox69.Text = strArray[68];
            textBox70.Text = strArray[69];
            textBox71.Text = strArray[70];
            textBox72.Text = strArray[71];
            textBox73.Text = strArray[72];
            textBox74.Text = strArray[73];
            textBox75.Text = strArray[74];
            textBox76.Text = strArray[75];
            textBox77.Text = strArray[76];
            textBox78.Text = strArray[77];
            textBox79.Text = strArray[78];
            textBox80.Text = strArray[79];
            textBox81.Text = strArray[80];
            textBox82.Text = strArray[81];
            textBox83.Text = strArray[82];
            SelectBoxes();
            IconItem();
            IconSkill();
            ClearPicture();
            try
            {
                pictureBox1.Image = (Image)databaseHandle.IconSkill1(int.Parse(textBox55.Text), int.Parse(textBox56.Text), int.Parse(textBox57.Text));
            }
            catch
            {
            }
            LoadListBox2();
        }

        private void ClearPicture()
        {
            if (textBox129.Text == "")
                pictureBox4.Image = (Image)null;
            if (textBox133.Text == "")
                pictureBox5.Image = (Image)null;
            if (textBox137.Text == "")
                pictureBox6.Image = (Image)null;
            if (textBox141.Text == "")
                pictureBox7.Image = (Image)null;
            if (textBox145.Text == "")
                pictureBox8.Image = (Image)null;
            if (textBox150.Text == "")
                pbNeedItem1.Image = (Image)null;
            if (textBox153.Text == "")
                pbNeedItem2.Image = (Image)null;
            if (!(textBox157.Text == ""))
                return;
            pbNeedItem3.Image = (Image)null;
        }

        private void IconSkill()
        {
            //aname = StringFromLanguage(); //dethunter12 4/12/14 lang system
            string Query1 = "select a_index, a_client_icon_texid, a_client_icon_row, a_client_icon_col, a_name_usa from t_skill WHERE a_index ='" + textBox97.Text + "';";//dethunter12 4/12/2018 adjust
            string Query2 = "select a_index, a_client_icon_texid, a_client_icon_row, a_client_icon_col, a_name_usa from t_skill WHERE a_index ='" + textBox99.Text + "';"; //dethunter12 4/12/2018 adjust
            string Query3 = "select a_index, a_client_icon_texid, a_client_icon_row, a_client_icon_col, a_name_usa from t_skill WHERE a_index ='" + textBox101.Text + "';"; //dethunter12 4/12/2018 adjust
            string[] rows1 = new string[5]
            {
        "a_index",
        "a_client_icon_texid",
        "a_client_icon_row",
        "a_client_icon_col",
        "a_name_usa"
            };
            string[] rows2 = new string[5]
            {
        "a_index",
        "a_client_icon_texid",
        "a_client_icon_row",
        "a_client_icon_col",
        "a_name_usa"
            };
            string[] rows3 = new string[5]
            {
        "a_index",
        "a_client_icon_texid",
        "a_client_icon_row",
        "a_client_icon_col",
        "a_name_usa"
            };
            Query1.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'");
            string[] strArray1 = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query1, rows1);
            string[] strArray2 = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query2, rows2);
            string[] strArray3 = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query3, rows3);
            textBox140.Text = strArray1[0];
            textBox137.Text = strArray1[1];
            textBox138.Text = strArray1[2];
            textBox139.Text = strArray1[3];
            textBox144.Text = strArray2[0];
            textBox141.Text = strArray2[1];
            textBox142.Text = strArray2[2];
            textBox143.Text = strArray2[3];
            textBox148.Text = strArray3[0];
            textBox145.Text = strArray3[1];
            textBox146.Text = strArray3[2];
            textBox147.Text = strArray3[3];
        }

        private void IconItem()
        {
            string Query1 = "select a_index, a_texture_id, a_texture_row, a_texture_col, a_name_usa from t_item WHERE a_index ='" + textBox91.Text + "';";
            string Query2 = "select a_index, a_texture_id, a_texture_row, a_texture_col, a_name_usa from t_item WHERE a_index ='" + textBox93.Text + "';";
            string Query3 = "select a_index, a_texture_id, a_texture_row, a_texture_col, a_name_usa from t_item WHERE a_index ='" + tbNeedLearn1.Text + "';";
            string Query4 = "select a_index, a_texture_id, a_texture_row, a_texture_col, a_name_usa from t_item WHERE a_index ='" + tbNeedLearn2.Text + "';";
            string Query5 = "select a_index, a_texture_id, a_texture_row, a_texture_col, a_name_usa from t_item WHERE a_index ='" + tbNeedLearn3.Text + "';";
            string[] rows1 = new string[5]
            {
        "a_index",
        "a_texture_id",
        "a_texture_row",
        "a_texture_col",
        "a_name_usa"
            };
            string[] rows2 = new string[5]
            {
        "a_index",
        "a_texture_id",
        "a_texture_row",
        "a_texture_col",
        "a_name_usa"
            };
            string[] rows3 = new string[5]
            {
        "a_index",
        "a_texture_id",
        "a_texture_row",
        "a_texture_col",
        "a_name_usa"
            };
            string[] rows4 = new string[5]
            {
        "a_index",
        "a_texture_id",
        "a_texture_row",
        "a_texture_col",
        "a_name_usa"
            };
            string[] rows5 = new string[5]
            {
        "a_index",
        "a_texture_id",
        "a_texture_row",
        "a_texture_col",
        "a_name_usa"
            };
            Query1.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'");
            string[] strArray1 = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query1, rows1);
            string[] strArray2 = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query2, rows2);
            string[] strArray3 = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query3, rows3);
            string[] strArray4 = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query4, rows4);
            string[] strArray5 = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query5, rows5);
            textBox132.Text = strArray1[0];
            textBox129.Text = strArray1[1];
            textBox130.Text = strArray1[2];
            textBox131.Text = strArray1[3];
            textBox136.Text = strArray2[0];
            textBox133.Text = strArray2[1];
            textBox134.Text = strArray2[2];
            textBox135.Text = strArray2[3];
            textBox149.Text = strArray3[0];
            textBox150.Text = strArray3[1];
            textBox151.Text = strArray3[2];
            textBox152.Text = strArray3[3];
            textBox156.Text = strArray4[0];
            textBox153.Text = strArray4[1];
            textBox154.Text = strArray4[2];
            textBox155.Text = strArray4[3];
            textBox160.Text = strArray5[0];
            textBox157.Text = strArray5[1];
            textBox158.Text = strArray5[2];
            textBox159.Text = strArray5[3];
        }

        private void SelectBoxes()
        {
            int num1 = comboBox1.FindString(textBox2.Text);
            int num2 = comboBox2.FindString(textBox3.Text);
            int num3 = comboBox3.FindString(textBox3.Text);
            int num4 = comboBox4.FindString(textBox3.Text);
            int num5 = comboBox5.FindString(textBox3.Text);
            int num6 = comboBox6.FindString(textBox3.Text);
            int num7 = comboBox7.FindString(textBox3.Text);
            int num8 = comboBox8.FindString(textBox3.Text);
            int num9 = comboBox9.FindString(textBox3.Text);
            int num10 = comboBox10.FindString(textBox3.Text);
            int num11 = comboBox11.FindString(textBox3.Text);
            int num12 = comboBox12.FindString(textBox3.Text);
            int num13 = comboBox13.FindString(textBox3.Text);
            int num14 = comboBox14.FindString(textBox3.Text);
            int num15 = comboBox15.FindString(textBox6.Text);
            int num16 = comboBox16.FindString(textBox13.Text);
            int num17 = comboBox17.FindString(textBox16.Text);
            int num18 = comboBox18.FindString(textBox17.Text);
            int num19 = CBPet.FindString(textBox82.Text); //dethunter12 add 5/6/2018
            comboBox1.SelectedIndex = num1;
            comboBox2.SelectedIndex = num2;
            comboBox3.SelectedIndex = num3;
            comboBox4.SelectedIndex = num4;
            comboBox5.SelectedIndex = num5;
            comboBox6.SelectedIndex = num6;
            comboBox7.SelectedIndex = num7;
            comboBox8.SelectedIndex = num8;
            comboBox9.SelectedIndex = num9;
            comboBox10.SelectedIndex = num10;
            comboBox11.SelectedIndex = num11;
            comboBox12.SelectedIndex = num12;
            comboBox13.SelectedIndex = num13;
            comboBox14.SelectedIndex = num14;
            comboBox15.SelectedIndex = num15;
            comboBox16.SelectedIndex = num16;
            comboBox17.SelectedIndex = num17;
            comboBox18.SelectedIndex = num18;
            CBPet.SelectedIndex = num19;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aname = StringFromLanguage(); //dethunter12 4/12/2018 language system modify
            aClientDescripton = ClientDescrFromLanguage(); //dethunter12 4/12/2018 language system 
            aToolTip = ToolTipFromLanguage(); //dethunter12 4/12/2018 modify 
            string str1 = "UPDATE t_skill SET " + "a_index = '" + textBox1.Text + "', " + "a_job = '" + textBox2.Text + "', " + "a_job2 = '" + textBox3.Text + "', ";
            string str2 = textBox4.Text.Replace("'", "\\'").Replace("\"", "\\\"");
            string Query = str1 + "a_name = '" + str2 + "', " + aname + "=" + " " + "'" + str2 + "', " + aClientDescripton + "=" + " " + "'" + textBox5.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_client_description = '" + textBox5.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "', " + "a_type = '" + textBox6.Text + "'," + "a_flag= '" + textBox7.Text + "'," + "a_maxLevel = '" + tbmaxLevel.Text + "'," + "a_appRange = '" + textBox9.Text + "'," + "a_fireRange = '" + textBox10.Text + "'," + "a_fireRange2 = '" + textBox11.Text + "'," + "a_minRange = '" + textBox12.Text + "'," + "a_targetType = '" + textBox13.Text + "'," + "a_targetNum = '" + textBox14.Text + "'," + "a_useState = '" + textBox15.Text + "'," + "a_useWeaponType0 = '" + textBox16.Text + "'," + "a_useWeaponType1 = '" + textBox17.Text + "'," + "a_use_needWearingType = '" + textBox18.Text + "'," + "a_useMagicIndex1 = '" + textBox19.Text + "'," + "a_useMagicIndex2 = '" + textBox20.Text + "'," + "a_useMagicIndex3 = '" + textBox21.Text + "'," + "a_useMagicLevel1 = '" + textBox22.Text + "'," + "a_useMagicLevel2 = '" + textBox23.Text + "'," + "a_useMagicLevel3 = '" + textBox24.Text + "'," + "a_appState = '" + textBox25.Text + "'," + "a_appWeaponType0 = '" + textBox26.Text + "'," + "a_appWeaponType1 = '" + textBox27.Text + "'," + "a_app_needWearingType = '" + textBox28.Text + "'," + "a_readyTime = '" + textBox29.Text + "'," + "a_stillTime = '" + textBox30.Text + "'," + "a_fireTime = '" + textBox31.Text + "'," + "a_reuseTime = '" + textBox32.Text + "'," + "a_cd_ra = '" + textBox33.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_re = '" + textBox34.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_sa = '" + textBox35.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fa = '" + textBox36.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fe0 = '" + textBox37.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fe1 = '" + textBox38.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fe2 = '" + textBox39.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fot = '" + textBox40.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fos = '" + textBox41.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_ox = '" + textBox42.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_oz = '" + textBox43.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_oh = '" + textBox44.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_oc = '" + textBox45.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fdc = '" + textBox46.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fd0 = '" + textBox47.Text.Replace(",", ".") + "'," + "a_cd_fd1 = '" + textBox48.Text.Replace(",", ".") + "'," + "a_cd_fd2 = '" + textBox49.Text.Replace(",", ".") + "'," + "a_cd_fd3 = '" + textBox50.Text.Replace(",", ".") + "'," + "a_cd_dd = '" + textBox51.Text + "'," + "a_cd_fe_after = '" + textBox52.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fe_after2 = '" + textBox53.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_client_tooltip = '" + textBox54.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + " " + aToolTip + "='" + textBox54.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_client_icon_texid = '" + textBox55.Text + "'," + "a_client_icon_row = '" + textBox56.Text + "'," + "a_client_icon_col = '" + textBox57.Text + "'," + "a_cd_ra2 = '" + textBox58.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_re2 = '" + textBox59.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_sa2 = '" + textBox60.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fa2 = '" + textBox61.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fe3 = '" + textBox62.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fe4 = '" + textBox63.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fe5 = '" + textBox64.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fot2 = '" + textBox65.Text + "'," + "a_cd_fos2 = '" + textBox66.Text + "'," + "a_cd_ox2 = '" + textBox67.Text + "'," + "a_cd_oz2 = '" + textBox68.Text + "'," + "a_cd_oh2 = '" + textBox69.Text + "'," + "a_cd_oc2 = '" + textBox70.Text + "'," + "a_cd_fdc2 = '" + textBox71.Text + "'," + "a_cd_fd4 = '" + textBox72.Text.Replace(",", ".") + "'," + "a_cd_fd5 = '" + textBox73.Text.Replace(",", ".") + "'," + "a_cd_fd6 = '" + textBox74.Text.Replace(",", ".") + "'," + "a_cd_fd7 = '" + textBox75.Text.Replace(",", ".") + "'," + "a_cd_dd2 = '" + textBox76.Text + "'," + "a_selfparam = '" + textBox77.Text + "'," + "a_targetparam = '" + textBox78.Text + "'," + "a_soul_consum = '" + textBox79.Text + "'," + "a_summon_idx = '" + textBox80.Text + "'," + "a_sorcerer_flag = '" + textBox81.Text + "'," + "a_apet_index = '" + textBox82.Text + "'," + "a_allowzone = '" + textBox83.Text + "'" + " WHERE a_index = '" + textBox1.Text + "'"; //dethunter12 4/12/2018 modify
            databaseHandle.SendQueryMySql(Host, User, Password, Database, Query);
            Console.WriteLine(Query);
            label130.Text = "Update Skill Succesfully!";
            label130.ForeColor = Color.Lime;
            label130.Visible = true;
            int selectedIndex = listBox1.SelectedIndex;
            if (textBox203.Text != "")
                SearchList(textBox203.Text);
            else
                LoadListBox();
            listBox1.SelectedIndex = selectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "INSERT INTO t_skill DEFAULT VALUES");
            LoadListBox();
            listBox1.SelectedIndex = listBox1.Items.Count - 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_skill WHERE a_index = '" + textBox1.Text + "'");
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_skilllevel WHERE a_index = '" + textBox1.Text + "'");
            LoadListBox();
            if (textBox203.Text != "") //dethunter12 add 12/22/2019
                SearchList(textBox203.Text);
            listBox1.SelectedIndex = selectedIndex - 1;
        }

        private void LoadStartUp()
        {
            comboBox19.Items.AddRange(new object[14]
      {
         "-1 - All",
         "0 - Titan",
         "1 - Knight",
         "2 - Healer",
         "3 - Mage",
         "4 - Rogue",
         "5 - Sorcerer",
         "6 - NightShadow",
         "7 - Ex-Rogue",
         "8 - Ex-Mage",
         "9 - Nothing",
         "10 - Pet",
         "11 - APet",
         "999 - All"
      });
            comboBox1.Items.AddRange(new object[13]
      {
         "0 - Titan",
         "1 - Knight",
         "2 - Healer",
         "3 - Mage",
         "4 - Rogue",
         "5 - Sorcerer",
         "6 - Night Shadow",
         "7 - Ex-Rogue",
         "8 - Archmage",
         "9 - Nothing",
         "10 - Pet",
         "11 - APet",
         "999 - All"
      });
            comboBox2.Items.AddRange(new object[3]
      {
         "0 - None",
         "1 - Higlander",
         "2 - Warmaster"
      });
            comboBox3.Items.AddRange(new object[3]
      {
         "0 - None",
         "1 - Royal",
         "2 - Templar"
      });
            comboBox4.Items.AddRange(new object[3]
      {
         "0 - None",
         "1 - Archer",
         "2 - Cleric"
      });
            comboBox5.Items.AddRange(new object[3]
      {
         "0 - None",
         "1 - Wizard",
         "2 - Witch"
      });
            comboBox6.Items.AddRange(new object[3]
      {
         "0 - None",
         "1 - Assasin",
         "2 - Ranger"
      });
            comboBox7.Items.AddRange(new object[3]
      {
         "0 - None",
         "1 - Elementalist",
         "2 - Specialist"
      });
            comboBox8.Items.AddRange(new object[2]
      {
         "0 - None",
         "1 - NightShadow"
      });
            comboBox9.Items.AddRange(new object[3]
      {
         "0 - None",
         "1 - Ex-Assasin",
         "2 - Ex-Ranger"
      });
            comboBox10.Items.AddRange(new object[3]
      {
         "0 - None",
         "1 - Arch-Wizard",
         "2 - Arch-Witch"
      });
            comboBox11.Items.AddRange(new object[1]
      {
         "0 - None"
      });
            comboBox12.Items.AddRange(new object[4]
      {
         "0 - Horse",
         "1 - Dragon",
         "2 - Horse Mount",
         "3 - Dragon Mount"

      });
            comboBox13.Items.AddRange(new object[5]
      {
         "0 - None",
         "1 - Human",
         "2 - Beast",
         "3 - Unknown",
         "4 - Unknown"
      });
            comboBox14.Items.AddRange(new object[4] //dethunter12 fix p1 pet
      {
            "0 - Horse",
         "1 - Dragon",
         "2 - Horse Mount",
         "3 - Dragon Mount"

      });
            comboBox15.Items.AddRange(new object[10]
      {
         "0 - Melee",
         "1 - Range",
         "2 - Magic",
         "3 - Passive",
         "4 - Pet Command",
         "5 - Pet Skill Passive",
         "6 - Pet Skill Active",
         "7 - Guild Skill Passive",
         "8 - Seal",
         "9 - Summon Skill"
      });
            comboBox16.Items.AddRange(new object[13]
      {
         "0 - Self One",
         "1 - Self Range",
         "2 - Target One",
         "3 - Target Range",
         "4 - Party One",
         "5 - Party All",
         "6 - Target D120",
         "7 - Target Rect",
         "8 - Elemental One",
         "9 - Guild All",
         "10 - Guild One",
         "11 - Guild Self Range",
         "12 - Guild Member Self"
      });
            comboBox17.Items.AddRange(new object[17]
      {
         "-1",
         "0 - Weapon Night",
         "1 - Weapon Crossbow",
         "2 - Weapon Staff",
         "3 - Weapon Big Sword",
         "4 - Weapon Axe",
         "5 - Weapon Short Staff",
         "6 - Weapon Bow",
         "7 - Weapon ShortGum",
         "8 - Weapon Mining",
         "9 - Weapon Gathering",
         "10 - Weapon Charge",
         "11 - Weapon Two Sword",
         "12 - Weapon Wand",
         "13 - Weapon Scythe",
         "14 - Weapon Polearm",
         "15 - Weapon Soul"
      });
            comboBox18.Items.AddRange(new object[17]
      {
         "-1",
         "0 - Weapon Night",
         "1 - Weapon Crossbow",
         "2 - Weapon Staff",
         "3 - Weapon Big Sword",
         "4 - Weapon Axe",
         "5 - Weapon Short Staff",
         "6 - Weapon Bow",
         "7 - Weapon ShortGum",
         "8 - Weapon Mining",
         "9 - Weapon Gathering",
         "10 - Weapon Charge",
         "11 - Weapon Two Sword",
         "12 - Weapon Wand",
         "13 - Weapon Scythe",
         "14 - Weapon Polearm",
         "15 - Weapon Soul"
      });
            CBPet.Items.AddRange(new object[87]
     {
         "-1 - none",
         "0 - none",
         "1 - Sca-chi",
         "2 - Ichi",
         "3 - Mystery Pet",
         "4 - Polar Bear Cub",
         "5 - Ursus",
         "6 - Nanook",
         "7 - Jaguar Cub",
         "8 - Jaguar",
         "9 - Panthera Onca",
         "10 - Pet",
         "11 - Baby Panda",
         "12 - Panda",
         "13 - Battle Panda",
         "14 - Mystery Pet",
         "15 - Lizard Linko Baby",
         "16 - Lizard Lingko",
         "17 - Lizard Battle Lingko",
         "18 - Strange Bat",
         "19 - Thorny Demon Bat",
         "20 - Scar Demon Bat",
         "21 - Succubus of Flame",
         "22 - Succubus of Seduction",
         "23 - Succubus of Lightning",
         "24 - Succubus of Seduction 2",
         "25 - Lizard Ruv Baby",
         "26 - Lizard Ruv",
         "27 - Lizard Battle Ruv",
         "28 - Lizard Kai Baby",
         "29 - Lizard Kai",
         "30 - Lizard Battle Kai",
         "31 - Swift Horse Diesel",
         "32 - Strong Pony",
         "33 - Imposing Pony",
         "34 - Arrogant Pony",
         "35 - Attractive Pony",
         "36 - Swift Pony",
         "37 - Mysterious Pony",
         "38 - Swift Horse Diesel Event",
         "39 - Red Diesel",
         "40 - Popenian",
         "41 - Rideable Popenian",
         "42 - Eaglet Zeppy",
         "43 - Eagle Zeppy",
         "44 - Battle Eagle Zeppy",
         "47 - Eagle Maxie",
         "48 - Suspicious Bat",
         "49 - Scar Nightmare",
         "50 - Incubus",
         "51 - Elephant Chang Thai",
         "52 - Leopard",
         "53 - Liopard",
         "54 - Zappy",
         "55 - Lingkogator",
         "56 - Panda Plush",
         "57 - Halloween Pumpkin Ghost",
         "58 - Qilin",
         "59 - Chameleon",
         "60 - Tiny Dragon",
         "61 - Bear",
         "62 - Bike",
         "63 - Red Okami",
         "64 - Black Lion-Wolf",
         "71 - Russia_elk",
         "72 - Exp_horse",
         "73 - Ghost_horse",
         "74 - Horse_Gray",
         "75 - Ice_horse",
         "76 - eInferno_horse Inf",
         "77 - Pegas a Fix",
         "78 - Tiger Lord",
         "79 - Lion Lord",
         "80 - Unicorn pink",
         "81 - Unicorn blue",
         "82 - Cat",
         "83 - Event Sca-chi",
         "84 - Event Ichi",
         "85 - Event Panda Cub",
         "86 - Event Panda",
         "87 - Event Battle Panda",
         "88 - Event Jaguar Cub",
         "89 - Event Jaguar",
         "90 - Event Panthera Onca",
         "91 - Event Pb Cub",
         "92 - Event Ursus",
         "93 - Event Nanook"
     }); //dethunter12 add 5/6/2018
           
           
        }
        private void textBox12_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = GetIndexByComboBox(comboBox1.Text).ToString();
            if (textBox2.Text == "0")
            {
                comboBox2.Visible = true;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
                comboBox7.Visible = false;
                comboBox8.Visible = false;
                comboBox9.Visible = false;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                comboBox12.Visible = false;
                comboBox13.Visible = false;
                comboBox14.Visible = false;
            }
            else if (textBox2.Text == "1")
            {
                comboBox2.Visible = false;
                comboBox3.Visible = true;
                comboBox4.Visible = false;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
                comboBox7.Visible = false;
                comboBox8.Visible = false;
                comboBox9.Visible = false;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                comboBox12.Visible = false;
                comboBox13.Visible = false;
                comboBox14.Visible = false;
            }
            else if (textBox2.Text == "2")
            {
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = true;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
                comboBox7.Visible = false;
                comboBox8.Visible = false;
                comboBox9.Visible = false;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                comboBox12.Visible = false;
                comboBox13.Visible = false;
                comboBox14.Visible = false;
            }
            else if (textBox2.Text == "3")
            {
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                comboBox5.Visible = true;
                comboBox6.Visible = false;
                comboBox7.Visible = false;
                comboBox8.Visible = false;
                comboBox9.Visible = false;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                comboBox12.Visible = false;
                comboBox13.Visible = false;
                comboBox14.Visible = false;
            }
            else if (textBox2.Text == "4")
            {
                comboBox4.Visible = false;
                comboBox5.Visible = false;
                comboBox6.Visible = true;
                comboBox7.Visible = false;
                comboBox8.Visible = false;
                comboBox9.Visible = false;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                comboBox12.Visible = false;
                comboBox13.Visible = false;
                comboBox14.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
            }
            else if (textBox2.Text == "5")
            {
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
                comboBox7.Visible = true;
                comboBox8.Visible = false;
                comboBox9.Visible = false;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                comboBox12.Visible = false;
                comboBox13.Visible = false;
                comboBox14.Visible = false;
            }
            else if (textBox2.Text == "6")
            {
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
                comboBox7.Visible = false;
                comboBox8.Visible = true;
                comboBox9.Visible = false;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                comboBox12.Visible = false;
                comboBox13.Visible = false;
                comboBox14.Visible = false;
            }
            else if (textBox2.Text == "7")
            {
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
                comboBox7.Visible = false;
                comboBox8.Visible = false;
                comboBox9.Visible = true;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                comboBox12.Visible = false;
                comboBox13.Visible = false;
                comboBox14.Visible = false;
            }
            else if (textBox2.Text == "8")
            {
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
                comboBox7.Visible = false;
                comboBox8.Visible = false;
                comboBox9.Visible = false;
                comboBox10.Visible = true;
                comboBox11.Visible = false;
                comboBox12.Visible = false;
                comboBox13.Visible = false;
                comboBox14.Visible = false;
            }
            else if (textBox2.Text == "9")
            {
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
                comboBox7.Visible = false;
                comboBox8.Visible = false;
                comboBox9.Visible = false;
                comboBox10.Visible = false;
                comboBox11.Visible = true;
                comboBox12.Visible = false;
                comboBox13.Visible = false;
                comboBox14.Visible = false;
            }
            else if (textBox2.Text == "10")
            {
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
                comboBox7.Visible = false;
                comboBox8.Visible = false;
                comboBox9.Visible = false;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                comboBox12.Visible = true;
                comboBox13.Visible = false;
                comboBox14.Visible = false;
            }
            else if (textBox2.Text == "11")
            {
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
                comboBox7.Visible = false;
                comboBox8.Visible = false;
                comboBox9.Visible = false;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                comboBox12.Visible = false;
                comboBox13.Visible = true;
                comboBox14.Visible = false;
            }
            else if (textBox2.Text == "999")
            {
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
                comboBox7.Visible = false;
                comboBox8.Visible = false;
                comboBox9.Visible = false;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                comboBox12.Visible = false;
                comboBox13.Visible = false;
                comboBox14.Visible = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = GetIndexByComboBox(comboBox2.Text).ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = GetIndexByComboBox(comboBox3.Text).ToString();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = GetIndexByComboBox(comboBox4.Text).ToString();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = GetIndexByComboBox(comboBox5.Text).ToString();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = GetIndexByComboBox(comboBox6.Text).ToString();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = GetIndexByComboBox(comboBox7.Text).ToString();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = GetIndexByComboBox(comboBox8.Text).ToString();
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = GetIndexByComboBox(comboBox9.Text).ToString();
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = GetIndexByComboBox(comboBox10.Text).ToString();
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = GetIndexByComboBox(comboBox11.Text).ToString();
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = GetIndexByComboBox(comboBox12.Text).ToString();
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = GetIndexByComboBox(comboBox13.Text).ToString();
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = GetIndexByComboBox(comboBox14.Text).ToString();
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox6.Text = GetIndexByComboBox(comboBox15.Text).ToString();
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox13.Text = GetIndexByComboBox(comboBox16.Text).ToString();
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox16.Text = GetIndexByComboBox(comboBox17.Text).ToString();
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox17.Text = GetIndexByComboBox(comboBox18.Text).ToString();
        }
        public string LanguageExport() //dethunter12 add 7/5/2020 [clean by scura]
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
        private void exportSkilllodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text1 = "skill";
            string text2 = "path_ship";
            string text3 = LanguageExport();
            Process.Start(new ProcessStartInfo()
            {
                FileName = "ExportLod.exe",
                Arguments = " -h " + Host + " -d " + Database + " -u " + User + " -p " + Password + " -k " + text2 + " -l " + text3 + " -t " + text1
            });
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IconPickerSkill iconPickerSkill = new IconPickerSkill();
            iconPickerSkill.OldItemBtnSelect = Convert.ToInt32(textBox55.Text);
            if (iconPickerSkill.ShowDialog() != DialogResult.OK)
                return;
            textBox55.Text = iconPickerSkill.TexID.ToString();
            textBox57.Text = iconPickerSkill.TexColumn.ToString();
            textBox56.Text = iconPickerSkill.TexRow.ToString();
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_skill SET " + "a_client_icon_texid = '" + textBox55.Text + "', " + "a_client_icon_row = '" + textBox56.Text + "', " + "a_client_icon_col = '" + textBox57.Text + "' " + "WHERE a_index = '" + textBox1.Text + "'");
            int selectedIndex = listBox1.SelectedIndex;
            LoadListBox();
            listBox1.SelectedIndex = selectedIndex;
        }

        public bool SearchString(string s)
        {
            return s.ToUpper().Contains(textBox203.Text.ToUpper());
        }

        private void textBox203_TextChanged(object sender, EventArgs e)
        {
            MenuListSearch = MenuList.FindAll(new Predicate<string>(SearchString));
            listBox1.DataSource = MenuListSearch;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadStartUp();
            IconItem();
            IconSkill();
            comboBox19.SelectedIndex = 0;
            LoadListBox();
            LoadListBox2();
            SelectBoxes();
            LoadLangAtStartup(); //dethunter12 4/12/2018 language add
            CBPet.Enabled = false;
            tabControl1.TabPages.Remove(tabPage2);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FlagBuilder flagBuilder = new FlagBuilder();
            flagBuilder.flagSmall = Convert.ToInt32(textBox7.Text);
            flagBuilder.flagBuilderType = "skills";
            if (flagBuilder.ShowDialog() != DialogResult.OK)
                return;
            textBox7.Text = Convert.ToString(flagBuilder.flagSmall);
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Size = new Size(26, 26);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(23, 28);
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Size = new Size(26, 26);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(23, 28);
        }

    private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, "SELECT * FROM t_skillLevel WHERE a_index ='" + textBox1.Text + "' AND a_level = '" + listBox2.SelectedItem.ToString() + "';", new string[45]
      {
        "a_index",
        "a_level",
        "a_needHP",
        "a_needMP",
        "a_needGP",
        "a_durtime",
        "a_dummypower",
        "a_needItemIndex1",
        "a_needItemCount1",
        "a_needItemIndex2",
        "a_needItemCount2",
        "a_learnLevel",
        "a_learnSP",
        "a_learnSkillIndex1",
        "a_learnSkillLevel1",
        "a_learnSkillIndex2",
        "a_learnSkillLevel2",
        "a_learnSkillIndex3",
        "a_learnSkillLevel3",
        "a_learnItemIndex1",
        "a_learnItemCount1",
        "a_learnItemIndex2",
        "a_learnItemCount2",
        "a_learnItemIndex3",
        "a_learnItemCount3",
        "a_appMagicIndex1",
        "a_appMagicLevel1",
        "a_appMagicIndex2",
        "a_appMagicLevel2",
        "a_appMagicIndex3",
        "a_appMagicLevel3",
        "a_magicIndex1",
        "a_magicLevel1",
        "a_magicIndex2",
        "a_magicLevel2",
        "a_magicIndex3",
        "a_magicLevel3",
        "a_learnstr",
        "a_learndex",
        "a_learnint",
        "a_learncon",
        "a_hate",
        "a_learnGP",
        "a_use_count",
        "a_targetNum"
                });
                textBox84.Text = strArray[0];
                textBox85.Text = strArray[1];
                textBox86.Text = strArray[2];
                textBox87.Text = strArray[3];
                textBox88.Text = strArray[4];
                textBox89.Text = strArray[5];
                textBox90.Text = strArray[6];
                textBox91.Text = strArray[7];
                textBox92.Text = strArray[8];
                textBox93.Text = strArray[9];
                textBox94.Text = strArray[10];
                textBox95.Text = strArray[11];
                textBox96.Text = strArray[12];
                textBox97.Text = strArray[13];
                textBox98.Text = strArray[14];
                textBox99.Text = strArray[15];
                textBox100.Text = strArray[16];
                textBox101.Text = strArray[17];
                textBox102.Text = strArray[18];
                tbNeedLearn1.Text = strArray[19];
                textBox104.Text = strArray[20];
                tbNeedLearn2.Text = strArray[21];
                textBox106.Text = strArray[22];
                tbNeedLearn3.Text = strArray[23];
                textBox108.Text = strArray[24];
                textBox109.Text = strArray[25];
                textBox110.Text = strArray[26];
                textBox111.Text = strArray[27];
                textBox112.Text = strArray[28];
                textBox113.Text = strArray[29];
                textBox114.Text = strArray[30];
                tbMagicIndex1.Text = strArray[31];
                tbMagicLevel1.Text = strArray[32];
                tbMagicIndex2.Text = strArray[33];
                tbMagicLevel2.Text = strArray[34];
                tbMagicIndex3.Text = strArray[35];
                tbMagicLevel3.Text = strArray[36];
                textBox121.Text = strArray[37];
                textBox122.Text = strArray[38];
                textBox123.Text = strArray[39];
                textBox124.Text = strArray[40];
                textBox125.Text = strArray[41];
                textBox126.Text = strArray[42];
                textBox127.Text = strArray[43];
                textBox128.Text = strArray[44];
                IconSkill();
                IconItem();
                ClearPicture();
                try
                {
                    pictureBox4.Image = (Image)databaseHandle.IconItem(int.Parse(textBox129.Text), int.Parse(textBox130.Text), int.Parse(textBox131.Text));
                    pictureBox5.Image = (Image)databaseHandle.IconItem(int.Parse(textBox133.Text), int.Parse(textBox134.Text), int.Parse(textBox135.Text));
                }
                catch
                {
                }
                try
                {
                    pictureBox6.Image = (Image)databaseHandle.IconSkill1(int.Parse(textBox137.Text), int.Parse(textBox138.Text), int.Parse(textBox139.Text));
                    pictureBox7.Image = (Image)databaseHandle.IconSkill1(int.Parse(textBox141.Text), int.Parse(textBox142.Text), int.Parse(textBox143.Text));
                    pictureBox8.Image = (Image)databaseHandle.IconSkill1(int.Parse(textBox145.Text), int.Parse(textBox146.Text), int.Parse(textBox147.Text));
                }
                catch
                {
                }
                try
                {
                    pbNeedItem1.Image = (Image)databaseHandle.IconItem(int.Parse(textBox150.Text), int.Parse(textBox151.Text), int.Parse(textBox152.Text));
                    pbNeedItem2.Image = (Image)databaseHandle.IconItem(int.Parse(textBox153.Text), int.Parse(textBox154.Text), int.Parse(textBox155.Text));
                    pbNeedItem3.Image = (Image)databaseHandle.IconItem(int.Parse(textBox157.Text), int.Parse(textBox158.Text), int.Parse(textBox159.Text));
                }
                catch
                {
                }
            }

    private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
    {
            comboBox20.Items.Clear();
            string str = GetIndexByComboBox(comboBox19.Text).ToString();
            comboBox20.Items.AddRange((object[])Types.JobSubTypes(Convert.ToInt32(str)));
            comboBox20.SelectedIndex = 0;
            mSortJob = str;
            LoadListBox();
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            mSortJob2 = GetIndexByComboBox(comboBox20.Text).ToString();
            LoadListBox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox91.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox93.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            tbNeedLearn2.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            tbNeedLearn3.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlags);

        
        
    private void button6_Click(object sender, EventArgs e)
    {
      string Query = "UPDATE t_skillLevel SET " + "a_needHP = '" + textBox86.Text + "'," + "a_needMP = '" + textBox87.Text + "'," + "a_needGP = '" + textBox88.Text + "'," + "a_durtime = '" + textBox89.Text + "'," + "a_dummypower = '" + textBox90.Text + "'," + "a_needItemIndex1 = '" + textBox91.Text + "'," + "a_needItemCount1 = '" + textBox92.Text + "'," + "a_needItemIndex2 = '" + textBox93.Text + "'," + "a_needItemCount2 = '" + textBox94.Text + "'," + "a_learnLevel = '" + textBox95.Text + "'," + "a_learnSP = '" + textBox96.Text + "'," + "a_learnSkillIndex1 = '" + textBox97.Text + "'," + "a_learnSkillLevel1 = '" + textBox98.Text + "'," + "a_learnSkillIndex2 = '" + textBox99.Text + "'," + "a_learnSkillLevel2 = '" + textBox100.Text + "'," + "a_learnSkillIndex3 = '" + textBox101.Text + "'," + "a_learnSkillLevel3 = '" + textBox102.Text + "'," + "a_learnItemIndex1 = '" + tbNeedLearn1.Text + "'," + "a_learnItemCount1 = '" + textBox104.Text + "'," + "a_learnItemIndex2 = '" + tbNeedLearn2.Text + "'," + "a_learnItemCount2 = '" + textBox106.Text + "'," + "a_learnItemIndex3 = '" + tbNeedLearn3.Text + "'," + "a_learnItemCount3 = '" + textBox108.Text + "'," + "a_appMagicIndex1 = '" + textBox109.Text + "'," + "a_appMagicLevel1 = '" + textBox110.Text + "'," + "a_appMagicIndex2 = '" + textBox111.Text + "'," + "a_appMagicLevel2 = '" + textBox112.Text + "'," + "a_appMagicIndex3 = '" + textBox113.Text + "'," + "a_appMagicLevel3 = '" + textBox114.Text + "'," + "a_magicIndex1 = '" + tbMagicIndex1.Text + "'," + "a_magicLevel1 = '" + tbMagicLevel1.Text + "'," + "a_magicIndex2 = '" + tbMagicIndex2.Text + "'," + "a_magicLevel2 = '" + tbMagicLevel2.Text + "'," + "a_magicIndex3 = '" + tbMagicIndex3.Text + "'," + "a_magicLevel3 = '" + tbMagicLevel3.Text + "'," + "a_learnstr = '" + textBox121.Text + "'," + "a_learndex = '" + textBox122.Text + "'," + "a_learnint = '" + textBox123.Text + "'," + "a_learncon = '" + textBox124.Text + "'," + "a_hate = '" + textBox125.Text + "'," + "a_learnGP = '" + textBox126.Text + "'," + "a_use_count = '" + textBox127.Text + "'," + "a_targetNum = '" + textBox128.Text + "'" + "WHERE a_index = '" + textBox1.Text + "' AND a_level = '" + textBox85.Text + "'";
      Console.WriteLine(Query);
            databaseHandle.SendQueryMySql(Host, User, Password, Database, Query);
            LoadListBox2();
            label130.Text = "Save level succesfully!";
            label130.ForeColor = Color.Lime;
            label130.Visible = true;
            listBox2.SelectedIndex = listBox2.SelectedIndex;
    }

    private void button4_Click_1(object sender, EventArgs e)
    {
        try {
                using (MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database))
                {
                    MySqlCommand mySqlCommand = new MySqlCommand();
                    mySqlConnection.Open();
                    mySqlCommand.Connection = mySqlConnection;
                    string str = "INSERT INTO t_skillLevel (" + "a_index, " + "a_level ," + "a_needItemIndex1 ," + "a_needItemIndex2 ," + "a_learnSkillIndex1 ," + "a_learnSkillIndex2 ," + "a_learnSkillIndex3 ," + "a_learnItemIndex1 ," + "a_learnItemIndex2 ," + "a_learnItemIndex3 ," + "a_magicIndex1 ," + "a_magicLevel1 ," + "a_magicIndex2 ," + "a_magicLevel2 ," + "a_magicIndex3 ," + "a_magicLevel3 , " + "a_targetNum" + ")" + "VALUES ("  + "@index ," + "@level ," + "@needItemIdx1 ," + "@needItemIdx2 ," + "@learnSkillIdx1 ," + "@learnSkillIdx2 ," + "@learnSkillIdx3 ," + "@learnItemIdx1 ," + "@learnItemIdx2 ," + "@learnItemIdx3 ," + "@magicIdx1 ," + "@magicLevel1 ," + "@magicIdx2 ," + "@magicLevel2 ," + "@magicIdx3 ," + "@magicLevel3 ," + "@targetnum " + ")";
                    mySqlCommand.CommandText = str;
                    mySqlCommand.Prepare();
                    mySqlCommand.Parameters.AddWithValue("@index", int.Parse(textBox1.Text));
                    mySqlCommand.Parameters.AddWithValue("@level", listBox2.Items.Count + 1);
                    mySqlCommand.Parameters.AddWithValue("@needItemIdx1", -1);
                    mySqlCommand.Parameters.AddWithValue("@needItemIdx2", -1);
                    mySqlCommand.Parameters.AddWithValue("@learnSkillIdx1", -1);
                    mySqlCommand.Parameters.AddWithValue("@learnSkillIdx2", -1);
                    mySqlCommand.Parameters.AddWithValue("@learnSkillIdx3", -1);
                    mySqlCommand.Parameters.AddWithValue("@learnItemIdx1", -1);
                    mySqlCommand.Parameters.AddWithValue("@learnItemIdx2", -1);
                    mySqlCommand.Parameters.AddWithValue("@learnItemIdx3", -1);
                    mySqlCommand.Parameters.AddWithValue("@magicIdx1", tbMagicIndex1.Text);
                    mySqlCommand.Parameters.AddWithValue("@magicLevel1", tbMagicLevel1.Text);
                    mySqlCommand.Parameters.AddWithValue("@magicIdx2", tbMagicIndex2.Text);
                    mySqlCommand.Parameters.AddWithValue("@magicLevel2", tbMagicLevel2.Text);
                    mySqlCommand.Parameters.AddWithValue("@magicIdx3", tbMagicIndex3.Text);
                    mySqlCommand.Parameters.AddWithValue("@magicLevel3", tbMagicLevel3.Text);
                    mySqlCommand.Parameters.AddWithValue("@targetnum", 1);

                    mySqlCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                }
                LoadListBox2();
                listBox2.SelectedIndex = listBox2.Items.Count - 1;
            }

            catch(MySqlException ex){
                int num = (int)MessageBox.Show(ex.Message.ToString());
            }
    }

    private void button5_Click_1(object sender, EventArgs e)
    {
      string Query = "DELETE FROM t_skillLevel WHERE a_index = '" + textBox1.Text + "' AND a_level ='" + textBox85.Text + "'";
      Console.WriteLine(Query);
            databaseHandle.SendQueryMySql(Host, User, Password, Database, Query);
            LoadListBox2();
            listBox2.SelectedIndex = listBox2.Items.Count - 1;
    }

    private void pictureBox6_Click(object sender, EventArgs e)
    {
      SkillPicker skillPicker = new SkillPicker();
      if (skillPicker.ShowDialog() != DialogResult.OK)
        return;
            textBox97.Text = Convert.ToString(skillPicker.SkillIndex);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkillEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSkilllodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportStrSkillsusalodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mYSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sKILLSCOST0SPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sKILLSREQUIRENOITEMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sKILLSREQUIRENOITEMLEARNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CBPet = new System.Windows.Forms.ComboBox();
            this.label132 = new System.Windows.Forms.Label();
            this.label139 = new System.Windows.Forms.Label();
            this.label138 = new System.Windows.Forms.Label();
            this.comboBox19 = new System.Windows.Forms.ComboBox();
            this.comboBox20 = new System.Windows.Forms.ComboBox();
            this.textBox203 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbmaxLevel = new System.Windows.Forms.TextBox();
            this.label140 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.label115 = new System.Windows.Forms.Label();
            this.textBox114 = new System.Windows.Forms.TextBox();
            this.label114 = new System.Windows.Forms.Label();
            this.textBox113 = new System.Windows.Forms.TextBox();
            this.label113 = new System.Windows.Forms.Label();
            this.textBox112 = new System.Windows.Forms.TextBox();
            this.label112 = new System.Windows.Forms.Label();
            this.textBox111 = new System.Windows.Forms.TextBox();
            this.label111 = new System.Windows.Forms.Label();
            this.textBox110 = new System.Windows.Forms.TextBox();
            this.label110 = new System.Windows.Forms.Label();
            this.textBox109 = new System.Windows.Forms.TextBox();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label142 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label134 = new System.Windows.Forms.Label();
            this.label133 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox128 = new System.Windows.Forms.TextBox();
            this.textBox85 = new System.Windows.Forms.TextBox();
            this.label129 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.textBox89 = new System.Windows.Forms.TextBox();
            this.label90 = new System.Windows.Forms.Label();
            this.textBox90 = new System.Windows.Forms.TextBox();
            this.label91 = new System.Windows.Forms.Label();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.label128 = new System.Windows.Forms.Label();
            this.textBox127 = new System.Windows.Forms.TextBox();
            this.label127 = new System.Windows.Forms.Label();
            this.textBox126 = new System.Windows.Forms.TextBox();
            this.label126 = new System.Windows.Forms.Label();
            this.textBox125 = new System.Windows.Forms.TextBox();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.textBox124 = new System.Windows.Forms.TextBox();
            this.textBox123 = new System.Windows.Forms.TextBox();
            this.textBox122 = new System.Windows.Forms.TextBox();
            this.textBox121 = new System.Windows.Forms.TextBox();
            this.label125 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.label122 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.textBox108 = new System.Windows.Forms.TextBox();
            this.label108 = new System.Windows.Forms.Label();
            this.textBox106 = new System.Windows.Forms.TextBox();
            this.label107 = new System.Windows.Forms.Label();
            this.textBox104 = new System.Windows.Forms.TextBox();
            this.tbNeedLearn3 = new System.Windows.Forms.TextBox();
            this.label106 = new System.Windows.Forms.Label();
            this.tbNeedLearn2 = new System.Windows.Forms.TextBox();
            this.label105 = new System.Windows.Forms.Label();
            this.tbNeedLearn1 = new System.Windows.Forms.TextBox();
            this.label104 = new System.Windows.Forms.Label();
            this.textBox102 = new System.Windows.Forms.TextBox();
            this.label103 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.textBox101 = new System.Windows.Forms.TextBox();
            this.textBox100 = new System.Windows.Forms.TextBox();
            this.label101 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.textBox99 = new System.Windows.Forms.TextBox();
            this.textBox98 = new System.Windows.Forms.TextBox();
            this.label99 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.textBox97 = new System.Windows.Forms.TextBox();
            this.label97 = new System.Windows.Forms.Label();
            this.textBox96 = new System.Windows.Forms.TextBox();
            this.label96 = new System.Windows.Forms.Label();
            this.textBox95 = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pbNeedItem1 = new System.Windows.Forms.PictureBox();
            this.pbNeedItem2 = new System.Windows.Forms.PictureBox();
            this.pbNeedItem3 = new System.Windows.Forms.PictureBox();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.PbMagicIdx3 = new System.Windows.Forms.PictureBox();
            this.PbMagicIdx2 = new System.Windows.Forms.PictureBox();
            this.PbMagicIdx1 = new System.Windows.Forms.PictureBox();
            this.tbMagicLevel3 = new System.Windows.Forms.TextBox();
            this.label121 = new System.Windows.Forms.Label();
            this.tbMagicIndex3 = new System.Windows.Forms.TextBox();
            this.label120 = new System.Windows.Forms.Label();
            this.tbMagicLevel2 = new System.Windows.Forms.TextBox();
            this.label119 = new System.Windows.Forms.Label();
            this.tbMagicIndex2 = new System.Windows.Forms.TextBox();
            this.label118 = new System.Windows.Forms.Label();
            this.tbMagicLevel1 = new System.Windows.Forms.TextBox();
            this.label117 = new System.Windows.Forms.Label();
            this.tbMagicIndex1 = new System.Windows.Forms.TextBox();
            this.label116 = new System.Windows.Forms.Label();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.label95 = new System.Windows.Forms.Label();
            this.textBox94 = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label94 = new System.Windows.Forms.Label();
            this.textBox93 = new System.Windows.Forms.TextBox();
            this.label93 = new System.Windows.Forms.Label();
            this.textBox92 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label92 = new System.Windows.Forms.Label();
            this.textBox91 = new System.Windows.Forms.TextBox();
            this.label89 = new System.Windows.Forms.Label();
            this.textBox88 = new System.Windows.Forms.TextBox();
            this.textBox87 = new System.Windows.Forms.TextBox();
            this.label88 = new System.Windows.Forms.Label();
            this.textBox86 = new System.Windows.Forms.TextBox();
            this.label87 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnCopyLevel = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox136 = new System.Windows.Forms.TextBox();
            this.textBox132 = new System.Windows.Forms.TextBox();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label75 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox18 = new System.Windows.Forms.ComboBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.comboBox17 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.comboBox16 = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label82 = new System.Windows.Forms.Label();
            this.textBox81 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label78 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PbUseState = new System.Windows.Forms.PictureBox();
            this.PbAppState = new System.Windows.Forms.PictureBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox82 = new System.Windows.Forms.TextBox();
            this.label83 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.textBox76 = new System.Windows.Forms.TextBox();
            this.textBox75 = new System.Windows.Forms.TextBox();
            this.textBox74 = new System.Windows.Forms.TextBox();
            this.textBox73 = new System.Windows.Forms.TextBox();
            this.textBox72 = new System.Windows.Forms.TextBox();
            this.textBox71 = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.textBox70 = new System.Windows.Forms.TextBox();
            this.textBox69 = new System.Windows.Forms.TextBox();
            this.textBox68 = new System.Windows.Forms.TextBox();
            this.textBox67 = new System.Windows.Forms.TextBox();
            this.textBox66 = new System.Windows.Forms.TextBox();
            this.textBox65 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.textBox59 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.textBox58 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox160 = new System.Windows.Forms.TextBox();
            this.textBox156 = new System.Windows.Forms.TextBox();
            this.textBox157 = new System.Windows.Forms.TextBox();
            this.textBox159 = new System.Windows.Forms.TextBox();
            this.textBox153 = new System.Windows.Forms.TextBox();
            this.textBox154 = new System.Windows.Forms.TextBox();
            this.textBox155 = new System.Windows.Forms.TextBox();
            this.textBox149 = new System.Windows.Forms.TextBox();
            this.textBox150 = new System.Windows.Forms.TextBox();
            this.textBox151 = new System.Windows.Forms.TextBox();
            this.textBox152 = new System.Windows.Forms.TextBox();
            this.textBox158 = new System.Windows.Forms.TextBox();
            this.textBox145 = new System.Windows.Forms.TextBox();
            this.textBox146 = new System.Windows.Forms.TextBox();
            this.textBox147 = new System.Windows.Forms.TextBox();
            this.label137 = new System.Windows.Forms.Label();
            this.textBox141 = new System.Windows.Forms.TextBox();
            this.textBox142 = new System.Windows.Forms.TextBox();
            this.textBox143 = new System.Windows.Forms.TextBox();
            this.label136 = new System.Windows.Forms.Label();
            this.textBox129 = new System.Windows.Forms.TextBox();
            this.textBox133 = new System.Windows.Forms.TextBox();
            this.textBox137 = new System.Windows.Forms.TextBox();
            this.textBox138 = new System.Windows.Forms.TextBox();
            this.textBox139 = new System.Windows.Forms.TextBox();
            this.textBox84 = new System.Windows.Forms.TextBox();
            this.textBox134 = new System.Windows.Forms.TextBox();
            this.textBox135 = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.textBox130 = new System.Windows.Forms.TextBox();
            this.textBox131 = new System.Windows.Forms.TextBox();
            this.label135 = new System.Windows.Forms.Label();
            this.textBox148 = new System.Windows.Forms.TextBox();
            this.textBox140 = new System.Windows.Forms.TextBox();
            this.textBox144 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label84 = new System.Windows.Forms.Label();
            this.textBox83 = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.textBox80 = new System.Windows.Forms.TextBox();
            this.label80 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.textBox79 = new System.Windows.Forms.TextBox();
            this.label77 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox78 = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.textBox77 = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label130 = new System.Windows.Forms.Label();
            this.label131 = new System.Windows.Forms.Label();
            this.lblLang = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSaveAndNext = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox26.SuspendLayout();
            this.groupBox30.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeedItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeedItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeedItem3)).BeginInit();
            this.groupBox27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMagicIdx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMagicIdx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMagicIdx1)).BeginInit();
            this.groupBox23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox21.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbUseState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAppState)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileExportToolStripMenuItem,
            this.mYSQLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1346, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileExportToolStripMenuItem
            // 
            this.fileExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportSkilllodToolStripMenuItem,
            this.exportStrSkillsusalodToolStripMenuItem});
            this.fileExportToolStripMenuItem.Name = "fileExportToolStripMenuItem";
            this.fileExportToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.fileExportToolStripMenuItem.Text = "File Export";
            // 
            // exportSkilllodToolStripMenuItem
            // 
            this.exportSkilllodToolStripMenuItem.Name = "exportSkilllodToolStripMenuItem";
            this.exportSkilllodToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.exportSkilllodToolStripMenuItem.Text = "Export skills.lod";
            this.exportSkilllodToolStripMenuItem.Click += new System.EventHandler(this.exportSkilllodToolStripMenuItem_Click);
            // 
            // exportStrSkillsusalodToolStripMenuItem
            // 
            this.exportStrSkillsusalodToolStripMenuItem.Name = "exportStrSkillsusalodToolStripMenuItem";
            this.exportStrSkillsusalodToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.exportStrSkillsusalodToolStripMenuItem.Text = "Export strSkills_usa.lod";
            this.exportStrSkillsusalodToolStripMenuItem.Click += new System.EventHandler(this.exportStrSkillsusalodToolStripMenuItem_Click);
            // 
            // mYSQLToolStripMenuItem
            // 
            this.mYSQLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sKILLSCOST0SPToolStripMenuItem,
            this.sKILLSREQUIRENOITEMSToolStripMenuItem,
            this.sKILLSREQUIRENOITEMLEARNToolStripMenuItem});
            this.mYSQLToolStripMenuItem.Name = "mYSQLToolStripMenuItem";
            this.mYSQLToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.mYSQLToolStripMenuItem.Text = "MYSQL";
            // 
            // sKILLSCOST0SPToolStripMenuItem
            // 
            this.sKILLSCOST0SPToolStripMenuItem.Name = "sKILLSCOST0SPToolStripMenuItem";
            this.sKILLSCOST0SPToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.sKILLSCOST0SPToolStripMenuItem.Text = "SKILLS COST 0 SP";
            this.sKILLSCOST0SPToolStripMenuItem.Click += new System.EventHandler(this.SKILLSCOST0SPToolStripMenuItem_Click);
            // 
            // sKILLSREQUIRENOITEMSToolStripMenuItem
            // 
            this.sKILLSREQUIRENOITEMSToolStripMenuItem.Name = "sKILLSREQUIRENOITEMSToolStripMenuItem";
            this.sKILLSREQUIRENOITEMSToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.sKILLSREQUIRENOITEMSToolStripMenuItem.Text = "SKILLS REQUIRE NO ITEMS CAST";
            this.sKILLSREQUIRENOITEMSToolStripMenuItem.Click += new System.EventHandler(this.SKILLSREQUIRENOITEMSToolStripMenuItem_Click);
            // 
            // sKILLSREQUIRENOITEMLEARNToolStripMenuItem
            // 
            this.sKILLSREQUIRENOITEMLEARNToolStripMenuItem.Name = "sKILLSREQUIRENOITEMLEARNToolStripMenuItem";
            this.sKILLSREQUIRENOITEMLEARNToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.sKILLSREQUIRENOITEMLEARNToolStripMenuItem.Text = "SKILLS REQUIRE NO ITEM LEARN";
            this.sKILLSREQUIRENOITEMLEARNToolStripMenuItem.Click += new System.EventHandler(this.SKILLSREQUIRENOITEMLEARNToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCopy);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 542);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Skills";
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(92, 517);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(70, 24);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(177, 517);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 24);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 498);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CBPet);
            this.groupBox5.Controls.Add(this.label132);
            this.groupBox5.Controls.Add(this.label139);
            this.groupBox5.Controls.Add(this.label138);
            this.groupBox5.Controls.Add(this.comboBox19);
            this.groupBox5.Controls.Add(this.comboBox20);
            this.groupBox5.Controls.Add(this.textBox203);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(12, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(265, 120);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search";
            // 
            // CBPet
            // 
            this.CBPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBPet.FormattingEnabled = true;
            this.CBPet.Location = new System.Drawing.Point(43, 95);
            this.CBPet.Name = "CBPet";
            this.CBPet.Size = new System.Drawing.Size(204, 21);
            this.CBPet.TabIndex = 54;
            this.CBPet.SelectedIndexChanged += new System.EventHandler(this.CBPet_SelectedIndexChanged);
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.Location = new System.Drawing.Point(6, 99);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(26, 13);
            this.label132.TabIndex = 53;
            this.label132.Text = "Pet:";
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.Location = new System.Drawing.Point(6, 73);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(27, 13);
            this.label139.TabIndex = 52;
            this.label139.Text = "Job:";
            // 
            // label138
            // 
            this.label138.AutoSize = true;
            this.label138.Location = new System.Drawing.Point(6, 48);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(35, 13);
            this.label138.TabIndex = 51;
            this.label138.Text = "Class:";
            // 
            // comboBox19
            // 
            this.comboBox19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox19.FormattingEnabled = true;
            this.comboBox19.Location = new System.Drawing.Point(43, 43);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Size = new System.Drawing.Size(204, 21);
            this.comboBox19.TabIndex = 50;
            this.comboBox19.SelectedIndexChanged += new System.EventHandler(this.comboBox19_SelectedIndexChanged);
            // 
            // comboBox20
            // 
            this.comboBox20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox20.FormattingEnabled = true;
            this.comboBox20.Location = new System.Drawing.Point(43, 70);
            this.comboBox20.Name = "comboBox20";
            this.comboBox20.Size = new System.Drawing.Size(204, 21);
            this.comboBox20.TabIndex = 49;
            this.comboBox20.SelectedIndexChanged += new System.EventHandler(this.comboBox20_SelectedIndexChanged);
            // 
            // textBox203
            // 
            this.textBox203.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox203.Location = new System.Drawing.Point(43, 18);
            this.textBox203.Name = "textBox203";
            this.textBox203.Size = new System.Drawing.Size(204, 20);
            this.textBox203.TabIndex = 22;
            this.textBox203.TextChanged += new System.EventHandler(this.textBox203_TextChanged);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(283, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1049, 624);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.tbmaxLevel);
            this.tabPage1.Controls.Add(this.label140);
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.textBox136);
            this.tabPage1.Controls.Add(this.textBox132);
            this.tabPage1.Controls.Add(this.groupBox22);
            this.tabPage1.Controls.Add(this.groupBox21);
            this.tabPage1.Controls.Add(this.groupBox8);
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
            this.tabPage1.Size = new System.Drawing.Size(1041, 598);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic";
            // 
            // tbmaxLevel
            // 
            this.tbmaxLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbmaxLevel.Location = new System.Drawing.Point(482, 299);
            this.tbmaxLevel.Name = "tbmaxLevel";
            this.tbmaxLevel.Size = new System.Drawing.Size(46, 20);
            this.tbmaxLevel.TabIndex = 58;
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Location = new System.Drawing.Point(412, 301);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(64, 13);
            this.label140.TabIndex = 59;
            this.label140.Text = "a_maxLevel";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(2, 333);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1035, 261);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Controls.Add(this.groupBox26);
            this.tabPage5.Controls.Add(this.groupBox30);
            this.tabPage5.Controls.Add(this.groupBox25);
            this.tabPage5.Controls.Add(this.groupBox27);
            this.tabPage5.Controls.Add(this.groupBox23);
            this.tabPage5.Controls.Add(this.groupBox7);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1027, 235);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Skill Levels";
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.label115);
            this.groupBox26.Controls.Add(this.textBox114);
            this.groupBox26.Controls.Add(this.label114);
            this.groupBox26.Controls.Add(this.textBox113);
            this.groupBox26.Controls.Add(this.label113);
            this.groupBox26.Controls.Add(this.textBox112);
            this.groupBox26.Controls.Add(this.label112);
            this.groupBox26.Controls.Add(this.textBox111);
            this.groupBox26.Controls.Add(this.label111);
            this.groupBox26.Controls.Add(this.textBox110);
            this.groupBox26.Controls.Add(this.label110);
            this.groupBox26.Controls.Add(this.textBox109);
            this.groupBox26.Location = new System.Drawing.Point(834, 8);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(187, 93);
            this.groupBox26.TabIndex = 15;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "App Magic Index";
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(98, 68);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(36, 13);
            this.label115.TabIndex = 11;
            this.label115.Text = "Level:";
            // 
            // textBox114
            // 
            this.textBox114.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox114.Location = new System.Drawing.Point(140, 64);
            this.textBox114.Name = "textBox114";
            this.textBox114.Size = new System.Drawing.Size(40, 20);
            this.textBox114.TabIndex = 10;
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(8, 68);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(36, 13);
            this.label114.TabIndex = 9;
            this.label114.Text = "Index:";
            // 
            // textBox113
            // 
            this.textBox113.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox113.Location = new System.Drawing.Point(48, 64);
            this.textBox113.Name = "textBox113";
            this.textBox113.Size = new System.Drawing.Size(38, 20);
            this.textBox113.TabIndex = 8;
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(98, 42);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(36, 13);
            this.label113.TabIndex = 7;
            this.label113.Text = "Level:";
            // 
            // textBox112
            // 
            this.textBox112.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox112.Location = new System.Drawing.Point(140, 40);
            this.textBox112.Name = "textBox112";
            this.textBox112.Size = new System.Drawing.Size(40, 20);
            this.textBox112.TabIndex = 6;
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(6, 42);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(36, 13);
            this.label112.TabIndex = 5;
            this.label112.Text = "Index:";
            // 
            // textBox111
            // 
            this.textBox111.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox111.Location = new System.Drawing.Point(48, 40);
            this.textBox111.Name = "textBox111";
            this.textBox111.Size = new System.Drawing.Size(38, 20);
            this.textBox111.TabIndex = 4;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(98, 16);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(36, 13);
            this.label111.TabIndex = 3;
            this.label111.Text = "Level:";
            // 
            // textBox110
            // 
            this.textBox110.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox110.Location = new System.Drawing.Point(140, 14);
            this.textBox110.Name = "textBox110";
            this.textBox110.Size = new System.Drawing.Size(40, 20);
            this.textBox110.TabIndex = 2;
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(6, 16);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(36, 13);
            this.label110.TabIndex = 1;
            this.label110.Text = "Index:";
            // 
            // textBox109
            // 
            this.textBox109.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox109.Location = new System.Drawing.Point(48, 14);
            this.textBox109.Name = "textBox109";
            this.textBox109.Size = new System.Drawing.Size(38, 20);
            this.textBox109.TabIndex = 0;
            // 
            // groupBox30
            // 
            this.groupBox30.Controls.Add(this.button16);
            this.groupBox30.Controls.Add(this.button13);
            this.groupBox30.Controls.Add(this.button14);
            this.groupBox30.Controls.Add(this.button15);
            this.groupBox30.Controls.Add(this.label142);
            this.groupBox30.Controls.Add(this.button12);
            this.groupBox30.Controls.Add(this.button11);
            this.groupBox30.Controls.Add(this.button10);
            this.groupBox30.Controls.Add(this.label134);
            this.groupBox30.Controls.Add(this.label133);
            this.groupBox30.Controls.Add(this.button9);
            this.groupBox30.Controls.Add(this.button8);
            this.groupBox30.Controls.Add(this.button7);
            this.groupBox30.Controls.Add(this.textBox128);
            this.groupBox30.Controls.Add(this.textBox85);
            this.groupBox30.Controls.Add(this.label129);
            this.groupBox30.Controls.Add(this.label86);
            this.groupBox30.Controls.Add(this.textBox89);
            this.groupBox30.Controls.Add(this.label90);
            this.groupBox30.Controls.Add(this.textBox90);
            this.groupBox30.Controls.Add(this.label91);
            this.groupBox30.Location = new System.Drawing.Point(134, 6);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new System.Drawing.Size(236, 113);
            this.groupBox30.TabIndex = 60;
            this.groupBox30.TabStop = false;
            this.groupBox30.Text = "Basic";
            // 
            // button16
            // 
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(135, 88);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(29, 22);
            this.button16.TabIndex = 69;
            this.button16.Text = "7";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.Button16_Click);
            // 
            // button13
            // 
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(107, 88);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(29, 22);
            this.button13.TabIndex = 68;
            this.button13.Text = "6";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Button13_Click);
            // 
            // button14
            // 
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(79, 88);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(29, 22);
            this.button14.TabIndex = 67;
            this.button14.Text = "3";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Button14_Click);
            // 
            // button15
            // 
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(57, 88);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(23, 22);
            this.button15.TabIndex = 66;
            this.button15.Text = "2";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Button15_Click);
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.Location = new System.Drawing.Point(12, 92);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(38, 13);
            this.label142.TabIndex = 65;
            this.label142.Text = "Hours:";
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(210, 63);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(23, 22);
            this.button12.TabIndex = 64;
            this.button12.Text = "7";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(189, 63);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(22, 22);
            this.button11.TabIndex = 63;
            this.button11.Text = "3";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(168, 63);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(22, 22);
            this.button10.TabIndex = 62;
            this.button10.Text = "1";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.Location = new System.Drawing.Point(137, 68);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(34, 13);
            this.label134.TabIndex = 61;
            this.label134.Text = "Days:";
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.Location = new System.Drawing.Point(6, 69);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(47, 13);
            this.label133.TabIndex = 60;
            this.label133.Text = "Minutes:";
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(107, 64);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(29, 22);
            this.button9.TabIndex = 59;
            this.button9.Text = "60";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(79, 64);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(29, 22);
            this.button8.TabIndex = 58;
            this.button8.Text = "30";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(57, 64);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(23, 22);
            this.button7.TabIndex = 4;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // textBox128
            // 
            this.textBox128.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox128.Location = new System.Drawing.Point(172, 12);
            this.textBox128.Name = "textBox128";
            this.textBox128.Size = new System.Drawing.Size(58, 20);
            this.textBox128.TabIndex = 57;
            // 
            // textBox85
            // 
            this.textBox85.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox85.Location = new System.Drawing.Point(71, 12);
            this.textBox85.Name = "textBox85";
            this.textBox85.Size = new System.Drawing.Size(28, 20);
            this.textBox85.TabIndex = 3;
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Location = new System.Drawing.Point(125, 14);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(41, 13);
            this.label129.TabIndex = 56;
            this.label129.Text = "Target:";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(6, 14);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(36, 13);
            this.label86.TabIndex = 4;
            this.label86.Text = "Level:";
            // 
            // textBox89
            // 
            this.textBox89.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox89.Location = new System.Drawing.Point(172, 39);
            this.textBox89.Name = "textBox89";
            this.textBox89.Size = new System.Drawing.Size(59, 20);
            this.textBox89.TabIndex = 11;
            this.toolTip1.SetToolTip(this.textBox89, "10 duration is 1 second actual time");
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(125, 41);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(33, 13);
            this.label90.TabIndex = 12;
            this.label90.Text = "Dure:";
            // 
            // textBox90
            // 
            this.textBox90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox90.Location = new System.Drawing.Point(54, 39);
            this.textBox90.Name = "textBox90";
            this.textBox90.Size = new System.Drawing.Size(62, 20);
            this.textBox90.TabIndex = 14;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(6, 41);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(40, 13);
            this.label91.TabIndex = 13;
            this.label91.Text = "Power:";
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.label128);
            this.groupBox25.Controls.Add(this.textBox127);
            this.groupBox25.Controls.Add(this.label127);
            this.groupBox25.Controls.Add(this.textBox126);
            this.groupBox25.Controls.Add(this.label126);
            this.groupBox25.Controls.Add(this.textBox125);
            this.groupBox25.Controls.Add(this.groupBox28);
            this.groupBox25.Controls.Add(this.label109);
            this.groupBox25.Controls.Add(this.textBox108);
            this.groupBox25.Controls.Add(this.label108);
            this.groupBox25.Controls.Add(this.textBox106);
            this.groupBox25.Controls.Add(this.label107);
            this.groupBox25.Controls.Add(this.textBox104);
            this.groupBox25.Controls.Add(this.tbNeedLearn3);
            this.groupBox25.Controls.Add(this.label106);
            this.groupBox25.Controls.Add(this.tbNeedLearn2);
            this.groupBox25.Controls.Add(this.label105);
            this.groupBox25.Controls.Add(this.tbNeedLearn1);
            this.groupBox25.Controls.Add(this.label104);
            this.groupBox25.Controls.Add(this.textBox102);
            this.groupBox25.Controls.Add(this.label103);
            this.groupBox25.Controls.Add(this.label102);
            this.groupBox25.Controls.Add(this.textBox101);
            this.groupBox25.Controls.Add(this.textBox100);
            this.groupBox25.Controls.Add(this.label101);
            this.groupBox25.Controls.Add(this.label100);
            this.groupBox25.Controls.Add(this.textBox99);
            this.groupBox25.Controls.Add(this.textBox98);
            this.groupBox25.Controls.Add(this.label99);
            this.groupBox25.Controls.Add(this.label98);
            this.groupBox25.Controls.Add(this.textBox97);
            this.groupBox25.Controls.Add(this.label97);
            this.groupBox25.Controls.Add(this.textBox96);
            this.groupBox25.Controls.Add(this.label96);
            this.groupBox25.Controls.Add(this.textBox95);
            this.groupBox25.Controls.Add(this.pictureBox6);
            this.groupBox25.Controls.Add(this.pictureBox7);
            this.groupBox25.Controls.Add(this.pictureBox8);
            this.groupBox25.Controls.Add(this.pbNeedItem1);
            this.groupBox25.Controls.Add(this.pbNeedItem2);
            this.groupBox25.Controls.Add(this.pbNeedItem3);
            this.groupBox25.Location = new System.Drawing.Point(134, 122);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(880, 107);
            this.groupBox25.TabIndex = 14;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Needed to Learn Skill";
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.Location = new System.Drawing.Point(10, 77);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(57, 13);
            this.label128.TabIndex = 55;
            this.label128.Text = "UseCount:";
            // 
            // textBox127
            // 
            this.textBox127.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox127.Location = new System.Drawing.Point(77, 75);
            this.textBox127.Name = "textBox127";
            this.textBox127.Size = new System.Drawing.Size(100, 20);
            this.textBox127.TabIndex = 54;
            // 
            // label127
            // 
            this.label127.AutoSize = true;
            this.label127.Location = new System.Drawing.Point(97, 53);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(25, 13);
            this.label127.TabIndex = 53;
            this.label127.Text = "GP:";
            // 
            // textBox126
            // 
            this.textBox126.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox126.Location = new System.Drawing.Point(128, 51);
            this.textBox126.Name = "textBox126";
            this.textBox126.Size = new System.Drawing.Size(49, 20);
            this.textBox126.TabIndex = 52;
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.Location = new System.Drawing.Point(10, 62);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(33, 13);
            this.label126.TabIndex = 51;
            this.label126.Text = "Hate:";
            // 
            // textBox125
            // 
            this.textBox125.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox125.Location = new System.Drawing.Point(52, 49);
            this.textBox125.Name = "textBox125";
            this.textBox125.Size = new System.Drawing.Size(29, 20);
            this.textBox125.TabIndex = 50;
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.textBox124);
            this.groupBox28.Controls.Add(this.textBox123);
            this.groupBox28.Controls.Add(this.textBox122);
            this.groupBox28.Controls.Add(this.textBox121);
            this.groupBox28.Controls.Add(this.label125);
            this.groupBox28.Controls.Add(this.label124);
            this.groupBox28.Controls.Add(this.label123);
            this.groupBox28.Controls.Add(this.label122);
            this.groupBox28.Location = new System.Drawing.Point(700, 7);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(154, 97);
            this.groupBox28.TabIndex = 49;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Stats Needed";
            // 
            // textBox124
            // 
            this.textBox124.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox124.Location = new System.Drawing.Point(119, 52);
            this.textBox124.Name = "textBox124";
            this.textBox124.Size = new System.Drawing.Size(28, 20);
            this.textBox124.TabIndex = 7;
            // 
            // textBox123
            // 
            this.textBox123.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox123.Location = new System.Drawing.Point(42, 52);
            this.textBox123.Name = "textBox123";
            this.textBox123.Size = new System.Drawing.Size(28, 20);
            this.textBox123.TabIndex = 6;
            // 
            // textBox122
            // 
            this.textBox122.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox122.Location = new System.Drawing.Point(120, 26);
            this.textBox122.Name = "textBox122";
            this.textBox122.Size = new System.Drawing.Size(28, 20);
            this.textBox122.TabIndex = 5;
            // 
            // textBox121
            // 
            this.textBox121.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox121.Location = new System.Drawing.Point(42, 27);
            this.textBox121.Name = "textBox121";
            this.textBox121.Size = new System.Drawing.Size(28, 20);
            this.textBox121.TabIndex = 4;
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(85, 56);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(32, 13);
            this.label125.TabIndex = 3;
            this.label125.Text = "Cont:";
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(8, 56);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(22, 13);
            this.label124.TabIndex = 2;
            this.label124.Text = "Int:";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(85, 30);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(29, 13);
            this.label123.TabIndex = 1;
            this.label123.Text = "Dex:";
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(7, 30);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(23, 13);
            this.label122.TabIndex = 0;
            this.label122.Text = "Str:";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(474, 79);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(26, 13);
            this.label109.TabIndex = 48;
            this.label109.Text = "Cnt:";
            // 
            // textBox108
            // 
            this.textBox108.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox108.Location = new System.Drawing.Point(504, 77);
            this.textBox108.Name = "textBox108";
            this.textBox108.Size = new System.Drawing.Size(157, 20);
            this.textBox108.TabIndex = 47;
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(477, 53);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(26, 13);
            this.label108.TabIndex = 46;
            this.label108.Text = "Cnt:";
            // 
            // textBox106
            // 
            this.textBox106.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox106.Location = new System.Drawing.Point(504, 51);
            this.textBox106.Name = "textBox106";
            this.textBox106.Size = new System.Drawing.Size(157, 20);
            this.textBox106.TabIndex = 45;
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(477, 28);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(26, 13);
            this.label107.TabIndex = 44;
            this.label107.Text = "Cnt:";
            // 
            // textBox104
            // 
            this.textBox104.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox104.Location = new System.Drawing.Point(504, 25);
            this.textBox104.Name = "textBox104";
            this.textBox104.Size = new System.Drawing.Size(157, 20);
            this.textBox104.TabIndex = 43;
            // 
            // tbNeedLearn3
            // 
            this.tbNeedLearn3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNeedLearn3.Location = new System.Drawing.Point(428, 77);
            this.tbNeedLearn3.Name = "tbNeedLearn3";
            this.tbNeedLearn3.Size = new System.Drawing.Size(43, 20);
            this.tbNeedLearn3.TabIndex = 41;
            this.tbNeedLearn3.TextChanged += new System.EventHandler(this.TbNeedLearn3_TextChanged);
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(393, 79);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(30, 13);
            this.label106.TabIndex = 40;
            this.label106.Text = "Item:";
            // 
            // tbNeedLearn2
            // 
            this.tbNeedLearn2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNeedLearn2.Location = new System.Drawing.Point(428, 51);
            this.tbNeedLearn2.Name = "tbNeedLearn2";
            this.tbNeedLearn2.Size = new System.Drawing.Size(43, 20);
            this.tbNeedLearn2.TabIndex = 38;
            this.tbNeedLearn2.TextChanged += new System.EventHandler(this.TbNeedLearn2_TextChanged);
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(393, 53);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(30, 13);
            this.label105.TabIndex = 37;
            this.label105.Text = "Item:";
            // 
            // tbNeedLearn1
            // 
            this.tbNeedLearn1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNeedLearn1.Location = new System.Drawing.Point(428, 25);
            this.tbNeedLearn1.Name = "tbNeedLearn1";
            this.tbNeedLearn1.Size = new System.Drawing.Size(43, 20);
            this.tbNeedLearn1.TabIndex = 35;
            this.tbNeedLearn1.TextChanged += new System.EventHandler(this.TbNeedLearn1_TextChanged);
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(393, 27);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(30, 13);
            this.label104.TabIndex = 34;
            this.label104.Text = "Item:";
            // 
            // textBox102
            // 
            this.textBox102.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox102.Location = new System.Drawing.Point(314, 73);
            this.textBox102.Name = "textBox102";
            this.textBox102.Size = new System.Drawing.Size(26, 20);
            this.textBox102.TabIndex = 33;
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(280, 74);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(28, 13);
            this.label103.TabIndex = 32;
            this.label103.Text = "LvL:";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(189, 75);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(38, 13);
            this.label102.TabIndex = 30;
            this.label102.Text = "Skill 3:";
            // 
            // textBox101
            // 
            this.textBox101.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox101.Location = new System.Drawing.Point(233, 72);
            this.textBox101.Name = "textBox101";
            this.textBox101.Size = new System.Drawing.Size(32, 20);
            this.textBox101.TabIndex = 29;
            // 
            // textBox100
            // 
            this.textBox100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox100.Location = new System.Drawing.Point(314, 46);
            this.textBox100.Name = "textBox100";
            this.textBox100.Size = new System.Drawing.Size(26, 20);
            this.textBox100.TabIndex = 28;
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(280, 48);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(28, 13);
            this.label101.TabIndex = 27;
            this.label101.Text = "LvL:";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(189, 48);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(38, 13);
            this.label100.TabIndex = 25;
            this.label100.Text = "Skill 2:";
            // 
            // textBox99
            // 
            this.textBox99.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox99.Location = new System.Drawing.Point(232, 46);
            this.textBox99.Name = "textBox99";
            this.textBox99.Size = new System.Drawing.Size(33, 20);
            this.textBox99.TabIndex = 24;
            // 
            // textBox98
            // 
            this.textBox98.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox98.Location = new System.Drawing.Point(314, 20);
            this.textBox98.Name = "textBox98";
            this.textBox98.Size = new System.Drawing.Size(26, 20);
            this.textBox98.TabIndex = 23;
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(280, 24);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(31, 13);
            this.label99.TabIndex = 22;
            this.label99.Text = "LvL.:";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(189, 24);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(38, 13);
            this.label98.TabIndex = 17;
            this.label98.Text = "Skill 1:";
            // 
            // textBox97
            // 
            this.textBox97.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox97.Location = new System.Drawing.Point(233, 20);
            this.textBox97.Name = "textBox97";
            this.textBox97.Size = new System.Drawing.Size(32, 20);
            this.textBox97.TabIndex = 16;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(98, 27);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(24, 13);
            this.label97.TabIndex = 15;
            this.label97.Text = "SP:";
            // 
            // textBox96
            // 
            this.textBox96.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox96.Location = new System.Drawing.Point(128, 25);
            this.textBox96.Name = "textBox96";
            this.textBox96.Size = new System.Drawing.Size(49, 20);
            this.textBox96.TabIndex = 14;
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(10, 34);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(36, 13);
            this.label96.TabIndex = 0;
            this.label96.Text = "Level:";
            // 
            // textBox95
            // 
            this.textBox95.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox95.Location = new System.Drawing.Point(52, 23);
            this.textBox95.Name = "textBox95";
            this.textBox95.Size = new System.Drawing.Size(29, 20);
            this.textBox95.TabIndex = 13;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox6.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Location = new System.Drawing.Point(346, 20);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox6, "Select Skill");
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox7.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Location = new System.Drawing.Point(346, 46);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 26;
            this.pictureBox7.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox7, "Select Skill");
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox8.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Location = new System.Drawing.Point(346, 73);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(20, 20);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 31;
            this.pictureBox8.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox8, "Select Skill");
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pbNeedItem1
            // 
            this.pbNeedItem1.BackColor = System.Drawing.SystemColors.Control;
            this.pbNeedItem1.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pbNeedItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbNeedItem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbNeedItem1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNeedItem1.Location = new System.Drawing.Point(666, 25);
            this.pbNeedItem1.Name = "pbNeedItem1";
            this.pbNeedItem1.Size = new System.Drawing.Size(20, 20);
            this.pbNeedItem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNeedItem1.TabIndex = 36;
            this.pbNeedItem1.TabStop = false;
            this.toolTip1.SetToolTip(this.pbNeedItem1, "Select Item");
            this.pbNeedItem1.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pbNeedItem2
            // 
            this.pbNeedItem2.BackColor = System.Drawing.SystemColors.Control;
            this.pbNeedItem2.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pbNeedItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbNeedItem2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbNeedItem2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNeedItem2.Location = new System.Drawing.Point(666, 51);
            this.pbNeedItem2.Name = "pbNeedItem2";
            this.pbNeedItem2.Size = new System.Drawing.Size(20, 20);
            this.pbNeedItem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNeedItem2.TabIndex = 39;
            this.pbNeedItem2.TabStop = false;
            this.toolTip1.SetToolTip(this.pbNeedItem2, "Select Item");
            this.pbNeedItem2.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pbNeedItem3
            // 
            this.pbNeedItem3.BackColor = System.Drawing.SystemColors.Control;
            this.pbNeedItem3.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pbNeedItem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbNeedItem3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbNeedItem3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNeedItem3.Location = new System.Drawing.Point(666, 77);
            this.pbNeedItem3.Name = "pbNeedItem3";
            this.pbNeedItem3.Size = new System.Drawing.Size(20, 20);
            this.pbNeedItem3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNeedItem3.TabIndex = 42;
            this.pbNeedItem3.TabStop = false;
            this.toolTip1.SetToolTip(this.pbNeedItem3, "Select Item");
            this.pbNeedItem3.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.PbMagicIdx3);
            this.groupBox27.Controls.Add(this.PbMagicIdx2);
            this.groupBox27.Controls.Add(this.PbMagicIdx1);
            this.groupBox27.Controls.Add(this.tbMagicLevel3);
            this.groupBox27.Controls.Add(this.label121);
            this.groupBox27.Controls.Add(this.tbMagicIndex3);
            this.groupBox27.Controls.Add(this.label120);
            this.groupBox27.Controls.Add(this.tbMagicLevel2);
            this.groupBox27.Controls.Add(this.label119);
            this.groupBox27.Controls.Add(this.tbMagicIndex2);
            this.groupBox27.Controls.Add(this.label118);
            this.groupBox27.Controls.Add(this.tbMagicLevel1);
            this.groupBox27.Controls.Add(this.label117);
            this.groupBox27.Controls.Add(this.tbMagicIndex1);
            this.groupBox27.Controls.Add(this.label116);
            this.groupBox27.Location = new System.Drawing.Point(623, 6);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(205, 95);
            this.groupBox27.TabIndex = 16;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "Magic Index";
            // 
            // PbMagicIdx3
            // 
            this.PbMagicIdx3.BackColor = System.Drawing.SystemColors.Control;
            this.PbMagicIdx3.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.PbMagicIdx3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbMagicIdx3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbMagicIdx3.Location = new System.Drawing.Point(47, 70);
            this.PbMagicIdx3.Name = "PbMagicIdx3";
            this.PbMagicIdx3.Size = new System.Drawing.Size(20, 20);
            this.PbMagicIdx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbMagicIdx3.TabIndex = 39;
            this.PbMagicIdx3.TabStop = false;
            this.toolTip1.SetToolTip(this.PbMagicIdx3, "Select MagicID");
            this.PbMagicIdx3.Click += new System.EventHandler(this.PbMagicIdx3_Click);
            // 
            // PbMagicIdx2
            // 
            this.PbMagicIdx2.BackColor = System.Drawing.SystemColors.Control;
            this.PbMagicIdx2.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.PbMagicIdx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbMagicIdx2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbMagicIdx2.Location = new System.Drawing.Point(47, 44);
            this.PbMagicIdx2.Name = "PbMagicIdx2";
            this.PbMagicIdx2.Size = new System.Drawing.Size(20, 20);
            this.PbMagicIdx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbMagicIdx2.TabIndex = 38;
            this.PbMagicIdx2.TabStop = false;
            this.toolTip1.SetToolTip(this.PbMagicIdx2, "Select MagicID");
            this.PbMagicIdx2.Click += new System.EventHandler(this.PbMagicIdx2_Click);
            // 
            // PbMagicIdx1
            // 
            this.PbMagicIdx1.BackColor = System.Drawing.SystemColors.Control;
            this.PbMagicIdx1.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.PbMagicIdx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbMagicIdx1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbMagicIdx1.Location = new System.Drawing.Point(47, 16);
            this.PbMagicIdx1.Name = "PbMagicIdx1";
            this.PbMagicIdx1.Size = new System.Drawing.Size(20, 20);
            this.PbMagicIdx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbMagicIdx1.TabIndex = 37;
            this.PbMagicIdx1.TabStop = false;
            this.toolTip1.SetToolTip(this.PbMagicIdx1, "Select MagicID");
            this.PbMagicIdx1.Click += new System.EventHandler(this.PbMagicIdx1_Click);
            // 
            // tbMagicLevel3
            // 
            this.tbMagicLevel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMagicLevel3.Location = new System.Drawing.Point(169, 69);
            this.tbMagicLevel3.Name = "tbMagicLevel3";
            this.tbMagicLevel3.Size = new System.Drawing.Size(21, 20);
            this.tbMagicLevel3.TabIndex = 11;
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(121, 71);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(36, 13);
            this.label121.TabIndex = 10;
            this.label121.Text = "Level:";
            // 
            // tbMagicIndex3
            // 
            this.tbMagicIndex3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMagicIndex3.Location = new System.Drawing.Point(73, 69);
            this.tbMagicIndex3.Name = "tbMagicIndex3";
            this.tbMagicIndex3.Size = new System.Drawing.Size(36, 20);
            this.tbMagicIndex3.TabIndex = 9;
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(9, 70);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(36, 13);
            this.label120.TabIndex = 8;
            this.label120.Text = "Index:";
            // 
            // tbMagicLevel2
            // 
            this.tbMagicLevel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMagicLevel2.Location = new System.Drawing.Point(169, 42);
            this.tbMagicLevel2.Name = "tbMagicLevel2";
            this.tbMagicLevel2.Size = new System.Drawing.Size(21, 20);
            this.tbMagicLevel2.TabIndex = 7;
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Location = new System.Drawing.Point(121, 42);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(36, 13);
            this.label119.TabIndex = 6;
            this.label119.Text = "Level:";
            // 
            // tbMagicIndex2
            // 
            this.tbMagicIndex2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMagicIndex2.Location = new System.Drawing.Point(73, 42);
            this.tbMagicIndex2.Name = "tbMagicIndex2";
            this.tbMagicIndex2.Size = new System.Drawing.Size(36, 20);
            this.tbMagicIndex2.TabIndex = 5;
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(9, 45);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(36, 13);
            this.label118.TabIndex = 4;
            this.label118.Text = "Index:";
            // 
            // tbMagicLevel1
            // 
            this.tbMagicLevel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMagicLevel1.Location = new System.Drawing.Point(169, 16);
            this.tbMagicLevel1.Name = "tbMagicLevel1";
            this.tbMagicLevel1.Size = new System.Drawing.Size(21, 20);
            this.tbMagicLevel1.TabIndex = 3;
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(121, 18);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(36, 13);
            this.label117.TabIndex = 2;
            this.label117.Text = "Level:";
            // 
            // tbMagicIndex1
            // 
            this.tbMagicIndex1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMagicIndex1.Location = new System.Drawing.Point(73, 16);
            this.tbMagicIndex1.Name = "tbMagicIndex1";
            this.tbMagicIndex1.Size = new System.Drawing.Size(36, 20);
            this.tbMagicIndex1.TabIndex = 1;
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(9, 18);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(36, 13);
            this.label116.TabIndex = 0;
            this.label116.Text = "Index:";
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.label95);
            this.groupBox23.Controls.Add(this.textBox94);
            this.groupBox23.Controls.Add(this.pictureBox5);
            this.groupBox23.Controls.Add(this.label94);
            this.groupBox23.Controls.Add(this.textBox93);
            this.groupBox23.Controls.Add(this.label93);
            this.groupBox23.Controls.Add(this.textBox92);
            this.groupBox23.Controls.Add(this.pictureBox4);
            this.groupBox23.Controls.Add(this.label92);
            this.groupBox23.Controls.Add(this.textBox91);
            this.groupBox23.Controls.Add(this.label89);
            this.groupBox23.Controls.Add(this.textBox88);
            this.groupBox23.Controls.Add(this.textBox87);
            this.groupBox23.Controls.Add(this.label88);
            this.groupBox23.Controls.Add(this.textBox86);
            this.groupBox23.Controls.Add(this.label87);
            this.groupBox23.Location = new System.Drawing.Point(371, 6);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(246, 113);
            this.groupBox23.TabIndex = 9;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Needed to Cast Skill";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(160, 86);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(26, 13);
            this.label95.TabIndex = 20;
            this.label95.Text = "Cnt:";
            // 
            // textBox94
            // 
            this.textBox94.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox94.Location = new System.Drawing.Point(192, 85);
            this.textBox94.Name = "textBox94";
            this.textBox94.Size = new System.Drawing.Size(43, 20);
            this.textBox94.TabIndex = 19;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Location = new System.Drawing.Point(119, 66);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox5, "Select Item");
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(160, 16);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(30, 13);
            this.label94.TabIndex = 17;
            this.label94.Text = "Item:";
            // 
            // textBox93
            // 
            this.textBox93.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox93.Location = new System.Drawing.Point(192, 61);
            this.textBox93.Name = "textBox93";
            this.textBox93.Size = new System.Drawing.Size(43, 20);
            this.textBox93.TabIndex = 16;
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(160, 39);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(26, 13);
            this.label93.TabIndex = 15;
            this.label93.Text = "Cnt:";
            // 
            // textBox92
            // 
            this.textBox92.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox92.Location = new System.Drawing.Point(192, 37);
            this.textBox92.Name = "textBox92";
            this.textBox92.Size = new System.Drawing.Size(43, 20);
            this.textBox92.TabIndex = 14;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(119, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "Select Item");
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(160, 63);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(30, 13);
            this.label92.TabIndex = 12;
            this.label92.Text = "Item:";
            // 
            // textBox91
            // 
            this.textBox91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox91.Location = new System.Drawing.Point(192, 12);
            this.textBox91.Name = "textBox91";
            this.textBox91.Size = new System.Drawing.Size(43, 20);
            this.textBox91.TabIndex = 11;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(5, 82);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(25, 13);
            this.label89.TabIndex = 10;
            this.label89.Text = "GP:";
            // 
            // textBox88
            // 
            this.textBox88.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox88.Location = new System.Drawing.Point(36, 79);
            this.textBox88.Name = "textBox88";
            this.textBox88.Size = new System.Drawing.Size(66, 20);
            this.textBox88.TabIndex = 9;
            // 
            // textBox87
            // 
            this.textBox87.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox87.Location = new System.Drawing.Point(37, 50);
            this.textBox87.Name = "textBox87";
            this.textBox87.Size = new System.Drawing.Size(65, 20);
            this.textBox87.TabIndex = 7;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(5, 52);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(26, 13);
            this.label88.TabIndex = 8;
            this.label88.Text = "MP:";
            // 
            // textBox86
            // 
            this.textBox86.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox86.Location = new System.Drawing.Point(37, 23);
            this.textBox86.Name = "textBox86";
            this.textBox86.Size = new System.Drawing.Size(65, 20);
            this.textBox86.TabIndex = 5;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(6, 26);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(25, 13);
            this.label87.TabIndex = 6;
            this.label87.Text = "HP:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnCopyLevel);
            this.groupBox7.Controls.Add(this.button5);
            this.groupBox7.Controls.Add(this.button4);
            this.groupBox7.Controls.Add(this.listBox2);
            this.groupBox7.Location = new System.Drawing.Point(6, 5);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(122, 224);
            this.groupBox7.TabIndex = 59;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Levels";
            // 
            // btnCopyLevel
            // 
            this.btnCopyLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyLevel.Location = new System.Drawing.Point(62, 71);
            this.btnCopyLevel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopyLevel.Name = "btnCopyLevel";
            this.btnCopyLevel.Size = new System.Drawing.Size(51, 25);
            this.btnCopyLevel.TabIndex = 3;
            this.btnCopyLevel.Text = "Copy";
            this.btnCopyLevel.UseVisualStyleBackColor = true;
            this.btnCopyLevel.Click += new System.EventHandler(this.BtnCopyLevel_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(62, 46);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 22);
            this.button5.TabIndex = 2;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(62, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 22);
            this.button4.TabIndex = 1;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(6, 19);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(50, 199);
            this.listBox2.TabIndex = 0;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // textBox136
            // 
            this.textBox136.Location = new System.Drawing.Point(949, 307);
            this.textBox136.Name = "textBox136";
            this.textBox136.Size = new System.Drawing.Size(30, 20);
            this.textBox136.TabIndex = 24;
            this.textBox136.Visible = false;
            // 
            // textBox132
            // 
            this.textBox132.Location = new System.Drawing.Point(931, 348);
            this.textBox132.Name = "textBox132";
            this.textBox132.Size = new System.Drawing.Size(30, 20);
            this.textBox132.TabIndex = 22;
            this.textBox132.Visible = false;
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.pictureBox1);
            this.groupBox22.Controls.Add(this.linkLabel1);
            this.groupBox22.Controls.Add(this.label75);
            this.groupBox22.Controls.Add(this.label74);
            this.groupBox22.Controls.Add(this.textBox57);
            this.groupBox22.Controls.Add(this.textBox56);
            this.groupBox22.Controls.Add(this.label73);
            this.groupBox22.Controls.Add(this.textBox55);
            this.groupBox22.Location = new System.Drawing.Point(9, 240);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(207, 87);
            this.groupBox22.TabIndex = 57;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Icon";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(140, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(128, 61);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 13);
            this.linkLabel1.TabIndex = 62;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Icon Picker";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(8, 63);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(25, 13);
            this.label75.TabIndex = 60;
            this.label75.Text = "Col:";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(8, 39);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(32, 13);
            this.label74.TabIndex = 59;
            this.label74.Text = "Row:";
            // 
            // textBox57
            // 
            this.textBox57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox57.Location = new System.Drawing.Point(42, 59);
            this.textBox57.Name = "textBox57";
            this.textBox57.Size = new System.Drawing.Size(41, 20);
            this.textBox57.TabIndex = 58;
            // 
            // textBox56
            // 
            this.textBox56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox56.Location = new System.Drawing.Point(42, 35);
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(41, 20);
            this.textBox56.TabIndex = 57;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(8, 14);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(21, 13);
            this.label73.TabIndex = 56;
            this.label73.Text = "ID:";
            // 
            // textBox55
            // 
            this.textBox55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox55.Location = new System.Drawing.Point(42, 10);
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(41, 20);
            this.textBox55.TabIndex = 55;
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.textBox52);
            this.groupBox21.Controls.Add(this.label70);
            this.groupBox21.Location = new System.Drawing.Point(356, 204);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(288, 42);
            this.groupBox21.TabIndex = 49;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Skill Effect";
            // 
            // textBox52
            // 
            this.textBox52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox52.Location = new System.Drawing.Point(49, 14);
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(185, 20);
            this.textBox52.TabIndex = 1;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(6, 16);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(38, 13);
            this.label70.TabIndex = 0;
            this.label70.Text = "Effect:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label31);
            this.groupBox8.Controls.Add(this.textBox32);
            this.groupBox8.Controls.Add(this.label30);
            this.groupBox8.Controls.Add(this.textBox31);
            this.groupBox8.Controls.Add(this.label29);
            this.groupBox8.Controls.Add(this.textBox30);
            this.groupBox8.Controls.Add(this.label28);
            this.groupBox8.Controls.Add(this.textBox29);
            this.groupBox8.Location = new System.Drawing.Point(6, 160);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(342, 74);
            this.groupBox8.TabIndex = 48;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Timings";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(156, 44);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(57, 13);
            this.label31.TabIndex = 54;
            this.label31.Text = "Cool Time:";
            // 
            // textBox32
            // 
            this.textBox32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox32.Location = new System.Drawing.Point(219, 40);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(52, 20);
            this.textBox32.TabIndex = 53;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(156, 19);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(53, 13);
            this.label30.TabIndex = 52;
            this.label30.Text = "Fire Time:";
            // 
            // textBox31
            // 
            this.textBox31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox31.Location = new System.Drawing.Point(219, 14);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(52, 20);
            this.textBox31.TabIndex = 51;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(8, 44);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(55, 13);
            this.label29.TabIndex = 50;
            this.label29.Text = "Skill Time:";
            // 
            // textBox30
            // 
            this.textBox30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox30.Location = new System.Drawing.Point(79, 42);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(52, 20);
            this.textBox30.TabIndex = 49;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 22);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(67, 13);
            this.label28.TabIndex = 48;
            this.label28.Text = "Ready Time:";
            // 
            // textBox29
            // 
            this.textBox29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox29.Location = new System.Drawing.Point(79, 17);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(52, 20);
            this.textBox29.TabIndex = 47;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.textBox22);
            this.groupBox11.Controls.Add(this.textBox23);
            this.groupBox11.Controls.Add(this.textBox24);
            this.groupBox11.Controls.Add(this.label25);
            this.groupBox11.Controls.Add(this.label24);
            this.groupBox11.Controls.Add(this.label23);
            this.groupBox11.Controls.Add(this.label22);
            this.groupBox11.Controls.Add(this.label21);
            this.groupBox11.Controls.Add(this.label20);
            this.groupBox11.Controls.Add(this.textBox21);
            this.groupBox11.Controls.Add(this.textBox19);
            this.groupBox11.Controls.Add(this.textBox20);
            this.groupBox11.Location = new System.Drawing.Point(651, 160);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(247, 86);
            this.groupBox11.TabIndex = 46;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Magic Level";
            // 
            // textBox22
            // 
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox22.Location = new System.Drawing.Point(201, 14);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(35, 20);
            this.textBox22.TabIndex = 54;
            // 
            // textBox23
            // 
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox23.Location = new System.Drawing.Point(201, 60);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(35, 20);
            this.textBox23.TabIndex = 52;
            // 
            // textBox24
            // 
            this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox24.Location = new System.Drawing.Point(201, 37);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(35, 20);
            this.textBox24.TabIndex = 53;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(138, 66);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(36, 13);
            this.label25.TabIndex = 51;
            this.label25.Text = "Level:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(137, 39);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(36, 13);
            this.label24.TabIndex = 50;
            this.label24.Text = "Level:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(138, 16);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 13);
            this.label23.TabIndex = 49;
            this.label23.Text = "Level:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 66);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 13);
            this.label22.TabIndex = 48;
            this.label22.Text = "Index:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 39);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 13);
            this.label21.TabIndex = 47;
            this.label21.Text = "Index:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 13);
            this.label20.TabIndex = 46;
            this.label20.Text = "Index:";
            // 
            // textBox21
            // 
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox21.Location = new System.Drawing.Point(48, 63);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(35, 20);
            this.textBox21.TabIndex = 45;
            // 
            // textBox19
            // 
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox19.Location = new System.Drawing.Point(48, 14);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(35, 20);
            this.textBox19.TabIndex = 43;
            // 
            // textBox20
            // 
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox20.Location = new System.Drawing.Point(48, 37);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(35, 20);
            this.textBox20.TabIndex = 44;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label19);
            this.groupBox10.Controls.Add(this.comboBox18);
            this.groupBox10.Controls.Add(this.textBox17);
            this.groupBox10.Controls.Add(this.comboBox17);
            this.groupBox10.Controls.Add(this.label18);
            this.groupBox10.Controls.Add(this.textBox16);
            this.groupBox10.Location = new System.Drawing.Point(356, 110);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(288, 85);
            this.groupBox10.TabIndex = 41;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Weapon Type";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 57);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 45;
            this.label19.Text = "Type 2:";
            // 
            // comboBox18
            // 
            this.comboBox18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox18.FormattingEnabled = true;
            this.comboBox18.Location = new System.Drawing.Point(54, 54);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(180, 21);
            this.comboBox18.TabIndex = 44;
            this.comboBox18.SelectedIndexChanged += new System.EventHandler(this.comboBox18_SelectedIndexChanged);
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox17.Location = new System.Drawing.Point(249, 55);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(22, 20);
            this.textBox17.TabIndex = 43;
            this.textBox17.Visible = false;
            // 
            // comboBox17
            // 
            this.comboBox17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox17.FormattingEnabled = true;
            this.comboBox17.Location = new System.Drawing.Point(55, 27);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Size = new System.Drawing.Size(180, 21);
            this.comboBox17.TabIndex = 42;
            this.comboBox17.SelectedIndexChanged += new System.EventHandler(this.comboBox17_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 41;
            this.label18.Text = "Type 1:";
            // 
            // textBox16
            // 
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox16.Location = new System.Drawing.Point(249, 27);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(22, 20);
            this.textBox16.TabIndex = 40;
            this.textBox16.Visible = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label26);
            this.groupBox9.Controls.Add(this.label17);
            this.groupBox9.Controls.Add(this.textBox14);
            this.groupBox9.Controls.Add(this.textBox13);
            this.groupBox9.Controls.Add(this.comboBox16);
            this.groupBox9.Location = new System.Drawing.Point(402, 245);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(348, 50);
            this.groupBox9.TabIndex = 37;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Target";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(245, 27);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(46, 13);
            this.label26.TabIndex = 39;
            this.label26.Text = "Amount:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Target Type:";
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox14.Location = new System.Drawing.Point(297, 22);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(34, 20);
            this.textBox14.TabIndex = 37;
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.Location = new System.Drawing.Point(218, 22);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(17, 20);
            this.textBox13.TabIndex = 35;
            this.textBox13.Visible = false;
            // 
            // comboBox16
            // 
            this.comboBox16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox16.FormattingEnabled = true;
            this.comboBox16.Location = new System.Drawing.Point(80, 21);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(130, 21);
            this.comboBox16.TabIndex = 36;
            this.comboBox16.SelectedIndexChanged += new System.EventHandler(this.comboBox16_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pictureBox3);
            this.groupBox6.Controls.Add(this.label82);
            this.groupBox6.Controls.Add(this.textBox81);
            this.groupBox6.Controls.Add(this.pictureBox2);
            this.groupBox6.Controls.Add(this.label78);
            this.groupBox6.Controls.Add(this.textBox7);
            this.groupBox6.Location = new System.Drawing.Point(222, 242);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(174, 85);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Flags Skill";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.Flag;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(139, 53);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 28);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Sorc Flag Builder");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(6, 57);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(55, 13);
            this.label82.TabIndex = 25;
            this.label82.Text = "Sorc Flag:";
            // 
            // textBox81
            // 
            this.textBox81.BackColor = System.Drawing.Color.White;
            this.textBox81.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox81.Location = new System.Drawing.Point(67, 55);
            this.textBox81.Name = "textBox81";
            this.textBox81.Size = new System.Drawing.Size(66, 20);
            this.textBox81.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.Flag;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(139, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 28);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Skill Flag Builder");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(9, 28);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(52, 13);
            this.label78.TabIndex = 22;
            this.label78.Text = "Skill Flag:";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Location = new System.Drawing.Point(67, 26);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(66, 20);
            this.textBox7.TabIndex = 21;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PbUseState);
            this.groupBox4.Controls.Add(this.PbAppState);
            this.groupBox4.Controls.Add(this.textBox25);
            this.groupBox4.Controls.Add(this.textBox15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.comboBox15);
            this.groupBox4.Controls.Add(this.textBox9);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.textBox12);
            this.groupBox4.Controls.Add(this.textBox10);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textBox11);
            this.groupBox4.Location = new System.Drawing.Point(651, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(337, 145);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Other";
            // 
            // PbUseState
            // 
            this.PbUseState.BackColor = System.Drawing.SystemColors.Control;
            this.PbUseState.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.PbUseState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbUseState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbUseState.Location = new System.Drawing.Point(257, 84);
            this.PbUseState.Name = "PbUseState";
            this.PbUseState.Size = new System.Drawing.Size(20, 20);
            this.PbUseState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbUseState.TabIndex = 48;
            this.PbUseState.TabStop = false;
            this.toolTip1.SetToolTip(this.PbUseState, "Use State Select");
            this.PbUseState.Click += new System.EventHandler(this.PbUseState_Click);
            // 
            // PbAppState
            // 
            this.PbAppState.BackColor = System.Drawing.SystemColors.Control;
            this.PbAppState.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.PbAppState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbAppState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbAppState.Location = new System.Drawing.Point(257, 53);
            this.PbAppState.Name = "PbAppState";
            this.PbAppState.Size = new System.Drawing.Size(20, 20);
            this.PbAppState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbAppState.TabIndex = 40;
            this.PbAppState.TabStop = false;
            this.toolTip1.SetToolTip(this.PbAppState, "App State Select");
            this.PbAppState.Click += new System.EventHandler(this.PbAppState_Click);
            // 
            // textBox25
            // 
            this.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox25.Location = new System.Drawing.Point(217, 53);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(34, 20);
            this.textBox25.TabIndex = 47;
            // 
            // textBox15
            // 
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox15.Location = new System.Drawing.Point(217, 82);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(34, 20);
            this.textBox15.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(144, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "App State:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Type:";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(294, 20);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(34, 20);
            this.textBox6.TabIndex = 19;
            this.textBox6.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(144, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Use State:";
            // 
            // comboBox15
            // 
            this.comboBox15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Location = new System.Drawing.Point(50, 19);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(235, 21);
            this.comboBox15.TabIndex = 0;
            this.comboBox15.SelectedIndexChanged += new System.EventHandler(this.comboBox15_SelectedIndexChanged);
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Location = new System.Drawing.Point(217, 110);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(34, 20);
            this.textBox9.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Soul Consum:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(144, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "App Range:";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.Window;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Location = new System.Drawing.Point(88, 105);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(34, 20);
            this.textBox12.TabIndex = 33;
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Location = new System.Drawing.Point(88, 53);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(34, 20);
            this.textBox10.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Fire Range 2:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Fire Range 1:";
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox11.Location = new System.Drawing.Point(88, 79);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(34, 20);
            this.textBox11.TabIndex = 31;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox82);
            this.groupBox2.Controls.Add(this.label83);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.comboBox14);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox5);
            this.groupBox2.Controls.Add(this.comboBox10);
            this.groupBox2.Controls.Add(this.comboBox13);
            this.groupBox2.Controls.Add(this.comboBox9);
            this.groupBox2.Controls.Add(this.comboBox11);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox6);
            this.groupBox2.Controls.Add(this.comboBox7);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox12);
            this.groupBox2.Controls.Add(this.comboBox8);
            this.groupBox2.Location = new System.Drawing.Point(356, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 99);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Character and Job";
            // 
            // textBox82
            // 
            this.textBox82.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox82.Location = new System.Drawing.Point(69, 70);
            this.textBox82.Name = "textBox82";
            this.textBox82.Size = new System.Drawing.Size(76, 20);
            this.textBox82.TabIndex = 52;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(16, 74);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(47, 13);
            this.label83.TabIndex = 51;
            this.label83.Text = "Pet IDX:";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(49, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 21);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Job:";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(230, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(26, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Visible = false;
            // 
            // comboBox14
            // 
            this.comboBox14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Location = new System.Drawing.Point(49, 44);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(174, 21);
            this.comboBox14.TabIndex = 49;
            this.comboBox14.SelectedIndexChanged += new System.EventHandler(this.comboBox14_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(230, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(26, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(49, 44);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(174, 21);
            this.comboBox3.TabIndex = 37;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(49, 44);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(174, 21);
            this.comboBox5.TabIndex = 38;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox10
            // 
            this.comboBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(49, 44);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(174, 21);
            this.comboBox10.TabIndex = 43;
            this.comboBox10.SelectedIndexChanged += new System.EventHandler(this.comboBox10_SelectedIndexChanged);
            // 
            // comboBox13
            // 
            this.comboBox13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Location = new System.Drawing.Point(49, 44);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(174, 21);
            this.comboBox13.TabIndex = 46;
            this.comboBox13.SelectedIndexChanged += new System.EventHandler(this.comboBox13_SelectedIndexChanged);
            // 
            // comboBox9
            // 
            this.comboBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(49, 44);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(174, 21);
            this.comboBox9.TabIndex = 42;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // comboBox11
            // 
            this.comboBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(49, 44);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(174, 21);
            this.comboBox11.TabIndex = 44;
            this.comboBox11.SelectedIndexChanged += new System.EventHandler(this.comboBox11_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(49, 44);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(174, 21);
            this.comboBox2.TabIndex = 36;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(49, 44);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(174, 21);
            this.comboBox6.TabIndex = 39;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // comboBox7
            // 
            this.comboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(49, 44);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(174, 21);
            this.comboBox7.TabIndex = 40;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(49, 44);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(174, 21);
            this.comboBox4.TabIndex = 37;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox12
            // 
            this.comboBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Location = new System.Drawing.Point(49, 44);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(174, 21);
            this.comboBox12.TabIndex = 45;
            this.comboBox12.SelectedIndexChanged += new System.EventHandler(this.comboBox12_SelectedIndexChanged);
            // 
            // comboBox8
            // 
            this.comboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(49, 44);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(174, 21);
            this.comboBox8.TabIndex = 41;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox54);
            this.groupBox1.Controls.Add(this.label71);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic";
            // 
            // textBox54
            // 
            this.textBox54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox54.Location = new System.Drawing.Point(56, 113);
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(273, 20);
            this.textBox54.TabIndex = 52;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(8, 115);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(42, 13);
            this.label71.TabIndex = 51;
            this.label71.Text = "Tooltip:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Descr:";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(55, 71);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(273, 36);
            this.textBox5.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name:";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(55, 45);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(273, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(55, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Index:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.groupBox12);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1041, 598);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Graphic";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.groupBox20);
            this.groupBox12.Controls.Add(this.groupBox19);
            this.groupBox12.Controls.Add(this.groupBox18);
            this.groupBox12.Controls.Add(this.groupBox17);
            this.groupBox12.Controls.Add(this.groupBox16);
            this.groupBox12.Controls.Add(this.groupBox15);
            this.groupBox12.Controls.Add(this.groupBox14);
            this.groupBox12.Controls.Add(this.groupBox13);
            this.groupBox12.Location = new System.Drawing.Point(3, 3);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(717, 550);
            this.groupBox12.TabIndex = 57;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Animation & Effect";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.textBox76);
            this.groupBox20.Controls.Add(this.textBox75);
            this.groupBox20.Controls.Add(this.textBox74);
            this.groupBox20.Controls.Add(this.textBox73);
            this.groupBox20.Controls.Add(this.textBox72);
            this.groupBox20.Controls.Add(this.textBox71);
            this.groupBox20.Controls.Add(this.label64);
            this.groupBox20.Controls.Add(this.label65);
            this.groupBox20.Controls.Add(this.label66);
            this.groupBox20.Controls.Add(this.label67);
            this.groupBox20.Controls.Add(this.label68);
            this.groupBox20.Controls.Add(this.label69);
            this.groupBox20.Location = new System.Drawing.Point(334, 422);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(252, 118);
            this.groupBox20.TabIndex = 64;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Fire Object Delay 2";
            // 
            // textBox76
            // 
            this.textBox76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox76.Location = new System.Drawing.Point(172, 29);
            this.textBox76.Name = "textBox76";
            this.textBox76.Size = new System.Drawing.Size(65, 20);
            this.textBox76.TabIndex = 11;
            // 
            // textBox75
            // 
            this.textBox75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox75.Location = new System.Drawing.Point(172, 89);
            this.textBox75.Name = "textBox75";
            this.textBox75.Size = new System.Drawing.Size(65, 20);
            this.textBox75.TabIndex = 10;
            // 
            // textBox74
            // 
            this.textBox74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox74.Location = new System.Drawing.Point(172, 58);
            this.textBox74.Name = "textBox74";
            this.textBox74.Size = new System.Drawing.Size(65, 20);
            this.textBox74.TabIndex = 9;
            // 
            // textBox73
            // 
            this.textBox73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox73.Location = new System.Drawing.Point(53, 89);
            this.textBox73.Name = "textBox73";
            this.textBox73.Size = new System.Drawing.Size(65, 20);
            this.textBox73.TabIndex = 8;
            // 
            // textBox72
            // 
            this.textBox72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox72.Location = new System.Drawing.Point(53, 58);
            this.textBox72.Name = "textBox72";
            this.textBox72.Size = new System.Drawing.Size(65, 20);
            this.textBox72.TabIndex = 7;
            // 
            // textBox71
            // 
            this.textBox71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox71.Location = new System.Drawing.Point(53, 29);
            this.textBox71.Name = "textBox71";
            this.textBox71.Size = new System.Drawing.Size(65, 20);
            this.textBox71.TabIndex = 6;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(135, 91);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(16, 13);
            this.label64.TabIndex = 5;
            this.label64.Text = "3:";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(135, 60);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(16, 13);
            this.label65.TabIndex = 4;
            this.label65.Text = "2:";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(9, 91);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(16, 13);
            this.label66.TabIndex = 3;
            this.label66.Text = "1:";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(9, 60);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(16, 13);
            this.label67.TabIndex = 2;
            this.label67.Text = "0:";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(135, 31);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(32, 13);
            this.label68.TabIndex = 1;
            this.label68.Text = "Dest:";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(9, 31);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(38, 13);
            this.label69.TabIndex = 0;
            this.label69.Text = "Count:";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.textBox51);
            this.groupBox19.Controls.Add(this.textBox50);
            this.groupBox19.Controls.Add(this.textBox49);
            this.groupBox19.Controls.Add(this.textBox48);
            this.groupBox19.Controls.Add(this.textBox47);
            this.groupBox19.Controls.Add(this.textBox46);
            this.groupBox19.Controls.Add(this.label63);
            this.groupBox19.Controls.Add(this.label62);
            this.groupBox19.Controls.Add(this.label61);
            this.groupBox19.Controls.Add(this.label60);
            this.groupBox19.Controls.Add(this.label59);
            this.groupBox19.Controls.Add(this.label58);
            this.groupBox19.Location = new System.Drawing.Point(34, 422);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(250, 118);
            this.groupBox19.TabIndex = 63;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Fire Object Delay 1";
            // 
            // textBox51
            // 
            this.textBox51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox51.Location = new System.Drawing.Point(172, 29);
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(65, 20);
            this.textBox51.TabIndex = 76;
            // 
            // textBox50
            // 
            this.textBox50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox50.Location = new System.Drawing.Point(172, 89);
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(65, 20);
            this.textBox50.TabIndex = 75;
            // 
            // textBox49
            // 
            this.textBox49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox49.Location = new System.Drawing.Point(172, 58);
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(65, 20);
            this.textBox49.TabIndex = 74;
            // 
            // textBox48
            // 
            this.textBox48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox48.Location = new System.Drawing.Point(53, 89);
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(65, 20);
            this.textBox48.TabIndex = 73;
            // 
            // textBox47
            // 
            this.textBox47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox47.Location = new System.Drawing.Point(53, 58);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(65, 20);
            this.textBox47.TabIndex = 72;
            // 
            // textBox46
            // 
            this.textBox46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox46.Location = new System.Drawing.Point(53, 29);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(65, 20);
            this.textBox46.TabIndex = 71;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(139, 91);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(16, 13);
            this.label63.TabIndex = 5;
            this.label63.Text = "3:";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(139, 60);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(16, 13);
            this.label62.TabIndex = 4;
            this.label62.Text = "2:";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(9, 91);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(16, 13);
            this.label61.TabIndex = 3;
            this.label61.Text = "1:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(9, 60);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(16, 13);
            this.label60.TabIndex = 2;
            this.label60.Text = "0:";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(139, 31);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(32, 13);
            this.label59.TabIndex = 1;
            this.label59.Text = "Dest:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(9, 31);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(38, 13);
            this.label58.TabIndex = 0;
            this.label58.Text = "Count:";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.textBox70);
            this.groupBox18.Controls.Add(this.textBox69);
            this.groupBox18.Controls.Add(this.textBox68);
            this.groupBox18.Controls.Add(this.textBox67);
            this.groupBox18.Controls.Add(this.textBox66);
            this.groupBox18.Controls.Add(this.textBox65);
            this.groupBox18.Controls.Add(this.label52);
            this.groupBox18.Controls.Add(this.label53);
            this.groupBox18.Controls.Add(this.label54);
            this.groupBox18.Controls.Add(this.label55);
            this.groupBox18.Controls.Add(this.label56);
            this.groupBox18.Controls.Add(this.label57);
            this.groupBox18.Location = new System.Drawing.Point(331, 287);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(255, 128);
            this.groupBox18.TabIndex = 62;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Fire Object 2";
            // 
            // textBox70
            // 
            this.textBox70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox70.Location = new System.Drawing.Point(172, 94);
            this.textBox70.Name = "textBox70";
            this.textBox70.Size = new System.Drawing.Size(65, 20);
            this.textBox70.TabIndex = 11;
            // 
            // textBox69
            // 
            this.textBox69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox69.Location = new System.Drawing.Point(48, 94);
            this.textBox69.Name = "textBox69";
            this.textBox69.Size = new System.Drawing.Size(65, 20);
            this.textBox69.TabIndex = 10;
            // 
            // textBox68
            // 
            this.textBox68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox68.Location = new System.Drawing.Point(172, 64);
            this.textBox68.Name = "textBox68";
            this.textBox68.Size = new System.Drawing.Size(65, 20);
            this.textBox68.TabIndex = 9;
            // 
            // textBox67
            // 
            this.textBox67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox67.Location = new System.Drawing.Point(48, 64);
            this.textBox67.Name = "textBox67";
            this.textBox67.Size = new System.Drawing.Size(65, 20);
            this.textBox67.TabIndex = 8;
            // 
            // textBox66
            // 
            this.textBox66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox66.Location = new System.Drawing.Point(172, 31);
            this.textBox66.Name = "textBox66";
            this.textBox66.Size = new System.Drawing.Size(65, 20);
            this.textBox66.TabIndex = 7;
            // 
            // textBox65
            // 
            this.textBox65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox65.Location = new System.Drawing.Point(48, 31);
            this.textBox65.Name = "textBox65";
            this.textBox65.Size = new System.Drawing.Size(65, 20);
            this.textBox65.TabIndex = 6;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(124, 96);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(38, 13);
            this.label52.TabIndex = 5;
            this.label52.Text = "Coord:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(124, 66);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(17, 13);
            this.label53.TabIndex = 4;
            this.label53.Text = "Z:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(124, 34);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(41, 13);
            this.label54.TabIndex = 3;
            this.label54.Text = "Speed:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(8, 96);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(18, 13);
            this.label55.TabIndex = 2;
            this.label55.Text = "H:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(8, 66);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(17, 13);
            this.label56.TabIndex = 1;
            this.label56.Text = "X:";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(8, 34);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(34, 13);
            this.label57.TabIndex = 0;
            this.label57.Text = "Type:";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.textBox45);
            this.groupBox17.Controls.Add(this.textBox44);
            this.groupBox17.Controls.Add(this.textBox43);
            this.groupBox17.Controls.Add(this.textBox42);
            this.groupBox17.Controls.Add(this.textBox41);
            this.groupBox17.Controls.Add(this.textBox40);
            this.groupBox17.Controls.Add(this.label51);
            this.groupBox17.Controls.Add(this.label50);
            this.groupBox17.Controls.Add(this.label49);
            this.groupBox17.Controls.Add(this.label48);
            this.groupBox17.Controls.Add(this.label47);
            this.groupBox17.Controls.Add(this.label46);
            this.groupBox17.Location = new System.Drawing.Point(34, 287);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(250, 128);
            this.groupBox17.TabIndex = 61;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Fire Object 1";
            // 
            // textBox45
            // 
            this.textBox45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox45.Location = new System.Drawing.Point(172, 94);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(65, 20);
            this.textBox45.TabIndex = 70;
            // 
            // textBox44
            // 
            this.textBox44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox44.Location = new System.Drawing.Point(48, 94);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(65, 20);
            this.textBox44.TabIndex = 69;
            // 
            // textBox43
            // 
            this.textBox43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox43.Location = new System.Drawing.Point(172, 64);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(65, 20);
            this.textBox43.TabIndex = 68;
            // 
            // textBox42
            // 
            this.textBox42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox42.Location = new System.Drawing.Point(48, 64);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(65, 20);
            this.textBox42.TabIndex = 67;
            // 
            // textBox41
            // 
            this.textBox41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox41.Location = new System.Drawing.Point(172, 31);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(65, 20);
            this.textBox41.TabIndex = 66;
            // 
            // textBox40
            // 
            this.textBox40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox40.Location = new System.Drawing.Point(48, 31);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(65, 20);
            this.textBox40.TabIndex = 65;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(124, 96);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(38, 13);
            this.label51.TabIndex = 5;
            this.label51.Text = "Coord:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(124, 66);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(17, 13);
            this.label50.TabIndex = 4;
            this.label50.Text = "Z:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(124, 34);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(41, 13);
            this.label49.TabIndex = 3;
            this.label49.Text = "Speed:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(8, 96);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(18, 13);
            this.label48.TabIndex = 2;
            this.label48.Text = "H:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(8, 66);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(17, 13);
            this.label47.TabIndex = 1;
            this.label47.Text = "X:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(8, 34);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(34, 13);
            this.label46.TabIndex = 0;
            this.label46.Text = "Type:";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.textBox64);
            this.groupBox16.Controls.Add(this.textBox63);
            this.groupBox16.Controls.Add(this.textBox62);
            this.groupBox16.Controls.Add(this.textBox59);
            this.groupBox16.Controls.Add(this.label42);
            this.groupBox16.Controls.Add(this.label43);
            this.groupBox16.Controls.Add(this.label44);
            this.groupBox16.Controls.Add(this.label45);
            this.groupBox16.Location = new System.Drawing.Point(334, 132);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(252, 150);
            this.groupBox16.TabIndex = 60;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Effect 2";
            // 
            // textBox64
            // 
            this.textBox64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox64.Location = new System.Drawing.Point(53, 119);
            this.textBox64.Name = "textBox64";
            this.textBox64.Size = new System.Drawing.Size(169, 20);
            this.textBox64.TabIndex = 69;
            // 
            // textBox63
            // 
            this.textBox63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox63.Location = new System.Drawing.Point(53, 92);
            this.textBox63.Name = "textBox63";
            this.textBox63.Size = new System.Drawing.Size(169, 20);
            this.textBox63.TabIndex = 68;
            // 
            // textBox62
            // 
            this.textBox62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox62.Location = new System.Drawing.Point(53, 64);
            this.textBox62.Name = "textBox62";
            this.textBox62.Size = new System.Drawing.Size(169, 20);
            this.textBox62.TabIndex = 67;
            // 
            // textBox59
            // 
            this.textBox59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox59.Location = new System.Drawing.Point(53, 32);
            this.textBox59.Name = "textBox59";
            this.textBox59.Size = new System.Drawing.Size(169, 20);
            this.textBox59.TabIndex = 66;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(6, 121);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(36, 13);
            this.label42.TabIndex = 3;
            this.label42.Text = "Fire 3:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(6, 94);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(36, 13);
            this.label43.TabIndex = 2;
            this.label43.Text = "Fire 2:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(6, 66);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(36, 13);
            this.label44.TabIndex = 1;
            this.label44.Text = "Fire 1:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(6, 34);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(41, 13);
            this.label45.TabIndex = 0;
            this.label45.Text = "Ready:";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.textBox39);
            this.groupBox15.Controls.Add(this.textBox38);
            this.groupBox15.Controls.Add(this.textBox37);
            this.groupBox15.Controls.Add(this.textBox34);
            this.groupBox15.Controls.Add(this.label41);
            this.groupBox15.Controls.Add(this.label40);
            this.groupBox15.Controls.Add(this.label39);
            this.groupBox15.Controls.Add(this.label38);
            this.groupBox15.Location = new System.Drawing.Point(34, 132);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(250, 150);
            this.groupBox15.TabIndex = 59;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Effect 1";
            // 
            // textBox39
            // 
            this.textBox39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox39.Location = new System.Drawing.Point(53, 119);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(169, 20);
            this.textBox39.TabIndex = 65;
            // 
            // textBox38
            // 
            this.textBox38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox38.Location = new System.Drawing.Point(53, 92);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(169, 20);
            this.textBox38.TabIndex = 64;
            // 
            // textBox37
            // 
            this.textBox37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox37.Location = new System.Drawing.Point(53, 64);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(169, 20);
            this.textBox37.TabIndex = 63;
            // 
            // textBox34
            // 
            this.textBox34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox34.Location = new System.Drawing.Point(53, 32);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(169, 20);
            this.textBox34.TabIndex = 60;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(6, 121);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(36, 13);
            this.label41.TabIndex = 3;
            this.label41.Text = "Fire 3:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(6, 94);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(36, 13);
            this.label40.TabIndex = 2;
            this.label40.Text = "Fire 2:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(6, 66);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(36, 13);
            this.label39.TabIndex = 1;
            this.label39.Text = "Fire 1:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(6, 34);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(41, 13);
            this.label38.TabIndex = 0;
            this.label38.Text = "Ready:";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.textBox61);
            this.groupBox14.Controls.Add(this.textBox60);
            this.groupBox14.Controls.Add(this.textBox58);
            this.groupBox14.Controls.Add(this.label35);
            this.groupBox14.Controls.Add(this.label36);
            this.groupBox14.Controls.Add(this.label37);
            this.groupBox14.Location = new System.Drawing.Point(334, 18);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(252, 108);
            this.groupBox14.TabIndex = 58;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Animations 2";
            // 
            // textBox61
            // 
            this.textBox61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox61.Location = new System.Drawing.Point(53, 82);
            this.textBox61.Name = "textBox61";
            this.textBox61.Size = new System.Drawing.Size(169, 20);
            this.textBox61.TabIndex = 68;
            // 
            // textBox60
            // 
            this.textBox60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox60.Location = new System.Drawing.Point(53, 56);
            this.textBox60.Name = "textBox60";
            this.textBox60.Size = new System.Drawing.Size(169, 20);
            this.textBox60.TabIndex = 67;
            // 
            // textBox58
            // 
            this.textBox58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox58.Location = new System.Drawing.Point(53, 30);
            this.textBox58.Name = "textBox58";
            this.textBox58.Size = new System.Drawing.Size(169, 20);
            this.textBox58.TabIndex = 63;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 82);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(27, 13);
            this.label35.TabIndex = 64;
            this.label35.Text = "Fire:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 58);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(26, 13);
            this.label36.TabIndex = 63;
            this.label36.Text = "Still:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 32);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(41, 13);
            this.label37.TabIndex = 62;
            this.label37.Text = "Ready:";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.textBox36);
            this.groupBox13.Controls.Add(this.textBox35);
            this.groupBox13.Controls.Add(this.label34);
            this.groupBox13.Controls.Add(this.label33);
            this.groupBox13.Controls.Add(this.label32);
            this.groupBox13.Controls.Add(this.textBox33);
            this.groupBox13.Location = new System.Drawing.Point(34, 18);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(250, 108);
            this.groupBox13.TabIndex = 57;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Animations 1";
            // 
            // textBox36
            // 
            this.textBox36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox36.Location = new System.Drawing.Point(53, 82);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(169, 20);
            this.textBox36.TabIndex = 62;
            // 
            // textBox35
            // 
            this.textBox35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox35.Location = new System.Drawing.Point(53, 56);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(169, 20);
            this.textBox35.TabIndex = 61;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 82);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(27, 13);
            this.label34.TabIndex = 59;
            this.label34.Text = "Fire:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 58);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(26, 13);
            this.label33.TabIndex = 58;
            this.label33.Text = "Still:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 32);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(41, 13);
            this.label32.TabIndex = 57;
            this.label32.Text = "Ready:";
            // 
            // textBox33
            // 
            this.textBox33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox33.Location = new System.Drawing.Point(53, 30);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(169, 20);
            this.textBox33.TabIndex = 56;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.textBox160);
            this.tabPage2.Controls.Add(this.textBox156);
            this.tabPage2.Controls.Add(this.textBox157);
            this.tabPage2.Controls.Add(this.textBox159);
            this.tabPage2.Controls.Add(this.textBox153);
            this.tabPage2.Controls.Add(this.textBox154);
            this.tabPage2.Controls.Add(this.textBox155);
            this.tabPage2.Controls.Add(this.textBox149);
            this.tabPage2.Controls.Add(this.textBox150);
            this.tabPage2.Controls.Add(this.textBox151);
            this.tabPage2.Controls.Add(this.textBox152);
            this.tabPage2.Controls.Add(this.textBox158);
            this.tabPage2.Controls.Add(this.textBox145);
            this.tabPage2.Controls.Add(this.textBox146);
            this.tabPage2.Controls.Add(this.textBox147);
            this.tabPage2.Controls.Add(this.label137);
            this.tabPage2.Controls.Add(this.textBox141);
            this.tabPage2.Controls.Add(this.textBox142);
            this.tabPage2.Controls.Add(this.textBox143);
            this.tabPage2.Controls.Add(this.label136);
            this.tabPage2.Controls.Add(this.textBox129);
            this.tabPage2.Controls.Add(this.textBox133);
            this.tabPage2.Controls.Add(this.textBox137);
            this.tabPage2.Controls.Add(this.textBox138);
            this.tabPage2.Controls.Add(this.textBox139);
            this.tabPage2.Controls.Add(this.textBox84);
            this.tabPage2.Controls.Add(this.textBox134);
            this.tabPage2.Controls.Add(this.textBox135);
            this.tabPage2.Controls.Add(this.label85);
            this.tabPage2.Controls.Add(this.textBox130);
            this.tabPage2.Controls.Add(this.textBox131);
            this.tabPage2.Controls.Add(this.label135);
            this.tabPage2.Controls.Add(this.textBox148);
            this.tabPage2.Controls.Add(this.textBox140);
            this.tabPage2.Controls.Add(this.textBox144);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1041, 598);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Levels";
            // 
            // textBox160
            // 
            this.textBox160.Location = new System.Drawing.Point(602, 215);
            this.textBox160.Name = "textBox160";
            this.textBox160.Size = new System.Drawing.Size(30, 20);
            this.textBox160.TabIndex = 70;
            // 
            // textBox156
            // 
            this.textBox156.Location = new System.Drawing.Point(602, 166);
            this.textBox156.Name = "textBox156";
            this.textBox156.Size = new System.Drawing.Size(30, 20);
            this.textBox156.TabIndex = 66;
            // 
            // textBox157
            // 
            this.textBox157.Location = new System.Drawing.Point(860, 325);
            this.textBox157.Name = "textBox157";
            this.textBox157.Size = new System.Drawing.Size(26, 20);
            this.textBox157.TabIndex = 55;
            // 
            // textBox159
            // 
            this.textBox159.Location = new System.Drawing.Point(934, 325);
            this.textBox159.Name = "textBox159";
            this.textBox159.Size = new System.Drawing.Size(26, 20);
            this.textBox159.TabIndex = 57;
            // 
            // textBox153
            // 
            this.textBox153.Location = new System.Drawing.Point(860, 292);
            this.textBox153.Name = "textBox153";
            this.textBox153.Size = new System.Drawing.Size(26, 20);
            this.textBox153.TabIndex = 52;
            // 
            // textBox154
            // 
            this.textBox154.Location = new System.Drawing.Point(902, 291);
            this.textBox154.Name = "textBox154";
            this.textBox154.Size = new System.Drawing.Size(26, 20);
            this.textBox154.TabIndex = 53;
            // 
            // textBox155
            // 
            this.textBox155.Location = new System.Drawing.Point(934, 285);
            this.textBox155.Name = "textBox155";
            this.textBox155.Size = new System.Drawing.Size(26, 20);
            this.textBox155.TabIndex = 54;
            // 
            // textBox149
            // 
            this.textBox149.Location = new System.Drawing.Point(602, 120);
            this.textBox149.Name = "textBox149";
            this.textBox149.Size = new System.Drawing.Size(30, 20);
            this.textBox149.TabIndex = 63;
            // 
            // textBox150
            // 
            this.textBox150.Location = new System.Drawing.Point(860, 259);
            this.textBox150.Name = "textBox150";
            this.textBox150.Size = new System.Drawing.Size(26, 20);
            this.textBox150.TabIndex = 49;
            // 
            // textBox151
            // 
            this.textBox151.Location = new System.Drawing.Point(902, 259);
            this.textBox151.Name = "textBox151";
            this.textBox151.Size = new System.Drawing.Size(26, 20);
            this.textBox151.TabIndex = 50;
            // 
            // textBox152
            // 
            this.textBox152.Location = new System.Drawing.Point(934, 259);
            this.textBox152.Name = "textBox152";
            this.textBox152.Size = new System.Drawing.Size(26, 20);
            this.textBox152.TabIndex = 51;
            // 
            // textBox158
            // 
            this.textBox158.Location = new System.Drawing.Point(902, 325);
            this.textBox158.Name = "textBox158";
            this.textBox158.Size = new System.Drawing.Size(26, 20);
            this.textBox158.TabIndex = 56;
            // 
            // textBox145
            // 
            this.textBox145.Location = new System.Drawing.Point(870, 225);
            this.textBox145.Name = "textBox145";
            this.textBox145.Size = new System.Drawing.Size(26, 20);
            this.textBox145.TabIndex = 46;
            // 
            // textBox146
            // 
            this.textBox146.Location = new System.Drawing.Point(902, 225);
            this.textBox146.Name = "textBox146";
            this.textBox146.Size = new System.Drawing.Size(26, 20);
            this.textBox146.TabIndex = 47;
            // 
            // textBox147
            // 
            this.textBox147.Location = new System.Drawing.Point(934, 225);
            this.textBox147.Name = "textBox147";
            this.textBox147.Size = new System.Drawing.Size(26, 20);
            this.textBox147.TabIndex = 48;
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.ForeColor = System.Drawing.Color.Purple;
            this.label137.Location = new System.Drawing.Point(200, 259);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(47, 13);
            this.label137.TabIndex = 69;
            this.label137.Text = "label137";
            // 
            // textBox141
            // 
            this.textBox141.Location = new System.Drawing.Point(860, 191);
            this.textBox141.Name = "textBox141";
            this.textBox141.Size = new System.Drawing.Size(26, 20);
            this.textBox141.TabIndex = 43;
            // 
            // textBox142
            // 
            this.textBox142.Location = new System.Drawing.Point(902, 191);
            this.textBox142.Name = "textBox142";
            this.textBox142.Size = new System.Drawing.Size(26, 20);
            this.textBox142.TabIndex = 44;
            // 
            // textBox143
            // 
            this.textBox143.Location = new System.Drawing.Point(934, 191);
            this.textBox143.Name = "textBox143";
            this.textBox143.Size = new System.Drawing.Size(26, 20);
            this.textBox143.TabIndex = 45;
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.ForeColor = System.Drawing.Color.Purple;
            this.label136.Location = new System.Drawing.Point(200, 215);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(47, 13);
            this.label136.TabIndex = 67;
            this.label136.Text = "label136";
            // 
            // textBox129
            // 
            this.textBox129.Location = new System.Drawing.Point(870, 81);
            this.textBox129.Name = "textBox129";
            this.textBox129.Size = new System.Drawing.Size(26, 20);
            this.textBox129.TabIndex = 21;
            // 
            // textBox133
            // 
            this.textBox133.Location = new System.Drawing.Point(870, 116);
            this.textBox133.Name = "textBox133";
            this.textBox133.Size = new System.Drawing.Size(26, 20);
            this.textBox133.TabIndex = 37;
            // 
            // textBox137
            // 
            this.textBox137.Location = new System.Drawing.Point(860, 153);
            this.textBox137.Name = "textBox137";
            this.textBox137.Size = new System.Drawing.Size(26, 20);
            this.textBox137.TabIndex = 40;
            // 
            // textBox138
            // 
            this.textBox138.Location = new System.Drawing.Point(902, 153);
            this.textBox138.Name = "textBox138";
            this.textBox138.Size = new System.Drawing.Size(26, 20);
            this.textBox138.TabIndex = 41;
            // 
            // textBox139
            // 
            this.textBox139.Location = new System.Drawing.Point(934, 153);
            this.textBox139.Name = "textBox139";
            this.textBox139.Size = new System.Drawing.Size(26, 20);
            this.textBox139.TabIndex = 42;
            // 
            // textBox84
            // 
            this.textBox84.Location = new System.Drawing.Point(757, 54);
            this.textBox84.Name = "textBox84";
            this.textBox84.Size = new System.Drawing.Size(35, 20);
            this.textBox84.TabIndex = 1;
            // 
            // textBox134
            // 
            this.textBox134.Location = new System.Drawing.Point(902, 116);
            this.textBox134.Name = "textBox134";
            this.textBox134.Size = new System.Drawing.Size(26, 20);
            this.textBox134.TabIndex = 38;
            // 
            // textBox135
            // 
            this.textBox135.Location = new System.Drawing.Point(934, 113);
            this.textBox135.Name = "textBox135";
            this.textBox135.Size = new System.Drawing.Size(26, 20);
            this.textBox135.TabIndex = 39;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(715, 57);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(36, 13);
            this.label85.TabIndex = 2;
            this.label85.Text = "Index:";
            // 
            // textBox130
            // 
            this.textBox130.Location = new System.Drawing.Point(902, 81);
            this.textBox130.Name = "textBox130";
            this.textBox130.Size = new System.Drawing.Size(26, 20);
            this.textBox130.TabIndex = 35;
            // 
            // textBox131
            // 
            this.textBox131.Location = new System.Drawing.Point(934, 80);
            this.textBox131.Name = "textBox131";
            this.textBox131.Size = new System.Drawing.Size(26, 20);
            this.textBox131.TabIndex = 36;
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.ForeColor = System.Drawing.Color.Purple;
            this.label135.Location = new System.Drawing.Point(200, 166);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(47, 13);
            this.label135.TabIndex = 65;
            this.label135.Text = "label135";
            // 
            // textBox148
            // 
            this.textBox148.Location = new System.Drawing.Point(762, 207);
            this.textBox148.Name = "textBox148";
            this.textBox148.Size = new System.Drawing.Size(30, 20);
            this.textBox148.TabIndex = 60;
            this.textBox148.Visible = false;
            // 
            // textBox140
            // 
            this.textBox140.Location = new System.Drawing.Point(762, 119);
            this.textBox140.Name = "textBox140";
            this.textBox140.Size = new System.Drawing.Size(30, 20);
            this.textBox140.TabIndex = 27;
            this.textBox140.Visible = false;
            // 
            // textBox144
            // 
            this.textBox144.Location = new System.Drawing.Point(762, 163);
            this.textBox144.Name = "textBox144";
            this.textBox144.Size = new System.Drawing.Size(30, 20);
            this.textBox144.TabIndex = 57;
            this.textBox144.Visible = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.label84);
            this.tabPage4.Controls.Add(this.textBox83);
            this.tabPage4.Controls.Add(this.label81);
            this.tabPage4.Controls.Add(this.textBox80);
            this.tabPage4.Controls.Add(this.label80);
            this.tabPage4.Controls.Add(this.label79);
            this.tabPage4.Controls.Add(this.textBox79);
            this.tabPage4.Controls.Add(this.label77);
            this.tabPage4.Controls.Add(this.textBox18);
            this.tabPage4.Controls.Add(this.textBox78);
            this.tabPage4.Controls.Add(this.label76);
            this.tabPage4.Controls.Add(this.textBox77);
            this.tabPage4.Controls.Add(this.label72);
            this.tabPage4.Controls.Add(this.label27);
            this.tabPage4.Controls.Add(this.textBox28);
            this.tabPage4.Controls.Add(this.textBox53);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.textBox27);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.textBox26);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1041, 598);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Other";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(96, 376);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(66, 13);
            this.label84.TabIndex = 70;
            this.label84.Text = "a_allowzone";
            // 
            // textBox83
            // 
            this.textBox83.Location = new System.Drawing.Point(170, 369);
            this.textBox83.Name = "textBox83";
            this.textBox83.Size = new System.Drawing.Size(100, 20);
            this.textBox83.TabIndex = 69;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(209, 187);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(77, 13);
            this.label81.TabIndex = 66;
            this.label81.Text = "a_summon_idx";
            // 
            // textBox80
            // 
            this.textBox80.Location = new System.Drawing.Point(290, 184);
            this.textBox80.Name = "textBox80";
            this.textBox80.Size = new System.Drawing.Size(100, 20);
            this.textBox80.TabIndex = 65;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(508, 81);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(81, 13);
            this.label80.TabIndex = 64;
            this.label80.Text = "a_soul_consum";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(508, 55);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(130, 13);
            this.label79.TabIndex = 63;
            this.label79.Text = "a_use_needWearingType";
            // 
            // textBox79
            // 
            this.textBox79.Location = new System.Drawing.Point(593, 78);
            this.textBox79.Name = "textBox79";
            this.textBox79.Size = new System.Drawing.Size(100, 20);
            this.textBox79.TabIndex = 62;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(18, 219);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(75, 13);
            this.label77.TabIndex = 61;
            this.label77.Text = "a_targetparam";
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.Color.Red;
            this.textBox18.Location = new System.Drawing.Point(644, 52);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(49, 20);
            this.textBox18.TabIndex = 42;
            // 
            // textBox78
            // 
            this.textBox78.Location = new System.Drawing.Point(99, 212);
            this.textBox78.Name = "textBox78";
            this.textBox78.Size = new System.Drawing.Size(58, 20);
            this.textBox78.TabIndex = 60;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(29, 174);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(64, 13);
            this.label76.TabIndex = 59;
            this.label76.Text = "a_selfparam";
            // 
            // textBox77
            // 
            this.textBox77.Location = new System.Drawing.Point(99, 170);
            this.textBox77.Name = "textBox77";
            this.textBox77.Size = new System.Drawing.Size(58, 20);
            this.textBox77.TabIndex = 58;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(29, 137);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(64, 13);
            this.label72.TabIndex = 56;
            this.label72.Text = "a_cd_after2";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(27, 104);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(108, 13);
            this.label27.TabIndex = 54;
            this.label27.Text = "a_appWeaponType1";
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(153, 97);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(100, 20);
            this.textBox28.TabIndex = 53;
            // 
            // textBox53
            // 
            this.textBox53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox53.Location = new System.Drawing.Point(99, 135);
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(58, 20);
            this.textBox53.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "a_appWeaponType0";
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(153, 65);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(100, 20);
            this.textBox27.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "a_appState";
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(99, 33);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(100, 20);
            this.textBox26.TabIndex = 49;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Lime;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(939, 653);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 31);
            this.button6.TabIndex = 58;
            this.button6.Text = "Save Level";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1040, 653);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 31);
            this.button2.TabIndex = 34;
            this.button2.Text = "Save Skill";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipTitle = "Information";
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label130.Location = new System.Drawing.Point(286, 658);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(66, 19);
            this.label130.TabIndex = 59;
            this.label130.Text = "label130";
            this.label130.Visible = false;
            // 
            // label131
            // 
            this.label131.AutoSize = true;
            this.label131.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label131.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label131.Location = new System.Drawing.Point(1076, 3);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(154, 16);
            this.label131.TabIndex = 60;
            this.label131.Text = "Current Language is :";
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLang.ForeColor = System.Drawing.Color.Crimson;
            this.lblLang.Location = new System.Drawing.Point(1230, 5);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(0, 16);
            this.lblLang.TabIndex = 104;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnSaveAndNext
            // 
            this.btnSaveAndNext.BackColor = System.Drawing.Color.Chartreuse;
            this.btnSaveAndNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAndNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndNext.Location = new System.Drawing.Point(1184, 653);
            this.btnSaveAndNext.Name = "btnSaveAndNext";
            this.btnSaveAndNext.Size = new System.Drawing.Size(143, 31);
            this.btnSaveAndNext.TabIndex = 105;
            this.btnSaveAndNext.Text = "Save Skill and Next";
            this.btnSaveAndNext.UseVisualStyleBackColor = false;
            this.btnSaveAndNext.Click += new System.EventHandler(this.btnSaveAndNext_Click);
            // 
            // SkillEditor
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1346, 691);
            this.Controls.Add(this.btnSaveAndNext);
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.label131);
            this.Controls.Add(this.label130);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SkillEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skill Editor EP4 V1.02";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.groupBox28.ResumeLayout(false);
            this.groupBox28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeedItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeedItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeedItem3)).EndInit();
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMagicIdx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMagicIdx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMagicIdx1)).EndInit();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbUseState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAppState)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            SkillPicker skillPicker = new SkillPicker(); //dethunter12 add
            if (skillPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox99.Text = Convert.ToString(skillPicker.SkillIndex); //sets text equal to id selected
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            SkillPicker skillPicker = new SkillPicker(); //dethunter12 add
            if (skillPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox101.Text = Convert.ToString(skillPicker.SkillIndex);
        }

        private void PbMagicIdx1_Click(object sender, EventArgs e)
        {

        }

        private void PbMagicIdx2_Click(object sender, EventArgs e)
        {

        }

        private void PbMagicIdx3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FlagBuilder flagBuilder = new FlagBuilder(); //dethunter12 add
            flagBuilder.flagSmall = Convert.ToInt32(textBox81.Text);
            flagBuilder.flagBuilderType = "skills2";
            if (flagBuilder.ShowDialog() != DialogResult.OK)
                return;
            textBox81.Text = Convert.ToString(flagBuilder.flagSmall);
        }

        private void PbUseState_Click(object sender, EventArgs e)
        {
            FlagBuilder flagBuilder = new FlagBuilder(); //dethunter12 add
            flagBuilder.flagSmall = Convert.ToInt32(textBox15.Text);
            flagBuilder.flagBuilderType = "skills1";
            if (flagBuilder.ShowDialog() != DialogResult.OK)
                return;
            textBox15.Text = Convert.ToString(flagBuilder.flagSmall);
        }

        private void PbAppState_Click(object sender, EventArgs e)
        {
            FlagBuilder flagBuilder = new FlagBuilder(); //dethunter12 add
            flagBuilder.flagSmall = Convert.ToInt32(textBox25.Text);
            flagBuilder.flagBuilderType = "skills1";
            if (flagBuilder.ShowDialog() != DialogResult.OK)
                return;
            textBox25.Text = Convert.ToString(flagBuilder.flagSmall);
        }

        private void btnCopy_Click(object sender, EventArgs e) //dethunter12 add
        {
         
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DROP TABLE IF EXISTS tempTable;" + "CREATE TEMPORARY TABLE tempTable ENGINE=MEMORY SELECT * FROM t_skill WHERE a_index=" + textBox1.Text + ";" + "SELECT a_index FROM tempTable;" + "UPDATE tempTable SET a_index=(SELECT a_index from t_skill ORDER BY a_index DESC LIMIT 1)+1; " + "SELECT a_index FROM tempTable;" + "INSERT INTO t_skill SELECT * FROM tempTable;");
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DROP TABLE IF EXISTS tempTable;" + "CREATE TEMPORARY TABLE tempTable ENGINE=MEMORY SELECT * FROM t_skillLevel WHERE a_index=" + textBox1.Text + ";" + "SELECT a_index FROM tempTable;" + "UPDATE tempTable SET a_index=(SELECT a_index from t_skillLevel ORDER BY a_index DESC LIMIT 1)+1; " + "SELECT a_index FROM tempTable;" + "INSERT INTO t_skillLevel SELECT * FROM tempTable;"); //test
            LoadListBox();
            LoadListBox2();
            if (textBox203.Text != "") //dethunter12 add 12/22/2019
                SearchList(textBox203.Text);
            listBox1.SelectedIndex = listBox1.Items.Count - 2; //test
            int num5 = (int)new CustomMessage("Copying Complete").ShowDialog();
        }

	private void CBPet_SelectedIndexChanged(object sender, EventArgs e) //dethunter12 5/6/2018
        {
            if (textBox82.Text != "0" && textBox2.Text == "11") //dethunter12 5/6/2018
            {
                mSortPet = GetIndexByComboBox(CBPet.Text).ToString();
                LoadListBox();
            } 
            else if (textBox82.Text != "0" && textBox2.Text != "11") //dethunter12 5/6/2018 to check if the skill has a pet value if it does and it isnt a pet dont load the value into the ComboBox
            {
                CBPet.SelectedIndex = 1;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) //dethunter12 test 5/7/2018
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) //dethunter12 5/7/2018
        {

        }

        private void btnSaveAndNext_Click(object sender, EventArgs e)
        {
            aname = StringFromLanguage(); //dethunter12 4/12/2018 language system modify
            aClientDescripton = ClientDescrFromLanguage(); //dethunter12 4/12/2018 language system 
            aToolTip = ToolTipFromLanguage(); //dethunter12 4/12/2018 modify 
            string str1 = "UPDATE t_skill SET " + "a_index = '" + textBox1.Text + "', " + "a_job = '" + textBox2.Text + "', " + "a_job2 = '" + textBox3.Text + "', ";
            string str2 = textBox4.Text.Replace("'", "\\'").Replace("\"", "\\\"");
            string Query = str1 + "a_name = '" + str2 + "', " + aname + "=" + " " + "'" + str2 + "', " + aClientDescripton + "=" + " " + "'" + textBox5.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_client_description = '" + textBox5.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "', " + "a_type = '" + textBox6.Text + "'," + "a_flag= '" + textBox7.Text + "'," + "a_maxLevel = '" + tbmaxLevel.Text + "'," + "a_appRange = '" + textBox9.Text + "'," + "a_fireRange = '" + textBox10.Text + "'," + "a_fireRange2 = '" + textBox11.Text + "'," + "a_minRange = '" + textBox12.Text + "'," + "a_targetType = '" + textBox13.Text + "'," + "a_targetNum = '" + textBox14.Text + "'," + "a_useState = '" + textBox15.Text + "'," + "a_useWeaponType0 = '" + textBox16.Text + "'," + "a_useWeaponType1 = '" + textBox17.Text + "'," + "a_use_needWearingType = '" + textBox18.Text + "'," + "a_useMagicIndex1 = '" + textBox19.Text + "'," + "a_useMagicIndex2 = '" + textBox20.Text + "'," + "a_useMagicIndex3 = '" + textBox21.Text + "'," + "a_useMagicLevel1 = '" + textBox22.Text + "'," + "a_useMagicLevel2 = '" + textBox23.Text + "'," + "a_useMagicLevel3 = '" + textBox24.Text + "'," + "a_appState = '" + textBox25.Text + "'," + "a_appWeaponType0 = '" + textBox26.Text + "'," + "a_appWeaponType1 = '" + textBox27.Text + "'," + "a_app_needWearingType = '" + textBox28.Text + "'," + "a_readyTime = '" + textBox29.Text + "'," + "a_stillTime = '" + textBox30.Text + "'," + "a_fireTime = '" + textBox31.Text + "'," + "a_reuseTime = '" + textBox32.Text + "'," + "a_cd_ra = '" + textBox33.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_re = '" + textBox34.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_sa = '" + textBox35.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fa = '" + textBox36.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fe0 = '" + textBox37.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fe1 = '" + textBox38.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fe2 = '" + textBox39.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fot = '" + textBox40.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fos = '" + textBox41.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_ox = '" + textBox42.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_oz = '" + textBox43.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_oh = '" + textBox44.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_oc = '" + textBox45.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fdc = '" + textBox46.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fd0 = '" + textBox47.Text.Replace(",", ".") + "'," + "a_cd_fd1 = '" + textBox48.Text.Replace(",", ".") + "'," + "a_cd_fd2 = '" + textBox49.Text.Replace(",", ".") + "'," + "a_cd_fd3 = '" + textBox50.Text.Replace(",", ".") + "'," + "a_cd_dd = '" + textBox51.Text + "'," + "a_cd_fe_after = '" + textBox52.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fe_after2 = '" + textBox53.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_client_tooltip = '" + textBox54.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + " " + aToolTip + "='" + textBox54.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_client_icon_texid = '" + textBox55.Text + "'," + "a_client_icon_row = '" + textBox56.Text + "'," + "a_client_icon_col = '" + textBox57.Text + "'," + "a_cd_ra2 = '" + textBox58.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_re2 = '" + textBox59.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_sa2 = '" + textBox60.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fa2 = '" + textBox61.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fe3 = '" + textBox62.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fe4 = '" + textBox63.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fe5 = '" + textBox64.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "'," + "a_cd_fot2 = '" + textBox65.Text + "'," + "a_cd_fos2 = '" + textBox66.Text + "'," + "a_cd_ox2 = '" + textBox67.Text + "'," + "a_cd_oz2 = '" + textBox68.Text + "'," + "a_cd_oh2 = '" + textBox69.Text + "'," + "a_cd_oc2 = '" + textBox70.Text + "'," + "a_cd_fdc2 = '" + textBox71.Text + "'," + "a_cd_fd4 = '" + textBox72.Text.Replace(",", ".") + "'," + "a_cd_fd5 = '" + textBox73.Text.Replace(",", ".") + "'," + "a_cd_fd6 = '" + textBox74.Text.Replace(",", ".") + "'," + "a_cd_fd7 = '" + textBox75.Text.Replace(",", ".") + "'," + "a_cd_dd2 = '" + textBox76.Text + "'," + "a_selfparam = '" + textBox77.Text + "'," + "a_targetparam = '" + textBox78.Text + "'," + "a_soul_consum = '" + textBox79.Text + "'," + "a_summon_idx = '" + textBox80.Text + "'," + "a_sorcerer_flag = '" + textBox81.Text + "'," + "a_apet_index = '" + textBox82.Text + "'," + "a_allowzone = '" + textBox83.Text + "'" + " WHERE a_index = '" + textBox1.Text + "'"; //dethunter12 4/12/2018 modify
            databaseHandle.SendQueryMySql(Host, User, Password, Database, Query);
            Console.WriteLine(Query);
            label130.Text = "Update Skill Succesfully!";
            label130.ForeColor = Color.Lime;
            label130.Visible = true;
            int selectedIndex = listBox1.SelectedIndex;
            int nextslected = listBox1.SelectedIndex + 1;
            if (textBox203.Text != "")
                SearchList(textBox203.Text);
            else
                LoadListBox();
            if (selectedIndex + 1 >= listBox1.Items.Count)
            {
                listBox1.SelectedIndex = selectedIndex;
            }
            else
                listBox1.SelectedIndex = nextslected;
        }

        private void BtnCopyLevel_Click(object sender, EventArgs e)
        {
            string Query = "INSERT INTO t_skillLevel (a_index, a_level) VALUES ('" + textBox1.Text + "', '" + Convert.ToString(listBox2.Items.Count + 1) + "')";
            Console.WriteLine(Query);
            databaseHandle.SendQueryMySql(Host, User, Password, Database, Query);
            LoadListBox2();
            listBox2.SelectedIndex = listBox2.Items.Count - 1;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox89.Text = Convert.ToString(3000); 
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            // per second * 10
            textBox89.Text = Convert.ToString(18000);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox89.Text = Convert.ToString(36000);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            textBox89.Text = Convert.ToString(864000);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            textBox89.Text = Convert.ToString(2592000);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            textBox89.Text = Convert.ToString(6048000);
        }

        private void SKILLSCOST0SPToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            string Query = "UPDATE t_skillLevel SET a_LearnSP = 0;";
            Console.WriteLine(Query);
            databaseHandle.SendQueryMySql(Host, User, Password, Database, Query);
        }

        private void SKILLSREQUIRENOITEMSToolStripMenuItem_Click(object sender, EventArgs e) // no items cast
        {
           
            string Query = "UPDATE t_skillLevel SET a_needItemIndex1 = -1, a_need_itemCount1 = 0, a_needItemIndex2 = -1, a_needItemCount2 = 0;";
            Console.WriteLine(Query);
            databaseHandle.SendQueryMySql(Host, User, Password, Database, Query);
        }

        private void SKILLSREQUIRENOITEMLEARNToolStripMenuItem_Click(object sender, EventArgs e) //no items learn
        {
            
            string Query = "UPDATE t_skillLevel SET a_learnItemIndex1 = -1, a_learnItemCount1 = 0, a_learnItemIndex2 = -1, a_learnItemCount2 = 0, a_learnItemIndex3 = -1, a_learnItemCount3 = 0;";
            Console.WriteLine(Query);
            databaseHandle.SendQueryMySql(Host, User, Password, Database, Query);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            textBox89.Text = Convert.ToString(72000);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            textBox89.Text = Convert.ToString(108000);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            textBox89.Text = Convert.ToString(216000);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            textBox89.Text = Convert.ToString(252000);
        }

        private void TbNeedLearn1_TextChanged(object sender, EventArgs e)
        {
            if (tbNeedLearn1.Text != "-1")
                pbNeedItem1.Image = databaseHandle.IconFast(Convert.ToInt32(tbNeedLearn1.Text));
            
              
        }

        private void TbNeedLearn2_TextChanged(object sender, EventArgs e)
        {
            if (tbNeedLearn2.Text != "")
                pbNeedItem2.Image = databaseHandle.IconFast(Convert.ToInt32(tbNeedLearn2.Text));

        }

        private void TbNeedLearn3_TextChanged(object sender, EventArgs e)
        {
            if (tbNeedLearn3.Text != "")
                pbNeedItem3.Image = databaseHandle.IconFast(Convert.ToInt32(tbNeedLearn3.Text));
        }

        private void exportStrSkillsusalodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExport f2 = new FormExport();
            f2.Show(); // Shows Form2
        }

        private void cbSkillLevel_SelectedIndexChanged(object sender, EventArgs e) //dethunter12 add 7/26/2020
        {
            
        }

        private void cbMagicLevel_SelectedIndexChanged(object sender, EventArgs e)  //dethunter12 add 7/26/2020
        {

        }
    }
}
