using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools.MemoryWorker.rareEditor
{
    public partial class RareOptionEditor : Form
    {
        private readonly string _connectionString;
        private string Host = ItemEditor2.connection.ReadSettings("Host");
        private string User = ItemEditor2.connection.ReadSettings("User");
        private string Password = ItemEditor2.connection.ReadSettings("Password");
        private string Database = ItemEditor2.connection.ReadSettings("Database");

        public RareOptionEditor()
        {
            InitializeComponent();
            _connectionString = $"Server={Host};Database={Database};Uid={User};Pwd={Password};";
            LoadRareOptions();
        }

        private List<t_rareoptions> rareOptions = new List<t_rareoptions>();

        private async Task<List<t_rareoptions>> GetRareOptions()
        {
            var rareOptions = new List<t_rareoptions>();
            using (var conn = new MySqlConnection(_connectionString))
            {
                conn.Open();

                var cmd = new MySqlCommand("SELECT * FROM t_rareoption", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (await reader.ReadAsync())
                    {
                        rareOptions.Add(new t_rareoptions
                        {
                            IndexID = reader.GetInt32("a_index"),
                            name = reader.GetString("a_name"),
                            grade = reader.GetInt32("a_grade"),
                            type = reader.GetInt32("a_type"),
                            attack = reader.GetInt32("a_attack"),
                            defense = reader.GetInt32("a_defense"),
                            magic = reader.GetInt32("a_magic"),
                            resist = reader.GetInt32("a_resist"),
                            optionindex0 = reader.GetInt32("a_option_index0"),
                            optionindex1 = reader.GetInt32("a_option_index1"),
                            optionindex2 = reader.GetInt32("a_option_index2"),
                            optionindex3 = reader.GetInt32("a_option_index3"),
                            optionindex4 = reader.GetInt32("a_option_index4"),
                            optionindex5 = reader.GetInt32("a_option_index5"),
                            optionindex6 = reader.GetInt32("a_option_index6"),
                            optionindex7 = reader.GetInt32("a_option_index7"),
                            optionindex8 = reader.GetInt32("a_option_index8"),
                            optionindex9 = reader.GetInt32("a_option_index9"),
                            // finish writing option index
                            optionlevel0 = reader.GetInt32("a_option_level0"),
                            optionlevel1 = reader.GetInt32("a_option_level1"),
                            optionlevel2 = reader.GetInt32("a_option_level2"),
                            optionlevel3 = reader.GetInt32("a_option_level3"),
                            optionlevel4 = reader.GetInt32("a_option_level4"),
                            optionlevel5 = reader.GetInt32("a_option_level5"),
                            optionlevel6 = reader.GetInt32("a_option_level6"),
                            optionlevel7 = reader.GetInt32("a_option_level7"),
                            optionlevel8 = reader.GetInt32("a_option_level8"),
                            optionlevel9 = reader.GetInt32("a_option_level9"),
                            // finish writing option level
                            optionprob0 = reader.GetInt32("a_option_prob0"),
                            optionprob1 = reader.GetInt32("a_option_prob1"),
                            optionprob2 = reader.GetInt32("a_option_prob2"),
                            optionprob3 = reader.GetInt32("a_option_prob3"),
                            optionprob4 = reader.GetInt32("a_option_prob4"),
                            optionprob5 = reader.GetInt32("a_option_prob5"),
                            optionprob6 = reader.GetInt32("a_option_prob6"),
                            optionprob7 = reader.GetInt32("a_option_prob7"),
                            optionprob8 = reader.GetInt32("a_option_prob8"),
                            optionprob9 = reader.GetInt32("a_option_prob9")
                            // finish writing option prob
                        });
                    }
                }
            }

            return rareOptions;
        }

        private List<t_option> optionsList = new List<t_option>();
        private async Task<List<t_option>> GetOptionList()
        {
            var optionsList = new List<t_option>();
            using (var conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT a_type, a_name_usa, a_level FROM t_option", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (await reader.ReadAsync())
                    {
                        //parse the a_level field 
                        string a_level = reader.GetString("a_level");
                        var levelArr = a_level.Split(' ');
                        int[] levels = new int[levelArr.Length];
                        for (int i = 0; i < levelArr.Length; i++)
                            levels[i] = int.Parse(levelArr[i]);
                        // end parse
                        optionsList.Add(new t_option
                        {
                            a_type = reader.GetInt32("a_type"),
                            a_name_usa = reader.GetString("a_name_usa"),
                            a_levels = levels[0]
                        });
                    }
                }
            }
            return optionsList;
        }

        private async void LoadRareOptions()
        {
            // Clear the listbox
            listBox1.Items.Clear();
            var options = await GetOptionList();
            cboxSeal1.DataSource = options;
            cboxSeal1.DisplayMember = "a_name_usa";
            cboxSeal1.ValueMember = "a_type";
            cboxSealLevel1.DataSource = options;
            cboxSealLevel1.DisplayMember = "a_level";
            cboxSealLevel1.ValueMember = "a_type";

            cboxSeal2.DataSource = options;
            cboxSeal2.DisplayMember = "a_name_usa";
            cboxSeal2.ValueMember = "a_type";
            cboxSealLevel2.DataSource = options;
            cboxSealLevel2.DisplayMember = "a_level";
            cboxSealLevel2.ValueMember = "a_type";

            cboxSeal3.DataSource = options;
            cboxSeal3.DisplayMember = "a_name_usa";
            cboxSeal3.ValueMember = "a_type";
            cboxSealLevel3.DataSource = options;
            cboxSealLevel3.DisplayMember = "a_level";
            cboxSealLevel3.ValueMember = "a_type";

            cboxSeal4.DataSource = options;
            cboxSeal4.DisplayMember = "a_name_usa";
            cboxSeal4.ValueMember = "a_type";
            cboxSealLevel4.DataSource = options;
            cboxSealLevel4.DisplayMember = "a_level";
            cboxSealLevel4.ValueMember = "a_type";

            cboxSeal5.DataSource = options;
            cboxSeal5.DisplayMember = "a_name_usa";
            cboxSeal5.ValueMember = "a_type";
            cboxSealLevel5.DataSource = options;
            cboxSealLevel5.DisplayMember = "a_level";
            cboxSealLevel5.ValueMember = "a_type";

            cboxSeal6.DataSource = options;
            cboxSeal6.DisplayMember = "a_name_usa";
            cboxSeal6.ValueMember = "a_type";
            cboxSealLevel6.DataSource = options;
            cboxSealLevel6.DisplayMember = "a_level";
            cboxSealLevel6.ValueMember = "a_type";

            cboxSeal7.DataSource = options;
            cboxSeal7.DisplayMember = "a_name_usa";
            cboxSeal7.ValueMember = "a_type";
            cboxSealLevel7.DataSource = options;
            cboxSealLevel7.DisplayMember = "a_level";
            cboxSealLevel7.ValueMember = "a_type";

            cboxSeal8.DataSource = options;
            cboxSeal8.DisplayMember = "a_name_usa";
            cboxSeal8.ValueMember = "a_type";
            cboxSealLevel8.DataSource = options;
            cboxSealLevel8.DisplayMember = "a_level";
            cboxSealLevel8.ValueMember = "a_type";

            cboxSeal9.DataSource = options;
            cboxSeal9.DisplayMember = "a_name_usa";
            cboxSeal9.ValueMember = "a_type";
            cboxSealLevel9.DataSource = options;
            cboxSealLevel9.DisplayMember = "a_level";
            cboxSealLevel9.ValueMember = "a_type";

            cboxSeal10.DataSource = options;
            cboxSeal10.DisplayMember = "a_name_usa";
            cboxSeal10.ValueMember = "a_type";
            cboxSealLevel10.DataSource = options;
            cboxSealLevel10.DisplayMember = "a_level";
            cboxSealLevel10.ValueMember = "a_type";

            
            // Fetch the rare options from the database
            rareOptions = await GetRareOptions();
            foreach (var option in rareOptions)
            {
                listBox1.Items.Add($"ID: {option.IndexID} - {option.name}");
            }
        }



        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnPercentAddResist_Click(object sender, EventArgs e)
        {

        }

        private void btnPercentAddMattk_Click(object sender, EventArgs e)
        {

        }

        private void btnPercentAddDef_Click(object sender, EventArgs e)
        {

        }

        private void btnPercentAddAttk_Click(object sender, EventArgs e)
        {

        }
        private void ClearControls()
        {
            tbID.Clear();
            tbName.Clear();
            tbAttack.Clear();
            tbDef.Clear();
            tbMAtk.Clear();
            tbResist.Clear();
            TbGrade.Clear();
            TbType.Clear();
        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
           if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < rareOptions.Count)
            {
                var selectedOption = rareOptions[listBox1.SelectedIndex];
                tbID.Text = selectedOption.IndexID.ToString();
                tbName.Text = selectedOption.name;
                tbAttack.Text = selectedOption.attack.ToString();
                tbDef.Text = selectedOption.defense.ToString();
                tbMAtk.Text = selectedOption.magic.ToString();
                tbResist.Text = selectedOption.resist.ToString();
                TbGrade.Text = selectedOption.grade.ToString();
                TbType.Text = selectedOption.type.ToString();
                cboxSeal1.SelectedIndex = selectedOption.optionindex0;
                cboxSeal2.SelectedIndex = selectedOption.optionindex1;
                cboxSeal3.SelectedIndex = selectedOption.optionindex2;
                cboxSeal4.SelectedIndex = selectedOption.optionindex3;
                cboxSeal5.SelectedIndex = selectedOption.optionindex4;
                cboxSeal6.SelectedIndex = selectedOption.optionindex5;
                cboxSeal7.SelectedIndex = selectedOption.optionindex6;
                cboxSeal8.SelectedIndex = selectedOption.optionindex7;
                cboxSeal9.SelectedIndex = selectedOption.optionindex8;
                cboxSeal10.SelectedIndex = selectedOption.optionindex9;
                cboxSealLevel1.SelectedIndex = selectedOption.optionlevel0;
                cboxSealLevel2.SelectedIndex = selectedOption.optionlevel1;
                cboxSealLevel3.SelectedIndex = selectedOption.optionlevel2;
                cboxSealLevel4.SelectedIndex = selectedOption.optionlevel3;
                cboxSealLevel5.SelectedIndex = selectedOption.optionlevel4;
                cboxSealLevel6.SelectedIndex = selectedOption.optionlevel5;
                cboxSealLevel7.SelectedIndex = selectedOption.optionlevel6;
                cboxSealLevel8.SelectedIndex = selectedOption.optionlevel7;
                cboxSealLevel9.SelectedIndex = selectedOption.optionlevel8;
                cboxSealLevel10.SelectedIndex = selectedOption.optionlevel9;
                tbProb1.Text = selectedOption.optionprob0.ToString();
                tbProb2.Text = selectedOption.optionprob1.ToString();
                tbProb3.Text = selectedOption.optionprob2.ToString();
                tbProb4.Text = selectedOption.optionprob3.ToString();
                tbProb5.Text = selectedOption.optionprob4.ToString();
                tbProb6.Text = selectedOption.optionprob5.ToString();
                tbProb7.Text = selectedOption.optionprob6.ToString();
                tbProb8.Text = selectedOption.optionprob7.ToString();
                tbProb9.Text = selectedOption.optionprob8.ToString();
                tbProb10.Text = selectedOption.optionprob9.ToString();
            }

        }
    }
}
