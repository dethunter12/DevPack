using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LodExporter
{
    partial class FormExport
    {
        private void _chk_all_CheckedChanged(object sender, EventArgs e)
        {
            bool bChecked = _chk_all.Checked;

            _chk_item.Checked = bChecked;
            _chk_itemCollection.Checked = bChecked;
            _chk_affinity.Checked = bChecked;
            _chk_option.Checked = bChecked;
            _chk_rareOption.Checked = bChecked;
            _chk_title.Checked = bChecked;
            _chk_skill.Checked = bChecked;
            _chk_npcHelp.Checked = bChecked;
            _chk_quest.Checked = bChecked;
            _chk_npc.Checked = bChecked;
            _chk_action.Checked = bChecked;
            _chk_SSkill.Checked = bChecked;
            _chk_apet.Checked = bChecked;
            _chk_combo.Checked = bChecked;
            _chk_map.Checked = bChecked;
            _chk_shop.Checked = bChecked;
        }

        private void _chk_nation_gamigo_all_CheckedChanged(object sender, EventArgs e)
        {
            bool bChecked = _chk_nation_gamigo_all.Checked;

            _chk_nation_ger.Checked = bChecked;
            _chk_nation_fra.Checked = bChecked;
            _chk_nation_ita.Checked = bChecked;
            _chk_nation_pol.Checked = bChecked;
            _chk_nation_esp.Checked = bChecked;
            _chk_nation_uk.Checked = bChecked;

            _chk_nation_usa.Checked = bChecked;

            _chk_nation_bra.Checked = bChecked;
            _chk_nation_mex.Checked = bChecked;

            _chk_nation_rus.Checked = bChecked;
        }

        private void OnChangeBtnSelect(object sender, EventArgs e)
        {
            bool bChecked = !_chk_nation_dev.Checked;

            _chk_nation_dev.Checked = bChecked;
            _chk_nation_gamigo_all.Checked = bChecked;
            
            _chk_nation_tha.Checked = bChecked;

            if (bChecked == true)
                _btn_select_all.Text = "Deselect";
            else
                _btn_select_all.Text = "Select All";
        }

        private void OnExport(object sender, EventArgs e)
        {
            int i, nLodIdx;

            _lb_output.Items.Clear();

            _lb_output.Items.Add("Export start.");

            _lb_output.Refresh();
            _lb_output.Invalidate();

            CheckBox[] chkbox = new CheckBox[(int)eLod.MAX]
            {
                _chk_item,
                _chk_itemCollection,
                _chk_skill,
                _chk_SSkill,
                _chk_action,
                _chk_npc,
                _chk_npcHelp,
                _chk_quest,
                _chk_affinity,
                _chk_option,
                _chk_rareOption,
                _chk_title,
                _chk_apet,
                _chk_map,
                _chk_combo,
                _chk_shop,
            };

            CheckBox[] chk_nation = new CheckBox[(int)eNATION.MAX]
            {
                _chk_nation_dev,
                _chk_nation_ger, _chk_nation_fra, _chk_nation_ita, _chk_nation_pol, _chk_nation_esp, _chk_nation_uk,
                _chk_nation_bra, _chk_nation_mex,
                _chk_nation_usa,
                _chk_nation_rus,                
                _chk_nation_tha,
            };

            string strLod = "";
            int nPathKey = (int)ePath.CURRENT;

            if (_radio_pre.Checked == true)
                nPathKey = (int)ePath.TEST;

            for (i = 0; i < (int)eNATION.MAX; ++i)
            {
                if (chk_nation[i].Checked == true)
                {
                    _lb_output.SelectedIndex = _lb_output.Items.Add("Export country - " + strNation[i] + " Build - " + strPath[nPathKey] + Environment.NewLine);
                    strLod = "";
                    // LOD Command 얻기
                    for (nLodIdx = 0; nLodIdx < (int)eLod.MAX; ++nLodIdx)
                    {
                        if (chkbox[nLodIdx].Checked == true)
                        {
                            strLod += strLodCmdName[nLodIdx];
                            strLod += " ";
                        }
                    }

                    // Command 조립
                    string strCommand;
                    string strDB;

                    if (i == 0 && _combo_ver.SelectedIndex == 0)
                        strDB = DBname[i];
                    else
                        strDB = DBname[i] + "_" + _db_config.GetStrVer(_combo_ver.SelectedIndex);
                    
                    strCommand = "-h " + strIP + " -d " + strDB + " -u " + strID +
                        " -p " + strPW + " -k " + strPath[nPathKey] + " -l " + strNation[i] + " -t " + strLod;

                    // Command 실행
                    System.Diagnostics.Process.Start("ExportLod.exe", strCommand);
                }                
            }
        }        
    }
}
