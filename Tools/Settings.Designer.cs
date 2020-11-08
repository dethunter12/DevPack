namespace LcDevPack_TeamDamonA.Tools
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.btnSave = new System.Windows.Forms.Button();
            this.TbClientPath = new System.Windows.Forms.TextBox();
            this.TbSqlHost = new System.Windows.Forms.TextBox();
            this.TbSqlUser = new System.Windows.Forms.TextBox();
            this.TbSqlPassword = new System.Windows.Forms.TextBox();
            this.TbSqlDatabase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CbLangSelect = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CBPass = new System.Windows.Forms.CheckBox();
            this.CBUser = new System.Windows.Forms.CheckBox();
            this.CBHost = new System.Windows.Forms.CheckBox();
            this.CBClientPath = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CbDb = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbSqlDb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(137, 335);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(210, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "SAVE SETTINGS";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TbClientPath
            // 
            this.TbClientPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbClientPath.Location = new System.Drawing.Point(137, 15);
            this.TbClientPath.Name = "TbClientPath";
            this.TbClientPath.Size = new System.Drawing.Size(271, 20);
            this.TbClientPath.TabIndex = 1;
            this.TbClientPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TbSqlHost
            // 
            this.TbSqlHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbSqlHost.Location = new System.Drawing.Point(137, 60);
            this.TbSqlHost.Name = "TbSqlHost";
            this.TbSqlHost.Size = new System.Drawing.Size(271, 20);
            this.TbSqlHost.TabIndex = 2;
            this.TbSqlHost.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TbSqlUser
            // 
            this.TbSqlUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbSqlUser.Location = new System.Drawing.Point(137, 106);
            this.TbSqlUser.Name = "TbSqlUser";
            this.TbSqlUser.Size = new System.Drawing.Size(271, 20);
            this.TbSqlUser.TabIndex = 3;
            this.TbSqlUser.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TbSqlPassword
            // 
            this.TbSqlPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbSqlPassword.Location = new System.Drawing.Point(137, 159);
            this.TbSqlPassword.Name = "TbSqlPassword";
            this.TbSqlPassword.Size = new System.Drawing.Size(271, 20);
            this.TbSqlPassword.TabIndex = 4;
            this.TbSqlPassword.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // TbSqlDatabase
            // 
            this.TbSqlDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbSqlDatabase.Location = new System.Drawing.Point(137, 211);
            this.TbSqlDatabase.Name = "TbSqlDatabase";
            this.TbSqlDatabase.Size = new System.Drawing.Size(271, 20);
            this.TbSqlDatabase.TabIndex = 5;
            this.TbSqlDatabase.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "CLIENT PATH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "SQL_HOST:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "SQL_USER:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "SQL_PASSWORD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "SQL_DATABASE_DATA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "LANGUAGE:";
            // 
            // CbLangSelect
            // 
            this.CbLangSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbLangSelect.FormattingEnabled = true;
            this.CbLangSelect.Location = new System.Drawing.Point(137, 308);
            this.CbLangSelect.Name = "CbLangSelect";
            this.CbLangSelect.Size = new System.Drawing.Size(271, 21);
            this.CbLangSelect.TabIndex = 13;
            this.CbLangSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(414, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CBPass
            // 
            this.CBPass.AutoSize = true;
            this.CBPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPass.Location = new System.Drawing.Point(137, 185);
            this.CBPass.Name = "CBPass";
            this.CBPass.Size = new System.Drawing.Size(147, 20);
            this.CBPass.TabIndex = 15;
            this.CBPass.Text = "Password is Hidden";
            this.CBPass.UseVisualStyleBackColor = true;
            this.CBPass.CheckedChanged += new System.EventHandler(this.CBPass_CheckedChanged);
            // 
            // CBUser
            // 
            this.CBUser.AutoSize = true;
            this.CBUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBUser.Location = new System.Drawing.Point(137, 132);
            this.CBUser.Name = "CBUser";
            this.CBUser.Size = new System.Drawing.Size(116, 20);
            this.CBUser.TabIndex = 16;
            this.CBUser.Text = "User is Hidden";
            this.CBUser.UseVisualStyleBackColor = true;
            this.CBUser.CheckedChanged += new System.EventHandler(this.CBUser_CheckedChanged);
            // 
            // CBHost
            // 
            this.CBHost.AutoSize = true;
            this.CBHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBHost.Location = new System.Drawing.Point(137, 80);
            this.CBHost.Name = "CBHost";
            this.CBHost.Size = new System.Drawing.Size(115, 20);
            this.CBHost.TabIndex = 17;
            this.CBHost.Text = "Host is Hidden";
            this.CBHost.UseVisualStyleBackColor = true;
            this.CBHost.CheckedChanged += new System.EventHandler(this.CBHost_CheckedChanged);
            // 
            // CBClientPath
            // 
            this.CBClientPath.AutoSize = true;
            this.CBClientPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBClientPath.Location = new System.Drawing.Point(139, 37);
            this.CBClientPath.Name = "CBClientPath";
            this.CBClientPath.Size = new System.Drawing.Size(147, 20);
            this.CBClientPath.TabIndex = 18;
            this.CBClientPath.Text = "ClientPath is Hidden";
            this.CBClientPath.UseVisualStyleBackColor = true;
            this.CBClientPath.CheckedChanged += new System.EventHandler(this.CBClientPath_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(137, 231);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 20);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Database is Hidden";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CbDb
            // 
            this.CbDb.AutoSize = true;
            this.CbDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbDb.Location = new System.Drawing.Point(137, 287);
            this.CbDb.Name = "CbDb";
            this.CbDb.Size = new System.Drawing.Size(147, 20);
            this.CbDb.TabIndex = 22;
            this.CbDb.Text = "Database is Hidden";
            this.CbDb.UseVisualStyleBackColor = true;
            this.CbDb.CheckedChanged += new System.EventHandler(this.CbDb_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "SQL_DB_DATABASE:";
            // 
            // TbSqlDb
            // 
            this.TbSqlDb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbSqlDb.Location = new System.Drawing.Point(137, 267);
            this.TbSqlDb.Name = "TbSqlDb";
            this.TbSqlDb.Size = new System.Drawing.Size(271, 20);
            this.TbSqlDb.TabIndex = 20;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 382);
            this.Controls.Add(this.CbDb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TbSqlDb);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.CBClientPath);
            this.Controls.Add(this.CBHost);
            this.Controls.Add(this.CBUser);
            this.Controls.Add(this.CBPass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CbLangSelect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbSqlDatabase);
            this.Controls.Add(this.TbSqlPassword);
            this.Controls.Add(this.TbSqlUser);
            this.Controls.Add(this.TbSqlHost);
            this.Controls.Add(this.TbClientPath);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox TbClientPath;
        private System.Windows.Forms.TextBox TbSqlHost;
        private System.Windows.Forms.TextBox TbSqlUser;
        private System.Windows.Forms.TextBox TbSqlPassword;
        private System.Windows.Forms.TextBox TbSqlDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbLangSelect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox CBPass;
        private System.Windows.Forms.CheckBox CBUser;
        private System.Windows.Forms.CheckBox CBHost;
        private System.Windows.Forms.CheckBox CBClientPath;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox CbDb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbSqlDb;
    }
}