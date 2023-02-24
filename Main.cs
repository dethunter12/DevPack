// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.Main
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using Echevil;
using LcDevPack_TeamDamonA.Tools;
using LcDevPack_TeamDamonA.Tools.MemoryWorker;
using LcDevPack_TeamDamonA.Tools.MemoryWorker.rareoption;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA
{
  public class Main : Form
  {
    public static Connection connection = new Connection();
    private string Host = Main.connection.ReadSettings("Host");
    private string User = Main.connection.ReadSettings("User");
    private string Password = Main.connection.ReadSettings("Password");
    private string Database = Main.connection.ReadSettings("Database");
    private string Episode = Main.connection.ReadSettings("Episode");
    private IContainer components = (IContainer) null;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private ToolStripMenuItem reloadMemoryItemsToolStripMenuItem;
    private GroupBox groupBox1;
    private CheckedListBox checkedListBox1;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel statusLabel;
    private StatusStrip statusStrip2;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem changeLanguageToolStripMenuItem;
        private ToolStripMenuItem configToolStripMenuItem;
        private ToolStripMenuItem editConfigToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private Timer timer1;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private ProgressBar progressBar1;
        private ToolStripMenuItem updateLOGToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel1;

    public Main()
    {
            InitializeComponent();
    }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool AllocConsole();

    private void Form1_Load(object sender, EventArgs e)
    {
         
            statusLabel.Text = "Version: " + Globals.Version;
            checkedListBox1.Items.AddRange(new object[22]
      {
         "Catalog",
         "LuckyDraw",
         "Magic",
         "Moonstone",
         "Option",
         "Shop",
         "Title",
         "Skill",
         "ItemEditor",
         "MobEditor",
         "QuestEditor",
        "RewardEditor",
        "AffinityEditor",
         //"BigPetEditor",
         "ItemCollection",
        // "SetItemEditor", //dethunter12 add
       //  "MakeItemEditor" //dethunter12 add
       "BigPetEditor", //test dethunter12
        "ExChange", //test AssasinPL
        "LevelUpGuide",//Test By AssasinPL
        "Rare Option",
        "Jewel Prob",
        "Log Reader",
        "Ip Reader",
       "Action Editor",
      });
      try
      {
        MySqlConnection mySqlConnection = new MySqlConnection("SERVER=" + Host + ";DATABASE=" + Database + ";UID=" + User + ";PASSWORD=" + Password + ";");
        mySqlConnection.Open();
                Text = Globals.Name;
        if (mySqlConnection.State == ConnectionState.Open)
                    Text = Text + " [Connected to: " + Host + "]";
      }
      catch (MySqlException ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message, "Unknown Exception", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      IconList.SetConnection();
      NpcList.SetConnection(); //dethunter12 important!!
      SkillList.SetConnection(); //dethunter12 important!!
      IconSkill.SetConnection(); //test
      IconAction.SetConnection();
      IconSkill.Import(); //test
      IconAction.Import();
      IconList.Import();
      NpcList.Import(); //dethunter12 important!!!
      SkillList.Import(); //dethunter12 add 7/31/2020
            checkedListBox1.Enabled = true;
      if (!Globals.Console)
        return;
      Main.AllocConsole();
      Console.Title = "Debug Console";
      Console.WriteLine("Console Initialized.");
    }

    private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      foreach (string checkedItem in checkedListBox1.CheckedItems)
      {
        if (checkedItem == "Moonstone")
          new MoonstoneEditor().Show();
        if (checkedItem == "Skill")
          new SkillEditor().Show();
        if (checkedItem == "Catalog")
          new CatalogEditor().Show();
        if (checkedItem == "Item")
          new ItemEditor().Show();
        if (checkedItem == "Option")
          new OptionEditor().Show();
        if (checkedItem == "Shop")
          new ShopEditor().Show();
        if (checkedItem == "Title")
          new TitleEditor().Show();
        if (checkedItem == "LuckyDraw")
          new LuckyDrawBoxTool().Show();
        if (checkedItem == "Magic")
          new MagicEditor().Show();
        if (checkedItem == "ItemEditor")
          new ItemEditor2().Show();
        if (checkedItem == "MobEditor")
          new LcDevPack_TeamDamonA.Tools.MobEditor().Show();
        if (checkedItem == "MobEditor2")
          new LcDevPack_TeamDamonA.Tools.MemoryWorker.MobEditor().Show();
        if (checkedItem == "QuestEditor")
          new QuestEditor().Show();
        if (checkedItem == "RewardEditor")
          new RewardEditor().Show();
        if (checkedItem == "AffinityEditor")
          new AffinityEditor().Show();
       /* if (checkedItem == "BigPetEditor")
          new BigPetEditor().Show();*/
        if (checkedItem == "ItemCollection")
          new ItemCollection().Show();
        if (checkedItem == "SetItemEditor") //dethunter12 add
           new SetItemEditor().Show();
         if (checkedItem == "MakeItemEditor") //dethunter12 add
          new MakeItemEditor().Show();
                if (checkedItem == "BigPetEditor")
                 new LcDevPack_TeamDamonA.Tools.MemoryWorker.PetEditor.BigPetEditorr().Show();
                if (checkedItem == "ExChange")
                    new ExchangeExport.ExchangeExport_cHaR().Show(); //new LcDevPack_TeamDamonA.Tools.MemoryWorker.ExChange.ExChange().Show();
                if (checkedItem == "LevelUpGuide")
                    new LcDevPack_TeamDamonA.Tools.MemoryWorker.LevelUpGuide.LevelUpGuide().Show();
                if (checkedItem == "Jewel Prob")
                    new LcDevPack_TeamDamonA.Tools.MemoryWorker.Jawel.JawelData().Show();
                if (checkedItem == "ItemEP4")
                    new LcDevPack_TeamDamonA.Tools.MemoryWorker.Item.ItemAll().Show();
                if (checkedItem == "Log Reader")
                    new LogReader().Show();
                if (checkedItem == "Ip Reader")
                    new IpEdit().Show();
                if (checkedItem == "Rare Option")
                    new Tools.MemoryWorker.rareEditor.RareOptionEditor().Show();
                if (checkedItem == "Action Editor")
                    new LcDevPack_TeamDamonA.Tools.MemoryWorker.ActionEditor().Show();
                //if (checkedItem == "Affinity")
                //if (checkedItem == "RareOption")
                //    new LcDevPack_TeamDamonA.Tools.MemoryWorker.rareoption.RareOptionEditor().Show();
              //  if (checkedItem == "LcBall")
              //      new LcDevPack_TeamDamonA.Tools.MemoryWorker.LacaBall.LacaBall().Show();
            }
            for (int index = 0; index < checkedListBox1.Items.Count; ++index)
                checkedListBox1.SetItemChecked(index, false);
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("This website is not operated by gamigo AG. Last Chaos, ©Barunson Games Inc., published by gamigo AG 2008, LastChaos is a protected trademark, All rights reserved.", "Information");
    }

    private void reloadMemoryItemsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      IconList.List.Clear();
      NpcList.List.Clear(); //dethunter12 important
      IconSkill.List.Clear(); //dethunter12 add
      IconAction.List.Clear();
      IconList.Import();
      NpcList.Import(); //dethunter12 important
      IconSkill.Import(); //dethunter12 add
       SkillList.Import(); //dethunter12 add 7/31/2020
       IconAction.Import();
    }

   /* private void licenceSystemToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new LicenceSystem().Show();
    }
    */


    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reloadMemoryItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateLOGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadMemoryItemsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.configToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reloadMemoryItemsToolStripMenuItem
            // 
            this.reloadMemoryItemsToolStripMenuItem.Name = "reloadMemoryItemsToolStripMenuItem";
            this.reloadMemoryItemsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.reloadMemoryItemsToolStripMenuItem.Text = "Reload Items";
            this.reloadMemoryItemsToolStripMenuItem.Click += new System.EventHandler(this.reloadMemoryItemsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateLOGToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // updateLOGToolStripMenuItem
            // 
            this.updateLOGToolStripMenuItem.Name = "updateLOGToolStripMenuItem";
            this.updateLOGToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.updateLOGToolStripMenuItem.Text = "UpdateLOG";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeLanguageToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "Language";
            this.languageToolStripMenuItem.Click += new System.EventHandler(this.languageToolStripMenuItem_Click);
            // 
            // changeLanguageToolStripMenuItem
            // 
            this.changeLanguageToolStripMenuItem.Name = "changeLanguageToolStripMenuItem";
            this.changeLanguageToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.changeLanguageToolStripMenuItem.Text = "Change Language";
            this.changeLanguageToolStripMenuItem.Click += new System.EventHandler(this.changeLanguageToolStripMenuItem_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editConfigToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // editConfigToolStripMenuItem
            // 
            this.editConfigToolStripMenuItem.Name = "editConfigToolStripMenuItem";
            this.editConfigToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.editConfigToolStripMenuItem.Text = "Edit Config";
            this.editConfigToolStripMenuItem.Click += new System.EventHandler(this.editConfigToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(795, 108);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Episode 4";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.Enabled = false;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(5, 22);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(5);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(785, 81);
            this.checkedListBox1.Sorted = true;
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 181);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(814, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Status";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip2.Location = new System.Drawing.Point(0, 159);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(814, 22);
            this.statusStrip2.TabIndex = 9;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel3.Text = ":";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Click += new System.EventHandler(this.toolStripStatusLabel4_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "Processor";
            this.performanceCounter1.CounterName = "% Processor Time";
            this.performanceCounter1.InstanceName = "_Total";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(709, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 16);
            this.progressBar1.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 203);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "LastChaos Tool Collection by DamonA & Kravens Fixes By Roseon & Dethunter12 & Ass" +
    "asinPL V1.13";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }


        private void languageToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void changeLanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LangSelect langSelect = new LangSelect(); //dethunter12 add
            if (langSelect.ShowDialog() != DialogResult.OK) //dethunter12 add
                return;
        }

        private void editConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(); //dethunter12 add
            if (settings.ShowDialog() != DialogResult.OK) //dethunter12 add
                return;
        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            progressBar1.Value = (int)(performanceCounter1.NextValue());
            toolStripStatusLabel4.Text = "Processor Time: " +
                          progressBar1.Value.ToString() + "%";
            
            
        }

 
    }
}
