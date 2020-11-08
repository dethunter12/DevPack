using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace StringExporter
{
    partial class FormExport
    {
        private void _chk_all_CheckedChanged(object sender, EventArgs e)
        {
            bool bChecked = _chk_all.Checked;

            _chk_string.Checked = bChecked;
            _chk_help1.Checked = bChecked;
            _chk_item.Checked = bChecked;
            _chk_setitem.Checked = bChecked;
            _chk_option.Checked = bChecked;
            _chk_opt_rare.Checked = bChecked;
            _chk_npcname.Checked = bChecked;
            _chk_quest.Checked = bChecked;
            _chk_skill.Checked = bChecked;
            _chk_sskill.Checked = bChecked;
            _chk_action.Checked = bChecked;
            _chk_combo.Checked = bChecked;
            _chk_affinity.Checked = bChecked;
            _chk_lacarette.Checked = bChecked;
            _chk_itemcollection.Checked = bChecked;
        }

        private void _chk_nation_gamigo_all_CheckedChanged(object sender, EventArgs e)
        {
            bool bChecked = _chk_nation_gamigo_all.Checked;

            _chk_nation_ger.Checked = bChecked;
            _chk_nation_fra.Checked = bChecked;
            _chk_nation_ita.Checked = bChecked;
            _chk_nation_pol.Checked = bChecked;
            _chk_nation_esp.Checked = bChecked;
            _chk_nation_usa.Checked = bChecked;

            _chk_nation_bra.Checked = bChecked;
            _chk_nation_mex.Checked = bChecked;

            _chk_nation_uk.Checked = bChecked;

            _chk_nation_rus.Checked = bChecked;
        }

        private void OnChangeBtnSelect(object sender, EventArgs e)
        {
            bool bChecked = !_chk_nation_dev.Checked;

            _chk_nation_dev.Checked = bChecked;
            _chk_nation_gamigo_all.Checked = bChecked;
            _chk_nation_rus.Checked = bChecked;
            _chk_nation_tha.Checked = bChecked;

            if (bChecked == true)
                _btn_select_all.Text = "선택 해제";
            else
                _btn_select_all.Text = "전체 선택";
        }

    }
}
