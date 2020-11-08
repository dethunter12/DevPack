using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LcDevPack_TeamDamonA.Tools.MemoryWorker.Item
{
    public class ItemContainer
    {
        public int EditFlag;
        public string Name;
        public string Description;
        public int[] CraftItemAmount;
        public int[] CraftItemID;
        public int[] rareOptionType;
        public int[] rareOptionChance;
        public string Effect1;
        public string Effect2;
        public string Effect3;
        public long Flag;
        public int ItemID;
        public int JobFlag;
        public int Level;
        public int MaxUse;
        public int Need_SSkill1_Id;
        public int Need_SSkill1_Level;
        public int Need_SSkill2_Id;
        public int Need_SSkill2_Level;
        public int Num0;
        public int Num1;
        public int Num2;
        public int Num3;
        public int Position;
        public int Price;
        public int RareChance;
        public int RareOption;
        public int Set1;
        public int Set2;
        public int Set3;
        public int Set4;
        public int Set5;
        public string Smc;
        public int SubType;
        public int TexCol;
        public int TexID;
        public int TexRow;
        public int Type;
        public int Weight;
        public object Clone()
        {
            return base.MemberwiseClone();
        }

        public int syndicate_type;
        public int fortuneIndex;
        public int castleWar;
        public int syndicate_grade;
        public int JewelOptionLevel;
        public int JewelOptionType;
    }
}
