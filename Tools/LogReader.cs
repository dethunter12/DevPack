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
    public partial class LogReader : Form
    {
        public LogReader()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void openLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Log Files|*.log";
            openFileDialog.Title = "Select a Log File";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            string[] strArray = File.ReadAllLines(openFileDialog.FileName);
            for (int index = 0; index < strArray.Length; ++index)
            {
                if (strArray[index].Contains("HACK_QUICK") || strArray[index].Contains("HACK QUICK") || (strArray[index].Contains("HACK_PULSE") || strArray[index].Contains("HACK PULSE")) || (strArray[index].Contains("HACK_WEAPON") || strArray[index].Contains("HACK WEAPON") || (strArray[index].Contains("HACK USER") || strArray[index].Contains("HACK_USER"))) || (strArray[index].Contains("HACK_PULSE_NOT_RESPONSE") || strArray[index].Contains("HACK PULSE NOT RESPONSE") || (strArray[index].Contains("HACK_CHECK") || strArray[index].Contains("HACK CHECK")) || (strArray[index].Contains("TELEPORT_HACK") || strArray[index].Contains("TELEPORT HACK") || (strArray[index].Contains("HACK ATTACK") || strArray[index].Contains("HACK_ATTACK")))) || (strArray[index].Contains("MOVE_HACK") || strArray[index].Contains("MOVE_HACK") || strArray[index].Contains("HACK_MOVE")) || strArray[index].Contains("HACK MOVE"))
                    this.listBox2.Items.Add(strArray[index]);
                if (strArray[index].Contains("ITEM_DROP") || strArray[index].Contains("ITEM_LOAD") || strArray[index].Contains("GM COMMAND"))
                    this.listBox1.Items.Add(strArray[index]);
                if (strArray[index].Contains("ITEM_JUNK") || strArray[index].Contains("ITEM_PICK") || (strArray[index].Contains("ITEM_SELL") || strArray[index].Contains("ITEM_BUY")) || (strArray[index].Contains("ITEM_BREAK") || strArray[index].Contains("ITEM_EXCHANGE") || (strArray[index].Contains("ITEM_ADJUST") || strArray[index].Contains("ITEM_UPGRADE"))) || (strArray[index].Contains("ITEM_MIX") || strArray[index].Contains("ITEM_MAKE") || (strArray[index].Contains("ITEM_PROCESS") || strArray[index].Contains("ITEM_PROCESS_SAMPLE")) || (strArray[index].Contains("ITEM_OPTION_DEL") || strArray[index].Contains("ITEM_REFINE") || (strArray[index].Contains("ITEM_OPTION_ADD") || strArray[index].Contains("ITEM_ARCANE")))) || (strArray[index].Contains("ITEM_PICK_QUESTPRIZE") || strArray[index].Contains("ITEM_PICK_LEVELUP")) || strArray[index].Contains("WEAR ITEM"))
                    this.listBox3.Items.Add(strArray[index]);
                if (strArray[index].Contains("CHAR_UPATE") || strArray[index].Contains("CHAR_DELETE") || (strArray[index].Contains("CHAR_CREATE") || strArray[index].Contains("CHAR_LOAD")) || (strArray[index].Contains("REBIRTH PC") || strArray[index].Contains("LEVEL_UP") || (strArray[index].Contains("HAVE_MONEY") || strArray[index].Contains("PERSONAL SHOP BUY"))) || strArray[index].Contains("PERSONAL SHOP START") || strArray[index].Contains("CHAR_DEAUTH"))
                    this.listBox4.Items.Add(strArray[index]);
                if (strArray[index].Contains("GUILD_NEW") || strArray[index].Contains("GUILD_CREATE") || (strArray[index].Contains("GUILD_DEL") || strArray[index].Contains("GUILD_KICK")) || (strArray[index].Contains("GUILD_LEAVE") || strArray[index].Contains("GUIL_SET_GRADE")) || strArray[index].Contains("GUILD_JOIN"))
                    this.listBox5.Items.Add(strArray[index]);
                if (strArray[index].Contains("BAD_CONNECTION") || strArray[index].Contains("SYS_ERROR") || (strArray[index].Contains("SYS_ERR") || strArray[index].Contains("CONN_ERR")) || strArray[index].Contains("INVALID_VERSION"))
                    this.listBox6.Items.Add(strArray[index]);
                if (strArray[index].Contains("STASH_IN") || strArray[index].Contains("STASH_OUT"))
                    this.listBox7.Items.Add(strArray[index]);
                if (strArray[index].Contains("JOIN") || strArray[index].Contains("DISCONNECT"))
                    this.listBox8.Items.Add(strArray[index]);
                if (strArray[index].Contains("QUEST REQUEST") || strArray[index].Contains("QUEST START") || (strArray[index].Contains("QUEST COMPLETE") || strArray[index].Contains("QUEST GIVEUP")) || (strArray[index].Contains("QUEST FAIL") || strArray[index].Contains("QUEST PRIZE")) || strArray[index].Contains("QUEST ERROR"))
                    this.listBox9.Items.Add(strArray[index]);
                if (strArray[index].Contains("TITLE ITEM USE") || strArray[index].Contains("TITLE SELECT"))
                    this.listBox10.Items.Add(strArray[index]);
                if (strArray[index].Contains("MOB DEAD") || strArray[index].Contains("MOB DROP MONEY") || strArray[index].Contains("MOD DROP ITEM") || strArray[index].Contains("MOB REGEN"))
                    this.listBox11.Items.Add(strArray[index]);
                if (strArray[index].Contains("CASH_ASSIST_DEL") || strArray[index].Contains("CASH_ABS_ASSIST") || strArray[index].Contains("CASH_MEMPOS_STASH_TIME"))
                    this.listBox12.Items.Add(strArray[index]);
                if (strArray[index].Contains("EP SKILL END") || strArray[index].Contains("EP SKILL START") || strArray[index].Contains("SKILL LEARN"))
                    this.listBox14.Items.Add(strArray[index]);
            }
        }
    }
}
