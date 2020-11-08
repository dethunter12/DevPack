using System;
using System.IO;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools
{
    public partial class Settings : Form
    {
        public string FolderPath = "";
        public string buffer = "\\";
        public static Connection connection = new Connection();
        private string language = Settings.connection.ReadSettings("Language"); //read the language from the config
        private string Host = Settings.connection.ReadSettings("Host"); //read the host from the config
        private string User = Settings.connection.ReadSettings("User"); //read the user from the config
        private string Password = Settings.connection.ReadSettings("Password"); //read the password from the config
        private string Database = Settings.connection.ReadSettings("Database"); //read the database from the config
        private string ClientPath = Settings.connection.ReadSettings("ClientPath"); //read the clientpath from the config
        private string DBdatabase = Settings.connection.ReadSettings("DB_Database");
        public Settings()
        {
            InitializeComponent();
        }



        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                FolderPath = fbd.SelectedPath.ToString(); //store the folderpath as a string
            TbClientPath.Text = FolderPath + buffer; // to load the information to textbox
        }

        private void CBClientPath_CheckedChanged(object sender, EventArgs e)
        {
            if (CBClientPath.Checked == true)
            {
                TbClientPath.PasswordChar = '●';
            }
            else if (CBClientPath.Checked == false)
            {
                TbClientPath.PasswordChar = '\0';
            }
            
        }

        private void CBHost_CheckedChanged(object sender, EventArgs e)
        {
            if (CBHost.Checked == true)
            {
                TbSqlHost.PasswordChar = '●';
            }
            else if (CBHost.Checked == false)
            {
                TbSqlHost.PasswordChar = '\0';
            }
        }

        private void CBUser_CheckedChanged(object sender, EventArgs e)
        {
            if (CBUser.Checked == true)
            {
                TbSqlUser.PasswordChar = '●';
            }
            else if (CBUser.Checked == false)
            {
                TbSqlUser.PasswordChar = '\0';
            }
        }

        private void CBPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CBPass.Checked == true)
            {
                TbSqlPassword.PasswordChar = '●';
            }
            else if (CBPass.Checked == false)
            {
                TbSqlPassword.PasswordChar = '\0';
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                TbSqlDatabase.PasswordChar = '●';
            }
            else if (checkBox1.Checked == false)
            {
                TbSqlDatabase.PasswordChar = '\0';
            }
        }

        private void Settings_Load(object sender, EventArgs e)

        {
            ComboBoxLoad(); //load combo box items at startup
                            //dethunter12 loading the textbox values to match the config file
            TbClientPath.Text = ClientPath;
            TbSqlDatabase.Text = Database;
            TbSqlHost.Text = Host;
            TbSqlPassword.Text = Password;
            TbSqlUser.Text = User;
            TbSqlDb.Text = DBdatabase; //dethunter12 add 6/1/2020
            if (language == "GER") // to load the language from reading the file then loading that value into the combobox's Item list
            {
                CbLangSelect.SelectedIndex = 0;
            }
            else if (language == "POL")
            {
                CbLangSelect.SelectedIndex = 1;
            }
            else if (language == "BRA")
            {
                CbLangSelect.SelectedIndex = 2;
            }
            else if (language == "RUS")
            {
                CbLangSelect.SelectedIndex = 3;
            }
            else if (language == "FRA")
            {
                CbLangSelect.SelectedIndex = 4;
            }
            else if (language == "ESP")
            {
                CbLangSelect.SelectedIndex = 5;
            }
            else if (language == "MEX")
            {
                CbLangSelect.SelectedIndex = 6;
            }
            else if (language == "THA")
            {
                CbLangSelect.SelectedIndex = 7;
            }
            else if (language == "ITA")
            {
                CbLangSelect.SelectedIndex = 8;
            }
            else if (language == "USA")
            {
                CbLangSelect.SelectedIndex = 9;
            }

        }

        private void ComboBoxLoad()
        {
            CbLangSelect.Items.AddRange(new object[10]
      {
         "1 - GER",
         "2 - POL",
         "3 - BRA",
         "4 - RUS",
         "5 - FRA",
         "6 - ESP",
         "7 - MEX",
         "8 - THA",
         "9 - ITA",
         "10 - USA"
      });
        }

        public int GetIndexByComboBox(string comboBox)
        {
            try
            {
                return Convert.ToInt32(comboBox.Split(' ')[0]);
            }
            catch
            {
                return 0;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                TextWriter sr = new StreamWriter("Config//Settings.cfg");
                sr.WriteLine("## MYSQL");
                sr.WriteLine("Episode=EP4");
                sr.WriteLine("ClientPath=" + TbClientPath.Text);
                sr.WriteLine("## MYSQL");
                sr.WriteLine("SQL_HOST=" + TbSqlHost.Text);
                sr.WriteLine("SQL_USER=" + TbSqlUser.Text);
                sr.WriteLine("SQL_PASSWORD=" + TbSqlPassword.Text);
                sr.WriteLine("SQL_DATABASE=" + TbSqlDatabase.Text);
                sr.WriteLine("SQL_DB_DATABASE=" + TbSqlDb.Text); //dethunter12 3/24/2019
                if (CbLangSelect.SelectedIndex == 0)
                {
                    sr.WriteLine("Language=" + "GER");
                }
                else if (CbLangSelect.SelectedIndex == 1)
                {
                    sr.WriteLine("Language=" + "POL");
                }
                else if (CbLangSelect.SelectedIndex == 2)
                {
                    sr.WriteLine("Language=" + "BRA");
                }
                else if (CbLangSelect.SelectedIndex == 3)
                {
                    sr.WriteLine("Language=" + "RUS");
                }
                else if (CbLangSelect.SelectedIndex == 4)
                {
                    sr.WriteLine("Language=" + "FRA");
                }
                else if (CbLangSelect.SelectedIndex == 5)
                {
                    sr.WriteLine("Language=" + "ESP");
                }
                else if (CbLangSelect.SelectedIndex == 6)
                {
                    sr.WriteLine("Language=" + "MEX");
                }
                else if (CbLangSelect.SelectedIndex == 7)
                {
                    sr.WriteLine("Language=" + "THA");
                }
                else if (CbLangSelect.SelectedIndex == 8)
                {
                    sr.WriteLine("Language=" + "ITA");
                }
                else if (CbLangSelect.SelectedIndex == 9)
                {
                    sr.WriteLine("Language=" + "USA");
                }
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

        private void CbDb_CheckedChanged(object sender, EventArgs e) //dethunter12 3/24/2019
        {
            if (CbDb.Checked == true)
            {
                TbSqlDb.PasswordChar = '●';
            }
            else if (CbDb.Checked == false)
            {
                TbSqlDb.PasswordChar = '\0';
            }
        }
    }
}
