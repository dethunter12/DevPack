// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.Tools.FlagBuilder
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools
{
  public class FlagBuilder : Form
  {
    public static Connection connection = new Connection();
    private string Episode = FlagBuilder.connection.ReadSettings("Episode");
    public string flagBuilderType = "items";
    private IContainer components = (IContainer) null;
    public long flagBig;
    public int flagSmall;
    private Button button1;
    public TextBox textBox2;
    public CheckedListBox clbFlagTest2;

    public FlagBuilder()
    {
            InitializeComponent();
    }

    private void LoadStartUp()
    {
      string[] strArray = new string[1]{ "0 - none" };
      if (flagBuilderType == "skills")
        strArray = FlagList.Skills;
      else if (flagBuilderType == "skills1") //dethunter12 add
        strArray = FlagList.Skills2;
       else if (flagBuilderType == "skills2") //dethunter12 add
        strArray = FlagList.Skills3;
       else if (flagBuilderType == "items")
        strArray = !(Episode == "EP4") ? FlagList.ItemsEP3 : FlagList.ItemsEP4;
      else if (flagBuilderType == "npcs")
        strArray = FlagList.Npcs;
      else if (flagBuilderType == "npcs1")
        strArray = FlagList.Npcs1;
            clbFlagTest2.Items.AddRange((object[]) strArray);
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

    private void ShowFlagLong(long flag)
    {
      for (int index = 0; index < 64; ++index)
                clbFlagTest2.SetItemChecked(index, (flag & 1L << index) > 0L);
    }

    private void ShowFlag(int flag)
    {
      for (int index = 0; index < clbFlagTest2.Items.Count; ++index)
                clbFlagTest2.SetItemChecked(index, (flag & 1 << index) > 0);
    }

    private void clbFlagTest2_SelectedIndexChanged(object sender, EventArgs e)
    {
      long num = 0;
      for (int index = 0; index < clbFlagTest2.Items.Count; ++index)
      {
        if (clbFlagTest2.GetItemChecked(index))
          num += 1L << index;
      }
            textBox2.Text = num.ToString();
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

    private void Form5_Load(object sender, EventArgs e)
    {
            LoadStartUp();
      if (flagBuilderType == "items")
      {
        if (Episode == "EP4")
        {
                    ShowFlagLong(flagBig);
                    textBox2.Text = flagBig.ToString();
        }
        else
        {
                    ShowFlag(flagSmall);
                    textBox2.Text = flagSmall.ToString();
        }
      }
      else
      {
                ShowFlag(flagSmall);
                textBox2.Text = flagSmall.ToString();
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
            DialogResult = DialogResult.OK;
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.clbFlagTest2 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(12, 578);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // clbFlagTest2
            // 
            this.clbFlagTest2.CheckOnClick = true;
            this.clbFlagTest2.FormattingEnabled = true;
            this.clbFlagTest2.Location = new System.Drawing.Point(12, 10);
            this.clbFlagTest2.MultiColumn = true;
            this.clbFlagTest2.Name = "clbFlagTest2";
            this.clbFlagTest2.Size = new System.Drawing.Size(280, 559);
            this.clbFlagTest2.TabIndex = 4;
            this.clbFlagTest2.SelectedIndexChanged += new System.EventHandler(this.clbFlagTest2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(192, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save Flag";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FlagBuilder
            // 
            this.ClientSize = new System.Drawing.Size(305, 610);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clbFlagTest2);
            this.Controls.Add(this.textBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlagBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FlagBuilder";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }
  }
}
