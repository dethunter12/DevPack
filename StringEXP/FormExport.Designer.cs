namespace StringExporter
{
    partial class FormExport
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this._chk_all = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._chk_itemcollection = new System.Windows.Forms.CheckBox();
            this._chk_lacarette = new System.Windows.Forms.CheckBox();
            this._chk_opt_rare = new System.Windows.Forms.CheckBox();
            this._chk_option = new System.Windows.Forms.CheckBox();
            this._chk_affinity = new System.Windows.Forms.CheckBox();
            this._chk_combo = new System.Windows.Forms.CheckBox();
            this._chk_help1 = new System.Windows.Forms.CheckBox();
            this._chk_sskill = new System.Windows.Forms.CheckBox();
            this._chk_action = new System.Windows.Forms.CheckBox();
            this._chk_skill = new System.Windows.Forms.CheckBox();
            this._chk_quest = new System.Windows.Forms.CheckBox();
            this._chk_npcname = new System.Windows.Forms.CheckBox();
            this._chk_setitem = new System.Windows.Forms.CheckBox();
            this._chk_item = new System.Windows.Forms.CheckBox();
            this._chk_string = new System.Windows.Forms.CheckBox();
            this._group_nation = new System.Windows.Forms.GroupBox();
            this._chk_nation_usa = new System.Windows.Forms.CheckBox();
            this._chk_nation_uk = new System.Windows.Forms.CheckBox();
            this._chk_nation_rus = new System.Windows.Forms.CheckBox();
            this._chk_nation_tha = new System.Windows.Forms.CheckBox();
            this._radio_pre = new System.Windows.Forms.RadioButton();
            this._chk_nation_bra = new System.Windows.Forms.CheckBox();
            this._radio_ship = new System.Windows.Forms.RadioButton();
            this._chk_nation_mex = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this._chk_nation_dev = new System.Windows.Forms.CheckBox();
            this._chk_nation_pol = new System.Windows.Forms.CheckBox();
            this._chk_nation_esp = new System.Windows.Forms.CheckBox();
            this._chk_nation_gamigo_all = new System.Windows.Forms.CheckBox();
            this._chk_nation_fra = new System.Windows.Forms.CheckBox();
            this._chk_nation_ita = new System.Windows.Forms.CheckBox();
            this._chk_nation_ger = new System.Windows.Forms.CheckBox();
            this._btn_select_all = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._lb_output = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this._group_nation.SuspendLayout();
            this.SuspendLayout();
            // 
            // _chk_all
            // 
            this._chk_all.AutoSize = true;
            this._chk_all.Location = new System.Drawing.Point(16, 25);
            this._chk_all.Name = "_chk_all";
            this._chk_all.Size = new System.Drawing.Size(45, 17);
            this._chk_all.TabIndex = 0;
            this._chk_all.Text = "ALL";
            this._chk_all.UseVisualStyleBackColor = true;
            this._chk_all.CheckedChanged += new System.EventHandler(this._chk_all_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._chk_itemcollection);
            this.groupBox1.Controls.Add(this._chk_lacarette);
            this.groupBox1.Controls.Add(this._chk_opt_rare);
            this.groupBox1.Controls.Add(this._chk_option);
            this.groupBox1.Controls.Add(this._chk_affinity);
            this.groupBox1.Controls.Add(this._chk_combo);
            this.groupBox1.Controls.Add(this._chk_help1);
            this.groupBox1.Controls.Add(this._chk_sskill);
            this.groupBox1.Controls.Add(this._chk_action);
            this.groupBox1.Controls.Add(this._chk_skill);
            this.groupBox1.Controls.Add(this._chk_quest);
            this.groupBox1.Controls.Add(this._chk_npcname);
            this.groupBox1.Controls.Add(this._chk_setitem);
            this.groupBox1.Controls.Add(this._chk_item);
            this.groupBox1.Controls.Add(this._chk_string);
            this.groupBox1.Controls.Add(this._chk_all);
            this.groupBox1.Location = new System.Drawing.Point(10, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "String Type";
            // 
            // _chk_itemcollection
            // 
            this._chk_itemcollection.AutoSize = true;
            this._chk_itemcollection.Location = new System.Drawing.Point(93, 152);
            this._chk_itemcollection.Name = "_chk_itemcollection";
            this._chk_itemcollection.Size = new System.Drawing.Size(95, 17);
            this._chk_itemcollection.TabIndex = 20;
            this._chk_itemcollection.Text = "Item Collection";
            this._chk_itemcollection.UseVisualStyleBackColor = true;
            // 
            // _chk_lacarette
            // 
            this._chk_lacarette.AutoSize = true;
            this._chk_lacarette.Location = new System.Drawing.Point(16, 151);
            this._chk_lacarette.Name = "_chk_lacarette";
            this._chk_lacarette.Size = new System.Drawing.Size(71, 17);
            this._chk_lacarette.TabIndex = 19;
            this._chk_lacarette.Text = "Lacarette";
            this._chk_lacarette.UseVisualStyleBackColor = true;
            // 
            // _chk_opt_rare
            // 
            this._chk_opt_rare.AutoSize = true;
            this._chk_opt_rare.Location = new System.Drawing.Point(93, 61);
            this._chk_opt_rare.Name = "_chk_opt_rare";
            this._chk_opt_rare.Size = new System.Drawing.Size(83, 17);
            this._chk_opt_rare.TabIndex = 17;
            this._chk_opt_rare.Text = "Rare Option";
            this._chk_opt_rare.UseVisualStyleBackColor = true;
            // 
            // _chk_option
            // 
            this._chk_option.AutoSize = true;
            this._chk_option.Location = new System.Drawing.Point(16, 79);
            this._chk_option.Name = "_chk_option";
            this._chk_option.Size = new System.Drawing.Size(57, 17);
            this._chk_option.TabIndex = 16;
            this._chk_option.Text = "Option";
            this._chk_option.UseVisualStyleBackColor = true;
            // 
            // _chk_affinity
            // 
            this._chk_affinity.AutoSize = true;
            this._chk_affinity.Location = new System.Drawing.Point(93, 134);
            this._chk_affinity.Name = "_chk_affinity";
            this._chk_affinity.Size = new System.Drawing.Size(57, 17);
            this._chk_affinity.TabIndex = 13;
            this._chk_affinity.Text = "Affinity";
            this._chk_affinity.UseVisualStyleBackColor = true;
            // 
            // _chk_combo
            // 
            this._chk_combo.AutoSize = true;
            this._chk_combo.Location = new System.Drawing.Point(16, 133);
            this._chk_combo.Name = "_chk_combo";
            this._chk_combo.Size = new System.Drawing.Size(59, 17);
            this._chk_combo.TabIndex = 12;
            this._chk_combo.Text = "Combo";
            this._chk_combo.UseVisualStyleBackColor = true;
            // 
            // _chk_help1
            // 
            this._chk_help1.AutoSize = true;
            this._chk_help1.Location = new System.Drawing.Point(93, 25);
            this._chk_help1.Name = "_chk_help1";
            this._chk_help1.Size = new System.Drawing.Size(54, 17);
            this._chk_help1.TabIndex = 11;
            this._chk_help1.Text = "Help1";
            this._chk_help1.UseVisualStyleBackColor = true;
            // 
            // _chk_sskill
            // 
            this._chk_sskill.AutoSize = true;
            this._chk_sskill.Location = new System.Drawing.Point(93, 97);
            this._chk_sskill.Name = "_chk_sskill";
            this._chk_sskill.Size = new System.Drawing.Size(55, 17);
            this._chk_sskill.TabIndex = 10;
            this._chk_sskill.Text = "S Skill";
            this._chk_sskill.UseVisualStyleBackColor = true;
            // 
            // _chk_action
            // 
            this._chk_action.AutoSize = true;
            this._chk_action.Location = new System.Drawing.Point(93, 115);
            this._chk_action.Name = "_chk_action";
            this._chk_action.Size = new System.Drawing.Size(56, 17);
            this._chk_action.TabIndex = 9;
            this._chk_action.Text = "Action";
            this._chk_action.UseVisualStyleBackColor = true;
            // 
            // _chk_skill
            // 
            this._chk_skill.AutoSize = true;
            this._chk_skill.Location = new System.Drawing.Point(16, 115);
            this._chk_skill.Name = "_chk_skill";
            this._chk_skill.Size = new System.Drawing.Size(45, 17);
            this._chk_skill.TabIndex = 8;
            this._chk_skill.Text = "Skill";
            this._chk_skill.UseVisualStyleBackColor = true;
            // 
            // _chk_quest
            // 
            this._chk_quest.AutoSize = true;
            this._chk_quest.Location = new System.Drawing.Point(93, 79);
            this._chk_quest.Name = "_chk_quest";
            this._chk_quest.Size = new System.Drawing.Size(54, 17);
            this._chk_quest.TabIndex = 7;
            this._chk_quest.Text = "Quest";
            this._chk_quest.UseVisualStyleBackColor = true;
            // 
            // _chk_npcname
            // 
            this._chk_npcname.AutoSize = true;
            this._chk_npcname.Location = new System.Drawing.Point(16, 97);
            this._chk_npcname.Name = "_chk_npcname";
            this._chk_npcname.Size = new System.Drawing.Size(79, 17);
            this._chk_npcname.TabIndex = 5;
            this._chk_npcname.Text = "NPC Name";
            this._chk_npcname.UseVisualStyleBackColor = true;
            // 
            // _chk_setitem
            // 
            this._chk_setitem.AutoSize = true;
            this._chk_setitem.Location = new System.Drawing.Point(93, 43);
            this._chk_setitem.Name = "_chk_setitem";
            this._chk_setitem.Size = new System.Drawing.Size(62, 17);
            this._chk_setitem.TabIndex = 3;
            this._chk_setitem.Text = "SetItem";
            this._chk_setitem.UseVisualStyleBackColor = true;
            // 
            // _chk_item
            // 
            this._chk_item.AutoSize = true;
            this._chk_item.Location = new System.Drawing.Point(16, 61);
            this._chk_item.Name = "_chk_item";
            this._chk_item.Size = new System.Drawing.Size(46, 17);
            this._chk_item.TabIndex = 2;
            this._chk_item.Text = "Item";
            this._chk_item.UseVisualStyleBackColor = true;
            // 
            // _chk_string
            // 
            this._chk_string.AutoSize = true;
            this._chk_string.Location = new System.Drawing.Point(16, 43);
            this._chk_string.Name = "_chk_string";
            this._chk_string.Size = new System.Drawing.Size(53, 17);
            this._chk_string.TabIndex = 1;
            this._chk_string.Text = "String";
            this._chk_string.UseVisualStyleBackColor = true;
            // 
            // _group_nation
            // 
            this._group_nation.Controls.Add(this._chk_nation_usa);
            this._group_nation.Controls.Add(this._chk_nation_uk);
            this._group_nation.Controls.Add(this._chk_nation_rus);
            this._group_nation.Controls.Add(this._chk_nation_tha);
            this._group_nation.Controls.Add(this._radio_pre);
            this._group_nation.Controls.Add(this._chk_nation_bra);
            this._group_nation.Controls.Add(this._radio_ship);
            this._group_nation.Controls.Add(this._chk_nation_mex);
            this._group_nation.Controls.Add(this.button2);
            this._group_nation.Controls.Add(this._chk_nation_dev);
            this._group_nation.Controls.Add(this._chk_nation_pol);
            this._group_nation.Controls.Add(this._chk_nation_esp);
            this._group_nation.Controls.Add(this._chk_nation_gamigo_all);
            this._group_nation.Controls.Add(this._chk_nation_fra);
            this._group_nation.Controls.Add(this._chk_nation_ita);
            this._group_nation.Controls.Add(this._chk_nation_ger);
            this._group_nation.Location = new System.Drawing.Point(205, 16);
            this._group_nation.Name = "_group_nation";
            this._group_nation.Size = new System.Drawing.Size(201, 171);
            this._group_nation.TabIndex = 2;
            this._group_nation.TabStop = false;
            this._group_nation.Text = "Nation";
            // 
            // _chk_nation_usa
            // 
            this._chk_nation_usa.AutoSize = true;
            this._chk_nation_usa.Location = new System.Drawing.Point(18, 94);
            this._chk_nation_usa.Name = "_chk_nation_usa";
            this._chk_nation_usa.Size = new System.Drawing.Size(41, 17);
            this._chk_nation_usa.TabIndex = 6;
            this._chk_nation_usa.Text = "US";
            this._chk_nation_usa.UseVisualStyleBackColor = true;
            // 
            // _chk_nation_uk
            // 
            this._chk_nation_uk.AutoSize = true;
            this._chk_nation_uk.Location = new System.Drawing.Point(118, 76);
            this._chk_nation_uk.Name = "_chk_nation_uk";
            this._chk_nation_uk.Size = new System.Drawing.Size(41, 17);
            this._chk_nation_uk.TabIndex = 7;
            this._chk_nation_uk.Text = "UK";
            this._chk_nation_uk.UseVisualStyleBackColor = true;
            // 
            // _chk_nation_rus
            // 
            this._chk_nation_rus.AutoSize = true;
            this._chk_nation_rus.Location = new System.Drawing.Point(67, 76);
            this._chk_nation_rus.Name = "_chk_nation_rus";
            this._chk_nation_rus.Size = new System.Drawing.Size(49, 17);
            this._chk_nation_rus.TabIndex = 5;
            this._chk_nation_rus.Text = "RUS";
            this._chk_nation_rus.UseVisualStyleBackColor = true;
            // 
            // _chk_nation_tha
            // 
            this._chk_nation_tha.AutoSize = true;
            this._chk_nation_tha.Location = new System.Drawing.Point(118, 58);
            this._chk_nation_tha.Name = "_chk_nation_tha";
            this._chk_nation_tha.Size = new System.Drawing.Size(48, 17);
            this._chk_nation_tha.TabIndex = 7;
            this._chk_nation_tha.Text = "THA";
            this._chk_nation_tha.UseVisualStyleBackColor = true;
            // 
            // _radio_pre
            // 
            this._radio_pre.AutoSize = true;
            this._radio_pre.Location = new System.Drawing.Point(92, 117);
            this._radio_pre.Name = "_radio_pre";
            this._radio_pre.Size = new System.Drawing.Size(63, 17);
            this._radio_pre.TabIndex = 1;
            this._radio_pre.TabStop = true;
            this._radio_pre.Text = "Pre Ver.";
            this._radio_pre.UseVisualStyleBackColor = true;
            // 
            // _chk_nation_bra
            // 
            this._chk_nation_bra.AutoSize = true;
            this._chk_nation_bra.Location = new System.Drawing.Point(18, 76);
            this._chk_nation_bra.Name = "_chk_nation_bra";
            this._chk_nation_bra.Size = new System.Drawing.Size(48, 17);
            this._chk_nation_bra.TabIndex = 3;
            this._chk_nation_bra.Text = "BRA";
            this._chk_nation_bra.UseVisualStyleBackColor = true;
            // 
            // _radio_ship
            // 
            this._radio_ship.AutoSize = true;
            this._radio_ship.Checked = true;
            this._radio_ship.Location = new System.Drawing.Point(18, 117);
            this._radio_ship.Name = "_radio_ship";
            this._radio_ship.Size = new System.Drawing.Size(68, 17);
            this._radio_ship.TabIndex = 0;
            this._radio_ship.TabStop = true;
            this._radio_ship.Text = "Ship Ver.";
            this._radio_ship.UseVisualStyleBackColor = true;
            // 
            // _chk_nation_mex
            // 
            this._chk_nation_mex.AutoSize = true;
            this._chk_nation_mex.Location = new System.Drawing.Point(67, 58);
            this._chk_nation_mex.Name = "_chk_nation_mex";
            this._chk_nation_mex.Size = new System.Drawing.Size(49, 17);
            this._chk_nation_mex.TabIndex = 4;
            this._chk_nation_mex.Text = "MEX";
            this._chk_nation_mex.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "Export";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnExport);
            // 
            // _chk_nation_dev
            // 
            this._chk_nation_dev.AutoSize = true;
            this._chk_nation_dev.Location = new System.Drawing.Point(18, 22);
            this._chk_nation_dev.Name = "_chk_nation_dev";
            this._chk_nation_dev.Size = new System.Drawing.Size(46, 17);
            this._chk_nation_dev.TabIndex = 0;
            this._chk_nation_dev.Text = "Dev";
            this._chk_nation_dev.UseVisualStyleBackColor = true;
            // 
            // _chk_nation_pol
            // 
            this._chk_nation_pol.AutoSize = true;
            this._chk_nation_pol.Location = new System.Drawing.Point(18, 58);
            this._chk_nation_pol.Name = "_chk_nation_pol";
            this._chk_nation_pol.Size = new System.Drawing.Size(47, 17);
            this._chk_nation_pol.TabIndex = 4;
            this._chk_nation_pol.Text = "POL";
            this._chk_nation_pol.UseVisualStyleBackColor = true;
            // 
            // _chk_nation_esp
            // 
            this._chk_nation_esp.AutoSize = true;
            this._chk_nation_esp.Location = new System.Drawing.Point(118, 40);
            this._chk_nation_esp.Name = "_chk_nation_esp";
            this._chk_nation_esp.Size = new System.Drawing.Size(47, 17);
            this._chk_nation_esp.TabIndex = 5;
            this._chk_nation_esp.Text = "ESP";
            this._chk_nation_esp.UseVisualStyleBackColor = true;
            // 
            // _chk_nation_gamigo_all
            // 
            this._chk_nation_gamigo_all.AutoSize = true;
            this._chk_nation_gamigo_all.Location = new System.Drawing.Point(67, 22);
            this._chk_nation_gamigo_all.Name = "_chk_nation_gamigo_all";
            this._chk_nation_gamigo_all.Size = new System.Drawing.Size(45, 17);
            this._chk_nation_gamigo_all.TabIndex = 0;
            this._chk_nation_gamigo_all.Text = "ALL";
            this._chk_nation_gamigo_all.UseVisualStyleBackColor = true;
            this._chk_nation_gamigo_all.CheckedChanged += new System.EventHandler(this._chk_nation_gamigo_all_CheckedChanged);
            // 
            // _chk_nation_fra
            // 
            this._chk_nation_fra.AutoSize = true;
            this._chk_nation_fra.Location = new System.Drawing.Point(118, 22);
            this._chk_nation_fra.Name = "_chk_nation_fra";
            this._chk_nation_fra.Size = new System.Drawing.Size(47, 17);
            this._chk_nation_fra.TabIndex = 2;
            this._chk_nation_fra.Text = "FRA";
            this._chk_nation_fra.UseVisualStyleBackColor = true;
            // 
            // _chk_nation_ita
            // 
            this._chk_nation_ita.AutoSize = true;
            this._chk_nation_ita.Location = new System.Drawing.Point(18, 40);
            this._chk_nation_ita.Name = "_chk_nation_ita";
            this._chk_nation_ita.Size = new System.Drawing.Size(43, 17);
            this._chk_nation_ita.TabIndex = 3;
            this._chk_nation_ita.Text = "ITA";
            this._chk_nation_ita.UseVisualStyleBackColor = true;
            // 
            // _chk_nation_ger
            // 
            this._chk_nation_ger.AutoSize = true;
            this._chk_nation_ger.Location = new System.Drawing.Point(67, 40);
            this._chk_nation_ger.Name = "_chk_nation_ger";
            this._chk_nation_ger.Size = new System.Drawing.Size(49, 17);
            this._chk_nation_ger.TabIndex = 1;
            this._chk_nation_ger.Text = "GER";
            this._chk_nation_ger.UseVisualStyleBackColor = true;
            // 
            // _btn_select_all
            // 
            this._btn_select_all.Location = new System.Drawing.Point(455, 196);
            this._btn_select_all.Name = "_btn_select_all";
            this._btn_select_all.Size = new System.Drawing.Size(64, 25);
            this._btn_select_all.TabIndex = 8;
            this._btn_select_all.Text = "전체 선택";
            this._btn_select_all.UseVisualStyleBackColor = true;
            this._btn_select_all.Click += new System.EventHandler(this.OnChangeBtnSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Log";
            // 
            // _lb_output
            // 
            this._lb_output.BackColor = System.Drawing.SystemColors.InfoText;
            this._lb_output.ForeColor = System.Drawing.Color.Yellow;
            this._lb_output.FormattingEnabled = true;
            this._lb_output.Location = new System.Drawing.Point(412, 24);
            this._lb_output.Name = "_lb_output";
            this._lb_output.Size = new System.Drawing.Size(211, 160);
            this._lb_output.TabIndex = 6;
            // 
            // FormExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 191);
            this.Controls.Add(this._lb_output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._group_nation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._btn_select_all);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormExport";
            this.Text = "String Export";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this._group_nation.ResumeLayout(false);
            this._group_nation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox _chk_all;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox _chk_affinity;
        private System.Windows.Forms.CheckBox _chk_combo;
        private System.Windows.Forms.CheckBox _chk_help1;
        private System.Windows.Forms.CheckBox _chk_sskill;
        private System.Windows.Forms.CheckBox _chk_action;
        private System.Windows.Forms.CheckBox _chk_skill;
        private System.Windows.Forms.CheckBox _chk_quest;
        private System.Windows.Forms.CheckBox _chk_npcname;
        private System.Windows.Forms.CheckBox _chk_setitem;
        private System.Windows.Forms.CheckBox _chk_item;
        private System.Windows.Forms.CheckBox _chk_string;
        private System.Windows.Forms.GroupBox _group_nation;
        private System.Windows.Forms.Button _btn_select_all;
        private System.Windows.Forms.CheckBox _chk_nation_tha;
        private System.Windows.Forms.CheckBox _chk_nation_usa;
        private System.Windows.Forms.CheckBox _chk_nation_rus;
        private System.Windows.Forms.CheckBox _chk_nation_esp;
        private System.Windows.Forms.CheckBox _chk_nation_pol;
        private System.Windows.Forms.CheckBox _chk_nation_ita;
        private System.Windows.Forms.CheckBox _chk_nation_fra;
        private System.Windows.Forms.CheckBox _chk_nation_ger;
        private System.Windows.Forms.CheckBox _chk_nation_gamigo_all;
        private System.Windows.Forms.CheckBox _chk_nation_dev;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox _lb_output;
        private System.Windows.Forms.CheckBox _chk_opt_rare;
        private System.Windows.Forms.CheckBox _chk_option;
        private System.Windows.Forms.RadioButton _radio_pre;
        private System.Windows.Forms.RadioButton _radio_ship;
        private System.Windows.Forms.CheckBox _chk_nation_uk;
        private System.Windows.Forms.CheckBox _chk_nation_mex;
        private System.Windows.Forms.CheckBox _chk_nation_bra;
        private System.Windows.Forms.CheckBox _chk_lacarette;
        private System.Windows.Forms.CheckBox _chk_itemcollection;
    }
}

