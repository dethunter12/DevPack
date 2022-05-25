// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.Tools.TitleEditor
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using StringExporter;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools
{
  public class TitleEditor : Form
  {
    public static Connection connection = new Connection();
    private string Host = TitleEditor.connection.ReadSettings("Host");
    private string User = TitleEditor.connection.ReadSettings("User");
    private string Password = TitleEditor.connection.ReadSettings("Password");
    private string Database = TitleEditor.connection.ReadSettings("Database");
        private string language = TitleEditor.connection.ReadSettings("Language");//dethunter12 language selection
        private string namee; //dethunter12 stringfrom lang modify
        private DatabaseHandle databaseHandle = new DatabaseHandle();
    public string rowName = "a_index";
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
    public string[] menuArray3 = new string[1]{ "a_level" };
    private ExportLodHandle exportLodHandle = new ExportLodHandle();
    private IContainer components = (IContainer) null;
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
    public System.Collections.Generic.List<string> List11;
    public System.Collections.Generic.List<string> List12;
    public System.Collections.Generic.List<string> List13;
    public System.Collections.Generic.List<string> List14;
    public System.Collections.Generic.List<string> List15;
    public string name;
    public int index;
    private ListBox listBox1;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem exportlodToolStripMenuItem;
    private Button button1;
    private Button button2;
    private Button button3;
    private GroupBox groupBox1;
    private Label label26;
    private Label label3;
    private Label label2;
    private TextBox textBox1;
    private Label label1;
    private GroupBox groupBox2;
    private Label label6;
    private Label label5;
    private Label label4;
    private GroupBox groupBox3;
    private GroupBox groupBox6;
    private Label label15;
    private GroupBox groupBox5;
    private TrackBar trackBar8;
    private TrackBar trackBar7;
    private TrackBar trackBar6;
    private TrackBar trackBar5;
    private Label label14;
    private Label label13;
    private Label label12;
    private Label label11;
    private GroupBox groupBox4;
    private TrackBar trackBar4;
    private TrackBar trackBar3;
    private TrackBar trackBar2;
    private TrackBar trackBar1;
    private Label label10;
    private Label label9;
    private Label label7;
    private Label label8;
    private TextBox textBox4;
    private TextBox textBox2;
    private TextBox textBox3;
    private TextBox textBox7;
    private TextBox textBox6;
    private TextBox textBox5;
    private Label label16;
    private Label label17;
    private TextBox textBox8;
    private TextBox textBox9;
    private TextBox textBox10;
    private GroupBox groupBox7;
    private TextBox textBox20;
    private TextBox textBox19;
    private TextBox textBox18;
    private TextBox textBox17;
    private TextBox textBox16;
    private TextBox textBox15;
    private TextBox textBox14;
    private TextBox textBox13;
    private TextBox textBox12;
    private TextBox textBox11;
    private TextBox textBox21;
    private Label label18;
    private TextBox textBox23;
    private TextBox textBox22;
    private Label label19;
    private TextBox textBox24;
    private TextBox textBox25;
    private TextBox textBox26;
    private TextBox textBox27;
    private TextBox textBox28;
    private TextBox textBox29;
    private TextBox textBox30;
    private TextBox textBox31;
    private ComboBox comboBox10;
    private ComboBox comboBox9;
    private ComboBox comboBox8;
    private ComboBox comboBox7;
    private ComboBox comboBox6;
    private ComboBox comboBox5;
    private ComboBox comboBox4;
    private ComboBox comboBox3;
    private ComboBox comboBox2;
    private Label label20;
    private Label label21;
    private Label label22;
    private Label label23;
    private Label label24;
    private ComboBox comboBox1;
    private TextBox textBox32;
    private TextBox textBox33;
    private TextBox textBox34;
    private TextBox textBox35;
    private TextBox textBox36;
    private GroupBox groupBox8;
    private TextBox textBox37;
    private Label label25;
    private GroupBox groupBox9;
    private Label label27;
    private PictureBox pictureBox1;
    private TextBox textBox38;
    private TextBox textBox39;
    private TextBox textBox40;
        private ToolStripMenuItem clickMeBeforeEditingTitlesToolStripMenuItem;
        private PictureBox PbSelectID1;
        private ToolStripMenuItem exportStringToolStripMenuItem;
        private Button button4;

    public TitleEditor()
    {
            InitializeComponent();
    }

    public int GetIndex()
    {
      return Convert.ToInt32(comboBox1.SelectedText.Split(' ')[0]);
    }

    public Bitmap CropImage(Bitmap source, Rectangle section)
    {
      Bitmap bitmap = new Bitmap(section.Width, section.Height);
      Graphics.FromImage((Image) bitmap).DrawImage((Image) source, 0, 0, section, GraphicsUnit.Pixel);
      return bitmap;
    }

    public void cropIcon()
    {
      try
      {
                pictureBox1.Image = (Image)databaseHandle.IconFast(Convert.ToInt32(textBox21.Text));
      }
      catch
      {
      }
    }

    public void SearchList(string searchString)
    {
      searchString = searchString.Replace("\\", "\\\\").Replace("'", "\\'");
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_index, a_name from t_title WHERE a_name LIKE '%" + searchString + "%' ORDER BY a_index;");
    }

    private void Exporter_Title_Load(object sender, EventArgs e)
    {
            listBox1.Items.Clear();
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_index, a_name from t_title ORDER BY a_index;");
            ChangeColor();
      string Query = "select * from t_option ORDER BY a_index;";
            List = databaseHandle.SelectMySqlReturnList(menuArray2, Host, User, Password, Database, Query);
            List2 = databaseHandle.SelectMySqlReturnList(menuArray2, Host, User, Password, Database, Query);
            List3 = databaseHandle.SelectMySqlReturnList(menuArray2, Host, User, Password, Database, Query);
            List4 = databaseHandle.SelectMySqlReturnList(menuArray2, Host, User, Password, Database, Query);
            List5 = databaseHandle.SelectMySqlReturnList(menuArray2, Host, User, Password, Database, Query);
            comboBox1.DataSource = List;
            comboBox2.DataSource = List2;
            comboBox3.DataSource = List3;
            comboBox4.DataSource = List4;
            comboBox5.DataSource = List5;
            listBox1.SelectedIndex = 1;
            listBox1.SelectedIndex = 0;
    }

    public new void ResetBindings()
    {
            textBox1.DataBindings.Clear();
    }

    public void ChangeColor()
    {
      int alpha1 = int.Parse(textBox27.Text);
      int red1 = int.Parse(textBox24.Text);
      int green1 = int.Parse(textBox25.Text);
      int blue1 = int.Parse(textBox26.Text);
      int alpha2 = int.Parse(textBox31.Text);
      int red2 = int.Parse(textBox28.Text);
      int green2 = int.Parse(textBox29.Text);
      int blue2 = int.Parse(textBox30.Text);
      string str1 = alpha1.ToString("X2");
      string str2 = red1.ToString("X2");
      string str3 = blue1.ToString("X2");
      string str4 = green1.ToString("X2");
      string str5 = alpha2.ToString("X2");
      string str6 = red2.ToString("X2");
      string str7 = blue2.ToString("X2");
      string str8 = green2.ToString("X2");
      string str9 = str2 + str4 + str3 + str1;
            textBox9.Text = str6 + str8 + str7 + str5;
            textBox10.Text = str9;
      Color color1 = Color.FromArgb(alpha1, red1, green1, blue1);
      Color color2 = Color.FromArgb(alpha2, red2, green2, blue2);
            label15.ForeColor = color1;
            label15.BackColor = color2;
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
            ResetBindings();
      if (listBox1.SelectedIndex != -1)
      {
                name = listBox1.SelectedItem.ToString();
                textBox1.Text = name;
      }
      string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, " select * FROM t_title WHERE a_index ='" + textBox1.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "';", new string[23]
      {
        "a_index",
        "a_name",
        "a_enable",
        "a_describe",
        "a_effect_name",
        "a_attack",
        "a_damage",
        "a_time",
        "a_bgcolor",
        "a_color",
        "a_option_index0",
        "a_option_level0",
        "a_option_index1",
        "a_option_level1",
        "a_option_index2",
        "a_option_level2",
        "a_option_index3",
        "a_option_level3",
        "a_option_index4",
        "a_option_level4",
        "a_item_index",
        "a_flag",
        "a_castle_num"
      });
            textBox1.Text = strArray[0];
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
            textBox2.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox21.Text));
      int num1 = int.Parse(strArray[9].Substring(0, strArray[9].Length - 6), NumberStyles.HexNumber);
      int num2 = int.Parse(strArray[9].Substring(2, strArray[9].Length - 6), NumberStyles.HexNumber);
      int num3 = int.Parse(strArray[9].Substring(4, strArray[9].Length - 6), NumberStyles.HexNumber);
      int num4 = int.Parse(strArray[9].Substring(6, strArray[9].Length - 6), NumberStyles.HexNumber);
      int num5 = int.Parse(strArray[8].Substring(0, strArray[8].Length - 6), NumberStyles.HexNumber);
      int num6 = int.Parse(strArray[8].Substring(2, strArray[8].Length - 6), NumberStyles.HexNumber);
      int num7 = int.Parse(strArray[8].Substring(4, strArray[8].Length - 6), NumberStyles.HexNumber);
      int num8 = int.Parse(strArray[8].Substring(6, strArray[8].Length - 6), NumberStyles.HexNumber);
            label15.Text = strArray[1];
            textBox24.Text = num1.ToString();
            textBox25.Text = num2.ToString();
            textBox26.Text = num3.ToString();
            textBox27.Text = num4.ToString();
            textBox28.Text = num5.ToString();
            textBox29.Text = num6.ToString();
            textBox30.Text = num7.ToString();
            textBox31.Text = num8.ToString();
            trackBar1.Value = int.Parse(textBox27.Text);
            trackBar2.Value = int.Parse(textBox24.Text);
            trackBar3.Value = int.Parse(textBox25.Text);
            trackBar4.Value = int.Parse(textBox26.Text);
            trackBar5.Value = int.Parse(textBox31.Text);
            trackBar6.Value = int.Parse(textBox28.Text);
            trackBar7.Value = int.Parse(textBox29.Text);
            trackBar8.Value = int.Parse(textBox30.Text);
            ChangeColor();
            comboBox1.SelectedIndex = int.Parse(textBox11.Text);
            comboBox2.SelectedIndex = int.Parse(textBox13.Text);
            comboBox3.SelectedIndex = int.Parse(textBox15.Text);
            comboBox4.SelectedIndex = int.Parse(textBox17.Text);
            comboBox5.SelectedIndex = int.Parse(textBox19.Text);
      string text1 = textBox11.Text;
      string text2 = textBox13.Text;
      string text3 = textBox15.Text;
      string text4 = textBox17.Text;
      string text5 = textBox19.Text;
      string Query1 = "select * from t_option WHERE a_type = '" + text1 + "' ORDER BY a_index;";
      string Query2 = "select * from t_option WHERE a_type = '" + text2 + "' ORDER BY a_index;";
      string Query3 = "select * from t_option WHERE a_type = '" + text3 + "' ORDER BY a_index;";
      string Query4 = "select * from t_option WHERE a_type = '" + text4 + "' ORDER BY a_index;";
      string Query5 = "select * from t_option WHERE a_type = '" + text5 + "' ORDER BY a_index;";
            List6 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, Query1);
            List7 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, Query2);
            List8 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, Query3);
            List9 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, Query4);
            List10 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, Query5);
            comboBox6.DataSource = List6;
            comboBox7.DataSource = List7;
            comboBox8.DataSource = List8;
            comboBox9.DataSource = List9;
            comboBox10.DataSource = List10;
      try
      {
                comboBox6.SelectedIndex = int.Parse(textBox12.Text) - 1;
                comboBox7.SelectedIndex = int.Parse(textBox14.Text) - 1;
                comboBox8.SelectedIndex = int.Parse(textBox16.Text) - 1;
                comboBox9.SelectedIndex = int.Parse(textBox18.Text) - 1;
                comboBox10.SelectedIndex = int.Parse(textBox20.Text) - 1;
      }
      catch
      {
      }
            cropIcon();
            label27.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox21.Text));
    }

    private void trackBar1_Scroll(object sender, EventArgs e)
    {
            textBox27.Text = trackBar1.Value.ToString();
            ChangeColor();
    }

    private void trackBar2_Scroll(object sender, EventArgs e)
    {
            textBox24.Text = trackBar2.Value.ToString();
            ChangeColor();
    }

    private void trackBar3_Scroll(object sender, EventArgs e)
    {
            textBox25.Text = trackBar3.Value.ToString();
            ChangeColor();
    }

    private void trackBar4_Scroll(object sender, EventArgs e)
    {
            textBox26.Text = trackBar4.Value.ToString();
            ChangeColor();
    }

    private void trackBar5_Scroll(object sender, EventArgs e)
    {
            textBox31.Text = trackBar5.Value.ToString();
            ChangeColor();
    }

    private void trackBar6_Scroll(object sender, EventArgs e)
    {
            textBox28.Text = trackBar6.Value.ToString();
            ChangeColor();
    }

    private void trackBar7_Scroll(object sender, EventArgs e)
    {
            textBox29.Text = trackBar7.Value.ToString();
            ChangeColor();
    }

    private void trackBar8_Scroll(object sender, EventArgs e)
    {
            textBox30.Text = trackBar8.Value.ToString();
            ChangeColor();
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox11.Text = comboBox1.SelectedIndex.ToString();
            List11 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + textBox11.Text + "' ORDER BY a_index;");
            comboBox6.DataSource =  null;
            comboBox6.Items.Clear();
            comboBox6.DataSource = List11;
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox13.Text = comboBox2.SelectedIndex.ToString();
            List12 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + textBox13.Text + "' ORDER BY a_index;");
            comboBox7.DataSource =  null;
            comboBox7.Items.Clear();
            comboBox7.DataSource = List12;
    }

    private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox15.Text = comboBox3.SelectedIndex.ToString();
            List13 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + textBox15.Text + "' ORDER BY a_index;");
            comboBox8.DataSource =  null;
            comboBox8.Items.Clear();
            comboBox8.DataSource = List13;
    }

    private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox17.Text = comboBox4.SelectedIndex.ToString();
            List14 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + textBox17.Text + "' ORDER BY a_index;");
            comboBox9.DataSource =  null;
            comboBox9.Items.Clear();
            comboBox9.DataSource = List14;
    }

    private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox19.Text = comboBox5.SelectedIndex.ToString();
            List15 = databaseHandle.SelectMySqlExplodedReturnList(menuArray3, Host, User, Password, Database, "select * from t_option WHERE a_type = '" + textBox19.Text + "' ORDER BY a_index;");
            comboBox10.DataSource =  null;
            comboBox10.Items.Clear();
            comboBox10.DataSource = List15;
    }

    private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox36.Text = (comboBox6.SelectedIndex + 1).ToString();
    }

    private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox35.Text = (comboBox7.SelectedIndex + 1).ToString();
    }

    private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox34.Text = (comboBox8.SelectedIndex + 1).ToString();
    }

    private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox33.Text = (comboBox9.SelectedIndex + 1).ToString();
    }

    private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
    {
            textBox32.Text = (comboBox10.SelectedIndex + 1).ToString();
    }

    private void textBox12_TextChanged(object sender, EventArgs e)
    {
    }

    private void textBox36_TextChanged(object sender, EventArgs e)
    {
    }

    private string EncodeMySqlString(string value)
    {
      return value = value.Replace("'", "'");
    }

    private void button3_Click(object sender, EventArgs e)
    {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_title SET a_name = '" + textBox2.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "', a_enable = '" + textBox3.Text + "', a_describe = '" + textBox4.Text.Replace("'", "\\'").Replace("\"", "\\\"") + "', a_effect_Name = '" + textBox5.Text + "', a_attack = '" + textBox6.Text + "', a_damage = '" + textBox7.Text + "', a_time = '" + textBox8.Text + "', a_bgcolor = '" + textBox9.Text + "', a_color = '" + textBox10.Text + "', a_option_index0 = '" + textBox11.Text + "', a_option_level0 = '" + textBox36.Text + "', a_option_index1 = '" + textBox13.Text + "', a_option_level1 = '" + textBox35.Text + "', a_option_index2 = '" + textBox15.Text + "', a_option_level2 = '" + textBox34.Text + "', a_option_index3 = '" + textBox17.Text + "', a_option_level3 = '" + textBox33.Text + "', a_option_index4 = '" + textBox19.Text + "', a_option_level4 = '" + textBox32.Text + "', a_item_index = '" + textBox21.Text + "', a_flag = '" + textBox22.Text + "', a_castle_num = '" + textBox23.Text + "' WHERE a_index ='" + textBox1.Text + "';");
            cropIcon();
      int selectedIndex = listBox1.SelectedIndex;
      if (textBox37.Text != "")
                SearchList(textBox12.Text);
      else
                listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select * from t_title ORDER BY a_index;");
            listBox1.SelectedIndex = selectedIndex;
            int num4 = (int)new CustomMessage("Done :)").ShowDialog();
        }

    private void button1_Click(object sender, EventArgs e)
    {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "INSERT INTO t_title (a_name, a_enable, a_bgcolor, a_color) VALUES ('New Title', '1', 'FFFFFFFF', '000000FF')");
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select * from t_title ORDER BY a_index;");
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      int selectedIndex = listBox1.SelectedIndex;
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_title WHERE a_index = '" + textBox1.Text + "'");
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select * from t_title ORDER BY a_index;");
            listBox1.SelectedIndex = selectedIndex - 1;
            int num4 = (int)new CustomMessage("Deleted :O").ShowDialog();
        }

    private void textBox37_TextChanged(object sender, EventArgs e)
    {
            SearchList(textBox37.Text);
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
        private void exportlodToolStripMenuItem_Click(object sender, EventArgs e)
    {
            string text1 = "title";
            string text2 = "path_ship";
            string text3 = LanguageExport();
            Process.Start(new ProcessStartInfo()
            {
                FileName = "ExportLod.exe",
                Arguments = " -h " + Host + " -d " + Database + " -u " + User + " -p " + Password + " -k " + text2 + " -l " + text3 + " -t " + text1
            });
        }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
    }

    private void textBox10_TextChanged(object sender, EventArgs e)
    {
    }

    private void textBox9_TextChanged(object sender, EventArgs e)
    {
    }

    private void textBox24_TextChanged(object sender, EventArgs e)
    {
    }

    private void button4_Click(object sender, EventArgs e)
    {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DROP TABLE IF EXISTS tempTable;" + "CREATE TEMPORARY TABLE tempTable ENGINE=MEMORY SELECT * FROM t_title WHERE a_index=" + textBox1.Text + ";" + "SELECT a_index FROM tempTable;" + "UPDATE tempTable SET a_index=(SELECT a_index from t_title ORDER BY a_index DESC LIMIT 1)+1; " + "SELECT a_index FROM tempTable;" + "INSERT INTO t_title SELECT * FROM tempTable;");
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select * from t_title ORDER BY a_index;");
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            int num4 = (int)new CustomMessage("Copying Complete !!").ShowDialog();
        }

    private void textBox21_TextChanged(object sender, EventArgs e)
    {
            label27.Text = databaseHandle.ItemNameFast(Convert.ToInt32(textBox21.Text));
            //dethunter12 change item icon update for text change
            if (textBox21.Text != "")  pictureBox1.Image = databaseHandle.IconFast(Convert.ToInt32(textBox21.Text));

    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && components != null)
                components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleEditor));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportlodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clickMeBeforeEditingTitlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.trackBar8 = new System.Windows.Forms.TrackBar();
            this.trackBar7 = new System.Windows.Forms.TrackBar();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.PbSelectID1 = new System.Windows.Forms.PictureBox();
            this.label27 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.exportStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(239, 576);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.clickMeBeforeEditingTitlesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportlodToolStripMenuItem,
            this.exportStringToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.fileToolStripMenuItem.Text = "FileExport";
            // 
            // exportlodToolStripMenuItem
            // 
            this.exportlodToolStripMenuItem.Name = "exportlodToolStripMenuItem";
            this.exportlodToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportlodToolStripMenuItem.Text = "Export .lod";
            this.exportlodToolStripMenuItem.Click += new System.EventHandler(this.exportlodToolStripMenuItem_Click);
            // 
            // clickMeBeforeEditingTitlesToolStripMenuItem
            // 
            this.clickMeBeforeEditingTitlesToolStripMenuItem.Name = "clickMeBeforeEditingTitlesToolStripMenuItem";
            this.clickMeBeforeEditingTitlesToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.clickMeBeforeEditingTitlesToolStripMenuItem.Text = "Click Me Before Editing Titles!!";
            this.clickMeBeforeEditingTitlesToolStripMenuItem.Click += new System.EventHandler(this.clickMeBeforeEditingTitlesToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 676);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(176, 676);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(742, 676);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.textBox23);
            this.groupBox1.Controls.Add(this.textBox22);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(269, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 184);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(167, 138);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "Castle";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 138);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Flag";
            // 
            // textBox23
            // 
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox23.Location = new System.Drawing.Point(214, 136);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(52, 20);
            this.textBox23.TabIndex = 15;
            // 
            // textBox22
            // 
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox22.Location = new System.Drawing.Point(85, 136);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(52, 20);
            this.textBox22.TabIndex = 14;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Location = new System.Drawing.Point(214, 107);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(52, 20);
            this.textBox8.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(167, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Time";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(85, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(52, 20);
            this.textBox3.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Enable:";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(85, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(181, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(85, 80);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(181, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 82);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(58, 13);
            this.label26.TabIndex = 8;
            this.label26.Text = "Title Desc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title Name:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(85, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TitleID:";
            // 
            // textBox21
            // 
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox21.Location = new System.Drawing.Point(52, 24);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(52, 20);
            this.textBox21.TabIndex = 13;
            this.textBox21.TextChanged += new System.EventHandler(this.textBox21_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ItemID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(567, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 110);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Effects";
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Location = new System.Drawing.Point(63, 76);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(181, 20);
            this.textBox7.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(63, 50);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(181, 20);
            this.textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(63, 24);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(181, 20);
            this.textBox5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Damage:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Attack:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Effect:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(269, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(548, 259);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visual View";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Location = new System.Drawing.Point(6, 176);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(536, 77);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pre-View";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(6, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(527, 50);
            this.label15.TabIndex = 0;
            this.label15.Text = "Preview Text";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox9);
            this.groupBox5.Controls.Add(this.trackBar8);
            this.groupBox5.Controls.Add(this.trackBar7);
            this.groupBox5.Controls.Add(this.trackBar6);
            this.groupBox5.Controls.Add(this.trackBar5);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(306, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(239, 151);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Background Color";
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Location = new System.Drawing.Point(153, 123);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(80, 20);
            this.textBox9.TabIndex = 13;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // trackBar8
            // 
            this.trackBar8.AutoSize = false;
            this.trackBar8.Location = new System.Drawing.Point(58, 97);
            this.trackBar8.Maximum = 255;
            this.trackBar8.Name = "trackBar8";
            this.trackBar8.Size = new System.Drawing.Size(126, 20);
            this.trackBar8.TabIndex = 13;
            this.trackBar8.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar8.Scroll += new System.EventHandler(this.trackBar8_Scroll);
            // 
            // trackBar7
            // 
            this.trackBar7.AutoSize = false;
            this.trackBar7.Location = new System.Drawing.Point(58, 72);
            this.trackBar7.Maximum = 255;
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Size = new System.Drawing.Size(126, 20);
            this.trackBar7.TabIndex = 12;
            this.trackBar7.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar7.Scroll += new System.EventHandler(this.trackBar7_Scroll);
            // 
            // trackBar6
            // 
            this.trackBar6.AutoSize = false;
            this.trackBar6.Location = new System.Drawing.Point(58, 46);
            this.trackBar6.Maximum = 255;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(126, 20);
            this.trackBar6.TabIndex = 11;
            this.trackBar6.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar6.Scroll += new System.EventHandler(this.trackBar6_Scroll);
            // 
            // trackBar5
            // 
            this.trackBar5.AutoSize = false;
            this.trackBar5.Location = new System.Drawing.Point(58, 19);
            this.trackBar5.Maximum = 255;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(126, 20);
            this.trackBar5.TabIndex = 7;
            this.trackBar5.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "B:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "G:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "R:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Opacity:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox10);
            this.groupBox4.Controls.Add(this.trackBar4);
            this.groupBox4.Controls.Add(this.trackBar3);
            this.groupBox4.Controls.Add(this.trackBar2);
            this.groupBox4.Controls.Add(this.trackBar1);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 151);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Text Color";
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Location = new System.Drawing.Point(156, 123);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(74, 20);
            this.textBox10.TabIndex = 14;
            this.textBox10.Text = " ";
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // trackBar4
            // 
            this.trackBar4.AutoSize = false;
            this.trackBar4.Location = new System.Drawing.Point(58, 97);
            this.trackBar4.Maximum = 255;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(125, 20);
            this.trackBar4.TabIndex = 9;
            this.trackBar4.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.AutoSize = false;
            this.trackBar3.Location = new System.Drawing.Point(58, 71);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(125, 20);
            this.trackBar3.TabIndex = 8;
            this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.Location = new System.Drawing.Point(58, 47);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(125, 20);
            this.trackBar2.TabIndex = 7;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(58, 20);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(126, 20);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Opacity:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "B:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "R:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "G:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox32);
            this.groupBox7.Controls.Add(this.comboBox10);
            this.groupBox7.Controls.Add(this.textBox33);
            this.groupBox7.Controls.Add(this.comboBox9);
            this.groupBox7.Controls.Add(this.comboBox8);
            this.groupBox7.Controls.Add(this.textBox34);
            this.groupBox7.Controls.Add(this.comboBox7);
            this.groupBox7.Controls.Add(this.comboBox6);
            this.groupBox7.Controls.Add(this.textBox35);
            this.groupBox7.Controls.Add(this.comboBox5);
            this.groupBox7.Controls.Add(this.comboBox4);
            this.groupBox7.Controls.Add(this.textBox36);
            this.groupBox7.Controls.Add(this.comboBox3);
            this.groupBox7.Controls.Add(this.comboBox2);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.comboBox1);
            this.groupBox7.Controls.Add(this.textBox19);
            this.groupBox7.Controls.Add(this.textBox17);
            this.groupBox7.Controls.Add(this.textBox15);
            this.groupBox7.Controls.Add(this.textBox13);
            this.groupBox7.Controls.Add(this.textBox11);
            this.groupBox7.Controls.Add(this.textBox14);
            this.groupBox7.Controls.Add(this.textBox12);
            this.groupBox7.Controls.Add(this.textBox16);
            this.groupBox7.Controls.Add(this.textBox20);
            this.groupBox7.Controls.Add(this.textBox18);
            this.groupBox7.Location = new System.Drawing.Point(269, 492);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(548, 169);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Seals";
            // 
            // textBox32
            // 
            this.textBox32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox32.Location = new System.Drawing.Point(299, 272);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(52, 20);
            this.textBox32.TabIndex = 42;
            // 
            // comboBox10
            // 
            this.comboBox10.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(382, 132);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(114, 21);
            this.comboBox10.TabIndex = 37;
            this.comboBox10.SelectedIndexChanged += new System.EventHandler(this.comboBox10_SelectedIndexChanged);
            // 
            // textBox33
            // 
            this.textBox33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox33.Location = new System.Drawing.Point(241, 272);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(52, 20);
            this.textBox33.TabIndex = 41;
            // 
            // comboBox9
            // 
            this.comboBox9.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(382, 102);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(114, 21);
            this.comboBox9.TabIndex = 36;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // comboBox8
            // 
            this.comboBox8.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(382, 74);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(114, 21);
            this.comboBox8.TabIndex = 35;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // textBox34
            // 
            this.textBox34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox34.Location = new System.Drawing.Point(180, 272);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(52, 20);
            this.textBox34.TabIndex = 40;
            // 
            // comboBox7
            // 
            this.comboBox7.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(382, 46);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(114, 21);
            this.comboBox7.TabIndex = 34;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(382, 17);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(114, 21);
            this.comboBox6.TabIndex = 33;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // textBox35
            // 
            this.textBox35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox35.Location = new System.Drawing.Point(122, 271);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(52, 20);
            this.textBox35.TabIndex = 39;
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "-1 - None"});
            this.comboBox5.Location = new System.Drawing.Point(102, 132);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(234, 21);
            this.comboBox5.TabIndex = 32;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "-1 - None"});
            this.comboBox4.Location = new System.Drawing.Point(102, 102);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(234, 21);
            this.comboBox4.TabIndex = 31;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // textBox36
            // 
            this.textBox36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox36.Location = new System.Drawing.Point(64, 271);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(52, 20);
            this.textBox36.TabIndex = 38;
            this.textBox36.TextChanged += new System.EventHandler(this.textBox36_TextChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "-1 - None"});
            this.comboBox3.Location = new System.Drawing.Point(102, 74);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(234, 21);
            this.comboBox3.TabIndex = 30;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "-1 - None"});
            this.comboBox2.Location = new System.Drawing.Point(102, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(234, 21);
            this.comboBox2.TabIndex = 29;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(35, 135);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "Seal 5:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(34, 105);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 13);
            this.label21.TabIndex = 27;
            this.label21.Text = "Seal 4:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(34, 77);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 13);
            this.label22.TabIndex = 26;
            this.label22.Text = "Seal 3:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(35, 49);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(40, 13);
            this.label23.TabIndex = 25;
            this.label23.Text = "Seal 2:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(34, 20);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 13);
            this.label24.TabIndex = 24;
            this.label24.Text = "Seal 1:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "-1 - None"});
            this.comboBox1.Location = new System.Drawing.Point(102, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox19
            // 
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox19.Location = new System.Drawing.Point(299, 208);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(52, 20);
            this.textBox19.TabIndex = 21;
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox17.Location = new System.Drawing.Point(241, 208);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(52, 20);
            this.textBox17.TabIndex = 19;
            // 
            // textBox15
            // 
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox15.Location = new System.Drawing.Point(183, 208);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(52, 20);
            this.textBox15.TabIndex = 17;
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.Location = new System.Drawing.Point(122, 208);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(52, 20);
            this.textBox13.TabIndex = 15;
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox11.Location = new System.Drawing.Point(64, 208);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(52, 20);
            this.textBox11.TabIndex = 13;
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox14.Location = new System.Drawing.Point(122, 245);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(52, 20);
            this.textBox14.TabIndex = 16;
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Location = new System.Drawing.Point(64, 245);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(52, 20);
            this.textBox12.TabIndex = 14;
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // textBox16
            // 
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox16.Location = new System.Drawing.Point(180, 245);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(52, 20);
            this.textBox16.TabIndex = 18;
            // 
            // textBox20
            // 
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox20.Location = new System.Drawing.Point(299, 245);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(52, 20);
            this.textBox20.TabIndex = 22;
            // 
            // textBox18
            // 
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox18.Location = new System.Drawing.Point(241, 245);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(52, 20);
            this.textBox18.TabIndex = 20;
            // 
            // textBox24
            // 
            this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox24.Location = new System.Drawing.Point(958, 217);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(53, 20);
            this.textBox24.TabIndex = 22;
            this.textBox24.TextChanged += new System.EventHandler(this.textBox24_TextChanged);
            // 
            // textBox25
            // 
            this.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox25.Location = new System.Drawing.Point(958, 243);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(53, 20);
            this.textBox25.TabIndex = 23;
            // 
            // textBox26
            // 
            this.textBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox26.Location = new System.Drawing.Point(958, 268);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(53, 20);
            this.textBox26.TabIndex = 24;
            // 
            // textBox27
            // 
            this.textBox27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox27.Location = new System.Drawing.Point(958, 295);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(53, 20);
            this.textBox27.TabIndex = 25;
            // 
            // textBox28
            // 
            this.textBox28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox28.Location = new System.Drawing.Point(958, 339);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(53, 20);
            this.textBox28.TabIndex = 26;
            // 
            // textBox29
            // 
            this.textBox29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox29.Location = new System.Drawing.Point(958, 369);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(53, 20);
            this.textBox29.TabIndex = 27;
            // 
            // textBox30
            // 
            this.textBox30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox30.Location = new System.Drawing.Point(958, 395);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(53, 20);
            this.textBox30.TabIndex = 28;
            // 
            // textBox31
            // 
            this.textBox31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox31.Location = new System.Drawing.Point(958, 421);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(53, 20);
            this.textBox31.TabIndex = 29;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBox37);
            this.groupBox8.Controls.Add(this.label25);
            this.groupBox8.Location = new System.Drawing.Point(12, 36);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(239, 52);
            this.groupBox8.TabIndex = 30;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Search";
            // 
            // textBox37
            // 
            this.textBox37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox37.Location = new System.Drawing.Point(44, 19);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(189, 20);
            this.textBox37.TabIndex = 5;
            this.textBox37.TextChanged += new System.EventHandler(this.textBox37_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 21);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(31, 13);
            this.label25.TabIndex = 4;
            this.label25.Text = "Text:";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.PbSelectID1);
            this.groupBox9.Controls.Add(this.label27);
            this.groupBox9.Controls.Add(this.textBox21);
            this.groupBox9.Controls.Add(this.pictureBox1);
            this.groupBox9.Controls.Add(this.label3);
            this.groupBox9.Location = new System.Drawing.Point(567, 37);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(250, 68);
            this.groupBox9.TabIndex = 31;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Item";
            // 
            // PbSelectID1
            // 
            this.PbSelectID1.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.PbSelectID1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbSelectID1.Location = new System.Drawing.Point(114, 23);
            this.PbSelectID1.Name = "PbSelectID1";
            this.PbSelectID1.Size = new System.Drawing.Size(22, 22);
            this.PbSelectID1.TabIndex = 106;
            this.PbSelectID1.TabStop = false;
            this.PbSelectID1.Click += new System.EventHandler(this.PbSelectID1_Click);
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(9, 52);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(235, 13);
            this.label27.TabIndex = 99;
            this.label27.Text = "label27";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(212, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // textBox38
            // 
            this.textBox38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox38.Location = new System.Drawing.Point(942, 94);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(53, 20);
            this.textBox38.TabIndex = 32;
            // 
            // textBox39
            // 
            this.textBox39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox39.Location = new System.Drawing.Point(942, 128);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(53, 20);
            this.textBox39.TabIndex = 32;
            // 
            // textBox40
            // 
            this.textBox40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox40.Location = new System.Drawing.Point(942, 154);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(53, 20);
            this.textBox40.TabIndex = 33;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(95, 676);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 34;
            this.button4.Text = "Copy";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // exportStringToolStripMenuItem
            // 
            this.exportStringToolStripMenuItem.Name = "exportStringToolStripMenuItem";
            this.exportStringToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportStringToolStripMenuItem.Text = "Export String";
            this.exportStringToolStripMenuItem.Click += new System.EventHandler(this.exportStringToolStripMenuItem_Click);
            // 
            // TitleEditor
            // 
            this.ClientSize = new System.Drawing.Size(822, 709);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox40);
            this.Controls.Add(this.textBox39);
            this.Controls.Add(this.textBox38);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.textBox31);
            this.Controls.Add(this.textBox30);
            this.Controls.Add(this.textBox29);
            this.Controls.Add(this.textBox28);
            this.Controls.Add(this.textBox27);
            this.Controls.Add(this.textBox26);
            this.Controls.Add(this.textBox25);
            this.Controls.Add(this.textBox24);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TitleEditor";
            this.Text = "Title Editor";
            this.Load += new System.EventHandler(this.Exporter_Title_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        private void clickMeBeforeEditingTitlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_option set a_level = TRIM(a_level);");
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_option set a_prob = TRIM(a_prob);");
            int num4 = (int)new CustomMessage("Done :)").ShowDialog();
            clickMeBeforeEditingTitlesToolStripMenuItem.Enabled = false;

        }

        private void PbSelectID1_Click(object sender, EventArgs e) //dethunter12 add 6/10/2018
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox21.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void exportStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExport f2 = new FormExport();
            f2.Show(); // Shows Form2
        }
    }
}
