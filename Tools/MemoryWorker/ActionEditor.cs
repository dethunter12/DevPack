using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools.MemoryWorker
{
    public partial class ActionEditor : Form
    {
        public static Connection connection = new Connection();
        public string ActionString = connection.ReadSettings("ClientPath") + "Local\\us\\String\\StrAction.lod";
        private string Host = Settings.connection.ReadSettings("Host"); //read the host from the config
        private string User = Settings.connection.ReadSettings("User"); //read the user from the config
        private string Password = Settings.connection.ReadSettings("Password"); //read the password from the config
        private string Database = Settings.connection.ReadSettings("Database"); //read the database from the config
        public ActionEditor()
        {
            InitializeComponent();
        }
        public void LoadData()
        {

        }
        private void ActionEditor_Load(object sender, EventArgs e)
        {

        }
    }
}
