namespace LodExporter
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
            this._btn_select_all = new System.Windows.Forms.Button();
            this._chk_nation_tha = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._chk_nation_mex = new System.Windows.Forms.CheckBox();
            this._chk_nation_uk = new System.Windows.Forms.CheckBox();
            this._chk_nation_dev = new System.Windows.Forms.CheckBox();
            this._chk_nation_rus = new System.Windows.Forms.CheckBox();
            this._chk_nation_bra = new System.Windows.Forms.CheckBox();
            this._chk_nation_esp = new System.Windows.Forms.CheckBox();
            this._chk_nation_pol = new System.Windows.Forms.CheckBox();
            this._chk_nation_gamigo_all = new System.Windows.Forms.CheckBox();
            this._chk_nation_usa = new System.Windows.Forms.CheckBox();
            this._chk_nation_ita = new System.Windows.Forms.CheckBox();
            this._chk_nation_fra = new System.Windows.Forms.CheckBox();
            this._chk_nation_ger = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._lb_output = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this._radio_pre = new System.Windows.Forms.RadioButton();
            this._radio_shop = new System.Windows.Forms.RadioButton();
            this._chk_all = new System.Windows.Forms.CheckBox();
            this._chk_item = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._chk_apet = new System.Windows.Forms.CheckBox();
            this._chk_combo = new System.Windows.Forms.CheckBox();
            this._chk_map = new System.Windows.Forms.CheckBox();
            this._chk_shop = new System.Windows.Forms.CheckBox();
            this._chk_affinity = new System.Windows.Forms.CheckBox();
            this._chk_option = new System.Windows.Forms.CheckBox();
            this._chk_rareOption = new System.Windows.Forms.CheckBox();
            this._chk_title = new System.Windows.Forms.CheckBox();
            this._chk_skill = new System.Windows.Forms.CheckBox();
            this._chk_npcHelp = new System.Windows.Forms.CheckBox();
            this._chk_quest = new System.Windows.Forms.CheckBox();
            this._chk_npc = new System.Windows.Forms.CheckBox();
            this._chk_action = new System.Windows.Forms.CheckBox();
            this._chk_SSkill = new System.Windows.Forms.CheckBox();
            this._chk_itemCollection = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._combo_ver = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btn_select_all
            // 
            this._btn_select_all.Location = new System.Drawing.Point(67, 114);
            this._btn_select_all.Name = "_btn_select_all";
            this._btn_select_all.Size = new System.Drawing.Size(64, 25);
            this._btn_select_all.TabIndex = 8;
            this._btn_select_all.Text = "Select All";
            this._btn_select_all.UseVisualStyleBackColor = true;
            this._btn_select_all.Click += new System.EventHandler(this.OnChangeBtnSelect);
            // 
            // _chk_nation_tha
            // 
            this._chk_nation_tha.AutoSize = true;
            this._chk_nation_tha.Location = new System.Drawing.Point(67, 143);
            this._chk_nation_tha.Name = "_chk_nation_tha";
            this._chk_nation_tha.Size = new System.Drawing.Size(48, 17);
            this._chk_nation_tha.TabIndex = 7;
            this._chk_nation_tha.Text = "THA";
            this._chk_nation_tha.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._btn_select_all);
            this.groupBox3.Controls.Add(this._chk_nation_mex);
            this.groupBox3.Controls.Add(this._chk_nation_tha);
            this.groupBox3.Controls.Add(this._chk_nation_uk);
            this.groupBox3.Controls.Add(this._chk_nation_dev);
            this.groupBox3.Controls.Add(this._chk_nation_rus);
            this.groupBox3.Controls.Add(this._chk_nation_bra);
            this.groupBox3.Controls.Add(this._chk_nation_esp);
            this.groupBox3.Controls.Add(this._chk_nation_pol);
            this.groupBox3.Controls.Add(this._chk_nation_gamigo_all);
            this.groupBox3.Controls.Add(this._chk_nation_usa);
            this.groupBox3.Controls.Add(this._chk_nation_ita);
            this.groupBox3.Controls.Add(this._chk_nation_fra);
            this.groupBox3.Controls.Add(this._chk_nation_ger);
            this.groupBox3.Location = new System.Drawing.Point(10, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 160);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Languages";
            this.groupBox3.Visible = false;
            // 
            // _chk_nation_mex
            // 
            this._chk_nation_mex.AutoSize = true;
            this._chk_nation_mex.Location = new System.Drawing.Point(67, 91);
            this._chk_nation_mex.Name = "_chk_nation_mex";
            this._chk_nation_mex.Size = new System.Drawing.Size(49, 17);
            this._chk_nation_mex.TabIndex = 4;
            this._chk_nation_mex.Text = "MEX";
            this._chk_nation_mex.UseVisualStyleBackColor = true;
            // 
            // _chk_nation_uk
            // 
            this._chk_nation_uk.AutoSize = true;
            this._chk_nation_uk.Location = new System.Drawing.Point(120, 68);
            this._chk_nation_uk.Name = "_chk_nation_uk";
            this._chk_nation_uk.Size = new System.Drawing.Size(41, 17);
            this._chk_nation_uk.TabIndex = 3;
            this._chk_nation_uk.Text = "UK";
            this._chk_nation_uk.UseVisualStyleBackColor = true;
            // 
            // _chk_nation_dev
            // 
            this._chk_nation_dev.AutoSize = true;
            this._chk_nation_dev.Checked = true;
            this._chk_nation_dev.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chk_nation_dev.Location = new System.Drawing.Point(12, 143);
            this._chk_nation_dev.Name = "_chk_nation_dev";
            this._chk_nation_dev.Size = new System.Drawing.Size(46, 17);
            this._chk_nation_dev.TabIndex = 0;
            this._chk_nation_dev.Text = "Dev";
            this._chk_nation_dev.UseVisualStyleBackColor = true;
            // 
            // _chk_nation_rus
            // 
            this._chk_nation_rus.AutoSize = true;
            this._chk_nation_rus.Location = new System.Drawing.Point(12, 114);
            this._chk_nation_rus.Name = "_chk_nation_rus";
            this._chk_nation_rus.Size = new System.Drawing.Size(49, 17);
            this._chk_nation_rus.TabIndex = 5;
            this._chk_nation_rus.Text = "RUS";
            this._chk_nation_rus.UseVisualStyleBackColor = true;
            // 
            // _chk_nation_bra
            // 
            this._chk_nation_bra.AutoSize = true;
            this._chk_nation_bra.Location = new System.Drawing.Point(12, 91);
            this._chk_nation_bra.Name = "_chk_nation_bra";
            this._chk_nation_bra.Size = new System.Drawing.Size(48, 17);
            this._chk_nation_bra.TabIndex = 3;
            this._chk_nation_bra.Text = "BRA";
            this._chk_nation_bra.UseVisualStyleBackColor = true;
            // 
            // _chk_nation_esp
            // 
            this._chk_nation_esp.AutoSize = true;
            this._chk_nation_esp.Location = new System.Drawing.Point(67, 68);
            this._chk_nation_esp.Name = "_chk_nation_esp";
            this._chk_nation_esp.Size = new System.Drawing.Size(47, 17);
            this._chk_nation_esp.TabIndex = 5;
            this._chk_nation_esp.Text = "ESP";
            this._chk_nation_esp.UseVisualStyleBackColor = true;
            // 
            // _chk_nation_pol
            // 
            this._chk_nation_pol.AutoSize = true;
            this._chk_nation_pol.Location = new System.Drawing.Point(12, 68);
            this._chk_nation_pol.Name = "_chk_nation_pol";
            this._chk_nation_pol.Size = new System.Drawing.Size(47, 17);
            this._chk_nation_pol.TabIndex = 4;
            this._chk_nation_pol.Text = "POL";
            this._chk_nation_pol.UseVisualStyleBackColor = true;
            // 
            // _chk_nation_gamigo_all
            // 
            this._chk_nation_gamigo_all.AutoSize = true;
            this._chk_nation_gamigo_all.Location = new System.Drawing.Point(12, 22);
            this._chk_nation_gamigo_all.Name = "_chk_nation_gamigo_all";
            this._chk_nation_gamigo_all.Size = new System.Drawing.Size(45, 17);
            this._chk_nation_gamigo_all.TabIndex = 0;
            this._chk_nation_gamigo_all.Text = "ALL";
            this._chk_nation_gamigo_all.UseVisualStyleBackColor = true;
            this._chk_nation_gamigo_all.CheckedChanged += new System.EventHandler(this._chk_nation_gamigo_all_CheckedChanged);
            // 
            // _chk_nation_usa
            // 
            this._chk_nation_usa.AutoSize = true;
            this._chk_nation_usa.Checked = true;
            this._chk_nation_usa.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chk_nation_usa.Location = new System.Drawing.Point(120, 91);
            this._chk_nation_usa.Name = "_chk_nation_usa";
            this._chk_nation_usa.Size = new System.Drawing.Size(41, 17);
            this._chk_nation_usa.TabIndex = 6;
            this._chk_nation_usa.Text = "US";
            this._chk_nation_usa.UseVisualStyleBackColor = true;
            // 
            // _chk_nation_ita
            // 
            this._chk_nation_ita.AutoSize = true;
            this._chk_nation_ita.Location = new System.Drawing.Point(120, 45);
            this._chk_nation_ita.Name = "_chk_nation_ita";
            this._chk_nation_ita.Size = new System.Drawing.Size(43, 17);
            this._chk_nation_ita.TabIndex = 3;
            this._chk_nation_ita.Text = "ITA";
            this._chk_nation_ita.UseVisualStyleBackColor = true;
            // 
            // _chk_nation_fra
            // 
            this._chk_nation_fra.AutoSize = true;
            this._chk_nation_fra.Location = new System.Drawing.Point(67, 45);
            this._chk_nation_fra.Name = "_chk_nation_fra";
            this._chk_nation_fra.Size = new System.Drawing.Size(47, 17);
            this._chk_nation_fra.TabIndex = 2;
            this._chk_nation_fra.Text = "FRA";
            this._chk_nation_fra.UseVisualStyleBackColor = true;
            // 
            // _chk_nation_ger
            // 
            this._chk_nation_ger.AutoSize = true;
            this._chk_nation_ger.Location = new System.Drawing.Point(12, 45);
            this._chk_nation_ger.Name = "_chk_nation_ger";
            this._chk_nation_ger.Size = new System.Drawing.Size(49, 17);
            this._chk_nation_ger.TabIndex = 1;
            this._chk_nation_ger.Text = "GER";
            this._chk_nation_ger.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "Export";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnExport);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Log";
            // 
            // _lb_output
            // 
            this._lb_output.BackColor = System.Drawing.SystemColors.MenuText;
            this._lb_output.ForeColor = System.Drawing.Color.Yellow;
            this._lb_output.FormattingEnabled = true;
            this._lb_output.Location = new System.Drawing.Point(221, 14);
            this._lb_output.Name = "_lb_output";
            this._lb_output.Size = new System.Drawing.Size(268, 56);
            this._lb_output.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this._radio_pre);
            this.groupBox5.Controls.Add(this._radio_shop);
            this.groupBox5.Location = new System.Drawing.Point(12, 76);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(212, 43);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select output";
            // 
            // _radio_pre
            // 
            this._radio_pre.AutoSize = true;
            this._radio_pre.Location = new System.Drawing.Point(80, 19);
            this._radio_pre.Name = "_radio_pre";
            this._radio_pre.Size = new System.Drawing.Size(63, 17);
            this._radio_pre.TabIndex = 1;
            this._radio_pre.TabStop = true;
            this._radio_pre.Text = "Pre Ver.";
            this._radio_pre.UseVisualStyleBackColor = true;
            // 
            // _radio_shop
            // 
            this._radio_shop.AutoSize = true;
            this._radio_shop.Checked = true;
            this._radio_shop.Location = new System.Drawing.Point(6, 19);
            this._radio_shop.Name = "_radio_shop";
            this._radio_shop.Size = new System.Drawing.Size(68, 17);
            this._radio_shop.TabIndex = 0;
            this._radio_shop.TabStop = true;
            this._radio_shop.Text = "Ship Ver.";
            this._radio_shop.UseVisualStyleBackColor = true;
            // 
            // _chk_all
            // 
            this._chk_all.AutoSize = true;
            this._chk_all.Location = new System.Drawing.Point(12, 167);
            this._chk_all.Name = "_chk_all";
            this._chk_all.Size = new System.Drawing.Size(45, 17);
            this._chk_all.TabIndex = 0;
            this._chk_all.Text = "ALL";
            this._chk_all.UseVisualStyleBackColor = true;
            this._chk_all.CheckedChanged += new System.EventHandler(this._chk_all_CheckedChanged);
            // 
            // _chk_item
            // 
            this._chk_item.AutoSize = true;
            this._chk_item.Location = new System.Drawing.Point(13, 52);
            this._chk_item.Name = "_chk_item";
            this._chk_item.Size = new System.Drawing.Size(46, 17);
            this._chk_item.TabIndex = 2;
            this._chk_item.Text = "Item";
            this._chk_item.UseVisualStyleBackColor = true;
            this._chk_item.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._chk_apet);
            this.groupBox1.Controls.Add(this._chk_combo);
            this.groupBox1.Controls.Add(this._chk_map);
            this.groupBox1.Controls.Add(this._chk_shop);
            this.groupBox1.Controls.Add(this._chk_affinity);
            this.groupBox1.Controls.Add(this._chk_option);
            this.groupBox1.Controls.Add(this._chk_rareOption);
            this.groupBox1.Controls.Add(this._chk_title);
            this.groupBox1.Controls.Add(this._chk_skill);
            this.groupBox1.Controls.Add(this._chk_npcHelp);
            this.groupBox1.Controls.Add(this._chk_quest);
            this.groupBox1.Controls.Add(this._chk_npc);
            this.groupBox1.Controls.Add(this._chk_action);
            this.groupBox1.Controls.Add(this._chk_SSkill);
            this.groupBox1.Controls.Add(this._chk_itemCollection);
            this.groupBox1.Controls.Add(this._chk_item);
            this.groupBox1.Controls.Add(this._chk_all);
            this.groupBox1.Location = new System.Drawing.Point(10, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 57);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pet LOD";
            // 
            // _chk_apet
            // 
            this._chk_apet.AutoSize = true;
            this._chk_apet.Location = new System.Drawing.Point(9, 19);
            this._chk_apet.Name = "_chk_apet";
            this._chk_apet.Size = new System.Drawing.Size(48, 17);
            this._chk_apet.TabIndex = 17;
            this._chk_apet.Text = "Apet";
            this._chk_apet.UseVisualStyleBackColor = true;
            // 
            // _chk_combo
            // 
            this._chk_combo.AutoSize = true;
            this._chk_combo.Location = new System.Drawing.Point(67, 213);
            this._chk_combo.Name = "_chk_combo";
            this._chk_combo.Size = new System.Drawing.Size(59, 17);
            this._chk_combo.TabIndex = 16;
            this._chk_combo.Text = "Combo";
            this._chk_combo.UseVisualStyleBackColor = true;
            // 
            // _chk_map
            // 
            this._chk_map.AutoSize = true;
            this._chk_map.Location = new System.Drawing.Point(13, 190);
            this._chk_map.Name = "_chk_map";
            this._chk_map.Size = new System.Drawing.Size(47, 17);
            this._chk_map.TabIndex = 15;
            this._chk_map.Text = "Map";
            this._chk_map.UseVisualStyleBackColor = true;
            this._chk_map.CheckedChanged += new System.EventHandler(this._chk_map_CheckedChanged);
            // 
            // _chk_shop
            // 
            this._chk_shop.AutoSize = true;
            this._chk_shop.Location = new System.Drawing.Point(13, 213);
            this._chk_shop.Name = "_chk_shop";
            this._chk_shop.Size = new System.Drawing.Size(51, 17);
            this._chk_shop.TabIndex = 14;
            this._chk_shop.Text = "Shop";
            this._chk_shop.UseVisualStyleBackColor = true;
            // 
            // _chk_affinity
            // 
            this._chk_affinity.AutoSize = true;
            this._chk_affinity.Location = new System.Drawing.Point(67, 144);
            this._chk_affinity.Name = "_chk_affinity";
            this._chk_affinity.Size = new System.Drawing.Size(57, 17);
            this._chk_affinity.TabIndex = 13;
            this._chk_affinity.Text = "Affinity";
            this._chk_affinity.UseVisualStyleBackColor = true;
            // 
            // _chk_option
            // 
            this._chk_option.AutoSize = true;
            this._chk_option.Location = new System.Drawing.Point(67, 167);
            this._chk_option.Name = "_chk_option";
            this._chk_option.Size = new System.Drawing.Size(57, 17);
            this._chk_option.TabIndex = 12;
            this._chk_option.Text = "Option";
            this._chk_option.UseVisualStyleBackColor = true;
            // 
            // _chk_rareOption
            // 
            this._chk_rareOption.AutoSize = true;
            this._chk_rareOption.Location = new System.Drawing.Point(67, 190);
            this._chk_rareOption.Name = "_chk_rareOption";
            this._chk_rareOption.Size = new System.Drawing.Size(83, 17);
            this._chk_rareOption.TabIndex = 11;
            this._chk_rareOption.Text = "Rare Option";
            this._chk_rareOption.UseVisualStyleBackColor = true;
            // 
            // _chk_title
            // 
            this._chk_title.AutoSize = true;
            this._chk_title.Location = new System.Drawing.Point(13, 144);
            this._chk_title.Name = "_chk_title";
            this._chk_title.Size = new System.Drawing.Size(46, 17);
            this._chk_title.TabIndex = 10;
            this._chk_title.Text = "Title";
            this._chk_title.UseVisualStyleBackColor = true;
            // 
            // _chk_skill
            // 
            this._chk_skill.AutoSize = true;
            this._chk_skill.Location = new System.Drawing.Point(13, 75);
            this._chk_skill.Name = "_chk_skill";
            this._chk_skill.Size = new System.Drawing.Size(45, 17);
            this._chk_skill.TabIndex = 9;
            this._chk_skill.Text = "Skill";
            this._chk_skill.UseVisualStyleBackColor = true;
            // 
            // _chk_npcHelp
            // 
            this._chk_npcHelp.AutoSize = true;
            this._chk_npcHelp.Location = new System.Drawing.Point(67, 98);
            this._chk_npcHelp.Name = "_chk_npcHelp";
            this._chk_npcHelp.Size = new System.Drawing.Size(68, 17);
            this._chk_npcHelp.TabIndex = 8;
            this._chk_npcHelp.Text = "HelpNpc";
            this._chk_npcHelp.UseVisualStyleBackColor = true;
            // 
            // _chk_quest
            // 
            this._chk_quest.AutoSize = true;
            this._chk_quest.Location = new System.Drawing.Point(13, 121);
            this._chk_quest.Name = "_chk_quest";
            this._chk_quest.Size = new System.Drawing.Size(54, 17);
            this._chk_quest.TabIndex = 7;
            this._chk_quest.Text = "Quest";
            this._chk_quest.UseVisualStyleBackColor = true;
            // 
            // _chk_npc
            // 
            this._chk_npc.AutoSize = true;
            this._chk_npc.Location = new System.Drawing.Point(13, 98);
            this._chk_npc.Name = "_chk_npc";
            this._chk_npc.Size = new System.Drawing.Size(48, 17);
            this._chk_npc.TabIndex = 6;
            this._chk_npc.Text = "NPC";
            this._chk_npc.UseVisualStyleBackColor = true;
            // 
            // _chk_action
            // 
            this._chk_action.AutoSize = true;
            this._chk_action.Location = new System.Drawing.Point(67, 121);
            this._chk_action.Name = "_chk_action";
            this._chk_action.Size = new System.Drawing.Size(56, 17);
            this._chk_action.TabIndex = 5;
            this._chk_action.Text = "Action";
            this._chk_action.UseVisualStyleBackColor = true;
            // 
            // _chk_SSkill
            // 
            this._chk_SSkill.AutoSize = true;
            this._chk_SSkill.Location = new System.Drawing.Point(67, 75);
            this._chk_SSkill.Name = "_chk_SSkill";
            this._chk_SSkill.Size = new System.Drawing.Size(52, 17);
            this._chk_SSkill.TabIndex = 4;
            this._chk_SSkill.Text = "SSkill";
            this._chk_SSkill.UseVisualStyleBackColor = true;
            // 
            // _chk_itemCollection
            // 
            this._chk_itemCollection.AutoSize = true;
            this._chk_itemCollection.Location = new System.Drawing.Point(67, 52);
            this._chk_itemCollection.Name = "_chk_itemCollection";
            this._chk_itemCollection.Size = new System.Drawing.Size(95, 17);
            this._chk_itemCollection.TabIndex = 3;
            this._chk_itemCollection.Text = "Item Collection";
            this._chk_itemCollection.UseVisualStyleBackColor = true;
            this._chk_itemCollection.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this._combo_ver);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(221, 76);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(268, 62);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select Version";
            this.groupBox4.UseCompatibleTextRendering = true;
            // 
            // _combo_ver
            // 
            this._combo_ver.FormattingEnabled = true;
            this._combo_ver.Location = new System.Drawing.Point(9, 19);
            this._combo_ver.Name = "_combo_ver";
            this._combo_ver.Size = new System.Drawing.Size(149, 21);
            this._combo_ver.TabIndex = 0;
            // 
            // FormExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 119);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this._lb_output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormExport";
            this.Text = "Lod Export";
            this.Load += new System.EventHandler(this.FormExport_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _btn_select_all;
        private System.Windows.Forms.CheckBox _chk_nation_tha;
        private System.Windows.Forms.CheckBox _chk_nation_usa;
        private System.Windows.Forms.CheckBox _chk_nation_rus;
        private System.Windows.Forms.CheckBox _chk_nation_mex;
        private System.Windows.Forms.CheckBox _chk_nation_bra;
        private System.Windows.Forms.GroupBox groupBox3;
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
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton _radio_pre;
        private System.Windows.Forms.RadioButton _radio_shop;
        private System.Windows.Forms.CheckBox _chk_all;
        private System.Windows.Forms.CheckBox _chk_item;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox _chk_nation_uk;
        private System.Windows.Forms.CheckBox _chk_itemCollection;
        private System.Windows.Forms.CheckBox _chk_affinity;
        private System.Windows.Forms.CheckBox _chk_option;
        private System.Windows.Forms.CheckBox _chk_rareOption;
        private System.Windows.Forms.CheckBox _chk_title;
        private System.Windows.Forms.CheckBox _chk_skill;
        private System.Windows.Forms.CheckBox _chk_npcHelp;
        private System.Windows.Forms.CheckBox _chk_quest;
        private System.Windows.Forms.CheckBox _chk_npc;
        private System.Windows.Forms.CheckBox _chk_action;
        private System.Windows.Forms.CheckBox _chk_SSkill;
        private System.Windows.Forms.CheckBox _chk_apet;
        private System.Windows.Forms.CheckBox _chk_combo;
        private System.Windows.Forms.CheckBox _chk_map;
        private System.Windows.Forms.CheckBox _chk_shop;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox _combo_ver;
    }
}

