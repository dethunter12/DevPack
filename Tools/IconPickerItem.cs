// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.Tools.IconPickerItem
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools
{
  public class IconPickerItem : Form
  {
    public string ImageMode = "Small";
    private DatabaseHandle databaseHandle = new DatabaseHandle();
    private IContainer components = (IContainer) null;
    private ComboBox comboBox1;
    private PictureBox pictureBox1;
    private GroupBox groupBox1;
    private PictureBox SelectedIcon;
    private Button button1;
    private Button button2;

    public int TexID { get; set; }

    public int TexColumn { get; set; }

    public int TexRow { get; set; }

    public int OldItemBtnSelect { get; set; }

    public IconPickerItem()
    {
            InitializeComponent();
    }

    private void IconPicker_Load(object sender, EventArgs e)
    {
      string[] files = Directory.GetFiles("icons");
      for (int index = 0; index < ((IEnumerable<string>) files).Count<string>(); ++index)
      {
        string[] strArray = files[index].Split('\\');
        if (((IEnumerable<string>) strArray).Count<string>() == 2 && strArray[1].ToLower().Contains("itembtn"))
                    comboBox1.Items.Add( Path.GetFileNameWithoutExtension(files[index]));
      }
      if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
            comboBox1.SelectedItem =  ("ItemBtn" + OldItemBtnSelect);
    }

    private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
    {
      float num = 32f;
      if (ImageMode == "Big")
        num = 16f;
      int x = e.X;
      int y = e.Y;
            TexID = Convert.ToInt32(comboBox1.SelectedItem.ToString().Remove(0, 7));
            TexRow = (int) Math.Floor((double) y / (double) num);
            TexColumn = (int) Math.Floor((double) x / (double) num);
            SelectedIcon.Image = (Image)databaseHandle.IconItem(TexID, TexRow, TexColumn);
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      Image image = Image.FromFile("icons/" + comboBox1.SelectedItem + ".png");
      if (image.Width == 1024 && image.Height == 1024)
      {
                ImageMode = "Big";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      }
      else
      {
                ImageMode = "Small";
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
      }
            pictureBox1.Image = image;
    }

    private void button1_Click(object sender, EventArgs e)
    {
            DialogResult = DialogResult.OK;
    }

    private void button2_Click(object sender, EventArgs e)
    {
            DialogResult = DialogResult.Cancel;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && components != null)
                components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IconPickerItem));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectedIcon = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(250, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectedIcon);
            this.groupBox1.Location = new System.Drawing.Point(69, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Icon";
            // 
            // SelectedIcon
            // 
            this.SelectedIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedIcon.Location = new System.Drawing.Point(34, 37);
            this.SelectedIcon.Name = "SelectedIcon";
            this.SelectedIcon.Size = new System.Drawing.Size(32, 32);
            this.SelectedIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SelectedIcon.TabIndex = 0;
            this.SelectedIcon.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IconPickerItem
            // 
            this.ClientSize = new System.Drawing.Size(775, 560);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IconPickerItem";
            this.Text = "IconPicker";
            this.Load += new System.EventHandler(this.IconPicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectedIcon)).EndInit();
            this.ResumeLayout(false);

    }
  }
}
