namespace LcDevPack_TeamDamonA.Tools
{
    partial class MobPicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MobPicker));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.chk3D = new System.Windows.Forms.CheckBox();
            this.slideLeftRight = new System.Windows.Forms.TrackBar();
            this.slideUpDown = new System.Windows.Forms.TrackBar();
            this.slideZoom = new System.Windows.Forms.TrackBar();
            this.panel3DView = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblSmc = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMobCount = new System.Windows.Forms.Label();
            this.TbMobCount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideLeftRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideZoom)).BeginInit();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(11, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 52);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(482, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(11, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 363);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Npcs";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(165, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(104, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "None";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pick";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(243, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 57);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preview";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Npc Name";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(64, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(192, 20);
            this.textBox2.TabIndex = 4;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.chk3D);
            this.groupBox20.Controls.Add(this.slideLeftRight);
            this.groupBox20.Controls.Add(this.slideUpDown);
            this.groupBox20.Controls.Add(this.slideZoom);
            this.groupBox20.Controls.Add(this.panel3DView);
            this.groupBox20.Location = new System.Drawing.Point(243, 155);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(279, 313);
            this.groupBox20.TabIndex = 53;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "3D View";
            // 
            // chk3D
            // 
            this.chk3D.AutoSize = true;
            this.chk3D.Checked = true;
            this.chk3D.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk3D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk3D.Location = new System.Drawing.Point(180, 0);
            this.chk3D.Name = "chk3D";
            this.chk3D.Size = new System.Drawing.Size(99, 17);
            this.chk3D.TabIndex = 38;
            this.chk3D.Text = "Enable 3D View";
            this.chk3D.UseVisualStyleBackColor = true;
            // 
            // slideLeftRight
            // 
            this.slideLeftRight.AutoSize = false;
            this.slideLeftRight.Location = new System.Drawing.Point(188, 284);
            this.slideLeftRight.Maximum = 10000;
            this.slideLeftRight.Minimum = -10000;
            this.slideLeftRight.Name = "slideLeftRight";
            this.slideLeftRight.Size = new System.Drawing.Size(85, 25);
            this.slideLeftRight.TabIndex = 3;
            this.slideLeftRight.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slideLeftRight.Scroll += new System.EventHandler(this.slideLeftRight_Scroll);
            // 
            // slideUpDown
            // 
            this.slideUpDown.AutoSize = false;
            this.slideUpDown.Location = new System.Drawing.Point(95, 284);
            this.slideUpDown.Maximum = 10000;
            this.slideUpDown.Minimum = -10000;
            this.slideUpDown.Name = "slideUpDown";
            this.slideUpDown.Size = new System.Drawing.Size(85, 25);
            this.slideUpDown.TabIndex = 2;
            this.slideUpDown.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slideUpDown.Scroll += new System.EventHandler(this.slideUpDown_Scroll);
            // 
            // slideZoom
            // 
            this.slideZoom.AutoSize = false;
            this.slideZoom.Location = new System.Drawing.Point(7, 284);
            this.slideZoom.Maximum = 10000;
            this.slideZoom.Minimum = -10000;
            this.slideZoom.Name = "slideZoom";
            this.slideZoom.Size = new System.Drawing.Size(85, 25);
            this.slideZoom.TabIndex = 1;
            this.slideZoom.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slideZoom.Scroll += new System.EventHandler(this.slideZoom_Scroll);
            // 
            // panel3DView
            // 
            this.panel3DView.Location = new System.Drawing.Point(7, 20);
            this.panel3DView.Name = "panel3DView";
            this.panel3DView.Size = new System.Drawing.Size(266, 258);
            this.panel3DView.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(46, 497);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(476, 20);
            this.textBox3.TabIndex = 1;
            // 
            // lblSmc
            // 
            this.lblSmc.AutoSize = true;
            this.lblSmc.Location = new System.Drawing.Point(7, 501);
            this.lblSmc.Name = "lblSmc";
            this.lblSmc.Size = new System.Drawing.Size(33, 13);
            this.lblSmc.TabIndex = 54;
            this.lblSmc.Text = "SMC:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMobCount
            // 
            this.lblMobCount.AutoSize = true;
            this.lblMobCount.Location = new System.Drawing.Point(14, 469);
            this.lblMobCount.Name = "lblMobCount";
            this.lblMobCount.Size = new System.Drawing.Size(62, 13);
            this.lblMobCount.TabIndex = 55;
            this.lblMobCount.Text = "Mob Count:";
            // 
            // TbMobCount
            // 
            this.TbMobCount.Location = new System.Drawing.Point(82, 466);
            this.TbMobCount.Name = "TbMobCount";
            this.TbMobCount.Size = new System.Drawing.Size(155, 20);
            this.TbMobCount.TabIndex = 56;
            // 
            // MobPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 520);
            this.Controls.Add(this.TbMobCount);
            this.Controls.Add(this.lblMobCount);
            this.Controls.Add(this.lblSmc);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.groupBox20);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MobPicker";
            this.Text = "NPCPicker";
            this.Load += new System.EventHandler(this.MobPicker_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideLeftRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.CheckBox chk3D;
        private System.Windows.Forms.TrackBar slideLeftRight;
        private System.Windows.Forms.TrackBar slideUpDown;
        private System.Windows.Forms.TrackBar slideZoom;
        private System.Windows.Forms.Panel panel3DView;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblSmc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMobCount;
        private System.Windows.Forms.TextBox TbMobCount;
    }
}