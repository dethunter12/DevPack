using LcDevPack_TeamDamonA.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LcDevPack_TeamDamonA
{
    public class LanguageHelper
    {
        private static Connection connection = new Connection();
        private static string language = ItemEditor2.connection.ReadSettings("Language");//dethunter12 test
        public static string StringFromLanguage()
        {
            if (language == "GER")
            {
                return "a_name_ger";
            }
            else if (language == "POL")
            {
                return "a_name_pld";
            }
            else if (language == "BRA")
            {
                return "a_name_brz";
            }
            else if (language == "RUS")
            {
                return "a_name_rus";
            }
            else if (language == "FRA")
            {
                return "a_name_frc";
            }
            else if (language == "ESP")
            {
                return "a_name_spn";
            }
            else if (language == "MEX")
            {
                return "a_name_mex";
            }
            else if (language == "THA")
            {
                return "a_name_thai";
            }
            else if (language == "ITA")
            {
                return "a_name_ita";
            }
            else if (language == "USA")
            {
                return "a_name_usa";
            }
            else
            {
                return null;
            }
        }

        public static string DescrFromLanguage()
        {
            if (language == "GER")
            {
                return "a_descr_ger";
            }
            else if (language == "POL")
            {
                return "a_descr_pld";
            }
            else if (language == "BRA")
            {
                return "a_descr_brz";
            }
            else if (language == "RUS")
            {
                return "a_descr_rus";
            }
            else if (language == "FRA")
            {
                return "a_descr_frc";
            }
            else if (language == "ESP")
            {
                return "a_descr_spn";
            }
            else if (language == "MEX")
            {
                return "a_descr_mex";
            }
            else if (language == "THA")
            {
                return "a_descr_thai";
            }
            else if (language == "ITA")
            {
                return "a_descr_ita";
            }
            else if (language == "USA")
            {
                return "a_descr_usa";
            }
            else
            {
                return null;
            }
        }
        public static string QDescFromLanguage() //dethunter12 4/11/2018
        {
            if (language == "GER")
            {
                return "a_desc_ger";
            }
            else if (language == "POL")
            {
                return "a_desc_pld";
            }
            else if (language == "BRA")
            {
                return "a_desc_brz";
            }
            else if (language == "RUS")
            {
                return "a_desc_rus";
            }
            else if (language == "FRA")
            {
                return "a_desc_frc";
            }
            else if (language == "ESP")
            {
                return "a_desc_spn";
            }
            else if (language == "MEX")
            {
                return "a_desc_mex";
            }
            else if (language == "THA")
            {
                return "a_desc_thai";
            }
            else if (language == "ITA")
            {
                return "a_desc_ita";
            }
            else if (language == "USA")
            {
                return "a_desc_usa";
            }
            else
            {
                return null;
            }
        }
        public static string QDesc2FromLanguage() //dethunter12 4/11/2018
        {
            if (language == "GER")
            {
                return "a_desc2_ger";
            }
            else if (language == "POL")
            {
                return "a_desc2_pld";
            }
            else if (language == "BRA")
            {
                return "a_desc2_brz";
            }
            else if (language == "RUS")
            {
                return "a_desc2_rus";
            }
            else if (language == "FRA")
            {
                return "a_desc2_frc";
            }
            else if (language == "ESP")
            {
                return "a_desc2_spn"; ;
            }
            else if (language == "MEX")
            {
                return "a_desc2_mex";
            }
            else if (language == "THA")
            {
                return "a_desc2_thai";
            }
            else if (language == "ITA")
            {
                return "a_desc2_ita";
            }
            else if (language == "USA")
            {
                return "a_desc2_usa";
            }
            else
            {
                return null;
            }
        }
        public static string QDesc3FromLanguage() //dethunter12 4/11/2018
        {
            if (language == "GER")
            {
                return "a_desc3_ger";
            }
            else if (language == "POL")
            {
                return "a_desc3_pld";
            }
            else if (language == "BRA")
            {
                return "a_desc3_brz";
            }
            else if (language == "RUS")
            {
                return "a_desc3_rus";
            }
            else if (language == "FRA")
            {
                return "a_desc3_frc";
            }
            else if (language == "ESP")
            {
                return "a_desc3_spn";
            }
            else if (language == "MEX")
            {
                return "a_desc3_mex";
            }
            else if (language == "THA")
            {
                return "a_desc3_thai";
            }
            else if (language == "ITA")
            {
                return "a_desc3_ita";
            }
            else if (language == "USA")
            {
                return "a_desc3_usa";
            }
            else
            {
                return null;
            }
        }
        public static string ActionDescFromLanguage()
        {
            if (language == "GER")
            {
                return "a_client_description_ger";
            }
            else if (language == "POL")
            {
                return "a_client_description_pld";
            }
            else if (language == "BRA")
            {
                return "a_client_description_brz";
            }
            else if (language == "RUS")
            {
                return "a_client_description_rus";
            }
            else if (language == "FRA")
            {
                return "a_client_description_frc";
            }
            else if (language == "ESP")
            {
                return "a_client_description_spn";
            }
            else if (language == "MEX")
            {
                return "a_client_description_mex";
            }
            else if (language == "THA")
            {
                return "a_client_description_thai";
            }
            else if (language == "ITA")
            {
                return "a_client_description_ita";
            }
            else if (language == "USA")
            {
                return "a_client_description_usa";
            }
            else
            {
                return null;
            }
        }
        public static string SkillDescFromLanguage() //dethunter12 4/12/2018
        {
            if (language == "GER")
            {
                return "a_client_description_ger";
            }
            else if (language == "POL")
            {
                return "a_client_description_pld";
            }
            else if (language == "BRA")
            {
                return "a_client_description_brz";
            }
            else if (language == "RUS")
            {
                return "a_client_description_rus";
            }
            else if (language == "FRA")
            {
                return "a_client_description_frc";
            }
            else if (language == "ESP")
            {
                return "a_client_description_spn";
            }
            else if (language == "MEX")
            {
                return "a_client_description_mex";
            }
            else if (language == "THA")
            {
                return "a_client_description_thai";
            }
            else if (language == "ITA")
            {
                return "a_client_description_ita";
            }
            else if (language == "USA")
            {
                return "a_client_description_usa";
            }
            else
            {
                return null;
            }
        }
        public static string SkillToolTipFromLanguage() //dethunter12 4/12/2018
        {

            if (language == "GER")
            {
                return "a_client_tooltip_ger";
            }
            else if (language == "POL")
            {
                return "a_client_tooltip_pld";
            }
            else if (language == "BRA")
            {
                return "a_client_tooltip_brz";
            }
            else if (language == "RUS")
            {
                return "a_client_tooltip_rus";
            }
            else if (language == "FRA")
            {
                return "a_client_tooltip_frc";
            }
            else if (language == "ESP")
            {
                return "a_client_tooltip_spn";
            }
            else if (language == "MEX")
            {
                return "a_client_tooltip_mex";
            }
            else if (language == "THA")
            {
                return "a_client_tooltip_thai";
            }
            else if (language == "ITA")
            {
                return "a_client_tooltip_ita";
            }
            else if (language == "USA")
            {
                return "a_client_tooltip_usa";
            }
            else
            {
                return null;
            }
        }
    }
}
