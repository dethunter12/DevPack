using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools.MemoryWorker.LacaBall
{
    public partial class LacaBall : Form
    {
        public LacaBall()
        {
            
            InitializeComponent();
            
        }
        public int LacaballItemIndex = -1;
        public static Connection connection = new Connection();
        private string Host = LacaBall.connection.ReadSettings("Host");
        private string User = LacaBall.connection.ReadSettings("User");
        private string Password = LacaBall.connection.ReadSettings("Password");
        private string Database = LacaBall.connection.ReadSettings("Database");
        private string DB_Database = LacaBall.connection.ReadSettings("DB_Database");
        public bool ISDataGridLoaded = false;
        public bool ISFinished = false;
        public bool completed = false;
        public int ItemIndx= -1;
        public bool ISNullValue = false;
        public static List<t_lcball> LcBallList  = new List<t_lcball>();
        private DatabaseHandle databaseHandle = new DatabaseHandle();
       
        public void LoadDG(int LacaballItemidx) //dethunter12 add test lacaball code.
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            dataGridView1.Rows.Clear(); string str1 = "select a_item_order, a_tocken_index, a_course_code, a_order, a_item_index, a_item_count, a_item_max, a_item_remain from t_lcball WHERE a_tocken_index = " + LacaballItemidx + " order by a_course_code ASC, a_order ASC ;";
            MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + DB_Database);
            MySqlCommand command = mySqlConnection.CreateCommand();
            command.CommandText = str1;
            mySqlConnection.Open();
            MySqlDataReader mySqlDataReader = command.ExecuteReader();
            if (mySqlDataReader.HasRows == false) //dethunter12 adjust 6/1/2020
                ISNullValue = true;
            else
                ISNullValue = false;

            while (mySqlDataReader.Read())
            {
                t_lcball t_Lcball = new t_lcball();
                t_Lcball.a_item_order = Convert.ToInt32(mySqlDataReader.GetValue(0).ToString());
                t_Lcball.a_tocken_index = Convert.ToInt32(mySqlDataReader.GetValue(1).ToString());
                t_Lcball.a_course_code = Convert.ToInt32(mySqlDataReader.GetValue(2).ToString());
                t_Lcball.a_order = Convert.ToInt32(mySqlDataReader.GetValue(3).ToString());
                t_Lcball.a_item_index = Convert.ToInt32(mySqlDataReader.GetValue(4).ToString());
                t_Lcball.a_item_count = Convert.ToInt32(mySqlDataReader.GetValue(5).ToString());
                t_Lcball.a_item_max = Convert.ToInt32(mySqlDataReader.GetValue(6).ToString());
                t_Lcball.a_item_remain = Convert.ToInt32(mySqlDataReader.GetValue(7).ToString());
                LcBallList.Add(t_Lcball);
                string item_id = mySqlDataReader.GetValue(4).ToString();
                int ItemIndx = t_Lcball.a_item_index;
                dataGridView1.Rows.Add(new Bitmap(databaseHandle.IconFast(Int32.Parse(item_id)), 20, 20), t_Lcball.a_item_order, t_Lcball.a_course_code, t_Lcball.a_order, t_Lcball.a_item_index, databaseHandle.ItemNameFast(Int32.Parse(item_id)), t_Lcball.a_item_count);
                tbItemMax.Text = t_Lcball.a_item_max.ToString();
                tbItemRemain.Text = t_Lcball.a_item_remain.ToString();
                
             

            }
            mySqlConnection.Close();
            ISDataGridLoaded = true;
            stopwatch.Stop();
            TimeSpan elapsed = stopwatch.Elapsed;
            string.Format("{0:00}:{1:00}:{2:00}.{3:00}", elapsed.Hours, elapsed.Minutes, elapsed.Seconds, (elapsed.Milliseconds / 10));
            toolStripStatusLabel1.Text = "Ready";
            toolStripStatusLabel1.ForeColor  = Color.LimeGreen;
        }

        public void UpdatePictureBox()
        {
            
 
        }

        
        private void pbMoveUp_Click(object sender, EventArgs e)
        {
          
            DataGridView dgv = dataGridView1;
            try
            {
                
                int totalRows = dgv.Rows.Count;
                // get index of the row for the selected cell
                int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
                if (rowIndex == 0)
                    return;
                //Test
                int NextOrder = Convert.ToInt16(dataGridView1.Rows[rowIndex].Cells["Order"].Value) - 1 ;
                if (NextOrder < 0 )
                { 
                MessageBox.Show("Test Next order is not valid");
                return;
                }
                else
                {
                    dataGridView1.Rows[rowIndex].Cells["Order"].Value = NextOrder;
                    databaseHandle.SendQueryMySql(Host, User, Password, DB_Database, "UPDATE t_lcball SET a_order  ='" + NextOrder + "' WHERE a_course_code = "  + "'" + Convert.ToString(dataGridView1.Rows[rowIndex].Cells["CourseCode"].Value )  + "' AND a_item_order = '" + Convert.ToString(dataGridView1.Rows[rowIndex].Cells["ItemOrder"].Value) + "' AND a_item_index ='" + Convert.ToString(dataGridView1.Rows[rowIndex].Cells["ItemIndex"].Value) + "'");
                    dataGridView1.Rows.Clear();
                    LoadDG(LacaballItemIndex);
                    // get index of the column for the selected cell
                    int colIndex = dgv.SelectedCells[0].OwningColumn.Index;
                    DataGridViewRow selectedRow = dgv.Rows[rowIndex];
                    dgv.Rows.Remove(selectedRow);
                    dgv.Rows.Insert(rowIndex - 1, selectedRow);
                    //find out where to store the value

                    dgv.ClearSelection();
                    dgv.Rows[rowIndex - 1].Cells[colIndex].Selected = true;
                }
                
            }
            catch { }
        }

        private void pbMoveDown_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView1;
            try
            {
                int totalRows = dgv.Rows.Count;
                // get index of the row for the selected cell
                int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
                if (rowIndex == totalRows - 1)
                    return;
                int NextOrder = Convert.ToInt16(dataGridView1.Rows[rowIndex].Cells["Order"].Value) + 1;
                if (NextOrder > 4)
                {
                    MessageBox.Show("Test Next order is not valid");
                    return;
                }
                else
                {
                    dataGridView1.Rows[rowIndex].Cells["Order"].Value = NextOrder;
                    databaseHandle.SendQueryMySql(Host, User, Password, DB_Database, "UPDATE t_lcball SET a_order  ='" + NextOrder + "' WHERE a_course_code = " + "'" + Convert.ToString(dataGridView1.Rows[rowIndex].Cells["CourseCode"].Value) + "' AND a_item_order = '" + Convert.ToString(dataGridView1.Rows[rowIndex].Cells["ItemOrder"].Value) + "' AND a_item_index ='" + Convert.ToString(dataGridView1.Rows[rowIndex].Cells["ItemIndex"].Value) + "'");
                    dataGridView1.Rows.Clear();
                    LoadDG(LacaballItemIndex);

                    // get index of the column for the selected cell
                    int colIndex = dgv.SelectedCells[0].OwningColumn.Index;
                    DataGridViewRow selectedRow = dgv.Rows[rowIndex];
                    dgv.Rows.Remove(selectedRow);
                    dgv.Rows.Insert(rowIndex + 1, selectedRow);
                    dgv.ClearSelection();
                    dgv.Rows[rowIndex + 1].Cells[colIndex].Selected = true;
                }
               
            }
            catch { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ItemPicker itemPicker = new ItemPicker(); //dethunter12 add
                if (itemPicker.ShowDialog() != DialogResult.OK)
                    return;
                int ItemIDx;
                ItemIDx = itemPicker.ItemIndex;
                databaseHandle.SendQueryMySql(Host, User, Password, DB_Database, "INSERT INTO t_lcball (a_type, a_giftindex) VALUES ('" + LacaballItemIndex + "'," + "'" + ItemIDx + "')");
            }
            catch
            {
                int num = (int)MessageBox.Show("Duplicated ItemID isn't allowed.", "Error");
            }
            dataGridView1.Rows.Clear();
            LoadDG(LacaballItemIndex);
            int index = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[index].Selected = true;
            dataGridView1.FirstDisplayedScrollingRowIndex = index;
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index1 = dataGridView1.CurrentRow.Index;
            int index2 = index1 - 1;
            databaseHandle.SendQueryMySql(Host, User, Password, DB_Database, "DELETE FROM t_lcball WHERE a_item_order ='" + Convert.ToString(dataGridView1.Rows[index1].Cells["ItemOrder"].Value) + "' AND " + "a_course_code ='" + Convert.ToString(dataGridView1.Rows[index1].Cells["CourseCode"].Value) + "'" + " AND " + "a_order ='" + Convert.ToString(dataGridView1.Rows[index1].Cells["Order"].Value) + "'");
            dataGridView1.Rows.Clear();
            LoadDG(LacaballItemIndex);
            try
            {
                dataGridView1.Rows[index2].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = index2;
            }
            catch
            {
                int num = (int)MessageBox.Show("You must select a Item", "Error");
            }
        }

        public void LoadDefaultImage()
        {
            pbLacaItem1.BackgroundImage = databaseHandle.IconFast(5123);
            pbLacaItem2.BackgroundImage = databaseHandle.IconFast(5124);
            pbLacaItem3.BackgroundImage = databaseHandle.IconFast(6653);
            pbLacaItem4.BackgroundImage = databaseHandle.IconFast(2545);
            pbLacaItem5.BackgroundImage = databaseHandle.IconFast(2546);
            pbLacaItem6.BackgroundImage = databaseHandle.IconFast(2547);
            pbLacaItem7.BackgroundImage = databaseHandle.IconFast(2548);
            pbLacaItem8.BackgroundImage = databaseHandle.IconFast(6092);
            pbLacaItem9.BackgroundImage = databaseHandle.IconFast(6939);
            pbLacaItem10.BackgroundImage = databaseHandle.IconFast(11495);
            pbLacaItem11.BackgroundImage = databaseHandle.IconFast(34288);
        }
        private void LacaBall_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            LoadDefaultImage();
            toolStripStatusLabel1.Text = "Choose your Item!";
            toolStripStatusLabel1.ForeColor = Color.Red;

        }

        private void pbLacaItem1_Click(object sender, EventArgs e)
        {
            LacaballItemIndex = 5123;
            LoadDG(5123);
            //if the datagrid doesnt load anything disable the icon (records dont exist)
            if (ISNullValue == true)
                pbLacaItem1.Enabled = false;
        }

        private void pbLacaItem2_Click(object sender, EventArgs e)
        {
            LacaballItemIndex = 5124;
            LoadDG(5124);
            if (ISNullValue == true)
                pbLacaItem2.Enabled = false;
        }

        private void pbLacaItem3_Click(object sender, EventArgs e)
        {
            LacaballItemIndex = 6653;
            LoadDG(6653);
            if (ISNullValue == true)
                pbLacaItem3.Enabled = false;
        }

        private void pbLacaItem4_Click(object sender, EventArgs e)
        {
            LacaballItemIndex = 2545;
            LoadDG(2545);
            if (ISNullValue == true)
            pbLacaItem4.Enabled = false;
               
               
        }

        private void pbLacaItem5_Click(object sender, EventArgs e)
        {
            LacaballItemIndex = 2546;
            LoadDG(2546);
            if (ISNullValue == true)
                pbLacaItem5.Enabled = false;
        }

        private void pbLacaItemAll_Click(object sender, EventArgs e)
        {
            LacaballItemIndex = 2547;
            LoadDG(2547);
            if (ISNullValue == true)
                pbLacaItemAll.Enabled = false;
        }

        private void pbLacaItem6_Click(object sender, EventArgs e)
        {
            LacaballItemIndex = 2548;
            LoadDG(2548);
            if (ISNullValue == true)
                pbLacaItem6.Enabled = false;
        }

        private void pbLacaItem7_Click(object sender, EventArgs e)
        {
            LacaballItemIndex = 6092;
            LoadDG(6092);
            if (ISNullValue == true)
                pbLacaItem7.Enabled = false;
        }

        private void pbLacaItem8_Click(object sender, EventArgs e)
        {
            LacaballItemIndex = 6092;
            LoadDG(6092);
            if (ISNullValue == true)
                pbLacaItem8.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            t_lcball t_Lcball = new t_lcball();


            if (ISDataGridLoaded == true)
            {
                if (ItemIndx != int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ItemIndex"].Value.ToString()) && (dataGridView1.Rows[e.RowIndex].Cells["ItemIndex"].Value.ToString() != "-1" || dataGridView1.Rows[e.RowIndex].Cells["ItemIndex"].Value.ToString() != "0"))
                {
                    ItemIndx = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ItemIndex"].Value.ToString());

                    if (ISFinished != true)
                    {
                        //if the column value isnt equal to the list set true then give a image otherwise its  false until true;
                        ISFinished = true;


                        dataGridView1.Rows[e.RowIndex].SetValues(new Bitmap(databaseHandle.IconFast(ItemIndx), 20, 20));

                    }
                    else if (ISDataGridLoaded == true && ISFinished == true)
                    {
                        dataGridView1.Rows[e.RowIndex].SetValues(new Bitmap(databaseHandle.IconFast(ItemIndx), 20, 20));
                    }

                }

            }


        }

        private void PbLacaItem9_Click(object sender, EventArgs e)
        {
            LacaballItemIndex = 6939;
            LoadDG(6939);
            if (ISNullValue == true)
                pbLacaItem9.Enabled = false;
        }

        private void PbLacaItem10_Click(object sender, EventArgs e)
        {
            LacaballItemIndex = 11495;
            LoadDG(11495);
            if (ISNullValue == true)
                pbLacaItem10.Enabled = false;
        }

        private void PbLacaItem11_Click(object sender, EventArgs e)
        {
            LacaballItemIndex = 34288;
            LoadDG(34288);
            if (ISNullValue == true)
                pbLacaItem11.Enabled = false;
        }

        private void PbLacaItem1_Paint(object sender, PaintEventArgs e)
        {
            if (pbLacaItem1.Enabled == false)
            { 

            using (var img = new Bitmap(pbLacaItem1.BackgroundImage, pbLacaItem1.ClientSize))
            {
                ControlPaint.DrawImageDisabled(e.Graphics, img, 0, 0, pbLacaItem1.BackColor);
            }
            }
        }

        private void PbLacaItem3_Paint(object sender, PaintEventArgs e)
        {
            if (pbLacaItem3.Enabled == false)
            {

                using (var img = new Bitmap(pbLacaItem3.BackgroundImage, pbLacaItem3.ClientSize))
                {
                    ControlPaint.DrawImageDisabled(e.Graphics, img, 0, 0, pbLacaItem3.BackColor);
                }
            }
        }

        private void PbLacaItem4_Paint(object sender, PaintEventArgs e)
        {
            if (pbLacaItem4.Enabled == false)
            {

                using (var img = new Bitmap(pbLacaItem4.BackgroundImage, pbLacaItem4.ClientSize))
                {
                    ControlPaint.DrawImageDisabled(e.Graphics, img, 0, 0, pbLacaItem4.BackColor);
                }
            }
        }

        private void PbLacaItem5_Paint(object sender, PaintEventArgs e)
        {
            if (pbLacaItem5.Enabled == false)
            {

                using (var img = new Bitmap(pbLacaItem5.BackgroundImage, pbLacaItem5.ClientSize))
                {
                    ControlPaint.DrawImageDisabled(e.Graphics, img, 0, 0, pbLacaItem5.BackColor);
                }
            }
        }

        private void PbLacaItem6_Paint(object sender, PaintEventArgs e)
        {
            if (pbLacaItem6.Enabled == false)
            {

                using (var img = new Bitmap(pbLacaItem6.BackgroundImage, pbLacaItem6.ClientSize))
                {
                    ControlPaint.DrawImageDisabled(e.Graphics, img, 0, 0, pbLacaItem6.BackColor);
                }
            }
        }

        private void PbLacaItem7_Paint(object sender, PaintEventArgs e)
        {
            if (pbLacaItem7.Enabled == false)
            {

                using (var img = new Bitmap(pbLacaItem7.BackgroundImage, pbLacaItem7.ClientSize))
                {
                    ControlPaint.DrawImageDisabled(e.Graphics, img, 0, 0, pbLacaItem7.BackColor);
                }
            }
        }

        private void PbLacaItem8_Paint(object sender, PaintEventArgs e)
        {
            if (pbLacaItem8.Enabled == false)
            {

                using (var img = new Bitmap(pbLacaItem8.BackgroundImage, pbLacaItem8.ClientSize))
                {
                    ControlPaint.DrawImageDisabled(e.Graphics, img, 0, 0, pbLacaItem8.BackColor);
                }
            }
        }

        private void PbLacaItem9_Paint(object sender, PaintEventArgs e)
        {
            if (pbLacaItem9.Enabled == false)
            {

                using (var img = new Bitmap(pbLacaItem9.BackgroundImage, pbLacaItem9.ClientSize))
                {
                    ControlPaint.DrawImageDisabled(e.Graphics, img, 0, 0, pbLacaItem9.BackColor);
                }
            }
        }

        private void PbLacaItem10_Paint(object sender, PaintEventArgs e)
        {
            if (pbLacaItem10.Enabled == false)
            {

                using (var img = new Bitmap(pbLacaItem10.BackgroundImage, pbLacaItem10.ClientSize))
                {
                    ControlPaint.DrawImageDisabled(e.Graphics, img, 0, 0, pbLacaItem10.BackColor);
                }
            }
        }

        private void PbLacaItem11_Paint(object sender, PaintEventArgs e)
        {
            if (pbLacaItem11.Enabled == false)
            {

                using (var img = new Bitmap(pbLacaItem11.BackgroundImage, pbLacaItem11.ClientSize))
                {
                    ControlPaint.DrawImageDisabled(e.Graphics, img, 0, 0, pbLacaItem11.BackColor);
                }
            }
        }

        private void PbLacaItemAll_Paint(object sender, PaintEventArgs e)
        {
            if (pbLacaItemAll.Enabled == false)
            {

                using (var img = new Bitmap(pbLacaItemAll.BackgroundImage, pbLacaItemAll.ClientSize))
                {
                    ControlPaint.DrawImageDisabled(e.Graphics, img, 0, 0, pbLacaItemAll.BackColor);
                }
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (ISDataGridLoaded == true)
            //{
            //    //Check if Selected is ItemIndex of DataGridView
            //    if (dataGridView1.Rows[e.RowIndex].Cells["ItemIndex"].Selected)
            //    {
            //        //Open ItemPicker
            //        ItemPicker itemPicker = new ItemPicker();

            //        //Check DiaglogResult
            //        if (itemPicker.ShowDialog() != DialogResult.OK)
            //            return;

            //        //Get Item selected index
            //        int itemchange = itemPicker.ItemIndex;

            //        //Update DataGrid + Mysql
            //        UpdateDataview(e.RowIndex, itemchange);
            //    }
            //}
        }
        public void UpdateDataview(int line, int itemNew)
        {

            dataGridView1.Rows[line].Cells["ItemIndex"].Value = itemNew.ToString();
            dataGridView1.Rows[line].Cells["ItemName"].Value = databaseHandle.ItemNameFast(itemNew);
            dataGridView1.Rows[line].SetValues(new Bitmap(databaseHandle.IconFast(itemNew), 20, 20));

            //Write code to Update Database.

            //End function

        }
    }
}
