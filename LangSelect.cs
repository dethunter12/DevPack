using LcDevPack_TeamDamonA.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA
{
    public partial class LangSelect : Form
    {
        public static Connection connection = new Connection();
        private string language = LangSelect.connection.ReadSettings("Language"); //read the language from the config
        public string Language = ""; //to create an empty string
        private string Host = LangSelect.connection.ReadSettings("Host"); //read the host from the config
        private string User = LangSelect.connection.ReadSettings("User"); //read the user from the config
        private string Password = LangSelect.connection.ReadSettings("Password"); //read the password from the config
        private string Database = LangSelect.connection.ReadSettings("Database"); //read the database from the config
        private string ClientPath = LangSelect.connection.ReadSettings("ClientPath"); //read the clientpath from the config
        string buffer = "Rb"; // to use the string to get the name correct on read
        public LangSelect()
        {
            InitializeComponent();
           
        }
        private void LoadColorFromConfig()
        {
            if (RbBRA.Text == language)
            {
                RbBRA.Checked = true;
                RbESP.Checked = false;
                RbFRA.Checked = false;
                RbGER.Checked = false;
                RbITA.Checked = false;
                RbMEX.Checked = false;
                RbPOL.Checked = false;
                RbRUS.Checked = false;
                RbTHA.Checked = false;
                RbUSA.Checked = false;
            }
            else if (RbESP.Text == language)
            {
                RbBRA.Checked = false;
                RbESP.Checked = true;
                RbFRA.Checked = false;
                RbGER.Checked = false;
                RbITA.Checked = false;
                RbMEX.Checked = false;
                RbPOL.Checked = false;
                RbRUS.Checked = false;
                RbTHA.Checked = false;
                RbUSA.Checked = false;
            }
            else if (RbFRA.Text == language)
            {
                RbBRA.Checked = false;
                RbESP.Checked = false;
                RbFRA.Checked = true;
                RbGER.Checked = false;
                RbITA.Checked = false;
                RbMEX.Checked = false;
                RbPOL.Checked = false;
                RbRUS.Checked = false;
                RbTHA.Checked = false;
                RbUSA.Checked = false;
            }
            else if (RbGER.Text == language)
            {
                RbBRA.Checked = false;
                RbESP.Checked = false;
                RbFRA.Checked = false;
                RbGER.Checked = true;
                RbITA.Checked = false;
                RbMEX.Checked = false;
                RbPOL.Checked = false;
                RbRUS.Checked = false;
                RbTHA.Checked = false;
                RbUSA.Checked = false;
            }
            else if (RbITA.Text == language)
            {
                RbBRA.Checked = false;
                RbESP.Checked = false;
                RbFRA.Checked = false;
                RbGER.Checked = false;
                RbITA.Checked = true;
                RbMEX.Checked = false;
                RbPOL.Checked = false;
                RbRUS.Checked = false;
                RbTHA.Checked = false;
                RbUSA.Checked = false;
            }

            else if (RbMEX.Text == language)
            {
                RbBRA.Checked = false;
                RbESP.Checked = false;
                RbFRA.Checked = false;
                RbGER.Checked = false;
                RbITA.Checked = false;
                RbMEX.Checked = true;
                RbPOL.Checked = false;
                RbRUS.Checked = false;
                RbTHA.Checked = false;
                RbUSA.Checked = false;
            }

            else if (RbPOL.Text == language)
            {
                RbBRA.Checked = false;
                RbESP.Checked = false;
                RbFRA.Checked = false;
                RbGER.Checked = false;
                RbITA.Checked = false;
                RbMEX.Checked = false;
                RbPOL.Checked = true;
                RbRUS.Checked = false;
                RbTHA.Checked = false;
                RbUSA.Checked = false;
            }

            else if (RbRUS.Text == language)
            {
                RbBRA.Checked = false;
                RbESP.Checked = false;
                RbFRA.Checked = false;
                RbGER.Checked = false;
                RbITA.Checked = false;
                RbMEX.Checked = false;
                RbPOL.Checked = false;
                RbRUS.Checked = true;
                RbTHA.Checked = false;
                RbUSA.Checked = false;
            }

            else if (RbTHA.Text == language)
            {
                RbBRA.Checked = false;
                RbESP.Checked = false;
                RbFRA.Checked = false;
                RbGER.Checked = false;
                RbITA.Checked = false;
                RbMEX.Checked = false;
                RbPOL.Checked = false;
                RbRUS.Checked = false;
                RbTHA.Checked = true;
                RbUSA.Checked = false;
            }
            else if (RbUSA.Text == language)
            {
                RbBRA.Checked = false;
                RbESP.Checked = false;
                RbFRA.Checked = false;
                RbGER.Checked = false;
                RbITA.Checked = false;
                RbMEX.Checked = false;
                RbPOL.Checked = false;
                RbRUS.Checked = false;
                RbTHA.Checked = false;
                RbUSA.Checked = true;
            }
            else if (language != RbBRA.Text && language != RbESP.Text && language != RbFRA.Text && language != RbGER.Text && language != RbITA.Text && language != RbMEX.Text && language != RbPOL.Text && language != RbRUS.Text && language != RbTHA.Text && language != RbUSA.Text)
            {
                RbUSA.Checked = true;
                MessageBox.Show("please check your config for proper language format");
            }

        }

        private void BtnSave_Click(object sender, EventArgs e) //dethunter12 test write function based off language select
        {
            if (RbBRA.Checked == true) // to test if the radio button is checked or not
            {
                Language = RbBRA.Text; //ifchecked write the name to the variable
            }
            else if (RbESP.Checked == true)
            {
                Language = RbESP.Text;
            }
            else if (RbFRA.Checked == true)
            {
                Language = RbFRA.Text;
            }
            else if (RbGER.Checked == true)
            {
                Language = RbGER.Text;
            }
            else if (RbITA.Checked == true)
            {
                Language = RbITA.Text;
            }
            else if (RbMEX.Checked == true)
            {
                Language = RbMEX.Text;
            }
            else if (RbPOL.Checked == true)
            {
                Language = RbPOL.Text;
            }
            else if (RbRUS.Checked == true)
            {
                Language = RbRUS.Text;
            }
            else if (RbTHA.Checked == true)
            {
                Language = RbTHA.Text;
            }
            else if (RbUSA.Checked == true )
            {
                Language = RbUSA.Text;
            }
            try
            {
                TextWriter sr = new StreamWriter("Config//Settings.cfg");
                sr.WriteLine("## MYSQL");
                sr.WriteLine("Episode=EP4");
                sr.WriteLine("ClientPath=" + ClientPath);
                sr.WriteLine("## MYSQL");
                sr.WriteLine("SQL_HOST=" + Host);
                sr.WriteLine("SQL_USER=" + User);
                sr.WriteLine("SQL_PASSWORD=" + Password);
                sr.WriteLine("SQL_DATABASE=" + Database);
                sr.WriteLine("Language=" + Language);
                sr.WriteLine("##language list");
                sr.WriteLine("GER");
                sr.WriteLine("POL");
                sr.WriteLine("BRA");
                sr.WriteLine("RUS");
                sr.WriteLine("FRA");
                sr.WriteLine("ESP");
                sr.WriteLine("MEX");
                sr.WriteLine("THA");
                sr.WriteLine("ITA");
                sr.WriteLine("USA");

                sr.Close();
                int num4 = (int)new CustomMessage("Saved!").ShowDialog();
            }
            catch
            {
                int num4 = (int)new CustomMessage("failed :(").ShowDialog();
            }

        }

        private void LangSelect_Load(object sender, EventArgs e)
        {
            LoadColorFromConfig();
        }
    }
}
