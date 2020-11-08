namespace LcDevPack_TeamDamonA.Tools.MemoryWorker
{
    partial class MassPercentAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MassPercentAdd));
            this.PbSelectID2 = new System.Windows.Forms.PictureBox();
            this.PbSelectID1 = new System.Windows.Forms.PictureBox();
            this.lblRange2 = new System.Windows.Forms.Label();
            this.tbRange2 = new System.Windows.Forms.TextBox();
            this.tbRange1 = new System.Windows.Forms.TextBox();
            this.lblRange1 = new System.Windows.Forms.Label();
            this.TbNum1 = new System.Windows.Forms.TextBox();
            this.TbNum2 = new System.Windows.Forms.TextBox();
            this.TbNum0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSubtract = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID1)).BeginInit();
            this.SuspendLayout();
            // 
            // PbSelectID2
            // 
            this.PbSelectID2.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.PbSelectID2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbSelectID2.Location = new System.Drawing.Point(188, 63);
            this.PbSelectID2.Name = "PbSelectID2";
            this.PbSelectID2.Size = new System.Drawing.Size(22, 22);
            this.PbSelectID2.TabIndex = 111;
            this.PbSelectID2.TabStop = false;
            this.PbSelectID2.Click += new System.EventHandler(this.PbSelectID2_Click);
            // 
            // PbSelectID1
            // 
            this.PbSelectID1.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.PbSelectID1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbSelectID1.Location = new System.Drawing.Point(186, 23);
            this.PbSelectID1.Name = "PbSelectID1";
            this.PbSelectID1.Size = new System.Drawing.Size(22, 22);
            this.PbSelectID1.TabIndex = 110;
            this.PbSelectID1.TabStop = false;
            this.PbSelectID1.Click += new System.EventHandler(this.PbSelectID1_Click);
            // 
            // lblRange2
            // 
            this.lblRange2.AutoSize = true;
            this.lblRange2.Location = new System.Drawing.Point(126, 48);
            this.lblRange2.Name = "lblRange2";
            this.lblRange2.Size = new System.Drawing.Size(45, 13);
            this.lblRange2.TabIndex = 109;
            this.lblRange2.Text = "Range2";
            // 
            // tbRange2
            // 
            this.tbRange2.Location = new System.Drawing.Point(111, 64);
            this.tbRange2.Name = "tbRange2";
            this.tbRange2.Size = new System.Drawing.Size(72, 20);
            this.tbRange2.TabIndex = 108;
            this.toolTip1.SetToolTip(this.tbRange2, "End Index");
            this.tbRange2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbRange2_KeyPress);
            // 
            // tbRange1
            // 
            this.tbRange1.Location = new System.Drawing.Point(108, 25);
            this.tbRange1.Name = "tbRange1";
            this.tbRange1.Size = new System.Drawing.Size(72, 20);
            this.tbRange1.TabIndex = 107;
            this.toolTip1.SetToolTip(this.tbRange1, "Start Index");
            this.tbRange1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbRange1_KeyPress);
            // 
            // lblRange1
            // 
            this.lblRange1.AutoSize = true;
            this.lblRange1.Location = new System.Drawing.Point(126, 9);
            this.lblRange1.Name = "lblRange1";
            this.lblRange1.Size = new System.Drawing.Size(45, 13);
            this.lblRange1.TabIndex = 106;
            this.lblRange1.Text = "Range1";
            // 
            // TbNum1
            // 
            this.TbNum1.Location = new System.Drawing.Point(38, 45);
            this.TbNum1.Name = "TbNum1";
            this.TbNum1.Size = new System.Drawing.Size(46, 20);
            this.TbNum1.TabIndex = 112;
            this.TbNum1.Text = "0";
            this.toolTip1.SetToolTip(this.TbNum1, "Magical Defence/Magical Attack");
            this.TbNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNum1_KeyPress);
            // 
            // TbNum2
            // 
            this.TbNum2.Location = new System.Drawing.Point(38, 68);
            this.TbNum2.Name = "TbNum2";
            this.TbNum2.Size = new System.Drawing.Size(46, 20);
            this.TbNum2.TabIndex = 113;
            this.TbNum2.Text = "0";
            this.toolTip1.SetToolTip(this.TbNum2, "Flight Speed/Attack Speed");
            this.TbNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNum2_KeyPress);
            // 
            // TbNum0
            // 
            this.TbNum0.Location = new System.Drawing.Point(38, 19);
            this.TbNum0.Name = "TbNum0";
            this.TbNum0.Size = new System.Drawing.Size(46, 20);
            this.TbNum0.TabIndex = 114;
            this.TbNum0.Text = "0";
            this.toolTip1.SetToolTip(this.TbNum0, "Physical Defence/Physical Attack");
            this.TbNum0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNum0_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 115;
            this.label1.Text = "Num0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 116;
            this.label2.Text = "Num1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 117;
            this.label3.Text = "Num3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 106;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 118;
            this.label5.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 119;
            this.label6.Text = "%";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 120;
            this.button1.Text = "Add Percent";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(11, 124);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(197, 23);
            this.btnSubtract.TabIndex = 121;
            this.btnSubtract.Text = "Subtract Percent";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // MassPercentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 151);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbNum0);
            this.Controls.Add(this.TbNum2);
            this.Controls.Add(this.TbNum1);
            this.Controls.Add(this.PbSelectID2);
            this.Controls.Add(this.PbSelectID1);
            this.Controls.Add(this.lblRange2);
            this.Controls.Add(this.tbRange2);
            this.Controls.Add(this.tbRange1);
            this.Controls.Add(this.lblRange1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MassPercentAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MassPercentAdd";
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbSelectID2;
        private System.Windows.Forms.PictureBox PbSelectID1;
        private System.Windows.Forms.Label lblRange2;
        private System.Windows.Forms.TextBox tbRange2;
        private System.Windows.Forms.TextBox tbRange1;
        private System.Windows.Forms.Label lblRange1;
        private System.Windows.Forms.TextBox TbNum1;
        private System.Windows.Forms.TextBox TbNum2;
        private System.Windows.Forms.TextBox TbNum0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSubtract;
    }
}