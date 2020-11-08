
//#define     G_DEV
#define     G_GAMIGO
//#define     G_THAI

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using LcDevPack_TeamDamonA;
using MySql.Data.MySqlClient;

namespace StringExporter
{
    partial class FormExport
    {
        public static Connection connection = new Connection();
        private string Host = FormExport.connection.ReadSettings("Host");
        private string User = FormExport.connection.ReadSettings("User");
        private string Password = FormExport.connection.ReadSettings("Password");
        private string Database = FormExport.connection.ReadSettings("Database");
        private void OnInitNation()
        {
#if     G_DEV
            _picbox.Hide();
            _sql.Connect("14.63.127.133", "itemtool", "roqkf2xla", "newproject_data");
#else   // G_DEV

         //   _group_output.Hide();
            _radio_ship.Checked = true;

#   if   G_GAMIGO
            MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);

            //  _picbox.Hide();

            _chk_nation_dev.Hide();

            _btn_select_all.Hide();
          //  _group_thai.Hide();

#   elif   G_THAI
            _sql.Connect("14.63.127.133", "lclocalthai", "lclocalthai874", "newproject_data");

            _picbox.Location = new Point(336, 15);

            _group_nation.Hide();            
            _group_output.Hide();

            _chk_nation_tha.Checked = true;            
#   endif

#endif  // G_DEVs
        }
    }
}
