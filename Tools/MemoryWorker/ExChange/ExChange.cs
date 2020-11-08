using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace LcDevPack_TeamDamonA.Tools.MemoryWorker.ExChange
{
    public partial class ExChange : Form
    {
        public ExChange()
        {
            InitializeComponent();
        }
        public static Connection connection = new Connection();
        private string Host = ExChange.connection.ReadSettings("Host");
        private string User = ExChange.connection.ReadSettings("User");
        private string Password = ExChange.connection.ReadSettings("Password");
        private string Database = ExChange.connection.ReadSettings("Database");
        private DatabaseHandle databaseHandle = new DatabaseHandle();
        private ExportLodHandle exportLodHandle = new ExportLodHandle();
        public static List<t_EXChange> ExChangeList = new List<t_EXChange>();
        public string _ClientPath = LcDevPack_TeamDamonA.Tools.MobEditor.connection.ReadSettings("ClientPath");

        private void LoadListBox()
        {
            MySqlConnection mysqlCon = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
            mysqlCon.Open();
            MySqlCommand Command = new MySqlCommand("SELECT * FROM t_item_exchange ORDER BY a_index ASC;", mysqlCon);
            Command.ExecuteNonQuery();
            MySqlDataReader Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                t_EXChange temp = new t_EXChange();
                temp.IndexID = (int)Reader["a_index"];
                temp.Enable = (int)Reader["a_enable"];
                temp.NpcIndex = (int)Reader["a_npc_index"];
                temp.ResultItemIdx = (int)Reader["result_itemIndex"];
                temp.ResultItemCount = (int)Reader["result_itemCount"];
                temp.SourceItemIndex0 = (int)Reader["source_itemIndex0"];
                temp.SourceItemIndex1 = (int)Reader["source_itemIndex1"];
                temp.SourceItemIndex2 = (int)Reader["source_itemIndex2"];
                temp.SourceItemIndex3 = (int)Reader["source_itemIndex3"];
                temp.SourceItemIndex4 = (int)Reader["source_itemIndex4"];
                temp.SourceItemCount0 = (int)Reader["source_itemCount0"];
                temp.SourceItemCount1 = (int)Reader["source_itemCount1"];
                temp.SourceItemCount2 = (int)Reader["source_itemCount2"];
                temp.SourceItemCount3 = (int)Reader["source_itemCount3"];
                temp.SourceItemCount4 = (int)Reader["source_itemCount4"];
                ExChangeList.Add(temp);
            }
            listBox1.Items.Clear();
            int sk = ExChangeList.Count();
            for (int i = 0; i < sk; i++)
            {
                int ID = ExChangeList[i].IndexID;
                int npcid = ExChangeList[i].NpcIndex;
                listBox1.Items.Add(ID + " - " + "NPC ID " + " - " + npcid);
            }
            mysqlCon.Close();
        }

        private void ExChange_Load(object sender, EventArgs e)
        {
            LoadListBox();
        }

        public int GetIndex()
        {
            try
            {
                return Convert.ToInt32(listBox1.Text.Split(' ')[0]);
            }
            catch
            {
                return 0;
            }
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
                int index = ExChangeList.FindIndex((t_EXChange p) => p.IndexID.Equals(Item));
                textBox1.Text = Convert.ToString(Item);
                textBox2.Text = ExChangeList[index].Enable.ToString();
                textBox3.Text = ExChangeList[index].NpcIndex.ToString();
                //resultitem
                textBox6.Text = ExChangeList[index].ResultItemIdx.ToString();
                textBox9.Text = ExChangeList[index].ResultItemCount.ToString();
                //need item
                tb_source_itemIndex0.Text = ExChangeList[index].SourceItemIndex0.ToString();
                tb_source_itemIndex1.Text = ExChangeList[index].SourceItemIndex1.ToString();
                tb_source_itemIndex2.Text = ExChangeList[index].SourceItemIndex2.ToString();
                tb_source_itemIndex3.Text = ExChangeList[index].SourceItemIndex3.ToString();
                tb_source_itemIndex4.Text = ExChangeList[index].SourceItemIndex4.ToString();
                //Count
                tb_count_itemIndex0.Text = ExChangeList[index].SourceItemCount0.ToString();
                tb_count_itemIndex1.Text = ExChangeList[index].SourceItemCount1.ToString();
                tb_count_itemIndex2.Text = ExChangeList[index].SourceItemCount2.ToString();
                tb_count_itemIndex3.Text = ExChangeList[index].SourceItemCount3.ToString();
                tb_count_itemIndex4.Text = ExChangeList[index].SourceItemCount4.ToString();

                try
                {
                    pictureBox1.Image = databaseHandle.IconItem(int.Parse(tbFileID.Text), int.Parse(tbFileRow.Text), int.Parse(tbFileCol.Text));
                    pictureBox3.Image = databaseHandle.IconItem(int.Parse(tbFileID0.Text), int.Parse(tbFileRow0.Text), int.Parse(tbFileCol0.Text));
                    pictureBox5.Image = databaseHandle.IconItem(int.Parse(tbFileID1.Text), int.Parse(tbFileRow1.Text), int.Parse(tbFileCol1.Text));
                    pictureBox7.Image = databaseHandle.IconItem(int.Parse(tbFileID2.Text), int.Parse(tbFileRow2.Text), int.Parse(tbFileCol2.Text));
                    pictureBox9.Image = databaseHandle.IconItem(int.Parse(tbFileID3.Text), int.Parse(tbFileRow3.Text), int.Parse(tbFileCol3.Text));
                    pictureBox11.Image = databaseHandle.IconItem(int.Parse(tbFileID4.Text), int.Parse(tbFileRow4.Text), int.Parse(tbFileCol4.Text));
                }
                catch
                {
                }
            }
        }

        private void IconResult()
        {
            string Query = "select a_index, a_texture_id, a_texture_row, a_texture_col FROM t_item WHERE a_index ='" + textBox6.Text + "';";
            string[] rows = new string[4]
            {
                "a_index",
                "a_texture_id",
                "a_texture_row",
                "a_texture_col"
            };
            Query.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'");
            string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query, rows);
            tbFileID.Text = strArray[1];
            tbFileRow.Text = strArray[2];
            tbFileCol.Text = strArray[3];
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            IconResult();
        }

        private void Iconsource_itemIndex0()
        {
            string Query = "select a_index, a_texture_id, a_texture_row, a_texture_col FROM t_item WHERE a_index ='" + tb_source_itemIndex0.Text + "';";
            string[] rows = new string[4]
            {
                "a_index",
                "a_texture_id",
                "a_texture_row",
                "a_texture_col"
            };
            Query.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'");
            string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query, rows);
            tbFileID0.Text = strArray[1];
            tbFileRow0.Text = strArray[2];
            tbFileCol0.Text = strArray[3];
        }

        private void tb_source_itemIndex0_TextChanged(object sender, EventArgs e)
        {
            Iconsource_itemIndex0();
        }

        private void Iconsource_itemIndex1()
        {
            string Query = "select a_index, a_texture_id, a_texture_row, a_texture_col FROM t_item WHERE a_index ='" + tb_source_itemIndex1.Text + "';";
            string[] rows = new string[4]
            {
                "a_index",
                "a_texture_id",
                "a_texture_row",
                "a_texture_col"
            };
            Query.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'");
            string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query, rows);
            tbFileID1.Text = strArray[1];
            tbFileRow1.Text = strArray[2];
            tbFileCol1.Text = strArray[3];
        }

        private void tb_source_itemIndex1_TextChanged(object sender, EventArgs e)
        {
            Iconsource_itemIndex1();
        }

        private void Iconsource_itemIndex2()
        {
            string Query = "select a_index, a_texture_id, a_texture_row, a_texture_col FROM t_item WHERE a_index ='" + tb_source_itemIndex2.Text + "';";
            string[] rows = new string[4]
            {
                "a_index",
                "a_texture_id",
                "a_texture_row",
                "a_texture_col"
            };
            Query.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'");
            string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query, rows);
            tbFileID2.Text = strArray[1];
            tbFileRow2.Text = strArray[2];
            tbFileCol2.Text = strArray[3];
        }

        private void tb_source_itemIndex2_TextChanged(object sender, EventArgs e)
        {
            Iconsource_itemIndex2();
        }

        private void Iconsource_itemIndex3()
        {
            string Query = "select a_index, a_texture_id, a_texture_row, a_texture_col FROM t_item WHERE a_index ='" + tb_source_itemIndex3.Text + "';";
            string[] rows = new string[4]
            {
                "a_index",
                "a_texture_id",
                "a_texture_row",
                "a_texture_col"
            };
            Query.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'");
            string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query, rows);
            tbFileID3.Text = strArray[1];
            tbFileRow3.Text = strArray[2];
            tbFileCol3.Text = strArray[3];
        }

        private void tb_source_itemIndex3_TextChanged(object sender, EventArgs e)
        {
            Iconsource_itemIndex3();
        }

        private void Iconsource_itemIndex4()
        {
            string Query = "select a_index, a_texture_id, a_texture_row, a_texture_col FROM t_item WHERE a_index ='" + tb_source_itemIndex4.Text + "';";
            string[] rows = new string[4]
            {
                "a_index",
                "a_texture_id",
                "a_texture_row",
                "a_texture_col"
            };
            Query.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'");
            string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query, rows);
            tbFileID4.Text = strArray[1];
            tbFileRow4.Text = strArray[2];
            tbFileCol4.Text = strArray[3];
        }

        private void tb_source_itemIndex4_TextChanged(object sender, EventArgs e)
        {
            Iconsource_itemIndex4();
        }

        //NPC Name
        private void NpcNameRead()
        {
            string Query = "select a_index, a_name FROM t_npc WHERE a_index ='" + textBox3.Text + "';";
            string[] rows = new string[2]
            {
                "a_index",
                "a_name"
            };
            Query.Replace("'", "\\'").Replace("\\", "\\\\").Replace("'", "\\'");
            string[] strArray = databaseHandle.SelectMySqlReturnArray(Host, User, Password, Database, Query, rows);
            textBox4.Text = strArray[1];
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            NpcNameRead();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.listBox1.Items.Count != 0)
            {
                int iD = ExChangeList[ExChangeList.Count - 1].IndexID + 1;
                t_EXChange temp = new t_EXChange();
                temp.IndexID = iD;
                ExChangeList.Add(temp);                
                this.listBox1.Items.Clear();
                int num = ExChangeList.Count<t_EXChange>();
                for (int i = 0; i < num; i++)
                {
                    int iD2 = ExChangeList[i].IndexID;
                    int npcid = ExChangeList[i].NpcIndex;
                    this.listBox1.Items.Add(iD2 + " - " + npcid);
                }
                if (this.checkBox1.Checked)
                {
                    //Mysql Insert
                    MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand3 = new MySqlCommand(string.Concat(new object[]
                                    {
                                    "INSERT INTO t_item_exchange (a_index,a_enable)VALUES('",
                                    iD,
                                    "','1",
                                    "');"
                                    }), mySqlConnection);
                    mySqlCommand3.ExecuteNonQuery();
                    mySqlConnection.Close();
                }
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
                    string Query = "DELETE FROM t_item_exchange WHERE a_index = '" + textBox1.Text + "'";
                    databaseHandle.SendQueryMySql(Host, User, Password, Database, Query);
                }
                int id = int.Parse(array[0]);
                int num = ExChangeList.FindIndex((t_EXChange p) => p.IndexID.Equals(id));
                if (num != -1)
                {
                    ExChangeList.RemoveAt(num);
                    this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
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

        private void PbSelectID1_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            textBox6.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            tb_source_itemIndex0.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            tb_source_itemIndex1.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            tb_source_itemIndex2.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            tb_source_itemIndex3.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            tb_source_itemIndex4.Text = Convert.ToString(itemPicker.ItemIndex);
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
                int num = ExChangeList.FindIndex((t_EXChange p) => p.IndexID.Equals(ID));
                //MYSQL DELATE
                if (this.checkBox1.Checked)
                {
                    Update_To_DB_SELECT();
                }

                if (num != -1)
                {
                    ExChangeList[num].IndexID = Convert.ToInt32(textBox1.Text);
                    ExChangeList[num].Enable = Convert.ToInt32(textBox2.Text);
                    ExChangeList[num].NpcIndex = Convert.ToInt32(textBox3.Text);
                    //result Item
                    ExChangeList[num].ResultItemIdx = Convert.ToInt32(textBox6.Text);
                    ExChangeList[num].ResultItemCount = Convert.ToInt32(textBox9.Text);
                    //Need Item
                    ExChangeList[num].SourceItemIndex0 = Convert.ToInt32(tb_source_itemIndex0.Text);
                    ExChangeList[num].SourceItemIndex1 = Convert.ToInt32(tb_source_itemIndex1.Text);
                    ExChangeList[num].SourceItemIndex2 = Convert.ToInt32(tb_source_itemIndex2.Text);
                    ExChangeList[num].SourceItemIndex3 = Convert.ToInt32(tb_source_itemIndex3.Text);
                    ExChangeList[num].SourceItemIndex4 = Convert.ToInt32(tb_source_itemIndex4.Text);
                    //Count Item 
                    ExChangeList[num].SourceItemCount0 = Convert.ToInt32(tb_count_itemIndex0.Text);
                    ExChangeList[num].SourceItemCount1 = Convert.ToInt32(tb_count_itemIndex1.Text);
                    ExChangeList[num].SourceItemCount2 = Convert.ToInt32(tb_count_itemIndex2.Text);
                    ExChangeList[num].SourceItemCount3 = Convert.ToInt32(tb_count_itemIndex3.Text);
                    ExChangeList[num].SourceItemCount4 = Convert.ToInt32(tb_count_itemIndex4.Text);
                }
                this.listBox1.Items.Clear();
                int num1 = ExChangeList.Count<t_EXChange>();
                for (int i = 0; i < num1; i++)
                {
                    int iD2 = ExChangeList[i].IndexID;
                    int npcid = ExChangeList[i].NpcIndex;
                    this.listBox1.Items.Add(iD2 + " - " + npcid);
                }
            }
        }

        private void Update_To_DB_SELECT()
        {
            MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(string.Concat(new string[]
            {
                    "UPDATE t_item_exchange SET a_index = '",
                    this.textBox1.Text,
                    "',a_enable = '",
                    this.textBox2.Text,
                    "',a_npc_index = '",
                    this.textBox3.Text,
                    //Result
                    "',a_result_itemIndex = '",
                    this.textBox6.Text,
                    "',a_result_itemCount = '",
                    this.textBox9.Text,
                    //Need Item
                    "',source_itemIndex0 = '",
                    this.tb_source_itemIndex0.Text,
                    "',source_itemIndex1 = '",
                    this.tb_source_itemIndex1.Text,
                    "',source_itemIndex2 = '",
                    this.tb_source_itemIndex2.Text,
                    "',source_itemIndex3 = '",
                    this.tb_source_itemIndex3.Text,
                    "',source_itemIndex4 = '",
                    this.tb_source_itemIndex4.Text,
                    "',source_itemCount0 = '",
                    this.tb_count_itemIndex0.Text,
                    "',source_itemCount1 = '",
                    this.tb_count_itemIndex1.Text,
                    "',source_itemCount2 = '",
                    this.tb_count_itemIndex2.Text,
                    "',source_itemCount3 = '",
                    this.tb_count_itemIndex3.Text,
                    "',source_itemCount4 = '",
                    this.tb_count_itemIndex4.Text,
                    "' WHERE a_index = '",
                    this.textBox1.Text,
                    "';"
            }), mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
        }

        private void saveToLodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listBox1.Items.Count != 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "item_exchange*.lod|item_exchange*.lod|data|*.data|All|*.*";
                saveFileDialog.Title = "Save item_exchange*.lod";
                saveFileDialog.InitialDirectory = _ClientPath;
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "")
                {
                    try
                    {
                        FileStream output = new FileStream(saveFileDialog.FileName, FileMode.Create);
                        BinaryWriter binaryWriter = new BinaryWriter(output);
                        binaryWriter.Write(ExChangeList.Count);
                        binaryWriter.Write(ExChangeList[ExChangeList.Count - 1].IndexID);
                        for (int i = 0; i <= ExChangeList.Count<t_EXChange>() - 1; i++)
                        {
                            binaryWriter.Write(ExChangeList[i].IndexID);
                            binaryWriter.Write(ExChangeList[i].NpcIndex);
                            binaryWriter.Write(ExChangeList[i].ResultItemIdx);
                            binaryWriter.Write(ExChangeList[i].ResultItemCount);
                            binaryWriter.Write(ExChangeList[i].SourceItemIndex0);
                            binaryWriter.Write(ExChangeList[i].SourceItemCount0);
                            binaryWriter.Write(ExChangeList[i].SourceItemIndex1);
                            binaryWriter.Write(ExChangeList[i].SourceItemCount1);
                            binaryWriter.Write(ExChangeList[i].SourceItemIndex2);
                            binaryWriter.Write(ExChangeList[i].SourceItemCount2);
                            binaryWriter.Write(ExChangeList[i].SourceItemIndex3);
                            binaryWriter.Write(ExChangeList[i].SourceItemCount3);
                            binaryWriter.Write(ExChangeList[i].SourceItemIndex3);
                            binaryWriter.Write(ExChangeList[i].SourceItemCount3);
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
