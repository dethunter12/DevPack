using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using LcDevPack_TeamDamonA.Tools;
using MySql.Data.MySqlClient;

namespace StringExporter
{
    public partial class FormExport : Form
    {
        private Int32 _BitString;
        private Int32 _BitNation;
        private UTIL.mysql _sql;
        private LcDevPack_TeamDamonA.Tools.MemoryWorker.mySQL _sql2;

        public FormExport()
        {
            InitializeComponent();

            // mysql 초기화
            _sql2 = new LcDevPack_TeamDamonA.Tools.MemoryWorker.mySQL();
            MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);

            OnInitNation();
        }

        private string EncodingString(string orig, int nNation)
        {
            Encoding encLatin_1 = Encoding.GetEncoding("ISO-8859-1");
            Encoding encOut;

            if (string.IsNullOrEmpty(strEncoding[nNation]))
                encOut = Encoding.Default;
            else
                encOut = Encoding.GetEncoding(strEncoding[nNation]);

            byte[] data = encLatin_1.GetBytes(orig.ToString());
            string str = encOut.GetString(data);

            string strOut = new string(str.ToCharArray());

            return strOut;
        }

        //----------------------------------------------------------------------------
        // args[0] - string 종류
        // args[1] - 국가
        // 
        //----------------------------------------------------------------------------
        private bool exportData(params object[] args)
        {
            int i;
            Int32 nString = Convert.ToInt32(args[0]);
            Int32 nNation = Convert.ToInt32(args[1]);
            string strOutName = args[2].ToString();
            string strIdxName = args[3].ToString();
            Int32 nOutCount = Convert.ToInt32(args[4]);

            if (nOutCount == 0)
                return false;

            string[] strOut = new string[nOutCount];

            for (i = 0; i < nOutCount; ++i)
            {
                strOut[i] = args[5 + i].ToString();
                strOut[i] += NationPostfix[nNation];
            }

            // Log
            _lb_output.Items.Add(string.Format("{0}", strOutName));

            _lb_output.Refresh();
            _lb_output.Invalidate();

            // 출력 경로를 얻는다.
            string path = Directory.GetCurrentDirectory();
            path += "\\";
            const string ini_name = "config.ini";

            UTIL.INI ini_reader = new UTIL.INI(path + ini_name);

            string strPathKey = "Path_Ship";

            if (_radio_pre.Checked == true)
                strPathKey = "Path_Pre";

            string strPath = ini_reader.GetIniValue(strPathKey, ((eNATION)(nNation)).ToString());

            strPath += string.Format("{0}{1}.lod", strOutName, OutputNationPost[nNation]);

            FileStream fs =
                new FileStream(strPath, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            DataTable dt = _sql2.dt;

            DataRow[] Rows = dt.Select(string.Format("{0} = MAX({0})", strIdxName));
            Int32 nMax = Convert.ToInt32(Rows[0][strIdxName]);

            bw.Write(dt.Rows.Count);
            bw.Write(nMax);

            Encoding encLatin_1 = Encoding.GetEncoding("ISO-8859-1");            

            foreach (DataRow row in dt.Rows)
            {
                bw.Write(Convert.ToInt32(row[strIdxName]));

                for (i = 0; i < nOutCount; ++i)
                {
                    string strTmp = row[strOut[i]].ToString();

                    string debug = EncodingString(strTmp, (int)eNATION.DEV);
                    byte[] data = encLatin_1.GetBytes(strTmp);

                    bw.Write(data.Length);
                    if (data.Length > 0)
                        bw.Write(data);
                }
            }

            bw.Close();
            fs.Close();

            return true;
        }

        private void OnExport(object sender, EventArgs e)
        {
            int i, nString;

            _lb_output.Items.Clear();

            _lb_output.Items.Add("Exporting !");

            _lb_output.Refresh();
            _lb_output.Invalidate();

            CheckBox[] chkbox = new CheckBox[(int)eSTRING.MAX]
            {
                _chk_string, _chk_help1,
                _chk_item, _chk_setitem,
                _chk_option, _chk_opt_rare,
                _chk_npcname,
                _chk_quest,
                _chk_skill, _chk_sskill,
                _chk_action,
                _chk_combo,
                _chk_affinity,
                _chk_lacarette,
                _chk_itemcollection
            };

            CheckBox[] chk_nation = new CheckBox[(int)eNATION.MAX]
            {
                _chk_nation_dev,
                _chk_nation_ger, _chk_nation_fra, _chk_nation_ita, _chk_nation_pol, _chk_nation_esp,
                _chk_nation_bra, _chk_nation_mex,
                _chk_nation_rus,
                _chk_nation_usa,
                _chk_nation_tha,
                _chk_nation_uk,
            };


            _BitString = 0;
            _BitNation = 0;

            for (i = 0; i < (int)eSTRING.MAX; ++i)
            {
                if (chkbox[i].Checked == true)
                    _BitString |= (1 << i);
            }

            string path = Directory.GetCurrentDirectory();
            path += "\\";

            const string ini_name = "config.ini";

            UTIL.INI ini_reader = new UTIL.INI(path + ini_name);
            string strRet, strNation;

            string strPathKey = "Path_Ship";

            if (_radio_pre.Checked == true)
                strPathKey = "Path_Pre";

            for (i = 0; i < (int)eNATION.MAX; ++i)
            {
                if (chk_nation[i].Checked == true)
                {
                    _BitNation |= (1 << i);

                    strNation = ((eNATION)(i)).ToString();
                    strRet = ini_reader.GetIniValue(strPathKey, strNation);

                    if (strRet == string.Empty)
                    {
                        using (FolderBrowserDialog dialog = new FolderBrowserDialog())
                        {
                            dialog.Description = strNation + " Set Data Path";
                            dialog.ShowNewFolderButton = false;
                            dialog.SelectedPath = path;

                            if (dialog.ShowDialog() == DialogResult.OK)
                            {
                                ini_reader.SetIniValue(strPathKey, ((eNATION)(i)).ToString(), dialog.SelectedPath + "\\");
                            }
                        }
                    }
                }
            }

            for (nString = 0; nString < (int)eSTRING.MAX; ++nString)
            {
                if ((_BitString & (1 << nString)) != 0)
                {
                    QueryProc(nString);

                    for (i = 0; i < (int)eNATION.MAX; ++i)
                    {
                        if ((_BitNation & (1 << i)) != 0)
                        {
                            switch (nString)
                            {
                                case (int)eSTRING.STRING:
                                    exportData(nString, i, "strClient", "a_index", 1, "a_string");
                                    break;
                                case (int)eSTRING.HELP1:
                                    exportData(nString, i, "strHelp", "a_index", 2, "a_name", "a_desc");
                                    break;
                                case (int)eSTRING.ITEM:
                                    exportData(nString, i, "strItem", "a_index", 2, "a_name", "a_descr");
                                    break;
                                case (int)eSTRING.ITEM_SET:
                                    exportData(nString, i, "strSetItem", "a_set_idx", 1, "a_set_name");
                                    break;
                                case (int)eSTRING.OPTION:
                                    exportData(nString, i, "strOption", "a_index", 1, "a_name");
                                    break;
                                case (int)eSTRING.OPTION_RARE:
                                    exportData(nString, i, "strRareOption", "a_index", 1, "a_prefix");
                                    break;
                                case (int)eSTRING.NPC_NAME:
                                    // descr ??
                                    exportData(nString, i, "strNpcName", "a_index", 2, "a_name", "a_descr");
                                    break;
                                case (int)eSTRING.QUEST:
                                    exportData(nString, i, "strQuest", "a_index", 4, "a_name", "a_desc", "a_desc2", "a_desc3");
                                    break;
                                case (int)eSTRING.SKILL:
                                    exportData(nString, i, "strSkill", "a_index", 3, "a_name", "a_client_description", "a_client_tooltip");
                                    break;
                                case (int)eSTRING.SKILL_SPECIAL:
                                    exportData(nString, i, "strSSkill", "a_index", 2, "a_name", "a_desc");
                                    break;
                                case (int)eSTRING.ACTION:
                                    exportData(nString, i, "strAction", "a_index", 2, "a_name", "a_client_description");
                                    break;
                                case (int)eSTRING.COMBO:
                                    exportData(nString, i, "strCombo", "a_index", 1, "a_name");
                                    break;
                                case (int)eSTRING.AFFINITY:
                                    exportData(nString, i, "strAffinity", "a_index", 1, "a_name");
                                    break;
                                case (int)eSTRING.LACARETTE:
                                    exportData(nString, i, "strLacarette", "a_index", 1, "a_name");
                                    break;
                                case (int)eSTRING.ITEMCOLLECTION:
                                    exportData(nString, i, "strItemCollection", "a_theme", 2, "a_theme_string", "a_desc_string");
                                    break;
                            }

                        }
                    }   // for (i
                }
            }   // for (nString

            _lb_output.SelectedIndex = _lb_output.Items.Add("Exported Completed!");
        
    }
    }
}
