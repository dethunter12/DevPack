using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LcDevPack_TeamDamonA.Tools.MemoryWorker.Item;
using StringExporter;

namespace LcDevPack_TeamDamonA.Tools.MemoryWorker.rareoption
{
    public partial class RareOptionEditor : Form
    {
        private string language = ItemAll.connection.ReadSettings("Language");//dethunter12 language selection
        private string namee; //dethunter12 stringfrom lang modify
        public RareOptionEditor()
        {
            InitializeComponent();

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
        } //dethunter12 add 6/3/2019

        private void Update_Probability_Text() //dethunter12 4/12/2018
        {
            if (od0.Text != "" && int.Parse(od0.Text) >= 0)
            {

                lblProb1.Text = "";
                decimal result = ((int.Parse(od0.Text) * 100m) / 10000m);
                lblProb1.Text = Convert.ToString(result) + "%";
            }
            if (od1.Text != "" && int.Parse(od1.Text) >= 0)
            {

                lblProb2.Text = "";
                decimal result = ((int.Parse(od1.Text) * 100m) / 10000m);
                lblProb2.Text = Convert.ToString(result) + "%";
            }
            if (od2.Text != "" && int.Parse(od2.Text) >= 0)
            {

                lblProb3.Text = "";
                decimal result = ((int.Parse(od2.Text) * 100m) / 10000m);
                lblProb3.Text = Convert.ToString(result) + "%";
            }
            if (od3.Text != "" && int.Parse(od3.Text) >= 0)
            {

                lblProb4.Text = "";
                decimal result = ((int.Parse(od3.Text) * 100m) / 10000m);
                lblProb4.Text = Convert.ToString(result) + "%";
            }
            if (od4.Text != "" && int.Parse(od4.Text) >= 0 )
            {

                lblProb5.Text = "";
                decimal result = ((int.Parse(od4.Text) * 100m) / 10000m);
                lblProb5.Text = Convert.ToString(result) + "%";
            }
            if (od5.Text != "" && int.Parse(od5.Text) >= 0)
            {

                lblProb6.Text = "";
                decimal result = ((int.Parse(od5.Text) * 100m) / 10000m);
                lblProb6.Text = Convert.ToString(result) + "%";
            }
            if (od6.Text != "" && int.Parse(od6.Text) >= 0)
            {

                lblProb7.Text = "";
                decimal result = ((int.Parse(od6.Text) * 100m) / 10000m);
                lblProb7.Text = Convert.ToString(result) + "%";
            }
            if (od7.Text != "" && (int.Parse(od7.Text) >= 0))
            {

                lblProb8.Text = "";
                decimal result = ((int.Parse(od7.Text) * 100m) / 10000m);
                lblProb8.Text = Convert.ToString(result) + "%";
            }
            if (od8.Text != "" && int.Parse(od8.Text) >= 0 )
            {

                lblProb9.Text = "";
                decimal result = ((int.Parse(od8.Text) * 100m) / 10000m);
                lblProb9.Text = Convert.ToString(result) + "%";
            }
            if (od9.Text != "" && int.Parse(od9.Text) >= 0)
            {

                lblProb10.Text = "";
                decimal result = ((int.Parse(od9.Text) * 100m) / 10000m);
                lblProb10.Text = Convert.ToString(result) + "%";
            }
        }
        void Fillcomo9()
        {

            string constring = ("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
            string Query = ("SELECT * FROM t_option ORDER BY a_index ASC;"); ;
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string a_index = myReader.GetString(1);
                    string a_name = myReader.GetString(2);
                    s9d.Items.Add(a_index + "-" + a_name);

                }
            }
            catch (Exception ex)
            {
                conDataBase.Close();
            }

        }
        void Fillcomo8()
        {

            string constring = ("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
            string Query = ("SELECT * FROM t_option ORDER BY a_index ASC;"); ;
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string a_index = myReader.GetString(1);
                    string a_name = myReader.GetString(2);
                    s8d.Items.Add(a_index + "-" + a_name); ;

                }
            }
            catch (Exception ex)
            {
                conDataBase.Close();
            }

        }
        void Fillcomo7()
        {

            string constring = ("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
            string Query = ("SELECT * FROM t_option ORDER BY a_index ASC;"); ;
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string a_index = myReader.GetString(1);
                    string a_name = myReader.GetString(2);
                    s7d.Items.Add(a_index + "-" + a_name);

                }
            }
            catch (Exception ex)
            {
                conDataBase.Close();
            }

        }
        void Fillcomo6()
        {

            string constring = ("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
            string Query = ("SELECT * FROM t_option ORDER BY a_index ASC;"); ;
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string a_index = myReader.GetString(1);
                    string a_name = myReader.GetString(2);
                    s6d.Items.Add(a_index + "-" + a_name);

                }
            }
            catch (Exception ex)
            {
                conDataBase.Close();
            }

        }
        void Fillcomo5()
        {

            string constring = ("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
            string Query = ("SELECT * FROM t_option ORDER BY a_index ASC;"); ;
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string a_index = myReader.GetString(1);
                    string a_name = myReader.GetString(2);
                    s5d.Items.Add(a_index + "-" + a_name);

                }
            }
            catch (Exception ex)
            {
                conDataBase.Close();
            }

        }
        void Fillcomo4()
        {

            string constring = ("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
            string Query = ("SELECT * FROM t_option ORDER BY a_index ASC;"); ;
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string a_index = myReader.GetString(1);
                    string a_name = myReader.GetString(2);
                    s4d.Items.Add(a_index + "-" + a_name);

                }
            }
            catch (Exception ex)
            {
                conDataBase.Close();
            }

        }
        void Fillcomo3()
        {

            string constring = ("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
            string Query = ("SELECT * FROM t_option ORDER BY a_index ASC;"); ;
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string a_index = myReader.GetString(1);
                    string a_name = myReader.GetString(2);
                    s3d.Items.Add(a_index + "-" + a_name);

                }
            }
            catch (Exception ex)
            {
                conDataBase.Close();
            }

        }
        void Fillcomo2()
        {

            string constring = ("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
            string Query = ("SELECT * FROM t_option ORDER BY a_index ASC;"); ;
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string a_index = myReader.GetString(1);
                    string a_name = myReader.GetString(2);
                    s2d.Items.Add(a_index + "-" + a_name);

                }
            }
            catch (Exception ex)
            {
                conDataBase.Close();
            }

        }
        void Fillcomo1()
        {
            string constring = ("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
            string Query = ("SELECT * FROM t_option ORDER BY a_index ASC;"); ;
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string a_index = myReader.GetString(1);
                    string a_name = myReader.GetString(2);
                    s1d.Items.Add(a_index + "-" + a_name);

                }
            }
            catch (Exception ex)
            {
                conDataBase.Close();
            }

        }
        void Fillcombo0()
        {
            string constring = ("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
            string Query = ("SELECT * FROM t_option ORDER BY a_index ASC;"); ;
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string a_index = myReader.GetString(1);
                    string a_name = myReader.GetString(2);
                    s0d.Items.Add(a_index + "-" + a_name);
                }
            }
            catch (Exception ex)
            {
                conDataBase.Close();
            }

        }
        void Fill_listbox()
        {
            string constring = ("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
            string Query = ("SELECT * FROM t_rareoption ORDER BY a_index ASC;"); ;
            //Fill_listbox();
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string SID = myReader.GetString("a_index");
                    string SID2 = myReader.GetString("a_name");
                    listBox1.Items.Add(SID + " - " + SID2);
                }
            }
            catch (Exception ex)
            {
                //conDataBase.Close();
            }

        }

        void RestTextBoxField() //dethunter12 add 6/3/2019
        {
            TbPercent1.Text = "";
            TbPercent2.Text = "";
            TbPercent3.Text = "";
            TbPercent4.Text = "";
            idtxt.BackColor = Color.White;
            nametxt.BackColor = Color.White;
            gdrop.BackColor = Color.White;
            tdrop.BackColor = Color.White;
            atktxt.BackColor = Color.White;
            mtktxt.BackColor = Color.White;
            rstxt.BackColor = Color.White;
            deftxt.BackColor = Color.White;
            s0d.BackColor = Color.White;
            s1d.BackColor = Color.White;
            s2d.BackColor = Color.White;
            s3d.BackColor = Color.White;
            s4d.BackColor = Color.White;
            s5d.BackColor = Color.White;
            s6d.BackColor = Color.White;
            s7d.BackColor = Color.White;
            s8d.BackColor = Color.White;
            s9d.BackColor = Color.White;
            od0.BackColor = Color.White;
            od1.BackColor = Color.White;
            od2.BackColor = Color.White;
            od3.BackColor = Color.White;
            od4.BackColor = Color.White;
            od5.BackColor = Color.White;
            od6.BackColor = Color.White;
            od7.BackColor = Color.White;
            od8.BackColor = Color.White;
            od9.BackColor = Color.White;
            lvl0.BackColor = Color.White;
            lvl1.BackColor = Color.White;
            lvl2.BackColor = Color.White;
            lvl3.BackColor = Color.White;
            lvl4.BackColor = Color.White;
            lvl5.BackColor = Color.White;
            lvl6.BackColor = Color.White;
            lvl7.BackColor = Color.White;
            lvl8.BackColor = Color.White;
            lvl9.BackColor = Color.White;
            TbPercent1.BackColor = Color.White;
            TbPercent2.BackColor = Color.White;
            TbPercent3.BackColor = Color.White;
            TbPercent4.BackColor = Color.White;
        }
        public static Connection connection = new Connection();
        private string Host = RareOptionEditor.connection.ReadSettings("Host");
        private string User = RareOptionEditor.connection.ReadSettings("User");
        private string Password = RareOptionEditor.connection.ReadSettings("Password");
        private string Database = RareOptionEditor.connection.ReadSettings("Database");
        private DatabaseHandle databaseHandle = new DatabaseHandle();
        private ExportLodHandle exportLodHandle = new ExportLodHandle();
        private static List<t_rareoption> RareOptionList = new List<t_rareoption>();
        public string _ClientPath = LcDevPack_TeamDamonA.Tools.MobEditor.connection.ReadSettings("ClientPath");

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = ("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
            string Query = "select * FROM t_rareoption WHERE a_index ='" + listBox1.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    string sID = myReader.GetInt32("a_index").ToString();
                    string sName = myReader.GetString("a_name");
                    string sAtk = myReader.GetInt32("a_attack").ToString();
                    string sDef = myReader.GetInt32("a_defense").ToString();
                    string sMAtk = myReader.GetInt32("a_magic").ToString();
                    string sResist = myReader.GetInt32("a_resist").ToString();
                    string sGrade = myReader.GetInt32("a_grade").ToString();
                    gdrop.SelectedIndex = Convert.ToInt32(sGrade);
                    string sType = myReader.GetInt32("a_type").ToString();
                    tdrop.SelectedIndex = Convert.ToInt32(sType);
                    string sSeal0 = myReader.GetInt32("a_option_index0").ToString();
                    string sSeal1 = myReader.GetInt32("a_option_index1").ToString();
                    string sSeal2 = myReader.GetInt32("a_option_index2").ToString();
                    string sSeal3 = myReader.GetInt32("a_option_index3").ToString();
                    string sSeal4 = myReader.GetInt32("a_option_index4").ToString();
                    string sSeal5 = myReader.GetInt32("a_option_index5").ToString();
                    string sSeal6 = myReader.GetInt32("a_option_index6").ToString();
                    string sSeal7 = myReader.GetInt32("a_option_index7").ToString();
                    string sSeal8 = myReader.GetInt32("a_option_index8").ToString();
                    string sSeal9 = myReader.GetInt32("a_option_index9").ToString();
                    string sLevel0 = myReader.GetInt32("a_option_level0").ToString();
                    string sLevel1 = myReader.GetInt32("a_option_level1").ToString();
                    string sLevel2 = myReader.GetInt32("a_option_level2").ToString();
                    string sLevel3 = myReader.GetInt32("a_option_level3").ToString();
                    string sLevel4 = myReader.GetInt32("a_option_level4").ToString();
                    string sLevel5 = myReader.GetInt32("a_option_level5").ToString();
                    string sLevel6 = myReader.GetInt32("a_option_level6").ToString();
                    string sLevel7 = myReader.GetInt32("a_option_level7").ToString();
                    string sLevel8 = myReader.GetInt32("a_option_level8").ToString();
                    string sLevel9 = myReader.GetInt32("a_option_level9").ToString();
                    string sprob0 = myReader.GetInt32("a_option_prob0").ToString();
                    string sprob1 = myReader.GetInt32("a_option_prob1").ToString();
                    string sprob2 = myReader.GetInt32("a_option_prob2").ToString();
                    string sprob3 = myReader.GetInt32("a_option_prob3").ToString();
                    string sprob4 = myReader.GetInt32("a_option_prob4").ToString();
                    string sprob5 = myReader.GetInt32("a_option_prob5").ToString();
                    string sprob6 = myReader.GetInt32("a_option_prob6").ToString();
                    string sprob7 = myReader.GetInt32("a_option_prob7").ToString();
                    string sprob8 = myReader.GetInt32("a_option_prob8").ToString();
                    string sprob9 = myReader.GetInt32("a_option_prob9").ToString();
                    /// Info Boxes


                    RestTextBoxField(); //dethunter12 add 6/3/2019
                    idtxt.Text = sID;
                    nametxt.Text = sName;
                    atktxt.Text = sAtk;
                    deftxt.Text = sDef;
                    mtktxt.Text = sMAtk;
                    rstxt.Text = sResist;
                    /// Grade and type dropbox
                    /// dethunter12 disable 
                    TbGrade.Text = sGrade; //dethunter12 adjust 6/3/2019
                    TbType.Text = sType; //dethunter12 adjust 6/3/2019
                    if (TbType.Text == "0") //dethunter12 add 6/3/2019
                    {
                        PbWeapon.BackColor = Color.LimeGreen;
                        PbArmor.BackColor = Control.DefaultBackColor;
                        PbAcc.BackColor = Control.DefaultBackColor;
                    }
                    else if (TbType.Text == "1") //check the field based on condition then set the colors accordingly
                    {
                        PbArmor.BackColor = Color.LimeGreen;
                        PbWeapon.BackColor = Control.DefaultBackColor;
                        PbAcc.BackColor = Control.DefaultBackColor;
                    } //dethunter12 add 6/3/2019
                    else if (TbType.Text == "2")
                    {
                        PbAcc.BackColor = Color.LimeGreen;
                        PbArmor.BackColor = Control.DefaultBackColor;
                        PbWeapon.BackColor = Control.DefaultBackColor;
                    } //dethunter12 add 6/3/2019
                    //Seal Boxes
             
                    TbSeal0.Text = sSeal0; //dethunter12 add 6/3/2019
                    s0d.SelectedIndex = Convert.ToInt32(sSeal0);
                    TbSeal1.Text = sSeal1; //dethunter12 add 6/3/2019
                    s1d.SelectedIndex = Convert.ToInt32(sSeal1);
                    TbSeal2.Text = sSeal2; //dethunter12 add 6/3/2019
                    s2d.SelectedIndex = Convert.ToInt32(sSeal2);
                    TbSeal3.Text = sSeal3; //dethunter12 add 6/3/2019
                    s3d.SelectedIndex = Convert.ToInt32(sSeal3);
                    TbSeal4.Text = sSeal4; //dethunter12 add 6/3/2019
                    s4d.SelectedIndex = Convert.ToInt32(sSeal4);
                    TbSeal5.Text = sSeal5; //dethunter12 add 6/3/2019
                    s5d.SelectedIndex = Convert.ToInt32(sSeal5);
                    TbSeal6.Text = sSeal6; //dethunter12 add 6/3/2019
                    s6d.SelectedIndex = Convert.ToInt32(sSeal6);
                    TbSeal7.Text = sSeal7; //dethunter12 add 6/3/2019
                    s6d.SelectedIndex = Convert.ToInt32(sSeal7);
                    TbSeal8.Text = sSeal8;//dethunter12 add 6/3/2019
                    s8d.SelectedIndex = Convert.ToInt32(sSeal8);
                    TbSeal9.Text = sSeal9; //dethunter12 add 6/3/2019
                    s9d.SelectedIndex = Convert.ToInt32(sSeal9);                 
                    //Seal Level
                    lvl0.Text = sLevel0;
                    lvl1.Text = sLevel1;
                    lvl2.Text = sLevel2;
                    lvl3.Text = sLevel3;
                    lvl4.Text = sLevel4;
                    lvl5.Text = sLevel5;
                    lvl6.Text = sLevel6;
                    lvl7.Text = sLevel7;
                    lvl8.Text = sLevel8;
                    lvl9.Text = sLevel9;
                    // Seal prob
                    od0.Text = sprob0;
                    od1.Text = sprob1;
                    od2.Text = sprob2;
                    od3.Text = sprob3;
                    od4.Text = sprob4;
                    od5.Text = sprob5;
                    od6.Text = sprob6;
                    od7.Text = sprob7;
                    od8.Text = sprob8;
                    od9.Text = sprob9;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            {
                conDataBase.Close();
            }

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_rareoption SET " + "a_index = '" + idtxt.Text + "', " + "a_name = '" + nametxt.Text + "', " + "a_grade = '" + TbGrade.Text + "', " + "a_type = '" + TbType.Text + "', " + "a_attack = '" + atktxt.Text + "', " + "a_defense = '" + deftxt.Text + "', " + "a_magic = '" + mtktxt.Text + "', " + "a_resist = '" + rstxt.Text + "', " + "a_option_index0 = '" + TbSeal0.Text + "', " + "a_option_index1 = '" + TbSeal1.Text + "', " + "a_option_index2 = '" + TbSeal2.Text + "', " + "a_option_index3 = '" + TbSeal3.Text + "', " + "a_option_index4 = '" + TbSeal4.Text + "', " + "a_option_index5 = '" + TbSeal5.Text + "', " + "a_option_index6 = '" + TbSeal6.Text + "', " + "a_option_index7 = '" + TbSeal7.Text + "', " + "a_option_index8 = '" + TbSeal8.Text + "', " + "a_option_index9 = '" + TbSeal9.Text + "', " + "a_option_level0 = '" + lvl0.Text + "', " + "a_option_level1 = '" + lvl1.Text + "', " + "a_option_level2 = '" + lvl2.Text + "', " + "a_option_level3 = '" + lvl3.Text + "', " + "a_option_level4 = '" + lvl4.Text + "', " + "a_option_level5 = '" + lvl5.Text + "', " + "a_option_level6 = '" + lvl6.Text + "', " + "a_option_level7 = '" + lvl7.Text + "', " + "a_option_level8 = '" + lvl8.Text + "', " + "a_option_level9 = '" + lvl0.Text + "', " + "a_option_prob0 = '" + od0.Text + "', " + "a_option_prob1 = '" + od1.Text + "', " + "a_option_prob2 = '" + od2.Text + "', " + "a_option_prob3 = '" + od3.Text + "', " + "a_option_prob4 = '" + od4.Text + "', " + "a_option_prob5 = '" + od5.Text + "', " + "a_option_prob6 = '" + od6.Text + "', " + "a_option_prob7 = '" + od7.Text + "', " + "a_option_prob8 = '" + od8.Text + "', " + "a_option_prob9 = '" + od9.Text + "' " + "WHERE a_index = '" + idtxt.Text + "'"); //dethunter12 adjust 6/3/2019
            Fill_listbox();
            int selectedIndex = listBox1.SelectedIndex;

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "DELETE FROM t_rareoption WHERE a_index = '" + idtxt.Text + "'");
            Fill_listbox();
            int num2 = (int)new CustomMessage("Deleted :O").ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            databaseHandle.SendQueryMySql(Host, User, Password, Database, "INSERT INTO t_rareoption DEFAULT VALUES");
            Fill_listbox();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            idtxt.BackColor = Color.Lime;
            nametxt.BackColor = Color.Lime;
        }

        private void RareOptionEditor_Load(object sender, EventArgs e)
        {
            Fill_listbox();
            Fillcombo0(); //dethunter12 adjust 6/3/2019
            Fillcomo1(); //dethunter12 adjust 6/3/2019
            Fillcomo2(); //dethunter12 adjust 6/3/2019
            Fillcomo3(); //dethunter12 adjust 6/3/2019
            Fillcomo4(); //dethunter12 adjust 6/3/2019
            Fillcomo5(); //dethunter12 adjust 6/3/2019
            Fillcomo6(); //dethunter12 adjust 6/3/2019
            Fillcomo7(); //dethunter12 adjust 6/3/2019
            Fillcomo8(); //dethunter12 adjust 6/3/2019
            Fillcomo9(); //dethunter12 adjust 6/3/2019
            gdrop.Items.AddRange(new object[5] //dethunter12 initialize the combo box values at startup 6/3/2019 
      {
         "0 - Blue",
         "1 - Green",
         "2 - Yellow",
         "3 - White bonus",
         "4 - White"

      }); //dethunter12 add 6/3/2019
            tdrop.Items.AddRange(new object[3] //dethunter12 initialize the combo box values at startup 6/3/2019 
      {
         "0 - Weapon",
         "1 - Armor",
         "2 - Accessory",

      }); //dethunter12 add 6/3/2019
            listBox1.SelectedIndex = 0; //dethunter12 start the tool with an index selected. 6/30/2019
        }

        private void Gdrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbGrade.Text = GetIndexByComboBox(gdrop.Text).ToString(); //dethunter12 add 6/3/2019
        }

        private void Tdrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbType.Text = GetIndexByComboBox(tdrop.Text).ToString(); //dethunter12 add 6/3/2019
        }

        private void PbWeapon_Click(object sender, EventArgs e)
        {
            TbType.Text = Convert.ToString(0);
            tdrop.SelectedIndex = 0;
            if (PbAcc.BackColor == Color.LimeGreen || PbArmor.BackColor == Color.LimeGreen) //make sure the other fields arent filed in if they are clear them
            {
                PbAcc.BackColor = Control.DefaultBackColor;
                PbArmor.BackColor = Control.DefaultBackColor;
            }
            PbWeapon.BackColor = Color.LimeGreen;
        }

        private void PbArmor_Click(object sender, EventArgs e)//dethunter12 add 6/3/2019
        {
            TbType.Text = Convert.ToString(1);
            tdrop.SelectedIndex = 1;
            if (PbWeapon.BackColor == Color.LimeGreen || PbAcc.BackColor == Color.LimeGreen)
            {
                PbWeapon.BackColor = Control.DefaultBackColor;
                PbAcc.BackColor = Control.DefaultBackColor;
            }
            PbArmor.BackColor = Color.LimeGreen;
        }

        private void PbAcc_Click(object sender, EventArgs e)//dethunter12 add 6/3/2019
        {
            TbType.Text = Convert.ToString(2);
            tdrop.SelectedIndex = 2;
            if (PbWeapon.BackColor == Color.LimeGreen || PbArmor.BackColor == Color.LimeGreen)
            {
                PbWeapon.BackColor = Control.DefaultBackColor;
                PbArmor.BackColor = Control.DefaultBackColor;
            }
            PbAcc.BackColor = Color.LimeGreen;
        }

        private void BtnPercentAddAttk_Click(object sender, EventArgs e)//dethunter12 add 6/3/2019
        {
            if (atktxt.Text != "0")
            {
                try
                {
                    int result1 = 0; //Dethunter12 add (wizatek code)
                    float result2 = 0.0f;

                    if (!int.TryParse(atktxt.Text, out result1) || !float.TryParse(TbPercent1.Text.Replace('.', ','), out result2))
                        return;
                    atktxt.Text = ((int)(result1 / 100f * (double)result2) + result1).ToString();


                }
                catch (Exception ex) { }
            }
            else if (atktxt.Text == "0")
            {
                MessageBox.Show("Please edit the attack value first");
            }
        }

        private void BtnPercentAddDef_Click(object sender, EventArgs e)//dethunter12 add 6/3/2019
        {
            if (deftxt.Text != "0") //check the condition first then work accordingly
            {
                try
                {
                    int result1 = 0; //Dethunter12 add (wizatek code)
                    float result2 = 0.0f;

                    if (!int.TryParse(deftxt.Text, out result1) || !float.TryParse(TbPercent2.Text.Replace('.', ','), out result2))
                        return;
                    this.deftxt.Text = ((int)(result1 / 100f * (double)result2) + result1).ToString();


                }
                catch (Exception ex) { }
            }
            else if (deftxt.Text == "0")
            {
                MessageBox.Show("Please edit the defence value first");
            }
        }

        private void BtnPercentAddMattk_Click(object sender, EventArgs e)//dethunter12 add 6/3/2019
        {
            if (mtktxt.Text != "0")
            {
                try
                {
                    int result1 = 0; //Dethunter12 add (wizatek code)
                    float result2 = 0.0f;

                    if (!int.TryParse(mtktxt.Text, out result1) || !float.TryParse(TbPercent3.Text.Replace('.', ','), out result2))
                        return;
                    mtktxt.Text = ((int)(result1 / 100f * (double)result2) + result1).ToString();


                }
                catch (Exception ex) { }
            }
            else if (mtktxt.Text == "0")
            {
                MessageBox.Show("Please edit the magic attack value first");
            }
        }

        private void BtnPercentAddResist_Click(object sender, EventArgs e)//dethunter12 add 6/3/2019
        {
            if (rstxt.Text != "0")
            {
                try
                {
                    int result1 = 0; //Dethunter12 add (wizatek code)
                    float result2 = 0.0f;

                    if (!int.TryParse(rstxt.Text, out result1) || !float.TryParse(TbPercent4.Text.Replace('.', ','), out result2))
                        return;
                    rstxt.Text = ((int)(result1 / 100f * (double)result2) + result1).ToString();


                }
                catch (Exception ex) { }
            }
            else if (rstxt.Text == "0")
            {
                MessageBox.Show("Please edit the magic defence value first");
            }
        }

        private void Atktxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            atktxt.BackColor = Color.Pink;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //limit to whole digits.
            {
                e.Handled = true;
            }
        }

        private void Deftxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            deftxt.BackColor = Color.Pink;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //limit to whole digits.
            {
                e.Handled = true;
            }
        }

        private void Mtktxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            mtktxt.BackColor = Color.Pink;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //limit to whole digits.
            {
                e.Handled = true;
            }
        }

        private void Rstxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            rstxt.BackColor = Color.Pink;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //limit to whole digits.
            {
                e.Handled = true;
            }
        }

        private void Nametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            nametxt.BackColor = Color.Pink;
            
        }

        private void Idtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            idtxt.BackColor = Color.Pink;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //limit to whole digits.
            {
                e.Handled = true;
            }
        }

        private void Gdrop_KeyPress(object sender, KeyPressEventArgs e)
        {
            gdrop.BackColor = Color.Pink;
            e.Handled = true;

        }

        private void Tdrop_KeyPress(object sender, KeyPressEventArgs e)
        {
            tdrop.BackColor = Color.Pink;
            e.Handled = true;
        }

        private void S0d_KeyPress(object sender, KeyPressEventArgs e)
        {
            s0d.BackColor = Color.Pink;
            e.Handled = true;
        }

        private void S1d_KeyPress(object sender, KeyPressEventArgs e)
        {
            s1d.BackColor = Color.Pink;
            e.Handled = true;
        }

        private void S2d_KeyPress(object sender, KeyPressEventArgs e)
        {
            s2d.BackColor = Color.Pink;
            e.Handled = true;
        }

        private void S3d_KeyPress(object sender, KeyPressEventArgs e)
        {
            s3d.BackColor = Color.Pink;
            e.Handled = true;
        }

        private void S4d_KeyPress(object sender, KeyPressEventArgs e)
        {
            s4d.BackColor = Color.Pink;
            e.Handled = true;
        }

        private void S5d_KeyPress(object sender, KeyPressEventArgs e)
        {
            s5d.BackColor = Color.Pink;
            e.Handled = true;
        }

        private void S6d_KeyPress(object sender, KeyPressEventArgs e)
        {
            s6d.BackColor = Color.Pink;
            e.Handled = true;
        }

        private void S7d_KeyPress(object sender, KeyPressEventArgs e)
        {
            s7d.BackColor = Color.Pink;
            e.Handled = true;
        }

        private void S8d_KeyPress(object sender, KeyPressEventArgs e)
        {
            s8d.BackColor = Color.Pink;
            e.Handled = true;
        }

        private void S9d_KeyPress(object sender, KeyPressEventArgs e)
        {
            s9d.BackColor = Color.Pink;
            e.Handled = true;
        }

        private void Lvl0_KeyPress(object sender, KeyPressEventArgs e)
        {
            lvl0.BackColor = Color.Pink;
            e.Handled = true;
        }

        private void Lvl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            lvl1.BackColor = Color.Pink;
            e.Handled = true;
        }

        private void Lvl2_KeyPress(object sender, KeyPressEventArgs e)
        {
            lvl2.BackColor = Color.Pink;
            e.Handled = true;
        }

        private void Lvl3_KeyPress(object sender, KeyPressEventArgs e)
        {
            lvl3.BackColor = Color.Pink;
            e.Handled = true;
        }

        private void Lvl4_KeyPress(object sender, KeyPressEventArgs e)
        {
            lvl4.BackColor = Color.Pink;
            e.Handled = true;
        }

        private void Lvl5_KeyPress(object sender, KeyPressEventArgs e)
        {
            lvl5.BackColor = Color.Pink;
            e.Handled = true;
        }

        private void Lvl6_KeyPress(object sender, KeyPressEventArgs e)
        {
            lvl6.BackColor = Color.Pink;
            e.Handled = true;
        }

        private void Lvl7_KeyPress(object sender, KeyPressEventArgs e)
        {
            lvl7.BackColor = Color.Pink;
            e.Handled = true;
        }

        private void Lvl8_KeyPress(object sender, KeyPressEventArgs e)
        {
            lvl8.BackColor = Color.Pink;
            e.Handled = true;
        }

        private void Lvl9_KeyPress(object sender, KeyPressEventArgs e)
        {
            lvl9.BackColor = Color.Pink;
            e.Handled = true;
        }

        private void Od0_KeyPress(object sender, KeyPressEventArgs e)
        {
            od0.BackColor = Color.Pink;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //limit to whole digits.
            {
                e.Handled = true;
            }
        }

        private void Od1_KeyPress(object sender, KeyPressEventArgs e)
        {
            od1.BackColor = Color.Pink;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //limit to whole digits.
            {
                e.Handled = true;
            }
        }

        private void Od2_KeyPress(object sender, KeyPressEventArgs e)
        {
            od2.BackColor = Color.Pink;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //limit to whole digits.
            {
                e.Handled = true;
            }
        }

        private void Od3_KeyPress(object sender, KeyPressEventArgs e)
        {
            od3.BackColor = Color.Pink;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //limit to whole digits.
            {
                e.Handled = true;
            }
        }

        private void Od4_KeyPress(object sender, KeyPressEventArgs e)
        {
            od4.BackColor = Color.Pink;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //limit to whole digits.
            {
                e.Handled = true;
            }
        }

        private void Od5_KeyPress(object sender, KeyPressEventArgs e)
        {
            od5.BackColor = Color.Pink;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //limit to whole digits.
            {
                e.Handled = true;
            }
        }

        private void Od6_KeyPress(object sender, KeyPressEventArgs e)
        {
            od6.BackColor = Color.Pink;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //limit to whole digits.
            {
                e.Handled = true;
            }
        }

        private void Od7_KeyPress(object sender, KeyPressEventArgs e)
        {
            od7.BackColor = Color.Pink;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //limit to whole digits.
            {
                e.Handled = true;
            }
        }

        private void Od8_KeyPress(object sender, KeyPressEventArgs e)
        {
            od8.BackColor = Color.Pink;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //limit to whole digits.
            {
                e.Handled = true;
            }
        }

        private void Od9_KeyPress(object sender, KeyPressEventArgs e)
        {
            od9.BackColor = Color.Pink;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //limit to whole digits.
            {
                e.Handled = true;
            }
        }

        private void TbPercent1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbPercent1.BackColor = Color.Pink;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //limit to whole digits.
            {
                e.Handled = true;
            }
        }

        private void TbPercent2_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbPercent2.BackColor = Color.Pink;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //limit to whole digits.
            {
                e.Handled = true;
            }
        }

        private void TbPercent3_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbPercent3.BackColor = Color.Pink;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //limit to whole digits.
            {
                e.Handled = true;
            }
        }

        private void TbPercent4_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbPercent4.BackColor = Color.Pink;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //limit to whole digits.
            {
                e.Handled = true;
            }
        }

        private void S0d_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbSeal0.Text = GetIndexByComboBox(s0d.Text).ToString(); //dethunter12 add 6/3/2019
        }

        private void S1d_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbSeal1.Text = GetIndexByComboBox(s1d.Text).ToString(); //dethunter12 add 6/3/2019
        }

        private void S2d_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbSeal2.Text = GetIndexByComboBox(s2d.Text).ToString(); //dethunter12 add 6/3/2019
        }

        private void S3d_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbSeal3.Text = GetIndexByComboBox(s3d.Text).ToString(); //dethunter12 add 6/3/2019
        }

        private void S4d_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbSeal4.Text = GetIndexByComboBox(s4d.Text).ToString(); //dethunter12 add 6/3/2019
        }

        private void S5d_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbSeal5.Text = GetIndexByComboBox(s5d.Text).ToString(); //dethunter12 add 6/3/2019
        }

        private void S6d_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbSeal6.Text = GetIndexByComboBox(s6d.Text).ToString(); //dethunter12 add 6/3/2019
        }

        private void S7d_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbSeal7.Text = GetIndexByComboBox(s7d.Text).ToString(); //dethunter12 add 6/3/2019
        }

        private void S8d_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbSeal8.Text = GetIndexByComboBox(s8d.Text).ToString(); //dethunter12 add 6/3/2019
        }

        private void S9d_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbSeal9.Text = GetIndexByComboBox(s9d.Text).ToString(); //dethunter12 add 6/3/2019
        }

        private void TbType_TextChanged(object sender, EventArgs e)
        {
            int TypeValue;
            TypeValue = Convert.ToInt16(TbType.Text);
            if (TypeValue < 0 || TypeValue > 2)
            {
                MessageBox.Show("Error Type Value Not Within Range ");
            }
            else if (TypeValue == 0 || TypeValue == 1 || TypeValue == 2)
            {

                if (TypeValue == 0) //weapon
                {
                    PbWeapon.BackColor = Color.LimeGreen;
                    PbArmor.BackColor = Control.DefaultBackColor;
                    PbAcc.BackColor = Control.DefaultBackColor;
                }
                else if (TypeValue == 1) //armor
                {
                    PbArmor.BackColor = Color.LimeGreen;
                    PbWeapon.BackColor = Control.DefaultBackColor;
                    PbAcc.BackColor = Control.DefaultBackColor;
                }
                else if (TypeValue == 2) //accessory
                {
                    PbAcc.BackColor = Color.LimeGreen;
                    PbWeapon.BackColor = Control.DefaultBackColor;
                    PbArmor.BackColor = Control.DefaultBackColor;
                }
            }
        }
        public string LanguageExport() //dethunter12 add 7/5/2020
        {

            if (language == "GER")
            {
                namee = "ger";
                return namee;

            }
            else if (language == "POL")
            {
                namee = "pol";
                return namee;

            }
            else if (language == "BRA")
            {
                namee = "brz";
                return namee;
            }
            else if (language == "RUS")
            {
                namee = "rus";
                return namee;
            }
            else if (language == "FRA")
            {
                namee = "fra";
                return namee;
            }
            else if (language == "ESP")
            {
                namee = "esp";
                return namee;
            }
            else if (language == "MEX")
            {
                namee = "mex";
                return namee;
            }
            else if (language == "THA")
            {
                namee = "tha";
                return namee;
            }
            else if (language == "ITA")
            {
                namee = "ita";
                return namee;
            }
            else if (language == "USA")
            {
                namee = "usa";
                return namee;
            }
            else
            {
                return null;
            }
        }
        private void rareOptionlodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text1 = "rareoption";
            string text2 = "path_ship";
            string text3 = LanguageExport();
            Process.Start(new ProcessStartInfo()
            {
                FileName = "ExportLod.exe",
                Arguments = " -h " + Host + " -d " + Database + " -u " + User + " -p " + Password + " -k " + text2 + " -l " + text3 + " -t " + text1
            });
        }

        private void exportStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
             FormExport f2 = new FormExport();
            f2.Show(); // Shows Form2
        }

        private void od0_TextChanged(object sender, EventArgs e)
        {
            
            if (od0.Text != "" && int.Parse(od0.Text) > 10000 )
                od0.Text = Convert.ToString(10000);
            Update_Probability_Text(); //dethunter12 add 9/2/2020
        }

        private void od1_TextChanged(object sender, EventArgs e)
        {
            if (od1.Text != "" && int.Parse(od1.Text) > 10000)
                od1.Text = Convert.ToString(10000);
            Update_Probability_Text();
        }

        private void od2_TextChanged(object sender, EventArgs e)
        {
            if (od2.Text != "" && int.Parse(od2.Text) > 10000)
                od2.Text = Convert.ToString(10000);
            Update_Probability_Text();
        }

        private void od3_TextChanged(object sender, EventArgs e)
        {
            if (od3.Text != "" && int.Parse(od3.Text) > 10000)
                od3.Text = Convert.ToString(10000);
            Update_Probability_Text();
        }

        private void od4_TextChanged(object sender, EventArgs e)
        {
            if (od4.Text != "" && int.Parse(od4.Text) > 10000)
                od4.Text = Convert.ToString(10000);
            Update_Probability_Text();
        }

        private void od5_TextChanged(object sender, EventArgs e)
        {
            if (od5.Text != "" && int.Parse(od5.Text) > 10000)
                od5.Text = Convert.ToString(10000);
            Update_Probability_Text();
        }

        private void od6_TextChanged(object sender, EventArgs e)
        {
            if (od6.Text != "" && int.Parse(od6.Text) > 10000)
                od6.Text = Convert.ToString(10000);
            Update_Probability_Text();
        }

        private void od7_TextChanged(object sender, EventArgs e)
        {
            if (od7.Text != "" && int.Parse(od7.Text) > 10000)
                od7.Text = Convert.ToString(10000);
            Update_Probability_Text();
        }

        private void od8_TextChanged(object sender, EventArgs e)
        {
            if (od8.Text != "" && int.Parse(od8.Text) > 10000)
                od8.Text = Convert.ToString(10000);
            Update_Probability_Text();
        }

        private void od9_TextChanged(object sender, EventArgs e)
        {
            if (od9.Text != "" && int.Parse(od9.Text) > 10000)
                od9.Text = Convert.ToString(10000);
            Update_Probability_Text();
        }
    }
}