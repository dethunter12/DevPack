namespace LcDevPack_TeamDamonA.Tools
{
    partial class MassNameChanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MassNameChanger));
            this.label3 = new System.Windows.Forms.Label();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.PbSelectID2 = new System.Windows.Forms.PictureBox();
            this.PbSelectID1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRange2 = new System.Windows.Forms.TextBox();
            this.tbRange1 = new System.Windows.Forms.TextBox();
            this.btnUpdateSelectedRange = new System.Windows.Forms.Button();
            this.cbRemoveBefore = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAddBefore = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 117;
            this.label3.Text = "Item Name";
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(96, 5);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(211, 20);
            this.tbItemName.TabIndex = 116;
            this.tbItemName.Text = "Item Name";
            // 
            // PbSelectID2
            // 
            this.PbSelectID2.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.PbSelectID2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbSelectID2.Location = new System.Drawing.Point(286, 45);
            this.PbSelectID2.Name = "PbSelectID2";
            this.PbSelectID2.Size = new System.Drawing.Size(22, 22);
            this.PbSelectID2.TabIndex = 115;
            this.PbSelectID2.TabStop = false;
            this.PbSelectID2.Click += new System.EventHandler(this.PbSelectID2_Click);
            // 
            // PbSelectID1
            // 
            this.PbSelectID1.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.PbSelectID1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbSelectID1.Location = new System.Drawing.Point(125, 45);
            this.PbSelectID1.Name = "PbSelectID1";
            this.PbSelectID1.Size = new System.Drawing.Size(22, 22);
            this.PbSelectID1.TabIndex = 114;
            this.PbSelectID1.TabStop = false;
            this.PbSelectID1.Click += new System.EventHandler(this.PbSelectID1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 113;
            this.label2.Text = "ItemRange2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 112;
            this.label1.Text = "ItemRange1";
            // 
            // tbRange2
            // 
            this.tbRange2.Location = new System.Drawing.Point(182, 47);
            this.tbRange2.Name = "tbRange2";
            this.tbRange2.Size = new System.Drawing.Size(100, 20);
            this.tbRange2.TabIndex = 111;
            this.tbRange2.Text = "End Index";
            // 
            // tbRange1
            // 
            this.tbRange1.Location = new System.Drawing.Point(21, 46);
            this.tbRange1.Name = "tbRange1";
            this.tbRange1.Size = new System.Drawing.Size(100, 20);
            this.tbRange1.TabIndex = 110;
            this.tbRange1.Text = "Start Index";
            // 
            // btnUpdateSelectedRange
            // 
            this.btnUpdateSelectedRange.Location = new System.Drawing.Point(15, 134);
            this.btnUpdateSelectedRange.Name = "btnUpdateSelectedRange";
            this.btnUpdateSelectedRange.Size = new System.Drawing.Size(292, 23);
            this.btnUpdateSelectedRange.TabIndex = 109;
            this.btnUpdateSelectedRange.Text = "Update For Selected Items";
            this.btnUpdateSelectedRange.UseVisualStyleBackColor = true;
            this.btnUpdateSelectedRange.Click += new System.EventHandler(this.BtnUpdateSelectedRange_Click);
            // 
            // cbRemoveBefore
            // 
            this.cbRemoveBefore.AutoSize = true;
            this.cbRemoveBefore.Location = new System.Drawing.Point(12, 16);
            this.cbRemoveBefore.Name = "cbRemoveBefore";
            this.cbRemoveBefore.Size = new System.Drawing.Size(96, 17);
            this.cbRemoveBefore.TabIndex = 118;
            this.cbRemoveBefore.Text = "Remove String";
            this.cbRemoveBefore.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAddBefore);
            this.groupBox1.Controls.Add(this.cbRemoveBefore);
            this.groupBox1.Location = new System.Drawing.Point(19, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 58);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NameModify";
            // 
            // cbAddBefore
            // 
            this.cbAddBefore.AutoSize = true;
            this.cbAddBefore.Location = new System.Drawing.Point(151, 15);
            this.cbAddBefore.Name = "cbAddBefore";
            this.cbAddBefore.Size = new System.Drawing.Size(75, 17);
            this.cbAddBefore.TabIndex = 119;
            this.cbAddBefore.Text = "Add String";
            this.cbAddBefore.UseVisualStyleBackColor = true;
            // 
            // MassNameChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 159);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.PbSelectID2);
            this.Controls.Add(this.PbSelectID1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRange2);
            this.Controls.Add(this.tbRange1);
            this.Controls.Add(this.btnUpdateSelectedRange);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MassNameChanger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MassNameChanger";
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.PictureBox PbSelectID2;
        private System.Windows.Forms.PictureBox PbSelectID1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRange2;
        private System.Windows.Forms.TextBox tbRange1;
        private System.Windows.Forms.Button btnUpdateSelectedRange;
        private System.Windows.Forms.CheckBox cbRemoveBefore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbAddBefore;
    }
}