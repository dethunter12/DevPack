using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace LcDevPack_TeamDamonA.Tools.MemoryWorker.Jawel
{
    public partial class JawelData : Form
    {
        public static Connection connection = new Connection();
        private string Host = JawelData.connection.ReadSettings("Host");
        private string User = JawelData.connection.ReadSettings("User");
        private string Password = JawelData.connection.ReadSettings("Password");
        private string Database = JawelData.connection.ReadSettings("Database");
        private DatabaseHandle databaseHandle = new DatabaseHandle();
        private ExportLodHandle exportLodHandle = new ExportLodHandle();
        public static List<JawelStruct> JawelList = new List<JawelStruct>();
        public string _ClientPath = LcDevPack_TeamDamonA.Tools.MobEditor.connection.ReadSettings("ClientPath");

        private void LoadListBox()
        {
            MySqlConnection mysqlCon = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
            mysqlCon.Open();
            MySqlCommand Command = new MySqlCommand("SELECT * FROM t_jewel_data ORDER BY a_index ASC;", mysqlCon);
            Command.ExecuteNonQuery();
            MySqlDataReader Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                JawelStruct temp = new JawelStruct();
                temp.a_index = (int)Reader["a_index"];
                temp.a_normal_compose_neednas = (long)Reader["a_normal_compose_neednas"];
                temp.a_chaos_compose_neednas = (long)Reader["a_chaos_compose_neednas"];
                temp.a_normal_compose_prob = (int)Reader["a_normal_compose_prob"];
                temp.a_chaos_compose_prob = (int)Reader["a_chaos_compose_prob"];
                temp.a_compose_normalToChaos_prob = (int)Reader["a_compose_normalToChaos_prob"];
                temp.a_normal_plus2_prob = (int)Reader["a_normal_plus2_prob"];
                temp.a_normal_plus3_prob = (int)Reader["a_normal_plus3_prob"];
                temp.a_chaos_plus2_prob = (int)Reader["a_chaos_plus2_prob"];
                temp.a_chaos_plus3_prob = (int)Reader["a_chaos_plus3_prob"];
                temp.a_normal_minus1_prob = (int)Reader["a_normal_minus1_prob"];
                temp.a_normal_minus2_prob = (int)Reader["a_normal_minus2_prob"];
                temp.a_normal_minus3_prob = (int)Reader["a_normal_minus3_prob"];
                temp.a_chaos_minus1_prob = (int)Reader["a_chaos_minus1_prob"];
                temp.a_chaos_minus2_prob = (int)Reader["a_chaos_minus2_prob"];
                temp.a_chaos_minus3_prob = (int)Reader["a_chaos_minus3_prob"];
                JawelList.Add(temp);
            }
            listBox1.Items.Clear();
            int sk = JawelList.Count();
            for (int i = 0; i < sk; i++)
            {
                int ID = JawelList[i].a_index;
                listBox1.Items.Add(ID);
            }
            mysqlCon.Close();
        }

        public JawelData()
        {
            InitializeComponent();
        }

        private void JawelData_Load(object sender, EventArgs e)
        {
            LoadListBox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string text = this.listBox1.SelectedItem.ToString();
                string[] array = text.Split(new char[]
                {
                    '-'
                });
                int Item = Convert.ToInt32(array[0]);
                int index = JawelList.FindIndex((JawelStruct p) => p.a_index.Equals(Item));
                textBox1.Text = Convert.ToString(Item);
                tb_normal_compose_neednas.Text = JawelList[index].a_normal_compose_neednas.ToString();
                tb_normal_compose_prob.Text = JawelList[index].a_normal_compose_prob.ToString();
                //Chaos
                tb_chaos_compose_neednas.Text = JawelList[index].a_chaos_compose_neednas.ToString();
                tb_chaos_compose_prob.Text = JawelList[index].a_chaos_compose_prob.ToString();
                //Normal to Chaos
                tb_a_compose_normalToChaos_prob.Text = JawelList[index].a_compose_normalToChaos_prob.ToString();
                //Normal Upgrade Proub
                tb_a_normal_plus2_prob.Text = JawelList[index].a_normal_plus2_prob.ToString();
                tb_a_normal_plus3_prob.Text = JawelList[index].a_normal_plus3_prob.ToString();
                //Chaos Upgrade Proub
                tb_a_chaos_plus2_prob.Text = JawelList[index].a_chaos_plus2_prob.ToString();
                tb_a_chaos_plus3_prob.Text = JawelList[index].a_chaos_plus3_prob.ToString();
                //Normal Upgrade Minus
                tb_a_normal_minus1_prob.Text = JawelList[index].a_normal_minus1_prob.ToString();
                tb_a_normal_minus2_prob.Text = JawelList[index].a_normal_minus2_prob.ToString();
                tb_a_normal_minus3_prob.Text = JawelList[index].a_normal_minus3_prob.ToString();
                //Chaos Upgrade Minus
                tb_a_chaos_minus1_prob.Text = JawelList[index].a_chaos_minus1_prob.ToString();
                tb_a_chaos_minus2_prob.Text = JawelList[index].a_chaos_minus2_prob.ToString();
                tb_a_chaos_minus3_prob.Text = JawelList[index].a_chaos_minus3_prob.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.listBox1.Items.Count != 0)
            {
                int iD = JawelList[JawelList.Count - 1].a_index + 1;
                JawelStruct temp = new JawelStruct();
                temp.a_index = iD;
                JawelList.Add(temp);
                this.listBox1.Items.Clear();
                int num = JawelList.Count<JawelStruct>();
                for (int i = 0; i < num; i++)
                {
                    int iD2 = JawelList[i].a_index;                    
                    this.listBox1.Items.Add(iD2);
                }
                if (this.checkBox1.Checked)
                {
                    //Mysql Insert
                    MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand3 = new MySqlCommand(string.Concat(new object[]
                                    {
                                    "INSERT INTO t_jewel_data (a_index)VALUES('",
                                    iD,
                                    //"','1",
                                    "');"
                                    }), mySqlConnection);
                    mySqlCommand3.ExecuteNonQuery();
                    mySqlConnection.Close();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                checkBox1.Text = "YES";
                checkBox1.BackColor = Color.LimeGreen; //dethunter12 add 6/27/2018
            }
            else
            {
                checkBox1.Text = "NO";
                checkBox1.BackColor = Color.Red; //dethunter12 add 6/27/2018
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are u sure u want to delete this record?", "Delete Record Confirmation", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            if (this.listBox1.SelectedIndex != -1)
            {
                string text = this.listBox1.SelectedItem.ToString();
                string[] array = text.Split(new char[]
                {
                    '-'
                });
                //MYSQL DELATE
                if (this.checkBox1.Checked)
                {
                    string Query = "DELETE FROM t_jewel_data WHERE a_index = '" + textBox1.Text + "'";
                    databaseHandle.SendQueryMySql(Host, User, Password, Database, Query);
                }
                int id = int.Parse(array[0]);
                int num = JawelList.FindIndex((JawelStruct p) => p.a_index.Equals(id));
                if (num != -1)
                {
                    JawelList.RemoveAt(num);
                    this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex != -1)
            {
                string text = this.listBox1.SelectedItem.ToString();
                string[] array = text.Split(new char[]
                {
                    '-'
                });
                int ID = int.Parse(array[0]);
                int num = JawelList.FindIndex((JawelStruct p) => p.a_index.Equals(ID));
                //MYSQL DELATE
                if (this.checkBox1.Checked)
                {
                    Update_To_DB_SELECT();
                }

                if (num != -1)
                {
                    JawelList[num].a_index = Convert.ToInt32(textBox1.Text);
                    JawelList[num].a_normal_compose_neednas = Convert.ToInt32(tb_normal_compose_neednas.Text);
                    JawelList[num].a_chaos_compose_neednas = Convert.ToInt32(tb_chaos_compose_neednas.Text);
                    //compose
                    JawelList[num].a_normal_compose_prob = Convert.ToInt32(tb_normal_compose_prob.Text);
                    JawelList[num].a_chaos_compose_prob = Convert.ToInt32(tb_chaos_compose_prob.Text);
                    //normal upgrade plus
                    JawelList[num].a_compose_normalToChaos_prob = Convert.ToInt32(tb_a_compose_normalToChaos_prob.Text);
                    JawelList[num].a_normal_plus2_prob = Convert.ToInt32(tb_a_normal_plus2_prob.Text);
                    JawelList[num].a_normal_plus3_prob = Convert.ToInt32(tb_a_normal_plus3_prob.Text);
                    //Chaos upgrade plus
                    JawelList[num].a_chaos_plus2_prob = Convert.ToInt32(tb_a_chaos_plus2_prob.Text);
                    JawelList[num].a_chaos_plus3_prob = Convert.ToInt32(tb_a_chaos_plus3_prob.Text);
                    //normal proub minus
                    JawelList[num].a_normal_minus1_prob = Convert.ToInt32(tb_a_normal_minus1_prob.Text);
                    JawelList[num].a_normal_minus2_prob = Convert.ToInt32(tb_a_normal_minus2_prob.Text);
                    JawelList[num].a_normal_minus3_prob = Convert.ToInt32(tb_a_normal_minus3_prob.Text);
                    //chaos proub minus
                    JawelList[num].a_chaos_minus1_prob = Convert.ToInt32(tb_a_chaos_minus1_prob.Text);
                    JawelList[num].a_chaos_minus2_prob = Convert.ToInt32(tb_a_chaos_minus2_prob.Text);
                    JawelList[num].a_chaos_minus3_prob = Convert.ToInt32(tb_a_chaos_minus3_prob.Text);
                }
                this.listBox1.Items.Clear();
                int num1 = JawelList.Count<JawelStruct>();
                for (int i = 0; i < num1; i++)
                {
                    int iD2 = JawelList[i].a_index;
                    this.listBox1.Items.Add(iD2);
                }
            }
        }

        private void Update_To_DB_SELECT()
        {
            MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(string.Concat(new string[]
            {
                    "UPDATE t_jewel_data SET a_index = '",
                    this.textBox1.Text,
                    "',a_normal_compose_neednas = '",
                    this.tb_normal_compose_neednas.Text,
                    "',a_chaos_compose_neednas = '",
                    this.tb_chaos_compose_neednas.Text,
                    //Result
                    "',a_normal_compose_prob = '",
                    this.tb_normal_compose_prob.Text,
                    "',a_chaos_compose_prob = '",
                    this.tb_chaos_compose_prob.Text,
                    //Need Item
                    "',a_compose_normalToChaos_prob = '",
                    this.tb_a_compose_normalToChaos_prob.Text,
                    "',a_normal_plus2_prob = '",
                    this.tb_a_normal_plus2_prob.Text,
                    "',a_normal_plus3_prob = '",
                    this.tb_a_normal_plus3_prob.Text,
                    "',a_chaos_plus2_prob = '",
                    this.tb_a_chaos_plus2_prob.Text,
                    "',a_chaos_plus3_prob = '",
                    this.tb_a_chaos_plus3_prob.Text,
                    "',a_normal_minus1_prob = '",
                    this.tb_a_normal_minus1_prob.Text,
                    "',a_normal_minus2_prob = '",
                    this.tb_a_normal_minus2_prob.Text,
                    "',a_normal_minus3_prob = '",
                    this.tb_a_normal_minus3_prob.Text,
                    "',a_chaos_minus1_prob = '",
                    this.tb_a_chaos_minus1_prob.Text,
                    "',a_chaos_minus2_prob = '",
                    this.tb_a_chaos_minus2_prob.Text,
                    "',a_chaos_minus3_prob = '",
                    this.tb_a_chaos_minus3_prob.Text,
                    "' WHERE a_index = '",
                    this.textBox1.Text,
                    "';"
            }), mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
        }

        private void saveToLODToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listBox1.Items.Count != 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JewelCompos*.lod|JewelCompos*.lod|data|*.data|All|*.*";
                saveFileDialog.Title = "Save JewelCompos*.lod";
                saveFileDialog.InitialDirectory = _ClientPath;
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "")
                {
                    try
                    {
                        FileStream output = new FileStream(saveFileDialog.FileName, FileMode.Create);
                        BinaryWriter binaryWriter = new BinaryWriter(output);
                        binaryWriter.Write(JawelList.Count);
                        //binaryWriter.Write(JawelList[JawelList.Count - 1].a_index);
                        for (int i = 0; i <= JawelList.Count<JawelStruct>() - 1; i++)
                        {
                            binaryWriter.Write(JawelList[i].a_index);
                            binaryWriter.Write(Convert.ToInt32(JawelList[i].a_normal_compose_neednas));
                            binaryWriter.Write(Convert.ToInt32(JawelList[i].a_chaos_compose_neednas));
                            binaryWriter.Write(JawelList[i].a_normal_compose_prob);
                            binaryWriter.Write(JawelList[i].a_chaos_compose_prob);
                            binaryWriter.Write(JawelList[i].a_compose_normalToChaos_prob);
                            binaryWriter.Write(JawelList[i].a_normal_plus2_prob);
                            binaryWriter.Write(JawelList[i].a_normal_plus3_prob);
                            binaryWriter.Write(JawelList[i].a_chaos_plus2_prob);
                            binaryWriter.Write(JawelList[i].a_chaos_plus3_prob);
                            binaryWriter.Write(JawelList[i].a_normal_minus1_prob);
                            binaryWriter.Write(JawelList[i].a_normal_minus2_prob);
                            binaryWriter.Write(JawelList[i].a_normal_minus3_prob);
                            binaryWriter.Write(JawelList[i].a_chaos_minus1_prob);
                            binaryWriter.Write(JawelList[i].a_chaos_minus2_prob);
                            binaryWriter.Write(JawelList[i].a_chaos_minus3_prob);
                        }
                        binaryWriter.Close();
                        MessageBox.Show("Sucess!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
        }
    }
}
