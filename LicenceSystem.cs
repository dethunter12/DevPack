// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.LicenceSystem
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA
{
  public class LicenceSystem : Form
  {
    private IContainer components = (IContainer) null;
    private Label label1;
    private TextBox textBox1;
    private Label label2;
    private LinkLabel linkLabel1;

    public LicenceSystem()
    {
            InitializeComponent();
    }

    private void LicenceSystem_Load(object sender, EventArgs e)
    {
            textBox1.Text = new epvp_hwid().strHWID();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("http://www.elitepvpers.com/forum/profile.php?do=editprofile");
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(68, 13);
            label1.TabIndex = 0;
            label1.Text = "Your HWID: ";
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(82, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(373, 20);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(443, 13);
            label2.TabIndex = 2;
            label2.Text = "To use this program you must verify your epvp account. Enter this HWID in your epvp profile.";
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(36, 68);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(293, 13);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "http://www.elitepvpers.com/forum/profile.php?do=editprofile";
            linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
            AutoScaleDimensions = new SizeF(6f, 13f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 99);
            Controls.Add((Control)linkLabel1);
            Controls.Add((Control)label2);
            Controls.Add((Control)textBox1);
            Controls.Add((Control)label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LicenceSystem";
            Text = "LicenceSystem";
            Load += new EventHandler(LicenceSystem_Load);
            ResumeLayout(false);
            PerformLayout();
    }
  }
}
