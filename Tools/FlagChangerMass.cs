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
    public partial class FlagChangerMass : Form
    {
        private string Host = ItemEditor2.connection.ReadSettings("Host");
        private string User = ItemEditor2.connection.ReadSettings("User");
        private string Password = ItemEditor2.connection.ReadSettings("Password");
        private string Database = ItemEditor2.connection.ReadSettings("Database");
        private string Episode = ItemEditor2.connection.ReadSettings("Episode");
        public string flagBuilderType = "items"; //dethunter12 add
        public long flagBig; //dethunter12 add
        public int flagSmall; //dethunter12 add
        private DatabaseHandle databaseHandle = new DatabaseHandle();
        public FlagChangerMass()
        {
            InitializeComponent();
        }

        private void PbSelectID1_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            tbRange1.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void PbSelectID2_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            tbRange2.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void btnUpdateSelectedRange_Click(object sender, EventArgs e)
        {
            if (tbItemFlag.Text != "" && tbRange1.Text != "" && tbRange2.Text != "")
            {
                databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_item SET a_flag ='" + tbItemFlag.Text + "'" +  "WHERE a_index BETWEEN '" + tbRange1.Text + "'" + " " + "AND'" + tbRange2.Text + "'" + ";");
                FlagChangerMass flagChangerMass = new FlagChangerMass();//dethunter12 edit 10/4/2019
                flagChangerMass.Close();//dethunter12 edit 10/4/2019
                int num2 = (int)new CustomMessage("DONE!").ShowDialog();

            }
            else if (tbItemFlag.Text != "" && tbRange1.Text != "" && tbRange2.Text.Equals(""))
            {
                int num2 = (int)new CustomMessage("Please Enter Range 2 Value").ShowDialog();
            }
            else if (tbItemFlag.Text != "" && tbRange1.Text.Equals("") && tbRange2.Text != "")
            {
                int num2 = (int)new CustomMessage("Please Enter Range 1 Value").ShowDialog();
            }
            else if (tbItemFlag.Text.Equals(0) && tbRange1.Text != "" && tbRange2.Text != "")
            {
                int num2 = (int)new CustomMessage("Please Select a Flag").ShowDialog();
            }

        }

        private void FlagChangerMass_Load(object sender, EventArgs e)
        {
            ClbItemFlag.Items.AddRange(new object[64] //dethunter12 test item flag move
       {
           "Count",
           "Drop",
           "Upgrade",
           "Exchange",
           "Trade",
           "Not Delete",
           "Made",
           "Mix",
           "Cash",
           "Lord",
           "No Stash",
           "Change",
           "Composite",
           "Duplication",
           "lent",
           "Rare",
           "ABS",
           "Not Reform",
           "ZoneMove Del",
           "Origin",
           "Trigger",
           "Raid Special",
           "Quest",
           "Box",
           "Not TradeAgent",
           "Durability",
           "Costume2",
           "Socket",
           "Seller",
           "Castillan",
           "LetsParty",
           "Non-RVR",
           "Quest Give",
           "Toggle",
           "Compose",
           "NotSingle",
           "Invisible Custom",
           "37 ",
           "38 ",
           "39 ",
           "40 ",
           "41 ",
           "42 ",
           "43 ",
           "44 ",
           "45 ",
           "46 ",
           "47 ",
           "48 ",
           "49 ",
           "50 ",
           "51 ",
           "52 ",
           "53 ",
           "54 ",
           "55 ",
           "56 ",
           "57 ",
           "58 ",
           "59 ",
           "60 ",
           "61 ",
           "62 ",
           "63 "
       });
            
        }

        private void ClbItemFlag_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            {
                long num = 0;
                for (int index = 0; index < ClbItemFlag.Items.Count; ++index)
                {
                    if (ClbItemFlag.GetItemChecked(index))
                        num += 1L << index;
                }
                tbItemFlag.Text = num.ToString();
                if (flagBuilderType == "items")
                {
                    if (Episode == "EP4")
                        flagBig = num;
                    else
                        flagSmall = Convert.ToInt32(num);
                }
                else
                    flagSmall = Convert.ToInt32(num);
            }
        }
    }
}
