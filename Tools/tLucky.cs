using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LcDevPack_TeamDamonA.Tools
{
    public class tLucky
    {
        int a_index;
        string a_name;
        char a_enable;
        int a_random;
        public string list_name
        {
            get
            {
                return a_index.ToString() + " - " + a_name;
                
            }
        }
    }
    public class TLuckyResult : tLucky
    {
        int a_index, a_luckydraw_idx, a_item_idx, a_count, a_upgrade, a_prob, a_flag, a_category;
    }

    public class TLuckyNeed : tLucky
    {
        int a_index, a_luckydraw_idx, a_item_idx, a_count;
    }
}
