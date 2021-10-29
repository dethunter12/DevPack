// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.Tools.MagicEditor
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
  public class MagicEditor : Form
  {
    public static Connection connection = new Connection();
    private string Host = MagicEditor.connection.ReadSettings("Host");
    private string User = MagicEditor.connection.ReadSettings("User");
    private string Password = MagicEditor.connection.ReadSettings("Password");
    private string Database = MagicEditor.connection.ReadSettings("Database");
    private DatabaseHandle databaseHandle = new DatabaseHandle();
    public string[] menuArray = new string[2]
    {
      "a_index",
      "a_name"
    };
    private IContainer components = (IContainer) null;
    private GroupBox groupBox1;
    private Button button2;
    private Button button1;
    private ListBox listBox1;
    private GroupBox groupBox2;
    private Label label4;
    private Label label1;
    private TextBox textBox2;
    private TextBox textBox1;
    private GroupBox groupBox3;
    private TextBox textBox3;
    private Label label2;
    private Label label6;
    private Label label5;
    private TextBox textBox6;
    private Label label3;
    private TextBox textBox5;
    private TextBox textBox4;
    private GroupBox groupBox4;
    private Label label12;
    private TextBox textBox12;
    private Label label11;
    private TextBox textBox11;
    private Label label10;
    private Label label9;
    private TextBox textBox10;
    private TextBox textBox9;
    private Label label8;
    private TextBox textBox8;
    private Label label7;
    private TextBox textBox7;
    private GroupBox groupBox5;
    private DataGridView dgItems;
    private ToolStrip toolStrip2;
    private ToolStripButton btnDeleteSelected;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripButton btnAddItems;
    private ToolStripSeparator toolStripSeparator6;
    private ToolStripButton toolStripButton1;
    private DataGridViewTextBoxColumn index;
    private DataGridViewTextBoxColumn Level;
    private DataGridViewTextBoxColumn Power;
    private DataGridViewTextBoxColumn HitRate;
    private Button button3;
    private ComboBox comboBox3;
    private ComboBox comboBox2;
    private ComboBox comboBox1;
    private TextBox textBox13;
    private Label label14;
    private ComboBox comboBox4;
    private GroupBox groupBox6;
    private Label label13;
        private ComboBox cbSubType1;
        private ComboBox cbSubType2;
        private ComboBox cbSubType10;
        private ComboBox cbSubType8;
        private ComboBox cbSubType9;
        private ComboBox cbSubType7;
        private ComboBox cbSubType5;
        private ComboBox cbSubType6;
        private ComboBox cbSubType4;
        private ComboBox cbSubType3;
        private TextBox tbSubtype;
        private TextBox textBox14;

    public MagicEditor()
    {
            InitializeComponent();
    }

    private void LoadListBox()
    {
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_index, a_name, a_maxlevel, a_type, a_subtype, a_damagetype, a_hittype, a_attribute, a_psp, a_ptp, a_hsp, a_htp, a_togle from t_magic ORDER BY a_index;");
    }

    public void Sort(string category)
    {
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_ctid, a_ctname from t_catalog WHERE a_category ='" + category + "'");
    }

    private void MagicEditor_Load(object sender, EventArgs e)
    {
            LoadStartUp();
            LoadListBox();
            SelectBoxes();
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
      string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, " SELECT a_index, a_name, a_maxlevel, a_type, a_subtype, a_damagetype, a_hittype, a_attribute, a_psp, a_ptp, a_hsp, a_htp, a_togle  from t_magic WHERE a_index ='" + textBox1.Text + "';", new string[13]
      {
        "a_index",
        "a_name",
        "a_maxlevel",
        "a_type",
        "a_subtype",
        "a_damagetype",
        "a_hittype",
        "a_attribute",
        "a_psp",
        "a_ptp",
        "a_hsp",
        "a_htp",
        "a_togle"
      });
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
            tbSubtype.Text = strArray[4];
            SelectBoxes();
          //LoadMisc();
            dgItems.Rows.Clear();
            LoadDG(textBox1.Text);
    }

        private void SelectBoxes() //dethunter12 add
        {
            int num1 = comboBox1.FindString(textBox4.Text);
            int num2 = comboBox2.FindString(textBox5.Text);
            int num3 = comboBox3.FindString(textBox6.Text);
            int num4 = comboBox4.FindString(textBox7.Text);
            int num5 = cbSubType1.FindString(textBox5.Text);
            int num6 = cbSubType2.FindString(textBox5.Text);
            int num7 = cbSubType3.FindString(textBox5.Text);
            int num8 = cbSubType4.FindString(textBox5.Text);
            int num9 = cbSubType5.FindString(textBox5.Text);
            int num10 = cbSubType6.FindString(textBox5.Text);
            int num11 = cbSubType7.FindString(textBox5.Text);
            int num12 = cbSubType8.FindString(textBox5.Text);
            int num13 = cbSubType9.FindString(textBox5.Text);
            int num14 = cbSubType10.FindString(textBox5.Text);
            comboBox1.SelectedIndex = num1;
            comboBox2.SelectedIndex = num2;
            comboBox3.SelectedIndex = num3;
            comboBox4.SelectedIndex = num4;
            cbSubType1.SelectedIndex = num5;
            cbSubType2.SelectedIndex = num6;
            cbSubType3.SelectedIndex = num7;
            cbSubType4.SelectedIndex = num8;
            cbSubType5.SelectedIndex = num9;
            cbSubType6.SelectedIndex = num10;
            cbSubType7.SelectedIndex = num11;
            cbSubType8.SelectedIndex = num12;
            cbSubType9.SelectedIndex = num13;
            cbSubType10.SelectedIndex = num14;

        }

        public void LoadDG(string strIndex)
    {
            dgItems.Rows.Clear();
      string str = "SELECT * FROM t_magicLevel WHERE  a_index ='+" + strIndex + "' ORDER BY a_level";
      MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
      MySqlCommand command = mySqlConnection.CreateCommand();
      command.CommandText = str;
      mySqlConnection.Open();
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (mySqlDataReader.Read())
                dgItems.Rows.Add( mySqlDataReader.GetValue(0).ToString(),  mySqlDataReader.GetValue(1).ToString(),  mySqlDataReader.GetValue(2).ToString(),  mySqlDataReader.GetValue(3).ToString());
      mySqlConnection.Close();
    }

    private void button3_Click(object sender, EventArgs e)
    {
            //databaseHandle.SendQueryMySql(Host, User, Password, Database, Query: $"UPDATE t_magic SET a_name = '{textBox2.Text}', a_maxlevel = '{textBox3.Text}', a_type = '{textBox4.Text}', a_subtype = '{textBox5.Text}', a_damagetype = '{textBox6.Text}', a_hittype = '{textBox7.Text}', a_attribute = '{textBox8.Text}', a_psp = '{textBox9.Text}', a_ptp = '{textBox10.Text}', a_hsp = '{textBox11.Text}', a_htp = '{textBox12.Text}', a_togle = '{textBox13.Text}' WHERE a_index = '{textBox1.Text}'");
            string str9 = "UPDATE t_magic SET " + "a_index = '" + textBox1.Text + "', " + "a_type = '" + textBox4.Text + "', " + "a_subtype = '" + textBox5.Text + "', ";
            string str10 = textBox2.Text.Replace("'", "\\'").Replace("\"", "\\\"");
            string QueryUpdate = str9 + "a_name = '" + str10 + "', " + "a_maxlevel = '" + textBox3.Text + "'," + "a_damagetype = '" + textBox6.Text + "'," + "a_hittype = '" + textBox7.Text + "'," + "a_attribute = '" + textBox8.Text + "'," + "a_psp = '" + textBox9.Text + "'," + "a_ptp = '" + textBox10.Text + "'," + "a_hsp = '" + textBox11.Text + "'," + "a_htp = '" + textBox12.Text + "'," + "a_togle = '" + textBox13.Text + "'" + " WHERE a_index = '" + textBox1.Text + "'";
            databaseHandle.SendQueryMySql(Host, User, Password, Database, QueryUpdate); //dethunter12 add
            Console.WriteLine(QueryUpdate); //dethunter12 add
            int selectedIndex = listBox1.SelectedIndex;
            int num4 = (int)new CustomMessage("Done :)").ShowDialog();
            if (textBox14.Text != "") //dethunter12 add
                SearchList(textBox14.Text);
      else
                LoadListBox();
            listBox1.SelectedIndex = selectedIndex;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string str1 = "";
      string str2 = "select * from t_magic order by a_index DESC Limit 0,1";
      MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
      MySqlCommand command = mySqlConnection.CreateCommand();
      command.CommandText = str2;
      mySqlConnection.Open();
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (mySqlDataReader.Read())
        str1 = mySqlDataReader.GetValue(0).ToString();
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "INSERT INTO t_magic (a_index, a_name) VALUES ('" + (Convert.ToInt32(str1) + 1).ToString() + "', 'New Magic Skill')");
            LoadListBox();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      int selectedIndex = listBox1.SelectedIndex;
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_magic WHERE a_index = '" + textBox1.Text + "'");
            LoadListBox();
            listBox1.SelectedIndex = selectedIndex - 1;
            int num4 = (int)new CustomMessage("Deleted :O").ShowDialog();
        }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
    }

    private void btnDeleteSelected_Click(object sender, EventArgs e) //saveitem
    {
      DataGridViewRow row = dgItems.Rows[dgItems.CurrentRow.Index];

            string str1 = Convert.ToString(row.Cells["index"].Value);
      string str2 = Convert.ToString(row.Cells["Level"].Value);
            string str3 = Convert.ToString(row.Cells["Power"].Value);
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_magicLevel SET " + "a_power = '" + Convert.ToString(row.Cells["Power"].Value) + "', " + "a_hitrate = '" + Convert.ToString(row.Cells["HitRate"].Value) + "' " + "WHERE a_index = '" + str1 + "' AND a_level = '" + str2 + "'");
            
            row.SetValues(str1, str2, str3);
            dgItems.Rows.Clear();
            LoadDG(textBox1.Text);
    }

    private void btnAddItems_Click(object sender, EventArgs e)
    {
      int num1 = databaseHandle.CountByRow(Host, User, Password, Database, "SELECT COUNT(*) FROM t_magicLevel WHERE a_index = '" + textBox1.Text + "' ") + 1;
      try
      {
                databaseHandle.SendQueryMySql(Host, User, Password, Database, "INSERT INTO t_magicLevel (a_index, a_level, a_power, a_hitrate) VALUES (" + textBox1.Text + ", '" + num1.ToString() + "', 0, 0)");
      }
      catch
      {
        int num2 = (int) MessageBox.Show("Duplicated ItemID isn't allowed.", "Error");
      }
            dgItems.Rows.Clear();
            LoadDG(textBox1.Text);
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      DataGridViewRow row = dgItems.Rows[dgItems.CurrentRow.Index];
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_magicLevel WHERE a_index ='" + Convert.ToString(row.Cells["index"].Value) + "' AND a_level = '" + Convert.ToString(row.Cells["Level"].Value) + "'");
            dgItems.Rows.Clear();
            LoadDG(textBox1.Text);
    }

    public void SearchList(string searchString)
    {
      searchString = searchString.Replace("\\", "\\\\").Replace("'", "\\'");
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_index, a_name from t_magic WHERE a_name LIKE '%" + searchString + "%' OR a_index LIKE '" + searchString + "' ORDER BY a_index;");
    }

    private void LoadStartUp()
    {
            comboBox1.Items.AddRange(new object[11]
      {
         "0 - Stat",
         "1 - Attribute",
         "2 - Assist",
         "3 - Attack",
         "4 - Recover",
         "5 - Cure",
         "6 - Other",
         "7 - Reduce",
         "8 - Immune",
         "9 - Castle War",
         "10 - Money"
      });
            comboBox3.Items.AddRange(new object[3]
      {
         "0 - Only Power",
         "1 - Addition",
         "2 - Rate"
      });
            comboBox4.Items.AddRange(new object[2]
      {
         "0 - Constant",
         "1 - Varible"
      });
            comboBox2.Items.AddRange(new object[39] //dethunter12 add
{
         "0 - Attack",
         "1 - Defense",
         "2 - Magic",
         "3 - Resist",
         "4 - Hitrate",
         "5 - Avoid",
         "6 - Critical",
         "7 - Attack Speed",
         "8 - MagicS peed",
         "9 - Move Speed",
         "10 - Recover HP",
         "11 - Recover MP",
         "12 - Max HP",
         "13 - Max MP",
         "14 - Deadldy",
         "15 - Magic Hitrate",
         "16 - Magic Avoid",
         "17 - AttackDist",
         "18 - Attack Melee",
         "19 - Attack Range",
         "20 - Hitrate Skill",
         "21 - Attack 80",
         "22 - Max Hp 450",
         "23 - Skill Speed",
         "24 - Valor",
         "25 - Statpall",
         "26 - Attack Per",
         "27 - Defense Per",
         "28 - Statpall Per",
         "29 - STR",
         "30 - DEX",
         "31 - INT",
         "32 - CON",
         "33 - Hard",
         "34 - Strong",
         "35 - NPC Attack",
         "36 - NPC Magic",
         "37 - Skill Cool Time",
         "38 - Decrase Mana Spend"
});
            cbSubType1.Items.AddRange(new object[8] //dethunter12 add
    {
         "0 - None",
         "1 - Fire",
         "2 - Water",
         "3 - Earth",
         "4 - Wind",
         "5 - Dark",
         "6 - Light",
         "7 - Random"
        });
            cbSubType2.Items.AddRange(new object[56] //dethunter12 add
    {
        "0 - Posion",
        "1 - Hold",
        "2 - Confusion",
        "3 - Stone",
        "4 - Silent",
        "5 - Blood",
        "6 - Blind",
        "7 - Sturn",
        "8 - Sleep",
        "9 - HP",
        "10 - MP",
        "11 - Move Speed",
        "12 - HP Cancel",
        "13 - MP Cancel",
        "14 - Dizzy",
        "15 - Invisible",
        "16 - Sloth",
        "17 - Fear",
        "18 - Fake Death",
        "19 - Perfect Body",
        "20 - Frenzy",
        "21 - Damagelink",
        "22 - Berserk",
        "23 - Despair",
        "24 - Manascreen",
        "25 - Bless",
        "26 - Safeguard",
        "27 - Mantle",
        "28 - Guard",
        "29 - Charge Attack",
        "30 - Charge Magic",
        "31 - Disease",
        "32 - Curse",
        "33 - Confused",
        "34 - Taming",
        "35 - Freeze",
        "36 - Inverse Damage",
        "37 - HP Dot",
        "38 - Rebirth",
        "39 - Darkness Mode",
        "40 - Aura Darkness",
        "41 - Aura Weakness",
        "42 - Aura Illusion",
        "43 - Mercenary",
        "44 - Soul Totem Buff",
        "45 - Soul Totem Attack",
        "46 - Trap",
        "47 - Parasite",
        "48 - Suicide",
        "49 - Invincibilty",
        "50 - GPS",
        "51 - Attack Tower",
        "52 - Artifact GPS",
        "53 - Totem Item Buff",
        "54 - Totem Item Attack",
        "55 - Heal % Reduction"
    });
            cbSubType3.Items.AddRange(new object[6] //dethunter12 add
    {
         "0 - Normal",
         "1 - Critical",
         "2 - Drain",
         "3 - One Shot Kill",
         "4 - Deadly",
         "5 - Hard"
    });
            cbSubType4.Items.AddRange(new object[6] //dethunter12 add
    {
         "0 - HP",
         "1 - MP",
         "2 - STM",
         "3 - Faith",
         "4 - EXP",
         "5 - SP"
    });
            cbSubType5.Items.AddRange(new object[16]  //dethunter12 add
    {
        "0 - Posion",
        "1 - Hold",
        "2 - Confusion",
        "3 - Stone",
        "4 - Silent",
        "5 - Blood",
        "6 - Rebirth",
        "7 - Invisible",
        "8 - Sturn",
        "9 - Sloth",
        "10 - Not Help",
        "11 - Blind",
        "12 - Disease",
        "13 - Curse",
        "14 - All",
        "15 - Instant Death"
    });
            cbSubType6.Items.AddRange(new object[31] //dethunter12 add
    {
         "0 - Instant Death",
         "1 - Skill Cancel",
         "2 - Tackle",
         "3 - Tackle2",
         "4 - Reflex",
         "5 - Death EXP Plus",
         "6 - Death SP Plus",
         "7 - Telekinesis",
         "8 - Tount",
         "9 - Summon",
         "10 -  Evocation",
         "11 - Targetfree",
         "12 - Curse",
         "13 - Peace",
         "14 - Soul Drain",
         "15 - Knockback",
         "16 - Warp",
         "17 - Fly",
         "18 - EXP",
         "19 - SP",
         "20 - Itemdrop",
         "21 - Skill",
         "22 - PK Disposition",
         "23 - Affinity",
         "24 - Affinity Quest",
         "25 - Affinity Monster",
         "26 - Affinity Item",
         "27 - Quest Exp",
         "28 - Guild Party Exp",
         "29 - Guild Party Sp",
         "30 - Summon NPC"
    });
            cbSubType7.Items.AddRange(new object[4] //dethunter12 add
    {
         "0 - Melee",
         "1 - Range",
         "2 - Magic",
         "3 - Skill"
    });
            cbSubType8.Items.AddRange(new object[1] //dethunter12 add
    {
         "0 - Blind"
    });
            cbSubType9.Items.AddRange(new object[7] //dethunter12 add
    {
         "0 - Melee",
         "1 - Range",
         "2 - Magic",
         "3 - Max HP",
         "4 - Defense",
         "5 - Resist",
         "6 - Tower Attack"
    });
            cbSubType10.Items.AddRange(new object[3] //dethunter12 add
    {
         "0 - Buy",
         "1 - Sell",
         "2 - Nas"
    });
        }

    public static string[] SubTypes(int Type)
    {
      List<string> stringList = new List<string>();
      switch (Type)
      {
        case 0:
          stringList.Add("0 - Attack");
          stringList.Add("1 - Defense");
          stringList.Add("2 - Magic");
          stringList.Add("3 - Resist");
          stringList.Add("4 - Hitrate");
          stringList.Add("5 - Avoid");
          stringList.Add("6 - Critical");
          stringList.Add("7 - Attack Speed");
          stringList.Add("8 - MagicS peed");
          stringList.Add("9 - Move Speed");
          stringList.Add("10 - Recover HP");
          stringList.Add("11 - Recover MP");
          stringList.Add("12 - Max HP");
          stringList.Add("13 - Max MP");
          stringList.Add("14 - Deadldy");
          stringList.Add("15 - MagicH itrate");
          stringList.Add("16 - Magic Avoid");
          stringList.Add("17 - AttackDist");
          stringList.Add("18 - Attack Melee");
          stringList.Add("19 - Attack Range");
          stringList.Add("20 - Hitrate Skill");
          stringList.Add("21 - Attack 80");
          stringList.Add("22 - Max Hp 450");
          stringList.Add("23 - Skill Speed");
          stringList.Add("24 - Valor");
          stringList.Add("25 - Statpall");
          stringList.Add("26 - Attack Per");
          stringList.Add("27 - Defense Per");
          stringList.Add("28 - Statpall Per");
          stringList.Add("29 - STR");
          stringList.Add("30 - DEX");
          stringList.Add("31 - INT");
          stringList.Add("32 - CON");
          stringList.Add("33 - Hard");
          stringList.Add("34 - Strong");
          stringList.Add("35 - NPC Attack");
          stringList.Add("36 - NPC Magic");
          stringList.Add("37 - Skill Cool Time");
          stringList.Add("38 - Decrase Mana Spend");
          break;
        case 1:
          stringList.Add("0 - None");
          stringList.Add("1 - Fire");
          stringList.Add("2 - Water");
          stringList.Add("3 - Earth");
          stringList.Add("4 - Wind");
          stringList.Add("5 - Dark");
          stringList.Add("6 - Light");
          stringList.Add("7 - Random");
          break;
        case 2:
          stringList.Add("0 - Posion");
          stringList.Add("1 - Hold");
          stringList.Add("2 - Confusion");
          stringList.Add("3 - Stone");
          stringList.Add("4 - Silent");
          stringList.Add("5 - Blood");
          stringList.Add("6 - Blind");
          stringList.Add("7 - Sturn");
          stringList.Add("8 - Sleep");
          stringList.Add("9 - HP");
          stringList.Add("10 - MP");
          stringList.Add("11 - Move Speed");
          stringList.Add("12 - HP Cancel");
          stringList.Add("13 - MP Cancel");
          stringList.Add("14 - Dizzy");
          stringList.Add("15 - Invisible");
          stringList.Add("16 - Sloth");
          stringList.Add("17 - Fear");
          stringList.Add("18 - Fake Death");
          stringList.Add("19 - Perfect Body");
          stringList.Add("20 - Frenzy");
          stringList.Add("21 - Damagelink");
          stringList.Add("22 - Berserk");
          stringList.Add("23 - Despair");
          stringList.Add("24 - Manascreen");
          stringList.Add("25 - Bless");
          stringList.Add("26 - Safeguard");
          stringList.Add("27 - Mantle");
          stringList.Add("28 - Guard");
          stringList.Add("29 - Charge Attack");
          stringList.Add("30 - Charge Magic");
          stringList.Add("31 - Disease");
          stringList.Add("32 - Curse");
          stringList.Add("33 - Confused");
          stringList.Add("34 - Taming");
          stringList.Add("35 - Freeze");
          stringList.Add("36 - Inverse Damage");
          stringList.Add("37 - HP Dot");
          stringList.Add("38 - Rebirth");
          stringList.Add("39 - Darkness Mode");
          stringList.Add("40 - Aura Darkness");
          stringList.Add("41 - Aura Weakness");
          stringList.Add("42 - Aura Illusion");
          stringList.Add("43 - Mercenary");
          stringList.Add("44 - Soul Totem Buff");
          stringList.Add("45 - Soul Totem Attack");
          stringList.Add("46 - Trap");
          stringList.Add("47 - Parasite");
          stringList.Add("48 - Suicide");
          stringList.Add("49 - Invincibilty");
          stringList.Add("50 - GPS");
          stringList.Add("51 - Attack Tower");
          stringList.Add("52 - Artifact GPS");
          stringList.Add("53 - Totem Item Buff");
          stringList.Add("54 - Totem Item Attack");
          stringList.Add("55 - Heal % Reduction");
          break;
        case 3:
          stringList.Add("0 - Normal");
          stringList.Add("1 - Critical");
          stringList.Add("2 - Drain");
          stringList.Add("3 - One Shot Kill");
          stringList.Add("4 - Deadly");
          stringList.Add("5 - Hard");
          break;
        case 4:
          stringList.Add("0 - HP");
          stringList.Add("1 - MP");
          stringList.Add("2 - STM");
          stringList.Add("3 - Faith");
          stringList.Add("4 - EXP");
          stringList.Add("5 - SP");
          break;
        case 5:
          stringList.Add("0 - Posion");
          stringList.Add("1 - Hold");
          stringList.Add("2 - Confusion");
          stringList.Add("3 - Stone");
          stringList.Add("4 - Silent");
          stringList.Add("5 - Blood");
          stringList.Add("6 - Rebirth");
          stringList.Add("7 - Invisible");
          stringList.Add("8 - Sturn");
          stringList.Add("9 - Sloth");
          stringList.Add("10 - Not Help");
          stringList.Add("11 - Blind");
          stringList.Add("12 - Disease");
          stringList.Add("13 - Curse");
          stringList.Add("14 - All");
          stringList.Add("15 - Instant Death");
          break;
        case 6:
          stringList.Add("0 - Instant Death");
          stringList.Add("1 - Skill Cancel");
          stringList.Add("2 - Tackle");
          stringList.Add("3 - Tackle2");
          stringList.Add("4 - Reflex");
          stringList.Add("5 - Death EXP Plus");
          stringList.Add("6 - Death SP Plus");
          stringList.Add("7 - Telekinesis");
          stringList.Add("8 - Tount");
          stringList.Add("9 - Summon");
          stringList.Add("10  Evocation");
          stringList.Add("11 - Targetfree");
          stringList.Add("12 - Curse");
          stringList.Add("13 - Peace");
          stringList.Add("14 - Soul Drain");
          stringList.Add("15 - Knockback");
          stringList.Add("16 - Warp");
          stringList.Add("17 - Fly");
          stringList.Add("18 - EXP");
          stringList.Add("19 - SP");
          stringList.Add("20 - Itemdrop");
          stringList.Add("21 - Skill");
          stringList.Add("22 - PK Disposition");
          stringList.Add("23 - Affinity");
          stringList.Add("24 - Affinity Quest");
          stringList.Add("25 - Affinity Monster");
          stringList.Add("26 - Affinity Item");
          stringList.Add("27 - Quest Exp");
          stringList.Add("28 - Guild Party Exp");
          stringList.Add("29 - Guild Party Sp");
          stringList.Add("30 - Summon NPC");
          break;
        case 7:
          stringList.Add("0 - Melee");
          stringList.Add("1 - Range");
          stringList.Add("2 - Magic");
          stringList.Add("3 - Skill");
          break;
        case 8:
          stringList.Add("0 - Blind");
          break;
        case 9:
          stringList.Add("0 - Melee");
          stringList.Add("1 - Range");
          stringList.Add("2 - Magic");
          stringList.Add("3 - Max HP");
          stringList.Add("4 - Defense");
          stringList.Add("5 - Resist");
          stringList.Add("6 - Tower Attack");
          break;
        case 10:
          stringList.Add("0 - Buy");
          stringList.Add("1 - Sell");
          stringList.Add("2 - Nas");
          break;
        default:
          stringList.Add("-1 - Unknown");
          break;
      }
      return stringList.ToArray();
            
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

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //dethunter12 add
    {
            textBox4.Text = comboBox1.SelectedIndex.ToString();
            if (textBox4.Text == "0") //dethunter12 add
            {
                comboBox2.Visible = true;
                cbSubType1.Visible = false;
                cbSubType2.Visible = false;
                cbSubType3.Visible = false;
                cbSubType4.Visible = false;
                cbSubType5.Visible = false;
                cbSubType6.Visible = false;
                cbSubType7.Visible = false;
                cbSubType8.Visible = false;
                cbSubType9.Visible = false;
                cbSubType10.Visible = false;

            }
            else if (textBox4.Text == "1")
            {
                comboBox2.Visible = false;
                cbSubType1.Visible = true;
                cbSubType2.Visible = false;
                cbSubType3.Visible = false;
                cbSubType4.Visible = false;
                cbSubType5.Visible = false;
                cbSubType6.Visible = false;
                cbSubType7.Visible = false;
                cbSubType8.Visible = false;
                cbSubType9.Visible = false;
                cbSubType10.Visible = false;
            }
            else if (textBox4.Text == "2")
            {
                comboBox2.Visible = false;
                cbSubType1.Visible = false;
                cbSubType2.Visible = true;
                cbSubType3.Visible = false;
                cbSubType4.Visible = false;
                cbSubType5.Visible = false;
                cbSubType6.Visible = false;
                cbSubType7.Visible = false;
                cbSubType8.Visible = false;
                cbSubType9.Visible = false;
                cbSubType10.Visible = false;
            }
            else if (textBox4.Text == "3")
            {
                comboBox2.Visible = false;
                cbSubType1.Visible = false;
                cbSubType2.Visible = false;
                cbSubType3.Visible = true;
                cbSubType4.Visible = false;
                cbSubType5.Visible = false;
                cbSubType6.Visible = false;
                cbSubType7.Visible = false;
                cbSubType8.Visible = false;
                cbSubType9.Visible = false;
                cbSubType10.Visible = false;
            }
            else if (textBox4.Text == "4")
            {
                comboBox2.Visible = false;
                cbSubType1.Visible = false;
                cbSubType2.Visible = false;
                cbSubType3.Visible = false;
                cbSubType4.Visible = true;
                cbSubType5.Visible = false;
                cbSubType6.Visible = false;
                cbSubType7.Visible = false;
                cbSubType8.Visible = false;
                cbSubType9.Visible = false;
                cbSubType10.Visible = false;
            }
            else if (textBox4.Text == "5")
            {
                comboBox2.Visible = false;
                cbSubType1.Visible = false;
                cbSubType2.Visible = false;
                cbSubType3.Visible = false;
                cbSubType4.Visible = false;
                cbSubType5.Visible = true;
                cbSubType6.Visible = false;
                cbSubType7.Visible = false;
                cbSubType8.Visible = false;
                cbSubType9.Visible = false;
                cbSubType10.Visible = false;
            }
            else if (textBox4.Text == "6")
            {
                comboBox2.Visible = false;
                cbSubType1.Visible = false;
                cbSubType2.Visible = false;
                cbSubType3.Visible = false;
                cbSubType4.Visible = false;
                cbSubType5.Visible = false;
                cbSubType6.Visible = true;
                cbSubType7.Visible = false;
                cbSubType8.Visible = false;
                cbSubType9.Visible = false;
                cbSubType10.Visible = false;
            }
            else if (textBox4.Text == "7")
            {
                comboBox2.Visible = false;
                cbSubType1.Visible = false;
                cbSubType2.Visible = false;
                cbSubType3.Visible = false;
                cbSubType4.Visible = false;
                cbSubType5.Visible = false;
                cbSubType6.Visible = false;
                cbSubType7.Visible = true;
                cbSubType8.Visible = false;
                cbSubType9.Visible = false;
                cbSubType10.Visible = false;
            }
            else if (textBox4.Text == "8")
            {
                comboBox2.Visible = false;
                cbSubType1.Visible = false;
                cbSubType2.Visible = false;
                cbSubType3.Visible = false;
                cbSubType4.Visible = false;
                cbSubType5.Visible = false;
                cbSubType6.Visible = false;
                cbSubType7.Visible = false;
                cbSubType8.Visible = true;
                cbSubType9.Visible = false;
                cbSubType10.Visible = false;
            }
            else if (textBox4.Text == "9")
            {
                comboBox2.Visible = false;
                cbSubType1.Visible = false;
                cbSubType2.Visible = false;
                cbSubType3.Visible = false;
                cbSubType4.Visible = false;
                cbSubType5.Visible = false;
                cbSubType6.Visible = false;
                cbSubType7.Visible = false;
                cbSubType8.Visible = false;
                cbSubType9.Visible = true;
                cbSubType10.Visible = false;
            }
            else if (textBox4.Text == "10")
            {
                comboBox2.Visible = false;
                cbSubType1.Visible = false;
                cbSubType2.Visible = false;
                cbSubType3.Visible = false;
                cbSubType4.Visible = false;
                cbSubType5.Visible = false;
                cbSubType6.Visible = false;
                cbSubType7.Visible = false;
                cbSubType8.Visible = false;
                cbSubType9.Visible = false;
                cbSubType10.Visible = true;
            }

         // LoadMisc();
    }


    private void textBox6_TextChanged(object sender, EventArgs e)
    {
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
            if (textBox4.Text == "0") //dethunter12 add ( save magic index fix)
            {
                textBox5.Text = GetIndexByComboBox(comboBox2.Text).ToString();
            }
        }

    private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox6.Text = GetIndexByComboBox(comboBox3.Text).ToString();
    }

    private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox7.Text = GetIndexByComboBox(comboBox4.Text).ToString();
    }

    private void textBox14_TextChanged(object sender, EventArgs e)
    {
            SearchList(textBox14.Text);
    }

    private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void groupBox6_Enter(object sender, EventArgs e)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagicEditor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbSubType10 = new System.Windows.Forms.ComboBox();
            this.cbSubType8 = new System.Windows.Forms.ComboBox();
            this.cbSubType9 = new System.Windows.Forms.ComboBox();
            this.cbSubType7 = new System.Windows.Forms.ComboBox();
            this.cbSubType5 = new System.Windows.Forms.ComboBox();
            this.cbSubType6 = new System.Windows.Forms.ComboBox();
            this.cbSubType2 = new System.Windows.Forms.ComboBox();
            this.cbSubType4 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.cbSubType3 = new System.Windows.Forms.ComboBox();
            this.cbSubType1 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HitRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnDeleteSelected = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddItems = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.tbSubtype = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 577);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Magics";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(117, 502);
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
            this.button1.Location = new System.Drawing.Point(6, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 459);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(241, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 133);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main";
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
            this.textBox2.Size = new System.Drawing.Size(179, 20);
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
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(185, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(48, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "MaxLevel:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbSubType10);
            this.groupBox3.Controls.Add(this.cbSubType8);
            this.groupBox3.Controls.Add(this.cbSubType9);
            this.groupBox3.Controls.Add(this.cbSubType7);
            this.groupBox3.Controls.Add(this.cbSubType5);
            this.groupBox3.Controls.Add(this.cbSubType6);
            this.groupBox3.Controls.Add(this.cbSubType2);
            this.groupBox3.Controls.Add(this.cbSubType4);
            this.groupBox3.Controls.Add(this.comboBox4);
            this.groupBox3.Controls.Add(this.cbSubType3);
            this.groupBox3.Controls.Add(this.cbSubType1);
            this.groupBox3.Controls.Add(this.comboBox3);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(491, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 133);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type";
            // 
            // cbSubType10
            // 
            this.cbSubType10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSubType10.FormattingEnabled = true;
            this.cbSubType10.Location = new System.Drawing.Point(90, 44);
            this.cbSubType10.Name = "cbSubType10";
            this.cbSubType10.Size = new System.Drawing.Size(193, 21);
            this.cbSubType10.TabIndex = 49;
            this.cbSubType10.SelectedIndexChanged += new System.EventHandler(this.cbSubType10_SelectedIndexChanged);
            // 
            // cbSubType8
            // 
            this.cbSubType8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSubType8.FormattingEnabled = true;
            this.cbSubType8.Location = new System.Drawing.Point(90, 44);
            this.cbSubType8.Name = "cbSubType8";
            this.cbSubType8.Size = new System.Drawing.Size(193, 21);
            this.cbSubType8.TabIndex = 47;
            this.cbSubType8.SelectedIndexChanged += new System.EventHandler(this.cbSubType8_SelectedIndexChanged);
            // 
            // cbSubType9
            // 
            this.cbSubType9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSubType9.FormattingEnabled = true;
            this.cbSubType9.Location = new System.Drawing.Point(90, 44);
            this.cbSubType9.Name = "cbSubType9";
            this.cbSubType9.Size = new System.Drawing.Size(193, 21);
            this.cbSubType9.TabIndex = 48;
            this.cbSubType9.SelectedIndexChanged += new System.EventHandler(this.cbSubType9_SelectedIndexChanged);
            // 
            // cbSubType7
            // 
            this.cbSubType7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSubType7.FormattingEnabled = true;
            this.cbSubType7.Location = new System.Drawing.Point(90, 44);
            this.cbSubType7.Name = "cbSubType7";
            this.cbSubType7.Size = new System.Drawing.Size(193, 21);
            this.cbSubType7.TabIndex = 46;
            this.cbSubType7.SelectedIndexChanged += new System.EventHandler(this.cbSubType7_SelectedIndexChanged);
            // 
            // cbSubType5
            // 
            this.cbSubType5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSubType5.FormattingEnabled = true;
            this.cbSubType5.Location = new System.Drawing.Point(90, 44);
            this.cbSubType5.Name = "cbSubType5";
            this.cbSubType5.Size = new System.Drawing.Size(193, 21);
            this.cbSubType5.TabIndex = 44;
            this.cbSubType5.SelectedIndexChanged += new System.EventHandler(this.cbSubType5_SelectedIndexChanged);
            // 
            // cbSubType6
            // 
            this.cbSubType6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSubType6.FormattingEnabled = true;
            this.cbSubType6.Location = new System.Drawing.Point(90, 44);
            this.cbSubType6.Name = "cbSubType6";
            this.cbSubType6.Size = new System.Drawing.Size(193, 21);
            this.cbSubType6.TabIndex = 45;
            this.cbSubType6.SelectedIndexChanged += new System.EventHandler(this.cbSubType6_SelectedIndexChanged);
            // 
            // cbSubType2
            // 
            this.cbSubType2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSubType2.FormattingEnabled = true;
            this.cbSubType2.Location = new System.Drawing.Point(90, 44);
            this.cbSubType2.Name = "cbSubType2";
            this.cbSubType2.Size = new System.Drawing.Size(193, 21);
            this.cbSubType2.TabIndex = 41;
            this.cbSubType2.SelectedIndexChanged += new System.EventHandler(this.cbSubType2_SelectedIndexChanged);
            // 
            // cbSubType4
            // 
            this.cbSubType4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSubType4.FormattingEnabled = true;
            this.cbSubType4.Location = new System.Drawing.Point(90, 44);
            this.cbSubType4.Name = "cbSubType4";
            this.cbSubType4.Size = new System.Drawing.Size(193, 21);
            this.cbSubType4.TabIndex = 43;
            this.cbSubType4.SelectedIndexChanged += new System.EventHandler(this.cbSubType4_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(90, 96);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(193, 21);
            this.comboBox4.TabIndex = 39;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // cbSubType3
            // 
            this.cbSubType3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSubType3.FormattingEnabled = true;
            this.cbSubType3.Location = new System.Drawing.Point(90, 44);
            this.cbSubType3.Name = "cbSubType3";
            this.cbSubType3.Size = new System.Drawing.Size(193, 21);
            this.cbSubType3.TabIndex = 42;
            this.cbSubType3.SelectedIndexChanged += new System.EventHandler(this.cbSubType3_SelectedIndexChanged);
            // 
            // cbSubType1
            // 
            this.cbSubType1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSubType1.FormattingEnabled = true;
            this.cbSubType1.Location = new System.Drawing.Point(90, 44);
            this.cbSubType1.Name = "cbSubType1";
            this.cbSubType1.Size = new System.Drawing.Size(193, 21);
            this.cbSubType1.TabIndex = 40;
            this.cbSubType1.SelectedIndexChanged += new System.EventHandler(this.cbSubType1_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(90, 70);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(193, 21);
            this.comboBox3.TabIndex = 38;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(90, 44);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(193, 21);
            this.comboBox2.TabIndex = 37;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "HitType:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "SubType:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "DamageTyp:";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(858, 31);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(48, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(858, 57);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(48, 20);
            this.textBox5.TabIndex = 6;
            this.textBox5.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(858, 83);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(48, 20);
            this.textBox6.TabIndex = 6;
            this.textBox6.Visible = false;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.textBox13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textBox12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.textBox11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBox10);
            this.groupBox4.Controls.Add(this.textBox9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Location = new System.Drawing.Point(241, 151);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(539, 100);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Misc";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Attribute:";
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.Location = new System.Drawing.Point(329, 71);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(48, 20);
            this.textBox13.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(266, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Togle:";
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Location = new System.Drawing.Point(329, 47);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(48, 20);
            this.textBox12.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(266, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "HTP:";
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox11.Location = new System.Drawing.Point(329, 21);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(48, 20);
            this.textBox11.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(266, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "HSP:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "PTP:";
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Location = new System.Drawing.Point(80, 71);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(48, 20);
            this.textBox10.TabIndex = 8;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Location = new System.Drawing.Point(80, 47);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(48, 20);
            this.textBox9.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "PSP:";
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Location = new System.Drawing.Point(80, 21);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(48, 20);
            this.textBox8.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Location = new System.Drawing.Point(858, 109);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(48, 20);
            this.textBox7.TabIndex = 8;
            this.textBox7.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.dgItems);
            this.groupBox5.Controls.Add(this.toolStrip2);
            this.groupBox5.Location = new System.Drawing.Point(241, 257);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(539, 351);
            this.groupBox5.TabIndex = 45;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Skill Level";
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
            this.dgItems.AllowUserToDeleteRows = false;
            this.dgItems.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.Level,
            this.Power,
            this.HitRate});
            this.dgItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgItems.EnableHeadersVisualStyles = false;
            this.dgItems.Location = new System.Drawing.Point(3, 16);
            this.dgItems.Name = "dgItems";
            this.dgItems.RowHeadersVisible = false;
            this.dgItems.RowTemplate.DefaultCellStyle.Format = "C2";
            this.dgItems.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dgItems.RowTemplate.Height = 25;
            this.dgItems.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItems.Size = new System.Drawing.Size(533, 307);
            this.dgItems.TabIndex = 0;
            // 
            // index
            // 
            this.index.HeaderText = "Index";
            this.index.Name = "index";
            this.index.Visible = false;
            this.index.Width = 50;
            // 
            // Level
            // 
            this.Level.HeaderText = "Level";
            this.Level.Name = "Level";
            this.Level.Width = 70;
            // 
            // Power
            // 
            this.Power.HeaderText = "Power";
            this.Power.Name = "Power";
            this.Power.Width = 150;
            // 
            // HitRate
            // 
            this.HitRate.HeaderText = "HitRate";
            this.HitRate.Name = "HitRate";
            this.HitRate.Width = 275;
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
            this.toolStrip2.Location = new System.Drawing.Point(3, 323);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(533, 25);
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(680, 623);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 46;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.textBox14);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(223, 53);
            this.groupBox6.TabIndex = 33;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Search";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Text:";
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox14.Location = new System.Drawing.Point(53, 19);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(164, 20);
            this.textBox14.TabIndex = 20;
            this.textBox14.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // tbSubtype
            // 
            this.tbSubtype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSubtype.Location = new System.Drawing.Point(922, 57);
            this.tbSubtype.Name = "tbSubtype";
            this.tbSubtype.Size = new System.Drawing.Size(48, 20);
            this.tbSubtype.TabIndex = 47;
            this.tbSubtype.Visible = false;
            // 
            // MagicEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 660);
            this.Controls.Add(this.tbSubtype);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MagicEditor";
            this.Text = "Magic Editor";
            this.Load += new System.EventHandler(this.MagicEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
        private void cbSubType1_SelectedIndexChanged(object sender, EventArgs e) //dethunter12 add
        {
            //dethunter12 add ( save magic index fix)
            if (textBox4.Text == "1")
            {
                textBox5.Text = GetIndexByComboBox(cbSubType1.Text).ToString();
            }
        }

        private void cbSubType2_SelectedIndexChanged(object sender, EventArgs e) //dethunter12 add
        {
            //dethunter12 add ( save magic index fix)
            if (textBox4.Text == "2")
            {
                textBox5.Text = GetIndexByComboBox(cbSubType2.Text).ToString();
            }
        }

        private void cbSubType3_SelectedIndexChanged(object sender, EventArgs e) //dethunter12 add
        {
            //dethunter12 add ( save magic index fix)
            if (textBox4.Text == "3")
            {
                textBox5.Text = GetIndexByComboBox(cbSubType3.Text).ToString();
            }
             
        }

        private void cbSubType4_SelectedIndexChanged(object sender, EventArgs e) //dethunter12 add 
        {
            //dethunter12 add ( save magic index fix)
            if (textBox4.Text == "4")
            {
                textBox5.Text = GetIndexByComboBox(cbSubType4.Text).ToString();
            }
        }

        private void cbSubType5_SelectedIndexChanged(object sender, EventArgs e) //dethunter12 add
        {
            //dethunter12 add ( save magic index fix)
            if (textBox4.Text == "5")
            {
                textBox5.Text = GetIndexByComboBox(cbSubType5.Text).ToString();
            }
        }

        private void cbSubType6_SelectedIndexChanged(object sender, EventArgs e) //dethunter12 add
        {
            //dethunter12 add ( save magic index fix)
            if (textBox4.Text == "6")
            {
                textBox5.Text = GetIndexByComboBox(cbSubType6.Text).ToString();
            }
        }

        private void cbSubType7_SelectedIndexChanged(object sender, EventArgs e) //dethunter12 add
        {
            //dethunter12 add ( save magic index fix)
            if (textBox4.Text == "7")
            {
                textBox5.Text = GetIndexByComboBox(cbSubType7.Text).ToString();
            }
        }

        private void cbSubType8_SelectedIndexChanged(object sender, EventArgs e) //dethunter12 add
        {
            //dethunter12 add ( save magic index fix)
            if (textBox4.Text == "8")
            {
                textBox5.Text = GetIndexByComboBox(cbSubType8.Text).ToString();
            }
        }

        private void cbSubType9_SelectedIndexChanged(object sender, EventArgs e) //dethunter12 add 
        {
            //dethunter12 add ( save magic index fix)
            if (textBox4.Text == "9")
            {
                textBox5.Text = GetIndexByComboBox(cbSubType9.Text).ToString();
            }
        }
        private void cbSubType10_SelectedIndexChanged(object sender, EventArgs e) //dethunter12 add
        {
            //dethunter12 add ( save magic index fix)
            if (textBox4.Text == "10")
            {
                textBox5.Text = GetIndexByComboBox(cbSubType10.Text).ToString();
            }
        }
    }
}
