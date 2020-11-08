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
    public partial class MassEditSeals : Form
    {
      //dethunter12 add
      //to initialize a paramater in which to send data to db.
        private string Host = ItemEditor2.connection.ReadSettings("Host");
        private string User = ItemEditor2.connection.ReadSettings("User");
        private string Password = ItemEditor2.connection.ReadSettings("Password");
        private string Database = ItemEditor2.connection.ReadSettings("Database");
        private DatabaseHandle databaseHandle = new DatabaseHandle();
        public MassEditSeals()
        {
            InitializeComponent();
        }

        private void btnTips_Click(object sender, EventArgs e)
        {
            //randomly generate a tip when button is clicked.
            Random r = new Random();
            int rInt = r.Next(1, 5);
            if (rInt == 1)
            {
                MessageBox.Show("If you're dealing with rareoption items start with option 0 if not start with option 1");
            }
            else if (rInt == 2)
            {
                MessageBox.Show("Rare Options operate off a chance based off 10000 being 100%");
            }
            else if (rInt == 3)
            {
                MessageBox.Show("Option is a_type from t_option and level represents the value ");
            }
            else if (rInt ==4)
            {
                MessageBox.Show("The 7th slot is usually for weapon armor skills");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (TbOption0.Text != "" && TbLevel0.Text != "" && TbOption1.Text != "" && TbLevel1.Text != "" && TbOption2.Text != "" && TbLevel2.Text != "" && TbOption3.Text != "" && TbLevel3.Text != "" && TbOption4.Text != "" && TbLevel4.Text != "" && TbOption5.Text !="" && TbLevel5.Text != "" && TbOption6.Text !="" && TbLevel6.Text != "" && TbOption7.Text != "" && TbLevel7.Text != "" && TbOption8.Text != "" && TbLevel8.Text != "" && TbOption9.Text != "" && TbLevel9.Text != "" && tbRange1.Text != "" && tbRange2.Text != "") // to confirm the fields aren't empty
            {
                //if not empty execture this
                string str1 = "UPDATE t_item SET " + "a_rare_index_0 = '" + TbOption0.Text + "', " + "a_rare_index_1 = '" + TbOption1.Text + "', " + "a_rare_index_2 = '" + TbOption2.Text + "', " + "a_rare_index_3 = '" + TbOption3.Text + "', " + "a_rare_index_4 = '" + TbOption4.Text + "', " + "a_rare_index_5 = '" + TbOption5.Text + "', " + "a_rare_index_6 = '" + TbOption6.Text + "', " + "a_rare_index_7 = '" + TbOption7.Text + "', " + "a_rare_index_8 = '" + TbOption8.Text + "', " + "a_rare_index_9 = '" + TbOption9.Text + "', ";// option string 
                databaseHandle.SendQueryMySql(Host, User, Password, Database, str1 + "a_rare_prob_0 = '" + TbLevel0.Text + "', " + "a_rare_prob_1 = '" + TbLevel1.Text + "', " + "a_rare_prob_2 = '" + TbLevel2.Text + "', " + "a_rare_prob_3 = '" + TbLevel3.Text + "', " + "a_rare_prob_4 = '" + TbLevel4.Text + "', " + "a_rare_prob_5 = '" + TbLevel5.Text + "', " + "a_rare_prob_6 = '" + TbLevel6.Text + "', " + "a_rare_prob_7 = '" + TbLevel7.Text + "', " + "a_rare_prob_8 = '" + TbLevel8.Text + "', " + "a_rare_prob_9 = '" + TbLevel9.Text + "'" + " " + "WHERE a_index BETWEEN " + " " + "'" + tbRange1.Text + "'AND'" + tbRange2.Text + "'" + ";"); //level + range/
                int num4 = (int)new CustomMessage("Done :)").ShowDialog();
                Close(); //dethunter12 edit 12/23/2019

            }
            
            else if (tbRange2.Text.Equals("") || tbRange1.Text.Equals("")) //if any of the range fields are empty
            {
                //throw message
                int num2 = (int)new CustomMessage("Please Enter 2 Ranges of Numbers").ShowDialog();
            }
        }

        private void PbSelectID2_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            tbRange2.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void PbSelectID1_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            tbRange1.Text = Convert.ToString(itemPicker.ItemIndex);
        }
    }
}
