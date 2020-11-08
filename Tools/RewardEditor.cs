using MySql.Data.MySqlClient;
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
    public partial class Reward : Form
    {
        public static Connection connection = new Connection();
        private string Host = Reward.connection.ReadSettings("Host");
        private string User = Reward.connection.ReadSettings("User");
        private string Password = Reward.connection.ReadSettings("Password");
        private string Database = Reward.connection.ReadSettings("Database");
        private DatabaseHandle databaseHandle = new DatabaseHandle();
        public string _ClientPath = Reward.connection.ReadSettings("ClientPath");
        public string rowName = "a_primarykey";
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        BindingManagerBase managerBase;
        BindingManagerBase managerBase2;
        MySqlCommandBuilder builder;


        public Reward()
        {
            InitializeComponent();

        }
        // Source Code Re-invented By Roseon
        private void Reward_Load(object sender, EventArgs e)
        {
            using (MySqlConnection sqlConn = new MySqlConnection("datasource = " + Host + "; port = 3306; username = " + User + "; password = " + Password + "; database = " + Database))
            {

                string query = "SELECT * FROM t_reward_data";
                command = new MySqlCommand(query, sqlConn);
                adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                textBox1.DataBindings.Add("text", table, "a_primarykey");
                textBox2.DataBindings.Add("text", table, "a_reward_idx");
                textBox3.DataBindings.Add("text", table, "a_type");
                textBox4.DataBindings.Add("text", table, "a_idx");
                textBox5.DataBindings.Add("text", table, "a_value_1");
                textBox6.DataBindings.Add("text", table, "a_value_2");
                textBox7.DataBindings.Add("text", table, "a_value_3");
                textBox8.DataBindings.Add("text", table, "a_job_flag");
                textBox9.DataBindings.Add("text", table, "a_level_mini");
                textBox10.DataBindings.Add("text", table, "a_level_maxi");
                textBox11.DataBindings.Add("text", table, "a_prob");
                string query2 = "SELECT * FROM t_reward_head";
                command = new MySqlCommand(query2, sqlConn);
                adapter = new MySqlDataAdapter(command);
                adapter.Fill(table2);
                dataGridView2.DataSource = table2;
                textBox13.DataBindings.Add("text", table2, "a_reward_idx");
                richTextBox1.DataBindings.Add("text", table2, "a_desc");
                textBox12.DataBindings.Add("text", table2, "a_rand_type");

            }
                

            managerBase = this.BindingContext[table];
            managerBase2 = this.BindingContext[table2];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            managerBase.Position = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            managerBase.Position = managerBase.Count;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            managerBase.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            managerBase.EndCurrentEdit();
            builder = new MySqlCommandBuilder(adapter);
            adapter.Update(table);
            MessageBox.Show("New Collum Added", "New Reward", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            managerBase.EndCurrentEdit();
            builder = new MySqlCommandBuilder(adapter);
            adapter.Update(table);
            MessageBox.Show("Reward Data Updated", "Edit Reward", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            managerBase.RemoveAt(managerBase.Position);
            builder = new MySqlCommandBuilder(adapter);
            adapter.Update(table);
            MessageBox.Show("Reward Deleted", "Removed Reward", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            managerBase2.Position = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            managerBase2.Position = managerBase2.Count;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            managerBase2.AddNew();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            managerBase2.EndCurrentEdit();
            builder = new MySqlCommandBuilder(adapter);
            adapter.Update(table2);
            MessageBox.Show("New Collum Added", "New Head", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            managerBase2.EndCurrentEdit();
            builder = new MySqlCommandBuilder(adapter);
            adapter.Update(table2);
            MessageBox.Show("Reward Head Updated", "Edit Head", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            managerBase2.RemoveAt(managerBase2.Position);
            builder = new MySqlCommandBuilder(adapter);
            adapter.Update(table2);
            MessageBox.Show("Reward Head Deleted", "Removed Head", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox5_MouseHover(object sender, EventArgs e) //value 1
        { 
            if (textBox3.Text == "0")//dethunter12 add
            {
                toolTip1.SetToolTip(textBox5, "Item Plus");//dethunter12 add
            }
            else if (textBox3.Text == "4")//dethunter12 add
            {
                toolTip1.SetToolTip(textBox5, "Statpoint amount");//dethunter12 add
            }
            else if (textBox3.Text == "5")//dethunter12 add
            {
                toolTip1.SetToolTip(textBox5, "Skill Level");//dethunter12 add
            }
        }

        private void textBox6_MouseHover(object sender, EventArgs e)
        {
            if (textBox3.Text == "0")//dethunter12 add
            {
                toolTip1.SetToolTip(textBox6, "Item Flag (used for minerals mostly)");//dethunter12 add
            }
        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            if (textBox3.Text == "0")//dethunter12 add
            {
                toolTip1.SetToolTip(textBox3, "Item Rewards");//dethunter12 add
            }
            else if (textBox3.Text == "1")//dethunter12 add
            {
                toolTip1.SetToolTip(textBox3, "Gold Reward");//dethunter12 add
            }
            else if (textBox3.Text == "2")//dethunter12 add
            {
                toolTip1.SetToolTip(textBox3, "Exp Reward");//dethunter12 add
            }
            else if (textBox3.Text == "3")//dethunter12 add
            {
                toolTip1.SetToolTip(textBox3, "SP Reward");//dethunter12 add

            }
            else if (textBox3.Text == "4")//dethunter12 add
            {
                toolTip1.SetToolTip(textBox3, "Statpoint Reward");//dethunter12 add
            }
            else if (textBox3.Text == "5")//dethunter12 add
            {
                toolTip1.SetToolTip(textBox3, "Skill Reward");//dethunter12 add
            }
        }

        private void textBox8_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox8, "Character flag");//dethunter12 add
        }

        private void textBox11_MouseHover(object sender, EventArgs e)
        {
            if (textBox12.Text == "1")//dethunter12 add
            {
                toolTip1.SetToolTip(textBox12, "Probability Must Total 10,000");//dethunter12 add
            }
            else if (textBox12.Text == "0")//dethunter12 add
            {
                toolTip1.SetToolTip(textBox12, "Probability Must be 10,000");//dethunter12 add
            }
            else if (textBox12.Text == "2")//dethunter12 add
            {
                toolTip1.SetToolTip(textBox12, "Probability Must be 10,000");//dethunter12 add
            }
        }

        private void textBox7_MouseHover(object sender, EventArgs e)
        {
            if (textBox3.Text == "0")//dethunter12 add
            {
                toolTip1.SetToolTip(textBox7, "Item Count");//dethunter12 add
            }
            else if (textBox3.Text == "1")//dethunter12 add
            {
                toolTip1.SetToolTip(textBox7, "Gold Amount");//dethunter12 add
            }
            else if (textBox3.Text == "2")//dethunter12 add
            {
                toolTip1.SetToolTip(textBox7, "Exp Amount");//dethunter12 add
            }
            else if (textBox3.Text == "3")//dethunter12 add
            {
                toolTip1.SetToolTip(textBox7, "SP Amount");//dethunter12 add

            }
        }

        private void textBox12_MouseHover(object sender, EventArgs e)
        {
            if (textBox12.Text == "0")//dethunter12 add
            {
                toolTip1.SetToolTip(textBox12, "Give all Items by Job");//dethunter12 add
            }
            else if (textBox12.Text == "1")//dethunter12 add
            {
                toolTip1.SetToolTip(textBox12, "Give one item by probability");//dethunter12 add
            }
            else if (textBox12.Text == "2")//dethunter12 add
            {
                toolTip1.SetToolTip(textBox12, "Give one item by random");//dethunter12 add
            }
        }

        private void textBox4_MouseHover(object sender, EventArgs e)
        {
            if (textBox3.Text == "5")//dethunter12 add
            {
                toolTip1.SetToolTip(textBox4, "Skill ID");//dethunter12 add
            }
        }
    }
    
}
