using System;
using System.Collections.Generic;
using System.Text;

namespace StringExporter
{
    partial class FormExport
    {
        public enum eSTRING
        {
            STRING,
            HELP1,
            ITEM,
            ITEM_SET,
            OPTION,
            OPTION_RARE,
            NPC_NAME,
            QUEST,
            SKILL,
            SKILL_SPECIAL,
            ACTION,
            COMBO,
            AFFINITY,
            LACARETTE,
            ITEMCOLLECTION,
            MAX
        };

        public enum eNATION
        {
            DEV,
            GER, FRA, ITA, POL, ESP,
            BRA, MEX,
            RUS,
            USA,
            THA,
            GBR,
            MAX
        };

        readonly string[] NationPostfix =
        {
            "",
            "_ger", "_frc", "_ita", "_pld", "_spn",
            "_brz", "_mex",
            "_rus",
            "_usa",
            "_thai",
            "_uk",
        };

        readonly string[] OutputNationPost =
        {
            "",
            "_de", "_fr", "_it", "_pl", "_es",
            "_br", "_mx",
            "_ru",
            "_us",
            "_th",
            "_uk",
        };

        public readonly string[] strEncoding = 
        {
            string.Empty,       // DEV
            "Windows-1252",     // GER            
            "Windows-1252",     // FRA            
            "Windows-1252",     // ITA
            "Windows-1250",     // POL
            "Windows-1252",     // ESP
            "Windows-1252",     // BRA
            "Windows-1252",     // MEX
            "Windows-1251",     // RUS
            string.Empty,       // USA
            "windows-874",      // THAI
            string.Empty,       // USA
        };
    }
}
