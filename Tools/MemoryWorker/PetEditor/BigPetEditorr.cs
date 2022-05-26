// Decompiled with JetBrains decompiler
// Type: LcDevPack_TeamDamonA.Tools.MemoryWorker.PetEditor.BigPetEditor
// Assembly: LcDevPack_TeamDamonA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA\LcDevPack_TeamDamonA.exe

using SlimDX;
using SlimDX.Direct3D9;
using StringExporter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LcDevPack_TeamDamonA.Tools.MemoryWorker.PetEditor
{
    public class BigPetEditorr : Form
    {
        public static Connection connection = new Connection();
        private string Host = AffinityEditor.connection.ReadSettings("Host");
        private string User = AffinityEditor.connection.ReadSettings("User");
        private string Password = AffinityEditor.connection.ReadSettings("Password");
        private string Database = AffinityEditor.connection.ReadSettings("Database");
        private string language = ItemEditor2.connection.ReadSettings("Language");//dethunter12 test
        private IContainer components = (IContainer)null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadFromDatabaseToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem exitToolStripMenuItem;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtSearch;
        private GroupBox groupBox2;
        private Button btnDelete;
        private Button btnAdd;
        private ListBox listBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox3;
        private Button button3;
        private Label label3;
        private Label label2;
        private CheckBox checkBox1;
        private TextBox txtID;
        private GroupBox groupBox7;
        private Label label51;
        private TextBox tbAniDamage1_2;
        private TextBox tbSmc1_2;
        private Label label65;
        private TextBox tbAniIdle1_2;
        private Label label49;
        private TextBox tbAniIdle2_2;
        private Label label54;
        private TextBox tbAniRun1_2;
        private Label label56;
        private TextBox tbSkillSummon1_2;
        private TextBox tbAniWalk1_2;
        private TextBox tbAniAttack1_2;
        private Label label58;
        private Label label60;
        private Label label50;
        private TextBox tbLevelUp1_2;
        private Label label62;
        private TextBox tbSpeed1_2;
        private TextBox tbAniAttack2_2;
        private Label label61;
        private Label label59;
        private TextBox tbAniDie1_2;
        private Label label57;
        private Label label63;
        private TextBox tbMount1_2;
        private GroupBox groupBox6;
        private TextBox tbSmc1_1;
        private Label label17;
        private TextBox tbAniAttack2_1;
        private Label label44;
        private TextBox tbSpeed1_1;
        private Label label48;
        private TextBox tbAniDamage1_1;
        private Label label45;
        private TextBox tbSkillSummon1_1;
        private Label label64;
        private TextBox tbAniAttack1_1;
        private Label label52;
        private TextBox tbAniIdle2_1;
        private Label label40;
        private TextBox tbMount1_1;
        private Label label55;
        private TextBox tbAniIdle1_1;
        private Label label31;
        private TextBox tbAniDie1_1;
        private TextBox tbAniWalk1_1;
        private Label label43;
        private Label label32;
        private Label label46;
        private TextBox tbAniRun1_1;
        private TextBox tbLevelUp1_1;
        private Label label53;
        private GroupBox groupBox5;
        private Label label47;
        private TextBox tbTransType;
        private TextBox tbTransStart;
        private Label label41;
        private TextBox tbTransEnd;
        private Label label42;
        private Label label33;
        private TextBox tbFlag;
        private Label label37;
        private Label label39;
        private TextBox tbStrong;
        private GroupBox groupBox4;
        private TextBox tbAttackSpeed;
        private Label label28;
        private TextBox tbDeadly;
        private Label label29;
        private TextBox tbMagicAvoid;
        private Label label25;
        private TextBox TbHitpoint;
        private Label label26;
        private TextBox tbAvoid;
        private Label label27;
        private TextBox tbmDefense;
        private Label label24;
        private TextBox tbAttack;
        private Label label20;
        private TextBox tbDefense;
        private Label label21;
        private TextBox tbmAttack;
        private Label label22;
        private TextBox tbAfterDead;
        private Label label23;
        private TextBox tbAiSlot;
        private Label label19;
        private TextBox tbDelay;
        private Label label18;
        private TextBox tbRecoveryMP;
        private TextBox tbRecoveryHP;
        private Label label16;
        private Label label15;
        private TextBox tbmaxStm;
        private Label label12;
        private TextBox tbmaxMP;
        private TextBox tbmaxHP;
        private TextBox tbmaxFaith;
        private Label label14;
        private Label label13;
        private Label label11;
        private TextBox tbConstitution;
        private TextBox tbIntelligence;
        private TextBox TbDexteriety;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox tbStrength;
        private Label label6;
        private TextBox tbAwful;
        private Label label30;
        private Label label36;
        private TextBox tbNoraml;
        private Label label34;
        private TextBox tbWeak;
        private Label label38;
        private TextBox tbBasicSkill2;
        private TextBox tbBasicSkill1;
        private TextBox tbCritical;
        private Label label35;
        private GroupBox groupBox20;
        private CheckBox chk3D;
        private TrackBar slideLeftRight;
        private TrackBar slideUpDown;
        private TrackBar slideZoom;
        private Panel panel3DView;
        private PictureBox PbSelectID1;
        private PictureBox pictureBox1;
        private TextBox tbItemIndex;
        private Label label10;
        private TextBox tbType;
        private Label label5;
        private ComboBox comboBox1;
        private TextBox tbEnable;
        private Button btnCopy;
        private Button BtnReadSmc2;
        private Button BtnReadSmc;
        private TextBox txtName;
        private Button BtnAniWalk;
        private Button BtnAniIdle;
        private Button BtnAniDam;
        private Button BtnAniAttack1;
        private Button btnAniDie;
        private Button btnAniRun;
        private Button btnAniIdle2;
        private Button BtnAniAttack2_1;
        private Button btnAniIdle2_1;
        private Button btnAniRun_1;
        private Button btnAniDie_1;
        private Button BtnAniAttack1_1;
        private Button BtnAniDam_1;
        private Button BtnAniIdle1;
        private Button BtnAniWalk_1;
        private Button BtnAniAttack2;
        private Button btnLevelup2;
        private Button btnLevelup1;
        public string _ClientPath = LcDevPack_TeamDamonA.Tools.MobEditor.connection.ReadSettings("ClientPath");
        public Direct3D _Direct3D;
        public Device _Device;
        public float _Zoom;
        public float _LeftRight;
        public float _Rotation;
        public float _UpDown = -1f;
        public List<tMesh> _Models;
        private Timer timer1;
        private TextBox tbFileCol;
        private TextBox tbFileRow;
        private TextBox tbFileID;
        public DatabaseHandle databaseHandle = new DatabaseHandle();
        private Label Status;
        private Button button2;
        private Button button1;
        private GroupBox groupBox8;
        private Label label4;
        private TextBox t_tex1;
        private TextBox t_row1;
        private Label label66;
        private TextBox t_col1;
        private Label label67;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label label68;
        private TextBox t_tex2;
        private TextBox t_row2;
        private Label label69;
        private TextBox t_col2;
        private Label label70;
        private CheckBox cbMount2;
        private CheckBox cbMount1;
        private TextBox tbItemExist;
        bool doespetexist; //dethunter12 7/9/2018
        private Label label71;
        private ASCIIEncoding _Enc = new ASCIIEncoding();
        private TabPage tabPage3;
        private GroupBox groupBox9;
        private TextBox tb_to_ev_id;
        private Label label72;
        private TextBox tb_ev_ID;
        private Label label74;
        private TextBox tb_ev_Level;
        private Label label73;
        private TextBox tb_ev_Faith;
        private Label label76;
        private TextBox tb_ev_Stemina;
        private Label label75;
        private TextBox tb_ev_order;
        private Label label79;
        private TextBox tb_ev_stat2;
        private Label label78;
        private TextBox tb_ev_stat1;
        private Label label77;
        private ComboBox flag;
        private Label label80;
        private TabPage tabPage4;
        private GroupBox groupBox10;
        private TextBox tb_exp_a_cooltime_rate;
        private Label label81;
        private TextBox tb_exp_a_cooltime;
        private Label label82;
        private TextBox tb_exp_a_acc_rate_param2;
        private Label label83;
        private TextBox tb_exp_a_acc_rate_param1;
        private Label label84;
        private TextBox tb_exp_a_max_acc_param2;
        private Label label85;
        private TextBox tb_exp_a_max_acc_param1;
        private Label label86;
        private TextBox tb_exp_a_pet_index;
        private Label label88;
        private ToolStripMenuItem exportBipetlodToolStripMenuItem;
        private ToolStripMenuItem usaToolStripMenuItem;
        private ToolStripMenuItem frenchToolStripMenuItem;
        private ToolStripMenuItem thaiToolStripMenuItem;
        private ToolStripMenuItem germanToolStripMenuItem;
        private ToolStripMenuItem mexicanToolStripMenuItem;
        private ToolStripMenuItem polandToolStripMenuItem;
        private ToolStripMenuItem italianToolStripMenuItem;
        private ToolStripMenuItem spanishToolStripMenuItem;
        private Encoding encoding = Encoding.GetEncoding("ISO-8859-1");
        public BigPetEditorr()
        {
            InitializeComponent();

        }
        //public static List<LcDevPack_TeamDamonA.Tools.MemoryWorker.Item.ItemContainer> ItemList = new List<LcDevPack_TeamDamonA.Tools.MemoryWorker.Item.ItemContainer>();
        private void BitPetEditor_Load(object sender, EventArgs e)
        {
            //ItemList.Clear();
            string readerItemAll = _ClientPath + "Data\\itemAll.lod";
            Open_Lod.ReadItem(readerItemAll);
            string readerItemName = _ClientPath + "Local\\us\\String\\strItem_us.lod";
            Open_Lod.ReadItemName(readerItemName);
            mySQL.SetConnection();
            InitializeDevice();
            listBox1.Items.Clear();
            new LoadFromDatabase().tPets_Import();
            new LoadFromDatabase().tPets_Evolution_Import();
            new LoadFromDatabase().tPets_Exp_Import();
            RefreshAll();            
            label71.Text = "Pet Count: " + AllLists.tpet_MenuData.Count();
            listBox1.SelectedIndex = 0; //dethunter12 list box not default 6/30/2019
            //label71.Text = "Pet Count: " + Open_Lod.ItemList.Count();
        }

        


        private void LoadStartupString() //dethunter12 add
        {
            comboBox1.Items.AddRange(new object[3]
                {
                    "1 - Human",
                    "2 - Beast",
                     "3 - Demon"

                 });
        }

        private void MakeLCModels(string SMCFile)
        {
            System.Collections.Generic.List<float> source1 = new System.Collections.Generic.List<float>();
            System.Collections.Generic.List<float> source2 = new System.Collections.Generic.List<float>();
            System.Collections.Generic.List<float> source3 = new System.Collections.Generic.List<float>();
            System.Collections.Generic.List<float> floatList1 = new System.Collections.Generic.List<float>();
            System.Collections.Generic.List<float> floatList2 = new System.Collections.Generic.List<float>();
            System.Collections.Generic.List<float> floatList3 = new System.Collections.Generic.List<float>();
            _Models = new System.Collections.Generic.List<tMesh>();
            try
            {
                System.Collections.Generic.List<smcMesh> source4 = SMCReader.ReadFile(SMCFile);
                for (int index1 = 0; index1 < source4.Count(); ++index1)
                {
                    if (LCMeshReader.ReadFile(source4[index1].FileName))
                    {
                        tMeshContainer pMesh = LCMeshReader.pMesh;
                        source1.Add((pMesh.Vertices).Max((p => p.X)));
                        source2.Add((pMesh.Vertices).Max((p => p.Y)));
                        source3.Add((pMesh.Vertices).Max((p => p.Z)));
                        floatList1.Add((pMesh.Vertices).Min((p => p.X)));
                        floatList2.Add((pMesh.Vertices).Min((p => p.Y)));
                        floatList3.Add((pMesh.Vertices).Min(p => p.Z));
                        for (int index2 = 0; index2 < (pMesh.Objects).Count(); ++index2)
                        {
                            int toVert = (int)pMesh.Objects[index2].ToVert;
                            int faceCount = (int)pMesh.Objects[index2].FaceCount;
                            short[] faces = pMesh.Objects[index2].GetFaces();
                            CustomVertex.PositionNormalTextured[] data = new CustomVertex.PositionNormalTextured[toVert];
                            int fromVert = (int)pMesh.Objects[index2].FromVert;
                            for (int index3 = 0; index3 < pMesh.Objects[index2].ToVert; ++index3)
                            {
                                data[index3].Position = new Vector3(pMesh.Vertices[fromVert].X, pMesh.Vertices[fromVert].Y, pMesh.Vertices[fromVert].Z);
                                data[index3].Normal = new Vector3(pMesh.Normals[fromVert].X, pMesh.Normals[fromVert].Y, pMesh.Normals[fromVert].Z);
                                try
                                {
                                    data[index3].Texture = new Vector2(pMesh.UVMaps[0].Coords[fromVert].U, pMesh.UVMaps[0].Coords[fromVert].V);
                                }
                                catch
                                {
                                    data[index3].Texture = new Vector2(0.0f, 0.0f);
                                }
                                ++fromVert;
                            }
                            VertexBuffer vertexBuffer = new VertexBuffer(_Device, (data).Count() * 32, Usage.None, VertexFormat.PositionNormal | VertexFormat.Texture1, Pool.Default);
                            Mesh mesh = new Mesh(_Device, (faces).Count() / 3, (data).Count(), MeshFlags.Managed, VertexFormat.PositionNormal | VertexFormat.Texture1);
                            DataStream dataStream1;
                            using (dataStream1 = mesh.VertexBuffer.Lock(0, (data).Count() * 32, LockFlags.None))
                            {
                                dataStream1.WriteRange(data);
                                mesh.VertexBuffer.Unlock();
                            }
                            DataStream dataStream2;
                            using (dataStream2 = mesh.IndexBuffer.Lock(0, (faces).Count() * 2, LockFlags.None))
                            {
                                dataStream2.WriteRange(faces);
                                mesh.IndexBuffer.Unlock();
                            }
                            if ((uint)(pMesh.Weights).Count() > 0U)
                            {
                                string[] strArray = new string[(pMesh.Weights).Count()];
                                System.Collections.Generic.List<int>[] intListArray = new System.Collections.Generic.List<int>[(pMesh.Weights).Count()];
                                System.Collections.Generic.List<float>[] floatListArray = new System.Collections.Generic.List<float>[(pMesh.Weights).Count()];
                                for (int index3 = 0; index3 < (pMesh.Weights).Count(); ++index3)
                                {
                                    strArray[index3] = _Enc.GetString(pMesh.Weights[index3].JointName);
                                    intListArray[index3] = new System.Collections.Generic.List<int>();
                                    floatListArray[index3] = new System.Collections.Generic.List<float>();
                                    for (int index4 = 0; index4 < (pMesh.Weights[index3].WeightsMap).Count(); ++index4)
                                    {
                                        intListArray[index3].Add(pMesh.Weights[index3].WeightsMap[index4].Index);
                                        floatListArray[index3].Add(pMesh.Weights[index3].WeightsMap[index4].Weight);
                                    }
                                }
                                mesh.SkinInfo = new SkinInfo((data).Count(), VertexFormat.PositionNormal | VertexFormat.Texture1, (int)pMesh.HeaderInfo.JointCount);
                                for (int bone = 0; bone < (intListArray).Count(); ++bone)
                                {
                                    mesh.SkinInfo.SetBoneName(bone, strArray[bone]);
                                    mesh.SkinInfo.SetBoneInfluence(bone, intListArray[bone].ToArray(), floatListArray[bone].ToArray());
                                }
                            }
                            mesh.GenerateAdjacency(0.5f);
                            mesh.ComputeNormals();
                            Texture texture = null;
                            string objName = _Enc.GetString(pMesh.Objects[index2].Textures[0].InternalName);
                            int index5 = source4[index1].Object.FindIndex(x => x.Name.Equals(objName));
                            if (index5 != -1)
                                texture = GetTextureFromFile(source4[index1].Object[index5].Texture);
                            _Models.Add(new tMesh(mesh, texture));
                        }
                    }
                }
            }
            catch
            {
            }
            try
            {
                _Zoom = (new float[3]
                {
          source1.Max(),
          source2.Max(),
          source3.Max()
                }).Max() * 3f;
            }
            catch
            {
            }
            slideZoom.Value = (int)_Zoom * 100;
        }

        private void InitializeDevice()
        {
            //you mest do private void example() and with all the code from panel1 (working) and call the example() to start form for example..
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
            if (_Models != null && (uint)_Models.Count() > 0U)
            {
                for (int index = 0; index < _Models.Count(); ++index)
                {
                    if (_Models[index].TexData != null)
                        _Device.SetTexture(0, _Models[index].TexData);
                    for (int subset = 0; subset < 1000; ++subset)
                        _Models[index].MeshData.DrawSubset(subset);
                }
            }
            _Device.EndScene();
            _Device.Present();
            _Rotation = _Rotation - 0.03f;
        }
        private SlimDX.Direct3D9.Format ConvFormat(texFormat tFormat)
        {
            SlimDX.Direct3D9.Format format = SlimDX.Direct3D9.Format.Unknown;
            switch (tFormat)
            {
                case texFormat.RGB:
                    return SlimDX.Direct3D9.Format.R8G8B8;
                case texFormat.ARGB:
                    return SlimDX.Direct3D9.Format.A8R8G8B8;
                case texFormat.DXT1:
                    return SlimDX.Direct3D9.Format.Dxt1;
                case texFormat.DXT3:
                    return SlimDX.Direct3D9.Format.Dxt3;
                default:
                    return format;
            }
        }

        private Texture BuildTexture(byte[] imageData, SlimDX.Direct3D9.Format imageFormat, int width, int height)
        {
            if (imageFormat == SlimDX.Direct3D9.Format.R8G8B8)
            {
                MemoryStream memoryStream;
                using (memoryStream = new MemoryStream())
                {
                    Tex.makeRGB8(imageData, width, height).Save((Stream)memoryStream, ImageFormat.Bmp);
                    memoryStream.Write(imageData, 0, imageData.Length);
                    memoryStream.Position = 0L;
                    return Texture.FromStream(_Device, (Stream)memoryStream, width, height, 0, Usage.SoftwareProcessing, SlimDX.Direct3D9.Format.A8B8G8R8, Pool.Default, Filter.None, Filter.None, 0);
                }
            }
            else if (imageFormat == SlimDX.Direct3D9.Format.A8R8G8B8)
            {
                MemoryStream memoryStream;
                using (memoryStream = new MemoryStream())
                {
                    Tex.makeRGB(imageData, width, height).Save((Stream)memoryStream, ImageFormat.Bmp);
                    memoryStream.Write(imageData, 0, imageData.Length);
                    memoryStream.Position = 0L;
                    return Texture.FromStream(_Device, (Stream)memoryStream, width, height, 0, Usage.SoftwareProcessing, SlimDX.Direct3D9.Format.A8B8G8R8, Pool.Default, Filter.None, Filter.None, 0);
                }
            }
            else
            {
                Texture texture = new Texture(_Device, width, height, 0, Usage.None, imageFormat, Pool.Managed);
                using (Stream data = (Stream)texture.LockRectangle(0, LockFlags.None).Data)
                {
                    data.Write(imageData, 0, ((IEnumerable<byte>)imageData).Count<byte>());
                    texture.UnlockRectangle(0);
                }
                return texture;
            }
        }

        private Texture GetTextureFromFile(string FileName)
        {
            Texture texture = null;
            if (File.Exists(FileName))
            {
                Tex.ReadFile(FileName);
                SlimDX.Direct3D9.Format imageFormat = ConvFormat(Tex.GetFormat());
                texture = BuildTexture(Tex.lcTex.imageData[0], imageFormat, (int)Tex.lcTex.Header.Width, (int)Tex.lcTex.Header.Height);
            }
            return texture;
        }


        private void slideZoom_Scroll(object sender, EventArgs e)
        {
            _Zoom = (float)slideZoom.Value / 100f;
        }

        private void slideUpDown_Scroll(object sender, EventArgs e)
        {
            _UpDown = (float)slideUpDown.Value / 1000f;
        }

        private void slideLeftRight_Scroll(object sender, EventArgs e)
        {
            _LeftRight = (float)slideLeftRight.Value / 1000f;
        }

        private int GetID()
        {
            int result = -1;
            int.TryParse(listBox1.Text.Split(' ')[0], out result);
            return result;
        }
        public void Clean()
        {
            AllLists.tpet_MenuData.Clear();
            AllLists.tpet_Menu.Clear();
            listBox1.Items.Clear();
        }

        public void MakeList()
        {
            //Clean();
            List<string> stringList = new List<string>();
            List<t_attkpet> all = AllLists.tpet_MenuData.FindAll((Predicate<t_attkpet>)(p => p.name.ToLower().Contains(txtName.Text.ToLower())));
            for (int index = 0; index < all.Count<t_attkpet>(); ++index)
                stringList.Add(all[index].index.ToString() + " - " + all[index].name.ToString());
            listBox1.Items.AddRange((object[])stringList.ToArray());
        }
        private void AniFind(object sender, EventArgs e)
        {

            string str1 = Path.GetDirectoryName(_ClientPath).Replace("Data", "").Replace("data", ""); //dethunter12 adjust

            if (File.Exists(str1 + "\\" + tbSmc1_1.Text)) //dethunter12 adjust
            {
                foreach (string readAllLine in File.ReadAllLines(str1 + "\\" + tbSmc1_1.Text)) //dethunter12 adjust
                {
                    if (readAllLine.Contains("ANIMSET"))
                    {
                        string str2 = str1 + "\\" + readAllLine.Split('"')[1];
                        if (File.Exists(str2))
                        {
                            Animation_Picker animation_Picker = (Animation_Picker)null;
                            switch ((sender as Button).Name)
                            {
                                case "BtnAniAttack1":
                                    animation_Picker = new Animation_Picker(str2, "Attack");
                                    break;
                                case "BtnAniAttack2":
                                    animation_Picker = new Animation_Picker(str2, "Attack2");
                                    break;
                                case "BtnAniDam":
                                    animation_Picker = new Animation_Picker(str2, "Damage");
                                    break;
                                case "btnAniDie":
                                    animation_Picker = new Animation_Picker(str2, "Die");
                                    break;
                                case "BtnAniIdle":
                                    animation_Picker = new Animation_Picker(str2, "Idle");
                                    break;
                                case "btnAniIdle2":
                                    animation_Picker = new Animation_Picker(str2, "Idle2");
                                    break;
                                case "btnAniRun":
                                    animation_Picker = new Animation_Picker(str2, "Run");
                                    break;
                                case "BtnAniWalk":
                                    animation_Picker = new Animation_Picker(str2, "Walk");
                                    break;
                                case "btnLevelup1":
                                    animation_Picker = new Animation_Picker(str2, "levelup");
                                    break;
                                default:
                                    int num = (int)MessageBox.Show("Not found : " + (sender as Button).Name);
                                    break;
                            }
                            if (animation_Picker.ShowDialog() == DialogResult.OK)
                            {
                                switch ((sender as Button).Name)
                                {
                                    case "BtnAniAttack1":
                                        tbAniAttack1_1.Text = animation_Picker.Animation;
                                        tbAniAttack1_1.BackColor = Color.PaleTurquoise;
                                        continue;
                                    case "BtnAniAttack2":
                                        tbAniAttack2_1.Text = animation_Picker.Animation;
                                        tbAniAttack2_1.BackColor = Color.PaleTurquoise;
                                        continue;
                                    case "BtnAniDam":
                                        tbAniDamage1_1.Text = animation_Picker.Animation;
                                        tbAniDamage1_1.BackColor = Color.PaleTurquoise;
                                        continue;
                                    case "btnAniDie":
                                        tbAniDie1_1.Text = animation_Picker.Animation;
                                        tbAniDie1_1.BackColor = Color.PaleTurquoise;
                                        continue;
                                    case "BtnAniIdle":
                                        tbAniIdle1_1.Text = animation_Picker.Animation;
                                        tbAniIdle1_1.BackColor = Color.PaleTurquoise; //dethunter12 7/14/2018
                                        continue;
                                    case "btnAniIdle2":
                                        tbAniIdle2_1.Text = animation_Picker.Animation;
                                        tbAniIdle2_1.BackColor = Color.PaleTurquoise; //dethunter12 7/14/2018
                                        continue;
                                    case "btnAniRun":
                                        tbAniRun1_1.Text = animation_Picker.Animation;
                                        tbAniRun1_1.BackColor = Color.PaleTurquoise; //dethunter12 7/14/2018
                                        continue;
                                    case "BtnAniWalk":
                                        tbAniWalk1_1.Text = animation_Picker.Animation;
                                        tbAniWalk1_1.BackColor = Color.PaleTurquoise; //dethunter12 7/14/2018
                                        continue;
                                    case "btnLevelup1":
                                        tbLevelUp1_1.Text = animation_Picker.Animation;
                                        tbLevelUp1_1.BackColor = Color.PaleTurquoise; //dethunter12 7/14/2018
                                        continue;
                                    default:
                                        continue;
                                }
                            }
                        }
                        else
                        {
                            int num4 = (int)new CustomMessage("Not Found :" + str2).ShowDialog(); //dethunter12 add

                        }
                    }
                }
            }
            else
                new CustomMessage("SMC File not found").Show();
        } //dethunter12 6/27/2018

        private void AniFind2(object sender, EventArgs e) //dethunter12 6/27/2018
        {

            string str1 = Path.GetDirectoryName(_ClientPath).Replace("Data", "").Replace("data", ""); //dethunter12 adjust

            if (File.Exists(str1 + "\\" + tbSmc1_2.Text)) //dethunter12 adjust
            {
                foreach (string readAllLine in File.ReadAllLines(str1 + "\\" + tbSmc1_2.Text)) //dethunter12 adjust
                {
                    if (readAllLine.Contains("ANIMSET"))
                    {
                        string str2 = str1 + "\\" + readAllLine.Split('"')[1];
                        if (File.Exists(str2))
                        {
                            Animation_Picker animation_Picker = (Animation_Picker)null;
                            switch ((sender as Button).Name)
                            {
                                case "BtnAniAttack1_1":
                                    animation_Picker = new Animation_Picker(str2, "Attack");
                                    break;
                                case "BtnAniAttack2_1":
                                    animation_Picker = new Animation_Picker(str2, "Attack2");
                                    break;
                                case "BtnAniDam_1":
                                    animation_Picker = new Animation_Picker(str2, "Damage");
                                    break;
                                case "btnAniDie_1":
                                    animation_Picker = new Animation_Picker(str2, "Die");
                                    break;
                                case "BtnAniIdle1":
                                    animation_Picker = new Animation_Picker(str2, "Idle");
                                    break;
                                case "btnAniIdle2_1":
                                    animation_Picker = new Animation_Picker(str2, "Idle2");
                                    break;
                                case "btnAniRun_1":
                                    animation_Picker = new Animation_Picker(str2, "Run");
                                    break;
                                case "BtnAniWalk_1":
                                    animation_Picker = new Animation_Picker(str2, "Walk");
                                    break;
                                case "btnLevelup2":
                                    animation_Picker = new Animation_Picker(str2, "levelup");
                                    break;
                                default:
                                    int num = (int)MessageBox.Show("Not found : " + (sender as Button).Name);
                                    break;
                            }
                            if (animation_Picker.ShowDialog() == DialogResult.OK)
                            {
                                switch ((sender as Button).Name)
                                {
                                    case "BtnAniAttack1_":
                                        tbAniAttack1_2.Text = animation_Picker.Animation;
                                        tbAniAttack1_2.BackColor = Color.PaleTurquoise; //dethunter12 7/14/2018
                                        continue;
                                    case "BtnAniAttack2_1":
                                        tbAniAttack2_2.Text = animation_Picker.Animation;
                                        tbAniAttack2_2.BackColor = Color.PaleTurquoise; //dethunter12 7/14/2018
                                        continue;
                                    case "BtnAniDam_1":
                                        tbAniDamage1_2.Text = animation_Picker.Animation;
                                        tbAniDamage1_2.BackColor = Color.PaleTurquoise; //dethunter12 7/14/2018
                                        continue;
                                    case "btnAniDie_1":
                                        tbAniDie1_2.Text = animation_Picker.Animation;
                                        tbAniDie1_2.BackColor = Color.PaleTurquoise; //dethunter12 7/14/2018
                                        continue;
                                    case "BtnAniIdle1":
                                        tbAniIdle1_2.Text = animation_Picker.Animation;
                                        tbAniDie1_2.BackColor = Color.PaleTurquoise; //dethunter12 7/14/2018
                                        continue;
                                    case "btnAniIdle2_1":
                                        tbAniIdle2_2.Text = animation_Picker.Animation;
                                        tbAniIdle2_2.BackColor = Color.PaleTurquoise; //dethunter12 7/14/2018
                                        continue;
                                    case "btnAniRun_1":
                                        tbAniRun1_2.Text = animation_Picker.Animation;
                                        tbAniRun1_2.BackColor = Color.PaleTurquoise; //dethunter12 7/14/2018
                                        continue;
                                    case "BtnAniWalk_1":
                                        tbAniWalk1_2.Text = animation_Picker.Animation;
                                        tbAniWalk1_2.BackColor = Color.PaleTurquoise; //dethunter12 7/14/2018
                                        continue;
                                    case "btnLevelup2":
                                        tbLevelUp1_2.Text = animation_Picker.Animation;
                                        tbLevelUp1_2.BackColor = Color.PaleTurquoise; //dethunter12 7/14/2018
                                        continue;
                                    default:
                                        continue;
                                }
                            }
                        }
                        else
                        {
                            int num4 = (int)new CustomMessage("Not Found :" + str2).ShowDialog(); //dethunter12 add

                        }
                    }
                }
            }
            else
                new CustomMessage("SMC File not found").Show();
        } //dethunter12 6/27/2018

        private void RefreshAll()//Add By Assasin
        {
            this.listBox1.Items.Clear();
            List<int> SortedIDs = new List<int>();
            for (int i = 0; i < AllLists.tpet_MenuData.Count<t_attkpet>(); i++)
            {
                SortedIDs.Add(AllLists.tpet_MenuData[i].index);
            }
            SortedIDs.Sort();
            Predicate<t_attkpet> match = null;
            Predicate<t_attkpet> predicate2 = null;
            for (int a = 0; a < SortedIDs.Count<int>(); a++)
            {
                if (match == null)
                {
                    if (predicate2 == null)
                    {
                        predicate2 = p => p.index.Equals(SortedIDs[a]);
                    }
                    match = predicate2;
                }
                int num2 = AllLists.tpet_MenuData.FindIndex(match);
                if (num2 != -1)
                {
                    string item = AllLists.tpet_MenuData[num2].index + " - " + AllLists.tpet_MenuData[num2].name;
                    this.listBox1.Items.Add(item);
                }
            }
        }

        private void IconPet()
        {
            string Query = "select a_index, a_texture_id, a_texture_row, a_texture_col FROM t_item WHERE a_index ='" + tbItemIndex.Text + "';";
            foreach (DataRow row in (InternalDataCollectionBase)mySQL.GetFromQuery(Query).Rows)
            {
                tbFileID.Text = Convert.ToString(row["a_texture_id"]);
                tbFileRow.Text = Convert.ToString(row["a_texture_row"]);
                tbFileCol.Text = Convert.ToString(row["a_texture_col"]);
            }
        }

        private void loadFromDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            new LoadFromDatabase().tPets_Import();
            //MakeList();  
            RefreshAll();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int PetID = GetID();
            if (PetID == -1)
                return;
            t_attkpet tAttkpet = AllLists.tpet_MenuData.Find((Predicate<t_attkpet>)(p => p.index.Equals(PetID)));
            if (tAttkpet == null)
                return;
            ResetTbBackGround(); //dethunter12 7/14/2018 reset the field colors on listbox id change
            Status.Text = ""; //reset the text field when clicking another id.
            tbItemExist.Text = ""; //reset item exist field
            txtID.Text = tAttkpet.index.ToString();
            tbEnable.Text = tAttkpet.enable.ToString(); //dethunter12 add 7/9/2018
            txtName.Text = tAttkpet.name.ToString();
            tbType.Text = tAttkpet.type.ToString(); //dethunter12 add 6/27/2018
            IsPetInDB(); //dethunter12 add 7/10/2018
            comboBox1.SelectedIndex = tAttkpet.type -1; //dethunter12 test  if list box changes does the combo box update correctly?
            if (Convert.ToInt16(tbType.Text) < 1)
            {
                comboBox1.SelectedIndex = 0;
            }
            this.flag.SelectedIndex = tAttkpet.flag -1;//AssasinPL 11/07/2018
            //comboBox1.SelectedIndex = tAttkpet.type -1;
            tbStrength.Text = tAttkpet.str.ToString(); //dethunter12 add 6/27/2018
            tbConstitution.Text = tAttkpet.con.ToString();  //dethunter12 add 6/27/2018
            TbDexteriety.Text = tAttkpet.dex.ToString();  //dethunter12 add 6/27/2018
            tbIntelligence.Text = tAttkpet.intel.ToString(); //dethunter12 add 6/27/2018
            tbItemIndex.Text = tAttkpet.itemidx.ToString();  //dethunter12 add 6/27/2018
            tbmaxFaith.Text = tAttkpet.maxFaith.ToString();  //dethunter12 add 6/27/2018
            tbmaxStm.Text = tAttkpet.maxStm.ToString();  //dethunter12 add 6/27/2018
            tbmaxHP.Text = tAttkpet.maxHP.ToString();  //dethunter12 add 6/27/2018
            tbmaxMP.Text = tAttkpet.maxMP.ToString();  //dethunter12 add 6/27/2018
            tbRecoveryHP.Text = tAttkpet.recoverHP.ToString();  //dethunter12 add 6/27/2018
            tbRecoveryMP.Text = tAttkpet.recoverMP.ToString();  //dethunter12 add 6/27/2018
            tbDelay.Text = tAttkpet.delay.ToString();  //dethunter12 add 6/27/2018
            tbAiSlot.Text = tAttkpet.AISlot.ToString();  //dethunter12 add 6/27/2018
            tbAfterDead.Text = tAttkpet.afterDead.ToString();  //dethunter12 add 6/27/2018
            tbAttack.Text = tAttkpet.attack.ToString();  //dethunter12 add 6/27/2018
            tbDefense.Text = tAttkpet.defense.ToString();  //dethunter12 add 6/27/2018
            tbmAttack.Text = tAttkpet.mAttack.ToString();  //dethunter12 add 6/27/2018
            tbmDefense.Text = tAttkpet.mDefense.ToString();  //dethunter12 add 6/27/2018
            TbHitpoint.Text = tAttkpet.avoidPoint.ToString();  //dethunter12 add 6/27/2018
            tbAvoid.Text = tAttkpet.avoidPoint.ToString();  //dethunter12 add 6/27/2018
            tbMagicAvoid.Text = tAttkpet.mavoidPoint.ToString();  //dethunter12 add 6/27/2018
            tbAttackSpeed.Text = tAttkpet.attackSpeed.ToString();  //dethunter12 add 6/27/2018
            tbDeadly.Text = tAttkpet.Deadly.ToString();  //dethunter12 add 6/27/2018
            tbCritical.Text = tAttkpet.Critical.ToString();  //dethunter12 add 6/27/2018
            tbAwful.Text = tAttkpet.awful.ToString();  //dethunter12 add 6/27/2018
            tbStrong.Text = tAttkpet.strong.ToString();  //dethunter12 add 6/27/2018
            tbNoraml.Text = tAttkpet.normal.ToString();  //dethunter12 add 6/27/2018
            tbWeak.Text = tAttkpet.weak.ToString();  //dethunter12 add 6/27/2018
            tbBasicSkill1.Text = tAttkpet.bagicSkill1.ToString();  //dethunter12 add 6/27/2018
            tbBasicSkill2.Text = tAttkpet.bagicSkill2.ToString();  //dethunter12 add 6/27/2018
            tbFlag.Text = tAttkpet.flag.ToString(); //dethunter12 add 6/27/2018
            tbTransType.Text = tAttkpet.transType.ToString(); //dethunter12 add 6/27/2018
            tbTransStart.Text = tAttkpet.transStart.ToString(); //dethunter12 add 6/27/2018
            tbTransEnd.Text = tAttkpet.transEnd.ToString(); //dethunter12 add 6/27/2018
            tbSmc1_1.Text = tAttkpet.smcFileName1; //dethunter12 add 6/27/2018 @ Edit By AssasinPL
            tbAniIdle1_1.Text = tAttkpet.aniIdle1; //dethunter12 add 6/27/2018 @ Edit By AssasinPL
            tbAniIdle2_1.Text = tAttkpet.aniIdle1_2; //dethunter12 add 6/27/2018 @ Edit By AssasinPL
            tbAniAttack1_1.Text = tAttkpet.aniAttack1; //dethunter12 add 6/27/2018 @ Edit By AssasinPL
            tbAniAttack2_1.Text = tAttkpet.aniAttack1_2; //dethunter12 add 6/27/2018 @ Edit By AssasinPL
            tbAniDamage1_1.Text = tAttkpet.aniDamage1; //dethunter12 add 6/27/2018 @ Edit By AssasinPL
            tbAniDie1_1.Text = tAttkpet.aniDie1; //dethunter12 add 6/27/2018 @ Edit By AssasinPL
            tbAniWalk1_1.Text = tAttkpet.aniWalk1; //dethunter12 add 6/27/2018 @ Edit By AssasinPL
            tbAniRun1_1.Text = tAttkpet.aniRun1; //dethunter12 add 6/27/2018 @ Edit By AssasinPL
            tbLevelUp1_1.Text = tAttkpet.aniLevelup1; //dethunter12 7/14/2018 add
            tbMount1_1.Text = tAttkpet.mount1.ToString(); //dethunter12 add 6/27/2018
            if (tbMount1_1.Text == "1") //dethunter12 7/10/2018
            {
                cbMount1.Text = "Mount";
               
                cbMount1.Checked = true;
                cbMount1.BackColor = Color.LimeGreen;
            }
            else 
            {
                cbMount1.Text = "NotMount";
                cbMount1.Checked = false;
                cbMount1.BackColor = Color.Red;
            }
            tbSkillSummon1_1.Text = tAttkpet.summonSkill1.ToString(); //dethunter12 add 6/27/2018
            tbSpeed1_1.Text = tAttkpet.speed1.ToString(); //dethunter12 add 6/27/2018
            tbSmc1_2.Text = tAttkpet.smcFileName2.ToString(); //dethunter12 add 6/27/2018
            tbAniDie1_2.Text = tAttkpet.aniIdle2.ToString(); //dethunter12 add 6/27/2018
            tbAniIdle1_2.Text = tAttkpet.aniIdle2.ToString(); //dethunter12 add 6/27/2018
            tbAniIdle2_2.Text = tAttkpet.aniIdle2_2.ToString(); //dethunter12 add 6/27/2018
            tbAniAttack1_2.Text = tAttkpet.aniAttack2.ToString(); //dethunter12 add 6/27/2018
            tbAniAttack2_2.Text = tAttkpet.aniAttack2_2.ToString(); //dethunter12 add 6/27/2018
            tbAniDamage1_2.Text = tAttkpet.aniDamage1_2.ToString(); //dethunter12 add 6/27/2018
            tbAniDie1_2.Text = tAttkpet.aniDie1_2.ToString(); //dethunter12 add 6/27/2018
            tbAniWalk1_2.Text = tAttkpet.aniWalk1_2.ToString(); //dethunter12 add 6/27/2018
            tbAniRun1_2.Text = tAttkpet.aniRun1_2.ToString(); //dethunter12 add 6/27/2018
            tbLevelUp1_2.Text = tAttkpet.aniLevelup1_2.ToString(); //dethunter12 add 6/27/2018
            tbMount1_2.Text = tAttkpet.mount1_2.ToString(); //dethunter12 add 6/27/2018
            if (tbMount1_2.Text == "1") //dethunter12 7/10/2018
            {
                cbMount2.Text = "Mount";

                cbMount2.Checked = true;
                cbMount2.BackColor = Color.LimeGreen;
            }
            else
            {
                cbMount2.Text = "NotMount";
                cbMount2.Checked = false;
                cbMount2.BackColor = Color.Red;
            }
            tbSkillSummon1_2.Text = tAttkpet.summonSkill1_2.ToString(); //dethunter12 add 6/27/2018
            tbSpeed1_2.Text = tAttkpet.speed1_2.ToString(); //dethunter12 add 6/27/2018
            if (chk3D.Checked && File.Exists(_ClientPath + tbSmc1_1.Text))
            {
                Console.WriteLine("Create Model > " + _ClientPath + tbSmc1_1.Text);
                MakeLCModels(_ClientPath + tbSmc1_1.Text);//Main
            }
            try
            {
                pictureBox1.Image = databaseHandle.IconItem(int.Parse(tbFileID.Text), int.Parse(tbFileRow.Text), int.Parse(tbFileCol.Text));                
            }
            catch
            {
            }
            try
            {/*
                //pictureBox2.Image = null;
                pictureBox2.Image = databaseHandle.IconSkill1(int.Parse(t_tex1.Text), int.Parse(t_row1.Text), int.Parse(t_col1.Text));*/
            }
            catch
            {
            }
            try
            {/*
                pictureBox3.Image = databaseHandle.IconSkill1(int.Parse(t_tex2.Text), int.Parse(t_row2.Text), int.Parse(t_col2.Text));*/
            }
            catch
            {
            }
            if (tAttkpet.enable == 1)
            {
                checkBox1.Checked = true;
                checkBox1.BackColor = Color.LimeGreen; //dethunter12 add 6/27/2018
            }
            else
            {
                checkBox1.Checked = false;
                checkBox1.BackColor = Color.Red; //dethunter12 add 6/27/2018
            }
            //PetEvolution
            this.groupBox9.Enabled = false;
            int PetID_ev = Convert.ToInt32(this.txtID.Text);
            int num = AllLists.tpet_ev_MenuData.FindIndex((BigpetEv p) => p.APetIdx.Equals(PetID_ev));
            if (num != -1)
            {
                this.groupBox9.Enabled = true;
                tb_ev_ID.Text = Convert.ToString(AllLists.tpet_ev_MenuData[num].APetIdx);
                tb_ev_Level.Text = Convert.ToString(AllLists.tpet_ev_MenuData[num].Level);
                tb_ev_Stemina.Text = Convert.ToString(AllLists.tpet_ev_MenuData[num].Stemina);
                tb_ev_Faith.Text = Convert.ToString(AllLists.tpet_ev_MenuData[num].Faith);
                tb_ev_stat1.Text = Convert.ToString(AllLists.tpet_ev_MenuData[num].a_stat1);
                tb_ev_stat2.Text = Convert.ToString(AllLists.tpet_ev_MenuData[num].a_stat2);
                tb_to_ev_id.Text = Convert.ToString(AllLists.tpet_ev_MenuData[num].a_ev_pet_index);
                tb_ev_order.Text = Convert.ToString(AllLists.tpet_ev_MenuData[num].a_order);
            }

            //PetExp
            this.groupBox10.Enabled = false;
            int PetID_Exp = Convert.ToInt32(this.txtID.Text);
            int num2 = AllLists.tpet_exp_MenuData.FindIndex((BigpetExp p) => p.a_pet_index.Equals(PetID_Exp));
            if (num2 != -1)
            {
                this.groupBox10.Enabled = true;
                tb_exp_a_pet_index.Text = Convert.ToString(AllLists.tpet_exp_MenuData[num2].a_pet_index);
                tb_exp_a_max_acc_param1.Text = Convert.ToString(AllLists.tpet_exp_MenuData[num2].a_max_acc_param1);
                tb_exp_a_max_acc_param2.Text = Convert.ToString(AllLists.tpet_exp_MenuData[num2].a_max_acc_param2);
                tb_exp_a_acc_rate_param1.Text = Convert.ToString(AllLists.tpet_exp_MenuData[num2].a_acc_rate_param1);
                tb_exp_a_acc_rate_param2.Text = Convert.ToString(AllLists.tpet_exp_MenuData[num2].a_acc_rate_param2);
                tb_exp_a_cooltime.Text = Convert.ToString(AllLists.tpet_exp_MenuData[num2].a_cooltime);
                tb_exp_a_cooltime_rate.Text = Convert.ToString(AllLists.tpet_exp_MenuData[num2].a_cooltime_rate);
            }

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BigPetEditorr));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportBipetlodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mexicanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbItemExist = new System.Windows.Forms.TextBox();
            this.tbFileCol = new System.Windows.Forms.TextBox();
            this.tbFileRow = new System.Windows.Forms.TextBox();
            this.tbFileID = new System.Windows.Forms.TextBox();
            this.tbEnable = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.PbSelectID1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbItemIndex = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.chk3D = new System.Windows.Forms.CheckBox();
            this.slideLeftRight = new System.Windows.Forms.TrackBar();
            this.slideUpDown = new System.Windows.Forms.TrackBar();
            this.slideZoom = new System.Windows.Forms.TrackBar();
            this.panel3DView = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.tbFlag = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.tbStrong = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbAttackSpeed = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tbDeadly = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tbMagicAvoid = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.TbHitpoint = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tbAvoid = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tbmDefense = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tbAttack = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbDefense = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbmAttack = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbAfterDead = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbAiSlot = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbDelay = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbRecoveryMP = new System.Windows.Forms.TextBox();
            this.tbRecoveryHP = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbmaxStm = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbmaxMP = new System.Windows.Forms.TextBox();
            this.tbmaxHP = new System.Windows.Forms.TextBox();
            this.tbmaxFaith = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbConstitution = new System.Windows.Forms.TextBox();
            this.tbIntelligence = new System.Windows.Forms.TextBox();
            this.TbDexteriety = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbStrength = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAwful = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.tbNoraml = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.tbWeak = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.tbBasicSkill2 = new System.Windows.Forms.TextBox();
            this.tbBasicSkill1 = new System.Windows.Forms.TextBox();
            this.tbCritical = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flag = new System.Windows.Forms.ComboBox();
            this.label80 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label68 = new System.Windows.Forms.Label();
            this.t_tex2 = new System.Windows.Forms.TextBox();
            this.t_row2 = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.t_col2 = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t_tex1 = new System.Windows.Forms.TextBox();
            this.t_row1 = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.t_col1 = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbMount2 = new System.Windows.Forms.CheckBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLevelup2 = new System.Windows.Forms.Button();
            this.BtnAniAttack2_1 = new System.Windows.Forms.Button();
            this.btnAniIdle2_1 = new System.Windows.Forms.Button();
            this.btnAniRun_1 = new System.Windows.Forms.Button();
            this.btnAniDie_1 = new System.Windows.Forms.Button();
            this.BtnAniAttack1_1 = new System.Windows.Forms.Button();
            this.BtnAniDam_1 = new System.Windows.Forms.Button();
            this.BtnAniIdle1 = new System.Windows.Forms.Button();
            this.BtnAniWalk_1 = new System.Windows.Forms.Button();
            this.BtnReadSmc2 = new System.Windows.Forms.Button();
            this.label51 = new System.Windows.Forms.Label();
            this.tbAniDamage1_2 = new System.Windows.Forms.TextBox();
            this.tbSmc1_2 = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.tbAniIdle1_2 = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.tbAniIdle2_2 = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.tbAniRun1_2 = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.tbSkillSummon1_2 = new System.Windows.Forms.TextBox();
            this.tbAniWalk1_2 = new System.Windows.Forms.TextBox();
            this.tbAniAttack1_2 = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.tbLevelUp1_2 = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.tbSpeed1_2 = new System.Windows.Forms.TextBox();
            this.tbAniAttack2_2 = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.tbAniDie1_2 = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.tbMount1_2 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbMount1 = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLevelup1 = new System.Windows.Forms.Button();
            this.BtnAniAttack2 = new System.Windows.Forms.Button();
            this.btnAniIdle2 = new System.Windows.Forms.Button();
            this.btnAniRun = new System.Windows.Forms.Button();
            this.btnAniDie = new System.Windows.Forms.Button();
            this.BtnAniAttack1 = new System.Windows.Forms.Button();
            this.BtnAniDam = new System.Windows.Forms.Button();
            this.BtnAniIdle = new System.Windows.Forms.Button();
            this.BtnAniWalk = new System.Windows.Forms.Button();
            this.BtnReadSmc = new System.Windows.Forms.Button();
            this.tbSmc1_1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbAniAttack2_1 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.tbSpeed1_1 = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.tbAniDamage1_1 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.tbSkillSummon1_1 = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.tbAniAttack1_1 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.tbAniIdle2_1 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.tbMount1_1 = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.tbAniIdle1_1 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tbAniDie1_1 = new System.Windows.Forms.TextBox();
            this.tbAniWalk1_1 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.tbAniRun1_1 = new System.Windows.Forms.TextBox();
            this.tbLevelUp1_1 = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label47 = new System.Windows.Forms.Label();
            this.tbTransType = new System.Windows.Forms.TextBox();
            this.tbTransStart = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.tbTransEnd = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tb_ev_order = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.tb_ev_stat2 = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.tb_ev_stat1 = new System.Windows.Forms.TextBox();
            this.label77 = new System.Windows.Forms.Label();
            this.tb_ev_Faith = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.tb_ev_Stemina = new System.Windows.Forms.TextBox();
            this.label75 = new System.Windows.Forms.Label();
            this.tb_ev_Level = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.tb_to_ev_id = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.tb_ev_ID = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.tb_exp_a_cooltime_rate = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.tb_exp_a_cooltime = new System.Windows.Forms.TextBox();
            this.label82 = new System.Windows.Forms.Label();
            this.tb_exp_a_acc_rate_param2 = new System.Windows.Forms.TextBox();
            this.label83 = new System.Windows.Forms.Label();
            this.tb_exp_a_acc_rate_param1 = new System.Windows.Forms.TextBox();
            this.label84 = new System.Windows.Forms.Label();
            this.tb_exp_a_max_acc_param2 = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.tb_exp_a_max_acc_param1 = new System.Windows.Forms.TextBox();
            this.label86 = new System.Windows.Forms.Label();
            this.tb_exp_a_pet_index = new System.Windows.Forms.TextBox();
            this.label88 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Status = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideLeftRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideZoom)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportBipetlodToolStripMenuItem,
            this.loadFromDatabaseToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportBipetlodToolStripMenuItem
            // 
            this.exportBipetlodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usaToolStripMenuItem,
            this.frenchToolStripMenuItem,
            this.thaiToolStripMenuItem,
            this.germanToolStripMenuItem,
            this.mexicanToolStripMenuItem,
            this.polandToolStripMenuItem,
            this.italianToolStripMenuItem,
            this.spanishToolStripMenuItem});
            this.exportBipetlodToolStripMenuItem.Name = "exportBipetlodToolStripMenuItem";
            this.exportBipetlodToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exportBipetlodToolStripMenuItem.Text = "Export bipet.lod";
            // 
            // usaToolStripMenuItem
            // 
            this.usaToolStripMenuItem.Name = "usaToolStripMenuItem";
            this.usaToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.usaToolStripMenuItem.Text = "Export";
            this.usaToolStripMenuItem.Click += new System.EventHandler(this.usaToolStripMenuItem_Click);
            // 
            // frenchToolStripMenuItem
            // 
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            this.frenchToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            // 
            // thaiToolStripMenuItem
            // 
            this.thaiToolStripMenuItem.Name = "thaiToolStripMenuItem";
            this.thaiToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            // 
            // germanToolStripMenuItem
            // 
            this.germanToolStripMenuItem.Name = "germanToolStripMenuItem";
            this.germanToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            // 
            // mexicanToolStripMenuItem
            // 
            this.mexicanToolStripMenuItem.Name = "mexicanToolStripMenuItem";
            this.mexicanToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            // 
            // polandToolStripMenuItem
            // 
            this.polandToolStripMenuItem.Name = "polandToolStripMenuItem";
            this.polandToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            // 
            // italianToolStripMenuItem
            // 
            this.italianToolStripMenuItem.Name = "italianToolStripMenuItem";
            this.italianToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            // 
            // spanishToolStripMenuItem
            // 
            this.spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
            this.spanishToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            // 
            // loadFromDatabaseToolStripMenuItem
            // 
            this.loadFromDatabaseToolStripMenuItem.Name = "loadFromDatabaseToolStripMenuItem";
            this.loadFromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.loadFromDatabaseToolStripMenuItem.Text = "Load From Database";
            this.loadFromDatabaseToolStripMenuItem.Click += new System.EventHandler(this.loadFromDatabaseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Visible = false;
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(179, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(179, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 63);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(43, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(166, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCopy);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 421);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pets";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(80, 392);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(58, 23);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(155, 392);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(54, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 392);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 368);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(227, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(628, 490);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.tbItemExist);
            this.tabPage1.Controls.Add(this.tbFileCol);
            this.tabPage1.Controls.Add(this.tbFileRow);
            this.tabPage1.Controls.Add(this.tbFileID);
            this.tabPage1.Controls.Add(this.tbEnable);
            this.tabPage1.Controls.Add(this.tbType);
            this.tabPage1.Controls.Add(this.PbSelectID1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.tbItemIndex);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.groupBox20);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.tbFlag);
            this.tabPage1.Controls.Add(this.label37);
            this.tabPage1.Controls.Add(this.label39);
            this.tabPage1.Controls.Add(this.tbStrong);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.tbAwful);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.label36);
            this.tabPage1.Controls.Add(this.tbNoraml);
            this.tabPage1.Controls.Add(this.label34);
            this.tabPage1.Controls.Add(this.tbWeak);
            this.tabPage1.Controls.Add(this.label38);
            this.tabPage1.Controls.Add(this.tbBasicSkill2);
            this.tabPage1.Controls.Add(this.tbBasicSkill1);
            this.tabPage1.Controls.Add(this.tbCritical);
            this.tabPage1.Controls.Add(this.label35);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(620, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic";
            // 
            // tbItemExist
            // 
            this.tbItemExist.Location = new System.Drawing.Point(147, 2);
            this.tbItemExist.Name = "tbItemExist";
            this.tbItemExist.Size = new System.Drawing.Size(26, 20);
            this.tbItemExist.TabIndex = 116;
            this.tbItemExist.Visible = false;
            // 
            // tbFileCol
            // 
            this.tbFileCol.Location = new System.Drawing.Point(343, 1);
            this.tbFileCol.Name = "tbFileCol";
            this.tbFileCol.Size = new System.Drawing.Size(26, 20);
            this.tbFileCol.TabIndex = 115;
            this.tbFileCol.Visible = false;
            // 
            // tbFileRow
            // 
            this.tbFileRow.Location = new System.Drawing.Point(311, 2);
            this.tbFileRow.Name = "tbFileRow";
            this.tbFileRow.Size = new System.Drawing.Size(26, 20);
            this.tbFileRow.TabIndex = 114;
            this.tbFileRow.Visible = false;
            // 
            // tbFileID
            // 
            this.tbFileID.Location = new System.Drawing.Point(279, 2);
            this.tbFileID.Name = "tbFileID";
            this.tbFileID.Size = new System.Drawing.Size(26, 20);
            this.tbFileID.TabIndex = 113;
            this.tbFileID.Visible = false;
            // 
            // tbEnable
            // 
            this.tbEnable.Location = new System.Drawing.Point(225, 2);
            this.tbEnable.Name = "tbEnable";
            this.tbEnable.Size = new System.Drawing.Size(27, 20);
            this.tbEnable.TabIndex = 112;
            this.tbEnable.Visible = false;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(181, 3);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(27, 20);
            this.tbType.TabIndex = 11;
            this.tbType.Visible = false;
            this.tbType.TextChanged += new System.EventHandler(this.tbType_TextChanged);
            // 
            // PbSelectID1
            // 
            this.PbSelectID1.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.PbSelectID1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbSelectID1.Location = new System.Drawing.Point(537, 14);
            this.PbSelectID1.Name = "PbSelectID1";
            this.PbSelectID1.Size = new System.Drawing.Size(22, 22);
            this.PbSelectID1.TabIndex = 111;
            this.PbSelectID1.TabStop = false;
            this.PbSelectID1.Click += new System.EventHandler(this.PbSelectID1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(565, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            // 
            // tbItemIndex
            // 
            this.tbItemIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbItemIndex.Location = new System.Drawing.Point(469, 14);
            this.tbItemIndex.Name = "tbItemIndex";
            this.tbItemIndex.Size = new System.Drawing.Size(63, 20);
            this.tbItemIndex.TabIndex = 109;
            this.tbItemIndex.TextChanged += new System.EventHandler(this.tbItemIndex_TextChanged);
            this.tbItemIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbItemIndex_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(407, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 108;
            this.label10.Text = "ItemIndex:";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.chk3D);
            this.groupBox20.Controls.Add(this.slideLeftRight);
            this.groupBox20.Controls.Add(this.slideUpDown);
            this.groupBox20.Controls.Add(this.slideZoom);
            this.groupBox20.Controls.Add(this.panel3DView);
            this.groupBox20.Location = new System.Drawing.Point(326, 42);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(279, 313);
            this.groupBox20.TabIndex = 107;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "3D View";
            // 
            // chk3D
            // 
            this.chk3D.AutoSize = true;
            this.chk3D.Checked = true;
            this.chk3D.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk3D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk3D.Location = new System.Drawing.Point(180, 0);
            this.chk3D.Name = "chk3D";
            this.chk3D.Size = new System.Drawing.Size(99, 17);
            this.chk3D.TabIndex = 38;
            this.chk3D.Text = "Enable 3D View";
            this.chk3D.UseVisualStyleBackColor = true;
            // 
            // slideLeftRight
            // 
            this.slideLeftRight.AutoSize = false;
            this.slideLeftRight.Location = new System.Drawing.Point(188, 284);
            this.slideLeftRight.Maximum = 10000;
            this.slideLeftRight.Minimum = -10000;
            this.slideLeftRight.Name = "slideLeftRight";
            this.slideLeftRight.Size = new System.Drawing.Size(85, 25);
            this.slideLeftRight.TabIndex = 3;
            this.slideLeftRight.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slideLeftRight.Scroll += new System.EventHandler(this.slideLeftRight_Scroll);
            // 
            // slideUpDown
            // 
            this.slideUpDown.AutoSize = false;
            this.slideUpDown.Location = new System.Drawing.Point(95, 284);
            this.slideUpDown.Maximum = 10000;
            this.slideUpDown.Minimum = -10000;
            this.slideUpDown.Name = "slideUpDown";
            this.slideUpDown.Size = new System.Drawing.Size(85, 25);
            this.slideUpDown.TabIndex = 2;
            this.slideUpDown.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slideUpDown.Scroll += new System.EventHandler(this.slideUpDown_Scroll);
            // 
            // slideZoom
            // 
            this.slideZoom.AutoSize = false;
            this.slideZoom.Location = new System.Drawing.Point(7, 284);
            this.slideZoom.Maximum = 10000;
            this.slideZoom.Minimum = -10000;
            this.slideZoom.Name = "slideZoom";
            this.slideZoom.Size = new System.Drawing.Size(85, 25);
            this.slideZoom.TabIndex = 1;
            this.slideZoom.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slideZoom.Scroll += new System.EventHandler(this.slideZoom_Scroll);
            // 
            // panel3DView
            // 
            this.panel3DView.Location = new System.Drawing.Point(7, 20);
            this.panel3DView.Name = "panel3DView";
            this.panel3DView.Size = new System.Drawing.Size(266, 258);
            this.panel3DView.TabIndex = 0;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(332, 440);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(41, 13);
            this.label33.TabIndex = 103;
            this.label33.Text = "Strong:";
            // 
            // tbFlag
            // 
            this.tbFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFlag.Location = new System.Drawing.Point(379, 387);
            this.tbFlag.Name = "tbFlag";
            this.tbFlag.Size = new System.Drawing.Size(68, 20);
            this.tbFlag.TabIndex = 106;
            this.tbFlag.Visible = false;
            this.tbFlag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFlag_KeyPress);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(482, 440);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(43, 13);
            this.label37.TabIndex = 95;
            this.label37.Text = "Normal:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(332, 414);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(41, 13);
            this.label39.TabIndex = 91;
            this.label39.Text = "Critical:";
            // 
            // tbStrong
            // 
            this.tbStrong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbStrong.Location = new System.Drawing.Point(379, 439);
            this.tbStrong.Name = "tbStrong";
            this.tbStrong.Size = new System.Drawing.Size(68, 20);
            this.tbStrong.TabIndex = 104;
            this.tbStrong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStrong_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbAttackSpeed);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.tbDeadly);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.tbMagicAvoid);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.TbHitpoint);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.tbAvoid);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.tbmDefense);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.tbAttack);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.tbDefense);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.tbmAttack);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.tbAfterDead);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.tbAiSlot);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.tbDelay);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.tbRecoveryMP);
            this.groupBox4.Controls.Add(this.tbRecoveryHP);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.tbmaxStm);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.tbmaxMP);
            this.groupBox4.Controls.Add(this.tbmaxHP);
            this.groupBox4.Controls.Add(this.tbmaxFaith);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.tbConstitution);
            this.groupBox4.Controls.Add(this.tbIntelligence);
            this.groupBox4.Controls.Add(this.TbDexteriety);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.tbStrength);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(8, 126);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 336);
            this.groupBox4.TabIndex = 90;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pet Stats";
            // 
            // tbAttackSpeed
            // 
            this.tbAttackSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAttackSpeed.Location = new System.Drawing.Point(81, 313);
            this.tbAttackSpeed.Name = "tbAttackSpeed";
            this.tbAttackSpeed.Size = new System.Drawing.Size(68, 20);
            this.tbAttackSpeed.TabIndex = 41;
            this.tbAttackSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAttackSpeed_KeyPress);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(0, 316);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(75, 13);
            this.label28.TabIndex = 40;
            this.label28.Text = "Attack Speed:";
            // 
            // tbDeadly
            // 
            this.tbDeadly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDeadly.Location = new System.Drawing.Point(233, 313);
            this.tbDeadly.Name = "tbDeadly";
            this.tbDeadly.Size = new System.Drawing.Size(68, 20);
            this.tbDeadly.TabIndex = 39;
            this.tbDeadly.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDeadly_KeyPress);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(185, 315);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(43, 13);
            this.label29.TabIndex = 38;
            this.label29.Text = "Deadly:";
            // 
            // tbMagicAvoid
            // 
            this.tbMagicAvoid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMagicAvoid.Location = new System.Drawing.Point(81, 287);
            this.tbMagicAvoid.Name = "tbMagicAvoid";
            this.tbMagicAvoid.Size = new System.Drawing.Size(68, 20);
            this.tbMagicAvoid.TabIndex = 37;
            this.tbMagicAvoid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMagicAvoid_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 290);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 13);
            this.label25.TabIndex = 36;
            this.label25.Text = "Magic Avoid:";
            // 
            // TbHitpoint
            // 
            this.TbHitpoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbHitpoint.Location = new System.Drawing.Point(81, 235);
            this.TbHitpoint.Name = "TbHitpoint";
            this.TbHitpoint.Size = new System.Drawing.Size(68, 20);
            this.TbHitpoint.TabIndex = 35;
            this.TbHitpoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbHitpoint_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(25, 238);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(50, 13);
            this.label26.TabIndex = 34;
            this.label26.Text = "Hit Point:";
            // 
            // tbAvoid
            // 
            this.tbAvoid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAvoid.Location = new System.Drawing.Point(81, 261);
            this.tbAvoid.Name = "tbAvoid";
            this.tbAvoid.Size = new System.Drawing.Size(68, 20);
            this.tbAvoid.TabIndex = 33;
            this.tbAvoid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAvoid_KeyPress);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(41, 264);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(34, 13);
            this.label27.TabIndex = 32;
            this.label27.Text = "Avoid";
            // 
            // tbmDefense
            // 
            this.tbmDefense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbmDefense.Location = new System.Drawing.Point(233, 287);
            this.tbmDefense.Name = "tbmDefense";
            this.tbmDefense.Size = new System.Drawing.Size(68, 20);
            this.tbmDefense.TabIndex = 31;
            this.tbmDefense.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbmDefense_KeyPress);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(145, 289);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 13);
            this.label24.TabIndex = 30;
            this.label24.Text = "Magic Defence:";
            // 
            // tbAttack
            // 
            this.tbAttack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAttack.Location = new System.Drawing.Point(233, 209);
            this.tbAttack.Name = "tbAttack";
            this.tbAttack.Size = new System.Drawing.Size(68, 20);
            this.tbAttack.TabIndex = 29;
            this.tbAttack.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAttack_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(187, 212);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "Attack:";
            // 
            // tbDefense
            // 
            this.tbDefense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDefense.Location = new System.Drawing.Point(233, 235);
            this.tbDefense.Name = "tbDefense";
            this.tbDefense.Size = new System.Drawing.Size(68, 20);
            this.tbDefense.TabIndex = 27;
            this.tbDefense.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDefense_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(179, 237);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 13);
            this.label21.TabIndex = 26;
            this.label21.Text = "defence:";
            // 
            // tbmAttack
            // 
            this.tbmAttack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbmAttack.Location = new System.Drawing.Point(233, 261);
            this.tbmAttack.Name = "tbmAttack";
            this.tbmAttack.Size = new System.Drawing.Size(68, 20);
            this.tbmAttack.TabIndex = 25;
            this.tbmAttack.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbmAttack_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(155, 263);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 13);
            this.label22.TabIndex = 24;
            this.label22.Text = "Magic Attack:";
            // 
            // tbAfterDead
            // 
            this.tbAfterDead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAfterDead.Location = new System.Drawing.Point(81, 209);
            this.tbAfterDead.Name = "tbAfterDead";
            this.tbAfterDead.Size = new System.Drawing.Size(68, 20);
            this.tbAfterDead.TabIndex = 23;
            this.tbAfterDead.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAfterDead_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(14, 211);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 13);
            this.label23.TabIndex = 22;
            this.label23.Text = "After Dead:";
            // 
            // tbAiSlot
            // 
            this.tbAiSlot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAiSlot.Location = new System.Drawing.Point(233, 131);
            this.tbAiSlot.Name = "tbAiSlot";
            this.tbAiSlot.Size = new System.Drawing.Size(68, 20);
            this.tbAiSlot.TabIndex = 21;
            this.tbAiSlot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAiSlot_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(187, 134);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "AI Slot:";
            // 
            // tbDelay
            // 
            this.tbDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDelay.Location = new System.Drawing.Point(233, 157);
            this.tbDelay.Name = "tbDelay";
            this.tbDelay.Size = new System.Drawing.Size(68, 20);
            this.tbDelay.TabIndex = 19;
            this.tbDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDelay_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(191, 159);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Delay:";
            // 
            // tbRecoveryMP
            // 
            this.tbRecoveryMP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRecoveryMP.Location = new System.Drawing.Point(233, 105);
            this.tbRecoveryMP.Name = "tbRecoveryMP";
            this.tbRecoveryMP.Size = new System.Drawing.Size(68, 20);
            this.tbRecoveryMP.TabIndex = 15;
            this.tbRecoveryMP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRecoveryMP_KeyPress);
            // 
            // tbRecoveryHP
            // 
            this.tbRecoveryHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRecoveryHP.Location = new System.Drawing.Point(233, 79);
            this.tbRecoveryHP.Name = "tbRecoveryHP";
            this.tbRecoveryHP.Size = new System.Drawing.Size(68, 20);
            this.tbRecoveryHP.TabIndex = 14;
            this.tbRecoveryHP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRecoveryHP_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(179, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Rcv MP:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(180, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Rcv HP:";
            // 
            // tbmaxStm
            // 
            this.tbmaxStm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbmaxStm.Location = new System.Drawing.Point(81, 157);
            this.tbmaxStm.Name = "tbmaxStm";
            this.tbmaxStm.Size = new System.Drawing.Size(68, 20);
            this.tbmaxStm.TabIndex = 11;
            this.tbmaxStm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbmaxStm_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "MaxStm:";
            // 
            // tbmaxMP
            // 
            this.tbmaxMP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbmaxMP.Location = new System.Drawing.Point(81, 105);
            this.tbmaxMP.Name = "tbmaxMP";
            this.tbmaxMP.Size = new System.Drawing.Size(68, 20);
            this.tbmaxMP.TabIndex = 11;
            this.tbmaxMP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbmaxMP_KeyPress);
            // 
            // tbmaxHP
            // 
            this.tbmaxHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbmaxHP.Location = new System.Drawing.Point(81, 79);
            this.tbmaxHP.Name = "tbmaxHP";
            this.tbmaxHP.Size = new System.Drawing.Size(68, 20);
            this.tbmaxHP.TabIndex = 10;
            this.tbmaxHP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbmaxHP_KeyPress);
            // 
            // tbmaxFaith
            // 
            this.tbmaxFaith.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbmaxFaith.Location = new System.Drawing.Point(81, 131);
            this.tbmaxFaith.Name = "tbmaxFaith";
            this.tbmaxFaith.Size = new System.Drawing.Size(68, 20);
            this.tbmaxFaith.TabIndex = 9;
            this.tbmaxFaith.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbmaxFaith_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "MaxMP:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "MaxHP:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "MaxFaith:";
            // 
            // tbConstitution
            // 
            this.tbConstitution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbConstitution.Location = new System.Drawing.Point(252, 53);
            this.tbConstitution.Name = "tbConstitution";
            this.tbConstitution.Size = new System.Drawing.Size(49, 20);
            this.tbConstitution.TabIndex = 7;
            this.tbConstitution.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbConstitution_KeyPress);
            // 
            // tbIntelligence
            // 
            this.tbIntelligence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIntelligence.Location = new System.Drawing.Point(190, 53);
            this.tbIntelligence.Name = "tbIntelligence";
            this.tbIntelligence.Size = new System.Drawing.Size(49, 20);
            this.tbIntelligence.TabIndex = 6;
            this.tbIntelligence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIntelligence_KeyPress);
            // 
            // TbDexteriety
            // 
            this.TbDexteriety.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbDexteriety.Location = new System.Drawing.Point(139, 53);
            this.TbDexteriety.Name = "TbDexteriety";
            this.TbDexteriety.Size = new System.Drawing.Size(49, 20);
            this.TbDexteriety.TabIndex = 5;
            this.TbDexteriety.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbDexteriety_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Con:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Int:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Dex:";
            // 
            // tbStrength
            // 
            this.tbStrength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbStrength.Location = new System.Drawing.Point(81, 53);
            this.tbStrength.Name = "tbStrength";
            this.tbStrength.Size = new System.Drawing.Size(49, 20);
            this.tbStrength.TabIndex = 1;
            this.tbStrength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStrength_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Str:";
            // 
            // tbAwful
            // 
            this.tbAwful.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAwful.Location = new System.Drawing.Point(531, 412);
            this.tbAwful.Name = "tbAwful";
            this.tbAwful.Size = new System.Drawing.Size(68, 20);
            this.tbAwful.TabIndex = 98;
            this.tbAwful.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAwful_KeyPress);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(343, 387);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(30, 13);
            this.label30.TabIndex = 105;
            this.label30.Text = "Flag:";
            this.label30.Visible = false;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(489, 414);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(36, 13);
            this.label36.TabIndex = 97;
            this.label36.Text = "Awful:";
            // 
            // tbNoraml
            // 
            this.tbNoraml.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNoraml.Location = new System.Drawing.Point(531, 438);
            this.tbNoraml.Name = "tbNoraml";
            this.tbNoraml.Size = new System.Drawing.Size(68, 20);
            this.tbNoraml.TabIndex = 96;
            this.tbNoraml.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNoraml_KeyPress);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(337, 363);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(36, 13);
            this.label34.TabIndex = 101;
            this.label34.Text = "Week";
            // 
            // tbWeak
            // 
            this.tbWeak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbWeak.Location = new System.Drawing.Point(379, 361);
            this.tbWeak.Name = "tbWeak";
            this.tbWeak.Size = new System.Drawing.Size(68, 20);
            this.tbWeak.TabIndex = 102;
            this.tbWeak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWeak_KeyPress);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(461, 363);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(64, 13);
            this.label38.TabIndex = 93;
            this.label38.Text = "Basic Skill 1";
            // 
            // tbBasicSkill2
            // 
            this.tbBasicSkill2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBasicSkill2.Location = new System.Drawing.Point(531, 386);
            this.tbBasicSkill2.Name = "tbBasicSkill2";
            this.tbBasicSkill2.Size = new System.Drawing.Size(68, 20);
            this.tbBasicSkill2.TabIndex = 100;
            this.tbBasicSkill2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBasicSkill2_KeyPress);
            // 
            // tbBasicSkill1
            // 
            this.tbBasicSkill1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBasicSkill1.Location = new System.Drawing.Point(531, 360);
            this.tbBasicSkill1.Name = "tbBasicSkill1";
            this.tbBasicSkill1.Size = new System.Drawing.Size(68, 20);
            this.tbBasicSkill1.TabIndex = 94;
            this.tbBasicSkill1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBasicSkill1_KeyPress);
            // 
            // tbCritical
            // 
            this.tbCritical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCritical.Location = new System.Drawing.Point(379, 413);
            this.tbCritical.Name = "tbCritical";
            this.tbCritical.Size = new System.Drawing.Size(68, 20);
            this.tbCritical.TabIndex = 92;
            this.tbCritical.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCritical_KeyPress);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(461, 387);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(64, 13);
            this.label35.TabIndex = 99;
            this.label35.Text = "Basic Skill 2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flag);
            this.groupBox3.Controls.Add(this.label80);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(8, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 103);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Basic";
            // 
            // flag
            // 
            this.flag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.flag.FormattingEnabled = true;
            this.flag.Items.AddRange(new object[] {
            "1 - Does not shares experience",
            "2 - shares his experience"});
            this.flag.Location = new System.Drawing.Point(50, 74);
            this.flag.Name = "flag";
            this.flag.Size = new System.Drawing.Size(231, 21);
            this.flag.TabIndex = 13;
            this.flag.SelectionChangeCommitted += new System.EventHandler(this.flag_SelectionChangeCommitted);
            this.flag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.flag_KeyPress);
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(11, 77);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(30, 13);
            this.label80.TabIndex = 12;
            this.label80.Text = "Flag:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Type:";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 - Human",
            "2 - Beast",
            "3 - Demon",
            "4 - Dark Lord"});
            this.comboBox1.Location = new System.Drawing.Point(206, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(97, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Enable";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(50, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(39, 20);
            this.txtID.TabIndex = 3;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(50, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 20);
            this.txtName.TabIndex = 2;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(620, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Animation Edit";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label68);
            this.groupBox8.Controls.Add(this.t_tex2);
            this.groupBox8.Controls.Add(this.t_row2);
            this.groupBox8.Controls.Add(this.label69);
            this.groupBox8.Controls.Add(this.t_col2);
            this.groupBox8.Controls.Add(this.label70);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.t_tex1);
            this.groupBox8.Controls.Add(this.t_row1);
            this.groupBox8.Controls.Add(this.label66);
            this.groupBox8.Controls.Add(this.t_col1);
            this.groupBox8.Controls.Add(this.label67);
            this.groupBox8.Location = new System.Drawing.Point(443, 133);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(144, 84);
            this.groupBox8.TabIndex = 68;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Only Admin";
            this.groupBox8.Visible = false;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(74, 15);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(30, 13);
            this.label68.TabIndex = 62;
            this.label68.Text = "tex 2";
            // 
            // t_tex2
            // 
            this.t_tex2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_tex2.Location = new System.Drawing.Point(105, 13);
            this.t_tex2.Name = "t_tex2";
            this.t_tex2.Size = new System.Drawing.Size(33, 20);
            this.t_tex2.TabIndex = 63;
            this.t_tex2.Visible = false;
            // 
            // t_row2
            // 
            this.t_row2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_row2.Location = new System.Drawing.Point(105, 39);
            this.t_row2.Name = "t_row2";
            this.t_row2.Size = new System.Drawing.Size(33, 20);
            this.t_row2.TabIndex = 67;
            this.t_row2.Visible = false;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(74, 41);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(33, 13);
            this.label69.TabIndex = 66;
            this.label69.Text = "row 2";
            // 
            // t_col2
            // 
            this.t_col2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_col2.Location = new System.Drawing.Point(105, 60);
            this.t_col2.Name = "t_col2";
            this.t_col2.Size = new System.Drawing.Size(33, 20);
            this.t_col2.TabIndex = 65;
            this.t_col2.Visible = false;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(74, 67);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(30, 13);
            this.label70.TabIndex = 64;
            this.label70.Text = "col 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "tex 1";
            // 
            // t_tex1
            // 
            this.t_tex1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_tex1.Location = new System.Drawing.Point(39, 13);
            this.t_tex1.Name = "t_tex1";
            this.t_tex1.Size = new System.Drawing.Size(33, 20);
            this.t_tex1.TabIndex = 57;
            this.t_tex1.Visible = false;
            // 
            // t_row1
            // 
            this.t_row1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_row1.Location = new System.Drawing.Point(39, 39);
            this.t_row1.Name = "t_row1";
            this.t_row1.Size = new System.Drawing.Size(33, 20);
            this.t_row1.TabIndex = 61;
            this.t_row1.Visible = false;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(8, 41);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(33, 13);
            this.label66.TabIndex = 60;
            this.label66.Text = "row 1";
            // 
            // t_col1
            // 
            this.t_col1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_col1.Location = new System.Drawing.Point(39, 60);
            this.t_col1.Name = "t_col1";
            this.t_col1.Size = new System.Drawing.Size(33, 20);
            this.t_col1.TabIndex = 59;
            this.t_col1.Visible = false;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(8, 67);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(30, 13);
            this.label67.TabIndex = 58;
            this.label67.Text = "col 1";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbMount2);
            this.groupBox7.Controls.Add(this.pictureBox5);
            this.groupBox7.Controls.Add(this.button2);
            this.groupBox7.Controls.Add(this.btnLevelup2);
            this.groupBox7.Controls.Add(this.BtnAniAttack2_1);
            this.groupBox7.Controls.Add(this.btnAniIdle2_1);
            this.groupBox7.Controls.Add(this.btnAniRun_1);
            this.groupBox7.Controls.Add(this.btnAniDie_1);
            this.groupBox7.Controls.Add(this.BtnAniAttack1_1);
            this.groupBox7.Controls.Add(this.BtnAniDam_1);
            this.groupBox7.Controls.Add(this.BtnAniIdle1);
            this.groupBox7.Controls.Add(this.BtnAniWalk_1);
            this.groupBox7.Controls.Add(this.BtnReadSmc2);
            this.groupBox7.Controls.Add(this.label51);
            this.groupBox7.Controls.Add(this.tbAniDamage1_2);
            this.groupBox7.Controls.Add(this.tbSmc1_2);
            this.groupBox7.Controls.Add(this.label65);
            this.groupBox7.Controls.Add(this.tbAniIdle1_2);
            this.groupBox7.Controls.Add(this.label49);
            this.groupBox7.Controls.Add(this.tbAniIdle2_2);
            this.groupBox7.Controls.Add(this.label54);
            this.groupBox7.Controls.Add(this.tbAniRun1_2);
            this.groupBox7.Controls.Add(this.label56);
            this.groupBox7.Controls.Add(this.tbSkillSummon1_2);
            this.groupBox7.Controls.Add(this.tbAniWalk1_2);
            this.groupBox7.Controls.Add(this.tbAniAttack1_2);
            this.groupBox7.Controls.Add(this.label58);
            this.groupBox7.Controls.Add(this.label60);
            this.groupBox7.Controls.Add(this.label50);
            this.groupBox7.Controls.Add(this.tbLevelUp1_2);
            this.groupBox7.Controls.Add(this.label62);
            this.groupBox7.Controls.Add(this.tbSpeed1_2);
            this.groupBox7.Controls.Add(this.tbAniAttack2_2);
            this.groupBox7.Controls.Add(this.label61);
            this.groupBox7.Controls.Add(this.label59);
            this.groupBox7.Controls.Add(this.tbAniDie1_2);
            this.groupBox7.Controls.Add(this.label57);
            this.groupBox7.Controls.Add(this.label63);
            this.groupBox7.Controls.Add(this.tbMount1_2);
            this.groupBox7.Location = new System.Drawing.Point(6, 226);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(431, 208);
            this.groupBox7.TabIndex = 67;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Animation 2";
            // 
            // cbMount2
            // 
            this.cbMount2.AutoSize = true;
            this.cbMount2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMount2.Location = new System.Drawing.Point(64, 151);
            this.cbMount2.Name = "cbMount2";
            this.cbMount2.Size = new System.Drawing.Size(70, 17);
            this.cbMount2.TabIndex = 115;
            this.cbMount2.Text = "NotMount";
            this.cbMount2.UseVisualStyleBackColor = true;
            this.cbMount2.CheckedChanged += new System.EventHandler(this.cbMount2_CheckedChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(381, 173);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 22);
            this.pictureBox5.TabIndex = 115;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.search;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(404, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 20);
            this.button2.TabIndex = 114;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLevelup2
            // 
            this.btnLevelup2.BackColor = System.Drawing.SystemColors.Control;
            this.btnLevelup2.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.search;
            this.btnLevelup2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLevelup2.FlatAppearance.BorderSize = 0;
            this.btnLevelup2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevelup2.Location = new System.Drawing.Point(404, 98);
            this.btnLevelup2.Name = "btnLevelup2";
            this.btnLevelup2.Size = new System.Drawing.Size(20, 20);
            this.btnLevelup2.TabIndex = 106;
            this.btnLevelup2.UseVisualStyleBackColor = true;
            this.btnLevelup2.Click += new System.EventHandler(this.AniFind2);
            // 
            // BtnAniAttack2_1
            // 
            this.BtnAniAttack2_1.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAniAttack2_1.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.search;
            this.BtnAniAttack2_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAniAttack2_1.FlatAppearance.BorderSize = 0;
            this.BtnAniAttack2_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAniAttack2_1.Location = new System.Drawing.Point(183, 99);
            this.BtnAniAttack2_1.Name = "BtnAniAttack2_1";
            this.BtnAniAttack2_1.Size = new System.Drawing.Size(20, 20);
            this.BtnAniAttack2_1.TabIndex = 112;
            this.BtnAniAttack2_1.UseVisualStyleBackColor = true;
            this.BtnAniAttack2_1.Click += new System.EventHandler(this.AniFind2);
            // 
            // btnAniIdle2_1
            // 
            this.btnAniIdle2_1.BackColor = System.Drawing.SystemColors.Control;
            this.btnAniIdle2_1.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.search;
            this.btnAniIdle2_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAniIdle2_1.FlatAppearance.BorderSize = 0;
            this.btnAniIdle2_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniIdle2_1.Location = new System.Drawing.Point(183, 46);
            this.btnAniIdle2_1.Name = "btnAniIdle2_1";
            this.btnAniIdle2_1.Size = new System.Drawing.Size(20, 20);
            this.btnAniIdle2_1.TabIndex = 111;
            this.btnAniIdle2_1.UseVisualStyleBackColor = true;
            this.btnAniIdle2_1.Click += new System.EventHandler(this.AniFind2);
            // 
            // btnAniRun_1
            // 
            this.btnAniRun_1.BackColor = System.Drawing.SystemColors.Control;
            this.btnAniRun_1.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.search;
            this.btnAniRun_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAniRun_1.FlatAppearance.BorderSize = 0;
            this.btnAniRun_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniRun_1.Location = new System.Drawing.Point(404, 45);
            this.btnAniRun_1.Name = "btnAniRun_1";
            this.btnAniRun_1.Size = new System.Drawing.Size(20, 20);
            this.btnAniRun_1.TabIndex = 110;
            this.btnAniRun_1.UseVisualStyleBackColor = true;
            this.btnAniRun_1.Click += new System.EventHandler(this.AniFind2);
            // 
            // btnAniDie_1
            // 
            this.btnAniDie_1.BackColor = System.Drawing.SystemColors.Control;
            this.btnAniDie_1.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.search;
            this.btnAniDie_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAniDie_1.FlatAppearance.BorderSize = 0;
            this.btnAniDie_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniDie_1.Location = new System.Drawing.Point(183, 123);
            this.btnAniDie_1.Name = "btnAniDie_1";
            this.btnAniDie_1.Size = new System.Drawing.Size(20, 20);
            this.btnAniDie_1.TabIndex = 109;
            this.btnAniDie_1.UseVisualStyleBackColor = true;
            this.btnAniDie_1.Click += new System.EventHandler(this.AniFind2);
            // 
            // BtnAniAttack1_1
            // 
            this.BtnAniAttack1_1.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAniAttack1_1.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.search;
            this.BtnAniAttack1_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAniAttack1_1.FlatAppearance.BorderSize = 0;
            this.BtnAniAttack1_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAniAttack1_1.Location = new System.Drawing.Point(183, 71);
            this.BtnAniAttack1_1.Name = "BtnAniAttack1_1";
            this.BtnAniAttack1_1.Size = new System.Drawing.Size(20, 20);
            this.BtnAniAttack1_1.TabIndex = 108;
            this.BtnAniAttack1_1.UseVisualStyleBackColor = true;
            this.BtnAniAttack1_1.Click += new System.EventHandler(this.AniFind2);
            // 
            // BtnAniDam_1
            // 
            this.BtnAniDam_1.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAniDam_1.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.search;
            this.BtnAniDam_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAniDam_1.FlatAppearance.BorderSize = 0;
            this.BtnAniDam_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAniDam_1.Location = new System.Drawing.Point(404, 71);
            this.BtnAniDam_1.Name = "BtnAniDam_1";
            this.BtnAniDam_1.Size = new System.Drawing.Size(20, 20);
            this.BtnAniDam_1.TabIndex = 107;
            this.BtnAniDam_1.UseVisualStyleBackColor = true;
            this.BtnAniDam_1.Click += new System.EventHandler(this.AniFind2);
            // 
            // BtnAniIdle1
            // 
            this.BtnAniIdle1.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAniIdle1.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.search;
            this.BtnAniIdle1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAniIdle1.FlatAppearance.BorderSize = 0;
            this.BtnAniIdle1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAniIdle1.Location = new System.Drawing.Point(183, 19);
            this.BtnAniIdle1.Name = "BtnAniIdle1";
            this.BtnAniIdle1.Size = new System.Drawing.Size(20, 20);
            this.BtnAniIdle1.TabIndex = 106;
            this.BtnAniIdle1.UseVisualStyleBackColor = true;
            this.BtnAniIdle1.Click += new System.EventHandler(this.AniFind2);
            // 
            // BtnAniWalk_1
            // 
            this.BtnAniWalk_1.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAniWalk_1.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.search;
            this.BtnAniWalk_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAniWalk_1.FlatAppearance.BorderSize = 0;
            this.BtnAniWalk_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAniWalk_1.Location = new System.Drawing.Point(404, 17);
            this.BtnAniWalk_1.Name = "BtnAniWalk_1";
            this.BtnAniWalk_1.Size = new System.Drawing.Size(20, 20);
            this.BtnAniWalk_1.TabIndex = 105;
            this.BtnAniWalk_1.UseVisualStyleBackColor = true;
            this.BtnAniWalk_1.Click += new System.EventHandler(this.AniFind2);
            // 
            // BtnReadSmc2
            // 
            this.BtnReadSmc2.BackColor = System.Drawing.SystemColors.Control;
            this.BtnReadSmc2.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.search;
            this.BtnReadSmc2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnReadSmc2.FlatAppearance.BorderSize = 0;
            this.BtnReadSmc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReadSmc2.Location = new System.Drawing.Point(352, 175);
            this.BtnReadSmc2.Name = "BtnReadSmc2";
            this.BtnReadSmc2.Size = new System.Drawing.Size(20, 20);
            this.BtnReadSmc2.TabIndex = 97;
            this.BtnReadSmc2.UseVisualStyleBackColor = true;
            this.BtnReadSmc2.Click += new System.EventHandler(this.BtnReadSmc2_Click);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(11, 177);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(30, 13);
            this.label51.TabIndex = 64;
            this.label51.Text = "SMC";
            // 
            // tbAniDamage1_2
            // 
            this.tbAniDamage1_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAniDamage1_2.Location = new System.Drawing.Point(262, 71);
            this.tbAniDamage1_2.Name = "tbAniDamage1_2";
            this.tbAniDamage1_2.Size = new System.Drawing.Size(140, 20);
            this.tbAniDamage1_2.TabIndex = 97;
            this.tbAniDamage1_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAniDamage1_2_KeyPress);
            // 
            // tbSmc1_2
            // 
            this.tbSmc1_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSmc1_2.Location = new System.Drawing.Point(64, 175);
            this.tbSmc1_2.Name = "tbSmc1_2";
            this.tbSmc1_2.Size = new System.Drawing.Size(282, 20);
            this.tbSmc1_2.TabIndex = 65;
            this.tbSmc1_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSmc1_2_KeyPress);
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(213, 75);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(47, 13);
            this.label65.TabIndex = 96;
            this.label65.Text = "Damage";
            // 
            // tbAniIdle1_2
            // 
            this.tbAniIdle1_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAniIdle1_2.Location = new System.Drawing.Point(50, 19);
            this.tbAniIdle1_2.Name = "tbAniIdle1_2";
            this.tbAniIdle1_2.Size = new System.Drawing.Size(127, 20);
            this.tbAniIdle1_2.TabIndex = 63;
            this.tbAniIdle1_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAniIdle1_2_KeyPress);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(11, 21);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(33, 13);
            this.label49.TabIndex = 62;
            this.label49.Text = "Idle 1";
            // 
            // tbAniIdle2_2
            // 
            this.tbAniIdle2_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAniIdle2_2.Location = new System.Drawing.Point(50, 45);
            this.tbAniIdle2_2.Name = "tbAniIdle2_2";
            this.tbAniIdle2_2.Size = new System.Drawing.Size(127, 20);
            this.tbAniIdle2_2.TabIndex = 67;
            this.tbAniIdle2_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAniIdle2_2_KeyPress);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(11, 47);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(33, 13);
            this.label54.TabIndex = 66;
            this.label54.Text = "Idle 2";
            // 
            // tbAniRun1_2
            // 
            this.tbAniRun1_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAniRun1_2.Location = new System.Drawing.Point(248, 45);
            this.tbAniRun1_2.Name = "tbAniRun1_2";
            this.tbAniRun1_2.Size = new System.Drawing.Size(155, 20);
            this.tbAniRun1_2.TabIndex = 85;
            this.tbAniRun1_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAniRun1_2_KeyPress);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(213, 47);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(27, 13);
            this.label56.TabIndex = 84;
            this.label56.Text = "Run";
            // 
            // tbSkillSummon1_2
            // 
            this.tbSkillSummon1_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSkillSummon1_2.Location = new System.Drawing.Point(283, 123);
            this.tbSkillSummon1_2.Name = "tbSkillSummon1_2";
            this.tbSkillSummon1_2.Size = new System.Drawing.Size(117, 20);
            this.tbSkillSummon1_2.TabIndex = 93;
            this.tbSkillSummon1_2.TextChanged += new System.EventHandler(this.tbSkillSummon1_2_TextChanged);
            this.tbSkillSummon1_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSkillSummon1_2_KeyPress);
            // 
            // tbAniWalk1_2
            // 
            this.tbAniWalk1_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAniWalk1_2.Location = new System.Drawing.Point(248, 19);
            this.tbAniWalk1_2.Name = "tbAniWalk1_2";
            this.tbAniWalk1_2.Size = new System.Drawing.Size(155, 20);
            this.tbAniWalk1_2.TabIndex = 81;
            this.tbAniWalk1_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAniWalk1_2_KeyPress);
            // 
            // tbAniAttack1_2
            // 
            this.tbAniAttack1_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAniAttack1_2.Location = new System.Drawing.Point(64, 71);
            this.tbAniAttack1_2.Name = "tbAniAttack1_2";
            this.tbAniAttack1_2.Size = new System.Drawing.Size(113, 20);
            this.tbAniAttack1_2.TabIndex = 75;
            this.tbAniAttack1_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAniAttack1_2_KeyPress);
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(213, 21);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(32, 13);
            this.label58.TabIndex = 80;
            this.label58.Text = "Walk";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(213, 130);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(70, 13);
            this.label60.TabIndex = 92;
            this.label60.Text = "Skill Summon";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(11, 73);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(47, 13);
            this.label50.TabIndex = 74;
            this.label50.Text = "Attack 1";
            // 
            // tbLevelUp1_2
            // 
            this.tbLevelUp1_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLevelUp1_2.Location = new System.Drawing.Point(265, 97);
            this.tbLevelUp1_2.Name = "tbLevelUp1_2";
            this.tbLevelUp1_2.Size = new System.Drawing.Size(136, 20);
            this.tbLevelUp1_2.TabIndex = 89;
            this.tbLevelUp1_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLevelUp1_2_KeyPress);
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(213, 104);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(51, 13);
            this.label62.TabIndex = 88;
            this.label62.Text = "Level UP";
            // 
            // tbSpeed1_2
            // 
            this.tbSpeed1_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSpeed1_2.Location = new System.Drawing.Point(266, 149);
            this.tbSpeed1_2.Name = "tbSpeed1_2";
            this.tbSpeed1_2.Size = new System.Drawing.Size(134, 20);
            this.tbSpeed1_2.TabIndex = 91;
            this.tbSpeed1_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSpeed1_2_KeyPress);
            // 
            // tbAniAttack2_2
            // 
            this.tbAniAttack2_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAniAttack2_2.Location = new System.Drawing.Point(64, 97);
            this.tbAniAttack2_2.Name = "tbAniAttack2_2";
            this.tbAniAttack2_2.Size = new System.Drawing.Size(113, 20);
            this.tbAniAttack2_2.TabIndex = 79;
            this.tbAniAttack2_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAniAttack2_2_KeyPress);
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(213, 151);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(38, 13);
            this.label61.TabIndex = 90;
            this.label61.Text = "Speed";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(11, 99);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(47, 13);
            this.label59.TabIndex = 78;
            this.label59.Text = "Attack 2";
            // 
            // tbAniDie1_2
            // 
            this.tbAniDie1_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAniDie1_2.Location = new System.Drawing.Point(64, 123);
            this.tbAniDie1_2.Name = "tbAniDie1_2";
            this.tbAniDie1_2.Size = new System.Drawing.Size(113, 20);
            this.tbAniDie1_2.TabIndex = 83;
            this.tbAniDie1_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAniDie1_2_KeyPress);
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(11, 125);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(23, 13);
            this.label57.TabIndex = 82;
            this.label57.Text = "Die";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(11, 151);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(37, 13);
            this.label63.TabIndex = 86;
            this.label63.Text = "Mount";
            // 
            // tbMount1_2
            // 
            this.tbMount1_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMount1_2.Location = new System.Drawing.Point(138, 149);
            this.tbMount1_2.Name = "tbMount1_2";
            this.tbMount1_2.Size = new System.Drawing.Size(32, 20);
            this.tbMount1_2.TabIndex = 87;
            this.tbMount1_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMount1_2_KeyPress);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbMount1);
            this.groupBox6.Controls.Add(this.pictureBox4);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.btnLevelup1);
            this.groupBox6.Controls.Add(this.BtnAniAttack2);
            this.groupBox6.Controls.Add(this.btnAniIdle2);
            this.groupBox6.Controls.Add(this.btnAniRun);
            this.groupBox6.Controls.Add(this.btnAniDie);
            this.groupBox6.Controls.Add(this.BtnAniAttack1);
            this.groupBox6.Controls.Add(this.BtnAniDam);
            this.groupBox6.Controls.Add(this.BtnAniIdle);
            this.groupBox6.Controls.Add(this.BtnAniWalk);
            this.groupBox6.Controls.Add(this.BtnReadSmc);
            this.groupBox6.Controls.Add(this.tbSmc1_1);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.tbAniAttack2_1);
            this.groupBox6.Controls.Add(this.label44);
            this.groupBox6.Controls.Add(this.tbSpeed1_1);
            this.groupBox6.Controls.Add(this.label48);
            this.groupBox6.Controls.Add(this.tbAniDamage1_1);
            this.groupBox6.Controls.Add(this.label45);
            this.groupBox6.Controls.Add(this.tbSkillSummon1_1);
            this.groupBox6.Controls.Add(this.label64);
            this.groupBox6.Controls.Add(this.tbAniAttack1_1);
            this.groupBox6.Controls.Add(this.label52);
            this.groupBox6.Controls.Add(this.tbAniIdle2_1);
            this.groupBox6.Controls.Add(this.label40);
            this.groupBox6.Controls.Add(this.tbMount1_1);
            this.groupBox6.Controls.Add(this.label55);
            this.groupBox6.Controls.Add(this.tbAniIdle1_1);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.tbAniDie1_1);
            this.groupBox6.Controls.Add(this.tbAniWalk1_1);
            this.groupBox6.Controls.Add(this.label43);
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Controls.Add(this.label46);
            this.groupBox6.Controls.Add(this.tbAniRun1_1);
            this.groupBox6.Controls.Add(this.tbLevelUp1_1);
            this.groupBox6.Controls.Add(this.label53);
            this.groupBox6.Location = new System.Drawing.Point(6, 10);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(431, 207);
            this.groupBox6.TabIndex = 66;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Animations 1";
            // 
            // cbMount1
            // 
            this.cbMount1.AutoSize = true;
            this.cbMount1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMount1.Location = new System.Drawing.Point(59, 151);
            this.cbMount1.Name = "cbMount1";
            this.cbMount1.Size = new System.Drawing.Size(70, 17);
            this.cbMount1.TabIndex = 114;
            this.cbMount1.Text = "NotMount";
            this.cbMount1.UseVisualStyleBackColor = true;
            this.cbMount1.CheckedChanged += new System.EventHandler(this.cbMount1_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.oie_transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(381, 173);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 22);
            this.pictureBox4.TabIndex = 113;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.search;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(404, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 112;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLevelup1
            // 
            this.btnLevelup1.BackColor = System.Drawing.SystemColors.Control;
            this.btnLevelup1.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.search;
            this.btnLevelup1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLevelup1.FlatAppearance.BorderSize = 0;
            this.btnLevelup1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevelup1.Location = new System.Drawing.Point(404, 99);
            this.btnLevelup1.Name = "btnLevelup1";
            this.btnLevelup1.Size = new System.Drawing.Size(20, 20);
            this.btnLevelup1.TabIndex = 105;
            this.btnLevelup1.UseVisualStyleBackColor = true;
            this.btnLevelup1.Click += new System.EventHandler(this.AniFind);
            // 
            // BtnAniAttack2
            // 
            this.BtnAniAttack2.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAniAttack2.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.search;
            this.BtnAniAttack2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAniAttack2.FlatAppearance.BorderSize = 0;
            this.BtnAniAttack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAniAttack2.Location = new System.Drawing.Point(181, 99);
            this.BtnAniAttack2.Name = "BtnAniAttack2";
            this.BtnAniAttack2.Size = new System.Drawing.Size(20, 20);
            this.BtnAniAttack2.TabIndex = 104;
            this.BtnAniAttack2.UseVisualStyleBackColor = true;
            this.BtnAniAttack2.Click += new System.EventHandler(this.AniFind);
            // 
            // btnAniIdle2
            // 
            this.btnAniIdle2.BackColor = System.Drawing.SystemColors.Control;
            this.btnAniIdle2.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.search;
            this.btnAniIdle2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAniIdle2.FlatAppearance.BorderSize = 0;
            this.btnAniIdle2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniIdle2.Location = new System.Drawing.Point(181, 46);
            this.btnAniIdle2.Name = "btnAniIdle2";
            this.btnAniIdle2.Size = new System.Drawing.Size(20, 20);
            this.btnAniIdle2.TabIndex = 103;
            this.btnAniIdle2.UseVisualStyleBackColor = true;
            this.btnAniIdle2.Click += new System.EventHandler(this.AniFind);
            // 
            // btnAniRun
            // 
            this.btnAniRun.BackColor = System.Drawing.SystemColors.Control;
            this.btnAniRun.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.search;
            this.btnAniRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAniRun.FlatAppearance.BorderSize = 0;
            this.btnAniRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniRun.Location = new System.Drawing.Point(404, 45);
            this.btnAniRun.Name = "btnAniRun";
            this.btnAniRun.Size = new System.Drawing.Size(20, 20);
            this.btnAniRun.TabIndex = 102;
            this.btnAniRun.UseVisualStyleBackColor = true;
            this.btnAniRun.Click += new System.EventHandler(this.AniFind);
            // 
            // btnAniDie
            // 
            this.btnAniDie.BackColor = System.Drawing.SystemColors.Control;
            this.btnAniDie.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.search;
            this.btnAniDie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAniDie.FlatAppearance.BorderSize = 0;
            this.btnAniDie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniDie.Location = new System.Drawing.Point(181, 123);
            this.btnAniDie.Name = "btnAniDie";
            this.btnAniDie.Size = new System.Drawing.Size(20, 20);
            this.btnAniDie.TabIndex = 101;
            this.btnAniDie.UseVisualStyleBackColor = true;
            this.btnAniDie.Click += new System.EventHandler(this.AniFind);
            // 
            // BtnAniAttack1
            // 
            this.BtnAniAttack1.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAniAttack1.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.search;
            this.BtnAniAttack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAniAttack1.FlatAppearance.BorderSize = 0;
            this.BtnAniAttack1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAniAttack1.Location = new System.Drawing.Point(181, 71);
            this.BtnAniAttack1.Name = "BtnAniAttack1";
            this.BtnAniAttack1.Size = new System.Drawing.Size(20, 20);
            this.BtnAniAttack1.TabIndex = 100;
            this.BtnAniAttack1.UseVisualStyleBackColor = true;
            this.BtnAniAttack1.Click += new System.EventHandler(this.AniFind);
            // 
            // BtnAniDam
            // 
            this.BtnAniDam.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAniDam.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.search;
            this.BtnAniDam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAniDam.FlatAppearance.BorderSize = 0;
            this.BtnAniDam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAniDam.Location = new System.Drawing.Point(404, 71);
            this.BtnAniDam.Name = "BtnAniDam";
            this.BtnAniDam.Size = new System.Drawing.Size(20, 20);
            this.BtnAniDam.TabIndex = 99;
            this.BtnAniDam.UseVisualStyleBackColor = true;
            this.BtnAniDam.Click += new System.EventHandler(this.AniFind);
            // 
            // BtnAniIdle
            // 
            this.BtnAniIdle.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAniIdle.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.search;
            this.BtnAniIdle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAniIdle.FlatAppearance.BorderSize = 0;
            this.BtnAniIdle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAniIdle.Location = new System.Drawing.Point(181, 19);
            this.BtnAniIdle.Name = "BtnAniIdle";
            this.BtnAniIdle.Size = new System.Drawing.Size(20, 20);
            this.BtnAniIdle.TabIndex = 98;
            this.BtnAniIdle.UseVisualStyleBackColor = true;
            this.BtnAniIdle.Click += new System.EventHandler(this.AniFind);
            // 
            // BtnAniWalk
            // 
            this.BtnAniWalk.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAniWalk.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.search;
            this.BtnAniWalk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAniWalk.FlatAppearance.BorderSize = 0;
            this.BtnAniWalk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAniWalk.Location = new System.Drawing.Point(404, 17);
            this.BtnAniWalk.Name = "BtnAniWalk";
            this.BtnAniWalk.Size = new System.Drawing.Size(20, 20);
            this.BtnAniWalk.TabIndex = 97;
            this.BtnAniWalk.UseVisualStyleBackColor = true;
            this.BtnAniWalk.Click += new System.EventHandler(this.AniFind);
            // 
            // BtnReadSmc
            // 
            this.BtnReadSmc.BackColor = System.Drawing.SystemColors.Control;
            this.BtnReadSmc.BackgroundImage = global::LcDevPack_TeamDamonA.Properties.Resources.search;
            this.BtnReadSmc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnReadSmc.FlatAppearance.BorderSize = 0;
            this.BtnReadSmc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReadSmc.Location = new System.Drawing.Point(355, 175);
            this.BtnReadSmc.Name = "BtnReadSmc";
            this.BtnReadSmc.Size = new System.Drawing.Size(20, 20);
            this.BtnReadSmc.TabIndex = 96;
            this.BtnReadSmc.UseVisualStyleBackColor = true;
            this.BtnReadSmc.Click += new System.EventHandler(this.BtnReadSmc_Click);
            // 
            // tbSmc1_1
            // 
            this.tbSmc1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSmc1_1.Location = new System.Drawing.Point(59, 175);
            this.tbSmc1_1.Name = "tbSmc1_1";
            this.tbSmc1_1.Size = new System.Drawing.Size(290, 20);
            this.tbSmc1_1.TabIndex = 66;
            this.tbSmc1_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSmc1_1_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 177);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 65;
            this.label17.Text = "SMC:";
            // 
            // tbAniAttack2_1
            // 
            this.tbAniAttack2_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAniAttack2_1.Location = new System.Drawing.Point(59, 97);
            this.tbAniAttack2_1.Name = "tbAniAttack2_1";
            this.tbAniAttack2_1.Size = new System.Drawing.Size(116, 20);
            this.tbAniAttack2_1.TabIndex = 47;
            this.tbAniAttack2_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAniAttack2_1_KeyPress);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(6, 74);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(47, 13);
            this.label44.TabIndex = 48;
            this.label44.Text = "Attack 1";
            // 
            // tbSpeed1_1
            // 
            this.tbSpeed1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSpeed1_1.Location = new System.Drawing.Point(260, 148);
            this.tbSpeed1_1.Name = "tbSpeed1_1";
            this.tbSpeed1_1.Size = new System.Drawing.Size(140, 20);
            this.tbSpeed1_1.TabIndex = 77;
            this.tbSpeed1_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSpeed1_1_KeyPress);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(207, 151);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(38, 13);
            this.label48.TabIndex = 76;
            this.label48.Text = "Speed";
            // 
            // tbAniDamage1_1
            // 
            this.tbAniDamage1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAniDamage1_1.Location = new System.Drawing.Point(260, 71);
            this.tbAniDamage1_1.Name = "tbAniDamage1_1";
            this.tbAniDamage1_1.Size = new System.Drawing.Size(140, 20);
            this.tbAniDamage1_1.TabIndex = 95;
            this.tbAniDamage1_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAniDamage1_1_KeyPress);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(6, 100);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(47, 13);
            this.label45.TabIndex = 46;
            this.label45.Text = "Attack 2";
            // 
            // tbSkillSummon1_1
            // 
            this.tbSkillSummon1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSkillSummon1_1.Location = new System.Drawing.Point(283, 123);
            this.tbSkillSummon1_1.Name = "tbSkillSummon1_1";
            this.tbSkillSummon1_1.Size = new System.Drawing.Size(117, 20);
            this.tbSkillSummon1_1.TabIndex = 73;
            this.tbSkillSummon1_1.TextChanged += new System.EventHandler(this.tbSkillSummon1_1_TextChanged);
            this.tbSkillSummon1_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSkillSummon1_1_KeyPress);
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(207, 73);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(47, 13);
            this.label64.TabIndex = 94;
            this.label64.Text = "Damage";
            // 
            // tbAniAttack1_1
            // 
            this.tbAniAttack1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAniAttack1_1.Location = new System.Drawing.Point(59, 71);
            this.tbAniAttack1_1.Name = "tbAniAttack1_1";
            this.tbAniAttack1_1.Size = new System.Drawing.Size(116, 20);
            this.tbAniAttack1_1.TabIndex = 49;
            this.tbAniAttack1_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAniAttack1_1_KeyPress);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(207, 125);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(70, 13);
            this.label52.TabIndex = 72;
            this.label52.Text = "Skill Summon";
            // 
            // tbAniIdle2_1
            // 
            this.tbAniIdle2_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAniIdle2_1.Location = new System.Drawing.Point(45, 45);
            this.tbAniIdle2_1.Name = "tbAniIdle2_1";
            this.tbAniIdle2_1.Size = new System.Drawing.Size(130, 20);
            this.tbAniIdle2_1.TabIndex = 61;
            this.tbAniIdle2_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAniIdle2_1_KeyPress);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(6, 19);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(33, 13);
            this.label40.TabIndex = 56;
            this.label40.Text = "Idle 1";
            // 
            // tbMount1_1
            // 
            this.tbMount1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMount1_1.Location = new System.Drawing.Point(138, 149);
            this.tbMount1_1.Name = "tbMount1_1";
            this.tbMount1_1.Size = new System.Drawing.Size(27, 20);
            this.tbMount1_1.TabIndex = 69;
            this.tbMount1_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMount1_1_KeyPress);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(6, 155);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(37, 13);
            this.label55.TabIndex = 68;
            this.label55.Text = "Mount";
            // 
            // tbAniIdle1_1
            // 
            this.tbAniIdle1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAniIdle1_1.Location = new System.Drawing.Point(45, 19);
            this.tbAniIdle1_1.Name = "tbAniIdle1_1";
            this.tbAniIdle1_1.Size = new System.Drawing.Size(130, 20);
            this.tbAniIdle1_1.TabIndex = 57;
            this.tbAniIdle1_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAniIdle1_1_KeyPress);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 45);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(33, 13);
            this.label31.TabIndex = 60;
            this.label31.Text = "Idle 2";
            // 
            // tbAniDie1_1
            // 
            this.tbAniDie1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAniDie1_1.Location = new System.Drawing.Point(59, 123);
            this.tbAniDie1_1.Name = "tbAniDie1_1";
            this.tbAniDie1_1.Size = new System.Drawing.Size(116, 20);
            this.tbAniDie1_1.TabIndex = 45;
            this.tbAniDie1_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAniDie1_1_KeyPress);
            // 
            // tbAniWalk1_1
            // 
            this.tbAniWalk1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAniWalk1_1.Location = new System.Drawing.Point(245, 19);
            this.tbAniWalk1_1.Name = "tbAniWalk1_1";
            this.tbAniWalk1_1.Size = new System.Drawing.Size(155, 20);
            this.tbAniWalk1_1.TabIndex = 51;
            this.tbAniWalk1_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAniWalk1_1_KeyPress);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(207, 21);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(32, 13);
            this.label43.TabIndex = 50;
            this.label43.Text = "Walk";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(207, 47);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(27, 13);
            this.label32.TabIndex = 58;
            this.label32.Text = "Run";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(6, 127);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(23, 13);
            this.label46.TabIndex = 44;
            this.label46.Text = "Die";
            // 
            // tbAniRun1_1
            // 
            this.tbAniRun1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAniRun1_1.Location = new System.Drawing.Point(245, 45);
            this.tbAniRun1_1.Name = "tbAniRun1_1";
            this.tbAniRun1_1.Size = new System.Drawing.Size(155, 20);
            this.tbAniRun1_1.TabIndex = 59;
            this.tbAniRun1_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAniRun1_1_KeyPress);
            // 
            // tbLevelUp1_1
            // 
            this.tbLevelUp1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLevelUp1_1.Location = new System.Drawing.Point(264, 98);
            this.tbLevelUp1_1.Name = "tbLevelUp1_1";
            this.tbLevelUp1_1.Size = new System.Drawing.Size(136, 20);
            this.tbLevelUp1_1.TabIndex = 71;
            this.tbLevelUp1_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLevelUp1_1_KeyPress);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(207, 99);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(51, 13);
            this.label53.TabIndex = 70;
            this.label53.Text = "Level UP";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label47);
            this.groupBox5.Controls.Add(this.tbTransType);
            this.groupBox5.Controls.Add(this.tbTransStart);
            this.groupBox5.Controls.Add(this.label41);
            this.groupBox5.Controls.Add(this.tbTransEnd);
            this.groupBox5.Controls.Add(this.label42);
            this.groupBox5.Location = new System.Drawing.Point(443, 10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(144, 119);
            this.groupBox5.TabIndex = 65;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Trans";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(10, 36);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(64, 13);
            this.label47.TabIndex = 42;
            this.label47.Text = "Trans Type:";
            // 
            // tbTransType
            // 
            this.tbTransType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTransType.Location = new System.Drawing.Point(105, 35);
            this.tbTransType.Name = "tbTransType";
            this.tbTransType.Size = new System.Drawing.Size(33, 20);
            this.tbTransType.TabIndex = 43;
            this.tbTransType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTransType_KeyPress);
            // 
            // tbTransStart
            // 
            this.tbTransStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTransStart.Location = new System.Drawing.Point(105, 61);
            this.tbTransStart.Name = "tbTransStart";
            this.tbTransStart.Size = new System.Drawing.Size(33, 20);
            this.tbTransStart.TabIndex = 55;
            this.tbTransStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTransStart_KeyPress);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(10, 62);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(62, 13);
            this.label41.TabIndex = 54;
            this.label41.Text = "Trans Start:";
            // 
            // tbTransEnd
            // 
            this.tbTransEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTransEnd.Location = new System.Drawing.Point(105, 87);
            this.tbTransEnd.Name = "tbTransEnd";
            this.tbTransEnd.Size = new System.Drawing.Size(33, 20);
            this.tbTransEnd.TabIndex = 53;
            this.tbTransEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTransEnd_KeyPress);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(10, 88);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(56, 13);
            this.label42.TabIndex = 52;
            this.label42.Text = "Trans End";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.groupBox9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(620, 464);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pet Evolution";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tb_ev_order);
            this.groupBox9.Controls.Add(this.label79);
            this.groupBox9.Controls.Add(this.tb_ev_stat2);
            this.groupBox9.Controls.Add(this.label78);
            this.groupBox9.Controls.Add(this.tb_ev_stat1);
            this.groupBox9.Controls.Add(this.label77);
            this.groupBox9.Controls.Add(this.tb_ev_Faith);
            this.groupBox9.Controls.Add(this.label76);
            this.groupBox9.Controls.Add(this.tb_ev_Stemina);
            this.groupBox9.Controls.Add(this.label75);
            this.groupBox9.Controls.Add(this.tb_ev_Level);
            this.groupBox9.Controls.Add(this.label73);
            this.groupBox9.Controls.Add(this.tb_to_ev_id);
            this.groupBox9.Controls.Add(this.label72);
            this.groupBox9.Controls.Add(this.tb_ev_ID);
            this.groupBox9.Controls.Add(this.label74);
            this.groupBox9.Enabled = false;
            this.groupBox9.Location = new System.Drawing.Point(6, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(239, 205);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Basic";
            // 
            // tb_ev_order
            // 
            this.tb_ev_order.Location = new System.Drawing.Point(127, 174);
            this.tb_ev_order.Name = "tb_ev_order";
            this.tb_ev_order.Size = new System.Drawing.Size(39, 20);
            this.tb_ev_order.TabIndex = 17;
            this.tb_ev_order.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ev_order_KeyPress);
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(6, 177);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(39, 13);
            this.label79.TabIndex = 16;
            this.label79.Text = "Order :";
            // 
            // tb_ev_stat2
            // 
            this.tb_ev_stat2.Location = new System.Drawing.Point(127, 148);
            this.tb_ev_stat2.Name = "tb_ev_stat2";
            this.tb_ev_stat2.Size = new System.Drawing.Size(39, 20);
            this.tb_ev_stat2.TabIndex = 15;
            this.tb_ev_stat2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ev_stat2_KeyPress);
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(6, 151);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(41, 13);
            this.label78.TabIndex = 14;
            this.label78.Text = "Stat 2 :";
            // 
            // tb_ev_stat1
            // 
            this.tb_ev_stat1.Location = new System.Drawing.Point(127, 122);
            this.tb_ev_stat1.Name = "tb_ev_stat1";
            this.tb_ev_stat1.Size = new System.Drawing.Size(39, 20);
            this.tb_ev_stat1.TabIndex = 13;
            this.tb_ev_stat1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ev_stat1_KeyPress);
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(6, 125);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(41, 13);
            this.label77.TabIndex = 12;
            this.label77.Text = "Stat 1 :";
            // 
            // tb_ev_Faith
            // 
            this.tb_ev_Faith.Location = new System.Drawing.Point(127, 96);
            this.tb_ev_Faith.Name = "tb_ev_Faith";
            this.tb_ev_Faith.Size = new System.Drawing.Size(39, 20);
            this.tb_ev_Faith.TabIndex = 11;
            this.tb_ev_Faith.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ev_Faith_KeyPress);
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(6, 99);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(36, 13);
            this.label76.TabIndex = 10;
            this.label76.Text = "Faith :";
            // 
            // tb_ev_Stemina
            // 
            this.tb_ev_Stemina.Location = new System.Drawing.Point(127, 70);
            this.tb_ev_Stemina.Name = "tb_ev_Stemina";
            this.tb_ev_Stemina.Size = new System.Drawing.Size(39, 20);
            this.tb_ev_Stemina.TabIndex = 9;
            this.tb_ev_Stemina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ev_Stemina_KeyPress);
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(6, 73);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(51, 13);
            this.label75.TabIndex = 8;
            this.label75.Text = "Stemina :";
            // 
            // tb_ev_Level
            // 
            this.tb_ev_Level.Location = new System.Drawing.Point(127, 45);
            this.tb_ev_Level.Name = "tb_ev_Level";
            this.tb_ev_Level.Size = new System.Drawing.Size(39, 20);
            this.tb_ev_Level.TabIndex = 7;
            this.tb_ev_Level.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ev_Level_KeyPress);
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(6, 48);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(115, 13);
            this.label73.TabIndex = 6;
            this.label73.Text = "Evolution Need Level :";
            // 
            // tb_to_ev_id
            // 
            this.tb_to_ev_id.Location = new System.Drawing.Point(189, 19);
            this.tb_to_ev_id.Name = "tb_to_ev_id";
            this.tb_to_ev_id.Size = new System.Drawing.Size(39, 20);
            this.tb_to_ev_id.TabIndex = 5;
            this.tb_to_ev_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_to_ev_id_KeyPress);
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(103, 22);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(80, 13);
            this.label72.TabIndex = 4;
            this.label72.Text = "Evolution to ID:";
            // 
            // tb_ev_ID
            // 
            this.tb_ev_ID.Location = new System.Drawing.Point(58, 19);
            this.tb_ev_ID.Name = "tb_ev_ID";
            this.tb_ev_ID.Size = new System.Drawing.Size(39, 20);
            this.tb_ev_ID.TabIndex = 3;
            this.tb_ev_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ev_ID_KeyPress);
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(6, 22);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(46, 13);
            this.label74.TabIndex = 0;
            this.label74.Text = "Start ID:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.groupBox10);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(620, 464);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pet Experience";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.tb_exp_a_cooltime_rate);
            this.groupBox10.Controls.Add(this.label81);
            this.groupBox10.Controls.Add(this.tb_exp_a_cooltime);
            this.groupBox10.Controls.Add(this.label82);
            this.groupBox10.Controls.Add(this.tb_exp_a_acc_rate_param2);
            this.groupBox10.Controls.Add(this.label83);
            this.groupBox10.Controls.Add(this.tb_exp_a_acc_rate_param1);
            this.groupBox10.Controls.Add(this.label84);
            this.groupBox10.Controls.Add(this.tb_exp_a_max_acc_param2);
            this.groupBox10.Controls.Add(this.label85);
            this.groupBox10.Controls.Add(this.tb_exp_a_max_acc_param1);
            this.groupBox10.Controls.Add(this.label86);
            this.groupBox10.Controls.Add(this.tb_exp_a_pet_index);
            this.groupBox10.Controls.Add(this.label88);
            this.groupBox10.Enabled = false;
            this.groupBox10.Location = new System.Drawing.Point(6, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(200, 205);
            this.groupBox10.TabIndex = 2;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Basic";
            // 
            // tb_exp_a_cooltime_rate
            // 
            this.tb_exp_a_cooltime_rate.Location = new System.Drawing.Point(152, 174);
            this.tb_exp_a_cooltime_rate.Name = "tb_exp_a_cooltime_rate";
            this.tb_exp_a_cooltime_rate.Size = new System.Drawing.Size(39, 20);
            this.tb_exp_a_cooltime_rate.TabIndex = 17;
            this.tb_exp_a_cooltime_rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_exp_a_cooltime_rate_KeyPress);
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(6, 177);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(77, 13);
            this.label81.TabIndex = 16;
            this.label81.Text = "CoolTime Rate";
            // 
            // tb_exp_a_cooltime
            // 
            this.tb_exp_a_cooltime.Location = new System.Drawing.Point(152, 148);
            this.tb_exp_a_cooltime.Name = "tb_exp_a_cooltime";
            this.tb_exp_a_cooltime.Size = new System.Drawing.Size(39, 20);
            this.tb_exp_a_cooltime.TabIndex = 15;
            this.tb_exp_a_cooltime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_exp_a_cooltime_KeyPress);
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(6, 151);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(51, 13);
            this.label82.TabIndex = 14;
            this.label82.Text = "CoolTime";
            // 
            // tb_exp_a_acc_rate_param2
            // 
            this.tb_exp_a_acc_rate_param2.Location = new System.Drawing.Point(152, 122);
            this.tb_exp_a_acc_rate_param2.Name = "tb_exp_a_acc_rate_param2";
            this.tb_exp_a_acc_rate_param2.Size = new System.Drawing.Size(39, 20);
            this.tb_exp_a_acc_rate_param2.TabIndex = 13;
            this.tb_exp_a_acc_rate_param2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_exp_a_acc_rate_param2_KeyPress);
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(6, 125);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(141, 13);
            this.label83.TabIndex = 12;
            this.label83.Text = "Max Player Experience Rate";
            // 
            // tb_exp_a_acc_rate_param1
            // 
            this.tb_exp_a_acc_rate_param1.Location = new System.Drawing.Point(152, 96);
            this.tb_exp_a_acc_rate_param1.Name = "tb_exp_a_acc_rate_param1";
            this.tb_exp_a_acc_rate_param1.Size = new System.Drawing.Size(39, 20);
            this.tb_exp_a_acc_rate_param1.TabIndex = 11;
            this.tb_exp_a_acc_rate_param1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_exp_a_acc_rate_param1_KeyPress);
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(6, 99);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(128, 13);
            this.label84.TabIndex = 10;
            this.label84.Text = "Max Pet Experience Rate";
            // 
            // tb_exp_a_max_acc_param2
            // 
            this.tb_exp_a_max_acc_param2.Location = new System.Drawing.Point(152, 70);
            this.tb_exp_a_max_acc_param2.Name = "tb_exp_a_max_acc_param2";
            this.tb_exp_a_max_acc_param2.Size = new System.Drawing.Size(39, 20);
            this.tb_exp_a_max_acc_param2.TabIndex = 9;
            this.tb_exp_a_max_acc_param2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_exp_a_max_acc_param2_KeyPress);
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(6, 73);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(115, 13);
            this.label85.TabIndex = 8;
            this.label85.Text = "Max Player Experience";
            // 
            // tb_exp_a_max_acc_param1
            // 
            this.tb_exp_a_max_acc_param1.Location = new System.Drawing.Point(152, 45);
            this.tb_exp_a_max_acc_param1.Name = "tb_exp_a_max_acc_param1";
            this.tb_exp_a_max_acc_param1.Size = new System.Drawing.Size(39, 20);
            this.tb_exp_a_max_acc_param1.TabIndex = 7;
            this.tb_exp_a_max_acc_param1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_exp_a_max_acc_param1_KeyPress);
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(6, 48);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(102, 13);
            this.label86.TabIndex = 6;
            this.label86.Text = "Max Pet Experience";
            // 
            // tb_exp_a_pet_index
            // 
            this.tb_exp_a_pet_index.Location = new System.Drawing.Point(152, 19);
            this.tb_exp_a_pet_index.Name = "tb_exp_a_pet_index";
            this.tb_exp_a_pet_index.Size = new System.Drawing.Size(39, 20);
            this.tb_exp_a_pet_index.TabIndex = 3;
            this.tb_exp_a_pet_index.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_exp_a_pet_index_KeyPress);
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(6, 22);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(40, 13);
            this.label88.TabIndex = 0;
            this.label88.Text = "Pet ID:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(776, 519);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(398, 524);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 13);
            this.Status.TabIndex = 5;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(12, 524);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(63, 13);
            this.label71.TabIndex = 41;
            this.label71.Text = "Pet Count : ";
            // 
            // BigPetEditorr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 543);
            this.Controls.Add(this.label71);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BigPetEditorr";
            this.Text = "Big Pet Editor";
            this.Load += new System.EventHandler(this.BitPetEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbSelectID1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideLeftRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideZoom)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private void BtnReadSmc_Click(object sender, EventArgs e) //dethunter12 6/27/2018
        {
            string str = Path.GetDirectoryName(_ClientPath).Replace("Data", "").Replace("data", "") + "\\" + tbSmc1_1.Text;
            if (File.Exists(str))
                new TextEditor(str).Show();
            else
                new CustomMessage("File not found").Show();
        }

        private void BtnReadSmc2_Click(object sender, EventArgs e) //dethunter12 6/27/2018
        {
            string str = Path.GetDirectoryName(_ClientPath).Replace("Data", "").Replace("data", "") + "\\" + tbSmc1_2.Text;
            if (File.Exists(str))
                new TextEditor(str).Show();
            else
                new CustomMessage("File not found").Show();
        }

        private void timer1_Tick(object sender, EventArgs e) //dethunter12 6/27/2018
        {
            Render();
        }

        private void PbSelectID1_Click(object sender, EventArgs e) //dethunter12 6/27/2018
        {
            ItemPicker itemPicker = new ItemPicker();
            if (itemPicker.ShowDialog() != DialogResult.OK)
                return;
            tbItemIndex.Text = Convert.ToString(itemPicker.ItemIndex);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tbItemIndex_TextChanged(object sender, EventArgs e)
        {
            IconPet();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int PetID = AllLists.tpet_MenuData.Max((t_attkpet p) => p.index) + 1;
            t_attkpet PetList = new t_attkpet();
            PetList.index = PetID;
            PetList.name = "New Pet";
            PetList.smcFileName1 = "";
            PetList.aniIdle1 = "";
            PetList.aniIdle1_2 = "";
            PetList.aniAttack1 = "";
            PetList.aniAttack1_2 = "";
            PetList.aniDamage1 = "";
            PetList.aniDie1 = "";
            PetList.aniWalk1 = "";
            PetList.aniRun1 = "";
            PetList.aniLevelup1 = "";
            PetList.smcFileName2 = "";
            PetList.aniIdle2 = "";
            PetList.aniIdle2_2 = "";
            PetList.aniAttack2 = "";
            PetList.aniAttack2_2 = "";
            PetList.aniDamage1_2 = "";
            PetList.aniDie1_2 = "";
            PetList.aniWalk1_2 = "";
            PetList.aniRun1_2 = "";
            PetList.aniLevelup1_2 = "";
            PetList.enable = 1;
            tbItemExist.Text = "";
            AllLists.tpet_MenuData.Add(PetList);
            AllLists.tpet_Menu.Add(PetList.index + " - " + PetList.name);
            RefreshAll();
            this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are u sure u want to delete this entire pet?\r\nThe action cannot be undone", "Delete Pets", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int PetID = GetID();
               
                AllLists.tpet_MenuData.RemoveAll((t_attkpet p) => p.index.Equals(PetID));
                mySQL.UpdateQuery("DELETE FROM t_attack_pet WHERE a_index ='" + PetID + "';"); //dethunter12 update delete from actual table
                int num4 = (int)new CustomMessage("Deleted :o").ShowDialog();
                RefreshAll();
            }
        }
        
        private void btnCopy_Click(object sender, EventArgs e)
        {
            int PetID = this.GetID();
            int petID = AllLists.tpet_MenuData.Max((t_attkpet p) => p.index) + 1;
            t_attkpet PetList = AllLists.tpet_MenuData.Find((t_attkpet p) => p.index.Equals(PetID));
            t_attkpet PetList2 = (t_attkpet)PetList.Clone();
            PetList2.index = petID;
            t_attkpet expr_6E = PetList2;
            expr_6E.name += " (copy)";
            PetList2.Menu = PetList2.index + " - " + PetList2.name;
            tbItemExist.Text = "";
            AllLists.tpet_MenuData.Add(PetList2);
            RefreshAll();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID = GetID();
            int num = AllLists.tpet_MenuData.FindIndex((t_attkpet p) => p.index.Equals(ID));
            if (num != -1)
            {
                string menu = AllLists.tpet_MenuData[num].Menu;
                AllLists.tpet_MenuData[num].index = Convert.ToInt32(txtID.Text);
                AllLists.tpet_MenuData[num].enable = Convert.ToInt16(tbEnable.Text);
                AllLists.tpet_MenuData[num].name = Convert.ToString(txtName.Text); //dethunter12 7/9/2018 adjust
                AllLists.tpet_MenuData[num].type = Convert.ToInt32(tbType.Text);
                comboBox1.SelectedIndex = AllLists.tpet_MenuData[num].type; //dethunter12 adjust 7/9/2018
                AllLists.tpet_MenuData[num].str = Convert.ToInt32(tbStrength.Text);
                AllLists.tpet_MenuData[num].con = Convert.ToInt32(tbConstitution.Text);
                AllLists.tpet_MenuData[num].dex = Convert.ToInt32(TbDexteriety.Text);
                AllLists.tpet_MenuData[num].intel = Convert.ToInt32(tbIntelligence.Text);
                AllLists.tpet_MenuData[num].itemidx = Convert.ToInt32(tbItemIndex.Text);
                AllLists.tpet_MenuData[num].maxFaith = Convert.ToInt32(tbmaxFaith.Text);
                AllLists.tpet_MenuData[num].maxStm = Convert.ToInt32(tbmaxStm.Text);
                AllLists.tpet_MenuData[num].maxHP = Convert.ToInt32(tbmaxHP.Text);
                AllLists.tpet_MenuData[num].maxMP = Convert.ToInt32(tbmaxMP.Text);
                AllLists.tpet_MenuData[num].recoverHP = Convert.ToInt32(tbRecoveryHP.Text);
                AllLists.tpet_MenuData[num].recoverMP = Convert.ToInt32(tbRecoveryMP.Text);
                AllLists.tpet_MenuData[num].delay = Convert.ToInt32(tbDelay.Text);
                AllLists.tpet_MenuData[num].AISlot = Convert.ToInt32(tbAiSlot.Text);
                AllLists.tpet_MenuData[num].afterDead = Convert.ToInt32(tbAfterDead.Text);
                AllLists.tpet_MenuData[num].attack = Convert.ToInt32(tbAttack.Text);
                AllLists.tpet_MenuData[num].defense = Convert.ToInt32(tbDefense.Text);
                AllLists.tpet_MenuData[num].mAttack = Convert.ToInt32(tbmAttack.Text);
                AllLists.tpet_MenuData[num].mDefense = Convert.ToInt32(tbmDefense.Text);
                AllLists.tpet_MenuData[num].hitPoint = Convert.ToInt32(TbHitpoint.Text);
                AllLists.tpet_MenuData[num].avoidPoint = Convert.ToInt32(tbAvoid.Text);
                AllLists.tpet_MenuData[num].mavoidPoint = Convert.ToInt32(tbMagicAvoid.Text);
                AllLists.tpet_MenuData[num].attackSpeed = Convert.ToInt32(tbAttackSpeed.Text);
                AllLists.tpet_MenuData[num].Deadly = Convert.ToInt32(tbDeadly.Text);
                AllLists.tpet_MenuData[num].Critical = Convert.ToInt32(tbCritical.Text);
                AllLists.tpet_MenuData[num].awful = Convert.ToInt32(tbAwful.Text);
                AllLists.tpet_MenuData[num].strong = Convert.ToInt32(tbStrong.Text);
                AllLists.tpet_MenuData[num].normal = Convert.ToInt32(tbNoraml.Text);
                AllLists.tpet_MenuData[num].weak = Convert.ToInt32(tbWeak.Text);
                AllLists.tpet_MenuData[num].bagicSkill1 = Convert.ToInt32(tbBasicSkill1.Text);
                AllLists.tpet_MenuData[num].bagicSkill2 = Convert.ToInt32(tbBasicSkill2.Text);
                //AllLists.tpet_MenuData[num].flag = Convert.ToInt32(tbFlag.Text);//edit by AssasinPL 11-07-2018
                AllLists.tpet_MenuData[num].flag = flag.SelectedIndex +1;//edit by AssasinPL 11-07-2018
                AllLists.tpet_MenuData[num].transType = Convert.ToInt32(tbTransType.Text);
                AllLists.tpet_MenuData[num].transStart = Convert.ToInt32(tbTransStart.Text);
                AllLists.tpet_MenuData[num].transEnd = Convert.ToInt32(tbTransEnd.Text);
                //Ani 1
                AllLists.tpet_MenuData[num].smcFileName1 = Convert.ToString(tbSmc1_1.Text); //dethunter12 7/9/2018 edit
                AllLists.tpet_MenuData[num].aniIdle1 = Convert.ToString(tbAniIdle1_1.Text); //dethunter12 7/9/2018 edit
                AllLists.tpet_MenuData[num].aniIdle1_2 = Convert.ToString(tbAniIdle2_1.Text);//dethunter12 7/9/2018 edit
                AllLists.tpet_MenuData[num].aniAttack1 = Convert.ToString(tbAniAttack1_1.Text);//dethunter12 7/9/2018 edit
                AllLists.tpet_MenuData[num].aniAttack1_2 = Convert.ToString(tbAniAttack2_1.Text);//dethunter12 7/9/2018 edit //
                AllLists.tpet_MenuData[num].aniDamage1 = Convert.ToString(tbAniDamage1_1.Text);//dethunter12 7/9/2018 edit
                AllLists.tpet_MenuData[num].aniDie1 = Convert.ToString(tbAniDie1_1.Text);//dethunter12 7/9/2018 edit
                AllLists.tpet_MenuData[num].aniWalk1 = Convert.ToString(tbAniWalk1_1.Text);//dethunter12 7/9/2018 edit
                AllLists.tpet_MenuData[num].aniRun1 = Convert.ToString(tbAniRun1_1.Text);//dethunter12 7/9/2018 edit
                AllLists.tpet_MenuData[num].aniLevelup1 = Convert.ToString(tbLevelUp1_1.Text);//dethunter12 7/9/2018 edit
                AllLists.tpet_MenuData[num].mount1 = Convert.ToInt32(tbMount1_1.Text);//dethunter12 7/9/2018 edit
                AllLists.tpet_MenuData[num].summonSkill1 = Convert.ToInt32(tbSkillSummon1_1.Text);//dethunter12 7/9/2018 edit
                AllLists.tpet_MenuData[num].speed1 = Convert.ToInt32(tbSpeed1_1.Text);//dethunter12 7/9/2018 edit
                //Ani 2
                AllLists.tpet_MenuData[num].smcFileName2 = Convert.ToString(tbSmc1_2.Text);//dethunter12 7/9/2018 edit
                AllLists.tpet_MenuData[num].aniIdle2 = Convert.ToString(tbAniIdle1_2.Text);//dethunter12 7/9/2018 edit
                AllLists.tpet_MenuData[num].aniIdle2_2 = Convert.ToString(tbAniIdle2_2.Text);//dethunter12 7/9/2018 edit
                AllLists.tpet_MenuData[num].aniAttack2 = Convert.ToString(tbAniAttack1_2.Text);//dethunter12 7/9/2018 edit
                AllLists.tpet_MenuData[num].aniAttack2_2 = Convert.ToString(tbAniAttack2_2.Text);//dethunter12 7/9/2018 edit
                AllLists.tpet_MenuData[num].aniDamage1_2 = Convert.ToString(tbAniDamage1_2.Text);//dethunter12 7/9/2018 edit
                AllLists.tpet_MenuData[num].aniDie1_2 = Convert.ToString(tbAniDie1_2.Text);//dethunter12 7/9/2018 edit
                AllLists.tpet_MenuData[num].aniWalk1_2 = Convert.ToString(tbAniWalk1_2.Text);//dethunter12 7/9/2018 edit
                AllLists.tpet_MenuData[num].aniRun1_2 = Convert.ToString(tbAniRun1_2.Text);//dethunter12 7/9/2018 edit
                AllLists.tpet_MenuData[num].aniLevelup1_2 = Convert.ToString(tbLevelUp1_2.Text);//dethunter12 7/9/2018 edit
                AllLists.tpet_MenuData[num].mount1_2 = Convert.ToInt32(tbMount1_2.Text);//dethunter12 7/9/2018 edit
                AllLists.tpet_MenuData[num].summonSkill1_2 = Convert.ToInt32(tbSkillSummon1_2.Text);
                AllLists.tpet_MenuData[num].speed1_2 = Convert.ToInt32(tbSpeed1_2.Text);
                //Status
                AllLists.tpet_MenuData[num].Menu = AllLists.tpet_MenuData[num].index + " - " + AllLists.tpet_MenuData[num].name;
                listBox1.Items[listBox1.SelectedIndex] = AllLists.tpet_MenuData[num].Menu;
                listBox1.SelectedItem = AllLists.tpet_MenuData[num].Menu;
                doespetexist = false; //dethunter12 7/10/2018 default value false
                IsPetInDB(); //dethunter12 7/9/2018
                if (doespetexist == true)
                {

                    mySQL.UpdateQuery("UPDATE t_attack_pet SET a_index = '" + AllLists.tpet_MenuData[num].index + "'," + "a_enable ='" + AllLists.tpet_MenuData[num].enable + "'," + "a_type ='" + AllLists.tpet_MenuData[num].type + "'," + "a_name ='" + AllLists.tpet_MenuData[num].name + "'," + "a_str = '" + AllLists.tpet_MenuData[num].str + "'," + "a_con ='" + AllLists.tpet_MenuData[num].con + "',a_dex = '" + AllLists.tpet_MenuData[num].dex + "',a_int = '" + AllLists.tpet_MenuData[num].intel + "', a_item_idx = '" + AllLists.tpet_MenuData[num].itemidx + "',a_maxFaith = '" + AllLists.tpet_MenuData[num].maxFaith + "',a_maxStm = '" + AllLists.tpet_MenuData[num].maxStm + "',a_maxHP = '" + AllLists.tpet_MenuData[num].maxHP + "',a_maxMP = '" + AllLists.tpet_MenuData[num].maxMP + "',a_recoverHP = '" + AllLists.tpet_MenuData[num].recoverHP + "',a_recoverMP = '" + AllLists.tpet_MenuData[num].recoverMP + "',a_delay = '" + AllLists.tpet_MenuData[num].delay + "',a_AISlot = '" + AllLists.tpet_MenuData[num].AISlot + "',a_after_dead = '" + AllLists.tpet_MenuData[num].afterDead + "',a_attack = '" + AllLists.tpet_MenuData[num].attack + "',a_defence = '" + AllLists.tpet_MenuData[num].defense + "',a_Mattack = '" + AllLists.tpet_MenuData[num].mAttack + "',a_Mdefence = '" + AllLists.tpet_MenuData[num].mDefense + "',a_hitpoint = '" + AllLists.tpet_MenuData[num].hitPoint + "',a_avoidpoint = '" + AllLists.tpet_MenuData[num].avoidPoint + "',a_Mavoidpoint = '" + AllLists.tpet_MenuData[num].mavoidPoint + "',a_attackSpeed = '" + AllLists.tpet_MenuData[num].attackSpeed + "',a_deadly = '" + AllLists.tpet_MenuData[num].Deadly + "',a_critical = '" + AllLists.tpet_MenuData[num].Critical + "',a_awful = '" + AllLists.tpet_MenuData[num].awful + "',a_strong = '" + AllLists.tpet_MenuData[num].strong + "',a_normal = '" + AllLists.tpet_MenuData[num].normal + "',a_week = '" + AllLists.tpet_MenuData[num].weak + "',a_bagic_skill1 = '" + AllLists.tpet_MenuData[num].bagicSkill1 + "',a_bagic_skill2 = '" + AllLists.tpet_MenuData[num].bagicSkill2 + "',a_flag = '" + AllLists.tpet_MenuData[num].flag + "',a_trans_type = '" + AllLists.tpet_MenuData[num].transType + "',a_trans_start = '" + AllLists.tpet_MenuData[num].transStart + "',a_trans_end = '" + AllLists.tpet_MenuData[num].transEnd + "',a_smcFileName_1 = '" + AllLists.tpet_MenuData[num].smcFileName1.Replace("\\", "\\\\").Replace("'", "\\'") + "',a_ani_idle1_1 = '" + AllLists.tpet_MenuData[num].aniIdle1 + "',a_ani_idle2_1 = '" + AllLists.tpet_MenuData[num].aniIdle1_2 + "',a_ani_attack1_1 = '" + AllLists.tpet_MenuData[num].aniAttack1 + "',a_ani_attack2_1 = '" + AllLists.tpet_MenuData[num].aniAttack1_2 + "',a_ani_damage_1 = '" + AllLists.tpet_MenuData[num].aniDamage1 + "',a_ani_die_1 = '" + AllLists.tpet_MenuData[num].aniDie1 + "',a_ani_walk_1 = '" + AllLists.tpet_MenuData[num].aniWalk1 + "',a_ani_run_1 = '" + AllLists.tpet_MenuData[num].aniRun1 + "',a_ani_levelup_1 = '" + AllLists.tpet_MenuData[num].aniLevelup1 + "',a_mount_1 = '" + AllLists.tpet_MenuData[num].mount1 + "',a_summon_skill_1 = '" + AllLists.tpet_MenuData[num].summonSkill1 + "',a_speed_1 = '" + AllLists.tpet_MenuData[num].speed1 + "',a_smcFileName_2 = '" + AllLists.tpet_MenuData[num].smcFileName2.Replace("\\", "\\\\").Replace("'", "\\'") + "',a_ani_idle1_2 = '" + AllLists.tpet_MenuData[num].aniIdle2 + "',a_ani_idle2_2 = '" + AllLists.tpet_MenuData[num].aniIdle2_2 + "',a_ani_attack1_2 = '" + AllLists.tpet_MenuData[num].aniAttack2 + "',a_ani_attack2_2 = '" + AllLists.tpet_MenuData[num].aniAttack2_2 + "',a_ani_damage_2 = '" + AllLists.tpet_MenuData[num].aniDamage1_2 + "',a_ani_die_2 = '" + AllLists.tpet_MenuData[num].aniDie1_2 + "',a_ani_walk_2 = '" + AllLists.tpet_MenuData[num].aniWalk1_2 + "',a_ani_run_2 = '" + AllLists.tpet_MenuData[num].aniRun1_2 + "',a_ani_levelup_2 = '" + AllLists.tpet_MenuData[num].aniLevelup1_2 + "',a_mount_2 = '" + AllLists.tpet_MenuData[num].mount1_2 + "',a_summon_skill_2 = '" + AllLists.tpet_MenuData[num].summonSkill1_2 + "',a_speed_2 = '" + AllLists.tpet_MenuData[num].speed1_2 + "'WHERE a_index ='" + AllLists.tpet_MenuData[num].index + "';"); //dethunter12 7/9/2018 update query
                    Status.Text = "Saved Pet : " + AllLists.tpet_MenuData[num].Menu;
                    int num4 = (int)new CustomMessage("Updated Pet").ShowDialog();
                }
                else if (doespetexist == false)
                {
                     mySQL.UpdateQuery("INSERT INTO t_attack_pet ( a_index, a_enable, a_type, a_name, a_str, a_con, a_dex, a_int, a_item_idx, a_maxFaith, a_maxStm, a_maxHP, a_maxMP, a_recoverHP, a_recoverMP, a_delay, a_AISlot, a_after_dead, a_attack, a_defence, a_Mattack, a_Mdefence, a_hitpoint, a_avoidpoint, a_Mavoidpoint, a_attackSpeed, a_deadly , a_critical, a_awful , a_strong, a_normal , a_week, a_bagic_skill1 , a_bagic_skill2, a_flag, a_trans_type, a_trans_start, a_trans_end, a_smcFileName_1, a_ani_idle1_1 , a_ani_idle2_1, a_ani_attack1_1, a_ani_attack2_1, a_ani_damage_1, a_ani_die_1, a_ani_walk_1, a_ani_run_1, a_ani_levelup_1, a_mount_1, a_summon_skill_1, a_speed_1, a_smcFileName_2, a_ani_idle1_2, a_ani_idle2_2, a_ani_attack1_2, a_ani_attack2_2, a_ani_damage_2, a_ani_die_2, a_ani_walk_2, a_ani_run_2, a_ani_levelup_2, a_mount_2, a_summon_skill_2, a_speed_2) VALUES (" + AllLists.tpet_MenuData[num].index + "," + AllLists.tpet_MenuData[num].enable + "," + AllLists.tpet_MenuData[num].type + ",'" + AllLists.tpet_MenuData[num].name + "'," + AllLists.tpet_MenuData[num].str + "," + AllLists.tpet_MenuData[num].con + "," + AllLists.tpet_MenuData[num].dex + "," + AllLists.tpet_MenuData[num].intel + "," + AllLists.tpet_MenuData[num].itemidx + "," + AllLists.tpet_MenuData[num].maxFaith + "," + AllLists.tpet_MenuData[num].maxStm + "," + AllLists.tpet_MenuData[num].maxHP + "," + AllLists.tpet_MenuData[num].maxMP + "," + AllLists.tpet_MenuData[num].recoverHP + "," + AllLists.tpet_MenuData[num].recoverMP + "," + AllLists.tpet_MenuData[num].delay + "," + AllLists.tpet_MenuData[num].AISlot + "," + AllLists.tpet_MenuData[num].afterDead + "," + AllLists.tpet_MenuData[num].attack + "," + AllLists.tpet_MenuData[num].defense + "," + AllLists.tpet_MenuData[num].mAttack + "," + AllLists.tpet_MenuData[num].mDefense + "," + AllLists.tpet_MenuData[num].hitPoint + "," + AllLists.tpet_MenuData[num].avoidPoint + "," + AllLists.tpet_MenuData[num].mavoidPoint + "," + AllLists.tpet_MenuData[num].attackSpeed + "," + AllLists.tpet_MenuData[num].Deadly + "," + AllLists.tpet_MenuData[num].Critical + "," + AllLists.tpet_MenuData[num].awful + "," + AllLists.tpet_MenuData[num].strong + "," + AllLists.tpet_MenuData[num].normal + "," + AllLists.tpet_MenuData[num].weak + "," + AllLists.tpet_MenuData[num].bagicSkill1 + "," + AllLists.tpet_MenuData[num].bagicSkill2 + "," + AllLists.tpet_MenuData[num].flag + "," + AllLists.tpet_MenuData[num].transType + "," + AllLists.tpet_MenuData[num].transStart + "," + AllLists.tpet_MenuData[num].transEnd + ",'" + AllLists.tpet_MenuData[num].smcFileName1.Replace("\\", "\\\\").Replace("'", "\\'") + "','" + AllLists.tpet_MenuData[num].aniIdle1 + "','" + AllLists.tpet_MenuData[num].aniIdle1_2 + "','" + AllLists.tpet_MenuData[num].aniAttack1 + "','" + AllLists.tpet_MenuData[num].aniAttack1_2 + "','" + AllLists.tpet_MenuData[num].aniDamage1 + "','" + AllLists.tpet_MenuData[num].aniDie1 + "','" + AllLists.tpet_MenuData[num].aniWalk1 + "','" + AllLists.tpet_MenuData[num].aniRun1 + "','" + AllLists.tpet_MenuData[num].aniLevelup1 + "'," + AllLists.tpet_MenuData[num].mount1 + "," + AllLists.tpet_MenuData[num].summonSkill1 + "," + AllLists.tpet_MenuData[num].speed1 + ",'" + AllLists.tpet_MenuData[num].smcFileName2.Replace("\\", "\\\\").Replace("'", "\\'") + "','" + AllLists.tpet_MenuData[num].aniIdle2 + "','" + AllLists.tpet_MenuData[num].aniIdle2_2 + "','" + AllLists.tpet_MenuData[num].aniAttack2 + "','" + AllLists.tpet_MenuData[num].aniAttack2_2 + "','" + AllLists.tpet_MenuData[num].aniDamage1_2 + "','" + AllLists.tpet_MenuData[num].aniDie1_2 + "','" + AllLists.tpet_MenuData[num].aniWalk1_2 + "','" + AllLists.tpet_MenuData[num].aniRun1_2 + "','" + AllLists.tpet_MenuData[num].aniLevelup1_2 + "'," + AllLists.tpet_MenuData[num].mount1_2 + "," + AllLists.tpet_MenuData[num].summonSkill1_2 + "," + AllLists.tpet_MenuData[num].speed1_2 +" );"); //dethunter12 7/9/2018 update query
                   // DatabaseUpdate.tattkpet_Update(AllLists.tpet_MenuData[num]);
                    Status.Text = "Inserted Pet : " + AllLists.tpet_MenuData[num].Menu;
                    int num4 = (int)new CustomMessage("Inserted Pet").ShowDialog();
                }
              
            }
        }

        private void tbType_TextChanged(object sender, EventArgs e)
        {
            this.comboBox1.Select();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SkillPicker skillPicker = new SkillPicker();
            if (skillPicker.ShowDialog() != DialogResult.OK)
                return;
            tbSkillSummon1_1.Text = Convert.ToString(skillPicker.SkillIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SkillPicker skillPicker2 = new SkillPicker();
            if (skillPicker2.ShowDialog() != DialogResult.OK)
                return;
            tbSkillSummon1_2.Text = Convert.ToString(skillPicker2.SkillIndex);
        }
        private void IsPetInDB() //dethunter12 7/9/2018
        {
            string Query = "select a_index FROM t_attack_pet WHERE a_index ='" + txtID.Text + "';";
            foreach (DataRow row in (InternalDataCollectionBase)mySQL.GetFromQuery(Query).Rows)
            {
                tbItemExist.Text = Convert.ToString(row["a_index"]);
                if (tbItemExist.Text != null || tbItemExist.Text != "")
                {
                    doespetexist = true;
                }
                else
                {
                    tbItemExist.Text = "";
                    doespetexist = false;
                }
            }
        }

        private void ResetTbBackGround()
        {
            //Basic
            txtID.BackColor = Color.White;
            txtName.BackColor = Color.White;
            comboBox1.BackColor = Color.White;
            flag.BackColor = Color.White;
            //Item Index
            tbItemIndex.BackColor = Color.White;
            //Pet Stats
            tbStrength.BackColor = Color.White;
            TbDexteriety.BackColor = Color.White;
            tbIntelligence.BackColor = Color.White;
            tbConstitution.BackColor = Color.White;
            tbmaxHP.BackColor = Color.White;
            tbmaxMP.BackColor = Color.White;
            tbmaxFaith.BackColor = Color.White;
            tbmaxStm.BackColor = Color.White;
            tbRecoveryHP.BackColor = Color.White;
            tbRecoveryMP.BackColor = Color.White;
            tbAiSlot.BackColor = Color.White;
            tbDelay.BackColor = Color.White;
            tbAfterDead.BackColor = Color.White;
            TbHitpoint.BackColor = Color.White;
            tbAvoid.BackColor = Color.White;
            tbMagicAvoid.BackColor = Color.White;
            tbAttackSpeed.BackColor = Color.White;
            tbAttack.BackColor = Color.White;
            tbDefense.BackColor = Color.White;
            tbmAttack.BackColor = Color.White;
            tbmDefense.BackColor = Color.White;
            tbDeadly.BackColor = Color.White;
            tbWeak.BackColor = Color.White;
            tbFlag.BackColor = Color.White;
            tbCritical.BackColor = Color.White;
            tbStrong.BackColor = Color.White;
            tbBasicSkill1.BackColor = Color.White;
            tbBasicSkill2.BackColor = Color.White;
            tbAwful.BackColor = Color.White;
            tbNoraml.BackColor = Color.White;
            //Animation1
            tbAniIdle1_1.BackColor = Color.White;
            tbAniIdle2_1.BackColor = Color.White;
            tbAniAttack1_1.BackColor = Color.White;
            tbAniAttack2_1.BackColor = Color.White;
            tbAniDie1_1.BackColor = Color.White;
            tbAniWalk1_1.BackColor = Color.White;
            tbAniRun1_1.BackColor = Color.White;
            tbAniDamage1_1.BackColor = Color.White;
            tbLevelUp1_1.BackColor = Color.White;
            tbSkillSummon1_1.BackColor = Color.White;
            tbSpeed1_1.BackColor = Color.White;
            tbMount1_1.BackColor = Color.White;
            tbSmc1_1.BackColor = Color.White;
            //Animation2
            tbAniIdle1_2.BackColor = Color.White;
            tbAniIdle2_2.BackColor = Color.White;
            tbAniAttack1_2.BackColor = Color.White;
            tbAniAttack2_2.BackColor = Color.White;
            tbAniDie1_2.BackColor = Color.White;
            tbAniWalk1_2.BackColor = Color.White;
            tbAniRun1_2.BackColor = Color.White;
            tbAniDamage1_2.BackColor = Color.White;
            tbLevelUp1_2.BackColor = Color.White;
            tbSkillSummon1_2.BackColor = Color.White;
            tbSpeed1_2.BackColor = Color.White;
            tbMount1_2.BackColor = Color.White;
            tbSmc1_2.BackColor = Color.White;

            //Trans
            tbTransType.BackColor = Color.White;
            tbTransStart.BackColor = Color.White;
            tbTransEnd.BackColor = Color.White;

            //Pet Evolution Basic
            tb_ev_ID.BackColor = Color.White;
            tb_to_ev_id.BackColor = Color.White;
            tb_ev_Level.BackColor = Color.White;
            tb_ev_ID.BackColor = Color.White;
            tb_ev_Stemina.BackColor = Color.White;
            tb_ev_Faith.BackColor = Color.White;
            tb_ev_stat1.BackColor = Color.White;
            tb_ev_stat2.BackColor = Color.White;
            tb_ev_order.BackColor = Color.White;
            //Pet Experience Basic
            tb_exp_a_pet_index.BackColor = Color.White;
            tb_exp_a_max_acc_param1.BackColor = Color.White;
            tb_exp_a_max_acc_param2.BackColor = Color.White;
            tb_exp_a_acc_rate_param1.BackColor = Color.White;
            tb_exp_a_acc_rate_param2.BackColor = Color.White;
        }

        private void IconSkill()
        {
            string Query = "select a_index, a_client_icon_texid, a_client_icon_row, a_client_icon_col FROM t_skill WHERE a_index ='" + tbSkillSummon1_1.Text + "';";
            foreach (DataRow row in (InternalDataCollectionBase)mySQL.GetFromQuery(Query).Rows)
            {
                t_tex1.Text = Convert.ToString(row["a_client_icon_texid"]);
                t_row1.Text = Convert.ToString(row["a_client_icon_row"]);
                t_col1.Text = Convert.ToString(row["a_client_icon_col"]);
            }
        }

        private void IconSkill2()
        {
            string Query = "select a_index, a_client_icon_texid, a_client_icon_row, a_client_icon_col FROM t_skill WHERE a_index ='" + tbSkillSummon1_2.Text + "';";
            foreach (DataRow row in (InternalDataCollectionBase)mySQL.GetFromQuery(Query).Rows)
            {
                t_tex2.Text = Convert.ToString(row["a_client_icon_texid"]);
                t_row2.Text = Convert.ToString(row["a_client_icon_row"]);
                t_col2.Text = Convert.ToString(row["a_client_icon_col"]);
            }
        }

        private void tbSkillSummon1_1_TextChanged(object sender, EventArgs e)
        {
            /*
            if (tbSkillSummon1_1.Text != "0")
            {
                t_col1.Text = null;
                t_row1.Text = null;
                t_tex1.Text = null;
            }
            IconSkill();
            */
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Select : *.smc";
            //openFile.InitialDirectory = "";
            openFile.InitialDirectory = _ClientPath;
            //string filter = "/Data";
            openFile.Filter = "SMC File|*.smc|All|*.*";
            if (openFile.ShowDialog() != DialogResult.Cancel)
            {
                openFile.FileName = openFile.FileName.Substring(openFile.FileName.IndexOf("Data")); // to remove everything before Data from a string
                tbSmc1_1.Text = openFile.FileName; // to load the information to textbox
                tbSmc1_1.BackColor = Color.PaleTurquoise; //dethunter12 7/14/2018 
            }                
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Select : *.smc";
            //openFile.InitialDirectory = "";
            openFile.InitialDirectory = _ClientPath;
            openFile.Filter = "SMC File|*.smc|All|*.*";
            if (openFile.ShowDialog() != DialogResult.Cancel)
            {
                openFile.FileName = openFile.FileName.Substring(openFile.FileName.IndexOf("Data")); //to remove everything before Data from a string
                tbSmc1_2.Text = openFile.FileName; // to load the information to textbox
                tbSmc1_2.BackColor = Color.PaleTurquoise;
            } 
        }

        private void tbSkillSummon1_2_TextChanged(object sender, EventArgs e)
        {
            /*
            IconSkill2();
            */
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.BackColor = Color.LimeGreen;
                checkBox1.Text = "Enable";
                tbEnable.Text = "1";
            }
            else if (cbMount1.Checked == false)
            {
                checkBox1.BackColor = Color.Red;
                tbEnable.Text = "0";
                checkBox1.Text = "disable";
            }
        }

        private void cbMount1_CheckedChanged(object sender, EventArgs e) //dethunter12 7/2018
        {
            if (cbMount1.Checked == true)
            {
                cbMount1.BackColor = Color.LimeGreen;
                cbMount1.Text = "Mount";
                tbMount1_1.Text = "1";
            }
            else if (cbMount1.Checked == false)
            {
                cbMount1.BackColor = Color.Red;
                tbMount1_1.Text = "0";
                cbMount1.Text = "NotMount";
            }
        }

        private void cbMount2_CheckedChanged(object sender, EventArgs e) //dethunter12 7/2018
        {
            if (cbMount2.Checked == true)
            {
                cbMount2.BackColor = Color.LimeGreen;
                cbMount2.Text = "Mount";
                tbMount1_2.Text = "1";
            }
            else if (cbMount2.Checked == false)
            {
                cbMount2.BackColor = Color.Red;
                tbMount1_2.Text = "0";
                cbMount2.Text = "NotMount";
            }
        }
        public int DEF_APET_NAME_LENGTH = 20;
        public int DEF_SMCFILE_LENGTH = 64;
        public int DEF_APET_ANI_LENGTH = 32;
        public Encoding _enc;

        private void bigpetlodToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (this.listBox1.Items.Count != 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "bigpet.lod|bigpet*.lod|data|*.data|All|*.*";
                saveFileDialog.Title = "Save bigpet.lod";
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "")
                {
                    try
                    {
                        FileStream output = new FileStream(saveFileDialog.FileName, FileMode.Create);
                        BinaryWriter binaryWriter = new BinaryWriter(output);
                        binaryWriter.Write(AllLists.tpet_MenuData.Count);
                        for (int i = 0; i <= AllLists.tpet_MenuData.Count<t_attkpet>() - 1; i++)
                        {
                            binaryWriter.Write(AllLists.tpet_MenuData[i].index);
                            string name = AllLists.tpet_MenuData[i].name;
                            byte[] buffname = new byte[20];
                            int length1 = name.Length > 20 ? 20 : name.Length;
                            Encoding.UTF8.GetBytes(name.Substring(0, length1)).CopyTo((Array)buffname, 0);
                            binaryWriter.Write(buffname);
                            //UpTest
                            binaryWriter.Write(AllLists.tpet_MenuData[i].type);
                            binaryWriter.Write(AllLists.tpet_MenuData[i].itemidx);
                            binaryWriter.Write(AllLists.tpet_MenuData[i].AISlot);
                            binaryWriter.Write(AllLists.tpet_MenuData[i].mount1);
                            binaryWriter.Write(AllLists.tpet_MenuData[i].mount1_2);
                            binaryWriter.Write(AllLists.tpet_MenuData[i].summonSkill1);
                            binaryWriter.Write(AllLists.tpet_MenuData[i].summonSkill1_2);
                            binaryWriter.Write(AllLists.tpet_MenuData[i].flag);
                            //SMC                            
                            string smc1 = AllLists.tpet_MenuData[i].smcFileName1;
                            byte[] buffsmc1 = new byte[64];
                            int lengthsmc = smc1.Length > 64 ? 64 : smc1.Length;
                            Encoding.UTF8.GetBytes(smc1.Substring(0, lengthsmc)).CopyTo((Array)buffsmc1, 0);
                            binaryWriter.Write(buffsmc1);
                            //smc 2
                            string smc2 = AllLists.tpet_MenuData[i].smcFileName2;
                            byte[] buffsmc2 = new byte[64];
                            int lengthsmc2 = smc2.Length > 64 ? 64 : smc2.Length;
                            Encoding.UTF8.GetBytes(smc2.Substring(0, lengthsmc2)).CopyTo((Array)buffsmc2, 0);
                            binaryWriter.Write(buffsmc2);

                            //aniIdle1
                            string aniIdle1 = AllLists.tpet_MenuData[i].aniIdle1;
                            byte[] buffaniIdle1 = new byte[32];
                            int lengthaniIdle1 = aniIdle1.Length > 32 ? 32 : aniIdle1.Length;
                            Encoding.UTF8.GetBytes(aniIdle1.Substring(0, lengthaniIdle1)).CopyTo((Array)buffaniIdle1, 0);
                            binaryWriter.Write(buffaniIdle1);
                            //aniIdle2
                            string aniIdle2 = AllLists.tpet_MenuData[i].aniIdle2;
                            byte[] buffaniIdle2 = new byte[32];
                            int lengthaniIdle2 = aniIdle2.Length > 32 ? 32 : aniIdle2.Length;
                            Encoding.UTF8.GetBytes(aniIdle2.Substring(0, lengthaniIdle2)).CopyTo((Array)buffaniIdle2, 0);
                            binaryWriter.Write(buffaniIdle2);
                            //aniIdle1_2
                            string aniIdle1_2 = AllLists.tpet_MenuData[i].aniIdle1_2;
                            byte[] buffaniIdle1_2 = new byte[32];
                            int lengthaniIdle1_2 = aniIdle1_2.Length > 32 ? 32 : aniIdle1_2.Length;
                            Encoding.UTF8.GetBytes(aniIdle1_2.Substring(0, lengthaniIdle1_2)).CopyTo((Array)buffaniIdle1_2, 0);
                            binaryWriter.Write(buffaniIdle1_2);                            
                            //aniIdle2_2
                            string aniIdle2_2 = AllLists.tpet_MenuData[i].aniIdle2_2;
                            byte[] buffaniIdle2_2 = new byte[32];
                            int lengthaniIdle2_2 = aniIdle2_2.Length > 32 ? 32 : aniIdle2_2.Length;
                            Encoding.UTF8.GetBytes(aniIdle2_2.Substring(0, lengthaniIdle2_2)).CopyTo((Array)buffaniIdle2_2, 0);
                            binaryWriter.Write(buffaniIdle2_2);
                            //aniAttack1
                            string aniAttack1 = AllLists.tpet_MenuData[i].aniAttack1;
                            byte[] buffaniAttack1 = new byte[32];
                            int lengthaniAttack1 = aniAttack1.Length > 32 ? 32 : aniAttack1.Length;
                            Encoding.UTF8.GetBytes(aniAttack1.Substring(0, lengthaniAttack1)).CopyTo((Array)buffaniAttack1, 0);
                            binaryWriter.Write(buffaniAttack1);
                            //aniAttack2
                            string aniAttack2 = AllLists.tpet_MenuData[i].aniAttack2;
                            byte[] buffaniAttack2 = new byte[32];
                            int lengthaniAttack2 = aniAttack2.Length > 32 ? 32 : aniAttack2.Length;
                            Encoding.UTF8.GetBytes(aniAttack2.Substring(0, lengthaniAttack2)).CopyTo((Array)buffaniAttack2, 0);
                            binaryWriter.Write(buffaniAttack2);
                            //aniAttack1_2
                            string aniAttack1_2 = AllLists.tpet_MenuData[i].aniAttack1_2;
                            byte[] buffaniAttack1_2 = new byte[32];
                            int lengthaniAttack1_2 = aniAttack1_2.Length > 32 ? 32 : aniAttack1_2.Length;
                            Encoding.UTF8.GetBytes(aniAttack1_2.Substring(0, lengthaniAttack1_2)).CopyTo((Array)buffaniAttack1_2, 0);
                            binaryWriter.Write(buffaniAttack1_2);                            
                            //aniAttack2_2
                            string aniAttack2_2 = AllLists.tpet_MenuData[i].aniAttack2_2;
                            byte[] buffaniAttack2_2 = new byte[32];
                            int lengthaniAttack2_2 = aniAttack2_2.Length > 32 ? 32 : aniAttack2_2.Length;
                            Encoding.UTF8.GetBytes(aniAttack2_2.Substring(0, lengthaniAttack2_2)).CopyTo((Array)buffaniAttack2_2, 0);
                            binaryWriter.Write(buffaniAttack2_2);
                            //aniDamage1
                            string aniDamage1 = AllLists.tpet_MenuData[i].aniDamage1;
                            byte[] buffaniDamage1 = new byte[32];
                            int lengthaniDamage1 = aniDamage1.Length > 32 ? 32 : aniDamage1.Length;
                            Encoding.UTF8.GetBytes(aniDamage1.Substring(0, lengthaniDamage1)).CopyTo((Array)buffaniDamage1, 0);
                            binaryWriter.Write(buffaniDamage1);
                            //aniDamage1_2
                            string aniDamage1_2 = AllLists.tpet_MenuData[i].aniDamage1_2;
                            byte[] buffaniDamage1_2 = new byte[32];
                            int lengthaniDamage1_2 = aniDamage1_2.Length > 32 ? 32 : aniDamage1_2.Length;
                            Encoding.UTF8.GetBytes(aniDamage1_2.Substring(0, lengthaniDamage1_2)).CopyTo((Array)buffaniDamage1_2, 0);
                            binaryWriter.Write(buffaniDamage1_2);
                            //aniDie1
                            string aniDie1 = AllLists.tpet_MenuData[i].aniDie1;
                            byte[] buffaniDie1 = new byte[32];
                            int lengthaniDie1 = aniDie1.Length > 32 ? 32 : aniDie1.Length;
                            Encoding.UTF8.GetBytes(aniDie1.Substring(0, lengthaniDie1)).CopyTo((Array)buffaniDie1, 0);
                            binaryWriter.Write(buffaniDie1);
                            //aniDie1_2
                            string aniDie1_2 = AllLists.tpet_MenuData[i].aniDie1_2;
                            byte[] buffaniDie1_2 = new byte[32];
                            int lengthaniDie1_2 = aniDie1_2.Length > 32 ? 32 : aniDie1_2.Length;
                            Encoding.UTF8.GetBytes(aniDie1_2.Substring(0, lengthaniDie1_2)).CopyTo((Array)buffaniDie1_2, 0);
                            binaryWriter.Write(buffaniDie1_2);
                            //aniWalk1
                            string aniWalk1 = AllLists.tpet_MenuData[i].aniWalk1;
                            byte[] buffaniWalk1 = new byte[32];
                            int lengthaniWalk1 = aniWalk1.Length > 32 ? 32 : aniWalk1.Length;
                            Encoding.UTF8.GetBytes(aniWalk1.Substring(0, lengthaniWalk1)).CopyTo((Array)buffaniWalk1, 0);
                            binaryWriter.Write(buffaniWalk1);
                            //aniWalk1_2
                            string aniWalk1_2 = AllLists.tpet_MenuData[i].aniWalk1_2;
                            byte[] buffaniWalk1_2 = new byte[32];
                            int lengthaniWalk1_2 = aniWalk1_2.Length > 32 ? 32 : aniWalk1_2.Length;
                            Encoding.UTF8.GetBytes(aniWalk1_2.Substring(0, lengthaniWalk1_2)).CopyTo((Array)buffaniWalk1_2, 0);
                            binaryWriter.Write(buffaniWalk1_2);
                            //aniRun1
                            string aniRun1 = AllLists.tpet_MenuData[i].aniRun1;
                            byte[] buffaniRun1 = new byte[32];
                            int lengthaniRun1 = aniRun1.Length > 32 ? 32 : aniRun1.Length;
                            Encoding.UTF8.GetBytes(aniRun1.Substring(0, lengthaniRun1)).CopyTo((Array)buffaniRun1, 0);
                            binaryWriter.Write(buffaniRun1);
                            //aniRun1_2
                            string aniRun1_2 = AllLists.tpet_MenuData[i].aniRun1_2;
                            byte[] buffaniRun1_2 = new byte[32];
                            int lengthaniRun1_2 = aniRun1_2.Length > 32 ? 32 : aniRun1_2.Length;
                            Encoding.UTF8.GetBytes(aniRun1_2.Substring(0, lengthaniRun1_2)).CopyTo((Array)buffaniRun1_2, 0);
                            binaryWriter.Write(buffaniRun1_2);
                            //aniLevelup1
                            string aniLevelup1 = AllLists.tpet_MenuData[i].aniLevelup1;
                            byte[] buffaniLevelup1 = new byte[32];
                            int lengthaniLevelup1 = aniLevelup1.Length > 32 ? 32 : aniLevelup1.Length;
                            Encoding.UTF8.GetBytes(aniLevelup1.Substring(0, lengthaniLevelup1)).CopyTo((Array)buffaniLevelup1, 0);
                            binaryWriter.Write(buffaniLevelup1);
                            //aniLevelup1_2
                            string aniLevelup1_2 = AllLists.tpet_MenuData[i].aniLevelup1_2;
                            byte[] buffaniLevelup1_2 = new byte[32];
                            int lengthaniLevelup1_2 = aniLevelup1_2.Length > 32 ? 32 : aniLevelup1_2.Length;
                            Encoding.UTF8.GetBytes(aniLevelup1_2.Substring(0, lengthaniLevelup1_2)).CopyTo((Array)buffaniLevelup1_2, 0);
                            binaryWriter.Write(buffaniLevelup1_2);

                               for (int num = 0; num <= AllLists.tpet_ev_MenuData.Count<BigpetEv>() - 1; num++)
                                {
                                    if (AllLists.tpet_MenuData[i].index == AllLists.tpet_ev_MenuData[num].APetIdx)
                                    {
                                        binaryWriter.Write(AllLists.tpet_ev_MenuData[num].Level);
                                        binaryWriter.Write(AllLists.tpet_ev_MenuData[num].Stemina);
                                        binaryWriter.Write(AllLists.tpet_ev_MenuData[num].Faith);
                                        binaryWriter.Write(AllLists.tpet_ev_MenuData[num].a_ev_pet_index); //dethunter12 pet id is off by 1
                                    }
                                }
                           //byte[] buffer = new byte[48]; // needs moved 48 bytes down


                           // binaryWriter.Write(buffer);
                            
                            for (int num2 = 0; num2 <= AllLists.tpet_exp_MenuData.Count<BigpetExp>() - 1; num2++)// <-- Start Position Wrong Save
                            {
                                if (AllLists.tpet_MenuData[i].index == AllLists.tpet_exp_MenuData[num2].a_pet_index)
                                {
                                    binaryWriter.Write(AllLists.tpet_exp_MenuData[num2].a_max_acc_param1);
                                    binaryWriter.Write(AllLists.tpet_exp_MenuData[num2].a_max_acc_param2);
                                    binaryWriter.Write(AllLists.tpet_exp_MenuData[num2].a_acc_rate_param1);
                                    binaryWriter.Write(AllLists.tpet_exp_MenuData[num2].a_acc_rate_param2);
                                    
                                }
                               /* else
                                {
                                    int save = 0;
                                    binaryWriter.Write(save);
                                    binaryWriter.Write(save);
                                    binaryWriter.Write(save);
                                    binaryWriter.Write(save);
                                }*/
                            }//< --End Position Wrong Save

                        }
                        binaryWriter.Close(); //dethunter12 add 7/13/2018
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    
                }
            }

        } 

        private void tbStrength_KeyPress(object sender, KeyPressEventArgs e) //dethunter12 7/13/2018 modify 
        {
            tbStrength.BackColor = Color.PaleTurquoise;
        }

        private void TbDexteriety_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbDexteriety.BackColor = Color.PaleTurquoise;
        }

        private void tbIntelligence_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbIntelligence.BackColor = Color.PaleTurquoise;
        }

        private void tbConstitution_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbConstitution.BackColor = Color.PaleTurquoise;
        }

        private void tbmaxHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbmaxHP.BackColor = Color.PaleTurquoise;
        }

        private void tbmaxMP_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbmaxMP.BackColor = Color.PaleTurquoise;
        }

        private void tbmaxFaith_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbmaxFaith.BackColor = Color.PaleTurquoise;
        }

        private void tbmaxStm_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbmaxStm.BackColor = Color.PaleTurquoise;
        }

        private void tbRecoveryHP_KeyPress(object sender, KeyPressEventArgs e)
        {
           tbRecoveryHP.BackColor = Color.PaleTurquoise;
        }

        private void tbRecoveryMP_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbRecoveryMP.BackColor = Color.PaleTurquoise;
        }

        private void tbAiSlot_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbAiSlot.BackColor = Color.PaleTurquoise;
        }

        private void tbDelay_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbDelay.BackColor = Color.PaleTurquoise;
        }

        private void tbAfterDead_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbAfterDead.BackColor = Color.PaleTurquoise;
        }

        private void TbHitpoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            TbHitpoint.BackColor = Color.PaleTurquoise;
        }

        private void tbAvoid_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbAvoid.BackColor = Color.PaleTurquoise;
        }

        private void tbMagicAvoid_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbMagicAvoid.BackColor = Color.PaleTurquoise;
        }

        private void tbAttackSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbAttackSpeed.BackColor = Color.PaleTurquoise;
        }

        private void tbAttack_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbAttack.BackColor = Color.PaleTurquoise; 
        }

        private void tbDefense_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbDefense.BackColor = Color.PaleTurquoise;
        }

        private void tbmAttack_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbmAttack.BackColor = Color.PaleTurquoise;
        }

        private void tbmDefense_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbmDefense.BackColor = Color.PaleTurquoise;
        }

        private void tbDeadly_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbDeadly.BackColor = Color.PaleTurquoise;
        }

        private void tbWeak_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbWeak.BackColor = Color.PaleTurquoise;
        }

        private void tbFlag_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbFlag.BackColor = Color.PaleTurquoise;
        }

        private void tbCritical_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbCritical.BackColor = Color.PaleTurquoise;
        }

        private void tbStrong_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbStrong.BackColor = Color.PaleTurquoise;
        }

        private void tbBasicSkill1_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbBasicSkill1.BackColor = Color.PaleTurquoise;
        }

        private void tbBasicSkill2_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbBasicSkill2.BackColor = Color.PaleTurquoise;
        }

        private void tbAwful_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbAwful.BackColor = Color.PaleTurquoise;
        }

        private void tbNoraml_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbNoraml.BackColor = Color.PaleTurquoise;
        }

        private void tbItemIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbItemIndex.BackColor = Color.PaleTurquoise;
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtID.BackColor = Color.PaleTurquoise;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtName.BackColor = Color.PaleTurquoise;
        }

        private void tbAniIdle1_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbAniIdle1_1.BackColor = Color.PaleTurquoise;
        }

        private void tbAniIdle2_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbAniIdle2_1.BackColor = Color.PaleTurquoise;
        }

        private void tbAniAttack1_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbAniAttack1_1.BackColor = Color.PaleTurquoise;
        }

        private void tbAniAttack2_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbAniAttack2_1.BackColor = Color.PaleTurquoise;
        }

        private void tbAniDie1_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbAniDie1_1.BackColor = Color.PaleTurquoise;
        }

        private void tbAniWalk1_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbAniWalk1_1.BackColor = Color.PaleTurquoise;
        }

        private void tbAniRun1_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbAniRun1_1.BackColor = Color.PaleTurquoise;
        }

        private void tbAniDamage1_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbAniDamage1_1.BackColor = Color.PaleTurquoise;
        }

        private void tbLevelUp1_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbLevelUp1_1.BackColor = Color.PaleTurquoise;
        }

        private void tbSkillSummon1_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbSkillSummon1_1.BackColor = Color.PaleTurquoise;
        }

        private void tbSpeed1_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbSpeed1_1.BackColor = Color.PaleTurquoise;
        }

        private void tbSmc1_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbSmc1_1.BackColor = Color.PaleTurquoise;
        }

        private void tbMount1_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbMount1_1.BackColor = Color.PaleTurquoise;
        }

        private void tbAniIdle1_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbAniIdle1_2.BackColor = Color.PaleTurquoise;
        }

        private void tbAniIdle2_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbAniIdle2_2.BackColor = Color.PaleTurquoise;
        }

        private void tbAniAttack1_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbAniAttack1_2.BackColor = Color.PaleTurquoise;
        }

        private void tbAniAttack2_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbAniAttack2_2.BackColor = Color.PaleTurquoise;
        }

        private void tbAniDie1_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbAniDie1_2.BackColor = Color.PaleTurquoise;
        }

        private void tbAniWalk1_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbAniWalk1_2.BackColor = Color.PaleTurquoise;
        }

        private void tbAniRun1_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbAniRun1_2.BackColor = Color.PaleTurquoise;
        }

        private void tbAniDamage1_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbAniDamage1_2.BackColor = Color.PaleTurquoise;
        }

        private void tbLevelUp1_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbLevelUp1_2.BackColor = Color.PaleTurquoise;
        }

        private void tbSkillSummon1_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbSkillSummon1_2.BackColor = Color.PaleTurquoise;
        }

        private void tbSpeed1_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbSpeed1_2.BackColor = Color.PaleTurquoise;
        }

        private void tbSmc1_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbSmc1_2.BackColor = Color.PaleTurquoise;
        }

        private void tbTransType_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbTransType.BackColor = Color.PaleTurquoise;
        }

        private void tbTransStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbTransStart.BackColor = Color.PaleTurquoise;
        }

        private void tbTransEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbTransEnd.BackColor = Color.PaleTurquoise;
        }

        private void tb_ev_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_ev_ID.BackColor = Color.PaleTurquoise;
        }

        private void tb_to_ev_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_to_ev_id.BackColor = Color.PaleTurquoise;
        }

        private void tb_ev_Level_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_ev_Level.BackColor = Color.PaleTurquoise;
        }

        private void tb_ev_Stemina_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_ev_Stemina.BackColor = Color.PaleTurquoise;
        }

        private void tb_ev_Faith_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_ev_Faith.BackColor = Color.PaleTurquoise;
        }

        private void tb_ev_stat1_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_ev_stat1.BackColor = Color.PaleTurquoise;
        }

        private void tb_ev_stat2_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_ev_stat2.BackColor = Color.PaleTurquoise;
        }

        private void tb_ev_order_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_ev_order.BackColor = Color.PaleTurquoise;
        }

        private void tb_exp_a_pet_index_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_exp_a_pet_index.BackColor = Color.PaleTurquoise;
        }

        private void tb_exp_a_max_acc_param1_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_exp_a_max_acc_param1.BackColor = Color.PaleTurquoise;
        }

        private void tb_exp_a_max_acc_param2_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_exp_a_max_acc_param2.BackColor = Color.PaleTurquoise;
        }

        private void tb_exp_a_acc_rate_param1_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_exp_a_acc_rate_param1.BackColor = Color.PaleTurquoise;
        }

        private void tb_exp_a_acc_rate_param2_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_exp_a_acc_rate_param2.BackColor = Color.PaleTurquoise;
        }

        private void tb_exp_a_cooltime_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_exp_a_cooltime.BackColor = Color.PaleTurquoise;
        }

        private void tb_exp_a_cooltime_rate_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_exp_a_cooltime_rate.BackColor = Color.PaleTurquoise;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBox1.BackColor = Color.PaleTurquoise;
        }

        private void flag_KeyPress(object sender, KeyPressEventArgs e)
        {
            flag.BackColor = Color.PaleTurquoise;
        }

        private void flag_SelectionChangeCommitted(object sender, EventArgs e)
        {
            flag.BackColor = Color.PaleTurquoise;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox1.BackColor = Color.PaleTurquoise;
        }

        private void tbMount1_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbMount1_2.BackColor = Color.PaleTurquoise;
        }
        private string namee; //dethunter12 stringfrom lang modify
        public string LanguageExport() //dethunter12 add 7/5/2020
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
        private void usaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text1 = "apet";
            string text2 = "path_ship";
            string text3 = LanguageExport();
            Process.Start(new ProcessStartInfo()
            {
                FileName = "ExportLod.exe",
                Arguments = " -h " + Host + " -d " + Database + " -u " + User + " -p " + Password + " -k " + text2 + " -l " + text3 + " -t " + text1
            });
        }

   
    }
}



