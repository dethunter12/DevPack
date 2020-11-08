// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.Tools.MemoryWorker.MobEditor
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools.MemoryWorker
{
  public class MobEditor : Form
  {
    private IContainer components = (IContainer) null;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem importFromDatabaseToolStripMenuItem;
    private ToolStripMenuItem saveToolStripMenuItem;
    private ToolStripMenuItem exportToolStripMenuItem;
    private ToolStripMenuItem moballlodToolStripMenuItem;
    private ToolStripMenuItem strToolStripMenuItem;
    private ToolStripMenuItem extraToolStripMenuItem;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private ListBox listBox1;
    private StatusStrip statusStrip1;
    private Button btnDelete;
    private Button btnCopy;
    private TextBox textBox1;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Button btnSave;
    private GroupBox groupBox3;
    private Label label1;
    private TextBox txtIndex;
    private CheckBox checkBoxEnable;
    private TextBox txtName;
    private Label label2;
    private GroupBox groupBox4;
    private TextBox txtFamily;
    private TextBox txtskillmaster;
    private TextBox txtFlag;
    private TextBox txtFlag1;
    private Label label3;
    private Label label4;
    private Label label6;
    private Label label5;
    private GroupBox groupBox5;
    private TextBox txtStateFlag;
    private Label label7;
    private Label label9;
    private TextBox txtExp;
    private Label label8;
    private TextBox txtLevel;
    private Label label10;
    private TextBox txtGold;
    private Label label13;
    private TextBox txtSize;
    private Label label11;
    private TextBox txtSight;
    private Label label12;
    private TextBox txtSkillPoint;
    private Label label14;
    private Label label15;
    private TextBox txtAttackArea;
    private TextBox txtMoveArea;
    private Label label16;
    private Label label17;
    private TextBox txtRunSpeed;
    private TextBox txtWalkSpeed;
    private GroupBox groupBox6;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private TabPage tabPage5;
    private Label label18;
    private Label label21;
    private Label label20;
    private Label label19;
    private Label label22;
    private TextBox txtAttack;
    private Label label23;
    private TextBox txtMagic;
    private Label label25;
    private TextBox txtResist;
    private Label label24;
    private TextBox txtDefense;
    private GroupBox groupBox7;
    private GroupBox groupBox8;
    private GroupBox groupBox9;
    private TextBox txtDefenseLevel;
    private TextBox txtAttackLevel;
    private Label label26;
    private Label label27;
    private TextBox txtMP;
    private Label label28;
    private Label label29;
    private TextBox txtHP;
    private GroupBox groupBox10;
    private Label label30;
    private Label label31;
    private TextBox txtRecoverHP;
    private TextBox txtRecoverMP;
    private GroupBox groupBox11;
    private Label label33;
    private TextBox txtSkill1;
    private Label label32;
    private TextBox txtSkill0;
    private Label label34;
    private TextBox txtSkill3;
    private Label label35;
    private TextBox txtSkill2;
    private TabPage tabPage6;
    private GroupBox groupBox12;
    private TextBox txtMagicAvoid;
    private TextBox txtHit;
    private Label label36;
    private Label label37;
    private TextBox txtJobAttribute;
    private Label label38;
    private Label label39;
    private TextBox txtDodge;
    private TabPage tabPage7;
    private GroupBox groupBox13;
    private TextBox txtAttackType;
    private Label label40;
    private TextBox txtAttackSpeed;
    private Label label41;
    private Label label42;
    private TextBox txtsskillmaster;
    private NumericUpDown txtStr;
    private NumericUpDown txtDex;
    private NumericUpDown txtInt;
    private NumericUpDown txtCon;
    private ToolStripProgressBar toolStripProgressBar1;
    private ToolStripStatusLabel toolStripStatusLabel1;
    private PictureBox pictureBox23;
    private PictureBox pictureBox1;

    public MobEditor()
    {
            InitializeComponent();
    }

    private void importFromDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new LoadFromDatabase().tnpc_Import();
            MakeList();
            checkListEmpty();
    }

    public void MakeList()
    {
      List<string> stringList = new List<string>();
      List<tnpc> all = AllLists.tnpc_MenuData.FindAll((Predicate<tnpc>) (p => p.name.ToLower().Contains(textBox1.Text.ToLower())));
      for (int index = 0; index < all.Count<tnpc>(); ++index)
        stringList.Add(all[index].index.ToString() + " - " + all[index].name.ToString());
            listBox1.Items.Clear();
            listBox1.Items.AddRange((object[]) stringList.ToArray());
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      mySQL.SetConnection();
            checkListEmpty();
    }

    private void checkListEmpty()
    {
      if (AllLists.tnpc_MenuData.Count<tnpc>() == 0)
      {
                saveToolStripMenuItem.Enabled = false;
                tabControl1.Enabled = false;
      }
      else
      {
                saveToolStripMenuItem.Enabled = true;
                tabControl1.Enabled = true;
      }
    }

    private int GetID()
    {
      int result = -1;
      int.TryParse(listBox1.Text.Split(' ')[0], out result);
      return result;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      int NpcID = GetID();
      if (NpcID == -1)
        return;
      tnpc tnpc = AllLists.tnpc_MenuData.Find(p => p.index.Equals(NpcID));
      tnpc.name = Convert.ToString(txtName.Text);
      tnpc.family = Convert.ToInt32(txtFamily.Text);
      tnpc.skillmaster = Convert.ToInt32(txtskillmaster.Text);
      tnpc.flag = Convert.ToInt32(txtFlag.Text);
      tnpc.flag1 = Convert.ToInt32(txtFlag1.Text);
      tnpc.stateflag = Convert.ToInt32(txtStateFlag.Text);
      tnpc.level = Convert.ToInt32(txtLevel.Text);
      tnpc.exp = Convert.ToInt32(txtExp.Text);
      tnpc.prize = Convert.ToInt32(txtGold.Text);
      tnpc.sight = Convert.ToInt32(txtSight.Text);
      tnpc.size = Convert.ToSingle(txtSize.Text);
      tnpc.movearea = Convert.ToInt32(txtMoveArea.Text);
      tnpc.attackarea = Convert.ToSingle(txtAttackArea.Text);
      tnpc.skillpoint = Convert.ToInt32(txtSkillPoint.Text);
      tnpc.sskillmaster = Convert.ToInt32(txtsskillmaster.Text);
      tnpc.str = Convert.ToInt32(txtStr.Value);
      tnpc.dex = Convert.ToInt32(txtDex.Value);
      tnpc.INT = Convert.ToInt32(txtInt.Value);
      tnpc.con = Convert.ToInt32(txtCon.Value);
      tnpc.attack = Convert.ToInt32(txtAttack.Text);
      tnpc.magic = Convert.ToInt32(txtMagic.Text);
      tnpc.defense = Convert.ToInt32(txtDefense.Text);
      tnpc.resist = Convert.ToInt32(txtResist.Text);
      tnpc.attacklevel = Convert.ToInt32(txtAttackLevel.Text);
      tnpc.defenselevel = Convert.ToInt32(txtDefenseLevel.Text);
      tnpc.hp = Convert.ToInt32(txtHP.Text);
      tnpc.mp = Convert.ToInt32(txtMP.Text);
      tnpc.attacktype = Convert.ToInt32(txtAttackType.Text);
      tnpc.attackspeed = Convert.ToInt32(txtAttackSpeed.Text);
      tnpc.recoverhp = Convert.ToInt32(txtRecoverHP.Text);
      tnpc.recovermp = Convert.ToInt32(txtRecoverMP.Text);
      tnpc.walkspeed = (float) Convert.ToInt32(txtWalkSpeed.Text);
      tnpc.runspeed = (float) Convert.ToInt32(txtRunSpeed.Text);
      tnpc.skill0 = Convert.ToString(txtSkill0.Text);
      tnpc.skill1 = Convert.ToString(txtSkill1.Text);
      tnpc.skill2 = Convert.ToString(txtSkill2.Text);
      tnpc.skill3 = Convert.ToString(txtSkill3.Text);
      tnpc.dodge = Convert.ToInt32(txtDodge.Text);
      tnpc.magicavoid = Convert.ToInt32(txtMagicAvoid.Text);
      tnpc.hit = Convert.ToInt32(txtHit.Text);
      tnpc.jobattribute = Convert.ToInt32(txtJobAttribute.Text);
    }

        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      int NpcID = GetID();
      if (NpcID == -1)
        return;
      tnpc tnpc = AllLists.tnpc_MenuData.Find((Predicate<tnpc>) (p => p.index.Equals(NpcID)));
      if (tnpc == null)
        return;
            CheckParameter(tnpc.enable);
            txtIndex.Text = tnpc.index.ToString();
            txtName.Text = tnpc.name.ToString();
            checkBoxEnable.Checked = tnpc.enable == 1;
            txtFamily.Text = tnpc.family.ToString();
            txtskillmaster.Text = tnpc.skillmaster.ToString();
            txtFlag.Text = tnpc.flag.ToString();
            txtFlag1.Text = tnpc.flag1.ToString();
            txtStateFlag.Text = tnpc.stateflag.ToString();
            txtLevel.Text = tnpc.level.ToString();
            txtExp.Text = tnpc.exp.ToString();
            txtGold.Text = tnpc.prize.ToString();
            txtSight.Text = tnpc.sight.ToString();
            txtSize.Text = tnpc.size.ToString();
            txtMoveArea.Text = tnpc.movearea.ToString();
            txtAttackArea.Text = tnpc.attackarea.ToString();
            txtSkillPoint.Text = tnpc.skillpoint.ToString();
            txtsskillmaster.Text = tnpc.sskillmaster.ToString();
            txtStr.Text = tnpc.str.ToString();
            txtDex.Text = tnpc.dex.ToString();
            txtInt.Text = tnpc.INT.ToString();
            txtCon.Text = tnpc.con.ToString();
            txtAttack.Text = tnpc.attack.ToString();
            txtMagic.Text = tnpc.magic.ToString();
            txtDefense.Text = tnpc.defense.ToString();
            txtResist.Text = tnpc.resist.ToString();
            txtAttackLevel.Text = tnpc.attacklevel.ToString();
            txtDefenseLevel.Text = tnpc.defenselevel.ToString();
            txtHP.Text = tnpc.hp.ToString();
            txtMP.Text = tnpc.mp.ToString();
            txtAttackType.Text = tnpc.attacktype.ToString();
            txtAttackSpeed.Text = tnpc.attackspeed.ToString();
            txtRecoverHP.Text = tnpc.recoverhp.ToString();
            txtRecoverMP.Text = tnpc.recovermp.ToString();
            txtWalkSpeed.Text = tnpc.walkspeed.ToString();
            txtRunSpeed.Text = tnpc.runspeed.ToString();
            txtSkill0.Text = tnpc.skill0.ToString();
            txtSkill1.Text = tnpc.skill1.ToString();
            txtSkill2.Text = tnpc.skill2.ToString();
            txtSkill3.Text = tnpc.skill3.ToString();
            txtDodge.Text = tnpc.dodge.ToString();
            txtMagicAvoid.Text = tnpc.magicavoid.ToString();
            txtHit.Text = tnpc.hit.ToString();
            txtJobAttribute.Text = tnpc.jobattribute.ToString();
    }

    private void CheckParameter(int checkbox)
    {
      if (checkbox == 1)
                checkBoxEnable.BackColor = Color.Lime;
      else
                checkBoxEnable.BackColor = Color.Red;
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      mySQL.UpdateQuery("DELETE FROM t_npc");
      int num = AllLists.tnpc_MenuData.Count<tnpc>();
            toolStripProgressBar1.Visible = true;
      for (int index = 0; index < AllLists.tnpc_MenuData.Count<tnpc>(); ++index)
      {
        DatabaseUpdate.tnpc_Update(AllLists.tnpc_MenuData[index]);
                toolStripProgressBar1.Value = 100 * (index + 1) / num;
      }
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Visible = false;
    }

    private void moballlodToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new ExportLodHandle().ExportMobAll_V4();
    }

    private void strToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void btnCopy_Click(object sender, EventArgs e)
    {
      int NpcID = GetID();
      if (NpcID == -1)
        return;
      tnpc tnpc = AllLists.tnpc_MenuData.Find((Predicate<tnpc>) (p => p.index == NpcID)).Clone();
      tnpc.index = AllLists.tnpc_MenuData.Max<tnpc>((Func<tnpc, int>) (p => p.index)) + 1;
      tnpc.name += " (copy)";
      AllLists.tnpc_MenuData.Add(tnpc);
      string str = tnpc.index.ToString() + " - " + tnpc.name.ToString();
      AllLists.tnpc_Menu.Add(str);
            listBox1.Items.Add( str);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
            MakeList();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      int NpcID = GetID();
      if (NpcID == -1)
        return;
      string text = listBox1.Text;
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
      AllLists.tnpc_Menu.Remove(text);
      AllLists.tnpc_MenuData.RemoveAll((Predicate<tnpc>) (p => p.index == NpcID));
    }

    private void pictureBox23_Click(object sender, EventArgs e)
    {
      FlagBuilder flagBuilder = new FlagBuilder();
      flagBuilder.flagSmall = Convert.ToInt32(txtFlag.Text);
      flagBuilder.flagBuilderType = "npcs";
      if (flagBuilder.ShowDialog() != DialogResult.OK)
        return;
            txtFlag.Text = Convert.ToString(flagBuilder.flagSmall);
        }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
      FlagBuilder flagBuilder = new FlagBuilder();
      flagBuilder.flagSmall = Convert.ToInt32(txtFlag1.Text);
      flagBuilder.flagBuilderType = "npcs";
      if (flagBuilder.ShowDialog() != DialogResult.OK)
        return;
            txtFlag1.Text = Convert.ToString(flagBuilder.flagSmall);
        }

    protected override void Dispose(bool disposing)
    {
      if (disposing && components != null)
                components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moballlodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.txtAttackType = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txtAttackSpeed = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.txtMagicAvoid = new System.Windows.Forms.TextBox();
            this.txtHit = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.txtJobAttribute = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.txtDodge = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txtSkill3 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.txtSkill1 = new System.Windows.Forms.TextBox();
            this.txtSkill2 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtSkill0 = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtRecoverHP = new System.Windows.Forms.TextBox();
            this.txtRecoverMP = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.txtMP = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtDefenseLevel = new System.Windows.Forms.TextBox();
            this.txtAttackLevel = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtMagic = new System.Windows.Forms.TextBox();
            this.txtAttack = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtResist = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtDefense = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtCon = new System.Windows.Forms.NumericUpDown();
            this.txtInt = new System.Windows.Forms.NumericUpDown();
            this.txtDex = new System.Windows.Forms.NumericUpDown();
            this.txtStr = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRunSpeed = new System.Windows.Forms.TextBox();
            this.txtWalkSpeed = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAttackArea = new System.Windows.Forms.TextBox();
            this.txtMoveArea = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStateFlag = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFlag1 = new System.Windows.Forms.TextBox();
            this.txtFlag = new System.Windows.Forms.TextBox();
            this.txtskillmaster = new System.Windows.Forms.TextBox();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label42 = new System.Windows.Forms.Label();
            this.txtsskillmaster = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSight = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSkillPoint = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGold = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtExp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxEnable = new System.Windows.Forms.CheckBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStr)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.extraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(970, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFromDatabaseToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importFromDatabaseToolStripMenuItem
            // 
            this.importFromDatabaseToolStripMenuItem.Name = "importFromDatabaseToolStripMenuItem";
            this.importFromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importFromDatabaseToolStripMenuItem.Text = "Load from Database";
            this.importFromDatabaseToolStripMenuItem.Click += new System.EventHandler(this.importFromDatabaseToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moballlodToolStripMenuItem,
            this.strToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // moballlodToolStripMenuItem
            // 
            this.moballlodToolStripMenuItem.Name = "moballlodToolStripMenuItem";
            this.moballlodToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.moballlodToolStripMenuItem.Text = "mobAll.lod";
            this.moballlodToolStripMenuItem.Click += new System.EventHandler(this.moballlodToolStripMenuItem_Click);
            // 
            // strToolStripMenuItem
            // 
            this.strToolStripMenuItem.Enabled = false;
            this.strToolStripMenuItem.Name = "strToolStripMenuItem";
            this.strToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.strToolStripMenuItem.Text = "strNpcName_us.lod";
            this.strToolStripMenuItem.Click += new System.EventHandler(this.strToolStripMenuItem_Click);
            // 
            // extraToolStripMenuItem
            // 
            this.extraToolStripMenuItem.Enabled = false;
            this.extraToolStripMenuItem.Name = "extraToolStripMenuItem";
            this.extraToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.extraToolStripMenuItem.Text = "Extra";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnCopy);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 493);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mob list";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(142, 464);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Location = new System.Drawing.Point(6, 464);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(130, 23);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "New Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // listBox1
            // 
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 433);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 580);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(970, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 15);
            this.toolStripProgressBar1.Step = 1;
            this.toolStripProgressBar1.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(274, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(25, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(674, 509);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(666, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox13);
            this.groupBox6.Controls.Add(this.groupBox12);
            this.groupBox6.Controls.Add(this.groupBox11);
            this.groupBox6.Controls.Add(this.groupBox10);
            this.groupBox6.Controls.Add(this.groupBox9);
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Location = new System.Drawing.Point(6, 190);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(652, 285);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Strength / Skills";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.txtAttackType);
            this.groupBox13.Controls.Add(this.label40);
            this.groupBox13.Controls.Add(this.txtAttackSpeed);
            this.groupBox13.Controls.Add(this.label41);
            this.groupBox13.Location = new System.Drawing.Point(190, 152);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(131, 74);
            this.groupBox13.TabIndex = 42;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Attack";
            // 
            // txtAttackType
            // 
            this.txtAttackType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAttackType.Location = new System.Drawing.Point(76, 16);
            this.txtAttackType.Name = "txtAttackType";
            this.txtAttackType.Size = new System.Drawing.Size(44, 20);
            this.txtAttackType.TabIndex = 21;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(6, 20);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(65, 13);
            this.label40.TabIndex = 20;
            this.label40.Text = "AttackType:";
            // 
            // txtAttackSpeed
            // 
            this.txtAttackSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAttackSpeed.Location = new System.Drawing.Point(76, 42);
            this.txtAttackSpeed.Name = "txtAttackSpeed";
            this.txtAttackSpeed.Size = new System.Drawing.Size(44, 20);
            this.txtAttackSpeed.TabIndex = 23;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(6, 46);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(72, 13);
            this.label41.TabIndex = 22;
            this.label41.Text = "AttackSpeed:";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.txtMagicAvoid);
            this.groupBox12.Controls.Add(this.txtHit);
            this.groupBox12.Controls.Add(this.label36);
            this.groupBox12.Controls.Add(this.label37);
            this.groupBox12.Controls.Add(this.txtJobAttribute);
            this.groupBox12.Controls.Add(this.label38);
            this.groupBox12.Controls.Add(this.label39);
            this.groupBox12.Controls.Add(this.txtDodge);
            this.groupBox12.Location = new System.Drawing.Point(324, 101);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(322, 73);
            this.groupBox12.TabIndex = 41;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Attribute";
            // 
            // txtMagicAvoid
            // 
            this.txtMagicAvoid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMagicAvoid.Location = new System.Drawing.Point(246, 16);
            this.txtMagicAvoid.Name = "txtMagicAvoid";
            this.txtMagicAvoid.Size = new System.Drawing.Size(70, 20);
            this.txtMagicAvoid.TabIndex = 31;
            // 
            // txtHit
            // 
            this.txtHit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHit.Location = new System.Drawing.Point(84, 16);
            this.txtHit.Name = "txtHit";
            this.txtHit.Size = new System.Drawing.Size(70, 20);
            this.txtHit.TabIndex = 29;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(176, 45);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(66, 13);
            this.label36.TabIndex = 34;
            this.label36.Text = "JobAttribute:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(14, 20);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(23, 13);
            this.label37.TabIndex = 28;
            this.label37.Text = "Hit:";
            // 
            // txtJobAttribute
            // 
            this.txtJobAttribute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJobAttribute.Location = new System.Drawing.Point(246, 41);
            this.txtJobAttribute.Name = "txtJobAttribute";
            this.txtJobAttribute.Size = new System.Drawing.Size(70, 20);
            this.txtJobAttribute.TabIndex = 35;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(176, 20);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(66, 13);
            this.label38.TabIndex = 30;
            this.label38.Text = "MagicAvoid:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(14, 43);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(42, 13);
            this.label39.TabIndex = 32;
            this.label39.Text = "Dodge:";
            // 
            // txtDodge
            // 
            this.txtDodge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDodge.Location = new System.Drawing.Point(84, 39);
            this.txtDodge.Name = "txtDodge";
            this.txtDodge.Size = new System.Drawing.Size(70, 20);
            this.txtDodge.TabIndex = 33;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label34);
            this.groupBox11.Controls.Add(this.label33);
            this.groupBox11.Controls.Add(this.txtSkill3);
            this.groupBox11.Controls.Add(this.label35);
            this.groupBox11.Controls.Add(this.txtSkill1);
            this.groupBox11.Controls.Add(this.txtSkill2);
            this.groupBox11.Controls.Add(this.label32);
            this.groupBox11.Controls.Add(this.txtSkill0);
            this.groupBox11.Location = new System.Drawing.Point(324, 180);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(322, 76);
            this.groupBox11.TabIndex = 40;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Skills";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(163, 52);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(32, 13);
            this.label34.TabIndex = 44;
            this.label34.Text = "Skill3";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(10, 52);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(32, 13);
            this.label33.TabIndex = 40;
            this.label33.Text = "Skill1";
            // 
            // txtSkill3
            // 
            this.txtSkill3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSkill3.Location = new System.Drawing.Point(216, 50);
            this.txtSkill3.Name = "txtSkill3";
            this.txtSkill3.Size = new System.Drawing.Size(88, 20);
            this.txtSkill3.TabIndex = 45;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(164, 28);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(35, 13);
            this.label35.TabIndex = 42;
            this.label35.Text = "Skill2:";
            // 
            // txtSkill1
            // 
            this.txtSkill1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSkill1.Location = new System.Drawing.Point(53, 50);
            this.txtSkill1.Name = "txtSkill1";
            this.txtSkill1.Size = new System.Drawing.Size(88, 20);
            this.txtSkill1.TabIndex = 41;
            // 
            // txtSkill2
            // 
            this.txtSkill2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSkill2.Location = new System.Drawing.Point(215, 24);
            this.txtSkill2.Name = "txtSkill2";
            this.txtSkill2.Size = new System.Drawing.Size(88, 20);
            this.txtSkill2.TabIndex = 43;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(7, 28);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(35, 13);
            this.label32.TabIndex = 38;
            this.label32.Text = "Skill0:";
            // 
            // txtSkill0
            // 
            this.txtSkill0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSkill0.Location = new System.Drawing.Point(53, 26);
            this.txtSkill0.Name = "txtSkill0";
            this.txtSkill0.Size = new System.Drawing.Size(88, 20);
            this.txtSkill0.TabIndex = 39;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label30);
            this.groupBox10.Controls.Add(this.label31);
            this.groupBox10.Controls.Add(this.txtRecoverHP);
            this.groupBox10.Controls.Add(this.txtRecoverMP);
            this.groupBox10.Controls.Add(this.label26);
            this.groupBox10.Controls.Add(this.label29);
            this.groupBox10.Controls.Add(this.txtHP);
            this.groupBox10.Controls.Add(this.txtMP);
            this.groupBox10.Location = new System.Drawing.Point(6, 101);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(174, 127);
            this.groupBox10.TabIndex = 39;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Health / Mana";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(13, 105);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(54, 13);
            this.label30.TabIndex = 38;
            this.label30.Text = "ManaReg";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(13, 79);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(61, 13);
            this.label31.TabIndex = 36;
            this.label31.Text = "HealthReg:";
            // 
            // txtRecoverHP
            // 
            this.txtRecoverHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecoverHP.Location = new System.Drawing.Point(80, 75);
            this.txtRecoverHP.Name = "txtRecoverHP";
            this.txtRecoverHP.Size = new System.Drawing.Size(88, 20);
            this.txtRecoverHP.TabIndex = 37;
            // 
            // txtRecoverMP
            // 
            this.txtRecoverMP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecoverMP.Location = new System.Drawing.Point(80, 101);
            this.txtRecoverMP.Name = "txtRecoverMP";
            this.txtRecoverMP.Size = new System.Drawing.Size(88, 20);
            this.txtRecoverMP.TabIndex = 39;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(13, 51);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(37, 13);
            this.label26.TabIndex = 34;
            this.label26.Text = "Mana:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(13, 25);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 13);
            this.label29.TabIndex = 32;
            this.label29.Text = "Health:";
            // 
            // txtHP
            // 
            this.txtHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHP.Location = new System.Drawing.Point(61, 21);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(107, 20);
            this.txtHP.TabIndex = 33;
            // 
            // txtMP
            // 
            this.txtMP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMP.Location = new System.Drawing.Point(61, 47);
            this.txtMP.Name = "txtMP";
            this.txtMP.Size = new System.Drawing.Size(107, 20);
            this.txtMP.TabIndex = 35;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtDefenseLevel);
            this.groupBox9.Controls.Add(this.txtAttackLevel);
            this.groupBox9.Controls.Add(this.label27);
            this.groupBox9.Controls.Add(this.label28);
            this.groupBox9.Location = new System.Drawing.Point(6, 19);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(175, 76);
            this.groupBox9.TabIndex = 38;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Level";
            // 
            // txtDefenseLevel
            // 
            this.txtDefenseLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDefenseLevel.Location = new System.Drawing.Point(117, 44);
            this.txtDefenseLevel.Name = "txtDefenseLevel";
            this.txtDefenseLevel.Size = new System.Drawing.Size(52, 20);
            this.txtDefenseLevel.TabIndex = 31;
            // 
            // txtAttackLevel
            // 
            this.txtAttackLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAttackLevel.Location = new System.Drawing.Point(117, 18);
            this.txtAttackLevel.Name = "txtAttackLevel";
            this.txtAttackLevel.Size = new System.Drawing.Size(52, 20);
            this.txtAttackLevel.TabIndex = 29;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(14, 20);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(67, 13);
            this.label27.TabIndex = 28;
            this.label27.Text = "AttackLevel:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(14, 48);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(76, 13);
            this.label28.TabIndex = 30;
            this.label28.Text = "DefenseLevel:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtMagic);
            this.groupBox8.Controls.Add(this.txtAttack);
            this.groupBox8.Controls.Add(this.label25);
            this.groupBox8.Controls.Add(this.label22);
            this.groupBox8.Controls.Add(this.txtResist);
            this.groupBox8.Controls.Add(this.label23);
            this.groupBox8.Controls.Add(this.label24);
            this.groupBox8.Controls.Add(this.txtDefense);
            this.groupBox8.Location = new System.Drawing.Point(324, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(322, 73);
            this.groupBox8.TabIndex = 37;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Stats";
            // 
            // txtMagic
            // 
            this.txtMagic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMagic.Location = new System.Drawing.Point(246, 16);
            this.txtMagic.Name = "txtMagic";
            this.txtMagic.Size = new System.Drawing.Size(70, 20);
            this.txtMagic.TabIndex = 31;
            // 
            // txtAttack
            // 
            this.txtAttack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAttack.Location = new System.Drawing.Point(84, 16);
            this.txtAttack.Name = "txtAttack";
            this.txtAttack.Size = new System.Drawing.Size(70, 20);
            this.txtAttack.TabIndex = 29;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(176, 45);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 13);
            this.label25.TabIndex = 34;
            this.label25.Text = "Resist:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(14, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 13);
            this.label22.TabIndex = 28;
            this.label22.Text = "Attack:";
            // 
            // txtResist
            // 
            this.txtResist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResist.Location = new System.Drawing.Point(246, 41);
            this.txtResist.Name = "txtResist";
            this.txtResist.Size = new System.Drawing.Size(70, 20);
            this.txtResist.TabIndex = 35;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(176, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(39, 13);
            this.label23.TabIndex = 30;
            this.label23.Text = "Magic:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(14, 43);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(50, 13);
            this.label24.TabIndex = 32;
            this.label24.Text = "Defense:";
            // 
            // txtDefense
            // 
            this.txtDefense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDefense.Location = new System.Drawing.Point(84, 39);
            this.txtDefense.Name = "txtDefense";
            this.txtDefense.Size = new System.Drawing.Size(70, 20);
            this.txtDefense.TabIndex = 33;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtCon);
            this.groupBox7.Controls.Add(this.txtInt);
            this.groupBox7.Controls.Add(this.txtDex);
            this.groupBox7.Controls.Add(this.txtStr);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Location = new System.Drawing.Point(187, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(131, 127);
            this.groupBox7.TabIndex = 36;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Basic Stats";
            // 
            // txtCon
            // 
            this.txtCon.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtCon.Location = new System.Drawing.Point(72, 95);
            this.txtCon.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(53, 20);
            this.txtCon.TabIndex = 46;
            // 
            // txtInt
            // 
            this.txtInt.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtInt.Location = new System.Drawing.Point(72, 70);
            this.txtInt.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(53, 20);
            this.txtInt.TabIndex = 45;
            // 
            // txtDex
            // 
            this.txtDex.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtDex.Location = new System.Drawing.Point(72, 44);
            this.txtDex.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtDex.Name = "txtDex";
            this.txtDex.Size = new System.Drawing.Size(53, 20);
            this.txtDex.TabIndex = 44;
            // 
            // txtStr
            // 
            this.txtStr.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtStr.Location = new System.Drawing.Point(72, 16);
            this.txtStr.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtStr.Name = "txtStr";
            this.txtStr.Size = new System.Drawing.Size(51, 20);
            this.txtStr.TabIndex = 43;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Strength:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 46);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 13);
            this.label19.TabIndex = 22;
            this.label19.Text = "Dexterity";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 24;
            this.label20.Text = "Intelligence:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 98);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 13);
            this.label21.TabIndex = 26;
            this.label21.Text = "Constitution:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.txtRunSpeed);
            this.groupBox5.Controls.Add(this.txtWalkSpeed);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.txtAttackArea);
            this.groupBox5.Controls.Add(this.txtMoveArea);
            this.groupBox5.Location = new System.Drawing.Point(333, 107);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(325, 77);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Move";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(154, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "RunSpeed:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "WalkSpeed:";
            // 
            // txtRunSpeed
            // 
            this.txtRunSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRunSpeed.Location = new System.Drawing.Point(223, 47);
            this.txtRunSpeed.Name = "txtRunSpeed";
            this.txtRunSpeed.Size = new System.Drawing.Size(69, 20);
            this.txtRunSpeed.TabIndex = 21;
            // 
            // txtWalkSpeed
            // 
            this.txtWalkSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWalkSpeed.Location = new System.Drawing.Point(75, 47);
            this.txtWalkSpeed.Name = "txtWalkSpeed";
            this.txtWalkSpeed.Size = new System.Drawing.Size(54, 20);
            this.txtWalkSpeed.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(154, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "AttackArea:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "MoveArea:";
            // 
            // txtAttackArea
            // 
            this.txtAttackArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAttackArea.Location = new System.Drawing.Point(223, 21);
            this.txtAttackArea.Name = "txtAttackArea";
            this.txtAttackArea.Size = new System.Drawing.Size(69, 20);
            this.txtAttackArea.TabIndex = 17;
            // 
            // txtMoveArea
            // 
            this.txtMoveArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoveArea.Location = new System.Drawing.Point(75, 21);
            this.txtMoveArea.Name = "txtMoveArea";
            this.txtMoveArea.Size = new System.Drawing.Size(54, 20);
            this.txtMoveArea.TabIndex = 16;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.pictureBox23);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtStateFlag);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtFlag1);
            this.groupBox4.Controls.Add(this.txtFlag);
            this.groupBox4.Controls.Add(this.txtskillmaster);
            this.groupBox4.Controls.Add(this.txtFamily);
            this.groupBox4.Location = new System.Drawing.Point(333, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 95);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "State";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(298, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 20);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "a";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox23.Location = new System.Drawing.Point(298, 66);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(17, 20);
            this.pictureBox23.TabIndex = 43;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.Tag = "a";
            this.pictureBox23.Click += new System.EventHandler(this.pictureBox23_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "StateFlag:";
            // 
            // txtStateFlag
            // 
            this.txtStateFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStateFlag.Location = new System.Drawing.Point(223, 14);
            this.txtStateFlag.Name = "txtStateFlag";
            this.txtStateFlag.Size = new System.Drawing.Size(69, 20);
            this.txtStateFlag.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Flag1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Flag:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Skillmaster:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Family:";
            // 
            // txtFlag1
            // 
            this.txtFlag1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFlag1.Location = new System.Drawing.Point(223, 40);
            this.txtFlag1.Name = "txtFlag1";
            this.txtFlag1.Size = new System.Drawing.Size(69, 20);
            this.txtFlag1.TabIndex = 12;
            // 
            // txtFlag
            // 
            this.txtFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFlag.Location = new System.Drawing.Point(75, 66);
            this.txtFlag.Name = "txtFlag";
            this.txtFlag.Size = new System.Drawing.Size(217, 20);
            this.txtFlag.TabIndex = 11;
            // 
            // txtskillmaster
            // 
            this.txtskillmaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtskillmaster.Location = new System.Drawing.Point(75, 40);
            this.txtskillmaster.Name = "txtskillmaster";
            this.txtskillmaster.Size = new System.Drawing.Size(54, 20);
            this.txtskillmaster.TabIndex = 10;
            // 
            // txtFamily
            // 
            this.txtFamily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFamily.Location = new System.Drawing.Point(75, 14);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(54, 20);
            this.txtFamily.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label42);
            this.groupBox3.Controls.Add(this.txtsskillmaster);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtSize);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtSight);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtSkillPoint);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtGold);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtExp);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtLevel);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.checkBoxEnable);
            this.groupBox3.Controls.Add(this.txtIndex);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 178);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Basic";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(7, 148);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(68, 13);
            this.label42.TabIndex = 22;
            this.label42.Text = "SSkillMaster:";
            // 
            // txtsskillmaster
            // 
            this.txtsskillmaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsskillmaster.Location = new System.Drawing.Point(81, 144);
            this.txtsskillmaster.Name = "txtsskillmaster";
            this.txtsskillmaster.Size = new System.Drawing.Size(87, 20);
            this.txtsskillmaster.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(180, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Size:";
            // 
            // txtSize
            // 
            this.txtSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSize.Location = new System.Drawing.Point(218, 118);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(97, 20);
            this.txtSize.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Sight:";
            // 
            // txtSight
            // 
            this.txtSight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSight.Location = new System.Drawing.Point(81, 118);
            this.txtSight.Name = "txtSight";
            this.txtSight.Size = new System.Drawing.Size(87, 20);
            this.txtSight.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "SkillPoint:";
            // 
            // txtSkillPoint
            // 
            this.txtSkillPoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSkillPoint.Location = new System.Drawing.Point(81, 92);
            this.txtSkillPoint.Name = "txtSkillPoint";
            this.txtSkillPoint.Size = new System.Drawing.Size(87, 20);
            this.txtSkillPoint.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(180, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Gold:";
            // 
            // txtGold
            // 
            this.txtGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGold.Location = new System.Drawing.Point(218, 66);
            this.txtGold.Name = "txtGold";
            this.txtGold.Size = new System.Drawing.Size(97, 20);
            this.txtGold.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "EXP:";
            // 
            // txtExp
            // 
            this.txtExp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExp.Location = new System.Drawing.Point(81, 66);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(87, 20);
            this.txtExp.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Level:";
            // 
            // txtLevel
            // 
            this.txtLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLevel.Location = new System.Drawing.Point(182, 14);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(45, 20);
            this.txtLevel.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(81, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 20);
            this.txtName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name:";
            // 
            // checkBoxEnable
            // 
            this.checkBoxEnable.AutoSize = true;
            this.checkBoxEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxEnable.Location = new System.Drawing.Point(259, 14);
            this.checkBoxEnable.Name = "checkBoxEnable";
            this.checkBoxEnable.Size = new System.Drawing.Size(56, 17);
            this.checkBoxEnable.TabIndex = 6;
            this.checkBoxEnable.Text = "Enable";
            this.checkBoxEnable.UseVisualStyleBackColor = true;
            // 
            // txtIndex
            // 
            this.txtIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIndex.Location = new System.Drawing.Point(81, 14);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(44, 20);
            this.txtIndex.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Index:";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(666, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Drop";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(666, 483);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "JewelDrop";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(666, 483);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Motion";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(666, 483);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Effect";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(666, 483);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "P2 Control";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(666, 483);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Misc";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(862, 548);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MobEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 602);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MobEditor";
            this.Text = "[Beta]Ultimate MobEditor for Episode 4 by DamonA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStr)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
  }
}
