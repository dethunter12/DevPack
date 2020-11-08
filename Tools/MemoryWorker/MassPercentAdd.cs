using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools.MemoryWorker
{
    public partial class MassPercentAdd : Form
    {
        private string Host = ItemEditor2.connection.ReadSettings("Host");
        private string User = ItemEditor2.connection.ReadSettings("User");
        private string Password = ItemEditor2.connection.ReadSettings("Password");
        private string Database = ItemEditor2.connection.ReadSettings("Database");
        private double result1, result2, result3;
        private double output1, output2, output3;
        private DatabaseHandle databaseHandle = new DatabaseHandle();

        private void TbNum0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //limit to whole digits.
            {
                e.Handled = true;
            }

        }

        private void TbNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbRange1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //limit to whole digits.
            {
                e.Handled = true;
            }
        }

        private void TbRange2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //limit to whole digits.
            {
                e.Handled = true;
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (TbNum0.Text != "" && TbNum1.Text != "" && TbNum2.Text != "")
            {
                result1 = Convert.ToDouble(TbNum0.Text); //assign
                result2 = Convert.ToDouble(TbNum1.Text);
                result3 = Convert.ToDouble(TbNum2.Text);
                output1 = result1 / 100f;
                output2 = result2 / 100f;
                output3 = result3 / 100f;
                //number is just multiplying by the decimal point equivalent of the value. and not adding to to the original value afte completion
                string str1 = "UPDATE t_item SET " + "a_num_0 = (a_num_0 * 1) - a_num_0 * '" + output1 + "', " + "a_num_1 = (a_num_1 * 1) - a_num_1 * '" + output2 + "', " + "a_num_2 = (a_num_2 *1) - a_num_2 * '" + output3 + "' ";
                databaseHandle.SendQueryMySql(Host, User, Password, Database, str1 + " " + "WHERE a_index BETWEEN '" + tbRange1.Text + "'" + " " + "AND'" + tbRange2.Text + "'" + ";");
                //_ = (int)new CustomMessage("Rows Updated Successfully").ShowDialog();
                Close();
            }
            else if (TbNum0.Text == "" || TbNum1.Text == "" || TbNum2.Text == "")
            {
                // if either if the fields are left blank throw a message to let the user know.
                //_ = (int)new CustomMessage("Check fields for blank spots").ShowDialog();
            }
            else if (tbRange2.Text.Equals("") || tbRange1.Text.Equals(""))
            {
                int num2 = (int)new CustomMessage("Please Enter 2 Ranges of Numbers").ShowDialog();
            }
        }

        public MassPercentAdd()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TbNum0.Text != "" && TbNum1.Text != "" && TbNum2.Text != "")
            {
                result1 = Convert.ToDouble(TbNum0.Text); //assign
                result2 = Convert.ToDouble(TbNum1.Text);
                result3 = Convert.ToDouble(TbNum2.Text);
                output1 = result1 / 100f;
                output2 = result2 / 100f;
                output3 = result3 / 100f;
                //number is just multiplying by the decimal point equivalent of the value. and not adding to to the original value afte completion
                string str1 = "UPDATE t_item SET " + "a_num_0 = (a_num_0 * 1) + a_num_0 * '" + output1 + "', " + "a_num_1 = (a_num_1 * 1) + a_num_1 * '" + output2 + "', " + "a_num_2 = (a_num_2 *1) + a_num_2 * '" + output3 + "' ";
                databaseHandle.SendQueryMySql(Host, User, Password, Database, str1 + " " + "WHERE a_index BETWEEN '" + tbRange1.Text + "'" + " " + "AND'" + tbRange2.Text + "'" + ";");
                //_ = (int)new CustomMessage("Rows Updated Successfully").ShowDialog();
                Close();
            }
            else if (TbNum0.Text == "" || TbNum1.Text == "" || TbNum2.Text == "")
            {
                // if either if the fields are left blank throw a message to let the user know.
                //_ = (int)new CustomMessage("Check fields for blank spots").ShowDialog();
            }
            else if (tbRange2.Text.Equals("") || tbRange1.Text.Equals(""))
            {
                int num2 = (int)new CustomMessage("Please Enter 2 Ranges of Numbers").ShowDialog();
            }
          
            
        }

        private void PbSelectID1_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            tbRange1.Text = Convert.ToString(itemPicker.ItemIndex); //Convert.ToString(itemPicker.ItemIndex);
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
