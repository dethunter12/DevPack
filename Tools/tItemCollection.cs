using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LcDevPack_TeamDamonA.Tools
{
   public class tItemCollection
    {
        public int a_theme;
        public int a_category;
        public string a_theme_string;
        public string a_descr_string;
        public bool a_enable;
        public int a_id, a_row, a_col;
        public int a_need1_type, a_need1_index, a_need1_num;
        public int a_need2_type, a_need2_index, a_need2_num;
        public int a_need3_type, a_need3_index, a_need3_num;
        public int a_need4_type, a_need4_index, a_need4_num;
        public int a_need5_type, a_need5_index, a_need5_num;
        public int a_need6_type, a_need6_index, a_need6_num;
        public int a_result_type;
        public int a_result_index;
        public int a_result_num;
        public string Menu;
        public tItemCollection Clone()
        {
            return (tItemCollection)MemberwiseClone();
        }
    
    }
    
}
