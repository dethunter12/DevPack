using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LodExporter
{
    partial class FormExport
    {
        public enum eLod
        {
            ITEM,               // 아이템 LOD
            ITEM_COLLECTION,    // 아이템 수집
            SKILL,              // 스킬
            SSKILL,             // 특수 스킬
            ACTION,             // 엑션 [소셜]
            NPC,                // NPC
            NPCHELP,            // NPC 스크롤
            QUEST,              // 퀘스트    
            AFFINITY,           // 친화도
            OPTION,             // 옵션
            RAREOPTION,         // 레어옵션
            TITLE,              // 타이틀
            APET,               // 공격펫[P2]
            MAP,                // 맵LOD
            COMBO,              // 몬스터콤보
            SHOP,               // 상인정보
            MAX
        };

        public enum ePath
        {
            CURRENT,
            TEST,
            MAX
        }

        public enum eNATION
        {
            DEV,
            GER, FRA, ITA, POL, ESP, GBR,
            BRA, MEX,
            USA,
            RUS,
            THA,
            MAX
        };

        public readonly string strIP = "25.73.158.252";
        public readonly string strID = "k1ngarture6969";
        public readonly string strPW = "ZJ40YJEgZrdFbxh";

        public readonly string[] DBname =
        {
            "ten_data_s_2015",          // DEV
            "ten_data_s_2015",       // GER            
            "ten_data_s_2015",       // FRA            
            "ten_data_s_2015",       // ITA
            "ten_data_s_2015",       // POL
            "ten_data_s_2015",       // ESP
            "ten_data_s_2015",       // GBR
            "ten_data_s_2015",       // BRA
            "ten_data_s_2015",       // MEX
            "ten_data_s_2015",       // USA
            "ten_data_s_2015",       // RUS
            "ten_data_s_2015",       // THAI
        };

        public readonly string[] strPath = 
        {
            "path_ship",
            "path_pre"
        };

        public readonly string[] strNation =
        {
            "dev",
            "ger", "fra", "ita", "pol", "esp", "gbr",
            "bra", "mex", 
            "usa",
            "rus",
            "tha",            
        };

        public readonly string[] strLodCmdName = 
        {
            "item",
            "itemCollection",
            "skill",
            "sskill",
            "action",
            "npc",
            "helpnpc",
            "quest",
            "affinity",
            "option",
            "rareoption",
            "title",
            "apet",
            "map",
            "combo",
            "shop",            
        };
    }
}
