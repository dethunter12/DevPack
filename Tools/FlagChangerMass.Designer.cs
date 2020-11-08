namespace LcDevPack_TeamDamonA.Tools
{
    partial class FlagChangerMass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlagChangerMass));
            this.ClbItemFlag = new System.Windows.Forms.CheckedListBox();
            this.btnUpdateSelectedRange = new System.Windows.Forms.Button();
            this.tbRange1 = new System.Windows.Forms.TextBox();
            this.tbRange2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PbSelectID1 = new System.Windows.Forms.PictureBox();
            this.PbSelectID2 = new System.Windows.Forms.PictureBox();
            this.tbItemFlag = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID2)).BeginInit();
            this.SuspendLayout();
            // 
            // ClbItemFlag
            // 
            this.ClbItemFlag.BackColor = System.Drawing.SystemColors.Control;
            this.ClbItemFlag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClbItemFlag.CheckOnClick = true;
            this.ClbItemFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClbItemFlag.FormattingEnabled = true;
            this.ClbItemFlag.IntegralHeight = false;
            this.ClbItemFlag.Location = new System.Drawing.Point(4, 4);
            this.ClbItemFlag.MultiColumn = true;
            this.ClbItemFlag.Name = "ClbItemFlag";
            this.ClbItemFlag.Size = new System.Drawing.Size(300, 539);
            this.ClbItemFlag.TabIndex = 1;
            this.ClbItemFlag.SelectedIndexChanged += new System.EventHandler(this.ClbItemFlag_SelectedIndexChanged_1);
            // 
            // btnUpdateSelectedRange
            // 
            this.btnUpdateSelectedRange.Location = new System.Drawing.Point(12, 612);
            this.btnUpdateSelectedRange.Name = "btnUpdateSelectedRange";
            this.btnUpdateSelectedRange.Size = new System.Drawing.Size(292, 23);
            this.btnUpdateSelectedRange.TabIndex = 2;
            this.btnUpdateSelectedRange.Text = "Update For Selected Items";
            this.btnUpdateSelectedRange.UseVisualStyleBackColor = true;
            this.btnUpdateSelectedRange.Click += new System.EventHandler(this.btnUpdateSelectedRange_Click);
            // 
            // tbRange1
            // 
            this.tbRange1.Location = new System.Drawing.Point(14, 562);
            this.tbRange1.Name = "tbRange1";
            this.tbRange1.Size = new System.Drawing.Size(100, 20);
            this.tbRange1.TabIndex = 3;
            // 
            // tbRange2
            // 
            this.tbRange2.Location = new System.Drawing.Point(175, 563);
            this.tbRange2.Name = "tbRange2";
            this.tbRange2.Size = new System.Drawing.Size(100, 20);
            this.tbRange2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ItemRange1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 545);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ItemRange2";
            // 
            // PbSelectID1
            // 
            this.PbSelectID1.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.PbSelectID1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbSelectID1.Location = new System.Drawing.Point(118, 561);
            this.PbSelectID1.Name = "PbSelectID1";
            this.PbSelectID1.Size = new System.Drawing.Size(22, 22);
            this.PbSelectID1.TabIndex = 105;
            this.PbSelectID1.TabStop = false;
            this.PbSelectID1.Click += new System.EventHandler(this.PbSelectID1_Click);
            // 
            // PbSelectID2
            // 
            this.PbSelectID2.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.PbSelectID2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbSelectID2.Location = new System.Drawing.Point(279, 561);
            this.PbSelectID2.Name = "PbSelectID2";
            this.PbSelectID2.Size = new System.Drawing.Size(22, 22);
            this.PbSelectID2.TabIndex = 106;
            this.PbSelectID2.TabStop = false;
            this.PbSelectID2.Click += new System.EventHandler(this.PbSelectID2_Click);
            // 
            // tbItemFlag
            // 
            this.tbItemFlag.Location = new System.Drawing.Point(93, 589);
            this.tbItemFlag.Name = "tbItemFlag";
            this.tbItemFlag.Size = new System.Drawing.Size(211, 20);
            this.tbItemFlag.TabIndex = 107;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 592);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 108;
            this.label3.Text = "Item Flag Value";
            // 
            // FlagChangerMass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 641);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbItemFlag);
            this.Controls.Add(this.PbSelectID2);
            this.Controls.Add(this.PbSelectID1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRange2);
            this.Controls.Add(this.tbRange1);
            this.Controls.Add(this.btnUpdateSelectedRange);
            this.Controls.Add(this.ClbItemFlag);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FlagChangerMass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FlagChangerMass";
            this.Load += new System.EventHandler(this.FlagChangerMass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckedListBox ClbItemFlag;
        private System.Windows.Forms.TextBox tbRange1;
        private System.Windows.Forms.TextBox tbRange2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PbSelectID1;
        private System.Windows.Forms.PictureBox PbSelectID2;
        private System.Windows.Forms.Button btnUpdateSelectedRange;
        private System.Windows.Forms.TextBox tbItemFlag;
        private System.Windows.Forms.Label label3;
    }
}