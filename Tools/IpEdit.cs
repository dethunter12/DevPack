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


namespace LcDevPack_TeamDamonA.Tools
{
    public partial class IpEdit : Form
    {
        
        private System.Collections.Specialized.StringCollection folderCol;
        public IpEdit()
        {
            InitializeComponent();
      
        }
        public static int Version;
        public static byte[] Header_lccnct;
        public static byte[] Header_sl;
        public static string urliptxt;
        private void CreateHeadersAndFillListView()
        {
            ColumnHeader colHead;

            colHead = new ColumnHeader();
            colHead.Text = "Filename";
            this.listView1.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Size";
            this.listView1.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Last accessed";
            this.listView1.Columns.Add(colHead);
        }
        private void PaintListView(string root)
        {
            try
            {
                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;

                if (root.CompareTo("") == 0)
                    return;
                DirectoryInfo dir = new DirectoryInfo(root);
                DirectoryInfo[] dirs = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();

                this.listView1.Items.Clear();
                this.label4.Text = root;
                this.listView1.BeginUpdate();
                foreach (DirectoryInfo di in dirs)
                {
                    lvi = new ListViewItem();
                    lvi.Text = di.Name;
                    lvi.Tag = di.FullName;

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = "";

                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = di.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvsi);

                    this.listView1.Items.Add(lvi);
                }

                foreach (FileInfo fi in files)
                {
                    lvi = new ListViewItem();
                    lvi.Text = fi.Name;
                    lvi.Tag = fi.FullName;

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.Length.ToString();
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvsi);
                    this.listView1.Items.Add(lvi);
                }
                this.listView1.EndUpdate();
            }
            catch (System.Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }


        public string readdtafile(string FileName)
        {
            ASCIIEncoding asciiEncoding = new ASCIIEncoding();
            BinaryReader binaryReader = new BinaryReader(System.IO.File.Open(FileName, FileMode.Open));
            int count1 = 19;
            int count2 = (int)binaryReader.BaseStream.Length - count1;
            byte[] numArray = binaryReader.ReadBytes(count1);
            if (Path.GetFileName(FileName) == "lccnct.dta")
                IpEdit.Header_lccnct = numArray;
            if (Path.GetFileName(FileName) == "sl.dta")
                IpEdit.Header_sl = numArray;
            byte[] bytes = binaryReader.ReadBytes(count2);
            binaryReader.Close();
            byte num = numArray[10];
            for (int index = 0; index < count2; ++index)
            {
                bytes[index] -= num;
                num += bytes[index];
            }
            return asciiEncoding.GetString(bytes);
        }
        public void saveDTAFile(string NewInput, string FileName)
        {
            ASCIIEncoding asciiEncoding = new ASCIIEncoding();
            byte[] buffer = new byte[0];
            if (Path.GetFileName(FileName) == "lccnct.dta")
                buffer = IpEdit.Header_lccnct;
            if (Path.GetFileName(FileName) == "sl.dta")
                buffer = IpEdit.Header_sl;
            byte[] bytes = asciiEncoding.GetBytes(NewInput);
            byte num = buffer[10];
            for (int index = 0; index < bytes.Length; ++index)
            {
                bytes[index] += num;
                num = bytes[index];
            }
            BinaryWriter binaryWriter = new BinaryWriter((Stream)System.IO.File.Create(FileName));
            binaryWriter.Write(buffer);
            binaryWriter.Write(bytes);
            binaryWriter.Close();
        }
        public void OpenVTM()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "LC Versions file to open";
            openFileDialog.InitialDirectory = "";
            openFileDialog.Filter = "brn|vtm.brn";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                BinaryReader binaryReader = new BinaryReader(System.IO.File.Open(openFileDialog.FileName, FileMode.Open));
                IpEdit.Version = binaryReader.ReadInt32();
                binaryReader.Close();
                IpEdit.Version = (IpEdit.Version - 27) / 3;
                this.textBoxversion.Text = IpEdit.Version.ToString();

            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show((IWin32Window)this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }
        public void OppenIP()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "LC IP file to open";
            openFileDialog.InitialDirectory = "";
            openFileDialog.Filter = "dta|sl.dta";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            this.textBoxIP.Text = this.readdtafile(openFileDialog.FileName);
        }
        public void OpenURL()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "LC URL file to open";
            openFileDialog.InitialDirectory = "";
            openFileDialog.Filter = "dta|lccnct.dta";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            this.textBoxURL.Text = this.readdtafile(openFileDialog.FileName);
        }
        public void SaveVER()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "brn|vtm.brn";
            saveFileDialog.Title = "LC Versions file to save";
            saveFileDialog.FileName = "vtm.brn";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel || !(saveFileDialog.FileName != ""))
                return;
            int num = (Convert.ToInt32(this.textBoxversion.Text) + 9) * 3;
            BinaryWriter binaryWriter = new BinaryWriter(System.IO.File.Create(saveFileDialog.FileName));
            binaryWriter.Write(num);
            binaryWriter.Close();
        }
        public void SaveIP()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "dta|sl.dta";
            saveFileDialog.Title = "LC IP file to save";
            saveFileDialog.FileName = "sl.dta";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel || !(saveFileDialog.FileName != ""))
                return;
            this.saveDTAFile(this.textBoxIP.Text, saveFileDialog.FileName);

        }
        public void SaveURL()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "dta|lccnct.dta";
            saveFileDialog.Title = "LC URL file to save";
            saveFileDialog.FileName = "lccnct.dta";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel || !(saveFileDialog.FileName != ""))
                return;
            this.saveDTAFile(this.textBoxURL.Text, saveFileDialog.FileName);
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenVTM();
            OppenIP();
            OpenURL();
        }
        MemoryStream userInput = new MemoryStream();
        private void button1_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@""+ textBox2.Text +"/LCNotes.txt");

            writer.Write(richTextBox1.Text);

            writer.Close();

        }
        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveVER();
            SaveIP();
            SaveURL();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult button2_Click = folderBrowserDialog1.ShowDialog();
            if (button2_Click == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                textBox2.Text = folderBrowserDialog1.SelectedPath;

            }

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string path;
            path = folderBrowserDialog1.SelectedPath;
            textBox2.Text = path;
            folderCol = new System.Collections.Specialized.StringCollection();
            CreateHeadersAndFillListView();
            PaintListView(@"" + textBox2.Text + "");
            folderCol.Add(@"" + textBox2.Text + "");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxIP.Clear();
            textBoxURL.Clear();
            textBoxversion.Clear();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView lw = (System.Windows.Forms.ListView)sender;
            string filename = lw.SelectedItems[0].Tag.ToString();

            if (lw.SelectedItems[0].ImageIndex != 0)
            {
                try
                {
                    System.Diagnostics.Process.Start(filename);
                }
                catch
                {
                    return;
                }
            }
            else
            {
               PaintListView(filename);
                folderCol.Add(filename);
            }
        }
    }
}
