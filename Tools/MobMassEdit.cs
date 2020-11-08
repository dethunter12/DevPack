using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools
{
    public partial class MobMassEdit : Form
    {
        private string Host = MobEditor.connection.ReadSettings("Host");
        private string User = MobEditor.connection.ReadSettings("User");
        private string Password = MobEditor.connection.ReadSettings("Password");
        private string Database = MobEditor.connection.ReadSettings("Database");
        private DatabaseHandle databaseHandle = new DatabaseHandle();
        public MobMassEdit()
        {
            InitializeComponent();
        }
    }
}
