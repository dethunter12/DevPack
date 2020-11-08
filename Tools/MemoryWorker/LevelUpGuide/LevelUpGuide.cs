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
namespace LcDevPack_TeamDamonA.Tools.MemoryWorker.LevelUpGuide
{
    public partial class LevelUpGuide : Form
    {
        public static string stritem;
        public static string stritemname;
        public static List<LevelUP> ItemList = new List<LevelUP>();
        public string _ClientPath = LcDevPack_TeamDamonA.Tools.MobEditor.connection.ReadSettings("ClientPath");
        public LevelUpGuide()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Abrir levelup_guide.bin";
            openFileDialog.InitialDirectory = _ClientPath;
            openFileDialog.Filter = "levelup_guide.bin|levelup_guide.bin|All|*.*";
            if (openFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                OpenFileDialog openFileDialog2 = new OpenFileDialog();
                openFileDialog2.Title = "Abrir strClient_us.lod";
                openFileDialog2.InitialDirectory = _ClientPath;
                openFileDialog2.Filter = "strClient*.lod|strClient*.lod|All|*.*";
                if (openFileDialog2.ShowDialog() != DialogResult.Cancel)
                {
                    ItemList.Clear();
                    ItemListBox.Items.Clear();
                    this.ReadItem(openFileDialog.FileName);
                    this.ReadItemName(openFileDialog2.FileName);
                    this.makelist();
                }
            }
        }

        private void ReadItem(string itemsource)
        {
            using (BinaryReader b = new BinaryReader(File.Open(itemsource, FileMode.Open)))
            {
                int num = b.ReadInt32();
                while (b.BaseStream.Position < b.BaseStream.Length)
                {
                    LevelUP temp = new LevelUP();
                    temp.Level = b.ReadInt32();
                    temp.StringIndex = b.ReadInt32();
                    ItemList.Add(temp);
                }
            }
        }

        private void ReadItemName(string itemnamesource)
        {
            using (BinaryReader binaryReader = new BinaryReader(File.Open(itemnamesource, FileMode.Open)))
            {
                int num = binaryReader.ReadInt32();
                int num2 = binaryReader.ReadInt32();
                while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
                {
                    int ID = binaryReader.ReadInt32();
                    int num3 = ItemList.FindIndex((LevelUP p) => p.StringIndex.Equals(ID));
                    string @string = Encoding.GetEncoding("ISO-8859-1").GetString(binaryReader.ReadBytes(binaryReader.ReadInt32()));
                    if (num3 != -1)
                    {
                        ItemList[num3].Name = @string;
                    }
                }
                binaryReader.Close();
                binaryReader.Dispose();
            }
        }

        private void makelist()
        {
            List<LevelUP> list = (from o in ItemList
                                  orderby o.Level
                                  select o).ToList<LevelUP>();
            int num = list.Count<LevelUP>();
            for (int i = 0; i < num; i++)
            {
                int itemID = list[i].Level;
                string name = list[i].Name;
                this.ItemListBox.Items.Add(string.Concat(new object[]
                {
                    itemID,
                    " - ",
                    name,
                    ")"
                }));
            }
        }

        public int GetIDFromList()
        {
            int result;
            try
            {
                result = Convert.ToInt32(this.ItemListBox.Text.Split(new char[]
                {
                    ' '
                })[0]);
            }
            catch
            {
                result = 2;
            }
            return result;
        }

        public void ViewItem()
        {
            int ID = this.GetIDFromList();
            int index = ItemList.FindIndex((LevelUP p) => p.Level.Equals(ID));
            this.textBox1.Text = ItemList[index].Level.ToString();
            this.textBox2.Text = ItemList[index].StringIndex.ToString();
            this.richTextBox1.Text = ItemList[index].Name;
        }

        private void ItemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewItem();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ItemListBox.Items.Count != 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "levelup_guide.bin|levelup_guide*.bin|bin|*.bin|All|*.*";
                saveFileDialog.Title = "Save levelup_guide.bin";
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "")
                {
                    try
                    {
                        FileStream output = new FileStream(saveFileDialog.FileName, FileMode.Create);
                        BinaryWriter binaryWriter = new BinaryWriter(output);
                        binaryWriter.Write(ItemList[ItemList.Count - 1].Level);
                        for (int i = 0; i <=ItemList.Count<LevelUP>() - 1; i++)
                        {
                            binaryWriter.Write(ItemList[i].Level);
                            binaryWriter.Write(ItemList[i].StringIndex);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ItemListBox.Items.Count != 0)
            {
                DialogResult messageBoxResult = MessageBox.Show("Are you sure you want to add new record?", "Adder", MessageBoxButtons.YesNo);
                if (messageBoxResult == DialogResult.Yes)
                {
                    int iD = ItemList[ItemList.Count - 1].Level + 1;
                    LevelUP temp = new LevelUP();
                    temp.Level = iD;
                    temp.StringIndex = 1;
                    ItemList.Add(temp);
                    this.ItemListBox.Items.Clear();
                }
            }
            this.ItemListBox.SelectedIndex = this.ItemListBox.Items.Count - 1;
            this.makelist();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.ItemListBox.SelectedIndex != -1)
            {
                DialogResult messageBoxResult = MessageBox.Show("Are you sure you want to save the record?", "Save Select", MessageBoxButtons.YesNo);
                if (messageBoxResult == DialogResult.Yes)
                {
                    this.SaveLevelGuide();
                    this.makelist();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ID = this.GetIDFromList();
            int num = ItemList.FindIndex((LevelUP p) => p.Level.Equals(ID));
            if (num != -1)
            {
                DialogResult messageBoxResult = MessageBox.Show("Are you sure you want to delete the record?", "removal", MessageBoxButtons.YesNo);
                if (messageBoxResult == DialogResult.Yes)
                {
                    ItemList.RemoveAt(num);
                    this.makelist();
                }
            }
        }

        private void SaveLevelGuide()
        {
            try
            {
                int ID = this.GetIDFromList();
                int num = ItemList.FindIndex((LevelUP p) => p.Level.Equals(ID));
                if (num != -1)
                {
                    ItemList[num].Level = Convert.ToInt32(this.textBox1.Text);
                    ItemList[num].StringIndex = Convert.ToInt32(this.textBox2.Text);

                }
            }
            catch (Exception)
            {
            }
        }
    }
}
