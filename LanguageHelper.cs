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
            switch (language)
            {
                case "GER":
                    return "a_name_ger";
                case "POL":
                    return "a_name_pld";
                case "BRA":
                    return "a_name_brz";
                case "RUS":
                    return "a_name_rus";
                case "FRA":
                    return "a_name_frc";
                case "ESP":
                    return "a_name_spn";
                case "MEX":
                    return "a_name_mex";
                case "THA":
                    return "a_name_thai";
                case "ITA":
                    return "a_name_ita";
                case "USA":
                    return "a_name_usa";
                default:
                    return null;
            }
        }

        public static string DescrFromLanguage()
        {
            switch (language)
            {
                case "GER":
                    return "a_descr_ger";
                case "POL":
                    return "a_descr_pld";
                case "BRA":
                    return "a_descr_brz";
                case "RUS":
                    return "a_descr_rus";
                case "FRA":
                    return "a_descr_frc";
                case "ESP":
                    return "a_descr_spn";
                case "MEX":
                    return "a_descr_mex";
                case "THA":
                    return "a_descr_thai";
                case "ITA":
                    return "a_descr_ita";
                case "USA":
                    return "a_descr_usa";
                default:
                    return null;
            }         
        }

        public static string QDescFromLanguage() //dethunter12 4/11/2018
        {
            switch (language)
            {
                case "GER":
                    return "a_desc_ger";
                case "POL":
                    return "a_desc_pld";
                case "BRA":
                    return "a_desc_brz";
                case "RUS":
                    return "a_desc_rus";
                case "FRA":
                    return "a_desc_frc";
                case "ESP":
                    return "a_desc_spn";
                case "MEX":
                    return "a_desc_mex";
                case "THA":
                    return "a_descr_thai";
                case "ITA":
                    return "a_desc_ita";
                case "USA":
                    return "a_desc_usa";
                default:
                    return null;
            }            
        }

        public static string QDesc2FromLanguage() //dethunter12 4/11/2018
        {
            switch (language)
            {
                case "GER":
                    return "a_desc2_ger";
                case "POL":
                    return "a_desc2_pld";
                case "BRA":
                    return "a_desc2_brz";
                case "RUS":
                    return "a_desc2_rus";
                case "FRA":
                    return "a_desc2_frc";
                case "ESP":
                    return "a_desc2_spn";
                case "MEX":
                    return "a_desc2_mex";
                case "THA":
                    return "a_descr_thai";
                case "ITA":
                    return "a_desc2_thai";
                case "USA":
                    return "a_desc2_usa";
                default:
                    return null;
            }          
        }
        public static string QDesc3FromLanguage() //dethunter12 4/11/2018
        {
            switch (language)
            {
                case "GER":
                    return "a_desc3_ger";
                case "POL":
                    return "a_desc3_pld";
                case "BRA":
                    return "a_desc3_brz";
                case "RUS":
                    return "a_desc3_rus";
                case "FRA":
                    return "a_desc3_frc";
                case "ESP":
                    return "a_desc3_spn";
                case "MEX":
                    return "a_desc3_mex";
                case "THA":
                    return "a_desc3_thai";
                case "ITA":
                    return "a_desc3_ita";
                case "USA":
                    return "a_desc3_usa";
                default:
                    return null;
            }           
        }
        public static string ActionDescFromLanguage()
        {
            switch (language)
            {
                case "GER":
                    return "a_client_description_ger";
                case "POL":
                    return "a_client_description_pld";
                case "BRA":
                    return "a_client_description_brz";
                case "RUS":
                    return "a_client_description_rus";
                case "FRA":
                    return "a_client_description_frc";
                case "ESP":
                    return "a_client_description_spn";
                case "MEX":
                    return "a_client_description_mex";
                case "THA":
                    return "a_client_description_thai";
                case "ITA":
                    return "a_client_description_ita";
                case "USA":
                    return "a_client_description_usa";
                default:
                    return null;
            }
        }

        public static string SkillDescFromLanguage() //dethunter12 4/12/2018
        {
            switch (language)
            {
                case "GER":
                    return "a_client_description_ger";
                case "POL":
                    return "a_client_description_pld";
                case "BRA":
                    return "a_client_description_brz";
                case "RUS":
                    return "a_client_description_rus";
                case "FRA":
                    return "a_client_description_frc";
                case "ESP":
                    return "a_client_description_spn";
                case "MEX":
                    return "a_client_description_mex";
                case "THA":
                    return "a_client_description_thai";
                case "ITA":
                    return "a_client_description_ita";
                case "USA":
                    return "a_client_description_usa";
                default:
                    return null;
            }            
        }

        public static string SkillToolTipFromLanguage() //dethunter12 4/12/2018
        {
            switch (language)
            {
                case "GER":
                    return "a_client_tooltip_ger";
                case "POL":
                    return "a_client_tooltip_pld";
                case "BRA":
                    return "a_client_tooltip_brz";
                case "RUS":
                    return "a_client_tooltip_rus";
                case "FRA":
                    return "a_client_tooltip_frc";
                case "ESP":
                    return "a_client_tooltip_spn";
                case "MEX":
                    return "a_client_tooltip_mex";
                case "THA":
                    return "a_client_tooltip_thai";
                case "ITA":
                    return "a_client_tooltip_ita";
                case "USA":
                    return "a_client_tooltip_usa";
                default:
                    return null;
            }       
        }
    }
}
