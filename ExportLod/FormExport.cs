using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LodExporter
{
    public partial class FormExport : Form
    {
        public UTIL.DBConfig _db_config;

        public FormExport()
        {
            InitializeComponent();
            _db_config = new UTIL.DBConfig();

            // 버전 선택
            int nCount = _db_config.GetVerMax();

            for (int i = 0; i < nCount; ++i)
            {
                _combo_ver.Items.Add(_db_config.GetStrVer(i));
            }

            _combo_ver.SelectedIndex = 0;
        }

        private void FormExport_Load(object sender, EventArgs e)
        {

        }

        private void _chk_map_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
