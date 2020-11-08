namespace LcDevPack_TeamDamonA.Tools
{
    partial class MassPrice
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
            this.LblPrice = new System.Windows.Forms.Label();
            this.TbPrice = new System.Windows.Forms.TextBox();
            this.PbSelectID2 = new System.Windows.Forms.PictureBox();
            this.PbSelectID1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRange2 = new System.Windows.Forms.TextBox();
            this.tbRange1 = new System.Windows.Forms.TextBox();
            this.btnUpdateSelectedRange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Location = new System.Drawing.Point(15, 66);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(54, 13);
            this.LblPrice.TabIndex = 128;
            this.LblPrice.Text = "Item Price";
            // 
            // TbPrice
            // 
            this.TbPrice.Location = new System.Drawing.Point(88, 63);
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.Size = new System.Drawing.Size(211, 20);
            this.TbPrice.TabIndex = 127;
            this.TbPrice.Text = "Item Price";
            // 
            // PbSelectID2
            // 
            this.PbSelectID2.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.PbSelectID2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbSelectID2.Location = new System.Drawing.Point(279, 26);
            this.PbSelectID2.Name = "PbSelectID2";
            this.PbSelectID2.Size = new System.Drawing.Size(22, 22);
            this.PbSelectID2.TabIndex = 126;
            this.PbSelectID2.TabStop = false;
            this.PbSelectID2.Click += new System.EventHandler(this.PbSelectID2_Click);
            // 
            // PbSelectID1
            // 
            this.PbSelectID1.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.PbSelectID1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbSelectID1.Location = new System.Drawing.Point(116, 24);
            this.PbSelectID1.Name = "PbSelectID1";
            this.PbSelectID1.Size = new System.Drawing.Size(22, 22);
            this.PbSelectID1.TabIndex = 125;
            this.PbSelectID1.TabStop = false;
            this.PbSelectID1.Click += new System.EventHandler(this.PbSelectID1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 124;
            this.label2.Text = "ItemRange2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 123;
            this.label1.Text = "ItemRange1";
            // 
            // tbRange2
            // 
            this.tbRange2.Location = new System.Drawing.Point(173, 26);
            this.tbRange2.Name = "tbRange2";
            this.tbRange2.Size = new System.Drawing.Size(100, 20);
            this.tbRange2.TabIndex = 122;
            this.tbRange2.Text = "End Index";
            // 
            // tbRange1
            // 
            this.tbRange1.Location = new System.Drawing.Point(12, 25);
            this.tbRange1.Name = "tbRange1";
            this.tbRange1.Size = new System.Drawing.Size(100, 20);
            this.tbRange1.TabIndex = 121;
            this.tbRange1.Text = "Start Index";
            // 
            // btnUpdateSelectedRange
            // 
            this.btnUpdateSelectedRange.Location = new System.Drawing.Point(8, 98);
            this.btnUpdateSelectedRange.Name = "btnUpdateSelectedRange";
            this.btnUpdateSelectedRange.Size = new System.Drawing.Size(292, 23);
            this.btnUpdateSelectedRange.TabIndex = 120;
            this.btnUpdateSelectedRange.Text = "Update For Selected Items";
            this.btnUpdateSelectedRange.UseVisualStyleBackColor = true;
            this.btnUpdateSelectedRange.Click += new System.EventHandler(this.BtnUpdateSelectedRange_Click);
            // 
            // MassPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 130);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.TbPrice);
            this.Controls.Add(this.PbSelectID2);
            this.Controls.Add(this.PbSelectID1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRange2);
            this.Controls.Add(this.tbRange1);
            this.Controls.Add(this.btnUpdateSelectedRange);
            this.Name = "MassPrice";
            this.Text = "MassPrice";
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.TextBox TbPrice;
        private System.Windows.Forms.PictureBox PbSelectID2;
        private System.Windows.Forms.PictureBox PbSelectID1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRange2;
        private System.Windows.Forms.TextBox tbRange1;
        private System.Windows.Forms.Button btnUpdateSelectedRange;
    }
}