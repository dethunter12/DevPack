namespace LcDevPack_TeamDamonA.Tools
{
    partial class Animation_Picker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Animation_Picker));
            this.LbAnimationList = new System.Windows.Forms.ListBox();
            this.BtnPickAni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbAnimationList
            // 
            this.LbAnimationList.FormattingEnabled = true;
            this.LbAnimationList.Location = new System.Drawing.Point(12, 12);
            this.LbAnimationList.Name = "LbAnimationList";
            this.LbAnimationList.Size = new System.Drawing.Size(206, 303);
            this.LbAnimationList.TabIndex = 0;
            this.LbAnimationList.SelectedIndexChanged += new System.EventHandler(this.LbAnimationList_SelectedIndexChanged);
            // 
            // BtnPickAni
            // 
            this.BtnPickAni.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnPickAni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPickAni.Location = new System.Drawing.Point(13, 321);
            this.BtnPickAni.Name = "BtnPickAni";
            this.BtnPickAni.Size = new System.Drawing.Size(206, 23);
            this.BtnPickAni.TabIndex = 1;
            this.BtnPickAni.Text = "Pick Animation";
            this.BtnPickAni.UseVisualStyleBackColor = true;
            // 
            // Animation_Picker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 345);
            this.Controls.Add(this.BtnPickAni);
            this.Controls.Add(this.LbAnimationList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Animation_Picker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Animation_Picker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LbAnimationList;
        private System.Windows.Forms.Button BtnPickAni;
    }
}