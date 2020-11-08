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
    public partial class MassPrice : Form
    {
        //5/30/2020
        private string Host = ItemEditor2.connection.ReadSettings("Host");
        private string User = ItemEditor2.connection.ReadSettings("User");
        private string Password = ItemEditor2.connection.ReadSettings("Password");
        private string Database = ItemEditor2.connection.ReadSettings("Database");
        private string language = ItemEditor2.connection.ReadSettings("Language");
        private DatabaseHandle databaseHandle = new DatabaseHandle();
        public MassPrice()
        {
            InitializeComponent();
        }

        private void BtnUpdateSelectedRange_Click(object sender, EventArgs e)
        {
            if (tbRange1.Text == "" || tbRange2.Text == "")
            {
                int num2 = (int)new CustomMessage("Insert a value in ranges!").ShowDialog();
            }
            else
            {
                databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_item SET  a_price  = '" + TbPrice.Text + "'"  + "WHERE a_index BETWEEN '" + tbRange1.Text + "'" + " " + "AND'" + tbRange2.Text + "'" + ";");
                int num2 = (int)new CustomMessage("Done!").ShowDialog();
            }

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
    }
}
