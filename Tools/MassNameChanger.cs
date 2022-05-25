using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools //dethunter12 10/3/2019 add
{
    public partial class MassNameChanger : Form
    {
        //dethunter12 add
        //to initialize a paramater in which to send data to db.
        private string Host = ItemEditor2.connection.ReadSettings("Host");
        private string User = ItemEditor2.connection.ReadSettings("User");
        private string Password = ItemEditor2.connection.ReadSettings("Password");
        private string Database = ItemEditor2.connection.ReadSettings("Database");
        private string language = ItemEditor2.connection.ReadSettings("Language");
        public string namee; //dethunter12 stringfrom lang modify
        public string aname = ""; //dehtunter12 add
        private DatabaseHandle databaseHandle = new DatabaseHandle();

        public string StringFromLanguage() //dethunter12 10/3/2019
        {
            if (language == "GER")
            {
                return "a_name_ger";
            }
            else if (language == "POL")
            {
                return "a_name_pld";
            }
            else if (language == "BRA")
            {
                return "a_name_brz";
            }
            else if (language == "RUS")
            {
                return "a_name_rus";
            }
            else if (language == "FRA")
            {
                return "a_name_frc";
            }
            else if (language == "ESP")
            {
                return "a_name_spn";
            }
            else if (language == "MEX")
            {
                return "a_name_mex";
            }
            else if (language == "THA")
            {
                return "a_name_thai";
            }
            else if (language == "ITA")
            {
                return "a_name_ita";
            }
            else if (language == "USA")
            {
                return "a_name_usa";
            }
            else
            {
                return null;
            }
        }
        public MassNameChanger()
        {
            InitializeComponent();
        }

        private void BtnUpdateSelectedRange_Click(object sender, EventArgs e) //dethunter12 10/3/2019
        {
            namee = StringFromLanguage();
            if (cbAddBefore.Checked == true || cbRemoveBefore.Checked == true)
            {
                if (tbItemName.Text != "" && tbRange1.Text != "" && tbRange2.Text != "" && cbRemoveBefore.Checked == true) //done
                {
                    databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_item SET " + namee + "= REPLACE(" + namee + ",'" + tbItemName.Text + "','" + "') " + "WHERE a_index BETWEEN '" + tbRange1.Text + "'" + " " + "AND'" + tbRange2.Text + "'" + ";");
                    int num2 = (int)new CustomMessage("DONE!").ShowDialog();
                    Close(); //dethunter12 adjust 12/23/2019
                }
               
                else if (tbItemName.Text != "" && tbRange1.Text != "" && tbRange2.Text != "" && cbAddBefore.Checked == true) //done
                {
                    databaseHandle.SendQueryMySql(Host, User, Password, Database, "UPDATE t_item SET " + namee + "= CONCAT ('" + tbItemName.Text + "'," + namee + ")" + "WHERE a_index BETWEEN '" + tbRange1.Text + "'" + " " + "AND'" + tbRange2.Text + "'" + ";");
                    int num2 = (int)new CustomMessage("DONE!").ShowDialog();
                    MassNameChanger massNameChanger = new MassNameChanger();
                    massNameChanger.Close();

                }
                
                else if (tbItemName.Text != "" && tbRange1.Text != "" && tbRange2.Text.Equals(""))
                {
                    int num2 = (int)new CustomMessage("Please Enter Range 2 Value").ShowDialog();
                }
                else if (tbItemName.Text != "" && tbRange1.Text.Equals("") && tbRange2.Text != "")
                {
                    int num2 = (int)new CustomMessage("Please Enter Range 1 Value").ShowDialog();
                }
                else if (tbItemName.Text.Equals("") && tbRange1.Text != "" && tbRange2.Text != "")
                {
                    int num2 = (int)new CustomMessage("Please Select a Name ").ShowDialog();
                }
            }
            else
            {
                int num2 = (int)new CustomMessage("Check one of the boxes").ShowDialog();
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
