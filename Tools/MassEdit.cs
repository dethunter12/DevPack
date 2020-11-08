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
    public partial class MassEdit : Form //dethunter12 add
    {
        private string Host = ItemEditor2.connection.ReadSettings("Host");
        private string User = ItemEditor2.connection.ReadSettings("User");
        private string Password = ItemEditor2.connection.ReadSettings("Password");
        private string Database = ItemEditor2.connection.ReadSettings("Database");
        private DatabaseHandle databaseHandle = new DatabaseHandle();
        public MassEdit()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateMass_Click(object sender, EventArgs e)
        {
            if (TbMinLevelMass.Text != "" && tbMaxLevelMass.Text != "" && tbFlagMass.Text != "" && tbNum0Mass.Text != "" && tbNum1Mass.Text != "" && tbNum2Mass.Text != "" && tbPriceMass.Text != "" && tbStackMass.Text != "" && tbRange1.Text != "" && tbRange2.Text != "")
            {
                string str1 = "UPDATE t_item SET " + "a_level = '" + TbMinLevelMass.Text + "', " + "a_level2 = '" + tbMaxLevelMass.Text + "', " + "a_flag = '" + tbFlagMass.Text + "', ";
                databaseHandle.SendQueryMySql(Host, User, Password, Database, str1 + "a_price = '" + tbPriceMass.Text + "', " + "a_num_0 = '" + tbNum0Mass.Text + "', " + "a_num_1 = '" + tbNum1Mass.Text + "', " + "a_num_2 = '" + tbNum2Mass.Text + "', " + "a_weight = '" + tbStackMass.Text + "'" + " " + "WHERE a_index BETWEEN '" + tbRange1.Text + "'" + " " + "AND'" + tbRange2.Text + "'" + ";");
                int num2 = (int)new CustomMessage("Done!").ShowDialog();
                Close(); //dethunter12 adjust 12/23/2019
            }
            else if (tbRange2.Text.Equals("") || tbRange1.Text.Equals(""))
            {
                int num2 = (int)new CustomMessage("Please Enter 2 Ranges of Numbers").ShowDialog();
            }
            else if (TbMinLevelMass.Text == "" || tbMaxLevelMass.Text == "" || tbFlagMass.Text == "" || tbNum0Mass.Text == "" || tbNum1Mass.Text == "" || tbNum2Mass.Text == "" || tbPriceMass.Text == "" || tbStackMass.Text == "")
            {
                int num2 = (int)new CustomMessage("Fill in the textbox fields!").ShowDialog();
            }

        }

        private void PbSelectID1_Click(object sender, EventArgs e) //dethunter12 add 6/10/2018
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            tbRange1.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void PbSelectID2_Click(object sender, EventArgs e) //dethunter12 add 6/10/2018
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            tbRange2.Text = Convert.ToString(itemPicker.ItemIndex);
        }
    }
    }

