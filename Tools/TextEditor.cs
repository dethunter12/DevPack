using System;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools
{
    public partial class TextEditor : Form
    {
        private string FileName;
        public TextEditor(string FileName)
        {
            InitializeComponent();
            FileName = FileName;
            if (!File.Exists(FileName))
                return;
            RTbSMC.Text = File.ReadAllText(FileName);
            RTbSMC.Select(0, 0);
            Text = FileName;
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close(); //close lol
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Text, RTbSMC.Text); //dethunter12 adjust
            int num4 = (int)new CustomMessage("Saved").ShowDialog();
        }
    }
}
