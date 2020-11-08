using SlimDX.Direct3D10;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringExporter
{
    partial class FormExport
    {
        private bool QueryProc(int StringIdx)
        {
            _lb_output.Items.Add(string.Format("{0} DB Query 시작", ((eSTRING)(StringIdx)).ToString()));

            _lb_output.Refresh();
            _lb_output.Invalidate();

            switch (StringIdx)
            {
                case (int)eSTRING.STRING:
                    _sql2.Query("SELECT * FROM t_string ORDER BY a_index");
                    break;
                case (int)eSTRING.HELP1:
                    _sql2.Query("SELECT * FROM t_help1 ORDER BY a_index");
                    break;
                case (int)eSTRING.ITEM:
                    _sql2.Query("SELECT * FROM t_item WHERE a_enable = 1 ORDER BY a_index");
                    break;
                case (int)eSTRING.ITEM_SET:
                    _sql2.Query("SELECT * FROM t_set_item WHERE a_enable = 1 ORDER BY a_set_idx");
                    break;
                case (int)eSTRING.OPTION:
                    _sql2.Query("SELECT * FROM t_option ORDER BY a_index");
                    break;
                case (int)eSTRING.OPTION_RARE:
                    _sql2.Query("SELECT * FROM t_rareoption ORDER BY a_index");
                    break;
                case (int)eSTRING.NPC_NAME:
                    _sql2.Query("SELECT DISTINCT * FROM t_npc WHERE a_enable = 1 ORDER BY a_index");
                    break;
                case (int)eSTRING.QUEST:
                    _sql2.Query("SELECT * " +
                                "FROM t_quest " +
                                "ORDER BY a_index");
                    break;                
                case (int)eSTRING.SKILL:
                    _sql2.Query("SELECT * FROM t_skill WHERE a_job>=0 ORDER BY a_index");
                    break;
                case (int)eSTRING.SKILL_SPECIAL:
                    _sql2.Query("SELECT * FROM t_special_skill WHERE a_enable=1 ORDER BY a_index");
                    break;
                case (int)eSTRING.ACTION:
                    _sql2.Query("SELECT * FROM t_action ORDER BY a_index");
                    break;
                case (int)eSTRING.COMBO:
                    _sql2.Query("SELECT * FROM t_missioncase WHERE a_enable = 1 ORDER BY a_index");
                    break;
                case (int)eSTRING.AFFINITY:
                    _sql2.Query("SELECT * FROM t_affinity WHERE a_enable = 1 ORDER BY a_index");
                    break;
                case (int)eSTRING.LACARETTE:
                    _sql2.Query("SELECT * FROM t_lacarette WHERE a_enable = 1 ORDER BY a_index");
                    break;
                case (int)eSTRING.ITEMCOLLECTION:
                    _sql2.Query("SELECT * FROM t_item_collection ORDER BY a_theme");
                    break;
            }

            return true;
        }
    }
}
