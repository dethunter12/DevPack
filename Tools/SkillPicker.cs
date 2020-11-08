// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.Tools.SkillPicker
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools
{
  public class SkillPicker : Form
  {
    public int SkillIndex = -1;
    public List<string> MenuList = new List<string>();
    public List<string> MenuListSearch = new List<string>();
    private IContainer components = (IContainer) null;
    private DatabaseHandle databaseHandle = new DatabaseHandle(); //dethunter12 add
    public string[] menuArray = new string[2] //dethunter12 add
    {
      "a_index",
      "a_name_usa"
    };
    private string Host = SkillEditor.connection.ReadSettings("Host"); //dethunter12 add
    private string User = SkillEditor.connection.ReadSettings("User"); //dethunter12 add
    private string Password = SkillEditor.connection.ReadSettings("Password"); //dethunter12 add
    private string Database = SkillEditor.connection.ReadSettings("Database"); //dethunter12 add
    private GroupBox groupBox1;
    private TextBox textBox1;
    private GroupBox groupBox2;
    private ListBox listBox1;
    private GroupBox groupBox3;
        private TextBox tbSkillName;
        private TextBox tbSkillDesc;
        private Button btnNone;
        private Button btnSelect;
        private Button btnClose;
        private GroupBox gbSort;
        private CheckedListBox ClbSort;
        private PictureBox pictureBox1;
     public string mSortJob = "-1";
    public SkillPicker()
    {
            InitializeComponent();
    }

    private void SkillPicker_Load(object sender, EventArgs e)
    {
            LoadStartup(); //dethunter12 add
            MenuList.Clear();
      for (int index = 0; index < ((IEnumerable<SkillIcon>) IconSkill.List).Count<SkillIcon>(); ++index) //dethunter12 adjust
                MenuList.Add("" + IconSkill.List[index].SkillID.ToString() + " - " + IconSkill.List[index].Name.ToString()); //dethunter12 adjust
            listBox1.DataSource = (object)MenuList;
    }

    private void LoadStartup()
        {
            ClbSort.Items.AddRange(new object[14]
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
        }
    private int GetID()
    {
      int result = -1;
      int.TryParse(listBox1.Text.Split(' ')[0], out result);
      return result;
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
            int SkillID = GetID(); //name = searched  value
            if (SkillID == -1) // if value doesnt exist cancel
                return;
            SkillIcon SkillIcon = IconSkill.List.Find((Predicate<SkillIcon>)(g => g.SkillID.Equals(SkillID)));
            if (SkillIcon == null) // if icon doesnt exist cancel
                return;
            SkillIndex = SkillIcon.SkillID;
            tbSkillName.Text = SkillIcon.Name; // assigns  the name from ticon to textbox
            tbSkillDesc.Text = SkillIcon.Desc; //assigns the description from ticon to textbox //.IconFast(SkillIcon.SkillID);
            pictureBox1.Image = (Image)new DatabaseHandle().SkillsFast(SkillIcon.SkillID);
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

    protected override void Dispose(bool disposing)
    {
      if (disposing && components != null)
                components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkillPicker));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNone = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbSkillDesc = new System.Windows.Forms.TextBox();
            this.tbSkillName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbSort = new System.Windows.Forms.GroupBox();
            this.ClbSort = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNone);
            this.groupBox2.Controls.Add(this.btnSelect);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 363);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Skills";
            // 
            // btnNone
            // 
            this.btnNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNone.Location = new System.Drawing.Point(99, 334);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(63, 23);
            this.btnNone.TabIndex = 4;
            this.btnNone.Text = "None";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Location = new System.Drawing.Point(6, 334);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(87, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 303);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbSkillDesc);
            this.groupBox3.Controls.Add(this.tbSkillName);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(244, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 132);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preview";
            // 
            // tbSkillDesc
            // 
            this.tbSkillDesc.BackColor = System.Drawing.SystemColors.Control;
            this.tbSkillDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSkillDesc.Location = new System.Drawing.Point(73, 57);
            this.tbSkillDesc.Multiline = true;
            this.tbSkillDesc.Name = "tbSkillDesc";
            this.tbSkillDesc.ReadOnly = true;
            this.tbSkillDesc.Size = new System.Drawing.Size(151, 60);
            this.tbSkillDesc.TabIndex = 2;
            // 
            // tbSkillName
            // 
            this.tbSkillName.BackColor = System.Drawing.SystemColors.Control;
            this.tbSkillName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSkillName.Location = new System.Drawing.Point(73, 20);
            this.tbSkillName.Name = "tbSkillName";
            this.tbSkillName.ReadOnly = true;
            this.tbSkillName.Size = new System.Drawing.Size(151, 20);
            this.tbSkillName.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(180, 404);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbSort
            // 
            this.gbSort.Controls.Add(this.ClbSort);
            this.gbSort.Location = new System.Drawing.Point(250, 208);
            this.gbSort.Name = "gbSort";
            this.gbSort.Size = new System.Drawing.Size(252, 225);
            this.gbSort.TabIndex = 6;
            this.gbSort.TabStop = false;
            this.gbSort.Text = "Sort";
            // 
            // ClbSort
            // 
            this.ClbSort.BackColor = System.Drawing.SystemColors.Control;
            this.ClbSort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClbSort.CheckOnClick = true;
            this.ClbSort.FormattingEnabled = true;
            this.ClbSort.Location = new System.Drawing.Point(15, 19);
            this.ClbSort.MultiColumn = true;
            this.ClbSort.Name = "ClbSort";
            this.ClbSort.Size = new System.Drawing.Size(231, 135);
            this.ClbSort.TabIndex = 0;
            this.ClbSort.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ClbSort_ItemCheck);
            this.ClbSort.SelectedIndexChanged += new System.EventHandler(this.ClbSort_SelectedIndexChanged);
            // 
            // SkillPicker
            // 
            this.ClientSize = new System.Drawing.Size(504, 445);
            this.Controls.Add(this.gbSort);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SkillPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Skill Picker";
            this.Load += new System.EventHandler(this.SkillPicker_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbSort.ResumeLayout(false);
            this.ResumeLayout(false);

    }
        private void LoadListBox() //dethunter12 add
    {
            listBox1.SelectedIndex = -1;
            MenuList.Clear();
      string Query = "SELECT a_index, a_name_usa FROM t_skill WHERE a_job ='" + mSortJob + "' ORDER BY a_index;";
      if (mSortJob == "-1")
        Query = "SELECT a_index, a_name_usa FROM t_skill ORDER BY a_index;";
            listBox1.DataSource = databaseHandle.SelectMySqlReturnList(menuArray, Host, User, Password, Database, Query);
      for (int index = 0; index < listBox1.Items.Count; ++index)
                MenuList.Add(listBox1.Items[index].ToString());
            listBox1.DataSource = MenuList;
            listBox1.SelectedIndex = -1;
    }
       public bool SearchString(string s)
        {
            return s.ToUpper().Contains(textBox1.Text.ToUpper());
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK; //dethunter12 add
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            SkillIndex = -1; //sets skill index to nothing
            DialogResult = DialogResult.OK; //dethunter12 add
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close(); //close
        }

        private void ClbSort_SelectedIndexChanged(object sender, EventArgs e) //dethunter12 add
        {
            string str = GetIndexByComboBox(ClbSort.Text).ToString();
            
            mSortJob = str;
            if (ClbSort.Text == "1")
                
            LoadListBox();
        }

        private void ClbSort_ItemCheck(object sender, ItemCheckEventArgs e) //dethunter12 add
        {
            if (e.NewValue == CheckState.Checked && ClbSort.CheckedItems.Count > 0) //checks if the checked item count is greater than 0
            {
                ClbSort.ItemCheck -= ClbSort_ItemCheck;
                ClbSort.SetItemChecked(ClbSort.CheckedIndices[0], false);
                ClbSort.ItemCheck += ClbSort_ItemCheck;
            }
            string str = GetIndexByComboBox(ClbSort.Text).ToString();
            mSortJob = str;
            LoadListBox();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MenuListSearch = MenuList.FindAll(new Predicate<string>(SearchString));
            listBox1.DataSource = (object)MenuListSearch;
        }
    }
}
