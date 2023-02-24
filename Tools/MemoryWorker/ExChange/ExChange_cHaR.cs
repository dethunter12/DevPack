using LcDevPack_TeamDamonA;
using LcDevPack_TeamDamonA.Tools;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SlimDX;
using SlimDX.Direct3D9;
using LcDevPack_TeamDamonA.Tools.MemoryWorker.ExChange;

namespace ExchangeExport
{
    public partial class ExchangeExport_cHaR : Form
    {
        public static Connection connection = new Connection();
        private string Host = MoonstoneEditor.connection.ReadSettings("Host");
        private string User = MoonstoneEditor.connection.ReadSettings("User");
        private string Password = MoonstoneEditor.connection.ReadSettings("Password");
        private string Database = MoonstoneEditor.connection.ReadSettings("Database");
        public static List<tbl_exchange> ExChangeList = new List<tbl_exchange>();


        int action_state = 0;

        DataTable dt_npc;
        DataTable dt_item;
        DataTable dt_item_exchange;

        ImageList img_item;
        ImageList img_npc;

        public Direct3D _Direct3D;
        public Device _Device;
        public float _Zoom;
        public float _LeftRight;
        public float _Rotation;
        public List<tMesh> _Models;
        public float _UpDown = -1f;


        private DatabaseHandle databaseHandle = new DatabaseHandle();

        System.Collections.Generic.List<ticon> List = new System.Collections.Generic.List<ticon>();

        public ExchangeExport_cHaR()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;


            button9.Enabled = false;
            button12.Enabled = false;
            button1.Enabled = false;

            InitializeDevice();

            LoadDG();
            //formatting_tbl(dgItems);
        }

        private void LoadDG()
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                dgItems.Rows.Clear();
                string str1 = "SELECT a_index, a_npc_index, a_result_itemIndex, a_result_itemCount, source_itemIndex0, source_itemCount0, source_itemIndex1, source_itemCount1, source_itemIndex2, source_itemCount2, source_itemIndex3, source_itemCount3, source_itemIndex4, source_itemCount4 FROM t_item_exchange ORDER BY a_index";
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
                MySqlCommand command = mySqlConnection.CreateCommand();
                command.CommandText = str1;

                mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = command.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    tbl_exchange exchange = new tbl_exchange();
                    exchange.index = Convert.ToInt32(mySqlDataReader.GetValue(0).ToString()); //dethunter12 add 
                    exchange.npcidx = Convert.ToInt32(mySqlDataReader.GetValue(1).ToString()); //dethunter12 add
                    exchange.result_itemIndex = Convert.ToInt32(mySqlDataReader.GetValue(2).ToString());
                    exchange.result_itemCount = Convert.ToInt32(mySqlDataReader.GetValue(3).ToString());
                    exchange.source_itemIndex0 = Convert.ToInt32(mySqlDataReader.GetValue(4).ToString()); //item index 1
                    exchange.source_itemCount0 = Convert.ToInt32(mySqlDataReader.GetValue(5).ToString());
                    exchange.source_itemIndex1 = Convert.ToInt32(mySqlDataReader.GetValue(6).ToString());
                    exchange.source_itemCount1 = Convert.ToInt32(mySqlDataReader.GetValue(7).ToString());
                    exchange.source_itemIndex2 = Convert.ToInt32(mySqlDataReader.GetValue(8).ToString());
                    exchange.source_itemCount2 = Convert.ToInt32(mySqlDataReader.GetValue(9).ToString());
                    exchange.source_itemIndex3 = Convert.ToInt32(mySqlDataReader.GetValue(10).ToString());
                    exchange.source_itemCount3 = Convert.ToInt32(mySqlDataReader.GetValue(11).ToString());
                    exchange.source_item_Index4 = Convert.ToInt32(mySqlDataReader.GetValue(12).ToString());
                    exchange.source_itemCount4 = Convert.ToInt32(mySqlDataReader.GetValue(13).ToString());
                    ExChangeList.Add(exchange); //add all the values to the list  box
                    string a_index = mySqlDataReader.GetValue(0).ToString();
                    string a_npc_index = mySqlDataReader.GetValue(1).ToString();
                    string item_id = mySqlDataReader.GetValue(2).ToString();

                    dgItems.Rows.Add(new Bitmap(databaseHandle.IconFast(Int32.Parse(item_id)), 20, 20), a_index, databaseHandle.ItemNameFast(Int32.Parse(item_id)), databaseHandle.MobNameFast(Int32.Parse(a_npc_index)));
                }
                mySqlConnection.Close();
                stopwatch.Stop();
                TimeSpan elapsed = stopwatch.Elapsed;
                string.Format("{0:00}:{1:00}:{2:00}.{3:00}", elapsed.Hours, elapsed.Minutes, elapsed.Seconds, (elapsed.Milliseconds / 10));

                //toolStripStatusLabel1.Text = "Ready";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while loading itemexchange db, Exception:\n {ex}", "Error");
            }
        }

        void item_src_init(PictureBox pb, TextBox id, TextBox name_src, TextBox qty)
        {
            pb.Image = null;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        void item_src_load(PictureBox pb, TextBox id, TextBox name_src, TextBox qty)
        {

        }

        private void language_selection_CheckedChanged(object sender, EventArgs e)
        {
            int lng_usa = ((RadioButton)sender).Name == "rd_usa" ? 1 : 0;

            label1.Text = label4.Text = label8.Text = label11.Text = label14.Text = label17.Text = label20.Text = lng_usa == 1 ? "ID :" : "รหัส :";
            label2.Text = lng_usa == 1 ? "Name :" : "ชื่อ npc :";
            label3.Text = label7.Text = label10.Text = label13.Text = label16.Text = label19.Text = lng_usa == 1 ? "Name :" : "ชื่อไอเทม :";

            //formatting_tbl(dgItems, ((RadioButton)sender).Name == "rd_usa" ? true : false);
        }
        public class ticon
        {
            public int ItemID;
            public int FileID;
            public int Row;
            public int Col;
            public string Name;
            public string Desc;
        }

        //public Bitmap IconFast(int itemID)
        //{
        //    Image image1 = Image.FromFile("icons/ItemBtn0.png");
        //    Bitmap bitmap1 = new Bitmap(32, 32);
        //    Graphics graphics1 = Graphics.FromImage((Image)bitmap1);
        //    Rectangle srcRect1 = new Rectangle(0, 0, 32, 32);
        //    graphics1.DrawImage(image1, 0, 0, srcRect1, GraphicsUnit.Pixel);
        //    graphics1.Dispose();

        //    if (itemID == -1)
        //        return global::ExchangeExport.Properties.Resources.question;

        //    //ticon ticon = IconList.List.Find((Predicate<ticon>)(p => p.ItemID.Equals(itemID)));

        //    //if (ticon == null)
        //    //    return bitmap1;

        //    //int fileId = ticon.FileID;
        //    //int row = ticon.Row;
        //    //int col = ticon.Col;

        //    //Image image2 = Image.FromFile("icons/ItemBtn" + fileId.ToString() + ".png");
        //    //Bitmap bitmap2 = new Bitmap(32, 32);
        //    //Graphics graphics2 = Graphics.FromImage((Image)bitmap2);
        //    //int y = row * 32;
        //    //Rectangle srcRect2 = new Rectangle(col * 32, y, 32, 32);
        //    //graphics2.DrawImage(image2, 0, 0, srcRect2, GraphicsUnit.Pixel);
        //    //graphics2.Dispose();
        //    //return bitmap2;
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;

            tb_reward_id.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void tb_reward_id_TextChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = databaseHandle.IconFast(Int32.Parse(tb_reward_id.Text.Trim()));
            tb_reward_name.Text = databaseHandle.ItemNameFast(Convert.ToInt32(tb_reward_id.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbExchangeID1.Text = "0";

            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;

            tbExchangeID1.Text = Convert.ToString(itemPicker.ItemIndex);
            //textBox7.Text = databaseHandle.ItemNameFast(Convert.ToInt32(r_t_id1.Text)); 
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            pictureBox3.Image = databaseHandle.IconFast(Int32.Parse(tbExchangeID1.Text.Trim()));
            tbExchangeName1.Text = databaseHandle.ItemNameFast(int.Parse(tbExchangeID1.Text.Trim()));
        }

        private void dgItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgItems.Rows[e.RowIndex].Cells["ID"].Value.ToString().Trim() != "")
            {
                //Stopwatch stopwatch = new Stopwatch();
                //stopwatch.Start();

                string strSQL = "select * from t_item_exchange where a_index = " + dgItems.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database);
                MySqlCommand command = mySqlConnection.CreateCommand();
                command.CommandText = strSQL;
                mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = command.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    tbl_exchange exchange = new tbl_exchange();
                    t_exchange_id.Text = mySqlDataReader["a_index"].ToString();
                    tx_npc_id.Text = mySqlDataReader["a_npc_index"].ToString();
                    tb_reward_id.Text = mySqlDataReader["result_itemIndex"].ToString();
                    tb_reward_qty.Text = mySqlDataReader["result_itemCount"].ToString();
                    tbExchangeID1.Text = mySqlDataReader["source_itemIndex0"].ToString();
                    tbExchangeID2.Text = mySqlDataReader["source_itemIndex1"].ToString();
                    tbExchangeID3.Text = mySqlDataReader["source_itemIndex2"].ToString();
                    tbExchangeID4.Text = mySqlDataReader["source_itemIndex3"].ToString();
                    tbExchangeID5.Text = mySqlDataReader["source_itemIndex4"].ToString();
                    tbExchange1Cnt.Text = mySqlDataReader["source_itemCount0"].ToString();
                    tbExchange2Cnt.Text = mySqlDataReader["source_itemCount1"].ToString();
                    tbExchange3Cnt.Text = mySqlDataReader["source_itemCount2"].ToString();
                    tbExchange4Cnt.Text = mySqlDataReader["source_itemCount3"].ToString();
                    tbExchange5Cnt.Text = mySqlDataReader["source_itemCount4"].ToString();
                    a_name.Text = mySqlDataReader["a_name"].ToString();
                    a_desc.Text = mySqlDataReader["a_desc"].ToString();
                    ExChangeList.Add(exchange);
                }
                mySqlConnection.Close();
            }
        }

        private void tx_npc_id_TextChanged(object sender, EventArgs e)
        {
            pc_npc.Image = databaseHandle.IconFast(int.Parse(tx_npc_id.Text.Trim()));
            tx_npc_name.Text = databaseHandle.MobNameFast(int.Parse(tx_npc_id.Text.Trim()));
        }

        private void r_t_id4_TextChanged(object sender, EventArgs e)
        {
            pictureBox6.Image = databaseHandle.IconFast(Int32.Parse(tbExchangeID4.Text.Trim()));
            tbExchangeName4.Text = databaseHandle.ItemNameFast(int.Parse(tbExchangeID4.Text.Trim()));
        }

        private void r_t_id5_TextChanged(object sender, EventArgs e)
        {
            pictureBox7.Image = databaseHandle.IconFast(Int32.Parse(tbExchangeID5.Text.Trim()));
            tbExchangeName5.Text = databaseHandle.ItemNameFast(int.Parse(tbExchangeID5.Text.Trim()));
        }

        private void r_t_id3_TextChanged(object sender, EventArgs e)
        {
            pictureBox5.Image = databaseHandle.IconFast(Int32.Parse(tbExchangeID3.Text.Trim()));
            tbExchangeName3.Text = databaseHandle.ItemNameFast(int.Parse(tbExchangeID3.Text.Trim()));
        }

        private void r_t_id2_TextChanged(object sender, EventArgs e)
        {

            pictureBox4.Image = databaseHandle.IconFast(Int32.Parse(tbExchangeID2.Text.Trim()));
            tbExchangeName2.Text = databaseHandle.ItemNameFast(int.Parse(tbExchangeID2.Text.Trim()));
        }


        private void InitializeDevice()
        {
            _Direct3D = new Direct3D();
            Direct3D direct3D = _Direct3D;
            int adapter = 0;
            int num1 = 1;
            IntPtr handle1 = Handle;
            int num2 = 32;
            PresentParameters[] presentParametersArray = new PresentParameters[1];
            int index = 0;
            PresentParameters presentParameters = new PresentParameters();
            presentParameters.SwapEffect = SwapEffect.Discard;
            IntPtr handle2 = panel3DView.Handle;
            presentParameters.DeviceWindowHandle = handle2;
            int num3 = 1;
            presentParameters.Windowed = num3 != 0;
            int width = panel3DView.Width;
            presentParameters.BackBufferWidth = width;
            int height = panel3DView.Height;
            presentParameters.BackBufferHeight = height;
            int num4 = 21;
            presentParameters.BackBufferFormat = (SlimDX.Direct3D9.Format)num4;
            presentParametersArray[index] = presentParameters;
            _Device = new Device(direct3D, adapter, (DeviceType)num1, handle1, (CreateFlags)num2, presentParametersArray);
            _Device.SetRenderState<Cull>(RenderState.CullMode, Cull.None);
            _Device.SetRenderState<FillMode>(RenderState.FillMode, FillMode.Solid);
            _Device.SetRenderState(RenderState.Lighting, false);
            CameraPositioning();
        }

        private void CameraPositioning()
        {
            _Device.SetTransform(TransformState.Projection, Matrix.PerspectiveFovLH(100f, 1f, 1f, 450f));
            _Device.SetTransform(TransformState.View, Matrix.LookAtLH(new Vector3(0.0f, 0.0f, -5f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 1f, 0.0f)));
            _Device.SetTransform(TransformState.World, Matrix.RotationYawPitchRoll(0.0f, 0.0f, 0.0f));
        }

        private void Render()
        {
            _Device.Viewport = new Viewport(0, 0, panel3DView.Width, panel3DView.Height);
            _Device.Clear(ClearFlags.ZBuffer | ClearFlags.Target, new Color4(Color.FromKnownColor(KnownColor.Control)), 1f, 0);
            _Device.BeginScene();
            _Device.SetTransform(TransformState.View, Matrix.LookAtLH(new Vector3(0.0f, 0.0f, _Zoom), new Vector3(_LeftRight, _UpDown, 0.0f), new Vector3(0.0f, 1f, 0.0f)));
            _Device.SetTransform(TransformState.World, Matrix.RotationYawPitchRoll(_Rotation, 3.1f, 0.0f));
            if (_Models != null && (uint)_Models.Count<tMesh>() > 0U)
            {
                for (int index = 0; index < _Models.Count<tMesh>(); ++index)
                {
                    if (_Models[index].TexData != null)
                        _Device.SetTexture(0, (BaseTexture)_Models[index].TexData);
                    for (int subset = 0; subset < 1000; ++subset)
                        _Models[index].MeshData.DrawSubset(subset);
                }
            }
            _Device.EndScene();
            _Device.Present();
            _Rotation = _Rotation - 0.03f;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Render();
        }

        private void dgItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbExchangeID2.Text = "0";

            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;

            tbExchangeID2.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbExchangeID3.Text = "0";

            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;

            tbExchangeID3.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbExchangeID4.Text = "0";

            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;

            tbExchangeID4.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tbExchangeID5.Text = "0";

            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;

            tbExchangeID5.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void t_exchange_id_TextChanged(object sender, EventArgs e)
        {
            button9.Enabled = (t_exchange_id.Text.Trim().Length > 0);
            button12.Enabled = (t_exchange_id.Text.Trim().Length > 0);
            button1.Enabled = (t_exchange_id.Text.Trim().Length > 0);

            button8.Enabled = (t_exchange_id.Text.Trim().Length <= 0);
        }

        private void btn_EnabledChanged(object sender, EventArgs e)
        {
            if (((Button)sender).Enabled == true)
            {
                switch (((Button)sender).Name)
                {
                    case "button9": ((Button)sender).BackColor = Color.LightCyan; break;
                    case "button12": ((Button)sender).BackColor = Color.LightCoral; break;
                    case "button1": ((Button)sender).BackColor = Color.Plum; break;
                    default: ((Button)sender).BackColor = Color.Honeydew; break;
                }
            }
            else
            {
                ((Button)sender).BackColor = Color.Silver;
            }
        }

        private void Number_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            t_exchange_id.Text = "";

            tx_npc_id.Text = "0";

            tb_reward_id.Text = "0";
            tb_reward_qty.Text = "0";

            tbExchangeID1.Text = "0";
            tbExchange1Cnt.Text = "0";

            tbExchangeID2.Text = "0";
            tbExchange2Cnt.Text = "0";

            tbExchangeID3.Text = "0";
            tbExchange3Cnt.Text = "0";

            tbExchangeID4.Text = "0";
            tbExchange4Cnt.Text = "0";

            tbExchangeID5.Text = "0";
            tbExchange5Cnt.Text = "0";

            a_name.Text = "";
            a_desc.Text = "";
        }

        private void bt_npc_Click(object sender, EventArgs e)
        {
            tx_npc_id.Text = "0";

            MobPicker mobPicker = new MobPicker();
            if (mobPicker.ShowDialog() != DialogResult.OK)
                return;

            tx_npc_id.Text = mobPicker.MobIndex.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tx_npc_id.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Please input NPC ID first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string strSQL = "INSERT INTO t_item_exchange(a_index, a_enable, a_npc_index, a_result_itemIndex, a_result_itemCount, "
                        + "source_itemIndex0, source_itemCount0, source_itemIndex1, source_itemCount1, source_itemIndex2, "
                        + "source_itemCount2, source_itemIndex3, source_itemCount3, source_itemIndex4, source_itemCount4) "
                        + "select IFNULL(max(a.a_index), 0) + 1 as id, "
                        + "a_enable, "
                        + tx_npc_id.Text.Trim() + ", "
                        + (tb_reward_id.Text.Trim().Length == 0 ? "0" : tb_reward_id.Text.Trim()) + ", "
                        + (tb_reward_qty.Text.Trim().Length == 0 ? "0" : tb_reward_qty.Text.Trim()) + ", "
                        + (tbExchangeID1.Text.Trim().Length == 0 ? "0" : tbExchangeID1.Text.Trim()) + ", " //source_itemIndex0
                        + (tbExchange1Cnt.Text.Trim().Length == 0 ? "0" : tbExchange1Cnt.Text.Trim()) + ", " //source_itemCount0
                        + (tbExchangeID2.Text.Trim().Length == 0 ? "0" : tbExchangeID2.Text.Trim()) + ", " //source_itemIndex1
                        + (tbExchange2Cnt.Text.Trim().Length == 0 ? "0" : tbExchange2Cnt.Text.Trim()) + ", " //source_itemCount1
                        + (tbExchangeID3.Text.Trim().Length == 0 ? "0" : tbExchangeID3.Text.Trim()) + ", " //source_itemIndex2
                        + (tbExchange3Cnt.Text.Trim().Length == 0 ? "0" : tbExchange3Cnt.Text.Trim()) + ", " //source_itemCount2
                        + (tbExchangeID4.Text.Trim().Length == 0 ? "0" : tbExchangeID4.Text.Trim()) + ", " //source_itemIndex3
                        + (tbExchange4Cnt.Text.Trim().Length == 0 ? "0" : tbExchange4Cnt.Text.Trim()) + ", " //source_itemCount3
                        + (tbExchangeID5.Text.Trim().Length == 0 ? "0" : tbExchangeID5.Text.Trim()) + ", " //source_itemIndex4
                        + (tbExchange5Cnt.Text.Trim().Length == 0 ? "0" : tbExchange5Cnt.Text.Trim()) + ", '" //source_itemCount4
                        + a_name.Text.Trim() + "', '" + a_desc.Text.Trim() + "' from t_item_exchange a";

            databaseHandle.SendQueryMySql(Host, User, Password, Database, strSQL);
            LoadDG();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete " + tb_reward_name.Text.Trim() + " ?", "Please confirm delete.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (t_exchange_id.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("No data to delete in select item to delete first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string strSQL = "delete from t_item_exchange where a_index = " + t_exchange_id.Text.Trim();

                databaseHandle.SendQueryMySql(Host, User, Password, Database, strSQL);
                LoadDG();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (tx_npc_id.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Please input NPC ID first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ID = Convert.ToInt32(dgItems.Rows[0].Cells["ID"].Value); //dethunter12 test .-.
            int num = ExChangeList.FindIndex((tbl_exchange p) => p.index.Equals(ID));
            ExChangeList[num].npcidx = Convert.ToInt32(tx_npc_id.Text);
            ExChangeList[num].result_itemIndex = Convert.ToInt32(tb_reward_id.Text);
            ExChangeList[num].result_itemCount = Convert.ToInt32(tb_reward_qty.Text);
            ExChangeList[num].source_itemIndex0 = Convert.ToInt32(tbExchangeID1.Text);
            ExChangeList[num].source_itemCount0 = Convert.ToInt32(tbExchange1Cnt.Text);
            ExChangeList[num].source_itemIndex1 = Convert.ToInt32(tbExchangeID2.Text);
            ExChangeList[num].source_itemCount1 = Convert.ToInt32(tbExchange2Cnt.Text);
            ExChangeList[num].source_itemIndex2 = Convert.ToInt32(tbExchangeID3.Text);
            ExChangeList[num].source_itemCount2 = Convert.ToInt32(tbExchange3Cnt.Text);
            ExChangeList[num].source_itemIndex3 = Convert.ToInt32(tbExchangeID4.Text);
            ExChangeList[num].source_itemCount3 = Convert.ToInt32(tbExchange4Cnt.Text);
            ExChangeList[num].source_item_Index4 = Convert.ToInt32(tbExchangeID5.Text);
            ExChangeList[num].source_itemCount4 = Convert.ToInt32(tbExchange5Cnt.Text);
            ExChangeList[num].npcidx = Convert.ToInt32(tx_npc_id.Text);
            ExChangeList[num].npcidx = Convert.ToInt32(tx_npc_id.Text);
            string strSQL = "UPDATE t_item_exchange SET "
                        + "a_npc_index = " + tx_npc_id.Text.Trim()
                        + ", result_itemIndex = " + (tb_reward_id.Text.Trim().Length == 0 ? "0" : tb_reward_id.Text.Trim())
                        + ", result_itemCount = " + (tb_reward_qty.Text.Trim().Length == 0 ? "0" : tb_reward_qty.Text.Trim())
                        + ", source_itemIndex0 = " + (tbExchangeID1.Text.Trim().Length == 0 ? "0" : tbExchangeID1.Text.Trim())  //source_itemIndex0
                        + ", source_itemCount0 = " + (tbExchange1Cnt.Text.Trim().Length == 0 ? "0" : tbExchange1Cnt.Text.Trim())    //source_itemCount0
                        + ", source_itemIndex1 = " + (tbExchangeID2.Text.Trim().Length == 0 ? "0" : tbExchangeID2.Text.Trim())  //source_itemIndex1
                        + ", source_itemCount1 = " + (tbExchange2Cnt.Text.Trim().Length == 0 ? "0" : tbExchange2Cnt.Text.Trim())    //source_itemCount1
                        + ", source_itemIndex2 = " + (tbExchangeID3.Text.Trim().Length == 0 ? "0" : tbExchangeID3.Text.Trim())  //source_itemIndex2
                        + ", source_itemCount2 = " + (tbExchange3Cnt.Text.Trim().Length == 0 ? "0" : tbExchange3Cnt.Text.Trim())  //source_itemCount2
                        + ", source_itemIndex3 = " + (tbExchangeID4.Text.Trim().Length == 0 ? "0" : tbExchangeID4.Text.Trim())  //source_itemIndex3
                        + ", source_itemCount3 = " + (tbExchange4Cnt.Text.Trim().Length == 0 ? "0" : tbExchange4Cnt.Text.Trim())  //source_itemCount3
                        + ", source_itemIndex4 = " + (tbExchangeID5.Text.Trim().Length == 0 ? "0" : tbExchangeID5.Text.Trim())  //source_itemIndex4
                        + ", source_itemCount4  = " + (tbExchange5Cnt.Text.Trim().Length == 0 ? "0" : tbExchange5Cnt.Text.Trim())  //source_itemCount4
                        + ", a_name = '" + (tbExchangeID5.Text.Trim().Length == 0 ? "0" : tbExchangeID5.Text.Trim()) +"'" //a_name
                        + ", a_desc  = '" + (tbExchange5Cnt.Text.Trim().Length == 0 ? "0" : tbExchange5Cnt.Text.Trim())  //a_desc
                        + "' where a_index = " + t_exchange_id.Text.Trim();

            databaseHandle.SendQueryMySql(Host, User, Password, Database, strSQL);
            LoadDG();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "File item_exchange.lod|item_exchange*.lod";
            saveFileDialog.FileName = "item_exchange.lod";
            saveFileDialog.Title = "Save item_exchange.lod file";
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Create(saveFileDialog.FileName));
            int num = databaseHandle.CountByRow(Host, User, Password, Database, "SELECT COUNT(*) FROM t_item_exchange");
            int max = databaseHandle.CountByRow(Host, User, Password, Database, "SELECT MAX(a_index) FROM t_item_exchange");
            string str1 = "SELECT * FROM t_item_exchange WHERE a_enable = 1 ORDER by a_index";
            string connectionString = "datasource=" + Host + ";port=3306;username=" + User + ";password=" + Password + ";database=" + Database;

            MySqlConnection mySqlConnection1 = new MySqlConnection(connectionString);
            MySqlCommand command1 = mySqlConnection1.CreateCommand();
            command1.CommandText = str1;
            mySqlConnection1.Open();

            MySqlDataReader mySqlDataReader1 = command1.ExecuteReader();
            binaryWriter.Write(max);
            binaryWriter.Write(num);
            for (int i = 0; i <= num - 1; i++) //create the statement to execute the binary reader for each instance of i
            {
                binaryWriter.Write(ExChangeList[i].index);
                binaryWriter.Write(ExChangeList[i].npcidx);
                binaryWriter.Write(ExChangeList[i].result_itemIndex);
                binaryWriter.Write(ExChangeList[i].result_itemCount);
                binaryWriter.Write(ExChangeList[i].source_itemIndex0);
                binaryWriter.Write(ExChangeList[i].source_itemCount0);
                binaryWriter.Write(ExChangeList[i].source_itemIndex1);
                binaryWriter.Write(ExChangeList[i].source_itemCount1);
                binaryWriter.Write(ExChangeList[i].source_itemIndex2);
                binaryWriter.Write(ExChangeList[i].source_itemCount2);
                binaryWriter.Write(ExChangeList[i].source_itemIndex3);
                binaryWriter.Write(ExChangeList[i].source_itemCount3);
                binaryWriter.Write(ExChangeList[i].source_item_Index4);
                binaryWriter.Write(ExChangeList[i].source_itemCount4);
            }
            //while (mySqlDataReader1.Read())
            //{
            //    int ordinal1 = mySqlDataReader1.GetOrdinal("a_index");
            //    string s1 = mySqlDataReader1.GetString(ordinal1);
            //    binaryWriter.Write(int.Parse(s1));
            //    int ordinal2 = mySqlDataReader1.GetOrdinal("a_npc_index");
            //    string s2 = mySqlDataReader1.GetString(ordinal2);
            //    binaryWriter.Write(int.Parse(s2));
            //    int ordinal3 = mySqlDataReader1.GetOrdinal("result_itemIndex");
            //    string s3 = mySqlDataReader1.GetString(ordinal3);
            //    binaryWriter.Write(int.Parse(s3));
            //    int ordinal4 = mySqlDataReader1.GetOrdinal("result_itemCount");
            //    string s4 = mySqlDataReader1.GetString(ordinal4);
            //    binaryWriter.Write(int.Parse(s4));
            //    int ordinal5 = mySqlDataReader1.GetOrdinal("source_itemIndex0");
            //    string s5 = mySqlDataReader1.GetString(ordinal5);
            //    binaryWriter.Write(int.Parse(s5));
            //    int ordinal6 = mySqlDataReader1.GetOrdinal("source_itemCount0");
            //    string s6 = mySqlDataReader1.GetString(ordinal6);
            //    binaryWriter.Write(int.Parse(s6));
            //    int ordinal7 = mySqlDataReader1.GetOrdinal("source_itemIndex1");
            //    string s7 = mySqlDataReader1.GetString(ordinal7);
            //    binaryWriter.Write(int.Parse(s7));
            //    int ordinal8 = mySqlDataReader1.GetOrdinal("source_itemCount1");
            //    string s8 = mySqlDataReader1.GetString(ordinal8);
            //    binaryWriter.Write(int.Parse(s8));
            //    int ordinal9 = mySqlDataReader1.GetOrdinal("source_itemIndex2");
            //    string s9 = mySqlDataReader1.GetString(ordinal9);
            //    binaryWriter.Write(int.Parse(s9));
            //    int ordinal10 = mySqlDataReader1.GetOrdinal("source_itemCount2");
            //    string s10 = mySqlDataReader1.GetString(ordinal10);
            //    binaryWriter.Write(int.Parse(s10));
            //    int ordinal11 = mySqlDataReader1.GetOrdinal("source_itemIndex3");
            //    string s11 = mySqlDataReader1.GetString(ordinal11);
            //    binaryWriter.Write(int.Parse(s11));
            //    int ordinal12 = mySqlDataReader1.GetOrdinal("source_itemCount3");
            //    string s12 = mySqlDataReader1.GetString(ordinal12);
            //    binaryWriter.Write(int.Parse(s12));
            //    int ordinal13 = mySqlDataReader1.GetOrdinal("source_itemIndex4");
            //    string s13 = mySqlDataReader1.GetString(ordinal13);
            //    binaryWriter.Write(int.Parse(s13));
            //    int ordinal14 = mySqlDataReader1.GetOrdinal("source_itemCount4");
            //    string s14 = mySqlDataReader1.GetString(ordinal14);
            //    binaryWriter.Write(int.Parse(s14));
            //}

            mySqlConnection1.Close();
            binaryWriter.Close();
            MessageBox.Show("It's done.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tx_npc_id.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Please input NPC ID first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string strSQL = "INSERT INTO t_item_exchange SELECT IFNULL(max(a_index), 0) + 1 AS id, a_enable, a_npc_index, a_result_itemIndex, a_result_itemCount, "
                        + "source_itemIndex0, source_itemCount0, source_itemIndex1, source_itemCount1, source_itemIndex2, "
                        + "source_itemCount2, source_itemIndex3, source_itemCount3, source_itemIndex4, source_itemCount4, a_name, a_desc FROM t_item_exchange a";

            databaseHandle.SendQueryMySql(Host, User, Password, Database, strSQL);

            MessageBox.Show("Successful copy", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadDG();
        }

    }
}


