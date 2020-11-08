// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.RareOptSearch
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA
{
  public class RareOptSearch : Form
  {
    public static Connection connection = new Connection();
    private string Host = RareOptSearch.connection.ReadSettings("Host");
    private string User = RareOptSearch.connection.ReadSettings("User");
    private string Password = RareOptSearch.connection.ReadSettings("Password");
    private string Database = RareOptSearch.connection.ReadSettings("Database");
    private DatabaseHandle databaseHandle = new DatabaseHandle();
    public string rowName = "a_index";
    public string[] menuArray = new string[2]
    {
      "a_index",
      "a_prefix_usa"
    };
    public string[] SearchMenu = new string[2]
    {
      "a_index",
      "a_prefix_usa"
    };
    public List<string> MenuList = new List<string>();
    public List<string> MenuListSearch = new List<string>();
    private IContainer components = (IContainer) null;
    public string name;
    public int index;
    public string varf3;
    private ListBox listBox1;
    private Button button3;
    private Button button2;
    private Button button1;
    private TextBox textBox1;
    private TextBox textBox2;
    private GroupBox groupBox1;
    private Label label1;
    private TextBox textBox3;

    public RareOptSearch()
    {
            InitializeComponent();
    }

    private void LoadListBox()
    {
            MenuList.Clear();
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_index, a_prefix_usa from t_rareoption ORDER BY a_index;"); //dethunter12 add
      for (int index = 0; index < listBox1.Items.Count; ++index)
                MenuList.Add(listBox1.Items[index].ToString());
            listBox1.DataSource = MenuList;
    }

    public void SearchList(string searchString)
    {
      searchString = searchString.Replace("\\", "\\\\").Replace("'", "\\'");
      string lower = searchString.ToLower();
      string upper = searchString.ToUpper();
      string str = "";
      if (searchString.Length > 1)
        str = char.ToUpper(searchString[0]).ToString() + searchString.Substring(1);
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, "select a_index, a_prefix_usa from t_rareoption WHERE a_prefix_usa LIKE '%" + searchString + "%'" + " OR a_index LIKE '%" + searchString + "%'" + " OR a_prefix_usa LIKE '%" + lower + "%' OR a_index  LIKE '%" + lower + "%'" + " OR a_prefix_usa LIKE '%" + upper + "%' OR a_index LIKE '%" + upper + "%'" + " OR a_prefix_usa LIKE '%" + str + "%' OR a_index LIKE '%" + str + "%'" + " ORDER BY a_index;"); //dethunter12 add
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
      string Query = " select a_index , a_prefix_usa from t_rareoption WHERE a_index ='" + textBox1.Text + "';"; //dethunter12 change
      string[] rows = new string[2]{ "a_index", "a_prefix_usa" }; //dethunter12 change
      Query.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'");
            textBox1.Text = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query, rows)[0];
    }

    private void Form4_Load(object sender, EventArgs e)
    {
            LoadListBox();
    }

    private void button1_Click(object sender, EventArgs e)
    {
            varf3 = textBox1.Text;
    }

    private void button2_Click(object sender, EventArgs e)
    {
            varf3 = textBox2.Text;
    }

    private void button3_Click(object sender, EventArgs e)
    {
            Close();
    }

    public bool SearchString(string s)
    {
      return s.ToUpper().Contains(textBox3.Text.ToUpper());
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
            MenuListSearch = MenuList.FindAll(new Predicate<string>(SearchString));
            listBox1.DataSource = MenuListSearch;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && components != null)
                components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            listBox1 = new ListBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(8, 70);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(199, 407);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);
            button3.Location = new Point(157, 488);
            button3.Name = "button3";
            button3.Size = new Size(52, 23);
            button3.TabIndex = 7;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new EventHandler(button3_Click);
            button2.DialogResult = DialogResult.OK;
            button2.Location = new Point(85, 488);
            button2.Name = "button2";
            button2.Size = new Size(52, 23);
            button2.TabIndex = 6;
            button2.Text = "No Opt";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new EventHandler(button2_Click);
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(15, 488);
            button1.Name = "button1";
            button1.Size = new Size(52, 23);
            button1.TabIndex = 5;
            button1.Text = "Pick";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new EventHandler(button1_Click);
            textBox1.Location = new Point(217, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 20);
            textBox1.TabIndex = 8;
            textBox2.Location = new Point(217, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 20);
            textBox2.TabIndex = 9;
            textBox2.Text = "-1";
            groupBox1.Controls.Add((Control)label1);
            groupBox1.Controls.Add((Control)textBox3);
            groupBox1.Location = new Point(8, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(195, 50);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(43, 19);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(146, 20);
            textBox3.TabIndex = 0;
            textBox3.TextChanged += new EventHandler(textBox3_TextChanged);
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(31, 13);
            label1.TabIndex = 1;
            label1.Text = "Text:";
            AutoScaleDimensions = new SizeF(6f, 13f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 522);
            Controls.Add((Control)groupBox1);
            Controls.Add((Control)textBox2);
            Controls.Add((Control)textBox1);
            Controls.Add((Control)button3);
            Controls.Add((Control)button2);
            Controls.Add((Control)button1);
            Controls.Add((Control)listBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RareOptSearch";
            Text = "Rare Option";
            Load += new EventHandler(Form4_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
    }
  }
}
