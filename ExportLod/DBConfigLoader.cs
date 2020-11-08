using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using LcDevPack_TeamDamonA.Tools;
using LcDevPack_TeamDamonA;

namespace UTIL
{

    public class DBConfig
    {
            public static Connection connection = new Connection();
    private string Host = DBConfig.connection.ReadSettings("Host");
    private string User = DBConfig.connection.ReadSettings("User");
    private string Password = DBConfig.connection.ReadSettings("Password");
    private string Database = DBConfig.connection.ReadSettings("Database");
    private DatabaseHandle databaseHandle = new DatabaseHandle();
        public string[] _config_DB = 
        {
            connection.ReadSettings("Host"),
            connection.ReadSettings("User"),
            connection.ReadSettings("Password"),
            connection.ReadSettings("Database")
        };

        private string[] _strPreFix;
        private string[] _strLocal;
        private string[] _strVersion;
        private string[] _strLang;
        private int _nLocalMax;
        private int _nPrefixMax;
        private int _nVerMax;
        private int _nLangMax;
               
        public enum eCONFIG_DB
        {
            eIP,
            eACCOUNT,
            ePASSWD,
            eTABLE,
            eCONFIG_MAX,
        }

        public enum eSECTION // InI 파일 색션
        {
            LOCAL,
            DB_PREFIX,
            VERSION,
            LANGUAGE,
            MAX,
        }

        public enum eKEY // InI 파일의 key 인덱스
        {
            LOCAL,
            PREFIX,
            VER,
            LANG,
            MAX
        }

        public DBConfig()
        {
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo Parentpath = Directory.GetParent(path);// 공용으로 사용하기 위하여 한폴더 위로
            const string ini_name = "\\DB_Config.ini";

            ConfigLoad(Parentpath + ini_name);
        }

        public string GetTable(int nLocal, int nVer)
        {
            if (nLocal >= 0 || nLocal < _nPrefixMax)
            {
                if (nVer >= 0 || nVer < _nVerMax)
                {
                    return _config_DB[(int)eCONFIG_DB.eTABLE] + _strPreFix[nLocal] + _strVersion[nVer];
                }
            }
            return "";
        }

        public string GetStrVer(int nVer)
        {
            if (nVer >= 0 || nVer < _nVerMax)
                return _strVersion[nVer];

            return "";
        }

        public string GetStrLang(int nIdx)
        {
            if (nIdx >= 0 || nIdx < _nVerMax)
                return _strLang[nIdx];

            return "";
        }

        public string GetStrLocal(int nIdx)
        {
            if (nIdx >= 0 || nIdx < _nLocalMax)
                return _strLocal[nIdx];

            return "";
        }

        public int GetLocalMax()
        {
            return _nLocalMax;
        }

        public int GetVerMax()
        {
            return _nVerMax;
        }

        public int GetLangMax()
        {
            return _nLangMax;
        }

        public bool ConfigLoad(string fileName)
        {
            // ini 파일 읽기
            UTIL.INI ini = new UTIL.INI(fileName);
            int i;
            string strKey;

            int[] nMax = new int[(int)eSECTION.MAX]
            {
                _nLocalMax,
                _nPrefixMax,
                _nVerMax,
                _nLangMax
            };

            // Count
            for(i = 0; i < (int)eSECTION.MAX; ++i)
	        {
                nMax[i] = Convert.ToInt32(ini.GetIniValue(((eSECTION)(i)).ToString(), "Count"));
            }

            _nLocalMax = nMax[(int)eSECTION.LOCAL];
            _nPrefixMax = nMax[(int)eSECTION.DB_PREFIX];
            _nVerMax = nMax[(int)eSECTION.VERSION];
            _nLangMax = nMax[(int)eSECTION.LANGUAGE];

            // 로컬 스트링
            if (_nLocalMax > 0)
			    _strLocal = new string[nMax[(int)eSECTION.LOCAL]];

            for (i = 0; i < _nLocalMax; ++i)
		    {
                strKey = string.Format("{0}{1}", eKEY.LOCAL.ToString(), i);
                _strLocal[i] = ini.GetIniValue(eSECTION.LOCAL.ToString(), strKey);
		    }
	        
            // 프리픽스 스트링
            if (_nPrefixMax > 0)
                _strPreFix = new string[nMax[(int)eSECTION.DB_PREFIX]];

            for (i = 0; i < _nPrefixMax; ++i)
            {
                strKey = string.Format("{0}{1}", eKEY.PREFIX.ToString(), i);
                _strPreFix[i] = ini.GetIniValue(eSECTION.DB_PREFIX.ToString(), strKey);
            }

            // 버전 스트링
            if (_nVerMax > 0)
                _strVersion = new string[nMax[(int)eSECTION.VERSION]];

            for (i = 0; i < _nVerMax; ++i)
            {
                strKey = string.Format("{0}{1}", eKEY.VER.ToString(), i);
                _strVersion[i] = ini.GetIniValue(eSECTION.VERSION.ToString(), strKey);
            }

            // 랭귀지 스트링
            if (_nLangMax > 0)
                _strLang = new string[nMax[(int)eSECTION.LANGUAGE]];

            for (i = 0; i < _nLangMax; ++i)
            {
                strKey = string.Format("{0}{1}", eKEY.LANG.ToString(), i);
                _strLang[i] = ini.GetIniValue(eSECTION.LANGUAGE.ToString(), strKey);
            }

            return true;
        }
    }
}
